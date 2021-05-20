using Stock_EQ_API_DataBaseContext.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_EQ_API_Business.IRepository
{
    interface IClientes
    {
        public void GetClientes(ClienteRQ cliente);
    }
}
