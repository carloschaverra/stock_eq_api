using System;


#nullable disable

namespace Stock_EQ_API_DataBaseContext.Models
{
    public partial class SpPedidoVentaInsertCompleto
    {
        private string prefijo;
        private long? numero;

        public string Prefijo 
        { 
            get => prefijo; 
            set => prefijo = value; 
        }
        public long? Numero 
        { 
            get => numero; 
            set => numero = value; 
        }
    }
}