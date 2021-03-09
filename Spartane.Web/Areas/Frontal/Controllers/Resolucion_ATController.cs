using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Resolucion_AT;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Estatus_de_Resolucion_de_AT;
using Spartane.Core.Domain.Resolucion;
using Spartane.Core.Domain.Detalle_de_Relaciones;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resolucion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Resolucion_AT;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Resolucion_AT;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Resolucion_de_AT;
using Spartane.Web.Areas.WebApiConsumer.Resolucion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Relaciones;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Resolucion;

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
    public class Resolucion_ATController : Controller
    {
        #region "variable declaration"

        private IResolucion_ATService service = null;
        private IResolucion_ATApiConsumer _IResolucion_ATApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IEstatus_de_Resolucion_de_ATApiConsumer _IEstatus_de_Resolucion_de_ATApiConsumer;
        private IResolucionApiConsumer _IResolucionApiConsumer;
        private IDetalle_de_RelacionesApiConsumer _IDetalle_de_RelacionesApiConsumer;

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

        
        public Resolucion_ATController(IResolucion_ATService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IResolucion_ATApiConsumer Resolucion_ATApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IEstatus_de_Resolucion_de_ATApiConsumer Estatus_de_Resolucion_de_ATApiConsumer , IResolucionApiConsumer ResolucionApiConsumer , IDetalle_de_RelacionesApiConsumer Detalle_de_RelacionesApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IResolucion_ATApiConsumer = Resolucion_ATApiConsumer;
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
            this._IEstatus_de_Resolucion_de_ATApiConsumer = Estatus_de_Resolucion_de_ATApiConsumer;
            this._IResolucionApiConsumer = ResolucionApiConsumer;
            this._IDetalle_de_RelacionesApiConsumer = Detalle_de_RelacionesApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IResolucionApiConsumer = ResolucionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Resolucion_AT
        [ObjectAuth(ObjectId = (ModuleObjectId)46209, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46209, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Resolucion_AT/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)46209, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46209, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varResolucion_AT = new Resolucion_ATModel();
			varResolucion_AT.Clave = Id;
			
            ViewBag.ObjectId = "46209";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IResolucion_ATApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Resolucion_ATsData = _IResolucion_ATApiConsumer.ListaSelAll(0, 1000, "Resolucion_AT.Clave=" + Id, "").Resource.Resolucion_ATs;
				
				if (Resolucion_ATsData != null && Resolucion_ATsData.Count > 0)
                {
					var Resolucion_ATData = Resolucion_ATsData.First();
					varResolucion_AT= new Resolucion_ATModel
					{
						Clave  = Resolucion_ATData.Clave 
	                    ,Modulo_Atencion_Inicial = Resolucion_ATData.Modulo_Atencion_Inicial
                    ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Resolucion_ATData.Modulo_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Resolucion_ATData.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Fecha_de_Resolucion = (Resolucion_ATData.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(Resolucion_ATData.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                    ,Persona_que_Resuelve = Resolucion_ATData.Persona_que_Resuelve
                    ,Persona_que_ResuelveName = CultureHelper.GetTraduction(Convert.ToString(Resolucion_ATData.Persona_que_Resuelve), "Spartan_User") ??  (string)Resolucion_ATData.Persona_que_Resuelve_Spartan_User.Name
                    ,Estatus = Resolucion_ATData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_ATData.Estatus), "Estatus_de_Resolucion_de_AT") ??  (string)Resolucion_ATData.Estatus_Estatus_de_Resolucion_de_AT.Descripcion
                    ,Resolucion = Resolucion_ATData.Resolucion
                    ,ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_ATData.Resolucion), "Resolucion") ??  (string)Resolucion_ATData.Resolucion_Resolucion.Descripcion
                    ,Relacion = Resolucion_ATData.Relacion
                    ,RelacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_ATData.Relacion), "Detalle_de_Relaciones") ??  (string)Resolucion_ATData.Relacion_Detalle_de_Relaciones.Descripcion
                    ,Observaciones = Resolucion_ATData.Observaciones
                    ,Fecha_de_Validacion = (Resolucion_ATData.Fecha_de_Validacion == null ? string.Empty : Convert.ToDateTime(Resolucion_ATData.Fecha_de_Validacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Validacion = Resolucion_ATData.Hora_de_Validacion
                    ,Dictaminador = Resolucion_ATData.Dictaminador
                    ,DictaminadorName = CultureHelper.GetTraduction(Convert.ToString(Resolucion_ATData.Dictaminador), "Spartan_User") ??  (string)Resolucion_ATData.Dictaminador_Spartan_User.Name
                    ,Resultado_de_Validacion = Resolucion_ATData.Resultado_de_Validacion
                    ,Resultado_de_ValidacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_ATData.Resultado_de_Validacion), "Resolucion") ??  (string)Resolucion_ATData.Resultado_de_Validacion_Resolucion.Descripcion
                    ,Observaciones_Dictaminador = Resolucion_ATData.Observaciones_Dictaminador

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_Modulo_Atencion_Inicial != null && Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource.Where(m => m.NUAT != null).OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT") ?? m.NUAT.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Persona_que_Resuelve = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Persona_que_Resuelve != null && Spartan_Users_Persona_que_Resuelve.Resource != null)
                ViewBag.Spartan_Users_Persona_que_Resuelve = Spartan_Users_Persona_que_Resuelve.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IEstatus_de_Resolucion_de_ATApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Resolucion_de_ATs_Estatus = _IEstatus_de_Resolucion_de_ATApiConsumer.SelAll(true);
            if (Estatus_de_Resolucion_de_ATs_Estatus != null && Estatus_de_Resolucion_de_ATs_Estatus.Resource != null)
                ViewBag.Estatus_de_Resolucion_de_ATs_Estatus = Estatus_de_Resolucion_de_ATs_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Resolucion_de_AT", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varResolucion_AT);
        }
		
	[HttpGet]
        public ActionResult AddResolucion_AT(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46209);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IResolucion_ATApiConsumer.SetAuthHeader(_tokenManager.Token);
			Resolucion_ATModel varResolucion_AT= new Resolucion_ATModel();


            if (id.ToString() != "0")
            {
                var Resolucion_ATsData = _IResolucion_ATApiConsumer.ListaSelAll(0, 1000, "Resolucion_AT.Clave=" + id, "").Resource.Resolucion_ATs;
				
				if (Resolucion_ATsData != null && Resolucion_ATsData.Count > 0)
                {
					var Resolucion_ATData = Resolucion_ATsData.First();
					varResolucion_AT= new Resolucion_ATModel
					{
						Clave  = Resolucion_ATData.Clave 
	                    ,Modulo_Atencion_Inicial = Resolucion_ATData.Modulo_Atencion_Inicial
                    ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Resolucion_ATData.Modulo_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Resolucion_ATData.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Fecha_de_Resolucion = (Resolucion_ATData.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(Resolucion_ATData.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                    ,Persona_que_Resuelve = Resolucion_ATData.Persona_que_Resuelve
                    ,Persona_que_ResuelveName = CultureHelper.GetTraduction(Convert.ToString(Resolucion_ATData.Persona_que_Resuelve), "Spartan_User") ??  (string)Resolucion_ATData.Persona_que_Resuelve_Spartan_User.Name
                    ,Estatus = Resolucion_ATData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_ATData.Estatus), "Estatus_de_Resolucion_de_AT") ??  (string)Resolucion_ATData.Estatus_Estatus_de_Resolucion_de_AT.Descripcion
                    ,Resolucion = Resolucion_ATData.Resolucion
                    ,ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_ATData.Resolucion), "Resolucion") ??  (string)Resolucion_ATData.Resolucion_Resolucion.Descripcion
                    ,Relacion = Resolucion_ATData.Relacion
                    ,RelacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_ATData.Relacion), "Detalle_de_Relaciones") ??  (string)Resolucion_ATData.Relacion_Detalle_de_Relaciones.Descripcion
                    ,Observaciones = Resolucion_ATData.Observaciones
                    ,Fecha_de_Validacion = (Resolucion_ATData.Fecha_de_Validacion == null ? string.Empty : Convert.ToDateTime(Resolucion_ATData.Fecha_de_Validacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Validacion = Resolucion_ATData.Hora_de_Validacion
                    ,Dictaminador = Resolucion_ATData.Dictaminador
                    ,DictaminadorName = CultureHelper.GetTraduction(Convert.ToString(Resolucion_ATData.Dictaminador), "Spartan_User") ??  (string)Resolucion_ATData.Dictaminador_Spartan_User.Name
                    ,Resultado_de_Validacion = Resolucion_ATData.Resultado_de_Validacion
                    ,Resultado_de_ValidacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_ATData.Resultado_de_Validacion), "Resolucion") ??  (string)Resolucion_ATData.Resultado_de_Validacion_Resolucion.Descripcion
                    ,Observaciones_Dictaminador = Resolucion_ATData.Observaciones_Dictaminador

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_Modulo_Atencion_Inicial != null && Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource.Where(m => m.NUAT != null).OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT") ?? m.NUAT.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Persona_que_Resuelve = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Persona_que_Resuelve != null && Spartan_Users_Persona_que_Resuelve.Resource != null)
                ViewBag.Spartan_Users_Persona_que_Resuelve = Spartan_Users_Persona_que_Resuelve.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IEstatus_de_Resolucion_de_ATApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Resolucion_de_ATs_Estatus = _IEstatus_de_Resolucion_de_ATApiConsumer.SelAll(true);
            if (Estatus_de_Resolucion_de_ATs_Estatus != null && Estatus_de_Resolucion_de_ATs_Estatus.Resource != null)
                ViewBag.Estatus_de_Resolucion_de_ATs_Estatus = Estatus_de_Resolucion_de_ATs_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Resolucion_de_AT", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddResolucion_AT", varResolucion_AT);
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
        public ActionResult GetEstatus_de_Resolucion_de_ATAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_Resolucion_de_ATApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_Resolucion_de_ATApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Resolucion_de_AT", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetResolucionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResolucionApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetDetalle_de_RelacionesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_RelacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_RelacionesApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Relaciones", "Descripcion")?? m.Descripcion,
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



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Resolucion_ATAdvanceSearchModel model, int idFilter = -1)
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

            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_Modulo_Atencion_Inicial != null && Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource.Where(m => m.NUAT != null).OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT") ?? m.NUAT.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Persona_que_Resuelve = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Persona_que_Resuelve != null && Spartan_Users_Persona_que_Resuelve.Resource != null)
                ViewBag.Spartan_Users_Persona_que_Resuelve = Spartan_Users_Persona_que_Resuelve.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IEstatus_de_Resolucion_de_ATApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Resolucion_de_ATs_Estatus = _IEstatus_de_Resolucion_de_ATApiConsumer.SelAll(true);
            if (Estatus_de_Resolucion_de_ATs_Estatus != null && Estatus_de_Resolucion_de_ATs_Estatus.Resource != null)
                ViewBag.Estatus_de_Resolucion_de_ATs_Estatus = Estatus_de_Resolucion_de_ATs_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Resolucion_de_AT", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_Modulo_Atencion_Inicial != null && Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_Modulo_Atencion_Inicial = Modulo_Atencion_Inicials_Modulo_Atencion_Inicial.Resource.Where(m => m.NUAT != null).OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT") ?? m.NUAT.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Persona_que_Resuelve = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Persona_que_Resuelve != null && Spartan_Users_Persona_que_Resuelve.Resource != null)
                ViewBag.Spartan_Users_Persona_que_Resuelve = Spartan_Users_Persona_que_Resuelve.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IEstatus_de_Resolucion_de_ATApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Resolucion_de_ATs_Estatus = _IEstatus_de_Resolucion_de_ATApiConsumer.SelAll(true);
            if (Estatus_de_Resolucion_de_ATs_Estatus != null && Estatus_de_Resolucion_de_ATs_Estatus.Resource != null)
                ViewBag.Estatus_de_Resolucion_de_ATs_Estatus = Estatus_de_Resolucion_de_ATs_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Resolucion_de_AT", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Resolucion_ATAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Resolucion_ATAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Resolucion_ATAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Resolucion_ATPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IResolucion_ATApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Resolucion_ATs == null)
                result.Resolucion_ATs = new List<Resolucion_AT>();

            return Json(new
            {
                data = result.Resolucion_ATs.Select(m => new Resolucion_ATGridModel
                    {
                    Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                        ,Persona_que_ResuelveName = CultureHelper.GetTraduction(m.Persona_que_Resuelve_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Persona_que_Resuelve_Spartan_User.Name
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Resolucion_de_AT.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Resolucion_de_AT.Descripcion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resolucion_Resolucion.Descripcion
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Relacion_Detalle_de_Relaciones.Descripcion
			,Observaciones = m.Observaciones
                        ,Fecha_de_Validacion = (m.Fecha_de_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion = m.Hora_de_Validacion
                        ,DictaminadorName = CultureHelper.GetTraduction(m.Dictaminador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Dictaminador_Spartan_User.Name
                        ,Resultado_de_ValidacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Validacion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resultado_de_Validacion_Resolucion.Descripcion
			,Observaciones_Dictaminador = m.Observaciones_Dictaminador

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetResolucion_ATAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_ATApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResolucion_ATApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Resolucion_AT", m.),
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
        /// Get List of Resolucion_AT from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Resolucion_AT Entity</returns>
        public ActionResult GetResolucion_ATList(UrlParametersModel param)
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
            _IResolucion_ATApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Resolucion_ATPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Resolucion_ATAdvanceSearchModel))
                {
					var advanceFilter =
                    (Resolucion_ATAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Resolucion_ATPropertyMapper oResolucion_ATPropertyMapper = new Resolucion_ATPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oResolucion_ATPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IResolucion_ATApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Resolucion_ATs == null)
                result.Resolucion_ATs = new List<Resolucion_AT>();

            return Json(new
            {
                aaData = result.Resolucion_ATs.Select(m => new Resolucion_ATGridModel
            {
                    Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                        ,Persona_que_ResuelveName = CultureHelper.GetTraduction(m.Persona_que_Resuelve_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Persona_que_Resuelve_Spartan_User.Name
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Resolucion_de_AT.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Resolucion_de_AT.Descripcion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resolucion_Resolucion.Descripcion
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Relacion_Detalle_de_Relaciones.Descripcion
			,Observaciones = m.Observaciones
                        ,Fecha_de_Validacion = (m.Fecha_de_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion = m.Hora_de_Validacion
                        ,DictaminadorName = CultureHelper.GetTraduction(m.Dictaminador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Dictaminador_Spartan_User.Name
                        ,Resultado_de_ValidacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Validacion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resultado_de_Validacion_Resolucion.Descripcion
			,Observaciones_Dictaminador = m.Observaciones_Dictaminador

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetResolucion_AT_Resolucion_Resolucion(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Resolucion.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Resolucion.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IResolucionApiConsumer.ListaSelAll(1, 20,elWhere , " Resolucion.Descripcion ASC ").Resource;
               
                foreach (var item in result.Resolucions)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Resolucion", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Resolucions.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetResolucion_AT_Relacion_Detalle_de_Relaciones(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_RelacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Relaciones.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Relaciones.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_RelacionesApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Relaciones.Descripcion ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Relacioness)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Relaciones", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Detalle_de_Relacioness.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetResolucion_AT_Dictaminador_Spartan_User(string query, string where)
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
        public JsonResult GetResolucion_AT_Resultado_de_Validacion_Resolucion(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Resolucion.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Resolucion.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IResolucionApiConsumer.ListaSelAll(1, 20,elWhere , " Resolucion.Descripcion ASC ").Resource;
               
                foreach (var item in result.Resolucions)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Resolucion", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Resolucions.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public string GetAdvanceFilter(Resolucion_ATAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Resolucion_AT.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Resolucion_AT.Clave <= " + filter.ToClave;
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

                where += " AND Resolucion_AT.Modulo_Atencion_Inicial In (" + Modulo_Atencion_InicialIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Resolucion) || !string.IsNullOrEmpty(filter.ToFecha_de_Resolucion))
            {
                var Fecha_de_ResolucionFrom = DateTime.ParseExact(filter.FromFecha_de_Resolucion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_ResolucionTo = DateTime.ParseExact(filter.ToFecha_de_Resolucion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Resolucion))
                    where += " AND Resolucion_AT.Fecha_de_Resolucion >= '" + Fecha_de_ResolucionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Resolucion))
                    where += " AND Resolucion_AT.Fecha_de_Resolucion <= '" + Fecha_de_ResolucionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePersona_que_Resuelve))
            {
                switch (filter.Persona_que_ResuelveFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvancePersona_que_Resuelve + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvancePersona_que_Resuelve + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvancePersona_que_Resuelve + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvancePersona_que_Resuelve + "%'";
                        break;
                }
            }
            else if (filter.AdvancePersona_que_ResuelveMultiple != null && filter.AdvancePersona_que_ResuelveMultiple.Count() > 0)
            {
                var Persona_que_ResuelveIds = string.Join(",", filter.AdvancePersona_que_ResuelveMultiple);

                where += " AND Resolucion_AT.Persona_que_Resuelve In (" + Persona_que_ResuelveIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_de_Resolucion_de_AT.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_de_Resolucion_de_AT.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_de_Resolucion_de_AT.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_de_Resolucion_de_AT.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Resolucion_AT.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResolucion))
            {
                switch (filter.ResolucionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion.Descripcion LIKE '" + filter.AdvanceResolucion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion.Descripcion LIKE '%" + filter.AdvanceResolucion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion.Descripcion = '" + filter.AdvanceResolucion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion.Descripcion LIKE '%" + filter.AdvanceResolucion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResolucionMultiple != null && filter.AdvanceResolucionMultiple.Count() > 0)
            {
                var ResolucionIds = string.Join(",", filter.AdvanceResolucionMultiple);

                where += " AND Resolucion_AT.Resolucion In (" + ResolucionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRelacion))
            {
                switch (filter.RelacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Relaciones.Descripcion LIKE '" + filter.AdvanceRelacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Relaciones.Descripcion LIKE '%" + filter.AdvanceRelacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Relaciones.Descripcion = '" + filter.AdvanceRelacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Relaciones.Descripcion LIKE '%" + filter.AdvanceRelacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRelacionMultiple != null && filter.AdvanceRelacionMultiple.Count() > 0)
            {
                var RelacionIds = string.Join(",", filter.AdvanceRelacionMultiple);

                where += " AND Resolucion_AT.Relacion In (" + RelacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion_AT.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion_AT.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion_AT.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion_AT.Observaciones LIKE '%" + filter.Observaciones + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Validacion) || !string.IsNullOrEmpty(filter.ToFecha_de_Validacion))
            {
                var Fecha_de_ValidacionFrom = DateTime.ParseExact(filter.FromFecha_de_Validacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_ValidacionTo = DateTime.ParseExact(filter.ToFecha_de_Validacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Validacion))
                    where += " AND Resolucion_AT.Fecha_de_Validacion >= '" + Fecha_de_ValidacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Validacion))
                    where += " AND Resolucion_AT.Fecha_de_Validacion <= '" + Fecha_de_ValidacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Validacion) || !string.IsNullOrEmpty(filter.ToHora_de_Validacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Validacion))
                    where += " AND Convert(TIME,Resolucion_AT.Hora_de_Validacion) >='" + filter.FromHora_de_Validacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Validacion))
                    where += " AND Convert(TIME,Resolucion_AT.Hora_de_Validacion) <='" + filter.ToHora_de_Validacion + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDictaminador))
            {
                switch (filter.DictaminadorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceDictaminador + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceDictaminador + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceDictaminador + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceDictaminador + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDictaminadorMultiple != null && filter.AdvanceDictaminadorMultiple.Count() > 0)
            {
                var DictaminadorIds = string.Join(",", filter.AdvanceDictaminadorMultiple);

                where += " AND Resolucion_AT.Dictaminador In (" + DictaminadorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResultado_de_Validacion))
            {
                switch (filter.Resultado_de_ValidacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion.Descripcion LIKE '" + filter.AdvanceResultado_de_Validacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion.Descripcion LIKE '%" + filter.AdvanceResultado_de_Validacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion.Descripcion = '" + filter.AdvanceResultado_de_Validacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion.Descripcion LIKE '%" + filter.AdvanceResultado_de_Validacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResultado_de_ValidacionMultiple != null && filter.AdvanceResultado_de_ValidacionMultiple.Count() > 0)
            {
                var Resultado_de_ValidacionIds = string.Join(",", filter.AdvanceResultado_de_ValidacionMultiple);

                where += " AND Resolucion_AT.Resultado_de_Validacion In (" + Resultado_de_ValidacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_Dictaminador))
            {
                switch (filter.Observaciones_DictaminadorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion_AT.Observaciones_Dictaminador LIKE '" + filter.Observaciones_Dictaminador + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion_AT.Observaciones_Dictaminador LIKE '%" + filter.Observaciones_Dictaminador + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion_AT.Observaciones_Dictaminador = '" + filter.Observaciones_Dictaminador + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion_AT.Observaciones_Dictaminador LIKE '%" + filter.Observaciones_Dictaminador + "%'";
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



        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_ATApiConsumer.SetAuthHeader(_tokenManager.Token);

                Resolucion_AT varResolucion_AT = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IResolucion_ATApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Resolucion_ATModel varResolucion_AT)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IResolucion_ATApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Resolucion_ATInfo = new Resolucion_AT
                    {
                        Clave = varResolucion_AT.Clave
                        ,Modulo_Atencion_Inicial = varResolucion_AT.Modulo_Atencion_Inicial
                        ,Fecha_de_Resolucion = (!String.IsNullOrEmpty(varResolucion_AT.Fecha_de_Resolucion)) ? DateTime.ParseExact(varResolucion_AT.Fecha_de_Resolucion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Persona_que_Resuelve = varResolucion_AT.Persona_que_Resuelve
                        ,Estatus = varResolucion_AT.Estatus
                        ,Resolucion = varResolucion_AT.Resolucion
                        ,Relacion = varResolucion_AT.Relacion
                        ,Observaciones = varResolucion_AT.Observaciones
                        ,Fecha_de_Validacion = (!String.IsNullOrEmpty(varResolucion_AT.Fecha_de_Validacion)) ? DateTime.ParseExact(varResolucion_AT.Fecha_de_Validacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Validacion = varResolucion_AT.Hora_de_Validacion
                        ,Dictaminador = varResolucion_AT.Dictaminador
                        ,Resultado_de_Validacion = varResolucion_AT.Resultado_de_Validacion
                        ,Observaciones_Dictaminador = varResolucion_AT.Observaciones_Dictaminador

                    };

                    result = !IsNew ?
                        _IResolucion_ATApiConsumer.Update(Resolucion_ATInfo, null, null).Resource.ToString() :
                         _IResolucion_ATApiConsumer.Insert(Resolucion_ATInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Resolucion_AT script
        /// </summary>
        /// <param name="oResolucion_ATElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Resolucion_ATModuleAttributeList)
        {
            for (int i = 0; i < Resolucion_ATModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Resolucion_ATModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Resolucion_ATModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Resolucion_ATModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Resolucion_ATModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Resolucion_ATModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Resolucion_ATModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Resolucion_ATModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Resolucion_ATModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Resolucion_ATModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Resolucion_ATModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Resolucion_ATModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strResolucion_ATScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Resolucion_AT.js")))
            {
                strResolucion_ATScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Resolucion_AT element attributes
            string userChangeJson = jsSerialize.Serialize(Resolucion_ATModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strResolucion_ATScript.IndexOf("inpuElementArray");
            string splittedString = strResolucion_ATScript.Substring(indexOfArray, strResolucion_ATScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Resolucion_ATModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Resolucion_ATModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strResolucion_ATScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strResolucion_ATScript.Substring(indexOfArrayHistory, strResolucion_ATScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strResolucion_ATScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strResolucion_ATScript.Substring(endIndexOfMainElement + indexOfArray, strResolucion_ATScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Resolucion_ATModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Resolucion_ATModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Resolucion_AT.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Resolucion_AT.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Resolucion_AT.js")))
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
        public ActionResult Resolucion_ATPropertyBag()
        {
            return PartialView("Resolucion_ATPropertyBag", "Resolucion_AT");
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
                var whereClauseFormat = "Object = 46209 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IResolucion_ATApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Resolucion_AT.Clave= " + RecordId;
                            var result = _IResolucion_ATApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IResolucion_ATApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Resolucion_ATPropertyMapper());
			
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
                    (Resolucion_ATAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Resolucion_ATPropertyMapper oResolucion_ATPropertyMapper = new Resolucion_ATPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oResolucion_ATPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IResolucion_ATApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Resolucion_ATs == null)
                result.Resolucion_ATs = new List<Resolucion_AT>();

            var data = result.Resolucion_ATs.Select(m => new Resolucion_ATGridModel
            {
                Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                        ,Persona_que_ResuelveName = CultureHelper.GetTraduction(m.Persona_que_Resuelve_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Persona_que_Resuelve_Spartan_User.Name
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Resolucion_de_AT.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Resolucion_de_AT.Descripcion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resolucion_Resolucion.Descripcion
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Relacion_Detalle_de_Relaciones.Descripcion
			,Observaciones = m.Observaciones
                        ,Fecha_de_Validacion = (m.Fecha_de_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion = m.Hora_de_Validacion
                        ,DictaminadorName = CultureHelper.GetTraduction(m.Dictaminador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Dictaminador_Spartan_User.Name
                        ,Resultado_de_ValidacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Validacion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resultado_de_Validacion_Resolucion.Descripcion
			,Observaciones_Dictaminador = m.Observaciones_Dictaminador

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(46209, arrayColumnsVisible), "Resolucion_ATList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(46209, arrayColumnsVisible), "Resolucion_ATList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(46209, arrayColumnsVisible), "Resolucion_ATList_" + DateTime.Now.ToString());
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

            _IResolucion_ATApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Resolucion_ATPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Resolucion_ATAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Resolucion_ATPropertyMapper oResolucion_ATPropertyMapper = new Resolucion_ATPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oResolucion_ATPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IResolucion_ATApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Resolucion_ATs == null)
                result.Resolucion_ATs = new List<Resolucion_AT>();

            var data = result.Resolucion_ATs.Select(m => new Resolucion_ATGridModel
            {
                Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                        ,Persona_que_ResuelveName = CultureHelper.GetTraduction(m.Persona_que_Resuelve_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Persona_que_Resuelve_Spartan_User.Name
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Resolucion_de_AT.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Resolucion_de_AT.Descripcion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resolucion_Resolucion.Descripcion
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Relacion_Detalle_de_Relaciones.Descripcion
			,Observaciones = m.Observaciones
                        ,Fecha_de_Validacion = (m.Fecha_de_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion = m.Hora_de_Validacion
                        ,DictaminadorName = CultureHelper.GetTraduction(m.Dictaminador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Dictaminador_Spartan_User.Name
                        ,Resultado_de_ValidacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Validacion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resultado_de_Validacion_Resolucion.Descripcion
			,Observaciones_Dictaminador = m.Observaciones_Dictaminador

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
                _IResolucion_ATApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResolucion_ATApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Resolucion_AT_Datos_GeneralesModel varResolucion_AT)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_ATApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Resolucion_AT_Datos_GeneralesInfo = new Resolucion_AT_Datos_Generales
                {
                    Clave = varResolucion_AT.Clave
                                            ,Modulo_Atencion_Inicial = varResolucion_AT.Modulo_Atencion_Inicial
                        ,Fecha_de_Resolucion = (!String.IsNullOrEmpty(varResolucion_AT.Fecha_de_Resolucion)) ? DateTime.ParseExact(varResolucion_AT.Fecha_de_Resolucion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Persona_que_Resuelve = varResolucion_AT.Persona_que_Resuelve
                        ,Estatus = varResolucion_AT.Estatus
                        ,Resolucion = varResolucion_AT.Resolucion
                        ,Relacion = varResolucion_AT.Relacion
                        ,Observaciones = varResolucion_AT.Observaciones
                    
                };

                result = _IResolucion_ATApiConsumer.Update_Datos_Generales(Resolucion_AT_Datos_GeneralesInfo).Resource.ToString();
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
                _IResolucion_ATApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IResolucion_ATApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Resolucion_AT_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Modulo_Atencion_Inicial = m.Modulo_Atencion_Inicial
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                        ,Persona_que_Resuelve = m.Persona_que_Resuelve
                        ,Persona_que_ResuelveName = CultureHelper.GetTraduction(m.Persona_que_Resuelve_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Persona_que_Resuelve_Spartan_User.Name
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Resolucion_de_AT.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Resolucion_de_AT.Descripcion
                        ,Resolucion = m.Resolucion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resolucion_Resolucion.Descripcion
                        ,Relacion = m.Relacion
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Relacion_Detalle_de_Relaciones.Descripcion
			,Observaciones = m.Observaciones

                    
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
        public ActionResult Post_Dictaminacion(Resolucion_AT_DictaminacionModel varResolucion_AT)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_ATApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Resolucion_AT_DictaminacionInfo = new Resolucion_AT_Dictaminacion
                {
                    Clave = varResolucion_AT.Clave
                                            ,Fecha_de_Validacion = (!String.IsNullOrEmpty(varResolucion_AT.Fecha_de_Validacion)) ? DateTime.ParseExact(varResolucion_AT.Fecha_de_Validacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Validacion = varResolucion_AT.Hora_de_Validacion
                        ,Dictaminador = varResolucion_AT.Dictaminador
                        ,Resultado_de_Validacion = varResolucion_AT.Resultado_de_Validacion
                        ,Observaciones_Dictaminador = varResolucion_AT.Observaciones_Dictaminador
                    
                };

                result = _IResolucion_ATApiConsumer.Update_Dictaminacion(Resolucion_AT_DictaminacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Dictaminacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_ATApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IResolucion_ATApiConsumer.Get_Dictaminacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Resolucion_AT_DictaminacionModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Validacion = (m.Fecha_de_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion = m.Hora_de_Validacion
                        ,Dictaminador = m.Dictaminador
                        ,DictaminadorName = CultureHelper.GetTraduction(m.Dictaminador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Dictaminador_Spartan_User.Name
                        ,Resultado_de_Validacion = m.Resultado_de_Validacion
                        ,Resultado_de_ValidacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Validacion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resultado_de_Validacion_Resolucion.Descripcion
			,Observaciones_Dictaminador = m.Observaciones_Dictaminador

                    
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

