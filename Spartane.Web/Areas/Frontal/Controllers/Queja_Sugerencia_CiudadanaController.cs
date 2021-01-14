using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Queja_Sugerencia_Ciudadana;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_queja_sugerencia;
using Spartane.Core.Domain.Estatus_queja_sugerencia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Queja_Sugerencia_Ciudadana;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Queja_Sugerencia_Ciudadana;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_queja_sugerencia;
using Spartane.Web.Areas.WebApiConsumer.Estatus_queja_sugerencia;

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
    public class Queja_Sugerencia_CiudadanaController : Controller
    {
        #region "variable declaration"

        private IQueja_Sugerencia_CiudadanaService service = null;
        private IQueja_Sugerencia_CiudadanaApiConsumer _IQueja_Sugerencia_CiudadanaApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ITipo_de_queja_sugerenciaApiConsumer _ITipo_de_queja_sugerenciaApiConsumer;
        private IEstatus_queja_sugerenciaApiConsumer _IEstatus_queja_sugerenciaApiConsumer;

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

        
        public Queja_Sugerencia_CiudadanaController(IQueja_Sugerencia_CiudadanaService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IQueja_Sugerencia_CiudadanaApiConsumer Queja_Sugerencia_CiudadanaApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ITipo_de_queja_sugerenciaApiConsumer Tipo_de_queja_sugerenciaApiConsumer , IEstatus_queja_sugerenciaApiConsumer Estatus_queja_sugerenciaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IQueja_Sugerencia_CiudadanaApiConsumer = Queja_Sugerencia_CiudadanaApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ITipo_de_queja_sugerenciaApiConsumer = Tipo_de_queja_sugerenciaApiConsumer;
            this._IEstatus_queja_sugerenciaApiConsumer = Estatus_queja_sugerenciaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Queja_Sugerencia_Ciudadana
        [ObjectAuth(ObjectId = (ModuleObjectId)45729, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45729, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Queja_Sugerencia_Ciudadana/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45729, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45729, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varQueja_Sugerencia_Ciudadana = new Queja_Sugerencia_CiudadanaModel();
			varQueja_Sugerencia_Ciudadana.Folio = Id;
			
            ViewBag.ObjectId = "45729";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IQueja_Sugerencia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Queja_Sugerencia_CiudadanasData = _IQueja_Sugerencia_CiudadanaApiConsumer.ListaSelAll(0, 1000, "Queja_Sugerencia_Ciudadana.Folio=" + Id, "").Resource.Queja_Sugerencia_Ciudadanas;
				
				if (Queja_Sugerencia_CiudadanasData != null && Queja_Sugerencia_CiudadanasData.Count > 0)
                {
					var Queja_Sugerencia_CiudadanaData = Queja_Sugerencia_CiudadanasData.First();
					varQueja_Sugerencia_Ciudadana= new Queja_Sugerencia_CiudadanaModel
					{
						Folio  = Queja_Sugerencia_CiudadanaData.Folio 
	                    ,Fecha_de_Registro = (Queja_Sugerencia_CiudadanaData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Queja_Sugerencia_CiudadanaData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Queja_Sugerencia_CiudadanaData.Hora_de_Registro
                    ,Usuario_que_Registra = Queja_Sugerencia_CiudadanaData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Queja_Sugerencia_CiudadanaData.Usuario_que_Registra), "Spartan_User") ??  (string)Queja_Sugerencia_CiudadanaData.Usuario_que_Registra_Spartan_User.Name
                    ,Tipo_de_Registro = Queja_Sugerencia_CiudadanaData.Tipo_de_Registro
                    ,Tipo_de_RegistroDescripcion = CultureHelper.GetTraduction(Convert.ToString(Queja_Sugerencia_CiudadanaData.Tipo_de_Registro), "Tipo_de_queja_sugerencia") ??  (string)Queja_Sugerencia_CiudadanaData.Tipo_de_Registro_Tipo_de_queja_sugerencia.Descripcion
                    ,Queja = Queja_Sugerencia_CiudadanaData.Queja
                    ,Sugerencia = Queja_Sugerencia_CiudadanaData.Sugerencia
                    ,Estatus = Queja_Sugerencia_CiudadanaData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Queja_Sugerencia_CiudadanaData.Estatus), "Estatus_queja_sugerencia") ??  (string)Queja_Sugerencia_CiudadanaData.Estatus_Estatus_queja_sugerencia.Descripcion
                    ,Motivo_de_Eliminacion = Queja_Sugerencia_CiudadanaData.Motivo_de_Eliminacion
                    ,Contestacion = Queja_Sugerencia_CiudadanaData.Contestacion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_queja_sugerenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_queja_sugerencias_Tipo_de_Registro = _ITipo_de_queja_sugerenciaApiConsumer.SelAll(true);
            if (Tipo_de_queja_sugerencias_Tipo_de_Registro != null && Tipo_de_queja_sugerencias_Tipo_de_Registro.Resource != null)
                ViewBag.Tipo_de_queja_sugerencias_Tipo_de_Registro = Tipo_de_queja_sugerencias_Tipo_de_Registro.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_queja_sugerencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_queja_sugerenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_queja_sugerencias_Estatus = _IEstatus_queja_sugerenciaApiConsumer.SelAll(true);
            if (Estatus_queja_sugerencias_Estatus != null && Estatus_queja_sugerencias_Estatus.Resource != null)
                ViewBag.Estatus_queja_sugerencias_Estatus = Estatus_queja_sugerencias_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_queja_sugerencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varQueja_Sugerencia_Ciudadana);
        }
		
	[HttpGet]
        public ActionResult AddQueja_Sugerencia_Ciudadana(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45729);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IQueja_Sugerencia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
			Queja_Sugerencia_CiudadanaModel varQueja_Sugerencia_Ciudadana= new Queja_Sugerencia_CiudadanaModel();


            if (id.ToString() != "0")
            {
                var Queja_Sugerencia_CiudadanasData = _IQueja_Sugerencia_CiudadanaApiConsumer.ListaSelAll(0, 1000, "Queja_Sugerencia_Ciudadana.Folio=" + id, "").Resource.Queja_Sugerencia_Ciudadanas;
				
				if (Queja_Sugerencia_CiudadanasData != null && Queja_Sugerencia_CiudadanasData.Count > 0)
                {
					var Queja_Sugerencia_CiudadanaData = Queja_Sugerencia_CiudadanasData.First();
					varQueja_Sugerencia_Ciudadana= new Queja_Sugerencia_CiudadanaModel
					{
						Folio  = Queja_Sugerencia_CiudadanaData.Folio 
	                    ,Fecha_de_Registro = (Queja_Sugerencia_CiudadanaData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Queja_Sugerencia_CiudadanaData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Queja_Sugerencia_CiudadanaData.Hora_de_Registro
                    ,Usuario_que_Registra = Queja_Sugerencia_CiudadanaData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Queja_Sugerencia_CiudadanaData.Usuario_que_Registra), "Spartan_User") ??  (string)Queja_Sugerencia_CiudadanaData.Usuario_que_Registra_Spartan_User.Name
                    ,Tipo_de_Registro = Queja_Sugerencia_CiudadanaData.Tipo_de_Registro
                    ,Tipo_de_RegistroDescripcion = CultureHelper.GetTraduction(Convert.ToString(Queja_Sugerencia_CiudadanaData.Tipo_de_Registro), "Tipo_de_queja_sugerencia") ??  (string)Queja_Sugerencia_CiudadanaData.Tipo_de_Registro_Tipo_de_queja_sugerencia.Descripcion
                    ,Queja = Queja_Sugerencia_CiudadanaData.Queja
                    ,Sugerencia = Queja_Sugerencia_CiudadanaData.Sugerencia
                    ,Estatus = Queja_Sugerencia_CiudadanaData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Queja_Sugerencia_CiudadanaData.Estatus), "Estatus_queja_sugerencia") ??  (string)Queja_Sugerencia_CiudadanaData.Estatus_Estatus_queja_sugerencia.Descripcion
                    ,Motivo_de_Eliminacion = Queja_Sugerencia_CiudadanaData.Motivo_de_Eliminacion
                    ,Contestacion = Queja_Sugerencia_CiudadanaData.Contestacion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_queja_sugerenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_queja_sugerencias_Tipo_de_Registro = _ITipo_de_queja_sugerenciaApiConsumer.SelAll(true);
            if (Tipo_de_queja_sugerencias_Tipo_de_Registro != null && Tipo_de_queja_sugerencias_Tipo_de_Registro.Resource != null)
                ViewBag.Tipo_de_queja_sugerencias_Tipo_de_Registro = Tipo_de_queja_sugerencias_Tipo_de_Registro.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_queja_sugerencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_queja_sugerenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_queja_sugerencias_Estatus = _IEstatus_queja_sugerenciaApiConsumer.SelAll(true);
            if (Estatus_queja_sugerencias_Estatus != null && Estatus_queja_sugerencias_Estatus.Resource != null)
                ViewBag.Estatus_queja_sugerencias_Estatus = Estatus_queja_sugerencias_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_queja_sugerencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddQueja_Sugerencia_Ciudadana", varQueja_Sugerencia_Ciudadana);
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
        public ActionResult GetTipo_de_queja_sugerenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_queja_sugerenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_queja_sugerenciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_queja_sugerencia", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatus_queja_sugerenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_queja_sugerenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_queja_sugerenciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_queja_sugerencia", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Queja_Sugerencia_CiudadanaAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_queja_sugerenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_queja_sugerencias_Tipo_de_Registro = _ITipo_de_queja_sugerenciaApiConsumer.SelAll(true);
            if (Tipo_de_queja_sugerencias_Tipo_de_Registro != null && Tipo_de_queja_sugerencias_Tipo_de_Registro.Resource != null)
                ViewBag.Tipo_de_queja_sugerencias_Tipo_de_Registro = Tipo_de_queja_sugerencias_Tipo_de_Registro.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_queja_sugerencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_queja_sugerenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_queja_sugerencias_Estatus = _IEstatus_queja_sugerenciaApiConsumer.SelAll(true);
            if (Estatus_queja_sugerencias_Estatus != null && Estatus_queja_sugerencias_Estatus.Resource != null)
                ViewBag.Estatus_queja_sugerencias_Estatus = Estatus_queja_sugerencias_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_queja_sugerencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_queja_sugerenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_queja_sugerencias_Tipo_de_Registro = _ITipo_de_queja_sugerenciaApiConsumer.SelAll(true);
            if (Tipo_de_queja_sugerencias_Tipo_de_Registro != null && Tipo_de_queja_sugerencias_Tipo_de_Registro.Resource != null)
                ViewBag.Tipo_de_queja_sugerencias_Tipo_de_Registro = Tipo_de_queja_sugerencias_Tipo_de_Registro.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_queja_sugerencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_queja_sugerenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_queja_sugerencias_Estatus = _IEstatus_queja_sugerenciaApiConsumer.SelAll(true);
            if (Estatus_queja_sugerencias_Estatus != null && Estatus_queja_sugerencias_Estatus.Resource != null)
                ViewBag.Estatus_queja_sugerencias_Estatus = Estatus_queja_sugerencias_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_queja_sugerencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Queja_Sugerencia_CiudadanaAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Queja_Sugerencia_CiudadanaAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Queja_Sugerencia_CiudadanaAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Queja_Sugerencia_CiudadanaPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IQueja_Sugerencia_CiudadanaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Queja_Sugerencia_Ciudadanas == null)
                result.Queja_Sugerencia_Ciudadanas = new List<Queja_Sugerencia_Ciudadana>();

            return Json(new
            {
                data = result.Queja_Sugerencia_Ciudadanas.Select(m => new Queja_Sugerencia_CiudadanaGridModel
                    {
                    Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_RegistroDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Registro_Tipo_de_queja_sugerencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Registro_Tipo_de_queja_sugerencia.Descripcion
			,Queja = m.Queja
			,Sugerencia = m.Sugerencia
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_queja_sugerencia.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_queja_sugerencia.Descripcion
			,Motivo_de_Eliminacion = m.Motivo_de_Eliminacion
			,Contestacion = m.Contestacion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetQueja_Sugerencia_CiudadanaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IQueja_Sugerencia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IQueja_Sugerencia_CiudadanaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Folio), "Queja_Sugerencia_Ciudadana", m.),
                     Value = Convert.ToString(m.Folio)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
*/
        /// <summary>
        /// Get List of Queja_Sugerencia_Ciudadana from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Queja_Sugerencia_Ciudadana Entity</returns>
        public ActionResult GetQueja_Sugerencia_CiudadanaList(UrlParametersModel param)
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
            _IQueja_Sugerencia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Queja_Sugerencia_CiudadanaPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Queja_Sugerencia_CiudadanaAdvanceSearchModel))
                {
					var advanceFilter =
                    (Queja_Sugerencia_CiudadanaAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Queja_Sugerencia_CiudadanaPropertyMapper oQueja_Sugerencia_CiudadanaPropertyMapper = new Queja_Sugerencia_CiudadanaPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oQueja_Sugerencia_CiudadanaPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IQueja_Sugerencia_CiudadanaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Queja_Sugerencia_Ciudadanas == null)
                result.Queja_Sugerencia_Ciudadanas = new List<Queja_Sugerencia_Ciudadana>();

            return Json(new
            {
                aaData = result.Queja_Sugerencia_Ciudadanas.Select(m => new Queja_Sugerencia_CiudadanaGridModel
            {
                    Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_RegistroDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Registro_Tipo_de_queja_sugerencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Registro_Tipo_de_queja_sugerencia.Descripcion
			,Queja = m.Queja
			,Sugerencia = m.Sugerencia
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_queja_sugerencia.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_queja_sugerencia.Descripcion
			,Motivo_de_Eliminacion = m.Motivo_de_Eliminacion
			,Contestacion = m.Contestacion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetQueja_Sugerencia_Ciudadana_Usuario_que_Registra_Spartan_User(string query, string where)
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





        [NonAction]
        public string GetAdvanceFilter(Queja_Sugerencia_CiudadanaAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromFolio) || !string.IsNullOrEmpty(filter.ToFolio))
            {
                if (!string.IsNullOrEmpty(filter.FromFolio))
                    where += " AND Queja_Sugerencia_Ciudadana.Folio >= " + filter.FromFolio;
                if (!string.IsNullOrEmpty(filter.ToFolio))
                    where += " AND Queja_Sugerencia_Ciudadana.Folio <= " + filter.ToFolio;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Queja_Sugerencia_Ciudadana.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Queja_Sugerencia_Ciudadana.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Queja_Sugerencia_Ciudadana.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Queja_Sugerencia_Ciudadana.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
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

                where += " AND Queja_Sugerencia_Ciudadana.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Registro))
            {
                switch (filter.Tipo_de_RegistroFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_queja_sugerencia.Descripcion LIKE '" + filter.AdvanceTipo_de_Registro + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_queja_sugerencia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Registro + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_queja_sugerencia.Descripcion = '" + filter.AdvanceTipo_de_Registro + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_queja_sugerencia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Registro + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_RegistroMultiple != null && filter.AdvanceTipo_de_RegistroMultiple.Count() > 0)
            {
                var Tipo_de_RegistroIds = string.Join(",", filter.AdvanceTipo_de_RegistroMultiple);

                where += " AND Queja_Sugerencia_Ciudadana.Tipo_de_Registro In (" + Tipo_de_RegistroIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Queja))
            {
                switch (filter.QuejaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Queja_Sugerencia_Ciudadana.Queja LIKE '" + filter.Queja + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Queja_Sugerencia_Ciudadana.Queja LIKE '%" + filter.Queja + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Queja_Sugerencia_Ciudadana.Queja = '" + filter.Queja + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Queja_Sugerencia_Ciudadana.Queja LIKE '%" + filter.Queja + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Sugerencia))
            {
                switch (filter.SugerenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Queja_Sugerencia_Ciudadana.Sugerencia LIKE '" + filter.Sugerencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Queja_Sugerencia_Ciudadana.Sugerencia LIKE '%" + filter.Sugerencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Queja_Sugerencia_Ciudadana.Sugerencia = '" + filter.Sugerencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Queja_Sugerencia_Ciudadana.Sugerencia LIKE '%" + filter.Sugerencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_queja_sugerencia.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_queja_sugerencia.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_queja_sugerencia.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_queja_sugerencia.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Queja_Sugerencia_Ciudadana.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Motivo_de_Eliminacion))
            {
                switch (filter.Motivo_de_EliminacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Queja_Sugerencia_Ciudadana.Motivo_de_Eliminacion LIKE '" + filter.Motivo_de_Eliminacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Queja_Sugerencia_Ciudadana.Motivo_de_Eliminacion LIKE '%" + filter.Motivo_de_Eliminacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Queja_Sugerencia_Ciudadana.Motivo_de_Eliminacion = '" + filter.Motivo_de_Eliminacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Queja_Sugerencia_Ciudadana.Motivo_de_Eliminacion LIKE '%" + filter.Motivo_de_Eliminacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Contestacion))
            {
                switch (filter.ContestacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Queja_Sugerencia_Ciudadana.Contestacion LIKE '" + filter.Contestacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Queja_Sugerencia_Ciudadana.Contestacion LIKE '%" + filter.Contestacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Queja_Sugerencia_Ciudadana.Contestacion = '" + filter.Contestacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Queja_Sugerencia_Ciudadana.Contestacion LIKE '%" + filter.Contestacion + "%'";
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
                _IQueja_Sugerencia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);

                Queja_Sugerencia_Ciudadana varQueja_Sugerencia_Ciudadana = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IQueja_Sugerencia_CiudadanaApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Queja_Sugerencia_CiudadanaModel varQueja_Sugerencia_Ciudadana)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IQueja_Sugerencia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Queja_Sugerencia_CiudadanaInfo = new Queja_Sugerencia_Ciudadana
                    {
                        Folio = varQueja_Sugerencia_Ciudadana.Folio
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varQueja_Sugerencia_Ciudadana.Fecha_de_Registro)) ? DateTime.ParseExact(varQueja_Sugerencia_Ciudadana.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varQueja_Sugerencia_Ciudadana.Hora_de_Registro
                        ,Usuario_que_Registra = varQueja_Sugerencia_Ciudadana.Usuario_que_Registra
                        ,Tipo_de_Registro = varQueja_Sugerencia_Ciudadana.Tipo_de_Registro
                        ,Queja = varQueja_Sugerencia_Ciudadana.Queja
                        ,Sugerencia = varQueja_Sugerencia_Ciudadana.Sugerencia
                        ,Estatus = varQueja_Sugerencia_Ciudadana.Estatus
                        ,Motivo_de_Eliminacion = varQueja_Sugerencia_Ciudadana.Motivo_de_Eliminacion
                        ,Contestacion = varQueja_Sugerencia_Ciudadana.Contestacion

                    };

                    result = !IsNew ?
                        _IQueja_Sugerencia_CiudadanaApiConsumer.Update(Queja_Sugerencia_CiudadanaInfo, null, null).Resource.ToString() :
                         _IQueja_Sugerencia_CiudadanaApiConsumer.Insert(Queja_Sugerencia_CiudadanaInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Queja_Sugerencia_Ciudadana script
        /// </summary>
        /// <param name="oQueja_Sugerencia_CiudadanaElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Queja_Sugerencia_CiudadanaModuleAttributeList)
        {
            for (int i = 0; i < Queja_Sugerencia_CiudadanaModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Queja_Sugerencia_CiudadanaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Queja_Sugerencia_CiudadanaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Queja_Sugerencia_CiudadanaModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Queja_Sugerencia_CiudadanaModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Queja_Sugerencia_CiudadanaModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Queja_Sugerencia_CiudadanaModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Queja_Sugerencia_CiudadanaModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Queja_Sugerencia_CiudadanaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Queja_Sugerencia_CiudadanaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Queja_Sugerencia_CiudadanaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Queja_Sugerencia_CiudadanaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strQueja_Sugerencia_CiudadanaScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Queja_Sugerencia_Ciudadana.js")))
            {
                strQueja_Sugerencia_CiudadanaScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Queja_Sugerencia_Ciudadana element attributes
            string userChangeJson = jsSerialize.Serialize(Queja_Sugerencia_CiudadanaModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strQueja_Sugerencia_CiudadanaScript.IndexOf("inpuElementArray");
            string splittedString = strQueja_Sugerencia_CiudadanaScript.Substring(indexOfArray, strQueja_Sugerencia_CiudadanaScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Queja_Sugerencia_CiudadanaModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Queja_Sugerencia_CiudadanaModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strQueja_Sugerencia_CiudadanaScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strQueja_Sugerencia_CiudadanaScript.Substring(indexOfArrayHistory, strQueja_Sugerencia_CiudadanaScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strQueja_Sugerencia_CiudadanaScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strQueja_Sugerencia_CiudadanaScript.Substring(endIndexOfMainElement + indexOfArray, strQueja_Sugerencia_CiudadanaScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Queja_Sugerencia_CiudadanaModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Queja_Sugerencia_CiudadanaModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Queja_Sugerencia_Ciudadana.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Queja_Sugerencia_Ciudadana.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Queja_Sugerencia_Ciudadana.js")))
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
        public ActionResult Queja_Sugerencia_CiudadanaPropertyBag()
        {
            return PartialView("Queja_Sugerencia_CiudadanaPropertyBag", "Queja_Sugerencia_Ciudadana");
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
                var whereClauseFormat = "Object = 45729 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IQueja_Sugerencia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Queja_Sugerencia_Ciudadana.Folio= " + RecordId;
                            var result = _IQueja_Sugerencia_CiudadanaApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IQueja_Sugerencia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Queja_Sugerencia_CiudadanaPropertyMapper());
			
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
                    (Queja_Sugerencia_CiudadanaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Queja_Sugerencia_CiudadanaPropertyMapper oQueja_Sugerencia_CiudadanaPropertyMapper = new Queja_Sugerencia_CiudadanaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oQueja_Sugerencia_CiudadanaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IQueja_Sugerencia_CiudadanaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Queja_Sugerencia_Ciudadanas == null)
                result.Queja_Sugerencia_Ciudadanas = new List<Queja_Sugerencia_Ciudadana>();

            var data = result.Queja_Sugerencia_Ciudadanas.Select(m => new Queja_Sugerencia_CiudadanaGridModel
            {
                Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_RegistroDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Registro_Tipo_de_queja_sugerencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Registro_Tipo_de_queja_sugerencia.Descripcion
			,Queja = m.Queja
			,Sugerencia = m.Sugerencia
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_queja_sugerencia.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_queja_sugerencia.Descripcion
			,Motivo_de_Eliminacion = m.Motivo_de_Eliminacion
			,Contestacion = m.Contestacion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45729, arrayColumnsVisible), "Queja_Sugerencia_CiudadanaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45729, arrayColumnsVisible), "Queja_Sugerencia_CiudadanaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45729, arrayColumnsVisible), "Queja_Sugerencia_CiudadanaList_" + DateTime.Now.ToString());
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

            _IQueja_Sugerencia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Queja_Sugerencia_CiudadanaPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Queja_Sugerencia_CiudadanaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Queja_Sugerencia_CiudadanaPropertyMapper oQueja_Sugerencia_CiudadanaPropertyMapper = new Queja_Sugerencia_CiudadanaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oQueja_Sugerencia_CiudadanaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IQueja_Sugerencia_CiudadanaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Queja_Sugerencia_Ciudadanas == null)
                result.Queja_Sugerencia_Ciudadanas = new List<Queja_Sugerencia_Ciudadana>();

            var data = result.Queja_Sugerencia_Ciudadanas.Select(m => new Queja_Sugerencia_CiudadanaGridModel
            {
                Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_RegistroDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Registro_Tipo_de_queja_sugerencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Registro_Tipo_de_queja_sugerencia.Descripcion
			,Queja = m.Queja
			,Sugerencia = m.Sugerencia
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_queja_sugerencia.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_queja_sugerencia.Descripcion
			,Motivo_de_Eliminacion = m.Motivo_de_Eliminacion
			,Contestacion = m.Contestacion

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
                _IQueja_Sugerencia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IQueja_Sugerencia_CiudadanaApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Queja_Sugerencia_Ciudadana_Datos_GeneralesModel varQueja_Sugerencia_Ciudadana)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IQueja_Sugerencia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Queja_Sugerencia_Ciudadana_Datos_GeneralesInfo = new Queja_Sugerencia_Ciudadana_Datos_Generales
                {
                    Folio = varQueja_Sugerencia_Ciudadana.Folio
                                            ,Fecha_de_Registro = (!String.IsNullOrEmpty(varQueja_Sugerencia_Ciudadana.Fecha_de_Registro)) ? DateTime.ParseExact(varQueja_Sugerencia_Ciudadana.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varQueja_Sugerencia_Ciudadana.Hora_de_Registro
                        ,Usuario_que_Registra = varQueja_Sugerencia_Ciudadana.Usuario_que_Registra
                        ,Tipo_de_Registro = varQueja_Sugerencia_Ciudadana.Tipo_de_Registro
                        ,Queja = varQueja_Sugerencia_Ciudadana.Queja
                        ,Sugerencia = varQueja_Sugerencia_Ciudadana.Sugerencia
                        ,Estatus = varQueja_Sugerencia_Ciudadana.Estatus
                        ,Motivo_de_Eliminacion = varQueja_Sugerencia_Ciudadana.Motivo_de_Eliminacion
                        ,Contestacion = varQueja_Sugerencia_Ciudadana.Contestacion
                    
                };

                result = _IQueja_Sugerencia_CiudadanaApiConsumer.Update_Datos_Generales(Queja_Sugerencia_Ciudadana_Datos_GeneralesInfo).Resource.ToString();
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
                _IQueja_Sugerencia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IQueja_Sugerencia_CiudadanaApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Queja_Sugerencia_Ciudadana_Datos_GeneralesModel
                {
                    Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_Registro = m.Tipo_de_Registro
                        ,Tipo_de_RegistroDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Registro_Tipo_de_queja_sugerencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Registro_Tipo_de_queja_sugerencia.Descripcion
			,Queja = m.Queja
			,Sugerencia = m.Sugerencia
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_queja_sugerencia.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_queja_sugerencia.Descripcion
			,Motivo_de_Eliminacion = m.Motivo_de_Eliminacion
			,Contestacion = m.Contestacion

                    
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

