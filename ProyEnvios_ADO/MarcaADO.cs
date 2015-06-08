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
    public class MarcaADO
    {
        Boolean vexito = false;
        public List<MarcaBE> ListarMarca()
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<MarcaBE> objListarMarca = new List<MarcaBE>();

            try
            {
                var query = MisCargos.ListarMarca();
                foreach (var marca in query)
                {
                    MarcaBE objMarcaBE = new MarcaBE();
                    objMarcaBE.IDMarca = marca.IDMarca;
                    objMarcaBE.Nombre = marca.Nombre;

                    objListarMarca.Add(objMarcaBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarMarca;
        }

        public bool InsertarMarca(MarcaBE objMarcaBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Marca objMarca = new tb_Marca();

                objMarca.IDMarca = String.Empty;
                objMarca.Nombre = objMarcaBE.Nombre;

                MisCargos.tb_Marca.Add(objMarca);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool ActualizarMarca(MarcaBE objMarcaBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Marca objMarca = (from mar in MisCargos.tb_Marca
                                     where mar.IDMarca == objMarcaBE.IDMarca
                                     select mar).FirstOrDefault();

                objMarca.Nombre = objMarcaBE.Nombre;

                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool EliminarMarca(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Marca objMarca = (from mar in MisCargos.tb_Marca
                                     where mar.IDMarca == strCodigo
                                     select mar).FirstOrDefault();

                MisCargos.tb_Marca.Remove(objMarca);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public MarcaBE ConsultarMarca(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            MarcaBE objMarcaBE = new MarcaBE();

            try
            {
                var query = MisCargos.usp_ConsultarMarca(strCodigo);
                foreach (var mar in query)
                {
                    objMarcaBE.IDMarca = mar.IDMarca;
                    objMarcaBE.Nombre = mar.Nombre;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objMarcaBE;
        }
    }
}
