using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEnvios_BE
{
    public class CargoBE
    {
        private string _idCargo;
        public string IDCargo
        {
            get { return _idCargo; }
            set { _idCargo = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        
        private string _idTipoCargo;
        public string IDTipoCargo
        {
            get { return _idTipoCargo; }
            set { _idTipoCargo = value; }
        }

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private Single _peso;
        public Single Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        private string _unidadMedida;
        public string UnidadMedida
        {
            get { return _unidadMedida; }
            set { _unidadMedida = value; }
        }
    }
}
