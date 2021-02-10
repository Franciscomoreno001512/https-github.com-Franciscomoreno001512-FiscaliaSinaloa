using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Titulo_del_Delito;
using Spartane.Core.Domain.Grupo_del_Delito;
using Spartane.Core.Domain.Configuracion_de_Planeacion;

using Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;




using Spartane.Core.Domain.Tipo_Delito;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Delito;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Delito;
using Spartane.Web.Areas.WebApiConsumer.Titulo_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Grupo_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Configuracion_de_Planeacion;

using Spartane.Web.Areas.WebApiConsumer.Categoria_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Servicio_de_Apoyo;

using Spartane.Web.Areas.WebApiConsumer.Tipo_Delito;

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
    public class DelitoController : Controller
    {
        #region "variable declaration"

        private IDelitoService service = null;
        private IDelitoApiConsumer _IDelitoApiConsumer;
        private ITitulo_del_DelitoApiConsumer _ITitulo_del_DelitoApiConsumer;
        private IGrupo_del_DelitoApiConsumer _IGrupo_del_DelitoApiConsumer;
        private IConfiguracion_de_PlaneacionApiConsumer _IConfiguracion_de_PlaneacionApiConsumer;

        private ICategoria_de_Servicio_de_ApoyoApiConsumer _ICategoria_de_Servicio_de_ApoyoApiConsumer;
        private ITipo_de_Servicio_de_ApoyoApiConsumer _ITipo_de_Servicio_de_ApoyoApiConsumer;

        private ITipo_DelitoApiConsumer _ITipo_DelitoApiConsumer;

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

        
        public DelitoController(IDelitoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDelitoApiConsumer DelitoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ITitulo_del_DelitoApiConsumer Titulo_del_DelitoApiConsumer , IGrupo_del_DelitoApiConsumer Grupo_del_DelitoApiConsumer , IConfiguracion_de_PlaneacionApiConsumer Configuracion_de_PlaneacionApiConsumer , ICategoria_de_Servicio_de_ApoyoApiConsumer Categoria_de_Servicio_de_ApoyoApiConsumer , ITipo_de_Servicio_de_ApoyoApiConsumer Tipo_de_Servicio_de_ApoyoApiConsumer  , ITipo_DelitoApiConsumer Tipo_DelitoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDelitoApiConsumer = DelitoApiConsumer;
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
            this._IConfiguracion_de_PlaneacionApiConsumer = Configuracion_de_PlaneacionApiConsumer;

            this._ICategoria_de_Servicio_de_ApoyoApiConsumer = Categoria_de_Servicio_de_ApoyoApiConsumer;
            this._ITipo_de_Servicio_de_ApoyoApiConsumer = Tipo_de_Servicio_de_ApoyoApiConsumer;

            this._ITipo_DelitoApiConsumer = Tipo_DelitoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Delito
        [ObjectAuth(ObjectId = (ModuleObjectId)44991, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44991, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Delito/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)44991, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44991, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDelito = new DelitoModel();
			varDelito.Clave = Id;
			
            ViewBag.ObjectId = "44991";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionConfiguracion_de_Planeacion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45477, ModuleId);
            ViewBag.PermissionConfiguracion_de_Planeacion = permissionConfiguracion_de_Planeacion;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var DelitosData = _IDelitoApiConsumer.ListaSelAll(0, 1000, "Delito.Clave=" + Id, "").Resource.Delitos;
				
				if (DelitosData != null && DelitosData.Count > 0)
                {
					var DelitoData = DelitosData.First();
					varDelito= new DelitoModel
					{
						Clave  = DelitoData.Clave 
	                    ,Titulo_del_Delito = DelitoData.Titulo_del_Delito
                    ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(DelitoData.Titulo_del_Delito), "Titulo_del_Delito") ??  (string)DelitoData.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                    ,Grupo_del_Delito = DelitoData.Grupo_del_Delito
                    ,Grupo_del_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(DelitoData.Grupo_del_Delito), "Grupo_del_Delito") ??  (string)DelitoData.Grupo_del_Delito_Grupo_del_Delito.Descripcion
                    ,Descripcion = DelitoData.Descripcion
                    ,Grave = DelitoData.Grave.GetValueOrDefault()
                    ,Alto_Impacto = DelitoData.Alto_Impacto.GetValueOrDefault()
                    ,Alta_Incidencia = DelitoData.Alta_Incidencia.GetValueOrDefault()
                    ,Tentativa = DelitoData.Tentativa.GetValueOrDefault()
                    ,Activo = DelitoData.Activo.GetValueOrDefault()
                    ,Robo_de_Vehiculo = DelitoData.Robo_de_Vehiculo.GetValueOrDefault()
                    ,delitox = DelitoData.delitox
                    ,ARTICULO = DelitoData.ARTICULO
                    ,DETALLE = DelitoData.DETALLE
                    ,TIPO_AGENCIA = DelitoData.TIPO_AGENCIA
                    ,ESTADISTICO_SSP = DelitoData.ESTADISTICO_SSP
                    ,VAL_VEHICULO = DelitoData.VAL_VEHICULO
                    ,TIPO_DELITO = DelitoData.TIPO_DELITO
                    ,TIPO_DELITODescripcion = CultureHelper.GetTraduction(Convert.ToString(DelitoData.TIPO_DELITO), "Tipo_Delito") ??  (string)DelitoData.TIPO_DELITO_Tipo_Delito.Descripcion
                    ,circunstancia_clasif = DelitoData.circunstancia_clasif
                    ,PRINCIPAL = DelitoData.PRINCIPAL
                    ,orden = DelitoData.orden

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

				
            return View(varDelito);
        }
		
	[HttpGet]
        public ActionResult AddDelito(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44991);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
			DelitoModel varDelito= new DelitoModel();
            var permissionConfiguracion_de_Planeacion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45477, ModuleId);
            ViewBag.PermissionConfiguracion_de_Planeacion = permissionConfiguracion_de_Planeacion;


            if (id.ToString() != "0")
            {
                var DelitosData = _IDelitoApiConsumer.ListaSelAll(0, 1000, "Delito.Clave=" + id, "").Resource.Delitos;
				
				if (DelitosData != null && DelitosData.Count > 0)
                {
					var DelitoData = DelitosData.First();
					varDelito= new DelitoModel
					{
						Clave  = DelitoData.Clave 
	                    ,Titulo_del_Delito = DelitoData.Titulo_del_Delito
                    ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(DelitoData.Titulo_del_Delito), "Titulo_del_Delito") ??  (string)DelitoData.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                    ,Grupo_del_Delito = DelitoData.Grupo_del_Delito
                    ,Grupo_del_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(DelitoData.Grupo_del_Delito), "Grupo_del_Delito") ??  (string)DelitoData.Grupo_del_Delito_Grupo_del_Delito.Descripcion
                    ,Descripcion = DelitoData.Descripcion
                    ,Grave = DelitoData.Grave.GetValueOrDefault()
                    ,Alto_Impacto = DelitoData.Alto_Impacto.GetValueOrDefault()
                    ,Alta_Incidencia = DelitoData.Alta_Incidencia.GetValueOrDefault()
                    ,Tentativa = DelitoData.Tentativa.GetValueOrDefault()
                    ,Activo = DelitoData.Activo.GetValueOrDefault()
                    ,Robo_de_Vehiculo = DelitoData.Robo_de_Vehiculo.GetValueOrDefault()
                    ,delitox = DelitoData.delitox
                    ,ARTICULO = DelitoData.ARTICULO
                    ,DETALLE = DelitoData.DETALLE
                    ,TIPO_AGENCIA = DelitoData.TIPO_AGENCIA
                    ,ESTADISTICO_SSP = DelitoData.ESTADISTICO_SSP
                    ,VAL_VEHICULO = DelitoData.VAL_VEHICULO
                    ,TIPO_DELITO = DelitoData.TIPO_DELITO
                    ,TIPO_DELITODescripcion = CultureHelper.GetTraduction(Convert.ToString(DelitoData.TIPO_DELITO), "Tipo_Delito") ??  (string)DelitoData.TIPO_DELITO_Tipo_Delito.Descripcion
                    ,circunstancia_clasif = DelitoData.circunstancia_clasif
                    ,PRINCIPAL = DelitoData.PRINCIPAL
                    ,orden = DelitoData.orden

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


            return PartialView("AddDelito", varDelito);
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
        public ActionResult GetTipo_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_DelitoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Delito", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(DelitoAdvanceSearchModel model, int idFilter = -1)
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


            var previousFiltersObj = new DelitoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (DelitoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new DelitoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new DelitoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDelitoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Delitos == null)
                result.Delitos = new List<Delito>();

            return Json(new
            {
                data = result.Delitos.Select(m => new DelitoGridModel
                    {
                    Clave = m.Clave
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_del_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_del_Delito_Grupo_del_Delito.Descripcion
			,Descripcion = m.Descripcion
			,Grave = m.Grave
			,Alto_Impacto = m.Alto_Impacto
			,Alta_Incidencia = m.Alta_Incidencia
			,Tentativa = m.Tentativa
			,Activo = m.Activo
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
			,delitox = m.delitox
			,ARTICULO = m.ARTICULO
			,DETALLE = m.DETALLE
			,TIPO_AGENCIA = m.TIPO_AGENCIA
			,ESTADISTICO_SSP = m.ESTADISTICO_SSP
			,VAL_VEHICULO = m.VAL_VEHICULO
                        ,TIPO_DELITODescripcion = CultureHelper.GetTraduction(m.TIPO_DELITO_Tipo_Delito.Clave.ToString(), "Tipo_Delito") ?? (string)m.TIPO_DELITO_Tipo_Delito.Descripcion
			,circunstancia_clasif = m.circunstancia_clasif
			,PRINCIPAL = m.PRINCIPAL
			,orden = m.orden

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Delito", m.),
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
        /// Get List of Delito from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Delito Entity</returns>
        public ActionResult GetDelitoList(UrlParametersModel param)
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
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new DelitoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(DelitoAdvanceSearchModel))
                {
					var advanceFilter =
                    (DelitoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            DelitoPropertyMapper oDelitoPropertyMapper = new DelitoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDelitoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDelitoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Delitos == null)
                result.Delitos = new List<Delito>();

            return Json(new
            {
                aaData = result.Delitos.Select(m => new DelitoGridModel
            {
                    Clave = m.Clave
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_del_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_del_Delito_Grupo_del_Delito.Descripcion
			,Descripcion = m.Descripcion
			,Grave = m.Grave
			,Alto_Impacto = m.Alto_Impacto
			,Alta_Incidencia = m.Alta_Incidencia
			,Tentativa = m.Tentativa
			,Activo = m.Activo
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
			,delitox = m.delitox
			,ARTICULO = m.ARTICULO
			,DETALLE = m.DETALLE
			,TIPO_AGENCIA = m.TIPO_AGENCIA
			,ESTADISTICO_SSP = m.ESTADISTICO_SSP
			,VAL_VEHICULO = m.VAL_VEHICULO
                        ,TIPO_DELITODescripcion = CultureHelper.GetTraduction(m.TIPO_DELITO_Tipo_Delito.Clave.ToString(), "Tipo_Delito") ?? (string)m.TIPO_DELITO_Tipo_Delito.Descripcion
			,circunstancia_clasif = m.circunstancia_clasif
			,PRINCIPAL = m.PRINCIPAL
			,orden = m.orden

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


//Grid GetAutoComplete

        [HttpGet]
        public JsonResult GetDelito_TIPO_DELITO_Tipo_Delito(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Tipo_Delito.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Tipo_Delito.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ITipo_DelitoApiConsumer.ListaSelAll(1, 20,elWhere , " Tipo_Delito.Descripcion ASC ").Resource;
               
                foreach (var item in result.Tipo_Delitos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_Delito", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Tipo_Delitos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public string GetAdvanceFilter(DelitoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Delito.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Delito.Clave <= " + filter.ToClave;
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

                where += " AND Delito.Titulo_del_Delito In (" + Titulo_del_DelitoIds + ")";
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

                where += " AND Delito.Grupo_del_Delito In (" + Grupo_del_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Descripcion))
            {
                switch (filter.DescripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delito.Descripcion LIKE '" + filter.Descripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delito.Descripcion LIKE '%" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delito.Descripcion = '" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delito.Descripcion LIKE '%" + filter.Descripcion + "%'";
                        break;
                }
            }

            if (filter.Grave != RadioOptions.NoApply)
                where += " AND Delito.Grave = " + Convert.ToInt32(filter.Grave);

            if (filter.Alto_Impacto != RadioOptions.NoApply)
                where += " AND Delito.Alto_Impacto = " + Convert.ToInt32(filter.Alto_Impacto);

            if (filter.Alta_Incidencia != RadioOptions.NoApply)
                where += " AND Delito.Alta_Incidencia = " + Convert.ToInt32(filter.Alta_Incidencia);

            if (filter.Tentativa != RadioOptions.NoApply)
                where += " AND Delito.Tentativa = " + Convert.ToInt32(filter.Tentativa);

            if (filter.Activo != RadioOptions.NoApply)
                where += " AND Delito.Activo = " + Convert.ToInt32(filter.Activo);

            if (filter.Robo_de_Vehiculo != RadioOptions.NoApply)
                where += " AND Delito.Robo_de_Vehiculo = " + Convert.ToInt32(filter.Robo_de_Vehiculo);

            if (!string.IsNullOrEmpty(filter.Fromdelitox) || !string.IsNullOrEmpty(filter.Todelitox))
            {
                if (!string.IsNullOrEmpty(filter.Fromdelitox))
                    where += " AND Delito.delitox >= " + filter.Fromdelitox;
                if (!string.IsNullOrEmpty(filter.Todelitox))
                    where += " AND Delito.delitox <= " + filter.Todelitox;
            }

            if (!string.IsNullOrEmpty(filter.ARTICULO))
            {
                switch (filter.ARTICULOFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delito.ARTICULO LIKE '" + filter.ARTICULO + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delito.ARTICULO LIKE '%" + filter.ARTICULO + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delito.ARTICULO = '" + filter.ARTICULO + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delito.ARTICULO LIKE '%" + filter.ARTICULO + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.DETALLE))
            {
                switch (filter.DETALLEFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delito.DETALLE LIKE '" + filter.DETALLE + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delito.DETALLE LIKE '%" + filter.DETALLE + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delito.DETALLE = '" + filter.DETALLE + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delito.DETALLE LIKE '%" + filter.DETALLE + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromTIPO_AGENCIA) || !string.IsNullOrEmpty(filter.ToTIPO_AGENCIA))
            {
                if (!string.IsNullOrEmpty(filter.FromTIPO_AGENCIA))
                    where += " AND Delito.TIPO_AGENCIA >= " + filter.FromTIPO_AGENCIA;
                if (!string.IsNullOrEmpty(filter.ToTIPO_AGENCIA))
                    where += " AND Delito.TIPO_AGENCIA <= " + filter.ToTIPO_AGENCIA;
            }

            if (!string.IsNullOrEmpty(filter.ESTADISTICO_SSP))
            {
                switch (filter.ESTADISTICO_SSPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delito.ESTADISTICO_SSP LIKE '" + filter.ESTADISTICO_SSP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delito.ESTADISTICO_SSP LIKE '%" + filter.ESTADISTICO_SSP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delito.ESTADISTICO_SSP = '" + filter.ESTADISTICO_SSP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delito.ESTADISTICO_SSP LIKE '%" + filter.ESTADISTICO_SSP + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.VAL_VEHICULO))
            {
                switch (filter.VAL_VEHICULOFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delito.VAL_VEHICULO LIKE '" + filter.VAL_VEHICULO + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delito.VAL_VEHICULO LIKE '%" + filter.VAL_VEHICULO + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delito.VAL_VEHICULO = '" + filter.VAL_VEHICULO + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delito.VAL_VEHICULO LIKE '%" + filter.VAL_VEHICULO + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTIPO_DELITO))
            {
                switch (filter.TIPO_DELITOFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_Delito.Descripcion LIKE '" + filter.AdvanceTIPO_DELITO + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_Delito.Descripcion LIKE '%" + filter.AdvanceTIPO_DELITO + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_Delito.Descripcion = '" + filter.AdvanceTIPO_DELITO + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_Delito.Descripcion LIKE '%" + filter.AdvanceTIPO_DELITO + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTIPO_DELITOMultiple != null && filter.AdvanceTIPO_DELITOMultiple.Count() > 0)
            {
                var TIPO_DELITOIds = string.Join(",", filter.AdvanceTIPO_DELITOMultiple);

                where += " AND Delito.TIPO_DELITO In (" + TIPO_DELITOIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Fromcircunstancia_clasif) || !string.IsNullOrEmpty(filter.Tocircunstancia_clasif))
            {
                if (!string.IsNullOrEmpty(filter.Fromcircunstancia_clasif))
                    where += " AND Delito.circunstancia_clasif >= " + filter.Fromcircunstancia_clasif;
                if (!string.IsNullOrEmpty(filter.Tocircunstancia_clasif))
                    where += " AND Delito.circunstancia_clasif <= " + filter.Tocircunstancia_clasif;
            }

            if (!string.IsNullOrEmpty(filter.FromPRINCIPAL) || !string.IsNullOrEmpty(filter.ToPRINCIPAL))
            {
                if (!string.IsNullOrEmpty(filter.FromPRINCIPAL))
                    where += " AND Delito.PRINCIPAL >= " + filter.FromPRINCIPAL;
                if (!string.IsNullOrEmpty(filter.ToPRINCIPAL))
                    where += " AND Delito.PRINCIPAL <= " + filter.ToPRINCIPAL;
            }

            if (!string.IsNullOrEmpty(filter.Fromorden) || !string.IsNullOrEmpty(filter.Toorden))
            {
                if (!string.IsNullOrEmpty(filter.Fromorden))
                    where += " AND Delito.orden >= " + filter.Fromorden;
                if (!string.IsNullOrEmpty(filter.Toorden))
                    where += " AND Delito.orden <= " + filter.Toorden;
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetConfiguracion_de_Planeacion(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Configuracion_de_PlaneacionGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IConfiguracion_de_PlaneacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Configuracion_de_Planeacion.Delito=" + RelationId;
            if("int" == "string")
            {
	           where = "Configuracion_de_Planeacion.Delito='" + RelationId + "'";
            }
            var result = _IConfiguracion_de_PlaneacionApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Configuracion_de_Planeacions == null)
                result.Configuracion_de_Planeacions = new List<Configuracion_de_Planeacion>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Configuracion_de_Planeacions.Select(m => new Configuracion_de_PlaneacionGridModel
                {
                    Folio = m.Folio

                        ,Categoria = m.Categoria
                        ,CategoriaDescripcion = CultureHelper.GetTraduction(m.Categoria_Categoria_de_Servicio_de_Apoyo.Clave.ToString(), "Descripcion") ??(string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                        ,Servicio = m.Servicio
                        ,ServicioServicio = CultureHelper.GetTraduction(m.Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ??(string)m.Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Entregable = m.Entregable
			,Tiempo_Estandar = m.Tiempo_Estandar
			,Ponderacion = m.Ponderacion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Configuracion_de_PlaneacionGridModel> GetConfiguracion_de_PlaneacionData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Configuracion_de_PlaneacionGridModel> resultData = new List<Configuracion_de_PlaneacionGridModel>();
            string where = "Configuracion_de_Planeacion.Delito=" + Id;
            if("int" == "string")
            {
                where = "Configuracion_de_Planeacion.Delito='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IConfiguracion_de_PlaneacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IConfiguracion_de_PlaneacionApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Configuracion_de_Planeacions != null)
            {
                resultData = result.Configuracion_de_Planeacions.Select(m => new Configuracion_de_PlaneacionGridModel
                    {
                        Folio = m.Folio

                        ,Categoria = m.Categoria
                        ,CategoriaDescripcion = CultureHelper.GetTraduction(m.Categoria_Categoria_de_Servicio_de_Apoyo.Clave.ToString(), "Descripcion") ??(string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                        ,Servicio = m.Servicio
                        ,ServicioServicio = CultureHelper.GetTraduction(m.Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ??(string)m.Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Entregable = m.Entregable
			,Tiempo_Estandar = m.Tiempo_Estandar
			,Ponderacion = m.Ponderacion


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
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Delito varDelito = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IConfiguracion_de_PlaneacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Configuracion_de_Planeacion.Delito=" + id;
                    if("int" == "string")
                    {
	                where = "Configuracion_de_Planeacion.Delito='" + id + "'";
                    }
                    var Configuracion_de_PlaneacionInfo =
                        _IConfiguracion_de_PlaneacionApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Configuracion_de_PlaneacionInfo.Configuracion_de_Planeacions.Count > 0)
                    {
                        var resultConfiguracion_de_Planeacion = true;
                        //Removing associated job history with attachment
                        foreach (var Configuracion_de_PlaneacionItem in Configuracion_de_PlaneacionInfo.Configuracion_de_Planeacions)
                            resultConfiguracion_de_Planeacion = resultConfiguracion_de_Planeacion
                                              && _IConfiguracion_de_PlaneacionApiConsumer.Delete(Configuracion_de_PlaneacionItem.Folio, null,null).Resource;

                        if (!resultConfiguracion_de_Planeacion)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IDelitoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, DelitoModel varDelito)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var DelitoInfo = new Delito
                    {
                        Clave = varDelito.Clave
                        ,Titulo_del_Delito = varDelito.Titulo_del_Delito
                        ,Grupo_del_Delito = varDelito.Grupo_del_Delito
                        ,Descripcion = varDelito.Descripcion
                        ,Grave = varDelito.Grave
                        ,Alto_Impacto = varDelito.Alto_Impacto
                        ,Alta_Incidencia = varDelito.Alta_Incidencia
                        ,Tentativa = varDelito.Tentativa
                        ,Activo = varDelito.Activo
                        ,Robo_de_Vehiculo = varDelito.Robo_de_Vehiculo
                        ,delitox = varDelito.delitox
                        ,ARTICULO = varDelito.ARTICULO
                        ,DETALLE = varDelito.DETALLE
                        ,TIPO_AGENCIA = varDelito.TIPO_AGENCIA
                        ,ESTADISTICO_SSP = varDelito.ESTADISTICO_SSP
                        ,VAL_VEHICULO = varDelito.VAL_VEHICULO
                        ,TIPO_DELITO = varDelito.TIPO_DELITO
                        ,circunstancia_clasif = varDelito.circunstancia_clasif
                        ,PRINCIPAL = varDelito.PRINCIPAL
                        ,orden = varDelito.orden

                    };

                    result = !IsNew ?
                        _IDelitoApiConsumer.Update(DelitoInfo, null, null).Resource.ToString() :
                         _IDelitoApiConsumer.Insert(DelitoInfo, null, null).Resource.ToString();
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
        public bool CopyConfiguracion_de_Planeacion(int MasterId, int referenceId, List<Configuracion_de_PlaneacionGridModelPost> Configuracion_de_PlaneacionItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IConfiguracion_de_PlaneacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Configuracion_de_PlaneacionData = _IConfiguracion_de_PlaneacionApiConsumer.ListaSelAll(1, int.MaxValue, "Configuracion_de_Planeacion.Delito=" + referenceId,"").Resource;
                if (Configuracion_de_PlaneacionData == null || Configuracion_de_PlaneacionData.Configuracion_de_Planeacions.Count == 0)
                    return true;

                var result = true;

                Configuracion_de_PlaneacionGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varConfiguracion_de_Planeacion in Configuracion_de_PlaneacionData.Configuracion_de_Planeacions)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Configuracion_de_Planeacion Configuracion_de_Planeacion1 = varConfiguracion_de_Planeacion;

                    if (Configuracion_de_PlaneacionItems != null && Configuracion_de_PlaneacionItems.Any(m => m.Folio == Configuracion_de_Planeacion1.Folio))
                    {
                        modelDataToChange = Configuracion_de_PlaneacionItems.FirstOrDefault(m => m.Folio == Configuracion_de_Planeacion1.Folio);
                    }
                    //Chaning Id Value
                    varConfiguracion_de_Planeacion.Delito = MasterId;
                    var insertId = _IConfiguracion_de_PlaneacionApiConsumer.Insert(varConfiguracion_de_Planeacion,null,null).Resource;
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
        public ActionResult PostConfiguracion_de_Planeacion(List<Configuracion_de_PlaneacionGridModelPost> Configuracion_de_PlaneacionItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyConfiguracion_de_Planeacion(MasterId, referenceId, Configuracion_de_PlaneacionItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Configuracion_de_PlaneacionItems != null && Configuracion_de_PlaneacionItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IConfiguracion_de_PlaneacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Configuracion_de_PlaneacionItem in Configuracion_de_PlaneacionItems)
                    {







                        //Removal Request
                        if (Configuracion_de_PlaneacionItem.Removed)
                        {
                            result = result && _IConfiguracion_de_PlaneacionApiConsumer.Delete(Configuracion_de_PlaneacionItem.Folio, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Configuracion_de_PlaneacionItem.Folio = 0;

                        var Configuracion_de_PlaneacionData = new Configuracion_de_Planeacion
                        {
                            Delito = MasterId
                            ,Folio = Configuracion_de_PlaneacionItem.Folio
                            ,Categoria = (Convert.ToInt16(Configuracion_de_PlaneacionItem.Categoria) == 0 ? (Int16?)null : Convert.ToInt16(Configuracion_de_PlaneacionItem.Categoria))
                            ,Servicio = (Convert.ToInt32(Configuracion_de_PlaneacionItem.Servicio) == 0 ? (Int32?)null : Convert.ToInt32(Configuracion_de_PlaneacionItem.Servicio))
                            ,Entregable = Configuracion_de_PlaneacionItem.Entregable
                            ,Tiempo_Estandar = Configuracion_de_PlaneacionItem.Tiempo_Estandar
                            ,Ponderacion = Configuracion_de_PlaneacionItem.Ponderacion

                        };

                        var resultId = Configuracion_de_PlaneacionItem.Folio > 0
                           ? _IConfiguracion_de_PlaneacionApiConsumer.Update(Configuracion_de_PlaneacionData,null,null).Resource
                           : _IConfiguracion_de_PlaneacionApiConsumer.Insert(Configuracion_de_PlaneacionData,null,null).Resource;

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
        public ActionResult GetConfiguracion_de_Planeacion_Categoria_de_Servicio_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICategoria_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICategoria_de_Servicio_de_ApoyoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Categoria_de_Servicio_de_Apoyo", "Descripcion");
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
        public ActionResult GetConfiguracion_de_Planeacion_Tipo_de_Servicio_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio");
                  item.Servicio= trans??item.Servicio;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }






        /// <summary>
        /// Write Element Array of Delito script
        /// </summary>
        /// <param name="oDelitoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew DelitoModuleAttributeList)
        {
            for (int i = 0; i < DelitoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(DelitoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    DelitoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(DelitoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    DelitoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (DelitoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < DelitoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < DelitoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(DelitoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							DelitoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(DelitoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							DelitoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDelitoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Delito.js")))
            {
                strDelitoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Delito element attributes
            string userChangeJson = jsSerialize.Serialize(DelitoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDelitoScript.IndexOf("inpuElementArray");
            string splittedString = strDelitoScript.Substring(indexOfArray, strDelitoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(DelitoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (DelitoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDelitoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDelitoScript.Substring(indexOfArrayHistory, strDelitoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDelitoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDelitoScript.Substring(endIndexOfMainElement + indexOfArray, strDelitoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (DelitoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in DelitoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Delito.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Delito.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Delito.js")))
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
        public ActionResult DelitoPropertyBag()
        {
            return PartialView("DelitoPropertyBag", "Delito");
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
        public ActionResult AddConfiguracion_de_Planeacion(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Configuracion_de_Planeacion/AddConfiguracion_de_Planeacion");
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
                var whereClauseFormat = "Object = 44991 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Delito.Clave= " + RecordId;
                            var result = _IDelitoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new DelitoPropertyMapper());
			
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
                    (DelitoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            DelitoPropertyMapper oDelitoPropertyMapper = new DelitoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDelitoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDelitoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Delitos == null)
                result.Delitos = new List<Delito>();

            var data = result.Delitos.Select(m => new DelitoGridModel
            {
                Clave = m.Clave
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_del_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_del_Delito_Grupo_del_Delito.Descripcion
			,Descripcion = m.Descripcion
			,Grave = m.Grave
			,Alto_Impacto = m.Alto_Impacto
			,Alta_Incidencia = m.Alta_Incidencia
			,Tentativa = m.Tentativa
			,Activo = m.Activo
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
			,delitox = m.delitox
			,ARTICULO = m.ARTICULO
			,DETALLE = m.DETALLE
			,TIPO_AGENCIA = m.TIPO_AGENCIA
			,ESTADISTICO_SSP = m.ESTADISTICO_SSP
			,VAL_VEHICULO = m.VAL_VEHICULO
                        ,TIPO_DELITODescripcion = CultureHelper.GetTraduction(m.TIPO_DELITO_Tipo_Delito.Clave.ToString(), "Tipo_Delito") ?? (string)m.TIPO_DELITO_Tipo_Delito.Descripcion
			,circunstancia_clasif = m.circunstancia_clasif
			,PRINCIPAL = m.PRINCIPAL
			,orden = m.orden

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(44991, arrayColumnsVisible), "DelitoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(44991, arrayColumnsVisible), "DelitoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(44991, arrayColumnsVisible), "DelitoList_" + DateTime.Now.ToString());
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

            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new DelitoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (DelitoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            DelitoPropertyMapper oDelitoPropertyMapper = new DelitoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDelitoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDelitoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Delitos == null)
                result.Delitos = new List<Delito>();

            var data = result.Delitos.Select(m => new DelitoGridModel
            {
                Clave = m.Clave
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_del_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_del_Delito_Grupo_del_Delito.Descripcion
			,Descripcion = m.Descripcion
			,Grave = m.Grave
			,Alto_Impacto = m.Alto_Impacto
			,Alta_Incidencia = m.Alta_Incidencia
			,Tentativa = m.Tentativa
			,Activo = m.Activo
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
			,delitox = m.delitox
			,ARTICULO = m.ARTICULO
			,DETALLE = m.DETALLE
			,TIPO_AGENCIA = m.TIPO_AGENCIA
			,ESTADISTICO_SSP = m.ESTADISTICO_SSP
			,VAL_VEHICULO = m.VAL_VEHICULO
                        ,TIPO_DELITODescripcion = CultureHelper.GetTraduction(m.TIPO_DELITO_Tipo_Delito.Clave.ToString(), "Tipo_Delito") ?? (string)m.TIPO_DELITO_Tipo_Delito.Descripcion
			,circunstancia_clasif = m.circunstancia_clasif
			,PRINCIPAL = m.PRINCIPAL
			,orden = m.orden

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
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelitoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Delito_Datos_GeneralesModel varDelito)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Delito_Datos_GeneralesInfo = new Delito_Datos_Generales
                {
                    Clave = varDelito.Clave
                                            ,Titulo_del_Delito = varDelito.Titulo_del_Delito
                        ,Grupo_del_Delito = varDelito.Grupo_del_Delito
                        ,Descripcion = varDelito.Descripcion
                        ,Grave = varDelito.Grave
                        ,Alto_Impacto = varDelito.Alto_Impacto
                        ,Alta_Incidencia = varDelito.Alta_Incidencia
                        ,Tentativa = varDelito.Tentativa
                        ,Activo = varDelito.Activo
                        ,Robo_de_Vehiculo = varDelito.Robo_de_Vehiculo
                        ,delitox = varDelito.delitox
                        ,ARTICULO = varDelito.ARTICULO
                        ,DETALLE = varDelito.DETALLE
                        ,TIPO_AGENCIA = varDelito.TIPO_AGENCIA
                        ,ESTADISTICO_SSP = varDelito.ESTADISTICO_SSP
                        ,VAL_VEHICULO = varDelito.VAL_VEHICULO
                        ,TIPO_DELITO = varDelito.TIPO_DELITO
                        ,circunstancia_clasif = varDelito.circunstancia_clasif
                        ,PRINCIPAL = varDelito.PRINCIPAL
                        ,orden = varDelito.orden
                    
                };

                result = _IDelitoApiConsumer.Update_Datos_Generales(Delito_Datos_GeneralesInfo).Resource.ToString();
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
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDelitoApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Configuracion_de_Planeacion;
                var Configuracion_de_PlaneacionData = GetConfiguracion_de_PlaneacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Configuracion_de_Planeacion);

                var result = new Delito_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Titulo_del_Delito = m.Titulo_del_Delito
                        ,Titulo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Titulo_del_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Titulo_del_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_del_Delito = m.Grupo_del_Delito
                        ,Grupo_del_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_del_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_del_Delito_Grupo_del_Delito.Descripcion
			,Descripcion = m.Descripcion
			,Grave = m.Grave
			,Alto_Impacto = m.Alto_Impacto
			,Alta_Incidencia = m.Alta_Incidencia
			,Tentativa = m.Tentativa
			,Activo = m.Activo
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
			,delitox = m.delitox
			,ARTICULO = m.ARTICULO
			,DETALLE = m.DETALLE
			,TIPO_AGENCIA = m.TIPO_AGENCIA
			,ESTADISTICO_SSP = m.ESTADISTICO_SSP
			,VAL_VEHICULO = m.VAL_VEHICULO
                        ,TIPO_DELITO = m.TIPO_DELITO
                        ,TIPO_DELITODescripcion = CultureHelper.GetTraduction(m.TIPO_DELITO_Tipo_Delito.Clave.ToString(), "Tipo_Delito") ?? (string)m.TIPO_DELITO_Tipo_Delito.Descripcion
			,circunstancia_clasif = m.circunstancia_clasif
			,PRINCIPAL = m.PRINCIPAL
			,orden = m.orden

                    
                };
				var resultData = new
                {
                    data = result
                    ,Configuracion_de_Planeacion = Configuracion_de_PlaneacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

