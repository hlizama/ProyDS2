using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEnvios_BE
{
    public class TransporteBE
    {
        private string _idTransporte;
        public string IDTransporte
        {
            get { return _idTransporte; }
            set { _idTransporte = value; }
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

        private string _idChofer;
        public string IDChofer
        {
            get { return _idChofer; }
            set { _idChofer = value; }
        }

        private string _idMarca;
        public string IDMarca
        {
            get { return _idMarca; }
            set { _idMarca = value; }
        }

        private string _modelo;
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        private string _placa;
        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        private string _tarjetaProp;
        public string TarjetaProp
        {
            get { return _tarjetaProp; }
            set { _tarjetaProp = value; }
        }
    }
}
