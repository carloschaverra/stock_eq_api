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
    public class DepartamentosController : ControllerBase
    {
        private readonly PRUEBAS_APIContext _context;

        public DepartamentosController(PRUEBAS_APIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<SammDepartamento> GetDepartamentos()
        {
            return _context.SammDepartamentos.ToList();
        }

        [HttpGet("{id}")]
        public SammDepartamento GetDepartamento(string id)
        {
            return _context.SammDepartamentos.Find(id);
        }
    }
}
