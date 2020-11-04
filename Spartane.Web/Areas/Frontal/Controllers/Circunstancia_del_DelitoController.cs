using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Circunstancia_del_Delito;
using Spartane.Core.Domain.Titulo_del_Delito;
using Spartane.Core.Domain.Grupo_del_Delito;
using Spartane.Core.Domain.Delito;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Circunstancia_del_Delito;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Titulo_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Grupo_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Delito;

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
    public class Circunstancia_del_DelitoController : Controller
    {
        #region "variable declaration"

        private ICircunstancia_del_DelitoService service = null;
        private ICircunstancia_del_DelitoApiConsumer _ICircunstancia_del_DelitoApiConsumer;
        private ITitulo_del_DelitoApiConsumer _ITitulo_del_DelitoApiConsumer;
        private IGrupo_del_DelitoApiConsumer _IGrupo_del_DelitoApiConsumer;
        private IDelitoApiConsumer _IDelitoApiConsumer;

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

        
        public Circunstancia_del_DelitoController(ICircunstancia_del_DelitoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ICircunstancia_del_DelitoApiConsumer Circunstancia_del_DelitoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ITitulo_del_DelitoApiConsumer Titulo_del_DelitoApiConsumer
, IGrupo_del_DelitoApiConsumer Grupo_del_DelitoApiConsumer
, IDelitoApiConsumer DelitoApiConsumer
)
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ICircunstancia_del_DelitoApiConsumer = Circunstancia_del_DelitoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ITitulo_del_DelitoApiConsumer = Titulo_del_DelitoApiConsumer;
            this._IGrupo_del_DelitoApiConsumer = Grupo_del_DelitoApiConsumer;
            this._IDelitoApiConsumer = DelitoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Circunstancia_del_Delito
        [ObjectAuth(ObjectId = (ModuleObjectId)44996, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44996, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Circunstancia_del_Delito/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)44996, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44996, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varCircunstancia_del_Delito = new Circunstancia_del_DelitoModel();
			varCircunstancia_del_Delito.Clave = Id;
			
            ViewBag.ObjectId = "44996";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Circunstancia_del_DelitosData = _ICircunstancia_del_DelitoApiConsumer.ListaSelAll(0, 1000, "Circunstancia_del_Delito.Clave=" + Id, "").Resource.Circunstancia_del_Delitos;
				
				if (Circunstancia_del_DelitosData != null && Circunstancia_del_DelitosData.Count > 0)
                {
					var Circunstancia_del_DelitoData = Circunstancia_del_DelitosData.First();
					varCircunstancia_del_Delito= new Circunstancia_del_DelitoModel
					{
						Clave  = Circunstancia_del_DelitoData.Clave 
	                    ,Titulo_del_Delito = Circunstancia_del_DelitoData.Titulo_del_Delito
                    ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Circunstancia_del_DelitoData.Titulo_del_Delito), "Titulo_del_Delito") ??  (string)Circunstancia_del_DelitoData.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                    ,Grupo_del_Delito = Circunstancia_del_DelitoData.Grupo_del_Delito
                    ,Grupo_del_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Circunstancia_del_DelitoData.Grupo_del_Delito), "Grupo_del_Delito") ??  (string)Circunstancia_del_DelitoData.Grupo_del_Delito_Grupo_del_Delito.Descripcion
                    ,Delito = Circunstancia_del_DelitoData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Circunstancia_del_DelitoData.Delito), "Delito") ??  (string)Circunstancia_del_DelitoData.Delito_Delito.Descripcion
                    ,Descripcion = Circunstancia_del_DelitoData.Descripcion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITitulo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Titulo_del_Delitos_Titulo_del_Delito = _ITitulo_del_DelitoApiConsumer.SelAll(true);
            if (Titulo_del_Delitos_Titulo_del_Delito != null && Titulo_del_Delitos_Titulo_del_Delito.Resource != null)
                ViewBag.Titulo_del_Delitos_Titulo_del_Delito = Titulo_del_Delitos_Titulo_del_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Titulo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_del_Delitos_Grupo_del_Delito = _IGrupo_del_DelitoApiConsumer.SelAll(true);
            if (Grupo_del_Delitos_Grupo_del_Delito != null && Grupo_del_Delitos_Grupo_del_Delito.Resource != null)
                ViewBag.Grupo_del_Delitos_Grupo_del_Delito = Grupo_del_Delitos_Grupo_del_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varCircunstancia_del_Delito);
        }
		
	[HttpGet]
        public ActionResult AddCircunstancia_del_Delito(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44996);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Circunstancia_del_DelitoModel varCircunstancia_del_Delito= new Circunstancia_del_DelitoModel();


            if (id.ToString() != "0")
            {
                var Circunstancia_del_DelitosData = _ICircunstancia_del_DelitoApiConsumer.ListaSelAll(0, 1000, "Circunstancia_del_Delito.Clave=" + id, "").Resource.Circunstancia_del_Delitos;
				
				if (Circunstancia_del_DelitosData != null && Circunstancia_del_DelitosData.Count > 0)
                {
					var Circunstancia_del_DelitoData = Circunstancia_del_DelitosData.First();
					varCircunstancia_del_Delito= new Circunstancia_del_DelitoModel
					{
						Clave  = Circunstancia_del_DelitoData.Clave 
	                    ,Titulo_del_Delito = Circunstancia_del_DelitoData.Titulo_del_Delito
                    ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Circunstancia_del_DelitoData.Titulo_del_Delito), "Titulo_del_Delito") ??  (string)Circunstancia_del_DelitoData.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                    ,Grupo_del_Delito = Circunstancia_del_DelitoData.Grupo_del_Delito
                    ,Grupo_del_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Circunstancia_del_DelitoData.Grupo_del_Delito), "Grupo_del_Delito") ??  (string)Circunstancia_del_DelitoData.Grupo_del_Delito_Grupo_del_Delito.Descripcion
                    ,Delito = Circunstancia_del_DelitoData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Circunstancia_del_DelitoData.Delito), "Delito") ??  (string)Circunstancia_del_DelitoData.Delito_Delito.Descripcion
                    ,Descripcion = Circunstancia_del_DelitoData.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITitulo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Titulo_del_Delitos_Titulo_del_Delito = _ITitulo_del_DelitoApiConsumer.SelAll(true);
            if (Titulo_del_Delitos_Titulo_del_Delito != null && Titulo_del_Delitos_Titulo_del_Delito.Resource != null)
                ViewBag.Titulo_del_Delitos_Titulo_del_Delito = Titulo_del_Delitos_Titulo_del_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Titulo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_del_Delitos_Grupo_del_Delito = _IGrupo_del_DelitoApiConsumer.SelAll(true);
            if (Grupo_del_Delitos_Grupo_del_Delito != null && Grupo_del_Delitos_Grupo_del_Delito.Resource != null)
                ViewBag.Grupo_del_Delitos_Grupo_del_Delito = Grupo_del_Delitos_Grupo_del_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddCircunstancia_del_Delito", varCircunstancia_del_Delito);
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
        public ActionResult GetTitulo_del_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITitulo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITitulo_del_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Titulo_del_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetGrupo_del_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGrupo_del_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
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



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Circunstancia_del_DelitoAdvanceSearchModel model, int idFilter = -1)
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

            _ITitulo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Titulo_del_Delitos_Titulo_del_Delito = _ITitulo_del_DelitoApiConsumer.SelAll(true);
            if (Titulo_del_Delitos_Titulo_del_Delito != null && Titulo_del_Delitos_Titulo_del_Delito.Resource != null)
                ViewBag.Titulo_del_Delitos_Titulo_del_Delito = Titulo_del_Delitos_Titulo_del_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Titulo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_del_Delitos_Grupo_del_Delito = _IGrupo_del_DelitoApiConsumer.SelAll(true);
            if (Grupo_del_Delitos_Grupo_del_Delito != null && Grupo_del_Delitos_Grupo_del_Delito.Resource != null)
                ViewBag.Grupo_del_Delitos_Grupo_del_Delito = Grupo_del_Delitos_Grupo_del_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITitulo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Titulo_del_Delitos_Titulo_del_Delito = _ITitulo_del_DelitoApiConsumer.SelAll(true);
            if (Titulo_del_Delitos_Titulo_del_Delito != null && Titulo_del_Delitos_Titulo_del_Delito.Resource != null)
                ViewBag.Titulo_del_Delitos_Titulo_del_Delito = Titulo_del_Delitos_Titulo_del_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Titulo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_del_Delitos_Grupo_del_Delito = _IGrupo_del_DelitoApiConsumer.SelAll(true);
            if (Grupo_del_Delitos_Grupo_del_Delito != null && Grupo_del_Delitos_Grupo_del_Delito.Resource != null)
                ViewBag.Grupo_del_Delitos_Grupo_del_Delito = Grupo_del_Delitos_Grupo_del_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Circunstancia_del_DelitoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Circunstancia_del_DelitoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Circunstancia_del_DelitoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Circunstancia_del_DelitoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ICircunstancia_del_DelitoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Circunstancia_del_Delitos == null)
                result.Circunstancia_del_Delitos = new List<Circunstancia_del_Delito>();

            return Json(new
            {
                data = result.Circunstancia_del_Delitos.Select(m => new Circunstancia_del_DelitoGridModel
                    {
                    Clave = m.Clave
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_del_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_del_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
			,Descripcion = m.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetCircunstancia_del_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstancia_del_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Circunstancia_del_Delito", m.),
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
        /// Get List of Circunstancia_del_Delito from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Circunstancia_del_Delito Entity</returns>
        public ActionResult GetCircunstancia_del_DelitoList(UrlParametersModel param)
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
            _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Circunstancia_del_DelitoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Circunstancia_del_DelitoAdvanceSearchModel))
                {
					var advanceFilter =
                    (Circunstancia_del_DelitoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Circunstancia_del_DelitoPropertyMapper oCircunstancia_del_DelitoPropertyMapper = new Circunstancia_del_DelitoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oCircunstancia_del_DelitoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _ICircunstancia_del_DelitoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Circunstancia_del_Delitos == null)
                result.Circunstancia_del_Delitos = new List<Circunstancia_del_Delito>();

            return Json(new
            {
                aaData = result.Circunstancia_del_Delitos.Select(m => new Circunstancia_del_DelitoGridModel
            {
                    Clave = m.Clave
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_del_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_del_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
			,Descripcion = m.Descripcion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(Circunstancia_del_DelitoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Circunstancia_del_Delito.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Circunstancia_del_Delito.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTitulo_del_Delito))
            {
                switch (filter.Titulo_del_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Titulo_del_Delito.Descripcion LIKE '" + filter.AdvanceTitulo_del_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Titulo_del_Delito.Descripcion LIKE '%" + filter.AdvanceTitulo_del_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Titulo_del_Delito.Descripcion = '" + filter.AdvanceTitulo_del_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Titulo_del_Delito.Descripcion LIKE '%" + filter.AdvanceTitulo_del_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTitulo_del_DelitoMultiple != null && filter.AdvanceTitulo_del_DelitoMultiple.Count() > 0)
            {
                var Titulo_del_DelitoIds = string.Join(",", filter.AdvanceTitulo_del_DelitoMultiple);

                where += " AND Circunstancia_del_Delito.Titulo_del_Delito In (" + Titulo_del_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceGrupo_del_Delito))
            {
                switch (filter.Grupo_del_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Grupo_del_Delito.Descripcion LIKE '" + filter.AdvanceGrupo_del_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Grupo_del_Delito.Descripcion LIKE '%" + filter.AdvanceGrupo_del_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Grupo_del_Delito.Descripcion = '" + filter.AdvanceGrupo_del_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Grupo_del_Delito.Descripcion LIKE '%" + filter.AdvanceGrupo_del_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceGrupo_del_DelitoMultiple != null && filter.AdvanceGrupo_del_DelitoMultiple.Count() > 0)
            {
                var Grupo_del_DelitoIds = string.Join(",", filter.AdvanceGrupo_del_DelitoMultiple);

                where += " AND Circunstancia_del_Delito.Grupo_del_Delito In (" + Grupo_del_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDelito))
            {
                switch (filter.DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delito.Descripcion LIKE '" + filter.AdvanceDelito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delito.Descripcion LIKE '%" + filter.AdvanceDelito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delito.Descripcion = '" + filter.AdvanceDelito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delito.Descripcion LIKE '%" + filter.AdvanceDelito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDelitoMultiple != null && filter.AdvanceDelitoMultiple.Count() > 0)
            {
                var DelitoIds = string.Join(",", filter.AdvanceDelitoMultiple);

                where += " AND Circunstancia_del_Delito.Delito In (" + DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Descripcion))
            {
                switch (filter.DescripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Circunstancia_del_Delito.Descripcion LIKE '" + filter.Descripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Circunstancia_del_Delito.Descripcion LIKE '%" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Circunstancia_del_Delito.Descripcion = '" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Circunstancia_del_Delito.Descripcion LIKE '%" + filter.Descripcion + "%'";
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
                _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Circunstancia_del_Delito varCircunstancia_del_Delito = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _ICircunstancia_del_DelitoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Circunstancia_del_DelitoModel varCircunstancia_del_Delito)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Circunstancia_del_DelitoInfo = new Circunstancia_del_Delito
                    {
                        Clave = varCircunstancia_del_Delito.Clave
                        ,Titulo_del_Delito = varCircunstancia_del_Delito.Titulo_del_Delito
                        ,Grupo_del_Delito = varCircunstancia_del_Delito.Grupo_del_Delito
                        ,Delito = varCircunstancia_del_Delito.Delito
                        ,Descripcion = varCircunstancia_del_Delito.Descripcion

                    };

                    result = !IsNew ?
                        _ICircunstancia_del_DelitoApiConsumer.Update(Circunstancia_del_DelitoInfo, null, null).Resource.ToString() :
                         _ICircunstancia_del_DelitoApiConsumer.Insert(Circunstancia_del_DelitoInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Circunstancia_del_Delito script
        /// </summary>
        /// <param name="oCircunstancia_del_DelitoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Circunstancia_del_DelitoModuleAttributeList)
        {
            for (int i = 0; i < Circunstancia_del_DelitoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Circunstancia_del_DelitoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Circunstancia_del_DelitoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Circunstancia_del_DelitoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Circunstancia_del_DelitoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Circunstancia_del_DelitoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Circunstancia_del_DelitoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Circunstancia_del_DelitoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Circunstancia_del_DelitoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Circunstancia_del_DelitoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Circunstancia_del_DelitoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Circunstancia_del_DelitoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strCircunstancia_del_DelitoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Circunstancia_del_Delito.js")))
            {
                strCircunstancia_del_DelitoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Circunstancia_del_Delito element attributes
            string userChangeJson = jsSerialize.Serialize(Circunstancia_del_DelitoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strCircunstancia_del_DelitoScript.IndexOf("inpuElementArray");
            string splittedString = strCircunstancia_del_DelitoScript.Substring(indexOfArray, strCircunstancia_del_DelitoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Circunstancia_del_DelitoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Circunstancia_del_DelitoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strCircunstancia_del_DelitoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strCircunstancia_del_DelitoScript.Substring(indexOfArrayHistory, strCircunstancia_del_DelitoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strCircunstancia_del_DelitoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strCircunstancia_del_DelitoScript.Substring(endIndexOfMainElement + indexOfArray, strCircunstancia_del_DelitoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Circunstancia_del_DelitoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Circunstancia_del_DelitoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Circunstancia_del_Delito.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Circunstancia_del_Delito.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Circunstancia_del_Delito.js")))
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
        public ActionResult Circunstancia_del_DelitoPropertyBag()
        {
            return PartialView("Circunstancia_del_DelitoPropertyBag", "Circunstancia_del_Delito");
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
                var whereClauseFormat = "Object = 44996 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Circunstancia_del_Delito.Clave= " + RecordId;
                            var result = _ICircunstancia_del_DelitoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Circunstancia_del_DelitoPropertyMapper());
			
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
                    (Circunstancia_del_DelitoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Circunstancia_del_DelitoPropertyMapper oCircunstancia_del_DelitoPropertyMapper = new Circunstancia_del_DelitoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oCircunstancia_del_DelitoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ICircunstancia_del_DelitoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Circunstancia_del_Delitos == null)
                result.Circunstancia_del_Delitos = new List<Circunstancia_del_Delito>();

            var data = result.Circunstancia_del_Delitos.Select(m => new Circunstancia_del_DelitoGridModel
            {
                Clave = m.Clave
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_del_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_del_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
			,Descripcion = m.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(44996, arrayColumnsVisible), "Circunstancia_del_DelitoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(44996, arrayColumnsVisible), "Circunstancia_del_DelitoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(44996, arrayColumnsVisible), "Circunstancia_del_DelitoList_" + DateTime.Now.ToString());
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

            _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Circunstancia_del_DelitoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Circunstancia_del_DelitoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Circunstancia_del_DelitoPropertyMapper oCircunstancia_del_DelitoPropertyMapper = new Circunstancia_del_DelitoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oCircunstancia_del_DelitoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ICircunstancia_del_DelitoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Circunstancia_del_Delitos == null)
                result.Circunstancia_del_Delitos = new List<Circunstancia_del_Delito>();

            var data = result.Circunstancia_del_Delitos.Select(m => new Circunstancia_del_DelitoGridModel
            {
                Clave = m.Clave
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_del_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_del_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
			,Descripcion = m.Descripcion

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
                _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstancia_del_DelitoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Circunstancia_del_Delito_Datos_GeneralesModel varCircunstancia_del_Delito)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Circunstancia_del_Delito_Datos_GeneralesInfo = new Circunstancia_del_Delito_Datos_Generales
                {
                    Clave = varCircunstancia_del_Delito.Clave
                                            ,Titulo_del_Delito = varCircunstancia_del_Delito.Titulo_del_Delito
                        ,Grupo_del_Delito = varCircunstancia_del_Delito.Grupo_del_Delito
                        ,Delito = varCircunstancia_del_Delito.Delito
                        ,Descripcion = varCircunstancia_del_Delito.Descripcion
                    
                };

                result = _ICircunstancia_del_DelitoApiConsumer.Update_Datos_Generales(Circunstancia_del_Delito_Datos_GeneralesInfo).Resource.ToString();
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
                _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICircunstancia_del_DelitoApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Circunstancia_del_Delito_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Titulo_del_Delito = m.Titulo_del_Delito
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_del_Delito = m.Grupo_del_Delito
                        ,Grupo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_del_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_del_Delito_Grupo_del_Delito.Descripcion
                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
			,Descripcion = m.Descripcion

                    
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

