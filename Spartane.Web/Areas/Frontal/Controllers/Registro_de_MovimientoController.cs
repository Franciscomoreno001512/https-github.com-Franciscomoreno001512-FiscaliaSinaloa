using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Registro_de_Movimiento;
using Spartane.Core.Domain.Judicializacion;
using Spartane.Core.Domain.Fase_de_Judicializacion;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Configurador_de_Movimientos;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Registro_de_Movimiento;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Registro_de_Movimiento;
using Spartane.Web.Areas.WebApiConsumer.Judicializacion;
using Spartane.Web.Areas.WebApiConsumer.Fase_de_Judicializacion;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Configurador_de_Movimientos;

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
    public class Registro_de_MovimientoController : Controller
    {
        #region "variable declaration"

        private IRegistro_de_MovimientoService service = null;
        private IRegistro_de_MovimientoApiConsumer _IRegistro_de_MovimientoApiConsumer;
        private IJudicializacionApiConsumer _IJudicializacionApiConsumer;
        private IFase_de_JudicializacionApiConsumer _IFase_de_JudicializacionApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IConfigurador_de_MovimientosApiConsumer _IConfigurador_de_MovimientosApiConsumer;

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

        
        public Registro_de_MovimientoController(IRegistro_de_MovimientoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IRegistro_de_MovimientoApiConsumer Registro_de_MovimientoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IJudicializacionApiConsumer JudicializacionApiConsumer , IFase_de_JudicializacionApiConsumer Fase_de_JudicializacionApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IConfigurador_de_MovimientosApiConsumer Configurador_de_MovimientosApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IRegistro_de_MovimientoApiConsumer = Registro_de_MovimientoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IJudicializacionApiConsumer = JudicializacionApiConsumer;
            this._IFase_de_JudicializacionApiConsumer = Fase_de_JudicializacionApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IConfigurador_de_MovimientosApiConsumer = Configurador_de_MovimientosApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Registro_de_Movimiento
        [ObjectAuth(ObjectId = (ModuleObjectId)45636, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45636, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Registro_de_Movimiento/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45636, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45636, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varRegistro_de_Movimiento = new Registro_de_MovimientoModel();
			varRegistro_de_Movimiento.Clave = Id;
			
            ViewBag.ObjectId = "45636";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IRegistro_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Registro_de_MovimientosData = _IRegistro_de_MovimientoApiConsumer.ListaSelAll(0, 1000, "Registro_de_Movimiento.Clave=" + Id, "").Resource.Registro_de_Movimientos;
				
				if (Registro_de_MovimientosData != null && Registro_de_MovimientosData.Count > 0)
                {
					var Registro_de_MovimientoData = Registro_de_MovimientosData.First();
					varRegistro_de_Movimiento= new Registro_de_MovimientoModel
					{
						Clave  = Registro_de_MovimientoData.Clave 
	                    ,Judicializacion = Registro_de_MovimientoData.Judicializacion
                    ,Judicializacioncausa_o_cuadernillo = CultureHelper.GetTraduction(Convert.ToString(Registro_de_MovimientoData.Judicializacion), "Judicializacion") ??  (string)Registro_de_MovimientoData.Judicializacion_Judicializacion.causa_o_cuadernillo
                    ,Fase = Registro_de_MovimientoData.Fase
                    ,FaseDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_MovimientoData.Fase), "Fase_de_Judicializacion") ??  (string)Registro_de_MovimientoData.Fase_Fase_de_Judicializacion.Descripcion
                    ,Usuario_que_Registra = Registro_de_MovimientoData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Registro_de_MovimientoData.Usuario_que_Registra), "Spartan_User") ??  (string)Registro_de_MovimientoData.Usuario_que_Registra_Spartan_User.Name
                    ,Movimiento_Realizado = Registro_de_MovimientoData.Movimiento_Realizado
                    ,Movimiento_RealizadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_MovimientoData.Movimiento_Realizado), "Configurador_de_Movimientos") ??  (string)Registro_de_MovimientoData.Movimiento_Realizado_Configurador_de_Movimientos.Descripcion
                    ,Fecha_de_Movimiento = (Registro_de_MovimientoData.Fecha_de_Movimiento == null ? string.Empty : Convert.ToDateTime(Registro_de_MovimientoData.Fecha_de_Movimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Movimiento = Registro_de_MovimientoData.Hora_de_Movimiento
                    ,Informacion = Registro_de_MovimientoData.Informacion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IFase_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fase_de_Judicializacions_Fase = _IFase_de_JudicializacionApiConsumer.SelAll(true);
            if (Fase_de_Judicializacions_Fase != null && Fase_de_Judicializacions_Fase.Resource != null)
                ViewBag.Fase_de_Judicializacions_Fase = Fase_de_Judicializacions_Fase.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fase_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varRegistro_de_Movimiento);
        }
		
	[HttpGet]
        public ActionResult AddRegistro_de_Movimiento(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45636);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IRegistro_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Registro_de_MovimientoModel varRegistro_de_Movimiento= new Registro_de_MovimientoModel();


            if (id.ToString() != "0")
            {
                var Registro_de_MovimientosData = _IRegistro_de_MovimientoApiConsumer.ListaSelAll(0, 1000, "Registro_de_Movimiento.Clave=" + id, "").Resource.Registro_de_Movimientos;
				
				if (Registro_de_MovimientosData != null && Registro_de_MovimientosData.Count > 0)
                {
					var Registro_de_MovimientoData = Registro_de_MovimientosData.First();
					varRegistro_de_Movimiento= new Registro_de_MovimientoModel
					{
						Clave  = Registro_de_MovimientoData.Clave 
	                    ,Judicializacion = Registro_de_MovimientoData.Judicializacion
                    ,Judicializacioncausa_o_cuadernillo = CultureHelper.GetTraduction(Convert.ToString(Registro_de_MovimientoData.Judicializacion), "Judicializacion") ??  (string)Registro_de_MovimientoData.Judicializacion_Judicializacion.causa_o_cuadernillo
                    ,Fase = Registro_de_MovimientoData.Fase
                    ,FaseDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_MovimientoData.Fase), "Fase_de_Judicializacion") ??  (string)Registro_de_MovimientoData.Fase_Fase_de_Judicializacion.Descripcion
                    ,Usuario_que_Registra = Registro_de_MovimientoData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Registro_de_MovimientoData.Usuario_que_Registra), "Spartan_User") ??  (string)Registro_de_MovimientoData.Usuario_que_Registra_Spartan_User.Name
                    ,Movimiento_Realizado = Registro_de_MovimientoData.Movimiento_Realizado
                    ,Movimiento_RealizadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_MovimientoData.Movimiento_Realizado), "Configurador_de_Movimientos") ??  (string)Registro_de_MovimientoData.Movimiento_Realizado_Configurador_de_Movimientos.Descripcion
                    ,Fecha_de_Movimiento = (Registro_de_MovimientoData.Fecha_de_Movimiento == null ? string.Empty : Convert.ToDateTime(Registro_de_MovimientoData.Fecha_de_Movimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Movimiento = Registro_de_MovimientoData.Hora_de_Movimiento
                    ,Informacion = Registro_de_MovimientoData.Informacion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IFase_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fase_de_Judicializacions_Fase = _IFase_de_JudicializacionApiConsumer.SelAll(true);
            if (Fase_de_Judicializacions_Fase != null && Fase_de_Judicializacions_Fase.Resource != null)
                ViewBag.Fase_de_Judicializacions_Fase = Fase_de_Judicializacions_Fase.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fase_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddRegistro_de_Movimiento", varRegistro_de_Movimiento);
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
        public ActionResult GetJudicializacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IJudicializacionApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.causa_o_cuadernillo).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Judicializacion", "causa_o_cuadernillo")?? m.causa_o_cuadernillo,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetFase_de_JudicializacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IFase_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IFase_de_JudicializacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fase_de_Judicializacion", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetConfigurador_de_MovimientosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConfigurador_de_MovimientosApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Configurador_de_Movimientos", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Registro_de_MovimientoAdvanceSearchModel model, int idFilter = -1)
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

            _IFase_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fase_de_Judicializacions_Fase = _IFase_de_JudicializacionApiConsumer.SelAll(true);
            if (Fase_de_Judicializacions_Fase != null && Fase_de_Judicializacions_Fase.Resource != null)
                ViewBag.Fase_de_Judicializacions_Fase = Fase_de_Judicializacions_Fase.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fase_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IFase_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fase_de_Judicializacions_Fase = _IFase_de_JudicializacionApiConsumer.SelAll(true);
            if (Fase_de_Judicializacions_Fase != null && Fase_de_Judicializacions_Fase.Resource != null)
                ViewBag.Fase_de_Judicializacions_Fase = Fase_de_Judicializacions_Fase.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fase_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Registro_de_MovimientoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Registro_de_MovimientoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Registro_de_MovimientoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Registro_de_MovimientoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IRegistro_de_MovimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Movimientos == null)
                result.Registro_de_Movimientos = new List<Registro_de_Movimiento>();

            return Json(new
            {
                data = result.Registro_de_Movimientos.Select(m => new Registro_de_MovimientoGridModel
                    {
                    Clave = m.Clave
                        ,Judicializacioncausa_o_cuadernillo = CultureHelper.GetTraduction(m.Judicializacion_Judicializacion.Clave.ToString(), "Judicializacion") ?? (string)m.Judicializacion_Judicializacion.causa_o_cuadernillo
                        ,FaseDescripcion = CultureHelper.GetTraduction(m.Fase_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Fase_de_Judicializacion.Descripcion
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Movimiento_RealizadoDescripcion = CultureHelper.GetTraduction(m.Movimiento_Realizado_Configurador_de_Movimientos.Clave.ToString(), "Configurador_de_Movimientos") ?? (string)m.Movimiento_Realizado_Configurador_de_Movimientos.Descripcion
                        ,Fecha_de_Movimiento = (m.Fecha_de_Movimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Movimiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Movimiento = m.Hora_de_Movimiento
			,Informacion = System.Net.WebUtility.HtmlDecode(m.Informacion)

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetRegistro_de_MovimientoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegistro_de_MovimientoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Registro_de_Movimiento", m.),
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
        /// Get List of Registro_de_Movimiento from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Registro_de_Movimiento Entity</returns>
        public ActionResult GetRegistro_de_MovimientoList(UrlParametersModel param)
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
            _IRegistro_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Registro_de_MovimientoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Registro_de_MovimientoAdvanceSearchModel))
                {
					var advanceFilter =
                    (Registro_de_MovimientoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Registro_de_MovimientoPropertyMapper oRegistro_de_MovimientoPropertyMapper = new Registro_de_MovimientoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oRegistro_de_MovimientoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IRegistro_de_MovimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Movimientos == null)
                result.Registro_de_Movimientos = new List<Registro_de_Movimiento>();

            return Json(new
            {
                aaData = result.Registro_de_Movimientos.Select(m => new Registro_de_MovimientoGridModel
            {
                    Clave = m.Clave
                        ,Judicializacioncausa_o_cuadernillo = CultureHelper.GetTraduction(m.Judicializacion_Judicializacion.Clave.ToString(), "Judicializacion") ?? (string)m.Judicializacion_Judicializacion.causa_o_cuadernillo
                        ,FaseDescripcion = CultureHelper.GetTraduction(m.Fase_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Fase_de_Judicializacion.Descripcion
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Movimiento_RealizadoDescripcion = CultureHelper.GetTraduction(m.Movimiento_Realizado_Configurador_de_Movimientos.Clave.ToString(), "Configurador_de_Movimientos") ?? (string)m.Movimiento_Realizado_Configurador_de_Movimientos.Descripcion
                        ,Fecha_de_Movimiento = (m.Fecha_de_Movimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Movimiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Movimiento = m.Hora_de_Movimiento
			,Informacion = System.Net.WebUtility.HtmlDecode(m.Informacion)

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetRegistro_de_Movimiento_Judicializacion_Judicializacion(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Judicializacion.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Judicializacion.causa_o_cuadernillo as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IJudicializacionApiConsumer.ListaSelAll(1, 20,elWhere , " Judicializacion.causa_o_cuadernillo ASC ").Resource;
               
                foreach (var item in result.Judicializacions)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Judicializacion", "causa_o_cuadernillo");
                    item.causa_o_cuadernillo =trans ??item.causa_o_cuadernillo;
                }
                return Json(result.Judicializacions.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetRegistro_de_Movimiento_Usuario_que_Registra_Spartan_User(string query, string where)
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
        public JsonResult GetRegistro_de_Movimiento_Movimiento_Realizado_Configurador_de_Movimientos(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Configurador_de_Movimientos.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Configurador_de_Movimientos.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IConfigurador_de_MovimientosApiConsumer.ListaSelAll(1, 20,elWhere , " Configurador_de_Movimientos.Descripcion ASC ").Resource;
               
                foreach (var item in result.Configurador_de_Movimientoss)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Configurador_de_Movimientos", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Configurador_de_Movimientoss.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public string GetAdvanceFilter(Registro_de_MovimientoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Registro_de_Movimiento.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Registro_de_Movimiento.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceJudicializacion))
            {
                switch (filter.JudicializacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.causa_o_cuadernillo LIKE '" + filter.AdvanceJudicializacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.causa_o_cuadernillo LIKE '%" + filter.AdvanceJudicializacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.causa_o_cuadernillo = '" + filter.AdvanceJudicializacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.causa_o_cuadernillo LIKE '%" + filter.AdvanceJudicializacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceJudicializacionMultiple != null && filter.AdvanceJudicializacionMultiple.Count() > 0)
            {
                var JudicializacionIds = string.Join(",", filter.AdvanceJudicializacionMultiple);

                where += " AND Registro_de_Movimiento.Judicializacion In (" + JudicializacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceFase))
            {
                switch (filter.FaseFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Fase_de_Judicializacion.Descripcion LIKE '" + filter.AdvanceFase + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Fase_de_Judicializacion.Descripcion LIKE '%" + filter.AdvanceFase + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Fase_de_Judicializacion.Descripcion = '" + filter.AdvanceFase + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Fase_de_Judicializacion.Descripcion LIKE '%" + filter.AdvanceFase + "%'";
                        break;
                }
            }
            else if (filter.AdvanceFaseMultiple != null && filter.AdvanceFaseMultiple.Count() > 0)
            {
                var FaseIds = string.Join(",", filter.AdvanceFaseMultiple);

                where += " AND Registro_de_Movimiento.Fase In (" + FaseIds + ")";
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

                where += " AND Registro_de_Movimiento.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMovimiento_Realizado))
            {
                switch (filter.Movimiento_RealizadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Configurador_de_Movimientos.Descripcion LIKE '" + filter.AdvanceMovimiento_Realizado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Configurador_de_Movimientos.Descripcion LIKE '%" + filter.AdvanceMovimiento_Realizado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Configurador_de_Movimientos.Descripcion = '" + filter.AdvanceMovimiento_Realizado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Configurador_de_Movimientos.Descripcion LIKE '%" + filter.AdvanceMovimiento_Realizado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMovimiento_RealizadoMultiple != null && filter.AdvanceMovimiento_RealizadoMultiple.Count() > 0)
            {
                var Movimiento_RealizadoIds = string.Join(",", filter.AdvanceMovimiento_RealizadoMultiple);

                where += " AND Registro_de_Movimiento.Movimiento_Realizado In (" + Movimiento_RealizadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Movimiento) || !string.IsNullOrEmpty(filter.ToFecha_de_Movimiento))
            {
                var Fecha_de_MovimientoFrom = DateTime.ParseExact(filter.FromFecha_de_Movimiento, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_MovimientoTo = DateTime.ParseExact(filter.ToFecha_de_Movimiento, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Movimiento))
                    where += " AND Registro_de_Movimiento.Fecha_de_Movimiento >= '" + Fecha_de_MovimientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Movimiento))
                    where += " AND Registro_de_Movimiento.Fecha_de_Movimiento <= '" + Fecha_de_MovimientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Movimiento) || !string.IsNullOrEmpty(filter.ToHora_de_Movimiento))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Movimiento))
                    where += " AND Convert(TIME,Registro_de_Movimiento.Hora_de_Movimiento) >='" + filter.FromHora_de_Movimiento + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Movimiento))
                    where += " AND Convert(TIME,Registro_de_Movimiento.Hora_de_Movimiento) <='" + filter.ToHora_de_Movimiento + "'";
            }

            if (!string.IsNullOrEmpty(filter.Informacion))
            {
                switch (filter.InformacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Movimiento.Informacion LIKE '" + filter.Informacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Movimiento.Informacion LIKE '%" + filter.Informacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Movimiento.Informacion = '" + filter.Informacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Movimiento.Informacion LIKE '%" + filter.Informacion + "%'";
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
                _IRegistro_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Registro_de_Movimiento varRegistro_de_Movimiento = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IRegistro_de_MovimientoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Registro_de_MovimientoModel varRegistro_de_Movimiento)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IRegistro_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Registro_de_MovimientoInfo = new Registro_de_Movimiento
                    {
                        Clave = varRegistro_de_Movimiento.Clave
                        ,Judicializacion = varRegistro_de_Movimiento.Judicializacion
                        ,Fase = varRegistro_de_Movimiento.Fase
                        ,Usuario_que_Registra = varRegistro_de_Movimiento.Usuario_que_Registra
                        ,Movimiento_Realizado = varRegistro_de_Movimiento.Movimiento_Realizado
                        ,Fecha_de_Movimiento = (!String.IsNullOrEmpty(varRegistro_de_Movimiento.Fecha_de_Movimiento)) ? DateTime.ParseExact(varRegistro_de_Movimiento.Fecha_de_Movimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Movimiento = varRegistro_de_Movimiento.Hora_de_Movimiento
                        ,Informacion = varRegistro_de_Movimiento.Informacion

                    };

                    result = !IsNew ?
                        _IRegistro_de_MovimientoApiConsumer.Update(Registro_de_MovimientoInfo, null, null).Resource.ToString() :
                         _IRegistro_de_MovimientoApiConsumer.Insert(Registro_de_MovimientoInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Registro_de_Movimiento script
        /// </summary>
        /// <param name="oRegistro_de_MovimientoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Registro_de_MovimientoModuleAttributeList)
        {
            for (int i = 0; i < Registro_de_MovimientoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Registro_de_MovimientoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Registro_de_MovimientoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Registro_de_MovimientoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Registro_de_MovimientoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Registro_de_MovimientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Registro_de_MovimientoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Registro_de_MovimientoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Registro_de_MovimientoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Registro_de_MovimientoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Registro_de_MovimientoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Registro_de_MovimientoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strRegistro_de_MovimientoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Registro_de_Movimiento.js")))
            {
                strRegistro_de_MovimientoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Registro_de_Movimiento element attributes
            string userChangeJson = jsSerialize.Serialize(Registro_de_MovimientoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strRegistro_de_MovimientoScript.IndexOf("inpuElementArray");
            string splittedString = strRegistro_de_MovimientoScript.Substring(indexOfArray, strRegistro_de_MovimientoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Registro_de_MovimientoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Registro_de_MovimientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strRegistro_de_MovimientoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strRegistro_de_MovimientoScript.Substring(indexOfArrayHistory, strRegistro_de_MovimientoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strRegistro_de_MovimientoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strRegistro_de_MovimientoScript.Substring(endIndexOfMainElement + indexOfArray, strRegistro_de_MovimientoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Registro_de_MovimientoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Registro_de_MovimientoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Registro_de_Movimiento.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Registro_de_Movimiento.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Registro_de_Movimiento.js")))
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
        public ActionResult Registro_de_MovimientoPropertyBag()
        {
            return PartialView("Registro_de_MovimientoPropertyBag", "Registro_de_Movimiento");
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
                var whereClauseFormat = "Object = 45636 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IRegistro_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Registro_de_Movimiento.Clave= " + RecordId;
                            var result = _IRegistro_de_MovimientoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IRegistro_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Registro_de_MovimientoPropertyMapper());
			
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
                    (Registro_de_MovimientoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Registro_de_MovimientoPropertyMapper oRegistro_de_MovimientoPropertyMapper = new Registro_de_MovimientoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRegistro_de_MovimientoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRegistro_de_MovimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Movimientos == null)
                result.Registro_de_Movimientos = new List<Registro_de_Movimiento>();

            var data = result.Registro_de_Movimientos.Select(m => new Registro_de_MovimientoGridModel
            {
                Clave = m.Clave
                        ,Judicializacioncausa_o_cuadernillo = CultureHelper.GetTraduction(m.Judicializacion_Judicializacion.Clave.ToString(), "Judicializacion") ?? (string)m.Judicializacion_Judicializacion.causa_o_cuadernillo
                        ,FaseDescripcion = CultureHelper.GetTraduction(m.Fase_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Fase_de_Judicializacion.Descripcion
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Movimiento_RealizadoDescripcion = CultureHelper.GetTraduction(m.Movimiento_Realizado_Configurador_de_Movimientos.Clave.ToString(), "Configurador_de_Movimientos") ?? (string)m.Movimiento_Realizado_Configurador_de_Movimientos.Descripcion
                        ,Fecha_de_Movimiento = (m.Fecha_de_Movimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Movimiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Movimiento = m.Hora_de_Movimiento
			,Informacion = System.Net.WebUtility.HtmlDecode(m.Informacion)

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45636, arrayColumnsVisible), "Registro_de_MovimientoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45636, arrayColumnsVisible), "Registro_de_MovimientoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45636, arrayColumnsVisible), "Registro_de_MovimientoList_" + DateTime.Now.ToString());
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

            _IRegistro_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Registro_de_MovimientoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Registro_de_MovimientoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Registro_de_MovimientoPropertyMapper oRegistro_de_MovimientoPropertyMapper = new Registro_de_MovimientoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRegistro_de_MovimientoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRegistro_de_MovimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Movimientos == null)
                result.Registro_de_Movimientos = new List<Registro_de_Movimiento>();

            var data = result.Registro_de_Movimientos.Select(m => new Registro_de_MovimientoGridModel
            {
                Clave = m.Clave
                        ,Judicializacioncausa_o_cuadernillo = CultureHelper.GetTraduction(m.Judicializacion_Judicializacion.Clave.ToString(), "Judicializacion") ?? (string)m.Judicializacion_Judicializacion.causa_o_cuadernillo
                        ,FaseDescripcion = CultureHelper.GetTraduction(m.Fase_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Fase_de_Judicializacion.Descripcion
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Movimiento_RealizadoDescripcion = CultureHelper.GetTraduction(m.Movimiento_Realizado_Configurador_de_Movimientos.Clave.ToString(), "Configurador_de_Movimientos") ?? (string)m.Movimiento_Realizado_Configurador_de_Movimientos.Descripcion
                        ,Fecha_de_Movimiento = (m.Fecha_de_Movimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Movimiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Movimiento = m.Hora_de_Movimiento
			,Informacion = System.Net.WebUtility.HtmlDecode(m.Informacion)

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
                _IRegistro_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegistro_de_MovimientoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Registro_de_Movimiento_Datos_GeneralesModel varRegistro_de_Movimiento)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Movimiento_Datos_GeneralesInfo = new Registro_de_Movimiento_Datos_Generales
                {
                    Clave = varRegistro_de_Movimiento.Clave
                                            ,Judicializacion = varRegistro_de_Movimiento.Judicializacion
                        ,Fase = varRegistro_de_Movimiento.Fase
                        ,Usuario_que_Registra = varRegistro_de_Movimiento.Usuario_que_Registra
                        ,Movimiento_Realizado = varRegistro_de_Movimiento.Movimiento_Realizado
                        ,Fecha_de_Movimiento = (!String.IsNullOrEmpty(varRegistro_de_Movimiento.Fecha_de_Movimiento)) ? DateTime.ParseExact(varRegistro_de_Movimiento.Fecha_de_Movimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Movimiento = varRegistro_de_Movimiento.Hora_de_Movimiento
                        ,Informacion = varRegistro_de_Movimiento.Informacion
                    
                };

                result = _IRegistro_de_MovimientoApiConsumer.Update_Datos_Generales(Registro_de_Movimiento_Datos_GeneralesInfo).Resource.ToString();
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
                _IRegistro_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_MovimientoApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Registro_de_Movimiento_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Judicializacion = m.Judicializacion
                        ,Judicializacioncausa_o_cuadernillo = CultureHelper.GetTraduction(m.Judicializacion_Judicializacion.Clave.ToString(), "Judicializacion") ?? (string)m.Judicializacion_Judicializacion.causa_o_cuadernillo
                        ,Fase = m.Fase
                        ,FaseDescripcion = CultureHelper.GetTraduction(m.Fase_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Fase_de_Judicializacion.Descripcion
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Movimiento_Realizado = m.Movimiento_Realizado
                        ,Movimiento_RealizadoDescripcion = CultureHelper.GetTraduction(m.Movimiento_Realizado_Configurador_de_Movimientos.Clave.ToString(), "Configurador_de_Movimientos") ?? (string)m.Movimiento_Realizado_Configurador_de_Movimientos.Descripcion
                        ,Fecha_de_Movimiento = (m.Fecha_de_Movimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Movimiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Movimiento = m.Hora_de_Movimiento
			,Informacion = m.Informacion

                    
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

