using System;
using System.Collections.Generic;

#nullable disable

namespace Stock_EQ_API_DataBaseContext.Models
{
    public partial class DocPrefijo
    {
        public string DctpPrefijo { get; set; }
        public string DctpNombre { get; set; }
        public string DctpIdtipo { get; set; }
        public string DctpFormato { get; set; }
        public string DctpFormatofull { get; set; }
        public int? DctpPrecio { get; set; }
        public bool? DctpCalculaAui { get; set; }
        public bool? DctpSolmaquina { get; set; }
        public string DctpAnexodefault { get; set; }
        public long? DctpIdtempariodefault { get; set; }
        public bool? DctpPuedediagramar { get; set; }
        public string DctpIdflujo { get; set; }
        public bool? DctpVercliente { get; set; }
        public bool? DctpVersucursal { get; set; }
    }
}
