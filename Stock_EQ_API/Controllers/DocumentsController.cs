using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Stock_EQ_API_Business.BusinessManager;
using Stock_EQ_API_DataBaseContext.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_EQ_API.Controllers
{
    [Route("api/v1/[controller]")]
    public class DocumentsController : Controller
    {
        private readonly ILogger<DocumentsController> _logger;

        public DocumentsController(ILogger<DocumentsController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult CreateDocument([FromBody] DocumentoRQ request)
        {
            DocumentoBusinessManager documentoBusinessManager = new DocumentoBusinessManager();
            try
            {
                _logger.LogTrace("> Inicia ejecución");
                return Ok(documentoBusinessManager.CreateDocument(request));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

    }
}
