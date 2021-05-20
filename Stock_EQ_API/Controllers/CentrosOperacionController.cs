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
    public class CentrosOperacionController : ControllerBase
    {
        private readonly PRUEBAS_APIContext _context;

        public CentrosOperacionController(PRUEBAS_APIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<LabCentrooperacion> GetCentros()
        {
            return _context.LabCentrooperacions.Take(50).ToList();
        }

        [HttpGet("{id}")]
        public LabCentrooperacion GetCentro(string id)
        {
            return _context.LabCentrooperacions.Find(id);
        }
    }
}
