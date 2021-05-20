using Stock_EQ_API_DataBaseContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_EQ_API_Business.IRepository
{
    public interface IProductRepository
    {
        public IEnumerable<VeqProdEcommerce> GetAll();
        public IAsyncEnumerable<VeqProdEcommerce> GetAllAsync();
        public VeqProdEcommerce FindProduct(VeqProdEcommerce oProduct);
        public VeqProdEcommerce FindProductAsync(VeqProdEcommerce oProduct);

    }
}
