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
    public class ChoferADO
    {
        Boolean vexito = false;
        public List<ChoferBE> ListarChofer()
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<ChoferBE> objListarChofer = new List<ChoferBE>();

            try
            {
                var query = MisCargos.ListarChofer();
                foreach (var chofer in query)
                {
                    ChoferBE objChoferBE = new ChoferBE();
                    objChoferBE.IDChofer = chofer.IDChofer;
                    objChoferBE.Razon_Social = chofer.Razon_Social;
                    objChoferBE.FechaNacimiento = Convert.ToDateTime(chofer.FechaNacimiento);
                    objChoferBE.Direccion = chofer.Direccion;
                    objChoferBE.Telefono = chofer.Telefono;
                    objChoferBE.DNI = Convert.ToInt32(chofer.DNI);
                    objChoferBE.NumeroBrevete = chofer.NumeroBrevete;
                    objChoferBE.TipoBrevete = chofer.TipoBrevete;

                    objListarChofer.Add(objChoferBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarChofer;
        }

        public bool InsertarChofer(ChoferBE objChoferBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Chofer objChofer = new tb_Chofer();

                objChofer.IDChofer = String.Empty;
                objChofer.Nombre = objChoferBE.Nombre;
                objChofer.Apellido_pat = objChoferBE.Apellido_Pat;
                objChofer.Apellido_mat = objChoferBE.Apellido_Mat;
                objChofer.FechaNacimiento = Convert.ToDateTime(objChoferBE.FechaNacimiento);
                objChofer.Direccion = objChoferBE.Direccion;
                objChofer.Telefono = objChoferBE.Telefono;
                objChofer.DNI = Convert.ToInt32(objChoferBE.DNI);
                objChofer.NumeroBrevete = objChoferBE.NumeroBrevete;
                objChofer.TipoBrevete = objChoferBE.TipoBrevete;

                MisCargos.tb_Chofer.Add(objChofer);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool ActualizarChofer(ChoferBE objChoferBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Chofer objChofer = (from chof in MisCargos.tb_Chofer
                                       where chof.IDChofer == objChoferBE.IDChofer
                                       select chof).FirstOrDefault();

                objChofer.Nombre = objChoferBE.Nombre;
                objChofer.Apellido_pat = objChoferBE.Apellido_Pat;
                objChofer.Apellido_mat = objChoferBE.Apellido_Mat;
                objChofer.FechaNacimiento = Convert.ToDateTime(objChoferBE.FechaNacimiento);
                objChofer.Direccion = objChoferBE.Direccion;
                objChofer.Telefono = objChoferBE.Telefono;
                objChofer.DNI = Convert.ToInt32(objChoferBE.DNI);
                objChofer.NumeroBrevete = objChoferBE.NumeroBrevete;
                objChofer.TipoBrevete = objChoferBE.TipoBrevete;
               
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch(EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool EliminarChofer(String strCodigo)
        {
            EmpresaCargoCourierEntities Miscargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Chofer objChofer = (from chof in Miscargos.tb_Chofer
                                       where chof.IDChofer == strCodigo
                                       select chof).FirstOrDefault();

                Miscargos.tb_Chofer.Remove(objChofer);
                Miscargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public ChoferBE ConsultarChofer(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            ChoferBE objChoferBE = new ChoferBE();

            try
            {
                var query = MisCargos.ConsultarChofer(strCodigo);
                foreach (var chof in query)
                {
                    objChoferBE.IDChofer = chof.IDChofer;
                    objChoferBE.Nombre = chof.Nombre;
                    objChoferBE.Apellido_Pat = chof.Apellido_pat;
                    objChoferBE.Apellido_Mat = chof.Apellido_mat;
                    objChoferBE.FechaNacimiento = Convert.ToDateTime(chof.FechaNacimiento);
                    objChoferBE.Direccion = chof.Direccion;
                    objChoferBE.Telefono = chof.Telefono;
                    objChoferBE.DNI = Convert.ToInt32(chof.DNI);
                    objChoferBE.NumeroBrevete = chof.NumeroBrevete;
                    objChoferBE.TipoBrevete = chof.TipoBrevete;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objChoferBE;
        }
    }
}
