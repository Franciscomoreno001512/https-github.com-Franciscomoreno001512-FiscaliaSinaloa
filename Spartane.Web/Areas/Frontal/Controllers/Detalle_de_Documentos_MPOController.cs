using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Documentos_MPO;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Documento;
using Spartane.Core.Domain.Documento;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.Detalle_Delitos_de_Documentos;

using Spartane.Core.Domain.Detalle_de_Delito;

using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia;





using Spartane.Core.Domain.Estatus_Persona;
using Spartane.Core.Domain.Condiciones_de_Localizacion;
using Spartane.Core.Domain.Lugar_del_Hallazgo;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Ente_que_localiza;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Documentos_MPO;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Documentos_MPO;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Documento;
using Spartane.Web.Areas.WebApiConsumer.Documento;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_Generales;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Imputado;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Delitos_de_Documentos;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Delito;

using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Indicios_de_Diligencia;



using Spartane.Web.Areas.WebApiConsumer.Estatus_Persona;
using Spartane.Web.Areas.WebApiConsumer.Condiciones_de_Localizacion;
using Spartane.Web.Areas.WebApiConsumer.Lugar_del_Hallazgo;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Ente_que_localiza;

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
    public class Detalle_de_Documentos_MPOController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Documentos_MPOService service = null;
        private IDetalle_de_Documentos_MPOApiConsumer _IDetalle_de_Documentos_MPOApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ITipo_de_DocumentoApiConsumer _ITipo_de_DocumentoApiConsumer;
        private IDocumentoApiConsumer _IDocumentoApiConsumer;
        private IDetalle_de_Datos_GeneralesApiConsumer _IDetalle_de_Datos_GeneralesApiConsumer;
        private IDetalle_de_ImputadoApiConsumer _IDetalle_de_ImputadoApiConsumer;
        private IDetalle_Delitos_de_DocumentosApiConsumer _IDetalle_Delitos_de_DocumentosApiConsumer;

        private IDetalle_de_DelitoApiConsumer _IDetalle_de_DelitoApiConsumer;

        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private IDetalle_de_Indicios_de_DiligenciaApiConsumer _IDetalle_de_Indicios_de_DiligenciaApiConsumer;



        private IEstatus_PersonaApiConsumer _IEstatus_PersonaApiConsumer;
        private ICondiciones_de_LocalizacionApiConsumer _ICondiciones_de_LocalizacionApiConsumer;
        private ILugar_del_HallazgoApiConsumer _ILugar_del_HallazgoApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IEnte_que_localizaApiConsumer _IEnte_que_localizaApiConsumer;

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

        
        public Detalle_de_Documentos_MPOController(IDetalle_de_Documentos_MPOService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Documentos_MPOApiConsumer Detalle_de_Documentos_MPOApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ITipo_de_DocumentoApiConsumer Tipo_de_DocumentoApiConsumer , IDocumentoApiConsumer DocumentoApiConsumer , IDetalle_de_Datos_GeneralesApiConsumer Detalle_de_Datos_GeneralesApiConsumer , IDetalle_de_ImputadoApiConsumer Detalle_de_ImputadoApiConsumer , IDetalle_Delitos_de_DocumentosApiConsumer Detalle_Delitos_de_DocumentosApiConsumer , IDetalle_de_DelitoApiConsumer Detalle_de_DelitoApiConsumer  , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , IDetalle_de_Indicios_de_DiligenciaApiConsumer Detalle_de_Indicios_de_DiligenciaApiConsumer  , IEstatus_PersonaApiConsumer Estatus_PersonaApiConsumer , ICondiciones_de_LocalizacionApiConsumer Condiciones_de_LocalizacionApiConsumer , ILugar_del_HallazgoApiConsumer Lugar_del_HallazgoApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IEnte_que_localizaApiConsumer Ente_que_localizaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Documentos_MPOApiConsumer = Detalle_de_Documentos_MPOApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IModulo_Atencion_InicialApiConsumer = Modulo_Atencion_InicialApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ITipo_de_DocumentoApiConsumer = Tipo_de_DocumentoApiConsumer;
            this._IDocumentoApiConsumer = DocumentoApiConsumer;
            this._IDetalle_de_Datos_GeneralesApiConsumer = Detalle_de_Datos_GeneralesApiConsumer;
            this._IDetalle_de_ImputadoApiConsumer = Detalle_de_ImputadoApiConsumer;
            this._IDetalle_Delitos_de_DocumentosApiConsumer = Detalle_Delitos_de_DocumentosApiConsumer;

            this._IDetalle_de_DelitoApiConsumer = Detalle_de_DelitoApiConsumer;

            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
            this._IDetalle_de_Indicios_de_DiligenciaApiConsumer = Detalle_de_Indicios_de_DiligenciaApiConsumer;



            this._IEstatus_PersonaApiConsumer = Estatus_PersonaApiConsumer;
            this._ICondiciones_de_LocalizacionApiConsumer = Condiciones_de_LocalizacionApiConsumer;
            this._ILugar_del_HallazgoApiConsumer = Lugar_del_HallazgoApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IEnte_que_localizaApiConsumer = Ente_que_localizaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Documentos_MPO
        [ObjectAuth(ObjectId = (ModuleObjectId)45109, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45109, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_de_Documentos_MPO/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45109, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45109, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_de_Documentos_MPO = new Detalle_de_Documentos_MPOModel();
			varDetalle_de_Documentos_MPO.Clave = Id;
			
            ViewBag.ObjectId = "45109";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_Delitos_de_Documentos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45390, ModuleId);
            ViewBag.PermissionDetalle_Delitos_de_Documentos = permissionDetalle_Delitos_de_Documentos;
            var permissionDetalle_de_Indicios_de_Diligencia = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46343, ModuleId);
            ViewBag.PermissionDetalle_de_Indicios_de_Diligencia = permissionDetalle_de_Indicios_de_Diligencia;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Documentos_MPOsData = _IDetalle_de_Documentos_MPOApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Documentos_MPO.Clave=" + Id, "").Resource.Detalle_de_Documentos_MPOs;
				
				if (Detalle_de_Documentos_MPOsData != null && Detalle_de_Documentos_MPOsData.Count > 0)
                {
					var Detalle_de_Documentos_MPOData = Detalle_de_Documentos_MPOsData.First();
					varDetalle_de_Documentos_MPO= new Detalle_de_Documentos_MPOModel
					{
						Clave  = Detalle_de_Documentos_MPOData.Clave 
	                    ,Modulo_Atencion_Inicial = Detalle_de_Documentos_MPOData.Modulo_Atencion_Inicial
                    ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Modulo_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Detalle_de_Documentos_MPOData.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Fecha = (Detalle_de_Documentos_MPOData.Fecha == null ? string.Empty : Convert.ToDateTime(Detalle_de_Documentos_MPOData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Detalle_de_Documentos_MPOData.Hora
                    ,Usuario_que_Registra = Detalle_de_Documentos_MPOData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Usuario_que_Registra), "Spartan_User") ??  (string)Detalle_de_Documentos_MPOData.Usuario_que_Registra_Spartan_User.Name
                    ,Tipo_de_Documento = Detalle_de_Documentos_MPOData.Tipo_de_Documento
                    ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Tipo_de_Documento), "Tipo_de_Documento") ??  (string)Detalle_de_Documentos_MPOData.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                    ,Documento = Detalle_de_Documentos_MPOData.Documento
                    ,DocumentoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Documento), "Documento") ??  (string)Detalle_de_Documentos_MPOData.Documento_Documento.Descripcion
                    ,Involucrado = Detalle_de_Documentos_MPOData.Involucrado
                    ,InvolucradoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Involucrado), "Detalle_de_Datos_Generales") ??  (string)Detalle_de_Documentos_MPOData.Involucrado_Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor
                    ,Probable_Responsable = Detalle_de_Documentos_MPOData.Probable_Responsable
                    ,Probable_ResponsableNombre_Completo_Detenido = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Probable_Responsable), "Detalle_de_Imputado") ??  (string)Detalle_de_Documentos_MPOData.Probable_Responsable_Detalle_de_Imputado.Nombre_Completo_Detenido
                    ,Archivo_Adjunto = Detalle_de_Documentos_MPOData.Archivo_Adjunto
                    ,Observaciones = Detalle_de_Documentos_MPOData.Observaciones
                    ,Archivo = Detalle_de_Documentos_MPOData.Archivo
                    ,Lista_para_periciales = Detalle_de_Documentos_MPOData.Lista_para_periciales.GetValueOrDefault()
                    ,Folio = Detalle_de_Documentos_MPOData.Folio
                    ,Expediente_MP = Detalle_de_Documentos_MPOData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Detalle_de_Documentos_MPOData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Descripcion = Detalle_de_Documentos_MPOData.Descripcion
                    ,Estatus_Persona = Detalle_de_Documentos_MPOData.Estatus_Persona
                    ,Estatus_PersonaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Estatus_Persona), "Estatus_Persona") ??  (string)Detalle_de_Documentos_MPOData.Estatus_Persona_Estatus_Persona.Descripcion
                    ,Fecha_Localizacion = (Detalle_de_Documentos_MPOData.Fecha_Localizacion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Documentos_MPOData.Fecha_Localizacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Localizacion = Detalle_de_Documentos_MPOData.Hora_Localizacion
                    ,Condiciones_de_Localizacion = Detalle_de_Documentos_MPOData.Condiciones_de_Localizacion
                    ,Condiciones_de_LocalizacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Condiciones_de_Localizacion), "Condiciones_de_Localizacion") ??  (string)Detalle_de_Documentos_MPOData.Condiciones_de_Localizacion_Condiciones_de_Localizacion.Descripcion
                    ,Lugar_de_Hallazgo = Detalle_de_Documentos_MPOData.Lugar_de_Hallazgo
                    ,Lugar_de_HallazgoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Lugar_de_Hallazgo), "Lugar_del_Hallazgo") ??  (string)Detalle_de_Documentos_MPOData.Lugar_de_Hallazgo_Lugar_del_Hallazgo.Descripcion
                    ,Posible_Causa_de_la_Desaparacion = Detalle_de_Documentos_MPOData.Posible_Causa_de_la_Desaparacion
                    ,Pais = Detalle_de_Documentos_MPOData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Pais), "Pais") ??  (string)Detalle_de_Documentos_MPOData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_Documentos_MPOData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Estado), "Estado") ??  (string)Detalle_de_Documentos_MPOData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Documentos_MPOData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Municipio), "Municipio") ??  (string)Detalle_de_Documentos_MPOData.Municipio_Municipio.Nombre
                    ,Poblacion = Detalle_de_Documentos_MPOData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Poblacion), "Colonia") ??  (string)Detalle_de_Documentos_MPOData.Poblacion_Colonia.Nombre
                    ,Colonia = Detalle_de_Documentos_MPOData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Colonia), "Colonia") ??  (string)Detalle_de_Documentos_MPOData.Colonia_Colonia.Nombre
                    ,Calle = Detalle_de_Documentos_MPOData.Calle
                    ,Numero_Interior = Detalle_de_Documentos_MPOData.Numero_Interior
                    ,Numero_Exterior = Detalle_de_Documentos_MPOData.Numero_Exterior
                    ,Codigo_Postal = Detalle_de_Documentos_MPOData.Codigo_Postal
                    ,Ente_que_localiza_al_no_localizado = Detalle_de_Documentos_MPOData.Ente_que_localiza_al_no_localizado
                    ,Ente_que_localiza_al_no_localizadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Ente_que_localiza_al_no_localizado), "Ente_que_localiza") ??  (string)Detalle_de_Documentos_MPOData.Ente_que_localiza_al_no_localizado_Ente_que_localiza.Descripcion
                    ,ente_Paterno = Detalle_de_Documentos_MPOData.ente_Paterno
                    ,ente_Materno = Detalle_de_Documentos_MPOData.ente_Materno
                    ,ente_Nombre = Detalle_de_Documentos_MPOData.ente_Nombre
                    ,Autoridad_que_conoce_el_hecho = Detalle_de_Documentos_MPOData.Autoridad_que_conoce_el_hecho
                    ,autoridad_Paterno = Detalle_de_Documentos_MPOData.autoridad_Paterno
                    ,autoridad_Materno = Detalle_de_Documentos_MPOData.autoridad_Materno
                    ,autoridad_Nombre = Detalle_de_Documentos_MPOData.autoridad_Nombre

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_AdjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Documentos_MPO.Archivo_Adjunto).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Documentos_Tipo_de_Documento = _ITipo_de_DocumentoApiConsumer.SelAll(true);
            if (Tipo_de_Documentos_Tipo_de_Documento != null && Tipo_de_Documentos_Tipo_de_Documento.Resource != null)
                ViewBag.Tipo_de_Documentos_Tipo_de_Documento = Tipo_de_Documentos_Tipo_de_Documento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var expediente_ministerio_publicos_Expediente_MP = _Iexpediente_ministerio_publicoApiConsumer.SelAll(true);
            if (expediente_ministerio_publicos_Expediente_MP != null && expediente_ministerio_publicos_Expediente_MP.Resource != null)
                ViewBag.expediente_ministerio_publicos_Expediente_MP = expediente_ministerio_publicos_Expediente_MP.Resource.Where(m => m.nic != null).OrderBy(m => m.nic).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "expediente_ministerio_publico", "nic") ?? m.nic.ToString(), Value = Convert.ToString(m.clave)
                }).ToList();
            _IEstatus_PersonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Personas_Estatus_Persona = _IEstatus_PersonaApiConsumer.SelAll(true);
            if (Estatus_Personas_Estatus_Persona != null && Estatus_Personas_Estatus_Persona.Resource != null)
                ViewBag.Estatus_Personas_Estatus_Persona = Estatus_Personas_Estatus_Persona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Persona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICondiciones_de_LocalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Condiciones_de_Localizacions_Condiciones_de_Localizacion = _ICondiciones_de_LocalizacionApiConsumer.SelAll(true);
            if (Condiciones_de_Localizacions_Condiciones_de_Localizacion != null && Condiciones_de_Localizacions_Condiciones_de_Localizacion.Resource != null)
                ViewBag.Condiciones_de_Localizacions_Condiciones_de_Localizacion = Condiciones_de_Localizacions_Condiciones_de_Localizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Condiciones_de_Localizacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_del_HallazgoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_del_Hallazgos_Lugar_de_Hallazgo = _ILugar_del_HallazgoApiConsumer.SelAll(true);
            if (Lugar_del_Hallazgos_Lugar_de_Hallazgo != null && Lugar_del_Hallazgos_Lugar_de_Hallazgo.Resource != null)
                ViewBag.Lugar_del_Hallazgos_Lugar_de_Hallazgo = Lugar_del_Hallazgos_Lugar_de_Hallazgo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_del_Hallazgo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais != null && Paiss_Pais.Resource != null)
                ViewBag.Paiss_Pais = Paiss_Pais.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado != null && Estados_Estado.Resource != null)
                ViewBag.Estados_Estado = Estados_Estado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
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
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Poblacion = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Poblacion != null && Colonias_Poblacion.Resource != null)
                ViewBag.Colonias_Poblacion = Colonias_Poblacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia != null && Colonias_Colonia.Resource != null)
                ViewBag.Colonias_Colonia = Colonias_Colonia.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEnte_que_localizaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ente_que_localizas_Ente_que_localiza_al_no_localizado = _IEnte_que_localizaApiConsumer.SelAll(true);
            if (Ente_que_localizas_Ente_que_localiza_al_no_localizado != null && Ente_que_localizas_Ente_que_localiza_al_no_localizado.Resource != null)
                ViewBag.Ente_que_localizas_Ente_que_localiza_al_no_localizado = Ente_que_localizas_Ente_que_localiza_al_no_localizado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ente_que_localiza", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDetalle_de_Documentos_MPO);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Documentos_MPO(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45109);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Documentos_MPOModel varDetalle_de_Documentos_MPO= new Detalle_de_Documentos_MPOModel();
            var permissionDetalle_Delitos_de_Documentos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45390, ModuleId);
            ViewBag.PermissionDetalle_Delitos_de_Documentos = permissionDetalle_Delitos_de_Documentos;
            var permissionDetalle_de_Indicios_de_Diligencia = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46343, ModuleId);
            ViewBag.PermissionDetalle_de_Indicios_de_Diligencia = permissionDetalle_de_Indicios_de_Diligencia;


            if (id.ToString() != "0")
            {
                var Detalle_de_Documentos_MPOsData = _IDetalle_de_Documentos_MPOApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Documentos_MPO.Clave=" + id, "").Resource.Detalle_de_Documentos_MPOs;
				
				if (Detalle_de_Documentos_MPOsData != null && Detalle_de_Documentos_MPOsData.Count > 0)
                {
					var Detalle_de_Documentos_MPOData = Detalle_de_Documentos_MPOsData.First();
					varDetalle_de_Documentos_MPO= new Detalle_de_Documentos_MPOModel
					{
						Clave  = Detalle_de_Documentos_MPOData.Clave 
	                    ,Modulo_Atencion_Inicial = Detalle_de_Documentos_MPOData.Modulo_Atencion_Inicial
                    ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Modulo_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Detalle_de_Documentos_MPOData.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Fecha = (Detalle_de_Documentos_MPOData.Fecha == null ? string.Empty : Convert.ToDateTime(Detalle_de_Documentos_MPOData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Detalle_de_Documentos_MPOData.Hora
                    ,Usuario_que_Registra = Detalle_de_Documentos_MPOData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Usuario_que_Registra), "Spartan_User") ??  (string)Detalle_de_Documentos_MPOData.Usuario_que_Registra_Spartan_User.Name
                    ,Tipo_de_Documento = Detalle_de_Documentos_MPOData.Tipo_de_Documento
                    ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Tipo_de_Documento), "Tipo_de_Documento") ??  (string)Detalle_de_Documentos_MPOData.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                    ,Documento = Detalle_de_Documentos_MPOData.Documento
                    ,DocumentoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Documento), "Documento") ??  (string)Detalle_de_Documentos_MPOData.Documento_Documento.Descripcion
                    ,Involucrado = Detalle_de_Documentos_MPOData.Involucrado
                    ,InvolucradoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Involucrado), "Detalle_de_Datos_Generales") ??  (string)Detalle_de_Documentos_MPOData.Involucrado_Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor
                    ,Probable_Responsable = Detalle_de_Documentos_MPOData.Probable_Responsable
                    ,Probable_ResponsableNombre_Completo_Detenido = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Probable_Responsable), "Detalle_de_Imputado") ??  (string)Detalle_de_Documentos_MPOData.Probable_Responsable_Detalle_de_Imputado.Nombre_Completo_Detenido
                    ,Archivo_Adjunto = Detalle_de_Documentos_MPOData.Archivo_Adjunto
                    ,Observaciones = Detalle_de_Documentos_MPOData.Observaciones
                    ,Archivo = Detalle_de_Documentos_MPOData.Archivo
                    ,Lista_para_periciales = Detalle_de_Documentos_MPOData.Lista_para_periciales.GetValueOrDefault()
                    ,Folio = Detalle_de_Documentos_MPOData.Folio
                    ,Expediente_MP = Detalle_de_Documentos_MPOData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Detalle_de_Documentos_MPOData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Descripcion = Detalle_de_Documentos_MPOData.Descripcion
                    ,Estatus_Persona = Detalle_de_Documentos_MPOData.Estatus_Persona
                    ,Estatus_PersonaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Estatus_Persona), "Estatus_Persona") ??  (string)Detalle_de_Documentos_MPOData.Estatus_Persona_Estatus_Persona.Descripcion
                    ,Fecha_Localizacion = (Detalle_de_Documentos_MPOData.Fecha_Localizacion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Documentos_MPOData.Fecha_Localizacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Localizacion = Detalle_de_Documentos_MPOData.Hora_Localizacion
                    ,Condiciones_de_Localizacion = Detalle_de_Documentos_MPOData.Condiciones_de_Localizacion
                    ,Condiciones_de_LocalizacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Condiciones_de_Localizacion), "Condiciones_de_Localizacion") ??  (string)Detalle_de_Documentos_MPOData.Condiciones_de_Localizacion_Condiciones_de_Localizacion.Descripcion
                    ,Lugar_de_Hallazgo = Detalle_de_Documentos_MPOData.Lugar_de_Hallazgo
                    ,Lugar_de_HallazgoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Lugar_de_Hallazgo), "Lugar_del_Hallazgo") ??  (string)Detalle_de_Documentos_MPOData.Lugar_de_Hallazgo_Lugar_del_Hallazgo.Descripcion
                    ,Posible_Causa_de_la_Desaparacion = Detalle_de_Documentos_MPOData.Posible_Causa_de_la_Desaparacion
                    ,Pais = Detalle_de_Documentos_MPOData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Pais), "Pais") ??  (string)Detalle_de_Documentos_MPOData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_Documentos_MPOData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Estado), "Estado") ??  (string)Detalle_de_Documentos_MPOData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Documentos_MPOData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Municipio), "Municipio") ??  (string)Detalle_de_Documentos_MPOData.Municipio_Municipio.Nombre
                    ,Poblacion = Detalle_de_Documentos_MPOData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Poblacion), "Colonia") ??  (string)Detalle_de_Documentos_MPOData.Poblacion_Colonia.Nombre
                    ,Colonia = Detalle_de_Documentos_MPOData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Colonia), "Colonia") ??  (string)Detalle_de_Documentos_MPOData.Colonia_Colonia.Nombre
                    ,Calle = Detalle_de_Documentos_MPOData.Calle
                    ,Numero_Interior = Detalle_de_Documentos_MPOData.Numero_Interior
                    ,Numero_Exterior = Detalle_de_Documentos_MPOData.Numero_Exterior
                    ,Codigo_Postal = Detalle_de_Documentos_MPOData.Codigo_Postal
                    ,Ente_que_localiza_al_no_localizado = Detalle_de_Documentos_MPOData.Ente_que_localiza_al_no_localizado
                    ,Ente_que_localiza_al_no_localizadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Documentos_MPOData.Ente_que_localiza_al_no_localizado), "Ente_que_localiza") ??  (string)Detalle_de_Documentos_MPOData.Ente_que_localiza_al_no_localizado_Ente_que_localiza.Descripcion
                    ,ente_Paterno = Detalle_de_Documentos_MPOData.ente_Paterno
                    ,ente_Materno = Detalle_de_Documentos_MPOData.ente_Materno
                    ,ente_Nombre = Detalle_de_Documentos_MPOData.ente_Nombre
                    ,Autoridad_que_conoce_el_hecho = Detalle_de_Documentos_MPOData.Autoridad_que_conoce_el_hecho
                    ,autoridad_Paterno = Detalle_de_Documentos_MPOData.autoridad_Paterno
                    ,autoridad_Materno = Detalle_de_Documentos_MPOData.autoridad_Materno
                    ,autoridad_Nombre = Detalle_de_Documentos_MPOData.autoridad_Nombre

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_AdjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Documentos_MPO.Archivo_Adjunto).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Documentos_Tipo_de_Documento = _ITipo_de_DocumentoApiConsumer.SelAll(true);
            if (Tipo_de_Documentos_Tipo_de_Documento != null && Tipo_de_Documentos_Tipo_de_Documento.Resource != null)
                ViewBag.Tipo_de_Documentos_Tipo_de_Documento = Tipo_de_Documentos_Tipo_de_Documento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var expediente_ministerio_publicos_Expediente_MP = _Iexpediente_ministerio_publicoApiConsumer.SelAll(true);
            if (expediente_ministerio_publicos_Expediente_MP != null && expediente_ministerio_publicos_Expediente_MP.Resource != null)
                ViewBag.expediente_ministerio_publicos_Expediente_MP = expediente_ministerio_publicos_Expediente_MP.Resource.Where(m => m.nic != null).OrderBy(m => m.nic).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "expediente_ministerio_publico", "nic") ?? m.nic.ToString(), Value = Convert.ToString(m.clave)
                }).ToList();
            _IEstatus_PersonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Personas_Estatus_Persona = _IEstatus_PersonaApiConsumer.SelAll(true);
            if (Estatus_Personas_Estatus_Persona != null && Estatus_Personas_Estatus_Persona.Resource != null)
                ViewBag.Estatus_Personas_Estatus_Persona = Estatus_Personas_Estatus_Persona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Persona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICondiciones_de_LocalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Condiciones_de_Localizacions_Condiciones_de_Localizacion = _ICondiciones_de_LocalizacionApiConsumer.SelAll(true);
            if (Condiciones_de_Localizacions_Condiciones_de_Localizacion != null && Condiciones_de_Localizacions_Condiciones_de_Localizacion.Resource != null)
                ViewBag.Condiciones_de_Localizacions_Condiciones_de_Localizacion = Condiciones_de_Localizacions_Condiciones_de_Localizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Condiciones_de_Localizacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_del_HallazgoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_del_Hallazgos_Lugar_de_Hallazgo = _ILugar_del_HallazgoApiConsumer.SelAll(true);
            if (Lugar_del_Hallazgos_Lugar_de_Hallazgo != null && Lugar_del_Hallazgos_Lugar_de_Hallazgo.Resource != null)
                ViewBag.Lugar_del_Hallazgos_Lugar_de_Hallazgo = Lugar_del_Hallazgos_Lugar_de_Hallazgo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_del_Hallazgo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais != null && Paiss_Pais.Resource != null)
                ViewBag.Paiss_Pais = Paiss_Pais.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado != null && Estados_Estado.Resource != null)
                ViewBag.Estados_Estado = Estados_Estado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
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
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Poblacion = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Poblacion != null && Colonias_Poblacion.Resource != null)
                ViewBag.Colonias_Poblacion = Colonias_Poblacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia != null && Colonias_Colonia.Resource != null)
                ViewBag.Colonias_Colonia = Colonias_Colonia.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEnte_que_localizaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ente_que_localizas_Ente_que_localiza_al_no_localizado = _IEnte_que_localizaApiConsumer.SelAll(true);
            if (Ente_que_localizas_Ente_que_localiza_al_no_localizado != null && Ente_que_localizas_Ente_que_localiza_al_no_localizado.Resource != null)
                ViewBag.Ente_que_localizas_Ente_que_localiza_al_no_localizado = Ente_que_localizas_Ente_que_localiza_al_no_localizado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ente_que_localiza", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Documentos_MPO", varDetalle_de_Documentos_MPO);
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
        public ActionResult GetModulo_Atencion_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModulo_Atencion_InicialApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT")?? m.NUAT,
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
        public ActionResult GetTipo_de_DocumentoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_DocumentoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Documento", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetDocumentoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDocumentoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetDetalle_de_Datos_GeneralesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre_Completo_del_Tutor).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_Completo_del_Tutor")?? m.Nombre_Completo_del_Tutor,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetDetalle_de_ImputadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_ImputadoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre_Completo_Detenido).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Imputado", "Nombre_Completo_Detenido")?? m.Nombre_Completo_Detenido,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult Getexpediente_ministerio_publicoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _Iexpediente_ministerio_publicoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.nic).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "expediente_ministerio_publico", "nic")?? m.nic,
                    Value = Convert.ToString(m.clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatus_PersonaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_PersonaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_PersonaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Persona", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCondiciones_de_LocalizacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICondiciones_de_LocalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICondiciones_de_LocalizacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Condiciones_de_Localizacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetLugar_del_HallazgoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILugar_del_HallazgoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILugar_del_HallazgoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_del_Hallazgo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetPaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre")?? m.Nombre,
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
        public ActionResult GetColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEnte_que_localizaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEnte_que_localizaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEnte_que_localizaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ente_que_localiza", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Detalle_de_Documentos_MPOAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Documentos_Tipo_de_Documento = _ITipo_de_DocumentoApiConsumer.SelAll(true);
            if (Tipo_de_Documentos_Tipo_de_Documento != null && Tipo_de_Documentos_Tipo_de_Documento.Resource != null)
                ViewBag.Tipo_de_Documentos_Tipo_de_Documento = Tipo_de_Documentos_Tipo_de_Documento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var expediente_ministerio_publicos_Expediente_MP = _Iexpediente_ministerio_publicoApiConsumer.SelAll(true);
            if (expediente_ministerio_publicos_Expediente_MP != null && expediente_ministerio_publicos_Expediente_MP.Resource != null)
                ViewBag.expediente_ministerio_publicos_Expediente_MP = expediente_ministerio_publicos_Expediente_MP.Resource.Where(m => m.nic != null).OrderBy(m => m.nic).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "expediente_ministerio_publico", "nic") ?? m.nic.ToString(), Value = Convert.ToString(m.clave)
                }).ToList();
            _IEstatus_PersonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Personas_Estatus_Persona = _IEstatus_PersonaApiConsumer.SelAll(true);
            if (Estatus_Personas_Estatus_Persona != null && Estatus_Personas_Estatus_Persona.Resource != null)
                ViewBag.Estatus_Personas_Estatus_Persona = Estatus_Personas_Estatus_Persona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Persona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICondiciones_de_LocalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Condiciones_de_Localizacions_Condiciones_de_Localizacion = _ICondiciones_de_LocalizacionApiConsumer.SelAll(true);
            if (Condiciones_de_Localizacions_Condiciones_de_Localizacion != null && Condiciones_de_Localizacions_Condiciones_de_Localizacion.Resource != null)
                ViewBag.Condiciones_de_Localizacions_Condiciones_de_Localizacion = Condiciones_de_Localizacions_Condiciones_de_Localizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Condiciones_de_Localizacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_del_HallazgoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_del_Hallazgos_Lugar_de_Hallazgo = _ILugar_del_HallazgoApiConsumer.SelAll(true);
            if (Lugar_del_Hallazgos_Lugar_de_Hallazgo != null && Lugar_del_Hallazgos_Lugar_de_Hallazgo.Resource != null)
                ViewBag.Lugar_del_Hallazgos_Lugar_de_Hallazgo = Lugar_del_Hallazgos_Lugar_de_Hallazgo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_del_Hallazgo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais != null && Paiss_Pais.Resource != null)
                ViewBag.Paiss_Pais = Paiss_Pais.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado != null && Estados_Estado.Resource != null)
                ViewBag.Estados_Estado = Estados_Estado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
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
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Poblacion = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Poblacion != null && Colonias_Poblacion.Resource != null)
                ViewBag.Colonias_Poblacion = Colonias_Poblacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia != null && Colonias_Colonia.Resource != null)
                ViewBag.Colonias_Colonia = Colonias_Colonia.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEnte_que_localizaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ente_que_localizas_Ente_que_localiza_al_no_localizado = _IEnte_que_localizaApiConsumer.SelAll(true);
            if (Ente_que_localizas_Ente_que_localiza_al_no_localizado != null && Ente_que_localizas_Ente_que_localiza_al_no_localizado.Resource != null)
                ViewBag.Ente_que_localizas_Ente_que_localiza_al_no_localizado = Ente_que_localizas_Ente_que_localiza_al_no_localizado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ente_que_localiza", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Documentos_Tipo_de_Documento = _ITipo_de_DocumentoApiConsumer.SelAll(true);
            if (Tipo_de_Documentos_Tipo_de_Documento != null && Tipo_de_Documentos_Tipo_de_Documento.Resource != null)
                ViewBag.Tipo_de_Documentos_Tipo_de_Documento = Tipo_de_Documentos_Tipo_de_Documento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var expediente_ministerio_publicos_Expediente_MP = _Iexpediente_ministerio_publicoApiConsumer.SelAll(true);
            if (expediente_ministerio_publicos_Expediente_MP != null && expediente_ministerio_publicos_Expediente_MP.Resource != null)
                ViewBag.expediente_ministerio_publicos_Expediente_MP = expediente_ministerio_publicos_Expediente_MP.Resource.Where(m => m.nic != null).OrderBy(m => m.nic).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "expediente_ministerio_publico", "nic") ?? m.nic.ToString(), Value = Convert.ToString(m.clave)
                }).ToList();
            _IEstatus_PersonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Personas_Estatus_Persona = _IEstatus_PersonaApiConsumer.SelAll(true);
            if (Estatus_Personas_Estatus_Persona != null && Estatus_Personas_Estatus_Persona.Resource != null)
                ViewBag.Estatus_Personas_Estatus_Persona = Estatus_Personas_Estatus_Persona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Persona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICondiciones_de_LocalizacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Condiciones_de_Localizacions_Condiciones_de_Localizacion = _ICondiciones_de_LocalizacionApiConsumer.SelAll(true);
            if (Condiciones_de_Localizacions_Condiciones_de_Localizacion != null && Condiciones_de_Localizacions_Condiciones_de_Localizacion.Resource != null)
                ViewBag.Condiciones_de_Localizacions_Condiciones_de_Localizacion = Condiciones_de_Localizacions_Condiciones_de_Localizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Condiciones_de_Localizacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_del_HallazgoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_del_Hallazgos_Lugar_de_Hallazgo = _ILugar_del_HallazgoApiConsumer.SelAll(true);
            if (Lugar_del_Hallazgos_Lugar_de_Hallazgo != null && Lugar_del_Hallazgos_Lugar_de_Hallazgo.Resource != null)
                ViewBag.Lugar_del_Hallazgos_Lugar_de_Hallazgo = Lugar_del_Hallazgos_Lugar_de_Hallazgo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_del_Hallazgo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais != null && Paiss_Pais.Resource != null)
                ViewBag.Paiss_Pais = Paiss_Pais.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado != null && Estados_Estado.Resource != null)
                ViewBag.Estados_Estado = Estados_Estado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
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
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Poblacion = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Poblacion != null && Colonias_Poblacion.Resource != null)
                ViewBag.Colonias_Poblacion = Colonias_Poblacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia != null && Colonias_Colonia.Resource != null)
                ViewBag.Colonias_Colonia = Colonias_Colonia.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEnte_que_localizaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ente_que_localizas_Ente_que_localiza_al_no_localizado = _IEnte_que_localizaApiConsumer.SelAll(true);
            if (Ente_que_localizas_Ente_que_localiza_al_no_localizado != null && Ente_que_localizas_Ente_que_localiza_al_no_localizado.Resource != null)
                ViewBag.Ente_que_localizas_Ente_que_localiza_al_no_localizado = Ente_que_localizas_Ente_que_localiza_al_no_localizado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ente_que_localiza", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Detalle_de_Documentos_MPOAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_de_Documentos_MPOAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_de_Documentos_MPOAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Documentos_MPOPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Documentos_MPOApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Documentos_MPOs == null)
                result.Detalle_de_Documentos_MPOs = new List<Detalle_de_Documentos_MPO>();

            return Json(new
            {
                data = result.Detalle_de_Documentos_MPOs.Select(m => new Detalle_de_Documentos_MPOGridModel
                    {
                    Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,DocumentoDescripcion = CultureHelper.GetTraduction(m.Documento_Documento.Clave.ToString(), "Documento") ?? (string)m.Documento_Documento.Descripcion
                        ,InvolucradoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(m.Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Involucrado_Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor
                        ,Probable_ResponsableNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Probable_Responsable_Detalle_de_Imputado.Nombre_Completo_Detenido
			,Archivo_Adjunto = m.Archivo_Adjunto
			,Observaciones = m.Observaciones
			,Archivo = m.Archivo
			,Lista_para_periciales = m.Lista_para_periciales
			,Folio = m.Folio
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "nic") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
			,Descripcion = m.Descripcion
                        ,Estatus_PersonaDescripcion = CultureHelper.GetTraduction(m.Estatus_Persona_Estatus_Persona.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Persona_Estatus_Persona.Descripcion
                        ,Fecha_Localizacion = (m.Fecha_Localizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Localizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_Localizacion = m.Hora_Localizacion
                        ,Condiciones_de_LocalizacionDescripcion = CultureHelper.GetTraduction(m.Condiciones_de_Localizacion_Condiciones_de_Localizacion.Clave.ToString(), "Descripcion") ?? (string)m.Condiciones_de_Localizacion_Condiciones_de_Localizacion.Descripcion
                        ,Lugar_de_HallazgoDescripcion = CultureHelper.GetTraduction(m.Lugar_de_Hallazgo_Lugar_del_Hallazgo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_Hallazgo_Lugar_del_Hallazgo.Descripcion
			,Posible_Causa_de_la_Desaparacion = m.Posible_Causa_de_la_Desaparacion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Interior = m.Numero_Interior
			,Numero_Exterior = m.Numero_Exterior
			,Codigo_Postal = m.Codigo_Postal
                        ,Ente_que_localiza_al_no_localizadoDescripcion = CultureHelper.GetTraduction(m.Ente_que_localiza_al_no_localizado_Ente_que_localiza.Clave.ToString(), "Descripcion") ?? (string)m.Ente_que_localiza_al_no_localizado_Ente_que_localiza.Descripcion
			,ente_Paterno = m.ente_Paterno
			,ente_Materno = m.ente_Materno
			,ente_Nombre = m.ente_Nombre
			,Autoridad_que_conoce_el_hecho = m.Autoridad_que_conoce_el_hecho
			,autoridad_Paterno = m.autoridad_Paterno
			,autoridad_Materno = m.autoridad_Materno
			,autoridad_Nombre = m.autoridad_Nombre

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_de_Documentos_MPOAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Documentos_MPOApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_de_Documentos_MPO", m.),
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
        /// Get List of Detalle_de_Documentos_MPO from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_de_Documentos_MPO Entity</returns>
        public ActionResult GetDetalle_de_Documentos_MPOList(UrlParametersModel param)
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
            _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_de_Documentos_MPOPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_de_Documentos_MPOAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_de_Documentos_MPOAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_de_Documentos_MPOPropertyMapper oDetalle_de_Documentos_MPOPropertyMapper = new Detalle_de_Documentos_MPOPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_de_Documentos_MPOPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_de_Documentos_MPOApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Documentos_MPOs == null)
                result.Detalle_de_Documentos_MPOs = new List<Detalle_de_Documentos_MPO>();

            return Json(new
            {
                aaData = result.Detalle_de_Documentos_MPOs.Select(m => new Detalle_de_Documentos_MPOGridModel
            {
                    Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,DocumentoDescripcion = CultureHelper.GetTraduction(m.Documento_Documento.Clave.ToString(), "Documento") ?? (string)m.Documento_Documento.Descripcion
                        ,InvolucradoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(m.Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Involucrado_Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor
                        ,Probable_ResponsableNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Probable_Responsable_Detalle_de_Imputado.Nombre_Completo_Detenido
			,Archivo_Adjunto = m.Archivo_Adjunto
			,Observaciones = m.Observaciones
			,Archivo = m.Archivo
			,Lista_para_periciales = m.Lista_para_periciales
			,Folio = m.Folio
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "nic") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
			,Descripcion = m.Descripcion
                        ,Estatus_PersonaDescripcion = CultureHelper.GetTraduction(m.Estatus_Persona_Estatus_Persona.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Persona_Estatus_Persona.Descripcion
                        ,Fecha_Localizacion = (m.Fecha_Localizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Localizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_Localizacion = m.Hora_Localizacion
                        ,Condiciones_de_LocalizacionDescripcion = CultureHelper.GetTraduction(m.Condiciones_de_Localizacion_Condiciones_de_Localizacion.Clave.ToString(), "Descripcion") ?? (string)m.Condiciones_de_Localizacion_Condiciones_de_Localizacion.Descripcion
                        ,Lugar_de_HallazgoDescripcion = CultureHelper.GetTraduction(m.Lugar_de_Hallazgo_Lugar_del_Hallazgo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_Hallazgo_Lugar_del_Hallazgo.Descripcion
			,Posible_Causa_de_la_Desaparacion = m.Posible_Causa_de_la_Desaparacion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Interior = m.Numero_Interior
			,Numero_Exterior = m.Numero_Exterior
			,Codigo_Postal = m.Codigo_Postal
                        ,Ente_que_localiza_al_no_localizadoDescripcion = CultureHelper.GetTraduction(m.Ente_que_localiza_al_no_localizado_Ente_que_localiza.Clave.ToString(), "Descripcion") ?? (string)m.Ente_que_localiza_al_no_localizado_Ente_que_localiza.Descripcion
			,ente_Paterno = m.ente_Paterno
			,ente_Materno = m.ente_Materno
			,ente_Nombre = m.ente_Nombre
			,Autoridad_que_conoce_el_hecho = m.Autoridad_que_conoce_el_hecho
			,autoridad_Paterno = m.autoridad_Paterno
			,autoridad_Materno = m.autoridad_Materno
			,autoridad_Nombre = m.autoridad_Nombre

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Documentos_MPO_Modulo_Atencion_Inicial_Modulo_Atencion_Inicial(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Modulo_Atencion_Inicial.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Modulo_Atencion_Inicial.NUAT as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IModulo_Atencion_InicialApiConsumer.ListaSelAll(1, 20,elWhere , " Modulo_Atencion_Inicial.NUAT ASC ").Resource;
               
                foreach (var item in result.Modulo_Atencion_Inicials)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Modulo_Atencion_Inicial", "NUAT");
                    item.NUAT =trans ??item.NUAT;
                }
                return Json(result.Modulo_Atencion_Inicials.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Documentos_MPO_Usuario_que_Registra_Spartan_User(string query, string where)
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
        [HttpGet]
        public JsonResult GetDetalle_de_Documentos_MPO_Documento_Documento(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Documento.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Documento.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDocumentoApiConsumer.ListaSelAll(1, 20,elWhere , " Documento.Descripcion ASC ").Resource;
               
                foreach (var item in result.Documentos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Documento", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Documentos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Documentos_MPO_Involucrado_Detalle_de_Datos_Generales(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Datos_Generales.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_Datos_GeneralesApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Datos_Generaless)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Datos_Generales", "Nombre_Completo_del_Tutor");
                    item.Nombre_Completo_del_Tutor =trans ??item.Nombre_Completo_del_Tutor;
                }
                return Json(result.Detalle_de_Datos_Generaless.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Documentos_MPO_Probable_Responsable_Detalle_de_Imputado(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Imputado.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Imputado.Nombre_Completo_Detenido as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_ImputadoApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Imputado.Nombre_Completo_Detenido ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Imputados)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Imputado", "Nombre_Completo_Detenido");
                    item.Nombre_Completo_Detenido =trans ??item.Nombre_Completo_Detenido;
                }
                return Json(result.Detalle_de_Imputados.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_Delitos_de_Documentos_Delito_Detalle_de_Delito(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Delito.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Delito.Descripcion_corta as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_DelitoApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Delito.Descripcion_corta ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Delitos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Delito", "Descripcion_corta");
                    item.Descripcion_corta =trans ??item.Descripcion_corta;
                }
                return Json(result.Detalle_de_Delitos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(Detalle_de_Documentos_MPOAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_de_Documentos_MPO.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_de_Documentos_MPO.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModulo_Atencion_Inicial))
            {
                switch (filter.Modulo_Atencion_InicialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '" + filter.AdvanceModulo_Atencion_Inicial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceModulo_Atencion_Inicial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.NUAT = '" + filter.AdvanceModulo_Atencion_Inicial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceModulo_Atencion_Inicial + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModulo_Atencion_InicialMultiple != null && filter.AdvanceModulo_Atencion_InicialMultiple.Count() > 0)
            {
                var Modulo_Atencion_InicialIds = string.Join(",", filter.AdvanceModulo_Atencion_InicialMultiple);

                where += " AND Detalle_de_Documentos_MPO.Modulo_Atencion_Inicial In (" + Modulo_Atencion_InicialIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha) || !string.IsNullOrEmpty(filter.ToFecha))
            {
                var FechaFrom = DateTime.ParseExact(filter.FromFecha, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var FechaTo = DateTime.ParseExact(filter.ToFecha, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha))
                    where += " AND Detalle_de_Documentos_MPO.Fecha >= '" + FechaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha))
                    where += " AND Detalle_de_Documentos_MPO.Fecha <= '" + FechaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora) || !string.IsNullOrEmpty(filter.ToHora))
            {
                if (!string.IsNullOrEmpty(filter.FromHora))
                    where += " AND Convert(TIME,Detalle_de_Documentos_MPO.Hora) >='" + filter.FromHora + "'";
                if (!string.IsNullOrEmpty(filter.ToHora))
                    where += " AND Convert(TIME,Detalle_de_Documentos_MPO.Hora) <='" + filter.ToHora + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Registra))
            {
                switch (filter.Usuario_que_RegistraFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Registra + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Registra + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Registra + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Registra + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_RegistraMultiple != null && filter.AdvanceUsuario_que_RegistraMultiple.Count() > 0)
            {
                var Usuario_que_RegistraIds = string.Join(",", filter.AdvanceUsuario_que_RegistraMultiple);

                where += " AND Detalle_de_Documentos_MPO.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Documento))
            {
                switch (filter.Tipo_de_DocumentoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Documento.Descripcion LIKE '" + filter.AdvanceTipo_de_Documento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Documento.Descripcion LIKE '%" + filter.AdvanceTipo_de_Documento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Documento.Descripcion = '" + filter.AdvanceTipo_de_Documento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Documento.Descripcion LIKE '%" + filter.AdvanceTipo_de_Documento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_DocumentoMultiple != null && filter.AdvanceTipo_de_DocumentoMultiple.Count() > 0)
            {
                var Tipo_de_DocumentoIds = string.Join(",", filter.AdvanceTipo_de_DocumentoMultiple);

                where += " AND Detalle_de_Documentos_MPO.Tipo_de_Documento In (" + Tipo_de_DocumentoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDocumento))
            {
                switch (filter.DocumentoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Documento.Descripcion LIKE '" + filter.AdvanceDocumento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Documento.Descripcion LIKE '%" + filter.AdvanceDocumento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Documento.Descripcion = '" + filter.AdvanceDocumento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Documento.Descripcion LIKE '%" + filter.AdvanceDocumento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDocumentoMultiple != null && filter.AdvanceDocumentoMultiple.Count() > 0)
            {
                var DocumentoIds = string.Join(",", filter.AdvanceDocumentoMultiple);

                where += " AND Detalle_de_Documentos_MPO.Documento In (" + DocumentoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceInvolucrado))
            {
                switch (filter.InvolucradoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor LIKE '" + filter.AdvanceInvolucrado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor LIKE '%" + filter.AdvanceInvolucrado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor = '" + filter.AdvanceInvolucrado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor LIKE '%" + filter.AdvanceInvolucrado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceInvolucradoMultiple != null && filter.AdvanceInvolucradoMultiple.Count() > 0)
            {
                var InvolucradoIds = string.Join(",", filter.AdvanceInvolucradoMultiple);

                where += " AND Detalle_de_Documentos_MPO.Involucrado In (" + InvolucradoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceProbable_Responsable))
            {
                switch (filter.Probable_ResponsableFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Imputado.Nombre_Completo_Detenido LIKE '" + filter.AdvanceProbable_Responsable + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Imputado.Nombre_Completo_Detenido LIKE '%" + filter.AdvanceProbable_Responsable + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Imputado.Nombre_Completo_Detenido = '" + filter.AdvanceProbable_Responsable + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Imputado.Nombre_Completo_Detenido LIKE '%" + filter.AdvanceProbable_Responsable + "%'";
                        break;
                }
            }
            else if (filter.AdvanceProbable_ResponsableMultiple != null && filter.AdvanceProbable_ResponsableMultiple.Count() > 0)
            {
                var Probable_ResponsableIds = string.Join(",", filter.AdvanceProbable_ResponsableMultiple);

                where += " AND Detalle_de_Documentos_MPO.Probable_Responsable In (" + Probable_ResponsableIds + ")";
            }

            if (filter.Archivo_Adjunto != RadioOptions.NoApply)
                where += " AND Detalle_de_Documentos_MPO.Archivo_Adjunto " + (filter.Archivo_Adjunto == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.Observaciones LIKE '%" + filter.Observaciones + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromArchivo) || !string.IsNullOrEmpty(filter.ToArchivo))
            {
                if (!string.IsNullOrEmpty(filter.FromArchivo))
                    where += " AND Detalle_de_Documentos_MPO.Archivo >= " + filter.FromArchivo;
                if (!string.IsNullOrEmpty(filter.ToArchivo))
                    where += " AND Detalle_de_Documentos_MPO.Archivo <= " + filter.ToArchivo;
            }

            if (filter.Lista_para_periciales != RadioOptions.NoApply)
                where += " AND Detalle_de_Documentos_MPO.Lista_para_periciales = " + Convert.ToInt32(filter.Lista_para_periciales);

            if (!string.IsNullOrEmpty(filter.Folio))
            {
                switch (filter.FolioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.Folio LIKE '" + filter.Folio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.Folio LIKE '%" + filter.Folio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.Folio = '" + filter.Folio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.Folio LIKE '%" + filter.Folio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceExpediente_MP))
            {
                switch (filter.Expediente_MPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '" + filter.AdvanceExpediente_MP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceExpediente_MP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.nic = '" + filter.AdvanceExpediente_MP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceExpediente_MP + "%'";
                        break;
                }
            }
            else if (filter.AdvanceExpediente_MPMultiple != null && filter.AdvanceExpediente_MPMultiple.Count() > 0)
            {
                var Expediente_MPIds = string.Join(",", filter.AdvanceExpediente_MPMultiple);

                where += " AND Detalle_de_Documentos_MPO.Expediente_MP In (" + Expediente_MPIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Descripcion))
            {
                switch (filter.DescripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.Descripcion LIKE '" + filter.Descripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.Descripcion LIKE '%" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.Descripcion = '" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.Descripcion LIKE '%" + filter.Descripcion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus_Persona))
            {
                switch (filter.Estatus_PersonaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_Persona.Descripcion LIKE '" + filter.AdvanceEstatus_Persona + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_Persona.Descripcion LIKE '%" + filter.AdvanceEstatus_Persona + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_Persona.Descripcion = '" + filter.AdvanceEstatus_Persona + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_Persona.Descripcion LIKE '%" + filter.AdvanceEstatus_Persona + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatus_PersonaMultiple != null && filter.AdvanceEstatus_PersonaMultiple.Count() > 0)
            {
                var Estatus_PersonaIds = string.Join(",", filter.AdvanceEstatus_PersonaMultiple);

                where += " AND Detalle_de_Documentos_MPO.Estatus_Persona In (" + Estatus_PersonaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Localizacion) || !string.IsNullOrEmpty(filter.ToFecha_Localizacion))
            {
                var Fecha_LocalizacionFrom = DateTime.ParseExact(filter.FromFecha_Localizacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_LocalizacionTo = DateTime.ParseExact(filter.ToFecha_Localizacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Localizacion))
                    where += " AND Detalle_de_Documentos_MPO.Fecha_Localizacion >= '" + Fecha_LocalizacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Localizacion))
                    where += " AND Detalle_de_Documentos_MPO.Fecha_Localizacion <= '" + Fecha_LocalizacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Localizacion) || !string.IsNullOrEmpty(filter.ToHora_Localizacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Localizacion))
                    where += " AND Convert(TIME,Detalle_de_Documentos_MPO.Hora_Localizacion) >='" + filter.FromHora_Localizacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Localizacion))
                    where += " AND Convert(TIME,Detalle_de_Documentos_MPO.Hora_Localizacion) <='" + filter.ToHora_Localizacion + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCondiciones_de_Localizacion))
            {
                switch (filter.Condiciones_de_LocalizacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Condiciones_de_Localizacion.Descripcion LIKE '" + filter.AdvanceCondiciones_de_Localizacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Condiciones_de_Localizacion.Descripcion LIKE '%" + filter.AdvanceCondiciones_de_Localizacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Condiciones_de_Localizacion.Descripcion = '" + filter.AdvanceCondiciones_de_Localizacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Condiciones_de_Localizacion.Descripcion LIKE '%" + filter.AdvanceCondiciones_de_Localizacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCondiciones_de_LocalizacionMultiple != null && filter.AdvanceCondiciones_de_LocalizacionMultiple.Count() > 0)
            {
                var Condiciones_de_LocalizacionIds = string.Join(",", filter.AdvanceCondiciones_de_LocalizacionMultiple);

                where += " AND Detalle_de_Documentos_MPO.Condiciones_de_Localizacion In (" + Condiciones_de_LocalizacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceLugar_de_Hallazgo))
            {
                switch (filter.Lugar_de_HallazgoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Lugar_del_Hallazgo.Descripcion LIKE '" + filter.AdvanceLugar_de_Hallazgo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Lugar_del_Hallazgo.Descripcion LIKE '%" + filter.AdvanceLugar_de_Hallazgo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Lugar_del_Hallazgo.Descripcion = '" + filter.AdvanceLugar_de_Hallazgo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Lugar_del_Hallazgo.Descripcion LIKE '%" + filter.AdvanceLugar_de_Hallazgo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceLugar_de_HallazgoMultiple != null && filter.AdvanceLugar_de_HallazgoMultiple.Count() > 0)
            {
                var Lugar_de_HallazgoIds = string.Join(",", filter.AdvanceLugar_de_HallazgoMultiple);

                where += " AND Detalle_de_Documentos_MPO.Lugar_de_Hallazgo In (" + Lugar_de_HallazgoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Posible_Causa_de_la_Desaparacion))
            {
                switch (filter.Posible_Causa_de_la_DesaparacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.Posible_Causa_de_la_Desaparacion LIKE '" + filter.Posible_Causa_de_la_Desaparacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.Posible_Causa_de_la_Desaparacion LIKE '%" + filter.Posible_Causa_de_la_Desaparacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.Posible_Causa_de_la_Desaparacion = '" + filter.Posible_Causa_de_la_Desaparacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.Posible_Causa_de_la_Desaparacion LIKE '%" + filter.Posible_Causa_de_la_Desaparacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais))
            {
                switch (filter.PaisFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais + "%'";
                        break;
                }
            }
            else if (filter.AdvancePaisMultiple != null && filter.AdvancePaisMultiple.Count() > 0)
            {
                var PaisIds = string.Join(",", filter.AdvancePaisMultiple);

                where += " AND Detalle_de_Documentos_MPO.Pais In (" + PaisIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado))
            {
                switch (filter.EstadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstadoMultiple != null && filter.AdvanceEstadoMultiple.Count() > 0)
            {
                var EstadoIds = string.Join(",", filter.AdvanceEstadoMultiple);

                where += " AND Detalle_de_Documentos_MPO.Estado In (" + EstadoIds + ")";
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

                where += " AND Detalle_de_Documentos_MPO.Municipio In (" + MunicipioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePoblacion))
            {
                switch (filter.PoblacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvancePoblacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvancePoblacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion + "%'";
                        break;
                }
            }
            else if (filter.AdvancePoblacionMultiple != null && filter.AdvancePoblacionMultiple.Count() > 0)
            {
                var PoblacionIds = string.Join(",", filter.AdvancePoblacionMultiple);

                where += " AND Detalle_de_Documentos_MPO.Poblacion In (" + PoblacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia))
            {
                switch (filter.ColoniaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColoniaMultiple != null && filter.AdvanceColoniaMultiple.Count() > 0)
            {
                var ColoniaIds = string.Join(",", filter.AdvanceColoniaMultiple);

                where += " AND Detalle_de_Documentos_MPO.Colonia In (" + ColoniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Calle))
            {
                switch (filter.CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.Calle LIKE '" + filter.Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.Calle LIKE '%" + filter.Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.Calle = '" + filter.Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.Calle LIKE '%" + filter.Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior))
            {
                switch (filter.Numero_InteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.Numero_Interior LIKE '" + filter.Numero_Interior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.Numero_Interior LIKE '%" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.Numero_Interior = '" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.Numero_Interior LIKE '%" + filter.Numero_Interior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior))
            {
                switch (filter.Numero_ExteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.Numero_Exterior LIKE '" + filter.Numero_Exterior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.Numero_Exterior = '" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal) || !string.IsNullOrEmpty(filter.ToCodigo_Postal))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal))
                    where += " AND Detalle_de_Documentos_MPO.Codigo_Postal >= " + filter.FromCodigo_Postal;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal))
                    where += " AND Detalle_de_Documentos_MPO.Codigo_Postal <= " + filter.ToCodigo_Postal;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEnte_que_localiza_al_no_localizado))
            {
                switch (filter.Ente_que_localiza_al_no_localizadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Ente_que_localiza.Descripcion LIKE '" + filter.AdvanceEnte_que_localiza_al_no_localizado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Ente_que_localiza.Descripcion LIKE '%" + filter.AdvanceEnte_que_localiza_al_no_localizado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Ente_que_localiza.Descripcion = '" + filter.AdvanceEnte_que_localiza_al_no_localizado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Ente_que_localiza.Descripcion LIKE '%" + filter.AdvanceEnte_que_localiza_al_no_localizado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEnte_que_localiza_al_no_localizadoMultiple != null && filter.AdvanceEnte_que_localiza_al_no_localizadoMultiple.Count() > 0)
            {
                var Ente_que_localiza_al_no_localizadoIds = string.Join(",", filter.AdvanceEnte_que_localiza_al_no_localizadoMultiple);

                where += " AND Detalle_de_Documentos_MPO.Ente_que_localiza_al_no_localizado In (" + Ente_que_localiza_al_no_localizadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.ente_Paterno))
            {
                switch (filter.ente_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.ente_Paterno LIKE '" + filter.ente_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.ente_Paterno LIKE '%" + filter.ente_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.ente_Paterno = '" + filter.ente_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.ente_Paterno LIKE '%" + filter.ente_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.ente_Materno))
            {
                switch (filter.ente_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.ente_Materno LIKE '" + filter.ente_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.ente_Materno LIKE '%" + filter.ente_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.ente_Materno = '" + filter.ente_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.ente_Materno LIKE '%" + filter.ente_Materno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.ente_Nombre))
            {
                switch (filter.ente_NombreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.ente_Nombre LIKE '" + filter.ente_Nombre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.ente_Nombre LIKE '%" + filter.ente_Nombre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.ente_Nombre = '" + filter.ente_Nombre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.ente_Nombre LIKE '%" + filter.ente_Nombre + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Autoridad_que_conoce_el_hecho))
            {
                switch (filter.Autoridad_que_conoce_el_hechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.Autoridad_que_conoce_el_hecho LIKE '" + filter.Autoridad_que_conoce_el_hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.Autoridad_que_conoce_el_hecho LIKE '%" + filter.Autoridad_que_conoce_el_hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.Autoridad_que_conoce_el_hecho = '" + filter.Autoridad_que_conoce_el_hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.Autoridad_que_conoce_el_hecho LIKE '%" + filter.Autoridad_que_conoce_el_hecho + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.autoridad_Paterno))
            {
                switch (filter.autoridad_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.autoridad_Paterno LIKE '" + filter.autoridad_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.autoridad_Paterno LIKE '%" + filter.autoridad_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.autoridad_Paterno = '" + filter.autoridad_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.autoridad_Paterno LIKE '%" + filter.autoridad_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.autoridad_Materno))
            {
                switch (filter.autoridad_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.autoridad_Materno LIKE '" + filter.autoridad_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.autoridad_Materno LIKE '%" + filter.autoridad_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.autoridad_Materno = '" + filter.autoridad_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.autoridad_Materno LIKE '%" + filter.autoridad_Materno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.autoridad_Nombre))
            {
                switch (filter.autoridad_NombreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.autoridad_Nombre LIKE '" + filter.autoridad_Nombre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.autoridad_Nombre LIKE '%" + filter.autoridad_Nombre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.autoridad_Nombre = '" + filter.autoridad_Nombre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.autoridad_Nombre LIKE '%" + filter.autoridad_Nombre + "%'";
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

        public ActionResult GetDetalle_Delitos_de_Documentos(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Delitos_de_DocumentosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Delitos_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Delitos_de_Documentos.IdDocumentos=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Delitos_de_Documentos.IdDocumentos='" + RelationId + "'";
            }
            var result = _IDetalle_Delitos_de_DocumentosApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Delitos_de_Documentoss == null)
                result.Detalle_Delitos_de_Documentoss = new List<Detalle_Delitos_de_Documentos>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Delitos_de_Documentoss.Select(m => new Detalle_Delitos_de_DocumentosGridModel
                {
                    Clave = m.Clave

                        ,Delito = m.Delito
                        ,DelitoDescripcion_corta = CultureHelper.GetTraduction(m.Delito_Detalle_de_Delito.Clave.ToString(), "Descripcion_corta") ??(string)m.Delito_Detalle_de_Delito.Descripcion_corta

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Delitos_de_DocumentosGridModel> GetDetalle_Delitos_de_DocumentosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Delitos_de_DocumentosGridModel> resultData = new List<Detalle_Delitos_de_DocumentosGridModel>();
            string where = "Detalle_Delitos_de_Documentos.IdDocumentos=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Delitos_de_Documentos.IdDocumentos='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Delitos_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Delitos_de_DocumentosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Delitos_de_Documentoss != null)
            {
                resultData = result.Detalle_Delitos_de_Documentoss.Select(m => new Detalle_Delitos_de_DocumentosGridModel
                    {
                        Clave = m.Clave

                        ,Delito = m.Delito
                        ,DelitoDescripcion_corta = CultureHelper.GetTraduction(m.Delito_Detalle_de_Delito.Clave.ToString(), "Descripcion_corta") ??(string)m.Delito_Detalle_de_Delito.Descripcion_corta


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Indicios_de_Diligencia(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Indicios_de_DiligenciaGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Indicios_de_DiligenciaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Indicios_de_Diligencia.Diligencia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Indicios_de_Diligencia.Diligencia='" + RelationId + "'";
            }
            var result = _IDetalle_de_Indicios_de_DiligenciaApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Indicios_de_Diligencias == null)
                result.Detalle_de_Indicios_de_Diligencias = new List<Detalle_de_Indicios_de_Diligencia>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Indicios_de_Diligencias.Select(m => new Detalle_de_Indicios_de_DiligenciaGridModel
                {
                    Folio = m.Folio

			,Indicio = m.Indicio
			,Seleccionar = m.Seleccionar
			,IndicioId = m.IndicioId

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Indicios_de_DiligenciaGridModel> GetDetalle_de_Indicios_de_DiligenciaData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Indicios_de_DiligenciaGridModel> resultData = new List<Detalle_de_Indicios_de_DiligenciaGridModel>();
            string where = "Detalle_de_Indicios_de_Diligencia.Diligencia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Indicios_de_Diligencia.Diligencia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Indicios_de_DiligenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Indicios_de_DiligenciaApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Indicios_de_Diligencias != null)
            {
                resultData = result.Detalle_de_Indicios_de_Diligencias.Select(m => new Detalle_de_Indicios_de_DiligenciaGridModel
                    {
                        Folio = m.Folio

			,Indicio = m.Indicio
			,Seleccionar = m.Seleccionar
			,IndicioId = m.IndicioId


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
                _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Documentos_MPO varDetalle_de_Documentos_MPO = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_Delitos_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Delitos_de_Documentos.IdDocumentos=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Delitos_de_Documentos.IdDocumentos='" + id + "'";
                    }
                    var Detalle_Delitos_de_DocumentosInfo =
                        _IDetalle_Delitos_de_DocumentosApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Delitos_de_DocumentosInfo.Detalle_Delitos_de_Documentoss.Count > 0)
                    {
                        var resultDetalle_Delitos_de_Documentos = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Delitos_de_DocumentosItem in Detalle_Delitos_de_DocumentosInfo.Detalle_Delitos_de_Documentoss)
                            resultDetalle_Delitos_de_Documentos = resultDetalle_Delitos_de_Documentos
                                              && _IDetalle_Delitos_de_DocumentosApiConsumer.Delete(Detalle_Delitos_de_DocumentosItem.Clave, null,null).Resource;

                        if (!resultDetalle_Delitos_de_Documentos)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Indicios_de_DiligenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Indicios_de_Diligencia.Diligencia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Indicios_de_Diligencia.Diligencia='" + id + "'";
                    }
                    var Detalle_de_Indicios_de_DiligenciaInfo =
                        _IDetalle_de_Indicios_de_DiligenciaApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Indicios_de_DiligenciaInfo.Detalle_de_Indicios_de_Diligencias.Count > 0)
                    {
                        var resultDetalle_de_Indicios_de_Diligencia = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Indicios_de_DiligenciaItem in Detalle_de_Indicios_de_DiligenciaInfo.Detalle_de_Indicios_de_Diligencias)
                            resultDetalle_de_Indicios_de_Diligencia = resultDetalle_de_Indicios_de_Diligencia
                                              && _IDetalle_de_Indicios_de_DiligenciaApiConsumer.Delete(Detalle_de_Indicios_de_DiligenciaItem.Folio, null,null).Resource;

                        if (!resultDetalle_de_Indicios_de_Diligencia)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IDetalle_de_Documentos_MPOApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Documentos_MPOModel varDetalle_de_Documentos_MPO)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varDetalle_de_Documentos_MPO.Archivo_AdjuntoRemoveAttachment != 0 && varDetalle_de_Documentos_MPO.Archivo_AdjuntoFile == null)
                    {
                        varDetalle_de_Documentos_MPO.Archivo_Adjunto = 0;
                    }

                    if (varDetalle_de_Documentos_MPO.Archivo_AdjuntoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Documentos_MPO.Archivo_AdjuntoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Documentos_MPO.Archivo_Adjunto = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Documentos_MPO.Archivo_AdjuntoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Detalle_de_Documentos_MPOInfo = new Detalle_de_Documentos_MPO
                    {
                        Clave = varDetalle_de_Documentos_MPO.Clave
                        ,Modulo_Atencion_Inicial = varDetalle_de_Documentos_MPO.Modulo_Atencion_Inicial
                        ,Fecha = (!String.IsNullOrEmpty(varDetalle_de_Documentos_MPO.Fecha)) ? DateTime.ParseExact(varDetalle_de_Documentos_MPO.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varDetalle_de_Documentos_MPO.Hora
                        ,Usuario_que_Registra = varDetalle_de_Documentos_MPO.Usuario_que_Registra
                        ,Tipo_de_Documento = varDetalle_de_Documentos_MPO.Tipo_de_Documento
                        ,Documento = varDetalle_de_Documentos_MPO.Documento
                        ,Involucrado = varDetalle_de_Documentos_MPO.Involucrado
                        ,Probable_Responsable = varDetalle_de_Documentos_MPO.Probable_Responsable
                        ,Archivo_Adjunto = (varDetalle_de_Documentos_MPO.Archivo_Adjunto.HasValue && varDetalle_de_Documentos_MPO.Archivo_Adjunto != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Documentos_MPO.Archivo_Adjunto.Value)) : null

                        ,Observaciones = varDetalle_de_Documentos_MPO.Observaciones
                        ,Archivo = varDetalle_de_Documentos_MPO.Archivo
                        ,Lista_para_periciales = varDetalle_de_Documentos_MPO.Lista_para_periciales
                        ,Folio = varDetalle_de_Documentos_MPO.Folio
                        ,Expediente_MP = varDetalle_de_Documentos_MPO.Expediente_MP
                        ,Descripcion = varDetalle_de_Documentos_MPO.Descripcion
                        ,Estatus_Persona = varDetalle_de_Documentos_MPO.Estatus_Persona
                        ,Fecha_Localizacion = (!String.IsNullOrEmpty(varDetalle_de_Documentos_MPO.Fecha_Localizacion)) ? DateTime.ParseExact(varDetalle_de_Documentos_MPO.Fecha_Localizacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Localizacion = varDetalle_de_Documentos_MPO.Hora_Localizacion
                        ,Condiciones_de_Localizacion = varDetalle_de_Documentos_MPO.Condiciones_de_Localizacion
                        ,Lugar_de_Hallazgo = varDetalle_de_Documentos_MPO.Lugar_de_Hallazgo
                        ,Posible_Causa_de_la_Desaparacion = varDetalle_de_Documentos_MPO.Posible_Causa_de_la_Desaparacion
                        ,Pais = varDetalle_de_Documentos_MPO.Pais
                        ,Estado = varDetalle_de_Documentos_MPO.Estado
                        ,Municipio = varDetalle_de_Documentos_MPO.Municipio
                        ,Poblacion = varDetalle_de_Documentos_MPO.Poblacion
                        ,Colonia = varDetalle_de_Documentos_MPO.Colonia
                        ,Calle = varDetalle_de_Documentos_MPO.Calle
                        ,Numero_Interior = varDetalle_de_Documentos_MPO.Numero_Interior
                        ,Numero_Exterior = varDetalle_de_Documentos_MPO.Numero_Exterior
                        ,Codigo_Postal = varDetalle_de_Documentos_MPO.Codigo_Postal
                        ,Ente_que_localiza_al_no_localizado = varDetalle_de_Documentos_MPO.Ente_que_localiza_al_no_localizado
                        ,ente_Paterno = varDetalle_de_Documentos_MPO.ente_Paterno
                        ,ente_Materno = varDetalle_de_Documentos_MPO.ente_Materno
                        ,ente_Nombre = varDetalle_de_Documentos_MPO.ente_Nombre
                        ,Autoridad_que_conoce_el_hecho = varDetalle_de_Documentos_MPO.Autoridad_que_conoce_el_hecho
                        ,autoridad_Paterno = varDetalle_de_Documentos_MPO.autoridad_Paterno
                        ,autoridad_Materno = varDetalle_de_Documentos_MPO.autoridad_Materno
                        ,autoridad_Nombre = varDetalle_de_Documentos_MPO.autoridad_Nombre

                    };

                    result = !IsNew ?
                        _IDetalle_de_Documentos_MPOApiConsumer.Update(Detalle_de_Documentos_MPOInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Documentos_MPOApiConsumer.Insert(Detalle_de_Documentos_MPOInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Delitos_de_Documentos(int MasterId, int referenceId, List<Detalle_Delitos_de_DocumentosGridModelPost> Detalle_Delitos_de_DocumentosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Delitos_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Delitos_de_DocumentosData = _IDetalle_Delitos_de_DocumentosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Delitos_de_Documentos.IdDocumentos=" + referenceId,"").Resource;
                if (Detalle_Delitos_de_DocumentosData == null || Detalle_Delitos_de_DocumentosData.Detalle_Delitos_de_Documentoss.Count == 0)
                    return true;

                var result = true;

                Detalle_Delitos_de_DocumentosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Delitos_de_Documentos in Detalle_Delitos_de_DocumentosData.Detalle_Delitos_de_Documentoss)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Delitos_de_Documentos Detalle_Delitos_de_Documentos1 = varDetalle_Delitos_de_Documentos;

                    if (Detalle_Delitos_de_DocumentosItems != null && Detalle_Delitos_de_DocumentosItems.Any(m => m.Clave == Detalle_Delitos_de_Documentos1.Clave))
                    {
                        modelDataToChange = Detalle_Delitos_de_DocumentosItems.FirstOrDefault(m => m.Clave == Detalle_Delitos_de_Documentos1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Delitos_de_Documentos.IdDocumentos = MasterId;
                    var insertId = _IDetalle_Delitos_de_DocumentosApiConsumer.Insert(varDetalle_Delitos_de_Documentos,null,null).Resource;
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
        public ActionResult PostDetalle_Delitos_de_Documentos(List<Detalle_Delitos_de_DocumentosGridModelPost> Detalle_Delitos_de_DocumentosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Delitos_de_Documentos(MasterId, referenceId, Detalle_Delitos_de_DocumentosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Delitos_de_DocumentosItems != null && Detalle_Delitos_de_DocumentosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Delitos_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Delitos_de_DocumentosItem in Detalle_Delitos_de_DocumentosItems)
                    {



                        //Removal Request
                        if (Detalle_Delitos_de_DocumentosItem.Removed)
                        {
                            result = result && _IDetalle_Delitos_de_DocumentosApiConsumer.Delete(Detalle_Delitos_de_DocumentosItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Delitos_de_DocumentosItem.Clave = 0;

                        var Detalle_Delitos_de_DocumentosData = new Detalle_Delitos_de_Documentos
                        {
                            IdDocumentos = MasterId
                            ,Clave = Detalle_Delitos_de_DocumentosItem.Clave
                            ,Delito = (Convert.ToInt32(Detalle_Delitos_de_DocumentosItem.Delito) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Delitos_de_DocumentosItem.Delito))

                        };

                        var resultId = Detalle_Delitos_de_DocumentosItem.Clave > 0
                           ? _IDetalle_Delitos_de_DocumentosApiConsumer.Update(Detalle_Delitos_de_DocumentosData,null,null).Resource
                           : _IDetalle_Delitos_de_DocumentosApiConsumer.Insert(Detalle_Delitos_de_DocumentosData,null,null).Resource;

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
        public ActionResult GetDetalle_Delitos_de_Documentos_Detalle_de_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_DelitoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Descripcion_corta= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Delito", "Descripcion_corta");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [NonAction]
        public bool CopyDetalle_de_Indicios_de_Diligencia(int MasterId, int referenceId, List<Detalle_de_Indicios_de_DiligenciaGridModelPost> Detalle_de_Indicios_de_DiligenciaItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Indicios_de_DiligenciaApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Indicios_de_DiligenciaData = _IDetalle_de_Indicios_de_DiligenciaApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Indicios_de_Diligencia.Diligencia=" + referenceId,"").Resource;
                if (Detalle_de_Indicios_de_DiligenciaData == null || Detalle_de_Indicios_de_DiligenciaData.Detalle_de_Indicios_de_Diligencias.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Indicios_de_DiligenciaGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Indicios_de_Diligencia in Detalle_de_Indicios_de_DiligenciaData.Detalle_de_Indicios_de_Diligencias)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Indicios_de_Diligencia Detalle_de_Indicios_de_Diligencia1 = varDetalle_de_Indicios_de_Diligencia;

                    if (Detalle_de_Indicios_de_DiligenciaItems != null && Detalle_de_Indicios_de_DiligenciaItems.Any(m => m.Folio == Detalle_de_Indicios_de_Diligencia1.Folio))
                    {
                        modelDataToChange = Detalle_de_Indicios_de_DiligenciaItems.FirstOrDefault(m => m.Folio == Detalle_de_Indicios_de_Diligencia1.Folio);
                    }
                    //Chaning Id Value
                    varDetalle_de_Indicios_de_Diligencia.Diligencia = MasterId;
                    var insertId = _IDetalle_de_Indicios_de_DiligenciaApiConsumer.Insert(varDetalle_de_Indicios_de_Diligencia,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Folio = insertId;

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
        public ActionResult PostDetalle_de_Indicios_de_Diligencia(List<Detalle_de_Indicios_de_DiligenciaGridModelPost> Detalle_de_Indicios_de_DiligenciaItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Indicios_de_Diligencia(MasterId, referenceId, Detalle_de_Indicios_de_DiligenciaItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Indicios_de_DiligenciaItems != null && Detalle_de_Indicios_de_DiligenciaItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Indicios_de_DiligenciaApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Indicios_de_DiligenciaItem in Detalle_de_Indicios_de_DiligenciaItems)
                    {





                        //Removal Request
                        if (Detalle_de_Indicios_de_DiligenciaItem.Removed)
                        {
                            result = result && _IDetalle_de_Indicios_de_DiligenciaApiConsumer.Delete(Detalle_de_Indicios_de_DiligenciaItem.Folio, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Indicios_de_DiligenciaItem.Folio = 0;

                        var Detalle_de_Indicios_de_DiligenciaData = new Detalle_de_Indicios_de_Diligencia
                        {
                            Diligencia = MasterId
                            ,Folio = Detalle_de_Indicios_de_DiligenciaItem.Folio
                            ,Indicio = Detalle_de_Indicios_de_DiligenciaItem.Indicio
                            ,Seleccionar = Detalle_de_Indicios_de_DiligenciaItem.Seleccionar
                            ,IndicioId = Detalle_de_Indicios_de_DiligenciaItem.IndicioId

                        };

                        var resultId = Detalle_de_Indicios_de_DiligenciaItem.Folio > 0
                           ? _IDetalle_de_Indicios_de_DiligenciaApiConsumer.Update(Detalle_de_Indicios_de_DiligenciaData,null,null).Resource
                           : _IDetalle_de_Indicios_de_DiligenciaApiConsumer.Insert(Detalle_de_Indicios_de_DiligenciaData,null,null).Resource;

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
        /// Write Element Array of Detalle_de_Documentos_MPO script
        /// </summary>
        /// <param name="oDetalle_de_Documentos_MPOElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_de_Documentos_MPOModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Documentos_MPOModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Documentos_MPOModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Documentos_MPOModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Documentos_MPOModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Documentos_MPOModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Documentos_MPOModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Documentos_MPOModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_de_Documentos_MPOModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_de_Documentos_MPOModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_de_Documentos_MPOModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_de_Documentos_MPOModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_de_Documentos_MPOModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_de_Documentos_MPOScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Documentos_MPO.js")))
            {
                strDetalle_de_Documentos_MPOScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Documentos_MPO element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Documentos_MPOModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Documentos_MPOScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Documentos_MPOScript.Substring(indexOfArray, strDetalle_de_Documentos_MPOScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Documentos_MPOModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Documentos_MPOModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Documentos_MPOScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_de_Documentos_MPOScript.Substring(indexOfArrayHistory, strDetalle_de_Documentos_MPOScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_de_Documentos_MPOScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Documentos_MPOScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Documentos_MPOScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_de_Documentos_MPOModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_de_Documentos_MPOModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Documentos_MPO.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Documentos_MPO.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Documentos_MPO.js")))
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
        public ActionResult Detalle_de_Documentos_MPOPropertyBag()
        {
            return PartialView("Detalle_de_Documentos_MPOPropertyBag", "Detalle_de_Documentos_MPO");
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
        public ActionResult AddDetalle_Delitos_de_Documentos(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Delitos_de_Documentos/AddDetalle_Delitos_de_Documentos");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Indicios_de_Diligencia(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Indicios_de_Diligencia/AddDetalle_de_Indicios_de_Diligencia");
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
                var whereClauseFormat = "Object = 45109 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_de_Documentos_MPO.Clave= " + RecordId;
                            var result = _IDetalle_de_Documentos_MPOApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Documentos_MPOPropertyMapper());
			
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
                    (Detalle_de_Documentos_MPOAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_de_Documentos_MPOPropertyMapper oDetalle_de_Documentos_MPOPropertyMapper = new Detalle_de_Documentos_MPOPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Documentos_MPOPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Documentos_MPOApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Documentos_MPOs == null)
                result.Detalle_de_Documentos_MPOs = new List<Detalle_de_Documentos_MPO>();

            var data = result.Detalle_de_Documentos_MPOs.Select(m => new Detalle_de_Documentos_MPOGridModel
            {
                Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,DocumentoDescripcion = CultureHelper.GetTraduction(m.Documento_Documento.Clave.ToString(), "Documento") ?? (string)m.Documento_Documento.Descripcion
                        ,InvolucradoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(m.Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Involucrado_Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor
                        ,Probable_ResponsableNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Probable_Responsable_Detalle_de_Imputado.Nombre_Completo_Detenido
			,Archivo_Adjunto = m.Archivo_Adjunto
			,Observaciones = m.Observaciones
			,Archivo = m.Archivo
			,Lista_para_periciales = m.Lista_para_periciales
			,Folio = m.Folio
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "nic") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
			,Descripcion = m.Descripcion
                        ,Estatus_PersonaDescripcion = CultureHelper.GetTraduction(m.Estatus_Persona_Estatus_Persona.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Persona_Estatus_Persona.Descripcion
                        ,Fecha_Localizacion = (m.Fecha_Localizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Localizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_Localizacion = m.Hora_Localizacion
                        ,Condiciones_de_LocalizacionDescripcion = CultureHelper.GetTraduction(m.Condiciones_de_Localizacion_Condiciones_de_Localizacion.Clave.ToString(), "Descripcion") ?? (string)m.Condiciones_de_Localizacion_Condiciones_de_Localizacion.Descripcion
                        ,Lugar_de_HallazgoDescripcion = CultureHelper.GetTraduction(m.Lugar_de_Hallazgo_Lugar_del_Hallazgo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_Hallazgo_Lugar_del_Hallazgo.Descripcion
			,Posible_Causa_de_la_Desaparacion = m.Posible_Causa_de_la_Desaparacion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Interior = m.Numero_Interior
			,Numero_Exterior = m.Numero_Exterior
			,Codigo_Postal = m.Codigo_Postal
                        ,Ente_que_localiza_al_no_localizadoDescripcion = CultureHelper.GetTraduction(m.Ente_que_localiza_al_no_localizado_Ente_que_localiza.Clave.ToString(), "Descripcion") ?? (string)m.Ente_que_localiza_al_no_localizado_Ente_que_localiza.Descripcion
			,ente_Paterno = m.ente_Paterno
			,ente_Materno = m.ente_Materno
			,ente_Nombre = m.ente_Nombre
			,Autoridad_que_conoce_el_hecho = m.Autoridad_que_conoce_el_hecho
			,autoridad_Paterno = m.autoridad_Paterno
			,autoridad_Materno = m.autoridad_Materno
			,autoridad_Nombre = m.autoridad_Nombre

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45109, arrayColumnsVisible), "Detalle_de_Documentos_MPOList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45109, arrayColumnsVisible), "Detalle_de_Documentos_MPOList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45109, arrayColumnsVisible), "Detalle_de_Documentos_MPOList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Documentos_MPOPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_de_Documentos_MPOAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_de_Documentos_MPOPropertyMapper oDetalle_de_Documentos_MPOPropertyMapper = new Detalle_de_Documentos_MPOPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Documentos_MPOPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Documentos_MPOApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Documentos_MPOs == null)
                result.Detalle_de_Documentos_MPOs = new List<Detalle_de_Documentos_MPO>();

            var data = result.Detalle_de_Documentos_MPOs.Select(m => new Detalle_de_Documentos_MPOGridModel
            {
                Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,DocumentoDescripcion = CultureHelper.GetTraduction(m.Documento_Documento.Clave.ToString(), "Documento") ?? (string)m.Documento_Documento.Descripcion
                        ,InvolucradoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(m.Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Involucrado_Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor
                        ,Probable_ResponsableNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Probable_Responsable_Detalle_de_Imputado.Nombre_Completo_Detenido
			,Archivo_Adjunto = m.Archivo_Adjunto
			,Observaciones = m.Observaciones
			,Archivo = m.Archivo
			,Lista_para_periciales = m.Lista_para_periciales
			,Folio = m.Folio
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "nic") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
			,Descripcion = m.Descripcion
                        ,Estatus_PersonaDescripcion = CultureHelper.GetTraduction(m.Estatus_Persona_Estatus_Persona.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Persona_Estatus_Persona.Descripcion
                        ,Fecha_Localizacion = (m.Fecha_Localizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Localizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_Localizacion = m.Hora_Localizacion
                        ,Condiciones_de_LocalizacionDescripcion = CultureHelper.GetTraduction(m.Condiciones_de_Localizacion_Condiciones_de_Localizacion.Clave.ToString(), "Descripcion") ?? (string)m.Condiciones_de_Localizacion_Condiciones_de_Localizacion.Descripcion
                        ,Lugar_de_HallazgoDescripcion = CultureHelper.GetTraduction(m.Lugar_de_Hallazgo_Lugar_del_Hallazgo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_Hallazgo_Lugar_del_Hallazgo.Descripcion
			,Posible_Causa_de_la_Desaparacion = m.Posible_Causa_de_la_Desaparacion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Interior = m.Numero_Interior
			,Numero_Exterior = m.Numero_Exterior
			,Codigo_Postal = m.Codigo_Postal
                        ,Ente_que_localiza_al_no_localizadoDescripcion = CultureHelper.GetTraduction(m.Ente_que_localiza_al_no_localizado_Ente_que_localiza.Clave.ToString(), "Descripcion") ?? (string)m.Ente_que_localiza_al_no_localizado_Ente_que_localiza.Descripcion
			,ente_Paterno = m.ente_Paterno
			,ente_Materno = m.ente_Materno
			,ente_Nombre = m.ente_Nombre
			,Autoridad_que_conoce_el_hecho = m.Autoridad_que_conoce_el_hecho
			,autoridad_Paterno = m.autoridad_Paterno
			,autoridad_Materno = m.autoridad_Materno
			,autoridad_Nombre = m.autoridad_Nombre

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
                _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Documentos_MPOApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_de_Documentos_MPO_Datos_GeneralesModel varDetalle_de_Documentos_MPO)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varDetalle_de_Documentos_MPO.Archivo_AdjuntoRemoveAttachment != 0 && varDetalle_de_Documentos_MPO.Archivo_AdjuntoFile == null)
                    {
                        varDetalle_de_Documentos_MPO.Archivo_Adjunto = 0;
                    }

                    if (varDetalle_de_Documentos_MPO.Archivo_AdjuntoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Documentos_MPO.Archivo_AdjuntoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Documentos_MPO.Archivo_Adjunto = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Documentos_MPO.Archivo_AdjuntoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Detalle_de_Documentos_MPO_Datos_GeneralesInfo = new Detalle_de_Documentos_MPO_Datos_Generales
                {
                    Clave = varDetalle_de_Documentos_MPO.Clave
                                            ,Modulo_Atencion_Inicial = varDetalle_de_Documentos_MPO.Modulo_Atencion_Inicial
                        ,Fecha = (!String.IsNullOrEmpty(varDetalle_de_Documentos_MPO.Fecha)) ? DateTime.ParseExact(varDetalle_de_Documentos_MPO.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varDetalle_de_Documentos_MPO.Hora
                        ,Usuario_que_Registra = varDetalle_de_Documentos_MPO.Usuario_que_Registra
                        ,Tipo_de_Documento = varDetalle_de_Documentos_MPO.Tipo_de_Documento
                        ,Documento = varDetalle_de_Documentos_MPO.Documento
                        ,Involucrado = varDetalle_de_Documentos_MPO.Involucrado
                        ,Probable_Responsable = varDetalle_de_Documentos_MPO.Probable_Responsable
                        ,Archivo_Adjunto = (varDetalle_de_Documentos_MPO.Archivo_Adjunto.HasValue && varDetalle_de_Documentos_MPO.Archivo_Adjunto != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Documentos_MPO.Archivo_Adjunto.Value)) : null

                        ,Observaciones = varDetalle_de_Documentos_MPO.Observaciones
                        ,Archivo = varDetalle_de_Documentos_MPO.Archivo
                        ,Lista_para_periciales = varDetalle_de_Documentos_MPO.Lista_para_periciales
                        ,Folio = varDetalle_de_Documentos_MPO.Folio
                        ,Expediente_MP = varDetalle_de_Documentos_MPO.Expediente_MP
                        ,Descripcion = varDetalle_de_Documentos_MPO.Descripcion
                    
                };

                result = _IDetalle_de_Documentos_MPOApiConsumer.Update_Datos_Generales(Detalle_de_Documentos_MPO_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Documentos_MPOApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Delitos_de_Documentos;
                var Detalle_Delitos_de_DocumentosData = GetDetalle_Delitos_de_DocumentosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Delitos_de_Documentos);
                int RowCount_Detalle_de_Indicios_de_Diligencia;
                var Detalle_de_Indicios_de_DiligenciaData = GetDetalle_de_Indicios_de_DiligenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios_de_Diligencia);

                var result = new Detalle_de_Documentos_MPO_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Modulo_Atencion_Inicial = m.Modulo_Atencion_Inicial
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_Documento = m.Tipo_de_Documento
                        ,Tipo_de_DocumentoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Documento_Tipo_de_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Documento_Tipo_de_Documento.Descripcion
                        ,Documento = m.Documento
                        ,DocumentoDescripcion = CultureHelper.GetTraduction(m.Documento_Documento.Clave.ToString(), "Documento") ?? (string)m.Documento_Documento.Descripcion
                        ,Involucrado = m.Involucrado
                        ,InvolucradoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(m.Involucrado_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Involucrado_Detalle_de_Datos_Generales.Nombre_Completo_del_Tutor
                        ,Probable_Responsable = m.Probable_Responsable
                        ,Probable_ResponsableNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Probable_Responsable_Detalle_de_Imputado.Nombre_Completo_Detenido
			,Archivo_Adjunto = m.Archivo_Adjunto
			,Observaciones = m.Observaciones
			,Archivo = m.Archivo
			,Lista_para_periciales = m.Lista_para_periciales
			,Folio = m.Folio
                        ,Expediente_MP = m.Expediente_MP
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "nic") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
			,Descripcion = m.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Delito = Detalle_Delitos_de_DocumentosData
                    ,Indicios_a_enviar = Detalle_de_Indicios_de_DiligenciaData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Localizacion(Detalle_de_Documentos_MPO_LocalizacionModel varDetalle_de_Documentos_MPO)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Documentos_MPO_LocalizacionInfo = new Detalle_de_Documentos_MPO_Localizacion
                {
                    Clave = varDetalle_de_Documentos_MPO.Clave
                                            ,Estatus_Persona = varDetalle_de_Documentos_MPO.Estatus_Persona
                        ,Fecha_Localizacion = (!String.IsNullOrEmpty(varDetalle_de_Documentos_MPO.Fecha_Localizacion)) ? DateTime.ParseExact(varDetalle_de_Documentos_MPO.Fecha_Localizacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Localizacion = varDetalle_de_Documentos_MPO.Hora_Localizacion
                        ,Condiciones_de_Localizacion = varDetalle_de_Documentos_MPO.Condiciones_de_Localizacion
                        ,Lugar_de_Hallazgo = varDetalle_de_Documentos_MPO.Lugar_de_Hallazgo
                        ,Posible_Causa_de_la_Desaparacion = varDetalle_de_Documentos_MPO.Posible_Causa_de_la_Desaparacion
                        ,Pais = varDetalle_de_Documentos_MPO.Pais
                        ,Estado = varDetalle_de_Documentos_MPO.Estado
                        ,Municipio = varDetalle_de_Documentos_MPO.Municipio
                        ,Poblacion = varDetalle_de_Documentos_MPO.Poblacion
                        ,Colonia = varDetalle_de_Documentos_MPO.Colonia
                        ,Calle = varDetalle_de_Documentos_MPO.Calle
                        ,Numero_Interior = varDetalle_de_Documentos_MPO.Numero_Interior
                        ,Numero_Exterior = varDetalle_de_Documentos_MPO.Numero_Exterior
                        ,Codigo_Postal = varDetalle_de_Documentos_MPO.Codigo_Postal
                    
                };

                result = _IDetalle_de_Documentos_MPOApiConsumer.Update_Localizacion(Detalle_de_Documentos_MPO_LocalizacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Localizacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Documentos_MPOApiConsumer.Get_Localizacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Delitos_de_Documentos;
                var Detalle_Delitos_de_DocumentosData = GetDetalle_Delitos_de_DocumentosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Delitos_de_Documentos);
                int RowCount_Detalle_de_Indicios_de_Diligencia;
                var Detalle_de_Indicios_de_DiligenciaData = GetDetalle_de_Indicios_de_DiligenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios_de_Diligencia);

                var result = new Detalle_de_Documentos_MPO_LocalizacionModel
                {
                    Clave = m.Clave
                        ,Estatus_Persona = m.Estatus_Persona
                        ,Estatus_PersonaDescripcion = CultureHelper.GetTraduction(m.Estatus_Persona_Estatus_Persona.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Persona_Estatus_Persona.Descripcion
                        ,Fecha_Localizacion = (m.Fecha_Localizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_Localizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_Localizacion = m.Hora_Localizacion
                        ,Condiciones_de_Localizacion = m.Condiciones_de_Localizacion
                        ,Condiciones_de_LocalizacionDescripcion = CultureHelper.GetTraduction(m.Condiciones_de_Localizacion_Condiciones_de_Localizacion.Clave.ToString(), "Descripcion") ?? (string)m.Condiciones_de_Localizacion_Condiciones_de_Localizacion.Descripcion
                        ,Lugar_de_Hallazgo = m.Lugar_de_Hallazgo
                        ,Lugar_de_HallazgoDescripcion = CultureHelper.GetTraduction(m.Lugar_de_Hallazgo_Lugar_del_Hallazgo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_Hallazgo_Lugar_del_Hallazgo.Descripcion
			,Posible_Causa_de_la_Desaparacion = m.Posible_Causa_de_la_Desaparacion
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Interior = m.Numero_Interior
			,Numero_Exterior = m.Numero_Exterior
			,Codigo_Postal = m.Codigo_Postal

                    
                };
				var resultData = new
                {
                    data = result
                    ,Delito = Detalle_Delitos_de_DocumentosData
                    ,Indicios_a_enviar = Detalle_de_Indicios_de_DiligenciaData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Ente_y_Autoridad(Detalle_de_Documentos_MPO_Ente_y_AutoridadModel varDetalle_de_Documentos_MPO)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Documentos_MPO_Ente_y_AutoridadInfo = new Detalle_de_Documentos_MPO_Ente_y_Autoridad
                {
                    Clave = varDetalle_de_Documentos_MPO.Clave
                                            ,Ente_que_localiza_al_no_localizado = varDetalle_de_Documentos_MPO.Ente_que_localiza_al_no_localizado
                        ,ente_Paterno = varDetalle_de_Documentos_MPO.ente_Paterno
                        ,ente_Materno = varDetalle_de_Documentos_MPO.ente_Materno
                        ,ente_Nombre = varDetalle_de_Documentos_MPO.ente_Nombre
                        ,Autoridad_que_conoce_el_hecho = varDetalle_de_Documentos_MPO.Autoridad_que_conoce_el_hecho
                        ,autoridad_Paterno = varDetalle_de_Documentos_MPO.autoridad_Paterno
                        ,autoridad_Materno = varDetalle_de_Documentos_MPO.autoridad_Materno
                        ,autoridad_Nombre = varDetalle_de_Documentos_MPO.autoridad_Nombre
                    
                };

                result = _IDetalle_de_Documentos_MPOApiConsumer.Update_Ente_y_Autoridad(Detalle_de_Documentos_MPO_Ente_y_AutoridadInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Ente_y_Autoridad(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Documentos_MPOApiConsumer.Get_Ente_y_Autoridad(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Delitos_de_Documentos;
                var Detalle_Delitos_de_DocumentosData = GetDetalle_Delitos_de_DocumentosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Delitos_de_Documentos);
                int RowCount_Detalle_de_Indicios_de_Diligencia;
                var Detalle_de_Indicios_de_DiligenciaData = GetDetalle_de_Indicios_de_DiligenciaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Indicios_de_Diligencia);

                var result = new Detalle_de_Documentos_MPO_Ente_y_AutoridadModel
                {
                    Clave = m.Clave
                        ,Ente_que_localiza_al_no_localizado = m.Ente_que_localiza_al_no_localizado
                        ,Ente_que_localiza_al_no_localizadoDescripcion = CultureHelper.GetTraduction(m.Ente_que_localiza_al_no_localizado_Ente_que_localiza.Clave.ToString(), "Descripcion") ?? (string)m.Ente_que_localiza_al_no_localizado_Ente_que_localiza.Descripcion
			,ente_Paterno = m.ente_Paterno
			,ente_Materno = m.ente_Materno
			,ente_Nombre = m.ente_Nombre
			,Autoridad_que_conoce_el_hecho = m.Autoridad_que_conoce_el_hecho
			,autoridad_Paterno = m.autoridad_Paterno
			,autoridad_Materno = m.autoridad_Materno
			,autoridad_Nombre = m.autoridad_Nombre

                    
                };
				var resultData = new
                {
                    data = result
                    ,Delito = Detalle_Delitos_de_DocumentosData
                    ,Indicios_a_enviar = Detalle_de_Indicios_de_DiligenciaData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

