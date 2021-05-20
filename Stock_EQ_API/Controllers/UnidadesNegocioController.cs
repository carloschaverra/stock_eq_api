using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock_EQ_API_DataBaseContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_EQ_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadesNegocioController : ControllerBase
    {
        private readonly PRUEBAS_APIContext _context;

        public UnidadesNegocioController(PRUEBAS_APIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<LabUnidadnegocio> GetDepartamentos()
        {
            return _context.LabUnidadesNegocio.Take(50).ToList();
        }

        [HttpGet("{id}")]
        public LabUnidadnegocio GetDepartamento(string id)
        {
            return _context.LabUnidadesNegocio.Find(id);
        }
    }
}
