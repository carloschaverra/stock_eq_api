using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_EQ_API_DataBaseContext.Requests
{
    public class DocumentoRQ
    {
        public string Prefijo { get; set; }
        public string IdEmpresa { get; set; }
        public long Tercero { get; set; }
        public long Sucursal { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Moneda { get; set; }
        public string Prioridad { get; set; }
        public long Creador { get; set; }
        public DateTime? FechaCompromiso { get; set; }
        public double Subtotal { get; set; }
        public string DepartamentoAsignado { get; set; }
        public double Total { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string Bodega { get; set; }
        public string FormaPago { get; set; }
        public double Descuento { get; set; }
        public double Descuento_ME { get; set; }
        public string DocumentoTercero { get; set; }
        public double ImpuestoMAS { get; set; }
        public double ImpuestoMAS_ME { get; set; }
        public double ImpuestoMENOS { get; set; }
        public double ImpuestoMENOS_ME { get; set; }
        public int NumeroDecimales_ME { get; set; }
        public double PorcentajeDescuento { get; set; }
        public double TotalME { get; set; }
        public double TotalImpuesto { get; set; }
        public int TotalImpuestoME { get; set; }
        public double ValorTRM { get; set; }
        public double SubtotalME { get; set; }
        public long IdAsesor { get; set; }
        public string IdListaPrecio { get; set; }
        public bool DescuentotoItem { get; set; }
        public bool AplicaIva { get; set; }
        public double CostoTotal { get; set; }
        public string IdMedioPago { get; set; }
        public string DireccionEntrega { get; set; }
        public long CiudadEntrega { get; set; }
        public string IdCentroOperativo { get; set; }
        public long IdUsuarioModifica { get; set; }
        public string EmailCliente { get; set; }
        public List<DocumentoItemRQ> Items { get; set; }
    }
}
