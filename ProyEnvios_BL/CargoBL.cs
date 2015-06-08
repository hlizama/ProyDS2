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
    public class CargoBL
    {
        CargoADO objCargoADO = new CargoADO();

        public List<CargoBE> ListarCargo()
        {
            return objCargoADO.ListarCargo();
        }

        public Boolean InsertarCargo(CargoBE objcargoBE)
        {
            return objCargoADO.InsertarCargo(objcargoBE);
        }

        public Boolean ActualizarCargo(CargoBE objcargoBE)
        {
            return objCargoADO.ActualizaCargo(objcargoBE);
        }

        public Boolean EliminarCargo(String strCodigo)
        {
            return objCargoADO.EliminarCargo(strCodigo);
        }

        public CargoBE ConsultarCargo(String strCodigo)
        {
            return objCargoADO.ConsultarCargo(strCodigo);
        }
    }
}
