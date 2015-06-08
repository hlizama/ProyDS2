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
    public class TipoServicioBL
    {
        TipoServicioADO objTServicioADO = new TipoServicioADO();

        public List<TipoServicioBE> ListarTipoServicio()
        {
            return objTServicioADO.ListarTipoServicio();
        }

        public Boolean InsertarTipoServicio(TipoServicioBE objTServiBE)
        {
            return objTServicioADO.InsertarTipoServicio(objTServiBE);
        }

        public Boolean ActualizarTipoServicio(TipoServicioBE objTServi)
        {
            return objTServicioADO.ActualizarTipoServicio(objTServi);
        }

        public Boolean EliminarTipoServicio(String strCodigo)
        {
            return objTServicioADO.EliminarTipoServicio(strCodigo);
        }

        public TipoServicioBE ConsultarTipoServicio(String strCodigo)
        {
            return objTServicioADO.ConsultarTipoServicio(strCodigo);
        }
    }
}
