using Stock_EQ_API_Business.IRepository;
using Stock_EQ_API_DataBaseContext.Requests;
using Stock_EQ_API_DataBaseContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_EQ_API_Business.Repository
{
    public class ClientesRepository : IClientesRepository
    {
        public Dictionary<TrcTercero, List<TrcTercero>> GetClientes(ClienteRQ cliente)
        {
            PRUEBAS_APIContext context;
            TrcTercero terceroPadre;
            List<TrcTercero> terceroHijos;
            Dictionary<TrcTercero, List<TrcTercero>> dRespuesta;
            try
            {
                context = new PRUEBAS_APIContext();
                dRespuesta = new Dictionary<TrcTercero, List<TrcTercero>>();
                terceroPadre = context.TrcTerceros.Where(p => p.TercNit.Equals(cliente.Documento)).FirstOrDefault();
                
                if (terceroPadre != null && terceroPadre.TercIdtercero > 0) 
                {
                    terceroHijos = new List<TrcTercero>();
                    terceroHijos = context.TrcTerceros.Where(p => p.TercIdpadre.Equals(terceroPadre.TercIdtercero)).ToList();
                    dRespuesta.Add(terceroPadre, terceroHijos);
                }
                else 
                {
                    dRespuesta.Add(new TrcTercero(), null);
                }
                return dRespuesta;
            }
            catch (Exception)
            {
                 throw;
            }
        }
    }
}
