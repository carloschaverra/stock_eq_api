using Stock_EQ_API_Business.IRepository;
using Stock_EQ_API_DataBaseContext.Requests;
using Stock_EQ_API_DataBaseContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Stock_EQ_API_DTO.DTOs;

namespace Stock_EQ_API_Business.Repository
{
    public class ClientesRepository : IClientesRepository
    {
        public ClienteRS GetClientes(ClienteRQ cliente)
        {
            PRUEBAS_APIContext context;
            TrcTercero terceroPadre;
            List<TrcTercero> terceroHijos;
            ClienteRS dRespuesta;
            try
            {
                context = new PRUEBAS_APIContext();
                dRespuesta = new ClienteRS();
                terceroPadre = context.TrcTerceros.Where(p => p.TercNit.Equals(cliente.Documento)).FirstOrDefault();
                
                if (terceroPadre != null && terceroPadre.TercIdtercero > 0) 
                {
                    dRespuesta.Parent = MappObject(terceroPadre);
                    terceroHijos = new List<TrcTercero>();                    
                    terceroHijos = context.TrcTerceros.Where(p => p.TercIdpadre.Equals(terceroPadre.TercIdtercero)).ToList();

                    foreach (TrcTercero item in terceroHijos)
                        dRespuesta.childs.Add(MappObject(item));
                }
                return dRespuesta;
            }
            catch (Exception)
            {
                 throw;
            }
        }

        private TercerosRS MappObject(TrcTercero trcTercero)
        {
            TercerosRS tercerosRS = new TercerosRS();
            
            tercerosRS.IdTercero = trcTercero.TercIdtercero;
            tercerosRS.Nit = trcTercero.TercNit;
            tercerosRS.Nombre = trcTercero.TercNombre;
            tercerosRS.Codigo = trcTercero.TercCodigo;
            tercerosRS.Ciudad = trcTercero.TercIdciudad;
            tercerosRS.Direccion = trcTercero.TercDireccion;
            tercerosRS.Telefono = trcTercero.TercTelefono;
            tercerosRS.Mail = trcTercero.TercMail;
            tercerosRS.IdEstado = trcTercero.TercIdestado;
            tercerosRS.EsCliente = trcTercero.TercEscliente.HasValue;
            tercerosRS.EsProveedor = trcTercero.TercEsproveedor;
            tercerosRS.EsUsuario = trcTercero.TercEsusuario;
            tercerosRS.IdPais = trcTercero.TercIdpais;
            tercerosRS.IdDepartamento = trcTercero.TercIddepartamento;
            tercerosRS.IdMoneda = trcTercero.TercIdmoneda;
            tercerosRS.IdTipopersona = trcTercero.TercIdtipopersona;
            tercerosRS.IdTipodocumento = trcTercero.TercIdtipodocumento;
            tercerosRS.Dv = trcTercero.TercDv;
            tercerosRS.Apellido1 = trcTercero.TercApellido1;
            tercerosRS.Apellido2 = trcTercero.TercApellido2;
            tercerosRS.NombreNatural = trcTercero.TercNombrenatural;
            tercerosRS.IdFormaPago = trcTercero.CliIdformapago;

            return tercerosRS;
        }
    }
}
