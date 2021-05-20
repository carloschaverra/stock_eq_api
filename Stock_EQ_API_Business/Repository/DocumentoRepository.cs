using Stock_EQ_API_Business.IRepository;
using Stock_EQ_API_DataBaseContext.Models;
using Stock_EQ_API_DataBaseContext.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient; 
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Stock_EQ_API_Business.Repository
{
    public class DocumentoRepository : IDocumentoRepository
    {
        public int CreateDocument(DocumentoRQ documentRequest)
        {
            int iResult = 0;
            Guid guid;
            PRUEBAS_APIContext context;
            string sSql = string.Empty;
            List<SqlParameter> parameters; 
            try
            {
                sSql = @"EXEC [dbo].[SpPedidoVentaInsertCompleto1] @DOC_PREFIJO
                        , @DOC_IDEMPRESA, @DOC_IDTERCERO, @DOC_IDSUCURSAL
                        , @DOC_IDESTADO, @DOC_DESCRIPCION, @DOC_FECHA
                        , @DOC_IDMONEDA, @DOC_IDPRIORIDAD, @DOC_IDCREADOR
                        , @DOC_FCOMPROMISO, @DOC_SUBTOTAL, @DOC_IDDPTOASIGNADO
                        , @DOC_TOTAL, @DOC_FCREACION, @DOC_IDBODEGA
                        , @DOC_IDFORMAPAGO, @DOC_DESCUENTO, @DOC_DESCUENTO_ME
                        , @DOC_DOCTERCERO, @DOC_IMPUESTOMAS, @DOC_IMPUESTOMAS_ME
                        , @DOC_IMPUESTOMENOS, @DOC_IMPUESTOMENOS_ME, @DOC_NDECIMALES_ME
                        , @DOC_PORCDESCUENTO, @DOC_TOTAL_ME, @DOC_TOTALCONIMPUESTO
                        , @DOC_TOTALCONIMPUESTO_ME, @DOC_VLRTRM, @DOC_SUBTOTAL_ME
                        , @COT_IDASESOR, @DOC_IDLISTA, @DOC_DTOXITEM
                        , @DOC_APLICAIVA, @ORT_CTOTAL, @DOC_IDMEDIOPAGO
                        , @DOC_DIRECCIONENTREGA, @DOC_IDCIUDADENTREGA, @DOC_IDCOP
                        , @DOC_IDUSUMODIFICA, @DOC_EMAILCLIENTE, @DOC_NUMERO, @idProceso";

                context = new PRUEBAS_APIContext();
                ValidateDocumentRequest(documentRequest);
                SetDefaultValues(ref documentRequest);
                guid = InsertDocumentsItem(documentRequest.Items);
                parameters = SetParametersSpPedidoVentaInsertCompleto1(documentRequest, guid);
                context.Database.ExecuteSqlRaw(sSql, parameters);
                iResult = DeleteDocumentsItem(guid);
            }
            catch (Exception)
            {
                iResult = -1;
                throw;
            }
            return iResult;
        }

        private int DeleteDocumentsItem(Guid guid)
        {
            int iResult = 0;
            List<EqPedidoApi> listaEqPedidoApi = new List<EqPedidoApi>();
            PRUEBAS_APIContext context;
            try
            {
                context = new PRUEBAS_APIContext();
                listaEqPedidoApi = context.EqPedidoApis.Where(p => p.IdProceso == guid).ToList();

                foreach (EqPedidoApi item in listaEqPedidoApi)
                    context.EqPedidoApis.Remove(item);

                iResult = context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return iResult;
        }

        private void SetDefaultValues(ref DocumentoRQ documentRequest) 
        {
            documentRequest.Estado = "58d413d3-a5b0-4069-8bdc-9ea29646c81a";
            documentRequest.Fecha = DateTime.Now;
            documentRequest.FechaCompromiso = documentRequest.Fecha.Value.AddDays(5); 
            documentRequest.FechaCreacion = DateTime.Now;
            documentRequest.Descuento = documentRequest.Descuento <= 0 ? 0d : documentRequest.Descuento;
            documentRequest.Descuento_ME = documentRequest.Descuento_ME <= 0 ? 0d : documentRequest.Descuento_ME;
            documentRequest.ImpuestoMAS = documentRequest.ImpuestoMAS <= 0 ? 0d : documentRequest.ImpuestoMAS;
            documentRequest.ImpuestoMAS_ME = documentRequest.ImpuestoMAS_ME <= 0 ? 0d : documentRequest.ImpuestoMAS_ME;
            documentRequest.ImpuestoMENOS = documentRequest.ImpuestoMENOS <= 0 ? 0d : documentRequest.ImpuestoMENOS;
            documentRequest.ImpuestoMENOS_ME = documentRequest.ImpuestoMENOS_ME <= 0 ? 0d : documentRequest.ImpuestoMENOS_ME;
            documentRequest.NumeroDecimales_ME = documentRequest.NumeroDecimales_ME <= 0 ? 0 : documentRequest.NumeroDecimales_ME;
            documentRequest.PorcentajeDescuento = documentRequest.PorcentajeDescuento <= 0 ? 0d : documentRequest.PorcentajeDescuento;
            documentRequest.TotalME = documentRequest.TotalME <= 0 ? 0d : documentRequest.TotalME;
            documentRequest.TotalImpuesto = documentRequest.TotalImpuesto <= 0 ? 0d : documentRequest.TotalImpuesto;
            documentRequest.TotalImpuestoME = documentRequest.TotalImpuestoME <= 0 ? 0 : documentRequest.TotalImpuestoME;
            documentRequest.ValorTRM = documentRequest.ValorTRM <= 0 ? 0d : documentRequest.ValorTRM;
            documentRequest.SubtotalME = documentRequest.SubtotalME <= 0 ? 0d : documentRequest.SubtotalME;
            documentRequest.IdUsuarioModifica = documentRequest.Creador;
        }

        private List<SqlParameter> SetParametersSpPedidoVentaInsertCompleto1(DocumentoRQ documentRequest, Guid guid) 
        {
            List<SqlParameter> parameters;
            try {
                parameters = new List<SqlParameter>();
                 
                parameters.Add(new SqlParameter() { ParameterName = "@DOC_PREFIJO", 
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar, 
                                                    Size = 10,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Prefijo });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDEMPRESA", 
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar, 
                                                    Size = 15,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.IdEmpresa });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDTERCERO", 
                                                    SqlDbType =  System.Data.SqlDbType.BigInt, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Tercero });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDSUCURSAL", 
                                                    SqlDbType =  System.Data.SqlDbType.BigInt, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Sucursal });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDESTADO", 
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar, 
                                                    Size = 50,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Estado });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_DESCRIPCION", 
                                                    SqlDbType =  System.Data.SqlDbType.NText, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Descripcion });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_FECHA", 
                                                    SqlDbType =  System.Data.SqlDbType.DateTime, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Fecha });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDMONEDA", 
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar, 
                                                    Size = 10,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Moneda });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDPRIORIDAD", 
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar, 
                                                    Size = 5,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Prioridad });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDCREADOR", 
                                                    SqlDbType =  System.Data.SqlDbType.BigInt, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Creador });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_FCOMPROMISO", 
                                                    SqlDbType =  System.Data.SqlDbType.DateTime, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.FechaCompromiso });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_SUBTOTAL", 
                                                    SqlDbType =  System.Data.SqlDbType.Float, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Subtotal });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDDPTOASIGNADO", 
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar, 
                                                    Size = 10,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.DepartamentoAsignado });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_TOTAL", 
                                                    SqlDbType =  System.Data.SqlDbType.Float, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Total });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_FCREACION", 
                                                    SqlDbType =  System.Data.SqlDbType.DateTime, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.FechaCreacion });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDBODEGA", 
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar, 
                                                    Size = 50,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Bodega });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDFORMAPAGO", 
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar, 
                                                    Size = 5,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.FormaPago });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_DESCUENTO", 
                                                    SqlDbType =  System.Data.SqlDbType.Float,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Descuento });
                                                
                parameters.Add(new SqlParameter() { ParameterName = "@DOC_DESCUENTO_ME", 
                                                    SqlDbType =  System.Data.SqlDbType.Float,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Descuento_ME });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_DOCTERCERO", 
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar,
                                                    Size = 20, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Tercero });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IMPUESTOMAS", 
                                                    SqlDbType =  System.Data.SqlDbType.Float, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.ImpuestoMAS });
                
                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IMPUESTOMAS_ME", 
                                                    SqlDbType =  System.Data.SqlDbType.Float, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.ImpuestoMAS_ME });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IMPUESTOMENOS", 
                                                    SqlDbType =  System.Data.SqlDbType.Float, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.ImpuestoMENOS });
                
                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IMPUESTOMENOS_ME", 
                                                    SqlDbType =  System.Data.SqlDbType.Float, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.ImpuestoMENOS_ME });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_NDECIMALES_ME", 
                                                    SqlDbType =  System.Data.SqlDbType.Int, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.NumeroDecimales_ME });
                
                parameters.Add(new SqlParameter() { ParameterName = "@DOC_PORCDESCUENTO", 
                                                    SqlDbType =  System.Data.SqlDbType.Float, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.PorcentajeDescuento });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_TOTAL_ME", 
                                                    SqlDbType =  System.Data.SqlDbType.Float, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.TotalME });
                
                parameters.Add(new SqlParameter() { ParameterName = "@DOC_TOTALCONIMPUESTO", 
                                                    SqlDbType =  System.Data.SqlDbType.Float, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.TotalImpuesto });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_TOTALCONIMPUESTO_ME", 
                                                    SqlDbType =  System.Data.SqlDbType.Float, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.TotalImpuestoME });
                
                parameters.Add(new SqlParameter() { ParameterName = "@DOC_VLRTRM", 
                                                    SqlDbType =  System.Data.SqlDbType.Float, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.ValorTRM });
                ////////////////////////////////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////////////////////
                parameters.Add(new SqlParameter() { ParameterName = "@DOC_SUBTOTAL_ME", 
                                                    SqlDbType =  System.Data.SqlDbType.Float,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.SubtotalME });

                parameters.Add(new SqlParameter() { ParameterName = "@COT_IDASESOR", 
                                                    SqlDbType =  System.Data.SqlDbType.BigInt, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.IdAsesor });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDLISTA", 
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar,
                                                    Size = 5, 
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.IdListaPrecio });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_DTOXITEM", 
                                                    SqlDbType =  System.Data.SqlDbType.Bit,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.DescuentotoItem });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_APLICAIVA", 
                                                    SqlDbType =  System.Data.SqlDbType.Bit,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.AplicaIva });

                parameters.Add(new SqlParameter() { ParameterName = "@ORT_CTOTAL", 
                                                    SqlDbType =  System.Data.SqlDbType.Float,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.CostoTotal });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDMEDIOPAGO", 
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar,
                                                    Size = 5,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.IdMedioPago });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_DIRECCIONENTREGA", 
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar,
                                                    Size = 300,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.DireccionEntrega });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDCIUDADENTREGA", 
                                                    SqlDbType =  System.Data.SqlDbType.BigInt,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.CiudadEntrega });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDCOP", 
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar,
                                                    Size = 15,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.IdCentroOperativo });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_IDUSUMODIFICA", 
                                                    SqlDbType =  System.Data.SqlDbType.BigInt,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.Creador });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_EMAILCLIENTE", 
                                                    SqlDbType =  System.Data.SqlDbType.NVarChar,
                                                    Size = 50,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = documentRequest.EmailCliente });

                parameters.Add(new SqlParameter() { ParameterName = "@DOC_NUMERO", 
                                                    SqlDbType =  System.Data.SqlDbType.BigInt,
                                                    Direction = System.Data.ParameterDirection.Output });

                parameters.Add(new SqlParameter() { ParameterName = "@idProceso", 
                                                    SqlDbType =  System.Data.SqlDbType.UniqueIdentifier,
                                                    Direction = System.Data.ParameterDirection.Input,
                                                    Value = guid });

            }
            catch (Exception)
            {
                throw;
            }
            return parameters;

        }

        private void ValidateDocumentRequest(DocumentoRQ documentRequest)
        {
            if (documentRequest == null)
                throw new Exception("¡El documento no se ha podido crear porque está nulo o vacío!");

            if (documentRequest.Items.Count() <= 0) {
                throw new Exception("¡El documento no tiene items, no se creará el documento!");
            }

            //Validar datos JSON
            if (documentRequest.Prefijo == null || documentRequest.Prefijo == "") {
                throw new Exception("¡El prefijo no puede ser nulo o vacío!");
            }

            if (documentRequest.IdEmpresa == null || documentRequest.IdEmpresa == "") {
                throw new Exception("¡El IdEmpresa no puede ser nula o vacía!");
            }

            if (documentRequest.Tercero <= 1) {
                throw new Exception("¡El Tercero no puede ser nula o vacía!");
            }

            if (documentRequest.Sucursal <= 1) {
                throw new Exception("¡La Sucursal no puede ser nula o vacía!");
            }

            if (documentRequest.Descripcion == null || documentRequest.Descripcion == "") {
                throw new Exception("¡La Descripcion no puede ser nula o vacía!");
            }

            if (documentRequest.Moneda == null || documentRequest.Moneda == "") {
                throw new Exception("¡La Moneda no puede ser nula o vacía!");
            }

            if (documentRequest.Creador <= 1) {
                throw new Exception("¡El Creador no puede ser nulo o vacío!");
            }

            if (documentRequest.FechaCompromiso == null) {
                throw new Exception("¡La FechaCompromiso no puede ser nula o vacía!");
            }

            if (documentRequest.Subtotal <= 0) {
                throw new Exception("¡El SubTotal no puede ser menor que 0!");
            }

            if (documentRequest.DepartamentoAsignado == null || documentRequest.DepartamentoAsignado == "") {
                throw new Exception("¡El DepartamentoAsignado no puede ser nulo o vacío!");
            }

            if (documentRequest.Total <= 0) {
                throw new Exception("¡El Total no puede ser menor que 0!");
            }

            if (documentRequest.Bodega == null || documentRequest.Bodega == "") {
                throw new Exception("¡La bodega no puede ser nula o vacía!");
            }

            if (documentRequest.FormaPago == null || documentRequest.FormaPago == "") {
                throw new Exception("¡La FormaPago no puede ser nula o vacía!");
            }

            if (documentRequest.IdAsesor <= 0) {
                throw new Exception("¡La IdAsesor no puede ser nulo o vacío!");
            }

            if (documentRequest.IdListaPrecio == null || documentRequest.IdListaPrecio == "") {
                throw new Exception("¡La IdListaPrecio no puede ser nulo o vacío!");
            }

            if (documentRequest.CostoTotal < 0) {
                throw new Exception("El CostoTotal no puede ser menor que 0!");
            }

            if (documentRequest.IdMedioPago == null || documentRequest.IdMedioPago == "") {
                throw new Exception("El IdMedioPago no puede ser nulo o vacío!");
            }

            if (documentRequest.DireccionEntrega == null || documentRequest.DireccionEntrega == "") {
                throw new Exception("El DireccionEntrega no puede ser nulo o vacío!");
            }

            if (documentRequest.CiudadEntrega < 0) {
                throw new Exception("La CiudadEntrega no puede ser nulo o vacío!");
            }

            if (documentRequest.IdCentroOperativo == null || documentRequest.IdCentroOperativo == "") {
                throw new Exception("El IdCentroOperativo no puede ser nulo o vacío!");
            }
        }

        
        public Guid InsertDocumentsItem(List<DocumentoItemRQ> listaItem)
        {

            if (listaItem.Count() < 1)
            {
                throw new Exception("¡No es prosible crear el documento porque no tiene Items!");
            }

            Guid oGuid;
            PRUEBAS_APIContext context;
            try
            {
                oGuid = Guid.NewGuid();
                context = new PRUEBAS_APIContext();
                foreach (DocumentoItemRQ item in listaItem)
                {
                    EqPedidoApi eqPedidoApi = new EqPedidoApi();
                    eqPedidoApi.Idproducto = item.IdProducto;
                    eqPedidoApi.Idunidad = item.IdUnidad;
                    eqPedidoApi.Descripcion = item.Descripcion;
                    eqPedidoApi.Observaciones = item.Observacion;
                    eqPedidoApi.Iditempadre = item.IdItemPadre;
                    eqPedidoApi.Prefijoorigen = item.PrefijoOrigen;
                    eqPedidoApi.Numeroorigen = item.NumeroOrigen;

                    eqPedidoApi.Iditemorigen = item.IdItemOrigen;
                    eqPedidoApi.Cantsolicitada = item.CantSolicitada;
                    eqPedidoApi.Cantrecibida = item.CantidadRecibida;
                    eqPedidoApi.Vlrunit = item.ValorUnitario;
                    eqPedidoApi.Porcdto = item.PorcentajeDescuento;
                    eqPedidoApi.Vlrdto = item.ValorDcto;
                    eqPedidoApi.Subtotal = item.SubTotal;
                    eqPedidoApi.Idimpuesto = item.IdImpuesto;
                    eqPedidoApi.Porciva = item.PorcentajeIVA;
                    eqPedidoApi.Vlriva = item.ValorIVA;
                    eqPedidoApi.Total = item.Total;
                    eqPedidoApi.Costounit = item.CostoUnitario;
                    eqPedidoApi.Costototal = item.CostoTotal;
                    eqPedidoApi.Mostrar = item.Mostrar;
                    eqPedidoApi.Idestado = item.IdEstado;
                    eqPedidoApi.Idbodega = item.IdBodega;
                    eqPedidoApi.Idcentrocosto = item.IdCentroCosto;
                    eqPedidoApi.Fcalificacion = item.FCalificacion;
                    eqPedidoApi.Vlrcalificacion = item.ValorCalificacion;
                    eqPedidoApi.Fcreacion = item.FechaCreacion;
                    eqPedidoApi.Idtipo = item.IdTipo;
                    eqPedidoApi.Idmaquina = item.IdMaquina;
                    eqPedidoApi.Calificacion = item.Calificacion;
                    eqPedidoApi.Idbodegadest = item.IdBodegaDestino;
                    eqPedidoApi.Vlrrte = item.ValorRTE;
                    eqPedidoApi.Totalconimpuesto = item.TotalConImpuesto;
                    eqPedidoApi.Idopcion = item.IdOpcion;
                    eqPedidoApi.Idescala = item.IdEscala;
                    eqPedidoApi.Cantenoc = item.Cantenoc;
                    eqPedidoApi.Cantcotiz = item.CantidadCotizacion;
                    eqPedidoApi.Elegido = item.Elegido;
                    eqPedidoApi.Cantprocesada = item.CantidadProcesada;
                    eqPedidoApi.Ncotizaciones = item.NumeroCotizaciones;
                    eqPedidoApi.SubtotalMe = item.SubTotalMe;
                    eqPedidoApi.DescuentoMe = item.DescuentoMe;
                    eqPedidoApi.TotalMe = item.TotalMe;
                    eqPedidoApi.ImpuestomasMe = item.ImpuestoMASMe;
                    eqPedidoApi.ImpuestomenosMe = item.ImpuestoMenosMe;
                    eqPedidoApi.TotalconimpuestoMe = item.TotalConImpuestoMe;
                    eqPedidoApi.VlrunitMe = item.ValorUnitarioMe;
                    eqPedidoApi.Localizacion = item.Localizacion;
                    eqPedidoApi.Tipomov = item.TipoMovimiento;
                    eqPedidoApi.Idlistaprecio = item.IdListaPrecio;

                    eqPedidoApi.IdProceso = oGuid;
                    context.EqPedidoApis.Add(eqPedidoApi);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return oGuid;
        }

        //public async Task<int> UpdateStockAsync(StockRQ stockRequest)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
