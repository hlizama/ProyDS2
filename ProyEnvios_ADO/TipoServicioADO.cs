using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyEnvios_ADO;
using ProyEnvios_BE;
using System.Data.Entity;

namespace ProyEnvios_ADO
{
    public class TipoServicioADO
    {
        Boolean vexito = false;
        public List<TipoServicioBE> ListarTipoServicio()
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<TipoServicioBE> objListarTipoServicio = new List<TipoServicioBE>();

            try
            {
                var query = MisCargos.usp_ListarTipoServicio2();
                foreach (var TServicio in query)
                {
                    TipoServicioBE objTipoServicioBE = new TipoServicioBE();
                    objTipoServicioBE.IDtiposervicio = TServicio.IDTipoServicio;
                    objTipoServicioBE.Nombre = TServicio.Nombre;
                    objTipoServicioBE.Dias = Convert.ToInt16(TServicio.dias);
                    objTipoServicioBE.Precio = Convert.ToSingle(TServicio.Precio);

                    objListarTipoServicio.Add(objTipoServicioBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarTipoServicio;
        }

        public bool InsertarTipoServicio(TipoServicioBE objTipoServicioBE)
        {
            //instaciamos el modelo
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                
                //creamos una instacia de la clas eTb _Vendedor
                tb_TipoServicio objTServicio = new tb_TipoServicio();

                //y la llenamos con los datos de la entidad de negocios 
                objTServicio.IDTipoServicio = String.Empty;
                objTServicio.Nombre = objTipoServicioBE.Nombre;
                objTServicio.dias = Convert.ToInt16(objTipoServicioBE.Dias);
                objTServicio.Precio = Convert.ToDecimal(objTipoServicioBE.Precio);

                //agregamos la instancia y grabamos los datos en el modelo
                MisCargos.tb_TipoServicio.Add(objTServicio);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool ActualizarTipoServicio(TipoServicioBE objTipoServicioBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                //obtenemos con LINQ el registro a actualizar (no necesariamente ven puede ser * cualquier nombre
                tb_TipoServicio objTServicio = (from Servi in MisCargos.tb_TipoServicio
                                                where Servi.IDTipoServicio == objTipoServicioBE.IDtiposervicio
                                                select Servi).FirstOrDefault();

                //actualizammos el registro con los datos que provienen de la entidad de negocios
                objTServicio.Nombre = objTipoServicioBE.Nombre;
                objTServicio.dias = Convert.ToInt16(objTipoServicioBE.Dias);
                objTServicio.Precio = Convert.ToDecimal(objTipoServicioBE.Precio);

                //actualizar el modelo
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool EliminarTipoServicio(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                //obtenemos con el LINQ el registro a eliminar
                tb_TipoServicio objTServicio = (from Servi in MisCargos.tb_TipoServicio
                                                where Servi.IDTipoServicio == strCodigo
                                                select Servi).FirstOrDefault();

                MisCargos.tb_TipoServicio.Remove(objTServicio);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public TipoServicioBE ConsultarTipoServicio(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            TipoServicioBE objTServicioBE = new TipoServicioBE();
            try
            {
                tb_TipoServicio objTServicio = (from Servi in MisCargos.tb_TipoServicio
                                                where Servi.IDTipoServicio == strCodigo
                                                select Servi).FirstOrDefault();

                objTServicioBE.IDtiposervicio = objTServicio.IDTipoServicio;
                objTServicioBE.Nombre = objTServicio.Nombre;
                objTServicioBE.Dias = Convert.ToInt16(objTServicio.dias);
                objTServicioBE.Precio = Convert.ToSingle(objTServicio.Precio);
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objTServicioBE;
        }

    }
}
