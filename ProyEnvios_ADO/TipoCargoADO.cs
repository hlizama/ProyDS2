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
    public class TipoCargoADO
    {
        Boolean vexito = false;
        public List<TipoCargoBE> ListarTipoCargo()
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<TipoCargoBE> objListarTipoCargo = new List<TipoCargoBE>();

            try
            {
                var query = MisCargos.usp_ListarTipoCargo();
                foreach (var tcargo in query)
                {
                    TipoCargoBE objTipoCargoBE = new TipoCargoBE();
                    objTipoCargoBE.Idtipocargo = tcargo.IDTipoCargo;
                    objTipoCargoBE.Nombre = tcargo.Nombre;

                    objListarTipoCargo.Add(objTipoCargoBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarTipoCargo;
        }

        public bool InsertarTipoCargo(TipoCargoBE objTipoCargoBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_TipoCargo objTipoCargo = new tb_TipoCargo();

                objTipoCargo.IDTipoCargo = objTipoCargoBE.Idtipocargo;
                objTipoCargo.Nombre = objTipoCargoBE.Nombre;

                MisCargos.tb_TipoCargo.Add(objTipoCargo);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool ActualizarTipoCargo(TipoCargoBE objTipoCargoBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_TipoCargo objTipoCargo = (from tcargo in MisCargos.tb_TipoCargo
                                             where tcargo.IDTipoCargo == objTipoCargoBE.Idtipocargo
                                             select tcargo).FirstOrDefault();

                objTipoCargo.Nombre = objTipoCargoBE.Nombre;

                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool EliminarTipoCargo(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_TipoCargo objTipoCargo = (from tcargo in MisCargos.tb_TipoCargo
                                             where tcargo.IDTipoCargo == strCodigo
                                             select tcargo).FirstOrDefault();

                MisCargos.tb_TipoCargo.Remove(objTipoCargo);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public TipoCargoBE ConsultarTipoCargo(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            TipoCargoBE objTipoCargoBE = new TipoCargoBE();

            try
            {
                var query = MisCargos.ConsultarTipoCargo(strCodigo);
                foreach (var tcargo in query)
                {
                    objTipoCargoBE.Idtipocargo = tcargo.IDTipoCargo;
                    objTipoCargoBE.Nombre = tcargo.Nombre;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objTipoCargoBE;
        }
    }
}
