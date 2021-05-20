using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stock_EQ_API_DataBaseContext.Procedures
{
    public partial class SpPedidoVentaInsertCompleto1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE PROCEDURE [dbo].[SpPedidoVentaInsertCompleto1]
                      @DOC_PREFIJO AS NVarChar(10) OUTPUT
                    , @DOC_IDEMPRESA AS NVarChar(15)
                    , @DOC_IDTERCERO AS BigInt
                    , @DOC_IDSUCURSAL AS BigInt
                    , @DOC_IDESTADO AS NVarChar(50)
                    , @DOC_DESCRIPCION AS NText
                    , @DOC_FECHA AS DateTime
                    , @DOC_IDMONEDA AS NVarChar(10)
                    , @DOC_IDPRIORIDAD AS NVarChar(5)
                    , @DOC_IDSUBTIPODOC AS NVarChar(10)
                    , @DOC_IDCREADOR AS BigInt
                    , @DOC_FCOMPROMISO AS DateTime
                    , @DOC_IDCIUDAD AS NVarChar(20)
                    , @DOC_SUBTOTAL AS Float
                    , @DOC_IDCOMPONENTE AS BigInt
                    , @DOC_IDDPTOASIGNADO AS NVarChar(10)
                    , @DOC_TOTAL AS Float
                    , @DOC_IDEMPRESADOC AS NVarChar(15)
                    , @DOC_IDMAQUINA AS BigInt
                    , @DOC_IDMOTIVOCIERRE AS NVarChar(5)
                    , @DOC_IDMEDIO AS NVarChar(5)
                    , @DOC_IDUSUARIOASIGNADO AS BigInt
                    , @DOC_FCIERRE AS DateTime
                    , @DOC_FCREACION AS DateTime
                    , @DOC_IDBODEGA AS NVarChar(50)
                    , @DOC_IDCONTACTO AS BigInt
                    , @DOC_IDFORMAPAGO AS NVarChar(5)
                    , @DOC_OBSERVACIONES AS NText
                    , @DOC_IDSUCINTERNA AS NVarChar(15)
                    , @DOC_MOTIVOCIERRE AS NVarChar(400)
                    , @DOC_DESCUENTO AS Float
                    , @DOC_DESCUENTO_ME AS Float
                    , @DOC_DIRENTREGA AS NVarChar(200)
                    , @DOC_DOCTERCERO AS NVarChar(20)
                    , @DOC_IDSOLICITANTE AS BigInt
                    , @DOC_IMPUESTOMAS AS Float
                    , @DOC_IMPUESTOMAS_ME AS Float
                    , @DOC_IMPUESTOMENOS AS Float
                    , @DOC_IMPUESTOMENOS_ME AS Float
                    , @DOC_NDECIMALES_ME AS Int
                    , @DOC_NUMEROPADRE AS BigInt
                    , @DOC_NUMEROPROYECTO AS BigInt
                    , @DOC_PORCDESCUENTO AS Float
                    , @DOC_TOTAL_ME AS Float
                    , @DOC_TOTALCONIMPUESTO AS Float
                    , @DOC_TOTALCONIMPUESTO_ME AS Float
                    , @DOC_VLRTRM AS Float
                    , @REM_APROBO AS NVarChar(150)
                    , @REM_CARGOAPROBO AS NVarChar(50)
                    , @REM_CARGODESPACHO AS NVarChar(50)
                    , @REM_CARGOELABORO AS NVarChar(50)
                    , @REM_CARGORECIBE AS NVarChar(50)
                    , @REM_DESPACHO AS NVarChar(150)
                    , @REM_ELABORO AS NVarChar(150)
                    , @REM_IDTRANSPORTADOR AS BigInt
                    , @REM_NOTAS AS NText
                    , @REM_RECIBE AS NVarChar(150)
                    , @DOC_PREFIJOPADRE AS NVarChar(10)
                    , @DOC_PREFIJOPROYECTO AS NVarChar(10)
                    , @DOC_SUBTOTAL_ME AS Float
                    , @DOC_TELENTREGA AS NVarChar(80)
                    , @COT_IDASESOR AS BigInt
                    , @DOC_IDLISTA AS NVarChar(5)
                    , @DOC_DTOXITEM AS Bit
                    , @DOC_APLICAIVA AS Bit
                    , @ORT_CTOTAL AS Float
                    , @DOC_IDMEDIOPAGO AS NVarChar(5)
                    , @DOC_DIRECCIONENTREGA AS NVarChar(300)
                    , @DOC_IDCIUDADENTREGA AS NVarChar(20)
                    , @DOC_IDCOP AS NVarChar(15)
                    , @DOC_IDUSUMODIFICA AS BigInt
                    , @DOC_NUMERO AS BIGINT OUTPUT 
                    , @idProceso AS UNIQUEIDENTIFIER 
                AS
                    
                    SET NOCOUNT ON
                    
                    DECLARE @vNumero AS BIGINT
                    DECLARE @vCuantos AS BIGINT
                    
                    SET NOCOUNT ON;
                    IF ISNULL(@DOC_NUMERO, 0) = 0
                    BEGIN
                        SELECT @vNumero = ISNULL(MAX(SMCN_CONSECUTIVO), 0) + 1 FROM SAMM_CONSECUTIVO WHERE SMCN_PREFIJO = @DOC_PREFIJO
                    END
                    ELSE
                    BEGIN
                        SELECT @vCuantos = COUNT(*) FROM SAMM_CONSECUTIVO WHERE SMCN_PREFIJO = @DOC_PREFIJO AND SMCN_CONSECUTIVO = @DOC_NUMERO
                        IF @vCuantos = 0 
                            SET @vNumero= @DOC_NUMERO
                        ELSE
                        BEGIN
                            RAISERROR ('El numero de remision que intenta ingresar ya existe, digite 0 para que el sistema asigne automaticamente un numero, o digite un nuevo numero de Remision', 16, 1)
                            RETURN
                        END
                    END
                    
                    SET @DOC_NUMERO = @vNumero
                
                    INSERT INTO DOC_DOCUMENTO
                    (
                    DOC_PREFIJO
                    , DOC_NUMERO
                    , DOC_IDEMPRESA
                    , DOC_IDTERCERO
                    , DOC_IDSUCURSAL
                    , DOC_IDESTADO
                    , DOC_DESCRIPCION
                    , DOC_FECHA
                    , DOC_IDMONEDA
                    , DOC_IDPRIORIDAD
                    , DOC_IDSUBTIPODOC
                    , DOC_IDCREADOR
                    , DOC_FCOMPROMISO
                    , DOC_IDCIUDAD
                    , DOC_SUBTOTAL
                    , DOC_IDCOMPONENTE
                    , DOC_IDDPTOASIGNADO
                    , DOC_TOTAL
                    , DOC_IDEMPRESADOC
                    , DOC_IDMAQUINA
                    , DOC_IDMOTIVOCIERRE
                    , DOC_IDMEDIO
                    , DOC_IDUSUARIOASIGNADO
                    , DOC_FCIERRE
                    , DOC_FCREACION
                    , DOC_IDBODEGA
                    , DOC_IDCONTACTO
                    , DOC_IDFORMAPAGO
                    , DOC_OBSERVACIONES
                    , DOC_IDSUCINTERNA
                    , DOC_MOTIVOCIERRE
                    , DOC_DESCUENTO
                    , DOC_DESCUENTO_ME
                    , DOC_DIRENTREGA
                    , DOC_DOCTERCERO
                    , DOC_IDSOLICITANTE
                    , DOC_IMPUESTOMAS
                    , DOC_IMPUESTOMAS_ME
                    , DOC_IMPUESTOMENOS
                    , DOC_IMPUESTOMENOS_ME
                    , DOC_NDECIMALES_ME
                    , DOC_NUMEROPADRE
                    , DOC_NUMEROPROYECTO
                    , DOC_PORCDESCUENTO
                    , DOC_TOTAL_ME
                    , DOC_TOTALCONIMPUESTO
                    , DOC_TOTALCONIMPUESTO_ME
                    , DOC_VLRTRM
                    , REM_APROBO
                    , REM_CARGOAPROBO
                    , REM_CARGODESPACHO
                    , REM_CARGOELABORO
                    , REM_CARGORECIBE
                    , REM_DESPACHO
                    , REM_ELABORO
                    , REM_IDTRANSPORTADOR
                    , REM_NOTAS
                    , REM_RECIBE
                    , DOC_PREFIJOPADRE
                    , DOC_PREFIJOPROYECTO
                    , DOC_SUBTOTAL_ME
                    , DOC_TELENTREGA
                    , COT_IDASESOR
                    , DOC_IDLISTA
                    , DOC_DTOXITEM
                    , DOC_APLICAIVA
                    , ORT_CTOTAL
                    , DOC_IDMEDIOPAGO
                    , DOC_DIRECCIONENTREGA
                    , DOC_IDCIUDADENTREGA
                    , DOC_IDCOP
                    , DOC_IDUSUMODIFICA
                    ) 
                    VALUES 
                    (
                    @DOC_PREFIJO
                    , @DOC_NUMERO
                    , @DOC_IDEMPRESA
                    , @DOC_IDTERCERO
                    , @DOC_IDSUCURSAL
                    , @DOC_IDESTADO
                    , @DOC_DESCRIPCION
                    , @DOC_FECHA
                    , @DOC_IDMONEDA
                    , @DOC_IDPRIORIDAD
                    , @DOC_IDSUBTIPODOC
                    , @DOC_IDCREADOR
                    , @DOC_FCOMPROMISO
                    , @DOC_IDCIUDAD
                    , @DOC_SUBTOTAL
                    , @DOC_IDCOMPONENTE
                    , @DOC_IDDPTOASIGNADO
                    , @DOC_TOTAL
                    , @DOC_IDEMPRESADOC
                    , @DOC_IDMAQUINA
                    , @DOC_IDMOTIVOCIERRE
                    , @DOC_IDMEDIO
                    , @DOC_IDUSUARIOASIGNADO
                    , @DOC_FCIERRE
                    , @DOC_FCREACION
                    , @DOC_IDBODEGA
                    , @DOC_IDCONTACTO
                    , @DOC_IDFORMAPAGO
                    , @DOC_OBSERVACIONES
                    , @DOC_IDSUCINTERNA
                    , @DOC_MOTIVOCIERRE
                    , @DOC_DESCUENTO
                    , @DOC_DESCUENTO_ME
                    , @DOC_DIRENTREGA
                    , @DOC_DOCTERCERO
                    , @DOC_IDSOLICITANTE
                    , @DOC_IMPUESTOMAS
                    , @DOC_IMPUESTOMAS_ME
                    , @DOC_IMPUESTOMENOS
                    , @DOC_IMPUESTOMENOS_ME
                    , @DOC_NDECIMALES_ME
                    , @DOC_NUMEROPADRE
                    , @DOC_NUMEROPROYECTO
                    , @DOC_PORCDESCUENTO
                    , @DOC_TOTAL_ME
                    , @DOC_TOTALCONIMPUESTO
                    , @DOC_TOTALCONIMPUESTO_ME
                    , @DOC_VLRTRM
                    , @REM_APROBO
                    , @REM_CARGOAPROBO
                    , @REM_CARGODESPACHO
                    , @REM_CARGOELABORO
                    , @REM_CARGORECIBE
                    , @REM_DESPACHO
                    , @REM_ELABORO
                    , @REM_IDTRANSPORTADOR
                    , @REM_NOTAS
                    , @REM_RECIBE
                    , @DOC_PREFIJOPADRE
                    , @DOC_PREFIJOPROYECTO
                    , @DOC_SUBTOTAL_ME
                    , @DOC_TELENTREGA
                    , @COT_IDASESOR
                    , @DOC_IDLISTA
                    , @DOC_DTOXITEM
                    , @DOC_APLICAIVA
                    , @ORT_CTOTAL
                    , @DOC_IDMEDIOPAGO
                    , @DOC_DIRECCIONENTREGA
                    , @DOC_IDCIUDADENTREGA
                    , @DOC_IDCOP
                    , @DOC_IDUSUMODIFICA
                    ) 
                    
                    INSERT INTO SAMM_CONSECUTIVO (SMCN_PREFIJO, SMCN_CONSECUTIVO, SMCN_IDUSUARIO) VALUES (@DOC_PREFIJO, @vNumero, @DOC_IDCREADOR)

                    --Ahora se insertan los ítems
                    DECLARE @DCIT_IDITEM AS Int
                    DECLARE @DCIT_PREFIJO AS NVarChar(10)
                    DECLARE @DCIT_NUMERO AS BigInt
                    DECLARE @DCIT_ORDEN AS Int
                    DECLARE @DCIT_IDPRODUCTO AS BigInt
                    DECLARE @DCIT_IDUNIDAD AS NVarChar(10)
                    DECLARE @DCIT_DESCRIPCION AS NVarChar(2000)
                    DECLARE @DCIT_OBSERVACIONES AS NVarChar(500)
                    DECLARE @DCIT_IDITEMPADRE AS Int
                    DECLARE @DCIT_PREFIJOORIGEN AS NVarChar(10)
                    DECLARE @DCIT_NUMEROORIGEN AS BigInt
                    DECLARE @DCIT_IDITEMORIGEN AS Int
                    DECLARE @DCIT_CANTSOLICITADA AS Float
                    DECLARE @DCIT_CANTRECIBIDA AS Float
                    DECLARE @DCIT_VLRUNIT AS Float
                    DECLARE @DCIT_PORCDTO AS Float
                    DECLARE @DCIT_VLRDTO AS Float
                    DECLARE @DCIT_SUBTOTAL AS Float
                    DECLARE @DCIT_IDIMPUESTO AS NVarChar(5)
                    DECLARE @DCIT_PORCIVA AS Float
                    DECLARE @DCIT_VLRIVA AS Float
                    DECLARE @DCIT_TOTAL AS Float
                    DECLARE @DCIT_COSTOUNIT AS Float
                    DECLARE @DCIT_COSTOTOTAL AS Float
                    DECLARE @DCIT_MOSTRAR AS Bit
                    DECLARE @DCIT_IDESTADO AS NVarChar(10)
                    DECLARE @DCIT_IDBODEGA AS NVarChar(50)
                    DECLARE @DCIT_IDCENTROCOSTO AS NVarChar(20)
                    DECLARE @DCIT_FCALIFICACION AS DateTime
                    DECLARE @DCIT_VLRCALIFICACION AS Float
                    DECLARE @DCIT_FCREACION AS DateTime
                    DECLARE @DCIT_IDTIPO AS NVarChar(5)
                    DECLARE @DCIT_IDMAQUINA AS BigInt
                    DECLARE @DCIT_CALIFICACION AS Int
                    DECLARE @DCIT_IDBODEGADEST AS NVarChar(50)
                    DECLARE @DCIT_VLRRTE AS Float
                    DECLARE @DCIT_TOTALCONIMPUESTO AS Float
                    DECLARE @DCIT_IDOPCION AS Int
                    DECLARE @DCIT_IDESCALA AS BigInt
                    DECLARE @DCIT_CANTENOC AS Float
                    DECLARE @DCIT_CANTCOTIZ AS Float
                    DECLARE @DCIT_ELEGIDO AS Bit
                    DECLARE @DCIT_CANTPROCESADA AS Float
                    DECLARE @DCIT_NCOTIZACIONES AS Int
                    DECLARE @DCIT_SUBTOTAL_ME AS Float
                    DECLARE @DCIT_DESCUENTO_ME AS Float
                    DECLARE @DCIT_TOTAL_ME AS Float
                    DECLARE @DCIT_IMPUESTOMAS_ME AS Float
                    DECLARE @DCIT_IMPUESTOMENOS_ME AS Float
                    DECLARE @DCIT_TOTALCONIMPUESTO_ME AS Float
                    DECLARE @DCIT_VLRUNIT_ME AS Float
                    DECLARE @DCIT_LOCALIZACION AS NVarChar(50)
                    DECLARE @DCIT_TIPOMOV AS NVarChar(10)
                    DECLARE @DCIT_IDLISTAPRECIO AS NVarChar(5) 

                    SELECT @DCIT_NUMERO = @DOC_NUMERO
                    SELECT @DCIT_PREFIJO = @DOC_PREFIJO
                    SELECT @DCIT_IDITEM = 1
                    SELECT @DCIT_ORDEN = 1
                    
                    
                    DECLARE CurItemsDocumento CURSOR LOCAL FOR
                        SELECT        IDPRODUCTO, IDUNIDAD, DESCRIPCION, OBSERVACIONES, IDITEMPADRE, PREFIJOORIGEN, NUMEROORIGEN, IDITEMORIGEN, CANTSOLICITADA, CANTRECIBIDA, VLRUNIT, PORCDTO, VLRDTO, SUBTOTAL, 
                                        IDIMPUESTO, PORCIVA, VLRIVA, TOTAL, COSTOUNIT, COSTOTOTAL, MOSTRAR, IDESTADO, IDBODEGA, IDCENTROCOSTO, FCALIFICACION, VLRCALIFICACION, FCREACION, IDTIPO, IDMAQUINA, CALIFICACION, 
                                        IDBODEGADEST, VLRRTE, TOTALCONIMPUESTO, IDOPCION, IDESCALA, CANTENOC, CANTCOTIZ, ELEGIDO, CANTPROCESADA, NCOTIZACIONES, SUBTOTAL_ME, DESCUENTO_ME, TOTAL_ME, 
                                        IMPUESTOMAS_ME, IMPUESTOMENOS_ME, TOTALCONIMPUESTO_ME, VLRUNIT_ME, LOCALIZACION, TIPOMOV, IDLISTAPRECIO
                FROM            eqPedidoAPI
                WHERE        (IdProceso = @IdProceso)
                    OPEN CurItemsDocumento
                        FETCH NEXT FROM CurItemsDocumento
                    INTO @DCIT_IDPRODUCTO, @DCIT_IDUNIDAD, @DCIT_DESCRIPCION, @DCIT_OBSERVACIONES, @DCIT_IDITEMPADRE, @DCIT_PREFIJOORIGEN, @DCIT_NUMEROORIGEN, @DCIT_IDITEMORIGEN, @DCIT_CANTSOLICITADA, @DCIT_CANTRECIBIDA, @DCIT_VLRUNIT, @DCIT_PORCDTO, @DCIT_VLRDTO, @DCIT_SUBTOTAL, @DCIT_IDIMPUESTO, @DCIT_PORCIVA, @DCIT_VLRIVA, @DCIT_TOTAL, @DCIT_COSTOUNIT, @DCIT_COSTOTOTAL, @DCIT_MOSTRAR, @DCIT_IDESTADO, @DCIT_IDBODEGA, @DCIT_IDCENTROCOSTO, @DCIT_FCALIFICACION, @DCIT_VLRCALIFICACION, @DCIT_FCREACION, @DCIT_IDTIPO, @DCIT_IDMAQUINA, @DCIT_CALIFICACION, @DCIT_IDBODEGADEST, @DCIT_VLRRTE, @DCIT_TOTALCONIMPUESTO, @DCIT_IDOPCION, @DCIT_IDESCALA, @DCIT_CANTENOC, @DCIT_CANTCOTIZ, @DCIT_ELEGIDO, @DCIT_CANTPROCESADA, @DCIT_NCOTIZACIONES, @DCIT_SUBTOTAL_ME, @DCIT_DESCUENTO_ME, @DCIT_TOTAL_ME, @DCIT_IMPUESTOMAS_ME, @DCIT_IMPUESTOMENOS_ME, @DCIT_TOTALCONIMPUESTO_ME, @DCIT_VLRUNIT_ME, @DCIT_LOCALIZACION, @DCIT_TIPOMOV, @DCIT_IDLISTAPRECIO
                    WHILE @@FETCH_STATUS = 0
                        BEGIN
                            IF ISNULL(@DCIT_IDOPCION, 0) = 0
                            BEGIN
                                SET @DCIT_IDOPCION = 1
                            END
                            
                            IF @DCIT_IDCENTROCOSTO = '' 
                            BEGIN
                                SET @DCIT_IDCENTROCOSTO = NULL
                            END

                            IF @DCIT_IDBODEGA = '' 
                            BEGIN
                                SET @DCIT_IDBODEGA = NULL
                            END
                            SET @DCIT_FCREACION = GETDATE()
                            
                            INSERT INTO DOC_ITEM
                                (
                                DCIT_IDITEM
                                , DCIT_PREFIJO
                                , DCIT_NUMERO
                                , DCIT_ORDEN
                                , DCIT_IDPRODUCTO
                                , DCIT_IDUNIDAD
                                , DCIT_DESCRIPCION
                                , DCIT_OBSERVACIONES
                                , DCIT_IDITEMPADRE
                                , DCIT_PREFIJOORIGEN
                                , DCIT_NUMEROORIGEN
                                , DCIT_IDITEMORIGEN
                                , DCIT_CANTSOLICITADA
                                , DCIT_CANTRECIBIDA
                                , DCIT_VLRUNIT
                                , DCIT_PORCDTO
                                , DCIT_VLRDTO
                                , DCIT_SUBTOTAL
                                , DCIT_IDIMPUESTO
                                , DCIT_PORCIVA
                                , DCIT_VLRIVA
                                , DCIT_TOTAL
                                , DCIT_COSTOUNIT
                                , DCIT_COSTOTOTAL
                                , DCIT_MOSTRAR
                                , DCIT_IDESTADO
                                , DCIT_IDBODEGA
                                , DCIT_IDCENTROCOSTO
                                , DCIT_FCALIFICACION
                                , DCIT_VLRCALIFICACION
                                , DCIT_FCREACION
                                , DCIT_IDTIPO
                                , DCIT_IDMAQUINA
                                , DCIT_CALIFICACION
                                , DCIT_IDBODEGADEST
                                , DCIT_VLRRTE
                                , DCIT_TOTALCONIMPUESTO
                                , DCIT_IDOPCION
                                , DCIT_IDESCALA
                                , DCIT_CANTENOC
                                , DCIT_CANTCOTIZ
                                , DCIT_ELEGIDO
                                , DCIT_CANTPROCESADA
                                , DCIT_NCOTIZACIONES
                                , DCIT_SUBTOTAL_ME
                                , DCIT_DESCUENTO_ME
                                , DCIT_TOTAL_ME
                                , DCIT_IMPUESTOMAS_ME
                                , DCIT_IMPUESTOMENOS_ME
                                , DCIT_TOTALCONIMPUESTO_ME
                                , DCIT_VLRUNIT_ME
                                , DCIT_LOCALIZACION
                                , DCIT_TIPOMOV
                                , DCIT_IDLISTAPRECIO
                                ) 
                            VALUES 
                                (
                                @DCIT_IDITEM
                                , @DCIT_PREFIJO
                                , @DCIT_NUMERO
                                , @DCIT_ORDEN
                                , @DCIT_IDPRODUCTO
                                , @DCIT_IDUNIDAD
                                , @DCIT_DESCRIPCION
                                , @DCIT_OBSERVACIONES
                                , @DCIT_IDITEMPADRE
                                , @DCIT_PREFIJOORIGEN
                                , @DCIT_NUMEROORIGEN
                                , @DCIT_IDITEMORIGEN
                                , @DCIT_CANTSOLICITADA
                                , @DCIT_CANTRECIBIDA
                                , @DCIT_VLRUNIT
                                , @DCIT_PORCDTO
                                , @DCIT_VLRDTO
                                , @DCIT_SUBTOTAL
                                , @DCIT_IDIMPUESTO
                                , @DCIT_PORCIVA
                                , @DCIT_VLRIVA
                                , @DCIT_TOTAL
                                , @DCIT_COSTOUNIT
                                , @DCIT_COSTOTOTAL
                                , @DCIT_MOSTRAR
                                , @DCIT_IDESTADO
                                , @DCIT_IDBODEGA
                                , @DCIT_IDCENTROCOSTO
                                , @DCIT_FCALIFICACION
                                , @DCIT_VLRCALIFICACION
                                , @DCIT_FCREACION
                                , @DCIT_IDTIPO
                                , @DCIT_IDMAQUINA
                                , @DCIT_CALIFICACION
                                , @DCIT_IDBODEGADEST
                                , @DCIT_VLRRTE
                                , @DCIT_TOTALCONIMPUESTO
                                , @DCIT_IDOPCION
                                , @DCIT_IDESCALA
                                , @DCIT_CANTENOC
                                , @DCIT_CANTCOTIZ
                                , @DCIT_ELEGIDO
                                , @DCIT_CANTPROCESADA
                                , @DCIT_NCOTIZACIONES
                                , @DCIT_SUBTOTAL_ME
                                , @DCIT_DESCUENTO_ME
                                , @DCIT_TOTAL_ME
                                , @DCIT_IMPUESTOMAS_ME
                                , @DCIT_IMPUESTOMENOS_ME
                                , @DCIT_TOTALCONIMPUESTO_ME
                                , @DCIT_VLRUNIT_ME
                                , @DCIT_LOCALIZACION
                                , @DCIT_TIPOMOV
                                , @DCIT_IDLISTAPRECIO
                                ) 
                            
                            DECLARE @DOC_IDTIPO AS NVARCHAR(10)
                            DECLARE @OCTP_TIPOCENTROCOSTO AS NVARCHAR(20)

                            SELECT @DOC_IDTIPO = T.OCTP_IDTIPO, @OCTP_TIPOCENTROCOSTO = OCTP_TIPOCENTROCOSTO FROM DOC_PREFIJO AS P WITH(NOLOCK) INNER JOIN DOC_TIPO AS T
                            ON P.DCTP_IDTIPO = T.OCTP_IDTIPO
                            WHERE P.DCTP_PREFIJO = @DCIT_PREFIJO

                            IF @DCIT_PREFIJOORIGEN IS NOT NULL
                            BEGIN
                                EXEC SPDOC_VERIFICAPROCESADOS @DCIT_PREFIJOORIGEN, @DCIT_NUMEROORIGEN, @DCIT_IDITEMORIGEN
                            END

                            DECLARE @TERC_IDCENTROCOSTO AS NVARCHAR(20)
                            IF @OCTP_TIPOCENTROCOSTO = 'SUCURSAL'
                            BEGIN
                                SELECT @TERC_IDCENTROCOSTO = TERC_IDCENTROCOSTO 
                                FROM TRC_TERCERO AS T WITH(NOLOCK) INNER JOIN DOC_DOCUMENTO AS D WITH(NOLOCK) ON T.TERC_IDTERCERO = D.DOC_IDSUCURSAL
                                WHERE DOC_PREFIJO = @DCIT_PREFIJO AND DOC_NUMERO = @DCIT_NUMERO
                    
                                IF @TERC_IDCENTROCOSTO IS NULL
                                BEGIN
                                    SELECT @TERC_IDCENTROCOSTO = MAQ_IDCENTROCOSTO 
                                    FROM MAQ_MAQUINA AS M WITH(NOLOCK) INNER JOIN DOC_DOCUMENTO AS D WITH(NOLOCK) ON M.MAQ_ID = D.DOC_IDMAQUINA
                                    WHERE DOC_PREFIJO = @DCIT_PREFIJO AND DOC_NUMERO = @DCIT_NUMERO
                                END
                            
                                IF @TERC_IDCENTROCOSTO IS NOT NULL
                                BEGIN
                                    INSERT INTO DOC_ITEMCENTROCOSTO (DICC_PREFIJO, DICC_NUMERO, DICC_IDITEM, DICC_IDCENTROCOSTO, DICC_PORCENTAJE, DICC_MONTO)
                                    VALUES (@DCIT_PREFIJO, @DCIT_NUMERO, @DCIT_IDITEM, @TERC_IDCENTROCOSTO, 1, 0)
                                END
                            END
                            IF @OCTP_TIPOCENTROCOSTO = 'EQUIPO'
                            BEGIN
                                SELECT @TERC_IDCENTROCOSTO = MAQ_IDCENTROCOSTO 
                                FROM MAQ_MAQUINA AS M WITH(NOLOCK) INNER JOIN DOC_DOCUMENTO AS D WITH(NOLOCK) ON M.MAQ_ID=D.DOC_IDMAQUINA
                                WHERE DOC_PREFIJO = @DCIT_PREFIJO AND DOC_NUMERO = @DCIT_NUMERO

                                IF @TERC_IDCENTROCOSTO IS  NULL
                                BEGIN
                                    SELECT @TERC_IDCENTROCOSTO = TERC_IDCENTROCOSTO FROM TRC_TERCERO AS T WITH(NOLOCK) INNER JOIN DOC_DOCUMENTO AS D WITH(NOLOCK) ON T.TERC_IDTERCERO = D.DOC_IDSUCURSAL
                                    WHERE DOC_PREFIJO = @DCIT_PREFIJO AND DOC_NUMERO = @DCIT_NUMERO
                                END

                                IF @TERC_IDCENTROCOSTO IS NOT NULL
                                BEGIN
                                    INSERT INTO DOC_ITEMCENTROCOSTO (DICC_PREFIJO, DICC_NUMERO, DICC_IDITEM, DICC_IDCENTROCOSTO, DICC_PORCENTAJE, DICC_MONTO)
                                    VALUES (@DCIT_PREFIJO, @DCIT_NUMERO, @DCIT_IDITEM, @TERC_IDCENTROCOSTO, 1, 0)
                                END
                            END
                            IF @OCTP_TIPOCENTROCOSTO = 'USUARIO'
                            BEGIN
                                DECLARE @IDSOLICITANTE AS BIGINT
                                SELECT @TERC_IDCENTROCOSTO = TERC_IDCENTROCOSTO, @IDSOLICITANTE = DOC_IDSOLICITANTE
                                FROM TRC_TERCERO AS T WITH(NOLOCK)INNER JOIN DOC_DOCUMENTO AS D WITH(NOLOCK) ON T.TERC_IDTERCERO = D.DOC_IDSOLICITANTE
                                WHERE DOC_PREFIJO = @DCIT_PREFIJO AND DOC_NUMERO = @DCIT_NUMERO
                            
                                DECLARE @CUANTOSCC AS INT
                                SELECT @CUANTOSCC = ISNULL(COUNT(*),0) FROM dbo.TRC_TERCEROCENTROCOSTO WITH(NOLOCK) WHERE TRCC_IDTERCERO = @IDSOLICITANTE
                                IF @CUANTOSCC = 1
                                BEGIN
                                    SELECT @TERC_IDCENTROCOSTO = TRCC_IDCENTROCOSTO 
                                    FROM TRC_TERCEROCENTROCOSTO WITH(NOLOCK) WHERE TRCC_IDTERCERO = @IDSOLICITANTE
                                END

                                IF @CUANTOSCC > 1
                                BEGIN
                                    SET @TERC_IDCENTROCOSTO = NULL
                                END

                                IF @TERC_IDCENTROCOSTO IS NOT NULL
                                BEGIN
                                    INSERT INTO DOC_ITEMCENTROCOSTO (DICC_PREFIJO, DICC_NUMERO, DICC_IDITEM, DICC_IDCENTROCOSTO, DICC_PORCENTAJE, DICC_MONTO)
                                    VALUES (@DCIT_PREFIJO, @DCIT_NUMERO, @DCIT_IDITEM, @TERC_IDCENTROCOSTO, 1, 0)			
                                END
                            END	
                                                
                            SELECT @DCIT_IDITEM += 1
                        FETCH NEXT FROM CurItemsDocumento
                            INTO  @DCIT_IDPRODUCTO, @DCIT_IDUNIDAD, @DCIT_DESCRIPCION, @DCIT_OBSERVACIONES, @DCIT_IDITEMPADRE, @DCIT_PREFIJOORIGEN, @DCIT_NUMEROORIGEN, @DCIT_IDITEMORIGEN, @DCIT_CANTSOLICITADA, @DCIT_CANTRECIBIDA, @DCIT_VLRUNIT, @DCIT_PORCDTO, @DCIT_VLRDTO, @DCIT_SUBTOTAL, @DCIT_IDIMPUESTO, @DCIT_PORCIVA, @DCIT_VLRIVA, @DCIT_TOTAL, @DCIT_COSTOUNIT, @DCIT_COSTOTOTAL, @DCIT_MOSTRAR, @DCIT_IDESTADO, @DCIT_IDBODEGA, @DCIT_IDCENTROCOSTO, @DCIT_FCALIFICACION, @DCIT_VLRCALIFICACION, @DCIT_FCREACION, @DCIT_IDTIPO, @DCIT_IDMAQUINA, @DCIT_CALIFICACION, @DCIT_IDBODEGADEST, @DCIT_VLRRTE, @DCIT_TOTALCONIMPUESTO, @DCIT_IDOPCION, @DCIT_IDESCALA, @DCIT_CANTENOC, @DCIT_CANTCOTIZ, @DCIT_ELEGIDO, @DCIT_CANTPROCESADA, @DCIT_NCOTIZACIONES, @DCIT_SUBTOTAL_ME, @DCIT_DESCUENTO_ME, @DCIT_TOTAL_ME, @DCIT_IMPUESTOMAS_ME, @DCIT_IMPUESTOMENOS_ME, @DCIT_TOTALCONIMPUESTO_ME, @DCIT_VLRUNIT_ME, @DCIT_LOCALIZACION, @DCIT_TIPOMOV, @DCIT_IDLISTAPRECIO
                        END
                    CLOSE CurItemsDocumento
                    DEALLOCATE CurItemsDocumento

                GO";
    
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROC SpPedidoVentaInsertCompleto1");
        }
    }
}