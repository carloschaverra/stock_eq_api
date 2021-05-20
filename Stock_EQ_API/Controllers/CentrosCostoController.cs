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
    public class CentrosCostoController : ControllerBase
    {
        private readonly PRUEBAS_APIContext _context;

        public CentrosCostoController(PRUEBAS_APIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<LabCentrocosto> GetCentros()
        {
            return _context.LabCentrocostos.Take(50).ToList();
        }

        [HttpGet("{id}")]
        public LabCentrocosto GetCentro(string id)
        {
            return _context.LabCentrocostos.Find(id);
        }
    }
}
