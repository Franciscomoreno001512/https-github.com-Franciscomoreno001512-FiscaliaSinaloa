using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Resolucion_MP;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Estatus_de_Resolucion;
using Spartane.Core.Domain.Resolucion;
using Spartane.Core.Domain.Detalle_Vinculacion_Resolucion;





using Spartane.Core.Domain.Juzgado;
using Spartane.Core.Domain.Tipo_de_Judicializacion;
using Spartane.Core.Domain.Ano;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resolucion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Resolucion_MP;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Resolucion_MP;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Resolucion;
using Spartane.Web.Areas.WebApiConsumer.Resolucion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Vinculacion_Resolucion;



using Spartane.Web.Areas.WebApiConsumer.Juzgado;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Judicializacion;
using Spartane.Web.Areas.WebApiConsumer.Ano;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Resolucion;

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
    public class Resolucion_MPController : Controller
    {
        #region "variable declaration"

        private IResolucion_MPService service = null;
        private IResolucion_MPApiConsumer _IResolucion_MPApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IEstatus_de_ResolucionApiConsumer _IEstatus_de_ResolucionApiConsumer;
        private IResolucionApiConsumer _IResolucionApiConsumer;
        private IDetalle_Vinculacion_ResolucionApiConsumer _IDetalle_Vinculacion_ResolucionApiConsumer;



        private IJuzgadoApiConsumer _IJuzgadoApiConsumer;
        private ITipo_de_JudicializacionApiConsumer _ITipo_de_JudicializacionApiConsumer;
        private IAnoApiConsumer _IAnoApiConsumer;

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

        
        public Resolucion_MPController(IResolucion_MPService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IResolucion_MPApiConsumer Resolucion_MPApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IEstatus_de_ResolucionApiConsumer Estatus_de_ResolucionApiConsumer , IResolucionApiConsumer ResolucionApiConsumer , IDetalle_Vinculacion_ResolucionApiConsumer Detalle_Vinculacion_ResolucionApiConsumer  , IJuzgadoApiConsumer JuzgadoApiConsumer , ITipo_de_JudicializacionApiConsumer Tipo_de_JudicializacionApiConsumer , IAnoApiConsumer AnoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IResolucion_MPApiConsumer = Resolucion_MPApiConsumer;
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
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IEstatus_de_ResolucionApiConsumer = Estatus_de_ResolucionApiConsumer;
            this._IResolucionApiConsumer = ResolucionApiConsumer;
            this._IDetalle_Vinculacion_ResolucionApiConsumer = Detalle_Vinculacion_ResolucionApiConsumer;



            this._IJuzgadoApiConsumer = JuzgadoApiConsumer;
            this._ITipo_de_JudicializacionApiConsumer = Tipo_de_JudicializacionApiConsumer;
            this._IAnoApiConsumer = AnoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IResolucionApiConsumer = ResolucionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Resolucion_MP
        [ObjectAuth(ObjectId = (ModuleObjectId)45628, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45628, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Resolucion_MP/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45628, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45628, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varResolucion_MP = new Resolucion_MPModel();
			varResolucion_MP.Clave = Id;
			
            ViewBag.ObjectId = "45628";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_Vinculacion_Resolucion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45629, ModuleId);
            ViewBag.PermissionDetalle_Vinculacion_Resolucion = permissionDetalle_Vinculacion_Resolucion;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Resolucion_MPsData = _IResolucion_MPApiConsumer.ListaSelAll(0, 1000, "Resolucion_MP.Clave=" + Id, "").Resource.Resolucion_MPs;
				
				if (Resolucion_MPsData != null && Resolucion_MPsData.Count > 0)
                {
					var Resolucion_MPData = Resolucion_MPsData.First();
					varResolucion_MP= new Resolucion_MPModel
					{
						Clave  = Resolucion_MPData.Clave 
	                    ,Expediente_MP = Resolucion_MPData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Resolucion_MPData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Fecha_de_Resolucion = (Resolucion_MPData.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(Resolucion_MPData.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                    ,Persona_que_Resuelve = Resolucion_MPData.Persona_que_Resuelve
                    ,Persona_que_ResuelveName = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Persona_que_Resuelve), "Spartan_User") ??  (string)Resolucion_MPData.Persona_que_Resuelve_Spartan_User.Name
                    ,Estatus = Resolucion_MPData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Estatus), "Estatus_de_Resolucion") ??  (string)Resolucion_MPData.Estatus_Estatus_de_Resolucion.Descripcion
                    ,Resolucion = Resolucion_MPData.Resolucion
                    ,ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Resolucion), "Resolucion") ??  (string)Resolucion_MPData.Resolucion_Resolucion.Descripcion
                    ,Juzgado = Resolucion_MPData.Juzgado
                    ,JuzgadoNombre = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Juzgado), "Juzgado") ??  (string)Resolucion_MPData.Juzgado_Juzgado.Nombre
                    ,Tipo = Resolucion_MPData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Tipo), "Tipo_de_Judicializacion") ??  (string)Resolucion_MPData.Tipo_Tipo_de_Judicializacion.Descripcion
                    ,No__De_Causa_o_Cuadernillo = Resolucion_MPData.No__De_Causa_o_Cuadernillo
                    ,Ano_de_Causa_o_Cuadernillo = Resolucion_MPData.Ano_de_Causa_o_Cuadernillo
                    ,Ano_de_Causa_o_CuadernilloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Ano_de_Causa_o_Cuadernillo), "Ano") ??  (string)Resolucion_MPData.Ano_de_Causa_o_Cuadernillo_Ano.Descripcion
                    ,Observaciones = Resolucion_MPData.Observaciones
                    ,Fecha_de_Validacion = (Resolucion_MPData.Fecha_de_Validacion == null ? string.Empty : Convert.ToDateTime(Resolucion_MPData.Fecha_de_Validacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Validacion = Resolucion_MPData.Hora_de_Validacion
                    ,Dictaminador = Resolucion_MPData.Dictaminador
                    ,DictaminadorName = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Dictaminador), "Spartan_User") ??  (string)Resolucion_MPData.Dictaminador_Spartan_User.Name
                    ,Resultado_de_Validacion = Resolucion_MPData.Resultado_de_Validacion
                    ,Resultado_de_ValidacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Resultado_de_Validacion), "Resolucion") ??  (string)Resolucion_MPData.Resultado_de_Validacion_Resolucion.Descripcion
                    ,Observaciones_Dictaminador = Resolucion_MPData.Observaciones_Dictaminador

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Resolucions_Estatus = _IEstatus_de_ResolucionApiConsumer.SelAll(true);
            if (Estatus_de_Resolucions_Estatus != null && Estatus_de_Resolucions_Estatus.Resource != null)
                ViewBag.Estatus_de_Resolucions_Estatus = Estatus_de_Resolucions_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IJuzgadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Juzgados_Juzgado = _IJuzgadoApiConsumer.SelAll(true);
            if (Juzgados_Juzgado != null && Juzgados_Juzgado.Resource != null)
                ViewBag.Juzgados_Juzgado = Juzgados_Juzgado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Juzgado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Judicializacions_Tipo = _ITipo_de_JudicializacionApiConsumer.SelAll(true);
            if (Tipo_de_Judicializacions_Tipo != null && Tipo_de_Judicializacions_Tipo.Resource != null)
                ViewBag.Tipo_de_Judicializacions_Tipo = Tipo_de_Judicializacions_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Anos_Ano_de_Causa_o_Cuadernillo = _IAnoApiConsumer.SelAll(true);
            if (Anos_Ano_de_Causa_o_Cuadernillo != null && Anos_Ano_de_Causa_o_Cuadernillo.Resource != null)
                ViewBag.Anos_Ano_de_Causa_o_Cuadernillo = Anos_Ano_de_Causa_o_Cuadernillo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ano", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucions_Resultado_de_Validacion = _IResolucionApiConsumer.SelAll(true);
            if (Resolucions_Resultado_de_Validacion != null && Resolucions_Resultado_de_Validacion.Resource != null)
                ViewBag.Resolucions_Resultado_de_Validacion = Resolucions_Resultado_de_Validacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varResolucion_MP);
        }
		
	[HttpGet]
        public ActionResult AddResolucion_MP(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45628);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
			Resolucion_MPModel varResolucion_MP= new Resolucion_MPModel();
            var permissionDetalle_Vinculacion_Resolucion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45629, ModuleId);
            ViewBag.PermissionDetalle_Vinculacion_Resolucion = permissionDetalle_Vinculacion_Resolucion;


            if (id.ToString() != "0")
            {
                var Resolucion_MPsData = _IResolucion_MPApiConsumer.ListaSelAll(0, 1000, "Resolucion_MP.Clave=" + id, "").Resource.Resolucion_MPs;
				
				if (Resolucion_MPsData != null && Resolucion_MPsData.Count > 0)
                {
					var Resolucion_MPData = Resolucion_MPsData.First();
					varResolucion_MP= new Resolucion_MPModel
					{
						Clave  = Resolucion_MPData.Clave 
	                    ,Expediente_MP = Resolucion_MPData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Resolucion_MPData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Fecha_de_Resolucion = (Resolucion_MPData.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(Resolucion_MPData.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                    ,Persona_que_Resuelve = Resolucion_MPData.Persona_que_Resuelve
                    ,Persona_que_ResuelveName = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Persona_que_Resuelve), "Spartan_User") ??  (string)Resolucion_MPData.Persona_que_Resuelve_Spartan_User.Name
                    ,Estatus = Resolucion_MPData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Estatus), "Estatus_de_Resolucion") ??  (string)Resolucion_MPData.Estatus_Estatus_de_Resolucion.Descripcion
                    ,Resolucion = Resolucion_MPData.Resolucion
                    ,ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Resolucion), "Resolucion") ??  (string)Resolucion_MPData.Resolucion_Resolucion.Descripcion
                    ,Juzgado = Resolucion_MPData.Juzgado
                    ,JuzgadoNombre = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Juzgado), "Juzgado") ??  (string)Resolucion_MPData.Juzgado_Juzgado.Nombre
                    ,Tipo = Resolucion_MPData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Tipo), "Tipo_de_Judicializacion") ??  (string)Resolucion_MPData.Tipo_Tipo_de_Judicializacion.Descripcion
                    ,No__De_Causa_o_Cuadernillo = Resolucion_MPData.No__De_Causa_o_Cuadernillo
                    ,Ano_de_Causa_o_Cuadernillo = Resolucion_MPData.Ano_de_Causa_o_Cuadernillo
                    ,Ano_de_Causa_o_CuadernilloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Ano_de_Causa_o_Cuadernillo), "Ano") ??  (string)Resolucion_MPData.Ano_de_Causa_o_Cuadernillo_Ano.Descripcion
                    ,Observaciones = Resolucion_MPData.Observaciones
                    ,Fecha_de_Validacion = (Resolucion_MPData.Fecha_de_Validacion == null ? string.Empty : Convert.ToDateTime(Resolucion_MPData.Fecha_de_Validacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Validacion = Resolucion_MPData.Hora_de_Validacion
                    ,Dictaminador = Resolucion_MPData.Dictaminador
                    ,DictaminadorName = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Dictaminador), "Spartan_User") ??  (string)Resolucion_MPData.Dictaminador_Spartan_User.Name
                    ,Resultado_de_Validacion = Resolucion_MPData.Resultado_de_Validacion
                    ,Resultado_de_ValidacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Resolucion_MPData.Resultado_de_Validacion), "Resolucion") ??  (string)Resolucion_MPData.Resultado_de_Validacion_Resolucion.Descripcion
                    ,Observaciones_Dictaminador = Resolucion_MPData.Observaciones_Dictaminador

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Resolucions_Estatus = _IEstatus_de_ResolucionApiConsumer.SelAll(true);
            if (Estatus_de_Resolucions_Estatus != null && Estatus_de_Resolucions_Estatus.Resource != null)
                ViewBag.Estatus_de_Resolucions_Estatus = Estatus_de_Resolucions_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IJuzgadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Juzgados_Juzgado = _IJuzgadoApiConsumer.SelAll(true);
            if (Juzgados_Juzgado != null && Juzgados_Juzgado.Resource != null)
                ViewBag.Juzgados_Juzgado = Juzgados_Juzgado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Juzgado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Judicializacions_Tipo = _ITipo_de_JudicializacionApiConsumer.SelAll(true);
            if (Tipo_de_Judicializacions_Tipo != null && Tipo_de_Judicializacions_Tipo.Resource != null)
                ViewBag.Tipo_de_Judicializacions_Tipo = Tipo_de_Judicializacions_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Anos_Ano_de_Causa_o_Cuadernillo = _IAnoApiConsumer.SelAll(true);
            if (Anos_Ano_de_Causa_o_Cuadernillo != null && Anos_Ano_de_Causa_o_Cuadernillo.Resource != null)
                ViewBag.Anos_Ano_de_Causa_o_Cuadernillo = Anos_Ano_de_Causa_o_Cuadernillo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ano", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucions_Resultado_de_Validacion = _IResolucionApiConsumer.SelAll(true);
            if (Resolucions_Resultado_de_Validacion != null && Resolucions_Resultado_de_Validacion.Resource != null)
                ViewBag.Resolucions_Resultado_de_Validacion = Resolucions_Resultado_de_Validacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddResolucion_MP", varResolucion_MP);
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
        public ActionResult GetEstatus_de_ResolucionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_ResolucionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Resolucion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetResolucionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResolucionApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetJuzgadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJuzgadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IJuzgadoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Juzgado", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_JudicializacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_JudicializacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Judicializacion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetAnoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAnoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAnoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ano", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Resolucion_MPAdvanceSearchModel model, int idFilter = -1)
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

            _IEstatus_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Resolucions_Estatus = _IEstatus_de_ResolucionApiConsumer.SelAll(true);
            if (Estatus_de_Resolucions_Estatus != null && Estatus_de_Resolucions_Estatus.Resource != null)
                ViewBag.Estatus_de_Resolucions_Estatus = Estatus_de_Resolucions_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IJuzgadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Juzgados_Juzgado = _IJuzgadoApiConsumer.SelAll(true);
            if (Juzgados_Juzgado != null && Juzgados_Juzgado.Resource != null)
                ViewBag.Juzgados_Juzgado = Juzgados_Juzgado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Juzgado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Judicializacions_Tipo = _ITipo_de_JudicializacionApiConsumer.SelAll(true);
            if (Tipo_de_Judicializacions_Tipo != null && Tipo_de_Judicializacions_Tipo.Resource != null)
                ViewBag.Tipo_de_Judicializacions_Tipo = Tipo_de_Judicializacions_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Anos_Ano_de_Causa_o_Cuadernillo = _IAnoApiConsumer.SelAll(true);
            if (Anos_Ano_de_Causa_o_Cuadernillo != null && Anos_Ano_de_Causa_o_Cuadernillo.Resource != null)
                ViewBag.Anos_Ano_de_Causa_o_Cuadernillo = Anos_Ano_de_Causa_o_Cuadernillo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ano", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucions_Resultado_de_Validacion = _IResolucionApiConsumer.SelAll(true);
            if (Resolucions_Resultado_de_Validacion != null && Resolucions_Resultado_de_Validacion.Resource != null)
                ViewBag.Resolucions_Resultado_de_Validacion = Resolucions_Resultado_de_Validacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Resolucions_Estatus = _IEstatus_de_ResolucionApiConsumer.SelAll(true);
            if (Estatus_de_Resolucions_Estatus != null && Estatus_de_Resolucions_Estatus.Resource != null)
                ViewBag.Estatus_de_Resolucions_Estatus = Estatus_de_Resolucions_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IJuzgadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Juzgados_Juzgado = _IJuzgadoApiConsumer.SelAll(true);
            if (Juzgados_Juzgado != null && Juzgados_Juzgado.Resource != null)
                ViewBag.Juzgados_Juzgado = Juzgados_Juzgado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Juzgado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Judicializacions_Tipo = _ITipo_de_JudicializacionApiConsumer.SelAll(true);
            if (Tipo_de_Judicializacions_Tipo != null && Tipo_de_Judicializacions_Tipo.Resource != null)
                ViewBag.Tipo_de_Judicializacions_Tipo = Tipo_de_Judicializacions_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAnoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Anos_Ano_de_Causa_o_Cuadernillo = _IAnoApiConsumer.SelAll(true);
            if (Anos_Ano_de_Causa_o_Cuadernillo != null && Anos_Ano_de_Causa_o_Cuadernillo.Resource != null)
                ViewBag.Anos_Ano_de_Causa_o_Cuadernillo = Anos_Ano_de_Causa_o_Cuadernillo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ano", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucions_Resultado_de_Validacion = _IResolucionApiConsumer.SelAll(true);
            if (Resolucions_Resultado_de_Validacion != null && Resolucions_Resultado_de_Validacion.Resource != null)
                ViewBag.Resolucions_Resultado_de_Validacion = Resolucions_Resultado_de_Validacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Resolucion_MPAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Resolucion_MPAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Resolucion_MPAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Resolucion_MPPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IResolucion_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Resolucion_MPs == null)
                result.Resolucion_MPs = new List<Resolucion_MP>();

            return Json(new
            {
                data = result.Resolucion_MPs.Select(m => new Resolucion_MPGridModel
                    {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                        ,Persona_que_ResuelveName = CultureHelper.GetTraduction(m.Persona_que_Resuelve_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Persona_que_Resuelve_Spartan_User.Name
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Resolucion.Descripcion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resolucion_Resolucion.Descripcion
                        ,JuzgadoNombre = CultureHelper.GetTraduction(m.Juzgado_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_Juzgado.Nombre
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,No__De_Causa_o_Cuadernillo = m.No__De_Causa_o_Cuadernillo
                        ,Ano_de_Causa_o_CuadernilloDescripcion = CultureHelper.GetTraduction(m.Ano_de_Causa_o_Cuadernillo_Ano.Clave.ToString(), "Descripcion") ?? (string)m.Ano_de_Causa_o_Cuadernillo_Ano.Descripcion
			,Observaciones = m.Observaciones
                        ,Fecha_de_Validacion = (m.Fecha_de_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion = m.Hora_de_Validacion
                        ,DictaminadorName = CultureHelper.GetTraduction(m.Dictaminador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Dictaminador_Spartan_User.Name
                        ,Resultado_de_ValidacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Validacion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Validacion_Resolucion.Descripcion
			,Observaciones_Dictaminador = m.Observaciones_Dictaminador

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetResolucion_MPAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResolucion_MPApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Resolucion_MP", m.),
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
        /// Get List of Resolucion_MP from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Resolucion_MP Entity</returns>
        public ActionResult GetResolucion_MPList(UrlParametersModel param)
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
            _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Resolucion_MPPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Resolucion_MPAdvanceSearchModel))
                {
					var advanceFilter =
                    (Resolucion_MPAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Resolucion_MPPropertyMapper oResolucion_MPPropertyMapper = new Resolucion_MPPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oResolucion_MPPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IResolucion_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Resolucion_MPs == null)
                result.Resolucion_MPs = new List<Resolucion_MP>();

            return Json(new
            {
                aaData = result.Resolucion_MPs.Select(m => new Resolucion_MPGridModel
            {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                        ,Persona_que_ResuelveName = CultureHelper.GetTraduction(m.Persona_que_Resuelve_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Persona_que_Resuelve_Spartan_User.Name
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Resolucion.Descripcion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resolucion_Resolucion.Descripcion
                        ,JuzgadoNombre = CultureHelper.GetTraduction(m.Juzgado_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_Juzgado.Nombre
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,No__De_Causa_o_Cuadernillo = m.No__De_Causa_o_Cuadernillo
                        ,Ano_de_Causa_o_CuadernilloDescripcion = CultureHelper.GetTraduction(m.Ano_de_Causa_o_Cuadernillo_Ano.Clave.ToString(), "Descripcion") ?? (string)m.Ano_de_Causa_o_Cuadernillo_Ano.Descripcion
			,Observaciones = m.Observaciones
                        ,Fecha_de_Validacion = (m.Fecha_de_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion = m.Hora_de_Validacion
                        ,DictaminadorName = CultureHelper.GetTraduction(m.Dictaminador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Dictaminador_Spartan_User.Name
                        ,Resultado_de_ValidacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Validacion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Validacion_Resolucion.Descripcion
			,Observaciones_Dictaminador = m.Observaciones_Dictaminador

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetResolucion_MP_Expediente_MP_expediente_ministerio_publico(string query, string where)
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
        [HttpGet]
        public JsonResult GetResolucion_MP_Persona_que_Resuelve_Spartan_User(string query, string where)
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
        public JsonResult GetResolucion_MP_Resolucion_Resolucion(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Resolucion.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Resolucion.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IResolucionApiConsumer.ListaSelAll(1, 20,elWhere , " Resolucion.Descripcion ASC ").Resource;
               
                foreach (var item in result.Resolucions)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Resolucion", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Resolucions.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete

        [HttpGet]
        public JsonResult GetResolucion_MP_Dictaminador_Spartan_User(string query, string where)
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
        public string GetAdvanceFilter(Resolucion_MPAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Resolucion_MP.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Resolucion_MP.Clave <= " + filter.ToClave;
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

                where += " AND Resolucion_MP.Expediente_MP In (" + Expediente_MPIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Resolucion) || !string.IsNullOrEmpty(filter.ToFecha_de_Resolucion))
            {
                var Fecha_de_ResolucionFrom = DateTime.ParseExact(filter.FromFecha_de_Resolucion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_ResolucionTo = DateTime.ParseExact(filter.ToFecha_de_Resolucion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Resolucion))
                    where += " AND Resolucion_MP.Fecha_de_Resolucion >= '" + Fecha_de_ResolucionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Resolucion))
                    where += " AND Resolucion_MP.Fecha_de_Resolucion <= '" + Fecha_de_ResolucionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePersona_que_Resuelve))
            {
                switch (filter.Persona_que_ResuelveFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvancePersona_que_Resuelve + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvancePersona_que_Resuelve + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvancePersona_que_Resuelve + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvancePersona_que_Resuelve + "%'";
                        break;
                }
            }
            else if (filter.AdvancePersona_que_ResuelveMultiple != null && filter.AdvancePersona_que_ResuelveMultiple.Count() > 0)
            {
                var Persona_que_ResuelveIds = string.Join(",", filter.AdvancePersona_que_ResuelveMultiple);

                where += " AND Resolucion_MP.Persona_que_Resuelve In (" + Persona_que_ResuelveIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_de_Resolucion.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_de_Resolucion.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_de_Resolucion.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_de_Resolucion.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Resolucion_MP.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResolucion))
            {
                switch (filter.ResolucionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion.Descripcion LIKE '" + filter.AdvanceResolucion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion.Descripcion LIKE '%" + filter.AdvanceResolucion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion.Descripcion = '" + filter.AdvanceResolucion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion.Descripcion LIKE '%" + filter.AdvanceResolucion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResolucionMultiple != null && filter.AdvanceResolucionMultiple.Count() > 0)
            {
                var ResolucionIds = string.Join(",", filter.AdvanceResolucionMultiple);

                where += " AND Resolucion_MP.Resolucion In (" + ResolucionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceJuzgado))
            {
                switch (filter.JuzgadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Juzgado.Nombre LIKE '" + filter.AdvanceJuzgado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Juzgado.Nombre LIKE '%" + filter.AdvanceJuzgado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Juzgado.Nombre = '" + filter.AdvanceJuzgado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Juzgado.Nombre LIKE '%" + filter.AdvanceJuzgado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceJuzgadoMultiple != null && filter.AdvanceJuzgadoMultiple.Count() > 0)
            {
                var JuzgadoIds = string.Join(",", filter.AdvanceJuzgadoMultiple);

                where += " AND Resolucion_MP.Juzgado In (" + JuzgadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo))
            {
                switch (filter.TipoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Judicializacion.Descripcion LIKE '" + filter.AdvanceTipo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Judicializacion.Descripcion LIKE '%" + filter.AdvanceTipo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Judicializacion.Descripcion = '" + filter.AdvanceTipo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Judicializacion.Descripcion LIKE '%" + filter.AdvanceTipo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipoMultiple != null && filter.AdvanceTipoMultiple.Count() > 0)
            {
                var TipoIds = string.Join(",", filter.AdvanceTipoMultiple);

                where += " AND Resolucion_MP.Tipo In (" + TipoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromNo__De_Causa_o_Cuadernillo) || !string.IsNullOrEmpty(filter.ToNo__De_Causa_o_Cuadernillo))
            {
                if (!string.IsNullOrEmpty(filter.FromNo__De_Causa_o_Cuadernillo))
                    where += " AND Resolucion_MP.No__De_Causa_o_Cuadernillo >= " + filter.FromNo__De_Causa_o_Cuadernillo;
                if (!string.IsNullOrEmpty(filter.ToNo__De_Causa_o_Cuadernillo))
                    where += " AND Resolucion_MP.No__De_Causa_o_Cuadernillo <= " + filter.ToNo__De_Causa_o_Cuadernillo;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAno_de_Causa_o_Cuadernillo))
            {
                switch (filter.Ano_de_Causa_o_CuadernilloFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Ano.Descripcion LIKE '" + filter.AdvanceAno_de_Causa_o_Cuadernillo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Ano.Descripcion LIKE '%" + filter.AdvanceAno_de_Causa_o_Cuadernillo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Ano.Descripcion = '" + filter.AdvanceAno_de_Causa_o_Cuadernillo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Ano.Descripcion LIKE '%" + filter.AdvanceAno_de_Causa_o_Cuadernillo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAno_de_Causa_o_CuadernilloMultiple != null && filter.AdvanceAno_de_Causa_o_CuadernilloMultiple.Count() > 0)
            {
                var Ano_de_Causa_o_CuadernilloIds = string.Join(",", filter.AdvanceAno_de_Causa_o_CuadernilloMultiple);

                where += " AND Resolucion_MP.Ano_de_Causa_o_Cuadernillo In (" + Ano_de_Causa_o_CuadernilloIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion_MP.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion_MP.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion_MP.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion_MP.Observaciones LIKE '%" + filter.Observaciones + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Validacion) || !string.IsNullOrEmpty(filter.ToFecha_de_Validacion))
            {
                var Fecha_de_ValidacionFrom = DateTime.ParseExact(filter.FromFecha_de_Validacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_ValidacionTo = DateTime.ParseExact(filter.ToFecha_de_Validacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Validacion))
                    where += " AND Resolucion_MP.Fecha_de_Validacion >= '" + Fecha_de_ValidacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Validacion))
                    where += " AND Resolucion_MP.Fecha_de_Validacion <= '" + Fecha_de_ValidacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Validacion) || !string.IsNullOrEmpty(filter.ToHora_de_Validacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Validacion))
                    where += " AND Convert(TIME,Resolucion_MP.Hora_de_Validacion) >='" + filter.FromHora_de_Validacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Validacion))
                    where += " AND Convert(TIME,Resolucion_MP.Hora_de_Validacion) <='" + filter.ToHora_de_Validacion + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDictaminador))
            {
                switch (filter.DictaminadorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceDictaminador + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceDictaminador + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceDictaminador + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceDictaminador + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDictaminadorMultiple != null && filter.AdvanceDictaminadorMultiple.Count() > 0)
            {
                var DictaminadorIds = string.Join(",", filter.AdvanceDictaminadorMultiple);

                where += " AND Resolucion_MP.Dictaminador In (" + DictaminadorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResultado_de_Validacion))
            {
                switch (filter.Resultado_de_ValidacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion.Descripcion LIKE '" + filter.AdvanceResultado_de_Validacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion.Descripcion LIKE '%" + filter.AdvanceResultado_de_Validacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion.Descripcion = '" + filter.AdvanceResultado_de_Validacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion.Descripcion LIKE '%" + filter.AdvanceResultado_de_Validacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResultado_de_ValidacionMultiple != null && filter.AdvanceResultado_de_ValidacionMultiple.Count() > 0)
            {
                var Resultado_de_ValidacionIds = string.Join(",", filter.AdvanceResultado_de_ValidacionMultiple);

                where += " AND Resolucion_MP.Resultado_de_Validacion In (" + Resultado_de_ValidacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_Dictaminador))
            {
                switch (filter.Observaciones_DictaminadorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion_MP.Observaciones_Dictaminador LIKE '" + filter.Observaciones_Dictaminador + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion_MP.Observaciones_Dictaminador LIKE '%" + filter.Observaciones_Dictaminador + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion_MP.Observaciones_Dictaminador = '" + filter.Observaciones_Dictaminador + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion_MP.Observaciones_Dictaminador LIKE '%" + filter.Observaciones_Dictaminador + "%'";
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

        public ActionResult GetDetalle_Vinculacion_Resolucion(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Vinculacion_ResolucionGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Vinculacion_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Vinculacion_Resolucion.Resolucion=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Vinculacion_Resolucion.Resolucion='" + RelationId + "'";
            }
            var result = _IDetalle_Vinculacion_ResolucionApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Vinculacion_Resolucions == null)
                result.Detalle_Vinculacion_Resolucions = new List<Detalle_Vinculacion_Resolucion>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Vinculacion_Resolucions.Select(m => new Detalle_Vinculacion_ResolucionGridModel
                {
                    Clave = m.Clave

			,Seleccionar = m.Seleccionar
			,Relacion = m.Relacion
			,idRelacion = m.idRelacion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Vinculacion_ResolucionGridModel> GetDetalle_Vinculacion_ResolucionData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Vinculacion_ResolucionGridModel> resultData = new List<Detalle_Vinculacion_ResolucionGridModel>();
            string where = "Detalle_Vinculacion_Resolucion.Resolucion=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Vinculacion_Resolucion.Resolucion='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Vinculacion_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Vinculacion_ResolucionApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Vinculacion_Resolucions != null)
            {
                resultData = result.Detalle_Vinculacion_Resolucions.Select(m => new Detalle_Vinculacion_ResolucionGridModel
                    {
                        Clave = m.Clave

			,Seleccionar = m.Seleccionar
			,Relacion = m.Relacion
			,idRelacion = m.idRelacion


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
                _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

                Resolucion_MP varResolucion_MP = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_Vinculacion_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Vinculacion_Resolucion.Resolucion=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Vinculacion_Resolucion.Resolucion='" + id + "'";
                    }
                    var Detalle_Vinculacion_ResolucionInfo =
                        _IDetalle_Vinculacion_ResolucionApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Vinculacion_ResolucionInfo.Detalle_Vinculacion_Resolucions.Count > 0)
                    {
                        var resultDetalle_Vinculacion_Resolucion = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Vinculacion_ResolucionItem in Detalle_Vinculacion_ResolucionInfo.Detalle_Vinculacion_Resolucions)
                            resultDetalle_Vinculacion_Resolucion = resultDetalle_Vinculacion_Resolucion
                                              && _IDetalle_Vinculacion_ResolucionApiConsumer.Delete(Detalle_Vinculacion_ResolucionItem.Clave, null,null).Resource;

                        if (!resultDetalle_Vinculacion_Resolucion)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IResolucion_MPApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Resolucion_MPModel varResolucion_MP)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Resolucion_MPInfo = new Resolucion_MP
                    {
                        Clave = varResolucion_MP.Clave
                        ,Expediente_MP = varResolucion_MP.Expediente_MP
                        ,Fecha_de_Resolucion = (!String.IsNullOrEmpty(varResolucion_MP.Fecha_de_Resolucion)) ? DateTime.ParseExact(varResolucion_MP.Fecha_de_Resolucion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Persona_que_Resuelve = varResolucion_MP.Persona_que_Resuelve
                        ,Estatus = varResolucion_MP.Estatus
                        ,Resolucion = varResolucion_MP.Resolucion
                        ,Juzgado = varResolucion_MP.Juzgado
                        ,Tipo = varResolucion_MP.Tipo
                        ,No__De_Causa_o_Cuadernillo = varResolucion_MP.No__De_Causa_o_Cuadernillo
                        ,Ano_de_Causa_o_Cuadernillo = varResolucion_MP.Ano_de_Causa_o_Cuadernillo
                        ,Observaciones = varResolucion_MP.Observaciones
                        ,Fecha_de_Validacion = (!String.IsNullOrEmpty(varResolucion_MP.Fecha_de_Validacion)) ? DateTime.ParseExact(varResolucion_MP.Fecha_de_Validacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Validacion = varResolucion_MP.Hora_de_Validacion
                        ,Dictaminador = varResolucion_MP.Dictaminador
                        ,Resultado_de_Validacion = varResolucion_MP.Resultado_de_Validacion
                        ,Observaciones_Dictaminador = varResolucion_MP.Observaciones_Dictaminador

                    };

                    result = !IsNew ?
                        _IResolucion_MPApiConsumer.Update(Resolucion_MPInfo, null, null).Resource.ToString() :
                         _IResolucion_MPApiConsumer.Insert(Resolucion_MPInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Vinculacion_Resolucion(int MasterId, int referenceId, List<Detalle_Vinculacion_ResolucionGridModelPost> Detalle_Vinculacion_ResolucionItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Vinculacion_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Vinculacion_ResolucionData = _IDetalle_Vinculacion_ResolucionApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Vinculacion_Resolucion.Resolucion=" + referenceId,"").Resource;
                if (Detalle_Vinculacion_ResolucionData == null || Detalle_Vinculacion_ResolucionData.Detalle_Vinculacion_Resolucions.Count == 0)
                    return true;

                var result = true;

                Detalle_Vinculacion_ResolucionGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Vinculacion_Resolucion in Detalle_Vinculacion_ResolucionData.Detalle_Vinculacion_Resolucions)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Vinculacion_Resolucion Detalle_Vinculacion_Resolucion1 = varDetalle_Vinculacion_Resolucion;

                    if (Detalle_Vinculacion_ResolucionItems != null && Detalle_Vinculacion_ResolucionItems.Any(m => m.Clave == Detalle_Vinculacion_Resolucion1.Clave))
                    {
                        modelDataToChange = Detalle_Vinculacion_ResolucionItems.FirstOrDefault(m => m.Clave == Detalle_Vinculacion_Resolucion1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Vinculacion_Resolucion.Resolucion = MasterId;
                    var insertId = _IDetalle_Vinculacion_ResolucionApiConsumer.Insert(varDetalle_Vinculacion_Resolucion,null,null).Resource;
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
        public ActionResult PostDetalle_Vinculacion_Resolucion(List<Detalle_Vinculacion_ResolucionGridModelPost> Detalle_Vinculacion_ResolucionItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Vinculacion_Resolucion(MasterId, referenceId, Detalle_Vinculacion_ResolucionItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Vinculacion_ResolucionItems != null && Detalle_Vinculacion_ResolucionItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Vinculacion_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Vinculacion_ResolucionItem in Detalle_Vinculacion_ResolucionItems)
                    {





                        //Removal Request
                        if (Detalle_Vinculacion_ResolucionItem.Removed)
                        {
                            result = result && _IDetalle_Vinculacion_ResolucionApiConsumer.Delete(Detalle_Vinculacion_ResolucionItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Vinculacion_ResolucionItem.Clave = 0;

                        var Detalle_Vinculacion_ResolucionData = new Detalle_Vinculacion_Resolucion
                        {
                            Resolucion = MasterId
                            ,Clave = Detalle_Vinculacion_ResolucionItem.Clave
                            ,Seleccionar = Detalle_Vinculacion_ResolucionItem.Seleccionar
                            ,Relacion = Detalle_Vinculacion_ResolucionItem.Relacion
                            ,idRelacion = Detalle_Vinculacion_ResolucionItem.idRelacion

                        };

                        var resultId = Detalle_Vinculacion_ResolucionItem.Clave > 0
                           ? _IDetalle_Vinculacion_ResolucionApiConsumer.Update(Detalle_Vinculacion_ResolucionData,null,null).Resource
                           : _IDetalle_Vinculacion_ResolucionApiConsumer.Insert(Detalle_Vinculacion_ResolucionData,null,null).Resource;

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
        /// Write Element Array of Resolucion_MP script
        /// </summary>
        /// <param name="oResolucion_MPElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Resolucion_MPModuleAttributeList)
        {
            for (int i = 0; i < Resolucion_MPModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Resolucion_MPModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Resolucion_MPModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Resolucion_MPModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Resolucion_MPModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Resolucion_MPModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Resolucion_MPModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Resolucion_MPModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Resolucion_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Resolucion_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Resolucion_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Resolucion_MPModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strResolucion_MPScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Resolucion_MP.js")))
            {
                strResolucion_MPScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Resolucion_MP element attributes
            string userChangeJson = jsSerialize.Serialize(Resolucion_MPModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strResolucion_MPScript.IndexOf("inpuElementArray");
            string splittedString = strResolucion_MPScript.Substring(indexOfArray, strResolucion_MPScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Resolucion_MPModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Resolucion_MPModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strResolucion_MPScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strResolucion_MPScript.Substring(indexOfArrayHistory, strResolucion_MPScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strResolucion_MPScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strResolucion_MPScript.Substring(endIndexOfMainElement + indexOfArray, strResolucion_MPScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Resolucion_MPModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Resolucion_MPModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Resolucion_MP.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Resolucion_MP.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Resolucion_MP.js")))
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
        public ActionResult Resolucion_MPPropertyBag()
        {
            return PartialView("Resolucion_MPPropertyBag", "Resolucion_MP");
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
        public ActionResult AddDetalle_Vinculacion_Resolucion(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Vinculacion_Resolucion/AddDetalle_Vinculacion_Resolucion");
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
                var whereClauseFormat = "Object = 45628 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Resolucion_MP.Clave= " + RecordId;
                            var result = _IResolucion_MPApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Resolucion_MPPropertyMapper());
			
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
                    (Resolucion_MPAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Resolucion_MPPropertyMapper oResolucion_MPPropertyMapper = new Resolucion_MPPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oResolucion_MPPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IResolucion_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Resolucion_MPs == null)
                result.Resolucion_MPs = new List<Resolucion_MP>();

            var data = result.Resolucion_MPs.Select(m => new Resolucion_MPGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                        ,Persona_que_ResuelveName = CultureHelper.GetTraduction(m.Persona_que_Resuelve_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Persona_que_Resuelve_Spartan_User.Name
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Resolucion.Descripcion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resolucion_Resolucion.Descripcion
                        ,JuzgadoNombre = CultureHelper.GetTraduction(m.Juzgado_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_Juzgado.Nombre
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,No__De_Causa_o_Cuadernillo = m.No__De_Causa_o_Cuadernillo
                        ,Ano_de_Causa_o_CuadernilloDescripcion = CultureHelper.GetTraduction(m.Ano_de_Causa_o_Cuadernillo_Ano.Clave.ToString(), "Descripcion") ?? (string)m.Ano_de_Causa_o_Cuadernillo_Ano.Descripcion
			,Observaciones = m.Observaciones
                        ,Fecha_de_Validacion = (m.Fecha_de_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion = m.Hora_de_Validacion
                        ,DictaminadorName = CultureHelper.GetTraduction(m.Dictaminador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Dictaminador_Spartan_User.Name
                        ,Resultado_de_ValidacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Validacion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Validacion_Resolucion.Descripcion
			,Observaciones_Dictaminador = m.Observaciones_Dictaminador

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45628, arrayColumnsVisible), "Resolucion_MPList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45628, arrayColumnsVisible), "Resolucion_MPList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45628, arrayColumnsVisible), "Resolucion_MPList_" + DateTime.Now.ToString());
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

            _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Resolucion_MPPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Resolucion_MPAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Resolucion_MPPropertyMapper oResolucion_MPPropertyMapper = new Resolucion_MPPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oResolucion_MPPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IResolucion_MPApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Resolucion_MPs == null)
                result.Resolucion_MPs = new List<Resolucion_MP>();

            var data = result.Resolucion_MPs.Select(m => new Resolucion_MPGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                        ,Persona_que_ResuelveName = CultureHelper.GetTraduction(m.Persona_que_Resuelve_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Persona_que_Resuelve_Spartan_User.Name
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Resolucion.Descripcion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resolucion_Resolucion.Descripcion
                        ,JuzgadoNombre = CultureHelper.GetTraduction(m.Juzgado_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_Juzgado.Nombre
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,No__De_Causa_o_Cuadernillo = m.No__De_Causa_o_Cuadernillo
                        ,Ano_de_Causa_o_CuadernilloDescripcion = CultureHelper.GetTraduction(m.Ano_de_Causa_o_Cuadernillo_Ano.Clave.ToString(), "Descripcion") ?? (string)m.Ano_de_Causa_o_Cuadernillo_Ano.Descripcion
			,Observaciones = m.Observaciones
                        ,Fecha_de_Validacion = (m.Fecha_de_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion = m.Hora_de_Validacion
                        ,DictaminadorName = CultureHelper.GetTraduction(m.Dictaminador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Dictaminador_Spartan_User.Name
                        ,Resultado_de_ValidacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Validacion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Validacion_Resolucion.Descripcion
			,Observaciones_Dictaminador = m.Observaciones_Dictaminador

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
                _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResolucion_MPApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Resolucion_MP_Datos_GeneralesModel varResolucion_MP)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Resolucion_MP_Datos_GeneralesInfo = new Resolucion_MP_Datos_Generales
                {
                    Clave = varResolucion_MP.Clave
                                            ,Expediente_MP = varResolucion_MP.Expediente_MP
                        ,Fecha_de_Resolucion = (!String.IsNullOrEmpty(varResolucion_MP.Fecha_de_Resolucion)) ? DateTime.ParseExact(varResolucion_MP.Fecha_de_Resolucion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Persona_que_Resuelve = varResolucion_MP.Persona_que_Resuelve
                        ,Estatus = varResolucion_MP.Estatus
                        ,Resolucion = varResolucion_MP.Resolucion
                        ,Juzgado = varResolucion_MP.Juzgado
                        ,Tipo = varResolucion_MP.Tipo
                        ,No__De_Causa_o_Cuadernillo = varResolucion_MP.No__De_Causa_o_Cuadernillo
                        ,Ano_de_Causa_o_Cuadernillo = varResolucion_MP.Ano_de_Causa_o_Cuadernillo
                        ,Observaciones = varResolucion_MP.Observaciones
                    
                };

                result = _IResolucion_MPApiConsumer.Update_Datos_Generales(Resolucion_MP_Datos_GeneralesInfo).Resource.ToString();
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
                _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IResolucion_MPApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Vinculacion_Resolucion;
                var Detalle_Vinculacion_ResolucionData = GetDetalle_Vinculacion_ResolucionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Vinculacion_Resolucion);

                var result = new Resolucion_MP_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Expediente_MP = m.Expediente_MP
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                        ,Persona_que_Resuelve = m.Persona_que_Resuelve
                        ,Persona_que_ResuelveName = CultureHelper.GetTraduction(m.Persona_que_Resuelve_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Persona_que_Resuelve_Spartan_User.Name
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Resolucion.Descripcion
                        ,Resolucion = m.Resolucion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion.Clave.ToString(), "Resolucion") ?? (string)m.Resolucion_Resolucion.Descripcion
                        ,Juzgado = m.Juzgado
                        ,JuzgadoNombre = CultureHelper.GetTraduction(m.Juzgado_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_Juzgado.Nombre
                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,No__De_Causa_o_Cuadernillo = m.No__De_Causa_o_Cuadernillo
                        ,Ano_de_Causa_o_Cuadernillo = m.Ano_de_Causa_o_Cuadernillo
                        ,Ano_de_Causa_o_CuadernilloDescripcion = CultureHelper.GetTraduction(m.Ano_de_Causa_o_Cuadernillo_Ano.Clave.ToString(), "Descripcion") ?? (string)m.Ano_de_Causa_o_Cuadernillo_Ano.Descripcion
			,Observaciones = m.Observaciones

                    
                };
				var resultData = new
                {
                    data = result
                    ,Vinculacion = Detalle_Vinculacion_ResolucionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Validacion(Resolucion_MP_ValidacionModel varResolucion_MP)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Resolucion_MP_ValidacionInfo = new Resolucion_MP_Validacion
                {
                    Clave = varResolucion_MP.Clave
                                            ,Fecha_de_Validacion = (!String.IsNullOrEmpty(varResolucion_MP.Fecha_de_Validacion)) ? DateTime.ParseExact(varResolucion_MP.Fecha_de_Validacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Validacion = varResolucion_MP.Hora_de_Validacion
                        ,Dictaminador = varResolucion_MP.Dictaminador
                        ,Resultado_de_Validacion = varResolucion_MP.Resultado_de_Validacion
                        ,Observaciones_Dictaminador = varResolucion_MP.Observaciones_Dictaminador
                    
                };

                result = _IResolucion_MPApiConsumer.Update_Validacion(Resolucion_MP_ValidacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Validacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IResolucion_MPApiConsumer.Get_Validacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Vinculacion_Resolucion;
                var Detalle_Vinculacion_ResolucionData = GetDetalle_Vinculacion_ResolucionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Vinculacion_Resolucion);

                var result = new Resolucion_MP_ValidacionModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Validacion = (m.Fecha_de_Validacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Validacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Validacion = m.Hora_de_Validacion
                        ,Dictaminador = m.Dictaminador
                        ,DictaminadorName = CultureHelper.GetTraduction(m.Dictaminador_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Dictaminador_Spartan_User.Name
                        ,Resultado_de_Validacion = m.Resultado_de_Validacion
                        ,Resultado_de_ValidacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Validacion_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Validacion_Resolucion.Descripcion
			,Observaciones_Dictaminador = m.Observaciones_Dictaminador

                    
                };
				var resultData = new
                {
                    data = result
                    ,Vinculacion = Detalle_Vinculacion_ResolucionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

