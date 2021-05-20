using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_EQ_API_DataBaseContext.Models
{
    public class Cliente
    {
        public int TipoPersona { get; set; }
        public string TipoDoc { get; set; }
        public string NumeroDoc { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string NombreCorto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string IdPais { get; set; }
        public string IdDepartamento { get; set; }
        public string IdCiudad { get; set; }
        public string Email { get; set; }
    }
}
