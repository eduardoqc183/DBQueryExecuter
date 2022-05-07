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
        private bool _isrunning = false;
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
            button1_Click(this, EventArgs.Empty);

            comboBox1.SelectedIndex = Properties.Settings.Default.indextype;
            ConexionData.ServerName = Properties.Settings.Default.server;
            ConexionData.User = Properties.Settings.Default.user;
            ConexionData.Password = Properties.Settings.Default.password;
            ConexionData.Port = Properties.Settings.Default.puerto;
            bsConexion.ResetBindings(true);
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

                int port;
                Properties.Settings.Default.indextype = comboBox1.SelectedIndex;
                Properties.Settings.Default.server = textBox1.Text;
                Properties.Settings.Default.user = textBox2.Text;
                Properties.Settings.Default.password = textBox3.Text;
                Properties.Settings.Default.puerto = int.TryParse(textBox4.Text, out port) ? port : 0;
                Properties.Settings.Default.Save();
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
                    _isrunning = true;

                    foreach (var modelDb in ModelDbs)
                    {
                        if (modelDb.Seleccionado)
                            modelDb.Estado = EstadoDB.EnPausa;
                    }

                    progressBar1.Value = 0;

                    btnAgregarComando.Enabled = false;
                    btnExecute.Enabled = false;
                    btnCancelar.Enabled = true;
                    checkBox1.Visible = false;
                    var cmds = ObtenerComandos();
                    int c = 0;
                    var seleccionados = ModelDbs.Where(w => w.Seleccionado).ToList();
                    if (seleccionados.Any())
                    {
                        foreach (var dbInfo in seleccionados)
                        {
                            if (!_cancelar)
                            {
                                try
                                {
                                    var percent = (c * 100) / seleccionados.Count;
                                    if (percent != progressBar1.Value)
                                    {
                                        progressBar1.Value = percent;
                                        progressBar1.Refresh();
                                    }
                                    dbInfo.Estado = EstadoDB.Ejecutando;
                                    await g.CompletarComandos(ConexionData, dbInfo.DbName, cmds);
                                    dbInfo.Estado = EstadoDB.Terminado;
                                }
                                catch (Exception exception)
                                {
                                    dbInfo.Estado = EstadoDB.Error;
                                    dbInfo.Error = exception.Message + "\n" + exception.InnerException?.Message;
                                    ultraGrid1.Rows.Refresh(RefreshRow.FireInitializeRow);
                                }
                                finally
                                {
                                    c++;
                                    ultraGrid1.Rows.Refresh(RefreshRow.ReloadData);
                                }
                            }

                        }
                    }


                    if (!_cancelar)
                    {
                        progressBar1.Value = 100;
                        progressBar1.Refresh();
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
                MessageBox.Show(exception.Message, @"Error en el proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ucTiles.Enabled = true;
                btnAgregarComando.Enabled = true;
                btnExecute.Enabled = true;
                btnCancelar.Enabled = false;
                _isrunning = false;
            }
        }

        private List<string> ObtenerComandos()
        {
            var cmds = new List<string>();
            foreach (UltraTile tile in ucTiles.Tiles)
            {
                var ctrl = (ucCommandFrame)tile.Control;
                var ccs = ctrl.QueryCommand.Split(';');
                ccs = ccs.Where(w => !string.IsNullOrWhiteSpace(w)).ToArray();
                cmds.AddRange(ccs);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var row in ultraGrid1.Rows)
            {
                if (row.IsFilterRow) continue;
                if (row.IsFilteredOut) continue;

                var item = (DbInfo)row.ListObject;
                item.Seleccionado = checkBox1.Checked;
            }

            ultraGrid1.Rows.Refresh(RefreshRow.ReloadData);
        }

        private void frmCommandUpdater_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isrunning)
            {
                e.Cancel = true;
            }
        }
    }
}
