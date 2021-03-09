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

namespace DatabaseCommandUpdater
{
    public partial class ucCommandFrame : UserControl
    {
        public delegate void Cerrar();

        public event Cerrar CerrarEvent;
        public UltraTile Tile { get; set; }

        public string QueryCommand => txtQuery.Text.Trim();

        public ucCommandFrame()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            OnCerrarEvent();
        }

        protected virtual void OnCerrarEvent()
        {
            CerrarEvent?.Invoke();
        }

        private void ucCommandFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
