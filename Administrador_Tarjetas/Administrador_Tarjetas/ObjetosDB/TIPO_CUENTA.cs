//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Administrador_Tarjetas.ObjetosDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPO_CUENTA
    {
        public decimal ID_TIPO_CUENTA { get; set; }
        public string TIPO_CUENTA1 { get; set; }
        public Nullable<decimal> TASA_INTERES_DIARIA { get; set; }
        public Nullable<decimal> TASA_MORA { get; set; }
        public Nullable<decimal> DIAS_PAGO_MINIMO { get; set; }
        public Nullable<decimal> DIAS_PAGO_CONTADO { get; set; }
        public Nullable<decimal> DIA_CORTE { get; set; }
        public Nullable<decimal> COMISION_RETIRO { get; set; }
        public Nullable<decimal> COMISION_ADMINISTRACION { get; set; }
        public Nullable<decimal> MESES_FINANCIACION { get; set; }
    }
}
