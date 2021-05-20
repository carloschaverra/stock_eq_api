using System;
using System.Collections.Generic;

#nullable disable

namespace Stock_EQ_API_DataBaseContext.Models
{
    public partial class LabCentrocosto
    {
        public string LbccIdcentrocosto { get; set; }
        public string LbccNombre { get; set; }
        public string LbccIdpadre { get; set; }
        public bool? LbccEsdistribuido { get; set; }
        public string LbccCodalterno { get; set; }
        public double? LbccAreametros { get; set; }
        public int? LbccNpersonas { get; set; }
        public int? LbccNusuarios { get; set; }
        public double? LbccUnidprod { get; set; }
        public double? LbccKgprod { get; set; }
        public int? LbccNextensiones { get; set; }
        public double? LbccVentareal { get; set; }
        public double? LbccVentapresupuestada { get; set; }
        public string LbccIdempresa { get; set; }
    }
}
