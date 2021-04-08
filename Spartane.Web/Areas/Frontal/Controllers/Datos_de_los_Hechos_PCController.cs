using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Datos_de_los_Hechos_PC;
using Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Core.Domain.Respuesta;
using Spartane.Core.Domain.Respuesta;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Direccion_Exacta;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Datos_de_los_Hechos_PC;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Datos_de_los_Hechos_PC;
using Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Web.Areas.WebApiConsumer.Respuesta;
using Spartane.Web.Areas.WebApiConsumer.Respuesta;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Direccion_Exacta;

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
    public class Datos_de_los_Hechos_PCController : Controller
    {
        #region "variable declaration"

        private IDatos_de_los_Hechos_PCService service = null;
        private IDatos_de_los_Hechos_PCApiConsumer _IDatos_de_los_Hechos_PCApiConsumer;
        private ISolicitud_de_Denuncia_CiudadanaApiConsumer _ISolicitud_de_Denuncia_CiudadanaApiConsumer;
        private IRespuestaApiConsumer _IRespuestaApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IDireccion_ExactaApiConsumer _IDireccion_ExactaApiConsumer;

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

        
        public Datos_de_los_Hechos_PCController(IDatos_de_los_Hechos_PCService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDatos_de_los_Hechos_PCApiConsumer Datos_de_los_Hechos_PCApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISolicitud_de_Denuncia_CiudadanaApiConsumer Solicitud_de_Denuncia_CiudadanaApiConsumer , IRespuestaApiConsumer RespuestaApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IDireccion_ExactaApiConsumer Direccion_ExactaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDatos_de_los_Hechos_PCApiConsumer = Datos_de_los_Hechos_PCApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ISolicitud_de_Denuncia_CiudadanaApiConsumer = Solicitud_de_Denuncia_CiudadanaApiConsumer;
            this._IRespuestaApiConsumer = RespuestaApiConsumer;
            this._IRespuestaApiConsumer = RespuestaApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IDireccion_ExactaApiConsumer = Direccion_ExactaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Datos_de_los_Hechos_PC
        [ObjectAuth(ObjectId = (ModuleObjectId)45711, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45711, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Datos_de_los_Hechos_PC/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45711, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45711, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDatos_de_los_Hechos_PC = new Datos_de_los_Hechos_PCModel();
			varDatos_de_los_Hechos_PC.Clave = Id;
			
            ViewBag.ObjectId = "45711";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDatos_de_los_Hechos_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Datos_de_los_Hechos_PCsData = _IDatos_de_los_Hechos_PCApiConsumer.ListaSelAll(0, 1000, "Datos_de_los_Hechos_PC.Clave=" + Id, "").Resource.Datos_de_los_Hechos_PCs;
				
				if (Datos_de_los_Hechos_PCsData != null && Datos_de_los_Hechos_PCsData.Count > 0)
                {
					var Datos_de_los_Hechos_PCData = Datos_de_los_Hechos_PCsData.First();
					varDatos_de_los_Hechos_PC= new Datos_de_los_Hechos_PCModel
					{
						Clave  = Datos_de_los_Hechos_PCData.Clave 
	                    ,Solicitud = Datos_de_los_Hechos_PCData.Solicitud
                    ,SolicitudFolio = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Solicitud), "Solicitud_de_Denuncia_Ciudadana") ??  (string)Datos_de_los_Hechos_PCData.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                    ,Titulo_del_Hecho = Datos_de_los_Hechos_PCData.Titulo_del_Hecho
                    ,Narrativa_Breve_de_los_Hechos = Datos_de_los_Hechos_PCData.Narrativa_Breve_de_los_Hechos
                    ,Fecha_del_Hecho = (Datos_de_los_Hechos_PCData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Datos_de_los_Hechos_PCData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Aproximada_del_Hecho = Datos_de_los_Hechos_PCData.Hora_Aproximada_del_Hecho
                    ,Tiene_alguna_Foto_o_Evidencia = Datos_de_los_Hechos_PCData.Tiene_alguna_Foto_o_Evidencia
                    ,Fosa_clandestina = Datos_de_los_Hechos_PCData.Fosa_clandestina
                    ,Fosa_clandestinaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Fosa_clandestina), "Respuesta") ??  (string)Datos_de_los_Hechos_PCData.Fosa_clandestina_Respuesta.Descripcion
                    ,Conoce_la_direccion = Datos_de_los_Hechos_PCData.Conoce_la_direccion
                    ,Conoce_la_direccionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Conoce_la_direccion), "Respuesta") ??  (string)Datos_de_los_Hechos_PCData.Conoce_la_direccion_Respuesta.Descripcion
                    ,Pais = Datos_de_los_Hechos_PCData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Pais), "Pais") ??  (string)Datos_de_los_Hechos_PCData.Pais_Pais.Nombre
                    ,Estado = Datos_de_los_Hechos_PCData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Estado), "Estado") ??  (string)Datos_de_los_Hechos_PCData.Estado_Estado.Nombre
                    ,Municipio = Datos_de_los_Hechos_PCData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Municipio), "Municipio") ??  (string)Datos_de_los_Hechos_PCData.Municipio_Municipio.Nombre
                    ,Poblacion = Datos_de_los_Hechos_PCData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Poblacion), "Colonia") ??  (string)Datos_de_los_Hechos_PCData.Poblacion_Colonia.Nombre
                    ,Colonia = Datos_de_los_Hechos_PCData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Colonia), "Colonia") ??  (string)Datos_de_los_Hechos_PCData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Datos_de_los_Hechos_PCData.Codigo_Postal
                    ,Calle = Datos_de_los_Hechos_PCData.Calle
                    ,Entre_Calle = Datos_de_los_Hechos_PCData.Entre_Calle
                    ,Y_Calle = Datos_de_los_Hechos_PCData.Y_Calle
                    ,Numero_Exterior = Datos_de_los_Hechos_PCData.Numero_Exterior
                    ,Numero_Interior = Datos_de_los_Hechos_PCData.Numero_Interior
                    ,Referencia = Datos_de_los_Hechos_PCData.Referencia
                    ,Latitud = Datos_de_los_Hechos_PCData.Latitud
                    ,Longitud = Datos_de_los_Hechos_PCData.Longitud
                    ,Es_una_direccion_exacta_o_aproximada = Datos_de_los_Hechos_PCData.Es_una_direccion_exacta_o_aproximada
                    ,Es_una_direccion_exacta_o_aproximadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Es_una_direccion_exacta_o_aproximada), "Direccion_Exacta") ??  (string)Datos_de_los_Hechos_PCData.Es_una_direccion_exacta_o_aproximada_Direccion_Exacta.Descripcion

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Tiene_alguna_Foto_o_EvidenciaSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_Evidencia).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Fosa_clandestina = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Fosa_clandestina != null && Respuestas_Fosa_clandestina.Resource != null)
                ViewBag.Respuestas_Fosa_clandestina = Respuestas_Fosa_clandestina.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Conoce_la_direccion = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Conoce_la_direccion != null && Respuestas_Conoce_la_direccion.Resource != null)
                ViewBag.Respuestas_Conoce_la_direccion = Respuestas_Conoce_la_direccion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDireccion_ExactaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Direccion_Exactas_Es_una_direccion_exacta_o_aproximada = _IDireccion_ExactaApiConsumer.SelAll(true);
            if (Direccion_Exactas_Es_una_direccion_exacta_o_aproximada != null && Direccion_Exactas_Es_una_direccion_exacta_o_aproximada.Resource != null)
                ViewBag.Direccion_Exactas_Es_una_direccion_exacta_o_aproximada = Direccion_Exactas_Es_una_direccion_exacta_o_aproximada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Direccion_Exacta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDatos_de_los_Hechos_PC);
        }
		
	[HttpGet]
        public ActionResult AddDatos_de_los_Hechos_PC(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45711);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDatos_de_los_Hechos_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
			Datos_de_los_Hechos_PCModel varDatos_de_los_Hechos_PC= new Datos_de_los_Hechos_PCModel();


            if (id.ToString() != "0")
            {
                var Datos_de_los_Hechos_PCsData = _IDatos_de_los_Hechos_PCApiConsumer.ListaSelAll(0, 1000, "Datos_de_los_Hechos_PC.Clave=" + id, "").Resource.Datos_de_los_Hechos_PCs;
				
				if (Datos_de_los_Hechos_PCsData != null && Datos_de_los_Hechos_PCsData.Count > 0)
                {
					var Datos_de_los_Hechos_PCData = Datos_de_los_Hechos_PCsData.First();
					varDatos_de_los_Hechos_PC= new Datos_de_los_Hechos_PCModel
					{
						Clave  = Datos_de_los_Hechos_PCData.Clave 
	                    ,Solicitud = Datos_de_los_Hechos_PCData.Solicitud
                    ,SolicitudFolio = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Solicitud), "Solicitud_de_Denuncia_Ciudadana") ??  (string)Datos_de_los_Hechos_PCData.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                    ,Titulo_del_Hecho = Datos_de_los_Hechos_PCData.Titulo_del_Hecho
                    ,Narrativa_Breve_de_los_Hechos = Datos_de_los_Hechos_PCData.Narrativa_Breve_de_los_Hechos
                    ,Fecha_del_Hecho = (Datos_de_los_Hechos_PCData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Datos_de_los_Hechos_PCData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Aproximada_del_Hecho = Datos_de_los_Hechos_PCData.Hora_Aproximada_del_Hecho
                    ,Tiene_alguna_Foto_o_Evidencia = Datos_de_los_Hechos_PCData.Tiene_alguna_Foto_o_Evidencia
                    ,Fosa_clandestina = Datos_de_los_Hechos_PCData.Fosa_clandestina
                    ,Fosa_clandestinaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Fosa_clandestina), "Respuesta") ??  (string)Datos_de_los_Hechos_PCData.Fosa_clandestina_Respuesta.Descripcion
                    ,Conoce_la_direccion = Datos_de_los_Hechos_PCData.Conoce_la_direccion
                    ,Conoce_la_direccionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Conoce_la_direccion), "Respuesta") ??  (string)Datos_de_los_Hechos_PCData.Conoce_la_direccion_Respuesta.Descripcion
                    ,Pais = Datos_de_los_Hechos_PCData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Pais), "Pais") ??  (string)Datos_de_los_Hechos_PCData.Pais_Pais.Nombre
                    ,Estado = Datos_de_los_Hechos_PCData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Estado), "Estado") ??  (string)Datos_de_los_Hechos_PCData.Estado_Estado.Nombre
                    ,Municipio = Datos_de_los_Hechos_PCData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Municipio), "Municipio") ??  (string)Datos_de_los_Hechos_PCData.Municipio_Municipio.Nombre
                    ,Poblacion = Datos_de_los_Hechos_PCData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Poblacion), "Colonia") ??  (string)Datos_de_los_Hechos_PCData.Poblacion_Colonia.Nombre
                    ,Colonia = Datos_de_los_Hechos_PCData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Colonia), "Colonia") ??  (string)Datos_de_los_Hechos_PCData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Datos_de_los_Hechos_PCData.Codigo_Postal
                    ,Calle = Datos_de_los_Hechos_PCData.Calle
                    ,Entre_Calle = Datos_de_los_Hechos_PCData.Entre_Calle
                    ,Y_Calle = Datos_de_los_Hechos_PCData.Y_Calle
                    ,Numero_Exterior = Datos_de_los_Hechos_PCData.Numero_Exterior
                    ,Numero_Interior = Datos_de_los_Hechos_PCData.Numero_Interior
                    ,Referencia = Datos_de_los_Hechos_PCData.Referencia
                    ,Latitud = Datos_de_los_Hechos_PCData.Latitud
                    ,Longitud = Datos_de_los_Hechos_PCData.Longitud
                    ,Es_una_direccion_exacta_o_aproximada = Datos_de_los_Hechos_PCData.Es_una_direccion_exacta_o_aproximada
                    ,Es_una_direccion_exacta_o_aproximadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Datos_de_los_Hechos_PCData.Es_una_direccion_exacta_o_aproximada), "Direccion_Exacta") ??  (string)Datos_de_los_Hechos_PCData.Es_una_direccion_exacta_o_aproximada_Direccion_Exacta.Descripcion

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Tiene_alguna_Foto_o_EvidenciaSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_Evidencia).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Fosa_clandestina = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Fosa_clandestina != null && Respuestas_Fosa_clandestina.Resource != null)
                ViewBag.Respuestas_Fosa_clandestina = Respuestas_Fosa_clandestina.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Conoce_la_direccion = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Conoce_la_direccion != null && Respuestas_Conoce_la_direccion.Resource != null)
                ViewBag.Respuestas_Conoce_la_direccion = Respuestas_Conoce_la_direccion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDireccion_ExactaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Direccion_Exactas_Es_una_direccion_exacta_o_aproximada = _IDireccion_ExactaApiConsumer.SelAll(true);
            if (Direccion_Exactas_Es_una_direccion_exacta_o_aproximada != null && Direccion_Exactas_Es_una_direccion_exacta_o_aproximada.Resource != null)
                ViewBag.Direccion_Exactas_Es_una_direccion_exacta_o_aproximada = Direccion_Exactas_Es_una_direccion_exacta_o_aproximada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Direccion_Exacta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDatos_de_los_Hechos_PC", varDatos_de_los_Hechos_PC);
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
        public ActionResult GetSolicitud_de_Denuncia_CiudadanaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Folio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitud_de_Denuncia_Ciudadana", "Folio")?? m.Folio,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetRespuestaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRespuestaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetDireccion_ExactaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDireccion_ExactaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDireccion_ExactaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Direccion_Exacta", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Datos_de_los_Hechos_PCAdvanceSearchModel model, int idFilter = -1)
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

            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Fosa_clandestina = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Fosa_clandestina != null && Respuestas_Fosa_clandestina.Resource != null)
                ViewBag.Respuestas_Fosa_clandestina = Respuestas_Fosa_clandestina.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Conoce_la_direccion = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Conoce_la_direccion != null && Respuestas_Conoce_la_direccion.Resource != null)
                ViewBag.Respuestas_Conoce_la_direccion = Respuestas_Conoce_la_direccion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDireccion_ExactaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Direccion_Exactas_Es_una_direccion_exacta_o_aproximada = _IDireccion_ExactaApiConsumer.SelAll(true);
            if (Direccion_Exactas_Es_una_direccion_exacta_o_aproximada != null && Direccion_Exactas_Es_una_direccion_exacta_o_aproximada.Resource != null)
                ViewBag.Direccion_Exactas_Es_una_direccion_exacta_o_aproximada = Direccion_Exactas_Es_una_direccion_exacta_o_aproximada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Direccion_Exacta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Fosa_clandestina = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Fosa_clandestina != null && Respuestas_Fosa_clandestina.Resource != null)
                ViewBag.Respuestas_Fosa_clandestina = Respuestas_Fosa_clandestina.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRespuestaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Respuestas_Conoce_la_direccion = _IRespuestaApiConsumer.SelAll(true);
            if (Respuestas_Conoce_la_direccion != null && Respuestas_Conoce_la_direccion.Resource != null)
                ViewBag.Respuestas_Conoce_la_direccion = Respuestas_Conoce_la_direccion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Respuesta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDireccion_ExactaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Direccion_Exactas_Es_una_direccion_exacta_o_aproximada = _IDireccion_ExactaApiConsumer.SelAll(true);
            if (Direccion_Exactas_Es_una_direccion_exacta_o_aproximada != null && Direccion_Exactas_Es_una_direccion_exacta_o_aproximada.Resource != null)
                ViewBag.Direccion_Exactas_Es_una_direccion_exacta_o_aproximada = Direccion_Exactas_Es_una_direccion_exacta_o_aproximada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Direccion_Exacta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Datos_de_los_Hechos_PCAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Datos_de_los_Hechos_PCAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Datos_de_los_Hechos_PCAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Datos_de_los_Hechos_PCPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDatos_de_los_Hechos_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Datos_de_los_Hechos_PCs == null)
                result.Datos_de_los_Hechos_PCs = new List<Datos_de_los_Hechos_PC>();

            return Json(new
            {
                data = result.Datos_de_los_Hechos_PCs.Select(m => new Datos_de_los_Hechos_PCGridModel
                    {
                    Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
			,Tiene_alguna_Foto_o_Evidencia = m.Tiene_alguna_Foto_o_Evidencia
                        ,Fosa_clandestinaDescripcion = CultureHelper.GetTraduction(m.Fosa_clandestina_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Fosa_clandestina_Respuesta.Descripcion
                        ,Conoce_la_direccionDescripcion = CultureHelper.GetTraduction(m.Conoce_la_direccion_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Conoce_la_direccion_Respuesta.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
                        ,Es_una_direccion_exacta_o_aproximadaDescripcion = CultureHelper.GetTraduction(m.Es_una_direccion_exacta_o_aproximada_Direccion_Exacta.Clave.ToString(), "Descripcion") ?? (string)m.Es_una_direccion_exacta_o_aproximada_Direccion_Exacta.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDatos_de_los_Hechos_PCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDatos_de_los_Hechos_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDatos_de_los_Hechos_PCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Datos_de_los_Hechos_PC", m.),
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
        /// Get List of Datos_de_los_Hechos_PC from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Datos_de_los_Hechos_PC Entity</returns>
        public ActionResult GetDatos_de_los_Hechos_PCList(UrlParametersModel param)
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
            _IDatos_de_los_Hechos_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Datos_de_los_Hechos_PCPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Datos_de_los_Hechos_PCAdvanceSearchModel))
                {
					var advanceFilter =
                    (Datos_de_los_Hechos_PCAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Datos_de_los_Hechos_PCPropertyMapper oDatos_de_los_Hechos_PCPropertyMapper = new Datos_de_los_Hechos_PCPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDatos_de_los_Hechos_PCPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDatos_de_los_Hechos_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Datos_de_los_Hechos_PCs == null)
                result.Datos_de_los_Hechos_PCs = new List<Datos_de_los_Hechos_PC>();

            return Json(new
            {
                aaData = result.Datos_de_los_Hechos_PCs.Select(m => new Datos_de_los_Hechos_PCGridModel
            {
                    Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
			,Tiene_alguna_Foto_o_Evidencia = m.Tiene_alguna_Foto_o_Evidencia
                        ,Fosa_clandestinaDescripcion = CultureHelper.GetTraduction(m.Fosa_clandestina_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Fosa_clandestina_Respuesta.Descripcion
                        ,Conoce_la_direccionDescripcion = CultureHelper.GetTraduction(m.Conoce_la_direccion_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Conoce_la_direccion_Respuesta.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
                        ,Es_una_direccion_exacta_o_aproximadaDescripcion = CultureHelper.GetTraduction(m.Es_una_direccion_exacta_o_aproximada_Direccion_Exacta.Clave.ToString(), "Descripcion") ?? (string)m.Es_una_direccion_exacta_o_aproximada_Direccion_Exacta.Descripcion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDatos_de_los_Hechos_PC_Solicitud_Solicitud_de_Denuncia_Ciudadana(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Solicitud_de_Denuncia_Ciudadana.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Solicitud_de_Denuncia_Ciudadana.Folio as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.ListaSelAll(1, 20,elWhere , " Solicitud_de_Denuncia_Ciudadana.Folio ASC ").Resource;
               
                foreach (var item in result.Solicitud_de_Denuncia_Ciudadanas)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Solicitud_de_Denuncia_Ciudadana", "Folio");
                    item.Folio =trans ??item.Folio;
                }
                return Json(result.Solicitud_de_Denuncia_Ciudadanas.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDatos_de_los_Hechos_PC_Pais_Pais(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Pais.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Pais.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IPaisApiConsumer.ListaSelAll(1, 20,elWhere , " Pais.Nombre ASC ").Resource;
               
                foreach (var item in result.Paiss)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Paiss.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDatos_de_los_Hechos_PC_Estado_Estado(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Estado.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Estado.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IEstadoApiConsumer.ListaSelAll(1, 20,elWhere , " Estado.Nombre ASC ").Resource;
               
                foreach (var item in result.Estados)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Estados.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDatos_de_los_Hechos_PC_Municipio_Municipio(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Municipio.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Municipio.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IMunicipioApiConsumer.ListaSelAll(1, 20,elWhere , " Municipio.Nombre ASC ").Resource;
               
                foreach (var item in result.Municipios)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Municipios.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDatos_de_los_Hechos_PC_Poblacion_Colonia(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Colonia.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Colonia.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IColoniaApiConsumer.ListaSelAll(1, 20,elWhere , " Colonia.Nombre ASC ").Resource;
               
                foreach (var item in result.Colonias)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Colonias.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDatos_de_los_Hechos_PC_Colonia_Colonia(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Colonia.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Colonia.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IColoniaApiConsumer.ListaSelAll(1, 20,elWhere , " Colonia.Nombre ASC ").Resource;
               
                foreach (var item in result.Colonias)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Colonias.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public string GetAdvanceFilter(Datos_de_los_Hechos_PCAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Datos_de_los_Hechos_PC.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Datos_de_los_Hechos_PC.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSolicitud))
            {
                switch (filter.SolicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '" + filter.AdvanceSolicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '%" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio = '" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '%" + filter.AdvanceSolicitud + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSolicitudMultiple != null && filter.AdvanceSolicitudMultiple.Count() > 0)
            {
                var SolicitudIds = string.Join(",", filter.AdvanceSolicitudMultiple);

                where += " AND Datos_de_los_Hechos_PC.Solicitud In (" + SolicitudIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Titulo_del_Hecho))
            {
                switch (filter.Titulo_del_HechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Datos_de_los_Hechos_PC.Titulo_del_Hecho LIKE '" + filter.Titulo_del_Hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Datos_de_los_Hechos_PC.Titulo_del_Hecho LIKE '%" + filter.Titulo_del_Hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Datos_de_los_Hechos_PC.Titulo_del_Hecho = '" + filter.Titulo_del_Hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Datos_de_los_Hechos_PC.Titulo_del_Hecho LIKE '%" + filter.Titulo_del_Hecho + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Narrativa_Breve_de_los_Hechos))
            {
                switch (filter.Narrativa_Breve_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Datos_de_los_Hechos_PC.Narrativa_Breve_de_los_Hechos LIKE '" + filter.Narrativa_Breve_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Datos_de_los_Hechos_PC.Narrativa_Breve_de_los_Hechos LIKE '%" + filter.Narrativa_Breve_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Datos_de_los_Hechos_PC.Narrativa_Breve_de_los_Hechos = '" + filter.Narrativa_Breve_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Datos_de_los_Hechos_PC.Narrativa_Breve_de_los_Hechos LIKE '%" + filter.Narrativa_Breve_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_del_Hecho) || !string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
            {
                var Fecha_del_HechoFrom = DateTime.ParseExact(filter.FromFecha_del_Hecho, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_del_HechoTo = DateTime.ParseExact(filter.ToFecha_del_Hecho, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_del_Hecho))
                    where += " AND Datos_de_los_Hechos_PC.Fecha_del_Hecho >= '" + Fecha_del_HechoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
                    where += " AND Datos_de_los_Hechos_PC.Fecha_del_Hecho <= '" + Fecha_del_HechoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Aproximada_del_Hecho) || !string.IsNullOrEmpty(filter.ToHora_Aproximada_del_Hecho))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Aproximada_del_Hecho))
                    where += " AND Convert(TIME,Datos_de_los_Hechos_PC.Hora_Aproximada_del_Hecho) >='" + filter.FromHora_Aproximada_del_Hecho + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Aproximada_del_Hecho))
                    where += " AND Convert(TIME,Datos_de_los_Hechos_PC.Hora_Aproximada_del_Hecho) <='" + filter.ToHora_Aproximada_del_Hecho + "'";
            }

            if (filter.Tiene_alguna_Foto_o_Evidencia != RadioOptions.NoApply)
                where += " AND Datos_de_los_Hechos_PC.Tiene_alguna_Foto_o_Evidencia " + (filter.Tiene_alguna_Foto_o_Evidencia == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.AdvanceFosa_clandestina))
            {
                switch (filter.Fosa_clandestinaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Respuesta.Descripcion LIKE '" + filter.AdvanceFosa_clandestina + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Respuesta.Descripcion LIKE '%" + filter.AdvanceFosa_clandestina + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Respuesta.Descripcion = '" + filter.AdvanceFosa_clandestina + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Respuesta.Descripcion LIKE '%" + filter.AdvanceFosa_clandestina + "%'";
                        break;
                }
            }
            else if (filter.AdvanceFosa_clandestinaMultiple != null && filter.AdvanceFosa_clandestinaMultiple.Count() > 0)
            {
                var Fosa_clandestinaIds = string.Join(",", filter.AdvanceFosa_clandestinaMultiple);

                where += " AND Datos_de_los_Hechos_PC.Fosa_clandestina In (" + Fosa_clandestinaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceConoce_la_direccion))
            {
                switch (filter.Conoce_la_direccionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Respuesta.Descripcion LIKE '" + filter.AdvanceConoce_la_direccion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Respuesta.Descripcion LIKE '%" + filter.AdvanceConoce_la_direccion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Respuesta.Descripcion = '" + filter.AdvanceConoce_la_direccion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Respuesta.Descripcion LIKE '%" + filter.AdvanceConoce_la_direccion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceConoce_la_direccionMultiple != null && filter.AdvanceConoce_la_direccionMultiple.Count() > 0)
            {
                var Conoce_la_direccionIds = string.Join(",", filter.AdvanceConoce_la_direccionMultiple);

                where += " AND Datos_de_los_Hechos_PC.Conoce_la_direccion In (" + Conoce_la_direccionIds + ")";
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

                where += " AND Datos_de_los_Hechos_PC.Pais In (" + PaisIds + ")";
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

                where += " AND Datos_de_los_Hechos_PC.Estado In (" + EstadoIds + ")";
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

                where += " AND Datos_de_los_Hechos_PC.Municipio In (" + MunicipioIds + ")";
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

                where += " AND Datos_de_los_Hechos_PC.Poblacion In (" + PoblacionIds + ")";
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

                where += " AND Datos_de_los_Hechos_PC.Colonia In (" + ColoniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal) || !string.IsNullOrEmpty(filter.ToCodigo_Postal))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal))
                    where += " AND Datos_de_los_Hechos_PC.Codigo_Postal >= " + filter.FromCodigo_Postal;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal))
                    where += " AND Datos_de_los_Hechos_PC.Codigo_Postal <= " + filter.ToCodigo_Postal;
            }

            if (!string.IsNullOrEmpty(filter.Calle))
            {
                switch (filter.CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Datos_de_los_Hechos_PC.Calle LIKE '" + filter.Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Datos_de_los_Hechos_PC.Calle LIKE '%" + filter.Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Datos_de_los_Hechos_PC.Calle = '" + filter.Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Datos_de_los_Hechos_PC.Calle LIKE '%" + filter.Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle))
            {
                switch (filter.Entre_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Datos_de_los_Hechos_PC.Entre_Calle LIKE '" + filter.Entre_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Datos_de_los_Hechos_PC.Entre_Calle LIKE '%" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Datos_de_los_Hechos_PC.Entre_Calle = '" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Datos_de_los_Hechos_PC.Entre_Calle LIKE '%" + filter.Entre_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Y_Calle))
            {
                switch (filter.Y_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Datos_de_los_Hechos_PC.Y_Calle LIKE '" + filter.Y_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Datos_de_los_Hechos_PC.Y_Calle LIKE '%" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Datos_de_los_Hechos_PC.Y_Calle = '" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Datos_de_los_Hechos_PC.Y_Calle LIKE '%" + filter.Y_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior))
            {
                switch (filter.Numero_ExteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Datos_de_los_Hechos_PC.Numero_Exterior LIKE '" + filter.Numero_Exterior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Datos_de_los_Hechos_PC.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Datos_de_los_Hechos_PC.Numero_Exterior = '" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Datos_de_los_Hechos_PC.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior))
            {
                switch (filter.Numero_InteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Datos_de_los_Hechos_PC.Numero_Interior LIKE '" + filter.Numero_Interior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Datos_de_los_Hechos_PC.Numero_Interior LIKE '%" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Datos_de_los_Hechos_PC.Numero_Interior = '" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Datos_de_los_Hechos_PC.Numero_Interior LIKE '%" + filter.Numero_Interior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencia))
            {
                switch (filter.ReferenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Datos_de_los_Hechos_PC.Referencia LIKE '" + filter.Referencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Datos_de_los_Hechos_PC.Referencia LIKE '%" + filter.Referencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Datos_de_los_Hechos_PC.Referencia = '" + filter.Referencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Datos_de_los_Hechos_PC.Referencia LIKE '%" + filter.Referencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud))
            {
                switch (filter.LatitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Datos_de_los_Hechos_PC.Latitud LIKE '" + filter.Latitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Datos_de_los_Hechos_PC.Latitud LIKE '%" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Datos_de_los_Hechos_PC.Latitud = '" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Datos_de_los_Hechos_PC.Latitud LIKE '%" + filter.Latitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud))
            {
                switch (filter.LongitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Datos_de_los_Hechos_PC.Longitud LIKE '" + filter.Longitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Datos_de_los_Hechos_PC.Longitud LIKE '%" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Datos_de_los_Hechos_PC.Longitud = '" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Datos_de_los_Hechos_PC.Longitud LIKE '%" + filter.Longitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEs_una_direccion_exacta_o_aproximada))
            {
                switch (filter.Es_una_direccion_exacta_o_aproximadaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Direccion_Exacta.Descripcion LIKE '" + filter.AdvanceEs_una_direccion_exacta_o_aproximada + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Direccion_Exacta.Descripcion LIKE '%" + filter.AdvanceEs_una_direccion_exacta_o_aproximada + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Direccion_Exacta.Descripcion = '" + filter.AdvanceEs_una_direccion_exacta_o_aproximada + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Direccion_Exacta.Descripcion LIKE '%" + filter.AdvanceEs_una_direccion_exacta_o_aproximada + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEs_una_direccion_exacta_o_aproximadaMultiple != null && filter.AdvanceEs_una_direccion_exacta_o_aproximadaMultiple.Count() > 0)
            {
                var Es_una_direccion_exacta_o_aproximadaIds = string.Join(",", filter.AdvanceEs_una_direccion_exacta_o_aproximadaMultiple);

                where += " AND Datos_de_los_Hechos_PC.Es_una_direccion_exacta_o_aproximada In (" + Es_una_direccion_exacta_o_aproximadaIds + ")";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }



        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDatos_de_los_Hechos_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

                Datos_de_los_Hechos_PC varDatos_de_los_Hechos_PC = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDatos_de_los_Hechos_PCApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Datos_de_los_Hechos_PCModel varDatos_de_los_Hechos_PC)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDatos_de_los_Hechos_PCApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_EvidenciaRemoveAttachment != 0 && varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_EvidenciaFile == null)
                    {
                        varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_Evidencia = 0;
                    }

                    if (varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_EvidenciaFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_EvidenciaFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_Evidencia = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_EvidenciaFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Datos_de_los_Hechos_PCInfo = new Datos_de_los_Hechos_PC
                    {
                        Clave = varDatos_de_los_Hechos_PC.Clave
                        ,Solicitud = varDatos_de_los_Hechos_PC.Solicitud
                        ,Titulo_del_Hecho = varDatos_de_los_Hechos_PC.Titulo_del_Hecho
                        ,Narrativa_Breve_de_los_Hechos = varDatos_de_los_Hechos_PC.Narrativa_Breve_de_los_Hechos
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varDatos_de_los_Hechos_PC.Fecha_del_Hecho)) ? DateTime.ParseExact(varDatos_de_los_Hechos_PC.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Aproximada_del_Hecho = varDatos_de_los_Hechos_PC.Hora_Aproximada_del_Hecho
                        ,Tiene_alguna_Foto_o_Evidencia = (varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_Evidencia.HasValue && varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_Evidencia != 0) ? ((int?)Convert.ToInt32(varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_Evidencia.Value)) : null

                        ,Fosa_clandestina = varDatos_de_los_Hechos_PC.Fosa_clandestina
                        ,Conoce_la_direccion = varDatos_de_los_Hechos_PC.Conoce_la_direccion
                        ,Pais = varDatos_de_los_Hechos_PC.Pais
                        ,Estado = varDatos_de_los_Hechos_PC.Estado
                        ,Municipio = varDatos_de_los_Hechos_PC.Municipio
                        ,Poblacion = varDatos_de_los_Hechos_PC.Poblacion
                        ,Colonia = varDatos_de_los_Hechos_PC.Colonia
                        ,Codigo_Postal = varDatos_de_los_Hechos_PC.Codigo_Postal
                        ,Calle = varDatos_de_los_Hechos_PC.Calle
                        ,Entre_Calle = varDatos_de_los_Hechos_PC.Entre_Calle
                        ,Y_Calle = varDatos_de_los_Hechos_PC.Y_Calle
                        ,Numero_Exterior = varDatos_de_los_Hechos_PC.Numero_Exterior
                        ,Numero_Interior = varDatos_de_los_Hechos_PC.Numero_Interior
                        ,Referencia = varDatos_de_los_Hechos_PC.Referencia
                        ,Latitud = varDatos_de_los_Hechos_PC.Latitud
                        ,Longitud = varDatos_de_los_Hechos_PC.Longitud
                        ,Es_una_direccion_exacta_o_aproximada = varDatos_de_los_Hechos_PC.Es_una_direccion_exacta_o_aproximada

                    };

                    result = !IsNew ?
                        _IDatos_de_los_Hechos_PCApiConsumer.Update(Datos_de_los_Hechos_PCInfo, null, null).Resource.ToString() :
                         _IDatos_de_los_Hechos_PCApiConsumer.Insert(Datos_de_los_Hechos_PCInfo, null, null).Resource.ToString();
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



        /// <summary>
        /// Write Element Array of Datos_de_los_Hechos_PC script
        /// </summary>
        /// <param name="oDatos_de_los_Hechos_PCElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Datos_de_los_Hechos_PCModuleAttributeList)
        {
            for (int i = 0; i < Datos_de_los_Hechos_PCModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Datos_de_los_Hechos_PCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Datos_de_los_Hechos_PCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Datos_de_los_Hechos_PCModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Datos_de_los_Hechos_PCModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Datos_de_los_Hechos_PCModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Datos_de_los_Hechos_PCModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Datos_de_los_Hechos_PCModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Datos_de_los_Hechos_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Datos_de_los_Hechos_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Datos_de_los_Hechos_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Datos_de_los_Hechos_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDatos_de_los_Hechos_PCScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Datos_de_los_Hechos_PC.js")))
            {
                strDatos_de_los_Hechos_PCScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Datos_de_los_Hechos_PC element attributes
            string userChangeJson = jsSerialize.Serialize(Datos_de_los_Hechos_PCModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDatos_de_los_Hechos_PCScript.IndexOf("inpuElementArray");
            string splittedString = strDatos_de_los_Hechos_PCScript.Substring(indexOfArray, strDatos_de_los_Hechos_PCScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Datos_de_los_Hechos_PCModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Datos_de_los_Hechos_PCModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDatos_de_los_Hechos_PCScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDatos_de_los_Hechos_PCScript.Substring(indexOfArrayHistory, strDatos_de_los_Hechos_PCScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDatos_de_los_Hechos_PCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDatos_de_los_Hechos_PCScript.Substring(endIndexOfMainElement + indexOfArray, strDatos_de_los_Hechos_PCScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Datos_de_los_Hechos_PCModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Datos_de_los_Hechos_PCModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Datos_de_los_Hechos_PC.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Datos_de_los_Hechos_PC.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Datos_de_los_Hechos_PC.js")))
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
        public ActionResult Datos_de_los_Hechos_PCPropertyBag()
        {
            return PartialView("Datos_de_los_Hechos_PCPropertyBag", "Datos_de_los_Hechos_PC");
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
                var whereClauseFormat = "Object = 45711 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDatos_de_los_Hechos_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Datos_de_los_Hechos_PC.Clave= " + RecordId;
                            var result = _IDatos_de_los_Hechos_PCApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDatos_de_los_Hechos_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Datos_de_los_Hechos_PCPropertyMapper());
			
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
                    (Datos_de_los_Hechos_PCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Datos_de_los_Hechos_PCPropertyMapper oDatos_de_los_Hechos_PCPropertyMapper = new Datos_de_los_Hechos_PCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDatos_de_los_Hechos_PCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDatos_de_los_Hechos_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Datos_de_los_Hechos_PCs == null)
                result.Datos_de_los_Hechos_PCs = new List<Datos_de_los_Hechos_PC>();

            var data = result.Datos_de_los_Hechos_PCs.Select(m => new Datos_de_los_Hechos_PCGridModel
            {
                Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
			,Tiene_alguna_Foto_o_Evidencia = m.Tiene_alguna_Foto_o_Evidencia
                        ,Fosa_clandestinaDescripcion = CultureHelper.GetTraduction(m.Fosa_clandestina_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Fosa_clandestina_Respuesta.Descripcion
                        ,Conoce_la_direccionDescripcion = CultureHelper.GetTraduction(m.Conoce_la_direccion_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Conoce_la_direccion_Respuesta.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
                        ,Es_una_direccion_exacta_o_aproximadaDescripcion = CultureHelper.GetTraduction(m.Es_una_direccion_exacta_o_aproximada_Direccion_Exacta.Clave.ToString(), "Descripcion") ?? (string)m.Es_una_direccion_exacta_o_aproximada_Direccion_Exacta.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45711, arrayColumnsVisible), "Datos_de_los_Hechos_PCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45711, arrayColumnsVisible), "Datos_de_los_Hechos_PCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45711, arrayColumnsVisible), "Datos_de_los_Hechos_PCList_" + DateTime.Now.ToString());
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

            _IDatos_de_los_Hechos_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Datos_de_los_Hechos_PCPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Datos_de_los_Hechos_PCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Datos_de_los_Hechos_PCPropertyMapper oDatos_de_los_Hechos_PCPropertyMapper = new Datos_de_los_Hechos_PCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDatos_de_los_Hechos_PCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDatos_de_los_Hechos_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Datos_de_los_Hechos_PCs == null)
                result.Datos_de_los_Hechos_PCs = new List<Datos_de_los_Hechos_PC>();

            var data = result.Datos_de_los_Hechos_PCs.Select(m => new Datos_de_los_Hechos_PCGridModel
            {
                Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
			,Tiene_alguna_Foto_o_Evidencia = m.Tiene_alguna_Foto_o_Evidencia
                        ,Fosa_clandestinaDescripcion = CultureHelper.GetTraduction(m.Fosa_clandestina_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Fosa_clandestina_Respuesta.Descripcion
                        ,Conoce_la_direccionDescripcion = CultureHelper.GetTraduction(m.Conoce_la_direccion_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Conoce_la_direccion_Respuesta.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
                        ,Es_una_direccion_exacta_o_aproximadaDescripcion = CultureHelper.GetTraduction(m.Es_una_direccion_exacta_o_aproximada_Direccion_Exacta.Clave.ToString(), "Descripcion") ?? (string)m.Es_una_direccion_exacta_o_aproximada_Direccion_Exacta.Descripcion

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
                _IDatos_de_los_Hechos_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDatos_de_los_Hechos_PCApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_de_los_hechos(Datos_de_los_Hechos_PC_Datos_de_los_hechosModel varDatos_de_los_Hechos_PC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDatos_de_los_Hechos_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_EvidenciaRemoveAttachment != 0 && varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_EvidenciaFile == null)
                    {
                        varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_Evidencia = 0;
                    }

                    if (varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_EvidenciaFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_EvidenciaFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_Evidencia = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_EvidenciaFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Datos_de_los_Hechos_PC_Datos_de_los_hechosInfo = new Datos_de_los_Hechos_PC_Datos_de_los_hechos
                {
                    Clave = varDatos_de_los_Hechos_PC.Clave
                                            ,Solicitud = varDatos_de_los_Hechos_PC.Solicitud
                        ,Titulo_del_Hecho = varDatos_de_los_Hechos_PC.Titulo_del_Hecho
                        ,Narrativa_Breve_de_los_Hechos = varDatos_de_los_Hechos_PC.Narrativa_Breve_de_los_Hechos
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varDatos_de_los_Hechos_PC.Fecha_del_Hecho)) ? DateTime.ParseExact(varDatos_de_los_Hechos_PC.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Aproximada_del_Hecho = varDatos_de_los_Hechos_PC.Hora_Aproximada_del_Hecho
                        ,Tiene_alguna_Foto_o_Evidencia = (varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_Evidencia.HasValue && varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_Evidencia != 0) ? ((int?)Convert.ToInt32(varDatos_de_los_Hechos_PC.Tiene_alguna_Foto_o_Evidencia.Value)) : null

                        ,Fosa_clandestina = varDatos_de_los_Hechos_PC.Fosa_clandestina
                    
                };

                result = _IDatos_de_los_Hechos_PCApiConsumer.Update_Datos_de_los_hechos(Datos_de_los_Hechos_PC_Datos_de_los_hechosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_los_hechos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDatos_de_los_Hechos_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDatos_de_los_Hechos_PCApiConsumer.Get_Datos_de_los_hechos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Datos_de_los_Hechos_PC_Datos_de_los_hechosModel
                {
                    Clave = m.Clave
                        ,Solicitud = m.Solicitud
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
			,Tiene_alguna_Foto_o_Evidencia = m.Tiene_alguna_Foto_o_Evidencia
                        ,Fosa_clandestina = m.Fosa_clandestina
                        ,Fosa_clandestinaDescripcion = CultureHelper.GetTraduction(m.Fosa_clandestina_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Fosa_clandestina_Respuesta.Descripcion

                    
                };
				var resultData = new
                {
                    data = result

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Lugar_de_los_Hechos(Datos_de_los_Hechos_PC_Lugar_de_los_HechosModel varDatos_de_los_Hechos_PC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDatos_de_los_Hechos_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Datos_de_los_Hechos_PC_Lugar_de_los_HechosInfo = new Datos_de_los_Hechos_PC_Lugar_de_los_Hechos
                {
                    Clave = varDatos_de_los_Hechos_PC.Clave
                                            ,Conoce_la_direccion = varDatos_de_los_Hechos_PC.Conoce_la_direccion
                        ,Pais = varDatos_de_los_Hechos_PC.Pais
                        ,Estado = varDatos_de_los_Hechos_PC.Estado
                        ,Municipio = varDatos_de_los_Hechos_PC.Municipio
                        ,Poblacion = varDatos_de_los_Hechos_PC.Poblacion
                        ,Colonia = varDatos_de_los_Hechos_PC.Colonia
                        ,Codigo_Postal = varDatos_de_los_Hechos_PC.Codigo_Postal
                        ,Calle = varDatos_de_los_Hechos_PC.Calle
                        ,Entre_Calle = varDatos_de_los_Hechos_PC.Entre_Calle
                        ,Y_Calle = varDatos_de_los_Hechos_PC.Y_Calle
                        ,Numero_Exterior = varDatos_de_los_Hechos_PC.Numero_Exterior
                        ,Numero_Interior = varDatos_de_los_Hechos_PC.Numero_Interior
                        ,Referencia = varDatos_de_los_Hechos_PC.Referencia
                        ,Latitud = varDatos_de_los_Hechos_PC.Latitud
                        ,Longitud = varDatos_de_los_Hechos_PC.Longitud
                        ,Es_una_direccion_exacta_o_aproximada = varDatos_de_los_Hechos_PC.Es_una_direccion_exacta_o_aproximada
                    
                };

                result = _IDatos_de_los_Hechos_PCApiConsumer.Update_Lugar_de_los_Hechos(Datos_de_los_Hechos_PC_Lugar_de_los_HechosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Lugar_de_los_Hechos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDatos_de_los_Hechos_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDatos_de_los_Hechos_PCApiConsumer.Get_Lugar_de_los_Hechos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Datos_de_los_Hechos_PC_Lugar_de_los_HechosModel
                {
                    Clave = m.Clave
                        ,Conoce_la_direccion = m.Conoce_la_direccion
                        ,Conoce_la_direccionDescripcion = CultureHelper.GetTraduction(m.Conoce_la_direccion_Respuesta.Clave.ToString(), "Descripcion") ?? (string)m.Conoce_la_direccion_Respuesta.Descripcion
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
                        ,Es_una_direccion_exacta_o_aproximada = m.Es_una_direccion_exacta_o_aproximada
                        ,Es_una_direccion_exacta_o_aproximadaDescripcion = CultureHelper.GetTraduction(m.Es_una_direccion_exacta_o_aproximada_Direccion_Exacta.Clave.ToString(), "Descripcion") ?? (string)m.Es_una_direccion_exacta_o_aproximada_Direccion_Exacta.Descripcion

                    
                };
				var resultData = new
                {
                    data = result

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

