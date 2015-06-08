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
    public class DestinoADO
    {
        Boolean vexito = false;
        public List<DestinoBE> ListarDestino()
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<DestinoBE> objListarDestino = new List<DestinoBE>();

            try
            {
                var query = MisCargos.ListarDestino();
                foreach (var desti in query)
                {
                    DestinoBE objDestinoBE = new DestinoBE();
                    objDestinoBE.Iddestino = desti.IDDestino;
                    objDestinoBE.Nombre = desti.Nombre;
                    objDestinoBE.Direccion = desti.Direccion;
                    objDestinoBE.Distrito = desti.Distrito;

                    objListarDestino.Add(objDestinoBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarDestino;
        }

        public bool InsertarDestino(DestinoBE objDestinoBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Destino objdestino = new tb_Destino();

                objdestino.IDDestino = String.Empty;
                objdestino.IDCiudad = objDestinoBE.Idciudad;
                objdestino.Direccion = objDestinoBE.Direccion;
                objdestino.Distrito = objDestinoBE.Distrito;

                MisCargos.tb_Destino.Add(objdestino);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool ActulizarDestino(DestinoBE objDestinoBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Destino objDestino = (from desti in MisCargos.tb_Destino
                                         where desti.IDDestino == objDestinoBE.Iddestino
                                         select desti).FirstOrDefault();

                objDestino.IDCiudad = objDestinoBE.Idciudad;
                objDestino.Direccion = objDestinoBE.Direccion;
                objDestino.Distrito = objDestinoBE.Distrito;

                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool EliminarDestino(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Destino objDestino = (from desti in MisCargos.tb_Destino
                                         where desti.IDDestino == strCodigo
                                         select desti).FirstOrDefault();

                MisCargos.tb_Destino.Remove(objDestino);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public DestinoBE ConsultarDestino(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            DestinoBE objDestinoBE = new DestinoBE();

            try
            {
                var query = MisCargos.ConsultarDestino(strCodigo);
                foreach (var desti in query)
                {
                    objDestinoBE.Iddestino = desti.IDDestino;
                    objDestinoBE.Idciudad = desti.IDCiudad;
                    objDestinoBE.Direccion = desti.Direccion;
                    objDestinoBE.Distrito = desti.Distrito;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objDestinoBE;
        }
    }
}
