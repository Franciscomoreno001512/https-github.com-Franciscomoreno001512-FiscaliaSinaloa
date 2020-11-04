using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Cadena_de_Custodia;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Catalogo_Tipo_de_Cargo_CC;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Catalogo_Unidad_Policial;
using Spartane.Core.Domain.Detalle_del_Certificado_CC;





using Spartane.Core.Domain.Detalle_de_Fotos_CC;




using Spartane.Core.Domain.Detalle_de_Videos_CC;




using Spartane.Core.Domain.Detalle_de_Registro_de_Intervinientes_CC;








using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;







using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes;










using Spartane.Core.Domain.Pais;



using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Tipo_de_Inimputabilidad;


using Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC;
using Spartane.Core.Domain.Detalle_de_Descripcion_de_Evidencia_CC;









using Spartane.Core.Domain.Detalle_de_Lista_de_Documentos_CC;





using Spartane.Core.Domain.Catalogo_Estatus_CC;
using Spartane.Core.Domain.Detalle_de_Retroalimentacion;






using Spartane.Core.Domain.Detalle_de_Referencia;





using Spartane.Core.Domain.Detalle_de_Fotos_de_Emergencia_CC;






using Spartane.Core.Domain.Detalle_de_Historial_de_Emergencia_CC;









using Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_CC;








using Spartane.Core.Domain.Colonia;




using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Estado_Civil;


using Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos;





using Spartane.Core.Domain.Tipo_de_Inimputabilidad;

using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Nacionalidad;





using Spartane.Core.Domain.Ocupacion;

using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Pais;


using Spartane.Core.Domain.Genero;

using Spartane.Core.Domain.Tipo_de_Identificacion;


using Spartane.Core.Domain.Detalle_de_Datos_del_Testigo_CC;






using Spartane.Core.Domain.Colonia;


using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Estado_Civil;



using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Nacionalidad;





using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;

using Spartane.Core.Domain.Genero;

using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Tipo_de_Inimputabilidad;




using Spartane.Core.Domain.Detalle_de_Galeria_de_Testigos;





using Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Catalogo_de_Recoleccion;
using Spartane.Core.Domain.Catalogo_de_Movil_para_traslado;
using Spartane.Core.Domain.Catalogo_Tipo_de_Embalaje_CC;



using Spartane.Core.Domain.Detalle_de_Lista_de_Asignaciones;






using Spartane.Core.Domain.Catalogo_Tipo_de_Fijacion_CC;



using Spartane.Core.Domain.Detalle_de_Traslado_de_CC;







using Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado;

using Spartane.Core.Domain.Catalogo_Tipo_de_Indicio_CC;




using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Cadena_de_Custodia;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Cadena_de_Custodia;
using Spartane.Web.Areas.WebApiConsumer.Delito;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Tipo_de_Cargo_CC;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Unidad_Policial;
using Spartane.Web.Areas.WebApiConsumer.Detalle_del_Certificado_CC;



using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Fotos_CC;


using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Videos_CC;


using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Registro_de_Intervinientes_CC;



using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Galeria_de_Intervinientes;



using Spartane.Web.Areas.WebApiConsumer.Pais;

using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Inimputabilidad;

using Spartane.Web.Areas.WebApiConsumer.Catalogo_Unidad_Administrativa_CC;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Motivo_de_Intervencion_CC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Descripcion_de_Evidencia_CC;


using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Lista_de_Documentos_CC;



using Spartane.Web.Areas.WebApiConsumer.Catalogo_Estatus_CC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Retroalimentacion;




using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Referencia;


using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Fotos_de_Emergencia_CC;




using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Historial_de_Emergencia_CC;




using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_del_Imputado_CC;


using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Galeria_de_Detenidos;



using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Inimputabilidad;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Pais;

using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_del_Testigo_CC;

using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;


using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;

using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Inimputabilidad;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Galeria_de_Testigos;



using Spartane.Web.Areas.WebApiConsumer.Catalogo_de_Inicio_de_Cadena_de_Custodia;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_de_Recoleccion;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_de_Movil_para_traslado;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Tipo_de_Embalaje_CC;


using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Lista_de_Asignaciones;



using Spartane.Web.Areas.WebApiConsumer.Catalogo_Tipo_de_Fijacion_CC;


using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Traslado_de_CC;



using Spartane.Web.Areas.WebApiConsumer.Catalogo_de_Estatus_de_Traslado;

using Spartane.Web.Areas.WebApiConsumer.Catalogo_Tipo_de_Indicio_CC;



using Spartane.Web.AuthFilters;
using Spartane.Web.Helpers;
using Spartane.Web.Models;
using Spartane.Web.SqlModelMapper;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;
using Spartane.Core.Domain.Spartan_Business_Rule;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Business_Rule;
using Spartane.Web.Areas.WebApiConsumer.Spartan_BR_Process_Event_Detail;

using Spartane.Web.Areas.WebApiConsumer.Spartan_Format;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Format_Permissions;
using Spartane.Web.Areas.WebApiConsumer.GeneratePDF;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;

using Spartane.Web.Areas.WebApiConsumer.Spartan_Format_Related;
using Spartane.Core.Domain.Spartan_Format;
using iTextSharp.text.pdf;


