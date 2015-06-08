using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEnvios_BE
{
    public class DestinoBE
    {
        private string _iddestino;
        public string Iddestino
        {
            get { return _iddestino; }
            set { _iddestino = value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _idciudad;
        public string Idciudad
        {
            get { return _idciudad; }
            set { _idciudad = value; }
        }

        private string _direccion;
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private string _distrito;
        public string Distrito
        {
            get { return _distrito; }
            set { _distrito = value; }
        }
    }
}
