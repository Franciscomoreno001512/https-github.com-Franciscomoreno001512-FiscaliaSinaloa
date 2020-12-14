using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Desestimacion;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Causas_de_Interrupcion;
using Spartane.Core.Domain.A_Tiempo;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Desestimacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Desestimacion;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_Generales;
using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.Causas_de_Interrupcion;
using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;

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
    public class Detalle_de_DesestimacionController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_DesestimacionService service = null;
        private IDetalle_de_DesestimacionApiConsumer _IDetalle_de_DesestimacionApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private IDetalle_de_Datos_GeneralesApiConsumer _IDetalle_de_Datos_GeneralesApiConsumer;
        private IA_TiempoApiConsumer _IA_TiempoApiConsumer;
        private ICausas_de_InterrupcionApiConsumer _ICausas_de_InterrupcionApiConsumer;

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

        
        public Detalle_de_DesestimacionController(IDetalle_de_DesestimacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_DesestimacionApiConsumer Detalle_de_DesestimacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , IDetalle_de_Datos_GeneralesApiConsumer Detalle_de_Datos_GeneralesApiConsumer , IA_TiempoApiConsumer A_TiempoApiConsumer , ICausas_de_InterrupcionApiConsumer Causas_de_InterrupcionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_DesestimacionApiConsumer = Detalle_de_DesestimacionApiConsumer;
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
            this._IDetalle_de_Datos_GeneralesApiConsumer = Detalle_de_Datos_GeneralesApiConsumer;
            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;
            this._ICausas_de_InterrupcionApiConsumer = Causas_de_InterrupcionApiConsumer;
            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Desestimacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45192, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45192, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_de_Desestimacion/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45192, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45192, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_de_Desestimacion = new Detalle_de_DesestimacionModel();
			varDetalle_de_Desestimacion.Clave = Id;
			
            ViewBag.ObjectId = "45192";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_de_DesestimacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_DesestimacionsData = _IDetalle_de_DesestimacionApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Desestimacion.Clave=" + Id, "").Resource.Detalle_de_Desestimacions;
				
				if (Detalle_de_DesestimacionsData != null && Detalle_de_DesestimacionsData.Count > 0)
                {
					var Detalle_de_DesestimacionData = Detalle_de_DesestimacionsData.First();
					varDetalle_de_Desestimacion= new Detalle_de_DesestimacionModel
					{
						Clave  = Detalle_de_DesestimacionData.Clave 
	                    ,Modulo_Atencion_Inicial = Detalle_de_DesestimacionData.Modulo_Atencion_Inicial
                    ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DesestimacionData.Modulo_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Detalle_de_DesestimacionData.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Nombre_Completo = Detalle_de_DesestimacionData.Nombre_Completo
                    ,Nombre_CompletoNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DesestimacionData.Nombre_Completo), "Detalle_de_Datos_Generales") ??  (string)Detalle_de_DesestimacionData.Nombre_Completo_Detalle_de_Datos_Generales.Nombre_Completo
                    ,Causal_de_Interrupcion = Detalle_de_DesestimacionData.Causal_de_Interrupcion
                    ,Causal_de_InterrupcionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DesestimacionData.Causal_de_Interrupcion), "A_Tiempo") ??  (string)Detalle_de_DesestimacionData.Causal_de_Interrupcion_A_Tiempo.Descripcion
                    ,Causa_de_Interrupcion = Detalle_de_DesestimacionData.Causa_de_Interrupcion
                    ,Causa_de_InterrupcionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DesestimacionData.Causa_de_Interrupcion), "Causas_de_Interrupcion") ??  (string)Detalle_de_DesestimacionData.Causa_de_Interrupcion_Causas_de_Interrupcion.Descripcion
                    ,Datos_Insuficientes = Detalle_de_DesestimacionData.Datos_Insuficientes
                    ,Datos_InsuficientesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DesestimacionData.Datos_Insuficientes), "A_Tiempo") ??  (string)Detalle_de_DesestimacionData.Datos_Insuficientes_A_Tiempo.Descripcion
                    ,Actualizacion_de_Sobreseimiento = Detalle_de_DesestimacionData.Actualizacion_de_Sobreseimiento

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Causal_de_Interrupcion = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Causal_de_Interrupcion != null && A_Tiempos_Causal_de_Interrupcion.Resource != null)
                ViewBag.A_Tiempos_Causal_de_Interrupcion = A_Tiempos_Causal_de_Interrupcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICausas_de_InterrupcionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Causas_de_Interrupcions_Causa_de_Interrupcion = _ICausas_de_InterrupcionApiConsumer.SelAll(true);
            if (Causas_de_Interrupcions_Causa_de_Interrupcion != null && Causas_de_Interrupcions_Causa_de_Interrupcion.Resource != null)
                ViewBag.Causas_de_Interrupcions_Causa_de_Interrupcion = Causas_de_Interrupcions_Causa_de_Interrupcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Causas_de_Interrupcion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Datos_Insuficientes = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Datos_Insuficientes != null && A_Tiempos_Datos_Insuficientes.Resource != null)
                ViewBag.A_Tiempos_Datos_Insuficientes = A_Tiempos_Datos_Insuficientes.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDetalle_de_Desestimacion);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Desestimacion(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45192);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_DesestimacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_DesestimacionModel varDetalle_de_Desestimacion= new Detalle_de_DesestimacionModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_DesestimacionsData = _IDetalle_de_DesestimacionApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Desestimacion.Clave=" + id, "").Resource.Detalle_de_Desestimacions;
				
				if (Detalle_de_DesestimacionsData != null && Detalle_de_DesestimacionsData.Count > 0)
                {
					var Detalle_de_DesestimacionData = Detalle_de_DesestimacionsData.First();
					varDetalle_de_Desestimacion= new Detalle_de_DesestimacionModel
					{
						Clave  = Detalle_de_DesestimacionData.Clave 
	                    ,Modulo_Atencion_Inicial = Detalle_de_DesestimacionData.Modulo_Atencion_Inicial
                    ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DesestimacionData.Modulo_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Detalle_de_DesestimacionData.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Nombre_Completo = Detalle_de_DesestimacionData.Nombre_Completo
                    ,Nombre_CompletoNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DesestimacionData.Nombre_Completo), "Detalle_de_Datos_Generales") ??  (string)Detalle_de_DesestimacionData.Nombre_Completo_Detalle_de_Datos_Generales.Nombre_Completo
                    ,Causal_de_Interrupcion = Detalle_de_DesestimacionData.Causal_de_Interrupcion
                    ,Causal_de_InterrupcionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DesestimacionData.Causal_de_Interrupcion), "A_Tiempo") ??  (string)Detalle_de_DesestimacionData.Causal_de_Interrupcion_A_Tiempo.Descripcion
                    ,Causa_de_Interrupcion = Detalle_de_DesestimacionData.Causa_de_Interrupcion
                    ,Causa_de_InterrupcionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DesestimacionData.Causa_de_Interrupcion), "Causas_de_Interrupcion") ??  (string)Detalle_de_DesestimacionData.Causa_de_Interrupcion_Causas_de_Interrupcion.Descripcion
                    ,Datos_Insuficientes = Detalle_de_DesestimacionData.Datos_Insuficientes
                    ,Datos_InsuficientesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_DesestimacionData.Datos_Insuficientes), "A_Tiempo") ??  (string)Detalle_de_DesestimacionData.Datos_Insuficientes_A_Tiempo.Descripcion
                    ,Actualizacion_de_Sobreseimiento = Detalle_de_DesestimacionData.Actualizacion_de_Sobreseimiento

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Causal_de_Interrupcion = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Causal_de_Interrupcion != null && A_Tiempos_Causal_de_Interrupcion.Resource != null)
                ViewBag.A_Tiempos_Causal_de_Interrupcion = A_Tiempos_Causal_de_Interrupcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICausas_de_InterrupcionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Causas_de_Interrupcions_Causa_de_Interrupcion = _ICausas_de_InterrupcionApiConsumer.SelAll(true);
            if (Causas_de_Interrupcions_Causa_de_Interrupcion != null && Causas_de_Interrupcions_Causa_de_Interrupcion.Resource != null)
                ViewBag.Causas_de_Interrupcions_Causa_de_Interrupcion = Causas_de_Interrupcions_Causa_de_Interrupcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Causas_de_Interrupcion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Datos_Insuficientes = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Datos_Insuficientes != null && A_Tiempos_Datos_Insuficientes.Resource != null)
                ViewBag.A_Tiempos_Datos_Insuficientes = A_Tiempos_Datos_Insuficientes.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Desestimacion", varDetalle_de_Desestimacion);
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
        public ActionResult GetDetalle_de_Datos_GeneralesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_Completo")?? m.Nombre_Completo,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetA_TiempoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IA_TiempoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCausas_de_InterrupcionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICausas_de_InterrupcionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICausas_de_InterrupcionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Causas_de_Interrupcion", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Detalle_de_DesestimacionAdvanceSearchModel model, int idFilter = -1)
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

            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Causal_de_Interrupcion = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Causal_de_Interrupcion != null && A_Tiempos_Causal_de_Interrupcion.Resource != null)
                ViewBag.A_Tiempos_Causal_de_Interrupcion = A_Tiempos_Causal_de_Interrupcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICausas_de_InterrupcionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Causas_de_Interrupcions_Causa_de_Interrupcion = _ICausas_de_InterrupcionApiConsumer.SelAll(true);
            if (Causas_de_Interrupcions_Causa_de_Interrupcion != null && Causas_de_Interrupcions_Causa_de_Interrupcion.Resource != null)
                ViewBag.Causas_de_Interrupcions_Causa_de_Interrupcion = Causas_de_Interrupcions_Causa_de_Interrupcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Causas_de_Interrupcion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Datos_Insuficientes = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Datos_Insuficientes != null && A_Tiempos_Datos_Insuficientes.Resource != null)
                ViewBag.A_Tiempos_Datos_Insuficientes = A_Tiempos_Datos_Insuficientes.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Causal_de_Interrupcion = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Causal_de_Interrupcion != null && A_Tiempos_Causal_de_Interrupcion.Resource != null)
                ViewBag.A_Tiempos_Causal_de_Interrupcion = A_Tiempos_Causal_de_Interrupcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICausas_de_InterrupcionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Causas_de_Interrupcions_Causa_de_Interrupcion = _ICausas_de_InterrupcionApiConsumer.SelAll(true);
            if (Causas_de_Interrupcions_Causa_de_Interrupcion != null && Causas_de_Interrupcions_Causa_de_Interrupcion.Resource != null)
                ViewBag.Causas_de_Interrupcions_Causa_de_Interrupcion = Causas_de_Interrupcions_Causa_de_Interrupcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Causas_de_Interrupcion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Datos_Insuficientes = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Datos_Insuficientes != null && A_Tiempos_Datos_Insuficientes.Resource != null)
                ViewBag.A_Tiempos_Datos_Insuficientes = A_Tiempos_Datos_Insuficientes.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Detalle_de_DesestimacionAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_de_DesestimacionAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_de_DesestimacionAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_DesestimacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_DesestimacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Desestimacions == null)
                result.Detalle_de_Desestimacions = new List<Detalle_de_Desestimacion>();

            return Json(new
            {
                data = result.Detalle_de_Desestimacions.Select(m => new Detalle_de_DesestimacionGridModel
                    {
                    Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Nombre_CompletoNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Completo_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Nombre_Completo_Detalle_de_Datos_Generales.Nombre_Completo
                        ,Causal_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causal_de_Interrupcion_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Causal_de_Interrupcion_A_Tiempo.Descripcion
                        ,Causa_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causa_de_Interrupcion_Causas_de_Interrupcion.Clave.ToString(), "Descripcion") ?? (string)m.Causa_de_Interrupcion_Causas_de_Interrupcion.Descripcion
                        ,Datos_InsuficientesDescripcion = CultureHelper.GetTraduction(m.Datos_Insuficientes_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Datos_Insuficientes_A_Tiempo.Descripcion
			,Actualizacion_de_Sobreseimiento = m.Actualizacion_de_Sobreseimiento

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_de_DesestimacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_DesestimacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_DesestimacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_de_Desestimacion", m.),
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
        /// Get List of Detalle_de_Desestimacion from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_de_Desestimacion Entity</returns>
        public ActionResult GetDetalle_de_DesestimacionList(UrlParametersModel param)
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
            _IDetalle_de_DesestimacionApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_de_DesestimacionPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_de_DesestimacionAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_de_DesestimacionAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_de_DesestimacionPropertyMapper oDetalle_de_DesestimacionPropertyMapper = new Detalle_de_DesestimacionPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_de_DesestimacionPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_de_DesestimacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Desestimacions == null)
                result.Detalle_de_Desestimacions = new List<Detalle_de_Desestimacion>();

            return Json(new
            {
                aaData = result.Detalle_de_Desestimacions.Select(m => new Detalle_de_DesestimacionGridModel
            {
                    Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Nombre_CompletoNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Completo_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Nombre_Completo_Detalle_de_Datos_Generales.Nombre_Completo
                        ,Causal_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causal_de_Interrupcion_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Causal_de_Interrupcion_A_Tiempo.Descripcion
                        ,Causa_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causa_de_Interrupcion_Causas_de_Interrupcion.Clave.ToString(), "Descripcion") ?? (string)m.Causa_de_Interrupcion_Causas_de_Interrupcion.Descripcion
                        ,Datos_InsuficientesDescripcion = CultureHelper.GetTraduction(m.Datos_Insuficientes_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Datos_Insuficientes_A_Tiempo.Descripcion
			,Actualizacion_de_Sobreseimiento = m.Actualizacion_de_Sobreseimiento

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Desestimacion_Modulo_Atencion_Inicial_Modulo_Atencion_Inicial(string query, string where)
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
        public JsonResult GetDetalle_de_Desestimacion_Nombre_Completo_Detalle_de_Datos_Generales(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Datos_Generales.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Datos_Generales.Nombre_Completo as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_Datos_GeneralesApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Datos_Generales.Nombre_Completo ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Datos_Generaless)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Datos_Generales", "Nombre_Completo");
                    item.Nombre_Completo =trans ??item.Nombre_Completo;
                }
                return Json(result.Detalle_de_Datos_Generaless.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public string GetAdvanceFilter(Detalle_de_DesestimacionAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_de_Desestimacion.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_de_Desestimacion.Clave <= " + filter.ToClave;
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

                where += " AND Detalle_de_Desestimacion.Modulo_Atencion_Inicial In (" + Modulo_Atencion_InicialIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNombre_Completo))
            {
                switch (filter.Nombre_CompletoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo LIKE '" + filter.AdvanceNombre_Completo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo LIKE '%" + filter.AdvanceNombre_Completo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo = '" + filter.AdvanceNombre_Completo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo LIKE '%" + filter.AdvanceNombre_Completo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNombre_CompletoMultiple != null && filter.AdvanceNombre_CompletoMultiple.Count() > 0)
            {
                var Nombre_CompletoIds = string.Join(",", filter.AdvanceNombre_CompletoMultiple);

                where += " AND Detalle_de_Desestimacion.Nombre_Completo In (" + Nombre_CompletoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCausal_de_Interrupcion))
            {
                switch (filter.Causal_de_InterrupcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.AdvanceCausal_de_Interrupcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceCausal_de_Interrupcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.AdvanceCausal_de_Interrupcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceCausal_de_Interrupcion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCausal_de_InterrupcionMultiple != null && filter.AdvanceCausal_de_InterrupcionMultiple.Count() > 0)
            {
                var Causal_de_InterrupcionIds = string.Join(",", filter.AdvanceCausal_de_InterrupcionMultiple);

                where += " AND Detalle_de_Desestimacion.Causal_de_Interrupcion In (" + Causal_de_InterrupcionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCausa_de_Interrupcion))
            {
                switch (filter.Causa_de_InterrupcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Causas_de_Interrupcion.Descripcion LIKE '" + filter.AdvanceCausa_de_Interrupcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Causas_de_Interrupcion.Descripcion LIKE '%" + filter.AdvanceCausa_de_Interrupcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Causas_de_Interrupcion.Descripcion = '" + filter.AdvanceCausa_de_Interrupcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Causas_de_Interrupcion.Descripcion LIKE '%" + filter.AdvanceCausa_de_Interrupcion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCausa_de_InterrupcionMultiple != null && filter.AdvanceCausa_de_InterrupcionMultiple.Count() > 0)
            {
                var Causa_de_InterrupcionIds = string.Join(",", filter.AdvanceCausa_de_InterrupcionMultiple);

                where += " AND Detalle_de_Desestimacion.Causa_de_Interrupcion In (" + Causa_de_InterrupcionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDatos_Insuficientes))
            {
                switch (filter.Datos_InsuficientesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.AdvanceDatos_Insuficientes + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceDatos_Insuficientes + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.AdvanceDatos_Insuficientes + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceDatos_Insuficientes + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDatos_InsuficientesMultiple != null && filter.AdvanceDatos_InsuficientesMultiple.Count() > 0)
            {
                var Datos_InsuficientesIds = string.Join(",", filter.AdvanceDatos_InsuficientesMultiple);

                where += " AND Detalle_de_Desestimacion.Datos_Insuficientes In (" + Datos_InsuficientesIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Actualizacion_de_Sobreseimiento))
            {
                switch (filter.Actualizacion_de_SobreseimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Desestimacion.Actualizacion_de_Sobreseimiento LIKE '" + filter.Actualizacion_de_Sobreseimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Desestimacion.Actualizacion_de_Sobreseimiento LIKE '%" + filter.Actualizacion_de_Sobreseimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Desestimacion.Actualizacion_de_Sobreseimiento = '" + filter.Actualizacion_de_Sobreseimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Desestimacion.Actualizacion_de_Sobreseimiento LIKE '%" + filter.Actualizacion_de_Sobreseimiento + "%'";
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
                _IDetalle_de_DesestimacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Desestimacion varDetalle_de_Desestimacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_DesestimacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_DesestimacionModel varDetalle_de_Desestimacion)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_DesestimacionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_DesestimacionInfo = new Detalle_de_Desestimacion
                    {
                        Clave = varDetalle_de_Desestimacion.Clave
                        ,Modulo_Atencion_Inicial = varDetalle_de_Desestimacion.Modulo_Atencion_Inicial
                        ,Nombre_Completo = varDetalle_de_Desestimacion.Nombre_Completo
                        ,Causal_de_Interrupcion = varDetalle_de_Desestimacion.Causal_de_Interrupcion
                        ,Causa_de_Interrupcion = varDetalle_de_Desestimacion.Causa_de_Interrupcion
                        ,Datos_Insuficientes = varDetalle_de_Desestimacion.Datos_Insuficientes
                        ,Actualizacion_de_Sobreseimiento = varDetalle_de_Desestimacion.Actualizacion_de_Sobreseimiento

                    };

                    result = !IsNew ?
                        _IDetalle_de_DesestimacionApiConsumer.Update(Detalle_de_DesestimacionInfo, null, null).Resource.ToString() :
                         _IDetalle_de_DesestimacionApiConsumer.Insert(Detalle_de_DesestimacionInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Detalle_de_Desestimacion script
        /// </summary>
        /// <param name="oDetalle_de_DesestimacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_de_DesestimacionModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_DesestimacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_DesestimacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_DesestimacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_DesestimacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_DesestimacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_DesestimacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_DesestimacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_de_DesestimacionModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_de_DesestimacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_de_DesestimacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_de_DesestimacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_de_DesestimacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_de_DesestimacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Desestimacion.js")))
            {
                strDetalle_de_DesestimacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Desestimacion element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_DesestimacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_DesestimacionScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_DesestimacionScript.Substring(indexOfArray, strDetalle_de_DesestimacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_DesestimacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_DesestimacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_DesestimacionScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_de_DesestimacionScript.Substring(indexOfArrayHistory, strDetalle_de_DesestimacionScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_de_DesestimacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_DesestimacionScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_DesestimacionScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_de_DesestimacionModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_de_DesestimacionModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Desestimacion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Desestimacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Desestimacion.js")))
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
        public ActionResult Detalle_de_DesestimacionPropertyBag()
        {
            return PartialView("Detalle_de_DesestimacionPropertyBag", "Detalle_de_Desestimacion");
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
                var whereClauseFormat = "Object = 45192 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_de_DesestimacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_de_Desestimacion.Clave= " + RecordId;
                            var result = _IDetalle_de_DesestimacionApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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
										  
			string[] arrayColumnsVisible = null;

			 where = HttpUtility.UrlEncode(where);
            if (!_tokenManager.GenerateToken())
                return;

            _IDetalle_de_DesestimacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_DesestimacionPropertyMapper());
			
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
                    (Detalle_de_DesestimacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_de_DesestimacionPropertyMapper oDetalle_de_DesestimacionPropertyMapper = new Detalle_de_DesestimacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_DesestimacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_DesestimacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Desestimacions == null)
                result.Detalle_de_Desestimacions = new List<Detalle_de_Desestimacion>();

            var data = result.Detalle_de_Desestimacions.Select(m => new Detalle_de_DesestimacionGridModel
            {
                Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Nombre_CompletoNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Completo_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Nombre_Completo_Detalle_de_Datos_Generales.Nombre_Completo
                        ,Causal_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causal_de_Interrupcion_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Causal_de_Interrupcion_A_Tiempo.Descripcion
                        ,Causa_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causa_de_Interrupcion_Causas_de_Interrupcion.Clave.ToString(), "Descripcion") ?? (string)m.Causa_de_Interrupcion_Causas_de_Interrupcion.Descripcion
                        ,Datos_InsuficientesDescripcion = CultureHelper.GetTraduction(m.Datos_Insuficientes_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Datos_Insuficientes_A_Tiempo.Descripcion
			,Actualizacion_de_Sobreseimiento = m.Actualizacion_de_Sobreseimiento

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45192, arrayColumnsVisible), "Detalle_de_DesestimacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45192, arrayColumnsVisible), "Detalle_de_DesestimacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45192, arrayColumnsVisible), "Detalle_de_DesestimacionList_" + DateTime.Now.ToString());
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

            _IDetalle_de_DesestimacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_DesestimacionPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_de_DesestimacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_de_DesestimacionPropertyMapper oDetalle_de_DesestimacionPropertyMapper = new Detalle_de_DesestimacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_DesestimacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_DesestimacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Desestimacions == null)
                result.Detalle_de_Desestimacions = new List<Detalle_de_Desestimacion>();

            var data = result.Detalle_de_Desestimacions.Select(m => new Detalle_de_DesestimacionGridModel
            {
                Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Nombre_CompletoNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Completo_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Nombre_Completo_Detalle_de_Datos_Generales.Nombre_Completo
                        ,Causal_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causal_de_Interrupcion_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Causal_de_Interrupcion_A_Tiempo.Descripcion
                        ,Causa_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causa_de_Interrupcion_Causas_de_Interrupcion.Clave.ToString(), "Descripcion") ?? (string)m.Causa_de_Interrupcion_Causas_de_Interrupcion.Descripcion
                        ,Datos_InsuficientesDescripcion = CultureHelper.GetTraduction(m.Datos_Insuficientes_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Datos_Insuficientes_A_Tiempo.Descripcion
			,Actualizacion_de_Sobreseimiento = m.Actualizacion_de_Sobreseimiento

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
                _IDetalle_de_DesestimacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_DesestimacionApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_de_Desestimacion_Datos_GeneralesModel varDetalle_de_Desestimacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_DesestimacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Desestimacion_Datos_GeneralesInfo = new Detalle_de_Desestimacion_Datos_Generales
                {
                    Clave = varDetalle_de_Desestimacion.Clave
                                            ,Modulo_Atencion_Inicial = varDetalle_de_Desestimacion.Modulo_Atencion_Inicial
                        ,Nombre_Completo = varDetalle_de_Desestimacion.Nombre_Completo
                        ,Causal_de_Interrupcion = varDetalle_de_Desestimacion.Causal_de_Interrupcion
                        ,Causa_de_Interrupcion = varDetalle_de_Desestimacion.Causa_de_Interrupcion
                        ,Datos_Insuficientes = varDetalle_de_Desestimacion.Datos_Insuficientes
                        ,Actualizacion_de_Sobreseimiento = varDetalle_de_Desestimacion.Actualizacion_de_Sobreseimiento
                    
                };

                result = _IDetalle_de_DesestimacionApiConsumer.Update_Datos_Generales(Detalle_de_Desestimacion_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_de_DesestimacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_DesestimacionApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Detalle_de_Desestimacion_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Modulo_Atencion_Inicial = m.Modulo_Atencion_Inicial
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Nombre_Completo = m.Nombre_Completo
                        ,Nombre_CompletoNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Completo_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Nombre_Completo_Detalle_de_Datos_Generales.Nombre_Completo
                        ,Causal_de_Interrupcion = m.Causal_de_Interrupcion
                        ,Causal_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causal_de_Interrupcion_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Causal_de_Interrupcion_A_Tiempo.Descripcion
                        ,Causa_de_Interrupcion = m.Causa_de_Interrupcion
                        ,Causa_de_InterrupcionDescripcion = CultureHelper.GetTraduction(m.Causa_de_Interrupcion_Causas_de_Interrupcion.Clave.ToString(), "Descripcion") ?? (string)m.Causa_de_Interrupcion_Causas_de_Interrupcion.Descripcion
                        ,Datos_Insuficientes = m.Datos_Insuficientes
                        ,Datos_InsuficientesDescripcion = CultureHelper.GetTraduction(m.Datos_Insuficientes_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Datos_Insuficientes_A_Tiempo.Descripcion
			,Actualizacion_de_Sobreseimiento = m.Actualizacion_de_Sobreseimiento

                    
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

