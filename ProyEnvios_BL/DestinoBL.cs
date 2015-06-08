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
    public class DestinoBL
    {
        DestinoADO objDestinoADO = new DestinoADO();

        public List<DestinoBE> ListarDestino()
        {
            return objDestinoADO.ListarDestino();
        }

        public Boolean InsertarDestino(DestinoBE objdestinoBE)
        {
            return objDestinoADO.InsertarDestino(objdestinoBE);
        }

        public Boolean ActualizarDestino(DestinoBE objdestinoBE)
        {
            return objDestinoADO.ActulizarDestino(objdestinoBE);
        }

        public Boolean EliminarDestino(String strCodigo)
        {
            return objDestinoADO.EliminarDestino(strCodigo);
        }

        public DestinoBE ConsultarDestino(String strCodigo)
        {
            return objDestinoADO.ConsultarDestino(strCodigo);
        }
    }
}
