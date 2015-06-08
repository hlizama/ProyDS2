using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEnvios_BE
{
    public class DestinatarioBE
    {
        private string _iddestinatario;
        public string Iddestinatario
        {
            get { return _iddestinatario; }
            set { _iddestinatario = value; }
        }

        private string _razon_social;
        public string Razon_Social
        {
            get { return _razon_social; }
            set { _razon_social = value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido_pat;
        public string Apellido_Pat
        {
            get { return _apellido_pat; }
            set { _apellido_pat = value; }
        }

        private string _apellido_mat;
        public string Apellido_Mat
        {
            get { return _apellido_mat; }
            set { _apellido_mat = value; }
        }

        private string _dni;
        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private string _direccion;
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private string _telefono;
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
    }
}
