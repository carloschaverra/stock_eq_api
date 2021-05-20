using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_EQ_API_DataBaseContext.Requests
{
    public class DocumentoItemRQ
    {
        public long? IdProducto { get; set; }
        public string IdUnidad { get; set; }
        public string Descripcion { get; set; }
        public string Observacion { get; set; }
        public int? IdItemPadre { get; set; }
        public string PrefijoOrigen { get; set; }
        public long? NumeroOrigen { get; set; }
        public int? IdItemOrigen { get; set; }
        public double? CantSolicitada { get; set; }
        public double? CantidadRecibida { get; set; }
        public double? ValorUnitario { get; set; }
        public double? PorcentajeDescuento { get; set; }
        public double? ValorDcto { get; set; }
        public double? SubTotal { get; set; }
        public string IdImpuesto { get; set; }
        public double? PorcentajeIVA { get; set; }
        public double? ValorIVA { get; set; }
        public double? Total { get; set; }
        public double? CostoUnitario { get; set; }
        public double? CostoTotal { get; set; }
        public bool? Mostrar { get; set; }
        public string IdEstado { get; set; }
        public string IdBodega { get; set; }
        public string IdCentroCosto { get; set; }
        public DateTime? FCalificacion { get; set; }
        public double? ValorCalificacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string IdTipo { get; set; }
        public long? IdMaquina { get; set; }
        public int? Calificacion { get; set; }
        public string IdBodegaDestino { get; set; }
        public double? ValorRTE { get; set; }
        public double? TotalConImpuesto { get; set; }
        public int? IdOpcion { get; set; }
        public long? IdEscala { get; set; }
        public double? Cantenoc { get; set; }
        public double? CantidadCotizacion { get; set; }
        public bool? Elegido { get; set; }
        public double? CantidadProcesada { get; set; }
        public int? NumeroCotizaciones { get; set; }
        public double? SubTotalMe { get; set; }
        public double? DescuentoMe { get; set; }
        public double? TotalMe { get; set; }
        public double? ImpuestoMASMe { get; set; }
        public double? ImpuestoMenosMe { get; set; }
        public double? TotalConImpuestoMe { get; set; }
        public double? ValorUnitarioMe { get; set; }
        public string Localizacion { get; set; }
        public string TipoMovimiento { get; set; }
        public string IdListaPrecio { get; set; }
        public Guid IdProceso { get; set; }
    }
}
