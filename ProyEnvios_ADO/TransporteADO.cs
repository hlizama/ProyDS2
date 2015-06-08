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
    public class TransporteADO
    {
        Boolean vexito = false;
        public List<TransporteBE> ListarTransporte()
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            List<TransporteBE> objListarTransporte = new List<TransporteBE>();

            try
            {
                var query = MisCargos.ListarTransporte();
                foreach (var trans in query)
                {
                    TransporteBE objTransporteBE = new TransporteBE();
                    objTransporteBE.IDTransporte = trans.IDTransporte;
                    objTransporteBE.Razon_Social = trans.Razon_Social;
                    objTransporteBE.Nombre = trans.Nombre;
                    objTransporteBE.Modelo = trans.Modelo;
                    objTransporteBE.Placa = trans.Placa;
                    objTransporteBE.TarjetaProp = trans.TarjetaProp;

                    objListarTransporte.Add(objTransporteBE);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objListarTransporte;
        }

        public bool InsertarTransporte(TransporteBE objTransporteBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Transporte objTransporte = new tb_Transporte();

                objTransporte.IDTransporte = String.Empty;
                objTransporte.IDChofer = objTransporteBE.IDChofer;
                objTransporte.IDMarca = objTransporteBE.IDMarca;
                objTransporte.Modelo = objTransporteBE.Modelo;
                objTransporte.Placa = objTransporteBE.Placa;
                objTransporte.TarjetaProp = objTransporteBE.TarjetaProp;

                MisCargos.tb_Transporte.Add(objTransporte);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool ActualizarTransporte(TransporteBE objTransporteBE)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Transporte objTransporte = (from trans in MisCargos.tb_Transporte
                                               where trans.IDTransporte == objTransporteBE.IDTransporte
                                               select trans).FirstOrDefault();

                objTransporte.IDChofer = objTransporteBE.IDChofer;
                objTransporte.IDMarca = objTransporteBE.IDMarca;
                objTransporte.Modelo = objTransporteBE.Modelo;
                objTransporte.Placa = objTransporteBE.Placa;
                objTransporte.TarjetaProp = objTransporteBE.TarjetaProp;

                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public bool EliminarTransporte(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            try
            {
                tb_Transporte objTransporte = (from trans in MisCargos.tb_Transporte
                                               where trans.IDTransporte == strCodigo
                                               select trans).FirstOrDefault();

                MisCargos.tb_Transporte.Remove(objTransporte);
                MisCargos.SaveChanges();
                vexito = true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return vexito;
        }

        public TransporteBE ConsultarTransporte(String strCodigo)
        {
            EmpresaCargoCourierEntities MisCargos = new EmpresaCargoCourierEntities();
            TransporteBE objTransporteBE = new TransporteBE();

            try
            {
                var query = MisCargos.ConsultarTransporte(strCodigo);
                foreach (var trans in query)
                {
                    objTransporteBE.IDTransporte = trans.IDTransporte;
                    objTransporteBE.IDChofer = trans.IDChofer;
                    objTransporteBE.IDMarca = trans.IDMarca;
                    objTransporteBE.Modelo = trans.Modelo;
                    objTransporteBE.Placa = trans.Placa;
                    objTransporteBE.TarjetaProp = trans.TarjetaProp;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            return objTransporteBE;
        }
    }
}
