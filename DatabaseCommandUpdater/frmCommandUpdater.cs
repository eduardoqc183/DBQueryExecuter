using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using LoadingIndicator.WinForms;

namespace DatabaseCommandUpdater
{
    public partial class frmCommandUpdater : Form
    {
        private LongOperation _longOperation;
        private ConexionData _conexionData;
        private bool _cancelar = false;

        public TipoMotor TipoMotor => comboBox1.SelectedIndex == 0 ? TipoMotor.Mssql : TipoMotor.Pgsql;

        private List<DbInfo> _modeldbs;

        public List<DbInfo> ModelDbs
        {
            get => _modeldbs;
            set
            {
                _modeldbs = value;
                bsDbs.DataSource = value;
                bsDbs.ResetBindings(true);
            }
        }


        public ConexionData ConexionData
        {
            get => _conexionData;
            set
            {
                _conexionData = value;
                bsConexion.DataSource = value;
                bsConexion.ResetBindings(true);
            }
        }

        public frmCommandUpdater()
        {
            InitializeComponent();
            _longOperation = new LongOperation(panel1);
            ConexionData = new ConexionData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            button1_Click(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var control = new ucCommandFrame();

                var tile = new UltraTile("Comando #" + (ucTiles.Tiles.Count + 1))
                {
                    Control = control,
                };

                control.Tile = tile;
                control.CerrarEvent += () =>
                {
                    ucTiles.Tiles.Remove(control.Tile);
                };

                ucTiles.Tiles.Add(tile);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                using (_longOperation.Start())
                {
                    ModelDbs = await ConexionData.ObtenerDatabases(TipoMotor);
                    panelAcciones.Enabled = ModelDbs.Any();
                    panel1.Enabled = !ModelDbs.Any();
                    btnAgregarComando.Enabled = btnExecute.Enabled = ModelDbs.Any();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                _longOperation = new LongOperation(panel2);
                ucTiles.Enabled = false;
                using (_longOperation.Start())
                {
                    var g = new GestorBL(TipoMotor);
                    ultraGrid1.DisplayLayout.Bands[0].Columns["Seleccionado"].Hidden = true;
                    ultraGrid1.DisplayLayout.Bands[0].Columns["IconoEstado"].Hidden = false;

                    foreach (var modelDb in ModelDbs)
                    {
                        if (modelDb.Seleccionado)
                            modelDb.Estado = EstadoDB.EnPausa;
                    }

                    btnAgregarComando.Enabled = false;
                    btnExecute.Enabled = false;
                    btnCancelar.Enabled = true;
                    foreach (var dbInfo in ModelDbs.Where(w => w.Seleccionado))
                    {
                        if (!_cancelar)
                        {
                            try
                            {
                                dbInfo.Estado = EstadoDB.Ejecutando;
                                await g.CompletarComandos(ConexionData, dbInfo.DbName, ObtenerComandos());
                                dbInfo.Estado = EstadoDB.Terminado;
                            }
                            catch (Exception exception)
                            {
                                dbInfo.Estado = EstadoDB.Error;
                                dbInfo.Error = exception.Message + "\n" + exception.InnerException?.Message;
                                ultraGrid1.Rows.Refresh(RefreshRow.FireInitializeRow);
                            }
                        }
                      
                    }

                    ultraGrid1.Rows.Refresh(RefreshRow.ReloadData);

                    if (!_cancelar)
                    {
                        MessageBox.Show(@"Proceso terminado", @"Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(@"Proceso cancelado", @"Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            finally
            {
                ucTiles.Enabled = true;
                btnAgregarComando.Enabled = true;
                btnExecute.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        private List<string> ObtenerComandos()
        {
            var cmds = new List<string>();
            foreach (UltraTile tile in ucTiles.Tiles)
            {
                var ctrl = (ucCommandFrame) tile.Control;
                cmds.Add(ctrl.QueryCommand);
            }

            return cmds;
        }

        private void ultraGrid1_InitializeRow(object sender, Infragistics.Win.UltraWinGrid.InitializeRowEventArgs e)
        {
            if (e.Row.IsFilterRow) return;
            var item = (DbInfo)e.Row.ListObject;
            e.Row.ToolTipText = item.Error;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _cancelar = true;
        }
    }
}
