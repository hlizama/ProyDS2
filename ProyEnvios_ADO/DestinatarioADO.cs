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
    public class DestinatarioADO
    {
        Boolean vexito = false;
        public List<DestinatarioBE> ListarDestinatario()
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<DestinatarioBE> objListarDestinatario = new List<DestinatarioBE>();

            try
            {
                var query = MisCargos.ListarDestinatario2();
                foreach (var desti in query)
                {
                    DestinatarioBE objDestinatarioBE = new DestinatarioBE();
                    objDestinatarioBE.Iddestinatario = desti.IDDestinatario;
                    objDestinatarioBE.Razon_Social = desti.Razon_Social;
                    objDestinatarioBE.Dni = desti.DNI;
                    objDestinatarioBE.Direccion = desti.Direccion;
                    objDestinatarioBE.Telefono = desti.Telefono;

                    objListarDestinatario.Add(objDestinatarioBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarDestinatario;
        }

        public bool InsertarDestinatario(DestinatarioBE objDestinatarioBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Destinatario objDestinatario = new tb_Destinatario();

                objDestinatario.IDDestinatario = String.Empty;
                objDestinatario.Nombre = objDestinatarioBE.Nombre;
                objDestinatario.Apellido_pat = objDestinatarioBE.Apellido_Pat;
                objDestinatario.Apellido_mat = objDestinatarioBE.Apellido_Mat;
                objDestinatario.DNI = objDestinatarioBE.Dni;
                objDestinatario.Direccion = objDestinatarioBE.Direccion;
                objDestinatario.Telefono = objDestinatarioBE.Telefono;

                MisCargos.tb_Destinatario.Add(objDestinatario);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool ActualizarDestinatario(DestinatarioBE objDestinatarioBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Destinatario objdestinatario = (from desti in MisCargos.tb_Destinatario
                                                   where desti.IDDestinatario == objDestinatarioBE.Iddestinatario
                                                   select desti).FirstOrDefault();

                objdestinatario.Nombre = objDestinatarioBE.Nombre;
                objdestinatario.Apellido_pat = objDestinatarioBE.Apellido_Pat;
                objdestinatario.Apellido_mat = objDestinatarioBE.Apellido_Mat;
                objdestinatario.DNI = objDestinatarioBE.Dni;
                objdestinatario.Direccion = objDestinatarioBE.Direccion;
                objdestinatario.Telefono = objDestinatarioBE.Telefono;

                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool EliminarDestinatario(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Destinatario objdestinatario = (from desti in MisCargos.tb_Destinatario
                                                   where desti.IDDestinatario == strCodigo
                                                   select desti).FirstOrDefault();

                MisCargos.tb_Destinatario.Remove(objdestinatario);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public DestinatarioBE ConsultarDestinatario(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            DestinatarioBE objDestinatarioBE = new DestinatarioBE();

            try
            {
                var query = MisCargos.ConsultarDestinatario2(strCodigo);
                foreach (var desti in query)
                {
                    objDestinatarioBE.Iddestinatario = desti.IDDestinatario;
                    objDestinatarioBE.Nombre = desti.Nombre;
                    objDestinatarioBE.Apellido_Pat = desti.Apellido_pat;
                    objDestinatarioBE.Apellido_Mat = desti.Apellido_mat;
                    objDestinatarioBE.Dni = desti.DNI;
                    objDestinatarioBE.Direccion = desti.Direccion;
                    objDestinatarioBE.Telefono = desti.Telefono;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objDestinatarioBE;
        }
    }
}
