using Stock_EQ_API_DataBaseContext.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_EQ_API_Business.BusinessManager
{
    public class ClienteBusinessManager
    {
        public object GetClientes(ClienteRQ cliente)
        {
            ServiceReference1.ConsultaClient consultarCliente = new ServiceReference1.ConsultaClient();
            var objeto = consultarCliente.GetClientesAsync(cliente.Documento, cliente.RazonSocial);

            return objeto;
        }
    }
}
