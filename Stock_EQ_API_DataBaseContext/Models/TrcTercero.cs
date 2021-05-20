using System;
using System.Collections.Generic;

#nullable disable

namespace Stock_EQ_API_DataBaseContext.Models
{
    public partial class TrcTercero
    {
        public TrcTercero()
        {
            InverseTercIdpadreNavigation = new HashSet<TrcTercero>();
        }

        public long TercIdtercero { get; set; }
        public string TercNit { get; set; }
        public string TercNombre { get; set; }
        public string TercCodigo { get; set; }
        public string TercIdciudad { get; set; }
        public string TercDireccion { get; set; }
        public string TercTelefono { get; set; }
        public string TercFax { get; set; }
        public string TercMail { get; set; }
        public string TercIdestado { get; set; }
        public string TercNotas { get; set; }
        public DateTime? TercFechaingreso { get; set; }
        public bool? TercEscliente { get; set; }
        public bool TercEsusuario { get; set; }
        public bool TercEsproveedor { get; set; }
        public bool TercEstrasportador { get; set; }
        public bool TercEspotencial { get; set; }
        public bool TercEssucursal { get; set; }
        public bool TercEstercero { get; set; }
        public bool TercEsvirtual { get; set; }
        public long? TercIdpadre { get; set; }
        public bool? Actuweb { get; set; }
        public bool? Creaweb { get; set; }
        public string TercClave { get; set; }
        public bool? TercEsdistribuidor { get; set; }
        public string TercFoto { get; set; }
        public long? TercIdtercefactura { get; set; }
        public string TercIdcentrocosto { get; set; }
        public string TercIdempresa { get; set; }
        public bool? TercMultiempresa { get; set; }
        public long? TercIdusucrea { get; set; }
        public DateTime? TercFcreacion { get; set; }
        public long? TercIdusuactualiza { get; set; }
        public DateTime? TercFactualizacion { get; set; }
        public long? TercIddistribuidor { get; set; }
        public long? TercIdintermediario { get; set; }
        public bool TercEliminado { get; set; }
        public string TercIdtipocliente { get; set; }
        public string UsuIdcargo { get; set; }
        public bool? UsuVenceclave { get; set; }
        public DateTime? UsuFultimocambio { get; set; }
        public int? UsuDiascambio { get; set; }
        public bool? UsuDebecambiar { get; set; }
        public string UsuIdturno { get; set; }
        public string UsuIdperfil { get; set; }
        public int? ParNminutos { get; set; }
        public int? ParTpemanencia { get; set; }
        public bool? ParIniciawindows { get; set; }
        public double? UsuCostohora { get; set; }
        public bool? PrusAlertaactiva { get; set; }
        public string PrusIdempresadefault { get; set; }
        public string UsuIdcop { get; set; }
        public DateTime? TercUltimagestion { get; set; }
        public DateTime? TercUltimaprogramacioncrm { get; set; }
        public double? CliCalificacion { get; set; }
        public double? CliCupocartera { get; set; }
        public double? CliTcartera { get; set; }
        public string TercWebsite { get; set; }
        public string TercRepresentante { get; set; }
        public long? CliIdasesor { get; set; }
        public string Canal { get; set; }
        public string CliIdlista { get; set; }
        public string CliIdtiporete { get; set; }
        public string CliIdregimen { get; set; }
        public string CliIdsector { get; set; }
        public string Zona { get; set; }
        public string TercIdgrupocontable { get; set; }
        public string TercIdpais { get; set; }
        public string TercIddepartamento { get; set; }
        public string TercIdmoneda { get; set; }
        public string TercIdtipopersona { get; set; }
        public string TercIdtipodocumento { get; set; }
        public string TercDv { get; set; }
        public string TercRazonbloqueo { get; set; }
        public string TercApellido1 { get; set; }
        public string TercApellido2 { get; set; }
        public string TercNombrenatural { get; set; }
        public string TercIdunidadnegocio { get; set; }
        public bool? TercLiquidaiva { get; set; }
        public string UsuIdarea { get; set; }
        public string CliIdformapago { get; set; }
        public string TercIdtipoclientefactura { get; set; }
        public string CliIdiva { get; set; }

        public virtual TrcTercero TercIdpadreNavigation { get; set; }
        public virtual ICollection<TrcTercero> InverseTercIdpadreNavigation { get; set; }
    }
}
