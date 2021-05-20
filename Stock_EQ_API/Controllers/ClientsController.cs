using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stock_EQ_API_DataBaseContext.Models;
using Stock_EQ_API_DataBaseContext.Requests;
using Stock_EQ_API_Business.BusinessManager;

namespace Stock_EQ_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly PRUEBAS_APIContext _context;

        public ClientsController(PRUEBAS_APIContext context)
        {
            _context = context;
        }

        // GET: api/v1/clients
        [HttpGet]
        public IActionResult GetClientes([FromBody] ClienteRQ request)
        {
            ClienteBusinessManager clienteBusinessManager = new ClienteBusinessManager();
            try
            {
                return Ok(clienteBusinessManager.GetClientes(request));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        // GET: api/v1/clients
        [HttpPost]
        public string InsertClient(Cliente cliente)
        {
            try
            {
                ServiceReference.ClientesClient clientes = new ServiceReference.ClientesClient();
                var respuesta = clientes.CrearCLientePOSAsync(
                                                        cliente.TipoPersona,
                                                        cliente.TipoDoc,
                                                        cliente.NumeroDoc,
                                                        cliente.Nombres,
                                                        cliente.Apellido1,
                                                        cliente.Apellido2,
                                                        cliente.NombreCorto,
                                                        cliente.Direccion,
                                                        cliente.Telefono,
                                                        cliente.IdPais,
                                                        cliente.IdDepartamento,
                                                        cliente.IdCiudad,
                                                        cliente.Email);

                TrcTercero labroidesCliente = new TrcTercero();

                labroidesCliente.TercIdtipopersona = cliente.TipoPersona.ToString();
                labroidesCliente.TercIdtipodocumento = cliente.TipoDoc;
                labroidesCliente.TercNit = cliente.NumeroDoc;
                labroidesCliente.TercNombre = cliente.Nombres;
                labroidesCliente.TercApellido1 = cliente.Apellido1;
                labroidesCliente.TercApellido2 = cliente.Apellido2;
                labroidesCliente.TercDireccion = cliente.Direccion;
                labroidesCliente.TercTelefono = cliente.Telefono;
                labroidesCliente.TercIdpais = cliente.IdPais;
                labroidesCliente.TercIddepartamento = cliente.IdDepartamento;
                labroidesCliente.TercIdciudad = cliente.IdCiudad;
                labroidesCliente.TercMail = cliente.Email;
                labroidesCliente.TercCodigo = cliente.NumeroDoc;
                labroidesCliente.TercIdestado = "AC";
                labroidesCliente.TercEstercero = true;
                labroidesCliente.TercIdmoneda = "COP";
                labroidesCliente.TercDv = null;
                labroidesCliente.TercNombrenatural = cliente.NombreCorto;
                labroidesCliente.CliIdformapago = "CON";
                labroidesCliente.TercIdtipoclientefactura = null;

                _context.TrcTerceros.Add(labroidesCliente);
                _context.SaveChanges();

                return "El cliente ha sido creado correctamente";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
