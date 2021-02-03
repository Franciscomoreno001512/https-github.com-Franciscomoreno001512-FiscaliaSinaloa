using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Indicios;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Expediente_Inicial;
using Spartane.Core.Domain.Delegacion;
using Spartane.Core.Domain.Agencia;
using Spartane.Core.Domain.Detalle_del_Indicio;





using Spartane.Core.Domain.Estatus_de_Indicio;


using Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio;





using Spartane.Core.Domain.Indicios_para_MPI;


using Spartane.Core.Domain.Servicios_Periciales;

using Spartane.Core.Domain.Detalle_de_Devolucion_de_Indicios;




using Spartane.Core.Domain.Indicios_para_MPI;


using Spartane.Core.Domain.Servicios_Periciales;


using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Indicios;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Indicios;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Expediente_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Delegacion;
using Spartane.Web.Areas.WebApiConsumer.Agencia;
using Spartane.Web.Areas.WebApiConsumer.Detalle_del_Indicio;

using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Indicio;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_de_Indicio;



using Spartane.Web.Areas.WebApiConsumer.Indicios_para_MPI;
using Spartane.Web.Areas.WebApiConsumer.Servicios_Periciales;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Devolucion_de_Indicios;



using Spartane.Web.Areas.WebApiConsumer.Indicios_para_MPI;
using Spartane.Web.Areas.WebApiConsumer.Servicios_Periciales;


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
    public class IndiciosController : Controller
    {
        #region "variable declaration"

        private IIndiciosService service = null;
        private IIndiciosApiConsumer _IIndiciosApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IExpediente_InicialApiConsumer _IExpediente_InicialApiConsumer;
        private IDelegacionApiConsumer _IDelegacionApiConsumer;
        private IAgenciaApiConsumer _IAgenciaApiConsumer;
        private IDetalle_del_IndicioApiConsumer _IDetalle_del_IndicioApiConsumer;

        private IEstatus_de_IndicioApiConsumer _IEstatus_de_IndicioApiConsumer;

        private IDetalle_de_Solicitud_de_IndicioApiConsumer _IDetalle_de_Solicitud_de_IndicioApiConsumer;



        private IIndicios_para_MPIApiConsumer _IIndicios_para_MPIApiConsumer;
        private IServicios_PericialesApiConsumer _IServicios_PericialesApiConsumer;

        private IDetalle_de_Devolucion_de_IndiciosApiConsumer _IDetalle_de_Devolucion_de_IndiciosApiConsumer;





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

        
        public IndiciosController(IIndiciosService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IIndiciosApiConsumer IndiciosApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IExpediente_InicialApiConsumer Expediente_InicialApiConsumer , IDelegacionApiConsumer DelegacionApiConsumer , IAgenciaApiConsumer AgenciaApiConsumer , IDetalle_del_IndicioApiConsumer Detalle_del_IndicioApiConsumer , IEstatus_de_IndicioApiConsumer Estatus_de_IndicioApiConsumer  , IDetalle_de_Solicitud_de_IndicioApiConsumer Detalle_de_Solicitud_de_IndicioApiConsumer , IIndicios_para_MPIApiConsumer Indicios_para_MPIApiConsumer , IServicios_PericialesApiConsumer Servicios_PericialesApiConsumer  , IDetalle_de_Devolucion_de_IndiciosApiConsumer Detalle_de_Devolucion_de_IndiciosApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IIndiciosApiConsumer = IndiciosApiConsumer;
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
            this._IExpediente_InicialApiConsumer = Expediente_InicialApiConsumer;
            this._IDelegacionApiConsumer = DelegacionApiConsumer;
            this._IAgenciaApiConsumer = AgenciaApiConsumer;
            this._IDetalle_del_IndicioApiConsumer = Detalle_del_IndicioApiConsumer;

            this._IEstatus_de_IndicioApiConsumer = Estatus_de_IndicioApiConsumer;

            this._IDetalle_de_Solicitud_de_IndicioApiConsumer = Detalle_de_Solicitud_de_IndicioApiConsumer;



            this._IIndicios_para_MPIApiConsumer = Indicios_para_MPIApiConsumer;
            this._IServicios_PericialesApiConsumer = Servicios_PericialesApiConsumer;

            this._IDetalle_de_Devolucion_de_IndiciosApiConsumer = Detalle_de_Devolucion_de_IndiciosApiConsumer;



            this._IIndicios_para_MPIApiConsumer = Indicios_para_MPIApiConsumer;
            this._IServicios_PericialesApiConsumer = Servicios_PericialesApiConsumer;


        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Indicios
        [ObjectAuth(ObjectId = (ModuleObjectId)45171, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45171, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Indicios/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45171, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45171, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varIndicios = new IndiciosModel();
			varIndicios.Clave = Id;
			
            ViewBag.ObjectId = "45171";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_del_Indicio = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45185, ModuleId);
            ViewBag.PermissionDetalle_del_Indicio = permissionDetalle_del_Indicio;
            var permissionDetalle_de_Solicitud_de_Indicio = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45186, ModuleId);
            ViewBag.PermissionDetalle_de_Solicitud_de_Indicio = permissionDetalle_de_Solicitud_de_Indicio;
            var permissionDetalle_de_Devolucion_de_Indicios = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45187, ModuleId);
            ViewBag.PermissionDetalle_de_Devolucion_de_Indicios = permissionDetalle_de_Devolucion_de_Indicios;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var IndiciossData = _IIndiciosApiConsumer.ListaSelAll(0, 1000, "Indicios.Clave=" + Id, "").Resource.Indicioss;
				
				if (IndiciossData != null && IndiciossData.Count > 0)
                {
					var IndiciosData = IndiciossData.First();
					varIndicios= new IndiciosModel
					{
						Clave  = IndiciosData.Clave 
	                    ,Fecha_de_Registro = (IndiciosData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(IndiciosData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = IndiciosData.Hora_de_Registro
                    ,Usuario_que_Registra = IndiciosData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(IndiciosData.Usuario_que_Registra), "Spartan_User") ??  (string)IndiciosData.Usuario_que_Registra_Spartan_User.Name
                    ,NUC = IndiciosData.NUC
                    ,NUCNUC = CultureHelper.GetTraduction(Convert.ToString(IndiciosData.NUC), "Expediente_Inicial") ??  (string)IndiciosData.NUC_Expediente_Inicial.NUC
                    ,NIC = IndiciosData.NIC
                    ,Delegacion = IndiciosData.Delegacion
                    ,DelegacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(IndiciosData.Delegacion), "Delegacion") ??  (string)IndiciosData.Delegacion_Delegacion.Descripcion
                    ,Agencia = IndiciosData.Agencia
                    ,AgenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(IndiciosData.Agencia), "Agencia") ??  (string)IndiciosData.Agencia_Agencia.Descripcion
                    ,Clave_Indicio = IndiciosData.Clave_Indicio

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Expediente_Inicials_NUC = _IExpediente_InicialApiConsumer.SelAll(true);
            if (Expediente_Inicials_NUC != null && Expediente_Inicials_NUC.Resource != null)
                ViewBag.Expediente_Inicials_NUC = Expediente_Inicials_NUC.Resource.Where(m => m.NUC != null).OrderBy(m => m.NUC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Expediente_Inicial", "NUC") ?? m.NUC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion != null && Delegacions_Delegacion.Resource != null)
                ViewBag.Delegacions_Delegacion = Delegacions_Delegacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencias_Agencia = _IAgenciaApiConsumer.SelAll(true);
            if (Agencias_Agencia != null && Agencias_Agencia.Resource != null)
                ViewBag.Agencias_Agencia = Agencias_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.ClaveID)
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

				
            return View(varIndicios);
        }
		
	[HttpGet]
        public ActionResult AddIndicios(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45171);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
			IndiciosModel varIndicios= new IndiciosModel();
            var permissionDetalle_del_Indicio = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45185, ModuleId);
            ViewBag.PermissionDetalle_del_Indicio = permissionDetalle_del_Indicio;
            var permissionDetalle_de_Solicitud_de_Indicio = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45186, ModuleId);
            ViewBag.PermissionDetalle_de_Solicitud_de_Indicio = permissionDetalle_de_Solicitud_de_Indicio;
            var permissionDetalle_de_Devolucion_de_Indicios = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45187, ModuleId);
            ViewBag.PermissionDetalle_de_Devolucion_de_Indicios = permissionDetalle_de_Devolucion_de_Indicios;


            if (id.ToString() != "0")
            {
                var IndiciossData = _IIndiciosApiConsumer.ListaSelAll(0, 1000, "Indicios.Clave=" + id, "").Resource.Indicioss;
				
				if (IndiciossData != null && IndiciossData.Count > 0)
                {
					var IndiciosData = IndiciossData.First();
					varIndicios= new IndiciosModel
					{
						Clave  = IndiciosData.Clave 
	                    ,Fecha_de_Registro = (IndiciosData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(IndiciosData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = IndiciosData.Hora_de_Registro
                    ,Usuario_que_Registra = IndiciosData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(IndiciosData.Usuario_que_Registra), "Spartan_User") ??  (string)IndiciosData.Usuario_que_Registra_Spartan_User.Name
                    ,NUC = IndiciosData.NUC
                    ,NUCNUC = CultureHelper.GetTraduction(Convert.ToString(IndiciosData.NUC), "Expediente_Inicial") ??  (string)IndiciosData.NUC_Expediente_Inicial.NUC
                    ,NIC = IndiciosData.NIC
                    ,Delegacion = IndiciosData.Delegacion
                    ,DelegacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(IndiciosData.Delegacion), "Delegacion") ??  (string)IndiciosData.Delegacion_Delegacion.Descripcion
                    ,Agencia = IndiciosData.Agencia
                    ,AgenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(IndiciosData.Agencia), "Agencia") ??  (string)IndiciosData.Agencia_Agencia.Descripcion
                    ,Clave_Indicio = IndiciosData.Clave_Indicio

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Expediente_Inicials_NUC = _IExpediente_InicialApiConsumer.SelAll(true);
            if (Expediente_Inicials_NUC != null && Expediente_Inicials_NUC.Resource != null)
                ViewBag.Expediente_Inicials_NUC = Expediente_Inicials_NUC.Resource.Where(m => m.NUC != null).OrderBy(m => m.NUC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Expediente_Inicial", "NUC") ?? m.NUC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion != null && Delegacions_Delegacion.Resource != null)
                ViewBag.Delegacions_Delegacion = Delegacions_Delegacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencias_Agencia = _IAgenciaApiConsumer.SelAll(true);
            if (Agencias_Agencia != null && Agencias_Agencia.Resource != null)
                ViewBag.Agencias_Agencia = Agencias_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.ClaveID)
                }).ToList();


            return PartialView("AddIndicios", varIndicios);
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
        public ActionResult GetExpediente_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IExpediente_InicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.NUC).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Expediente_Inicial", "NUC")?? m.NUC,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDelegacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelegacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetAgenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAgenciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.ClaveID)
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
        public ActionResult ShowAdvanceFilter(IndiciosAdvanceSearchModel model, int idFilter = -1)
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

	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Expediente_Inicials_NUC = _IExpediente_InicialApiConsumer.SelAll(true);
            if (Expediente_Inicials_NUC != null && Expediente_Inicials_NUC.Resource != null)
                ViewBag.Expediente_Inicials_NUC = Expediente_Inicials_NUC.Resource.Where(m => m.NUC != null).OrderBy(m => m.NUC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Expediente_Inicial", "NUC") ?? m.NUC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion != null && Delegacions_Delegacion.Resource != null)
                ViewBag.Delegacions_Delegacion = Delegacions_Delegacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencias_Agencia = _IAgenciaApiConsumer.SelAll(true);
            if (Agencias_Agencia != null && Agencias_Agencia.Resource != null)
                ViewBag.Agencias_Agencia = Agencias_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.ClaveID)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IExpediente_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Expediente_Inicials_NUC = _IExpediente_InicialApiConsumer.SelAll(true);
            if (Expediente_Inicials_NUC != null && Expediente_Inicials_NUC.Resource != null)
                ViewBag.Expediente_Inicials_NUC = Expediente_Inicials_NUC.Resource.Where(m => m.NUC != null).OrderBy(m => m.NUC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Expediente_Inicial", "NUC") ?? m.NUC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelegacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delegacions_Delegacion = _IDelegacionApiConsumer.SelAll(true);
            if (Delegacions_Delegacion != null && Delegacions_Delegacion.Resource != null)
                ViewBag.Delegacions_Delegacion = Delegacions_Delegacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delegacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencias_Agencia = _IAgenciaApiConsumer.SelAll(true);
            if (Agencias_Agencia != null && Agencias_Agencia.Resource != null)
                ViewBag.Agencias_Agencia = Agencias_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ClaveID), "Agencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.ClaveID)
                }).ToList();


            var previousFiltersObj = new IndiciosAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (IndiciosAdvanceSearchModel)(Session["AdvanceSearch"] ?? new IndiciosAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new IndiciosPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IIndiciosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Indicioss == null)
                result.Indicioss = new List<Indicios>();

            return Json(new
            {
                data = result.Indicioss.Select(m => new IndiciosGridModel
                    {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,NUCNUC = CultureHelper.GetTraduction(m.NUC_Expediente_Inicial.Clave.ToString(), "NUC") ?? (string)m.NUC_Expediente_Inicial.NUC
			,NIC = m.NIC
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
			,Clave_Indicio = m.Clave_Indicio

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetIndiciosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IIndiciosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Indicios", m.),
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
        /// Get List of Indicios from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Indicios Entity</returns>
        public ActionResult GetIndiciosList(UrlParametersModel param)
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
            _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new IndiciosPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(IndiciosAdvanceSearchModel))
                {
					var advanceFilter =
                    (IndiciosAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            IndiciosPropertyMapper oIndiciosPropertyMapper = new IndiciosPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oIndiciosPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IIndiciosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Indicioss == null)
                result.Indicioss = new List<Indicios>();

            return Json(new
            {
                aaData = result.Indicioss.Select(m => new IndiciosGridModel
            {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,NUCNUC = CultureHelper.GetTraduction(m.NUC_Expediente_Inicial.Clave.ToString(), "NUC") ?? (string)m.NUC_Expediente_Inicial.NUC
			,NIC = m.NIC
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
			,Clave_Indicio = m.Clave_Indicio

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetIndicios_Usuario_que_Registra_Spartan_User(string query, string where)
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
//Grid GetAutoComplete

//Grid GetAutoComplete

//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(IndiciosAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Indicios.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Indicios.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Indicios.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Indicios.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Indicios.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Indicios.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
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

                where += " AND Indicios.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNUC))
            {
                switch (filter.NUCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Expediente_Inicial.NUC LIKE '" + filter.AdvanceNUC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Expediente_Inicial.NUC LIKE '%" + filter.AdvanceNUC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Expediente_Inicial.NUC = '" + filter.AdvanceNUC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Expediente_Inicial.NUC LIKE '%" + filter.AdvanceNUC + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNUCMultiple != null && filter.AdvanceNUCMultiple.Count() > 0)
            {
                var NUCIds = string.Join(",", filter.AdvanceNUCMultiple);

                where += " AND Indicios.NUC In (" + NUCIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.NIC))
            {
                switch (filter.NICFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Indicios.NIC LIKE '" + filter.NIC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Indicios.NIC LIKE '%" + filter.NIC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Indicios.NIC = '" + filter.NIC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Indicios.NIC LIKE '%" + filter.NIC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDelegacion))
            {
                switch (filter.DelegacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delegacion.Descripcion LIKE '" + filter.AdvanceDelegacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delegacion.Descripcion LIKE '%" + filter.AdvanceDelegacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delegacion.Descripcion = '" + filter.AdvanceDelegacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delegacion.Descripcion LIKE '%" + filter.AdvanceDelegacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDelegacionMultiple != null && filter.AdvanceDelegacionMultiple.Count() > 0)
            {
                var DelegacionIds = string.Join(",", filter.AdvanceDelegacionMultiple);

                where += " AND Indicios.Delegacion In (" + DelegacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAgencia))
            {
                switch (filter.AgenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Agencia.Descripcion LIKE '" + filter.AdvanceAgencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Agencia.Descripcion LIKE '%" + filter.AdvanceAgencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Agencia.Descripcion = '" + filter.AdvanceAgencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Agencia.Descripcion LIKE '%" + filter.AdvanceAgencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAgenciaMultiple != null && filter.AdvanceAgenciaMultiple.Count() > 0)
            {
                var AgenciaIds = string.Join(",", filter.AdvanceAgenciaMultiple);

                where += " AND Indicios.Agencia In (" + AgenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Clave_Indicio))
            {
                switch (filter.Clave_IndicioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Indicios.Clave_Indicio LIKE '" + filter.Clave_Indicio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Indicios.Clave_Indicio LIKE '%" + filter.Clave_Indicio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Indicios.Clave_Indicio = '" + filter.Clave_Indicio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Indicios.Clave_Indicio LIKE '%" + filter.Clave_Indicio + "%'";
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

        public ActionResult GetDetalle_del_Indicio(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_del_IndicioGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_del_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_del_Indicio.Indicios=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_del_Indicio.Indicios='" + RelationId + "'";
            }
            var result = _IDetalle_del_IndicioApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_del_Indicios == null)
                result.Detalle_del_Indicios = new List<Detalle_del_Indicio>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_del_Indicios.Select(m => new Detalle_del_IndicioGridModel
                {
                    Clave = m.Clave

			,Numero_de_Indicio = m.Numero_de_Indicio
			,Nombre_del_Indicio = m.Nombre_del_Indicio
			,Descripcion_del_Indicio = m.Descripcion_del_Indicio
			,Motivo = m.Motivo
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Indicio.Clave.ToString(), "Descripcion") ??(string)m.Estatus_Estatus_de_Indicio.Descripcion
			,Ubicacion_de_Indicio = m.Ubicacion_de_Indicio

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_del_IndicioGridModel> GetDetalle_del_IndicioData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_del_IndicioGridModel> resultData = new List<Detalle_del_IndicioGridModel>();
            string where = "Detalle_del_Indicio.Indicios=" + Id;
            if("int" == "string")
            {
                where = "Detalle_del_Indicio.Indicios='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_del_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_del_IndicioApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_del_Indicios != null)
            {
                resultData = result.Detalle_del_Indicios.Select(m => new Detalle_del_IndicioGridModel
                    {
                        Clave = m.Clave

			,Numero_de_Indicio = m.Numero_de_Indicio
			,Nombre_del_Indicio = m.Nombre_del_Indicio
			,Descripcion_del_Indicio = m.Descripcion_del_Indicio
			,Motivo = m.Motivo
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Indicio.Clave.ToString(), "Descripcion") ??(string)m.Estatus_Estatus_de_Indicio.Descripcion
			,Ubicacion_de_Indicio = m.Ubicacion_de_Indicio


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Solicitud_de_Indicio(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Solicitud_de_IndicioGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Solicitud_de_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Solicitud_de_Indicio.Indicios=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Solicitud_de_Indicio.Indicios='" + RelationId + "'";
            }
            var result = _IDetalle_de_Solicitud_de_IndicioApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Solicitud_de_Indicios == null)
                result.Detalle_de_Solicitud_de_Indicios = new List<Detalle_de_Solicitud_de_Indicio>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Solicitud_de_Indicios.Select(m => new Detalle_de_Solicitud_de_IndicioGridModel
                {
                    Clave = m.Clave

			,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Solicitud = m.Hora_de_Solicitud
			,Nombre_del_Solicitante = m.Nombre_del_Solicitante
			,Motivo = m.Motivo
                        ,Numero_de_Indicio = m.Numero_de_Indicio
                        ,Numero_de_IndicioDescripcion = CultureHelper.GetTraduction(m.Numero_de_Indicio_Indicios_para_MPI.Clave.ToString(), "Descripcion") ??(string)m.Numero_de_Indicio_Indicios_para_MPI.Descripcion
			,Nombre_de_Indicio = m.Nombre_de_Indicio
			,Descripcion_de_Entrega_de_Indicio = m.Descripcion_de_Entrega_de_Indicio
                        ,Diligencia_que_Solicita = m.Diligencia_que_Solicita
                        ,Diligencia_que_SolicitaServicio = CultureHelper.GetTraduction(m.Diligencia_que_Solicita_Servicios_Periciales.Clave.ToString(), "Servicio") ??(string)m.Diligencia_que_Solicita_Servicios_Periciales.Servicio

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Solicitud_de_IndicioGridModel> GetDetalle_de_Solicitud_de_IndicioData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Solicitud_de_IndicioGridModel> resultData = new List<Detalle_de_Solicitud_de_IndicioGridModel>();
            string where = "Detalle_de_Solicitud_de_Indicio.Indicios=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Solicitud_de_Indicio.Indicios='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Solicitud_de_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Solicitud_de_IndicioApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Solicitud_de_Indicios != null)
            {
                resultData = result.Detalle_de_Solicitud_de_Indicios.Select(m => new Detalle_de_Solicitud_de_IndicioGridModel
                    {
                        Clave = m.Clave

			,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Solicitud = m.Hora_de_Solicitud
			,Nombre_del_Solicitante = m.Nombre_del_Solicitante
			,Motivo = m.Motivo
                        ,Numero_de_Indicio = m.Numero_de_Indicio
                        ,Numero_de_IndicioDescripcion = CultureHelper.GetTraduction(m.Numero_de_Indicio_Indicios_para_MPI.Clave.ToString(), "Descripcion") ??(string)m.Numero_de_Indicio_Indicios_para_MPI.Descripcion
			,Nombre_de_Indicio = m.Nombre_de_Indicio
			,Descripcion_de_Entrega_de_Indicio = m.Descripcion_de_Entrega_de_Indicio
                        ,Diligencia_que_Solicita = m.Diligencia_que_Solicita
                        ,Diligencia_que_SolicitaServicio = CultureHelper.GetTraduction(m.Diligencia_que_Solicita_Servicios_Periciales.Clave.ToString(), "Servicio") ??(string)m.Diligencia_que_Solicita_Servicios_Periciales.Servicio


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Devolucion_de_Indicios(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Devolucion_de_IndiciosGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Devolucion_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Devolucion_de_Indicios.Indicios=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Devolucion_de_Indicios.Indicios='" + RelationId + "'";
            }
            var result = _IDetalle_de_Devolucion_de_IndiciosApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Devolucion_de_Indicioss == null)
                result.Detalle_de_Devolucion_de_Indicioss = new List<Detalle_de_Devolucion_de_Indicios>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Devolucion_de_Indicioss.Select(m => new Detalle_de_Devolucion_de_IndiciosGridModel
                {
                    Clave = m.Clave

			,Fecha_de_Devolucion = (m.Fecha_de_Devolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Devolucion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Devolucion = m.Hora_de_Devolucion
			,Nombre_de_Persona_que_Entrega = m.Nombre_de_Persona_que_Entrega
                        ,Numero_de_Indicio = m.Numero_de_Indicio
                        ,Numero_de_IndicioDescripcion = CultureHelper.GetTraduction(m.Numero_de_Indicio_Indicios_para_MPI.Clave.ToString(), "Descripcion") ??(string)m.Numero_de_Indicio_Indicios_para_MPI.Descripcion
			,Nombre_de_Indicio = m.Nombre_de_Indicio
			,Descripcion_de_Devolucion_de_Indicio = m.Descripcion_de_Devolucion_de_Indicio
                        ,Diligencia_que_Devuelve = m.Diligencia_que_Devuelve
                        ,Diligencia_que_DevuelveServicio = CultureHelper.GetTraduction(m.Diligencia_que_Devuelve_Servicios_Periciales.Clave.ToString(), "Servicio") ??(string)m.Diligencia_que_Devuelve_Servicios_Periciales.Servicio

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Devolucion_de_IndiciosGridModel> GetDetalle_de_Devolucion_de_IndiciosData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Devolucion_de_IndiciosGridModel> resultData = new List<Detalle_de_Devolucion_de_IndiciosGridModel>();
            string where = "Detalle_de_Devolucion_de_Indicios.Indicios=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Devolucion_de_Indicios.Indicios='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Devolucion_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Devolucion_de_IndiciosApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Devolucion_de_Indicioss != null)
            {
                resultData = result.Detalle_de_Devolucion_de_Indicioss.Select(m => new Detalle_de_Devolucion_de_IndiciosGridModel
                    {
                        Clave = m.Clave

			,Fecha_de_Devolucion = (m.Fecha_de_Devolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Devolucion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Devolucion = m.Hora_de_Devolucion
			,Nombre_de_Persona_que_Entrega = m.Nombre_de_Persona_que_Entrega
                        ,Numero_de_Indicio = m.Numero_de_Indicio
                        ,Numero_de_IndicioDescripcion = CultureHelper.GetTraduction(m.Numero_de_Indicio_Indicios_para_MPI.Clave.ToString(), "Descripcion") ??(string)m.Numero_de_Indicio_Indicios_para_MPI.Descripcion
			,Nombre_de_Indicio = m.Nombre_de_Indicio
			,Descripcion_de_Devolucion_de_Indicio = m.Descripcion_de_Devolucion_de_Indicio
                        ,Diligencia_que_Devuelve = m.Diligencia_que_Devuelve
                        ,Diligencia_que_DevuelveServicio = CultureHelper.GetTraduction(m.Diligencia_que_Devuelve_Servicios_Periciales.Clave.ToString(), "Servicio") ??(string)m.Diligencia_que_Devuelve_Servicios_Periciales.Servicio


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
                _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);

                Indicios varIndicios = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_del_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_del_Indicio.Indicios=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_del_Indicio.Indicios='" + id + "'";
                    }
                    var Detalle_del_IndicioInfo =
                        _IDetalle_del_IndicioApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_del_IndicioInfo.Detalle_del_Indicios.Count > 0)
                    {
                        var resultDetalle_del_Indicio = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_del_IndicioItem in Detalle_del_IndicioInfo.Detalle_del_Indicios)
                            resultDetalle_del_Indicio = resultDetalle_del_Indicio
                                              && _IDetalle_del_IndicioApiConsumer.Delete(Detalle_del_IndicioItem.Clave, null,null).Resource;

                        if (!resultDetalle_del_Indicio)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Solicitud_de_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Solicitud_de_Indicio.Indicios=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Solicitud_de_Indicio.Indicios='" + id + "'";
                    }
                    var Detalle_de_Solicitud_de_IndicioInfo =
                        _IDetalle_de_Solicitud_de_IndicioApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Solicitud_de_IndicioInfo.Detalle_de_Solicitud_de_Indicios.Count > 0)
                    {
                        var resultDetalle_de_Solicitud_de_Indicio = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Solicitud_de_IndicioItem in Detalle_de_Solicitud_de_IndicioInfo.Detalle_de_Solicitud_de_Indicios)
                            resultDetalle_de_Solicitud_de_Indicio = resultDetalle_de_Solicitud_de_Indicio
                                              && _IDetalle_de_Solicitud_de_IndicioApiConsumer.Delete(Detalle_de_Solicitud_de_IndicioItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Solicitud_de_Indicio)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Devolucion_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Devolucion_de_Indicios.Indicios=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Devolucion_de_Indicios.Indicios='" + id + "'";
                    }
                    var Detalle_de_Devolucion_de_IndiciosInfo =
                        _IDetalle_de_Devolucion_de_IndiciosApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Devolucion_de_IndiciosInfo.Detalle_de_Devolucion_de_Indicioss.Count > 0)
                    {
                        var resultDetalle_de_Devolucion_de_Indicios = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Devolucion_de_IndiciosItem in Detalle_de_Devolucion_de_IndiciosInfo.Detalle_de_Devolucion_de_Indicioss)
                            resultDetalle_de_Devolucion_de_Indicios = resultDetalle_de_Devolucion_de_Indicios
                                              && _IDetalle_de_Devolucion_de_IndiciosApiConsumer.Delete(Detalle_de_Devolucion_de_IndiciosItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Devolucion_de_Indicios)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IIndiciosApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, IndiciosModel varIndicios)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var IndiciosInfo = new Indicios
                    {
                        Clave = varIndicios.Clave
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varIndicios.Fecha_de_Registro)) ? DateTime.ParseExact(varIndicios.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varIndicios.Hora_de_Registro
                        ,Usuario_que_Registra = varIndicios.Usuario_que_Registra
                        ,NUC = varIndicios.NUC
                        ,NIC = varIndicios.NIC
                        ,Delegacion = varIndicios.Delegacion
                        ,Agencia = varIndicios.Agencia
                        ,Clave_Indicio = varIndicios.Clave_Indicio

                    };

                    result = !IsNew ?
                        _IIndiciosApiConsumer.Update(IndiciosInfo, null, null).Resource.ToString() :
                         _IIndiciosApiConsumer.Insert(IndiciosInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_del_Indicio(int MasterId, int referenceId, List<Detalle_del_IndicioGridModelPost> Detalle_del_IndicioItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_del_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_del_IndicioData = _IDetalle_del_IndicioApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_del_Indicio.Indicios=" + referenceId,"").Resource;
                if (Detalle_del_IndicioData == null || Detalle_del_IndicioData.Detalle_del_Indicios.Count == 0)
                    return true;

                var result = true;

                Detalle_del_IndicioGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_del_Indicio in Detalle_del_IndicioData.Detalle_del_Indicios)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_del_Indicio Detalle_del_Indicio1 = varDetalle_del_Indicio;

                    if (Detalle_del_IndicioItems != null && Detalle_del_IndicioItems.Any(m => m.Clave == Detalle_del_Indicio1.Clave))
                    {
                        modelDataToChange = Detalle_del_IndicioItems.FirstOrDefault(m => m.Clave == Detalle_del_Indicio1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_del_Indicio.Indicios = MasterId;
                    var insertId = _IDetalle_del_IndicioApiConsumer.Insert(varDetalle_del_Indicio,null,null).Resource;
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
        public ActionResult PostDetalle_del_Indicio(List<Detalle_del_IndicioGridModelPost> Detalle_del_IndicioItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_del_Indicio(MasterId, referenceId, Detalle_del_IndicioItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_del_IndicioItems != null && Detalle_del_IndicioItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_del_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_del_IndicioItem in Detalle_del_IndicioItems)
                    {








                        //Removal Request
                        if (Detalle_del_IndicioItem.Removed)
                        {
                            result = result && _IDetalle_del_IndicioApiConsumer.Delete(Detalle_del_IndicioItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_del_IndicioItem.Clave = 0;

                        var Detalle_del_IndicioData = new Detalle_del_Indicio
                        {
                            Indicios = MasterId
                            ,Clave = Detalle_del_IndicioItem.Clave
                            ,Numero_de_Indicio = Detalle_del_IndicioItem.Numero_de_Indicio
                            ,Nombre_del_Indicio = Detalle_del_IndicioItem.Nombre_del_Indicio
                            ,Descripcion_del_Indicio = Detalle_del_IndicioItem.Descripcion_del_Indicio
                            ,Motivo = Detalle_del_IndicioItem.Motivo
                            ,Estatus = (Convert.ToInt32(Detalle_del_IndicioItem.Estatus) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_IndicioItem.Estatus))
                            ,Ubicacion_de_Indicio = Detalle_del_IndicioItem.Ubicacion_de_Indicio

                        };

                        var resultId = Detalle_del_IndicioItem.Clave > 0
                           ? _IDetalle_del_IndicioApiConsumer.Update(Detalle_del_IndicioData,null,null).Resource
                           : _IDetalle_del_IndicioApiConsumer.Insert(Detalle_del_IndicioData,null,null).Resource;

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
        public ActionResult GetDetalle_del_Indicio_Estatus_de_IndicioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_IndicioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estatus_de_Indicio", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }


        [NonAction]
        public bool CopyDetalle_de_Solicitud_de_Indicio(int MasterId, int referenceId, List<Detalle_de_Solicitud_de_IndicioGridModelPost> Detalle_de_Solicitud_de_IndicioItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Solicitud_de_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Solicitud_de_IndicioData = _IDetalle_de_Solicitud_de_IndicioApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Solicitud_de_Indicio.Indicios=" + referenceId,"").Resource;
                if (Detalle_de_Solicitud_de_IndicioData == null || Detalle_de_Solicitud_de_IndicioData.Detalle_de_Solicitud_de_Indicios.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Solicitud_de_IndicioGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Solicitud_de_Indicio in Detalle_de_Solicitud_de_IndicioData.Detalle_de_Solicitud_de_Indicios)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Solicitud_de_Indicio Detalle_de_Solicitud_de_Indicio1 = varDetalle_de_Solicitud_de_Indicio;

                    if (Detalle_de_Solicitud_de_IndicioItems != null && Detalle_de_Solicitud_de_IndicioItems.Any(m => m.Clave == Detalle_de_Solicitud_de_Indicio1.Clave))
                    {
                        modelDataToChange = Detalle_de_Solicitud_de_IndicioItems.FirstOrDefault(m => m.Clave == Detalle_de_Solicitud_de_Indicio1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Solicitud_de_Indicio.Indicios = MasterId;
                    var insertId = _IDetalle_de_Solicitud_de_IndicioApiConsumer.Insert(varDetalle_de_Solicitud_de_Indicio,null,null).Resource;
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
        public ActionResult PostDetalle_de_Solicitud_de_Indicio(List<Detalle_de_Solicitud_de_IndicioGridModelPost> Detalle_de_Solicitud_de_IndicioItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Solicitud_de_Indicio(MasterId, referenceId, Detalle_de_Solicitud_de_IndicioItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Solicitud_de_IndicioItems != null && Detalle_de_Solicitud_de_IndicioItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Solicitud_de_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Solicitud_de_IndicioItem in Detalle_de_Solicitud_de_IndicioItems)
                    {










                        //Removal Request
                        if (Detalle_de_Solicitud_de_IndicioItem.Removed)
                        {
                            result = result && _IDetalle_de_Solicitud_de_IndicioApiConsumer.Delete(Detalle_de_Solicitud_de_IndicioItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Solicitud_de_IndicioItem.Clave = 0;

                        var Detalle_de_Solicitud_de_IndicioData = new Detalle_de_Solicitud_de_Indicio
                        {
                            Indicios = MasterId
                            ,Clave = Detalle_de_Solicitud_de_IndicioItem.Clave
                            ,Fecha_de_Solicitud = (Detalle_de_Solicitud_de_IndicioItem.Fecha_de_Solicitud!= null) ? DateTime.ParseExact(Detalle_de_Solicitud_de_IndicioItem.Fecha_de_Solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora_de_Solicitud = Detalle_de_Solicitud_de_IndicioItem.Hora_de_Solicitud
                            ,Nombre_del_Solicitante = Detalle_de_Solicitud_de_IndicioItem.Nombre_del_Solicitante
                            ,Motivo = Detalle_de_Solicitud_de_IndicioItem.Motivo
                            ,Numero_de_Indicio = (Convert.ToInt32(Detalle_de_Solicitud_de_IndicioItem.Numero_de_Indicio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Solicitud_de_IndicioItem.Numero_de_Indicio))
                            ,Nombre_de_Indicio = Detalle_de_Solicitud_de_IndicioItem.Nombre_de_Indicio
                            ,Descripcion_de_Entrega_de_Indicio = Detalle_de_Solicitud_de_IndicioItem.Descripcion_de_Entrega_de_Indicio
                            ,Diligencia_que_Solicita = (Convert.ToInt32(Detalle_de_Solicitud_de_IndicioItem.Diligencia_que_Solicita) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Solicitud_de_IndicioItem.Diligencia_que_Solicita))

                        };

                        var resultId = Detalle_de_Solicitud_de_IndicioItem.Clave > 0
                           ? _IDetalle_de_Solicitud_de_IndicioApiConsumer.Update(Detalle_de_Solicitud_de_IndicioData,null,null).Resource
                           : _IDetalle_de_Solicitud_de_IndicioApiConsumer.Insert(Detalle_de_Solicitud_de_IndicioData,null,null).Resource;

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
        public ActionResult GetDetalle_de_Solicitud_de_Indicio_Indicios_para_MPIAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIndicios_para_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IIndicios_para_MPIApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Indicios_para_MPI", "Descripcion");
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
        public ActionResult GetDetalle_de_Solicitud_de_Indicio_Servicios_PericialesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IServicios_PericialesApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Servicios_Periciales", "Servicio");
                  item.Servicio= trans??item.Servicio;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [NonAction]
        public bool CopyDetalle_de_Devolucion_de_Indicios(int MasterId, int referenceId, List<Detalle_de_Devolucion_de_IndiciosGridModelPost> Detalle_de_Devolucion_de_IndiciosItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Devolucion_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Devolucion_de_IndiciosData = _IDetalle_de_Devolucion_de_IndiciosApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Devolucion_de_Indicios.Indicios=" + referenceId,"").Resource;
                if (Detalle_de_Devolucion_de_IndiciosData == null || Detalle_de_Devolucion_de_IndiciosData.Detalle_de_Devolucion_de_Indicioss.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Devolucion_de_IndiciosGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Devolucion_de_Indicios in Detalle_de_Devolucion_de_IndiciosData.Detalle_de_Devolucion_de_Indicioss)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Devolucion_de_Indicios Detalle_de_Devolucion_de_Indicios1 = varDetalle_de_Devolucion_de_Indicios;

                    if (Detalle_de_Devolucion_de_IndiciosItems != null && Detalle_de_Devolucion_de_IndiciosItems.Any(m => m.Clave == Detalle_de_Devolucion_de_Indicios1.Clave))
                    {
                        modelDataToChange = Detalle_de_Devolucion_de_IndiciosItems.FirstOrDefault(m => m.Clave == Detalle_de_Devolucion_de_Indicios1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Devolucion_de_Indicios.Indicios = MasterId;
                    var insertId = _IDetalle_de_Devolucion_de_IndiciosApiConsumer.Insert(varDetalle_de_Devolucion_de_Indicios,null,null).Resource;
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
        public ActionResult PostDetalle_de_Devolucion_de_Indicios(List<Detalle_de_Devolucion_de_IndiciosGridModelPost> Detalle_de_Devolucion_de_IndiciosItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Devolucion_de_Indicios(MasterId, referenceId, Detalle_de_Devolucion_de_IndiciosItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Devolucion_de_IndiciosItems != null && Detalle_de_Devolucion_de_IndiciosItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Devolucion_de_IndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Devolucion_de_IndiciosItem in Detalle_de_Devolucion_de_IndiciosItems)
                    {









                        //Removal Request
                        if (Detalle_de_Devolucion_de_IndiciosItem.Removed)
                        {
                            result = result && _IDetalle_de_Devolucion_de_IndiciosApiConsumer.Delete(Detalle_de_Devolucion_de_IndiciosItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Devolucion_de_IndiciosItem.Clave = 0;

                        var Detalle_de_Devolucion_de_IndiciosData = new Detalle_de_Devolucion_de_Indicios
                        {
                            Indicios = MasterId
                            ,Clave = Detalle_de_Devolucion_de_IndiciosItem.Clave
                            ,Fecha_de_Devolucion = (Detalle_de_Devolucion_de_IndiciosItem.Fecha_de_Devolucion!= null) ? DateTime.ParseExact(Detalle_de_Devolucion_de_IndiciosItem.Fecha_de_Devolucion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora_de_Devolucion = Detalle_de_Devolucion_de_IndiciosItem.Hora_de_Devolucion
                            ,Nombre_de_Persona_que_Entrega = Detalle_de_Devolucion_de_IndiciosItem.Nombre_de_Persona_que_Entrega
                            ,Numero_de_Indicio = (Convert.ToInt32(Detalle_de_Devolucion_de_IndiciosItem.Numero_de_Indicio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Devolucion_de_IndiciosItem.Numero_de_Indicio))
                            ,Nombre_de_Indicio = Detalle_de_Devolucion_de_IndiciosItem.Nombre_de_Indicio
                            ,Descripcion_de_Devolucion_de_Indicio = Detalle_de_Devolucion_de_IndiciosItem.Descripcion_de_Devolucion_de_Indicio
                            ,Diligencia_que_Devuelve = (Convert.ToInt32(Detalle_de_Devolucion_de_IndiciosItem.Diligencia_que_Devuelve) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Devolucion_de_IndiciosItem.Diligencia_que_Devuelve))

                        };

                        var resultId = Detalle_de_Devolucion_de_IndiciosItem.Clave > 0
                           ? _IDetalle_de_Devolucion_de_IndiciosApiConsumer.Update(Detalle_de_Devolucion_de_IndiciosData,null,null).Resource
                           : _IDetalle_de_Devolucion_de_IndiciosApiConsumer.Insert(Detalle_de_Devolucion_de_IndiciosData,null,null).Resource;

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
        public ActionResult GetDetalle_de_Devolucion_de_Indicios_Indicios_para_MPIAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIndicios_para_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IIndicios_para_MPIApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Indicios_para_MPI", "Descripcion");
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
        public ActionResult GetDetalle_de_Devolucion_de_Indicios_Servicios_PericialesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IServicios_PericialesApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Servicios_Periciales", "Servicio");
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
        /// Write Element Array of Indicios script
        /// </summary>
        /// <param name="oIndiciosElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew IndiciosModuleAttributeList)
        {
            for (int i = 0; i < IndiciosModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(IndiciosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    IndiciosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(IndiciosModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    IndiciosModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (IndiciosModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < IndiciosModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < IndiciosModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(IndiciosModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							IndiciosModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(IndiciosModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							IndiciosModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strIndiciosScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Indicios.js")))
            {
                strIndiciosScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Indicios element attributes
            string userChangeJson = jsSerialize.Serialize(IndiciosModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strIndiciosScript.IndexOf("inpuElementArray");
            string splittedString = strIndiciosScript.Substring(indexOfArray, strIndiciosScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(IndiciosModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (IndiciosModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strIndiciosScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strIndiciosScript.Substring(indexOfArrayHistory, strIndiciosScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strIndiciosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strIndiciosScript.Substring(endIndexOfMainElement + indexOfArray, strIndiciosScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (IndiciosModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in IndiciosModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Indicios.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Indicios.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Indicios.js")))
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
        public ActionResult IndiciosPropertyBag()
        {
            return PartialView("IndiciosPropertyBag", "Indicios");
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
        public ActionResult AddDetalle_del_Indicio(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_del_Indicio/AddDetalle_del_Indicio");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Solicitud_de_Indicio(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Solicitud_de_Indicio/AddDetalle_de_Solicitud_de_Indicio");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Devolucion_de_Indicios(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Devolucion_de_Indicios/AddDetalle_de_Devolucion_de_Indicios");
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
                var whereClauseFormat = "Object = 45171 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Indicios.Clave= " + RecordId;
                            var result = _IIndiciosApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new IndiciosPropertyMapper());
			
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
                    (IndiciosAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            IndiciosPropertyMapper oIndiciosPropertyMapper = new IndiciosPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oIndiciosPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IIndiciosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Indicioss == null)
                result.Indicioss = new List<Indicios>();

            var data = result.Indicioss.Select(m => new IndiciosGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,NUCNUC = CultureHelper.GetTraduction(m.NUC_Expediente_Inicial.Clave.ToString(), "NUC") ?? (string)m.NUC_Expediente_Inicial.NUC
			,NIC = m.NIC
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
			,Clave_Indicio = m.Clave_Indicio

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45171, arrayColumnsVisible), "IndiciosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45171, arrayColumnsVisible), "IndiciosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45171, arrayColumnsVisible), "IndiciosList_" + DateTime.Now.ToString());
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

            _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new IndiciosPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (IndiciosAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            IndiciosPropertyMapper oIndiciosPropertyMapper = new IndiciosPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oIndiciosPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IIndiciosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Indicioss == null)
                result.Indicioss = new List<Indicios>();

            var data = result.Indicioss.Select(m => new IndiciosGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,NUCNUC = CultureHelper.GetTraduction(m.NUC_Expediente_Inicial.Clave.ToString(), "NUC") ?? (string)m.NUC_Expediente_Inicial.NUC
			,NIC = m.NIC
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
			,Clave_Indicio = m.Clave_Indicio

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
                _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IIndiciosApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Registro_de_Indicios(Indicios_Registro_de_IndiciosModel varIndicios)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Indicios_Registro_de_IndiciosInfo = new Indicios_Registro_de_Indicios
                {
                    Clave = varIndicios.Clave
                                            ,Fecha_de_Registro = (!String.IsNullOrEmpty(varIndicios.Fecha_de_Registro)) ? DateTime.ParseExact(varIndicios.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varIndicios.Hora_de_Registro
                        ,Usuario_que_Registra = varIndicios.Usuario_que_Registra
                        ,NUC = varIndicios.NUC
                        ,NIC = varIndicios.NIC
                        ,Delegacion = varIndicios.Delegacion
                        ,Agencia = varIndicios.Agencia
                        ,Clave_Indicio = varIndicios.Clave_Indicio
                    
                };

                result = _IIndiciosApiConsumer.Update_Registro_de_Indicios(Indicios_Registro_de_IndiciosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Registro_de_Indicios(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IIndiciosApiConsumer.Get_Registro_de_Indicios(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Indicio;
                var Detalle_del_IndicioData = GetDetalle_del_IndicioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Indicio);
                int RowCount_Detalle_de_Solicitud_de_Indicio;
                var Detalle_de_Solicitud_de_IndicioData = GetDetalle_de_Solicitud_de_IndicioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitud_de_Indicio);
                int RowCount_Detalle_de_Devolucion_de_Indicios;
                var Detalle_de_Devolucion_de_IndiciosData = GetDetalle_de_Devolucion_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Devolucion_de_Indicios);

                var result = new Indicios_Registro_de_IndiciosModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,NUC = m.NUC
                        ,NUCNUC = CultureHelper.GetTraduction(m.NUC_Expediente_Inicial.Clave.ToString(), "NUC") ?? (string)m.NUC_Expediente_Inicial.NUC
			,NIC = m.NIC
                        ,Delegacion = m.Delegacion
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
                        ,Agencia = m.Agencia
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
			,Clave_Indicio = m.Clave_Indicio

                    
                };
				var resultData = new
                {
                    data = result
                    ,IndiciosC = Detalle_del_IndicioData
                    ,Solicitudes = Detalle_de_Solicitud_de_IndicioData
                    ,Devoluciones = Detalle_de_Devolucion_de_IndiciosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_Indicios(Indicios_Datos_IndiciosModel varIndicios)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Indicios_Datos_IndiciosInfo = new Indicios_Datos_Indicios
                {
                    Clave = varIndicios.Clave
                                        
                };

                result = _IIndiciosApiConsumer.Update_Datos_Indicios(Indicios_Datos_IndiciosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_Indicios(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IIndiciosApiConsumer.Get_Datos_Indicios(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Indicio;
                var Detalle_del_IndicioData = GetDetalle_del_IndicioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Indicio);
                int RowCount_Detalle_de_Solicitud_de_Indicio;
                var Detalle_de_Solicitud_de_IndicioData = GetDetalle_de_Solicitud_de_IndicioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitud_de_Indicio);
                int RowCount_Detalle_de_Devolucion_de_Indicios;
                var Detalle_de_Devolucion_de_IndiciosData = GetDetalle_de_Devolucion_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Devolucion_de_Indicios);

                var result = new Indicios_Datos_IndiciosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,IndiciosC = Detalle_del_IndicioData
                    ,Solicitudes = Detalle_de_Solicitud_de_IndicioData
                    ,Devoluciones = Detalle_de_Devolucion_de_IndiciosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Solicitud_de_Indicios(Indicios_Solicitud_de_IndiciosModel varIndicios)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Indicios_Solicitud_de_IndiciosInfo = new Indicios_Solicitud_de_Indicios
                {
                    Clave = varIndicios.Clave
                                        
                };

                result = _IIndiciosApiConsumer.Update_Solicitud_de_Indicios(Indicios_Solicitud_de_IndiciosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Solicitud_de_Indicios(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IIndiciosApiConsumer.Get_Solicitud_de_Indicios(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Indicio;
                var Detalle_del_IndicioData = GetDetalle_del_IndicioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Indicio);
                int RowCount_Detalle_de_Solicitud_de_Indicio;
                var Detalle_de_Solicitud_de_IndicioData = GetDetalle_de_Solicitud_de_IndicioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitud_de_Indicio);
                int RowCount_Detalle_de_Devolucion_de_Indicios;
                var Detalle_de_Devolucion_de_IndiciosData = GetDetalle_de_Devolucion_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Devolucion_de_Indicios);

                var result = new Indicios_Solicitud_de_IndiciosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,IndiciosC = Detalle_del_IndicioData
                    ,Solicitudes = Detalle_de_Solicitud_de_IndicioData
                    ,Devoluciones = Detalle_de_Devolucion_de_IndiciosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Devolucion_de_Indicios(Indicios_Devolucion_de_IndiciosModel varIndicios)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Indicios_Devolucion_de_IndiciosInfo = new Indicios_Devolucion_de_Indicios
                {
                    Clave = varIndicios.Clave
                                        
                };

                result = _IIndiciosApiConsumer.Update_Devolucion_de_Indicios(Indicios_Devolucion_de_IndiciosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Devolucion_de_Indicios(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIndiciosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IIndiciosApiConsumer.Get_Devolucion_de_Indicios(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_del_Indicio;
                var Detalle_del_IndicioData = GetDetalle_del_IndicioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_del_Indicio);
                int RowCount_Detalle_de_Solicitud_de_Indicio;
                var Detalle_de_Solicitud_de_IndicioData = GetDetalle_de_Solicitud_de_IndicioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Solicitud_de_Indicio);
                int RowCount_Detalle_de_Devolucion_de_Indicios;
                var Detalle_de_Devolucion_de_IndiciosData = GetDetalle_de_Devolucion_de_IndiciosData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Devolucion_de_Indicios);

                var result = new Indicios_Devolucion_de_IndiciosModel
                {
                    Clave = m.Clave

                    
                };
				var resultData = new
                {
                    data = result
                    ,IndiciosC = Detalle_del_IndicioData
                    ,Solicitudes = Detalle_de_Solicitud_de_IndicioData
                    ,Devoluciones = Detalle_de_Devolucion_de_IndiciosData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

