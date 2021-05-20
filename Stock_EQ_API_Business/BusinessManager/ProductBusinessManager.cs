using Stock_EQ_API_Business.IRepository;
using Stock_EQ_API_Business.Repository;
using Stock_EQ_API_Business.Response;
using Stock_EQ_API_DataBaseContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_EQ_API_Business.BusinessManager
{
    public class ProductBusinessManager
    {
        public GeneralResponse getAllProducts()
        {
            IGeneralResponseRepository generalResponseRepository = new GeneralResponseRespository();
            IProductRepository productRepository;
            IEnumerable<VeqProdEcommerce> productos;
            GeneralResponse generalResponse;
            try
            {
                productRepository = new ProductRepository();
                productos = productRepository.GetAll();
                if (productos.Count() > 0)
                {
                    generalResponse = generalResponseRepository.getOK(productos);
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

    //public async Task<GeneralResponse> getAllProductsAsync()
    //{
    //    IGeneralResponseRepository generalResponseRepository = new GeneralResponseRespository();
    //    IProductRepository productRepository;
    //    IEnumerable<Product> productos;
    //    GeneralResponse generalResponse;
    //    try
    //    {
    //        productRepository = new ProductRepository();
    //        productos = productRepository.GetAll();
    //        if (productos.Count() > 0)
    //        {
    //            generalResponse = generalResponseRepository.getOK(productos);
    //        }
    //        else
    //        {
    //            generalResponse = generalResponseRepository.getErrorValidation("¡La búsqueda no obtuvo resultados!");
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        generalResponse = generalResponseRepository.getError(ex);
    //        throw;
    //    }
    //    return generalResponse;
    //}
}



