using System;
using System.Collections.Generic;

#nullable disable

namespace Stock_EQ_API_DataBaseContext.Models
{
    public partial class SammEmpresa
    {
        public string SaemNit { get; set; }
        public string SaemNombre { get; set; }
        public string SaemResoluciondian { get; set; }
        public DateTime? SaemFresolucion { get; set; }
        public string SaemNfacturaini { get; set; }
        public string SaemNfacturafin { get; set; }
        public string SaemNitverdadero { get; set; }
        public string SaemPrefijo { get; set; }
        public string SaemLogoempresa { get; set; }
        public double? SaemCostohhtandar { get; set; }
        public string SaemTiporegimen { get; set; }
        public string SaemTextoresolucion { get; set; }
        public string SaemTextocuenta { get; set; }
    }
}
