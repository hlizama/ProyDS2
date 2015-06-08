using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyEnvios_ADO;
using ProyEnvios_BE;

namespace ProyEnvios_BL
{
    public class MarcaBL
    {
        MarcaADO objMarcaADO = new MarcaADO();

        public List<MarcaBE> ListarMarca()
        {
            return objMarcaADO.ListarMarca();
        }

        public Boolean InsertarMarca(MarcaBE objmarcaBE)
        {
            return objMarcaADO.InsertarMarca(objmarcaBE);
        }

        public Boolean ActualizarMarca(MarcaBE objmarcaBE)
        {
            return objMarcaADO.ActualizarMarca(objmarcaBE);
        }

        public Boolean EliminarMarca(String strCodigo)
        {
            return objMarcaADO.EliminarMarca(strCodigo);
        }

        public MarcaBE ConsultarMarca(String strCodigo)
        {
            return objMarcaADO.ConsultarMarca(strCodigo);
        }
    }
}
