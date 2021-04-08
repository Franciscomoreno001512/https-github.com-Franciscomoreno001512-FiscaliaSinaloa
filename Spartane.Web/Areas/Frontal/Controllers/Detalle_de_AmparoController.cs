using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Amparo;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Tipo_de_Amparo;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Tipo_de_Resolucion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Amparo;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Amparo;
using Spartane.Web.Areas.WebApiConsumer.Registro_de_Mandamiento_Judicial;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Amparo;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Resolucion;

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
    public class Detalle_de_AmparoController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_AmparoService service = null;
        private IDetalle_de_AmparoApiConsumer _IDetalle_de_AmparoApiConsumer;
        private IRegistro_de_Mandamiento_JudicialApiConsumer _IRegistro_de_Mandamiento_JudicialApiConsumer;
        private ITipo_de_AmparoApiConsumer _ITipo_de_AmparoApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private ITipo_de_ResolucionApiConsumer _ITipo_de_ResolucionApiConsumer;

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

        
        public Detalle_de_AmparoController(IDetalle_de_AmparoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_AmparoApiConsumer Detalle_de_AmparoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IRegistro_de_Mandamiento_JudicialApiConsumer Registro_de_Mandamiento_JudicialApiConsumer , ITipo_de_AmparoApiConsumer Tipo_de_AmparoApiConsumer , IEstadoApiConsumer EstadoApiConsumer , ITipo_de_ResolucionApiConsumer Tipo_de_ResolucionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_AmparoApiConsumer = Detalle_de_AmparoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IRegistro_de_Mandamiento_JudicialApiConsumer = Registro_de_Mandamiento_JudicialApiConsumer;
            this._ITipo_de_AmparoApiConsumer = Tipo_de_AmparoApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._ITipo_de_ResolucionApiConsumer = Tipo_de_ResolucionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Amparo
        [ObjectAuth(ObjectId = (ModuleObjectId)45663, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45663, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_de_Amparo/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45663, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45663, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_de_Amparo = new Detalle_de_AmparoModel();
			varDetalle_de_Amparo.Clave = Id;
			
            ViewBag.ObjectId = "45663";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_AmparosData = _IDetalle_de_AmparoApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Amparo.Clave=" + Id, "").Resource.Detalle_de_Amparos;
				
				if (Detalle_de_AmparosData != null && Detalle_de_AmparosData.Count > 0)
                {
					var Detalle_de_AmparoData = Detalle_de_AmparosData.First();
					varDetalle_de_Amparo= new Detalle_de_AmparoModel
					{
						Clave  = Detalle_de_AmparoData.Clave 
	                    ,Orden_de_Aprehension = Detalle_de_AmparoData.Orden_de_Aprehension
                    ,Orden_de_AprehensionNumero_de_Mandamiento = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_AmparoData.Orden_de_Aprehension), "Registro_de_Mandamiento_Judicial") ??  (string)Detalle_de_AmparoData.Orden_de_Aprehension_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                    ,Tipo_de_Amparo = Detalle_de_AmparoData.Tipo_de_Amparo
                    ,Tipo_de_AmparoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_AmparoData.Tipo_de_Amparo), "Tipo_de_Amparo") ??  (string)Detalle_de_AmparoData.Tipo_de_Amparo_Tipo_de_Amparo.Descripcion
                    ,Numero_de_Amparo = Detalle_de_AmparoData.Numero_de_Amparo
                    ,Fecha_Amparo = (Detalle_de_AmparoData.Fecha_Amparo == null ? string.Empty : Convert.ToDateTime(Detalle_de_AmparoData.Fecha_Amparo).ToString(ConfigurationProperty.DateFormat))
                    ,Entidad_que_Emitio_Amparo = Detalle_de_AmparoData.Entidad_que_Emitio_Amparo
                    ,Entidad_que_Emitio_AmparoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_AmparoData.Entidad_que_Emitio_Amparo), "Estado") ??  (string)Detalle_de_AmparoData.Entidad_que_Emitio_Amparo_Estado.Nombre
                    ,Resolucion = Detalle_de_AmparoData.Resolucion
                    ,ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_AmparoData.Resolucion), "Tipo_de_Resolucion") ??  (string)Detalle_de_AmparoData.Resolucion_Tipo_de_Resolucion.Descripcion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Amparos_Tipo_de_Amparo = _ITipo_de_AmparoApiConsumer.SelAll(true);
            if (Tipo_de_Amparos_Tipo_de_Amparo != null && Tipo_de_Amparos_Tipo_de_Amparo.Resource != null)
                ViewBag.Tipo_de_Amparos_Tipo_de_Amparo = Tipo_de_Amparos_Tipo_de_Amparo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Amparo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Resolucions_Resolucion = _ITipo_de_ResolucionApiConsumer.SelAll(true);
            if (Tipo_de_Resolucions_Resolucion != null && Tipo_de_Resolucions_Resolucion.Resource != null)
                ViewBag.Tipo_de_Resolucions_Resolucion = Tipo_de_Resolucions_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDetalle_de_Amparo);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Amparo(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45663);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_AmparoModel varDetalle_de_Amparo= new Detalle_de_AmparoModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_AmparosData = _IDetalle_de_AmparoApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Amparo.Clave=" + id, "").Resource.Detalle_de_Amparos;
				
				if (Detalle_de_AmparosData != null && Detalle_de_AmparosData.Count > 0)
                {
					var Detalle_de_AmparoData = Detalle_de_AmparosData.First();
					varDetalle_de_Amparo= new Detalle_de_AmparoModel
					{
						Clave  = Detalle_de_AmparoData.Clave 
	                    ,Orden_de_Aprehension = Detalle_de_AmparoData.Orden_de_Aprehension
                    ,Orden_de_AprehensionNumero_de_Mandamiento = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_AmparoData.Orden_de_Aprehension), "Registro_de_Mandamiento_Judicial") ??  (string)Detalle_de_AmparoData.Orden_de_Aprehension_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                    ,Tipo_de_Amparo = Detalle_de_AmparoData.Tipo_de_Amparo
                    ,Tipo_de_AmparoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_AmparoData.Tipo_de_Amparo), "Tipo_de_Amparo") ??  (string)Detalle_de_AmparoData.Tipo_de_Amparo_Tipo_de_Amparo.Descripcion
                    ,Numero_de_Amparo = Detalle_de_AmparoData.Numero_de_Amparo
                    ,Fecha_Amparo = (Detalle_de_AmparoData.Fecha_Amparo == null ? string.Empty : Convert.ToDateTime(Detalle_de_AmparoData.Fecha_Amparo).ToString(ConfigurationProperty.DateFormat))
                    ,Entidad_que_Emitio_Amparo = Detalle_de_AmparoData.Entidad_que_Emitio_Amparo
                    ,Entidad_que_Emitio_AmparoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_AmparoData.Entidad_que_Emitio_Amparo), "Estado") ??  (string)Detalle_de_AmparoData.Entidad_que_Emitio_Amparo_Estado.Nombre
                    ,Resolucion = Detalle_de_AmparoData.Resolucion
                    ,ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_AmparoData.Resolucion), "Tipo_de_Resolucion") ??  (string)Detalle_de_AmparoData.Resolucion_Tipo_de_Resolucion.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Amparos_Tipo_de_Amparo = _ITipo_de_AmparoApiConsumer.SelAll(true);
            if (Tipo_de_Amparos_Tipo_de_Amparo != null && Tipo_de_Amparos_Tipo_de_Amparo.Resource != null)
                ViewBag.Tipo_de_Amparos_Tipo_de_Amparo = Tipo_de_Amparos_Tipo_de_Amparo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Amparo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Resolucions_Resolucion = _ITipo_de_ResolucionApiConsumer.SelAll(true);
            if (Tipo_de_Resolucions_Resolucion != null && Tipo_de_Resolucions_Resolucion.Resource != null)
                ViewBag.Tipo_de_Resolucions_Resolucion = Tipo_de_Resolucions_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Amparo", varDetalle_de_Amparo);
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
        public ActionResult GetRegistro_de_Mandamiento_JudicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegistro_de_Mandamiento_JudicialApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Numero_de_Mandamiento).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Registro_de_Mandamiento_Judicial", "Numero_de_Mandamiento")?? m.Numero_de_Mandamiento,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_AmparoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_AmparoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Amparo", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetTipo_de_ResolucionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ResolucionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Resolucion", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Detalle_de_AmparoAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Amparos_Tipo_de_Amparo = _ITipo_de_AmparoApiConsumer.SelAll(true);
            if (Tipo_de_Amparos_Tipo_de_Amparo != null && Tipo_de_Amparos_Tipo_de_Amparo.Resource != null)
                ViewBag.Tipo_de_Amparos_Tipo_de_Amparo = Tipo_de_Amparos_Tipo_de_Amparo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Amparo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Resolucions_Resolucion = _ITipo_de_ResolucionApiConsumer.SelAll(true);
            if (Tipo_de_Resolucions_Resolucion != null && Tipo_de_Resolucions_Resolucion.Resource != null)
                ViewBag.Tipo_de_Resolucions_Resolucion = Tipo_de_Resolucions_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Amparos_Tipo_de_Amparo = _ITipo_de_AmparoApiConsumer.SelAll(true);
            if (Tipo_de_Amparos_Tipo_de_Amparo != null && Tipo_de_Amparos_Tipo_de_Amparo.Resource != null)
                ViewBag.Tipo_de_Amparos_Tipo_de_Amparo = Tipo_de_Amparos_Tipo_de_Amparo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Amparo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Resolucions_Resolucion = _ITipo_de_ResolucionApiConsumer.SelAll(true);
            if (Tipo_de_Resolucions_Resolucion != null && Tipo_de_Resolucions_Resolucion.Resource != null)
                ViewBag.Tipo_de_Resolucions_Resolucion = Tipo_de_Resolucions_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Detalle_de_AmparoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_de_AmparoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_de_AmparoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_AmparoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_AmparoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Amparos == null)
                result.Detalle_de_Amparos = new List<Detalle_de_Amparo>();

            return Json(new
            {
                data = result.Detalle_de_Amparos.Select(m => new Detalle_de_AmparoGridModel
                    {
                    Clave = m.Clave
                        ,Orden_de_AprehensionNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Orden_de_Aprehension_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Orden_de_Aprehension_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Tipo_de_AmparoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Amparo_Tipo_de_Amparo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Amparo_Tipo_de_Amparo.Descripcion
			,Numero_de_Amparo = m.Numero_de_Amparo
                        ,Fecha_Amparo = (m.Fecha_Amparo == null ? string.Empty : Convert.ToDateTime(m.Fecha_Amparo).ToString(ConfigurationProperty.DateFormat))
                        ,Entidad_que_Emitio_AmparoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emitio_Amparo_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emitio_Amparo_Estado.Nombre
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Tipo_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Tipo_de_Resolucion.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_de_AmparoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_AmparoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_de_Amparo", m.),
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
        /// Get List of Detalle_de_Amparo from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_de_Amparo Entity</returns>
        public ActionResult GetDetalle_de_AmparoList(UrlParametersModel param)
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
            _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_de_AmparoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_de_AmparoAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_de_AmparoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_de_AmparoPropertyMapper oDetalle_de_AmparoPropertyMapper = new Detalle_de_AmparoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_de_AmparoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_de_AmparoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Amparos == null)
                result.Detalle_de_Amparos = new List<Detalle_de_Amparo>();

            return Json(new
            {
                aaData = result.Detalle_de_Amparos.Select(m => new Detalle_de_AmparoGridModel
            {
                    Clave = m.Clave
                        ,Orden_de_AprehensionNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Orden_de_Aprehension_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Orden_de_Aprehension_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Tipo_de_AmparoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Amparo_Tipo_de_Amparo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Amparo_Tipo_de_Amparo.Descripcion
			,Numero_de_Amparo = m.Numero_de_Amparo
                        ,Fecha_Amparo = (m.Fecha_Amparo == null ? string.Empty : Convert.ToDateTime(m.Fecha_Amparo).ToString(ConfigurationProperty.DateFormat))
                        ,Entidad_que_Emitio_AmparoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emitio_Amparo_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emitio_Amparo_Estado.Nombre
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Tipo_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Tipo_de_Resolucion.Descripcion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Amparo_Orden_de_Aprehension_Registro_de_Mandamiento_Judicial(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Registro_de_Mandamiento_Judicial.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IRegistro_de_Mandamiento_JudicialApiConsumer.ListaSelAll(1, 20,elWhere , " Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento ASC ").Resource;
               
                foreach (var item in result.Registro_de_Mandamiento_Judicials)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Registro_de_Mandamiento_Judicial", "Numero_de_Mandamiento");
                    item.Numero_de_Mandamiento =trans ??item.Numero_de_Mandamiento;
                }
                return Json(result.Registro_de_Mandamiento_Judicials.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Amparo_Entidad_que_Emitio_Amparo_Estado(string query, string where)
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





        [NonAction]
        public string GetAdvanceFilter(Detalle_de_AmparoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_de_Amparo.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_de_Amparo.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceOrden_de_Aprehension))
            {
                switch (filter.Orden_de_AprehensionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento LIKE '" + filter.AdvanceOrden_de_Aprehension + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento LIKE '%" + filter.AdvanceOrden_de_Aprehension + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento = '" + filter.AdvanceOrden_de_Aprehension + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento LIKE '%" + filter.AdvanceOrden_de_Aprehension + "%'";
                        break;
                }
            }
            else if (filter.AdvanceOrden_de_AprehensionMultiple != null && filter.AdvanceOrden_de_AprehensionMultiple.Count() > 0)
            {
                var Orden_de_AprehensionIds = string.Join(",", filter.AdvanceOrden_de_AprehensionMultiple);

                where += " AND Detalle_de_Amparo.Orden_de_Aprehension In (" + Orden_de_AprehensionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Amparo))
            {
                switch (filter.Tipo_de_AmparoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Amparo.Descripcion LIKE '" + filter.AdvanceTipo_de_Amparo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Amparo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Amparo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Amparo.Descripcion = '" + filter.AdvanceTipo_de_Amparo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Amparo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Amparo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_AmparoMultiple != null && filter.AdvanceTipo_de_AmparoMultiple.Count() > 0)
            {
                var Tipo_de_AmparoIds = string.Join(",", filter.AdvanceTipo_de_AmparoMultiple);

                where += " AND Detalle_de_Amparo.Tipo_de_Amparo In (" + Tipo_de_AmparoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Amparo))
            {
                switch (filter.Numero_de_AmparoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Amparo.Numero_de_Amparo LIKE '" + filter.Numero_de_Amparo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Amparo.Numero_de_Amparo LIKE '%" + filter.Numero_de_Amparo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Amparo.Numero_de_Amparo = '" + filter.Numero_de_Amparo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Amparo.Numero_de_Amparo LIKE '%" + filter.Numero_de_Amparo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Amparo) || !string.IsNullOrEmpty(filter.ToFecha_Amparo))
            {
                var Fecha_AmparoFrom = DateTime.ParseExact(filter.FromFecha_Amparo, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_AmparoTo = DateTime.ParseExact(filter.ToFecha_Amparo, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Amparo))
                    where += " AND Detalle_de_Amparo.Fecha_Amparo >= '" + Fecha_AmparoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Amparo))
                    where += " AND Detalle_de_Amparo.Fecha_Amparo <= '" + Fecha_AmparoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEntidad_que_Emitio_Amparo))
            {
                switch (filter.Entidad_que_Emitio_AmparoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEntidad_que_Emitio_Amparo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEntidad_que_Emitio_Amparo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEntidad_que_Emitio_Amparo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEntidad_que_Emitio_Amparo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEntidad_que_Emitio_AmparoMultiple != null && filter.AdvanceEntidad_que_Emitio_AmparoMultiple.Count() > 0)
            {
                var Entidad_que_Emitio_AmparoIds = string.Join(",", filter.AdvanceEntidad_que_Emitio_AmparoMultiple);

                where += " AND Detalle_de_Amparo.Entidad_que_Emitio_Amparo In (" + Entidad_que_Emitio_AmparoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResolucion))
            {
                switch (filter.ResolucionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Resolucion.Descripcion LIKE '" + filter.AdvanceResolucion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Resolucion.Descripcion LIKE '%" + filter.AdvanceResolucion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Resolucion.Descripcion = '" + filter.AdvanceResolucion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Resolucion.Descripcion LIKE '%" + filter.AdvanceResolucion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResolucionMultiple != null && filter.AdvanceResolucionMultiple.Count() > 0)
            {
                var ResolucionIds = string.Join(",", filter.AdvanceResolucionMultiple);

                where += " AND Detalle_de_Amparo.Resolucion In (" + ResolucionIds + ")";
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
                _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Amparo varDetalle_de_Amparo = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_AmparoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_AmparoModel varDetalle_de_Amparo)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_AmparoInfo = new Detalle_de_Amparo
                    {
                        Clave = varDetalle_de_Amparo.Clave
                        ,Orden_de_Aprehension = varDetalle_de_Amparo.Orden_de_Aprehension
                        ,Tipo_de_Amparo = varDetalle_de_Amparo.Tipo_de_Amparo
                        ,Numero_de_Amparo = varDetalle_de_Amparo.Numero_de_Amparo
                        ,Fecha_Amparo = (!String.IsNullOrEmpty(varDetalle_de_Amparo.Fecha_Amparo)) ? DateTime.ParseExact(varDetalle_de_Amparo.Fecha_Amparo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Entidad_que_Emitio_Amparo = varDetalle_de_Amparo.Entidad_que_Emitio_Amparo
                        ,Resolucion = varDetalle_de_Amparo.Resolucion

                    };

                    result = !IsNew ?
                        _IDetalle_de_AmparoApiConsumer.Update(Detalle_de_AmparoInfo, null, null).Resource.ToString() :
                         _IDetalle_de_AmparoApiConsumer.Insert(Detalle_de_AmparoInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Detalle_de_Amparo script
        /// </summary>
        /// <param name="oDetalle_de_AmparoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_de_AmparoModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_AmparoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_AmparoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_AmparoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_AmparoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_AmparoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_de_AmparoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Amparo.js")))
            {
                strDetalle_de_AmparoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Amparo element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_AmparoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_AmparoScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_AmparoScript.Substring(indexOfArray, strDetalle_de_AmparoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_AmparoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_de_AmparoScript.Substring(indexOfArrayHistory, strDetalle_de_AmparoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_de_AmparoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_AmparoScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_AmparoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Amparo.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Amparo.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Amparo.js")))
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
        public ActionResult Detalle_de_AmparoPropertyBag()
        {
            return PartialView("Detalle_de_AmparoPropertyBag", "Detalle_de_Amparo");
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
                var whereClauseFormat = "Object = 45663 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_de_Amparo.Clave= " + RecordId;
                            var result = _IDetalle_de_AmparoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_AmparoPropertyMapper());
			
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
                    (Detalle_de_AmparoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_de_AmparoPropertyMapper oDetalle_de_AmparoPropertyMapper = new Detalle_de_AmparoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_AmparoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_AmparoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Amparos == null)
                result.Detalle_de_Amparos = new List<Detalle_de_Amparo>();

            var data = result.Detalle_de_Amparos.Select(m => new Detalle_de_AmparoGridModel
            {
                Clave = m.Clave
                        ,Orden_de_AprehensionNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Orden_de_Aprehension_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Orden_de_Aprehension_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Tipo_de_AmparoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Amparo_Tipo_de_Amparo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Amparo_Tipo_de_Amparo.Descripcion
			,Numero_de_Amparo = m.Numero_de_Amparo
                        ,Fecha_Amparo = (m.Fecha_Amparo == null ? string.Empty : Convert.ToDateTime(m.Fecha_Amparo).ToString(ConfigurationProperty.DateFormat))
                        ,Entidad_que_Emitio_AmparoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emitio_Amparo_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emitio_Amparo_Estado.Nombre
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Tipo_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Tipo_de_Resolucion.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45663, arrayColumnsVisible), "Detalle_de_AmparoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45663, arrayColumnsVisible), "Detalle_de_AmparoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45663, arrayColumnsVisible), "Detalle_de_AmparoList_" + DateTime.Now.ToString());
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

            _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_AmparoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_de_AmparoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_de_AmparoPropertyMapper oDetalle_de_AmparoPropertyMapper = new Detalle_de_AmparoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_AmparoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_AmparoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Amparos == null)
                result.Detalle_de_Amparos = new List<Detalle_de_Amparo>();

            var data = result.Detalle_de_Amparos.Select(m => new Detalle_de_AmparoGridModel
            {
                Clave = m.Clave
                        ,Orden_de_AprehensionNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Orden_de_Aprehension_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Orden_de_Aprehension_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Tipo_de_AmparoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Amparo_Tipo_de_Amparo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Amparo_Tipo_de_Amparo.Descripcion
			,Numero_de_Amparo = m.Numero_de_Amparo
                        ,Fecha_Amparo = (m.Fecha_Amparo == null ? string.Empty : Convert.ToDateTime(m.Fecha_Amparo).ToString(ConfigurationProperty.DateFormat))
                        ,Entidad_que_Emitio_AmparoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emitio_Amparo_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emitio_Amparo_Estado.Nombre
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Tipo_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Tipo_de_Resolucion.Descripcion

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
                _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_AmparoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_de_Amparo_Datos_GeneralesModel varDetalle_de_Amparo)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Amparo_Datos_GeneralesInfo = new Detalle_de_Amparo_Datos_Generales
                {
                    Clave = varDetalle_de_Amparo.Clave
                                            ,Orden_de_Aprehension = varDetalle_de_Amparo.Orden_de_Aprehension
                        ,Tipo_de_Amparo = varDetalle_de_Amparo.Tipo_de_Amparo
                        ,Numero_de_Amparo = varDetalle_de_Amparo.Numero_de_Amparo
                        ,Fecha_Amparo = (!String.IsNullOrEmpty(varDetalle_de_Amparo.Fecha_Amparo)) ? DateTime.ParseExact(varDetalle_de_Amparo.Fecha_Amparo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Entidad_que_Emitio_Amparo = varDetalle_de_Amparo.Entidad_que_Emitio_Amparo
                        ,Resolucion = varDetalle_de_Amparo.Resolucion
                    
                };

                result = _IDetalle_de_AmparoApiConsumer.Update_Datos_Generales(Detalle_de_Amparo_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_AmparoApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Detalle_de_Amparo_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Orden_de_Aprehension = m.Orden_de_Aprehension
                        ,Orden_de_AprehensionNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Orden_de_Aprehension_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Orden_de_Aprehension_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Tipo_de_Amparo = m.Tipo_de_Amparo
                        ,Tipo_de_AmparoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Amparo_Tipo_de_Amparo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Amparo_Tipo_de_Amparo.Descripcion
			,Numero_de_Amparo = m.Numero_de_Amparo
                        ,Fecha_Amparo = (m.Fecha_Amparo == null ? string.Empty : Convert.ToDateTime(m.Fecha_Amparo).ToString(ConfigurationProperty.DateFormat))
                        ,Entidad_que_Emitio_Amparo = m.Entidad_que_Emitio_Amparo
                        ,Entidad_que_Emitio_AmparoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emitio_Amparo_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emitio_Amparo_Estado.Nombre
                        ,Resolucion = m.Resolucion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Tipo_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Tipo_de_Resolucion.Descripcion

                    
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

