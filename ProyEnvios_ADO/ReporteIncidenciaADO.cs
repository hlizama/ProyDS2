using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyEnvios_BE;
using System.Data.Entity;

namespace ProyEnvios_ADO
{
    public class ReporteIncidenciaADO
    {
        Boolean vexito = false;
        public List<ReporteIncidenciaBE> ListarReporteIncidencia()
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<ReporteIncidenciaBE> objListarReporteIncidencia = new List<ReporteIncidenciaBE>();

            try
            {
                var query = MisCargos.ListarReporteIncidencia();
                foreach (var reporte in query)
                {
                    ReporteIncidenciaBE objReporteBE = new ReporteIncidenciaBE();
                    objReporteBE.IdReporte = reporte.IDReporte;
                    objReporteBE.Idenvio = reporte.IDEnvio;
                    objReporteBE.Nombre = reporte.Nombre;
                    objReporteBE.Notificado = Convert.ToInt16(reporte.Notificado);
                    objReporteBE.Retraso = Convert.ToInt16(reporte.Retraso);
                    objReporteBE.Descrip = reporte.Descrip;
                    objReporteBE.Fecha = Convert.ToDateTime(reporte.Fecha);

                    objListarReporteIncidencia.Add(objReporteBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarReporteIncidencia;
        }

        public bool InsertarReporteIncidencia(ReporteIncidenciaBE objReIncidenciaBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_ReporteIncidencia objReporte = new tb_ReporteIncidencia();

                objReporte.IDReporte = String.Empty;
                objReporte.IDEnvio = objReIncidenciaBE.Idenvio;
                objReporte.Nombre = objReIncidenciaBE.Nombre;
                objReporte.Notificado = Convert.ToInt16(objReIncidenciaBE.Notificado);
                objReporte.Retraso = Convert.ToInt16(objReIncidenciaBE.Retraso);
                objReporte.Descrip = objReIncidenciaBE.Descrip;
                objReporte.Fecha = Convert.ToDateTime(objReIncidenciaBE.Fecha);

                MisCargos.tb_ReporteIncidencia.Add(objReporte);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool ActualizarReporteIncidencia(ReporteIncidenciaBE objReIncidenciaBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_ReporteIncidencia objReporte = (from repor in MisCargos.tb_ReporteIncidencia
                                                   where repor.IDReporte == objReIncidenciaBE.IdReporte
                                                   select repor).FirstOrDefault();

                objReporte.IDEnvio = objReIncidenciaBE.Idenvio;
                objReporte.Nombre = objReIncidenciaBE.Nombre;
                objReporte.Notificado = Convert.ToInt16(objReIncidenciaBE.Notificado);
                objReporte.Retraso = Convert.ToInt16(objReIncidenciaBE.Retraso);
                objReporte.Descrip = objReIncidenciaBE.Descrip;
                objReporte.Fecha = Convert.ToDateTime(objReIncidenciaBE.Fecha);

                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool EliminarReporteIncidencia(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_ReporteIncidencia objReporte = (from repor in MisCargos.tb_ReporteIncidencia
                                                   where repor.IDReporte == strCodigo
                                                   select repor).FirstOrDefault();

                MisCargos.tb_ReporteIncidencia.Remove(objReporte);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public ReporteIncidenciaBE ConsulatarReporteIncidencia(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            ReporteIncidenciaBE objReIncidenciaBE = new ReporteIncidenciaBE();

            try
            {
                var query = MisCargos.ConsultarReporteIncidencia(strCodigo);
                foreach (var repor in query)
                {
                    objReIncidenciaBE.IdReporte = repor.IDReporte;
                    objReIncidenciaBE.Idenvio = repor.IDEnvio;
                    objReIncidenciaBE.Nombre = repor.Nombre;
                    objReIncidenciaBE.Notificado = Convert.ToInt16(repor.Notificado);
                    objReIncidenciaBE.Retraso = Convert.ToInt16(repor.Retraso);
                    objReIncidenciaBE.Descrip = repor.Descrip;
                    objReIncidenciaBE.Fecha = Convert.ToDateTime(repor.Fecha);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objReIncidenciaBE;
        }
    }
}
