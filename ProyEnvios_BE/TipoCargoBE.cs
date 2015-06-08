using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEnvios_BE
{
    public class TipoCargoBE
    {
        private string _idtipocargo;
        public string Idtipocargo
        {
            get { return _idtipocargo; }
            set { _idtipocargo = value; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
