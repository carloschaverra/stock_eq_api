using System;
using System.Collections.Generic;

#nullable disable

namespace Stock_EQ_API_DataBaseContext.Models
{
    public partial class SammDepartamento
    {
        public string SmdpIddepartamento { get; set; }
        public string SmdpIdempresa { get; set; }
        public string SmdpNombre { get; set; }
        public string SmdpIdpadre { get; set; }
        public bool? SmdpOtexternas { get; set; }
        public long? SmdpIdmanoobradefault { get; set; }
        public string SmdpBodegarepuestos { get; set; }
        public string SmdpBodegafacturacion { get; set; }
        public string SmdpIdcentrocosto { get; set; }
        public string SmdpIdmedioot { get; set; }
        public int? SmdpDiasvencereserva { get; set; }
    }
}
