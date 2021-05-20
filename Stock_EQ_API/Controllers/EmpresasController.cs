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
    public class EmpresasController : ControllerBase
    {
        private readonly PRUEBAS_APIContext _context;

        public EmpresasController(PRUEBAS_APIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<SammEmpresa> GetEmpresas()
        {
            return _context.SammEmpresas.Take(3).ToList();
        }

        [HttpGet("{id}")]
        public SammEmpresa GetEmpresas(string id)
        {
            return _context.SammEmpresas.Find(id);
        }
    }
}
