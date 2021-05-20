using Stock_EQ_API_Business.IRepository;
using Stock_EQ_API_Business.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_EQ_API_Business.BusinessManager
{
    public class GeneralResponseRespository : IGeneralResponseRepository
    {

        public GeneralResponse getError(Exception exception)
        {
            GeneralResponse oGeneralResponse = new GeneralResponse();
            oGeneralResponse.Code = -1;
            oGeneralResponse.Descripcion = exception.InnerException != null ? exception.InnerException.Message : string.Empty;
            oGeneralResponse.Mensaje = exception.Message != null ? exception.Message : "¡Ha ocurrido un error inesperado!";
            oGeneralResponse.ResultData = new object();
            oGeneralResponse.Fecha = DateTime.Now;
            return oGeneralResponse;
        }

        public GeneralResponse getErrorValidation(string mensaje)
        {
            GeneralResponse oGeneralResponse = new GeneralResponse();
            oGeneralResponse.Code = 0;
            oGeneralResponse.Descripcion = string.Empty;
            oGeneralResponse.Mensaje = mensaje;
            oGeneralResponse.ResultData = new object();
            oGeneralResponse.Fecha = DateTime.Now;
            return oGeneralResponse;
        }

        public GeneralResponse getOK(object resultData)
        {
            GeneralResponse oGeneralResponse = new GeneralResponse();
            oGeneralResponse.Code = 1;
            oGeneralResponse.Descripcion = string.Empty;
            oGeneralResponse.Mensaje = "¡El proceso se ha ejecutado correctamente!";
            oGeneralResponse.ResultData = resultData;
            oGeneralResponse.Fecha = DateTime.Now;
            return oGeneralResponse;
        }
    }
}
