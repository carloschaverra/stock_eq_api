using Stock_EQ_API_DataBaseContext.Requests;
using System.Collections.Generic;
using Stock_EQ_API_DataBaseContext.Models;

namespace Stock_EQ_API_Business.IRepository
{
    public interface IClientesRepository
    {
        public Dictionary<TrcTercero, List<TrcTercero>> GetClientes(ClienteRQ cliente);
    }
}
