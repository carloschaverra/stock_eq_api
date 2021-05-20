using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock_EQ_API_DataBaseContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_EQ_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PrefijosController : ControllerBase
    {
        private readonly PRUEBAS_APIContext _context;

        public PrefijosController(PRUEBAS_APIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<DocPrefijo> GetPrefijos()
        {
            return _context.DocPrefijos.Take(100).ToList();
        }

        [HttpGet("{id}")]
        public DocPrefijo GetPrefijos(string id)
        {
            return _context.DocPrefijos.Find(id);
        }
    }
}
