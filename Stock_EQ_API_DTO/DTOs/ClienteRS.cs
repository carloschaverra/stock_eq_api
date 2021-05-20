using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_EQ_API_DTO.DTOs
{
    public class ClienteRS
    {
        public ClienteRS()
        {
            childs = new List<TercerosRS>();
        }

        public TercerosRS Parent { get; set; }
        public List<TercerosRS> childs { get; set; }
    }
}
