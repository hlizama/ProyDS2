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
    public class TipoCargoBL
    {
        TipoCargoADO objTipoCargoADO = new TipoCargoADO();

        public List<TipoCargoBE> ListarTipoCargo()
        {
            return objTipoCargoADO.ListarTipoCargo();
        }

        public Boolean InsertarTipoCargo(TipoCargoBE objTipoCargoBE)
        {
            return objTipoCargoADO.InsertarTipoCargo(objTipoCargoBE);
        }

        public Boolean ActualizarTipoCargo(TipoCargoBE objTipoCargoBE)
        {
            return objTipoCargoADO.ActualizarTipoCargo(objTipoCargoBE);
        }

        public Boolean EliminarTipoCargo(String strCodigo)
        {
            return objTipoCargoADO.EliminarTipoCargo(strCodigo);
        }

        public TipoCargoBE ConsultarTipoCargo(String strCodigo)
        {
            return objTipoCargoADO.ConsultarTipoCargo(strCodigo);
        }
    }
}
