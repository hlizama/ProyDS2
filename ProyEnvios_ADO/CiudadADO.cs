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
    public class CiudadADO
    {
        Boolean vexito = false;
        public List<CiudadBE> ListarCiudad()
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<CiudadBE> objListarCiudad = new List<CiudadBE>();

            try
            {
                var query = MisCargos.ListarCiudad2();
                foreach (var ciudad in query)
                {
                    CiudadBE objCiudadBE = new CiudadBE();
                    objCiudadBE.IDCiudad = ciudad.IDCiudad;
                    objCiudadBE.Nombre = ciudad.Nombre;
                    objCiudadBE.Kilometros = Convert.ToInt32(ciudad.Kilometros);

                    objListarCiudad.Add(objCiudadBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarCiudad;
        }

        public bool InsertarCiudad(CiudadBE objCiudadBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Ciudad objCiudad = new tb_Ciudad();

                objCiudad.IDCiudad = String.Empty;
                objCiudad.Nombre = objCiudadBE.Nombre;
                objCiudad.Kilometros = Convert.ToInt32(objCiudadBE.Kilometros);

                MisCargos.tb_Ciudad.Add(objCiudad);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool ActualizarCiudad(CiudadBE objCiudadBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Ciudad objCiudad = (from ciu in MisCargos.tb_Ciudad
                                       where ciu.IDCiudad == objCiudadBE.IDCiudad
                                       select ciu).FirstOrDefault();

                objCiudad.Nombre = objCiudadBE.Nombre;
                objCiudad.Kilometros = Convert.ToInt32(objCiudadBE.Kilometros);

                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool EliminarCiudad(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Ciudad objCiudad = (from ciu in MisCargos.tb_Ciudad
                                       where ciu.IDCiudad == strCodigo
                                       select ciu).FirstOrDefault();

                MisCargos.tb_Ciudad.Remove(objCiudad);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public CiudadBE ConsultarCiudad(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            CiudadBE objCiudadBE = new CiudadBE();

            try
            {
                var query = MisCargos.ConsultarCiudad2(strCodigo);
                foreach (var ciu in query)
                {
                    objCiudadBE.IDCiudad = ciu.IDCiudad;
                    objCiudadBE.Nombre = ciu.Nombre;
                    objCiudadBE.Kilometros = Convert.ToInt32(ciu.Kilometros);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objCiudadBE;
        }

        //-----------------------------consultas
        
    }
}
