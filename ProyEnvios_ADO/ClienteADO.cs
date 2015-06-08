using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyEnvios_BE;
using System.Data.Entity;
using System.Data.Objects;

namespace ProyEnvios_ADO
{
    public class ClienteADO
    {
        Boolean vexito = false;
        public List<ClienteBE> ListarCliente()
        {
    
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<ClienteBE> objListarCliente = new List<ClienteBE>();

            try
            {
                var query = MisCargos.ListarCliente();
                foreach (var cliente in query)
                {
                    ClienteBE objClienteBE = new ClienteBE();
                    objClienteBE.Idcliente = cliente.IDCliente;
                    objClienteBE.Razon_Social = cliente.Razon_Social;
                    objClienteBE.Dni = cliente.DNI;
                    objClienteBE.FechaNacimiento = Convert.ToDateTime(cliente.FechaNacimiento);
                    objClienteBE.Direccion = cliente.Direccion;
                    objClienteBE.Ruc = cliente.RUC;
                    objClienteBE.Telefono = cliente.Telefono;
                    objClienteBE.Usuario = cliente.Usuario;
                    objClienteBE.Correo = cliente.Correo;

                    objListarCliente.Add(objClienteBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarCliente;
        }

        public bool InsertarCliente(ClienteBE objClienteBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Cliente objCliente = new tb_Cliente();

                objCliente.IDCliente = String.Empty;
                objCliente.Nombre = objClienteBE.Nombre;
                objCliente.Apellido_pat = objClienteBE.Apellido_pat;
                objCliente.Apellido_mat = objClienteBE.Apellido_mat;
                objCliente.FechaNacimiento = Convert.ToDateTime(objClienteBE.FechaNacimiento);
                objCliente.Direccion = objClienteBE.Direccion;
                objCliente.RUC = objClienteBE.Ruc;
                objCliente.Telefono = objClienteBE.Telefono;
                objCliente.DNI = objClienteBE.Dni;
                objCliente.Usuario = objClienteBE.Usuario;
                objCliente.Pass = objClienteBE.Pass;
                objCliente.Correo = objClienteBE.Correo;

                MisCargos.tb_Cliente.Add(objCliente);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }
    }
}
