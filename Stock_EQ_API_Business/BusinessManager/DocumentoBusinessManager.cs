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
    public class DocumentoBusinessManager
    {
        public GeneralResponse CreateDocument(DocumentoRQ documentoRQ)
        {
            IGeneralResponseRepository generalResponseRepository = new GeneralResponseRespository();
            IDocumentoRepository documentoRepository;
            GeneralResponse generalResponse;
            int iResult = int.MinValue;
            try
            {
                documentoRepository = new DocumentoRepository();
                iResult = documentoRepository.CreateDocument(documentoRQ);

                if (iResult > 0)
                {
                    generalResponse = generalResponseRepository.getOK(iResult);
                }
                else if (iResult == 0)
                {
                    generalResponse = generalResponseRepository.getErrorValidation("¡No se creó el documento!");
                }
                else
                {
                    generalResponse = generalResponseRepository.getErrorValidation("¡Ha ocurrido un error al guardar el documento!");
                }
            }
            catch (Exception ex)
            {
                generalResponse = generalResponseRepository.getError(ex);
                throw;
            }

            return generalResponse;
        }


       
        // public async Task<GeneralResponse> UpdateStockAsync(StockRQ stockRQ)
        // {
        //    IGeneralResponseRepository generalResponseRepository = new GeneralResponseRespository();
        //     IDocumentoRepository documentoRepository;
        //     GeneralResponse generalResponse;
        //     int iResult = int.MinValue;
        //     try
        //     {
        //         documentoRepository = new DocumentoRepository();
        //         iResult = documentoRepository.CreateDocument(documentoRQ);

        //         if (iResult > 0)
        //         {
        //             generalResponse = generalResponseRepository.getOK(iResult);
        //         }
        //         else if (iResult == 0)
        //         {
        //             generalResponse = generalResponseRepository.getErrorValidation("¡No se creó el documento!");
        //         }
        //         else
        //         {
        //             generalResponse = generalResponseRepository.getErrorValidation("¡Ha ocurrido un error al guardar el documento!");
        //         }
        //     }
        //     catch (Exception ex)
        //     {
        //         generalResponse = generalResponseRepository.getError(ex);
        //         throw;
        //     }

        //     return generalResponse;
        // }

    }
}
