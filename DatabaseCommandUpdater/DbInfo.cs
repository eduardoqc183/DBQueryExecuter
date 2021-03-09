using System;
using System.Drawing;

namespace DatabaseCommandUpdater
{
    public enum EstadoDB
    {
        Ejecutando,
        Ignorado,
        Error,
        Terminado,
        EnPausa
    }

    public class DbInfo
    {
        public string DbName { get; set; }
        public bool Seleccionado { get; set; }

        public EstadoDB Estado { get; set; } = EstadoDB.Ignorado;
        public string EstadoInfo => Estado.ToString();

        public Image IconoEstado
        {
            get
            {
                switch (Estado)
                {
                    case EstadoDB.Ejecutando: return Properties.Resources.dark_loader;
                    case EstadoDB.Ignorado: return null;
                    case EstadoDB.Error: return Properties.Resources.stop_red;
                    case EstadoDB.Terminado: return Properties.Resources.stop_green;
                    case EstadoDB.EnPausa: return Properties.Resources.control_pause;
                    default: return null;
                }
            }
        }
        public string Error { get; set; }
    }
}