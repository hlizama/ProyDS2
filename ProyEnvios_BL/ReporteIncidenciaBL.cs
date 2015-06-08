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
    public class ReporteIncidenciaBL
    {
        ReporteIncidenciaADO objReIncidenciaADO = new ReporteIncidenciaADO();

        public List<ReporteIncidenciaBE> ListarReporteIncidencia()
        {
            return objReIncidenciaADO.ListarReporteIncidencia();
        }

        public Boolean InsertarReporteIncidencia(ReporteIncidenciaBE objreincidenciaBE)
        {
            return objReIncidenciaADO.InsertarReporteIncidencia(objreincidenciaBE);
        }

        public Boolean ActualizarReporteIncidencia(ReporteIncidenciaBE objreincidenciaBE)
        {
            return objReIncidenciaADO.ActualizarReporteIncidencia(objreincidenciaBE);
        }

        public Boolean EliminarReporteIncidencia(String strCodigo)
        {
            return objReIncidenciaADO.EliminarReporteIncidencia(strCodigo);
        }

        public ReporteIncidenciaBE ConsultarReporteIncidencia(String strCodigo)
        {
            return objReIncidenciaADO.ConsulatarReporteIncidencia(strCodigo);
        }
    }
}
