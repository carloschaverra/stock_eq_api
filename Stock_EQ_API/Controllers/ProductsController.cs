using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Stock_EQ_API_Business.BusinessManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_EQ_API.Controllers
{
    [Route("api/v1/[controller]")]
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult getAll()
        {
            ProductBusinessManager productBusinessManager = new ProductBusinessManager();
            try
            {
                _logger.LogTrace("> Inicia ejecución");
                return Ok(productBusinessManager.getAllProducts());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                return StatusCode(500, productBusinessManager.getAllProducts());
            }
        }

        //[HttpGet]
        //public async Task<IActionResult> getAllAsync()
        //{
        //    ProductBusinessManager productBusinessManager = new ProductBusinessManager();
        //    try
        //    {
        //        _logger.LogTrace("> Inicia ejecución");
        //        return await Ok(productBusinessManager.getAllProducts());
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError($"Error: {ex.Message}");
        //        return StatusCode(500, productBusinessManager.getAllProducts());
        //    }
        //}

    }
}
