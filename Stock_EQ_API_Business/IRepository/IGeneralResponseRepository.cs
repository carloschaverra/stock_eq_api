
using Stock_EQ_API_Business.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_EQ_API_Business.IRepository
{
    public interface IGeneralResponseRepository
    {
        public GeneralResponse getError(Exception exception);
        public GeneralResponse getOK(object resultData);
        public GeneralResponse getErrorValidation(string mensaje);
    }
}
