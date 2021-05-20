using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_EQ_API_DataBaseContext.Requests
{
    public class ClienteRQ
    {
        public string Documento { get; set; }
        public string RazonSocial { get; set; }
        public bool? EsCliente { get; set; }
        public bool? EsUsuario { get; set; }
        public bool? EsProveedor { get; set; }
    }
}
