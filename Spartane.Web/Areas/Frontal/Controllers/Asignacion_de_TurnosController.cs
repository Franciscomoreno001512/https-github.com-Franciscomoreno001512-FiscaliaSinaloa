using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Asignacion_de_Turnos;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Tipo_de_Atencion;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Tipo_de_Urgencia;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Estatus_de_Turno;
using Spartane.Core.Domain.Modulo;
using Spartane.Core.Domain.Motivo_Finalizacion_Turno;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Asignacion_de_Turnos;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Asignacion_de_Turnos;
using Spartane.Web.Areas.WebApiConsumer.Unidad;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Atencion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Urgencia;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Turno;
using Spartane.Web.Areas.WebApiConsumer.Modulo;
using Spartane.Web.Areas.WebApiConsumer.Motivo_Finalizacion_Turno;

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
using Spartane.Web.Areas.WebApiConsumer.SpartaneQuery;

namespace Spartane.Web.Areas.Frontal.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class Asignacion_de_TurnosController : Controller
    {
        #region "variable declaration"

        private IAsignacion_de_TurnosService service = null;
        private IAsignacion_de_TurnosApiConsumer _IAsignacion_de_TurnosApiConsumer;
        private IUnidadApiConsumer _IUnidadApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IGeneroApiConsumer _IGeneroApiConsumer;
        private ITipo_de_AtencionApiConsumer _ITipo_de_AtencionApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private ITipo_de_UrgenciaApiConsumer _ITipo_de_UrgenciaApiConsumer;
        private IEstatus_de_TurnoApiConsumer _IEstatus_de_TurnoApiConsumer;
        private IModuloApiConsumer _IModuloApiConsumer;
        private IMotivo_Finalizacion_TurnoApiConsumer _IMotivo_Finalizacion_TurnoApiConsumer;

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
		private ISpartaneQueryApiConsumer _ISpartaneQueryApiConsumer;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Asignacion_de_TurnosController(IAsignacion_de_TurnosService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IAsignacion_de_TurnosApiConsumer Asignacion_de_TurnosApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IUnidadApiConsumer UnidadApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IGeneroApiConsumer GeneroApiConsumer , ITipo_de_AtencionApiConsumer Tipo_de_AtencionApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , ITipo_de_UrgenciaApiConsumer Tipo_de_UrgenciaApiConsumer , IEstatus_de_TurnoApiConsumer Estatus_de_TurnoApiConsumer , IModuloApiConsumer ModuloApiConsumer , IMotivo_Finalizacion_TurnoApiConsumer Motivo_Finalizacion_TurnoApiConsumer, ISpartaneQueryApiConsumer SpartaneQueryApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IAsignacion_de_TurnosApiConsumer = Asignacion_de_TurnosApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IUnidadApiConsumer = UnidadApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._ITipo_de_AtencionApiConsumer = Tipo_de_AtencionApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._ITipo_de_UrgenciaApiConsumer = Tipo_de_UrgenciaApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IEstatus_de_TurnoApiConsumer = Estatus_de_TurnoApiConsumer;
            this._IModuloApiConsumer = ModuloApiConsumer;
            this._IMotivo_Finalizacion_TurnoApiConsumer = Motivo_Finalizacion_TurnoApiConsumer;
			this._ISpartaneQueryApiConsumer = SpartaneQueryApiConsumer;
        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Asignacion_de_Turnos
        [ObjectAuth(ObjectId = (ModuleObjectId)45297, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45297, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Asignacion_de_Turnos/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45297, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45297, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varAsignacion_de_Turnos = new Asignacion_de_TurnosModel();
			varAsignacion_de_Turnos.Folio = Id;
			
            ViewBag.ObjectId = "45297";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Asignacion_de_TurnossData = _IAsignacion_de_TurnosApiConsumer.ListaSelAll(0, 1000, "Asignacion_de_Turnos.Folio=" + Id, "").Resource.Asignacion_de_Turnoss;
				
				if (Asignacion_de_TurnossData != null && Asignacion_de_TurnossData.Count > 0)
                {
					var Asignacion_de_TurnosData = Asignacion_de_TurnossData.First();
					varAsignacion_de_Turnos= new Asignacion_de_TurnosModel
					{
						Folio  = Asignacion_de_TurnosData.Folio 
	                    ,Fecha_de_Turno = (Asignacion_de_TurnosData.Fecha_de_Turno == null ? string.Empty : Convert.ToDateTime(Asignacion_de_TurnosData.Fecha_de_Turno).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Turno = Asignacion_de_TurnosData.Hora_de_Turno
                    ,Numero_de_Turno = Asignacion_de_TurnosData.Numero_de_Turno
                    ,Unidad_de_Atencion = Asignacion_de_TurnosData.Unidad_de_Atencion
                    ,Unidad_de_AtencionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Unidad_de_Atencion), "Unidad") ??  (string)Asignacion_de_TurnosData.Unidad_de_Atencion_Unidad.Descripcion
                    ,Recepcion = Asignacion_de_TurnosData.Recepcion
                    ,RecepcionName = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Recepcion), "Spartan_User") ??  (string)Asignacion_de_TurnosData.Recepcion_Spartan_User.Name
                    ,Nombres = Asignacion_de_TurnosData.Nombres
                    ,Apellido_Paterno = Asignacion_de_TurnosData.Apellido_Paterno
                    ,Apellido_Materno = Asignacion_de_TurnosData.Apellido_Materno
                    ,Nombre_Completo = Asignacion_de_TurnosData.Nombre_Completo
                    ,Sexo = Asignacion_de_TurnosData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Sexo), "Genero") ??  (string)Asignacion_de_TurnosData.Sexo_Genero.Descripcion
                    ,Edad = Asignacion_de_TurnosData.Edad
                    ,Tipo_de_Atencion = Asignacion_de_TurnosData.Tipo_de_Atencion
                    ,Tipo_de_AtencionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Tipo_de_Atencion), "Tipo_de_Atencion") ??  (string)Asignacion_de_TurnosData.Tipo_de_Atencion_Tipo_de_Atencion.Descripcion
                    ,Tipo_de_Identificacion = Asignacion_de_TurnosData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Asignacion_de_TurnosData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Asignacion_de_TurnosData.Numero_de_Identificacion
                    ,Urgencia = Asignacion_de_TurnosData.Urgencia.GetValueOrDefault()
                    ,Tipo_de_Urgencia = Asignacion_de_TurnosData.Tipo_de_Urgencia
                    ,Tipo_de_UrgenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Tipo_de_Urgencia), "Tipo_de_Urgencia") ??  (string)Asignacion_de_TurnosData.Tipo_de_Urgencia_Tipo_de_Urgencia.Descripcion
                    ,Orientador = Asignacion_de_TurnosData.Orientador
                    ,OrientadorName = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Orientador), "Spartan_User") ??  (string)Asignacion_de_TurnosData.Orientador_Spartan_User.Name
                    ,Estatus_de_Turno = Asignacion_de_TurnosData.Estatus_de_Turno
                    ,Estatus_de_TurnoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Estatus_de_Turno), "Estatus_de_Turno") ??  (string)Asignacion_de_TurnosData.Estatus_de_Turno_Estatus_de_Turno.Descripcion
                    ,Modulo = Asignacion_de_TurnosData.Modulo
                    ,ModuloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Modulo), "Modulo") ??  (string)Asignacion_de_TurnosData.Modulo_Modulo.Descripcion
                    ,Motivo_Finalizacion_Turno = Asignacion_de_TurnosData.Motivo_Finalizacion_Turno
                    ,Motivo_Finalizacion_TurnoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Motivo_Finalizacion_Turno), "Motivo_Finalizacion_Turno") ??  (string)Asignacion_de_TurnosData.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Descripcion
                    ,Observaciones = Asignacion_de_TurnosData.Observaciones
                    ,Fecha_de_Asignacion = (Asignacion_de_TurnosData.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(Asignacion_de_TurnosData.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Asignacion = Asignacion_de_TurnosData.Hora_de_Asignacion
                    ,Fecha_de_Finalizacion = (Asignacion_de_TurnosData.Fecha_de_Finalizacion == null ? string.Empty : Convert.ToDateTime(Asignacion_de_TurnosData.Fecha_de_Finalizacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Finalizacion = Asignacion_de_TurnosData.Hora_de_Finalizacion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad_de_Atencion = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad_de_Atencion != null && Unidads_Unidad_de_Atencion.Resource != null)
                ViewBag.Unidads_Unidad_de_Atencion = Unidads_Unidad_de_Atencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Recepcion = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Recepcion != null && Spartan_Users_Recepcion.Resource != null)
                ViewBag.Spartan_Users_Recepcion = Spartan_Users_Recepcion.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AtencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Atencions_Tipo_de_Atencion = _ITipo_de_AtencionApiConsumer.SelAll(true);
            if (Tipo_de_Atencions_Tipo_de_Atencion != null && Tipo_de_Atencions_Tipo_de_Atencion.Resource != null)
                ViewBag.Tipo_de_Atencions_Tipo_de_Atencion = Tipo_de_Atencions_Tipo_de_Atencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Atencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_UrgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Urgencias_Tipo_de_Urgencia = _ITipo_de_UrgenciaApiConsumer.SelAll(true);
            if (Tipo_de_Urgencias_Tipo_de_Urgencia != null && Tipo_de_Urgencias_Tipo_de_Urgencia.Resource != null)
                ViewBag.Tipo_de_Urgencias_Tipo_de_Urgencia = Tipo_de_Urgencias_Tipo_de_Urgencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Urgencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Orientador = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Orientador != null && Spartan_Users_Orientador.Resource != null)
                ViewBag.Spartan_Users_Orientador = Spartan_Users_Orientador.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IEstatus_de_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Turnos_Estatus_de_Turno = _IEstatus_de_TurnoApiConsumer.SelAll(true);
            if (Estatus_de_Turnos_Estatus_de_Turno != null && Estatus_de_Turnos_Estatus_de_Turno.Resource != null)
                ViewBag.Estatus_de_Turnos_Estatus_de_Turno = Estatus_de_Turnos_Estatus_de_Turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Turno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModuloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulos_Modulo = _IModuloApiConsumer.SelAll(true);
            if (Modulos_Modulo != null && Modulos_Modulo.Resource != null)
                ViewBag.Modulos_Modulo = Modulos_Modulo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_Finalizacion_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = _IMotivo_Finalizacion_TurnoApiConsumer.SelAll(true);
            if (Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno != null && Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource != null)
                ViewBag.Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_Finalizacion_Turno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varAsignacion_de_Turnos);
        }
		
	[HttpGet]
        public ActionResult AddAsignacion_de_Turnos(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45297);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);
			Asignacion_de_TurnosModel varAsignacion_de_Turnos= new Asignacion_de_TurnosModel();


            if (id.ToString() != "0")
            {
                var Asignacion_de_TurnossData = _IAsignacion_de_TurnosApiConsumer.ListaSelAll(0, 1000, "Asignacion_de_Turnos.Folio=" + id, "").Resource.Asignacion_de_Turnoss;
				
				if (Asignacion_de_TurnossData != null && Asignacion_de_TurnossData.Count > 0)
                {
					var Asignacion_de_TurnosData = Asignacion_de_TurnossData.First();
					varAsignacion_de_Turnos= new Asignacion_de_TurnosModel
					{
						Folio  = Asignacion_de_TurnosData.Folio 
	                    ,Fecha_de_Turno = (Asignacion_de_TurnosData.Fecha_de_Turno == null ? string.Empty : Convert.ToDateTime(Asignacion_de_TurnosData.Fecha_de_Turno).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Turno = Asignacion_de_TurnosData.Hora_de_Turno
                    ,Numero_de_Turno = Asignacion_de_TurnosData.Numero_de_Turno
                    ,Unidad_de_Atencion = Asignacion_de_TurnosData.Unidad_de_Atencion
                    ,Unidad_de_AtencionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Unidad_de_Atencion), "Unidad") ??  (string)Asignacion_de_TurnosData.Unidad_de_Atencion_Unidad.Descripcion
                    ,Recepcion = Asignacion_de_TurnosData.Recepcion
                    ,RecepcionName = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Recepcion), "Spartan_User") ??  (string)Asignacion_de_TurnosData.Recepcion_Spartan_User.Name
                    ,Nombres = Asignacion_de_TurnosData.Nombres
                    ,Apellido_Paterno = Asignacion_de_TurnosData.Apellido_Paterno
                    ,Apellido_Materno = Asignacion_de_TurnosData.Apellido_Materno
                    ,Nombre_Completo = Asignacion_de_TurnosData.Nombre_Completo
                    ,Sexo = Asignacion_de_TurnosData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Sexo), "Genero") ??  (string)Asignacion_de_TurnosData.Sexo_Genero.Descripcion
                    ,Edad = Asignacion_de_TurnosData.Edad
                    ,Tipo_de_Atencion = Asignacion_de_TurnosData.Tipo_de_Atencion
                    ,Tipo_de_AtencionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Tipo_de_Atencion), "Tipo_de_Atencion") ??  (string)Asignacion_de_TurnosData.Tipo_de_Atencion_Tipo_de_Atencion.Descripcion
                    ,Tipo_de_Identificacion = Asignacion_de_TurnosData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Asignacion_de_TurnosData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Asignacion_de_TurnosData.Numero_de_Identificacion
                    ,Urgencia = Asignacion_de_TurnosData.Urgencia.GetValueOrDefault()
                    ,Tipo_de_Urgencia = Asignacion_de_TurnosData.Tipo_de_Urgencia
                    ,Tipo_de_UrgenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Tipo_de_Urgencia), "Tipo_de_Urgencia") ??  (string)Asignacion_de_TurnosData.Tipo_de_Urgencia_Tipo_de_Urgencia.Descripcion
                    ,Orientador = Asignacion_de_TurnosData.Orientador
                    ,OrientadorName = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Orientador), "Spartan_User") ??  (string)Asignacion_de_TurnosData.Orientador_Spartan_User.Name
                    ,Estatus_de_Turno = Asignacion_de_TurnosData.Estatus_de_Turno
                    ,Estatus_de_TurnoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Estatus_de_Turno), "Estatus_de_Turno") ??  (string)Asignacion_de_TurnosData.Estatus_de_Turno_Estatus_de_Turno.Descripcion
                    ,Modulo = Asignacion_de_TurnosData.Modulo
                    ,ModuloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Modulo), "Modulo") ??  (string)Asignacion_de_TurnosData.Modulo_Modulo.Descripcion
                    ,Motivo_Finalizacion_Turno = Asignacion_de_TurnosData.Motivo_Finalizacion_Turno
                    ,Motivo_Finalizacion_TurnoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Asignacion_de_TurnosData.Motivo_Finalizacion_Turno), "Motivo_Finalizacion_Turno") ??  (string)Asignacion_de_TurnosData.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Descripcion
                    ,Observaciones = Asignacion_de_TurnosData.Observaciones
                    ,Fecha_de_Asignacion = (Asignacion_de_TurnosData.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(Asignacion_de_TurnosData.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Asignacion = Asignacion_de_TurnosData.Hora_de_Asignacion
                    ,Fecha_de_Finalizacion = (Asignacion_de_TurnosData.Fecha_de_Finalizacion == null ? string.Empty : Convert.ToDateTime(Asignacion_de_TurnosData.Fecha_de_Finalizacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Finalizacion = Asignacion_de_TurnosData.Hora_de_Finalizacion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad_de_Atencion = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad_de_Atencion != null && Unidads_Unidad_de_Atencion.Resource != null)
                ViewBag.Unidads_Unidad_de_Atencion = Unidads_Unidad_de_Atencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Recepcion = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Recepcion != null && Spartan_Users_Recepcion.Resource != null)
                ViewBag.Spartan_Users_Recepcion = Spartan_Users_Recepcion.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AtencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Atencions_Tipo_de_Atencion = _ITipo_de_AtencionApiConsumer.SelAll(true);
            if (Tipo_de_Atencions_Tipo_de_Atencion != null && Tipo_de_Atencions_Tipo_de_Atencion.Resource != null)
                ViewBag.Tipo_de_Atencions_Tipo_de_Atencion = Tipo_de_Atencions_Tipo_de_Atencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Atencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_UrgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Urgencias_Tipo_de_Urgencia = _ITipo_de_UrgenciaApiConsumer.SelAll(true);
            if (Tipo_de_Urgencias_Tipo_de_Urgencia != null && Tipo_de_Urgencias_Tipo_de_Urgencia.Resource != null)
                ViewBag.Tipo_de_Urgencias_Tipo_de_Urgencia = Tipo_de_Urgencias_Tipo_de_Urgencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Urgencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Orientador = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Orientador != null && Spartan_Users_Orientador.Resource != null)
                ViewBag.Spartan_Users_Orientador = Spartan_Users_Orientador.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IEstatus_de_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Turnos_Estatus_de_Turno = _IEstatus_de_TurnoApiConsumer.SelAll(true);
            if (Estatus_de_Turnos_Estatus_de_Turno != null && Estatus_de_Turnos_Estatus_de_Turno.Resource != null)
                ViewBag.Estatus_de_Turnos_Estatus_de_Turno = Estatus_de_Turnos_Estatus_de_Turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Turno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModuloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulos_Modulo = _IModuloApiConsumer.SelAll(true);
            if (Modulos_Modulo != null && Modulos_Modulo.Resource != null)
                ViewBag.Modulos_Modulo = Modulos_Modulo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_Finalizacion_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = _IMotivo_Finalizacion_TurnoApiConsumer.SelAll(true);
            if (Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno != null && Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource != null)
                ViewBag.Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_Finalizacion_Turno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddAsignacion_de_Turnos", varAsignacion_de_Turnos);
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
        public ActionResult GetUnidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUnidadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetGeneroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGeneroApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_AtencionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_AtencionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_AtencionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Atencion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_IdentificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_IdentificacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_UrgenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_UrgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_UrgenciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Urgencia", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatus_de_TurnoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_TurnoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Turno", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetModuloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModuloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModuloApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetMotivo_Finalizacion_TurnoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMotivo_Finalizacion_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMotivo_Finalizacion_TurnoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_Finalizacion_Turno", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Asignacion_de_TurnosAdvanceSearchModel model, int idFilter = -1)
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

            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad_de_Atencion = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad_de_Atencion != null && Unidads_Unidad_de_Atencion.Resource != null)
                ViewBag.Unidads_Unidad_de_Atencion = Unidads_Unidad_de_Atencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Recepcion = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Recepcion != null && Spartan_Users_Recepcion.Resource != null)
                ViewBag.Spartan_Users_Recepcion = Spartan_Users_Recepcion.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AtencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Atencions_Tipo_de_Atencion = _ITipo_de_AtencionApiConsumer.SelAll(true);
            if (Tipo_de_Atencions_Tipo_de_Atencion != null && Tipo_de_Atencions_Tipo_de_Atencion.Resource != null)
                ViewBag.Tipo_de_Atencions_Tipo_de_Atencion = Tipo_de_Atencions_Tipo_de_Atencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Atencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_UrgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Urgencias_Tipo_de_Urgencia = _ITipo_de_UrgenciaApiConsumer.SelAll(true);
            if (Tipo_de_Urgencias_Tipo_de_Urgencia != null && Tipo_de_Urgencias_Tipo_de_Urgencia.Resource != null)
                ViewBag.Tipo_de_Urgencias_Tipo_de_Urgencia = Tipo_de_Urgencias_Tipo_de_Urgencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Urgencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Orientador = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Orientador != null && Spartan_Users_Orientador.Resource != null)
                ViewBag.Spartan_Users_Orientador = Spartan_Users_Orientador.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IEstatus_de_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Turnos_Estatus_de_Turno = _IEstatus_de_TurnoApiConsumer.SelAll(true);
            if (Estatus_de_Turnos_Estatus_de_Turno != null && Estatus_de_Turnos_Estatus_de_Turno.Resource != null)
                ViewBag.Estatus_de_Turnos_Estatus_de_Turno = Estatus_de_Turnos_Estatus_de_Turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Turno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModuloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulos_Modulo = _IModuloApiConsumer.SelAll(true);
            if (Modulos_Modulo != null && Modulos_Modulo.Resource != null)
                ViewBag.Modulos_Modulo = Modulos_Modulo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_Finalizacion_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = _IMotivo_Finalizacion_TurnoApiConsumer.SelAll(true);
            if (Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno != null && Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource != null)
                ViewBag.Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_Finalizacion_Turno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad_de_Atencion = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad_de_Atencion != null && Unidads_Unidad_de_Atencion.Resource != null)
                ViewBag.Unidads_Unidad_de_Atencion = Unidads_Unidad_de_Atencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Recepcion = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Recepcion != null && Spartan_Users_Recepcion.Resource != null)
                ViewBag.Spartan_Users_Recepcion = Spartan_Users_Recepcion.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_AtencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Atencions_Tipo_de_Atencion = _ITipo_de_AtencionApiConsumer.SelAll(true);
            if (Tipo_de_Atencions_Tipo_de_Atencion != null && Tipo_de_Atencions_Tipo_de_Atencion.Resource != null)
                ViewBag.Tipo_de_Atencions_Tipo_de_Atencion = Tipo_de_Atencions_Tipo_de_Atencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Atencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_UrgenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Urgencias_Tipo_de_Urgencia = _ITipo_de_UrgenciaApiConsumer.SelAll(true);
            if (Tipo_de_Urgencias_Tipo_de_Urgencia != null && Tipo_de_Urgencias_Tipo_de_Urgencia.Resource != null)
                ViewBag.Tipo_de_Urgencias_Tipo_de_Urgencia = Tipo_de_Urgencias_Tipo_de_Urgencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Urgencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Orientador = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Orientador != null && Spartan_Users_Orientador.Resource != null)
                ViewBag.Spartan_Users_Orientador = Spartan_Users_Orientador.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IEstatus_de_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Turnos_Estatus_de_Turno = _IEstatus_de_TurnoApiConsumer.SelAll(true);
            if (Estatus_de_Turnos_Estatus_de_Turno != null && Estatus_de_Turnos_Estatus_de_Turno.Resource != null)
                ViewBag.Estatus_de_Turnos_Estatus_de_Turno = Estatus_de_Turnos_Estatus_de_Turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Turno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModuloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulos_Modulo = _IModuloApiConsumer.SelAll(true);
            if (Modulos_Modulo != null && Modulos_Modulo.Resource != null)
                ViewBag.Modulos_Modulo = Modulos_Modulo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMotivo_Finalizacion_TurnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = _IMotivo_Finalizacion_TurnoApiConsumer.SelAll(true);
            if (Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno != null && Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource != null)
                ViewBag.Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno = Motivo_Finalizacion_Turnos_Motivo_Finalizacion_Turno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Motivo_Finalizacion_Turno", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Asignacion_de_TurnosAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Asignacion_de_TurnosAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Asignacion_de_TurnosAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Asignacion_de_TurnosPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IAsignacion_de_TurnosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Asignacion_de_Turnoss == null)
                result.Asignacion_de_Turnoss = new List<Asignacion_de_Turnos>();

            return Json(new
            {
                data = result.Asignacion_de_Turnoss.Select(m => new Asignacion_de_TurnosGridModel
                    {
                    Folio = m.Folio
                        ,Fecha_de_Turno = (m.Fecha_de_Turno == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Turno).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Turno = m.Hora_de_Turno
			,Numero_de_Turno = m.Numero_de_Turno
                        ,Unidad_de_AtencionDescripcion = CultureHelper.GetTraduction(m.Unidad_de_Atencion_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_de_Atencion_Unidad.Descripcion
                        ,RecepcionName = CultureHelper.GetTraduction(m.Recepcion_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Recepcion_Spartan_User.Name
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
			,Edad = m.Edad
                        ,Tipo_de_AtencionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Atencion_Tipo_de_Atencion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Atencion_Tipo_de_Atencion.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Urgencia = m.Urgencia
                        ,Tipo_de_UrgenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Urgencia_Tipo_de_Urgencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Urgencia_Tipo_de_Urgencia.Descripcion
                        ,OrientadorName = CultureHelper.GetTraduction(m.Orientador_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Orientador_Spartan_User.Name
                        ,Estatus_de_TurnoDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Turno_Estatus_de_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Turno_Estatus_de_Turno.Descripcion
                        ,ModuloDescripcion = CultureHelper.GetTraduction(m.Modulo_Modulo.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Modulo.Descripcion
                        ,Motivo_Finalizacion_TurnoDescripcion = CultureHelper.GetTraduction(m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Descripcion
			,Observaciones = m.Observaciones
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Fecha_de_Finalizacion = (m.Fecha_de_Finalizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Finalizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Finalizacion = m.Hora_de_Finalizacion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetAsignacion_de_TurnosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAsignacion_de_TurnosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Folio), "Asignacion_de_Turnos", m.),
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
        /// Get List of Asignacion_de_Turnos from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Asignacion_de_Turnos Entity</returns>
        public ActionResult GetAsignacion_de_TurnosList(UrlParametersModel param)
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
            _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Asignacion_de_TurnosPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Asignacion_de_TurnosAdvanceSearchModel))
                {
					var advanceFilter =
                    (Asignacion_de_TurnosAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Asignacion_de_TurnosPropertyMapper oAsignacion_de_TurnosPropertyMapper = new Asignacion_de_TurnosPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oAsignacion_de_TurnosPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IAsignacion_de_TurnosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Asignacion_de_Turnoss == null)
                result.Asignacion_de_Turnoss = new List<Asignacion_de_Turnos>();

            return Json(new
            {
                aaData = result.Asignacion_de_Turnoss.Select(m => new Asignacion_de_TurnosGridModel
            {
                    Folio = m.Folio
                        ,Fecha_de_Turno = (m.Fecha_de_Turno == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Turno).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Turno = m.Hora_de_Turno
			,Numero_de_Turno = m.Numero_de_Turno
                        ,Unidad_de_AtencionDescripcion = CultureHelper.GetTraduction(m.Unidad_de_Atencion_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_de_Atencion_Unidad.Descripcion
                        ,RecepcionName = CultureHelper.GetTraduction(m.Recepcion_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Recepcion_Spartan_User.Name
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
			,Edad = m.Edad
                        ,Tipo_de_AtencionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Atencion_Tipo_de_Atencion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Atencion_Tipo_de_Atencion.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Urgencia = m.Urgencia
                        ,Tipo_de_UrgenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Urgencia_Tipo_de_Urgencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Urgencia_Tipo_de_Urgencia.Descripcion
                        ,OrientadorName = CultureHelper.GetTraduction(m.Orientador_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Orientador_Spartan_User.Name
                        ,Estatus_de_TurnoDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Turno_Estatus_de_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Turno_Estatus_de_Turno.Descripcion
                        ,ModuloDescripcion = CultureHelper.GetTraduction(m.Modulo_Modulo.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Modulo.Descripcion
                        ,Motivo_Finalizacion_TurnoDescripcion = CultureHelper.GetTraduction(m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Descripcion
			,Observaciones = m.Observaciones
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Fecha_de_Finalizacion = (m.Fecha_de_Finalizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Finalizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Finalizacion = m.Hora_de_Finalizacion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(Asignacion_de_TurnosAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromFolio) || !string.IsNullOrEmpty(filter.ToFolio))
            {
                if (!string.IsNullOrEmpty(filter.FromFolio))
                    where += " AND Asignacion_de_Turnos.Folio >= " + filter.FromFolio;
                if (!string.IsNullOrEmpty(filter.ToFolio))
                    where += " AND Asignacion_de_Turnos.Folio <= " + filter.ToFolio;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Turno) || !string.IsNullOrEmpty(filter.ToFecha_de_Turno))
            {
                var Fecha_de_TurnoFrom = DateTime.ParseExact(filter.FromFecha_de_Turno, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_TurnoTo = DateTime.ParseExact(filter.ToFecha_de_Turno, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Turno))
                    where += " AND Asignacion_de_Turnos.Fecha_de_Turno >= '" + Fecha_de_TurnoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Turno))
                    where += " AND Asignacion_de_Turnos.Fecha_de_Turno <= '" + Fecha_de_TurnoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Turno) || !string.IsNullOrEmpty(filter.ToHora_de_Turno))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Turno))
                    where += " AND Convert(TIME,Asignacion_de_Turnos.Hora_de_Turno) >='" + filter.FromHora_de_Turno + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Turno))
                    where += " AND Convert(TIME,Asignacion_de_Turnos.Hora_de_Turno) <='" + filter.ToHora_de_Turno + "'";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Turno))
            {
                switch (filter.Numero_de_TurnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Asignacion_de_Turnos.Numero_de_Turno LIKE '" + filter.Numero_de_Turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Asignacion_de_Turnos.Numero_de_Turno LIKE '%" + filter.Numero_de_Turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Asignacion_de_Turnos.Numero_de_Turno = '" + filter.Numero_de_Turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Asignacion_de_Turnos.Numero_de_Turno LIKE '%" + filter.Numero_de_Turno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUnidad_de_Atencion))
            {
                switch (filter.Unidad_de_AtencionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Unidad.Descripcion LIKE '" + filter.AdvanceUnidad_de_Atencion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.AdvanceUnidad_de_Atencion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Unidad.Descripcion = '" + filter.AdvanceUnidad_de_Atencion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.AdvanceUnidad_de_Atencion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUnidad_de_AtencionMultiple != null && filter.AdvanceUnidad_de_AtencionMultiple.Count() > 0)
            {
                var Unidad_de_AtencionIds = string.Join(",", filter.AdvanceUnidad_de_AtencionMultiple);

                where += " AND Asignacion_de_Turnos.Unidad_de_Atencion In (" + Unidad_de_AtencionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRecepcion))
            {
                switch (filter.RecepcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceRecepcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceRecepcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceRecepcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceRecepcion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRecepcionMultiple != null && filter.AdvanceRecepcionMultiple.Count() > 0)
            {
                var RecepcionIds = string.Join(",", filter.AdvanceRecepcionMultiple);

                where += " AND Asignacion_de_Turnos.Recepcion In (" + RecepcionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombres))
            {
                switch (filter.NombresFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Asignacion_de_Turnos.Nombres LIKE '" + filter.Nombres + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Asignacion_de_Turnos.Nombres LIKE '%" + filter.Nombres + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Asignacion_de_Turnos.Nombres = '" + filter.Nombres + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Asignacion_de_Turnos.Nombres LIKE '%" + filter.Nombres + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno))
            {
                switch (filter.Apellido_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Asignacion_de_Turnos.Apellido_Paterno LIKE '" + filter.Apellido_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Asignacion_de_Turnos.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Asignacion_de_Turnos.Apellido_Paterno = '" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Asignacion_de_Turnos.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno))
            {
                switch (filter.Apellido_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Asignacion_de_Turnos.Apellido_Materno LIKE '" + filter.Apellido_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Asignacion_de_Turnos.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Asignacion_de_Turnos.Apellido_Materno = '" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Asignacion_de_Turnos.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo))
            {
                switch (filter.Nombre_CompletoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Asignacion_de_Turnos.Nombre_Completo LIKE '" + filter.Nombre_Completo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Asignacion_de_Turnos.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Asignacion_de_Turnos.Nombre_Completo = '" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Asignacion_de_Turnos.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSexo))
            {
                switch (filter.SexoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Genero.Descripcion LIKE '" + filter.AdvanceSexo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Genero.Descripcion = '" + filter.AdvanceSexo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSexoMultiple != null && filter.AdvanceSexoMultiple.Count() > 0)
            {
                var SexoIds = string.Join(",", filter.AdvanceSexoMultiple);

                where += " AND Asignacion_de_Turnos.Sexo In (" + SexoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromEdad) || !string.IsNullOrEmpty(filter.ToEdad))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad))
                    where += " AND Asignacion_de_Turnos.Edad >= " + filter.FromEdad;
                if (!string.IsNullOrEmpty(filter.ToEdad))
                    where += " AND Asignacion_de_Turnos.Edad <= " + filter.ToEdad;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Atencion))
            {
                switch (filter.Tipo_de_AtencionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Atencion.Descripcion LIKE '" + filter.AdvanceTipo_de_Atencion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Atencion.Descripcion LIKE '%" + filter.AdvanceTipo_de_Atencion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Atencion.Descripcion = '" + filter.AdvanceTipo_de_Atencion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Atencion.Descripcion LIKE '%" + filter.AdvanceTipo_de_Atencion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_AtencionMultiple != null && filter.AdvanceTipo_de_AtencionMultiple.Count() > 0)
            {
                var Tipo_de_AtencionIds = string.Join(",", filter.AdvanceTipo_de_AtencionMultiple);

                where += " AND Asignacion_de_Turnos.Tipo_de_Atencion In (" + Tipo_de_AtencionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Identificacion))
            {
                switch (filter.Tipo_de_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '" + filter.AdvanceTipo_de_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Identificacion.Nombre = '" + filter.AdvanceTipo_de_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_IdentificacionMultiple != null && filter.AdvanceTipo_de_IdentificacionMultiple.Count() > 0)
            {
                var Tipo_de_IdentificacionIds = string.Join(",", filter.AdvanceTipo_de_IdentificacionMultiple);

                where += " AND Asignacion_de_Turnos.Tipo_de_Identificacion In (" + Tipo_de_IdentificacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Identificacion))
            {
                switch (filter.Numero_de_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Asignacion_de_Turnos.Numero_de_Identificacion LIKE '" + filter.Numero_de_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Asignacion_de_Turnos.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Asignacion_de_Turnos.Numero_de_Identificacion = '" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Asignacion_de_Turnos.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "%'";
                        break;
                }
            }

            if (filter.Urgencia != RadioOptions.NoApply)
                where += " AND Asignacion_de_Turnos.Urgencia = " + Convert.ToInt32(filter.Urgencia);

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Urgencia))
            {
                switch (filter.Tipo_de_UrgenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Urgencia.Descripcion LIKE '" + filter.AdvanceTipo_de_Urgencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Urgencia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Urgencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Urgencia.Descripcion = '" + filter.AdvanceTipo_de_Urgencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Urgencia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Urgencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_UrgenciaMultiple != null && filter.AdvanceTipo_de_UrgenciaMultiple.Count() > 0)
            {
                var Tipo_de_UrgenciaIds = string.Join(",", filter.AdvanceTipo_de_UrgenciaMultiple);

                where += " AND Asignacion_de_Turnos.Tipo_de_Urgencia In (" + Tipo_de_UrgenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceOrientador))
            {
                switch (filter.OrientadorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceOrientador + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceOrientador + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceOrientador + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceOrientador + "%'";
                        break;
                }
            }
            else if (filter.AdvanceOrientadorMultiple != null && filter.AdvanceOrientadorMultiple.Count() > 0)
            {
                var OrientadorIds = string.Join(",", filter.AdvanceOrientadorMultiple);

                where += " AND Asignacion_de_Turnos.Orientador In (" + OrientadorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus_de_Turno))
            {
                switch (filter.Estatus_de_TurnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_de_Turno.Descripcion LIKE '" + filter.AdvanceEstatus_de_Turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_de_Turno.Descripcion LIKE '%" + filter.AdvanceEstatus_de_Turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_de_Turno.Descripcion = '" + filter.AdvanceEstatus_de_Turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_de_Turno.Descripcion LIKE '%" + filter.AdvanceEstatus_de_Turno + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatus_de_TurnoMultiple != null && filter.AdvanceEstatus_de_TurnoMultiple.Count() > 0)
            {
                var Estatus_de_TurnoIds = string.Join(",", filter.AdvanceEstatus_de_TurnoMultiple);

                where += " AND Asignacion_de_Turnos.Estatus_de_Turno In (" + Estatus_de_TurnoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModulo))
            {
                switch (filter.ModuloFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo.Descripcion LIKE '" + filter.AdvanceModulo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo.Descripcion LIKE '%" + filter.AdvanceModulo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo.Descripcion = '" + filter.AdvanceModulo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo.Descripcion LIKE '%" + filter.AdvanceModulo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModuloMultiple != null && filter.AdvanceModuloMultiple.Count() > 0)
            {
                var ModuloIds = string.Join(",", filter.AdvanceModuloMultiple);

                where += " AND Asignacion_de_Turnos.Modulo In (" + ModuloIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMotivo_Finalizacion_Turno))
            {
                switch (filter.Motivo_Finalizacion_TurnoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Motivo_Finalizacion_Turno.Descripcion LIKE '" + filter.AdvanceMotivo_Finalizacion_Turno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Motivo_Finalizacion_Turno.Descripcion LIKE '%" + filter.AdvanceMotivo_Finalizacion_Turno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Motivo_Finalizacion_Turno.Descripcion = '" + filter.AdvanceMotivo_Finalizacion_Turno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Motivo_Finalizacion_Turno.Descripcion LIKE '%" + filter.AdvanceMotivo_Finalizacion_Turno + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMotivo_Finalizacion_TurnoMultiple != null && filter.AdvanceMotivo_Finalizacion_TurnoMultiple.Count() > 0)
            {
                var Motivo_Finalizacion_TurnoIds = string.Join(",", filter.AdvanceMotivo_Finalizacion_TurnoMultiple);

                where += " AND Asignacion_de_Turnos.Motivo_Finalizacion_Turno In (" + Motivo_Finalizacion_TurnoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Asignacion_de_Turnos.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Asignacion_de_Turnos.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Asignacion_de_Turnos.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Asignacion_de_Turnos.Observaciones LIKE '%" + filter.Observaciones + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Asignacion) || !string.IsNullOrEmpty(filter.ToFecha_de_Asignacion))
            {
                var Fecha_de_AsignacionFrom = DateTime.ParseExact(filter.FromFecha_de_Asignacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_AsignacionTo = DateTime.ParseExact(filter.ToFecha_de_Asignacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Asignacion))
                    where += " AND Asignacion_de_Turnos.Fecha_de_Asignacion >= '" + Fecha_de_AsignacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Asignacion))
                    where += " AND Asignacion_de_Turnos.Fecha_de_Asignacion <= '" + Fecha_de_AsignacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Asignacion) || !string.IsNullOrEmpty(filter.ToHora_de_Asignacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Asignacion))
                    where += " AND Convert(TIME,Asignacion_de_Turnos.Hora_de_Asignacion) >='" + filter.FromHora_de_Asignacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Asignacion))
                    where += " AND Convert(TIME,Asignacion_de_Turnos.Hora_de_Asignacion) <='" + filter.ToHora_de_Asignacion + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Finalizacion) || !string.IsNullOrEmpty(filter.ToFecha_de_Finalizacion))
            {
                var Fecha_de_FinalizacionFrom = DateTime.ParseExact(filter.FromFecha_de_Finalizacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_FinalizacionTo = DateTime.ParseExact(filter.ToFecha_de_Finalizacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Finalizacion))
                    where += " AND Asignacion_de_Turnos.Fecha_de_Finalizacion >= '" + Fecha_de_FinalizacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Finalizacion))
                    where += " AND Asignacion_de_Turnos.Fecha_de_Finalizacion <= '" + Fecha_de_FinalizacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Finalizacion) || !string.IsNullOrEmpty(filter.ToHora_de_Finalizacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Finalizacion))
                    where += " AND Convert(TIME,Asignacion_de_Turnos.Hora_de_Finalizacion) >='" + filter.FromHora_de_Finalizacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Finalizacion))
                    where += " AND Convert(TIME,Asignacion_de_Turnos.Hora_de_Finalizacion) <='" + filter.ToHora_de_Finalizacion + "'";
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
                _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);

                Asignacion_de_Turnos varAsignacion_de_Turnos = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IAsignacion_de_TurnosApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Asignacion_de_TurnosModel varAsignacion_de_Turnos)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Asignacion_de_TurnosInfo = new Asignacion_de_Turnos
                    {
                        Folio = varAsignacion_de_Turnos.Folio
                        ,Fecha_de_Turno = (!String.IsNullOrEmpty(varAsignacion_de_Turnos.Fecha_de_Turno)) ? DateTime.ParseExact(varAsignacion_de_Turnos.Fecha_de_Turno, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Turno = varAsignacion_de_Turnos.Hora_de_Turno
                        ,Numero_de_Turno = varAsignacion_de_Turnos.Numero_de_Turno
                        ,Unidad_de_Atencion = varAsignacion_de_Turnos.Unidad_de_Atencion
                        ,Recepcion = varAsignacion_de_Turnos.Recepcion
                        ,Nombres = varAsignacion_de_Turnos.Nombres
                        ,Apellido_Paterno = varAsignacion_de_Turnos.Apellido_Paterno
                        ,Apellido_Materno = varAsignacion_de_Turnos.Apellido_Materno
                        ,Nombre_Completo = varAsignacion_de_Turnos.Nombre_Completo
                        ,Sexo = varAsignacion_de_Turnos.Sexo
                        ,Edad = varAsignacion_de_Turnos.Edad
                        ,Tipo_de_Atencion = varAsignacion_de_Turnos.Tipo_de_Atencion
                        ,Tipo_de_Identificacion = varAsignacion_de_Turnos.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varAsignacion_de_Turnos.Numero_de_Identificacion
                        ,Urgencia = varAsignacion_de_Turnos.Urgencia
                        ,Tipo_de_Urgencia = varAsignacion_de_Turnos.Tipo_de_Urgencia
                        ,Orientador = varAsignacion_de_Turnos.Orientador
                        ,Estatus_de_Turno = varAsignacion_de_Turnos.Estatus_de_Turno
                        ,Modulo = varAsignacion_de_Turnos.Modulo
                        ,Motivo_Finalizacion_Turno = varAsignacion_de_Turnos.Motivo_Finalizacion_Turno
                        ,Observaciones = varAsignacion_de_Turnos.Observaciones
                        ,Fecha_de_Asignacion = (!String.IsNullOrEmpty(varAsignacion_de_Turnos.Fecha_de_Asignacion)) ? DateTime.ParseExact(varAsignacion_de_Turnos.Fecha_de_Asignacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Asignacion = varAsignacion_de_Turnos.Hora_de_Asignacion
                        ,Fecha_de_Finalizacion = (!String.IsNullOrEmpty(varAsignacion_de_Turnos.Fecha_de_Finalizacion)) ? DateTime.ParseExact(varAsignacion_de_Turnos.Fecha_de_Finalizacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Finalizacion = varAsignacion_de_Turnos.Hora_de_Finalizacion

                    };

                    result = !IsNew ?
                        _IAsignacion_de_TurnosApiConsumer.Update(Asignacion_de_TurnosInfo, null, null).Resource.ToString() :
                         _IAsignacion_de_TurnosApiConsumer.Insert(Asignacion_de_TurnosInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Asignacion_de_Turnos script
        /// </summary>
        /// <param name="oAsignacion_de_TurnosElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Asignacion_de_TurnosModuleAttributeList)
        {
            for (int i = 0; i < Asignacion_de_TurnosModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Asignacion_de_TurnosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Asignacion_de_TurnosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Asignacion_de_TurnosModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Asignacion_de_TurnosModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Asignacion_de_TurnosModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Asignacion_de_TurnosModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Asignacion_de_TurnosModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Asignacion_de_TurnosModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Asignacion_de_TurnosModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Asignacion_de_TurnosModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Asignacion_de_TurnosModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strAsignacion_de_TurnosScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Asignacion_de_Turnos.js")))
            {
                strAsignacion_de_TurnosScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Asignacion_de_Turnos element attributes
            string userChangeJson = jsSerialize.Serialize(Asignacion_de_TurnosModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strAsignacion_de_TurnosScript.IndexOf("inpuElementArray");
            string splittedString = strAsignacion_de_TurnosScript.Substring(indexOfArray, strAsignacion_de_TurnosScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Asignacion_de_TurnosModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Asignacion_de_TurnosModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strAsignacion_de_TurnosScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strAsignacion_de_TurnosScript.Substring(indexOfArrayHistory, strAsignacion_de_TurnosScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strAsignacion_de_TurnosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strAsignacion_de_TurnosScript.Substring(endIndexOfMainElement + indexOfArray, strAsignacion_de_TurnosScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Asignacion_de_TurnosModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Asignacion_de_TurnosModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Asignacion_de_Turnos.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Asignacion_de_Turnos.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Asignacion_de_Turnos.js")))
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
        public ActionResult Asignacion_de_TurnosPropertyBag()
        {
            return PartialView("Asignacion_de_TurnosPropertyBag", "Asignacion_de_Turnos");
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
                var whereClauseFormat = "Object = 45297 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Asignacion_de_Turnos.Folio= " + RecordId;
                            var result = _IAsignacion_de_TurnosApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Asignacion_de_TurnosPropertyMapper());
			
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
                    (Asignacion_de_TurnosAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Asignacion_de_TurnosPropertyMapper oAsignacion_de_TurnosPropertyMapper = new Asignacion_de_TurnosPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oAsignacion_de_TurnosPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IAsignacion_de_TurnosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Asignacion_de_Turnoss == null)
                result.Asignacion_de_Turnoss = new List<Asignacion_de_Turnos>();

            var data = result.Asignacion_de_Turnoss.Select(m => new Asignacion_de_TurnosGridModel
            {
                Folio = m.Folio
                        ,Fecha_de_Turno = (m.Fecha_de_Turno == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Turno).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Turno = m.Hora_de_Turno
			,Numero_de_Turno = m.Numero_de_Turno
                        ,Unidad_de_AtencionDescripcion = CultureHelper.GetTraduction(m.Unidad_de_Atencion_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_de_Atencion_Unidad.Descripcion
                        ,RecepcionName = CultureHelper.GetTraduction(m.Recepcion_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Recepcion_Spartan_User.Name
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
			,Edad = m.Edad
                        ,Tipo_de_AtencionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Atencion_Tipo_de_Atencion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Atencion_Tipo_de_Atencion.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Urgencia = m.Urgencia
                        ,Tipo_de_UrgenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Urgencia_Tipo_de_Urgencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Urgencia_Tipo_de_Urgencia.Descripcion
                        ,OrientadorName = CultureHelper.GetTraduction(m.Orientador_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Orientador_Spartan_User.Name
                        ,Estatus_de_TurnoDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Turno_Estatus_de_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Turno_Estatus_de_Turno.Descripcion
                        ,ModuloDescripcion = CultureHelper.GetTraduction(m.Modulo_Modulo.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Modulo.Descripcion
                        ,Motivo_Finalizacion_TurnoDescripcion = CultureHelper.GetTraduction(m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Descripcion
			,Observaciones = m.Observaciones
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Fecha_de_Finalizacion = (m.Fecha_de_Finalizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Finalizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Finalizacion = m.Hora_de_Finalizacion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45297, arrayColumnsVisible), "Asignacion_de_TurnosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45297, arrayColumnsVisible), "Asignacion_de_TurnosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45297, arrayColumnsVisible), "Asignacion_de_TurnosList_" + DateTime.Now.ToString());
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

            _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Asignacion_de_TurnosPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Asignacion_de_TurnosAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Asignacion_de_TurnosPropertyMapper oAsignacion_de_TurnosPropertyMapper = new Asignacion_de_TurnosPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oAsignacion_de_TurnosPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IAsignacion_de_TurnosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Asignacion_de_Turnoss == null)
                result.Asignacion_de_Turnoss = new List<Asignacion_de_Turnos>();

            var data = result.Asignacion_de_Turnoss.Select(m => new Asignacion_de_TurnosGridModel
            {
                Folio = m.Folio
                        ,Fecha_de_Turno = (m.Fecha_de_Turno == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Turno).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Turno = m.Hora_de_Turno
			,Numero_de_Turno = m.Numero_de_Turno
                        ,Unidad_de_AtencionDescripcion = CultureHelper.GetTraduction(m.Unidad_de_Atencion_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_de_Atencion_Unidad.Descripcion
                        ,RecepcionName = CultureHelper.GetTraduction(m.Recepcion_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Recepcion_Spartan_User.Name
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
			,Edad = m.Edad
                        ,Tipo_de_AtencionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Atencion_Tipo_de_Atencion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Atencion_Tipo_de_Atencion.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Urgencia = m.Urgencia
                        ,Tipo_de_UrgenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Urgencia_Tipo_de_Urgencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Urgencia_Tipo_de_Urgencia.Descripcion
                        ,OrientadorName = CultureHelper.GetTraduction(m.Orientador_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Orientador_Spartan_User.Name
                        ,Estatus_de_TurnoDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Turno_Estatus_de_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Turno_Estatus_de_Turno.Descripcion
                        ,ModuloDescripcion = CultureHelper.GetTraduction(m.Modulo_Modulo.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Modulo.Descripcion
                        ,Motivo_Finalizacion_TurnoDescripcion = CultureHelper.GetTraduction(m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Descripcion
			,Observaciones = m.Observaciones
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Fecha_de_Finalizacion = (m.Fecha_de_Finalizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Finalizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Finalizacion = m.Hora_de_Finalizacion

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
                _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAsignacion_de_TurnosApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Asignacion_de_Turnos_Datos_GeneralesModel varAsignacion_de_Turnos)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Asignacion_de_Turnos_Datos_GeneralesInfo = new Asignacion_de_Turnos_Datos_Generales
                {
                    Folio = varAsignacion_de_Turnos.Folio
                                            ,Fecha_de_Turno = (!String.IsNullOrEmpty(varAsignacion_de_Turnos.Fecha_de_Turno)) ? DateTime.ParseExact(varAsignacion_de_Turnos.Fecha_de_Turno, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Turno = varAsignacion_de_Turnos.Hora_de_Turno
                        ,Numero_de_Turno = varAsignacion_de_Turnos.Numero_de_Turno
                        ,Unidad_de_Atencion = varAsignacion_de_Turnos.Unidad_de_Atencion
                        ,Recepcion = varAsignacion_de_Turnos.Recepcion
                        ,Nombres = varAsignacion_de_Turnos.Nombres
                        ,Apellido_Paterno = varAsignacion_de_Turnos.Apellido_Paterno
                        ,Apellido_Materno = varAsignacion_de_Turnos.Apellido_Materno
                        ,Nombre_Completo = varAsignacion_de_Turnos.Nombre_Completo
                        ,Sexo = varAsignacion_de_Turnos.Sexo
                        ,Edad = varAsignacion_de_Turnos.Edad
                        ,Tipo_de_Atencion = varAsignacion_de_Turnos.Tipo_de_Atencion
                        ,Tipo_de_Identificacion = varAsignacion_de_Turnos.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varAsignacion_de_Turnos.Numero_de_Identificacion
                        ,Urgencia = varAsignacion_de_Turnos.Urgencia
                        ,Tipo_de_Urgencia = varAsignacion_de_Turnos.Tipo_de_Urgencia
                        ,Orientador = varAsignacion_de_Turnos.Orientador
                        ,Estatus_de_Turno = varAsignacion_de_Turnos.Estatus_de_Turno
                        ,Modulo = varAsignacion_de_Turnos.Modulo
                        ,Motivo_Finalizacion_Turno = varAsignacion_de_Turnos.Motivo_Finalizacion_Turno
                        ,Observaciones = varAsignacion_de_Turnos.Observaciones
                        ,Fecha_de_Asignacion = (!String.IsNullOrEmpty(varAsignacion_de_Turnos.Fecha_de_Asignacion)) ? DateTime.ParseExact(varAsignacion_de_Turnos.Fecha_de_Asignacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Asignacion = varAsignacion_de_Turnos.Hora_de_Asignacion
                        ,Fecha_de_Finalizacion = (!String.IsNullOrEmpty(varAsignacion_de_Turnos.Fecha_de_Finalizacion)) ? DateTime.ParseExact(varAsignacion_de_Turnos.Fecha_de_Finalizacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Finalizacion = varAsignacion_de_Turnos.Hora_de_Finalizacion
                    
                };

                result = _IAsignacion_de_TurnosApiConsumer.Update_Datos_Generales(Asignacion_de_Turnos_Datos_GeneralesInfo).Resource.ToString();
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
                _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IAsignacion_de_TurnosApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Asignacion_de_Turnos_Datos_GeneralesModel
                {
                    Folio = m.Folio
                        ,Fecha_de_Turno = (m.Fecha_de_Turno == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Turno).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Turno = m.Hora_de_Turno
			,Numero_de_Turno = m.Numero_de_Turno
                        ,Unidad_de_Atencion = m.Unidad_de_Atencion
                        ,Unidad_de_AtencionDescripcion = CultureHelper.GetTraduction(m.Unidad_de_Atencion_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_de_Atencion_Unidad.Descripcion
                        ,Recepcion = m.Recepcion
                        ,RecepcionName = CultureHelper.GetTraduction(m.Recepcion_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Recepcion_Spartan_User.Name
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
			,Edad = m.Edad
                        ,Tipo_de_Atencion = m.Tipo_de_Atencion
                        ,Tipo_de_AtencionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Atencion_Tipo_de_Atencion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Atencion_Tipo_de_Atencion.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Urgencia = m.Urgencia
                        ,Tipo_de_Urgencia = m.Tipo_de_Urgencia
                        ,Tipo_de_UrgenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Urgencia_Tipo_de_Urgencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Urgencia_Tipo_de_Urgencia.Descripcion
                        ,Orientador = m.Orientador
                        ,OrientadorName = CultureHelper.GetTraduction(m.Orientador_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Orientador_Spartan_User.Name
                        ,Estatus_de_Turno = m.Estatus_de_Turno
                        ,Estatus_de_TurnoDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Turno_Estatus_de_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Turno_Estatus_de_Turno.Descripcion
                        ,Modulo = m.Modulo
                        ,ModuloDescripcion = CultureHelper.GetTraduction(m.Modulo_Modulo.Clave.ToString(), "Descripcion") ?? (string)m.Modulo_Modulo.Descripcion
                        ,Motivo_Finalizacion_Turno = m.Motivo_Finalizacion_Turno
                        ,Motivo_Finalizacion_TurnoDescripcion = CultureHelper.GetTraduction(m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Clave.ToString(), "Descripcion") ?? (string)m.Motivo_Finalizacion_Turno_Motivo_Finalizacion_Turno.Descripcion
			,Observaciones = m.Observaciones
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Fecha_de_Finalizacion = (m.Fecha_de_Finalizacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Finalizacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Finalizacion = m.Hora_de_Finalizacion

                    
                };
				var resultData = new
                {
                    data = result

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
       }
public ActionResult FinalizarTurno(int Folio)
        {
            try
            {
                string query;

                if (Folio < 1)
                    return Json(null, JsonRequestBehavior.AllowGet);


                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartaneQueryApiConsumer.SetAuthHeader(_tokenManager.Token);

                query = String.Format("EXEC dbo.usp_SETFinalizarTurno  @Folio = {0}", Folio.ToString());

                var result = _ISpartaneQueryApiConsumer.ExecuteQuery(query) ;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException )
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
public ActionResult ToAssign(int orientador, int Folio)
        {
            try
            {
                string claveModulo = GetModuuloOrientador(orientador);
                string query;

                if (Folio < 1)
                    return Json(null, JsonRequestBehavior.AllowGet);

                if (claveModulo == "-1" || claveModulo == "")
                    return Json(null, JsonRequestBehavior.AllowGet);

                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartaneQueryApiConsumer.SetAuthHeader(_tokenManager.Token);

                query = String.Format("EXEC dbo.usp_SETAsignarTurno @Orientador = {0}, @Modulo = {1}, @Estatus = {2},     @Folio = {3}", (string)orientador.ToString(), claveModulo, "1", (string)Folio.ToString());


                var result = _ISpartaneQueryApiConsumer.ExecuteQuery(query);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
public ActionResult TurnoAsignado(int orientador)
        {
            try
            {
                string query;

                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartaneQueryApiConsumer.SetAuthHeader(_tokenManager.Token);

                query = String.Format("EXEC dbo.usp_GetTurnoAsignado @Orientador = {0}", orientador.ToString());

                var result = _ISpartaneQueryApiConsumer.ExecuteQuery(query);

                return Json((string)result.Resource, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
//ToAssignAsignacion_de_Turnos
        private string GetModuuloOrientador(int idUser)
        {
            string claveModulo ="-1";

            try
            {

                if (!_tokenManager.GenerateToken())
                {
                    throw new Exception("");
                }
                
                _ISpartaneQueryApiConsumer.SetAuthHeader(_tokenManager.Token);


                var result = _ISpartaneQueryApiConsumer.ExecuteQuery("SELECT Clave as 'ResourceId' FROM dbo.Modulo WHERE Orientador  = " + idUser);
                claveModulo = (string)result.Resource;
            }
            catch (Exception )
            {
                claveModulo = "-1";

            }

            return claveModulo;        
       }


    }
}

