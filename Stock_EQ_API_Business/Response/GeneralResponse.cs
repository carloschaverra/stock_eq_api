using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_EQ_API_Business.Response
{
    public class GeneralResponse
    {
        private int code;
        private string mensaje;
        private string descripcion;
        private DateTime fecha;
        private object resultData;

        public int Code
        {
            get => code;
            set => code = value;
        }
        public string Mensaje
        {
            get => mensaje;
            set => mensaje = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        public DateTime Fecha
        {
            get => fecha;
            set => fecha = value;
        }
        public object ResultData
        {
            get => resultData;
            set => resultData = value;
        }
    }
}
