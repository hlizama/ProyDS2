using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEnvios_BE
{
    public class ReporteIncidenciaBE
    {
        private string _idReporte;
        public string IdReporte
        {
            get { return _idReporte; }
            set { _idReporte = value; }
        }

        private string _idenvio;
        public string Idenvio
        {
            get { return _idenvio; }
            set { _idenvio = value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _notificado;
        public int Notificado
        {
            get { return _notificado; }
            set { _notificado = value; }
        }

        private int _retraso;
        public int Retraso
        {
            get { return _retraso; }
            set { _retraso = value; }
        }

        private string _descrip;
        public string Descrip
        {
            get { return _descrip; }
            set { _descrip = value; }
        }

        private System.DateTime _fecha;
        public System.DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
    }
}
