using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEnvios_BE
{
    public class ChoferBE
    {
        private string _idChofer;
        public string IDChofer
        {
            get { return _idChofer; }
            set { _idChofer = value; }
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

        private System.DateTime _fecchaNacimiento;
        public System.DateTime FechaNacimiento
        {
            get { return _fecchaNacimiento; }
            set { _fecchaNacimiento = value; }
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
        private int _dni;
        public int DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private string _numeroBrevete;
        public string NumeroBrevete
        {
            get { return _numeroBrevete; }
            set { _numeroBrevete = value; }
        }

        private string _tipoBrevete;
        public string TipoBrevete
        {
            get { return _tipoBrevete; }
            set { _tipoBrevete = value; }
        }
    }
}
