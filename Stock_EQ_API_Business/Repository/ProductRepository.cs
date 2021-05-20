using Stock_EQ_API_Business.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock_EQ_API_DataBaseContext.Models;

namespace Stock_EQ_API_Business.Repository
{
    public class ProductRepository : IProductRepository
    {
     
        
        public VeqProdEcommerce FindProduct(VeqProdEcommerce oProduct)
        {
            throw new NotImplementedException();
        }

        public VeqProdEcommerce FindProductAsync(VeqProdEcommerce oProduct)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VeqProdEcommerce> GetAll()
        {
            PRUEBAS_APIContext context;
            List<VeqProdEcommerce> productos = new List<VeqProdEcommerce>();
            try
            {
                context = new PRUEBAS_APIContext();
                productos = context.VeqProdEcommerces.Take(1000).ToList(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return productos;
        }

        public IAsyncEnumerable<VeqProdEcommerce> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
