using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Stock_EQ_API_DataBaseContext.Models
{
    public partial class PRUEBAS_APIContext : DbContext
    {
        public PRUEBAS_APIContext()
        {
        }

        public PRUEBAS_APIContext(DbContextOptions<PRUEBAS_APIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DocPrefijo> DocPrefijos { get; set; }
        public virtual DbSet<EqPedidoApi> EqPedidoApis { get; set; }
        public virtual DbSet<LabCentrocosto> LabCentrocostos { get; set; }
        public virtual DbSet<LabCentrooperacion> LabCentrooperacions { get; set; }
        public virtual DbSet<LabUnidadnegocio> LabUnidadnegocios { get; set; }
        public virtual DbSet<SammDepartamento> SammDepartamentos { get; set; }
        public virtual DbSet<SammEmpresa> SammEmpresas { get; set; }
        public virtual DbSet<TrcTercero> TrcTerceros { get; set; }
        public virtual DbSet<VeqProdEcommerce> VeqProdEcommerces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=172.16.100.14\\LAB;Database=PRUEBAS_API;User=labroides;Password=Labroides1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<DocPrefijo>(entity =>
            {
                entity.HasKey(e => e.DctpPrefijo)
                    .HasName("PK_DOC_TIPO");

                entity.ToTable("DOC_PREFIJO");

                entity.HasIndex(e => e.DctpIdtipo, "IX_DOC_PREFIJO");

                entity.Property(e => e.DctpPrefijo)
                    .HasMaxLength(10)
                    .HasColumnName("DCTP_PREFIJO");

                entity.Property(e => e.DctpAnexodefault)
                    .HasMaxLength(300)
                    .HasColumnName("DCTP_ANEXODEFAULT");

                entity.Property(e => e.DctpCalculaAui).HasColumnName("DCTP_CALCULA_AUI");

                entity.Property(e => e.DctpFormato)
                    .HasMaxLength(400)
                    .HasColumnName("DCTP_FORMATO");

                entity.Property(e => e.DctpFormatofull)
                    .HasMaxLength(400)
                    .HasColumnName("DCTP_FORMATOFULL");

                entity.Property(e => e.DctpIdflujo)
                    .HasMaxLength(50)
                    .HasColumnName("DCTP_IDFLUJO");

                entity.Property(e => e.DctpIdtempariodefault).HasColumnName("DCTP_IDTEMPARIODEFAULT");

                entity.Property(e => e.DctpIdtipo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("DCTP_IDTIPO");

                entity.Property(e => e.DctpNombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("DCTP_NOMBRE");

                entity.Property(e => e.DctpPrecio)
                    .HasColumnName("DCTP_PRECIO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DctpPuedediagramar).HasColumnName("DCTP_PUEDEDIAGRAMAR");

                entity.Property(e => e.DctpSolmaquina).HasColumnName("DCTP_SOLMAQUINA");

                entity.Property(e => e.DctpVercliente).HasColumnName("DCTP_VERCLIENTE");

                entity.Property(e => e.DctpVersucursal).HasColumnName("DCTP_VERSUCURSAL");
            });

            modelBuilder.Entity<EqPedidoApi>(entity =>
            {
                entity.ToTable("eqPedidoAPI");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Calificacion).HasColumnName("CALIFICACION");

                entity.Property(e => e.Cantcotiz).HasColumnName("CANTCOTIZ");

                entity.Property(e => e.Cantenoc).HasColumnName("CANTENOC");

                entity.Property(e => e.Cantprocesada).HasColumnName("CANTPROCESADA");

                entity.Property(e => e.Cantrecibida).HasColumnName("CANTRECIBIDA");

                entity.Property(e => e.Cantsolicitada).HasColumnName("CANTSOLICITADA");

                entity.Property(e => e.Costototal).HasColumnName("COSTOTOTAL");

                entity.Property(e => e.Costounit).HasColumnName("COSTOUNIT");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2000)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.DescuentoMe).HasColumnName("DESCUENTO_ME");

                entity.Property(e => e.Elegido).HasColumnName("ELEGIDO");

                entity.Property(e => e.Fcalificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FCALIFICACION");

                entity.Property(e => e.Fcreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FCREACION");

                entity.Property(e => e.Idbodega)
                    .HasMaxLength(50)
                    .HasColumnName("IDBODEGA");

                entity.Property(e => e.Idbodegadest)
                    .HasMaxLength(50)
                    .HasColumnName("IDBODEGADEST");

                entity.Property(e => e.Idcentrocosto)
                    .HasMaxLength(20)
                    .HasColumnName("IDCENTROCOSTO");

                entity.Property(e => e.Idescala).HasColumnName("IDESCALA");

                entity.Property(e => e.Idestado)
                    .HasMaxLength(10)
                    .HasColumnName("IDESTADO");

                entity.Property(e => e.Idimpuesto)
                    .HasMaxLength(5)
                    .HasColumnName("IDIMPUESTO");

                entity.Property(e => e.Iditemorigen).HasColumnName("IDITEMORIGEN");

                entity.Property(e => e.Iditempadre).HasColumnName("IDITEMPADRE");

                entity.Property(e => e.Idlistaprecio)
                    .HasMaxLength(5)
                    .HasColumnName("IDLISTAPRECIO");

                entity.Property(e => e.Idmaquina).HasColumnName("IDMAQUINA");

                entity.Property(e => e.Idopcion).HasColumnName("IDOPCION");

                entity.Property(e => e.Idproducto).HasColumnName("IDPRODUCTO");

                entity.Property(e => e.Idtipo)
                    .HasMaxLength(5)
                    .HasColumnName("IDTIPO");

                entity.Property(e => e.Idunidad)
                    .HasMaxLength(10)
                    .HasColumnName("IDUNIDAD");

                entity.Property(e => e.ImpuestomasMe).HasColumnName("IMPUESTOMAS_ME");

                entity.Property(e => e.ImpuestomenosMe).HasColumnName("IMPUESTOMENOS_ME");

                entity.Property(e => e.Localizacion)
                    .HasMaxLength(50)
                    .HasColumnName("LOCALIZACION");

                entity.Property(e => e.Mostrar).HasColumnName("MOSTRAR");

                entity.Property(e => e.Ncotizaciones).HasColumnName("NCOTIZACIONES");

                entity.Property(e => e.Numeroorigen).HasColumnName("NUMEROORIGEN");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .HasColumnName("OBSERVACIONES");

                entity.Property(e => e.Porcdto).HasColumnName("PORCDTO");

                entity.Property(e => e.Porciva).HasColumnName("PORCIVA");

                entity.Property(e => e.Prefijoorigen)
                    .HasMaxLength(10)
                    .HasColumnName("PREFIJOORIGEN");

                entity.Property(e => e.Subtotal).HasColumnName("SUBTOTAL");

                entity.Property(e => e.SubtotalMe).HasColumnName("SUBTOTAL_ME");

                entity.Property(e => e.Tipomov)
                    .HasMaxLength(10)
                    .HasColumnName("TIPOMOV");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.TotalMe).HasColumnName("TOTAL_ME");

                entity.Property(e => e.Totalconimpuesto).HasColumnName("TOTALCONIMPUESTO");

                entity.Property(e => e.TotalconimpuestoMe).HasColumnName("TOTALCONIMPUESTO_ME");

                entity.Property(e => e.Vlrcalificacion).HasColumnName("VLRCALIFICACION");

                entity.Property(e => e.Vlrdto).HasColumnName("VLRDTO");

                entity.Property(e => e.Vlriva).HasColumnName("VLRIVA");

                entity.Property(e => e.Vlrrte).HasColumnName("VLRRTE");

                entity.Property(e => e.Vlrunit).HasColumnName("VLRUNIT");

                entity.Property(e => e.VlrunitMe).HasColumnName("VLRUNIT_ME");
            });

            modelBuilder.Entity<LabCentrocosto>(entity =>
            {
                entity.HasKey(e => e.LbccIdcentrocosto);

                entity.ToTable("LAB_CENTROCOSTO");

                entity.Property(e => e.LbccIdcentrocosto)
                    .HasMaxLength(20)
                    .HasColumnName("LBCC_IDCENTROCOSTO");

                entity.Property(e => e.LbccAreametros).HasColumnName("LBCC_AREAMETROS");

                entity.Property(e => e.LbccCodalterno)
                    .HasMaxLength(50)
                    .HasColumnName("LBCC_CODALTERNO");

                entity.Property(e => e.LbccEsdistribuido).HasColumnName("LBCC_ESDISTRIBUIDO");

                entity.Property(e => e.LbccIdempresa)
                    .HasMaxLength(50)
                    .HasColumnName("LBCC_IDEMPRESA");

                entity.Property(e => e.LbccIdpadre)
                    .HasMaxLength(20)
                    .HasColumnName("LBCC_IDPADRE");

                entity.Property(e => e.LbccKgprod).HasColumnName("LBCC_KGPROD");

                entity.Property(e => e.LbccNextensiones).HasColumnName("LBCC_NEXTENSIONES");

                entity.Property(e => e.LbccNombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("LBCC_NOMBRE");

                entity.Property(e => e.LbccNpersonas).HasColumnName("LBCC_NPERSONAS");

                entity.Property(e => e.LbccNusuarios).HasColumnName("LBCC_NUSUARIOS");

                entity.Property(e => e.LbccUnidprod).HasColumnName("LBCC_UNIDPROD");

                entity.Property(e => e.LbccVentapresupuestada).HasColumnName("LBCC_VENTAPRESUPUESTADA");

                entity.Property(e => e.LbccVentareal).HasColumnName("LBCC_VENTAREAL");
            });

            modelBuilder.Entity<LabCentrooperacion>(entity =>
            {
                entity.HasKey(e => e.LbcoIdcentroperacion);

                entity.ToTable("LAB_CENTROOPERACION");

                entity.Property(e => e.LbcoIdcentroperacion)
                    .HasMaxLength(15)
                    .HasColumnName("LBCO_IDCENTROPERACION");

                entity.Property(e => e.LbcoDireccion)
                    .HasMaxLength(150)
                    .HasColumnName("LBCO_DIRECCION");

                entity.Property(e => e.LbcoNombre)
                    .HasMaxLength(50)
                    .HasColumnName("LBCO_NOMBRE");

                entity.Property(e => e.LbcoTelefono)
                    .HasMaxLength(80)
                    .HasColumnName("LBCO_TELEFONO");
            });

            modelBuilder.Entity<LabUnidadnegocio>(entity =>
            {
                entity.HasKey(e => e.LbunIdun);

                entity.ToTable("LAB_UNIDADNEGOCIO");

                entity.Property(e => e.LbunIdun)
                    .HasMaxLength(50)
                    .HasColumnName("LBUN_IDUN");

                entity.Property(e => e.LbunIdcentrooperaciones)
                    .HasMaxLength(20)
                    .HasColumnName("LBUN_IDCENTROOPERACIONES");

                entity.Property(e => e.LbunNombre)
                    .HasMaxLength(200)
                    .HasColumnName("LBUN_NOMBRE");
            });

            modelBuilder.Entity<SammDepartamento>(entity =>
            {
                entity.HasKey(e => e.SmdpIddepartamento);

                entity.ToTable("SAMM_DEPARTAMENTO");

                entity.Property(e => e.SmdpIddepartamento)
                    .HasMaxLength(10)
                    .HasColumnName("SMDP_IDDEPARTAMENTO");

                entity.Property(e => e.SmdpBodegafacturacion)
                    .HasMaxLength(50)
                    .HasColumnName("SMDP_BODEGAFACTURACION");

                entity.Property(e => e.SmdpBodegarepuestos)
                    .HasMaxLength(50)
                    .HasColumnName("SMDP_BODEGAREPUESTOS");

                entity.Property(e => e.SmdpDiasvencereserva).HasColumnName("SMDP_DIASVENCERESERVA");

                entity.Property(e => e.SmdpIdcentrocosto)
                    .HasMaxLength(20)
                    .HasColumnName("SMDP_IDCENTROCOSTO");

                entity.Property(e => e.SmdpIdempresa)
                    .HasMaxLength(15)
                    .HasColumnName("SMDP_IDEMPRESA");

                entity.Property(e => e.SmdpIdmanoobradefault).HasColumnName("SMDP_IDMANOOBRADEFAULT");

                entity.Property(e => e.SmdpIdmedioot)
                    .HasMaxLength(5)
                    .HasColumnName("SMDP_IDMEDIOOT");

                entity.Property(e => e.SmdpIdpadre)
                    .HasMaxLength(10)
                    .HasColumnName("SMDP_IDPADRE");

                entity.Property(e => e.SmdpNombre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("SMDP_NOMBRE");

                entity.Property(e => e.SmdpOtexternas)
                    .HasColumnName("SMDP_OTEXTERNAS")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SammEmpresa>(entity =>
            {
                entity.HasKey(e => e.SaemNit)
                    .HasName("PK_SAMM_EMPRESA_1");

                entity.ToTable("SAMM_EMPRESA");

                entity.Property(e => e.SaemNit)
                    .HasMaxLength(15)
                    .HasColumnName("SAEM_NIT");

                entity.Property(e => e.SaemCostohhtandar).HasColumnName("SAEM_COSTOHHTANDAR");

                entity.Property(e => e.SaemFresolucion)
                    .HasColumnType("datetime")
                    .HasColumnName("SAEM_FRESOLUCION");

                entity.Property(e => e.SaemLogoempresa)
                    .HasMaxLength(300)
                    .HasColumnName("SAEM_LOGOEMPRESA");

                entity.Property(e => e.SaemNfacturafin)
                    .HasMaxLength(10)
                    .HasColumnName("SAEM_NFACTURAFIN");

                entity.Property(e => e.SaemNfacturaini)
                    .HasMaxLength(10)
                    .HasColumnName("SAEM_NFACTURAINI");

                entity.Property(e => e.SaemNitverdadero)
                    .HasMaxLength(15)
                    .HasColumnName("SAEM_NITVERDADERO");

                entity.Property(e => e.SaemNombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("SAEM_NOMBRE");

                entity.Property(e => e.SaemPrefijo)
                    .HasMaxLength(5)
                    .HasColumnName("SAEM_PREFIJO");

                entity.Property(e => e.SaemResoluciondian)
                    .HasMaxLength(50)
                    .HasColumnName("SAEM_RESOLUCIONDIAN");

                entity.Property(e => e.SaemTextocuenta)
                    .HasMaxLength(800)
                    .HasColumnName("SAEM_TEXTOCUENTA");

                entity.Property(e => e.SaemTextoresolucion)
                    .HasMaxLength(800)
                    .HasColumnName("SAEM_TEXTORESOLUCION");

                entity.Property(e => e.SaemTiporegimen)
                    .HasMaxLength(20)
                    .HasColumnName("SAEM_TIPOREGIMEN");
            });

            modelBuilder.Entity<TrcTercero>(entity =>
            {
                entity.HasKey(e => e.TercIdtercero);

                entity.ToTable("TRC_TERCERO");

                entity.HasIndex(e => e.TercNit, "IX_TRC_TERCERO")
                    .IsUnique()
                    .HasFillFactor((byte)80);

                entity.Property(e => e.TercIdtercero).HasColumnName("TERC_IDTERCERO");

                entity.Property(e => e.Actuweb).HasColumnName("ACTUWEB");

                entity.Property(e => e.Canal).HasMaxLength(20);

                entity.Property(e => e.CliCalificacion).HasColumnName("CLI_CALIFICACION");

                entity.Property(e => e.CliCupocartera).HasColumnName("CLI_CUPOCARTERA");

                entity.Property(e => e.CliIdasesor).HasColumnName("CLI_IDASESOR");

                entity.Property(e => e.CliIdformapago)
                    .HasMaxLength(5)
                    .HasColumnName("CLI_IDFORMAPAGO");

                entity.Property(e => e.CliIdiva)
                    .HasMaxLength(5)
                    .HasColumnName("CLI_IDIVA");

                entity.Property(e => e.CliIdlista)
                    .HasMaxLength(5)
                    .HasColumnName("CLI_IDLISTA");

                entity.Property(e => e.CliIdregimen)
                    .HasMaxLength(2)
                    .HasColumnName("CLI_IDREGIMEN");

                entity.Property(e => e.CliIdsector)
                    .HasMaxLength(12)
                    .HasColumnName("CLI_IDSECTOR");

                entity.Property(e => e.CliIdtiporete)
                    .HasMaxLength(5)
                    .HasColumnName("CLI_IDTIPORETE");

                entity.Property(e => e.CliTcartera).HasColumnName("CLI_TCARTERA");

                entity.Property(e => e.Creaweb).HasColumnName("CREAWEB");

                entity.Property(e => e.ParIniciawindows).HasColumnName("PAR_INICIAWINDOWS");

                entity.Property(e => e.ParNminutos).HasColumnName("PAR_NMINUTOS");

                entity.Property(e => e.ParTpemanencia).HasColumnName("PAR_TPEMANENCIA");

                entity.Property(e => e.PrusAlertaactiva).HasColumnName("PRUS_ALERTAACTIVA");

                entity.Property(e => e.PrusIdempresadefault)
                    .HasMaxLength(15)
                    .HasColumnName("PRUS_IDEMPRESADEFAULT");

                entity.Property(e => e.TercApellido1)
                    .HasMaxLength(80)
                    .HasColumnName("TERC_APELLIDO1");

                entity.Property(e => e.TercApellido2)
                    .HasMaxLength(14)
                    .HasColumnName("TERC_APELLIDO2");

                entity.Property(e => e.TercClave)
                    .HasMaxLength(20)
                    .HasColumnName("TERC_CLAVE");

                entity.Property(e => e.TercCodigo)
                    .HasMaxLength(50)
                    .HasColumnName("TERC_CODIGO");

                entity.Property(e => e.TercDireccion)
                    .HasMaxLength(200)
                    .HasColumnName("TERC_DIRECCION");

                entity.Property(e => e.TercDv)
                    .HasMaxLength(3)
                    .HasColumnName("TERC_DV");

                entity.Property(e => e.TercEliminado).HasColumnName("TERC_ELIMINADO");

                entity.Property(e => e.TercEscliente)
                    .IsRequired()
                    .HasColumnName("TERC_ESCLIENTE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TercEsdistribuidor).HasColumnName("TERC_ESDISTRIBUIDOR");

                entity.Property(e => e.TercEspotencial).HasColumnName("TERC_ESPOTENCIAL");

                entity.Property(e => e.TercEsproveedor).HasColumnName("TERC_ESPROVEEDOR");

                entity.Property(e => e.TercEssucursal).HasColumnName("TERC_ESSUCURSAL");

                entity.Property(e => e.TercEstercero).HasColumnName("TERC_ESTERCERO");

                entity.Property(e => e.TercEstrasportador).HasColumnName("TERC_ESTRASPORTADOR");

                entity.Property(e => e.TercEsusuario).HasColumnName("TERC_ESUSUARIO");

                entity.Property(e => e.TercEsvirtual).HasColumnName("TERC_ESVIRTUAL");

                entity.Property(e => e.TercFactualizacion)
                    .HasColumnType("datetime")
                    .HasColumnName("TERC_FACTUALIZACION");

                entity.Property(e => e.TercFax)
                    .HasMaxLength(80)
                    .HasColumnName("TERC_FAX");

                entity.Property(e => e.TercFcreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("TERC_FCREACION");

                entity.Property(e => e.TercFechaingreso)
                    .HasColumnType("datetime")
                    .HasColumnName("TERC_FECHAINGRESO");

                entity.Property(e => e.TercFoto)
                    .HasMaxLength(300)
                    .HasColumnName("TERC_FOTO");

                entity.Property(e => e.TercIdcentrocosto)
                    .HasMaxLength(20)
                    .HasColumnName("TERC_IDCENTROCOSTO");

                entity.Property(e => e.TercIdciudad)
                    .HasMaxLength(20)
                    .HasColumnName("TERC_IDCIUDAD");

                entity.Property(e => e.TercIddepartamento)
                    .HasMaxLength(50)
                    .HasColumnName("TERC_IDDEPARTAMENTO");

                entity.Property(e => e.TercIddistribuidor).HasColumnName("TERC_IDDISTRIBUIDOR");

                entity.Property(e => e.TercIdempresa)
                    .HasMaxLength(15)
                    .HasColumnName("TERC_IDEMPRESA");

                entity.Property(e => e.TercIdestado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("TERC_IDESTADO");

                entity.Property(e => e.TercIdgrupocontable)
                    .HasMaxLength(50)
                    .HasColumnName("TERC_IDGRUPOCONTABLE");

                entity.Property(e => e.TercIdintermediario).HasColumnName("TERC_IDINTERMEDIARIO");

                entity.Property(e => e.TercIdmoneda)
                    .HasMaxLength(5)
                    .HasColumnName("TERC_IDMONEDA");

                entity.Property(e => e.TercIdpadre).HasColumnName("TERC_IDPADRE");

                entity.Property(e => e.TercIdpais)
                    .HasMaxLength(50)
                    .HasColumnName("TERC_IDPAIS");

                entity.Property(e => e.TercIdtercefactura).HasColumnName("TERC_IDTERCEFACTURA");

                entity.Property(e => e.TercIdtipocliente)
                    .HasMaxLength(20)
                    .HasColumnName("TERC_IDTIPOCLIENTE");

                entity.Property(e => e.TercIdtipoclientefactura)
                    .HasMaxLength(10)
                    .HasColumnName("TERC_IDTIPOCLIENTEFACTURA");

                entity.Property(e => e.TercIdtipodocumento)
                    .HasMaxLength(20)
                    .HasColumnName("TERC_IDTIPODOCUMENTO");

                entity.Property(e => e.TercIdtipopersona)
                    .HasMaxLength(20)
                    .HasColumnName("TERC_IDTIPOPERSONA");

                entity.Property(e => e.TercIdunidadnegocio)
                    .HasMaxLength(50)
                    .HasColumnName("TERC_IDUNIDADNEGOCIO");

                entity.Property(e => e.TercIdusuactualiza).HasColumnName("TERC_IDUSUACTUALIZA");

                entity.Property(e => e.TercIdusucrea).HasColumnName("TERC_IDUSUCREA");

                entity.Property(e => e.TercLiquidaiva)
                    .HasColumnName("TERC_LIQUIDAIVA")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TercMail)
                    .HasMaxLength(200)
                    .HasColumnName("TERC_MAIL");

                entity.Property(e => e.TercMultiempresa).HasColumnName("TERC_MULTIEMPRESA");

                entity.Property(e => e.TercNit)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("TERC_NIT");

                entity.Property(e => e.TercNombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("TERC_NOMBRE");

                entity.Property(e => e.TercNombrenatural)
                    .HasMaxLength(300)
                    .HasColumnName("TERC_NOMBRENATURAL");

                entity.Property(e => e.TercNotas)
                    .HasColumnType("ntext")
                    .HasColumnName("TERC_NOTAS");

                entity.Property(e => e.TercRazonbloqueo)
                    .HasMaxLength(200)
                    .HasColumnName("TERC_RAZONBLOQUEO");

                entity.Property(e => e.TercRepresentante)
                    .HasMaxLength(300)
                    .HasColumnName("TERC_REPRESENTANTE");

                entity.Property(e => e.TercTelefono)
                    .HasMaxLength(200)
                    .HasColumnName("TERC_TELEFONO");

                entity.Property(e => e.TercUltimagestion)
                    .HasColumnType("datetime")
                    .HasColumnName("TERC_ULTIMAGESTION");

                entity.Property(e => e.TercUltimaprogramacioncrm)
                    .HasColumnType("datetime")
                    .HasColumnName("TERC_ULTIMAPROGRAMACIONCRM");

                entity.Property(e => e.TercWebsite)
                    .HasMaxLength(300)
                    .HasColumnName("TERC_WEBSITE");

                entity.Property(e => e.UsuCostohora).HasColumnName("USU_COSTOHORA");

                entity.Property(e => e.UsuDebecambiar).HasColumnName("USU_DEBECAMBIAR");

                entity.Property(e => e.UsuDiascambio).HasColumnName("USU_DIASCAMBIO");

                entity.Property(e => e.UsuFultimocambio)
                    .HasColumnType("datetime")
                    .HasColumnName("USU_FULTIMOCAMBIO");

                entity.Property(e => e.UsuIdarea)
                    .HasMaxLength(20)
                    .HasColumnName("USU_IDAREA");

                entity.Property(e => e.UsuIdcargo)
                    .HasMaxLength(10)
                    .HasColumnName("USU_IDCARGO");

                entity.Property(e => e.UsuIdcop)
                    .HasMaxLength(15)
                    .HasColumnName("USU_IDCOP");

                entity.Property(e => e.UsuIdperfil)
                    .HasMaxLength(50)
                    .HasColumnName("USU_IDPERFIL");

                entity.Property(e => e.UsuIdturno)
                    .HasMaxLength(20)
                    .HasColumnName("USU_IDTURNO");

                entity.Property(e => e.UsuVenceclave).HasColumnName("USU_VENCECLAVE");

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.HasOne(d => d.TercIdpadreNavigation)
                    .WithMany(p => p.InverseTercIdpadreNavigation)
                    .HasForeignKey(d => d.TercIdpadre)
                    .HasConstraintName("FK_TRC_TERCERO_TRC_TERCERO");
            });

            modelBuilder.Entity<VeqProdEcommerce>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("veqProdEcommerce");

                entity.Property(e => e.Bodega)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CentroOperativo).HasMaxLength(50);

                entity.Property(e => e.DescripcionEcommerce).HasMaxLength(2000);

                entity.Property(e => e.IdCentroOperativo).HasMaxLength(15);

                entity.Property(e => e.IdEmpresa).HasMaxLength(50);

                entity.Property(e => e.IdLista)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Moneda).HasMaxLength(10);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ProdIdproducto).HasColumnName("PROD_IDPRODUCTO");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("SKU");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
