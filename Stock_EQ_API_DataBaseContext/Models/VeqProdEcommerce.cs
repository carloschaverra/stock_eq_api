using System;
using System.Collections.Generic;

#nullable disable

namespace Stock_EQ_API_DataBaseContext.Models
{
    public partial class VeqProdEcommerce
    {
        public long ProdIdproducto { get; set; }
        public string Sku { get; set; }
        public string CentroOperativo { get; set; }
        public double? Precio { get; set; }
        public double? Iva { get; set; }
        public string Nombre { get; set; }
        public double Disponible { get; set; }
        public string Bodega { get; set; }
        public string IdEmpresa { get; set; }
        public string IdCentroOperativo { get; set; }
        public string IdLista { get; set; }
        public string Moneda { get; set; }
        public string DescripcionEcommerce { get; set; }
    }
}
