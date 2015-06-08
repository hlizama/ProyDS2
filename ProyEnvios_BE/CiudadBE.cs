using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEnvios_BE
{
    public class CiudadBE
    {
        private string _idCiudad;
        public string IDCiudad
        {
            get { return _idCiudad; }
            set { _idCiudad = value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _kilometros;
        public int Kilometros
        {
            get { return _kilometros; }
            set { _kilometros = value; }
        }
    }
}
