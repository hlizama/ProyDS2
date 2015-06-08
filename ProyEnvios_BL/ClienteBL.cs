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
    public class ClienteBL
    {
        ClienteADO objClienteADO = new ClienteADO();

        public List<ClienteBE> ListarCliente()
        {
            return objClienteADO.ListarCliente();
        }

        public Boolean InsertarCliente(ClienteBE objclienteBE)
        {
            return objClienteADO.InsertarCliente(objclienteBE);
        }
    }
}
