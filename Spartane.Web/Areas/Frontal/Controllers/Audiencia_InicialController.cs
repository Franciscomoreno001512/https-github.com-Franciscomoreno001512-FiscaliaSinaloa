using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Audiencia_Inicial;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Judicializacion;
using Spartane.Core.Domain.Detalle_Relaciones_Audiencia_Inicial;

using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.Delito;

using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Especificacion_Detencion;
using Spartane.Core.Domain.Control_de_Detencion;
using Spartane.Core.Domain.Continuacion_de_Proceso;
using Spartane.Core.Domain.Formulacion_de_Imputacion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Audiencia_Inicial;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Audiencia_Inicial;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Judicializacion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Relaciones_Audiencia_Inicial;

using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Imputado;
using Spartane.Web.Areas.WebApiConsumer.Delito;

using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.Especificacion_Detencion;
using Spartane.Web.Areas.WebApiConsumer.Control_de_Detencion;
using Spartane.Web.Areas.WebApiConsumer.Continuacion_de_Proceso;
using Spartane.Web.Areas.WebApiConsumer.Formulacion_de_Imputacion;

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
    public class Audiencia_InicialController : Controller
    {
        #region "variable declaration"

        private IAudiencia_InicialService service = null;
        private IAudiencia_InicialApiConsumer _IAudiencia_InicialApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ITipo_de_JudicializacionApiConsumer _ITipo_de_JudicializacionApiConsumer;
        private IDetalle_Relaciones_Audiencia_InicialApiConsumer _IDetalle_Relaciones_Audiencia_InicialApiConsumer;

        private IDetalle_de_ImputadoApiConsumer _IDetalle_de_ImputadoApiConsumer;
        private IDelitoApiConsumer _IDelitoApiConsumer;

        private IA_TiempoApiConsumer _IA_TiempoApiConsumer;
        private IEspecificacion_DetencionApiConsumer _IEspecificacion_DetencionApiConsumer;
        private IControl_de_DetencionApiConsumer _IControl_de_DetencionApiConsumer;
        private IContinuacion_de_ProcesoApiConsumer _IContinuacion_de_ProcesoApiConsumer;
        private IFormulacion_de_ImputacionApiConsumer _IFormulacion_de_ImputacionApiConsumer;

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

        
        public Audiencia_InicialController(IAudiencia_InicialService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IAudiencia_InicialApiConsumer Audiencia_InicialApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ITipo_de_JudicializacionApiConsumer Tipo_de_JudicializacionApiConsumer , IDetalle_Relaciones_Audiencia_InicialApiConsumer Detalle_Relaciones_Audiencia_InicialApiConsumer , IDetalle_de_ImputadoApiConsumer Detalle_de_ImputadoApiConsumer , IDelitoApiConsumer DelitoApiConsumer  , IA_TiempoApiConsumer A_TiempoApiConsumer , IEspecificacion_DetencionApiConsumer Especificacion_DetencionApiConsumer , IControl_de_DetencionApiConsumer Control_de_DetencionApiConsumer , IContinuacion_de_ProcesoApiConsumer Continuacion_de_ProcesoApiConsumer , IFormulacion_de_ImputacionApiConsumer Formulacion_de_ImputacionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IAudiencia_InicialApiConsumer = Audiencia_InicialApiConsumer;
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
            this._ITipo_de_JudicializacionApiConsumer = Tipo_de_JudicializacionApiConsumer;
            this._IDetalle_Relaciones_Audiencia_InicialApiConsumer = Detalle_Relaciones_Audiencia_InicialApiConsumer;

            this._IDetalle_de_ImputadoApiConsumer = Detalle_de_ImputadoApiConsumer;
            this._IDelitoApiConsumer = DelitoApiConsumer;

            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;
            this._IEspecificacion_DetencionApiConsumer = Especificacion_DetencionApiConsumer;
            this._IControl_de_DetencionApiConsumer = Control_de_DetencionApiConsumer;
            this._IContinuacion_de_ProcesoApiConsumer = Continuacion_de_ProcesoApiConsumer;
            this._IFormulacion_de_ImputacionApiConsumer = Formulacion_de_ImputacionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Audiencia_Inicial
        [ObjectAuth(ObjectId = (ModuleObjectId)45552, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45552, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Audiencia_Inicial/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45552, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45552, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varAudiencia_Inicial = new Audiencia_InicialModel();
			varAudiencia_Inicial.Clave = Id;
			
            ViewBag.ObjectId = "45552";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_Relaciones_Audiencia_Inicial = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45562, ModuleId);
            ViewBag.PermissionDetalle_Relaciones_Audiencia_Inicial = permissionDetalle_Relaciones_Audiencia_Inicial;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IAudiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Audiencia_InicialsData = _IAudiencia_InicialApiConsumer.ListaSelAll(0, 1000, "Audiencia_Inicial.Clave=" + Id, "").Resource.Audiencia_Inicials;
				
				if (Audiencia_InicialsData != null && Audiencia_InicialsData.Count > 0)
                {
					var Audiencia_InicialData = Audiencia_InicialsData.First();
					varAudiencia_Inicial= new Audiencia_InicialModel
					{
						Clave  = Audiencia_InicialData.Clave 
	                    ,Expediente_MP = Audiencia_InicialData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Audiencia_InicialData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Fecha_de_Registro = (Audiencia_InicialData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Audiencia_InicialData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Audiencia_InicialData.Hora_de_Registro
                    ,Usuario_que_Registra = Audiencia_InicialData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Usuario_que_Registra), "Spartan_User") ??  (string)Audiencia_InicialData.Usuario_que_Registra_Spartan_User.Name
                    ,Nombre_del_Juez_de_Control = Audiencia_InicialData.Nombre_del_Juez_de_Control
                    ,Tipo = Audiencia_InicialData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Tipo), "Tipo_de_Judicializacion") ??  (string)Audiencia_InicialData.Tipo_Tipo_de_Judicializacion.Descripcion
                    ,causa_penal = Audiencia_InicialData.causa_penal
                    ,Fecha_Audiencia_Inicial = (Audiencia_InicialData.Fecha_Audiencia_Inicial == null ? string.Empty : Convert.ToDateTime(Audiencia_InicialData.Fecha_Audiencia_Inicial).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Audiencia_Inicial = Audiencia_InicialData.Hora_Audiencia_Inicial
                    ,Sala_de_Audiencia = Audiencia_InicialData.Sala_de_Audiencia
                    ,Con_Detenido = Audiencia_InicialData.Con_Detenido
                    ,Con_DetenidoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Con_Detenido), "A_Tiempo") ??  (string)Audiencia_InicialData.Con_Detenido_A_Tiempo.Descripcion
                    ,Especificar_Detencion = Audiencia_InicialData.Especificar_Detencion
                    ,Especificar_DetencionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Especificar_Detencion), "Especificacion_Detencion") ??  (string)Audiencia_InicialData.Especificar_Detencion_Especificacion_Detencion.Descripcion
                    ,Control_de_Detencion = Audiencia_InicialData.Control_de_Detencion
                    ,Control_de_DetencionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Control_de_Detencion), "Control_de_Detencion") ??  (string)Audiencia_InicialData.Control_de_Detencion_Control_de_Detencion.Descripcion
                    ,Especificar_Control_Detencion = Audiencia_InicialData.Especificar_Control_Detencion
                    ,Especificar_Control_DetencionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Especificar_Control_Detencion), "Continuacion_de_Proceso") ??  (string)Audiencia_InicialData.Especificar_Control_Detencion_Continuacion_de_Proceso.Descripcion
                    ,Formulacion_de_Imputacion = Audiencia_InicialData.Formulacion_de_Imputacion
                    ,Formulacion_de_ImputacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Formulacion_de_Imputacion), "Formulacion_de_Imputacion") ??  (string)Audiencia_InicialData.Formulacion_de_Imputacion_Formulacion_de_Imputacion.Descripcion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Judicializacions_Tipo = _ITipo_de_JudicializacionApiConsumer.SelAll(true);
            if (Tipo_de_Judicializacions_Tipo != null && Tipo_de_Judicializacions_Tipo.Resource != null)
                ViewBag.Tipo_de_Judicializacions_Tipo = Tipo_de_Judicializacions_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Con_Detenido = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Con_Detenido != null && A_Tiempos_Con_Detenido.Resource != null)
                ViewBag.A_Tiempos_Con_Detenido = A_Tiempos_Con_Detenido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecificacion_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especificacion_Detencions_Especificar_Detencion = _IEspecificacion_DetencionApiConsumer.SelAll(true);
            if (Especificacion_Detencions_Especificar_Detencion != null && Especificacion_Detencions_Especificar_Detencion.Resource != null)
                ViewBag.Especificacion_Detencions_Especificar_Detencion = Especificacion_Detencions_Especificar_Detencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especificacion_Detencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IControl_de_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Control_de_Detencions_Control_de_Detencion = _IControl_de_DetencionApiConsumer.SelAll(true);
            if (Control_de_Detencions_Control_de_Detencion != null && Control_de_Detencions_Control_de_Detencion.Resource != null)
                ViewBag.Control_de_Detencions_Control_de_Detencion = Control_de_Detencions_Control_de_Detencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Control_de_Detencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IContinuacion_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Continuacion_de_Procesos_Especificar_Control_Detencion = _IContinuacion_de_ProcesoApiConsumer.SelAll(true);
            if (Continuacion_de_Procesos_Especificar_Control_Detencion != null && Continuacion_de_Procesos_Especificar_Control_Detencion.Resource != null)
                ViewBag.Continuacion_de_Procesos_Especificar_Control_Detencion = Continuacion_de_Procesos_Especificar_Control_Detencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Continuacion_de_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFormulacion_de_ImputacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Formulacion_de_Imputacions_Formulacion_de_Imputacion = _IFormulacion_de_ImputacionApiConsumer.SelAll(true);
            if (Formulacion_de_Imputacions_Formulacion_de_Imputacion != null && Formulacion_de_Imputacions_Formulacion_de_Imputacion.Resource != null)
                ViewBag.Formulacion_de_Imputacions_Formulacion_de_Imputacion = Formulacion_de_Imputacions_Formulacion_de_Imputacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Formulacion_de_Imputacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varAudiencia_Inicial);
        }
		
	[HttpGet]
        public ActionResult AddAudiencia_Inicial(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45552);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IAudiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
			Audiencia_InicialModel varAudiencia_Inicial= new Audiencia_InicialModel();
            var permissionDetalle_Relaciones_Audiencia_Inicial = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45562, ModuleId);
            ViewBag.PermissionDetalle_Relaciones_Audiencia_Inicial = permissionDetalle_Relaciones_Audiencia_Inicial;


            if (id.ToString() != "0")
            {
                var Audiencia_InicialsData = _IAudiencia_InicialApiConsumer.ListaSelAll(0, 1000, "Audiencia_Inicial.Clave=" + id, "").Resource.Audiencia_Inicials;
				
				if (Audiencia_InicialsData != null && Audiencia_InicialsData.Count > 0)
                {
					var Audiencia_InicialData = Audiencia_InicialsData.First();
					varAudiencia_Inicial= new Audiencia_InicialModel
					{
						Clave  = Audiencia_InicialData.Clave 
	                    ,Expediente_MP = Audiencia_InicialData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Audiencia_InicialData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Fecha_de_Registro = (Audiencia_InicialData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Audiencia_InicialData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Audiencia_InicialData.Hora_de_Registro
                    ,Usuario_que_Registra = Audiencia_InicialData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Usuario_que_Registra), "Spartan_User") ??  (string)Audiencia_InicialData.Usuario_que_Registra_Spartan_User.Name
                    ,Nombre_del_Juez_de_Control = Audiencia_InicialData.Nombre_del_Juez_de_Control
                    ,Tipo = Audiencia_InicialData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Tipo), "Tipo_de_Judicializacion") ??  (string)Audiencia_InicialData.Tipo_Tipo_de_Judicializacion.Descripcion
                    ,causa_penal = Audiencia_InicialData.causa_penal
                    ,Fecha_Audiencia_Inicial = (Audiencia_InicialData.Fecha_Audiencia_Inicial == null ? string.Empty : Convert.ToDateTime(Audiencia_InicialData.Fecha_Audiencia_Inicial).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Audiencia_Inicial = Audiencia_InicialData.Hora_Audiencia_Inicial
                    ,Sala_de_Audiencia = Audiencia_InicialData.Sala_de_Audiencia
                    ,Con_Detenido = Audiencia_InicialData.Con_Detenido
                    ,Con_DetenidoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Con_Detenido), "A_Tiempo") ??  (string)Audiencia_InicialData.Con_Detenido_A_Tiempo.Descripcion
                    ,Especificar_Detencion = Audiencia_InicialData.Especificar_Detencion
                    ,Especificar_DetencionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Especificar_Detencion), "Especificacion_Detencion") ??  (string)Audiencia_InicialData.Especificar_Detencion_Especificacion_Detencion.Descripcion
                    ,Control_de_Detencion = Audiencia_InicialData.Control_de_Detencion
                    ,Control_de_DetencionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Control_de_Detencion), "Control_de_Detencion") ??  (string)Audiencia_InicialData.Control_de_Detencion_Control_de_Detencion.Descripcion
                    ,Especificar_Control_Detencion = Audiencia_InicialData.Especificar_Control_Detencion
                    ,Especificar_Control_DetencionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Especificar_Control_Detencion), "Continuacion_de_Proceso") ??  (string)Audiencia_InicialData.Especificar_Control_Detencion_Continuacion_de_Proceso.Descripcion
                    ,Formulacion_de_Imputacion = Audiencia_InicialData.Formulacion_de_Imputacion
                    ,Formulacion_de_ImputacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Audiencia_InicialData.Formulacion_de_Imputacion), "Formulacion_de_Imputacion") ??  (string)Audiencia_InicialData.Formulacion_de_Imputacion_Formulacion_de_Imputacion.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Judicializacions_Tipo = _ITipo_de_JudicializacionApiConsumer.SelAll(true);
            if (Tipo_de_Judicializacions_Tipo != null && Tipo_de_Judicializacions_Tipo.Resource != null)
                ViewBag.Tipo_de_Judicializacions_Tipo = Tipo_de_Judicializacions_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Con_Detenido = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Con_Detenido != null && A_Tiempos_Con_Detenido.Resource != null)
                ViewBag.A_Tiempos_Con_Detenido = A_Tiempos_Con_Detenido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecificacion_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especificacion_Detencions_Especificar_Detencion = _IEspecificacion_DetencionApiConsumer.SelAll(true);
            if (Especificacion_Detencions_Especificar_Detencion != null && Especificacion_Detencions_Especificar_Detencion.Resource != null)
                ViewBag.Especificacion_Detencions_Especificar_Detencion = Especificacion_Detencions_Especificar_Detencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especificacion_Detencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IControl_de_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Control_de_Detencions_Control_de_Detencion = _IControl_de_DetencionApiConsumer.SelAll(true);
            if (Control_de_Detencions_Control_de_Detencion != null && Control_de_Detencions_Control_de_Detencion.Resource != null)
                ViewBag.Control_de_Detencions_Control_de_Detencion = Control_de_Detencions_Control_de_Detencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Control_de_Detencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IContinuacion_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Continuacion_de_Procesos_Especificar_Control_Detencion = _IContinuacion_de_ProcesoApiConsumer.SelAll(true);
            if (Continuacion_de_Procesos_Especificar_Control_Detencion != null && Continuacion_de_Procesos_Especificar_Control_Detencion.Resource != null)
                ViewBag.Continuacion_de_Procesos_Especificar_Control_Detencion = Continuacion_de_Procesos_Especificar_Control_Detencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Continuacion_de_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFormulacion_de_ImputacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Formulacion_de_Imputacions_Formulacion_de_Imputacion = _IFormulacion_de_ImputacionApiConsumer.SelAll(true);
            if (Formulacion_de_Imputacions_Formulacion_de_Imputacion != null && Formulacion_de_Imputacions_Formulacion_de_Imputacion.Resource != null)
                ViewBag.Formulacion_de_Imputacions_Formulacion_de_Imputacion = Formulacion_de_Imputacions_Formulacion_de_Imputacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Formulacion_de_Imputacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddAudiencia_Inicial", varAudiencia_Inicial);
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
        public ActionResult GetEspecificacion_DetencionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEspecificacion_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEspecificacion_DetencionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especificacion_Detencion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetControl_de_DetencionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IControl_de_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IControl_de_DetencionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Control_de_Detencion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetContinuacion_de_ProcesoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IContinuacion_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IContinuacion_de_ProcesoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Continuacion_de_Proceso", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetFormulacion_de_ImputacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IFormulacion_de_ImputacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IFormulacion_de_ImputacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Formulacion_de_Imputacion", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Audiencia_InicialAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Judicializacions_Tipo = _ITipo_de_JudicializacionApiConsumer.SelAll(true);
            if (Tipo_de_Judicializacions_Tipo != null && Tipo_de_Judicializacions_Tipo.Resource != null)
                ViewBag.Tipo_de_Judicializacions_Tipo = Tipo_de_Judicializacions_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Con_Detenido = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Con_Detenido != null && A_Tiempos_Con_Detenido.Resource != null)
                ViewBag.A_Tiempos_Con_Detenido = A_Tiempos_Con_Detenido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecificacion_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especificacion_Detencions_Especificar_Detencion = _IEspecificacion_DetencionApiConsumer.SelAll(true);
            if (Especificacion_Detencions_Especificar_Detencion != null && Especificacion_Detencions_Especificar_Detencion.Resource != null)
                ViewBag.Especificacion_Detencions_Especificar_Detencion = Especificacion_Detencions_Especificar_Detencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especificacion_Detencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IControl_de_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Control_de_Detencions_Control_de_Detencion = _IControl_de_DetencionApiConsumer.SelAll(true);
            if (Control_de_Detencions_Control_de_Detencion != null && Control_de_Detencions_Control_de_Detencion.Resource != null)
                ViewBag.Control_de_Detencions_Control_de_Detencion = Control_de_Detencions_Control_de_Detencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Control_de_Detencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IContinuacion_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Continuacion_de_Procesos_Especificar_Control_Detencion = _IContinuacion_de_ProcesoApiConsumer.SelAll(true);
            if (Continuacion_de_Procesos_Especificar_Control_Detencion != null && Continuacion_de_Procesos_Especificar_Control_Detencion.Resource != null)
                ViewBag.Continuacion_de_Procesos_Especificar_Control_Detencion = Continuacion_de_Procesos_Especificar_Control_Detencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Continuacion_de_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFormulacion_de_ImputacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Formulacion_de_Imputacions_Formulacion_de_Imputacion = _IFormulacion_de_ImputacionApiConsumer.SelAll(true);
            if (Formulacion_de_Imputacions_Formulacion_de_Imputacion != null && Formulacion_de_Imputacions_Formulacion_de_Imputacion.Resource != null)
                ViewBag.Formulacion_de_Imputacions_Formulacion_de_Imputacion = Formulacion_de_Imputacions_Formulacion_de_Imputacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Formulacion_de_Imputacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Judicializacions_Tipo = _ITipo_de_JudicializacionApiConsumer.SelAll(true);
            if (Tipo_de_Judicializacions_Tipo != null && Tipo_de_Judicializacions_Tipo.Resource != null)
                ViewBag.Tipo_de_Judicializacions_Tipo = Tipo_de_Judicializacions_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Con_Detenido = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Con_Detenido != null && A_Tiempos_Con_Detenido.Resource != null)
                ViewBag.A_Tiempos_Con_Detenido = A_Tiempos_Con_Detenido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecificacion_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especificacion_Detencions_Especificar_Detencion = _IEspecificacion_DetencionApiConsumer.SelAll(true);
            if (Especificacion_Detencions_Especificar_Detencion != null && Especificacion_Detencions_Especificar_Detencion.Resource != null)
                ViewBag.Especificacion_Detencions_Especificar_Detencion = Especificacion_Detencions_Especificar_Detencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especificacion_Detencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IControl_de_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Control_de_Detencions_Control_de_Detencion = _IControl_de_DetencionApiConsumer.SelAll(true);
            if (Control_de_Detencions_Control_de_Detencion != null && Control_de_Detencions_Control_de_Detencion.Resource != null)
                ViewBag.Control_de_Detencions_Control_de_Detencion = Control_de_Detencions_Control_de_Detencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Control_de_Detencion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IContinuacion_de_ProcesoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Continuacion_de_Procesos_Especificar_Control_Detencion = _IContinuacion_de_ProcesoApiConsumer.SelAll(true);
            if (Continuacion_de_Procesos_Especificar_Control_Detencion != null && Continuacion_de_Procesos_Especificar_Control_Detencion.Resource != null)
                ViewBag.Continuacion_de_Procesos_Especificar_Control_Detencion = Continuacion_de_Procesos_Especificar_Control_Detencion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Continuacion_de_Proceso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFormulacion_de_ImputacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Formulacion_de_Imputacions_Formulacion_de_Imputacion = _IFormulacion_de_ImputacionApiConsumer.SelAll(true);
            if (Formulacion_de_Imputacions_Formulacion_de_Imputacion != null && Formulacion_de_Imputacions_Formulacion_de_Imputacion.Resource != null)
                ViewBag.Formulacion_de_Imputacions_Formulacion_de_Imputacion = Formulacion_de_Imputacions_Formulacion_de_Imputacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Formulacion_de_Imputacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Audiencia_InicialAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Audiencia_InicialAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Audiencia_InicialAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Audiencia_InicialPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IAudiencia_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Audiencia_Inicials == null)
                result.Audiencia_Inicials = new List<Audiencia_Inicial>();

            return Json(new
            {
                data = result.Audiencia_Inicials.Select(m => new Audiencia_InicialGridModel
                    {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Nombre_del_Juez_de_Control = m.Nombre_del_Juez_de_Control
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,causa_penal = m.causa_penal
                        ,Fecha_Audiencia_Inicial = (m.Fecha_Audiencia_Inicial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Audiencia_Inicial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Audiencia_Inicial = m.Hora_Audiencia_Inicial
			,Sala_de_Audiencia = m.Sala_de_Audiencia
                        ,Con_DetenidoDescripcion = CultureHelper.GetTraduction(m.Con_Detenido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Con_Detenido_A_Tiempo.Descripcion
                        ,Especificar_DetencionDescripcion = CultureHelper.GetTraduction(m.Especificar_Detencion_Especificacion_Detencion.Clave.ToString(), "Descripcion") ?? (string)m.Especificar_Detencion_Especificacion_Detencion.Descripcion
                        ,Control_de_DetencionDescripcion = CultureHelper.GetTraduction(m.Control_de_Detencion_Control_de_Detencion.Clave.ToString(), "Descripcion") ?? (string)m.Control_de_Detencion_Control_de_Detencion.Descripcion
                        ,Especificar_Control_DetencionDescripcion = CultureHelper.GetTraduction(m.Especificar_Control_Detencion_Continuacion_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Especificar_Control_Detencion_Continuacion_de_Proceso.Descripcion
                        ,Formulacion_de_ImputacionDescripcion = CultureHelper.GetTraduction(m.Formulacion_de_Imputacion_Formulacion_de_Imputacion.Clave.ToString(), "Descripcion") ?? (string)m.Formulacion_de_Imputacion_Formulacion_de_Imputacion.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetAudiencia_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAudiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAudiencia_InicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Audiencia_Inicial", m.),
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
        /// Get List of Audiencia_Inicial from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Audiencia_Inicial Entity</returns>
        public ActionResult GetAudiencia_InicialList(UrlParametersModel param)
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
            _IAudiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Audiencia_InicialPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Audiencia_InicialAdvanceSearchModel))
                {
					var advanceFilter =
                    (Audiencia_InicialAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Audiencia_InicialPropertyMapper oAudiencia_InicialPropertyMapper = new Audiencia_InicialPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oAudiencia_InicialPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IAudiencia_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Audiencia_Inicials == null)
                result.Audiencia_Inicials = new List<Audiencia_Inicial>();

            return Json(new
            {
                aaData = result.Audiencia_Inicials.Select(m => new Audiencia_InicialGridModel
            {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Nombre_del_Juez_de_Control = m.Nombre_del_Juez_de_Control
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,causa_penal = m.causa_penal
                        ,Fecha_Audiencia_Inicial = (m.Fecha_Audiencia_Inicial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Audiencia_Inicial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Audiencia_Inicial = m.Hora_Audiencia_Inicial
			,Sala_de_Audiencia = m.Sala_de_Audiencia
                        ,Con_DetenidoDescripcion = CultureHelper.GetTraduction(m.Con_Detenido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Con_Detenido_A_Tiempo.Descripcion
                        ,Especificar_DetencionDescripcion = CultureHelper.GetTraduction(m.Especificar_Detencion_Especificacion_Detencion.Clave.ToString(), "Descripcion") ?? (string)m.Especificar_Detencion_Especificacion_Detencion.Descripcion
                        ,Control_de_DetencionDescripcion = CultureHelper.GetTraduction(m.Control_de_Detencion_Control_de_Detencion.Clave.ToString(), "Descripcion") ?? (string)m.Control_de_Detencion_Control_de_Detencion.Descripcion
                        ,Especificar_Control_DetencionDescripcion = CultureHelper.GetTraduction(m.Especificar_Control_Detencion_Continuacion_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Especificar_Control_Detencion_Continuacion_de_Proceso.Descripcion
                        ,Formulacion_de_ImputacionDescripcion = CultureHelper.GetTraduction(m.Formulacion_de_Imputacion_Formulacion_de_Imputacion.Clave.ToString(), "Descripcion") ?? (string)m.Formulacion_de_Imputacion_Formulacion_de_Imputacion.Descripcion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetAudiencia_Inicial_Expediente_MP_expediente_ministerio_publico(string query, string where)
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
        public JsonResult GetAudiencia_Inicial_Usuario_que_Registra_Spartan_User(string query, string where)
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
        [HttpGet]
        public JsonResult GetDetalle_Relaciones_Audiencia_Inicial_Imputado_Detalle_de_Imputado(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Imputado.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Imputado.Nombre_Completo_Detenido as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_ImputadoApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Imputado.Nombre_Completo_Detenido ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Imputados)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Imputado", "Nombre_Completo_Detenido");
                    item.Nombre_Completo_Detenido =trans ??item.Nombre_Completo_Detenido;
                }
                return Json(result.Detalle_de_Imputados.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_Relaciones_Audiencia_Inicial_Delito_Delito(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Delito.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Delito.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDelitoApiConsumer.ListaSelAll(1, 20,elWhere , " Delito.Descripcion ASC ").Resource;
               
                foreach (var item in result.Delitos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Delito", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Delitos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }






        [NonAction]
        public string GetAdvanceFilter(Audiencia_InicialAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Audiencia_Inicial.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Audiencia_Inicial.Clave <= " + filter.ToClave;
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

                where += " AND Audiencia_Inicial.Expediente_MP In (" + Expediente_MPIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Audiencia_Inicial.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Audiencia_Inicial.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Audiencia_Inicial.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Audiencia_Inicial.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
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

                where += " AND Audiencia_Inicial.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombre_del_Juez_de_Control))
            {
                switch (filter.Nombre_del_Juez_de_ControlFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Audiencia_Inicial.Nombre_del_Juez_de_Control LIKE '" + filter.Nombre_del_Juez_de_Control + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Audiencia_Inicial.Nombre_del_Juez_de_Control LIKE '%" + filter.Nombre_del_Juez_de_Control + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Audiencia_Inicial.Nombre_del_Juez_de_Control = '" + filter.Nombre_del_Juez_de_Control + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Audiencia_Inicial.Nombre_del_Juez_de_Control LIKE '%" + filter.Nombre_del_Juez_de_Control + "%'";
                        break;
                }
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

                where += " AND Audiencia_Inicial.Tipo In (" + TipoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.causa_penal))
            {
                switch (filter.causa_penalFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Audiencia_Inicial.causa_penal LIKE '" + filter.causa_penal + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Audiencia_Inicial.causa_penal LIKE '%" + filter.causa_penal + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Audiencia_Inicial.causa_penal = '" + filter.causa_penal + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Audiencia_Inicial.causa_penal LIKE '%" + filter.causa_penal + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Audiencia_Inicial) || !string.IsNullOrEmpty(filter.ToFecha_Audiencia_Inicial))
            {
                var Fecha_Audiencia_InicialFrom = DateTime.ParseExact(filter.FromFecha_Audiencia_Inicial, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_Audiencia_InicialTo = DateTime.ParseExact(filter.ToFecha_Audiencia_Inicial, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Audiencia_Inicial))
                    where += " AND Audiencia_Inicial.Fecha_Audiencia_Inicial >= '" + Fecha_Audiencia_InicialFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Audiencia_Inicial))
                    where += " AND Audiencia_Inicial.Fecha_Audiencia_Inicial <= '" + Fecha_Audiencia_InicialTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Audiencia_Inicial) || !string.IsNullOrEmpty(filter.ToHora_Audiencia_Inicial))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Audiencia_Inicial))
                    where += " AND Convert(TIME,Audiencia_Inicial.Hora_Audiencia_Inicial) >='" + filter.FromHora_Audiencia_Inicial + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Audiencia_Inicial))
                    where += " AND Convert(TIME,Audiencia_Inicial.Hora_Audiencia_Inicial) <='" + filter.ToHora_Audiencia_Inicial + "'";
            }

            if (!string.IsNullOrEmpty(filter.Sala_de_Audiencia))
            {
                switch (filter.Sala_de_AudienciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Audiencia_Inicial.Sala_de_Audiencia LIKE '" + filter.Sala_de_Audiencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Audiencia_Inicial.Sala_de_Audiencia LIKE '%" + filter.Sala_de_Audiencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Audiencia_Inicial.Sala_de_Audiencia = '" + filter.Sala_de_Audiencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Audiencia_Inicial.Sala_de_Audiencia LIKE '%" + filter.Sala_de_Audiencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCon_Detenido))
            {
                switch (filter.Con_DetenidoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.AdvanceCon_Detenido + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceCon_Detenido + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.AdvanceCon_Detenido + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceCon_Detenido + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCon_DetenidoMultiple != null && filter.AdvanceCon_DetenidoMultiple.Count() > 0)
            {
                var Con_DetenidoIds = string.Join(",", filter.AdvanceCon_DetenidoMultiple);

                where += " AND Audiencia_Inicial.Con_Detenido In (" + Con_DetenidoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEspecificar_Detencion))
            {
                switch (filter.Especificar_DetencionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Especificacion_Detencion.Descripcion LIKE '" + filter.AdvanceEspecificar_Detencion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Especificacion_Detencion.Descripcion LIKE '%" + filter.AdvanceEspecificar_Detencion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Especificacion_Detencion.Descripcion = '" + filter.AdvanceEspecificar_Detencion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Especificacion_Detencion.Descripcion LIKE '%" + filter.AdvanceEspecificar_Detencion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEspecificar_DetencionMultiple != null && filter.AdvanceEspecificar_DetencionMultiple.Count() > 0)
            {
                var Especificar_DetencionIds = string.Join(",", filter.AdvanceEspecificar_DetencionMultiple);

                where += " AND Audiencia_Inicial.Especificar_Detencion In (" + Especificar_DetencionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceControl_de_Detencion))
            {
                switch (filter.Control_de_DetencionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Control_de_Detencion.Descripcion LIKE '" + filter.AdvanceControl_de_Detencion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Control_de_Detencion.Descripcion LIKE '%" + filter.AdvanceControl_de_Detencion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Control_de_Detencion.Descripcion = '" + filter.AdvanceControl_de_Detencion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Control_de_Detencion.Descripcion LIKE '%" + filter.AdvanceControl_de_Detencion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceControl_de_DetencionMultiple != null && filter.AdvanceControl_de_DetencionMultiple.Count() > 0)
            {
                var Control_de_DetencionIds = string.Join(",", filter.AdvanceControl_de_DetencionMultiple);

                where += " AND Audiencia_Inicial.Control_de_Detencion In (" + Control_de_DetencionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEspecificar_Control_Detencion))
            {
                switch (filter.Especificar_Control_DetencionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Continuacion_de_Proceso.Descripcion LIKE '" + filter.AdvanceEspecificar_Control_Detencion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Continuacion_de_Proceso.Descripcion LIKE '%" + filter.AdvanceEspecificar_Control_Detencion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Continuacion_de_Proceso.Descripcion = '" + filter.AdvanceEspecificar_Control_Detencion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Continuacion_de_Proceso.Descripcion LIKE '%" + filter.AdvanceEspecificar_Control_Detencion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEspecificar_Control_DetencionMultiple != null && filter.AdvanceEspecificar_Control_DetencionMultiple.Count() > 0)
            {
                var Especificar_Control_DetencionIds = string.Join(",", filter.AdvanceEspecificar_Control_DetencionMultiple);

                where += " AND Audiencia_Inicial.Especificar_Control_Detencion In (" + Especificar_Control_DetencionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceFormulacion_de_Imputacion))
            {
                switch (filter.Formulacion_de_ImputacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Formulacion_de_Imputacion.Descripcion LIKE '" + filter.AdvanceFormulacion_de_Imputacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Formulacion_de_Imputacion.Descripcion LIKE '%" + filter.AdvanceFormulacion_de_Imputacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Formulacion_de_Imputacion.Descripcion = '" + filter.AdvanceFormulacion_de_Imputacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Formulacion_de_Imputacion.Descripcion LIKE '%" + filter.AdvanceFormulacion_de_Imputacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceFormulacion_de_ImputacionMultiple != null && filter.AdvanceFormulacion_de_ImputacionMultiple.Count() > 0)
            {
                var Formulacion_de_ImputacionIds = string.Join(",", filter.AdvanceFormulacion_de_ImputacionMultiple);

                where += " AND Audiencia_Inicial.Formulacion_de_Imputacion In (" + Formulacion_de_ImputacionIds + ")";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_Relaciones_Audiencia_Inicial(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Relaciones_Audiencia_InicialGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Relaciones_Audiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Relaciones_Audiencia_Inicial.Audiencia_Inicial=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Relaciones_Audiencia_Inicial.Audiencia_Inicial='" + RelationId + "'";
            }
            var result = _IDetalle_Relaciones_Audiencia_InicialApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Relaciones_Audiencia_Inicials == null)
                result.Detalle_Relaciones_Audiencia_Inicials = new List<Detalle_Relaciones_Audiencia_Inicial>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Relaciones_Audiencia_Inicials.Select(m => new Detalle_Relaciones_Audiencia_InicialGridModel
                {
                    Clave = m.Clave

                        ,Imputado = m.Imputado
                        ,ImputadoNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Imputado_Detalle_de_Imputado.Clave.ToString(), "Nombre_Completo_Detenido") ??(string)m.Imputado_Detalle_de_Imputado.Nombre_Completo_Detenido
                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ??(string)m.Delito_Delito.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Relaciones_Audiencia_InicialGridModel> GetDetalle_Relaciones_Audiencia_InicialData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Relaciones_Audiencia_InicialGridModel> resultData = new List<Detalle_Relaciones_Audiencia_InicialGridModel>();
            string where = "Detalle_Relaciones_Audiencia_Inicial.Audiencia_Inicial=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Relaciones_Audiencia_Inicial.Audiencia_Inicial='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Relaciones_Audiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Relaciones_Audiencia_InicialApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Relaciones_Audiencia_Inicials != null)
            {
                resultData = result.Detalle_Relaciones_Audiencia_Inicials.Select(m => new Detalle_Relaciones_Audiencia_InicialGridModel
                    {
                        Clave = m.Clave

                        ,Imputado = m.Imputado
                        ,ImputadoNombre_Completo_Detenido = CultureHelper.GetTraduction(m.Imputado_Detalle_de_Imputado.Clave.ToString(), "Nombre_Completo_Detenido") ??(string)m.Imputado_Detalle_de_Imputado.Nombre_Completo_Detenido
                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ??(string)m.Delito_Delito.Descripcion


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
                _IAudiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

                Audiencia_Inicial varAudiencia_Inicial = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_Relaciones_Audiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Relaciones_Audiencia_Inicial.Audiencia_Inicial=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Relaciones_Audiencia_Inicial.Audiencia_Inicial='" + id + "'";
                    }
                    var Detalle_Relaciones_Audiencia_InicialInfo =
                        _IDetalle_Relaciones_Audiencia_InicialApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Relaciones_Audiencia_InicialInfo.Detalle_Relaciones_Audiencia_Inicials.Count > 0)
                    {
                        var resultDetalle_Relaciones_Audiencia_Inicial = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Relaciones_Audiencia_InicialItem in Detalle_Relaciones_Audiencia_InicialInfo.Detalle_Relaciones_Audiencia_Inicials)
                            resultDetalle_Relaciones_Audiencia_Inicial = resultDetalle_Relaciones_Audiencia_Inicial
                                              && _IDetalle_Relaciones_Audiencia_InicialApiConsumer.Delete(Detalle_Relaciones_Audiencia_InicialItem.Clave, null,null).Resource;

                        if (!resultDetalle_Relaciones_Audiencia_Inicial)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IAudiencia_InicialApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Audiencia_InicialModel varAudiencia_Inicial)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IAudiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Audiencia_InicialInfo = new Audiencia_Inicial
                    {
                        Clave = varAudiencia_Inicial.Clave
                        ,Expediente_MP = varAudiencia_Inicial.Expediente_MP
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varAudiencia_Inicial.Fecha_de_Registro)) ? DateTime.ParseExact(varAudiencia_Inicial.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varAudiencia_Inicial.Hora_de_Registro
                        ,Usuario_que_Registra = varAudiencia_Inicial.Usuario_que_Registra
                        ,Nombre_del_Juez_de_Control = varAudiencia_Inicial.Nombre_del_Juez_de_Control
                        ,Tipo = varAudiencia_Inicial.Tipo
                        ,causa_penal = varAudiencia_Inicial.causa_penal
                        ,Fecha_Audiencia_Inicial = (!String.IsNullOrEmpty(varAudiencia_Inicial.Fecha_Audiencia_Inicial)) ? DateTime.ParseExact(varAudiencia_Inicial.Fecha_Audiencia_Inicial, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Audiencia_Inicial = varAudiencia_Inicial.Hora_Audiencia_Inicial
                        ,Sala_de_Audiencia = varAudiencia_Inicial.Sala_de_Audiencia
                        ,Con_Detenido = varAudiencia_Inicial.Con_Detenido
                        ,Especificar_Detencion = varAudiencia_Inicial.Especificar_Detencion
                        ,Control_de_Detencion = varAudiencia_Inicial.Control_de_Detencion
                        ,Especificar_Control_Detencion = varAudiencia_Inicial.Especificar_Control_Detencion
                        ,Formulacion_de_Imputacion = varAudiencia_Inicial.Formulacion_de_Imputacion

                    };

                    result = !IsNew ?
                        _IAudiencia_InicialApiConsumer.Update(Audiencia_InicialInfo, null, null).Resource.ToString() :
                         _IAudiencia_InicialApiConsumer.Insert(Audiencia_InicialInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Relaciones_Audiencia_Inicial(int MasterId, int referenceId, List<Detalle_Relaciones_Audiencia_InicialGridModelPost> Detalle_Relaciones_Audiencia_InicialItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Relaciones_Audiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Relaciones_Audiencia_InicialData = _IDetalle_Relaciones_Audiencia_InicialApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Relaciones_Audiencia_Inicial.Audiencia_Inicial=" + referenceId,"").Resource;
                if (Detalle_Relaciones_Audiencia_InicialData == null || Detalle_Relaciones_Audiencia_InicialData.Detalle_Relaciones_Audiencia_Inicials.Count == 0)
                    return true;

                var result = true;

                Detalle_Relaciones_Audiencia_InicialGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Relaciones_Audiencia_Inicial in Detalle_Relaciones_Audiencia_InicialData.Detalle_Relaciones_Audiencia_Inicials)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Relaciones_Audiencia_Inicial Detalle_Relaciones_Audiencia_Inicial1 = varDetalle_Relaciones_Audiencia_Inicial;

                    if (Detalle_Relaciones_Audiencia_InicialItems != null && Detalle_Relaciones_Audiencia_InicialItems.Any(m => m.Clave == Detalle_Relaciones_Audiencia_Inicial1.Clave))
                    {
                        modelDataToChange = Detalle_Relaciones_Audiencia_InicialItems.FirstOrDefault(m => m.Clave == Detalle_Relaciones_Audiencia_Inicial1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Relaciones_Audiencia_Inicial.Audiencia_Inicial = MasterId;
                    var insertId = _IDetalle_Relaciones_Audiencia_InicialApiConsumer.Insert(varDetalle_Relaciones_Audiencia_Inicial,null,null).Resource;
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
        public ActionResult PostDetalle_Relaciones_Audiencia_Inicial(List<Detalle_Relaciones_Audiencia_InicialGridModelPost> Detalle_Relaciones_Audiencia_InicialItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Relaciones_Audiencia_Inicial(MasterId, referenceId, Detalle_Relaciones_Audiencia_InicialItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Relaciones_Audiencia_InicialItems != null && Detalle_Relaciones_Audiencia_InicialItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Relaciones_Audiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Relaciones_Audiencia_InicialItem in Detalle_Relaciones_Audiencia_InicialItems)
                    {




                        //Removal Request
                        if (Detalle_Relaciones_Audiencia_InicialItem.Removed)
                        {
                            result = result && _IDetalle_Relaciones_Audiencia_InicialApiConsumer.Delete(Detalle_Relaciones_Audiencia_InicialItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Relaciones_Audiencia_InicialItem.Clave = 0;

                        var Detalle_Relaciones_Audiencia_InicialData = new Detalle_Relaciones_Audiencia_Inicial
                        {
                            Audiencia_Inicial = MasterId
                            ,Clave = Detalle_Relaciones_Audiencia_InicialItem.Clave
                            ,Imputado = (Convert.ToInt32(Detalle_Relaciones_Audiencia_InicialItem.Imputado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Relaciones_Audiencia_InicialItem.Imputado))
                            ,Delito = (Convert.ToInt32(Detalle_Relaciones_Audiencia_InicialItem.Delito) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Relaciones_Audiencia_InicialItem.Delito))

                        };

                        var resultId = Detalle_Relaciones_Audiencia_InicialItem.Clave > 0
                           ? _IDetalle_Relaciones_Audiencia_InicialApiConsumer.Update(Detalle_Relaciones_Audiencia_InicialData,null,null).Resource
                           : _IDetalle_Relaciones_Audiencia_InicialApiConsumer.Insert(Detalle_Relaciones_Audiencia_InicialData,null,null).Resource;

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
        public ActionResult GetDetalle_Relaciones_Audiencia_Inicial_Detalle_de_ImputadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_ImputadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Nombre_Completo_Detenido= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Imputado", "Nombre_Completo_Detenido");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_Relaciones_Audiencia_Inicial_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelitoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
                    item.Descripcion= CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Delito", "Descripcion");
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of Audiencia_Inicial script
        /// </summary>
        /// <param name="oAudiencia_InicialElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Audiencia_InicialModuleAttributeList)
        {
            for (int i = 0; i < Audiencia_InicialModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Audiencia_InicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Audiencia_InicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Audiencia_InicialModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Audiencia_InicialModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Audiencia_InicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Audiencia_InicialModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Audiencia_InicialModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Audiencia_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Audiencia_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Audiencia_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Audiencia_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strAudiencia_InicialScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Audiencia_Inicial.js")))
            {
                strAudiencia_InicialScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Audiencia_Inicial element attributes
            string userChangeJson = jsSerialize.Serialize(Audiencia_InicialModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strAudiencia_InicialScript.IndexOf("inpuElementArray");
            string splittedString = strAudiencia_InicialScript.Substring(indexOfArray, strAudiencia_InicialScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Audiencia_InicialModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Audiencia_InicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strAudiencia_InicialScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strAudiencia_InicialScript.Substring(indexOfArrayHistory, strAudiencia_InicialScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strAudiencia_InicialScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strAudiencia_InicialScript.Substring(endIndexOfMainElement + indexOfArray, strAudiencia_InicialScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Audiencia_InicialModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Audiencia_InicialModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Audiencia_Inicial.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Audiencia_Inicial.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Audiencia_Inicial.js")))
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
        public ActionResult Audiencia_InicialPropertyBag()
        {
            return PartialView("Audiencia_InicialPropertyBag", "Audiencia_Inicial");
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
        public ActionResult AddDetalle_Relaciones_Audiencia_Inicial(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Relaciones_Audiencia_Inicial/AddDetalle_Relaciones_Audiencia_Inicial");
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
                var whereClauseFormat = "Object = 45552 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IAudiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Audiencia_Inicial.Clave= " + RecordId;
                            var result = _IAudiencia_InicialApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IAudiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Audiencia_InicialPropertyMapper());
			
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
                    (Audiencia_InicialAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Audiencia_InicialPropertyMapper oAudiencia_InicialPropertyMapper = new Audiencia_InicialPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oAudiencia_InicialPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IAudiencia_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Audiencia_Inicials == null)
                result.Audiencia_Inicials = new List<Audiencia_Inicial>();

            var data = result.Audiencia_Inicials.Select(m => new Audiencia_InicialGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Nombre_del_Juez_de_Control = m.Nombre_del_Juez_de_Control
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,causa_penal = m.causa_penal
                        ,Fecha_Audiencia_Inicial = (m.Fecha_Audiencia_Inicial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Audiencia_Inicial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Audiencia_Inicial = m.Hora_Audiencia_Inicial
			,Sala_de_Audiencia = m.Sala_de_Audiencia
                        ,Con_DetenidoDescripcion = CultureHelper.GetTraduction(m.Con_Detenido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Con_Detenido_A_Tiempo.Descripcion
                        ,Especificar_DetencionDescripcion = CultureHelper.GetTraduction(m.Especificar_Detencion_Especificacion_Detencion.Clave.ToString(), "Descripcion") ?? (string)m.Especificar_Detencion_Especificacion_Detencion.Descripcion
                        ,Control_de_DetencionDescripcion = CultureHelper.GetTraduction(m.Control_de_Detencion_Control_de_Detencion.Clave.ToString(), "Descripcion") ?? (string)m.Control_de_Detencion_Control_de_Detencion.Descripcion
                        ,Especificar_Control_DetencionDescripcion = CultureHelper.GetTraduction(m.Especificar_Control_Detencion_Continuacion_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Especificar_Control_Detencion_Continuacion_de_Proceso.Descripcion
                        ,Formulacion_de_ImputacionDescripcion = CultureHelper.GetTraduction(m.Formulacion_de_Imputacion_Formulacion_de_Imputacion.Clave.ToString(), "Descripcion") ?? (string)m.Formulacion_de_Imputacion_Formulacion_de_Imputacion.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45552, arrayColumnsVisible), "Audiencia_InicialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45552, arrayColumnsVisible), "Audiencia_InicialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45552, arrayColumnsVisible), "Audiencia_InicialList_" + DateTime.Now.ToString());
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

            _IAudiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Audiencia_InicialPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Audiencia_InicialAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Audiencia_InicialPropertyMapper oAudiencia_InicialPropertyMapper = new Audiencia_InicialPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oAudiencia_InicialPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IAudiencia_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Audiencia_Inicials == null)
                result.Audiencia_Inicials = new List<Audiencia_Inicial>();

            var data = result.Audiencia_Inicials.Select(m => new Audiencia_InicialGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Nombre_del_Juez_de_Control = m.Nombre_del_Juez_de_Control
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,causa_penal = m.causa_penal
                        ,Fecha_Audiencia_Inicial = (m.Fecha_Audiencia_Inicial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Audiencia_Inicial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Audiencia_Inicial = m.Hora_Audiencia_Inicial
			,Sala_de_Audiencia = m.Sala_de_Audiencia
                        ,Con_DetenidoDescripcion = CultureHelper.GetTraduction(m.Con_Detenido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Con_Detenido_A_Tiempo.Descripcion
                        ,Especificar_DetencionDescripcion = CultureHelper.GetTraduction(m.Especificar_Detencion_Especificacion_Detencion.Clave.ToString(), "Descripcion") ?? (string)m.Especificar_Detencion_Especificacion_Detencion.Descripcion
                        ,Control_de_DetencionDescripcion = CultureHelper.GetTraduction(m.Control_de_Detencion_Control_de_Detencion.Clave.ToString(), "Descripcion") ?? (string)m.Control_de_Detencion_Control_de_Detencion.Descripcion
                        ,Especificar_Control_DetencionDescripcion = CultureHelper.GetTraduction(m.Especificar_Control_Detencion_Continuacion_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Especificar_Control_Detencion_Continuacion_de_Proceso.Descripcion
                        ,Formulacion_de_ImputacionDescripcion = CultureHelper.GetTraduction(m.Formulacion_de_Imputacion_Formulacion_de_Imputacion.Clave.ToString(), "Descripcion") ?? (string)m.Formulacion_de_Imputacion_Formulacion_de_Imputacion.Descripcion

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
                _IAudiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAudiencia_InicialApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Audiencia_Inicial_Datos_GeneralesModel varAudiencia_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAudiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Audiencia_Inicial_Datos_GeneralesInfo = new Audiencia_Inicial_Datos_Generales
                {
                    Clave = varAudiencia_Inicial.Clave
                                            ,Expediente_MP = varAudiencia_Inicial.Expediente_MP
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varAudiencia_Inicial.Fecha_de_Registro)) ? DateTime.ParseExact(varAudiencia_Inicial.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varAudiencia_Inicial.Hora_de_Registro
                        ,Usuario_que_Registra = varAudiencia_Inicial.Usuario_que_Registra
                        ,Nombre_del_Juez_de_Control = varAudiencia_Inicial.Nombre_del_Juez_de_Control
                        ,Tipo = varAudiencia_Inicial.Tipo
                        ,causa_penal = varAudiencia_Inicial.causa_penal
                        ,Fecha_Audiencia_Inicial = (!String.IsNullOrEmpty(varAudiencia_Inicial.Fecha_Audiencia_Inicial)) ? DateTime.ParseExact(varAudiencia_Inicial.Fecha_Audiencia_Inicial, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Audiencia_Inicial = varAudiencia_Inicial.Hora_Audiencia_Inicial
                        ,Sala_de_Audiencia = varAudiencia_Inicial.Sala_de_Audiencia
                        ,Con_Detenido = varAudiencia_Inicial.Con_Detenido
                        ,Especificar_Detencion = varAudiencia_Inicial.Especificar_Detencion
                        ,Control_de_Detencion = varAudiencia_Inicial.Control_de_Detencion
                        ,Especificar_Control_Detencion = varAudiencia_Inicial.Especificar_Control_Detencion
                        ,Formulacion_de_Imputacion = varAudiencia_Inicial.Formulacion_de_Imputacion
                    
                };

                result = _IAudiencia_InicialApiConsumer.Update_Datos_Generales(Audiencia_Inicial_Datos_GeneralesInfo).Resource.ToString();
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
                _IAudiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IAudiencia_InicialApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Relaciones_Audiencia_Inicial;
                var Detalle_Relaciones_Audiencia_InicialData = GetDetalle_Relaciones_Audiencia_InicialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Relaciones_Audiencia_Inicial);

                var result = new Audiencia_Inicial_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Expediente_MP = m.Expediente_MP
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Nombre_del_Juez_de_Control = m.Nombre_del_Juez_de_Control
                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,causa_penal = m.causa_penal
                        ,Fecha_Audiencia_Inicial = (m.Fecha_Audiencia_Inicial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Audiencia_Inicial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Audiencia_Inicial = m.Hora_Audiencia_Inicial
			,Sala_de_Audiencia = m.Sala_de_Audiencia
                        ,Con_Detenido = m.Con_Detenido
                        ,Con_DetenidoDescripcion = CultureHelper.GetTraduction(m.Con_Detenido_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Con_Detenido_A_Tiempo.Descripcion
                        ,Especificar_Detencion = m.Especificar_Detencion
                        ,Especificar_DetencionDescripcion = CultureHelper.GetTraduction(m.Especificar_Detencion_Especificacion_Detencion.Clave.ToString(), "Descripcion") ?? (string)m.Especificar_Detencion_Especificacion_Detencion.Descripcion
                        ,Control_de_Detencion = m.Control_de_Detencion
                        ,Control_de_DetencionDescripcion = CultureHelper.GetTraduction(m.Control_de_Detencion_Control_de_Detencion.Clave.ToString(), "Descripcion") ?? (string)m.Control_de_Detencion_Control_de_Detencion.Descripcion
                        ,Especificar_Control_Detencion = m.Especificar_Control_Detencion
                        ,Especificar_Control_DetencionDescripcion = CultureHelper.GetTraduction(m.Especificar_Control_Detencion_Continuacion_de_Proceso.Clave.ToString(), "Descripcion") ?? (string)m.Especificar_Control_Detencion_Continuacion_de_Proceso.Descripcion
                        ,Formulacion_de_Imputacion = m.Formulacion_de_Imputacion
                        ,Formulacion_de_ImputacionDescripcion = CultureHelper.GetTraduction(m.Formulacion_de_Imputacion_Formulacion_de_Imputacion.Clave.ToString(), "Descripcion") ?? (string)m.Formulacion_de_Imputacion_Formulacion_de_Imputacion.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Relaciones = Detalle_Relaciones_Audiencia_InicialData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

