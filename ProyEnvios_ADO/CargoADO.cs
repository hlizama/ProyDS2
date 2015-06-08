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
    public class CargoADO
    {
        Boolean vexito = false;
        public List<CargoBE> ListarCargo()
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<CargoBE> objListarCargo = new List<CargoBE>();

            try
            {
                var query = MisCargos.ListarCargo();
                foreach (var cargo in query)
                {
                    CargoBE objCargoBE = new CargoBE();
                    objCargoBE.IDCargo = cargo.IDCargo;
                    objCargoBE.Nombre = cargo.Nombre;
                    objCargoBE.Descripcion = cargo.Descripcion;
                    objCargoBE.Peso = Convert.ToSingle(cargo.Peso);
                    objCargoBE.UnidadMedida = cargo.UnidadMedida;

                    objListarCargo.Add(objCargoBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarCargo;
        }

        public bool InsertarCargo(CargoBE objCargoBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Cargo objCargo = new tb_Cargo();

                objCargo.IDCargo = String.Empty;
                objCargo.IDTipoCargo = objCargoBE.IDTipoCargo;
                objCargo.Descripcion = objCargoBE.Descripcion;
                objCargo.Peso = Convert.ToSingle(objCargoBE.Peso);
                objCargo.UnidadMedida = objCargoBE.UnidadMedida;

                MisCargos.tb_Cargo.Add(objCargo);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool ActualizaCargo(CargoBE objCargoBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Cargo objCargo = (from carg in MisCargos.tb_Cargo
                                     where carg.IDCargo == objCargoBE.IDCargo
                                     select carg).FirstOrDefault();

                objCargo.IDTipoCargo = objCargoBE.IDTipoCargo;
                objCargo.Descripcion = objCargoBE.Descripcion;
                objCargo.Peso = Convert.ToSingle(objCargoBE.Peso);
                objCargo.UnidadMedida = objCargoBE.UnidadMedida;

                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool EliminarCargo(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Cargo objCargo = (from carg in MisCargos.tb_Cargo
                                     where carg.IDCargo == strCodigo
                                     select carg).FirstOrDefault();

                MisCargos.tb_Cargo.Remove(objCargo);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public CargoBE ConsultarCargo(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            CargoBE objCargoBE = new CargoBE();

            try
            {
                var query = MisCargos.ConsultarCargo(strCodigo);
                foreach (var carg in query)
                {
                    objCargoBE.IDCargo = carg.IDCargo;
                    objCargoBE.IDTipoCargo = carg.IDTipoCargo;
                    objCargoBE.Descripcion = carg.Descripcion;
                    objCargoBE.Peso = Convert.ToSingle(carg.Peso);
                    objCargoBE.UnidadMedida = carg.UnidadMedida;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objCargoBE;
        }
    }
}
