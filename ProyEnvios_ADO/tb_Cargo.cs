//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyEnvios_ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Cargo
    {
        public string IDCargo { get; set; }
        public string IDTipoCargo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<double> Peso { get; set; }
        public string UnidadMedida { get; set; }
    
        public virtual tb_TipoCargo tb_TipoCargo { get; set; }
    }
}
