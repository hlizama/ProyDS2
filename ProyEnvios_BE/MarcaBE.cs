using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEnvios_BE
{
    public class MarcaBE
    {
        private string _idMarca;
        public string IDMarca
        {
            get { return _idMarca; }
            set { _idMarca = value; }
        }
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
