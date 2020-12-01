using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Audiencias_MP;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Tipo_de_Audiencia;
using Spartane.Core.Domain.Audiencia;
using Spartane.Core.Domain.Detalle_Audiencia_Defensor_Imputado;

using Spartane.Core.Domain.Detalle_de_Imputado;



using Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima;

using Spartane.Core.Domain.Detalle_de_Imputado;



using Spartane.Core.Domain.Resultado_de_Audiencia;
using Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos;




using Spartane.Core.Domain.Spartan_User;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Audiencias_MP;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Audiencias_MP;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Audiencia;
using Spartane.Web.Areas.WebApiConsumer.Audiencia;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Audiencia_Defensor_Imputado;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Imputado;

using Spartane.Web.Areas.WebApiConsumer.Detalle_Audiencia_Defensor_Victima;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Imputado;

using Spartane.Web.Areas.WebApiConsumer.Resultado_de_Audiencia;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Audiencia_Archivos_Adjuntos;



using Spartane.Web.Areas.WebApiConsumer.Spartan_User;

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
    public class Audiencias_MPController : Controller
    {
        #region "variable declaration"

        private IAudiencias_MPService service = null;
        private IAudiencias_MPApiConsumer _IAudiencias_MPApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private ITipo_de_AudienciaApiConsumer _ITipo_de_AudienciaApiConsumer;
        private IAudienciaApiConsumer _IAudienciaApiConsumer;
        private IDetalle_Audiencia_Defensor_ImputadoApiConsumer _IDetalle_Audiencia_Defensor_ImputadoApiConsumer;

        private IDetalle_de_ImputadoApiConsumer _IDetalle_de_ImputadoApiConsumer;

        private IDetalle_Audiencia_Defensor_VictimaApiConsumer _IDetalle_Audiencia_Defensor_VictimaApiConsumer;


        private IResultado_de_AudienciaApiConsumer _IResultado_de_AudienciaApiConsumer;
        private IDetalle_Audiencia_Archivos_AdjuntosApiConsumer _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer;



        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;

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

        
        public Audiencias_MPController(IAudiencias_MPService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IAudiencias_MPApiConsumer Audiencias_MPApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , ITipo_de_AudienciaApiConsumer Tipo_de_AudienciaApiConsumer , IAudienciaApiConsumer AudienciaApiConsumer , IDetalle_Audiencia_Defensor_ImputadoApiConsumer Detalle_Audiencia_Defensor_ImputadoApiConsumer , IDetalle_de_ImputadoApiConsumer Detalle_de_ImputadoApiConsumer  , IDetalle_Audiencia_Defensor_VictimaApiConsumer Detalle_Audiencia_Defensor_VictimaApiConsumer  , IResultado_de_AudienciaApiConsumer Resultado_de_AudienciaApiConsumer , IDetalle_Audiencia_Archivos_AdjuntosApiConsumer Detalle_Audiencia_Archivos_AdjuntosApiConsumer  , ISpartan_UserApiConsumer Spartan_UserApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IAudiencias_MPApiConsumer = Audiencias_MPApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
            this._ITipo_de_AudienciaApiConsumer = Tipo_de_AudienciaApiConsumer;
            this._IAudienciaApiConsumer = AudienciaApiConsumer;
            this._IDetalle_Audiencia_Defensor_ImputadoApiConsumer = Detalle_Audiencia_Defensor_ImputadoApiConsumer;

            this._IDetalle_de_ImputadoApiConsumer = Detalle_de_ImputadoApiConsumer;

            this._IDetalle_Audiencia_Defensor_VictimaApiConsumer = Detalle_Audiencia_Defensor_VictimaApiConsumer;

            this._IDetalle_de_ImputadoApiConsumer = Detalle_de_ImputadoApiConsumer;

            this._IResultado_de_AudienciaApiConsumer = Resultado_de_AudienciaApiConsumer;
            this._IDetalle_Audiencia_Archivos_AdjuntosApiConsumer = Detalle_Audiencia_Archivos_AdjuntosApiConsumer;



            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Audiencias_MP
        [ObjectAuth(ObjectId = (ModuleObjectId)45483, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45483, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Audiencias_MP/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45483, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45483, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varAudiencias_MP = new Audiencias_MPModel();
			varAudiencias_MP.Clave = Id;
			
            ViewBag.ObjectId = "45483";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_Audiencia_Defensor_Imputado = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45484, ModuleId);
            ViewBag.PermissionDetalle_Audiencia_Defensor_Imputado = permissionDetalle_Audiencia_Defensor_Imputado;
            var permissionDetalle_Audiencia_Defensor_Victima = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45485, ModuleId);
            ViewBag.PermissionDetalle_Audiencia_Defensor_Victima = permissionDetalle_Audiencia_Defensor_Victima;
            var permissionDetalle_Audiencia_Archivos_Adjuntos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45486, ModuleId);
            ViewBag.PermissionDetalle_Audiencia_Archivos_Adjuntos = permissionDetalle_Audiencia_Archivos_Adjuntos;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IAudiencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Audiencias_MPsData = _IAudiencias_MPApiConsumer.ListaSelAll(0, 1000, "Audiencias_MP.Clave=" + Id, "").Resource.Audiencias_MPs;
				
				if (Audiencias_MPsData != null && Audiencias_MPsData.Count > 0)
                {
					var Audiencias_MPData = Audiencias_MPsData.First();
					varAudiencias_MP= new Audiencias_MPModel
					{
						Clave  = Audiencias_MPData.Clave 
	                    ,Expediente_MP = Audiencias_MPData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Audiencias_MPData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Audiencias_MPData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Tipo_de_Audiencia = Audiencias_MPData.Tipo_de_Audiencia
                    ,Tipo_de_AudienciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencias_MPData.Tipo_de_Audiencia), "Tipo_de_Audiencia") ??  (string)Audiencias_MPData.Tipo_de_Audiencia_Tipo_de_Audiencia.Descripcion
                    ,Audiencia = Audiencias_MPData.Audiencia
                    ,AudienciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencias_MPData.Audiencia), "Audiencia") ??  (string)Audiencias_MPData.Audiencia_Audiencia.Descripcion
                    ,Fecha = (Audiencias_MPData.Fecha == null ? string.Empty : Convert.ToDateTime(Audiencias_MPData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Audiencias_MPData.Hora
                    ,Observaciones = Audiencias_MPData.Observaciones
                    ,Resultado_de_Audiencia = Audiencias_MPData.Resultado_de_Audiencia
                    ,Resultado_de_AudienciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencias_MPData.Resultado_de_Audiencia), "Resultado_de_Audiencia") ??  (string)Audiencias_MPData.Resultado_de_Audiencia_Resultado_de_Audiencia.Descripcion
                    ,Asignar_MP_Litigacion = Audiencias_MPData.Asignar_MP_Litigacion.GetValueOrDefault()
                    ,MP_Litigacion = Audiencias_MPData.MP_Litigacion
                    ,MP_LitigacionName = CultureHelper.GetTraduction(Convert.ToString(Audiencias_MPData.MP_Litigacion), "Spartan_User") ??  (string)Audiencias_MPData.MP_Litigacion_Spartan_User.Name

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_AudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Audiencias_Tipo_de_Audiencia = _ITipo_de_AudienciaApiConsumer.SelAll(true);
            if (Tipo_de_Audiencias_Tipo_de_Audiencia != null && Tipo_de_Audiencias_Tipo_de_Audiencia.Resource != null)
                ViewBag.Tipo_de_Audiencias_Tipo_de_Audiencia = Tipo_de_Audiencias_Tipo_de_Audiencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Audiencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Audiencias_Audiencia = _IAudienciaApiConsumer.SelAll(true);
            if (Audiencias_Audiencia != null && Audiencias_Audiencia.Resource != null)
                ViewBag.Audiencias_Audiencia = Audiencias_Audiencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Audiencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_AudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Audiencias_Resultado_de_Audiencia = _IResultado_de_AudienciaApiConsumer.SelAll(true);
            if (Resultado_de_Audiencias_Resultado_de_Audiencia != null && Resultado_de_Audiencias_Resultado_de_Audiencia.Resource != null)
                ViewBag.Resultado_de_Audiencias_Resultado_de_Audiencia = Resultado_de_Audiencias_Resultado_de_Audiencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Audiencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varAudiencias_MP);
        }
		
	[HttpGet]
        public ActionResult AddAudiencias_MP(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45483);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IAudiencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
			Audiencias_MPModel varAudiencias_MP= new Audiencias_MPModel();
            var permissionDetalle_Audiencia_Defensor_Imputado = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45484, ModuleId);
            ViewBag.PermissionDetalle_Audiencia_Defensor_Imputado = permissionDetalle_Audiencia_Defensor_Imputado;
            var permissionDetalle_Audiencia_Defensor_Victima = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45485, ModuleId);
            ViewBag.PermissionDetalle_Audiencia_Defensor_Victima = permissionDetalle_Audiencia_Defensor_Victima;
            var permissionDetalle_Audiencia_Archivos_Adjuntos = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45486, ModuleId);
            ViewBag.PermissionDetalle_Audiencia_Archivos_Adjuntos = permissionDetalle_Audiencia_Archivos_Adjuntos;


            if (id.ToString() != "0")
            {
                var Audiencias_MPsData = _IAudiencias_MPApiConsumer.ListaSelAll(0, 1000, "Audiencias_MP.Clave=" + id, "").Resource.Audiencias_MPs;
				
				if (Audiencias_MPsData != null && Audiencias_MPsData.Count > 0)
                {
					var Audiencias_MPData = Audiencias_MPsData.First();
					varAudiencias_MP= new Audiencias_MPModel
					{
						Clave  = Audiencias_MPData.Clave 
	                    ,Expediente_MP = Audiencias_MPData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Audiencias_MPData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Audiencias_MPData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Tipo_de_Audiencia = Audiencias_MPData.Tipo_de_Audiencia
                    ,Tipo_de_AudienciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencias_MPData.Tipo_de_Audiencia), "Tipo_de_Audiencia") ??  (string)Audiencias_MPData.Tipo_de_Audiencia_Tipo_de_Audiencia.Descripcion
                    ,Audiencia = Audiencias_MPData.Audiencia
                    ,AudienciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencias_MPData.Audiencia), "Audiencia") ??  (string)Audiencias_MPData.Audiencia_Audiencia.Descripcion
                    ,Fecha = (Audiencias_MPData.Fecha == null ? string.Empty : Convert.ToDateTime(Audiencias_MPData.Fecha).ToString(ConfigurationProperty.DateFormat))
                    ,Hora = Audiencias_MPData.Hora
                    ,Observaciones = Audiencias_MPData.Observaciones
                    ,Resultado_de_Audiencia = Audiencias_MPData.Resultado_de_Audiencia
                    ,Resultado_de_AudienciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencias_MPData.Resultado_de_Audiencia), "Resultado_de_Audiencia") ??  (string)Audiencias_MPData.Resultado_de_Audiencia_Resultado_de_Audiencia.Descripcion
                    ,Asignar_MP_Litigacion = Audiencias_MPData.Asignar_MP_Litigacion.GetValueOrDefault()
                    ,MP_Litigacion = Audiencias_MPData.MP_Litigacion
                    ,MP_LitigacionName = CultureHelper.GetTraduction(Convert.ToString(Audiencias_MPData.MP_Litigacion), "Spartan_User") ??  (string)Audiencias_MPData.MP_Litigacion_Spartan_User.Name

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_AudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Audiencias_Tipo_de_Audiencia = _ITipo_de_AudienciaApiConsumer.SelAll(true);
            if (Tipo_de_Audiencias_Tipo_de_Audiencia != null && Tipo_de_Audiencias_Tipo_de_Audiencia.Resource != null)
                ViewBag.Tipo_de_Audiencias_Tipo_de_Audiencia = Tipo_de_Audiencias_Tipo_de_Audiencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Audiencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Audiencias_Audiencia = _IAudienciaApiConsumer.SelAll(true);
            if (Audiencias_Audiencia != null && Audiencias_Audiencia.Resource != null)
                ViewBag.Audiencias_Audiencia = Audiencias_Audiencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Audiencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_AudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Audiencias_Resultado_de_Audiencia = _IResultado_de_AudienciaApiConsumer.SelAll(true);
            if (Resultado_de_Audiencias_Resultado_de_Audiencia != null && Resultado_de_Audiencias_Resultado_de_Audiencia.Resource != null)
                ViewBag.Resultado_de_Audiencias_Resultado_de_Audiencia = Resultado_de_Audiencias_Resultado_de_Audiencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Audiencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddAudiencias_MP", varAudiencias_MP);
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
        public ActionResult GetTipo_de_AudienciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_AudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_AudienciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Audiencia", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetAudienciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAudienciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Audiencia", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetResultado_de_AudienciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResultado_de_AudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResultado_de_AudienciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Audiencia", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Audiencias_MPAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_AudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Audiencias_Tipo_de_Audiencia = _ITipo_de_AudienciaApiConsumer.SelAll(true);
            if (Tipo_de_Audiencias_Tipo_de_Audiencia != null && Tipo_de_Audiencias_Tipo_de_Audiencia.Resource != null)
                ViewBag.Tipo_de_Audiencias_Tipo_de_Audiencia = Tipo_de_Audiencias_Tipo_de_Audiencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Audiencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Audiencias_Audiencia = _IAudienciaApiConsumer.SelAll(true);
            if (Audiencias_Audiencia != null && Audiencias_Audiencia.Resource != null)
                ViewBag.Audiencias_Audiencia = Audiencias_Audiencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Audiencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_AudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Audiencias_Resultado_de_Audiencia = _IResultado_de_AudienciaApiConsumer.SelAll(true);
            if (Resultado_de_Audiencias_Resultado_de_Audiencia != null && Resultado_de_Audiencias_Resultado_de_Audiencia.Resource != null)
                ViewBag.Resultado_de_Audiencias_Resultado_de_Audiencia = Resultado_de_Audiencias_Resultado_de_Audiencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Audiencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_AudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Audiencias_Tipo_de_Audiencia = _ITipo_de_AudienciaApiConsumer.SelAll(true);
            if (Tipo_de_Audiencias_Tipo_de_Audiencia != null && Tipo_de_Audiencias_Tipo_de_Audiencia.Resource != null)
                ViewBag.Tipo_de_Audiencias_Tipo_de_Audiencia = Tipo_de_Audiencias_Tipo_de_Audiencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Audiencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Audiencias_Audiencia = _IAudienciaApiConsumer.SelAll(true);
            if (Audiencias_Audiencia != null && Audiencias_Audiencia.Resource != null)
                ViewBag.Audiencias_Audiencia = Audiencias_Audiencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Audiencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_AudienciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Audiencias_Resultado_de_Audiencia = _IResultado_de_AudienciaApiConsumer.SelAll(true);
            if (Resultado_de_Audiencias_Resultado_de_Audiencia != null && Resultado_de_Audiencias_Resultado_de_Audiencia.Resource != null)
                ViewBag.Resultado_de_Audiencias_Resultado_de_Audiencia = Resultado_de_Audiencias_Resultado_de_Audiencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Audiencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Audiencias_MPAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Audiencias_MPAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Audiencias_MPAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Audiencias_MPPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IAudiencias_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Audiencias_MPs == null)
                result.Audiencias_MPs = new List<Audiencias_MP>();

            return Json(new
            {
                data = result.Audiencias_MPs.Select(m => new Audiencias_MPGridModel
                    {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Tipo_de_AudienciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Audiencia_Tipo_de_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Audiencia_Tipo_de_Audiencia.Descripcion
                        ,AudienciaDescripcion = CultureHelper.GetTraduction(m.Audiencia_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Audiencia_Audiencia.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Observaciones = m.Observaciones
                        ,Resultado_de_AudienciaDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Audiencia_Resultado_de_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Audiencia_Resultado_de_Audiencia.Descripcion
			,Asignar_MP_Litigacion = m.Asignar_MP_Litigacion
                        ,MP_LitigacionName = CultureHelper.GetTraduction(m.MP_Litigacion_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.MP_Litigacion_Spartan_User.Name

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetAudiencias_MPAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAudiencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAudiencias_MPApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Audiencias_MP", m.),
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
        /// Get List of Audiencias_MP from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Audiencias_MP Entity</returns>
        public ActionResult GetAudiencias_MPList(UrlParametersModel param)
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
            _IAudiencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Audiencias_MPPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Audiencias_MPAdvanceSearchModel))
                {
					var advanceFilter =
                    (Audiencias_MPAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Audiencias_MPPropertyMapper oAudiencias_MPPropertyMapper = new Audiencias_MPPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oAudiencias_MPPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IAudiencias_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Audiencias_MPs == null)
                result.Audiencias_MPs = new List<Audiencias_MP>();

            return Json(new
            {
                aaData = result.Audiencias_MPs.Select(m => new Audiencias_MPGridModel
            {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Tipo_de_AudienciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Audiencia_Tipo_de_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Audiencia_Tipo_de_Audiencia.Descripcion
                        ,AudienciaDescripcion = CultureHelper.GetTraduction(m.Audiencia_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Audiencia_Audiencia.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Observaciones = m.Observaciones
                        ,Resultado_de_AudienciaDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Audiencia_Resultado_de_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Audiencia_Resultado_de_Audiencia.Descripcion
			,Asignar_MP_Litigacion = m.Asignar_MP_Litigacion
                        ,MP_LitigacionName = CultureHelper.GetTraduction(m.MP_Litigacion_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.MP_Litigacion_Spartan_User.Name

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetAudiencias_MP_Expediente_MP_expediente_ministerio_publico(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(expediente_ministerio_publico.clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(expediente_ministerio_publico.nic as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _Iexpediente_ministerio_publicoApiConsumer.ListaSelAll(1, 20,elWhere , " expediente_ministerio_publico.nic ASC ").Resource;
               
                foreach (var item in result.expediente_ministerio_publicos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.clave), "expediente_ministerio_publico", "nic");
                    item.nic =trans ??item.nic;
                }
                return Json(result.expediente_ministerio_publicos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete
        [HttpGet]
        public JsonResult GetDetalle_Audiencia_Defensor_Imputado_Nombre_Del_Imputado_Detalle_de_Imputado(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Imputado.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Imputado.Nombre_Completo_del_Tutor as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_ImputadoApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Imputado.Nombre_Completo_del_Tutor ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Imputados)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Imputado", "Nombre_Completo_del_Tutor");
                    item.Nombre_Completo_del_Tutor =trans ??item.Nombre_Completo_del_Tutor;
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
        public JsonResult GetDetalle_Audiencia_Defensor_Victima_Nombre_del_Imputado_Detalle_de_Imputado(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Imputado.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Imputado.Nombre_Completo_del_Tutor as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_ImputadoApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Imputado.Nombre_Completo_del_Tutor ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Imputados)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Imputado", "Nombre_Completo_del_Tutor");
                    item.Nombre_Completo_del_Tutor =trans ??item.Nombre_Completo_del_Tutor;
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
        public JsonResult GetAudiencias_MP_MP_Litigacion_Spartan_User(string query, string where)
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
        public string GetAdvanceFilter(Audiencias_MPAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Audiencias_MP.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Audiencias_MP.Clave <= " + filter.ToClave;
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

                where += " AND Audiencias_MP.Expediente_MP In (" + Expediente_MPIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Audiencia))
            {
                switch (filter.Tipo_de_AudienciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Audiencia.Descripcion LIKE '" + filter.AdvanceTipo_de_Audiencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Audiencia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Audiencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Audiencia.Descripcion = '" + filter.AdvanceTipo_de_Audiencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Audiencia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Audiencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_AudienciaMultiple != null && filter.AdvanceTipo_de_AudienciaMultiple.Count() > 0)
            {
                var Tipo_de_AudienciaIds = string.Join(",", filter.AdvanceTipo_de_AudienciaMultiple);

                where += " AND Audiencias_MP.Tipo_de_Audiencia In (" + Tipo_de_AudienciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAudiencia))
            {
                switch (filter.AudienciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Audiencia.Descripcion LIKE '" + filter.AdvanceAudiencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Audiencia.Descripcion LIKE '%" + filter.AdvanceAudiencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Audiencia.Descripcion = '" + filter.AdvanceAudiencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Audiencia.Descripcion LIKE '%" + filter.AdvanceAudiencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAudienciaMultiple != null && filter.AdvanceAudienciaMultiple.Count() > 0)
            {
                var AudienciaIds = string.Join(",", filter.AdvanceAudienciaMultiple);

                where += " AND Audiencias_MP.Audiencia In (" + AudienciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha) || !string.IsNullOrEmpty(filter.ToFecha))
            {
                var FechaFrom = DateTime.ParseExact(filter.FromFecha, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var FechaTo = DateTime.ParseExact(filter.ToFecha, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha))
                    where += " AND Audiencias_MP.Fecha >= '" + FechaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha))
                    where += " AND Audiencias_MP.Fecha <= '" + FechaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora) || !string.IsNullOrEmpty(filter.ToHora))
            {
                if (!string.IsNullOrEmpty(filter.FromHora))
                    where += " AND Convert(TIME,Audiencias_MP.Hora) >='" + filter.FromHora + "'";
                if (!string.IsNullOrEmpty(filter.ToHora))
                    where += " AND Convert(TIME,Audiencias_MP.Hora) <='" + filter.ToHora + "'";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Audiencias_MP.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Audiencias_MP.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Audiencias_MP.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Audiencias_MP.Observaciones LIKE '%" + filter.Observaciones + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResultado_de_Audiencia))
            {
                switch (filter.Resultado_de_AudienciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resultado_de_Audiencia.Descripcion LIKE '" + filter.AdvanceResultado_de_Audiencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resultado_de_Audiencia.Descripcion LIKE '%" + filter.AdvanceResultado_de_Audiencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resultado_de_Audiencia.Descripcion = '" + filter.AdvanceResultado_de_Audiencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resultado_de_Audiencia.Descripcion LIKE '%" + filter.AdvanceResultado_de_Audiencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResultado_de_AudienciaMultiple != null && filter.AdvanceResultado_de_AudienciaMultiple.Count() > 0)
            {
                var Resultado_de_AudienciaIds = string.Join(",", filter.AdvanceResultado_de_AudienciaMultiple);

                where += " AND Audiencias_MP.Resultado_de_Audiencia In (" + Resultado_de_AudienciaIds + ")";
            }

            if (filter.Asignar_MP_Litigacion != RadioOptions.NoApply)
                where += " AND Audiencias_MP.Asignar_MP_Litigacion = " + Convert.ToInt32(filter.Asignar_MP_Litigacion);

            if (!string.IsNullOrEmpty(filter.AdvanceMP_Litigacion))
            {
                switch (filter.MP_LitigacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceMP_Litigacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceMP_Litigacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceMP_Litigacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceMP_Litigacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMP_LitigacionMultiple != null && filter.AdvanceMP_LitigacionMultiple.Count() > 0)
            {
                var MP_LitigacionIds = string.Join(",", filter.AdvanceMP_LitigacionMultiple);

                where += " AND Audiencias_MP.MP_Litigacion In (" + MP_LitigacionIds + ")";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_Audiencia_Defensor_Imputado(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Audiencia_Defensor_ImputadoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Audiencia_Defensor_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Audiencia_Defensor_Imputado.Audiencia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Audiencia_Defensor_Imputado.Audiencia='" + RelationId + "'";
            }
            var result = _IDetalle_Audiencia_Defensor_ImputadoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Audiencia_Defensor_Imputados == null)
                result.Detalle_Audiencia_Defensor_Imputados = new List<Detalle_Audiencia_Defensor_Imputado>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Audiencia_Defensor_Imputados.Select(m => new Detalle_Audiencia_Defensor_ImputadoGridModel
                {
                    Clave = m.Clave

                        ,Nombre_Del_Imputado = m.Nombre_Del_Imputado
                        ,Nombre_Del_ImputadoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(m.Nombre_Del_Imputado_Detalle_de_Imputado.Clave.ToString(), "Nombre_Completo_del_Tutor") ??(string)m.Nombre_Del_Imputado_Detalle_de_Imputado.Nombre_Completo_del_Tutor
			,Abogado = m.Abogado
			,Cedula_Profesional = m.Cedula_Profesional

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Audiencia_Defensor_ImputadoGridModel> GetDetalle_Audiencia_Defensor_ImputadoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Audiencia_Defensor_ImputadoGridModel> resultData = new List<Detalle_Audiencia_Defensor_ImputadoGridModel>();
            string where = "Detalle_Audiencia_Defensor_Imputado.Audiencia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Audiencia_Defensor_Imputado.Audiencia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Audiencia_Defensor_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Audiencia_Defensor_ImputadoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Audiencia_Defensor_Imputados != null)
            {
                resultData = result.Detalle_Audiencia_Defensor_Imputados.Select(m => new Detalle_Audiencia_Defensor_ImputadoGridModel
                    {
                        Clave = m.Clave

                        ,Nombre_Del_Imputado = m.Nombre_Del_Imputado
                        ,Nombre_Del_ImputadoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(m.Nombre_Del_Imputado_Detalle_de_Imputado.Clave.ToString(), "Nombre_Completo_del_Tutor") ??(string)m.Nombre_Del_Imputado_Detalle_de_Imputado.Nombre_Completo_del_Tutor
			,Abogado = m.Abogado
			,Cedula_Profesional = m.Cedula_Profesional


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Audiencia_Defensor_Victima(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Audiencia_Defensor_VictimaGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Audiencia_Defensor_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Audiencia_Defensor_Victima.Audiencia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Audiencia_Defensor_Victima.Audiencia='" + RelationId + "'";
            }
            var result = _IDetalle_Audiencia_Defensor_VictimaApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Audiencia_Defensor_Victimas == null)
                result.Detalle_Audiencia_Defensor_Victimas = new List<Detalle_Audiencia_Defensor_Victima>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Audiencia_Defensor_Victimas.Select(m => new Detalle_Audiencia_Defensor_VictimaGridModel
                {
                    Clave = m.Clave

                        ,Nombre_del_Imputado = m.Nombre_del_Imputado
                        ,Nombre_del_ImputadoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(m.Nombre_del_Imputado_Detalle_de_Imputado.Clave.ToString(), "Nombre_Completo_del_Tutor") ??(string)m.Nombre_del_Imputado_Detalle_de_Imputado.Nombre_Completo_del_Tutor
			,Abogado = m.Abogado
			,Cedula_Profesional = m.Cedula_Profesional

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Audiencia_Defensor_VictimaGridModel> GetDetalle_Audiencia_Defensor_VictimaData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Audiencia_Defensor_VictimaGridModel> resultData = new List<Detalle_Audiencia_Defensor_VictimaGridModel>();
            string where = "Detalle_Audiencia_Defensor_Victima.Audiencia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Audiencia_Defensor_Victima.Audiencia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Audiencia_Defensor_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Audiencia_Defensor_VictimaApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Audiencia_Defensor_Victimas != null)
            {
                resultData = result.Detalle_Audiencia_Defensor_Victimas.Select(m => new Detalle_Audiencia_Defensor_VictimaGridModel
                    {
                        Clave = m.Clave

                        ,Nombre_del_Imputado = m.Nombre_del_Imputado
                        ,Nombre_del_ImputadoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(m.Nombre_del_Imputado_Detalle_de_Imputado.Clave.ToString(), "Nombre_Completo_del_Tutor") ??(string)m.Nombre_del_Imputado_Detalle_de_Imputado.Nombre_Completo_del_Tutor
			,Abogado = m.Abogado
			,Cedula_Profesional = m.Cedula_Profesional


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_Audiencia_Archivos_Adjuntos(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Audiencia_Archivos_AdjuntosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Audiencia_Archivos_Adjuntos.Audiencia=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Audiencia_Archivos_Adjuntos.Audiencia='" + RelationId + "'";
            }
            var result = _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Audiencia_Archivos_Adjuntoss == null)
                result.Detalle_Audiencia_Archivos_Adjuntoss = new List<Detalle_Audiencia_Archivos_Adjuntos>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Audiencia_Archivos_Adjuntoss.Select(m => new Detalle_Audiencia_Archivos_AdjuntosGridModel
                {
                    Clave = m.Clave

			,Nombre_Archivo = m.Nombre_Archivo
			,Archivo_AdjuntoFileInfo = m.Archivo_Adjunto > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Archivo_Adjunto).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Audiencia_Archivos_AdjuntosGridModel> GetDetalle_Audiencia_Archivos_AdjuntosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Audiencia_Archivos_AdjuntosGridModel> resultData = new List<Detalle_Audiencia_Archivos_AdjuntosGridModel>();
            string where = "Detalle_Audiencia_Archivos_Adjuntos.Audiencia=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Audiencia_Archivos_Adjuntos.Audiencia='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Audiencia_Archivos_Adjuntoss != null)
            {
                resultData = result.Detalle_Audiencia_Archivos_Adjuntoss.Select(m => new Detalle_Audiencia_Archivos_AdjuntosGridModel
                    {
                        Clave = m.Clave

			,Nombre_Archivo = m.Nombre_Archivo
			,Archivo_AdjuntoFileInfo = m.Archivo_Adjunto > 0 ? (ConvertSpartane_FileToGridFile(_ISpartane_FileApiConsumer.GetByKey(m.Archivo_Adjunto).Resource)) : new Grid_File { FileId = 0, FileSize = 0, FileName = "" }


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
                _IAudiencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

                Audiencias_MP varAudiencias_MP = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_Audiencia_Defensor_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Audiencia_Defensor_Imputado.Audiencia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Audiencia_Defensor_Imputado.Audiencia='" + id + "'";
                    }
                    var Detalle_Audiencia_Defensor_ImputadoInfo =
                        _IDetalle_Audiencia_Defensor_ImputadoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Audiencia_Defensor_ImputadoInfo.Detalle_Audiencia_Defensor_Imputados.Count > 0)
                    {
                        var resultDetalle_Audiencia_Defensor_Imputado = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Audiencia_Defensor_ImputadoItem in Detalle_Audiencia_Defensor_ImputadoInfo.Detalle_Audiencia_Defensor_Imputados)
                            resultDetalle_Audiencia_Defensor_Imputado = resultDetalle_Audiencia_Defensor_Imputado
                                              && _IDetalle_Audiencia_Defensor_ImputadoApiConsumer.Delete(Detalle_Audiencia_Defensor_ImputadoItem.Clave, null,null).Resource;

                        if (!resultDetalle_Audiencia_Defensor_Imputado)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Audiencia_Defensor_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Audiencia_Defensor_Victima.Audiencia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Audiencia_Defensor_Victima.Audiencia='" + id + "'";
                    }
                    var Detalle_Audiencia_Defensor_VictimaInfo =
                        _IDetalle_Audiencia_Defensor_VictimaApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Audiencia_Defensor_VictimaInfo.Detalle_Audiencia_Defensor_Victimas.Count > 0)
                    {
                        var resultDetalle_Audiencia_Defensor_Victima = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Audiencia_Defensor_VictimaItem in Detalle_Audiencia_Defensor_VictimaInfo.Detalle_Audiencia_Defensor_Victimas)
                            resultDetalle_Audiencia_Defensor_Victima = resultDetalle_Audiencia_Defensor_Victima
                                              && _IDetalle_Audiencia_Defensor_VictimaApiConsumer.Delete(Detalle_Audiencia_Defensor_VictimaItem.Clave, null,null).Resource;

                        if (!resultDetalle_Audiencia_Defensor_Victima)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Audiencia_Archivos_Adjuntos.Audiencia=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Audiencia_Archivos_Adjuntos.Audiencia='" + id + "'";
                    }
                    var Detalle_Audiencia_Archivos_AdjuntosInfo =
                        _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Audiencia_Archivos_AdjuntosInfo.Detalle_Audiencia_Archivos_Adjuntoss.Count > 0)
                    {
                        var resultDetalle_Audiencia_Archivos_Adjuntos = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Audiencia_Archivos_AdjuntosItem in Detalle_Audiencia_Archivos_AdjuntosInfo.Detalle_Audiencia_Archivos_Adjuntoss)
                            resultDetalle_Audiencia_Archivos_Adjuntos = resultDetalle_Audiencia_Archivos_Adjuntos
                                              && _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.Delete(Detalle_Audiencia_Archivos_AdjuntosItem.Clave, null,null).Resource;

                        if (!resultDetalle_Audiencia_Archivos_Adjuntos)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IAudiencias_MPApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Audiencias_MPModel varAudiencias_MP)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IAudiencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Audiencias_MPInfo = new Audiencias_MP
                    {
                        Clave = varAudiencias_MP.Clave
                        ,Expediente_MP = varAudiencias_MP.Expediente_MP
                        ,Tipo_de_Audiencia = varAudiencias_MP.Tipo_de_Audiencia
                        ,Audiencia = varAudiencias_MP.Audiencia
                        ,Fecha = (!String.IsNullOrEmpty(varAudiencias_MP.Fecha)) ? DateTime.ParseExact(varAudiencias_MP.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varAudiencias_MP.Hora
                        ,Observaciones = varAudiencias_MP.Observaciones
                        ,Resultado_de_Audiencia = varAudiencias_MP.Resultado_de_Audiencia
                        ,Asignar_MP_Litigacion = varAudiencias_MP.Asignar_MP_Litigacion
                        ,MP_Litigacion = varAudiencias_MP.MP_Litigacion

                    };

                    result = !IsNew ?
                        _IAudiencias_MPApiConsumer.Update(Audiencias_MPInfo, null, null).Resource.ToString() :
                         _IAudiencias_MPApiConsumer.Insert(Audiencias_MPInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Audiencia_Defensor_Imputado(int MasterId, int referenceId, List<Detalle_Audiencia_Defensor_ImputadoGridModelPost> Detalle_Audiencia_Defensor_ImputadoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Audiencia_Defensor_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Audiencia_Defensor_ImputadoData = _IDetalle_Audiencia_Defensor_ImputadoApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Audiencia_Defensor_Imputado.Audiencia=" + referenceId,"").Resource;
                if (Detalle_Audiencia_Defensor_ImputadoData == null || Detalle_Audiencia_Defensor_ImputadoData.Detalle_Audiencia_Defensor_Imputados.Count == 0)
                    return true;

                var result = true;

                Detalle_Audiencia_Defensor_ImputadoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Audiencia_Defensor_Imputado in Detalle_Audiencia_Defensor_ImputadoData.Detalle_Audiencia_Defensor_Imputados)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Audiencia_Defensor_Imputado Detalle_Audiencia_Defensor_Imputado1 = varDetalle_Audiencia_Defensor_Imputado;

                    if (Detalle_Audiencia_Defensor_ImputadoItems != null && Detalle_Audiencia_Defensor_ImputadoItems.Any(m => m.Clave == Detalle_Audiencia_Defensor_Imputado1.Clave))
                    {
                        modelDataToChange = Detalle_Audiencia_Defensor_ImputadoItems.FirstOrDefault(m => m.Clave == Detalle_Audiencia_Defensor_Imputado1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Audiencia_Defensor_Imputado.Audiencia = MasterId;
                    var insertId = _IDetalle_Audiencia_Defensor_ImputadoApiConsumer.Insert(varDetalle_Audiencia_Defensor_Imputado,null,null).Resource;
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
        public ActionResult PostDetalle_Audiencia_Defensor_Imputado(List<Detalle_Audiencia_Defensor_ImputadoGridModelPost> Detalle_Audiencia_Defensor_ImputadoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Audiencia_Defensor_Imputado(MasterId, referenceId, Detalle_Audiencia_Defensor_ImputadoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Audiencia_Defensor_ImputadoItems != null && Detalle_Audiencia_Defensor_ImputadoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Audiencia_Defensor_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Audiencia_Defensor_ImputadoItem in Detalle_Audiencia_Defensor_ImputadoItems)
                    {





                        //Removal Request
                        if (Detalle_Audiencia_Defensor_ImputadoItem.Removed)
                        {
                            result = result && _IDetalle_Audiencia_Defensor_ImputadoApiConsumer.Delete(Detalle_Audiencia_Defensor_ImputadoItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Audiencia_Defensor_ImputadoItem.Clave = 0;

                        var Detalle_Audiencia_Defensor_ImputadoData = new Detalle_Audiencia_Defensor_Imputado
                        {
                            Audiencia = MasterId
                            ,Clave = Detalle_Audiencia_Defensor_ImputadoItem.Clave
                            ,Nombre_Del_Imputado = (Convert.ToInt32(Detalle_Audiencia_Defensor_ImputadoItem.Nombre_Del_Imputado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Audiencia_Defensor_ImputadoItem.Nombre_Del_Imputado))
                            ,Abogado = Detalle_Audiencia_Defensor_ImputadoItem.Abogado
                            ,Cedula_Profesional = Detalle_Audiencia_Defensor_ImputadoItem.Cedula_Profesional

                        };

                        var resultId = Detalle_Audiencia_Defensor_ImputadoItem.Clave > 0
                           ? _IDetalle_Audiencia_Defensor_ImputadoApiConsumer.Update(Detalle_Audiencia_Defensor_ImputadoData,null,null).Resource
                           : _IDetalle_Audiencia_Defensor_ImputadoApiConsumer.Insert(Detalle_Audiencia_Defensor_ImputadoData,null,null).Resource;

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
        public ActionResult GetDetalle_Audiencia_Defensor_Imputado_Detalle_de_ImputadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_ImputadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre_Completo_del_Tutor= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Imputado", "Nombre_Completo_del_Tutor");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        [NonAction]
        public bool CopyDetalle_Audiencia_Defensor_Victima(int MasterId, int referenceId, List<Detalle_Audiencia_Defensor_VictimaGridModelPost> Detalle_Audiencia_Defensor_VictimaItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Audiencia_Defensor_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Audiencia_Defensor_VictimaData = _IDetalle_Audiencia_Defensor_VictimaApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Audiencia_Defensor_Victima.Audiencia=" + referenceId,"").Resource;
                if (Detalle_Audiencia_Defensor_VictimaData == null || Detalle_Audiencia_Defensor_VictimaData.Detalle_Audiencia_Defensor_Victimas.Count == 0)
                    return true;

                var result = true;

                Detalle_Audiencia_Defensor_VictimaGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Audiencia_Defensor_Victima in Detalle_Audiencia_Defensor_VictimaData.Detalle_Audiencia_Defensor_Victimas)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Audiencia_Defensor_Victima Detalle_Audiencia_Defensor_Victima1 = varDetalle_Audiencia_Defensor_Victima;

                    if (Detalle_Audiencia_Defensor_VictimaItems != null && Detalle_Audiencia_Defensor_VictimaItems.Any(m => m.Clave == Detalle_Audiencia_Defensor_Victima1.Clave))
                    {
                        modelDataToChange = Detalle_Audiencia_Defensor_VictimaItems.FirstOrDefault(m => m.Clave == Detalle_Audiencia_Defensor_Victima1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Audiencia_Defensor_Victima.Audiencia = MasterId;
                    var insertId = _IDetalle_Audiencia_Defensor_VictimaApiConsumer.Insert(varDetalle_Audiencia_Defensor_Victima,null,null).Resource;
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
        public ActionResult PostDetalle_Audiencia_Defensor_Victima(List<Detalle_Audiencia_Defensor_VictimaGridModelPost> Detalle_Audiencia_Defensor_VictimaItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Audiencia_Defensor_Victima(MasterId, referenceId, Detalle_Audiencia_Defensor_VictimaItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Audiencia_Defensor_VictimaItems != null && Detalle_Audiencia_Defensor_VictimaItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Audiencia_Defensor_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Audiencia_Defensor_VictimaItem in Detalle_Audiencia_Defensor_VictimaItems)
                    {





                        //Removal Request
                        if (Detalle_Audiencia_Defensor_VictimaItem.Removed)
                        {
                            result = result && _IDetalle_Audiencia_Defensor_VictimaApiConsumer.Delete(Detalle_Audiencia_Defensor_VictimaItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Audiencia_Defensor_VictimaItem.Clave = 0;

                        var Detalle_Audiencia_Defensor_VictimaData = new Detalle_Audiencia_Defensor_Victima
                        {
                            Audiencia = MasterId
                            ,Clave = Detalle_Audiencia_Defensor_VictimaItem.Clave
                            ,Nombre_del_Imputado = (Convert.ToInt32(Detalle_Audiencia_Defensor_VictimaItem.Nombre_del_Imputado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Audiencia_Defensor_VictimaItem.Nombre_del_Imputado))
                            ,Abogado = Detalle_Audiencia_Defensor_VictimaItem.Abogado
                            ,Cedula_Profesional = Detalle_Audiencia_Defensor_VictimaItem.Cedula_Profesional

                        };

                        var resultId = Detalle_Audiencia_Defensor_VictimaItem.Clave > 0
                           ? _IDetalle_Audiencia_Defensor_VictimaApiConsumer.Update(Detalle_Audiencia_Defensor_VictimaData,null,null).Resource
                           : _IDetalle_Audiencia_Defensor_VictimaApiConsumer.Insert(Detalle_Audiencia_Defensor_VictimaData,null,null).Resource;

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
        public ActionResult GetDetalle_Audiencia_Defensor_Victima_Detalle_de_ImputadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_ImputadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre_Completo_del_Tutor= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Imputado", "Nombre_Completo_del_Tutor");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        [NonAction]
        public bool CopyDetalle_Audiencia_Archivos_Adjuntos(int MasterId, int referenceId, List<Detalle_Audiencia_Archivos_AdjuntosGridModelPost> Detalle_Audiencia_Archivos_AdjuntosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Audiencia_Archivos_AdjuntosData = _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Audiencia_Archivos_Adjuntos.Audiencia=" + referenceId,"").Resource;
                if (Detalle_Audiencia_Archivos_AdjuntosData == null || Detalle_Audiencia_Archivos_AdjuntosData.Detalle_Audiencia_Archivos_Adjuntoss.Count == 0)
                    return true;

                var result = true;

                Detalle_Audiencia_Archivos_AdjuntosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Audiencia_Archivos_Adjuntos in Detalle_Audiencia_Archivos_AdjuntosData.Detalle_Audiencia_Archivos_Adjuntoss)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Audiencia_Archivos_Adjuntos Detalle_Audiencia_Archivos_Adjuntos1 = varDetalle_Audiencia_Archivos_Adjuntos;

                    if (Detalle_Audiencia_Archivos_AdjuntosItems != null && Detalle_Audiencia_Archivos_AdjuntosItems.Any(m => m.Clave == Detalle_Audiencia_Archivos_Adjuntos1.Clave))
                    {
                        modelDataToChange = Detalle_Audiencia_Archivos_AdjuntosItems.FirstOrDefault(m => m.Clave == Detalle_Audiencia_Archivos_Adjuntos1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Audiencia_Archivos_Adjuntos.Audiencia = MasterId;
                    var insertId = _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.Insert(varDetalle_Audiencia_Archivos_Adjuntos,null,null).Resource;
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
        public ActionResult PostDetalle_Audiencia_Archivos_Adjuntos(List<Detalle_Audiencia_Archivos_AdjuntosGridModelPost> Detalle_Audiencia_Archivos_AdjuntosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Audiencia_Archivos_Adjuntos(MasterId, referenceId, Detalle_Audiencia_Archivos_AdjuntosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Audiencia_Archivos_AdjuntosItems != null && Detalle_Audiencia_Archivos_AdjuntosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Audiencia_Archivos_AdjuntosItem in Detalle_Audiencia_Archivos_AdjuntosItems)
                    {


                        #region Archivo_AdjuntoInfo
                        //Checking if file exist if yes edit or add
                        if (Detalle_Audiencia_Archivos_AdjuntosItem.Archivo_AdjuntoInfo.Control != null && !Detalle_Audiencia_Archivos_AdjuntosItem.Removed)
                        {
                            var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(Detalle_Audiencia_Archivos_AdjuntosItem.Archivo_AdjuntoInfo.Control);
                            Detalle_Audiencia_Archivos_AdjuntosItem.Archivo_AdjuntoInfo.FileId = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                            {
                                File = fileAsBytes,
                                Description = Detalle_Audiencia_Archivos_AdjuntosItem.Archivo_AdjuntoInfo.Control.FileName,
                                File_Size = fileAsBytes.Length
                            }).Resource;
                        }
                        else if (!Detalle_Audiencia_Archivos_AdjuntosItem.Removed && Detalle_Audiencia_Archivos_AdjuntosItem.Archivo_AdjuntoInfo.RemoveFile)
                        {
                            Detalle_Audiencia_Archivos_AdjuntosItem.Archivo_AdjuntoInfo.FileId = 0;
                        }
                        #endregion Archivo_AdjuntoInfo

                        //Removal Request
                        if (Detalle_Audiencia_Archivos_AdjuntosItem.Removed)
                        {
                            result = result && _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.Delete(Detalle_Audiencia_Archivos_AdjuntosItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Audiencia_Archivos_AdjuntosItem.Clave = 0;

                        var Detalle_Audiencia_Archivos_AdjuntosData = new Detalle_Audiencia_Archivos_Adjuntos
                        {
                            Audiencia = MasterId
                            ,Clave = Detalle_Audiencia_Archivos_AdjuntosItem.Clave
                            ,Nombre_Archivo = Detalle_Audiencia_Archivos_AdjuntosItem.Nombre_Archivo
                            ,Archivo_Adjunto = Detalle_Audiencia_Archivos_AdjuntosItem.Archivo_AdjuntoInfo.FileId

                        };

                        var resultId = Detalle_Audiencia_Archivos_AdjuntosItem.Clave > 0
                           ? _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.Update(Detalle_Audiencia_Archivos_AdjuntosData,null,null).Resource
                           : _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.Insert(Detalle_Audiencia_Archivos_AdjuntosData,null,null).Resource;

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
        /// Write Element Array of Audiencias_MP script
        /// </summary>
        /// <param name="oAudiencias_MPElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Audiencias_MPModuleAttributeList)
        {
            for (int i = 0; i < Audiencias_MPModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Audiencias_MPModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Audiencias_MPModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Audiencias_MPModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Audiencias_MPModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Audiencias_MPModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Audiencias_MPModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Audiencias_MPModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Audiencias_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Audiencias_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Audiencias_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Audiencias_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strAudiencias_MPScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Audiencias_MP.js")))
            {
                strAudiencias_MPScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Audiencias_MP element attributes
            string userChangeJson = jsSerialize.Serialize(Audiencias_MPModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strAudiencias_MPScript.IndexOf("inpuElementArray");
            string splittedString = strAudiencias_MPScript.Substring(indexOfArray, strAudiencias_MPScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Audiencias_MPModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Audiencias_MPModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strAudiencias_MPScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strAudiencias_MPScript.Substring(indexOfArrayHistory, strAudiencias_MPScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strAudiencias_MPScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strAudiencias_MPScript.Substring(endIndexOfMainElement + indexOfArray, strAudiencias_MPScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Audiencias_MPModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Audiencias_MPModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Audiencias_MP.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Audiencias_MP.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Audiencias_MP.js")))
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
        public ActionResult Audiencias_MPPropertyBag()
        {
            return PartialView("Audiencias_MPPropertyBag", "Audiencias_MP");
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
        public ActionResult AddDetalle_Audiencia_Defensor_Imputado(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Audiencia_Defensor_Imputado/AddDetalle_Audiencia_Defensor_Imputado");
        }

        [HttpGet]
        public ActionResult AddDetalle_Audiencia_Defensor_Victima(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Audiencia_Defensor_Victima/AddDetalle_Audiencia_Defensor_Victima");
        }

        [HttpGet]
        public ActionResult AddDetalle_Audiencia_Archivos_Adjuntos(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Audiencia_Archivos_Adjuntos/AddDetalle_Audiencia_Archivos_Adjuntos");
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
                var whereClauseFormat = "Object = 45483 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IAudiencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Audiencias_MP.Clave= " + RecordId;
                            var result = _IAudiencias_MPApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IAudiencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Audiencias_MPPropertyMapper());
			
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
                    (Audiencias_MPAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Audiencias_MPPropertyMapper oAudiencias_MPPropertyMapper = new Audiencias_MPPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oAudiencias_MPPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IAudiencias_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Audiencias_MPs == null)
                result.Audiencias_MPs = new List<Audiencias_MP>();

            var data = result.Audiencias_MPs.Select(m => new Audiencias_MPGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Tipo_de_AudienciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Audiencia_Tipo_de_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Audiencia_Tipo_de_Audiencia.Descripcion
                        ,AudienciaDescripcion = CultureHelper.GetTraduction(m.Audiencia_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Audiencia_Audiencia.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Observaciones = m.Observaciones
                        ,Resultado_de_AudienciaDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Audiencia_Resultado_de_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Audiencia_Resultado_de_Audiencia.Descripcion
			,Asignar_MP_Litigacion = m.Asignar_MP_Litigacion
                        ,MP_LitigacionName = CultureHelper.GetTraduction(m.MP_Litigacion_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.MP_Litigacion_Spartan_User.Name

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45483, arrayColumnsVisible), "Audiencias_MPList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45483, arrayColumnsVisible), "Audiencias_MPList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45483, arrayColumnsVisible), "Audiencias_MPList_" + DateTime.Now.ToString());
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

            _IAudiencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Audiencias_MPPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Audiencias_MPAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Audiencias_MPPropertyMapper oAudiencias_MPPropertyMapper = new Audiencias_MPPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oAudiencias_MPPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IAudiencias_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Audiencias_MPs == null)
                result.Audiencias_MPs = new List<Audiencias_MP>();

            var data = result.Audiencias_MPs.Select(m => new Audiencias_MPGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Tipo_de_AudienciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Audiencia_Tipo_de_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Audiencia_Tipo_de_Audiencia.Descripcion
                        ,AudienciaDescripcion = CultureHelper.GetTraduction(m.Audiencia_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Audiencia_Audiencia.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Observaciones = m.Observaciones
                        ,Resultado_de_AudienciaDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Audiencia_Resultado_de_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Audiencia_Resultado_de_Audiencia.Descripcion
			,Asignar_MP_Litigacion = m.Asignar_MP_Litigacion
                        ,MP_LitigacionName = CultureHelper.GetTraduction(m.MP_Litigacion_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.MP_Litigacion_Spartan_User.Name

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
                _IAudiencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAudiencias_MPApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Audiencias_MP_Datos_GeneralesModel varAudiencias_MP)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAudiencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Audiencias_MP_Datos_GeneralesInfo = new Audiencias_MP_Datos_Generales
                {
                    Clave = varAudiencias_MP.Clave
                                            ,Expediente_MP = varAudiencias_MP.Expediente_MP
                        ,Tipo_de_Audiencia = varAudiencias_MP.Tipo_de_Audiencia
                        ,Audiencia = varAudiencias_MP.Audiencia
                        ,Fecha = (!String.IsNullOrEmpty(varAudiencias_MP.Fecha)) ? DateTime.ParseExact(varAudiencias_MP.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora = varAudiencias_MP.Hora
                        ,Observaciones = varAudiencias_MP.Observaciones
                        ,Resultado_de_Audiencia = varAudiencias_MP.Resultado_de_Audiencia
                        ,Asignar_MP_Litigacion = varAudiencias_MP.Asignar_MP_Litigacion
                        ,MP_Litigacion = varAudiencias_MP.MP_Litigacion
                    
                };

                result = _IAudiencias_MPApiConsumer.Update_Datos_Generales(Audiencias_MP_Datos_GeneralesInfo).Resource.ToString();
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
                _IAudiencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IAudiencias_MPApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Audiencia_Defensor_Imputado;
                var Detalle_Audiencia_Defensor_ImputadoData = GetDetalle_Audiencia_Defensor_ImputadoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Audiencia_Defensor_Imputado);
                int RowCount_Detalle_Audiencia_Defensor_Victima;
                var Detalle_Audiencia_Defensor_VictimaData = GetDetalle_Audiencia_Defensor_VictimaData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Audiencia_Defensor_Victima);
                int RowCount_Detalle_Audiencia_Archivos_Adjuntos;
                var Detalle_Audiencia_Archivos_AdjuntosData = GetDetalle_Audiencia_Archivos_AdjuntosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Audiencia_Archivos_Adjuntos);

                var result = new Audiencias_MP_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Expediente_MP = m.Expediente_MP
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Tipo_de_Audiencia = m.Tipo_de_Audiencia
                        ,Tipo_de_AudienciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Audiencia_Tipo_de_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Audiencia_Tipo_de_Audiencia.Descripcion
                        ,Audiencia = m.Audiencia
                        ,AudienciaDescripcion = CultureHelper.GetTraduction(m.Audiencia_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Audiencia_Audiencia.Descripcion
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))
			,Hora = m.Hora
			,Observaciones = m.Observaciones
                        ,Resultado_de_Audiencia = m.Resultado_de_Audiencia
                        ,Resultado_de_AudienciaDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Audiencia_Resultado_de_Audiencia.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Audiencia_Resultado_de_Audiencia.Descripcion
			,Asignar_MP_Litigacion = m.Asignar_MP_Litigacion
                        ,MP_Litigacion = m.MP_Litigacion
                        ,MP_LitigacionName = CultureHelper.GetTraduction(m.MP_Litigacion_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.MP_Litigacion_Spartan_User.Name

                    
                };
				var resultData = new
                {
                    data = result
                    ,Defensor_del_Imputado = Detalle_Audiencia_Defensor_ImputadoData
                    ,Defensor_por_Victima = Detalle_Audiencia_Defensor_VictimaData
                    ,Archivos = Detalle_Audiencia_Archivos_AdjuntosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

