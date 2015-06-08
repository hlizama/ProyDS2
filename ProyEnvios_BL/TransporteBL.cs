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
    public class TransporteBL
    {
        TransporteADO objTransporteADO = new TransporteADO();

        public List<TransporteBE> ListarTransporte()
        {
            return objTransporteADO.ListarTransporte();
        }

        public Boolean InsertarTransporte(TransporteBE objTransporteBE)
        {
            return objTransporteADO.InsertarTransporte(objTransporteBE);
        }

        public Boolean ActualizarTransporte(TransporteBE objTransporteBE)
        {
            return objTransporteADO.ActualizarTransporte(objTransporteBE);
        }

        public Boolean EliminarTransporte(String strCodigo)
        {
            return objTransporteADO.EliminarTransporte(strCodigo);
        }

        public TransporteBE ConsultarTransporte(String strCodigo)
        {
            return objTransporteADO.ConsultarTransporte(strCodigo);
        }
    }
}
