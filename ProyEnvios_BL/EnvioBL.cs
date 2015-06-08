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
    public class EnvioBL
    {
        EnvioADO objEnvioADO = new EnvioADO();

        public List<EnvioBE> ListarEnviosPendientes()
        {
            return objEnvioADO.ListarEnviosPendientes();
        }

        public String ListarCorreoClienteEnvio(String strCodigo)
        {
            return objEnvioADO.ListarCorreoClienteEnvio(strCodigo);
        }

        //----------------------consultas
        public List<EnvioBE> ConsultarEnviosCiudad(String strCodigo)
        {
            return objEnvioADO.ConsultarEnviosCiudad(strCodigo);
        }

        public List<EnvioBE> ConsultarEmpleadoEnvioFecha(String strCodigo, DateTime inicio, DateTime fin)
        {
            return objEnvioADO.ConsultarEmpleadoEnvioFecha(strCodigo, inicio, fin);
        }

        public List<EnvioBE> ListarEnvioChofer(String strCodigo)
        {
            return objEnvioADO.ListarEnvioChofer(strCodigo);
        }

        public List<EnvioBE> ConsultarEnvioEmpleado(String strCodigo)
        {
            return objEnvioADO.ConsultarEnvioEmpleado(strCodigo);
        }

        public List<EnvioBE> ConsultarEnvioCliente(String strCodigo)
        {
            return objEnvioADO.ConsultarEnvioCliente(strCodigo);
        }
    }
}
