using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Usuario;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Delegacion;
using Spartane.Core.Domain.Agencia;
using Spartane.Core.Domain.Especialidad_MP;
using Spartane.Core.Domain.Detalle_de_Folio_Asignado_de_Usuario;


using Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio;



using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Usuario;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Usuario;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Delegacion;
using Spartane.Web.Areas.WebApiConsumer.Agencia;
using Spartane.Web.Areas.WebApiConsumer.Especialidad_MP;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Folio_Asignado_de_Usuario;

using Spartane.Web.Areas.WebApiConsumer.Catalogo_de_Estatus_de_Folio;



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
    public class UsuarioController : Controller
    {
        #region "variable declaration"

        private IUsuarioService service = null;
        private IUsuarioApiConsumer _IUsuarioApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IDelegacionApiConsumer _IDelegacionApiConsumer;
        private IAgenciaApiConsumer _IAgenciaApiConsumer;
        private IEspecialidad_MPApiConsumer _IEspecialidad_MPApiConsumer;
        private IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer;

        private ICatalogo_de_Estatus_de_FolioApiConsumer _ICatalogo_de_Estatus_de_FolioApiConsumer;



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

        
        public UsuarioController(IUsuarioService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IUsuarioApiConsumer UsuarioApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IDelegacionApiConsumer DelegacionApiConsumer , IAgenciaApiConsumer AgenciaApiConsumer , IEspecialidad_MPApiConsumer Especialidad_MPApiConsumer , IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer Detalle_de_Folio_Asignado_de_UsuarioApiConsumer , ICatalogo_de_Estatus_de_FolioApiConsumer Catalogo_de_Estatus_de_FolioApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IUsuarioApiConsumer = UsuarioApiConsumer;
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
            this._IDelegacionApiConsumer = DelegacionApiConsumer;
            this._IAgenciaApiConsumer = AgenciaApiConsumer;
            this._IEspecialidad_MPApiConsumer = Especialidad_MPApiConsumer;
            this._IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer = Detalle_de_Folio_Asignado_de_UsuarioApiConsumer;

            this._ICatalogo_de_Estatus_de_FolioApiConsumer = Catalogo_de_Estatus_de_FolioApiConsumer;



        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Usuario
        [ObjectAuth(ObjectId = (ModuleObjectId)45040, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45040, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Usuario/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45040, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45040, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varUsuario = new UsuarioModel();
			varUsuario.Clave = Id;
			
            ViewBag.ObjectId = "45040";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_de_Folio_Asignado_de_Usuario = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45232, ModuleId);
            ViewBag.PermissionDetalle_de_Folio_Asignado_de_Usuario = permissionDetalle_de_Folio_Asignado_de_Usuario;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IUsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var UsuariosData = _IUsuarioApiConsumer.ListaSelAll(0, 1000, "Usuario.Clave=" + Id, "").Resource.Usuarios;
				
				if (UsuariosData != null && UsuariosData.Count > 0)
                {
					var UsuarioData = UsuariosData.First();
					varUsuario= new UsuarioModel
					{
						Clave  = UsuarioData.Clave 
	                    ,Nombre = UsuarioData.Nombre
                    ,NombreName = CultureHelper.GetTraduction(Convert.ToString(UsuarioData.Nombre), "Spartan_User") ??  (string)UsuarioData.Nombre_Spartan_User.Name
                    ,Clave_de_Acceso = UsuarioData.Clave_de_Acceso
                    ,Grupo_de_Usuario = UsuarioData.Grupo_de_Usuario
                    ,Numero_de_Empleado = UsuarioData.Numero_de_Empleado
                    ,Correo_Institucional = UsuarioData.Correo_Institucional
                    ,CUIP = UsuarioData.CUIP
                    ,Delegacion = UsuarioData.Delegacion
                    ,DelegacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(UsuarioData.Delegacion), "Delegacion") ??  (string)UsuarioData.Delegacion_Delegacion.Descripcion
                    ,Carga_de_Trabajo = UsuarioData.Carga_de_Trabajo
                    ,Nombre_Remitente = UsuarioData.Nombre_Remitente
                    ,Apellido_Paterno = UsuarioData.Apellido_Paterno
                    ,Apellido_Materno = UsuarioData.Apellido_Materno
                    ,Agencia = UsuarioData.Agencia
                    ,AgenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(UsuarioData.Agencia), "Agencia") ??  (string)UsuarioData.Agencia_Agencia.Descripcion
                    ,Especialidad = UsuarioData.Especialidad
                    ,EspecialidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(UsuarioData.Especialidad), "Especialidad_MP") ??  (string)UsuarioData.Especialidad_Especialidad_MP.Descripcion
                    ,ID_de_Dispositivo = UsuarioData.ID_de_Dispositivo
                    ,ID_de_Huella = UsuarioData.ID_de_Huella
                    ,Fotografia = UsuarioData.Fotografia
                    ,Usuario_que_Registra = UsuarioData.Usuario_que_Registra
                    ,Fecha_de_Registro = (UsuarioData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(UsuarioData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = UsuarioData.Hora_de_Registro
                    ,Estatus_de_Registro = UsuarioData.Estatus_de_Registro

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Nombre = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Nombre != null && Spartan_Users_Nombre.Resource != null)
                ViewBag.Spartan_Users_Nombre = Spartan_Users_Nombre.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
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
            _IEspecialidad_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especialidad_MPs_Especialidad = _IEspecialidad_MPApiConsumer.SelAll(true);
            if (Especialidad_MPs_Especialidad != null && Especialidad_MPs_Especialidad.Resource != null)
                ViewBag.Especialidad_MPs_Especialidad = Especialidad_MPs_Especialidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad_MP", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varUsuario);
        }
		
	[HttpGet]
        public ActionResult AddUsuario(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45040);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IUsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
			UsuarioModel varUsuario= new UsuarioModel();
            var permissionDetalle_de_Folio_Asignado_de_Usuario = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45232, ModuleId);
            ViewBag.PermissionDetalle_de_Folio_Asignado_de_Usuario = permissionDetalle_de_Folio_Asignado_de_Usuario;


            if (id.ToString() != "0")
            {
                var UsuariosData = _IUsuarioApiConsumer.ListaSelAll(0, 1000, "Usuario.Clave=" + id, "").Resource.Usuarios;
				
				if (UsuariosData != null && UsuariosData.Count > 0)
                {
					var UsuarioData = UsuariosData.First();
					varUsuario= new UsuarioModel
					{
						Clave  = UsuarioData.Clave 
	                    ,Nombre = UsuarioData.Nombre
                    ,NombreName = CultureHelper.GetTraduction(Convert.ToString(UsuarioData.Nombre), "Spartan_User") ??  (string)UsuarioData.Nombre_Spartan_User.Name
                    ,Clave_de_Acceso = UsuarioData.Clave_de_Acceso
                    ,Grupo_de_Usuario = UsuarioData.Grupo_de_Usuario
                    ,Numero_de_Empleado = UsuarioData.Numero_de_Empleado
                    ,Correo_Institucional = UsuarioData.Correo_Institucional
                    ,CUIP = UsuarioData.CUIP
                    ,Delegacion = UsuarioData.Delegacion
                    ,DelegacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(UsuarioData.Delegacion), "Delegacion") ??  (string)UsuarioData.Delegacion_Delegacion.Descripcion
                    ,Carga_de_Trabajo = UsuarioData.Carga_de_Trabajo
                    ,Nombre_Remitente = UsuarioData.Nombre_Remitente
                    ,Apellido_Paterno = UsuarioData.Apellido_Paterno
                    ,Apellido_Materno = UsuarioData.Apellido_Materno
                    ,Agencia = UsuarioData.Agencia
                    ,AgenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(UsuarioData.Agencia), "Agencia") ??  (string)UsuarioData.Agencia_Agencia.Descripcion
                    ,Especialidad = UsuarioData.Especialidad
                    ,EspecialidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(UsuarioData.Especialidad), "Especialidad_MP") ??  (string)UsuarioData.Especialidad_Especialidad_MP.Descripcion
                    ,ID_de_Dispositivo = UsuarioData.ID_de_Dispositivo
                    ,ID_de_Huella = UsuarioData.ID_de_Huella
                    ,Fotografia = UsuarioData.Fotografia
                    ,Usuario_que_Registra = UsuarioData.Usuario_que_Registra
                    ,Fecha_de_Registro = (UsuarioData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(UsuarioData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = UsuarioData.Hora_de_Registro
                    ,Estatus_de_Registro = UsuarioData.Estatus_de_Registro

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Nombre = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Nombre != null && Spartan_Users_Nombre.Resource != null)
                ViewBag.Spartan_Users_Nombre = Spartan_Users_Nombre.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
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
            _IEspecialidad_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especialidad_MPs_Especialidad = _IEspecialidad_MPApiConsumer.SelAll(true);
            if (Especialidad_MPs_Especialidad != null && Especialidad_MPs_Especialidad.Resource != null)
                ViewBag.Especialidad_MPs_Especialidad = Especialidad_MPs_Especialidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad_MP", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddUsuario", varUsuario);
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
        [HttpGet]
        public ActionResult GetEspecialidad_MPAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEspecialidad_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEspecialidad_MPApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad_MP", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(UsuarioAdvanceSearchModel model, int idFilter = -1)
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
            var Spartan_Users_Nombre = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Nombre != null && Spartan_Users_Nombre.Resource != null)
                ViewBag.Spartan_Users_Nombre = Spartan_Users_Nombre.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
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
            _IEspecialidad_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especialidad_MPs_Especialidad = _IEspecialidad_MPApiConsumer.SelAll(true);
            if (Especialidad_MPs_Especialidad != null && Especialidad_MPs_Especialidad.Resource != null)
                ViewBag.Especialidad_MPs_Especialidad = Especialidad_MPs_Especialidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad_MP", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

	    _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Nombre = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Nombre != null && Spartan_Users_Nombre.Resource != null)
                ViewBag.Spartan_Users_Nombre = Spartan_Users_Nombre.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
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
            _IEspecialidad_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especialidad_MPs_Especialidad = _IEspecialidad_MPApiConsumer.SelAll(true);
            if (Especialidad_MPs_Especialidad != null && Especialidad_MPs_Especialidad.Resource != null)
                ViewBag.Especialidad_MPs_Especialidad = Especialidad_MPs_Especialidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especialidad_MP", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new UsuarioAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (UsuarioAdvanceSearchModel)(Session["AdvanceSearch"] ?? new UsuarioAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new UsuarioPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IUsuarioApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Usuarios == null)
                result.Usuarios = new List<Usuario>();

            return Json(new
            {
                data = result.Usuarios.Select(m => new UsuarioGridModel
                    {
                    Clave = m.Clave
                        ,NombreName = CultureHelper.GetTraduction(m.Nombre_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Nombre_Spartan_User.Name
			,Clave_de_Acceso = m.Clave_de_Acceso
			,Grupo_de_Usuario = m.Grupo_de_Usuario
			,Numero_de_Empleado = m.Numero_de_Empleado
			,Correo_Institucional = m.Correo_Institucional
			,CUIP = m.CUIP
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
			,Carga_de_Trabajo = m.Carga_de_Trabajo
			,Nombre_Remitente = m.Nombre_Remitente
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad_MP.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad_MP.Descripcion
			,ID_de_Dispositivo = m.ID_de_Dispositivo
			,ID_de_Huella = m.ID_de_Huella
			,Fotografia = m.Fotografia
			,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
			,Estatus_de_Registro = m.Estatus_de_Registro

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetUsuarioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUsuarioApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Usuario", m.),
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
        /// Get List of Usuario from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Usuario Entity</returns>
        public ActionResult GetUsuarioList(UrlParametersModel param)
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
            _IUsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new UsuarioPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(UsuarioAdvanceSearchModel))
                {
					var advanceFilter =
                    (UsuarioAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            UsuarioPropertyMapper oUsuarioPropertyMapper = new UsuarioPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oUsuarioPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IUsuarioApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Usuarios == null)
                result.Usuarios = new List<Usuario>();

            return Json(new
            {
                aaData = result.Usuarios.Select(m => new UsuarioGridModel
            {
                    Clave = m.Clave
                        ,NombreName = CultureHelper.GetTraduction(m.Nombre_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Nombre_Spartan_User.Name
			,Clave_de_Acceso = m.Clave_de_Acceso
			,Grupo_de_Usuario = m.Grupo_de_Usuario
			,Numero_de_Empleado = m.Numero_de_Empleado
			,Correo_Institucional = m.Correo_Institucional
			,CUIP = m.CUIP
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
			,Carga_de_Trabajo = m.Carga_de_Trabajo
			,Nombre_Remitente = m.Nombre_Remitente
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad_MP.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad_MP.Descripcion
			,ID_de_Dispositivo = m.ID_de_Dispositivo
			,ID_de_Huella = m.ID_de_Huella
			,Fotografia = m.Fotografia
			,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
			,Estatus_de_Registro = m.Estatus_de_Registro

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetUsuario_Nombre_Spartan_User(string query, string where)
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






        [NonAction]
        public string GetAdvanceFilter(UsuarioAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Usuario.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Usuario.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNombre))
            {
                switch (filter.NombreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceNombre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceNombre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceNombre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceNombre + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNombreMultiple != null && filter.AdvanceNombreMultiple.Count() > 0)
            {
                var NombreIds = string.Join(",", filter.AdvanceNombreMultiple);

                where += " AND Usuario.Nombre In (" + NombreIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Clave_de_Acceso))
            {
                switch (filter.Clave_de_AccesoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Usuario.Clave_de_Acceso LIKE '" + filter.Clave_de_Acceso + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Usuario.Clave_de_Acceso LIKE '%" + filter.Clave_de_Acceso + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Usuario.Clave_de_Acceso = '" + filter.Clave_de_Acceso + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Usuario.Clave_de_Acceso LIKE '%" + filter.Clave_de_Acceso + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromGrupo_de_Usuario) || !string.IsNullOrEmpty(filter.ToGrupo_de_Usuario))
            {
                if (!string.IsNullOrEmpty(filter.FromGrupo_de_Usuario))
                    where += " AND Usuario.Grupo_de_Usuario >= " + filter.FromGrupo_de_Usuario;
                if (!string.IsNullOrEmpty(filter.ToGrupo_de_Usuario))
                    where += " AND Usuario.Grupo_de_Usuario <= " + filter.ToGrupo_de_Usuario;
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Empleado))
            {
                switch (filter.Numero_de_EmpleadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Usuario.Numero_de_Empleado LIKE '" + filter.Numero_de_Empleado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Usuario.Numero_de_Empleado LIKE '%" + filter.Numero_de_Empleado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Usuario.Numero_de_Empleado = '" + filter.Numero_de_Empleado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Usuario.Numero_de_Empleado LIKE '%" + filter.Numero_de_Empleado + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Institucional))
            {
                switch (filter.Correo_InstitucionalFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Usuario.Correo_Institucional LIKE '" + filter.Correo_Institucional + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Usuario.Correo_Institucional LIKE '%" + filter.Correo_Institucional + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Usuario.Correo_Institucional = '" + filter.Correo_Institucional + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Usuario.Correo_Institucional LIKE '%" + filter.Correo_Institucional + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.CUIP))
            {
                switch (filter.CUIPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Usuario.CUIP LIKE '" + filter.CUIP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Usuario.CUIP LIKE '%" + filter.CUIP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Usuario.CUIP = '" + filter.CUIP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Usuario.CUIP LIKE '%" + filter.CUIP + "%'";
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

                where += " AND Usuario.Delegacion In (" + DelegacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCarga_de_Trabajo) || !string.IsNullOrEmpty(filter.ToCarga_de_Trabajo))
            {
                if (!string.IsNullOrEmpty(filter.FromCarga_de_Trabajo))
                    where += " AND Usuario.Carga_de_Trabajo >= " + filter.FromCarga_de_Trabajo;
                if (!string.IsNullOrEmpty(filter.ToCarga_de_Trabajo))
                    where += " AND Usuario.Carga_de_Trabajo <= " + filter.ToCarga_de_Trabajo;
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Remitente))
            {
                switch (filter.Nombre_RemitenteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Usuario.Nombre_Remitente LIKE '" + filter.Nombre_Remitente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Usuario.Nombre_Remitente LIKE '%" + filter.Nombre_Remitente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Usuario.Nombre_Remitente = '" + filter.Nombre_Remitente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Usuario.Nombre_Remitente LIKE '%" + filter.Nombre_Remitente + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno))
            {
                switch (filter.Apellido_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Usuario.Apellido_Paterno LIKE '" + filter.Apellido_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Usuario.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Usuario.Apellido_Paterno = '" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Usuario.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno))
            {
                switch (filter.Apellido_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Usuario.Apellido_Materno LIKE '" + filter.Apellido_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Usuario.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Usuario.Apellido_Materno = '" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Usuario.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "%'";
                        break;
                }
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

                where += " AND Usuario.Agencia In (" + AgenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEspecialidad))
            {
                switch (filter.EspecialidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Especialidad_MP.Descripcion LIKE '" + filter.AdvanceEspecialidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Especialidad_MP.Descripcion LIKE '%" + filter.AdvanceEspecialidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Especialidad_MP.Descripcion = '" + filter.AdvanceEspecialidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Especialidad_MP.Descripcion LIKE '%" + filter.AdvanceEspecialidad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEspecialidadMultiple != null && filter.AdvanceEspecialidadMultiple.Count() > 0)
            {
                var EspecialidadIds = string.Join(",", filter.AdvanceEspecialidadMultiple);

                where += " AND Usuario.Especialidad In (" + EspecialidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.ID_de_Dispositivo))
            {
                switch (filter.ID_de_DispositivoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Usuario.ID_de_Dispositivo LIKE '" + filter.ID_de_Dispositivo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Usuario.ID_de_Dispositivo LIKE '%" + filter.ID_de_Dispositivo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Usuario.ID_de_Dispositivo = '" + filter.ID_de_Dispositivo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Usuario.ID_de_Dispositivo LIKE '%" + filter.ID_de_Dispositivo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.ID_de_Huella))
            {
                switch (filter.ID_de_HuellaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Usuario.ID_de_Huella LIKE '" + filter.ID_de_Huella + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Usuario.ID_de_Huella LIKE '%" + filter.ID_de_Huella + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Usuario.ID_de_Huella = '" + filter.ID_de_Huella + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Usuario.ID_de_Huella LIKE '%" + filter.ID_de_Huella + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFotografia) || !string.IsNullOrEmpty(filter.ToFotografia))
            {
                if (!string.IsNullOrEmpty(filter.FromFotografia))
                    where += " AND Usuario.Fotografia >= " + filter.FromFotografia;
                if (!string.IsNullOrEmpty(filter.ToFotografia))
                    where += " AND Usuario.Fotografia <= " + filter.ToFotografia;
            }

            if (!string.IsNullOrEmpty(filter.FromUsuario_que_Registra) || !string.IsNullOrEmpty(filter.ToUsuario_que_Registra))
            {
                if (!string.IsNullOrEmpty(filter.FromUsuario_que_Registra))
                    where += " AND Usuario.Usuario_que_Registra >= " + filter.FromUsuario_que_Registra;
                if (!string.IsNullOrEmpty(filter.ToUsuario_que_Registra))
                    where += " AND Usuario.Usuario_que_Registra <= " + filter.ToUsuario_que_Registra;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Usuario.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Usuario.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Usuario.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Usuario.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
            }

            if (!string.IsNullOrEmpty(filter.Estatus_de_Registro))
            {
                switch (filter.Estatus_de_RegistroFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Usuario.Estatus_de_Registro LIKE '" + filter.Estatus_de_Registro + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Usuario.Estatus_de_Registro LIKE '%" + filter.Estatus_de_Registro + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Usuario.Estatus_de_Registro = '" + filter.Estatus_de_Registro + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Usuario.Estatus_de_Registro LIKE '%" + filter.Estatus_de_Registro + "%'";
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

        public ActionResult GetDetalle_de_Folio_Asignado_de_Usuario(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Folio_Asignado_de_UsuarioGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Folio_Asignado_de_Usuario.Usuario=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Folio_Asignado_de_Usuario.Usuario='" + RelationId + "'";
            }
            var result = _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Folio_Asignado_de_Usuarios == null)
                result.Detalle_de_Folio_Asignado_de_Usuarios = new List<Detalle_de_Folio_Asignado_de_Usuario>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Folio_Asignado_de_Usuarios.Select(m => new Detalle_de_Folio_Asignado_de_UsuarioGridModel
                {
                    Clave = m.Clave

			,Folio = m.Folio
                        ,Estatus_de_Folio = m.Estatus_de_Folio
                        ,Estatus_de_FolioDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Folio_Catalogo_de_Estatus_de_Folio.Clave.ToString(), "Descripcion") ??(string)m.Estatus_de_Folio_Catalogo_de_Estatus_de_Folio.Descripcion
			,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Folio_Asignado_de_UsuarioGridModel> GetDetalle_de_Folio_Asignado_de_UsuarioData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Folio_Asignado_de_UsuarioGridModel> resultData = new List<Detalle_de_Folio_Asignado_de_UsuarioGridModel>();
            string where = "Detalle_de_Folio_Asignado_de_Usuario.Usuario=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Folio_Asignado_de_Usuario.Usuario='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Folio_Asignado_de_Usuarios != null)
            {
                resultData = result.Detalle_de_Folio_Asignado_de_Usuarios.Select(m => new Detalle_de_Folio_Asignado_de_UsuarioGridModel
                    {
                        Clave = m.Clave

			,Folio = m.Folio
                        ,Estatus_de_Folio = m.Estatus_de_Folio
                        ,Estatus_de_FolioDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Folio_Catalogo_de_Estatus_de_Folio.Clave.ToString(), "Descripcion") ??(string)m.Estatus_de_Folio_Catalogo_de_Estatus_de_Folio.Descripcion
			,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))


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
                _IUsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);

                Usuario varUsuario = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Folio_Asignado_de_Usuario.Usuario=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Folio_Asignado_de_Usuario.Usuario='" + id + "'";
                    }
                    var Detalle_de_Folio_Asignado_de_UsuarioInfo =
                        _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Folio_Asignado_de_UsuarioInfo.Detalle_de_Folio_Asignado_de_Usuarios.Count > 0)
                    {
                        var resultDetalle_de_Folio_Asignado_de_Usuario = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Folio_Asignado_de_UsuarioItem in Detalle_de_Folio_Asignado_de_UsuarioInfo.Detalle_de_Folio_Asignado_de_Usuarios)
                            resultDetalle_de_Folio_Asignado_de_Usuario = resultDetalle_de_Folio_Asignado_de_Usuario
                                              && _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer.Delete(Detalle_de_Folio_Asignado_de_UsuarioItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Folio_Asignado_de_Usuario)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IUsuarioApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, UsuarioModel varUsuario)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IUsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var UsuarioInfo = new Usuario
                    {
                        Clave = varUsuario.Clave
                        ,Nombre = varUsuario.Nombre
                        ,Clave_de_Acceso = varUsuario.Clave_de_Acceso
                        ,Grupo_de_Usuario = varUsuario.Grupo_de_Usuario
                        ,Numero_de_Empleado = varUsuario.Numero_de_Empleado
                        ,Correo_Institucional = varUsuario.Correo_Institucional
                        ,CUIP = varUsuario.CUIP
                        ,Delegacion = varUsuario.Delegacion
                        ,Carga_de_Trabajo = varUsuario.Carga_de_Trabajo
                        ,Nombre_Remitente = varUsuario.Nombre_Remitente
                        ,Apellido_Paterno = varUsuario.Apellido_Paterno
                        ,Apellido_Materno = varUsuario.Apellido_Materno
                        ,Agencia = varUsuario.Agencia
                        ,Especialidad = varUsuario.Especialidad
                        ,ID_de_Dispositivo = varUsuario.ID_de_Dispositivo
                        ,ID_de_Huella = varUsuario.ID_de_Huella
                        ,Fotografia = varUsuario.Fotografia
                        ,Usuario_que_Registra = varUsuario.Usuario_que_Registra
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varUsuario.Fecha_de_Registro)) ? DateTime.ParseExact(varUsuario.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varUsuario.Hora_de_Registro
                        ,Estatus_de_Registro = varUsuario.Estatus_de_Registro

                    };

                    result = !IsNew ?
                        _IUsuarioApiConsumer.Update(UsuarioInfo, null, null).Resource.ToString() :
                         _IUsuarioApiConsumer.Insert(UsuarioInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_de_Folio_Asignado_de_Usuario(int MasterId, int referenceId, List<Detalle_de_Folio_Asignado_de_UsuarioGridModelPost> Detalle_de_Folio_Asignado_de_UsuarioItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Folio_Asignado_de_UsuarioData = _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Folio_Asignado_de_Usuario.Usuario=" + referenceId,"").Resource;
                if (Detalle_de_Folio_Asignado_de_UsuarioData == null || Detalle_de_Folio_Asignado_de_UsuarioData.Detalle_de_Folio_Asignado_de_Usuarios.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Folio_Asignado_de_UsuarioGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Folio_Asignado_de_Usuario in Detalle_de_Folio_Asignado_de_UsuarioData.Detalle_de_Folio_Asignado_de_Usuarios)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Folio_Asignado_de_Usuario Detalle_de_Folio_Asignado_de_Usuario1 = varDetalle_de_Folio_Asignado_de_Usuario;

                    if (Detalle_de_Folio_Asignado_de_UsuarioItems != null && Detalle_de_Folio_Asignado_de_UsuarioItems.Any(m => m.Clave == Detalle_de_Folio_Asignado_de_Usuario1.Clave))
                    {
                        modelDataToChange = Detalle_de_Folio_Asignado_de_UsuarioItems.FirstOrDefault(m => m.Clave == Detalle_de_Folio_Asignado_de_Usuario1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Folio_Asignado_de_Usuario.Usuario = MasterId;
                    var insertId = _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer.Insert(varDetalle_de_Folio_Asignado_de_Usuario,null,null).Resource;
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
        public ActionResult PostDetalle_de_Folio_Asignado_de_Usuario(List<Detalle_de_Folio_Asignado_de_UsuarioGridModelPost> Detalle_de_Folio_Asignado_de_UsuarioItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Folio_Asignado_de_Usuario(MasterId, referenceId, Detalle_de_Folio_Asignado_de_UsuarioItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Folio_Asignado_de_UsuarioItems != null && Detalle_de_Folio_Asignado_de_UsuarioItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Folio_Asignado_de_UsuarioItem in Detalle_de_Folio_Asignado_de_UsuarioItems)
                    {





                        //Removal Request
                        if (Detalle_de_Folio_Asignado_de_UsuarioItem.Removed)
                        {
                            result = result && _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer.Delete(Detalle_de_Folio_Asignado_de_UsuarioItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Folio_Asignado_de_UsuarioItem.Clave = 0;

                        var Detalle_de_Folio_Asignado_de_UsuarioData = new Detalle_de_Folio_Asignado_de_Usuario
                        {
                            Usuario = MasterId
                            ,Clave = Detalle_de_Folio_Asignado_de_UsuarioItem.Clave
                            ,Folio = Detalle_de_Folio_Asignado_de_UsuarioItem.Folio
                            ,Estatus_de_Folio = (Convert.ToInt32(Detalle_de_Folio_Asignado_de_UsuarioItem.Estatus_de_Folio) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Folio_Asignado_de_UsuarioItem.Estatus_de_Folio))
                            ,Fecha_de_Registro = (Detalle_de_Folio_Asignado_de_UsuarioItem.Fecha_de_Registro!= null) ? DateTime.ParseExact(Detalle_de_Folio_Asignado_de_UsuarioItem.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null

                        };

                        var resultId = Detalle_de_Folio_Asignado_de_UsuarioItem.Clave > 0
                           ? _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer.Update(Detalle_de_Folio_Asignado_de_UsuarioData,null,null).Resource
                           : _IDetalle_de_Folio_Asignado_de_UsuarioApiConsumer.Insert(Detalle_de_Folio_Asignado_de_UsuarioData,null,null).Resource;

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
        public ActionResult GetDetalle_de_Folio_Asignado_de_Usuario_Catalogo_de_Estatus_de_FolioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_de_Estatus_de_FolioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_de_Estatus_de_FolioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Catalogo_de_Estatus_de_Folio", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }




        /// <summary>
        /// Write Element Array of Usuario script
        /// </summary>
        /// <param name="oUsuarioElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew UsuarioModuleAttributeList)
        {
            for (int i = 0; i < UsuarioModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(UsuarioModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    UsuarioModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(UsuarioModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    UsuarioModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (UsuarioModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < UsuarioModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < UsuarioModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(UsuarioModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							UsuarioModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(UsuarioModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							UsuarioModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strUsuarioScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Usuario.js")))
            {
                strUsuarioScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Usuario element attributes
            string userChangeJson = jsSerialize.Serialize(UsuarioModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strUsuarioScript.IndexOf("inpuElementArray");
            string splittedString = strUsuarioScript.Substring(indexOfArray, strUsuarioScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(UsuarioModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (UsuarioModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strUsuarioScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strUsuarioScript.Substring(indexOfArrayHistory, strUsuarioScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strUsuarioScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strUsuarioScript.Substring(endIndexOfMainElement + indexOfArray, strUsuarioScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (UsuarioModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in UsuarioModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Usuario.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Usuario.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Usuario.js")))
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
        public ActionResult UsuarioPropertyBag()
        {
            return PartialView("UsuarioPropertyBag", "Usuario");
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
        public ActionResult AddDetalle_de_Folio_Asignado_de_Usuario(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Folio_Asignado_de_Usuario/AddDetalle_de_Folio_Asignado_de_Usuario");
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
                var whereClauseFormat = "Object = 45040 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IUsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Usuario.Clave= " + RecordId;
                            var result = _IUsuarioApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IUsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new UsuarioPropertyMapper());
			
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
                    (UsuarioAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            UsuarioPropertyMapper oUsuarioPropertyMapper = new UsuarioPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oUsuarioPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IUsuarioApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Usuarios == null)
                result.Usuarios = new List<Usuario>();

            var data = result.Usuarios.Select(m => new UsuarioGridModel
            {
                Clave = m.Clave
                        ,NombreName = CultureHelper.GetTraduction(m.Nombre_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Nombre_Spartan_User.Name
			,Clave_de_Acceso = m.Clave_de_Acceso
			,Grupo_de_Usuario = m.Grupo_de_Usuario
			,Numero_de_Empleado = m.Numero_de_Empleado
			,Correo_Institucional = m.Correo_Institucional
			,CUIP = m.CUIP
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
			,Carga_de_Trabajo = m.Carga_de_Trabajo
			,Nombre_Remitente = m.Nombre_Remitente
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad_MP.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad_MP.Descripcion
			,ID_de_Dispositivo = m.ID_de_Dispositivo
			,ID_de_Huella = m.ID_de_Huella
			,Fotografia = m.Fotografia
			,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
			,Estatus_de_Registro = m.Estatus_de_Registro

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45040, arrayColumnsVisible), "UsuarioList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45040, arrayColumnsVisible), "UsuarioList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45040, arrayColumnsVisible), "UsuarioList_" + DateTime.Now.ToString());
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

            _IUsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new UsuarioPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (UsuarioAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            UsuarioPropertyMapper oUsuarioPropertyMapper = new UsuarioPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oUsuarioPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IUsuarioApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Usuarios == null)
                result.Usuarios = new List<Usuario>();

            var data = result.Usuarios.Select(m => new UsuarioGridModel
            {
                Clave = m.Clave
                        ,NombreName = CultureHelper.GetTraduction(m.Nombre_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Nombre_Spartan_User.Name
			,Clave_de_Acceso = m.Clave_de_Acceso
			,Grupo_de_Usuario = m.Grupo_de_Usuario
			,Numero_de_Empleado = m.Numero_de_Empleado
			,Correo_Institucional = m.Correo_Institucional
			,CUIP = m.CUIP
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
			,Carga_de_Trabajo = m.Carga_de_Trabajo
			,Nombre_Remitente = m.Nombre_Remitente
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad_MP.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad_MP.Descripcion
			,ID_de_Dispositivo = m.ID_de_Dispositivo
			,ID_de_Huella = m.ID_de_Huella
			,Fotografia = m.Fotografia
			,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
			,Estatus_de_Registro = m.Estatus_de_Registro

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
                _IUsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUsuarioApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Usuario_Datos_GeneralesModel varUsuario)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Usuario_Datos_GeneralesInfo = new Usuario_Datos_Generales
                {
                    Clave = varUsuario.Clave
                                            ,Nombre = varUsuario.Nombre
                        ,Clave_de_Acceso = varUsuario.Clave_de_Acceso
                        ,Grupo_de_Usuario = varUsuario.Grupo_de_Usuario
                        ,Numero_de_Empleado = varUsuario.Numero_de_Empleado
                        ,Correo_Institucional = varUsuario.Correo_Institucional
                        ,CUIP = varUsuario.CUIP
                        ,Delegacion = varUsuario.Delegacion
                        ,Carga_de_Trabajo = varUsuario.Carga_de_Trabajo
                        ,Nombre_Remitente = varUsuario.Nombre_Remitente
                        ,Apellido_Paterno = varUsuario.Apellido_Paterno
                        ,Apellido_Materno = varUsuario.Apellido_Materno
                        ,Agencia = varUsuario.Agencia
                        ,Especialidad = varUsuario.Especialidad
                        ,ID_de_Dispositivo = varUsuario.ID_de_Dispositivo
                        ,ID_de_Huella = varUsuario.ID_de_Huella
                        ,Fotografia = varUsuario.Fotografia
                        ,Usuario_que_Registra = varUsuario.Usuario_que_Registra
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varUsuario.Fecha_de_Registro)) ? DateTime.ParseExact(varUsuario.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varUsuario.Hora_de_Registro
                        ,Estatus_de_Registro = varUsuario.Estatus_de_Registro
                    
                };

                result = _IUsuarioApiConsumer.Update_Datos_Generales(Usuario_Datos_GeneralesInfo).Resource.ToString();
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
                _IUsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IUsuarioApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Folio_Asignado_de_Usuario;
                var Detalle_de_Folio_Asignado_de_UsuarioData = GetDetalle_de_Folio_Asignado_de_UsuarioData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Folio_Asignado_de_Usuario);

                var result = new Usuario_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Nombre = m.Nombre
                        ,NombreName = CultureHelper.GetTraduction(m.Nombre_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Nombre_Spartan_User.Name
			,Clave_de_Acceso = m.Clave_de_Acceso
			,Grupo_de_Usuario = m.Grupo_de_Usuario
			,Numero_de_Empleado = m.Numero_de_Empleado
			,Correo_Institucional = m.Correo_Institucional
			,CUIP = m.CUIP
                        ,Delegacion = m.Delegacion
                        ,DelegacionDescripcion = CultureHelper.GetTraduction(m.Delegacion_Delegacion.Clave.ToString(), "Descripcion") ?? (string)m.Delegacion_Delegacion.Descripcion
			,Carga_de_Trabajo = m.Carga_de_Trabajo
			,Nombre_Remitente = m.Nombre_Remitente
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Agencia = m.Agencia
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia.ClaveID.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia.Descripcion
                        ,Especialidad = m.Especialidad
                        ,EspecialidadDescripcion = CultureHelper.GetTraduction(m.Especialidad_Especialidad_MP.Clave.ToString(), "Descripcion") ?? (string)m.Especialidad_Especialidad_MP.Descripcion
			,ID_de_Dispositivo = m.ID_de_Dispositivo
			,ID_de_Huella = m.ID_de_Huella
			,Fotografia = m.Fotografia
			,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
			,Estatus_de_Registro = m.Estatus_de_Registro

                    
                };
				var resultData = new
                {
                    data = result
                    ,Folios_Asignados = Detalle_de_Folio_Asignado_de_UsuarioData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

