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
    public class ChoferBL
    {
        ChoferADO objChoferADO = new ChoferADO();

        public List<ChoferBE> ListarChofer()
        {
            return objChoferADO.ListarChofer();
        }

        public Boolean InsertarChofer(ChoferBE objchoferBE)
        {
            return objChoferADO.InsertarChofer(objchoferBE);
        }

        public Boolean ActualizarChofer(ChoferBE objchoferBE)
        {
            return objChoferADO.ActualizarChofer(objchoferBE);
        }

        public Boolean EliminarChofer(String strCodigo)
        {
            return objChoferADO.EliminarChofer(strCodigo);
        }

        public ChoferBE ConsultarChofer(String strCodigo)
        {
            return objChoferADO.ConsultarChofer(strCodigo);
        }
    }
}
