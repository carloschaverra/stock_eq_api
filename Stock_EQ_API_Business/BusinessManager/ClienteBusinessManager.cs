using Stock_EQ_API_Business.IRepository;
using Stock_EQ_API_Business.Repository;
using Stock_EQ_API_Business.Response;
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
        public GeneralResponse GetClientes(ClienteRQ cliente)
        {
            IGeneralResponseRepository generalResponseRepository = new GeneralResponseRespository();
            IClientesRepository clientesRepository;
            GeneralResponse generalResponse;
            object oResponse;

            try
            {
                clientesRepository = new ClientesRepository();
                oResponse = clientesRepository.GetClientes(cliente);
                if (oResponse != null)
                {
                    generalResponse = generalResponseRepository.getOK(oResponse);
                }
                else
                {
                    generalResponse = generalResponseRepository.getErrorValidation("¡La búsqueda no obtuvo resultados!");
                }
            }
            catch (Exception ex)
            {
                generalResponse = generalResponseRepository.getError(ex);
                throw;
            }

            return generalResponse;
        }
    }
}
