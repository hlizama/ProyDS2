using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEnvios_BE
{
    public class EmpleadoBE
    {
        private string _idempleado;
        public string Idempleado
        {
            get { return _idempleado; }
            set { _idempleado = value; }
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
        public string Apellido_pat
        {
            get { return _apellido_pat; }
            set { _apellido_pat = value; }
        }

        private string _apellido_mat;
        public string Apellido_mat
        {
            get { return _apellido_mat; }
            set { _apellido_mat = value; }
        }

        private System.DateTime _fechaNacimiento;
        public System.DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        private string _direccion;
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private int _dni;
        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private string _telefono;
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _sexo;
        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        private string _usuario;
        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private string _pass;
        public string Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

        private byte[] _foto;
        public byte[] Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }
    }
}