namespace Spartane.Web.Areas.Frontal.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class Cadena_de_CustodiaController : Controller
    {
        #region "variable declaration"

        private ICadena_de_CustodiaService service = null;
        private ICadena_de_CustodiaApiConsumer _ICadena_de_CustodiaApiConsumer;
        private IDelitoApiConsumer _IDelitoApiConsumer;
        private ICatalogo_Tipo_de_Cargo_CCApiConsumer _ICatalogo_Tipo_de_Cargo_CCApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ICatalogo_Unidad_PolicialApiConsumer _ICatalogo_Unidad_PolicialApiConsumer;
        private IDetalle_del_Certificado_CCApiConsumer _IDetalle_del_Certificado_CCApiConsumer;



        private IDetalle_de_Fotos_CCApiConsumer _IDetalle_de_Fotos_CCApiConsumer;


        private IDetalle_de_Videos_CCApiConsumer _IDetalle_de_Videos_CCApiConsumer;


        private IDetalle_de_Registro_de_Intervinientes_CCApiConsumer _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer;



        private IGeneroApiConsumer _IGeneroApiConsumer;
        private IEstado_CivilApiConsumer _IEstado_CivilApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private IEscolaridadApiConsumer _IEscolaridadApiConsumer;
        private IOcupacionApiConsumer _IOcupacionApiConsumer;
        private INacionalidadApiConsumer _INacionalidadApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IDetalle_de_Galeria_de_IntervinientesApiConsumer _IDetalle_de_Galeria_de_IntervinientesApiConsumer;




        private ITipo_de_ComparecienteApiConsumer _ITipo_de_ComparecienteApiConsumer;
        private ITipo_de_InimputabilidadApiConsumer _ITipo_de_InimputabilidadApiConsumer;

        private ICatalogo_Unidad_Administrativa_CCApiConsumer _ICatalogo_Unidad_Administrativa_CCApiConsumer;
        private ICatalogo_Motivo_de_Intervencion_CCApiConsumer _ICatalogo_Motivo_de_Intervencion_CCApiConsumer;
        private IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer;


        private IDetalle_de_Lista_de_Documentos_CCApiConsumer _IDetalle_de_Lista_de_Documentos_CCApiConsumer;



        private ICatalogo_Estatus_CCApiConsumer _ICatalogo_Estatus_CCApiConsumer;
        private IDetalle_de_RetroalimentacionApiConsumer _IDetalle_de_RetroalimentacionApiConsumer;




        private IDetalle_de_ReferenciaApiConsumer _IDetalle_de_ReferenciaApiConsumer;


        private IDetalle_de_Fotos_de_Emergencia_CCApiConsumer _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer;




        private IDetalle_de_Historial_de_Emergencia_CCApiConsumer _IDetalle_de_Historial_de_Emergencia_CCApiConsumer;




        private IDetalle_de_Datos_del_Imputado_CCApiConsumer _IDetalle_de_Datos_del_Imputado_CCApiConsumer;



        private IDetalle_de_Galeria_de_DetenidosApiConsumer _IDetalle_de_Galeria_de_DetenidosApiConsumer;





        private IDetalle_de_Datos_del_Testigo_CCApiConsumer _IDetalle_de_Datos_del_Testigo_CCApiConsumer;




        private IDetalle_de_Galeria_de_TestigosApiConsumer _IDetalle_de_Galeria_de_TestigosApiConsumer;



        private ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer _ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer;
        private ICatalogo_de_RecoleccionApiConsumer _ICatalogo_de_RecoleccionApiConsumer;
        private ICatalogo_de_Movil_para_trasladoApiConsumer _ICatalogo_de_Movil_para_trasladoApiConsumer;
        private ICatalogo_Tipo_de_Embalaje_CCApiConsumer _ICatalogo_Tipo_de_Embalaje_CCApiConsumer;


        private IDetalle_de_Lista_de_AsignacionesApiConsumer _IDetalle_de_Lista_de_AsignacionesApiConsumer;



        private ICatalogo_Tipo_de_Fijacion_CCApiConsumer _ICatalogo_Tipo_de_Fijacion_CCApiConsumer;


        private IDetalle_de_Traslado_de_CCApiConsumer _IDetalle_de_Traslado_de_CCApiConsumer;



        private ICatalogo_de_Estatus_de_TrasladoApiConsumer _ICatalogo_de_Estatus_de_TrasladoApiConsumer;

        private ICatalogo_Tipo_de_Indicio_CCApiConsumer _ICatalogo_Tipo_de_Indicio_CCApiConsumer;



        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;
        private IGeneratePDFApiConsumer _IGeneratePDFApiConsumer;
        private ISpartan_FormatApiConsumer _ISpartan_FormatApiConsumer;
        private ISpartan_Format_PermissionsApiConsumer _ISpartan_Format_PermissionsApiConsumer;
		private ISpartan_Format_RelatedApiConsumer _ISpartan_FormatRelatedApiConsumer;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Cadena_de_CustodiaController(ICadena_de_CustodiaService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ICadena_de_CustodiaApiConsumer Cadena_de_CustodiaApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IDelitoApiConsumer DelitoApiConsumer , ICatalogo_Tipo_de_Cargo_CCApiConsumer Catalogo_Tipo_de_Cargo_CCApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ICatalogo_Unidad_PolicialApiConsumer Catalogo_Unidad_PolicialApiConsumer , IDetalle_del_Certificado_CCApiConsumer Detalle_del_Certificado_CCApiConsumer  , IDetalle_de_Fotos_CCApiConsumer Detalle_de_Fotos_CCApiConsumer  , IDetalle_de_Videos_CCApiConsumer Detalle_de_Videos_CCApiConsumer  , IDetalle_de_Registro_de_Intervinientes_CCApiConsumer Detalle_de_Registro_de_Intervinientes_CCApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , IEscolaridadApiConsumer EscolaridadApiConsumer , IOcupacionApiConsumer OcupacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IPaisApiConsumer PaisApiConsumer , IDetalle_de_Galeria_de_IntervinientesApiConsumer Detalle_de_Galeria_de_IntervinientesApiConsumer  , ITipo_de_ComparecienteApiConsumer Tipo_de_ComparecienteApiConsumer , ITipo_de_InimputabilidadApiConsumer Tipo_de_InimputabilidadApiConsumer  , ICatalogo_Unidad_Administrativa_CCApiConsumer Catalogo_Unidad_Administrativa_CCApiConsumer , ICatalogo_Motivo_de_Intervencion_CCApiConsumer Catalogo_Motivo_de_Intervencion_CCApiConsumer , IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer Detalle_de_Descripcion_de_Evidencia_CCApiConsumer  , IDetalle_de_Lista_de_Documentos_CCApiConsumer Detalle_de_Lista_de_Documentos_CCApiConsumer  , ICatalogo_Estatus_CCApiConsumer Catalogo_Estatus_CCApiConsumer , IDetalle_de_RetroalimentacionApiConsumer Detalle_de_RetroalimentacionApiConsumer  , IDetalle_de_ReferenciaApiConsumer Detalle_de_ReferenciaApiConsumer  , IDetalle_de_Fotos_de_Emergencia_CCApiConsumer Detalle_de_Fotos_de_Emergencia_CCApiConsumer  , IDetalle_de_Historial_de_Emergencia_CCApiConsumer Detalle_de_Historial_de_Emergencia_CCApiConsumer  , IDetalle_de_Datos_del_Imputado_CCApiConsumer Detalle_de_Datos_del_Imputado_CCApiConsumer , IDetalle_de_Galeria_de_DetenidosApiConsumer Detalle_de_Galeria_de_DetenidosApiConsumer   , IDetalle_de_Datos_del_Testigo_CCApiConsumer Detalle_de_Datos_del_Testigo_CCApiConsumer , IDetalle_de_Galeria_de_TestigosApiConsumer Detalle_de_Galeria_de_TestigosApiConsumer   , ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer Catalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer , ICatalogo_de_RecoleccionApiConsumer Catalogo_de_RecoleccionApiConsumer , ICatalogo_de_Movil_para_trasladoApiConsumer Catalogo_de_Movil_para_trasladoApiConsumer , ICatalogo_Tipo_de_Embalaje_CCApiConsumer Catalogo_Tipo_de_Embalaje_CCApiConsumer  , IDetalle_de_Lista_de_AsignacionesApiConsumer Detalle_de_Lista_de_AsignacionesApiConsumer  , ICatalogo_Tipo_de_Fijacion_CCApiConsumer Catalogo_Tipo_de_Fijacion_CCApiConsumer  , IDetalle_de_Traslado_de_CCApiConsumer Detalle_de_Traslado_de_CCApiConsumer , ICatalogo_de_Estatus_de_TrasladoApiConsumer Catalogo_de_Estatus_de_TrasladoApiConsumer  , ICatalogo_Tipo_de_Indicio_CCApiConsumer Catalogo_Tipo_de_Indicio_CCApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ICadena_de_CustodiaApiConsumer = Cadena_de_CustodiaApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IDelitoApiConsumer = DelitoApiConsumer;
            this._ICatalogo_Tipo_de_Cargo_CCApiConsumer = Catalogo_Tipo_de_Cargo_CCApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ICatalogo_Unidad_PolicialApiConsumer = Catalogo_Unidad_PolicialApiConsumer;
            this._IDetalle_del_Certificado_CCApiConsumer = Detalle_del_Certificado_CCApiConsumer;



            this._IDetalle_de_Fotos_CCApiConsumer = Detalle_de_Fotos_CCApiConsumer;


            this._IDetalle_de_Videos_CCApiConsumer = Detalle_de_Videos_CCApiConsumer;


            this._IDetalle_de_Registro_de_Intervinientes_CCApiConsumer = Detalle_de_Registro_de_Intervinientes_CCApiConsumer;



            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IDetalle_de_Galeria_de_IntervinientesApiConsumer = Detalle_de_Galeria_de_IntervinientesApiConsumer;



            this._IPaisApiConsumer = PaisApiConsumer;

            this._ITipo_de_ComparecienteApiConsumer = Tipo_de_ComparecienteApiConsumer;
            this._ITipo_de_InimputabilidadApiConsumer = Tipo_de_InimputabilidadApiConsumer;

            this._ICatalogo_Unidad_Administrativa_CCApiConsumer = Catalogo_Unidad_Administrativa_CCApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._ICatalogo_Motivo_de_Intervencion_CCApiConsumer = Catalogo_Motivo_de_Intervencion_CCApiConsumer;
            this._IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer = Detalle_de_Descripcion_de_Evidencia_CCApiConsumer;


            this._IDetalle_de_Lista_de_Documentos_CCApiConsumer = Detalle_de_Lista_de_Documentos_CCApiConsumer;



            this._ICatalogo_Estatus_CCApiConsumer = Catalogo_Estatus_CCApiConsumer;
            this._IDetalle_de_RetroalimentacionApiConsumer = Detalle_de_RetroalimentacionApiConsumer;




            this._IDetalle_de_ReferenciaApiConsumer = Detalle_de_ReferenciaApiConsumer;


            this._IDetalle_de_Fotos_de_Emergencia_CCApiConsumer = Detalle_de_Fotos_de_Emergencia_CCApiConsumer;




            this._IDetalle_de_Historial_de_Emergencia_CCApiConsumer = Detalle_de_Historial_de_Emergencia_CCApiConsumer;




            this._IDetalle_de_Datos_del_Imputado_CCApiConsumer = Detalle_de_Datos_del_Imputado_CCApiConsumer;


            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;

            this._IDetalle_de_Galeria_de_DetenidosApiConsumer = Detalle_de_Galeria_de_DetenidosApiConsumer;



            this._ITipo_de_InimputabilidadApiConsumer = Tipo_de_InimputabilidadApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;

            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;

            this._IDetalle_de_Datos_del_Testigo_CCApiConsumer = Detalle_de_Datos_del_Testigo_CCApiConsumer;

            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;


            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;

            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._ITipo_de_ComparecienteApiConsumer = Tipo_de_ComparecienteApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._ITipo_de_InimputabilidadApiConsumer = Tipo_de_InimputabilidadApiConsumer;
            this._IDetalle_de_Galeria_de_TestigosApiConsumer = Detalle_de_Galeria_de_TestigosApiConsumer;



            this._ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer = Catalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer;
            this._ITipo_de_ComparecienteApiConsumer = Tipo_de_ComparecienteApiConsumer;
            this._ICatalogo_de_RecoleccionApiConsumer = Catalogo_de_RecoleccionApiConsumer;
            this._ICatalogo_de_Movil_para_trasladoApiConsumer = Catalogo_de_Movil_para_trasladoApiConsumer;
            this._ICatalogo_Tipo_de_Embalaje_CCApiConsumer = Catalogo_Tipo_de_Embalaje_CCApiConsumer;


            this._IDetalle_de_Lista_de_AsignacionesApiConsumer = Detalle_de_Lista_de_AsignacionesApiConsumer;



            this._ICatalogo_Tipo_de_Fijacion_CCApiConsumer = Catalogo_Tipo_de_Fijacion_CCApiConsumer;


            this._IDetalle_de_Traslado_de_CCApiConsumer = Detalle_de_Traslado_de_CCApiConsumer;



            this._ICatalogo_de_Estatus_de_TrasladoApiConsumer = Catalogo_de_Estatus_de_TrasladoApiConsumer;

            this._ICatalogo_Tipo_de_Indicio_CCApiConsumer = Catalogo_Tipo_de_Indicio_CCApiConsumer;



        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Cadena_de_Custodia
        [ObjectAuth(ObjectId = (ModuleObjectId)45133, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index(int ModuleId=0)
        {
			if (Session["AdvanceReportFilter"] != null)
            {
                Session["AdvanceReportFilter"] = null;
                Session["AdvanceSearch"] = null;
            }
			if (ModuleId == 0)
            {
                ModuleId = Convert.ToInt32(Session["CurrentModuleId"]);
                if (ModuleId == 0)
                {
                    Response.Redirect("~/");
                }
            }
            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45133, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Cadena_de_Custodia/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45133, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45133, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varCadena_de_Custodia = new Cadena_de_CustodiaModel();
			varCadena_de_Custodia.Clave = Id;
			
            ViewBag.ObjectId = "45133";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_del_Certificado_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45136, ModuleId);
            ViewBag.PermissionDetalle_del_Certificado_CC = permissionDetalle_del_Certificado_CC;
            var permissionDetalle_de_Fotos_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45137, ModuleId);
            ViewBag.PermissionDetalle_de_Fotos_CC = permissionDetalle_de_Fotos_CC;
            var permissionDetalle_de_Videos_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45138, ModuleId);
            ViewBag.PermissionDetalle_de_Videos_CC = permissionDetalle_de_Videos_CC;
            var permissionDetalle_de_Registro_de_Intervinientes_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45139, ModuleId);
            ViewBag.PermissionDetalle_de_Registro_de_Intervinientes_CC = permissionDetalle_de_Registro_de_Intervinientes_CC;
            var permissionDetalle_de_Descripcion_de_Evidencia_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45140, ModuleId);
            ViewBag.PermissionDetalle_de_Descripcion_de_Evidencia_CC = permissionDetalle_de_Descripcion_de_Evidencia_CC;
            var permissionDetalle_de_Lista_de_Documentos_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45141, ModuleId);
            ViewBag.PermissionDetalle_de_Lista_de_Documentos_CC = permissionDetalle_de_Lista_de_Documentos_CC;
            var permissionDetalle_de_Retroalimentacion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45218, ModuleId);
            ViewBag.PermissionDetalle_de_Retroalimentacion = permissionDetalle_de_Retroalimentacion;
            var permissionDetalle_de_Referencia = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45219, ModuleId);
            ViewBag.PermissionDetalle_de_Referencia = permissionDetalle_de_Referencia;
            var permissionDetalle_de_Fotos_de_Emergencia_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45220, ModuleId);
            ViewBag.PermissionDetalle_de_Fotos_de_Emergencia_CC = permissionDetalle_de_Fotos_de_Emergencia_CC;
            var permissionDetalle_de_Historial_de_Emergencia_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45221, ModuleId);
            ViewBag.PermissionDetalle_de_Historial_de_Emergencia_CC = permissionDetalle_de_Historial_de_Emergencia_CC;
            var permissionDetalle_de_Datos_del_Imputado_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45222, ModuleId);
            ViewBag.PermissionDetalle_de_Datos_del_Imputado_CC = permissionDetalle_de_Datos_del_Imputado_CC;
            var permissionDetalle_de_Datos_del_Testigo_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45224, ModuleId);
            ViewBag.PermissionDetalle_de_Datos_del_Testigo_CC = permissionDetalle_de_Datos_del_Testigo_CC;
            var permissionCatalogo_Tipo_de_Embalaje_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45146, ModuleId);
            ViewBag.PermissionCatalogo_Tipo_de_Embalaje_CC = permissionCatalogo_Tipo_de_Embalaje_CC;
            var permissionDetalle_de_Lista_de_Asignaciones = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45229, ModuleId);
            ViewBag.PermissionDetalle_de_Lista_de_Asignaciones = permissionDetalle_de_Lista_de_Asignaciones;
            var permissionCatalogo_Tipo_de_Fijacion_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45144, ModuleId);
            ViewBag.PermissionCatalogo_Tipo_de_Fijacion_CC = permissionCatalogo_Tipo_de_Fijacion_CC;
            var permissionDetalle_de_Traslado_de_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45230, ModuleId);
            ViewBag.PermissionDetalle_de_Traslado_de_CC = permissionDetalle_de_Traslado_de_CC;
            var permissionCatalogo_Tipo_de_Indicio_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45145, ModuleId);
            ViewBag.PermissionCatalogo_Tipo_de_Indicio_CC = permissionCatalogo_Tipo_de_Indicio_CC;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Cadena_de_CustodiasData = _ICadena_de_CustodiaApiConsumer.ListaSelAll(0, 1000, "Cadena_de_Custodia.Clave=" + Id, "").Resource.Cadena_de_Custodias;
				
				if (Cadena_de_CustodiasData != null && Cadena_de_CustodiasData.Count > 0)
                {
					var Cadena_de_CustodiaData = Cadena_de_CustodiasData.First();
					varCadena_de_Custodia= new Cadena_de_CustodiaModel
					{
						Clave  = Cadena_de_CustodiaData.Clave 
	                    ,NUC = Cadena_de_CustodiaData.NUC
                    ,NIC = Cadena_de_CustodiaData.NIC
                    ,Delito_Referencia = Cadena_de_CustodiaData.Delito_Referencia
                    ,Delito_ReferenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Delito_Referencia), "Delito") ??  (string)Cadena_de_CustodiaData.Delito_Referencia_Delito.Descripcion
                    ,Fecha = (Cadena_de_CustodiaData.Fecha == null ? string.Empty : Convert.ToDateTime(Cadena_de_CustodiaData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Cadena_de_CustodiaData.Hora
                    ,Lugar_Exacto_del_Levantamiento = Cadena_de_CustodiaData.Lugar_Exacto_del_Levantamiento
                    ,Condicion_y_Ubicacion = Cadena_de_CustodiaData.Condicion_y_Ubicacion
                    ,Levantada_por = Cadena_de_CustodiaData.Levantada_por
                    ,Cargo = Cadena_de_CustodiaData.Cargo
                    ,CargoTipo_de_Cargo = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Cargo), "Catalogo_Tipo_de_Cargo_CC") ??  (string)Cadena_de_CustodiaData.Cargo_Catalogo_Tipo_de_Cargo_CC.Tipo_de_Cargo
                    ,Asignar = Cadena_de_CustodiaData.Asignar
                    ,AsignarName = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Asignar), "Spartan_User") ??  (string)Cadena_de_CustodiaData.Asignar_Spartan_User.Name
                    ,Folio_NUE = Cadena_de_CustodiaData.Folio_NUE
                    ,Unidad_Policial = Cadena_de_CustodiaData.Unidad_Policial
                    ,Unidad_PolicialUnidad_Policial = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Unidad_Policial), "Catalogo_Unidad_Policial") ??  (string)Cadena_de_CustodiaData.Unidad_Policial_Catalogo_Unidad_Policial.Unidad_Policial
                    ,Caracterististicas_del_indicio = Cadena_de_CustodiaData.Caracterististicas_del_indicio
                    ,Condiciones_De_Manejo = Cadena_de_CustodiaData.Condiciones_De_Manejo
                    ,Numero_de_Parte = Cadena_de_CustodiaData.Numero_de_Parte
                    ,CUIP = Cadena_de_CustodiaData.CUIP
                    ,Observaciones = Cadena_de_CustodiaData.Observaciones
                    ,Longitud = Cadena_de_CustodiaData.Longitud
                    ,Latitud = Cadena_de_CustodiaData.Latitud
                    ,Clima = Cadena_de_CustodiaData.Clima
                    ,Grados = Cadena_de_CustodiaData.Grados
                    ,Fijacion_Planimetrica = Cadena_de_CustodiaData.Fijacion_Planimetrica
                    ,Mensaje = Cadena_de_CustodiaData.Mensaje
                    ,Unidad_Administrativa = Cadena_de_CustodiaData.Unidad_Administrativa
                    ,Unidad_AdministrativaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Unidad_Administrativa), "Catalogo_Unidad_Administrativa_CC") ??  (string)Cadena_de_CustodiaData.Unidad_Administrativa_Catalogo_Unidad_Administrativa_CC.Descripcion
                    ,Entidad_Federativa = Cadena_de_CustodiaData.Entidad_Federativa
                    ,Entidad_FederativaNombre = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Entidad_Federativa), "Estado") ??  (string)Cadena_de_CustodiaData.Entidad_Federativa_Estado.Nombre
                    ,Municipio = Cadena_de_CustodiaData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Municipio), "Municipio") ??  (string)Cadena_de_CustodiaData.Municipio_Municipio.Nombre
                    ,Numero_de_Oficio = Cadena_de_CustodiaData.Numero_de_Oficio
                    ,Fecha_CC = (Cadena_de_CustodiaData.Fecha_CC == null ? string.Empty : Convert.ToDateTime(Cadena_de_CustodiaData.Fecha_CC).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_CC = Cadena_de_CustodiaData.Hora_CC
                    ,Motivo_de_Intervencion = Cadena_de_CustodiaData.Motivo_de_Intervencion
                    ,Motivo_de_IntervencionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Motivo_de_Intervencion), "Catalogo_Motivo_de_Intervencion_CC") ??  (string)Cadena_de_CustodiaData.Motivo_de_Intervencion_Catalogo_Motivo_de_Intervencion_CC.Descripcion
                    ,Otro = Cadena_de_CustodiaData.Otro
                    ,Estatus = Cadena_de_CustodiaData.Estatus
                    ,EstatusEstatus = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Estatus), "Catalogo_Estatus_CC") ??  (string)Cadena_de_CustodiaData.Estatus_Catalogo_Estatus_CC.Estatus
                    ,Nombre_Completo = Cadena_de_CustodiaData.Nombre_Completo
                    ,Usuario_que_Registra = Cadena_de_CustodiaData.Usuario_que_Registra
                    ,FAE = Cadena_de_CustodiaData.FAE
                    ,Fecha_de_la_Emergencia = (Cadena_de_CustodiaData.Fecha_de_la_Emergencia == null ? string.Empty : Convert.ToDateTime(Cadena_de_CustodiaData.Fecha_de_la_Emergencia).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_la_Emergencia = Cadena_de_CustodiaData.Hora_de_la_Emergencia
                    ,Fuente = Cadena_de_CustodiaData.Fuente
                    ,Telefono = Cadena_de_CustodiaData.Telefono
                    ,Celular = Cadena_de_CustodiaData.Celular
                    ,Correo_Electronico = Cadena_de_CustodiaData.Correo_Electronico
                    ,Red_Social = Cadena_de_CustodiaData.Red_Social
                    ,Medio_Masivo = Cadena_de_CustodiaData.Medio_Masivo
                    ,Cargo_de_la_Autoridad = Cadena_de_CustodiaData.Cargo_de_la_Autoridad
                    ,Tipo_de_Emergencia = Cadena_de_CustodiaData.Tipo_de_Emergencia
                    ,Descripcion_de_la_Emergencia = Cadena_de_CustodiaData.Descripcion_de_la_Emergencia
                    ,Probables_Detenidos = Cadena_de_CustodiaData.Probables_Detenidos.GetValueOrDefault()
                    ,Fecha_de_la_Detencion = (Cadena_de_CustodiaData.Fecha_de_la_Detencion == null ? string.Empty : Convert.ToDateTime(Cadena_de_CustodiaData.Fecha_de_la_Detencion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_la_Detencion = Cadena_de_CustodiaData.Hora_de_la_Detencion
                    ,Pais_Emergencia = Cadena_de_CustodiaData.Pais_Emergencia
                    ,Estado_Emergencia = Cadena_de_CustodiaData.Estado_Emergencia
                    ,Municipio_Emergencia = Cadena_de_CustodiaData.Municipio_Emergencia
                    ,Colonia_Emergencia = Cadena_de_CustodiaData.Colonia_Emergencia
                    ,Calle_Emergencia = Cadena_de_CustodiaData.Calle_Emergencia
                    ,Entre_Calle_Emergencia = Cadena_de_CustodiaData.Entre_Calle_Emergencia
                    ,Y_Calle_Emergencia = Cadena_de_CustodiaData.Y_Calle_Emergencia
                    ,Latitud_Emergencia = Cadena_de_CustodiaData.Latitud_Emergencia
                    ,Longitud_Emergencia = Cadena_de_CustodiaData.Longitud_Emergencia
                    ,Nombre_de_la_Autoridad = Cadena_de_CustodiaData.Nombre_de_la_Autoridad
                    ,Especifique = Cadena_de_CustodiaData.Especifique
                    ,Tipo_de_Agente = Cadena_de_CustodiaData.Tipo_de_Agente
                    ,Area = Cadena_de_CustodiaData.Area
                    ,Unidad = Cadena_de_CustodiaData.Unidad
                    ,Zona = Cadena_de_CustodiaData.Zona
                    ,Agente_Investigador = Cadena_de_CustodiaData.Agente_Investigador
                    ,Narrativa_de_los_Hechos = Cadena_de_CustodiaData.Narrativa_de_los_Hechos
                    ,Probable_Delito_Principal = Cadena_de_CustodiaData.Probable_Delito_Principal
                    ,Fecha_de_Asignacion = (Cadena_de_CustodiaData.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(Cadena_de_CustodiaData.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Asignacion = Cadena_de_CustodiaData.Hora_de_Asignacion
                    ,Estatus_NUE = Cadena_de_CustodiaData.Estatus_NUE
                    ,Inicio_de_Cadena_de_Custodia = Cadena_de_CustodiaData.Inicio_de_Cadena_de_Custodia
                    ,Inicio_de_Cadena_de_CustodiaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Inicio_de_Cadena_de_Custodia), "Catalogo_de_Inicio_de_Cadena_de_Custodia") ??  (string)Cadena_de_CustodiaData.Inicio_de_Cadena_de_Custodia_Catalogo_de_Inicio_de_Cadena_de_Custodia.Descripcion
                    ,Calidad_de_quien_aporta = Cadena_de_CustodiaData.Calidad_de_quien_aporta
                    ,Calidad_de_quien_aportaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Calidad_de_quien_aporta), "Tipo_de_Compareciente") ??  (string)Cadena_de_CustodiaData.Calidad_de_quien_aporta_Tipo_de_Compareciente.Descripcion
                    ,Fecha_del_arribo = (Cadena_de_CustodiaData.Fecha_del_arribo == null ? string.Empty : Convert.ToDateTime(Cadena_de_CustodiaData.Fecha_del_arribo).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_del_arribo = Cadena_de_CustodiaData.Hora_del_arribo
                    ,Descripcion_de_recoleccion = Cadena_de_CustodiaData.Descripcion_de_recoleccion
                    ,Descripcion_de_recoleccionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Descripcion_de_recoleccion), "Catalogo_de_Recoleccion") ??  (string)Cadena_de_CustodiaData.Descripcion_de_recoleccion_Catalogo_de_Recoleccion.Descripcion
                    ,Movil_para_Traslado = Cadena_de_CustodiaData.Movil_para_Traslado
                    ,Movil_para_TrasladoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Movil_para_Traslado), "Catalogo_de_Movil_para_traslado") ??  (string)Cadena_de_CustodiaData.Movil_para_Traslado_Catalogo_de_Movil_para_traslado.Descripcion
                    ,Servidor_Publico_que_Preserva = Cadena_de_CustodiaData.Servidor_Publico_que_Preserva
                    ,Servidor_Publico_que_Busca = Cadena_de_CustodiaData.Servidor_Publico_que_Busca
                    ,Servidor_Publico_que_Localiza = Cadena_de_CustodiaData.Servidor_Publico_que_Localiza
                    ,Servidor_Publico_que_Recolecta = Cadena_de_CustodiaData.Servidor_Publico_que_Recolecta
                    ,Servidor_Publico_que_Traslada = Cadena_de_CustodiaData.Servidor_Publico_que_Traslada
                    ,Preservacion = Cadena_de_CustodiaData.Preservacion
                    ,Busqueda = Cadena_de_CustodiaData.Busqueda
                    ,Localizacion = Cadena_de_CustodiaData.Localizacion
                    ,Recoleccion = Cadena_de_CustodiaData.Recoleccion

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Fijacion_PlanimetricaSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varCadena_de_Custodia.Fijacion_Planimetrica).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito_Referencia = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito_Referencia != null && Delitos_Delito_Referencia.Resource != null)
                ViewBag.Delitos_Delito_Referencia = Delitos_Delito_Referencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Tipo_de_Cargo_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Tipo_de_Cargo_CCs_Cargo = _ICatalogo_Tipo_de_Cargo_CCApiConsumer.SelAll(true);
            if (Catalogo_Tipo_de_Cargo_CCs_Cargo != null && Catalogo_Tipo_de_Cargo_CCs_Cargo.Resource != null)
                ViewBag.Catalogo_Tipo_de_Cargo_CCs_Cargo = Catalogo_Tipo_de_Cargo_CCs_Cargo.Resource.Where(m => m.Tipo_de_Cargo != null).OrderBy(m => m.Tipo_de_Cargo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Tipo_de_Cargo_CC", "Tipo_de_Cargo") ?? m.Tipo_de_Cargo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Asignar = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Asignar != null && Spartan_Users_Asignar.Resource != null)
                ViewBag.Spartan_Users_Asignar = Spartan_Users_Asignar.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ICatalogo_Unidad_PolicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Unidad_Policials_Unidad_Policial = _ICatalogo_Unidad_PolicialApiConsumer.SelAll(true);
            if (Catalogo_Unidad_Policials_Unidad_Policial != null && Catalogo_Unidad_Policials_Unidad_Policial.Resource != null)
                ViewBag.Catalogo_Unidad_Policials_Unidad_Policial = Catalogo_Unidad_Policials_Unidad_Policial.Resource.Where(m => m.Unidad_Policial != null).OrderBy(m => m.Unidad_Policial).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Unidad_Policial", "Unidad_Policial") ?? m.Unidad_Policial.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Unidad_Administrativa_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa = _ICatalogo_Unidad_Administrativa_CCApiConsumer.SelAll(true);
            if (Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa != null && Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa.Resource != null)
                ViewBag.Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa = Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Unidad_Administrativa_CC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Entidad_Federativa = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Entidad_Federativa != null && Estados_Entidad_Federativa.Resource != null)
                ViewBag.Estados_Entidad_Federativa = Estados_Entidad_Federativa.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Motivo_de_Intervencion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion = _ICatalogo_Motivo_de_Intervencion_CCApiConsumer.SelAll(true);
            if (Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion != null && Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion.Resource != null)
                ViewBag.Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion = Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Motivo_de_Intervencion_CC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Estatus_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Estatus_CCs_Estatus = _ICatalogo_Estatus_CCApiConsumer.SelAll(true);
            if (Catalogo_Estatus_CCs_Estatus != null && Catalogo_Estatus_CCs_Estatus.Resource != null)
                ViewBag.Catalogo_Estatus_CCs_Estatus = Catalogo_Estatus_CCs_Estatus.Resource.Where(m => m.Estatus != null).OrderBy(m => m.Estatus).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Estatus_CC", "Estatus") ?? m.Estatus.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia = _ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer.SelAll(true);
            if (Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia != null && Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia.Resource != null)
                ViewBag.Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia = Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Inicio_de_Cadena_de_Custodia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Calidad_de_quien_aporta = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Calidad_de_quien_aporta != null && Tipo_de_Comparecientes_Calidad_de_quien_aporta.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Calidad_de_quien_aporta = Tipo_de_Comparecientes_Calidad_de_quien_aporta.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_de_RecoleccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_de_Recoleccions_Descripcion_de_recoleccion = _ICatalogo_de_RecoleccionApiConsumer.SelAll(true);
            if (Catalogo_de_Recoleccions_Descripcion_de_recoleccion != null && Catalogo_de_Recoleccions_Descripcion_de_recoleccion.Resource != null)
                ViewBag.Catalogo_de_Recoleccions_Descripcion_de_recoleccion = Catalogo_de_Recoleccions_Descripcion_de_recoleccion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Recoleccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_de_Movil_para_trasladoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_de_Movil_para_traslados_Movil_para_Traslado = _ICatalogo_de_Movil_para_trasladoApiConsumer.SelAll(true);
            if (Catalogo_de_Movil_para_traslados_Movil_para_Traslado != null && Catalogo_de_Movil_para_traslados_Movil_para_Traslado.Resource != null)
                ViewBag.Catalogo_de_Movil_para_traslados_Movil_para_Traslado = Catalogo_de_Movil_para_traslados_Movil_para_Traslado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Movil_para_traslado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
				
			var viewInEframe = false;
			var isPartial = false;
            var isMR = false;
            var nameMR = string.Empty;
            var nameAttribute = string.Empty;

	        if (Request.QueryString["isPartial"]!= null)
                isPartial = Convert.ToBoolean(Request.QueryString["isPartial"]);

            if (Request.QueryString["isMR"] != null)
                isMR = Convert.ToBoolean(Request.QueryString["isMR"]);

            if (Request.QueryString["nameMR"] != null)
                nameMR = Request.QueryString["nameMR"].ToString();

            if (Request.QueryString["nameAttribute"] != null)
                nameAttribute = Request.QueryString["nameAttribute"].ToString();
				
			if (Request.QueryString["viewInEframe"] != null)
                viewInEframe = Convert.ToBoolean(Request.QueryString["viewInEframe"]);	
				
			ViewBag.isPartial=isPartial;
			ViewBag.isMR=isMR;
			ViewBag.nameMR=nameMR;
			ViewBag.nameAttribute=nameAttribute;
			ViewBag.viewInEframe = viewInEframe;

				
            return View(varCadena_de_Custodia);
        }
		
	[HttpGet]
        public ActionResult AddCadena_de_Custodia(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45133);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
			Cadena_de_CustodiaModel varCadena_de_Custodia= new Cadena_de_CustodiaModel();
            var permissionDetalle_del_Certificado_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45136, ModuleId);
            ViewBag.PermissionDetalle_del_Certificado_CC = permissionDetalle_del_Certificado_CC;
            var permissionDetalle_de_Fotos_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45137, ModuleId);
            ViewBag.PermissionDetalle_de_Fotos_CC = permissionDetalle_de_Fotos_CC;
            var permissionDetalle_de_Videos_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45138, ModuleId);
            ViewBag.PermissionDetalle_de_Videos_CC = permissionDetalle_de_Videos_CC;
            var permissionDetalle_de_Registro_de_Intervinientes_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45139, ModuleId);
            ViewBag.PermissionDetalle_de_Registro_de_Intervinientes_CC = permissionDetalle_de_Registro_de_Intervinientes_CC;
            var permissionDetalle_de_Descripcion_de_Evidencia_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45140, ModuleId);
            ViewBag.PermissionDetalle_de_Descripcion_de_Evidencia_CC = permissionDetalle_de_Descripcion_de_Evidencia_CC;
            var permissionDetalle_de_Lista_de_Documentos_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45141, ModuleId);
            ViewBag.PermissionDetalle_de_Lista_de_Documentos_CC = permissionDetalle_de_Lista_de_Documentos_CC;
            var permissionDetalle_de_Retroalimentacion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45218, ModuleId);
            ViewBag.PermissionDetalle_de_Retroalimentacion = permissionDetalle_de_Retroalimentacion;
            var permissionDetalle_de_Referencia = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45219, ModuleId);
            ViewBag.PermissionDetalle_de_Referencia = permissionDetalle_de_Referencia;
            var permissionDetalle_de_Fotos_de_Emergencia_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45220, ModuleId);
            ViewBag.PermissionDetalle_de_Fotos_de_Emergencia_CC = permissionDetalle_de_Fotos_de_Emergencia_CC;
            var permissionDetalle_de_Historial_de_Emergencia_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45221, ModuleId);
            ViewBag.PermissionDetalle_de_Historial_de_Emergencia_CC = permissionDetalle_de_Historial_de_Emergencia_CC;
            var permissionDetalle_de_Datos_del_Imputado_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45222, ModuleId);
            ViewBag.PermissionDetalle_de_Datos_del_Imputado_CC = permissionDetalle_de_Datos_del_Imputado_CC;
            var permissionDetalle_de_Datos_del_Testigo_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45224, ModuleId);
            ViewBag.PermissionDetalle_de_Datos_del_Testigo_CC = permissionDetalle_de_Datos_del_Testigo_CC;
            var permissionCatalogo_Tipo_de_Embalaje_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45146, ModuleId);
            ViewBag.PermissionCatalogo_Tipo_de_Embalaje_CC = permissionCatalogo_Tipo_de_Embalaje_CC;
            var permissionDetalle_de_Lista_de_Asignaciones = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45229, ModuleId);
            ViewBag.PermissionDetalle_de_Lista_de_Asignaciones = permissionDetalle_de_Lista_de_Asignaciones;
            var permissionCatalogo_Tipo_de_Fijacion_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45144, ModuleId);
            ViewBag.PermissionCatalogo_Tipo_de_Fijacion_CC = permissionCatalogo_Tipo_de_Fijacion_CC;
            var permissionDetalle_de_Traslado_de_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45230, ModuleId);
            ViewBag.PermissionDetalle_de_Traslado_de_CC = permissionDetalle_de_Traslado_de_CC;
            var permissionCatalogo_Tipo_de_Indicio_CC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45145, ModuleId);
            ViewBag.PermissionCatalogo_Tipo_de_Indicio_CC = permissionCatalogo_Tipo_de_Indicio_CC;


            if (id.ToString() != "0")
            {
                var Cadena_de_CustodiasData = _ICadena_de_CustodiaApiConsumer.ListaSelAll(0, 1000, "Cadena_de_Custodia.Clave=" + id, "").Resource.Cadena_de_Custodias;
				
				if (Cadena_de_CustodiasData != null && Cadena_de_CustodiasData.Count > 0)
                {
					var Cadena_de_CustodiaData = Cadena_de_CustodiasData.First();
					varCadena_de_Custodia= new Cadena_de_CustodiaModel
					{
						Clave  = Cadena_de_CustodiaData.Clave 
	                    ,NUC = Cadena_de_CustodiaData.NUC
                    ,NIC = Cadena_de_CustodiaData.NIC
                    ,Delito_Referencia = Cadena_de_CustodiaData.Delito_Referencia
                    ,Delito_ReferenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Delito_Referencia), "Delito") ??  (string)Cadena_de_CustodiaData.Delito_Referencia_Delito.Descripcion
                    ,Fecha = (Cadena_de_CustodiaData.Fecha == null ? string.Empty : Convert.ToDateTime(Cadena_de_CustodiaData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Cadena_de_CustodiaData.Hora
                    ,Lugar_Exacto_del_Levantamiento = Cadena_de_CustodiaData.Lugar_Exacto_del_Levantamiento
                    ,Condicion_y_Ubicacion = Cadena_de_CustodiaData.Condicion_y_Ubicacion
                    ,Levantada_por = Cadena_de_CustodiaData.Levantada_por
                    ,Cargo = Cadena_de_CustodiaData.Cargo
                    ,CargoTipo_de_Cargo = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Cargo), "Catalogo_Tipo_de_Cargo_CC") ??  (string)Cadena_de_CustodiaData.Cargo_Catalogo_Tipo_de_Cargo_CC.Tipo_de_Cargo
                    ,Asignar = Cadena_de_CustodiaData.Asignar
                    ,AsignarName = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Asignar), "Spartan_User") ??  (string)Cadena_de_CustodiaData.Asignar_Spartan_User.Name
                    ,Folio_NUE = Cadena_de_CustodiaData.Folio_NUE
                    ,Unidad_Policial = Cadena_de_CustodiaData.Unidad_Policial
                    ,Unidad_PolicialUnidad_Policial = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Unidad_Policial), "Catalogo_Unidad_Policial") ??  (string)Cadena_de_CustodiaData.Unidad_Policial_Catalogo_Unidad_Policial.Unidad_Policial
                    ,Caracterististicas_del_indicio = Cadena_de_CustodiaData.Caracterististicas_del_indicio
                    ,Condiciones_De_Manejo = Cadena_de_CustodiaData.Condiciones_De_Manejo
                    ,Numero_de_Parte = Cadena_de_CustodiaData.Numero_de_Parte
                    ,CUIP = Cadena_de_CustodiaData.CUIP
                    ,Observaciones = Cadena_de_CustodiaData.Observaciones
                    ,Longitud = Cadena_de_CustodiaData.Longitud
                    ,Latitud = Cadena_de_CustodiaData.Latitud
                    ,Clima = Cadena_de_CustodiaData.Clima
                    ,Grados = Cadena_de_CustodiaData.Grados
                    ,Fijacion_Planimetrica = Cadena_de_CustodiaData.Fijacion_Planimetrica
                    ,Mensaje = Cadena_de_CustodiaData.Mensaje
                    ,Unidad_Administrativa = Cadena_de_CustodiaData.Unidad_Administrativa
                    ,Unidad_AdministrativaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Unidad_Administrativa), "Catalogo_Unidad_Administrativa_CC") ??  (string)Cadena_de_CustodiaData.Unidad_Administrativa_Catalogo_Unidad_Administrativa_CC.Descripcion
                    ,Entidad_Federativa = Cadena_de_CustodiaData.Entidad_Federativa
                    ,Entidad_FederativaNombre = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Entidad_Federativa), "Estado") ??  (string)Cadena_de_CustodiaData.Entidad_Federativa_Estado.Nombre
                    ,Municipio = Cadena_de_CustodiaData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Municipio), "Municipio") ??  (string)Cadena_de_CustodiaData.Municipio_Municipio.Nombre
                    ,Numero_de_Oficio = Cadena_de_CustodiaData.Numero_de_Oficio
                    ,Fecha_CC = (Cadena_de_CustodiaData.Fecha_CC == null ? string.Empty : Convert.ToDateTime(Cadena_de_CustodiaData.Fecha_CC).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_CC = Cadena_de_CustodiaData.Hora_CC
                    ,Motivo_de_Intervencion = Cadena_de_CustodiaData.Motivo_de_Intervencion
                    ,Motivo_de_IntervencionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Motivo_de_Intervencion), "Catalogo_Motivo_de_Intervencion_CC") ??  (string)Cadena_de_CustodiaData.Motivo_de_Intervencion_Catalogo_Motivo_de_Intervencion_CC.Descripcion
                    ,Otro = Cadena_de_CustodiaData.Otro
                    ,Estatus = Cadena_de_CustodiaData.Estatus
                    ,EstatusEstatus = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Estatus), "Catalogo_Estatus_CC") ??  (string)Cadena_de_CustodiaData.Estatus_Catalogo_Estatus_CC.Estatus
                    ,Nombre_Completo = Cadena_de_CustodiaData.Nombre_Completo
                    ,Usuario_que_Registra = Cadena_de_CustodiaData.Usuario_que_Registra
                    ,FAE = Cadena_de_CustodiaData.FAE
                    ,Fecha_de_la_Emergencia = (Cadena_de_CustodiaData.Fecha_de_la_Emergencia == null ? string.Empty : Convert.ToDateTime(Cadena_de_CustodiaData.Fecha_de_la_Emergencia).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_la_Emergencia = Cadena_de_CustodiaData.Hora_de_la_Emergencia
                    ,Fuente = Cadena_de_CustodiaData.Fuente
                    ,Telefono = Cadena_de_CustodiaData.Telefono
                    ,Celular = Cadena_de_CustodiaData.Celular
                    ,Correo_Electronico = Cadena_de_CustodiaData.Correo_Electronico
                    ,Red_Social = Cadena_de_CustodiaData.Red_Social
                    ,Medio_Masivo = Cadena_de_CustodiaData.Medio_Masivo
                    ,Cargo_de_la_Autoridad = Cadena_de_CustodiaData.Cargo_de_la_Autoridad
                    ,Tipo_de_Emergencia = Cadena_de_CustodiaData.Tipo_de_Emergencia
                    ,Descripcion_de_la_Emergencia = Cadena_de_CustodiaData.Descripcion_de_la_Emergencia
                    ,Probables_Detenidos = Cadena_de_CustodiaData.Probables_Detenidos.GetValueOrDefault()
                    ,Fecha_de_la_Detencion = (Cadena_de_CustodiaData.Fecha_de_la_Detencion == null ? string.Empty : Convert.ToDateTime(Cadena_de_CustodiaData.Fecha_de_la_Detencion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_la_Detencion = Cadena_de_CustodiaData.Hora_de_la_Detencion
                    ,Pais_Emergencia = Cadena_de_CustodiaData.Pais_Emergencia
                    ,Estado_Emergencia = Cadena_de_CustodiaData.Estado_Emergencia
                    ,Municipio_Emergencia = Cadena_de_CustodiaData.Municipio_Emergencia
                    ,Colonia_Emergencia = Cadena_de_CustodiaData.Colonia_Emergencia
                    ,Calle_Emergencia = Cadena_de_CustodiaData.Calle_Emergencia
                    ,Entre_Calle_Emergencia = Cadena_de_CustodiaData.Entre_Calle_Emergencia
                    ,Y_Calle_Emergencia = Cadena_de_CustodiaData.Y_Calle_Emergencia
                    ,Latitud_Emergencia = Cadena_de_CustodiaData.Latitud_Emergencia
                    ,Longitud_Emergencia = Cadena_de_CustodiaData.Longitud_Emergencia
                    ,Nombre_de_la_Autoridad = Cadena_de_CustodiaData.Nombre_de_la_Autoridad
                    ,Especifique = Cadena_de_CustodiaData.Especifique
                    ,Tipo_de_Agente = Cadena_de_CustodiaData.Tipo_de_Agente
                    ,Area = Cadena_de_CustodiaData.Area
                    ,Unidad = Cadena_de_CustodiaData.Unidad
                    ,Zona = Cadena_de_CustodiaData.Zona
                    ,Agente_Investigador = Cadena_de_CustodiaData.Agente_Investigador
                    ,Narrativa_de_los_Hechos = Cadena_de_CustodiaData.Narrativa_de_los_Hechos
                    ,Probable_Delito_Principal = Cadena_de_CustodiaData.Probable_Delito_Principal
                    ,Fecha_de_Asignacion = (Cadena_de_CustodiaData.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(Cadena_de_CustodiaData.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Asignacion = Cadena_de_CustodiaData.Hora_de_Asignacion
                    ,Estatus_NUE = Cadena_de_CustodiaData.Estatus_NUE
                    ,Inicio_de_Cadena_de_Custodia = Cadena_de_CustodiaData.Inicio_de_Cadena_de_Custodia
                    ,Inicio_de_Cadena_de_CustodiaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Inicio_de_Cadena_de_Custodia), "Catalogo_de_Inicio_de_Cadena_de_Custodia") ??  (string)Cadena_de_CustodiaData.Inicio_de_Cadena_de_Custodia_Catalogo_de_Inicio_de_Cadena_de_Custodia.Descripcion
                    ,Calidad_de_quien_aporta = Cadena_de_CustodiaData.Calidad_de_quien_aporta
                    ,Calidad_de_quien_aportaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Calidad_de_quien_aporta), "Tipo_de_Compareciente") ??  (string)Cadena_de_CustodiaData.Calidad_de_quien_aporta_Tipo_de_Compareciente.Descripcion
                    ,Fecha_del_arribo = (Cadena_de_CustodiaData.Fecha_del_arribo == null ? string.Empty : Convert.ToDateTime(Cadena_de_CustodiaData.Fecha_del_arribo).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_del_arribo = Cadena_de_CustodiaData.Hora_del_arribo
                    ,Descripcion_de_recoleccion = Cadena_de_CustodiaData.Descripcion_de_recoleccion
                    ,Descripcion_de_recoleccionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Descripcion_de_recoleccion), "Catalogo_de_Recoleccion") ??  (string)Cadena_de_CustodiaData.Descripcion_de_recoleccion_Catalogo_de_Recoleccion.Descripcion
                    ,Movil_para_Traslado = Cadena_de_CustodiaData.Movil_para_Traslado
                    ,Movil_para_TrasladoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Cadena_de_CustodiaData.Movil_para_Traslado), "Catalogo_de_Movil_para_traslado") ??  (string)Cadena_de_CustodiaData.Movil_para_Traslado_Catalogo_de_Movil_para_traslado.Descripcion
                    ,Servidor_Publico_que_Preserva = Cadena_de_CustodiaData.Servidor_Publico_que_Preserva
                    ,Servidor_Publico_que_Busca = Cadena_de_CustodiaData.Servidor_Publico_que_Busca
                    ,Servidor_Publico_que_Localiza = Cadena_de_CustodiaData.Servidor_Publico_que_Localiza
                    ,Servidor_Publico_que_Recolecta = Cadena_de_CustodiaData.Servidor_Publico_que_Recolecta
                    ,Servidor_Publico_que_Traslada = Cadena_de_CustodiaData.Servidor_Publico_que_Traslada
                    ,Preservacion = Cadena_de_CustodiaData.Preservacion
                    ,Busqueda = Cadena_de_CustodiaData.Busqueda
                    ,Localizacion = Cadena_de_CustodiaData.Localizacion
                    ,Recoleccion = Cadena_de_CustodiaData.Recoleccion

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Fijacion_PlanimetricaSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varCadena_de_Custodia.Fijacion_Planimetrica).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito_Referencia = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito_Referencia != null && Delitos_Delito_Referencia.Resource != null)
                ViewBag.Delitos_Delito_Referencia = Delitos_Delito_Referencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Tipo_de_Cargo_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Tipo_de_Cargo_CCs_Cargo = _ICatalogo_Tipo_de_Cargo_CCApiConsumer.SelAll(true);
            if (Catalogo_Tipo_de_Cargo_CCs_Cargo != null && Catalogo_Tipo_de_Cargo_CCs_Cargo.Resource != null)
                ViewBag.Catalogo_Tipo_de_Cargo_CCs_Cargo = Catalogo_Tipo_de_Cargo_CCs_Cargo.Resource.Where(m => m.Tipo_de_Cargo != null).OrderBy(m => m.Tipo_de_Cargo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Tipo_de_Cargo_CC", "Tipo_de_Cargo") ?? m.Tipo_de_Cargo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Asignar = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Asignar != null && Spartan_Users_Asignar.Resource != null)
                ViewBag.Spartan_Users_Asignar = Spartan_Users_Asignar.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ICatalogo_Unidad_PolicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Unidad_Policials_Unidad_Policial = _ICatalogo_Unidad_PolicialApiConsumer.SelAll(true);
            if (Catalogo_Unidad_Policials_Unidad_Policial != null && Catalogo_Unidad_Policials_Unidad_Policial.Resource != null)
                ViewBag.Catalogo_Unidad_Policials_Unidad_Policial = Catalogo_Unidad_Policials_Unidad_Policial.Resource.Where(m => m.Unidad_Policial != null).OrderBy(m => m.Unidad_Policial).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Unidad_Policial", "Unidad_Policial") ?? m.Unidad_Policial.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Unidad_Administrativa_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa = _ICatalogo_Unidad_Administrativa_CCApiConsumer.SelAll(true);
            if (Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa != null && Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa.Resource != null)
                ViewBag.Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa = Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Unidad_Administrativa_CC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Entidad_Federativa = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Entidad_Federativa != null && Estados_Entidad_Federativa.Resource != null)
                ViewBag.Estados_Entidad_Federativa = Estados_Entidad_Federativa.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Motivo_de_Intervencion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion = _ICatalogo_Motivo_de_Intervencion_CCApiConsumer.SelAll(true);
            if (Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion != null && Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion.Resource != null)
                ViewBag.Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion = Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Motivo_de_Intervencion_CC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Estatus_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Estatus_CCs_Estatus = _ICatalogo_Estatus_CCApiConsumer.SelAll(true);
            if (Catalogo_Estatus_CCs_Estatus != null && Catalogo_Estatus_CCs_Estatus.Resource != null)
                ViewBag.Catalogo_Estatus_CCs_Estatus = Catalogo_Estatus_CCs_Estatus.Resource.Where(m => m.Estatus != null).OrderBy(m => m.Estatus).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Estatus_CC", "Estatus") ?? m.Estatus.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia = _ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer.SelAll(true);
            if (Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia != null && Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia.Resource != null)
                ViewBag.Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia = Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Inicio_de_Cadena_de_Custodia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Calidad_de_quien_aporta = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Calidad_de_quien_aporta != null && Tipo_de_Comparecientes_Calidad_de_quien_aporta.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Calidad_de_quien_aporta = Tipo_de_Comparecientes_Calidad_de_quien_aporta.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_de_RecoleccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_de_Recoleccions_Descripcion_de_recoleccion = _ICatalogo_de_RecoleccionApiConsumer.SelAll(true);
            if (Catalogo_de_Recoleccions_Descripcion_de_recoleccion != null && Catalogo_de_Recoleccions_Descripcion_de_recoleccion.Resource != null)
                ViewBag.Catalogo_de_Recoleccions_Descripcion_de_recoleccion = Catalogo_de_Recoleccions_Descripcion_de_recoleccion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Recoleccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_de_Movil_para_trasladoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_de_Movil_para_traslados_Movil_para_Traslado = _ICatalogo_de_Movil_para_trasladoApiConsumer.SelAll(true);
            if (Catalogo_de_Movil_para_traslados_Movil_para_Traslado != null && Catalogo_de_Movil_para_traslados_Movil_para_Traslado.Resource != null)
                ViewBag.Catalogo_de_Movil_para_traslados_Movil_para_Traslado = Catalogo_de_Movil_para_traslados_Movil_para_Traslado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Movil_para_traslado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddCadena_de_Custodia", varCadena_de_Custodia);
        }


        [HttpGet]
        public FileResult GetFile(int id)
        {

            if (!_tokenManager.GenerateToken())
                return null;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var fileInfo = _ISpartane_FileApiConsumer.GetByKey(id).Resource;
            if (fileInfo == null)
                return null;
            return File(fileInfo.File, System.Net.Mime.MediaTypeNames.Application.Octet, fileInfo.Description);
        }

        [HttpGet]
        public ActionResult GetDelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCatalogo_Tipo_de_Cargo_CCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_Tipo_de_Cargo_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_Tipo_de_Cargo_CCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Tipo_de_Cargo).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Tipo_de_Cargo_CC", "Tipo_de_Cargo")?? m.Tipo_de_Cargo,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetSpartan_UserAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_UserApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name")?? m.Name,
                    Value = Convert.ToString(m.Id_User)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCatalogo_Unidad_PolicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_Unidad_PolicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_Unidad_PolicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Unidad_Policial).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Unidad_Policial", "Unidad_Policial")?? m.Unidad_Policial,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCatalogo_Unidad_Administrativa_CCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_Unidad_Administrativa_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_Unidad_Administrativa_CCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Unidad_Administrativa_CC", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetMunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCatalogo_Motivo_de_Intervencion_CCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_Motivo_de_Intervencion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_Motivo_de_Intervencion_CCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Motivo_de_Intervencion_CC", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCatalogo_Estatus_CCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_Estatus_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_Estatus_CCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Estatus).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Estatus_CC", "Estatus")?? m.Estatus,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCatalogo_de_Inicio_de_Cadena_de_CustodiaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Inicio_de_Cadena_de_Custodia", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_ComparecienteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ComparecienteApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCatalogo_de_RecoleccionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_de_RecoleccionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_de_RecoleccionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Recoleccion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCatalogo_de_Movil_para_trasladoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_de_Movil_para_trasladoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_de_Movil_para_trasladoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Movil_para_traslado", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Cadena_de_CustodiaAdvanceSearchModel model, int idFilter = -1)
        {
            if (ModelState.IsValid)
            {
                Session["AdvanceSearch"] = model;
				if (idFilter != -1)
                {
                    Session["AdvanceReportFilter"] = GetAdvanceFilter(model);
                    return RedirectToAction("Index", "Report", new { id = idFilter });
                }
                return RedirectToAction("Index");
            }
            ViewBag.Filter = new List<SelectListItem>
            {
                new SelectListItem() {Text = Resources.Resources.BeginWith, Value = "1"},
                new SelectListItem() {Text = Resources.Resources.EndWith, Value = "2"},
                new SelectListItem() {Text = Resources.Resources.Contains, Value = "4"},
                new SelectListItem() {Text = Resources.Resources.Exact, Value = "3"},
            };
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito_Referencia = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito_Referencia != null && Delitos_Delito_Referencia.Resource != null)
                ViewBag.Delitos_Delito_Referencia = Delitos_Delito_Referencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Tipo_de_Cargo_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Tipo_de_Cargo_CCs_Cargo = _ICatalogo_Tipo_de_Cargo_CCApiConsumer.SelAll(true);
            if (Catalogo_Tipo_de_Cargo_CCs_Cargo != null && Catalogo_Tipo_de_Cargo_CCs_Cargo.Resource != null)
                ViewBag.Catalogo_Tipo_de_Cargo_CCs_Cargo = Catalogo_Tipo_de_Cargo_CCs_Cargo.Resource.Where(m => m.Tipo_de_Cargo != null).OrderBy(m => m.Tipo_de_Cargo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Tipo_de_Cargo_CC", "Tipo_de_Cargo") ?? m.Tipo_de_Cargo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Asignar = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Asignar != null && Spartan_Users_Asignar.Resource != null)
                ViewBag.Spartan_Users_Asignar = Spartan_Users_Asignar.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ICatalogo_Unidad_PolicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Unidad_Policials_Unidad_Policial = _ICatalogo_Unidad_PolicialApiConsumer.SelAll(true);
            if (Catalogo_Unidad_Policials_Unidad_Policial != null && Catalogo_Unidad_Policials_Unidad_Policial.Resource != null)
                ViewBag.Catalogo_Unidad_Policials_Unidad_Policial = Catalogo_Unidad_Policials_Unidad_Policial.Resource.Where(m => m.Unidad_Policial != null).OrderBy(m => m.Unidad_Policial).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Unidad_Policial", "Unidad_Policial") ?? m.Unidad_Policial.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Unidad_Administrativa_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa = _ICatalogo_Unidad_Administrativa_CCApiConsumer.SelAll(true);
            if (Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa != null && Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa.Resource != null)
                ViewBag.Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa = Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Unidad_Administrativa_CC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Entidad_Federativa = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Entidad_Federativa != null && Estados_Entidad_Federativa.Resource != null)
                ViewBag.Estados_Entidad_Federativa = Estados_Entidad_Federativa.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Motivo_de_Intervencion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion = _ICatalogo_Motivo_de_Intervencion_CCApiConsumer.SelAll(true);
            if (Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion != null && Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion.Resource != null)
                ViewBag.Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion = Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Motivo_de_Intervencion_CC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Estatus_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Estatus_CCs_Estatus = _ICatalogo_Estatus_CCApiConsumer.SelAll(true);
            if (Catalogo_Estatus_CCs_Estatus != null && Catalogo_Estatus_CCs_Estatus.Resource != null)
                ViewBag.Catalogo_Estatus_CCs_Estatus = Catalogo_Estatus_CCs_Estatus.Resource.Where(m => m.Estatus != null).OrderBy(m => m.Estatus).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Estatus_CC", "Estatus") ?? m.Estatus.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia = _ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer.SelAll(true);
            if (Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia != null && Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia.Resource != null)
                ViewBag.Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia = Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Inicio_de_Cadena_de_Custodia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Calidad_de_quien_aporta = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Calidad_de_quien_aporta != null && Tipo_de_Comparecientes_Calidad_de_quien_aporta.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Calidad_de_quien_aporta = Tipo_de_Comparecientes_Calidad_de_quien_aporta.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_de_RecoleccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_de_Recoleccions_Descripcion_de_recoleccion = _ICatalogo_de_RecoleccionApiConsumer.SelAll(true);
            if (Catalogo_de_Recoleccions_Descripcion_de_recoleccion != null && Catalogo_de_Recoleccions_Descripcion_de_recoleccion.Resource != null)
                ViewBag.Catalogo_de_Recoleccions_Descripcion_de_recoleccion = Catalogo_de_Recoleccions_Descripcion_de_recoleccion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Recoleccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_de_Movil_para_trasladoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_de_Movil_para_traslados_Movil_para_Traslado = _ICatalogo_de_Movil_para_trasladoApiConsumer.SelAll(true);
            if (Catalogo_de_Movil_para_traslados_Movil_para_Traslado != null && Catalogo_de_Movil_para_traslados_Movil_para_Traslado.Resource != null)
                ViewBag.Catalogo_de_Movil_para_traslados_Movil_para_Traslado = Catalogo_de_Movil_para_traslados_Movil_para_Traslado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Movil_para_traslado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito_Referencia = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito_Referencia != null && Delitos_Delito_Referencia.Resource != null)
                ViewBag.Delitos_Delito_Referencia = Delitos_Delito_Referencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Tipo_de_Cargo_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Tipo_de_Cargo_CCs_Cargo = _ICatalogo_Tipo_de_Cargo_CCApiConsumer.SelAll(true);
            if (Catalogo_Tipo_de_Cargo_CCs_Cargo != null && Catalogo_Tipo_de_Cargo_CCs_Cargo.Resource != null)
                ViewBag.Catalogo_Tipo_de_Cargo_CCs_Cargo = Catalogo_Tipo_de_Cargo_CCs_Cargo.Resource.Where(m => m.Tipo_de_Cargo != null).OrderBy(m => m.Tipo_de_Cargo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Tipo_de_Cargo_CC", "Tipo_de_Cargo") ?? m.Tipo_de_Cargo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Asignar = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Asignar != null && Spartan_Users_Asignar.Resource != null)
                ViewBag.Spartan_Users_Asignar = Spartan_Users_Asignar.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ICatalogo_Unidad_PolicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Unidad_Policials_Unidad_Policial = _ICatalogo_Unidad_PolicialApiConsumer.SelAll(true);
            if (Catalogo_Unidad_Policials_Unidad_Policial != null && Catalogo_Unidad_Policials_Unidad_Policial.Resource != null)
                ViewBag.Catalogo_Unidad_Policials_Unidad_Policial = Catalogo_Unidad_Policials_Unidad_Policial.Resource.Where(m => m.Unidad_Policial != null).OrderBy(m => m.Unidad_Policial).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Unidad_Policial", "Unidad_Policial") ?? m.Unidad_Policial.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Unidad_Administrativa_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa = _ICatalogo_Unidad_Administrativa_CCApiConsumer.SelAll(true);
            if (Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa != null && Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa.Resource != null)
                ViewBag.Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa = Catalogo_Unidad_Administrativa_CCs_Unidad_Administrativa.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Unidad_Administrativa_CC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Entidad_Federativa = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Entidad_Federativa != null && Estados_Entidad_Federativa.Resource != null)
                ViewBag.Estados_Entidad_Federativa = Estados_Entidad_Federativa.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Motivo_de_Intervencion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion = _ICatalogo_Motivo_de_Intervencion_CCApiConsumer.SelAll(true);
            if (Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion != null && Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion.Resource != null)
                ViewBag.Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion = Catalogo_Motivo_de_Intervencion_CCs_Motivo_de_Intervencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Motivo_de_Intervencion_CC", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Estatus_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Estatus_CCs_Estatus = _ICatalogo_Estatus_CCApiConsumer.SelAll(true);
            if (Catalogo_Estatus_CCs_Estatus != null && Catalogo_Estatus_CCs_Estatus.Resource != null)
                ViewBag.Catalogo_Estatus_CCs_Estatus = Catalogo_Estatus_CCs_Estatus.Resource.Where(m => m.Estatus != null).OrderBy(m => m.Estatus).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Estatus_CC", "Estatus") ?? m.Estatus.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia = _ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer.SelAll(true);
            if (Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia != null && Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia.Resource != null)
                ViewBag.Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia = Catalogo_de_Inicio_de_Cadena_de_Custodias_Inicio_de_Cadena_de_Custodia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Inicio_de_Cadena_de_Custodia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Calidad_de_quien_aporta = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Calidad_de_quien_aporta != null && Tipo_de_Comparecientes_Calidad_de_quien_aporta.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Calidad_de_quien_aporta = Tipo_de_Comparecientes_Calidad_de_quien_aporta.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_de_RecoleccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_de_Recoleccions_Descripcion_de_recoleccion = _ICatalogo_de_RecoleccionApiConsumer.SelAll(true);
            if (Catalogo_de_Recoleccions_Descripcion_de_recoleccion != null && Catalogo_de_Recoleccions_Descripcion_de_recoleccion.Resource != null)
                ViewBag.Catalogo_de_Recoleccions_Descripcion_de_recoleccion = Catalogo_de_Recoleccions_Descripcion_de_recoleccion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Recoleccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_de_Movil_para_trasladoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_de_Movil_para_traslados_Movil_para_Traslado = _ICatalogo_de_Movil_para_trasladoApiConsumer.SelAll(true);
            if (Catalogo_de_Movil_para_traslados_Movil_para_Traslado != null && Catalogo_de_Movil_para_traslados_Movil_para_Traslado.Resource != null)
                ViewBag.Catalogo_de_Movil_para_traslados_Movil_para_Traslado = Catalogo_de_Movil_para_traslados_Movil_para_Traslado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_de_Movil_para_traslado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Cadena_de_CustodiaAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Cadena_de_CustodiaAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Cadena_de_CustodiaAdvanceSearchModel());
            }

            ViewBag.Filter = new List<SelectListItem>
            {
                new SelectListItem() {Text = Resources.Resources.BeginWith, Value = "1"},
                new SelectListItem() {Text = Resources.Resources.EndWith, Value = "2"},
                new SelectListItem() {Text = Resources.Resources.Contains, Value = "4"},
                new SelectListItem() {Text = Resources.Resources.Exact, Value = "3"},

            };

            return View(previousFiltersObj);
        }

        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Cadena_de_CustodiaPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ICadena_de_CustodiaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Cadena_de_Custodias == null)
                result.Cadena_de_Custodias = new List<Cadena_de_Custodia>();

            return Json(new
            {
                data = result.Cadena_de_Custodias.Select(m => new Cadena_de_CustodiaGridModel
                    {
                    Clave = m.Clave
			,NUC = m.NUC
			,NIC = m.NIC
                        ,Delito_ReferenciaDescripcion = CultureHelper.GetTraduction(m.Delito_Referencia_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Referencia_Delito.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Lugar_Exacto_del_Levantamiento = m.Lugar_Exacto_del_Levantamiento
			,Condicion_y_Ubicacion = m.Condicion_y_Ubicacion
			,Levantada_por = m.Levantada_por
                        ,CargoTipo_de_Cargo = CultureHelper.GetTraduction(m.Cargo_Catalogo_Tipo_de_Cargo_CC.Clave.ToString(), "Tipo_de_Cargo") ?? (string)m.Cargo_Catalogo_Tipo_de_Cargo_CC.Tipo_de_Cargo
                        ,AsignarName = CultureHelper.GetTraduction(m.Asignar_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Asignar_Spartan_User.Name
			,Folio_NUE = m.Folio_NUE
                        ,Unidad_PolicialUnidad_Policial = CultureHelper.GetTraduction(m.Unidad_Policial_Catalogo_Unidad_Policial.Clave.ToString(), "Unidad_Policial") ?? (string)m.Unidad_Policial_Catalogo_Unidad_Policial.Unidad_Policial
			,Caracterististicas_del_indicio = m.Caracterististicas_del_indicio
			,Condiciones_De_Manejo = m.Condiciones_De_Manejo
			,Numero_de_Parte = m.Numero_de_Parte
			,CUIP = m.CUIP
			,Observaciones = m.Observaciones
			,Longitud = m.Longitud
			,Latitud = m.Latitud
			,Clima = m.Clima
			,Grados = m.Grados
			,Fijacion_Planimetrica = m.Fijacion_Planimetrica
			,Mensaje = m.Mensaje
                        ,Unidad_AdministrativaDescripcion = CultureHelper.GetTraduction(m.Unidad_Administrativa_Catalogo_Unidad_Administrativa_CC.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Administrativa_Catalogo_Unidad_Administrativa_CC.Descripcion
                        ,Entidad_FederativaNombre = CultureHelper.GetTraduction(m.Entidad_Federativa_Estado.Clave.ToString(), "Nombre") ?? (string)m.Entidad_Federativa_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,Fecha_CC = (m.Fecha_CC == null ? string.Empty : Convert.ToDateTime(m.Fecha_CC).ToString(ConfigurationProperty.DateFormat))
			,Hora_CC = m.Hora_CC
                        ,Motivo_de_IntervencionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Intervencion_Catalogo_Motivo_de_Intervencion_CC.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Intervencion_Catalogo_Motivo_de_Intervencion_CC.Descripcion
			,Otro = m.Otro
                        ,EstatusEstatus = CultureHelper.GetTraduction(m.Estatus_Catalogo_Estatus_CC.Clave.ToString(), "Estatus") ?? (string)m.Estatus_Catalogo_Estatus_CC.Estatus
			,Nombre_Completo = m.Nombre_Completo
			,Usuario_que_Registra = m.Usuario_que_Registra
			,FAE = m.FAE
                        ,Fecha_de_la_Emergencia = (m.Fecha_de_la_Emergencia == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_Emergencia).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Emergencia = m.Hora_de_la_Emergencia
			,Fuente = m.Fuente
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Red_Social = m.Red_Social
			,Medio_Masivo = m.Medio_Masivo
			,Cargo_de_la_Autoridad = m.Cargo_de_la_Autoridad
			,Tipo_de_Emergencia = m.Tipo_de_Emergencia
			,Descripcion_de_la_Emergencia = m.Descripcion_de_la_Emergencia
			,Probables_Detenidos = m.Probables_Detenidos
                        ,Fecha_de_la_Detencion = (m.Fecha_de_la_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_Detencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Detencion = m.Hora_de_la_Detencion
			,Pais_Emergencia = m.Pais_Emergencia
			,Estado_Emergencia = m.Estado_Emergencia
			,Municipio_Emergencia = m.Municipio_Emergencia
			,Colonia_Emergencia = m.Colonia_Emergencia
			,Calle_Emergencia = m.Calle_Emergencia
			,Entre_Calle_Emergencia = m.Entre_Calle_Emergencia
			,Y_Calle_Emergencia = m.Y_Calle_Emergencia
			,Latitud_Emergencia = m.Latitud_Emergencia
			,Longitud_Emergencia = m.Longitud_Emergencia
			,Nombre_de_la_Autoridad = m.Nombre_de_la_Autoridad
			,Especifique = m.Especifique
			,Tipo_de_Agente = m.Tipo_de_Agente
			,Area = m.Area
			,Unidad = m.Unidad
			,Zona = m.Zona
			,Agente_Investigador = m.Agente_Investigador
			,Narrativa_de_los_Hechos = m.Narrativa_de_los_Hechos
			,Probable_Delito_Principal = m.Probable_Delito_Principal
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
			,Estatus_NUE = m.Estatus_NUE
                        ,Inicio_de_Cadena_de_CustodiaDescripcion = CultureHelper.GetTraduction(m.Inicio_de_Cadena_de_Custodia_Catalogo_de_Inicio_de_Cadena_de_Custodia.Clave.ToString(), "Descripcion") ?? (string)m.Inicio_de_Cadena_de_Custodia_Catalogo_de_Inicio_de_Cadena_de_Custodia.Descripcion
                        ,Calidad_de_quien_aportaDescripcion = CultureHelper.GetTraduction(m.Calidad_de_quien_aporta_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_de_quien_aporta_Tipo_de_Compareciente.Descripcion
                        ,Fecha_del_arribo = (m.Fecha_del_arribo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_arribo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_arribo = m.Hora_del_arribo
                        ,Descripcion_de_recoleccionDescripcion = CultureHelper.GetTraduction(m.Descripcion_de_recoleccion_Catalogo_de_Recoleccion.Clave.ToString(), "Descripcion") ?? (string)m.Descripcion_de_recoleccion_Catalogo_de_Recoleccion.Descripcion
                        ,Movil_para_TrasladoDescripcion = CultureHelper.GetTraduction(m.Movil_para_Traslado_Catalogo_de_Movil_para_traslado.Clave.ToString(), "Descripcion") ?? (string)m.Movil_para_Traslado_Catalogo_de_Movil_para_traslado.Descripcion
			,Servidor_Publico_que_Preserva = m.Servidor_Publico_que_Preserva
			,Servidor_Publico_que_Busca = m.Servidor_Publico_que_Busca
			,Servidor_Publico_que_Localiza = m.Servidor_Publico_que_Localiza
			,Servidor_Publico_que_Recolecta = m.Servidor_Publico_que_Recolecta
			,Servidor_Publico_que_Traslada = m.Servidor_Publico_que_Traslada
			,Preservacion = m.Preservacion
			,Busqueda = m.Busqueda
			,Localizacion = m.Localizacion
			,Recoleccion = m.Recoleccion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetCadena_de_CustodiaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICadena_de_CustodiaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Cadena_de_Custodia", m.),
                     Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
*/
        /// <summary>
        /// Get List of Cadena_de_Custodia from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Cadena_de_Custodia Entity</returns>
        public ActionResult GetCadena_de_CustodiaList(UrlParametersModel param)
        {
			 int sEcho = param.sEcho;
            int iDisplayStart = param.iDisplayStart;
            int iDisplayLength = param.iDisplayLength;
            string where = param.where;
            string order = param.order;

            where = HttpUtility.UrlEncode(where);
            int sortColumn = -1;
            string sortDirection = "asc";
            if (iDisplayLength == -1)
            {
                //length = TOTAL_ROWS;
                iDisplayLength = Int32.MaxValue;
            }
            // note: we only sort one column at a time
            if (param.sortColumn != null)
            {
                sortColumn = int.Parse(param.sortColumn);
            }
            if (param.sortDirection != null)
            {
                sortDirection = param.sortDirection;
            }


            if (!_tokenManager.GenerateToken())
                return null;
            _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Cadena_de_CustodiaPropertyMapper());
				
			if (!String.IsNullOrEmpty(where))
            {
                 configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
            if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            //Adding Advance Search
            if (param.AdvanceSearch != null && param.AdvanceSearch == true && Session["AdvanceSearch"] != null)            
            {
				if (Session["AdvanceSearch"].GetType() == typeof(Cadena_de_CustodiaAdvanceSearchModel))
                {
					var advanceFilter =
                    (Cadena_de_CustodiaAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Cadena_de_CustodiaPropertyMapper oCadena_de_CustodiaPropertyMapper = new Cadena_de_CustodiaPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oCadena_de_CustodiaPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _ICadena_de_CustodiaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Cadena_de_Custodias == null)
                result.Cadena_de_Custodias = new List<Cadena_de_Custodia>();

            return Json(new
            {
                aaData = result.Cadena_de_Custodias.Select(m => new Cadena_de_CustodiaGridModel
            {
                    Clave = m.Clave
			,NUC = m.NUC
			,NIC = m.NIC
                        ,Delito_ReferenciaDescripcion = CultureHelper.GetTraduction(m.Delito_Referencia_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Referencia_Delito.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Lugar_Exacto_del_Levantamiento = m.Lugar_Exacto_del_Levantamiento
			,Condicion_y_Ubicacion = m.Condicion_y_Ubicacion
			,Levantada_por = m.Levantada_por
                        ,CargoTipo_de_Cargo = CultureHelper.GetTraduction(m.Cargo_Catalogo_Tipo_de_Cargo_CC.Clave.ToString(), "Tipo_de_Cargo") ?? (string)m.Cargo_Catalogo_Tipo_de_Cargo_CC.Tipo_de_Cargo
                        ,AsignarName = CultureHelper.GetTraduction(m.Asignar_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Asignar_Spartan_User.Name
			,Folio_NUE = m.Folio_NUE
                        ,Unidad_PolicialUnidad_Policial = CultureHelper.GetTraduction(m.Unidad_Policial_Catalogo_Unidad_Policial.Clave.ToString(), "Unidad_Policial") ?? (string)m.Unidad_Policial_Catalogo_Unidad_Policial.Unidad_Policial
			,Caracterististicas_del_indicio = m.Caracterististicas_del_indicio
			,Condiciones_De_Manejo = m.Condiciones_De_Manejo
			,Numero_de_Parte = m.Numero_de_Parte
			,CUIP = m.CUIP
			,Observaciones = m.Observaciones
			,Longitud = m.Longitud
			,Latitud = m.Latitud
			,Clima = m.Clima
			,Grados = m.Grados
			,Fijacion_Planimetrica = m.Fijacion_Planimetrica
			,Mensaje = m.Mensaje
                        ,Unidad_AdministrativaDescripcion = CultureHelper.GetTraduction(m.Unidad_Administrativa_Catalogo_Unidad_Administrativa_CC.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Administrativa_Catalogo_Unidad_Administrativa_CC.Descripcion
                        ,Entidad_FederativaNombre = CultureHelper.GetTraduction(m.Entidad_Federativa_Estado.Clave.ToString(), "Nombre") ?? (string)m.Entidad_Federativa_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,Fecha_CC = (m.Fecha_CC == null ? string.Empty : Convert.ToDateTime(m.Fecha_CC).ToString(ConfigurationProperty.DateFormat))
			,Hora_CC = m.Hora_CC
                        ,Motivo_de_IntervencionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Intervencion_Catalogo_Motivo_de_Intervencion_CC.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Intervencion_Catalogo_Motivo_de_Intervencion_CC.Descripcion
			,Otro = m.Otro
                        ,EstatusEstatus = CultureHelper.GetTraduction(m.Estatus_Catalogo_Estatus_CC.Clave.ToString(), "Estatus") ?? (string)m.Estatus_Catalogo_Estatus_CC.Estatus
			,Nombre_Completo = m.Nombre_Completo
			,Usuario_que_Registra = m.Usuario_que_Registra
			,FAE = m.FAE
                        ,Fecha_de_la_Emergencia = (m.Fecha_de_la_Emergencia == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_Emergencia).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Emergencia = m.Hora_de_la_Emergencia
			,Fuente = m.Fuente
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Red_Social = m.Red_Social
			,Medio_Masivo = m.Medio_Masivo
			,Cargo_de_la_Autoridad = m.Cargo_de_la_Autoridad
			,Tipo_de_Emergencia = m.Tipo_de_Emergencia
			,Descripcion_de_la_Emergencia = m.Descripcion_de_la_Emergencia
			,Probables_Detenidos = m.Probables_Detenidos
                        ,Fecha_de_la_Detencion = (m.Fecha_de_la_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_Detencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Detencion = m.Hora_de_la_Detencion
			,Pais_Emergencia = m.Pais_Emergencia
			,Estado_Emergencia = m.Estado_Emergencia
			,Municipio_Emergencia = m.Municipio_Emergencia
			,Colonia_Emergencia = m.Colonia_Emergencia
			,Calle_Emergencia = m.Calle_Emergencia
			,Entre_Calle_Emergencia = m.Entre_Calle_Emergencia
			,Y_Calle_Emergencia = m.Y_Calle_Emergencia
			,Latitud_Emergencia = m.Latitud_Emergencia
			,Longitud_Emergencia = m.Longitud_Emergencia
			,Nombre_de_la_Autoridad = m.Nombre_de_la_Autoridad
			,Especifique = m.Especifique
			,Tipo_de_Agente = m.Tipo_de_Agente
			,Area = m.Area
			,Unidad = m.Unidad
			,Zona = m.Zona
			,Agente_Investigador = m.Agente_Investigador
			,Narrativa_de_los_Hechos = m.Narrativa_de_los_Hechos
			,Probable_Delito_Principal = m.Probable_Delito_Principal
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
			,Estatus_NUE = m.Estatus_NUE
                        ,Inicio_de_Cadena_de_CustodiaDescripcion = CultureHelper.GetTraduction(m.Inicio_de_Cadena_de_Custodia_Catalogo_de_Inicio_de_Cadena_de_Custodia.Clave.ToString(), "Descripcion") ?? (string)m.Inicio_de_Cadena_de_Custodia_Catalogo_de_Inicio_de_Cadena_de_Custodia.Descripcion
                        ,Calidad_de_quien_aportaDescripcion = CultureHelper.GetTraduction(m.Calidad_de_quien_aporta_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_de_quien_aporta_Tipo_de_Compareciente.Descripcion
                        ,Fecha_del_arribo = (m.Fecha_del_arribo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_arribo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_arribo = m.Hora_del_arribo
                        ,Descripcion_de_recoleccionDescripcion = CultureHelper.GetTraduction(m.Descripcion_de_recoleccion_Catalogo_de_Recoleccion.Clave.ToString(), "Descripcion") ?? (string)m.Descripcion_de_recoleccion_Catalogo_de_Recoleccion.Descripcion
                        ,Movil_para_TrasladoDescripcion = CultureHelper.GetTraduction(m.Movil_para_Traslado_Catalogo_de_Movil_para_traslado.Clave.ToString(), "Descripcion") ?? (string)m.Movil_para_Traslado_Catalogo_de_Movil_para_traslado.Descripcion
			,Servidor_Publico_que_Preserva = m.Servidor_Publico_que_Preserva
			,Servidor_Publico_que_Busca = m.Servidor_Publico_que_Busca
			,Servidor_Publico_que_Localiza = m.Servidor_Publico_que_Localiza
			,Servidor_Publico_que_Recolecta = m.Servidor_Publico_que_Recolecta
			,Servidor_Publico_que_Traslada = m.Servidor_Publico_que_Traslada
			,Preservacion = m.Preservacion
			,Busqueda = m.Busqueda
			,Localizacion = m.Localizacion
			,Recoleccion = m.Recoleccion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetCadena_de_Custodia_Asignar_Spartan_User(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Spartan_User.Id_User as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Spartan_User.Name as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISpartan_UserApiConsumer.ListaSelAll(1, 20,elWhere , " Spartan_User.Name ASC ").Resource;
               
                foreach (var item in result.Spartan_Users)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                    item.Name =trans ??item.Name;
                }
                return Json(result.Spartan_Users.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(Cadena_de_CustodiaAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Cadena_de_Custodia.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Cadena_de_Custodia.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.NUC))
            {
                switch (filter.NUCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.NUC LIKE '" + filter.NUC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.NUC LIKE '%" + filter.NUC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.NUC = '" + filter.NUC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.NUC LIKE '%" + filter.NUC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.NIC))
            {
                switch (filter.NICFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.NIC LIKE '" + filter.NIC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.NIC LIKE '%" + filter.NIC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.NIC = '" + filter.NIC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.NIC LIKE '%" + filter.NIC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDelito_Referencia))
            {
                switch (filter.Delito_ReferenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delito.Descripcion LIKE '" + filter.AdvanceDelito_Referencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delito.Descripcion LIKE '%" + filter.AdvanceDelito_Referencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delito.Descripcion = '" + filter.AdvanceDelito_Referencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delito.Descripcion LIKE '%" + filter.AdvanceDelito_Referencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDelito_ReferenciaMultiple != null && filter.AdvanceDelito_ReferenciaMultiple.Count() > 0)
            {
                var Delito_ReferenciaIds = string.Join(",", filter.AdvanceDelito_ReferenciaMultiple);

                where += " AND Cadena_de_Custodia.Delito_Referencia In (" + Delito_ReferenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha) || !string.IsNullOrEmpty(filter.ToFecha))
            {
                var FechaFrom = DateTime.ParseExact(filter.FromFecha, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var FechaTo = DateTime.ParseExact(filter.ToFecha, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha))
                    where += " AND Cadena_de_Custodia.Fecha >= '" + FechaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha))
                    where += " AND Cadena_de_Custodia.Fecha <= '" + FechaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora) || !string.IsNullOrEmpty(filter.ToHora))
            {
                if (!string.IsNullOrEmpty(filter.FromHora))
                    where += " AND Convert(TIME,Cadena_de_Custodia.Hora) >='" + filter.FromHora + "'";
                if (!string.IsNullOrEmpty(filter.ToHora))
                    where += " AND Convert(TIME,Cadena_de_Custodia.Hora) <='" + filter.ToHora + "'";
            }

            if (!string.IsNullOrEmpty(filter.Lugar_Exacto_del_Levantamiento))
            {
                switch (filter.Lugar_Exacto_del_LevantamientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Lugar_Exacto_del_Levantamiento LIKE '" + filter.Lugar_Exacto_del_Levantamiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Lugar_Exacto_del_Levantamiento LIKE '%" + filter.Lugar_Exacto_del_Levantamiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Lugar_Exacto_del_Levantamiento = '" + filter.Lugar_Exacto_del_Levantamiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Lugar_Exacto_del_Levantamiento LIKE '%" + filter.Lugar_Exacto_del_Levantamiento + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Condicion_y_Ubicacion))
            {
                switch (filter.Condicion_y_UbicacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Condicion_y_Ubicacion LIKE '" + filter.Condicion_y_Ubicacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Condicion_y_Ubicacion LIKE '%" + filter.Condicion_y_Ubicacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Condicion_y_Ubicacion = '" + filter.Condicion_y_Ubicacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Condicion_y_Ubicacion LIKE '%" + filter.Condicion_y_Ubicacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromLevantada_por) || !string.IsNullOrEmpty(filter.ToLevantada_por))
            {
                if (!string.IsNullOrEmpty(filter.FromLevantada_por))
                    where += " AND Cadena_de_Custodia.Levantada_por >= " + filter.FromLevantada_por;
                if (!string.IsNullOrEmpty(filter.ToLevantada_por))
                    where += " AND Cadena_de_Custodia.Levantada_por <= " + filter.ToLevantada_por;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCargo))
            {
                switch (filter.CargoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_Tipo_de_Cargo_CC.Tipo_de_Cargo LIKE '" + filter.AdvanceCargo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_Tipo_de_Cargo_CC.Tipo_de_Cargo LIKE '%" + filter.AdvanceCargo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_Tipo_de_Cargo_CC.Tipo_de_Cargo = '" + filter.AdvanceCargo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_Tipo_de_Cargo_CC.Tipo_de_Cargo LIKE '%" + filter.AdvanceCargo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCargoMultiple != null && filter.AdvanceCargoMultiple.Count() > 0)
            {
                var CargoIds = string.Join(",", filter.AdvanceCargoMultiple);

                where += " AND Cadena_de_Custodia.Cargo In (" + CargoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAsignar))
            {
                switch (filter.AsignarFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceAsignar + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceAsignar + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceAsignar + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceAsignar + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAsignarMultiple != null && filter.AdvanceAsignarMultiple.Count() > 0)
            {
                var AsignarIds = string.Join(",", filter.AdvanceAsignarMultiple);

                where += " AND Cadena_de_Custodia.Asignar In (" + AsignarIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Folio_NUE))
            {
                switch (filter.Folio_NUEFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Folio_NUE LIKE '" + filter.Folio_NUE + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Folio_NUE LIKE '%" + filter.Folio_NUE + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Folio_NUE = '" + filter.Folio_NUE + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Folio_NUE LIKE '%" + filter.Folio_NUE + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUnidad_Policial))
            {
                switch (filter.Unidad_PolicialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_Unidad_Policial.Unidad_Policial LIKE '" + filter.AdvanceUnidad_Policial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_Unidad_Policial.Unidad_Policial LIKE '%" + filter.AdvanceUnidad_Policial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_Unidad_Policial.Unidad_Policial = '" + filter.AdvanceUnidad_Policial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_Unidad_Policial.Unidad_Policial LIKE '%" + filter.AdvanceUnidad_Policial + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUnidad_PolicialMultiple != null && filter.AdvanceUnidad_PolicialMultiple.Count() > 0)
            {
                var Unidad_PolicialIds = string.Join(",", filter.AdvanceUnidad_PolicialMultiple);

                where += " AND Cadena_de_Custodia.Unidad_Policial In (" + Unidad_PolicialIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Caracterististicas_del_indicio))
            {
                switch (filter.Caracterististicas_del_indicioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Caracterististicas_del_indicio LIKE '" + filter.Caracterististicas_del_indicio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Caracterististicas_del_indicio LIKE '%" + filter.Caracterististicas_del_indicio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Caracterististicas_del_indicio = '" + filter.Caracterististicas_del_indicio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Caracterististicas_del_indicio LIKE '%" + filter.Caracterististicas_del_indicio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Condiciones_De_Manejo))
            {
                switch (filter.Condiciones_De_ManejoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Condiciones_De_Manejo LIKE '" + filter.Condiciones_De_Manejo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Condiciones_De_Manejo LIKE '%" + filter.Condiciones_De_Manejo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Condiciones_De_Manejo = '" + filter.Condiciones_De_Manejo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Condiciones_De_Manejo LIKE '%" + filter.Condiciones_De_Manejo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Parte))
            {
                switch (filter.Numero_de_ParteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Numero_de_Parte LIKE '" + filter.Numero_de_Parte + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Numero_de_Parte LIKE '%" + filter.Numero_de_Parte + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Numero_de_Parte = '" + filter.Numero_de_Parte + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Numero_de_Parte LIKE '%" + filter.Numero_de_Parte + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.CUIP))
            {
                switch (filter.CUIPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.CUIP LIKE '" + filter.CUIP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.CUIP LIKE '%" + filter.CUIP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.CUIP = '" + filter.CUIP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.CUIP LIKE '%" + filter.CUIP + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Observaciones LIKE '%" + filter.Observaciones + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud))
            {
                switch (filter.LongitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Longitud LIKE '" + filter.Longitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Longitud LIKE '%" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Longitud = '" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Longitud LIKE '%" + filter.Longitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud))
            {
                switch (filter.LatitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Latitud LIKE '" + filter.Latitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Latitud LIKE '%" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Latitud = '" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Latitud LIKE '%" + filter.Latitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Clima))
            {
                switch (filter.ClimaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Clima LIKE '" + filter.Clima + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Clima LIKE '%" + filter.Clima + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Clima = '" + filter.Clima + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Clima LIKE '%" + filter.Clima + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Grados))
            {
                switch (filter.GradosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Grados LIKE '" + filter.Grados + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Grados LIKE '%" + filter.Grados + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Grados = '" + filter.Grados + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Grados LIKE '%" + filter.Grados + "%'";
                        break;
                }
            }

            if (filter.Fijacion_Planimetrica != RadioOptions.NoApply)
                where += " AND Cadena_de_Custodia.Fijacion_Planimetrica " + (filter.Fijacion_Planimetrica == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.Mensaje))
            {
                switch (filter.MensajeFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Mensaje LIKE '" + filter.Mensaje + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Mensaje LIKE '%" + filter.Mensaje + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Mensaje = '" + filter.Mensaje + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Mensaje LIKE '%" + filter.Mensaje + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUnidad_Administrativa))
            {
                switch (filter.Unidad_AdministrativaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_Unidad_Administrativa_CC.Descripcion LIKE '" + filter.AdvanceUnidad_Administrativa + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_Unidad_Administrativa_CC.Descripcion LIKE '%" + filter.AdvanceUnidad_Administrativa + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_Unidad_Administrativa_CC.Descripcion = '" + filter.AdvanceUnidad_Administrativa + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_Unidad_Administrativa_CC.Descripcion LIKE '%" + filter.AdvanceUnidad_Administrativa + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUnidad_AdministrativaMultiple != null && filter.AdvanceUnidad_AdministrativaMultiple.Count() > 0)
            {
                var Unidad_AdministrativaIds = string.Join(",", filter.AdvanceUnidad_AdministrativaMultiple);

                where += " AND Cadena_de_Custodia.Unidad_Administrativa In (" + Unidad_AdministrativaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEntidad_Federativa))
            {
                switch (filter.Entidad_FederativaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEntidad_Federativa + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEntidad_Federativa + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEntidad_Federativa + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEntidad_Federativa + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEntidad_FederativaMultiple != null && filter.AdvanceEntidad_FederativaMultiple.Count() > 0)
            {
                var Entidad_FederativaIds = string.Join(",", filter.AdvanceEntidad_FederativaMultiple);

                where += " AND Cadena_de_Custodia.Entidad_Federativa In (" + Entidad_FederativaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio))
            {
                switch (filter.MunicipioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipioMultiple != null && filter.AdvanceMunicipioMultiple.Count() > 0)
            {
                var MunicipioIds = string.Join(",", filter.AdvanceMunicipioMultiple);

                where += " AND Cadena_de_Custodia.Municipio In (" + MunicipioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Oficio))
            {
                switch (filter.Numero_de_OficioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Numero_de_Oficio LIKE '" + filter.Numero_de_Oficio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Numero_de_Oficio LIKE '%" + filter.Numero_de_Oficio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Numero_de_Oficio = '" + filter.Numero_de_Oficio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Numero_de_Oficio LIKE '%" + filter.Numero_de_Oficio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_CC) || !string.IsNullOrEmpty(filter.ToFecha_CC))
            {
                var Fecha_CCFrom = DateTime.ParseExact(filter.FromFecha_CC, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_CCTo = DateTime.ParseExact(filter.ToFecha_CC, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_CC))
                    where += " AND Cadena_de_Custodia.Fecha_CC >= '" + Fecha_CCFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_CC))
                    where += " AND Cadena_de_Custodia.Fecha_CC <= '" + Fecha_CCTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_CC) || !string.IsNullOrEmpty(filter.ToHora_CC))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_CC))
                    where += " AND Convert(TIME,Cadena_de_Custodia.Hora_CC) >='" + filter.FromHora_CC + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_CC))
                    where += " AND Convert(TIME,Cadena_de_Custodia.Hora_CC) <='" + filter.ToHora_CC + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMotivo_de_Intervencion))
            {
                switch (filter.Motivo_de_IntervencionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_Motivo_de_Intervencion_CC.Descripcion LIKE '" + filter.AdvanceMotivo_de_Intervencion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_Motivo_de_Intervencion_CC.Descripcion LIKE '%" + filter.AdvanceMotivo_de_Intervencion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_Motivo_de_Intervencion_CC.Descripcion = '" + filter.AdvanceMotivo_de_Intervencion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_Motivo_de_Intervencion_CC.Descripcion LIKE '%" + filter.AdvanceMotivo_de_Intervencion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMotivo_de_IntervencionMultiple != null && filter.AdvanceMotivo_de_IntervencionMultiple.Count() > 0)
            {
                var Motivo_de_IntervencionIds = string.Join(",", filter.AdvanceMotivo_de_IntervencionMultiple);

                where += " AND Cadena_de_Custodia.Motivo_de_Intervencion In (" + Motivo_de_IntervencionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Otro))
            {
                switch (filter.OtroFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Otro LIKE '" + filter.Otro + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Otro LIKE '%" + filter.Otro + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Otro = '" + filter.Otro + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Otro LIKE '%" + filter.Otro + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_Estatus_CC.Estatus LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_Estatus_CC.Estatus LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_Estatus_CC.Estatus = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_Estatus_CC.Estatus LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Cadena_de_Custodia.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo))
            {
                switch (filter.Nombre_CompletoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Nombre_Completo LIKE '" + filter.Nombre_Completo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Nombre_Completo = '" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromUsuario_que_Registra) || !string.IsNullOrEmpty(filter.ToUsuario_que_Registra))
            {
                if (!string.IsNullOrEmpty(filter.FromUsuario_que_Registra))
                    where += " AND Cadena_de_Custodia.Usuario_que_Registra >= " + filter.FromUsuario_que_Registra;
                if (!string.IsNullOrEmpty(filter.ToUsuario_que_Registra))
                    where += " AND Cadena_de_Custodia.Usuario_que_Registra <= " + filter.ToUsuario_que_Registra;
            }

            if (!string.IsNullOrEmpty(filter.FAE))
            {
                switch (filter.FAEFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.FAE LIKE '" + filter.FAE + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.FAE LIKE '%" + filter.FAE + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.FAE = '" + filter.FAE + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.FAE LIKE '%" + filter.FAE + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_la_Emergencia) || !string.IsNullOrEmpty(filter.ToFecha_de_la_Emergencia))
            {
                var Fecha_de_la_EmergenciaFrom = DateTime.ParseExact(filter.FromFecha_de_la_Emergencia, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_la_EmergenciaTo = DateTime.ParseExact(filter.ToFecha_de_la_Emergencia, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_la_Emergencia))
                    where += " AND Cadena_de_Custodia.Fecha_de_la_Emergencia >= '" + Fecha_de_la_EmergenciaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_la_Emergencia))
                    where += " AND Cadena_de_Custodia.Fecha_de_la_Emergencia <= '" + Fecha_de_la_EmergenciaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_la_Emergencia) || !string.IsNullOrEmpty(filter.ToHora_de_la_Emergencia))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_la_Emergencia))
                    where += " AND Convert(TIME,Cadena_de_Custodia.Hora_de_la_Emergencia) >='" + filter.FromHora_de_la_Emergencia + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_la_Emergencia))
                    where += " AND Convert(TIME,Cadena_de_Custodia.Hora_de_la_Emergencia) <='" + filter.ToHora_de_la_Emergencia + "'";
            }

            if (!string.IsNullOrEmpty(filter.Fuente))
            {
                switch (filter.FuenteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Fuente LIKE '" + filter.Fuente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Fuente LIKE '%" + filter.Fuente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Fuente = '" + filter.Fuente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Fuente LIKE '%" + filter.Fuente + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Telefono))
            {
                switch (filter.TelefonoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Telefono LIKE '" + filter.Telefono + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Telefono LIKE '%" + filter.Telefono + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Telefono = '" + filter.Telefono + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Telefono LIKE '%" + filter.Telefono + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Celular))
            {
                switch (filter.CelularFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Celular LIKE '" + filter.Celular + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Celular LIKE '%" + filter.Celular + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Celular = '" + filter.Celular + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Celular LIKE '%" + filter.Celular + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Electronico))
            {
                switch (filter.Correo_ElectronicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Correo_Electronico LIKE '" + filter.Correo_Electronico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Correo_Electronico = '" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Red_Social))
            {
                switch (filter.Red_SocialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Red_Social LIKE '" + filter.Red_Social + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Red_Social LIKE '%" + filter.Red_Social + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Red_Social = '" + filter.Red_Social + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Red_Social LIKE '%" + filter.Red_Social + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Medio_Masivo))
            {
                switch (filter.Medio_MasivoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Medio_Masivo LIKE '" + filter.Medio_Masivo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Medio_Masivo LIKE '%" + filter.Medio_Masivo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Medio_Masivo = '" + filter.Medio_Masivo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Medio_Masivo LIKE '%" + filter.Medio_Masivo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Cargo_de_la_Autoridad))
            {
                switch (filter.Cargo_de_la_AutoridadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Cargo_de_la_Autoridad LIKE '" + filter.Cargo_de_la_Autoridad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Cargo_de_la_Autoridad LIKE '%" + filter.Cargo_de_la_Autoridad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Cargo_de_la_Autoridad = '" + filter.Cargo_de_la_Autoridad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Cargo_de_la_Autoridad LIKE '%" + filter.Cargo_de_la_Autoridad + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Tipo_de_Emergencia))
            {
                switch (filter.Tipo_de_EmergenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Tipo_de_Emergencia LIKE '" + filter.Tipo_de_Emergencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Tipo_de_Emergencia LIKE '%" + filter.Tipo_de_Emergencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Tipo_de_Emergencia = '" + filter.Tipo_de_Emergencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Tipo_de_Emergencia LIKE '%" + filter.Tipo_de_Emergencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Descripcion_de_la_Emergencia))
            {
                switch (filter.Descripcion_de_la_EmergenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Descripcion_de_la_Emergencia LIKE '" + filter.Descripcion_de_la_Emergencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Descripcion_de_la_Emergencia LIKE '%" + filter.Descripcion_de_la_Emergencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Descripcion_de_la_Emergencia = '" + filter.Descripcion_de_la_Emergencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Descripcion_de_la_Emergencia LIKE '%" + filter.Descripcion_de_la_Emergencia + "%'";
                        break;
                }
            }

            if (filter.Probables_Detenidos != RadioOptions.NoApply)
                where += " AND Cadena_de_Custodia.Probables_Detenidos = " + Convert.ToInt32(filter.Probables_Detenidos);

            if (!string.IsNullOrEmpty(filter.FromFecha_de_la_Detencion) || !string.IsNullOrEmpty(filter.ToFecha_de_la_Detencion))
            {
                var Fecha_de_la_DetencionFrom = DateTime.ParseExact(filter.FromFecha_de_la_Detencion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_la_DetencionTo = DateTime.ParseExact(filter.ToFecha_de_la_Detencion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_la_Detencion))
                    where += " AND Cadena_de_Custodia.Fecha_de_la_Detencion >= '" + Fecha_de_la_DetencionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_la_Detencion))
                    where += " AND Cadena_de_Custodia.Fecha_de_la_Detencion <= '" + Fecha_de_la_DetencionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_la_Detencion) || !string.IsNullOrEmpty(filter.ToHora_de_la_Detencion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_la_Detencion))
                    where += " AND Convert(TIME,Cadena_de_Custodia.Hora_de_la_Detencion) >='" + filter.FromHora_de_la_Detencion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_la_Detencion))
                    where += " AND Convert(TIME,Cadena_de_Custodia.Hora_de_la_Detencion) <='" + filter.ToHora_de_la_Detencion + "'";
            }

            if (!string.IsNullOrEmpty(filter.Pais_Emergencia))
            {
                switch (filter.Pais_EmergenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Pais_Emergencia LIKE '" + filter.Pais_Emergencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Pais_Emergencia LIKE '%" + filter.Pais_Emergencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Pais_Emergencia = '" + filter.Pais_Emergencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Pais_Emergencia LIKE '%" + filter.Pais_Emergencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Estado_Emergencia))
            {
                switch (filter.Estado_EmergenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Estado_Emergencia LIKE '" + filter.Estado_Emergencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Estado_Emergencia LIKE '%" + filter.Estado_Emergencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Estado_Emergencia = '" + filter.Estado_Emergencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Estado_Emergencia LIKE '%" + filter.Estado_Emergencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Municipio_Emergencia))
            {
                switch (filter.Municipio_EmergenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Municipio_Emergencia LIKE '" + filter.Municipio_Emergencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Municipio_Emergencia LIKE '%" + filter.Municipio_Emergencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Municipio_Emergencia = '" + filter.Municipio_Emergencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Municipio_Emergencia LIKE '%" + filter.Municipio_Emergencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Colonia_Emergencia))
            {
                switch (filter.Colonia_EmergenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Colonia_Emergencia LIKE '" + filter.Colonia_Emergencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Colonia_Emergencia LIKE '%" + filter.Colonia_Emergencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Colonia_Emergencia = '" + filter.Colonia_Emergencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Colonia_Emergencia LIKE '%" + filter.Colonia_Emergencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Calle_Emergencia))
            {
                switch (filter.Calle_EmergenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Calle_Emergencia LIKE '" + filter.Calle_Emergencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Calle_Emergencia LIKE '%" + filter.Calle_Emergencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Calle_Emergencia = '" + filter.Calle_Emergencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Calle_Emergencia LIKE '%" + filter.Calle_Emergencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle_Emergencia))
            {
                switch (filter.Entre_Calle_EmergenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Entre_Calle_Emergencia LIKE '" + filter.Entre_Calle_Emergencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Entre_Calle_Emergencia LIKE '%" + filter.Entre_Calle_Emergencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Entre_Calle_Emergencia = '" + filter.Entre_Calle_Emergencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Entre_Calle_Emergencia LIKE '%" + filter.Entre_Calle_Emergencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Y_Calle_Emergencia))
            {
                switch (filter.Y_Calle_EmergenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Y_Calle_Emergencia LIKE '" + filter.Y_Calle_Emergencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Y_Calle_Emergencia LIKE '%" + filter.Y_Calle_Emergencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Y_Calle_Emergencia = '" + filter.Y_Calle_Emergencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Y_Calle_Emergencia LIKE '%" + filter.Y_Calle_Emergencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud_Emergencia))
            {
                switch (filter.Latitud_EmergenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Latitud_Emergencia LIKE '" + filter.Latitud_Emergencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Latitud_Emergencia LIKE '%" + filter.Latitud_Emergencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Latitud_Emergencia = '" + filter.Latitud_Emergencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Latitud_Emergencia LIKE '%" + filter.Latitud_Emergencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud_Emergencia))
            {
                switch (filter.Longitud_EmergenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Longitud_Emergencia LIKE '" + filter.Longitud_Emergencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Longitud_Emergencia LIKE '%" + filter.Longitud_Emergencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Longitud_Emergencia = '" + filter.Longitud_Emergencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Longitud_Emergencia LIKE '%" + filter.Longitud_Emergencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_de_la_Autoridad))
            {
                switch (filter.Nombre_de_la_AutoridadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Nombre_de_la_Autoridad LIKE '" + filter.Nombre_de_la_Autoridad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Nombre_de_la_Autoridad LIKE '%" + filter.Nombre_de_la_Autoridad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Nombre_de_la_Autoridad = '" + filter.Nombre_de_la_Autoridad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Nombre_de_la_Autoridad LIKE '%" + filter.Nombre_de_la_Autoridad + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Especifique))
            {
                switch (filter.EspecifiqueFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Especifique LIKE '" + filter.Especifique + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Especifique LIKE '%" + filter.Especifique + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Especifique = '" + filter.Especifique + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Especifique LIKE '%" + filter.Especifique + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Tipo_de_Agente))
            {
                switch (filter.Tipo_de_AgenteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Tipo_de_Agente LIKE '" + filter.Tipo_de_Agente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Tipo_de_Agente LIKE '%" + filter.Tipo_de_Agente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Tipo_de_Agente = '" + filter.Tipo_de_Agente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Tipo_de_Agente LIKE '%" + filter.Tipo_de_Agente + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Area))
            {
                switch (filter.AreaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Area LIKE '" + filter.Area + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Area LIKE '%" + filter.Area + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Area = '" + filter.Area + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Area LIKE '%" + filter.Area + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Unidad))
            {
                switch (filter.UnidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Unidad LIKE '" + filter.Unidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Unidad LIKE '%" + filter.Unidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Unidad = '" + filter.Unidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Unidad LIKE '%" + filter.Unidad + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Zona))
            {
                switch (filter.ZonaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Zona LIKE '" + filter.Zona + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Zona LIKE '%" + filter.Zona + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Zona = '" + filter.Zona + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Zona LIKE '%" + filter.Zona + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Agente_Investigador))
            {
                switch (filter.Agente_InvestigadorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Agente_Investigador LIKE '" + filter.Agente_Investigador + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Agente_Investigador LIKE '%" + filter.Agente_Investigador + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Agente_Investigador = '" + filter.Agente_Investigador + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Agente_Investigador LIKE '%" + filter.Agente_Investigador + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Narrativa_de_los_Hechos))
            {
                switch (filter.Narrativa_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Narrativa_de_los_Hechos LIKE '" + filter.Narrativa_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Narrativa_de_los_Hechos LIKE '%" + filter.Narrativa_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Narrativa_de_los_Hechos = '" + filter.Narrativa_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Narrativa_de_los_Hechos LIKE '%" + filter.Narrativa_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Probable_Delito_Principal))
            {
                switch (filter.Probable_Delito_PrincipalFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Probable_Delito_Principal LIKE '" + filter.Probable_Delito_Principal + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Probable_Delito_Principal LIKE '%" + filter.Probable_Delito_Principal + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Probable_Delito_Principal = '" + filter.Probable_Delito_Principal + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Probable_Delito_Principal LIKE '%" + filter.Probable_Delito_Principal + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Asignacion) || !string.IsNullOrEmpty(filter.ToFecha_de_Asignacion))
            {
                var Fecha_de_AsignacionFrom = DateTime.ParseExact(filter.FromFecha_de_Asignacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_AsignacionTo = DateTime.ParseExact(filter.ToFecha_de_Asignacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Asignacion))
                    where += " AND Cadena_de_Custodia.Fecha_de_Asignacion >= '" + Fecha_de_AsignacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Asignacion))
                    where += " AND Cadena_de_Custodia.Fecha_de_Asignacion <= '" + Fecha_de_AsignacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Asignacion) || !string.IsNullOrEmpty(filter.ToHora_de_Asignacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Asignacion))
                    where += " AND Convert(TIME,Cadena_de_Custodia.Hora_de_Asignacion) >='" + filter.FromHora_de_Asignacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Asignacion))
                    where += " AND Convert(TIME,Cadena_de_Custodia.Hora_de_Asignacion) <='" + filter.ToHora_de_Asignacion + "'";
            }

            if (!string.IsNullOrEmpty(filter.Estatus_NUE))
            {
                switch (filter.Estatus_NUEFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Estatus_NUE LIKE '" + filter.Estatus_NUE + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Estatus_NUE LIKE '%" + filter.Estatus_NUE + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Estatus_NUE = '" + filter.Estatus_NUE + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Estatus_NUE LIKE '%" + filter.Estatus_NUE + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceInicio_de_Cadena_de_Custodia))
            {
                switch (filter.Inicio_de_Cadena_de_CustodiaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_de_Inicio_de_Cadena_de_Custodia.Descripcion LIKE '" + filter.AdvanceInicio_de_Cadena_de_Custodia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_de_Inicio_de_Cadena_de_Custodia.Descripcion LIKE '%" + filter.AdvanceInicio_de_Cadena_de_Custodia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_de_Inicio_de_Cadena_de_Custodia.Descripcion = '" + filter.AdvanceInicio_de_Cadena_de_Custodia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_de_Inicio_de_Cadena_de_Custodia.Descripcion LIKE '%" + filter.AdvanceInicio_de_Cadena_de_Custodia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceInicio_de_Cadena_de_CustodiaMultiple != null && filter.AdvanceInicio_de_Cadena_de_CustodiaMultiple.Count() > 0)
            {
                var Inicio_de_Cadena_de_CustodiaIds = string.Join(",", filter.AdvanceInicio_de_Cadena_de_CustodiaMultiple);

                where += " AND Cadena_de_Custodia.Inicio_de_Cadena_de_Custodia In (" + Inicio_de_Cadena_de_CustodiaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCalidad_de_quien_aporta))
            {
                switch (filter.Calidad_de_quien_aportaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Compareciente.Descripcion LIKE '" + filter.AdvanceCalidad_de_quien_aporta + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Compareciente.Descripcion LIKE '%" + filter.AdvanceCalidad_de_quien_aporta + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Compareciente.Descripcion = '" + filter.AdvanceCalidad_de_quien_aporta + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Compareciente.Descripcion LIKE '%" + filter.AdvanceCalidad_de_quien_aporta + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCalidad_de_quien_aportaMultiple != null && filter.AdvanceCalidad_de_quien_aportaMultiple.Count() > 0)
            {
                var Calidad_de_quien_aportaIds = string.Join(",", filter.AdvanceCalidad_de_quien_aportaMultiple);

                where += " AND Cadena_de_Custodia.Calidad_de_quien_aporta In (" + Calidad_de_quien_aportaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_del_arribo) || !string.IsNullOrEmpty(filter.ToFecha_del_arribo))
            {
                var Fecha_del_arriboFrom = DateTime.ParseExact(filter.FromFecha_del_arribo, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_del_arriboTo = DateTime.ParseExact(filter.ToFecha_del_arribo, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_del_arribo))
                    where += " AND Cadena_de_Custodia.Fecha_del_arribo >= '" + Fecha_del_arriboFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_del_arribo))
                    where += " AND Cadena_de_Custodia.Fecha_del_arribo <= '" + Fecha_del_arriboTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_del_arribo) || !string.IsNullOrEmpty(filter.ToHora_del_arribo))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_del_arribo))
                    where += " AND Convert(TIME,Cadena_de_Custodia.Hora_del_arribo) >='" + filter.FromHora_del_arribo + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_del_arribo))
                    where += " AND Convert(TIME,Cadena_de_Custodia.Hora_del_arribo) <='" + filter.ToHora_del_arribo + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDescripcion_de_recoleccion))
            {
                switch (filter.Descripcion_de_recoleccionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_de_Recoleccion.Descripcion LIKE '" + filter.AdvanceDescripcion_de_recoleccion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_de_Recoleccion.Descripcion LIKE '%" + filter.AdvanceDescripcion_de_recoleccion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_de_Recoleccion.Descripcion = '" + filter.AdvanceDescripcion_de_recoleccion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_de_Recoleccion.Descripcion LIKE '%" + filter.AdvanceDescripcion_de_recoleccion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDescripcion_de_recoleccionMultiple != null && filter.AdvanceDescripcion_de_recoleccionMultiple.Count() > 0)
            {
                var Descripcion_de_recoleccionIds = string.Join(",", filter.AdvanceDescripcion_de_recoleccionMultiple);

                where += " AND Cadena_de_Custodia.Descripcion_de_recoleccion In (" + Descripcion_de_recoleccionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMovil_para_Traslado))
            {
                switch (filter.Movil_para_TrasladoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Catalogo_de_Movil_para_traslado.Descripcion LIKE '" + filter.AdvanceMovil_para_Traslado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Catalogo_de_Movil_para_traslado.Descripcion LIKE '%" + filter.AdvanceMovil_para_Traslado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Catalogo_de_Movil_para_traslado.Descripcion = '" + filter.AdvanceMovil_para_Traslado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Catalogo_de_Movil_para_traslado.Descripcion LIKE '%" + filter.AdvanceMovil_para_Traslado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMovil_para_TrasladoMultiple != null && filter.AdvanceMovil_para_TrasladoMultiple.Count() > 0)
            {
                var Movil_para_TrasladoIds = string.Join(",", filter.AdvanceMovil_para_TrasladoMultiple);

                where += " AND Cadena_de_Custodia.Movil_para_Traslado In (" + Movil_para_TrasladoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Servidor_Publico_que_Preserva))
            {
                switch (filter.Servidor_Publico_que_PreservaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Preserva LIKE '" + filter.Servidor_Publico_que_Preserva + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Preserva LIKE '%" + filter.Servidor_Publico_que_Preserva + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Preserva = '" + filter.Servidor_Publico_que_Preserva + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Preserva LIKE '%" + filter.Servidor_Publico_que_Preserva + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Servidor_Publico_que_Busca))
            {
                switch (filter.Servidor_Publico_que_BuscaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Busca LIKE '" + filter.Servidor_Publico_que_Busca + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Busca LIKE '%" + filter.Servidor_Publico_que_Busca + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Busca = '" + filter.Servidor_Publico_que_Busca + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Busca LIKE '%" + filter.Servidor_Publico_que_Busca + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Servidor_Publico_que_Localiza))
            {
                switch (filter.Servidor_Publico_que_LocalizaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Localiza LIKE '" + filter.Servidor_Publico_que_Localiza + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Localiza LIKE '%" + filter.Servidor_Publico_que_Localiza + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Localiza = '" + filter.Servidor_Publico_que_Localiza + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Localiza LIKE '%" + filter.Servidor_Publico_que_Localiza + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Servidor_Publico_que_Recolecta))
            {
                switch (filter.Servidor_Publico_que_RecolectaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Recolecta LIKE '" + filter.Servidor_Publico_que_Recolecta + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Recolecta LIKE '%" + filter.Servidor_Publico_que_Recolecta + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Recolecta = '" + filter.Servidor_Publico_que_Recolecta + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Recolecta LIKE '%" + filter.Servidor_Publico_que_Recolecta + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Servidor_Publico_que_Traslada))
            {
                switch (filter.Servidor_Publico_que_TrasladaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Traslada LIKE '" + filter.Servidor_Publico_que_Traslada + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Traslada LIKE '%" + filter.Servidor_Publico_que_Traslada + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Traslada = '" + filter.Servidor_Publico_que_Traslada + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Servidor_Publico_que_Traslada LIKE '%" + filter.Servidor_Publico_que_Traslada + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Preservacion))
            {
                switch (filter.PreservacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Preservacion LIKE '" + filter.Preservacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Preservacion LIKE '%" + filter.Preservacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Preservacion = '" + filter.Preservacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Preservacion LIKE '%" + filter.Preservacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Busqueda))
            {
                switch (filter.BusquedaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Busqueda LIKE '" + filter.Busqueda + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Busqueda LIKE '%" + filter.Busqueda + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Busqueda = '" + filter.Busqueda + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Busqueda LIKE '%" + filter.Busqueda + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Localizacion))
            {
                switch (filter.LocalizacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Localizacion LIKE '" + filter.Localizacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Localizacion LIKE '%" + filter.Localizacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Localizacion = '" + filter.Localizacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Localizacion LIKE '%" + filter.Localizacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Recoleccion))
            {
                switch (filter.RecoleccionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cadena_de_Custodia.Recoleccion LIKE '" + filter.Recoleccion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cadena_de_Custodia.Recoleccion LIKE '%" + filter.Recoleccion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cadena_de_Custodia.Recoleccion = '" + filter.Recoleccion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cadena_de_Custodia.Recoleccion LIKE '%" + filter.Recoleccion + "%'";
                        break;
                }
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_del_Certificado_CC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_del_Certificado_CCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_del_Certificado_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_del_Certificado_CC.Cadena_de_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_del_Certificado_CC.Cadena_de_Custodia='" + RelationId + "'";
            }
            var result = _IDetalle_del_Certificado_CCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_del_Certificado_CCs == null)
                result.Detalle_del_Certificado_CCs = new List<Detalle_del_Certificado_CC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_del_Certificado_CCs.Select(m => new Detalle_del_Certificado_CCGridModel
                {
                    Clave = m.Clave

			,Certificado = m.Certificado
			,Archivo = m.Archivo
			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_del_Certificado_CCGridModel> GetDetalle_del_Certificado_CCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_del_Certificado_CCGridModel> resultData = new List<Detalle_del_Certificado_CCGridModel>();
            string where = "Detalle_del_Certificado_CC.Cadena_de_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_del_Certificado_CC.Cadena_de_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_del_Certificado_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_del_Certificado_CCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_del_Certificado_CCs != null)
            {
                resultData = result.Detalle_del_Certificado_CCs.Select(m => new Detalle_del_Certificado_CCGridModel
                    {
                        Clave = m.Clave

			,Certificado = m.Certificado
			,Archivo = m.Archivo
			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Fotos_CC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Fotos_CCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Fotos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Fotos_CC.Cadena_de_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Fotos_CC.Cadena_de_Custodia='" + RelationId + "'";
            }
            var result = _IDetalle_de_Fotos_CCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Fotos_CCs == null)
                result.Detalle_de_Fotos_CCs = new List<Detalle_de_Fotos_CC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Fotos_CCs.Select(m => new Detalle_de_Fotos_CCGridModel
                {
                    Clave = m.Clave

			,Fotos = m.Fotos
			,Pie_de_Foto = m.Pie_de_Foto

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Fotos_CCGridModel> GetDetalle_de_Fotos_CCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Fotos_CCGridModel> resultData = new List<Detalle_de_Fotos_CCGridModel>();
            string where = "Detalle_de_Fotos_CC.Cadena_de_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Fotos_CC.Cadena_de_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Fotos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Fotos_CCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Fotos_CCs != null)
            {
                resultData = result.Detalle_de_Fotos_CCs.Select(m => new Detalle_de_Fotos_CCGridModel
                    {
                        Clave = m.Clave

			,Fotos = m.Fotos
			,Pie_de_Foto = m.Pie_de_Foto


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Videos_CC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Videos_CCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Videos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Videos_CC.Cadenade_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Videos_CC.Cadenade_Custodia='" + RelationId + "'";
            }
            var result = _IDetalle_de_Videos_CCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Videos_CCs == null)
                result.Detalle_de_Videos_CCs = new List<Detalle_de_Videos_CC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Videos_CCs.Select(m => new Detalle_de_Videos_CCGridModel
                {
                    Clave = m.Clave

			,Video = m.Video
			,Pie_de_Video = m.Pie_de_Video

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Videos_CCGridModel> GetDetalle_de_Videos_CCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Videos_CCGridModel> resultData = new List<Detalle_de_Videos_CCGridModel>();
            string where = "Detalle_de_Videos_CC.Cadenade_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Videos_CC.Cadenade_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Videos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Videos_CCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Videos_CCs != null)
            {
                resultData = result.Detalle_de_Videos_CCs.Select(m => new Detalle_de_Videos_CCGridModel
                    {
                        Clave = m.Clave

			,Video = m.Video
			,Pie_de_Video = m.Pie_de_Video


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Registro_de_Intervinientes_CC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Registro_de_Intervinientes_CCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Registro_de_Intervinientes_CC.Cadena_de_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Registro_de_Intervinientes_CC.Cadena_de_Custodia='" + RelationId + "'";
            }
            var result = _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Registro_de_Intervinientes_CCs == null)
                result.Detalle_de_Registro_de_Intervinientes_CCs = new List<Detalle_de_Registro_de_Intervinientes_CC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Registro_de_Intervinientes_CCs.Select(m => new Detalle_de_Registro_de_Intervinientes_CCGridModel
                {
                    Clave = m.Clave

			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Alias = m.Alias
			,Anonimo = m.Anonimo
			,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_Genero.Descripcion
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,Escolaridad = m.Escolaridad
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_Escolaridad.Descripcion
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_Ocupacion.Descripcion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre

			,Entre_calle = m.Entre_calle
			,Especifique = m.Especifique
			,Extension = m.Extension
			,Inimputable = m.Inimputable
			,Nombre_Completo = m.Nombre_Completo
			,Originario_de = m.Originario_de
                        ,Pais_de_Origen = m.Pais_de_Origen
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_de_Origen_Pais.Nombre
			,Proteccion_de_Datos = m.Proteccion_de_Datos
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Y_calle = m.Y_calle
                        ,Tipo_de_Compareciente = m.Tipo_de_Compareciente
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                        ,Tipo_de_inimputabilidad = m.Tipo_de_inimputabilidad
                        ,Tipo_de_inimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Nombre = m.Nombre

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Registro_de_Intervinientes_CCGridModel> GetDetalle_de_Registro_de_Intervinientes_CCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Registro_de_Intervinientes_CCGridModel> resultData = new List<Detalle_de_Registro_de_Intervinientes_CCGridModel>();
            string where = "Detalle_de_Registro_de_Intervinientes_CC.Cadena_de_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Registro_de_Intervinientes_CC.Cadena_de_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Registro_de_Intervinientes_CCs != null)
            {
                resultData = result.Detalle_de_Registro_de_Intervinientes_CCs.Select(m => new Detalle_de_Registro_de_Intervinientes_CCGridModel
                    {
                        Clave = m.Clave

			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Alias = m.Alias
			,Anonimo = m.Anonimo
			,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_Genero.Descripcion
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,Escolaridad = m.Escolaridad
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_Escolaridad.Descripcion
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_Ocupacion.Descripcion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre

			,Entre_calle = m.Entre_calle
			,Especifique = m.Especifique
			,Extension = m.Extension
			,Inimputable = m.Inimputable
			,Nombre_Completo = m.Nombre_Completo
			,Originario_de = m.Originario_de
                        ,Pais_de_Origen = m.Pais_de_Origen
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_de_Origen_Pais.Nombre
			,Proteccion_de_Datos = m.Proteccion_de_Datos
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Y_calle = m.Y_calle
                        ,Tipo_de_Compareciente = m.Tipo_de_Compareciente
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                        ,Tipo_de_inimputabilidad = m.Tipo_de_inimputabilidad
                        ,Tipo_de_inimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Nombre = m.Nombre


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Descripcion_de_Evidencia_CC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Descripcion_de_Evidencia_CCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Descripcion_de_Evidencia_CC.Cadena_y_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Descripcion_de_Evidencia_CC.Cadena_y_Custodia='" + RelationId + "'";
            }
            var result = _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Descripcion_de_Evidencia_CCs == null)
                result.Detalle_de_Descripcion_de_Evidencia_CCs = new List<Detalle_de_Descripcion_de_Evidencia_CC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Descripcion_de_Evidencia_CCs.Select(m => new Detalle_de_Descripcion_de_Evidencia_CCGridModel
                {
                    Clave = m.Clave

			,Numero_de_Evidencia = m.Numero_de_Evidencia
			,Descripcion_de_la_Evidencia = m.Descripcion_de_la_Evidencia
			,Origen = m.Origen
			,Descripcion = m.Descripcion
			,Examen_Solicitado = m.Examen_Solicitado
			,Codigo_de_Barras = m.Codigo_de_Barras
			,Archivo_de_Foto = m.Archivo_de_Foto

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Descripcion_de_Evidencia_CCGridModel> GetDetalle_de_Descripcion_de_Evidencia_CCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Descripcion_de_Evidencia_CCGridModel> resultData = new List<Detalle_de_Descripcion_de_Evidencia_CCGridModel>();
            string where = "Detalle_de_Descripcion_de_Evidencia_CC.Cadena_y_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Descripcion_de_Evidencia_CC.Cadena_y_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Descripcion_de_Evidencia_CCs != null)
            {
                resultData = result.Detalle_de_Descripcion_de_Evidencia_CCs.Select(m => new Detalle_de_Descripcion_de_Evidencia_CCGridModel
                    {
                        Clave = m.Clave

			,Numero_de_Evidencia = m.Numero_de_Evidencia
			,Descripcion_de_la_Evidencia = m.Descripcion_de_la_Evidencia
			,Origen = m.Origen
			,Descripcion = m.Descripcion
			,Examen_Solicitado = m.Examen_Solicitado
			,Codigo_de_Barras = m.Codigo_de_Barras
			,Archivo_de_Foto = m.Archivo_de_Foto


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Lista_de_Documentos_CC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Lista_de_Documentos_CCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Lista_de_Documentos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Lista_de_Documentos_CC.Cadena_y_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Lista_de_Documentos_CC.Cadena_y_Custodia='" + RelationId + "'";
            }
            var result = _IDetalle_de_Lista_de_Documentos_CCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Lista_de_Documentos_CCs == null)
                result.Detalle_de_Lista_de_Documentos_CCs = new List<Detalle_de_Lista_de_Documentos_CC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Lista_de_Documentos_CCs.Select(m => new Detalle_de_Lista_de_Documentos_CCGridModel
                {
                    Clave = m.Clave

			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Nombre_del_Archivo = m.Nombre_del_Archivo
			,Archivo = m.Archivo

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Lista_de_Documentos_CCGridModel> GetDetalle_de_Lista_de_Documentos_CCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Lista_de_Documentos_CCGridModel> resultData = new List<Detalle_de_Lista_de_Documentos_CCGridModel>();
            string where = "Detalle_de_Lista_de_Documentos_CC.Cadena_y_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Lista_de_Documentos_CC.Cadena_y_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Lista_de_Documentos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Lista_de_Documentos_CCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Lista_de_Documentos_CCs != null)
            {
                resultData = result.Detalle_de_Lista_de_Documentos_CCs.Select(m => new Detalle_de_Lista_de_Documentos_CCGridModel
                    {
                        Clave = m.Clave

			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Nombre_del_Archivo = m.Nombre_del_Archivo
			,Archivo = m.Archivo


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Retroalimentacion(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_RetroalimentacionGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_RetroalimentacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Retroalimentacion.Cadena_de_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Retroalimentacion.Cadena_de_Custodia='" + RelationId + "'";
            }
            var result = _IDetalle_de_RetroalimentacionApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Retroalimentacions == null)
                result.Detalle_de_Retroalimentacions = new List<Detalle_de_Retroalimentacion>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Retroalimentacions.Select(m => new Detalle_de_RetroalimentacionGridModel
                {
                    Clave = m.Clave

			,Usuario_que_Registra = m.Usuario_que_Registra
			,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
			,Retroalimentacion = m.Retroalimentacion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_RetroalimentacionGridModel> GetDetalle_de_RetroalimentacionData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_RetroalimentacionGridModel> resultData = new List<Detalle_de_RetroalimentacionGridModel>();
            string where = "Detalle_de_Retroalimentacion.Cadena_de_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Retroalimentacion.Cadena_de_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_RetroalimentacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_RetroalimentacionApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Retroalimentacions != null)
            {
                resultData = result.Detalle_de_Retroalimentacions.Select(m => new Detalle_de_RetroalimentacionGridModel
                    {
                        Clave = m.Clave

			,Usuario_que_Registra = m.Usuario_que_Registra
			,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
			,Retroalimentacion = m.Retroalimentacion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Referencia(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_ReferenciaGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_ReferenciaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Referencia.Cadena_de_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Referencia.Cadena_de_Custodia='" + RelationId + "'";
            }
            var result = _IDetalle_de_ReferenciaApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Referencias == null)
                result.Detalle_de_Referencias = new List<Detalle_de_Referencia>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Referencias.Select(m => new Detalle_de_ReferenciaGridModel
                {
                    Clave = m.Clave

			,Punto_de_Referencia = m.Punto_de_Referencia
			,Descripcion = m.Descripcion
			,Distancia = m.Distancia

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_ReferenciaGridModel> GetDetalle_de_ReferenciaData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_ReferenciaGridModel> resultData = new List<Detalle_de_ReferenciaGridModel>();
            string where = "Detalle_de_Referencia.Cadena_de_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Referencia.Cadena_de_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_ReferenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_ReferenciaApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Referencias != null)
            {
                resultData = result.Detalle_de_Referencias.Select(m => new Detalle_de_ReferenciaGridModel
                    {
                        Clave = m.Clave

			,Punto_de_Referencia = m.Punto_de_Referencia
			,Descripcion = m.Descripcion
			,Distancia = m.Distancia


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Fotos_de_Emergencia_CC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Fotos_de_Emergencia_CCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Fotos_de_Emergencia_CC.Cadena_de_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Fotos_de_Emergencia_CC.Cadena_de_Custodia='" + RelationId + "'";
            }
            var result = _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Fotos_de_Emergencia_CCs == null)
                result.Detalle_de_Fotos_de_Emergencia_CCs = new List<Detalle_de_Fotos_de_Emergencia_CC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Fotos_de_Emergencia_CCs.Select(m => new Detalle_de_Fotos_de_Emergencia_CCGridModel
                {
                    Clave = m.Clave

			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Latitud = m.Latitud
			,Longitud = m.Longitud

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Fotos_de_Emergencia_CCGridModel> GetDetalle_de_Fotos_de_Emergencia_CCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Fotos_de_Emergencia_CCGridModel> resultData = new List<Detalle_de_Fotos_de_Emergencia_CCGridModel>();
            string where = "Detalle_de_Fotos_de_Emergencia_CC.Cadena_de_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Fotos_de_Emergencia_CC.Cadena_de_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Fotos_de_Emergencia_CCs != null)
            {
                resultData = result.Detalle_de_Fotos_de_Emergencia_CCs.Select(m => new Detalle_de_Fotos_de_Emergencia_CCGridModel
                    {
                        Clave = m.Clave

			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Latitud = m.Latitud
			,Longitud = m.Longitud


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Historial_de_Emergencia_CC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Historial_de_Emergencia_CCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Historial_de_Emergencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Historial_de_Emergencia_CC.Cadena_de_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Historial_de_Emergencia_CC.Cadena_de_Custodia='" + RelationId + "'";
            }
            var result = _IDetalle_de_Historial_de_Emergencia_CCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Historial_de_Emergencia_CCs == null)
                result.Detalle_de_Historial_de_Emergencia_CCs = new List<Detalle_de_Historial_de_Emergencia_CC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Historial_de_Emergencia_CCs.Select(m => new Detalle_de_Historial_de_Emergencia_CCGridModel
                {
                    Clave = m.Clave

			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Estatus = m.Estatus
			,Comentarios = m.Comentarios
			,Usuario_que_registra = m.Usuario_que_registra

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Historial_de_Emergencia_CCGridModel> GetDetalle_de_Historial_de_Emergencia_CCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Historial_de_Emergencia_CCGridModel> resultData = new List<Detalle_de_Historial_de_Emergencia_CCGridModel>();
            string where = "Detalle_de_Historial_de_Emergencia_CC.Cadena_de_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Historial_de_Emergencia_CC.Cadena_de_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Historial_de_Emergencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Historial_de_Emergencia_CCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Historial_de_Emergencia_CCs != null)
            {
                resultData = result.Detalle_de_Historial_de_Emergencia_CCs.Select(m => new Detalle_de_Historial_de_Emergencia_CCGridModel
                    {
                        Clave = m.Clave

			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Estatus = m.Estatus
			,Comentarios = m.Comentarios
			,Usuario_que_registra = m.Usuario_que_registra


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Datos_del_Imputado_CC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Datos_del_Imputado_CCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Datos_del_Imputado_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Datos_del_Imputado_CC.Cadena_de_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Datos_del_Imputado_CC.Cadena_de_Custodia='" + RelationId + "'";
            }
            var result = _IDetalle_de_Datos_del_Imputado_CCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Datos_del_Imputado_CCs == null)
                result.Detalle_de_Datos_del_Imputado_CCs = new List<Detalle_de_Datos_del_Imputado_CC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Datos_del_Imputado_CCs.Select(m => new Detalle_de_Datos_del_Imputado_CCGridModel
                {
                    Clave = m.Clave

			,A_Quien_Resulte_Responsable = m.A_Quien_Resulte_Responsable
			,Alias = m.Alias
			,Apellido_Materno = m.Apellido_Materno
			,Apellido_Paterno = m.Apellido_Paterno
			,Calle = m.Calle
			,Celular = m.Celular
			,Codigo_Postal = m.Codigo_Postal
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Correo_Electronico = m.Correo_Electronico
			,Edad = m.Edad
			,Entre_calle = m.Entre_calle
			,Escolaridad = m.Escolaridad
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_Estado_Civil.Descripcion
			,Estension = m.Estension
			,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))

			,Inimputable = m.Inimputable
                        ,Tipo_de_Inimputabilidad = m.Tipo_de_Inimputabilidad
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Especifique = m.Especifique
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_Nacionalidad.NacionalidadC
			,Nombre = m.Nombre
			,Nombre_Completo = m.Nombre_Completo
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_Ocupacion.Descripcion
			,Originario_de = m.Originario_de
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
                        ,Pais_de_Origen = m.Pais_de_Origen
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_de_Origen_Pais.Nombre
			,Proteccion_de_datos = m.Proteccion_de_datos
			,Referencia_de_domicilio = m.Referencia_de_domicilio
                        ,Genero = m.Genero
                        ,GeneroDescripcion = CultureHelper.GetTraduction(m.Genero_Genero.Clave.ToString(), "Descripcion") ??(string)m.Genero_Genero.Descripcion
			,Telefono = m.Telefono
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Y_calle = m.Y_calle

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Datos_del_Imputado_CCGridModel> GetDetalle_de_Datos_del_Imputado_CCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Datos_del_Imputado_CCGridModel> resultData = new List<Detalle_de_Datos_del_Imputado_CCGridModel>();
            string where = "Detalle_de_Datos_del_Imputado_CC.Cadena_de_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Datos_del_Imputado_CC.Cadena_de_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Datos_del_Imputado_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Datos_del_Imputado_CCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Datos_del_Imputado_CCs != null)
            {
                resultData = result.Detalle_de_Datos_del_Imputado_CCs.Select(m => new Detalle_de_Datos_del_Imputado_CCGridModel
                    {
                        Clave = m.Clave

			,A_Quien_Resulte_Responsable = m.A_Quien_Resulte_Responsable
			,Alias = m.Alias
			,Apellido_Materno = m.Apellido_Materno
			,Apellido_Paterno = m.Apellido_Paterno
			,Calle = m.Calle
			,Celular = m.Celular
			,Codigo_Postal = m.Codigo_Postal
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Correo_Electronico = m.Correo_Electronico
			,Edad = m.Edad
			,Entre_calle = m.Entre_calle
			,Escolaridad = m.Escolaridad
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_Estado_Civil.Descripcion
			,Estension = m.Estension
			,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))

			,Inimputable = m.Inimputable
                        ,Tipo_de_Inimputabilidad = m.Tipo_de_Inimputabilidad
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Especifique = m.Especifique
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_Nacionalidad.NacionalidadC
			,Nombre = m.Nombre
			,Nombre_Completo = m.Nombre_Completo
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_Ocupacion.Descripcion
			,Originario_de = m.Originario_de
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
                        ,Pais_de_Origen = m.Pais_de_Origen
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_de_Origen_Pais.Nombre
			,Proteccion_de_datos = m.Proteccion_de_datos
			,Referencia_de_domicilio = m.Referencia_de_domicilio
                        ,Genero = m.Genero
                        ,GeneroDescripcion = CultureHelper.GetTraduction(m.Genero_Genero.Clave.ToString(), "Descripcion") ??(string)m.Genero_Genero.Descripcion
			,Telefono = m.Telefono
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Y_calle = m.Y_calle


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Datos_del_Testigo_CC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Datos_del_Testigo_CCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Datos_del_Testigo_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Datos_del_Testigo_CC.Cadena_de_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Datos_del_Testigo_CC.Cadena_de_Custodia='" + RelationId + "'";
            }
            var result = _IDetalle_de_Datos_del_Testigo_CCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Datos_del_Testigo_CCs == null)
                result.Detalle_de_Datos_del_Testigo_CCs = new List<Detalle_de_Datos_del_Testigo_CC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Datos_del_Testigo_CCs.Select(m => new Detalle_de_Datos_del_Testigo_CCGridModel
                {
                    Clave = m.Clave

			,Apellido_Materno = m.Apellido_Materno
			,Apellido_Paterno = m.Apellido_Paterno
			,Calle = m.Calle
			,Celular = m.Celular
			,Codigo_Postal = m.Codigo_Postal
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Correo_Electronico = m.Correo_Electronico
			,Edad = m.Edad
                        ,Escolaridad = m.Escolaridad
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_Escolaridad.Descripcion
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_Estado_Civil.Descripcion
			,Extension = m.Extension
			,Fecha_de_nacimiento = (m.Fecha_de_nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Inimputable = m.Inimputable
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_Nacionalidad.NacionalidadC
			,Nombre = m.Nombre
			,Nombre_Completo = m.Nombre_Completo
			,Numero_de_identificacion = m.Numero_de_identificacion
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_Ocupacion.Descripcion
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
			,Proteccion_de_Datos = m.Proteccion_de_Datos
                        ,Genero = m.Genero
                        ,GeneroDescripcion = CultureHelper.GetTraduction(m.Genero_Genero.Clave.ToString(), "Descripcion") ??(string)m.Genero_Genero.Descripcion
			,Telefono = m.Telefono
                        ,Tipo_de_compareciente = m.Tipo_de_compareciente
                        ,Tipo_de_comparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_compareciente_Tipo_de_Compareciente.Descripcion
                        ,Tipo_de_identificacion = m.Tipo_de_identificacion
                        ,Tipo_de_identificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_identificacion_Tipo_de_Identificacion.Nombre
                        ,Tipo_de_inimputabilidad = m.Tipo_de_inimputabilidad
                        ,Tipo_de_inimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Referencia_del_Domicilio = m.Referencia_del_Domicilio
			,Especifique = m.Especifique


                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Datos_del_Testigo_CCGridModel> GetDetalle_de_Datos_del_Testigo_CCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Datos_del_Testigo_CCGridModel> resultData = new List<Detalle_de_Datos_del_Testigo_CCGridModel>();
            string where = "Detalle_de_Datos_del_Testigo_CC.Cadena_de_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Datos_del_Testigo_CC.Cadena_de_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Datos_del_Testigo_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Datos_del_Testigo_CCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Datos_del_Testigo_CCs != null)
            {
                resultData = result.Detalle_de_Datos_del_Testigo_CCs.Select(m => new Detalle_de_Datos_del_Testigo_CCGridModel
                    {
                        Clave = m.Clave

			,Apellido_Materno = m.Apellido_Materno
			,Apellido_Paterno = m.Apellido_Paterno
			,Calle = m.Calle
			,Celular = m.Celular
			,Codigo_Postal = m.Codigo_Postal
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_Colonia.Nombre
			,Correo_Electronico = m.Correo_Electronico
			,Edad = m.Edad
                        ,Escolaridad = m.Escolaridad
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ??(string)m.Escolaridad_Escolaridad.Descripcion
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_Estado.Nombre
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_Estado_Civil.Descripcion
			,Extension = m.Extension
			,Fecha_de_nacimiento = (m.Fecha_de_nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Inimputable = m.Inimputable
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_Municipio.Nombre
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_Nacionalidad.NacionalidadC
			,Nombre = m.Nombre
			,Nombre_Completo = m.Nombre_Completo
			,Numero_de_identificacion = m.Numero_de_identificacion
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ??(string)m.Ocupacion_Ocupacion.Descripcion
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_Pais.Nombre
			,Proteccion_de_Datos = m.Proteccion_de_Datos
                        ,Genero = m.Genero
                        ,GeneroDescripcion = CultureHelper.GetTraduction(m.Genero_Genero.Clave.ToString(), "Descripcion") ??(string)m.Genero_Genero.Descripcion
			,Telefono = m.Telefono
                        ,Tipo_de_compareciente = m.Tipo_de_compareciente
                        ,Tipo_de_comparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_compareciente_Tipo_de_Compareciente.Descripcion
                        ,Tipo_de_identificacion = m.Tipo_de_identificacion
                        ,Tipo_de_identificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_identificacion_Tipo_de_Identificacion.Nombre
                        ,Tipo_de_inimputabilidad = m.Tipo_de_inimputabilidad
                        ,Tipo_de_inimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Referencia_del_Domicilio = m.Referencia_del_Domicilio
			,Especifique = m.Especifique



                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetCatalogo_Tipo_de_Embalaje_CC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Catalogo_Tipo_de_Embalaje_CCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _ICatalogo_Tipo_de_Embalaje_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Catalogo_Tipo_de_Embalaje_CC.Cadena_de_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Catalogo_Tipo_de_Embalaje_CC.Cadena_de_Custodia='" + RelationId + "'";
            }
            var result = _ICatalogo_Tipo_de_Embalaje_CCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Catalogo_Tipo_de_Embalaje_CCs == null)
                result.Catalogo_Tipo_de_Embalaje_CCs = new List<Catalogo_Tipo_de_Embalaje_CC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Catalogo_Tipo_de_Embalaje_CCs.Select(m => new Catalogo_Tipo_de_Embalaje_CCGridModel
                {
                    Clave = m.Clave

			,Descripcion = m.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Catalogo_Tipo_de_Embalaje_CCGridModel> GetCatalogo_Tipo_de_Embalaje_CCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Catalogo_Tipo_de_Embalaje_CCGridModel> resultData = new List<Catalogo_Tipo_de_Embalaje_CCGridModel>();
            string where = "Catalogo_Tipo_de_Embalaje_CC.Cadena_de_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Catalogo_Tipo_de_Embalaje_CC.Cadena_de_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _ICatalogo_Tipo_de_Embalaje_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _ICatalogo_Tipo_de_Embalaje_CCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Catalogo_Tipo_de_Embalaje_CCs != null)
            {
                resultData = result.Catalogo_Tipo_de_Embalaje_CCs.Select(m => new Catalogo_Tipo_de_Embalaje_CCGridModel
                    {
                        Clave = m.Clave

			,Descripcion = m.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Lista_de_Asignaciones(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Lista_de_AsignacionesGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Lista_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Lista_de_Asignaciones.Cadena_de_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Lista_de_Asignaciones.Cadena_de_Custodia='" + RelationId + "'";
            }
            var result = _IDetalle_de_Lista_de_AsignacionesApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Lista_de_Asignacioness == null)
                result.Detalle_de_Lista_de_Asignacioness = new List<Detalle_de_Lista_de_Asignaciones>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Lista_de_Asignacioness.Select(m => new Detalle_de_Lista_de_AsignacionesGridModel
                {
                    Clave = m.Clave

			,Numero_de_Asignacion = m.Numero_de_Asignacion
			,Nombre = m.Nombre
			,Realizado = m.Realizado
			,Especifique = m.Especifique

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Lista_de_AsignacionesGridModel> GetDetalle_de_Lista_de_AsignacionesData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Lista_de_AsignacionesGridModel> resultData = new List<Detalle_de_Lista_de_AsignacionesGridModel>();
            string where = "Detalle_de_Lista_de_Asignaciones.Cadena_de_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Lista_de_Asignaciones.Cadena_de_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Lista_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Lista_de_AsignacionesApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Lista_de_Asignacioness != null)
            {
                resultData = result.Detalle_de_Lista_de_Asignacioness.Select(m => new Detalle_de_Lista_de_AsignacionesGridModel
                    {
                        Clave = m.Clave

			,Numero_de_Asignacion = m.Numero_de_Asignacion
			,Nombre = m.Nombre
			,Realizado = m.Realizado
			,Especifique = m.Especifique


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetCatalogo_Tipo_de_Fijacion_CC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Catalogo_Tipo_de_Fijacion_CCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Catalogo_Tipo_de_Fijacion_CC.Cadena_y_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Catalogo_Tipo_de_Fijacion_CC.Cadena_y_Custodia='" + RelationId + "'";
            }
            var result = _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Catalogo_Tipo_de_Fijacion_CCs == null)
                result.Catalogo_Tipo_de_Fijacion_CCs = new List<Catalogo_Tipo_de_Fijacion_CC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Catalogo_Tipo_de_Fijacion_CCs.Select(m => new Catalogo_Tipo_de_Fijacion_CCGridModel
                {
                    Clave = m.Clave

			,Descripcion = m.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Catalogo_Tipo_de_Fijacion_CCGridModel> GetCatalogo_Tipo_de_Fijacion_CCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Catalogo_Tipo_de_Fijacion_CCGridModel> resultData = new List<Catalogo_Tipo_de_Fijacion_CCGridModel>();
            string where = "Catalogo_Tipo_de_Fijacion_CC.Cadena_y_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Catalogo_Tipo_de_Fijacion_CC.Cadena_y_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Catalogo_Tipo_de_Fijacion_CCs != null)
            {
                resultData = result.Catalogo_Tipo_de_Fijacion_CCs.Select(m => new Catalogo_Tipo_de_Fijacion_CCGridModel
                    {
                        Clave = m.Clave

			,Descripcion = m.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Traslado_de_CC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Traslado_de_CCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Traslado_de_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Traslado_de_CC.Cadena_de_Custodia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Traslado_de_CC.Cadena_de_Custodia='" + RelationId + "'";
            }
            var result = _IDetalle_de_Traslado_de_CCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Traslado_de_CCs == null)
                result.Detalle_de_Traslado_de_CCs = new List<Detalle_de_Traslado_de_CC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Traslado_de_CCs.Select(m => new Detalle_de_Traslado_de_CCGridModel
                {
                    Clave = m.Clave

			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Temperatura = m.Temperatura
			,Humedad = m.Humedad
			,Latitud = m.Latitud
			,Longitud = m.Longitud
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Catalogo_de_Estatus_de_Traslado.Clave.ToString(), "Descripcion") ??(string)m.Estatus_Catalogo_de_Estatus_de_Traslado.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Traslado_de_CCGridModel> GetDetalle_de_Traslado_de_CCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Traslado_de_CCGridModel> resultData = new List<Detalle_de_Traslado_de_CCGridModel>();
            string where = "Detalle_de_Traslado_de_CC.Cadena_de_Custodia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Traslado_de_CC.Cadena_de_Custodia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Traslado_de_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Traslado_de_CCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Traslado_de_CCs != null)
            {
                resultData = result.Detalle_de_Traslado_de_CCs.Select(m => new Detalle_de_Traslado_de_CCGridModel
                    {
                        Clave = m.Clave

			,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Temperatura = m.Temperatura
			,Humedad = m.Humedad
			,Latitud = m.Latitud
			,Longitud = m.Longitud
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Catalogo_de_Estatus_de_Traslado.Clave.ToString(), "Descripcion") ??(string)m.Estatus_Catalogo_de_Estatus_de_Traslado.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetCatalogo_Tipo_de_Indicio_CC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Catalogo_Tipo_de_Indicio_CCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _ICatalogo_Tipo_de_Indicio_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Catalogo_Tipo_de_Indicio_CC.Tipo_de_Indicio=" + RelationId;
            if("int" == "string")
            {
	           where = "Catalogo_Tipo_de_Indicio_CC.Tipo_de_Indicio='" + RelationId + "'";
            }
            var result = _ICatalogo_Tipo_de_Indicio_CCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Catalogo_Tipo_de_Indicio_CCs == null)
                result.Catalogo_Tipo_de_Indicio_CCs = new List<Catalogo_Tipo_de_Indicio_CC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Catalogo_Tipo_de_Indicio_CCs.Select(m => new Catalogo_Tipo_de_Indicio_CCGridModel
                {
                    Clave = m.Clave

			,Descripcion = m.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Catalogo_Tipo_de_Indicio_CCGridModel> GetCatalogo_Tipo_de_Indicio_CCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Catalogo_Tipo_de_Indicio_CCGridModel> resultData = new List<Catalogo_Tipo_de_Indicio_CCGridModel>();
            string where = "Catalogo_Tipo_de_Indicio_CC.Tipo_de_Indicio=" + Id;
            if("int" == "string")
            {
                where = "Catalogo_Tipo_de_Indicio_CC.Tipo_de_Indicio='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _ICatalogo_Tipo_de_Indicio_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _ICatalogo_Tipo_de_Indicio_CCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Catalogo_Tipo_de_Indicio_CCs != null)
            {
                resultData = result.Catalogo_Tipo_de_Indicio_CCs.Select(m => new Catalogo_Tipo_de_Indicio_CCGridModel
                    {
                        Clave = m.Clave

			,Descripcion = m.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }


        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);

                Cadena_de_Custodia varCadena_de_Custodia = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_del_Certificado_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_del_Certificado_CC.Cadena_de_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_del_Certificado_CC.Cadena_de_Custodia='" + id + "'";
                    }
                    var Detalle_del_Certificado_CCInfo =
                        _IDetalle_del_Certificado_CCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_del_Certificado_CCInfo.Detalle_del_Certificado_CCs.Count > 0)
                    {
                        var resultDetalle_del_Certificado_CC = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_del_Certificado_CCItem in Detalle_del_Certificado_CCInfo.Detalle_del_Certificado_CCs)
                            resultDetalle_del_Certificado_CC = resultDetalle_del_Certificado_CC
                                              && _IDetalle_del_Certificado_CCApiConsumer.Delete(Detalle_del_Certificado_CCItem.Clave, null,null).Resource;

                        if (!resultDetalle_del_Certificado_CC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Fotos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Fotos_CC.Cadena_de_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Fotos_CC.Cadena_de_Custodia='" + id + "'";
                    }
                    var Detalle_de_Fotos_CCInfo =
                        _IDetalle_de_Fotos_CCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Fotos_CCInfo.Detalle_de_Fotos_CCs.Count > 0)
                    {
                        var resultDetalle_de_Fotos_CC = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Fotos_CCItem in Detalle_de_Fotos_CCInfo.Detalle_de_Fotos_CCs)
                            resultDetalle_de_Fotos_CC = resultDetalle_de_Fotos_CC
                                              && _IDetalle_de_Fotos_CCApiConsumer.Delete(Detalle_de_Fotos_CCItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Fotos_CC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Videos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Videos_CC.Cadenade_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Videos_CC.Cadenade_Custodia='" + id + "'";
                    }
                    var Detalle_de_Videos_CCInfo =
                        _IDetalle_de_Videos_CCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Videos_CCInfo.Detalle_de_Videos_CCs.Count > 0)
                    {
                        var resultDetalle_de_Videos_CC = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Videos_CCItem in Detalle_de_Videos_CCInfo.Detalle_de_Videos_CCs)
                            resultDetalle_de_Videos_CC = resultDetalle_de_Videos_CC
                                              && _IDetalle_de_Videos_CCApiConsumer.Delete(Detalle_de_Videos_CCItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Videos_CC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Registro_de_Intervinientes_CC.Cadena_de_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Registro_de_Intervinientes_CC.Cadena_de_Custodia='" + id + "'";
                    }
                    var Detalle_de_Registro_de_Intervinientes_CCInfo =
                        _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Registro_de_Intervinientes_CCInfo.Detalle_de_Registro_de_Intervinientes_CCs.Count > 0)
                    {
                        var resultDetalle_de_Registro_de_Intervinientes_CC = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Registro_de_Intervinientes_CCItem in Detalle_de_Registro_de_Intervinientes_CCInfo.Detalle_de_Registro_de_Intervinientes_CCs)
                            resultDetalle_de_Registro_de_Intervinientes_CC = resultDetalle_de_Registro_de_Intervinientes_CC
                                              && _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.Delete(Detalle_de_Registro_de_Intervinientes_CCItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Registro_de_Intervinientes_CC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Descripcion_de_Evidencia_CC.Cadena_y_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Descripcion_de_Evidencia_CC.Cadena_y_Custodia='" + id + "'";
                    }
                    var Detalle_de_Descripcion_de_Evidencia_CCInfo =
                        _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Descripcion_de_Evidencia_CCInfo.Detalle_de_Descripcion_de_Evidencia_CCs.Count > 0)
                    {
                        var resultDetalle_de_Descripcion_de_Evidencia_CC = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Descripcion_de_Evidencia_CCItem in Detalle_de_Descripcion_de_Evidencia_CCInfo.Detalle_de_Descripcion_de_Evidencia_CCs)
                            resultDetalle_de_Descripcion_de_Evidencia_CC = resultDetalle_de_Descripcion_de_Evidencia_CC
                                              && _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer.Delete(Detalle_de_Descripcion_de_Evidencia_CCItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Descripcion_de_Evidencia_CC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Lista_de_Documentos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Lista_de_Documentos_CC.Cadena_y_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Lista_de_Documentos_CC.Cadena_y_Custodia='" + id + "'";
                    }
                    var Detalle_de_Lista_de_Documentos_CCInfo =
                        _IDetalle_de_Lista_de_Documentos_CCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Lista_de_Documentos_CCInfo.Detalle_de_Lista_de_Documentos_CCs.Count > 0)
                    {
                        var resultDetalle_de_Lista_de_Documentos_CC = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Lista_de_Documentos_CCItem in Detalle_de_Lista_de_Documentos_CCInfo.Detalle_de_Lista_de_Documentos_CCs)
                            resultDetalle_de_Lista_de_Documentos_CC = resultDetalle_de_Lista_de_Documentos_CC
                                              && _IDetalle_de_Lista_de_Documentos_CCApiConsumer.Delete(Detalle_de_Lista_de_Documentos_CCItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Lista_de_Documentos_CC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_RetroalimentacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Retroalimentacion.Cadena_de_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Retroalimentacion.Cadena_de_Custodia='" + id + "'";
                    }
                    var Detalle_de_RetroalimentacionInfo =
                        _IDetalle_de_RetroalimentacionApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_RetroalimentacionInfo.Detalle_de_Retroalimentacions.Count > 0)
                    {
                        var resultDetalle_de_Retroalimentacion = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_RetroalimentacionItem in Detalle_de_RetroalimentacionInfo.Detalle_de_Retroalimentacions)
                            resultDetalle_de_Retroalimentacion = resultDetalle_de_Retroalimentacion
                                              && _IDetalle_de_RetroalimentacionApiConsumer.Delete(Detalle_de_RetroalimentacionItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Retroalimentacion)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_ReferenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Referencia.Cadena_de_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Referencia.Cadena_de_Custodia='" + id + "'";
                    }
                    var Detalle_de_ReferenciaInfo =
                        _IDetalle_de_ReferenciaApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_ReferenciaInfo.Detalle_de_Referencias.Count > 0)
                    {
                        var resultDetalle_de_Referencia = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_ReferenciaItem in Detalle_de_ReferenciaInfo.Detalle_de_Referencias)
                            resultDetalle_de_Referencia = resultDetalle_de_Referencia
                                              && _IDetalle_de_ReferenciaApiConsumer.Delete(Detalle_de_ReferenciaItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Referencia)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Fotos_de_Emergencia_CC.Cadena_de_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Fotos_de_Emergencia_CC.Cadena_de_Custodia='" + id + "'";
                    }
                    var Detalle_de_Fotos_de_Emergencia_CCInfo =
                        _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Fotos_de_Emergencia_CCInfo.Detalle_de_Fotos_de_Emergencia_CCs.Count > 0)
                    {
                        var resultDetalle_de_Fotos_de_Emergencia_CC = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Fotos_de_Emergencia_CCItem in Detalle_de_Fotos_de_Emergencia_CCInfo.Detalle_de_Fotos_de_Emergencia_CCs)
                            resultDetalle_de_Fotos_de_Emergencia_CC = resultDetalle_de_Fotos_de_Emergencia_CC
                                              && _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer.Delete(Detalle_de_Fotos_de_Emergencia_CCItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Fotos_de_Emergencia_CC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Historial_de_Emergencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Historial_de_Emergencia_CC.Cadena_de_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Historial_de_Emergencia_CC.Cadena_de_Custodia='" + id + "'";
                    }
                    var Detalle_de_Historial_de_Emergencia_CCInfo =
                        _IDetalle_de_Historial_de_Emergencia_CCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Historial_de_Emergencia_CCInfo.Detalle_de_Historial_de_Emergencia_CCs.Count > 0)
                    {
                        var resultDetalle_de_Historial_de_Emergencia_CC = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Historial_de_Emergencia_CCItem in Detalle_de_Historial_de_Emergencia_CCInfo.Detalle_de_Historial_de_Emergencia_CCs)
                            resultDetalle_de_Historial_de_Emergencia_CC = resultDetalle_de_Historial_de_Emergencia_CC
                                              && _IDetalle_de_Historial_de_Emergencia_CCApiConsumer.Delete(Detalle_de_Historial_de_Emergencia_CCItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Historial_de_Emergencia_CC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Datos_del_Imputado_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Datos_del_Imputado_CC.Cadena_de_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Datos_del_Imputado_CC.Cadena_de_Custodia='" + id + "'";
                    }
                    var Detalle_de_Datos_del_Imputado_CCInfo =
                        _IDetalle_de_Datos_del_Imputado_CCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Datos_del_Imputado_CCInfo.Detalle_de_Datos_del_Imputado_CCs.Count > 0)
                    {
                        var resultDetalle_de_Datos_del_Imputado_CC = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Datos_del_Imputado_CCItem in Detalle_de_Datos_del_Imputado_CCInfo.Detalle_de_Datos_del_Imputado_CCs)
                            resultDetalle_de_Datos_del_Imputado_CC = resultDetalle_de_Datos_del_Imputado_CC
                                              && _IDetalle_de_Datos_del_Imputado_CCApiConsumer.Delete(Detalle_de_Datos_del_Imputado_CCItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Datos_del_Imputado_CC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Datos_del_Testigo_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Datos_del_Testigo_CC.Cadena_de_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Datos_del_Testigo_CC.Cadena_de_Custodia='" + id + "'";
                    }
                    var Detalle_de_Datos_del_Testigo_CCInfo =
                        _IDetalle_de_Datos_del_Testigo_CCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Datos_del_Testigo_CCInfo.Detalle_de_Datos_del_Testigo_CCs.Count > 0)
                    {
                        var resultDetalle_de_Datos_del_Testigo_CC = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Datos_del_Testigo_CCItem in Detalle_de_Datos_del_Testigo_CCInfo.Detalle_de_Datos_del_Testigo_CCs)
                            resultDetalle_de_Datos_del_Testigo_CC = resultDetalle_de_Datos_del_Testigo_CC
                                              && _IDetalle_de_Datos_del_Testigo_CCApiConsumer.Delete(Detalle_de_Datos_del_Testigo_CCItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Datos_del_Testigo_CC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _ICatalogo_Tipo_de_Embalaje_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Catalogo_Tipo_de_Embalaje_CC.Cadena_de_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Catalogo_Tipo_de_Embalaje_CC.Cadena_de_Custodia='" + id + "'";
                    }
                    var Catalogo_Tipo_de_Embalaje_CCInfo =
                        _ICatalogo_Tipo_de_Embalaje_CCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Catalogo_Tipo_de_Embalaje_CCInfo.Catalogo_Tipo_de_Embalaje_CCs.Count > 0)
                    {
                        var resultCatalogo_Tipo_de_Embalaje_CC = true;
                        //Removing associated job history with attachment
                        foreach (var Catalogo_Tipo_de_Embalaje_CCItem in Catalogo_Tipo_de_Embalaje_CCInfo.Catalogo_Tipo_de_Embalaje_CCs)
                            resultCatalogo_Tipo_de_Embalaje_CC = resultCatalogo_Tipo_de_Embalaje_CC
                                              && _ICatalogo_Tipo_de_Embalaje_CCApiConsumer.Delete(Catalogo_Tipo_de_Embalaje_CCItem.Clave, null,null).Resource;

                        if (!resultCatalogo_Tipo_de_Embalaje_CC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Lista_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Lista_de_Asignaciones.Cadena_de_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Lista_de_Asignaciones.Cadena_de_Custodia='" + id + "'";
                    }
                    var Detalle_de_Lista_de_AsignacionesInfo =
                        _IDetalle_de_Lista_de_AsignacionesApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Lista_de_AsignacionesInfo.Detalle_de_Lista_de_Asignacioness.Count > 0)
                    {
                        var resultDetalle_de_Lista_de_Asignaciones = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Lista_de_AsignacionesItem in Detalle_de_Lista_de_AsignacionesInfo.Detalle_de_Lista_de_Asignacioness)
                            resultDetalle_de_Lista_de_Asignaciones = resultDetalle_de_Lista_de_Asignaciones
                                              && _IDetalle_de_Lista_de_AsignacionesApiConsumer.Delete(Detalle_de_Lista_de_AsignacionesItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Lista_de_Asignaciones)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Catalogo_Tipo_de_Fijacion_CC.Cadena_y_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Catalogo_Tipo_de_Fijacion_CC.Cadena_y_Custodia='" + id + "'";
                    }
                    var Catalogo_Tipo_de_Fijacion_CCInfo =
                        _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Catalogo_Tipo_de_Fijacion_CCInfo.Catalogo_Tipo_de_Fijacion_CCs.Count > 0)
                    {
                        var resultCatalogo_Tipo_de_Fijacion_CC = true;
                        //Removing associated job history with attachment
                        foreach (var Catalogo_Tipo_de_Fijacion_CCItem in Catalogo_Tipo_de_Fijacion_CCInfo.Catalogo_Tipo_de_Fijacion_CCs)
                            resultCatalogo_Tipo_de_Fijacion_CC = resultCatalogo_Tipo_de_Fijacion_CC
                                              && _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.Delete(Catalogo_Tipo_de_Fijacion_CCItem.Clave, null,null).Resource;

                        if (!resultCatalogo_Tipo_de_Fijacion_CC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Traslado_de_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Traslado_de_CC.Cadena_de_Custodia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Traslado_de_CC.Cadena_de_Custodia='" + id + "'";
                    }
                    var Detalle_de_Traslado_de_CCInfo =
                        _IDetalle_de_Traslado_de_CCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Traslado_de_CCInfo.Detalle_de_Traslado_de_CCs.Count > 0)
                    {
                        var resultDetalle_de_Traslado_de_CC = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Traslado_de_CCItem in Detalle_de_Traslado_de_CCInfo.Detalle_de_Traslado_de_CCs)
                            resultDetalle_de_Traslado_de_CC = resultDetalle_de_Traslado_de_CC
                                              && _IDetalle_de_Traslado_de_CCApiConsumer.Delete(Detalle_de_Traslado_de_CCItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Traslado_de_CC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _ICatalogo_Tipo_de_Indicio_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Catalogo_Tipo_de_Indicio_CC.Tipo_de_Indicio=" + id;
                    if("int" == "string")
                    {
	                where = "Catalogo_Tipo_de_Indicio_CC.Tipo_de_Indicio='" + id + "'";
                    }
                    var Catalogo_Tipo_de_Indicio_CCInfo =
                        _ICatalogo_Tipo_de_Indicio_CCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Catalogo_Tipo_de_Indicio_CCInfo.Catalogo_Tipo_de_Indicio_CCs.Count > 0)
                    {
                        var resultCatalogo_Tipo_de_Indicio_CC = true;
                        //Removing associated job history with attachment
                        foreach (var Catalogo_Tipo_de_Indicio_CCItem in Catalogo_Tipo_de_Indicio_CCInfo.Catalogo_Tipo_de_Indicio_CCs)
                            resultCatalogo_Tipo_de_Indicio_CC = resultCatalogo_Tipo_de_Indicio_CC
                                              && _ICatalogo_Tipo_de_Indicio_CCApiConsumer.Delete(Catalogo_Tipo_de_Indicio_CCItem.Clave, null,null).Resource;

                        if (!resultCatalogo_Tipo_de_Indicio_CC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _ICadena_de_CustodiaApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Cadena_de_CustodiaModel varCadena_de_Custodia)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varCadena_de_Custodia.Fijacion_PlanimetricaRemoveAttachment != 0 && varCadena_de_Custodia.Fijacion_PlanimetricaFile == null)
                    {
                        varCadena_de_Custodia.Fijacion_Planimetrica = 0;
                    }

                    if (varCadena_de_Custodia.Fijacion_PlanimetricaFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varCadena_de_Custodia.Fijacion_PlanimetricaFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varCadena_de_Custodia.Fijacion_Planimetrica = (short)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varCadena_de_Custodia.Fijacion_PlanimetricaFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Cadena_de_CustodiaInfo = new Cadena_de_Custodia
                    {
                        Clave = varCadena_de_Custodia.Clave
                        ,NUC = varCadena_de_Custodia.NUC
                        ,NIC = varCadena_de_Custodia.NIC
                        ,Delito_Referencia = varCadena_de_Custodia.Delito_Referencia
                        ,Fecha = (!String.IsNullOrEmpty(varCadena_de_Custodia.Fecha)) ? DateTime.ParseExact(varCadena_de_Custodia.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varCadena_de_Custodia.Hora
                        ,Lugar_Exacto_del_Levantamiento = varCadena_de_Custodia.Lugar_Exacto_del_Levantamiento
                        ,Condicion_y_Ubicacion = varCadena_de_Custodia.Condicion_y_Ubicacion
                        ,Levantada_por = varCadena_de_Custodia.Levantada_por
                        ,Cargo = varCadena_de_Custodia.Cargo
                        ,Asignar = varCadena_de_Custodia.Asignar
                        ,Folio_NUE = varCadena_de_Custodia.Folio_NUE
                        ,Unidad_Policial = varCadena_de_Custodia.Unidad_Policial
                        ,Caracterististicas_del_indicio = varCadena_de_Custodia.Caracterististicas_del_indicio
                        ,Condiciones_De_Manejo = varCadena_de_Custodia.Condiciones_De_Manejo
                        ,Numero_de_Parte = varCadena_de_Custodia.Numero_de_Parte
                        ,CUIP = varCadena_de_Custodia.CUIP
                        ,Observaciones = varCadena_de_Custodia.Observaciones
                        ,Longitud = varCadena_de_Custodia.Longitud
                        ,Latitud = varCadena_de_Custodia.Latitud
                        ,Clima = varCadena_de_Custodia.Clima
                        ,Grados = varCadena_de_Custodia.Grados
                        ,Fijacion_Planimetrica = (varCadena_de_Custodia.Fijacion_Planimetrica.HasValue && varCadena_de_Custodia.Fijacion_Planimetrica != 0) ? ((int?)Convert.ToInt32(varCadena_de_Custodia.Fijacion_Planimetrica.Value)) : null

                        ,Mensaje = varCadena_de_Custodia.Mensaje
                        ,Unidad_Administrativa = varCadena_de_Custodia.Unidad_Administrativa
                        ,Entidad_Federativa = varCadena_de_Custodia.Entidad_Federativa
                        ,Municipio = varCadena_de_Custodia.Municipio
                        ,Numero_de_Oficio = varCadena_de_Custodia.Numero_de_Oficio
                        ,Fecha_CC = (!String.IsNullOrEmpty(varCadena_de_Custodia.Fecha_CC)) ? DateTime.ParseExact(varCadena_de_Custodia.Fecha_CC, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_CC = varCadena_de_Custodia.Hora_CC
                        ,Motivo_de_Intervencion = varCadena_de_Custodia.Motivo_de_Intervencion
                        ,Otro = varCadena_de_Custodia.Otro
                        ,Estatus = varCadena_de_Custodia.Estatus
                        ,Nombre_Completo = varCadena_de_Custodia.Nombre_Completo
                        ,Usuario_que_Registra = varCadena_de_Custodia.Usuario_que_Registra
                        ,FAE = varCadena_de_Custodia.FAE
                        ,Fecha_de_la_Emergencia = (!String.IsNullOrEmpty(varCadena_de_Custodia.Fecha_de_la_Emergencia)) ? DateTime.ParseExact(varCadena_de_Custodia.Fecha_de_la_Emergencia, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_la_Emergencia = varCadena_de_Custodia.Hora_de_la_Emergencia
                        ,Fuente = varCadena_de_Custodia.Fuente
                        ,Telefono = varCadena_de_Custodia.Telefono
                        ,Celular = varCadena_de_Custodia.Celular
                        ,Correo_Electronico = varCadena_de_Custodia.Correo_Electronico
                        ,Red_Social = varCadena_de_Custodia.Red_Social
                        ,Medio_Masivo = varCadena_de_Custodia.Medio_Masivo
                        ,Cargo_de_la_Autoridad = varCadena_de_Custodia.Cargo_de_la_Autoridad
                        ,Tipo_de_Emergencia = varCadena_de_Custodia.Tipo_de_Emergencia
                        ,Descripcion_de_la_Emergencia = varCadena_de_Custodia.Descripcion_de_la_Emergencia
                        ,Probables_Detenidos = varCadena_de_Custodia.Probables_Detenidos
                        ,Fecha_de_la_Detencion = (!String.IsNullOrEmpty(varCadena_de_Custodia.Fecha_de_la_Detencion)) ? DateTime.ParseExact(varCadena_de_Custodia.Fecha_de_la_Detencion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_la_Detencion = varCadena_de_Custodia.Hora_de_la_Detencion
                        ,Pais_Emergencia = varCadena_de_Custodia.Pais_Emergencia
                        ,Estado_Emergencia = varCadena_de_Custodia.Estado_Emergencia
                        ,Municipio_Emergencia = varCadena_de_Custodia.Municipio_Emergencia
                        ,Colonia_Emergencia = varCadena_de_Custodia.Colonia_Emergencia
                        ,Calle_Emergencia = varCadena_de_Custodia.Calle_Emergencia
                        ,Entre_Calle_Emergencia = varCadena_de_Custodia.Entre_Calle_Emergencia
                        ,Y_Calle_Emergencia = varCadena_de_Custodia.Y_Calle_Emergencia
                        ,Latitud_Emergencia = varCadena_de_Custodia.Latitud_Emergencia
                        ,Longitud_Emergencia = varCadena_de_Custodia.Longitud_Emergencia
                        ,Nombre_de_la_Autoridad = varCadena_de_Custodia.Nombre_de_la_Autoridad
                        ,Especifique = varCadena_de_Custodia.Especifique
                        ,Tipo_de_Agente = varCadena_de_Custodia.Tipo_de_Agente
                        ,Area = varCadena_de_Custodia.Area
                        ,Unidad = varCadena_de_Custodia.Unidad
                        ,Zona = varCadena_de_Custodia.Zona
                        ,Agente_Investigador = varCadena_de_Custodia.Agente_Investigador
                        ,Narrativa_de_los_Hechos = varCadena_de_Custodia.Narrativa_de_los_Hechos
                        ,Probable_Delito_Principal = varCadena_de_Custodia.Probable_Delito_Principal
                        ,Fecha_de_Asignacion = (!String.IsNullOrEmpty(varCadena_de_Custodia.Fecha_de_Asignacion)) ? DateTime.ParseExact(varCadena_de_Custodia.Fecha_de_Asignacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Asignacion = varCadena_de_Custodia.Hora_de_Asignacion
                        ,Estatus_NUE = varCadena_de_Custodia.Estatus_NUE
                        ,Inicio_de_Cadena_de_Custodia = varCadena_de_Custodia.Inicio_de_Cadena_de_Custodia
                        ,Calidad_de_quien_aporta = varCadena_de_Custodia.Calidad_de_quien_aporta
                        ,Fecha_del_arribo = (!String.IsNullOrEmpty(varCadena_de_Custodia.Fecha_del_arribo)) ? DateTime.ParseExact(varCadena_de_Custodia.Fecha_del_arribo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_del_arribo = varCadena_de_Custodia.Hora_del_arribo
                        ,Descripcion_de_recoleccion = varCadena_de_Custodia.Descripcion_de_recoleccion
                        ,Movil_para_Traslado = varCadena_de_Custodia.Movil_para_Traslado
                        ,Servidor_Publico_que_Preserva = varCadena_de_Custodia.Servidor_Publico_que_Preserva
                        ,Servidor_Publico_que_Busca = varCadena_de_Custodia.Servidor_Publico_que_Busca
                        ,Servidor_Publico_que_Localiza = varCadena_de_Custodia.Servidor_Publico_que_Localiza
                        ,Servidor_Publico_que_Recolecta = varCadena_de_Custodia.Servidor_Publico_que_Recolecta
                        ,Servidor_Publico_que_Traslada = varCadena_de_Custodia.Servidor_Publico_que_Traslada
                        ,Preservacion = varCadena_de_Custodia.Preservacion
                        ,Busqueda = varCadena_de_Custodia.Busqueda
                        ,Localizacion = varCadena_de_Custodia.Localizacion
                        ,Recoleccion = varCadena_de_Custodia.Recoleccion

                    };

                    result = !IsNew ?
                        _ICadena_de_CustodiaApiConsumer.Update(Cadena_de_CustodiaInfo, null, null).Resource.ToString() :
                         _ICadena_de_CustodiaApiConsumer.Insert(Cadena_de_CustodiaInfo, null, null).Resource.ToString();
					Session["KeyValueInserted"] = result;
                    return Json(result, JsonRequestBehavior.AllowGet);
				//}
				//return Json(false, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [NonAction]
        public bool CopyDetalle_del_Certificado_CC(int MasterId, int referenceId, List<Detalle_del_Certificado_CCGridModelPost> Detalle_del_Certificado_CCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_del_Certificado_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_del_Certificado_CCData = _IDetalle_del_Certificado_CCApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_del_Certificado_CC.Cadena_de_Custodia=" + referenceId,"").Resource;
                if (Detalle_del_Certificado_CCData == null || Detalle_del_Certificado_CCData.Detalle_del_Certificado_CCs.Count == 0)
                    return true;

                var result = true;

                Detalle_del_Certificado_CCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_del_Certificado_CC in Detalle_del_Certificado_CCData.Detalle_del_Certificado_CCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_del_Certificado_CC Detalle_del_Certificado_CC1 = varDetalle_del_Certificado_CC;

                    if (Detalle_del_Certificado_CCItems != null && Detalle_del_Certificado_CCItems.Any(m => m.Clave == Detalle_del_Certificado_CC1.Clave))
                    {
                        modelDataToChange = Detalle_del_Certificado_CCItems.FirstOrDefault(m => m.Clave == Detalle_del_Certificado_CC1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_del_Certificado_CC.Cadena_de_Custodia = MasterId;
                    var insertId = _IDetalle_del_Certificado_CCApiConsumer.Insert(varDetalle_del_Certificado_CC,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_del_Certificado_CC(List<Detalle_del_Certificado_CCGridModelPost> Detalle_del_Certificado_CCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_del_Certificado_CC(MasterId, referenceId, Detalle_del_Certificado_CCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_del_Certificado_CCItems != null && Detalle_del_Certificado_CCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_del_Certificado_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_del_Certificado_CCItem in Detalle_del_Certificado_CCItems)
                    {





                        //Removal Request
                        if (Detalle_del_Certificado_CCItem.Removed)
                        {
                            result = result && _IDetalle_del_Certificado_CCApiConsumer.Delete(Detalle_del_Certificado_CCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_del_Certificado_CCItem.Clave = 0;

                        var Detalle_del_Certificado_CCData = new Detalle_del_Certificado_CC
                        {
                            Cadena_de_Custodia = MasterId
                            ,Clave = Detalle_del_Certificado_CCItem.Clave
                            ,Certificado = Detalle_del_Certificado_CCItem.Certificado
                            ,Archivo = Detalle_del_Certificado_CCItem.Archivo
                            ,Fecha = (Detalle_del_Certificado_CCItem.Fecha!= null) ? DateTime.ParseExact(Detalle_del_Certificado_CCItem.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null

                        };

                        var resultId = Detalle_del_Certificado_CCItem.Clave > 0
                           ? _IDetalle_del_Certificado_CCApiConsumer.Update(Detalle_del_Certificado_CCData,null,null).Resource
                           : _IDetalle_del_Certificado_CCApiConsumer.Insert(Detalle_del_Certificado_CCData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }






        [NonAction]
        public bool CopyDetalle_de_Fotos_CC(int MasterId, int referenceId, List<Detalle_de_Fotos_CCGridModelPost> Detalle_de_Fotos_CCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Fotos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Fotos_CCData = _IDetalle_de_Fotos_CCApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Fotos_CC.Cadena_de_Custodia=" + referenceId,"").Resource;
                if (Detalle_de_Fotos_CCData == null || Detalle_de_Fotos_CCData.Detalle_de_Fotos_CCs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Fotos_CCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Fotos_CC in Detalle_de_Fotos_CCData.Detalle_de_Fotos_CCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Fotos_CC Detalle_de_Fotos_CC1 = varDetalle_de_Fotos_CC;

                    if (Detalle_de_Fotos_CCItems != null && Detalle_de_Fotos_CCItems.Any(m => m.Clave == Detalle_de_Fotos_CC1.Clave))
                    {
                        modelDataToChange = Detalle_de_Fotos_CCItems.FirstOrDefault(m => m.Clave == Detalle_de_Fotos_CC1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Fotos_CC.Cadena_de_Custodia = MasterId;
                    var insertId = _IDetalle_de_Fotos_CCApiConsumer.Insert(varDetalle_de_Fotos_CC,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Fotos_CC(List<Detalle_de_Fotos_CCGridModelPost> Detalle_de_Fotos_CCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Fotos_CC(MasterId, referenceId, Detalle_de_Fotos_CCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Fotos_CCItems != null && Detalle_de_Fotos_CCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Fotos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Fotos_CCItem in Detalle_de_Fotos_CCItems)
                    {




                        //Removal Request
                        if (Detalle_de_Fotos_CCItem.Removed)
                        {
                            result = result && _IDetalle_de_Fotos_CCApiConsumer.Delete(Detalle_de_Fotos_CCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Fotos_CCItem.Clave = 0;

                        var Detalle_de_Fotos_CCData = new Detalle_de_Fotos_CC
                        {
                            Cadena_de_Custodia = MasterId
                            ,Clave = Detalle_de_Fotos_CCItem.Clave
                            ,Fotos = Detalle_de_Fotos_CCItem.Fotos
                            ,Pie_de_Foto = Detalle_de_Fotos_CCItem.Pie_de_Foto

                        };

                        var resultId = Detalle_de_Fotos_CCItem.Clave > 0
                           ? _IDetalle_de_Fotos_CCApiConsumer.Update(Detalle_de_Fotos_CCData,null,null).Resource
                           : _IDetalle_de_Fotos_CCApiConsumer.Insert(Detalle_de_Fotos_CCData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public bool CopyDetalle_de_Videos_CC(int MasterId, int referenceId, List<Detalle_de_Videos_CCGridModelPost> Detalle_de_Videos_CCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Videos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Videos_CCData = _IDetalle_de_Videos_CCApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Videos_CC.Cadenade_Custodia=" + referenceId,"").Resource;
                if (Detalle_de_Videos_CCData == null || Detalle_de_Videos_CCData.Detalle_de_Videos_CCs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Videos_CCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Videos_CC in Detalle_de_Videos_CCData.Detalle_de_Videos_CCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Videos_CC Detalle_de_Videos_CC1 = varDetalle_de_Videos_CC;

                    if (Detalle_de_Videos_CCItems != null && Detalle_de_Videos_CCItems.Any(m => m.Clave == Detalle_de_Videos_CC1.Clave))
                    {
                        modelDataToChange = Detalle_de_Videos_CCItems.FirstOrDefault(m => m.Clave == Detalle_de_Videos_CC1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Videos_CC.Cadenade_Custodia = MasterId;
                    var insertId = _IDetalle_de_Videos_CCApiConsumer.Insert(varDetalle_de_Videos_CC,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Videos_CC(List<Detalle_de_Videos_CCGridModelPost> Detalle_de_Videos_CCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Videos_CC(MasterId, referenceId, Detalle_de_Videos_CCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Videos_CCItems != null && Detalle_de_Videos_CCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Videos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Videos_CCItem in Detalle_de_Videos_CCItems)
                    {




                        //Removal Request
                        if (Detalle_de_Videos_CCItem.Removed)
                        {
                            result = result && _IDetalle_de_Videos_CCApiConsumer.Delete(Detalle_de_Videos_CCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Videos_CCItem.Clave = 0;

                        var Detalle_de_Videos_CCData = new Detalle_de_Videos_CC
                        {
                            Cadenade_Custodia = MasterId
                            ,Clave = Detalle_de_Videos_CCItem.Clave
                            ,Video = Detalle_de_Videos_CCItem.Video
                            ,Pie_de_Video = Detalle_de_Videos_CCItem.Pie_de_Video

                        };

                        var resultId = Detalle_de_Videos_CCItem.Clave > 0
                           ? _IDetalle_de_Videos_CCApiConsumer.Update(Detalle_de_Videos_CCData,null,null).Resource
                           : _IDetalle_de_Videos_CCApiConsumer.Insert(Detalle_de_Videos_CCData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public bool CopyDetalle_de_Registro_de_Intervinientes_CC(int MasterId, int referenceId, List<Detalle_de_Registro_de_Intervinientes_CCGridModelPost> Detalle_de_Registro_de_Intervinientes_CCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Registro_de_Intervinientes_CCData = _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Registro_de_Intervinientes_CC.Cadena_de_Custodia=" + referenceId,"").Resource;
                if (Detalle_de_Registro_de_Intervinientes_CCData == null || Detalle_de_Registro_de_Intervinientes_CCData.Detalle_de_Registro_de_Intervinientes_CCs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Registro_de_Intervinientes_CCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Registro_de_Intervinientes_CC in Detalle_de_Registro_de_Intervinientes_CCData.Detalle_de_Registro_de_Intervinientes_CCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Registro_de_Intervinientes_CC Detalle_de_Registro_de_Intervinientes_CC1 = varDetalle_de_Registro_de_Intervinientes_CC;

                    if (Detalle_de_Registro_de_Intervinientes_CCItems != null && Detalle_de_Registro_de_Intervinientes_CCItems.Any(m => m.Clave == Detalle_de_Registro_de_Intervinientes_CC1.Clave))
                    {
                        modelDataToChange = Detalle_de_Registro_de_Intervinientes_CCItems.FirstOrDefault(m => m.Clave == Detalle_de_Registro_de_Intervinientes_CC1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Registro_de_Intervinientes_CC.Cadena_de_Custodia = MasterId;
                    var insertId = _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.Insert(varDetalle_de_Registro_de_Intervinientes_CC,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Registro_de_Intervinientes_CC(List<Detalle_de_Registro_de_Intervinientes_CCGridModelPost> Detalle_de_Registro_de_Intervinientes_CCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Registro_de_Intervinientes_CC(MasterId, referenceId, Detalle_de_Registro_de_Intervinientes_CCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Registro_de_Intervinientes_CCItems != null && Detalle_de_Registro_de_Intervinientes_CCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Registro_de_Intervinientes_CCItem in Detalle_de_Registro_de_Intervinientes_CCItems)
                    {









































                        //Removal Request
                        if (Detalle_de_Registro_de_Intervinientes_CCItem.Removed)
                        {
                            result = result && _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.Delete(Detalle_de_Registro_de_Intervinientes_CCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Registro_de_Intervinientes_CCItem.Clave = 0;

                        var Detalle_de_Registro_de_Intervinientes_CCData = new Detalle_de_Registro_de_Intervinientes_CC
                        {
                            Cadena_de_Custodia = MasterId
                            ,Clave = Detalle_de_Registro_de_Intervinientes_CCItem.Clave
                            ,Nombres = Detalle_de_Registro_de_Intervinientes_CCItem.Nombres
                            ,Apellido_Paterno = Detalle_de_Registro_de_Intervinientes_CCItem.Apellido_Paterno
                            ,Apellido_Materno = Detalle_de_Registro_de_Intervinientes_CCItem.Apellido_Materno
                            ,Alias = Detalle_de_Registro_de_Intervinientes_CCItem.Alias
                            ,Anonimo = Detalle_de_Registro_de_Intervinientes_CCItem.Anonimo
                            ,Fecha_de_Nacimiento = (Detalle_de_Registro_de_Intervinientes_CCItem.Fecha_de_Nacimiento!= null) ? DateTime.ParseExact(Detalle_de_Registro_de_Intervinientes_CCItem.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Edad = Detalle_de_Registro_de_Intervinientes_CCItem.Edad
                            ,Sexo = (Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Sexo) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Sexo))
                            ,Estado_Civil = (Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Estado_Civil) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Estado_Civil))
                            ,Tipo_de_Identificacion = (Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Tipo_de_Identificacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Tipo_de_Identificacion))
                            ,Numero_de_Identificacion = Detalle_de_Registro_de_Intervinientes_CCItem.Numero_de_Identificacion
                            ,Escolaridad = (Convert.ToInt16(Detalle_de_Registro_de_Intervinientes_CCItem.Escolaridad) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_de_Registro_de_Intervinientes_CCItem.Escolaridad))
                            ,Ocupacion = (Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Ocupacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Ocupacion))
                            ,Nacionalidad = (Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Nacionalidad) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Nacionalidad))
                            ,Estado = (Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Estado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Estado))
                            ,Municipio = (Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Municipio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Municipio))
                            ,Colonia = (Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Colonia) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Colonia))
                            ,Codigo_Postal = Detalle_de_Registro_de_Intervinientes_CCItem.Codigo_Postal
                            ,Calle = Detalle_de_Registro_de_Intervinientes_CCItem.Calle
                            ,Numero_Exterior = Detalle_de_Registro_de_Intervinientes_CCItem.Numero_Exterior
                            ,Numero_Interior = Detalle_de_Registro_de_Intervinientes_CCItem.Numero_Interior
                            ,Telefono = Detalle_de_Registro_de_Intervinientes_CCItem.Telefono
                            ,Celular = Detalle_de_Registro_de_Intervinientes_CCItem.Celular
                            ,Correo_Electronico = Detalle_de_Registro_de_Intervinientes_CCItem.Correo_Electronico
                            ,Pais = (Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Pais) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Pais))

                            ,Entre_calle = Detalle_de_Registro_de_Intervinientes_CCItem.Entre_calle
                            ,Especifique = Detalle_de_Registro_de_Intervinientes_CCItem.Especifique
                            ,Extension = Detalle_de_Registro_de_Intervinientes_CCItem.Extension
                            ,Inimputable = Detalle_de_Registro_de_Intervinientes_CCItem.Inimputable
                            ,Nombre_Completo = Detalle_de_Registro_de_Intervinientes_CCItem.Nombre_Completo
                            ,Originario_de = Detalle_de_Registro_de_Intervinientes_CCItem.Originario_de
                            ,Pais_de_Origen = (Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Pais_de_Origen) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Pais_de_Origen))
                            ,Proteccion_de_Datos = Detalle_de_Registro_de_Intervinientes_CCItem.Proteccion_de_Datos
                            ,Referencia_de_Domicilio = Detalle_de_Registro_de_Intervinientes_CCItem.Referencia_de_Domicilio
                            ,Y_calle = Detalle_de_Registro_de_Intervinientes_CCItem.Y_calle
                            ,Tipo_de_Compareciente = (Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Tipo_de_Compareciente) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Tipo_de_Compareciente))
                            ,Tipo_de_inimputabilidad = (Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Tipo_de_inimputabilidad) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Registro_de_Intervinientes_CCItem.Tipo_de_inimputabilidad))
                            ,Nombre = Detalle_de_Registro_de_Intervinientes_CCItem.Nombre

                        };

                        var resultId = Detalle_de_Registro_de_Intervinientes_CCItem.Clave > 0
                           ? _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.Update(Detalle_de_Registro_de_Intervinientes_CCData,null,null).Resource
                           : _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.Insert(Detalle_de_Registro_de_Intervinientes_CCData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }









        [HttpGet]
        public ActionResult GetDetalle_de_Registro_de_Intervinientes_CC_GeneroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGeneroApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Genero", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Registro_de_Intervinientes_CC_Estado_CivilAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstado_CivilApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado_Civil", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Registro_de_Intervinientes_CC_Tipo_de_IdentificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_IdentificacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Identificacion", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_de_Registro_de_Intervinientes_CC_EscolaridadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEscolaridadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Escolaridad", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Registro_de_Intervinientes_CC_OcupacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOcupacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Ocupacion", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Registro_de_Intervinientes_CC_NacionalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _INacionalidadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Nacionalidad", "NacionalidadC");
                  item.NacionalidadC= trans??item.NacionalidadC;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Registro_de_Intervinientes_CC_EstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Registro_de_Intervinientes_CC_MunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Registro_de_Intervinientes_CC_ColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }







        [HttpGet]
        public ActionResult GetDetalle_de_Registro_de_Intervinientes_CC_PaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }









        [HttpGet]
        public ActionResult GetDetalle_de_Registro_de_Intervinientes_CC_Tipo_de_ComparecienteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ComparecienteApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Compareciente", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Registro_de_Intervinientes_CC_Tipo_de_InimputabilidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_InimputabilidadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Inimputabilidad", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [NonAction]
        public bool CopyDetalle_de_Descripcion_de_Evidencia_CC(int MasterId, int referenceId, List<Detalle_de_Descripcion_de_Evidencia_CCGridModelPost> Detalle_de_Descripcion_de_Evidencia_CCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Descripcion_de_Evidencia_CCData = _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Descripcion_de_Evidencia_CC.Cadena_y_Custodia=" + referenceId,"").Resource;
                if (Detalle_de_Descripcion_de_Evidencia_CCData == null || Detalle_de_Descripcion_de_Evidencia_CCData.Detalle_de_Descripcion_de_Evidencia_CCs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Descripcion_de_Evidencia_CCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Descripcion_de_Evidencia_CC in Detalle_de_Descripcion_de_Evidencia_CCData.Detalle_de_Descripcion_de_Evidencia_CCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Descripcion_de_Evidencia_CC Detalle_de_Descripcion_de_Evidencia_CC1 = varDetalle_de_Descripcion_de_Evidencia_CC;

                    if (Detalle_de_Descripcion_de_Evidencia_CCItems != null && Detalle_de_Descripcion_de_Evidencia_CCItems.Any(m => m.Clave == Detalle_de_Descripcion_de_Evidencia_CC1.Clave))
                    {
                        modelDataToChange = Detalle_de_Descripcion_de_Evidencia_CCItems.FirstOrDefault(m => m.Clave == Detalle_de_Descripcion_de_Evidencia_CC1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Descripcion_de_Evidencia_CC.Cadena_y_Custodia = MasterId;
                    var insertId = _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer.Insert(varDetalle_de_Descripcion_de_Evidencia_CC,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Descripcion_de_Evidencia_CC(List<Detalle_de_Descripcion_de_Evidencia_CCGridModelPost> Detalle_de_Descripcion_de_Evidencia_CCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Descripcion_de_Evidencia_CC(MasterId, referenceId, Detalle_de_Descripcion_de_Evidencia_CCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Descripcion_de_Evidencia_CCItems != null && Detalle_de_Descripcion_de_Evidencia_CCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Descripcion_de_Evidencia_CCItem in Detalle_de_Descripcion_de_Evidencia_CCItems)
                    {









                        //Removal Request
                        if (Detalle_de_Descripcion_de_Evidencia_CCItem.Removed)
                        {
                            result = result && _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer.Delete(Detalle_de_Descripcion_de_Evidencia_CCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Descripcion_de_Evidencia_CCItem.Clave = 0;

                        var Detalle_de_Descripcion_de_Evidencia_CCData = new Detalle_de_Descripcion_de_Evidencia_CC
                        {
                            Cadena_y_Custodia = MasterId
                            ,Clave = Detalle_de_Descripcion_de_Evidencia_CCItem.Clave
                            ,Numero_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCItem.Numero_de_Evidencia
                            ,Descripcion_de_la_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCItem.Descripcion_de_la_Evidencia
                            ,Origen = Detalle_de_Descripcion_de_Evidencia_CCItem.Origen
                            ,Descripcion = Detalle_de_Descripcion_de_Evidencia_CCItem.Descripcion
                            ,Examen_Solicitado = Detalle_de_Descripcion_de_Evidencia_CCItem.Examen_Solicitado
                            ,Codigo_de_Barras = Detalle_de_Descripcion_de_Evidencia_CCItem.Codigo_de_Barras
                            ,Archivo_de_Foto = Detalle_de_Descripcion_de_Evidencia_CCItem.Archivo_de_Foto

                        };

                        var resultId = Detalle_de_Descripcion_de_Evidencia_CCItem.Clave > 0
                           ? _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer.Update(Detalle_de_Descripcion_de_Evidencia_CCData,null,null).Resource
                           : _IDetalle_de_Descripcion_de_Evidencia_CCApiConsumer.Insert(Detalle_de_Descripcion_de_Evidencia_CCData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }










        [NonAction]
        public bool CopyDetalle_de_Lista_de_Documentos_CC(int MasterId, int referenceId, List<Detalle_de_Lista_de_Documentos_CCGridModelPost> Detalle_de_Lista_de_Documentos_CCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Lista_de_Documentos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Lista_de_Documentos_CCData = _IDetalle_de_Lista_de_Documentos_CCApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Lista_de_Documentos_CC.Cadena_y_Custodia=" + referenceId,"").Resource;
                if (Detalle_de_Lista_de_Documentos_CCData == null || Detalle_de_Lista_de_Documentos_CCData.Detalle_de_Lista_de_Documentos_CCs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Lista_de_Documentos_CCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Lista_de_Documentos_CC in Detalle_de_Lista_de_Documentos_CCData.Detalle_de_Lista_de_Documentos_CCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Lista_de_Documentos_CC Detalle_de_Lista_de_Documentos_CC1 = varDetalle_de_Lista_de_Documentos_CC;

                    if (Detalle_de_Lista_de_Documentos_CCItems != null && Detalle_de_Lista_de_Documentos_CCItems.Any(m => m.Clave == Detalle_de_Lista_de_Documentos_CC1.Clave))
                    {
                        modelDataToChange = Detalle_de_Lista_de_Documentos_CCItems.FirstOrDefault(m => m.Clave == Detalle_de_Lista_de_Documentos_CC1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Lista_de_Documentos_CC.Cadena_y_Custodia = MasterId;
                    var insertId = _IDetalle_de_Lista_de_Documentos_CCApiConsumer.Insert(varDetalle_de_Lista_de_Documentos_CC,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Lista_de_Documentos_CC(List<Detalle_de_Lista_de_Documentos_CCGridModelPost> Detalle_de_Lista_de_Documentos_CCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Lista_de_Documentos_CC(MasterId, referenceId, Detalle_de_Lista_de_Documentos_CCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Lista_de_Documentos_CCItems != null && Detalle_de_Lista_de_Documentos_CCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Lista_de_Documentos_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Lista_de_Documentos_CCItem in Detalle_de_Lista_de_Documentos_CCItems)
                    {





                        //Removal Request
                        if (Detalle_de_Lista_de_Documentos_CCItem.Removed)
                        {
                            result = result && _IDetalle_de_Lista_de_Documentos_CCApiConsumer.Delete(Detalle_de_Lista_de_Documentos_CCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Lista_de_Documentos_CCItem.Clave = 0;

                        var Detalle_de_Lista_de_Documentos_CCData = new Detalle_de_Lista_de_Documentos_CC
                        {
                            Cadena_y_Custodia = MasterId
                            ,Clave = Detalle_de_Lista_de_Documentos_CCItem.Clave
                            ,Fecha = (Detalle_de_Lista_de_Documentos_CCItem.Fecha!= null) ? DateTime.ParseExact(Detalle_de_Lista_de_Documentos_CCItem.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Nombre_del_Archivo = Detalle_de_Lista_de_Documentos_CCItem.Nombre_del_Archivo
                            ,Archivo = Detalle_de_Lista_de_Documentos_CCItem.Archivo

                        };

                        var resultId = Detalle_de_Lista_de_Documentos_CCItem.Clave > 0
                           ? _IDetalle_de_Lista_de_Documentos_CCApiConsumer.Update(Detalle_de_Lista_de_Documentos_CCData,null,null).Resource
                           : _IDetalle_de_Lista_de_Documentos_CCApiConsumer.Insert(Detalle_de_Lista_de_Documentos_CCData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }






        [NonAction]
        public bool CopyDetalle_de_Retroalimentacion(int MasterId, int referenceId, List<Detalle_de_RetroalimentacionGridModelPost> Detalle_de_RetroalimentacionItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_RetroalimentacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_RetroalimentacionData = _IDetalle_de_RetroalimentacionApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Retroalimentacion.Cadena_de_Custodia=" + referenceId,"").Resource;
                if (Detalle_de_RetroalimentacionData == null || Detalle_de_RetroalimentacionData.Detalle_de_Retroalimentacions.Count == 0)
                    return true;

                var result = true;

                Detalle_de_RetroalimentacionGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Retroalimentacion in Detalle_de_RetroalimentacionData.Detalle_de_Retroalimentacions)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Retroalimentacion Detalle_de_Retroalimentacion1 = varDetalle_de_Retroalimentacion;

                    if (Detalle_de_RetroalimentacionItems != null && Detalle_de_RetroalimentacionItems.Any(m => m.Clave == Detalle_de_Retroalimentacion1.Clave))
                    {
                        modelDataToChange = Detalle_de_RetroalimentacionItems.FirstOrDefault(m => m.Clave == Detalle_de_Retroalimentacion1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Retroalimentacion.Cadena_de_Custodia = MasterId;
                    var insertId = _IDetalle_de_RetroalimentacionApiConsumer.Insert(varDetalle_de_Retroalimentacion,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Retroalimentacion(List<Detalle_de_RetroalimentacionGridModelPost> Detalle_de_RetroalimentacionItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Retroalimentacion(MasterId, referenceId, Detalle_de_RetroalimentacionItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_RetroalimentacionItems != null && Detalle_de_RetroalimentacionItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_RetroalimentacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_RetroalimentacionItem in Detalle_de_RetroalimentacionItems)
                    {






                        //Removal Request
                        if (Detalle_de_RetroalimentacionItem.Removed)
                        {
                            result = result && _IDetalle_de_RetroalimentacionApiConsumer.Delete(Detalle_de_RetroalimentacionItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_RetroalimentacionItem.Clave = 0;

                        var Detalle_de_RetroalimentacionData = new Detalle_de_Retroalimentacion
                        {
                            Cadena_de_Custodia = MasterId
                            ,Clave = Detalle_de_RetroalimentacionItem.Clave
                            ,Usuario_que_Registra = Detalle_de_RetroalimentacionItem.Usuario_que_Registra
                            ,Fecha_de_Registro = (Detalle_de_RetroalimentacionItem.Fecha_de_Registro!= null) ? DateTime.ParseExact(Detalle_de_RetroalimentacionItem.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora_de_Registro = Detalle_de_RetroalimentacionItem.Hora_de_Registro
                            ,Retroalimentacion = Detalle_de_RetroalimentacionItem.Retroalimentacion

                        };

                        var resultId = Detalle_de_RetroalimentacionItem.Clave > 0
                           ? _IDetalle_de_RetroalimentacionApiConsumer.Update(Detalle_de_RetroalimentacionData,null,null).Resource
                           : _IDetalle_de_RetroalimentacionApiConsumer.Insert(Detalle_de_RetroalimentacionData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }







        [NonAction]
        public bool CopyDetalle_de_Referencia(int MasterId, int referenceId, List<Detalle_de_ReferenciaGridModelPost> Detalle_de_ReferenciaItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_ReferenciaApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_ReferenciaData = _IDetalle_de_ReferenciaApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Referencia.Cadena_de_Custodia=" + referenceId,"").Resource;
                if (Detalle_de_ReferenciaData == null || Detalle_de_ReferenciaData.Detalle_de_Referencias.Count == 0)
                    return true;

                var result = true;

                Detalle_de_ReferenciaGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Referencia in Detalle_de_ReferenciaData.Detalle_de_Referencias)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Referencia Detalle_de_Referencia1 = varDetalle_de_Referencia;

                    if (Detalle_de_ReferenciaItems != null && Detalle_de_ReferenciaItems.Any(m => m.Clave == Detalle_de_Referencia1.Clave))
                    {
                        modelDataToChange = Detalle_de_ReferenciaItems.FirstOrDefault(m => m.Clave == Detalle_de_Referencia1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Referencia.Cadena_de_Custodia = MasterId;
                    var insertId = _IDetalle_de_ReferenciaApiConsumer.Insert(varDetalle_de_Referencia,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Referencia(List<Detalle_de_ReferenciaGridModelPost> Detalle_de_ReferenciaItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Referencia(MasterId, referenceId, Detalle_de_ReferenciaItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_ReferenciaItems != null && Detalle_de_ReferenciaItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_ReferenciaApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_ReferenciaItem in Detalle_de_ReferenciaItems)
                    {





                        //Removal Request
                        if (Detalle_de_ReferenciaItem.Removed)
                        {
                            result = result && _IDetalle_de_ReferenciaApiConsumer.Delete(Detalle_de_ReferenciaItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_ReferenciaItem.Clave = 0;

                        var Detalle_de_ReferenciaData = new Detalle_de_Referencia
                        {
                            Cadena_de_Custodia = MasterId
                            ,Clave = Detalle_de_ReferenciaItem.Clave
                            ,Punto_de_Referencia = Detalle_de_ReferenciaItem.Punto_de_Referencia
                            ,Descripcion = Detalle_de_ReferenciaItem.Descripcion
                            ,Distancia = Detalle_de_ReferenciaItem.Distancia

                        };

                        var resultId = Detalle_de_ReferenciaItem.Clave > 0
                           ? _IDetalle_de_ReferenciaApiConsumer.Update(Detalle_de_ReferenciaData,null,null).Resource
                           : _IDetalle_de_ReferenciaApiConsumer.Insert(Detalle_de_ReferenciaData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }






        [NonAction]
        public bool CopyDetalle_de_Fotos_de_Emergencia_CC(int MasterId, int referenceId, List<Detalle_de_Fotos_de_Emergencia_CCGridModelPost> Detalle_de_Fotos_de_Emergencia_CCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Fotos_de_Emergencia_CCData = _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Fotos_de_Emergencia_CC.Cadena_de_Custodia=" + referenceId,"").Resource;
                if (Detalle_de_Fotos_de_Emergencia_CCData == null || Detalle_de_Fotos_de_Emergencia_CCData.Detalle_de_Fotos_de_Emergencia_CCs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Fotos_de_Emergencia_CCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Fotos_de_Emergencia_CC in Detalle_de_Fotos_de_Emergencia_CCData.Detalle_de_Fotos_de_Emergencia_CCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Fotos_de_Emergencia_CC Detalle_de_Fotos_de_Emergencia_CC1 = varDetalle_de_Fotos_de_Emergencia_CC;

                    if (Detalle_de_Fotos_de_Emergencia_CCItems != null && Detalle_de_Fotos_de_Emergencia_CCItems.Any(m => m.Clave == Detalle_de_Fotos_de_Emergencia_CC1.Clave))
                    {
                        modelDataToChange = Detalle_de_Fotos_de_Emergencia_CCItems.FirstOrDefault(m => m.Clave == Detalle_de_Fotos_de_Emergencia_CC1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Fotos_de_Emergencia_CC.Cadena_de_Custodia = MasterId;
                    var insertId = _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer.Insert(varDetalle_de_Fotos_de_Emergencia_CC,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Fotos_de_Emergencia_CC(List<Detalle_de_Fotos_de_Emergencia_CCGridModelPost> Detalle_de_Fotos_de_Emergencia_CCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Fotos_de_Emergencia_CC(MasterId, referenceId, Detalle_de_Fotos_de_Emergencia_CCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Fotos_de_Emergencia_CCItems != null && Detalle_de_Fotos_de_Emergencia_CCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Fotos_de_Emergencia_CCItem in Detalle_de_Fotos_de_Emergencia_CCItems)
                    {






                        //Removal Request
                        if (Detalle_de_Fotos_de_Emergencia_CCItem.Removed)
                        {
                            result = result && _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer.Delete(Detalle_de_Fotos_de_Emergencia_CCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Fotos_de_Emergencia_CCItem.Clave = 0;

                        var Detalle_de_Fotos_de_Emergencia_CCData = new Detalle_de_Fotos_de_Emergencia_CC
                        {
                            Cadena_de_Custodia = MasterId
                            ,Clave = Detalle_de_Fotos_de_Emergencia_CCItem.Clave
                            ,Fecha = (Detalle_de_Fotos_de_Emergencia_CCItem.Fecha!= null) ? DateTime.ParseExact(Detalle_de_Fotos_de_Emergencia_CCItem.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora = Detalle_de_Fotos_de_Emergencia_CCItem.Hora
                            ,Latitud = Detalle_de_Fotos_de_Emergencia_CCItem.Latitud
                            ,Longitud = Detalle_de_Fotos_de_Emergencia_CCItem.Longitud

                        };

                        var resultId = Detalle_de_Fotos_de_Emergencia_CCItem.Clave > 0
                           ? _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer.Update(Detalle_de_Fotos_de_Emergencia_CCData,null,null).Resource
                           : _IDetalle_de_Fotos_de_Emergencia_CCApiConsumer.Insert(Detalle_de_Fotos_de_Emergencia_CCData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }







        [NonAction]
        public bool CopyDetalle_de_Historial_de_Emergencia_CC(int MasterId, int referenceId, List<Detalle_de_Historial_de_Emergencia_CCGridModelPost> Detalle_de_Historial_de_Emergencia_CCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Historial_de_Emergencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Historial_de_Emergencia_CCData = _IDetalle_de_Historial_de_Emergencia_CCApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Historial_de_Emergencia_CC.Cadena_de_Custodia=" + referenceId,"").Resource;
                if (Detalle_de_Historial_de_Emergencia_CCData == null || Detalle_de_Historial_de_Emergencia_CCData.Detalle_de_Historial_de_Emergencia_CCs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Historial_de_Emergencia_CCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Historial_de_Emergencia_CC in Detalle_de_Historial_de_Emergencia_CCData.Detalle_de_Historial_de_Emergencia_CCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Historial_de_Emergencia_CC Detalle_de_Historial_de_Emergencia_CC1 = varDetalle_de_Historial_de_Emergencia_CC;

                    if (Detalle_de_Historial_de_Emergencia_CCItems != null && Detalle_de_Historial_de_Emergencia_CCItems.Any(m => m.Clave == Detalle_de_Historial_de_Emergencia_CC1.Clave))
                    {
                        modelDataToChange = Detalle_de_Historial_de_Emergencia_CCItems.FirstOrDefault(m => m.Clave == Detalle_de_Historial_de_Emergencia_CC1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Historial_de_Emergencia_CC.Cadena_de_Custodia = MasterId;
                    var insertId = _IDetalle_de_Historial_de_Emergencia_CCApiConsumer.Insert(varDetalle_de_Historial_de_Emergencia_CC,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Historial_de_Emergencia_CC(List<Detalle_de_Historial_de_Emergencia_CCGridModelPost> Detalle_de_Historial_de_Emergencia_CCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Historial_de_Emergencia_CC(MasterId, referenceId, Detalle_de_Historial_de_Emergencia_CCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Historial_de_Emergencia_CCItems != null && Detalle_de_Historial_de_Emergencia_CCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Historial_de_Emergencia_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Historial_de_Emergencia_CCItem in Detalle_de_Historial_de_Emergencia_CCItems)
                    {









                        //Removal Request
                        if (Detalle_de_Historial_de_Emergencia_CCItem.Removed)
                        {
                            result = result && _IDetalle_de_Historial_de_Emergencia_CCApiConsumer.Delete(Detalle_de_Historial_de_Emergencia_CCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Historial_de_Emergencia_CCItem.Clave = 0;

                        var Detalle_de_Historial_de_Emergencia_CCData = new Detalle_de_Historial_de_Emergencia_CC
                        {
                            Cadena_de_Custodia = MasterId
                            ,Clave = Detalle_de_Historial_de_Emergencia_CCItem.Clave
                            ,Fecha = (Detalle_de_Historial_de_Emergencia_CCItem.Fecha!= null) ? DateTime.ParseExact(Detalle_de_Historial_de_Emergencia_CCItem.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora = Detalle_de_Historial_de_Emergencia_CCItem.Hora
                            ,Latitud = Detalle_de_Historial_de_Emergencia_CCItem.Latitud
                            ,Longitud = Detalle_de_Historial_de_Emergencia_CCItem.Longitud
                            ,Estatus = Detalle_de_Historial_de_Emergencia_CCItem.Estatus
                            ,Comentarios = Detalle_de_Historial_de_Emergencia_CCItem.Comentarios
                            ,Usuario_que_registra = Detalle_de_Historial_de_Emergencia_CCItem.Usuario_que_registra

                        };

                        var resultId = Detalle_de_Historial_de_Emergencia_CCItem.Clave > 0
                           ? _IDetalle_de_Historial_de_Emergencia_CCApiConsumer.Update(Detalle_de_Historial_de_Emergencia_CCData,null,null).Resource
                           : _IDetalle_de_Historial_de_Emergencia_CCApiConsumer.Insert(Detalle_de_Historial_de_Emergencia_CCData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }










        [NonAction]
        public bool CopyDetalle_de_Datos_del_Imputado_CC(int MasterId, int referenceId, List<Detalle_de_Datos_del_Imputado_CCGridModelPost> Detalle_de_Datos_del_Imputado_CCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Datos_del_Imputado_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Datos_del_Imputado_CCData = _IDetalle_de_Datos_del_Imputado_CCApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Datos_del_Imputado_CC.Cadena_de_Custodia=" + referenceId,"").Resource;
                if (Detalle_de_Datos_del_Imputado_CCData == null || Detalle_de_Datos_del_Imputado_CCData.Detalle_de_Datos_del_Imputado_CCs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Datos_del_Imputado_CCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Datos_del_Imputado_CC in Detalle_de_Datos_del_Imputado_CCData.Detalle_de_Datos_del_Imputado_CCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Datos_del_Imputado_CC Detalle_de_Datos_del_Imputado_CC1 = varDetalle_de_Datos_del_Imputado_CC;

                    if (Detalle_de_Datos_del_Imputado_CCItems != null && Detalle_de_Datos_del_Imputado_CCItems.Any(m => m.Clave == Detalle_de_Datos_del_Imputado_CC1.Clave))
                    {
                        modelDataToChange = Detalle_de_Datos_del_Imputado_CCItems.FirstOrDefault(m => m.Clave == Detalle_de_Datos_del_Imputado_CC1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Datos_del_Imputado_CC.Cadena_de_Custodia = MasterId;
                    var insertId = _IDetalle_de_Datos_del_Imputado_CCApiConsumer.Insert(varDetalle_de_Datos_del_Imputado_CC,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Datos_del_Imputado_CC(List<Detalle_de_Datos_del_Imputado_CCGridModelPost> Detalle_de_Datos_del_Imputado_CCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Datos_del_Imputado_CC(MasterId, referenceId, Detalle_de_Datos_del_Imputado_CCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Datos_del_Imputado_CCItems != null && Detalle_de_Datos_del_Imputado_CCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Datos_del_Imputado_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Datos_del_Imputado_CCItem in Detalle_de_Datos_del_Imputado_CCItems)
                    {







































                        //Removal Request
                        if (Detalle_de_Datos_del_Imputado_CCItem.Removed)
                        {
                            result = result && _IDetalle_de_Datos_del_Imputado_CCApiConsumer.Delete(Detalle_de_Datos_del_Imputado_CCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Datos_del_Imputado_CCItem.Clave = 0;

                        var Detalle_de_Datos_del_Imputado_CCData = new Detalle_de_Datos_del_Imputado_CC
                        {
                            Cadena_de_Custodia = MasterId
                            ,Clave = Detalle_de_Datos_del_Imputado_CCItem.Clave
                            ,A_Quien_Resulte_Responsable = Detalle_de_Datos_del_Imputado_CCItem.A_Quien_Resulte_Responsable
                            ,Alias = Detalle_de_Datos_del_Imputado_CCItem.Alias
                            ,Apellido_Materno = Detalle_de_Datos_del_Imputado_CCItem.Apellido_Materno
                            ,Apellido_Paterno = Detalle_de_Datos_del_Imputado_CCItem.Apellido_Paterno
                            ,Calle = Detalle_de_Datos_del_Imputado_CCItem.Calle
                            ,Celular = Detalle_de_Datos_del_Imputado_CCItem.Celular
                            ,Codigo_Postal = Detalle_de_Datos_del_Imputado_CCItem.Codigo_Postal
                            ,Colonia = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Colonia) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Colonia))
                            ,Correo_Electronico = Detalle_de_Datos_del_Imputado_CCItem.Correo_Electronico
                            ,Edad = Detalle_de_Datos_del_Imputado_CCItem.Edad
                            ,Entre_calle = Detalle_de_Datos_del_Imputado_CCItem.Entre_calle
                            ,Escolaridad = Detalle_de_Datos_del_Imputado_CCItem.Escolaridad
                            ,Estado = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Estado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Estado))
                            ,Estado_Civil = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Estado_Civil) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Estado_Civil))
                            ,Estension = Detalle_de_Datos_del_Imputado_CCItem.Estension
                            ,Fecha_de_Nacimiento = (Detalle_de_Datos_del_Imputado_CCItem.Fecha_de_Nacimiento!= null) ? DateTime.ParseExact(Detalle_de_Datos_del_Imputado_CCItem.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null

                            ,Inimputable = Detalle_de_Datos_del_Imputado_CCItem.Inimputable
                            ,Tipo_de_Inimputabilidad = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Tipo_de_Inimputabilidad) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Tipo_de_Inimputabilidad))
                            ,Especifique = Detalle_de_Datos_del_Imputado_CCItem.Especifique
                            ,Municipio = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Municipio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Municipio))
                            ,Nacionalidad = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Nacionalidad) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Nacionalidad))
                            ,Nombre = Detalle_de_Datos_del_Imputado_CCItem.Nombre
                            ,Nombre_Completo = Detalle_de_Datos_del_Imputado_CCItem.Nombre_Completo
                            ,Numero_de_Identificacion = Detalle_de_Datos_del_Imputado_CCItem.Numero_de_Identificacion
                            ,Numero_Exterior = Detalle_de_Datos_del_Imputado_CCItem.Numero_Exterior
                            ,Numero_Interior = Detalle_de_Datos_del_Imputado_CCItem.Numero_Interior
                            ,Ocupacion = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Ocupacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Ocupacion))
                            ,Originario_de = Detalle_de_Datos_del_Imputado_CCItem.Originario_de
                            ,Pais = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Pais) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Pais))
                            ,Pais_de_Origen = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Pais_de_Origen) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Pais_de_Origen))
                            ,Proteccion_de_datos = Detalle_de_Datos_del_Imputado_CCItem.Proteccion_de_datos
                            ,Referencia_de_domicilio = Detalle_de_Datos_del_Imputado_CCItem.Referencia_de_domicilio
                            ,Genero = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Genero) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Genero))
                            ,Telefono = Detalle_de_Datos_del_Imputado_CCItem.Telefono
                            ,Tipo_de_Identificacion = (Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Tipo_de_Identificacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Imputado_CCItem.Tipo_de_Identificacion))
                            ,Y_calle = Detalle_de_Datos_del_Imputado_CCItem.Y_calle

                        };

                        var resultId = Detalle_de_Datos_del_Imputado_CCItem.Clave > 0
                           ? _IDetalle_de_Datos_del_Imputado_CCApiConsumer.Update(Detalle_de_Datos_del_Imputado_CCData,null,null).Resource
                           : _IDetalle_de_Datos_del_Imputado_CCApiConsumer.Insert(Detalle_de_Datos_del_Imputado_CCData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }









        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_CC_ColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }




        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_CC_EstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_CC_Estado_CivilAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstado_CivilApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado_Civil", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }




        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_CC_Tipo_de_InimputabilidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_InimputabilidadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Inimputabilidad", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_CC_MunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_CC_NacionalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _INacionalidadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Nacionalidad", "NacionalidadC");
                  item.NacionalidadC= trans??item.NacionalidadC;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_CC_OcupacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOcupacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Ocupacion", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_CC_PaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
       

        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_CC_GeneroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGeneroApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Genero", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Imputado_CC_Tipo_de_IdentificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_IdentificacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Identificacion", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [NonAction]
        public bool CopyDetalle_de_Datos_del_Testigo_CC(int MasterId, int referenceId, List<Detalle_de_Datos_del_Testigo_CCGridModelPost> Detalle_de_Datos_del_Testigo_CCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Datos_del_Testigo_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Datos_del_Testigo_CCData = _IDetalle_de_Datos_del_Testigo_CCApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Datos_del_Testigo_CC.Cadena_de_Custodia=" + referenceId,"").Resource;
                if (Detalle_de_Datos_del_Testigo_CCData == null || Detalle_de_Datos_del_Testigo_CCData.Detalle_de_Datos_del_Testigo_CCs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Datos_del_Testigo_CCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Datos_del_Testigo_CC in Detalle_de_Datos_del_Testigo_CCData.Detalle_de_Datos_del_Testigo_CCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Datos_del_Testigo_CC Detalle_de_Datos_del_Testigo_CC1 = varDetalle_de_Datos_del_Testigo_CC;

                    if (Detalle_de_Datos_del_Testigo_CCItems != null && Detalle_de_Datos_del_Testigo_CCItems.Any(m => m.Clave == Detalle_de_Datos_del_Testigo_CC1.Clave))
                    {
                        modelDataToChange = Detalle_de_Datos_del_Testigo_CCItems.FirstOrDefault(m => m.Clave == Detalle_de_Datos_del_Testigo_CC1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Datos_del_Testigo_CC.Cadena_de_Custodia = MasterId;
                    var insertId = _IDetalle_de_Datos_del_Testigo_CCApiConsumer.Insert(varDetalle_de_Datos_del_Testigo_CC,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Datos_del_Testigo_CC(List<Detalle_de_Datos_del_Testigo_CCGridModelPost> Detalle_de_Datos_del_Testigo_CCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Datos_del_Testigo_CC(MasterId, referenceId, Detalle_de_Datos_del_Testigo_CCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Datos_del_Testigo_CCItems != null && Detalle_de_Datos_del_Testigo_CCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Datos_del_Testigo_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Datos_del_Testigo_CCItem in Detalle_de_Datos_del_Testigo_CCItems)
                    {




































                        //Removal Request
                        if (Detalle_de_Datos_del_Testigo_CCItem.Removed)
                        {
                            result = result && _IDetalle_de_Datos_del_Testigo_CCApiConsumer.Delete(Detalle_de_Datos_del_Testigo_CCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Datos_del_Testigo_CCItem.Clave = 0;

                        var Detalle_de_Datos_del_Testigo_CCData = new Detalle_de_Datos_del_Testigo_CC
                        {
                            Cadena_de_Custodia = MasterId
                            ,Clave = Detalle_de_Datos_del_Testigo_CCItem.Clave
                            ,Apellido_Materno = Detalle_de_Datos_del_Testigo_CCItem.Apellido_Materno
                            ,Apellido_Paterno = Detalle_de_Datos_del_Testigo_CCItem.Apellido_Paterno
                            ,Calle = Detalle_de_Datos_del_Testigo_CCItem.Calle
                            ,Celular = Detalle_de_Datos_del_Testigo_CCItem.Celular
                            ,Codigo_Postal = Detalle_de_Datos_del_Testigo_CCItem.Codigo_Postal
                            ,Colonia = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Colonia) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Colonia))
                            ,Correo_Electronico = Detalle_de_Datos_del_Testigo_CCItem.Correo_Electronico
                            ,Edad = Detalle_de_Datos_del_Testigo_CCItem.Edad
                            ,Escolaridad = (Convert.ToInt16(Detalle_de_Datos_del_Testigo_CCItem.Escolaridad) == 0 ? (Int16?)null : Convert.ToInt16(Detalle_de_Datos_del_Testigo_CCItem.Escolaridad))
                            ,Estado = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Estado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Estado))
                            ,Estado_Civil = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Estado_Civil) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Estado_Civil))
                            ,Extension = Detalle_de_Datos_del_Testigo_CCItem.Extension
                            ,Fecha_de_nacimiento = (Detalle_de_Datos_del_Testigo_CCItem.Fecha_de_nacimiento!= null) ? DateTime.ParseExact(Detalle_de_Datos_del_Testigo_CCItem.Fecha_de_nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Inimputable = Detalle_de_Datos_del_Testigo_CCItem.Inimputable
                            ,Municipio = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Municipio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Municipio))
                            ,Nacionalidad = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Nacionalidad) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Nacionalidad))
                            ,Nombre = Detalle_de_Datos_del_Testigo_CCItem.Nombre
                            ,Nombre_Completo = Detalle_de_Datos_del_Testigo_CCItem.Nombre_Completo
                            ,Numero_de_identificacion = Detalle_de_Datos_del_Testigo_CCItem.Numero_de_identificacion
                            ,Numero_Exterior = Detalle_de_Datos_del_Testigo_CCItem.Numero_Exterior
                            ,Numero_Interior = Detalle_de_Datos_del_Testigo_CCItem.Numero_Interior
                            ,Ocupacion = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Ocupacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Ocupacion))
                            ,Pais = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Pais) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Pais))
                            ,Proteccion_de_Datos = Detalle_de_Datos_del_Testigo_CCItem.Proteccion_de_Datos
                            ,Genero = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Genero) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Genero))
                            ,Telefono = Detalle_de_Datos_del_Testigo_CCItem.Telefono
                            ,Tipo_de_compareciente = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Tipo_de_compareciente) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Tipo_de_compareciente))
                            ,Tipo_de_identificacion = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Tipo_de_identificacion) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Tipo_de_identificacion))
                            ,Tipo_de_inimputabilidad = (Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Tipo_de_inimputabilidad) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Datos_del_Testigo_CCItem.Tipo_de_inimputabilidad))
                            ,Entre_Calle = Detalle_de_Datos_del_Testigo_CCItem.Entre_Calle
                            ,Y_Calle = Detalle_de_Datos_del_Testigo_CCItem.Y_Calle
                            ,Referencia_del_Domicilio = Detalle_de_Datos_del_Testigo_CCItem.Referencia_del_Domicilio
                            ,Especifique = Detalle_de_Datos_del_Testigo_CCItem.Especifique


                        };

                        var resultId = Detalle_de_Datos_del_Testigo_CCItem.Clave > 0
                           ? _IDetalle_de_Datos_del_Testigo_CCApiConsumer.Update(Detalle_de_Datos_del_Testigo_CCData,null,null).Resource
                           : _IDetalle_de_Datos_del_Testigo_CCApiConsumer.Insert(Detalle_de_Datos_del_Testigo_CCData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }







        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_CC_ColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_CC_EscolaridadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEscolaridadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Escolaridad", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_CC_EstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_CC_Estado_CivilAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstado_CivilApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado_Civil", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_CC_MunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_CC_NacionalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _INacionalidadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Nacionalidad", "NacionalidadC");
                  item.NacionalidadC= trans??item.NacionalidadC;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_CC_OcupacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOcupacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Ocupacion", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_CC_PaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_CC_GeneroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGeneroApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Genero", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_CC_Tipo_de_ComparecienteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ComparecienteApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Compareciente", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_CC_Tipo_de_IdentificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_IdentificacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Identificacion", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Datos_del_Testigo_CC_Tipo_de_InimputabilidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_InimputabilidadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Inimputabilidad", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }






        [NonAction]
        public bool CopyCatalogo_Tipo_de_Embalaje_CC(int MasterId, int referenceId, List<Catalogo_Tipo_de_Embalaje_CCGridModelPost> Catalogo_Tipo_de_Embalaje_CCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _ICatalogo_Tipo_de_Embalaje_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Catalogo_Tipo_de_Embalaje_CCData = _ICatalogo_Tipo_de_Embalaje_CCApiConsumer.ListaSelAll(1, int.MaxValue, "Catalogo_Tipo_de_Embalaje_CC.Cadena_de_Custodia=" + referenceId,"").Resource;
                if (Catalogo_Tipo_de_Embalaje_CCData == null || Catalogo_Tipo_de_Embalaje_CCData.Catalogo_Tipo_de_Embalaje_CCs.Count == 0)
                    return true;

                var result = true;

                Catalogo_Tipo_de_Embalaje_CCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varCatalogo_Tipo_de_Embalaje_CC in Catalogo_Tipo_de_Embalaje_CCData.Catalogo_Tipo_de_Embalaje_CCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Catalogo_Tipo_de_Embalaje_CC Catalogo_Tipo_de_Embalaje_CC1 = varCatalogo_Tipo_de_Embalaje_CC;

                    if (Catalogo_Tipo_de_Embalaje_CCItems != null && Catalogo_Tipo_de_Embalaje_CCItems.Any(m => m.Clave == Catalogo_Tipo_de_Embalaje_CC1.Clave))
                    {
                        modelDataToChange = Catalogo_Tipo_de_Embalaje_CCItems.FirstOrDefault(m => m.Clave == Catalogo_Tipo_de_Embalaje_CC1.Clave);
                    }
                    //Chaning Id Value
                    varCatalogo_Tipo_de_Embalaje_CC.Cadena_de_Custodia = MasterId;
                    var insertId = _ICatalogo_Tipo_de_Embalaje_CCApiConsumer.Insert(varCatalogo_Tipo_de_Embalaje_CC,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostCatalogo_Tipo_de_Embalaje_CC(List<Catalogo_Tipo_de_Embalaje_CCGridModelPost> Catalogo_Tipo_de_Embalaje_CCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyCatalogo_Tipo_de_Embalaje_CC(MasterId, referenceId, Catalogo_Tipo_de_Embalaje_CCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Catalogo_Tipo_de_Embalaje_CCItems != null && Catalogo_Tipo_de_Embalaje_CCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _ICatalogo_Tipo_de_Embalaje_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Catalogo_Tipo_de_Embalaje_CCItem in Catalogo_Tipo_de_Embalaje_CCItems)
                    {



                        //Removal Request
                        if (Catalogo_Tipo_de_Embalaje_CCItem.Removed)
                        {
                            result = result && _ICatalogo_Tipo_de_Embalaje_CCApiConsumer.Delete(Catalogo_Tipo_de_Embalaje_CCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Catalogo_Tipo_de_Embalaje_CCItem.Clave = 0;

                        var Catalogo_Tipo_de_Embalaje_CCData = new Catalogo_Tipo_de_Embalaje_CC
                        {
                            Cadena_de_Custodia = MasterId
                            ,Clave = Catalogo_Tipo_de_Embalaje_CCItem.Clave
                            ,Descripcion = Catalogo_Tipo_de_Embalaje_CCItem.Descripcion

                        };

                        var resultId = Catalogo_Tipo_de_Embalaje_CCItem.Clave > 0
                           ? _ICatalogo_Tipo_de_Embalaje_CCApiConsumer.Update(Catalogo_Tipo_de_Embalaje_CCData,null,null).Resource
                           : _ICatalogo_Tipo_de_Embalaje_CCApiConsumer.Insert(Catalogo_Tipo_de_Embalaje_CCData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }




        [NonAction]
        public bool CopyDetalle_de_Lista_de_Asignaciones(int MasterId, int referenceId, List<Detalle_de_Lista_de_AsignacionesGridModelPost> Detalle_de_Lista_de_AsignacionesItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Lista_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Lista_de_AsignacionesData = _IDetalle_de_Lista_de_AsignacionesApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Lista_de_Asignaciones.Cadena_de_Custodia=" + referenceId,"").Resource;
                if (Detalle_de_Lista_de_AsignacionesData == null || Detalle_de_Lista_de_AsignacionesData.Detalle_de_Lista_de_Asignacioness.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Lista_de_AsignacionesGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Lista_de_Asignaciones in Detalle_de_Lista_de_AsignacionesData.Detalle_de_Lista_de_Asignacioness)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Lista_de_Asignaciones Detalle_de_Lista_de_Asignaciones1 = varDetalle_de_Lista_de_Asignaciones;

                    if (Detalle_de_Lista_de_AsignacionesItems != null && Detalle_de_Lista_de_AsignacionesItems.Any(m => m.Clave == Detalle_de_Lista_de_Asignaciones1.Clave))
                    {
                        modelDataToChange = Detalle_de_Lista_de_AsignacionesItems.FirstOrDefault(m => m.Clave == Detalle_de_Lista_de_Asignaciones1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Lista_de_Asignaciones.Cadena_de_Custodia = MasterId;
                    var insertId = _IDetalle_de_Lista_de_AsignacionesApiConsumer.Insert(varDetalle_de_Lista_de_Asignaciones,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Lista_de_Asignaciones(List<Detalle_de_Lista_de_AsignacionesGridModelPost> Detalle_de_Lista_de_AsignacionesItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Lista_de_Asignaciones(MasterId, referenceId, Detalle_de_Lista_de_AsignacionesItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Lista_de_AsignacionesItems != null && Detalle_de_Lista_de_AsignacionesItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Lista_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Lista_de_AsignacionesItem in Detalle_de_Lista_de_AsignacionesItems)
                    {






                        //Removal Request
                        if (Detalle_de_Lista_de_AsignacionesItem.Removed)
                        {
                            result = result && _IDetalle_de_Lista_de_AsignacionesApiConsumer.Delete(Detalle_de_Lista_de_AsignacionesItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Lista_de_AsignacionesItem.Clave = 0;

                        var Detalle_de_Lista_de_AsignacionesData = new Detalle_de_Lista_de_Asignaciones
                        {
                            Cadena_de_Custodia = MasterId
                            ,Clave = Detalle_de_Lista_de_AsignacionesItem.Clave
                            ,Numero_de_Asignacion = Detalle_de_Lista_de_AsignacionesItem.Numero_de_Asignacion
                            ,Nombre = Detalle_de_Lista_de_AsignacionesItem.Nombre
                            ,Realizado = Detalle_de_Lista_de_AsignacionesItem.Realizado
                            ,Especifique = Detalle_de_Lista_de_AsignacionesItem.Especifique

                        };

                        var resultId = Detalle_de_Lista_de_AsignacionesItem.Clave > 0
                           ? _IDetalle_de_Lista_de_AsignacionesApiConsumer.Update(Detalle_de_Lista_de_AsignacionesData,null,null).Resource
                           : _IDetalle_de_Lista_de_AsignacionesApiConsumer.Insert(Detalle_de_Lista_de_AsignacionesData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }







        [NonAction]
        public bool CopyCatalogo_Tipo_de_Fijacion_CC(int MasterId, int referenceId, List<Catalogo_Tipo_de_Fijacion_CCGridModelPost> Catalogo_Tipo_de_Fijacion_CCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Catalogo_Tipo_de_Fijacion_CCData = _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.ListaSelAll(1, int.MaxValue, "Catalogo_Tipo_de_Fijacion_CC.Cadena_y_Custodia=" + referenceId,"").Resource;
                if (Catalogo_Tipo_de_Fijacion_CCData == null || Catalogo_Tipo_de_Fijacion_CCData.Catalogo_Tipo_de_Fijacion_CCs.Count == 0)
                    return true;

                var result = true;

                Catalogo_Tipo_de_Fijacion_CCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varCatalogo_Tipo_de_Fijacion_CC in Catalogo_Tipo_de_Fijacion_CCData.Catalogo_Tipo_de_Fijacion_CCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Catalogo_Tipo_de_Fijacion_CC Catalogo_Tipo_de_Fijacion_CC1 = varCatalogo_Tipo_de_Fijacion_CC;

                    if (Catalogo_Tipo_de_Fijacion_CCItems != null && Catalogo_Tipo_de_Fijacion_CCItems.Any(m => m.Clave == Catalogo_Tipo_de_Fijacion_CC1.Clave))
                    {
                        modelDataToChange = Catalogo_Tipo_de_Fijacion_CCItems.FirstOrDefault(m => m.Clave == Catalogo_Tipo_de_Fijacion_CC1.Clave);
                    }
                    //Chaning Id Value
                    varCatalogo_Tipo_de_Fijacion_CC.Cadena_y_Custodia = MasterId;
                    var insertId = _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.Insert(varCatalogo_Tipo_de_Fijacion_CC,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostCatalogo_Tipo_de_Fijacion_CC(List<Catalogo_Tipo_de_Fijacion_CCGridModelPost> Catalogo_Tipo_de_Fijacion_CCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyCatalogo_Tipo_de_Fijacion_CC(MasterId, referenceId, Catalogo_Tipo_de_Fijacion_CCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Catalogo_Tipo_de_Fijacion_CCItems != null && Catalogo_Tipo_de_Fijacion_CCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Catalogo_Tipo_de_Fijacion_CCItem in Catalogo_Tipo_de_Fijacion_CCItems)
                    {



                        //Removal Request
                        if (Catalogo_Tipo_de_Fijacion_CCItem.Removed)
                        {
                            result = result && _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.Delete(Catalogo_Tipo_de_Fijacion_CCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Catalogo_Tipo_de_Fijacion_CCItem.Clave = 0;

                        var Catalogo_Tipo_de_Fijacion_CCData = new Catalogo_Tipo_de_Fijacion_CC
                        {
                            Cadena_y_Custodia = MasterId
                            ,Clave = Catalogo_Tipo_de_Fijacion_CCItem.Clave
                            ,Descripcion = Catalogo_Tipo_de_Fijacion_CCItem.Descripcion

                        };

                        var resultId = Catalogo_Tipo_de_Fijacion_CCItem.Clave > 0
                           ? _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.Update(Catalogo_Tipo_de_Fijacion_CCData,null,null).Resource
                           : _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.Insert(Catalogo_Tipo_de_Fijacion_CCData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }




        [NonAction]
        public bool CopyDetalle_de_Traslado_de_CC(int MasterId, int referenceId, List<Detalle_de_Traslado_de_CCGridModelPost> Detalle_de_Traslado_de_CCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Traslado_de_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Traslado_de_CCData = _IDetalle_de_Traslado_de_CCApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Traslado_de_CC.Cadena_de_Custodia=" + referenceId,"").Resource;
                if (Detalle_de_Traslado_de_CCData == null || Detalle_de_Traslado_de_CCData.Detalle_de_Traslado_de_CCs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Traslado_de_CCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Traslado_de_CC in Detalle_de_Traslado_de_CCData.Detalle_de_Traslado_de_CCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Traslado_de_CC Detalle_de_Traslado_de_CC1 = varDetalle_de_Traslado_de_CC;

                    if (Detalle_de_Traslado_de_CCItems != null && Detalle_de_Traslado_de_CCItems.Any(m => m.Clave == Detalle_de_Traslado_de_CC1.Clave))
                    {
                        modelDataToChange = Detalle_de_Traslado_de_CCItems.FirstOrDefault(m => m.Clave == Detalle_de_Traslado_de_CC1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Traslado_de_CC.Cadena_de_Custodia = MasterId;
                    var insertId = _IDetalle_de_Traslado_de_CCApiConsumer.Insert(varDetalle_de_Traslado_de_CC,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Traslado_de_CC(List<Detalle_de_Traslado_de_CCGridModelPost> Detalle_de_Traslado_de_CCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Traslado_de_CC(MasterId, referenceId, Detalle_de_Traslado_de_CCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Traslado_de_CCItems != null && Detalle_de_Traslado_de_CCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Traslado_de_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Traslado_de_CCItem in Detalle_de_Traslado_de_CCItems)
                    {









                        //Removal Request
                        if (Detalle_de_Traslado_de_CCItem.Removed)
                        {
                            result = result && _IDetalle_de_Traslado_de_CCApiConsumer.Delete(Detalle_de_Traslado_de_CCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Traslado_de_CCItem.Clave = 0;

                        var Detalle_de_Traslado_de_CCData = new Detalle_de_Traslado_de_CC
                        {
                            Cadena_de_Custodia = MasterId
                            ,Clave = Detalle_de_Traslado_de_CCItem.Clave
                            ,Fecha = (Detalle_de_Traslado_de_CCItem.Fecha!= null) ? DateTime.ParseExact(Detalle_de_Traslado_de_CCItem.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora = Detalle_de_Traslado_de_CCItem.Hora
                            ,Temperatura = Detalle_de_Traslado_de_CCItem.Temperatura
                            ,Humedad = Detalle_de_Traslado_de_CCItem.Humedad
                            ,Latitud = Detalle_de_Traslado_de_CCItem.Latitud
                            ,Longitud = Detalle_de_Traslado_de_CCItem.Longitud
                            ,Estatus = (Convert.ToInt32(Detalle_de_Traslado_de_CCItem.Estatus) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Traslado_de_CCItem.Estatus))

                        };

                        var resultId = Detalle_de_Traslado_de_CCItem.Clave > 0
                           ? _IDetalle_de_Traslado_de_CCApiConsumer.Update(Detalle_de_Traslado_de_CCData,null,null).Resource
                           : _IDetalle_de_Traslado_de_CCApiConsumer.Insert(Detalle_de_Traslado_de_CCData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }








        [HttpGet]
        public ActionResult GetDetalle_de_Traslado_de_CC_Catalogo_de_Estatus_de_TrasladoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_de_Estatus_de_TrasladoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_de_Estatus_de_TrasladoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Catalogo_de_Estatus_de_Traslado", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [NonAction]
        public bool CopyCatalogo_Tipo_de_Indicio_CC(int MasterId, int referenceId, List<Catalogo_Tipo_de_Indicio_CCGridModelPost> Catalogo_Tipo_de_Indicio_CCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _ICatalogo_Tipo_de_Indicio_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Catalogo_Tipo_de_Indicio_CCData = _ICatalogo_Tipo_de_Indicio_CCApiConsumer.ListaSelAll(1, int.MaxValue, "Catalogo_Tipo_de_Indicio_CC.Tipo_de_Indicio=" + referenceId,"").Resource;
                if (Catalogo_Tipo_de_Indicio_CCData == null || Catalogo_Tipo_de_Indicio_CCData.Catalogo_Tipo_de_Indicio_CCs.Count == 0)
                    return true;

                var result = true;

                Catalogo_Tipo_de_Indicio_CCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varCatalogo_Tipo_de_Indicio_CC in Catalogo_Tipo_de_Indicio_CCData.Catalogo_Tipo_de_Indicio_CCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Catalogo_Tipo_de_Indicio_CC Catalogo_Tipo_de_Indicio_CC1 = varCatalogo_Tipo_de_Indicio_CC;

                    if (Catalogo_Tipo_de_Indicio_CCItems != null && Catalogo_Tipo_de_Indicio_CCItems.Any(m => m.Clave == Catalogo_Tipo_de_Indicio_CC1.Clave))
                    {
                        modelDataToChange = Catalogo_Tipo_de_Indicio_CCItems.FirstOrDefault(m => m.Clave == Catalogo_Tipo_de_Indicio_CC1.Clave);
                    }
                    //Chaning Id Value
                    varCatalogo_Tipo_de_Indicio_CC.Tipo_de_Indicio = MasterId;
                    var insertId = _ICatalogo_Tipo_de_Indicio_CCApiConsumer.Insert(varCatalogo_Tipo_de_Indicio_CC,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostCatalogo_Tipo_de_Indicio_CC(List<Catalogo_Tipo_de_Indicio_CCGridModelPost> Catalogo_Tipo_de_Indicio_CCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyCatalogo_Tipo_de_Indicio_CC(MasterId, referenceId, Catalogo_Tipo_de_Indicio_CCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Catalogo_Tipo_de_Indicio_CCItems != null && Catalogo_Tipo_de_Indicio_CCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _ICatalogo_Tipo_de_Indicio_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Catalogo_Tipo_de_Indicio_CCItem in Catalogo_Tipo_de_Indicio_CCItems)
                    {



                        //Removal Request
                        if (Catalogo_Tipo_de_Indicio_CCItem.Removed)
                        {
                            result = result && _ICatalogo_Tipo_de_Indicio_CCApiConsumer.Delete(Catalogo_Tipo_de_Indicio_CCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Catalogo_Tipo_de_Indicio_CCItem.Clave = 0;

                        var Catalogo_Tipo_de_Indicio_CCData = new Catalogo_Tipo_de_Indicio_CC
                        {
                            Tipo_de_Indicio = MasterId
                            ,Clave = Catalogo_Tipo_de_Indicio_CCItem.Clave
                            ,Descripcion = Catalogo_Tipo_de_Indicio_CCItem.Descripcion

                        };

                        var resultId = Catalogo_Tipo_de_Indicio_CCItem.Clave > 0
                           ? _ICatalogo_Tipo_de_Indicio_CCApiConsumer.Update(Catalogo_Tipo_de_Indicio_CCData,null,null).Resource
                           : _ICatalogo_Tipo_de_Indicio_CCApiConsumer.Insert(Catalogo_Tipo_de_Indicio_CCData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }






        /// <summary>
        /// Write Element Array of Cadena_de_Custodia script
        /// </summary>
        /// <param name="oCadena_de_CustodiaElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Cadena_de_CustodiaModuleAttributeList)
        {
            for (int i = 0; i < Cadena_de_CustodiaModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Cadena_de_CustodiaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Cadena_de_CustodiaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Cadena_de_CustodiaModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Cadena_de_CustodiaModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Cadena_de_CustodiaModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Cadena_de_CustodiaModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Cadena_de_CustodiaModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Cadena_de_CustodiaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Cadena_de_CustodiaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Cadena_de_CustodiaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Cadena_de_CustodiaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strCadena_de_CustodiaScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Cadena_de_Custodia.js")))
            {
                strCadena_de_CustodiaScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Cadena_de_Custodia element attributes
            string userChangeJson = jsSerialize.Serialize(Cadena_de_CustodiaModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strCadena_de_CustodiaScript.IndexOf("inpuElementArray");
            string splittedString = strCadena_de_CustodiaScript.Substring(indexOfArray, strCadena_de_CustodiaScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Cadena_de_CustodiaModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Cadena_de_CustodiaModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strCadena_de_CustodiaScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strCadena_de_CustodiaScript.Substring(indexOfArrayHistory, strCadena_de_CustodiaScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strCadena_de_CustodiaScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strCadena_de_CustodiaScript.Substring(endIndexOfMainElement + indexOfArray, strCadena_de_CustodiaScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Cadena_de_CustodiaModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Cadena_de_CustodiaModuleAttributeList.ChildModuleAttributeList)
                {
				if (item!= null && item.elements != null  && item.elements.Count>0)
                    ResponseChild += "\r\n  \n\r function set" + item.table + "Validation() { " +
                                    " \r\n var inpuElementChildArray =" + jsSerialize.Serialize(item.elements) + ";" +
                                    "  \r\n setInputEntityAttributes(inpuElementChildArray, \".\", 0);" +
                                    "  \r\n setDynamicRenderElement(); \n\r } ";

                }
            }
            finalResponse = finalResponse.Substring(0, finalResponse.IndexOf("});") + 4) +  "\n\r";
            finalResponse += ResponseChild;
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Cadena_de_Custodia.js")))
            {
                w.WriteLine(finalResponse);
            }
            
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        

        [HttpPost]
        public JsonResult ReadScriptSettings()
        {
            string strCustomScript = string.Empty;
            
            CustomElementAttribute oCustomElementAttribute = new CustomElementAttribute();

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Cadena_de_Custodia.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Cadena_de_Custodia.js")))
                {
                    strCustomScript = r.ReadToEnd();
                
                }

                int indexOfArray = strCustomScript.IndexOf("inpuElementArray");
                string splittedString = strCustomScript.Substring(indexOfArray, strCustomScript.Length - indexOfArray);                
                int indexOfMainElement = splittedString.IndexOf('[');                
                int endIndexOfMainElement = splittedString.IndexOf(']') + 1;                
                string mainJsonArray = splittedString.Substring(indexOfMainElement, endIndexOfMainElement - indexOfMainElement);

                int indexOfChildArray = strCustomScript.IndexOf("function set");
                string childJsonArray = "[";
                if (indexOfChildArray != -1)
                {
                    string splittedChildString = strCustomScript.Substring(indexOfChildArray, strCustomScript.Length - indexOfChildArray);

                    var funcionsValidations = splittedChildString.Split(new string[] { "function" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var str in funcionsValidations)
                    {
                        var tabla = str.Substring(0, str.IndexOf('('));
                        tabla = tabla.Trim().Replace("set", string.Empty).Replace("Validation", string.Empty);
                        childJsonArray += "{ \"table\": \"" + tabla + "\", \"elements\":";
                        int indexOfChildElement = str.IndexOf('[');
                        int endIndexOfChildElement = str.IndexOf(']') + 1;
                        childJsonArray += str.Substring(indexOfChildElement, endIndexOfChildElement - indexOfChildElement) + "},";
                    }
                }
                childJsonArray = childJsonArray.TrimEnd(',') + "]";
                var MainElementList = JsonConvert.DeserializeObject(mainJsonArray);
                var ChildElementList = JsonConvert.DeserializeObject(childJsonArray);

                oCustomElementAttribute.MainElement = MainElementList.ToString();

                if (indexOfChildArray != -1)
                {
                    oCustomElementAttribute.ChildElement = ChildElementList.ToString();
                }
            }
            else
            {
                oCustomElementAttribute.MainElement = string.Empty;
                oCustomElementAttribute.ChildElement = string.Empty;
            }        
            return Json(oCustomElementAttribute, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Cadena_de_CustodiaPropertyBag()
        {
            return PartialView("Cadena_de_CustodiaPropertyBag", "Cadena_de_Custodia");
        }
		
		public List<Spartan_Business_Rule> GetBusinessRules(int ObjectId, int Attribute)
        {
            if (!_tokenManager.GenerateToken())
                return null;
            List<Spartan_Business_Rule> result = new List<Spartan_Business_Rule>();
            _ISpartan_Business_RuleApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (Attribute != 0)
            {
                result = _ISpartan_Business_RuleApiConsumer.ListaSelAll(0, 1000, "Object = " + ObjectId + " AND Attribute = " + Attribute, "").Resource.Spartan_Business_Rules;
            }
            else
            {
                List<Spartan_Business_Rule> partialResult = _ISpartan_Business_RuleApiConsumer.ListaSelAll(0, 1000, "Object = " + ObjectId, "").Resource.Spartan_Business_Rules;
                foreach (var item in partialResult)
                {
                    if (item.Attribute == Attribute)
                    {
                        result.Add(item);
                    }
                    else//Busco las reglas con el event process en cuestion
                    {
                        _ISpartan_BR_Process_Event_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);
                        var eventProcess = _ISpartan_BR_Process_Event_DetailApiConsumer.ListaSelAll(0, 1000, "Business_Rule = " + item.BusinessRuleId, "").Resource;
                        if (Attribute == 0 && eventProcess.Spartan_BR_Process_Event_Details.Where(x => x.Process_Event == 1).Count() > 0)
                        {
                            result.Add(item);
                        }
                        if ((Attribute == 2) && eventProcess.Spartan_BR_Process_Event_Details.Where(x => x.Process_Event == 2 || x.Process_Event == 3).Count() > 0)
                        {
                            result.Add(item);
                        }
                        if ((Attribute == 3) && eventProcess.Spartan_BR_Process_Event_Details.Where(x => x.Process_Event == 4 || x.Process_Event == 5).Count() > 0)
                        {
                            result.Add(item);
                        }
                        //TODO Faltan en la base de datos cuando creas una row de grilla
                    }
                }
            }
            return result;
        }

        [HttpGet]
        public ActionResult AddDetalle_del_Certificado_CC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_del_Certificado_CC/AddDetalle_del_Certificado_CC");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Fotos_CC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Fotos_CC/AddDetalle_de_Fotos_CC");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Videos_CC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Videos_CC/AddDetalle_de_Videos_CC");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Registro_de_Intervinientes_CC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Registro_de_Intervinientes_CC/AddDetalle_de_Registro_de_Intervinientes_CC");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Descripcion_de_Evidencia_CC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Descripcion_de_Evidencia_CC/AddDetalle_de_Descripcion_de_Evidencia_CC");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Lista_de_Documentos_CC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Lista_de_Documentos_CC/AddDetalle_de_Lista_de_Documentos_CC");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Retroalimentacion(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Retroalimentacion/AddDetalle_de_Retroalimentacion");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Referencia(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Referencia/AddDetalle_de_Referencia");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Fotos_de_Emergencia_CC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Fotos_de_Emergencia_CC/AddDetalle_de_Fotos_de_Emergencia_CC");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Historial_de_Emergencia_CC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Historial_de_Emergencia_CC/AddDetalle_de_Historial_de_Emergencia_CC");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Datos_del_Imputado_CC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Datos_del_Imputado_CC/AddDetalle_de_Datos_del_Imputado_CC");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Datos_del_Testigo_CC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Datos_del_Testigo_CC/AddDetalle_de_Datos_del_Testigo_CC");
        }

        [HttpGet]
        public ActionResult AddCatalogo_Tipo_de_Embalaje_CC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Catalogo_Tipo_de_Embalaje_CC/AddCatalogo_Tipo_de_Embalaje_CC");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Lista_de_Asignaciones(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Lista_de_Asignaciones/AddDetalle_de_Lista_de_Asignaciones");
        }

        [HttpGet]
        public ActionResult AddCatalogo_Tipo_de_Fijacion_CC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Catalogo_Tipo_de_Fijacion_CC/AddCatalogo_Tipo_de_Fijacion_CC");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Traslado_de_CC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Traslado_de_CC/AddDetalle_de_Traslado_de_CC");
        }

        [HttpGet]
        public ActionResult AddCatalogo_Tipo_de_Indicio_CC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Catalogo_Tipo_de_Indicio_CC/AddCatalogo_Tipo_de_Indicio_CC");
        }



        #endregion "Controller Methods"

        #region "Custom methods"
		
		[HttpGet]
        public FileStreamResult PrintFormats(int idFormat, string RecordId)
        {
            if (!_tokenManager.GenerateToken())
                return null;

            _IGeneratePDFApiConsumer.SetAuthHeader(_tokenManager.Token);
            _ISpartan_FormatRelatedApiConsumer.SetAuthHeader(_tokenManager.Token);

            MemoryStream ms = new MemoryStream();
           
            //Buscar los Formatos Relacionados
            var relacionados = _ISpartan_FormatRelatedApiConsumer.ListaSelAll(0, 5000, "Spartan_Format_Related.FormatId = " + idFormat, "").Resource.Spartan_Format_Relateds.OrderBy(r => r.Order).ToList();
            if (relacionados.Count > 0)
            {
                var outputDocument = new iTextSharp.text.Document();
                var writer = new PdfCopy(outputDocument, ms);
                outputDocument.Open();
                foreach (var spartan_Format_Related in relacionados)
                {
                    var bytePdf = _IGeneratePDFApiConsumer.GeneratePDF(Convert.ToInt32(spartan_Format_Related.FormatId_Related), RecordId).Resource;
                    var reader = new PdfReader(bytePdf);
                    for (var j = 1; j <= reader.NumberOfPages; j++)
                    {
                        writer.AddPage(writer.GetImportedPage(reader, j));
                    }
                    writer.FreeReader(reader);
                    reader.Close();
                }
                writer.Close();
                outputDocument.Close();
                var allPagesContent = ms.GetBuffer();
                ms.Flush();
            }
            else {
                var bytePdf = _IGeneratePDFApiConsumer.GeneratePDF(idFormat, RecordId);
                ms.Write(bytePdf.Resource, 0, bytePdf.Resource.Length);           
            }
                
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Formatos.pdf");
            Response.Buffer = true;
            Response.Clear();
            Response.OutputStream.Write(ms.GetBuffer(), 0, ms.GetBuffer().Length);
            Response.OutputStream.Flush();
            Response.End();

            return new FileStreamResult(Response.OutputStream, "application/pdf");
        }
		
		
		
		[HttpGet]
        public ActionResult GetFormats(string RecordId)
        {
            if (!_tokenManager.GenerateToken())
                return null;

            var formatList = new List<SelectListItem>();

            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);
            _ISpartan_Format_PermissionsApiConsumer.SetAuthHeader(_tokenManager.Token);
           _ISpartan_FormatApiConsumer.SetAuthHeader(_tokenManager.Token);

            var whereClause = " Spartan_Format_Permissions.Spartan_User_Role = " + SessionHelper.Role + " AND Spartan_Format_Permissions.Permission_Type = 1 AND Apply=1 ";
            var formatsPermisions = _ISpartan_Format_PermissionsApiConsumer.ListaSelAll(0, 500, whereClause, string.Empty).Resource;
            if (formatsPermisions.RowCount > 0)
            {
                var formats = string.Join(",", formatsPermisions.Spartan_Format_Permissionss.Select(f => f.Format).ToArray());
                var whereClauseFormat = "Object = 45133 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Cadena_de_Custodia.Clave= " + RecordId;
                            var result = _ICadena_de_CustodiaApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
                            if (result != null && result.Resource != null && result.Resource.RowCount > 0)
                            {
                                formatList.Add(new SelectListItem
                                {
                                    Text =  CultureHelper.GetTraductionAdd(format.FormatId.ToString(), "Format", format.Format_Name),
                                    Value = Convert.ToString(format.FormatId)
                                });
                            }
                        }
                        else
                        {
                            formatList.Add(new SelectListItem
                            {
                                Text =  CultureHelper.GetTraductionAdd(format.FormatId.ToString(), "Format", format.Format_Name),
                                Value = Convert.ToString(format.FormatId)
                            });
                        }


                    }
                }
            }
            return Json(formatList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public void Export(string format, int pageIndex, int pageSize, string iSortCol, string sSortDir, string where, string order, dynamic columnsVisible)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);
										  
			string[] arrayColumnsVisible = ((string[])columnsVisible)[0].ToString().Split(',');

			 where = HttpUtility.UrlEncode(where);
            if (!_tokenManager.GenerateToken())
                return;

            _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Cadena_de_CustodiaPropertyMapper());
			
			 if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
            if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            //Adding Advance Search
            if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Cadena_de_CustodiaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Cadena_de_CustodiaPropertyMapper oCadena_de_CustodiaPropertyMapper = new Cadena_de_CustodiaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oCadena_de_CustodiaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ICadena_de_CustodiaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Cadena_de_Custodias == null)
                result.Cadena_de_Custodias = new List<Cadena_de_Custodia>();

            var data = result.Cadena_de_Custodias.Select(m => new Cadena_de_CustodiaGridModel
            {
                Clave = m.Clave
			,NUC = m.NUC
			,NIC = m.NIC
                        ,Delito_ReferenciaDescripcion = CultureHelper.GetTraduction(m.Delito_Referencia_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Referencia_Delito.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Lugar_Exacto_del_Levantamiento = m.Lugar_Exacto_del_Levantamiento
			,Condicion_y_Ubicacion = m.Condicion_y_Ubicacion
			,Levantada_por = m.Levantada_por
                        ,CargoTipo_de_Cargo = CultureHelper.GetTraduction(m.Cargo_Catalogo_Tipo_de_Cargo_CC.Clave.ToString(), "Tipo_de_Cargo") ?? (string)m.Cargo_Catalogo_Tipo_de_Cargo_CC.Tipo_de_Cargo
                        ,AsignarName = CultureHelper.GetTraduction(m.Asignar_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Asignar_Spartan_User.Name
			,Folio_NUE = m.Folio_NUE
                        ,Unidad_PolicialUnidad_Policial = CultureHelper.GetTraduction(m.Unidad_Policial_Catalogo_Unidad_Policial.Clave.ToString(), "Unidad_Policial") ?? (string)m.Unidad_Policial_Catalogo_Unidad_Policial.Unidad_Policial
			,Caracterististicas_del_indicio = m.Caracterististicas_del_indicio
			,Condiciones_De_Manejo = m.Condiciones_De_Manejo
			,Numero_de_Parte = m.Numero_de_Parte
			,CUIP = m.CUIP
			,Observaciones = m.Observaciones
			,Longitud = m.Longitud
			,Latitud = m.Latitud
			,Clima = m.Clima
			,Grados = m.Grados
			,Fijacion_Planimetrica = m.Fijacion_Planimetrica
			,Mensaje = m.Mensaje
                        ,Unidad_AdministrativaDescripcion = CultureHelper.GetTraduction(m.Unidad_Administrativa_Catalogo_Unidad_Administrativa_CC.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Administrativa_Catalogo_Unidad_Administrativa_CC.Descripcion
                        ,Entidad_FederativaNombre = CultureHelper.GetTraduction(m.Entidad_Federativa_Estado.Clave.ToString(), "Nombre") ?? (string)m.Entidad_Federativa_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,Fecha_CC = (m.Fecha_CC == null ? string.Empty : Convert.ToDateTime(m.Fecha_CC).ToString(ConfigurationProperty.DateFormat))
			,Hora_CC = m.Hora_CC
                        ,Motivo_de_IntervencionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Intervencion_Catalogo_Motivo_de_Intervencion_CC.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Intervencion_Catalogo_Motivo_de_Intervencion_CC.Descripcion
			,Otro = m.Otro
                        ,EstatusEstatus = CultureHelper.GetTraduction(m.Estatus_Catalogo_Estatus_CC.Clave.ToString(), "Estatus") ?? (string)m.Estatus_Catalogo_Estatus_CC.Estatus
			,Nombre_Completo = m.Nombre_Completo
			,Usuario_que_Registra = m.Usuario_que_Registra
			,FAE = m.FAE
                        ,Fecha_de_la_Emergencia = (m.Fecha_de_la_Emergencia == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_Emergencia).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Emergencia = m.Hora_de_la_Emergencia
			,Fuente = m.Fuente
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Red_Social = m.Red_Social
			,Medio_Masivo = m.Medio_Masivo
			,Cargo_de_la_Autoridad = m.Cargo_de_la_Autoridad
			,Tipo_de_Emergencia = m.Tipo_de_Emergencia
			,Descripcion_de_la_Emergencia = m.Descripcion_de_la_Emergencia
			,Probables_Detenidos = m.Probables_Detenidos
                        ,Fecha_de_la_Detencion = (m.Fecha_de_la_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_Detencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Detencion = m.Hora_de_la_Detencion
			,Pais_Emergencia = m.Pais_Emergencia
			,Estado_Emergencia = m.Estado_Emergencia
			,Municipio_Emergencia = m.Municipio_Emergencia
			,Colonia_Emergencia = m.Colonia_Emergencia
			,Calle_Emergencia = m.Calle_Emergencia
			,Entre_Calle_Emergencia = m.Entre_Calle_Emergencia
			,Y_Calle_Emergencia = m.Y_Calle_Emergencia
			,Latitud_Emergencia = m.Latitud_Emergencia
			,Longitud_Emergencia = m.Longitud_Emergencia
			,Nombre_de_la_Autoridad = m.Nombre_de_la_Autoridad
			,Especifique = m.Especifique
			,Tipo_de_Agente = m.Tipo_de_Agente
			,Area = m.Area
			,Unidad = m.Unidad
			,Zona = m.Zona
			,Agente_Investigador = m.Agente_Investigador
			,Narrativa_de_los_Hechos = m.Narrativa_de_los_Hechos
			,Probable_Delito_Principal = m.Probable_Delito_Principal
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
			,Estatus_NUE = m.Estatus_NUE
                        ,Inicio_de_Cadena_de_CustodiaDescripcion = CultureHelper.GetTraduction(m.Inicio_de_Cadena_de_Custodia_Catalogo_de_Inicio_de_Cadena_de_Custodia.Clave.ToString(), "Descripcion") ?? (string)m.Inicio_de_Cadena_de_Custodia_Catalogo_de_Inicio_de_Cadena_de_Custodia.Descripcion
                        ,Calidad_de_quien_aportaDescripcion = CultureHelper.GetTraduction(m.Calidad_de_quien_aporta_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_de_quien_aporta_Tipo_de_Compareciente.Descripcion
                        ,Fecha_del_arribo = (m.Fecha_del_arribo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_arribo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_arribo = m.Hora_del_arribo
                        ,Descripcion_de_recoleccionDescripcion = CultureHelper.GetTraduction(m.Descripcion_de_recoleccion_Catalogo_de_Recoleccion.Clave.ToString(), "Descripcion") ?? (string)m.Descripcion_de_recoleccion_Catalogo_de_Recoleccion.Descripcion
                        ,Movil_para_TrasladoDescripcion = CultureHelper.GetTraduction(m.Movil_para_Traslado_Catalogo_de_Movil_para_traslado.Clave.ToString(), "Descripcion") ?? (string)m.Movil_para_Traslado_Catalogo_de_Movil_para_traslado.Descripcion
			,Servidor_Publico_que_Preserva = m.Servidor_Publico_que_Preserva
			,Servidor_Publico_que_Busca = m.Servidor_Publico_que_Busca
			,Servidor_Publico_que_Localiza = m.Servidor_Publico_que_Localiza
			,Servidor_Publico_que_Recolecta = m.Servidor_Publico_que_Recolecta
			,Servidor_Publico_que_Traslada = m.Servidor_Publico_que_Traslada
			,Preservacion = m.Preservacion
			,Busqueda = m.Busqueda
			,Localizacion = m.Localizacion
			,Recoleccion = m.Recoleccion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45133, arrayColumnsVisible), "Cadena_de_CustodiaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45133, arrayColumnsVisible), "Cadena_de_CustodiaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45133, arrayColumnsVisible), "Cadena_de_CustodiaList_" + DateTime.Now.ToString());
                    break;
            }
        }

        [HttpGet]
        //[ObjectAuth(ObjectId = ModuleObjectId.EMPLEADOS_OBJECT, PermissionType = PermissionTypes.Export)]
        public ActionResult Print(string format, int pageIndex, int pageSize, string iSortCol, string sSortDir,string where, string order)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);

			where = HttpUtility.UrlEncode(where);
										   
            if (!_tokenManager.GenerateToken())
                return null;

            _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Cadena_de_CustodiaPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Cadena_de_CustodiaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Cadena_de_CustodiaPropertyMapper oCadena_de_CustodiaPropertyMapper = new Cadena_de_CustodiaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oCadena_de_CustodiaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ICadena_de_CustodiaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Cadena_de_Custodias == null)
                result.Cadena_de_Custodias = new List<Cadena_de_Custodia>();

            var data = result.Cadena_de_Custodias.Select(m => new Cadena_de_CustodiaGridModel
            {
                Clave = m.Clave
			,NUC = m.NUC
			,NIC = m.NIC
                        ,Delito_ReferenciaDescripcion = CultureHelper.GetTraduction(m.Delito_Referencia_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Referencia_Delito.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Lugar_Exacto_del_Levantamiento = m.Lugar_Exacto_del_Levantamiento
			,Condicion_y_Ubicacion = m.Condicion_y_Ubicacion
			,Levantada_por = m.Levantada_por
                        ,CargoTipo_de_Cargo = CultureHelper.GetTraduction(m.Cargo_Catalogo_Tipo_de_Cargo_CC.Clave.ToString(), "Tipo_de_Cargo") ?? (string)m.Cargo_Catalogo_Tipo_de_Cargo_CC.Tipo_de_Cargo
                        ,AsignarName = CultureHelper.GetTraduction(m.Asignar_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Asignar_Spartan_User.Name
			,Folio_NUE = m.Folio_NUE
                        ,Unidad_PolicialUnidad_Policial = CultureHelper.GetTraduction(m.Unidad_Policial_Catalogo_Unidad_Policial.Clave.ToString(), "Unidad_Policial") ?? (string)m.Unidad_Policial_Catalogo_Unidad_Policial.Unidad_Policial
			,Caracterististicas_del_indicio = m.Caracterististicas_del_indicio
			,Condiciones_De_Manejo = m.Condiciones_De_Manejo
			,Numero_de_Parte = m.Numero_de_Parte
			,CUIP = m.CUIP
			,Observaciones = m.Observaciones
			,Longitud = m.Longitud
			,Latitud = m.Latitud
			,Clima = m.Clima
			,Grados = m.Grados
			,Fijacion_Planimetrica = m.Fijacion_Planimetrica
			,Mensaje = m.Mensaje
                        ,Unidad_AdministrativaDescripcion = CultureHelper.GetTraduction(m.Unidad_Administrativa_Catalogo_Unidad_Administrativa_CC.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Administrativa_Catalogo_Unidad_Administrativa_CC.Descripcion
                        ,Entidad_FederativaNombre = CultureHelper.GetTraduction(m.Entidad_Federativa_Estado.Clave.ToString(), "Nombre") ?? (string)m.Entidad_Federativa_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,Fecha_CC = (m.Fecha_CC == null ? string.Empty : Convert.ToDateTime(m.Fecha_CC).ToString(ConfigurationProperty.DateFormat))
			,Hora_CC = m.Hora_CC
                        ,Motivo_de_IntervencionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Intervencion_Catalogo_Motivo_de_Intervencion_CC.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Intervencion_Catalogo_Motivo_de_Intervencion_CC.Descripcion
			,Otro = m.Otro
                        ,EstatusEstatus = CultureHelper.GetTraduction(m.Estatus_Catalogo_Estatus_CC.Clave.ToString(), "Estatus") ?? (string)m.Estatus_Catalogo_Estatus_CC.Estatus
			,Nombre_Completo = m.Nombre_Completo
			,Usuario_que_Registra = m.Usuario_que_Registra
			,FAE = m.FAE
                        ,Fecha_de_la_Emergencia = (m.Fecha_de_la_Emergencia == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_Emergencia).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Emergencia = m.Hora_de_la_Emergencia
			,Fuente = m.Fuente
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Red_Social = m.Red_Social
			,Medio_Masivo = m.Medio_Masivo
			,Cargo_de_la_Autoridad = m.Cargo_de_la_Autoridad
			,Tipo_de_Emergencia = m.Tipo_de_Emergencia
			,Descripcion_de_la_Emergencia = m.Descripcion_de_la_Emergencia
			,Probables_Detenidos = m.Probables_Detenidos
                        ,Fecha_de_la_Detencion = (m.Fecha_de_la_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_Detencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Detencion = m.Hora_de_la_Detencion
			,Pais_Emergencia = m.Pais_Emergencia
			,Estado_Emergencia = m.Estado_Emergencia
			,Municipio_Emergencia = m.Municipio_Emergencia
			,Colonia_Emergencia = m.Colonia_Emergencia
			,Calle_Emergencia = m.Calle_Emergencia
			,Entre_Calle_Emergencia = m.Entre_Calle_Emergencia
			,Y_Calle_Emergencia = m.Y_Calle_Emergencia
			,Latitud_Emergencia = m.Latitud_Emergencia
			,Longitud_Emergencia = m.Longitud_Emergencia
			,Nombre_de_la_Autoridad = m.Nombre_de_la_Autoridad
			,Especifique = m.Especifique
			,Tipo_de_Agente = m.Tipo_de_Agente
			,Area = m.Area
			,Unidad = m.Unidad
			,Zona = m.Zona
			,Agente_Investigador = m.Agente_Investigador
			,Narrativa_de_los_Hechos = m.Narrativa_de_los_Hechos
			,Probable_Delito_Principal = m.Probable_Delito_Principal
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
			,Estatus_NUE = m.Estatus_NUE
                        ,Inicio_de_Cadena_de_CustodiaDescripcion = CultureHelper.GetTraduction(m.Inicio_de_Cadena_de_Custodia_Catalogo_de_Inicio_de_Cadena_de_Custodia.Clave.ToString(), "Descripcion") ?? (string)m.Inicio_de_Cadena_de_Custodia_Catalogo_de_Inicio_de_Cadena_de_Custodia.Descripcion
                        ,Calidad_de_quien_aportaDescripcion = CultureHelper.GetTraduction(m.Calidad_de_quien_aporta_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_de_quien_aporta_Tipo_de_Compareciente.Descripcion
                        ,Fecha_del_arribo = (m.Fecha_del_arribo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_arribo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_arribo = m.Hora_del_arribo
                        ,Descripcion_de_recoleccionDescripcion = CultureHelper.GetTraduction(m.Descripcion_de_recoleccion_Catalogo_de_Recoleccion.Clave.ToString(), "Descripcion") ?? (string)m.Descripcion_de_recoleccion_Catalogo_de_Recoleccion.Descripcion
                        ,Movil_para_TrasladoDescripcion = CultureHelper.GetTraduction(m.Movil_para_Traslado_Catalogo_de_Movil_para_traslado.Clave.ToString(), "Descripcion") ?? (string)m.Movil_para_Traslado_Catalogo_de_Movil_para_traslado.Descripcion
			,Servidor_Publico_que_Preserva = m.Servidor_Publico_que_Preserva
			,Servidor_Publico_que_Busca = m.Servidor_Publico_que_Busca
			,Servidor_Publico_que_Localiza = m.Servidor_Publico_que_Localiza
			,Servidor_Publico_que_Recolecta = m.Servidor_Publico_que_Recolecta
			,Servidor_Publico_que_Traslada = m.Servidor_Publico_que_Traslada
			,Preservacion = m.Preservacion
			,Busqueda = m.Busqueda
			,Localizacion = m.Localizacion
			,Recoleccion = m.Recoleccion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
		
		[HttpGet]
        public JsonResult CreateID()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICadena_de_CustodiaApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Asignacion(Cadena_de_Custodia_AsignacionModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Cadena_de_Custodia_AsignacionInfo = new Cadena_de_Custodia_Asignacion
                {
                    Clave = varCadena_de_Custodia.Clave
                                            ,NUC = varCadena_de_Custodia.NUC
                        ,NIC = varCadena_de_Custodia.NIC
                        ,Delito_Referencia = varCadena_de_Custodia.Delito_Referencia
                        ,Fecha = (!String.IsNullOrEmpty(varCadena_de_Custodia.Fecha)) ? DateTime.ParseExact(varCadena_de_Custodia.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varCadena_de_Custodia.Hora
                        ,Asignar = varCadena_de_Custodia.Asignar
                        ,Folio_NUE = varCadena_de_Custodia.Folio_NUE
                        ,CUIP = varCadena_de_Custodia.CUIP
                        ,Estatus = varCadena_de_Custodia.Estatus
                        ,Usuario_que_Registra = varCadena_de_Custodia.Usuario_que_Registra
                        ,Fecha_de_Asignacion = (!String.IsNullOrEmpty(varCadena_de_Custodia.Fecha_de_Asignacion)) ? DateTime.ParseExact(varCadena_de_Custodia.Fecha_de_Asignacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Asignacion = varCadena_de_Custodia.Hora_de_Asignacion
                        ,Estatus_NUE = varCadena_de_Custodia.Estatus_NUE
                    
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Asignacion(Cadena_de_Custodia_AsignacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Asignacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Asignacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_AsignacionModel
                {
                    Clave = m.Clave
			,NUC = m.NUC
			,NIC = m.NIC
                        ,Delito_Referencia = m.Delito_Referencia
                        ,Delito_ReferenciaDescripcion = CultureHelper.GetTraduction(m.Delito_Referencia_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Referencia_Delito.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Asignar = m.Asignar
                        ,AsignarName = CultureHelper.GetTraduction(m.Asignar_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Asignar_Spartan_User.Name
			,Folio_NUE = m.Folio_NUE
			,CUIP = m.CUIP
                        ,Estatus = m.Estatus
                        ,EstatusEstatus = CultureHelper.GetTraduction(m.Estatus_Catalogo_Estatus_CC.Clave.ToString(), "Estatus") ?? (string)m.Estatus_Catalogo_Estatus_CC.Estatus
			,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
			,Estatus_NUE = m.Estatus_NUE

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Cadena_de_Custodia(Cadena_de_Custodia_Cadena_de_CustodiaModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Cadena_de_Custodia_Cadena_de_CustodiaInfo = new Cadena_de_Custodia_Cadena_de_Custodia
                {
                    Clave = varCadena_de_Custodia.Clave
                                            ,Lugar_Exacto_del_Levantamiento = varCadena_de_Custodia.Lugar_Exacto_del_Levantamiento
                        ,Condicion_y_Ubicacion = varCadena_de_Custodia.Condicion_y_Ubicacion
                        ,Levantada_por = varCadena_de_Custodia.Levantada_por
                        ,Cargo = varCadena_de_Custodia.Cargo
                        ,Unidad_Policial = varCadena_de_Custodia.Unidad_Policial
                        ,Caracterististicas_del_indicio = varCadena_de_Custodia.Caracterististicas_del_indicio
                        ,Condiciones_De_Manejo = varCadena_de_Custodia.Condiciones_De_Manejo
                        ,Numero_de_Parte = varCadena_de_Custodia.Numero_de_Parte
                        ,Observaciones = varCadena_de_Custodia.Observaciones
                        ,Unidad_Administrativa = varCadena_de_Custodia.Unidad_Administrativa
                        ,Entidad_Federativa = varCadena_de_Custodia.Entidad_Federativa
                        ,Municipio = varCadena_de_Custodia.Municipio
                        ,Numero_de_Oficio = varCadena_de_Custodia.Numero_de_Oficio
                        ,Fecha_CC = (!String.IsNullOrEmpty(varCadena_de_Custodia.Fecha_CC)) ? DateTime.ParseExact(varCadena_de_Custodia.Fecha_CC, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_CC = varCadena_de_Custodia.Hora_CC
                        ,Motivo_de_Intervencion = varCadena_de_Custodia.Motivo_de_Intervencion
                        ,Otro = varCadena_de_Custodia.Otro
                        ,Nombre_Completo = varCadena_de_Custodia.Nombre_Completo
                        ,Inicio_de_Cadena_de_Custodia = varCadena_de_Custodia.Inicio_de_Cadena_de_Custodia
                        ,Calidad_de_quien_aporta = varCadena_de_Custodia.Calidad_de_quien_aporta
                        ,Fecha_del_arribo = (!String.IsNullOrEmpty(varCadena_de_Custodia.Fecha_del_arribo)) ? DateTime.ParseExact(varCadena_de_Custodia.Fecha_del_arribo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_del_arribo = varCadena_de_Custodia.Hora_del_arribo
                        ,Descripcion_de_recoleccion = varCadena_de_Custodia.Descripcion_de_recoleccion
                        ,Movil_para_Traslado = varCadena_de_Custodia.Movil_para_Traslado
                        ,Servidor_Publico_que_Preserva = varCadena_de_Custodia.Servidor_Publico_que_Preserva
                        ,Servidor_Publico_que_Busca = varCadena_de_Custodia.Servidor_Publico_que_Busca
                        ,Servidor_Publico_que_Localiza = varCadena_de_Custodia.Servidor_Publico_que_Localiza
                        ,Servidor_Publico_que_Recolecta = varCadena_de_Custodia.Servidor_Publico_que_Recolecta
                        ,Servidor_Publico_que_Traslada = varCadena_de_Custodia.Servidor_Publico_que_Traslada
                        ,Preservacion = varCadena_de_Custodia.Preservacion
                        ,Busqueda = varCadena_de_Custodia.Busqueda
                        ,Localizacion = varCadena_de_Custodia.Localizacion
                        ,Recoleccion = varCadena_de_Custodia.Recoleccion
                    
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Cadena_de_Custodia(Cadena_de_Custodia_Cadena_de_CustodiaInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Cadena_de_Custodia(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Cadena_de_Custodia(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_Cadena_de_CustodiaModel
                {
                    Clave = m.Clave
			,Lugar_Exacto_del_Levantamiento = m.Lugar_Exacto_del_Levantamiento
			,Condicion_y_Ubicacion = m.Condicion_y_Ubicacion
			,Levantada_por = m.Levantada_por
                        ,Cargo = m.Cargo
                        ,CargoTipo_de_Cargo = CultureHelper.GetTraduction(m.Cargo_Catalogo_Tipo_de_Cargo_CC.Clave.ToString(), "Tipo_de_Cargo") ?? (string)m.Cargo_Catalogo_Tipo_de_Cargo_CC.Tipo_de_Cargo
                        ,Unidad_Policial = m.Unidad_Policial
                        ,Unidad_PolicialUnidad_Policial = CultureHelper.GetTraduction(m.Unidad_Policial_Catalogo_Unidad_Policial.Clave.ToString(), "Unidad_Policial") ?? (string)m.Unidad_Policial_Catalogo_Unidad_Policial.Unidad_Policial
			,Caracterististicas_del_indicio = m.Caracterististicas_del_indicio
			,Condiciones_De_Manejo = m.Condiciones_De_Manejo
			,Numero_de_Parte = m.Numero_de_Parte
			,Observaciones = m.Observaciones
                        ,Unidad_Administrativa = m.Unidad_Administrativa
                        ,Unidad_AdministrativaDescripcion = CultureHelper.GetTraduction(m.Unidad_Administrativa_Catalogo_Unidad_Administrativa_CC.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Administrativa_Catalogo_Unidad_Administrativa_CC.Descripcion
                        ,Entidad_Federativa = m.Entidad_Federativa
                        ,Entidad_FederativaNombre = CultureHelper.GetTraduction(m.Entidad_Federativa_Estado.Clave.ToString(), "Nombre") ?? (string)m.Entidad_Federativa_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,Fecha_CC = (m.Fecha_CC == null ? string.Empty : Convert.ToDateTime(m.Fecha_CC).ToString(ConfigurationProperty.DateFormat))
			,Hora_CC = m.Hora_CC
                        ,Motivo_de_Intervencion = m.Motivo_de_Intervencion
                        ,Motivo_de_IntervencionDescripcion = CultureHelper.GetTraduction(m.Motivo_de_Intervencion_Catalogo_Motivo_de_Intervencion_CC.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_de_Intervencion_Catalogo_Motivo_de_Intervencion_CC.Descripcion
			,Otro = m.Otro
			,Nombre_Completo = m.Nombre_Completo
                        ,Inicio_de_Cadena_de_Custodia = m.Inicio_de_Cadena_de_Custodia
                        ,Inicio_de_Cadena_de_CustodiaDescripcion = CultureHelper.GetTraduction(m.Inicio_de_Cadena_de_Custodia_Catalogo_de_Inicio_de_Cadena_de_Custodia.Clave.ToString(), "Descripcion") ?? (string)m.Inicio_de_Cadena_de_Custodia_Catalogo_de_Inicio_de_Cadena_de_Custodia.Descripcion
                        ,Calidad_de_quien_aporta = m.Calidad_de_quien_aporta
                        ,Calidad_de_quien_aportaDescripcion = CultureHelper.GetTraduction(m.Calidad_de_quien_aporta_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Calidad_de_quien_aporta_Tipo_de_Compareciente.Descripcion
                        ,Fecha_del_arribo = (m.Fecha_del_arribo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_arribo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_arribo = m.Hora_del_arribo
                        ,Descripcion_de_recoleccion = m.Descripcion_de_recoleccion
                        ,Descripcion_de_recoleccionDescripcion = CultureHelper.GetTraduction(m.Descripcion_de_recoleccion_Catalogo_de_Recoleccion.Clave.ToString(), "Descripcion") ?? (string)m.Descripcion_de_recoleccion_Catalogo_de_Recoleccion.Descripcion
                        ,Movil_para_Traslado = m.Movil_para_Traslado
                        ,Movil_para_TrasladoDescripcion = CultureHelper.GetTraduction(m.Movil_para_Traslado_Catalogo_de_Movil_para_traslado.Clave.ToString(), "Descripcion") ?? (string)m.Movil_para_Traslado_Catalogo_de_Movil_para_traslado.Descripcion
			,Servidor_Publico_que_Preserva = m.Servidor_Publico_que_Preserva
			,Servidor_Publico_que_Busca = m.Servidor_Publico_que_Busca
			,Servidor_Publico_que_Localiza = m.Servidor_Publico_que_Localiza
			,Servidor_Publico_que_Recolecta = m.Servidor_Publico_que_Recolecta
			,Servidor_Publico_que_Traslada = m.Servidor_Publico_que_Traslada
			,Preservacion = m.Preservacion
			,Busqueda = m.Busqueda
			,Localizacion = m.Localizacion
			,Recoleccion = m.Recoleccion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Fijacion_Planimetrica(Cadena_de_Custodia_Fijacion_PlanimetricaModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varCadena_de_Custodia.Fijacion_PlanimetricaRemoveAttachment != 0 && varCadena_de_Custodia.Fijacion_PlanimetricaFile == null)
                    {
                        varCadena_de_Custodia.Fijacion_Planimetrica = 0;
                    }

                    if (varCadena_de_Custodia.Fijacion_PlanimetricaFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varCadena_de_Custodia.Fijacion_PlanimetricaFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varCadena_de_Custodia.Fijacion_Planimetrica = (short)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varCadena_de_Custodia.Fijacion_PlanimetricaFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Cadena_de_Custodia_Fijacion_PlanimetricaInfo = new Cadena_de_Custodia_Fijacion_Planimetrica
                {
                    Clave = varCadena_de_Custodia.Clave
                                            ,Longitud = varCadena_de_Custodia.Longitud
                        ,Latitud = varCadena_de_Custodia.Latitud
                        ,Clima = varCadena_de_Custodia.Clima
                        ,Grados = varCadena_de_Custodia.Grados
                        ,Fijacion_Planimetrica = (varCadena_de_Custodia.Fijacion_Planimetrica.HasValue && varCadena_de_Custodia.Fijacion_Planimetrica != 0) ? ((int?)Convert.ToInt32(varCadena_de_Custodia.Fijacion_Planimetrica.Value)) : null

                    
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Fijacion_Planimetrica(Cadena_de_Custodia_Fijacion_PlanimetricaInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Fijacion_Planimetrica(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Fijacion_Planimetrica(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_Fijacion_PlanimetricaModel
                {
                    Clave = m.Clave
			,Longitud = m.Longitud
			,Latitud = m.Latitud
			,Clima = m.Clima
			,Grados = m.Grados
			,Fijacion_Planimetrica = m.Fijacion_Planimetrica

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Fotos(Cadena_de_Custodia_FotosModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Cadena_de_Custodia_FotosInfo = new Cadena_de_Custodia_Fotos
                {
                    Clave = varCadena_de_Custodia.Clave
                                        
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Fotos(Cadena_de_Custodia_FotosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Fotos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Fotos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_FotosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Videos(Cadena_de_Custodia_VideosModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Cadena_de_Custodia_VideosInfo = new Cadena_de_Custodia_Videos
                {
                    Clave = varCadena_de_Custodia.Clave
                                        
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Videos(Cadena_de_Custodia_VideosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Videos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Videos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_VideosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Registro_de_Intervinientes(Cadena_de_Custodia_Registro_de_IntervinientesModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Cadena_de_Custodia_Registro_de_IntervinientesInfo = new Cadena_de_Custodia_Registro_de_Intervinientes
                {
                    Clave = varCadena_de_Custodia.Clave
                                        
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Registro_de_Intervinientes(Cadena_de_Custodia_Registro_de_IntervinientesInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Registro_de_Intervinientes(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Registro_de_Intervinientes(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_Registro_de_IntervinientesModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Chat(Cadena_de_Custodia_ChatModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Cadena_de_Custodia_ChatInfo = new Cadena_de_Custodia_Chat
                {
                    Clave = varCadena_de_Custodia.Clave
                                            ,Mensaje = varCadena_de_Custodia.Mensaje
                    
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Chat(Cadena_de_Custodia_ChatInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Chat(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Chat(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_ChatModel
                {
                    Clave = m.Clave
			,Mensaje = m.Mensaje

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Documentos(Cadena_de_Custodia_DocumentosModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Cadena_de_Custodia_DocumentosInfo = new Cadena_de_Custodia_Documentos
                {
                    Clave = varCadena_de_Custodia.Clave
                                        
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Documentos(Cadena_de_Custodia_DocumentosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Documentos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Documentos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_DocumentosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Retroalimentacion(Cadena_de_Custodia_RetroalimentacionModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Cadena_de_Custodia_RetroalimentacionInfo = new Cadena_de_Custodia_Retroalimentacion
                {
                    Clave = varCadena_de_Custodia.Clave
                                        
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Retroalimentacion(Cadena_de_Custodia_RetroalimentacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Retroalimentacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Retroalimentacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_RetroalimentacionModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Registro_de_Emergencia(Cadena_de_Custodia_Registro_de_EmergenciaModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Cadena_de_Custodia_Registro_de_EmergenciaInfo = new Cadena_de_Custodia_Registro_de_Emergencia
                {
                    Clave = varCadena_de_Custodia.Clave
                                            ,FAE = varCadena_de_Custodia.FAE
                        ,Fecha_de_la_Emergencia = (!String.IsNullOrEmpty(varCadena_de_Custodia.Fecha_de_la_Emergencia)) ? DateTime.ParseExact(varCadena_de_Custodia.Fecha_de_la_Emergencia, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_la_Emergencia = varCadena_de_Custodia.Hora_de_la_Emergencia
                        ,Fuente = varCadena_de_Custodia.Fuente
                        ,Telefono = varCadena_de_Custodia.Telefono
                        ,Celular = varCadena_de_Custodia.Celular
                        ,Correo_Electronico = varCadena_de_Custodia.Correo_Electronico
                        ,Red_Social = varCadena_de_Custodia.Red_Social
                        ,Medio_Masivo = varCadena_de_Custodia.Medio_Masivo
                        ,Cargo_de_la_Autoridad = varCadena_de_Custodia.Cargo_de_la_Autoridad
                        ,Tipo_de_Emergencia = varCadena_de_Custodia.Tipo_de_Emergencia
                        ,Descripcion_de_la_Emergencia = varCadena_de_Custodia.Descripcion_de_la_Emergencia
                        ,Probables_Detenidos = varCadena_de_Custodia.Probables_Detenidos
                        ,Fecha_de_la_Detencion = (!String.IsNullOrEmpty(varCadena_de_Custodia.Fecha_de_la_Detencion)) ? DateTime.ParseExact(varCadena_de_Custodia.Fecha_de_la_Detencion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_la_Detencion = varCadena_de_Custodia.Hora_de_la_Detencion
                        ,Pais_Emergencia = varCadena_de_Custodia.Pais_Emergencia
                        ,Estado_Emergencia = varCadena_de_Custodia.Estado_Emergencia
                        ,Municipio_Emergencia = varCadena_de_Custodia.Municipio_Emergencia
                        ,Colonia_Emergencia = varCadena_de_Custodia.Colonia_Emergencia
                        ,Calle_Emergencia = varCadena_de_Custodia.Calle_Emergencia
                        ,Entre_Calle_Emergencia = varCadena_de_Custodia.Entre_Calle_Emergencia
                        ,Y_Calle_Emergencia = varCadena_de_Custodia.Y_Calle_Emergencia
                        ,Latitud_Emergencia = varCadena_de_Custodia.Latitud_Emergencia
                        ,Longitud_Emergencia = varCadena_de_Custodia.Longitud_Emergencia
                        ,Nombre_de_la_Autoridad = varCadena_de_Custodia.Nombre_de_la_Autoridad
                        ,Especifique = varCadena_de_Custodia.Especifique
                        ,Tipo_de_Agente = varCadena_de_Custodia.Tipo_de_Agente
                        ,Area = varCadena_de_Custodia.Area
                        ,Unidad = varCadena_de_Custodia.Unidad
                        ,Zona = varCadena_de_Custodia.Zona
                        ,Agente_Investigador = varCadena_de_Custodia.Agente_Investigador
                        ,Narrativa_de_los_Hechos = varCadena_de_Custodia.Narrativa_de_los_Hechos
                        ,Probable_Delito_Principal = varCadena_de_Custodia.Probable_Delito_Principal
                    
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Registro_de_Emergencia(Cadena_de_Custodia_Registro_de_EmergenciaInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Registro_de_Emergencia(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Registro_de_Emergencia(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_Registro_de_EmergenciaModel
                {
                    Clave = m.Clave
			,FAE = m.FAE
                        ,Fecha_de_la_Emergencia = (m.Fecha_de_la_Emergencia == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_Emergencia).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Emergencia = m.Hora_de_la_Emergencia
			,Fuente = m.Fuente
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Red_Social = m.Red_Social
			,Medio_Masivo = m.Medio_Masivo
			,Cargo_de_la_Autoridad = m.Cargo_de_la_Autoridad
			,Tipo_de_Emergencia = m.Tipo_de_Emergencia
			,Descripcion_de_la_Emergencia = m.Descripcion_de_la_Emergencia
			,Probables_Detenidos = m.Probables_Detenidos
                        ,Fecha_de_la_Detencion = (m.Fecha_de_la_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_la_Detencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_la_Detencion = m.Hora_de_la_Detencion
			,Pais_Emergencia = m.Pais_Emergencia
			,Estado_Emergencia = m.Estado_Emergencia
			,Municipio_Emergencia = m.Municipio_Emergencia
			,Colonia_Emergencia = m.Colonia_Emergencia
			,Calle_Emergencia = m.Calle_Emergencia
			,Entre_Calle_Emergencia = m.Entre_Calle_Emergencia
			,Y_Calle_Emergencia = m.Y_Calle_Emergencia
			,Latitud_Emergencia = m.Latitud_Emergencia
			,Longitud_Emergencia = m.Longitud_Emergencia
			,Nombre_de_la_Autoridad = m.Nombre_de_la_Autoridad
			,Especifique = m.Especifique
			,Tipo_de_Agente = m.Tipo_de_Agente
			,Area = m.Area
			,Unidad = m.Unidad
			,Zona = m.Zona
			,Agente_Investigador = m.Agente_Investigador
			,Narrativa_de_los_Hechos = m.Narrativa_de_los_Hechos
			,Probable_Delito_Principal = m.Probable_Delito_Principal

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Registro_de_Detenidos(Cadena_de_Custodia_Registro_de_DetenidosModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Cadena_de_Custodia_Registro_de_DetenidosInfo = new Cadena_de_Custodia_Registro_de_Detenidos
                {
                    Clave = varCadena_de_Custodia.Clave
                                        
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Registro_de_Detenidos(Cadena_de_Custodia_Registro_de_DetenidosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Registro_de_Detenidos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Registro_de_Detenidos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_Registro_de_DetenidosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Registro_de_Testigos(Cadena_de_Custodia_Registro_de_TestigosModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Cadena_de_Custodia_Registro_de_TestigosInfo = new Cadena_de_Custodia_Registro_de_Testigos
                {
                    Clave = varCadena_de_Custodia.Clave
                                        
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Registro_de_Testigos(Cadena_de_Custodia_Registro_de_TestigosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Registro_de_Testigos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Registro_de_Testigos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_Registro_de_TestigosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_Generales(Cadena_de_Custodia_Datos_GeneralesModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Cadena_de_Custodia_Datos_GeneralesInfo = new Cadena_de_Custodia_Datos_Generales
                {
                    Clave = varCadena_de_Custodia.Clave
                                        
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Datos_Generales(Cadena_de_Custodia_Datos_GeneralesInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_Generales(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_Datos_GeneralesModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Asignaciones(Cadena_de_Custodia_AsignacionesModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Cadena_de_Custodia_AsignacionesInfo = new Cadena_de_Custodia_Asignaciones
                {
                    Clave = varCadena_de_Custodia.Clave
                                        
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Asignaciones(Cadena_de_Custodia_AsignacionesInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Asignaciones(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Asignaciones(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_AsignacionesModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_de_Traslado(Cadena_de_Custodia_Datos_de_TrasladoModel varCadena_de_Custodia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Cadena_de_Custodia_Datos_de_TrasladoInfo = new Cadena_de_Custodia_Datos_de_Traslado
                {
                    Clave = varCadena_de_Custodia.Clave
                                        
                };

                result = _ICadena_de_CustodiaApiConsumer.Update_Datos_de_Traslado(Cadena_de_Custodia_Datos_de_TrasladoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_Traslado(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICadena_de_CustodiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICadena_de_CustodiaApiConsumer.Get_Datos_de_Traslado(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Certificado_CC;
                var Detalle_del_Certificado_CCData = GetDetalle_del_Certificado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Certificado_CC);
                int RowCount_Detalle_de_Fotos_CC;
                var Detalle_de_Fotos_CCData = GetDetalle_de_Fotos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_CC);
                int RowCount_Detalle_de_Videos_CC;
                var Detalle_de_Videos_CCData = GetDetalle_de_Videos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Videos_CC);
                int RowCount_Detalle_de_Registro_de_Intervinientes_CC;
                var Detalle_de_Registro_de_Intervinientes_CCData = GetDetalle_de_Registro_de_Intervinientes_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Registro_de_Intervinientes_CC);
                int RowCount_Detalle_de_Descripcion_de_Evidencia_CC;
                var Detalle_de_Descripcion_de_Evidencia_CCData = GetDetalle_de_Descripcion_de_Evidencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Descripcion_de_Evidencia_CC);
                int RowCount_Detalle_de_Lista_de_Documentos_CC;
                var Detalle_de_Lista_de_Documentos_CCData = GetDetalle_de_Lista_de_Documentos_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Documentos_CC);
                int RowCount_Detalle_de_Retroalimentacion;
                var Detalle_de_RetroalimentacionData = GetDetalle_de_RetroalimentacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Retroalimentacion);
                int RowCount_Detalle_de_Referencia;
                var Detalle_de_ReferenciaData = GetDetalle_de_ReferenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Referencia);
                int RowCount_Detalle_de_Fotos_de_Emergencia_CC;
                var Detalle_de_Fotos_de_Emergencia_CCData = GetDetalle_de_Fotos_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Fotos_de_Emergencia_CC);
                int RowCount_Detalle_de_Historial_de_Emergencia_CC;
                var Detalle_de_Historial_de_Emergencia_CCData = GetDetalle_de_Historial_de_Emergencia_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Historial_de_Emergencia_CC);
                int RowCount_Detalle_de_Datos_del_Imputado_CC;
                var Detalle_de_Datos_del_Imputado_CCData = GetDetalle_de_Datos_del_Imputado_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Imputado_CC);
                int RowCount_Detalle_de_Datos_del_Testigo_CC;
                var Detalle_de_Datos_del_Testigo_CCData = GetDetalle_de_Datos_del_Testigo_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Datos_del_Testigo_CC);
                int RowCount_Catalogo_Tipo_de_Embalaje_CC;
                var Catalogo_Tipo_de_Embalaje_CCData = GetCatalogo_Tipo_de_Embalaje_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Embalaje_CC);
                int RowCount_Detalle_de_Lista_de_Asignaciones;
                var Detalle_de_Lista_de_AsignacionesData = GetDetalle_de_Lista_de_AsignacionesData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Lista_de_Asignaciones);
                int RowCount_Catalogo_Tipo_de_Fijacion_CC;
                var Catalogo_Tipo_de_Fijacion_CCData = GetCatalogo_Tipo_de_Fijacion_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Fijacion_CC);
                int RowCount_Detalle_de_Traslado_de_CC;
                var Detalle_de_Traslado_de_CCData = GetDetalle_de_Traslado_de_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Traslado_de_CC);
                int RowCount_Catalogo_Tipo_de_Indicio_CC;
                var Catalogo_Tipo_de_Indicio_CCData = GetCatalogo_Tipo_de_Indicio_CCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Catalogo_Tipo_de_Indicio_CC);

                var result = new Cadena_de_Custodia_Datos_de_TrasladoModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,Certificado = Detalle_del_Certificado_CCData
                    ,Fotos = Detalle_de_Fotos_CCData
                    ,Videos = Detalle_de_Videos_CCData
                    ,Datos_del_Interviniente = Detalle_de_Registro_de_Intervinientes_CCData
                    ,Descripcion_de_Evidencia = Detalle_de_Descripcion_de_Evidencia_CCData
                    ,Lista_de_Documentos = Detalle_de_Lista_de_Documentos_CCData
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData
                    ,Puntos_de_Referencia = Detalle_de_ReferenciaData
                    ,Fotos_de_Evidencia = Detalle_de_Fotos_de_Emergencia_CCData
                    ,Historial_de_Movimientos = Detalle_de_Historial_de_Emergencia_CCData
                    ,Datos_del_Detenido = Detalle_de_Datos_del_Imputado_CCData
                    ,Datos_del_Testigo = Detalle_de_Datos_del_Testigo_CCData
                    ,Tipo_de_embalaje = Catalogo_Tipo_de_Embalaje_CCData
                    ,Lista_de_Asignaciones = Detalle_de_Lista_de_AsignacionesData
                    ,Tipo_de_Fijacion = Catalogo_Tipo_de_Fijacion_CCData
                    ,Datos_de_Traslado = Detalle_de_Traslado_de_CCData
                    ,Tipo_de_Indicio = Catalogo_Tipo_de_Indicio_CCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

