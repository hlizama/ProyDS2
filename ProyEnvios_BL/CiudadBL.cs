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
    public class CiudadBL
    {
        CiudadADO objCiudadADO = new CiudadADO();

        public List<CiudadBE> ListarCiudad()
        {
            return objCiudadADO.ListarCiudad();
        }

        public Boolean InsertarCiudad(CiudadBE objciudadBE)
        {
            return objCiudadADO.InsertarCiudad(objciudadBE);
        }

        public Boolean ActualizarCiudad(CiudadBE objciudadBE)
        {
            return objCiudadADO.ActualizarCiudad(objciudadBE);
        }

        public Boolean EliminarCiudad(String strCodigo)
        {
            return objCiudadADO.EliminarCiudad(strCodigo);
        }

        public CiudadBE ConsultarCuidad(String strCodigo)
        {
            return objCiudadADO.ConsultarCiudad(strCodigo);
        }
    }
}
