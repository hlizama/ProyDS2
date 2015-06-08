using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEnvios_BE
{
    public class TipoServicioBE
    {
        private string _idtiposervicio;
        public string IDtiposervicio
        {
            get { return _idtiposervicio; }
            set { _idtiposervicio = value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _dias;
        public int Dias
        {
            get { return _dias; }
            set { _dias = value; }
        }

        private Single _precio;
        public Single Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
    }
}
