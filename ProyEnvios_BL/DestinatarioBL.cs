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
    public class DestinatarioBL
    {
        DestinatarioADO objDestinatarioADO = new DestinatarioADO();

        public List<DestinatarioBE> ListarDestinario()
        {
            return objDestinatarioADO.ListarDestinatario();
        }

        public Boolean InsertarDestinatario(DestinatarioBE objdestinatarioBE)
        {
            return objDestinatarioADO.InsertarDestinatario(objdestinatarioBE);
        }

        public Boolean ActualizarDestinatario(DestinatarioBE objdestinatarioBE)
        {
            return objDestinatarioADO.ActualizarDestinatario(objdestinatarioBE);
        }

        public Boolean EliminarDestinatario(String strCodigo)
        {
            return objDestinatarioADO.EliminarDestinatario(strCodigo);
        }

        public DestinatarioBE ConsultarDestinatario(String strCodigo)
        {
            return objDestinatarioADO.ConsultarDestinatario(strCodigo);
        }
    }
}
