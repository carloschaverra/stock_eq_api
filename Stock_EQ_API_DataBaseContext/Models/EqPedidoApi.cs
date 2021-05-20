using System;
using System.Collections.Generic;

#nullable disable

namespace Stock_EQ_API_DataBaseContext.Models
{
    public partial class EqPedidoApi
    {
        public long? Idproducto { get; set; }
        public string Idunidad { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public int? Iditempadre { get; set; }
        public string Prefijoorigen { get; set; }
        public long? Numeroorigen { get; set; }
        public int? Iditemorigen { get; set; }
        public double? Cantsolicitada { get; set; }
        public double? Cantrecibida { get; set; }
        public double? Vlrunit { get; set; }
        public double? Porcdto { get; set; }
        public double? Vlrdto { get; set; }
        public double? Subtotal { get; set; }
        public string Idimpuesto { get; set; }
        public double? Porciva { get; set; }
        public double? Vlriva { get; set; }
        public double? Total { get; set; }
        public double? Costounit { get; set; }
        public double? Costototal { get; set; }
        public bool? Mostrar { get; set; }
        public string Idestado { get; set; }
        public string Idbodega { get; set; }
        public string Idcentrocosto { get; set; }
        public DateTime? Fcalificacion { get; set; }
        public double? Vlrcalificacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Idtipo { get; set; }
        public long? Idmaquina { get; set; }
        public int? Calificacion { get; set; }
        public string Idbodegadest { get; set; }
        public double? Vlrrte { get; set; }
        public double? Totalconimpuesto { get; set; }
        public int? Idopcion { get; set; }
        public long? Idescala { get; set; }
        public double? Cantenoc { get; set; }
        public double? Cantcotiz { get; set; }
        public bool? Elegido { get; set; }
        public double? Cantprocesada { get; set; }
        public int? Ncotizaciones { get; set; }
        public double? SubtotalMe { get; set; }
        public double? DescuentoMe { get; set; }
        public double? TotalMe { get; set; }
        public double? ImpuestomasMe { get; set; }
        public double? ImpuestomenosMe { get; set; }
        public double? TotalconimpuestoMe { get; set; }
        public double? VlrunitMe { get; set; }
        public string Localizacion { get; set; }
        public string Tipomov { get; set; }
        public string Idlistaprecio { get; set; }
        public Guid IdProceso { get; set; }
        public int Id { get; set; }
    }
}
