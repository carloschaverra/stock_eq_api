using Stock_EQ_API_DataBaseContext.Requests;
using System.Collections.Generic;
using Stock_EQ_API_DataBaseContext.Models;
using Stock_EQ_API_DTO.DTOs;

namespace Stock_EQ_API_Business.IRepository
{
    public interface IClientesRepository
    {
        public ClienteRS GetClientes(ClienteRQ cliente);
    }
}
