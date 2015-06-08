using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyEnvios_ADO;
using ProyEnvios_BE;

namespace ProyEnvios_BL
{
    public class EmpleadoBL
    {
        EmpleadoADO objEmpleadoADO = new EmpleadoADO();

        public List<EmpleadoBE> ListarEmpleado()
        {
            return objEmpleadoADO.ListarEmpleado();
        }

        public Boolean InsertarEmpleado(EmpleadoBE objempBE)
        {
            return objEmpleadoADO.InsertarEmpleado(objempBE);
        }
    }
}
