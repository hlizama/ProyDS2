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
    public class EnvioADO
    {
        public List<EnvioBE> ListarEnviosPendientes()
        {

            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<EnvioBE> objListarEvioPendiente = new List<EnvioBE>();

            try
            {
                var query = MisCargos.ListarEnvioPendiente();
                foreach (var envioPe in query)
                {
                    EnvioBE objEnvioBE = new EnvioBE();
                    objEnvioBE.IDEnvio = envioPe.IDEnvio;
                    objEnvioBE.Nombre_Cliente = envioPe.Nombre_Cliente;
                    objEnvioBE.Placa = envioPe.Placa;
                    objEnvioBE.Tipo_Servicio = envioPe.Tipo_Servicio;
                    objEnvioBE.Estatus = envioPe.Estatus;
                    objEnvioBE.FechaEstimada = Convert.ToDateTime(envioPe.FechaEstimada);

                    objListarEvioPendiente.Add(objEnvioBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarEvioPendiente;
        }

        public String ListarCorreoClienteEnvio(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            EnvioBE objEnvioBE = new EnvioBE();

            try
            {
                var query = MisCargos.ListarCorreoCliente2(strCodigo);
                foreach (var cor in query)
                {
                    objEnvioBE.Correo = cor.Correo;
                    return objEnvioBE.Correo;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return String.Empty;
        }

        public List<EnvioBE> ConsultarEnviosCiudad(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<EnvioBE> objConsultarEnvCiu = new List<EnvioBE>();
            try
            {
                var query = MisCargos.ConsultarEnvioCiudad(strCodigo);
                foreach (var resultado in query)
                {
                    EnvioBE objEnvioBE = new EnvioBE();
                    objEnvioBE.IDEnvio = resultado.IDEnvio;
                    objEnvioBE.Estatus = resultado.Estatus;
                    objEnvioBE.Razon_Social = resultado.Razon_Social;
                    objEnvioBE.FechaEstimada = Convert.ToDateTime(resultado.FechaEstimada);
                    objEnvioBE.Distrito = resultado.Distrito;
                    objEnvioBE.Direccion = resultado.Direccion;

                    objConsultarEnvCiu.Add(objEnvioBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objConsultarEnvCiu;
        }

        public List<EnvioBE> ConsultarEmpleadoEnvioFecha(String strCodigo, DateTime inicio, DateTime fin)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<EnvioBE> objConsEmpleadoEnvioFec = new List<EnvioBE>();
            try
            {
                var query = MisCargos.ConsultarEmpleadoEnvioFecha(strCodigo, inicio, fin);
                foreach (var result in query)
                {
                    EnvioBE objEnvioBE = new EnvioBE();
                    objEnvioBE.IDEnvio = result.IDEnvio;
                    objEnvioBE.Razon_Social = result.Razon_Social;
                    objEnvioBE.FechaEstimada = Convert.ToDateTime(result.FechaEstimada);
                    objEnvioBE.Descripcion = result.Descripcion;
                    objEnvioBE.TCNombre = result.TCNombre;
                    objEnvioBE.TSNombre = result.TSNombre;
                    objEnvioBE.Estatus = result.Estatus;

                    objConsEmpleadoEnvioFec.Add(objEnvioBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objConsEmpleadoEnvioFec;
        }

        public List<EnvioBE> ListarEnvioChofer(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<EnvioBE> objListarEnvioChofer = new List<EnvioBE>();
            try
            {
                var query = MisCargos.ListarEnvioChofer(strCodigo);
                foreach (var envioChof in query)
                {
                    EnvioBE objEnvioBE = new EnvioBE();
                    objEnvioBE.IDEnvio = envioChof.IDEnvio;
                    objEnvioBE.CINombre = envioChof.CINombre;
                    objEnvioBE.Distrito = envioChof.Distrito;
                    objEnvioBE.TCNombre = envioChof.TCNombre;
                    objEnvioBE.TSNombre = envioChof.TSNombre;
                    objEnvioBE.Estatus = envioChof.Estatus;
                    objEnvioBE.Placa = envioChof.Placa;
                    objEnvioBE.FechaEstimada = Convert.ToDateTime(envioChof.FechaEstimada);
                    objEnvioBE.Peso = Convert.ToInt32(envioChof.Peso);

                    objListarEnvioChofer.Add(objEnvioBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarEnvioChofer;
        }

        public List<EnvioBE> ConsultarEnvioEmpleado(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<EnvioBE> objConsultarEnvioEmp = new List<EnvioBE>();
            try
            {
                var query = MisCargos.ConsultarEnvioEmpleado(strCodigo);
                foreach (var envioEmp in query)
                {
                    EnvioBE objEnvioBE = new EnvioBE();
                    objEnvioBE.IDEnvio = envioEmp.IDEnvio;
                    objEnvioBE.CINombre = envioEmp.CINombre;
                    objEnvioBE.Distrito = envioEmp.Distrito;
                    objEnvioBE.TCNombre = envioEmp.TCNombre;
                    objEnvioBE.TSNombre = envioEmp.TSNombre;
                    objEnvioBE.Estatus = envioEmp.Estatus;
                    objEnvioBE.Placa = envioEmp.Placa;
                    objEnvioBE.FechaEstimada = Convert.ToDateTime(envioEmp.FechaEstimada);
                    objEnvioBE.Peso = Convert.ToInt32(envioEmp.Peso);

                    objConsultarEnvioEmp.Add(objEnvioBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objConsultarEnvioEmp;
        }

        public List<EnvioBE> ConsultarEnvioCliente(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<EnvioBE> objConsultarEnvioCli = new List<EnvioBE>();
            try
            {
                var query = MisCargos.ConsultarEnvioCliente(strCodigo);
                foreach (var envioCli in query)
                {
                    EnvioBE objEnvioBE = new EnvioBE();
                    objEnvioBE.IDEnvio = envioCli.IDEnvio;
                    objEnvioBE.CINombre = envioCli.CINombre;
                    objEnvioBE.Distrito = envioCli.Distrito;
                    objEnvioBE.TCNombre = envioCli.TCNombre;
                    objEnvioBE.TSNombre = envioCli.TSNombre;
                    objEnvioBE.Estatus = envioCli.Estatus;
                    objEnvioBE.Placa = envioCli.Placa;
                    objEnvioBE.FechaEstimada = Convert.ToDateTime(envioCli.FechaEstimada);
                    objEnvioBE.Peso = Convert.ToInt32(envioCli.Peso);

                    objConsultarEnvioCli.Add(objEnvioBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objConsultarEnvioCli;
        }
    }
}
