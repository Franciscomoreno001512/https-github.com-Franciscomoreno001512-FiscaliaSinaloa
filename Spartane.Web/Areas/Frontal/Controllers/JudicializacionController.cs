using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Judicializacion;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Resolucion_MP;
using Spartane.Core.Domain.Tipo_de_Judicializacion;
using Spartane.Core.Domain.Fase_de_Judicializacion;
using Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion;



using Spartane.Core.Domain.Tribunal_de_Enjuiciamiento;
using Spartane.Core.Domain.Sentencia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Judicializacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Judicializacion;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Resolucion_MP;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Judicializacion;
using Spartane.Web.Areas.WebApiConsumer.Fase_de_Judicializacion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Vinculacion_Judicializacion;


using Spartane.Web.Areas.WebApiConsumer.Tribunal_de_Enjuiciamiento;
using Spartane.Web.Areas.WebApiConsumer.Sentencia;

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
    public class JudicializacionController : Controller
    {
        #region "variable declaration"

        private IJudicializacionService service = null;
        private IJudicializacionApiConsumer _IJudicializacionApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private IResolucion_MPApiConsumer _IResolucion_MPApiConsumer;
        private ITipo_de_JudicializacionApiConsumer _ITipo_de_JudicializacionApiConsumer;
        private IFase_de_JudicializacionApiConsumer _IFase_de_JudicializacionApiConsumer;
        private IDetalle_Vinculacion_JudicializacionApiConsumer _IDetalle_Vinculacion_JudicializacionApiConsumer;


        private ITribunal_de_EnjuiciamientoApiConsumer _ITribunal_de_EnjuiciamientoApiConsumer;
        private ISentenciaApiConsumer _ISentenciaApiConsumer;

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

        
        public JudicializacionController(IJudicializacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IJudicializacionApiConsumer JudicializacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , IResolucion_MPApiConsumer Resolucion_MPApiConsumer , ITipo_de_JudicializacionApiConsumer Tipo_de_JudicializacionApiConsumer , IFase_de_JudicializacionApiConsumer Fase_de_JudicializacionApiConsumer , IDetalle_Vinculacion_JudicializacionApiConsumer Detalle_Vinculacion_JudicializacionApiConsumer  , ITribunal_de_EnjuiciamientoApiConsumer Tribunal_de_EnjuiciamientoApiConsumer , ISentenciaApiConsumer SentenciaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IJudicializacionApiConsumer = JudicializacionApiConsumer;
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
            this._IResolucion_MPApiConsumer = Resolucion_MPApiConsumer;
            this._ITipo_de_JudicializacionApiConsumer = Tipo_de_JudicializacionApiConsumer;
            this._IFase_de_JudicializacionApiConsumer = Fase_de_JudicializacionApiConsumer;
            this._IDetalle_Vinculacion_JudicializacionApiConsumer = Detalle_Vinculacion_JudicializacionApiConsumer;


            this._ITribunal_de_EnjuiciamientoApiConsumer = Tribunal_de_EnjuiciamientoApiConsumer;
            this._ISentenciaApiConsumer = SentenciaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Judicializacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45637, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45637, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Judicializacion/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45637, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45637, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varJudicializacion = new JudicializacionModel();
			varJudicializacion.Clave = Id;
			
            ViewBag.ObjectId = "45637";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_Vinculacion_Judicializacion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45638, ModuleId);
            ViewBag.PermissionDetalle_Vinculacion_Judicializacion = permissionDetalle_Vinculacion_Judicializacion;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var JudicializacionsData = _IJudicializacionApiConsumer.ListaSelAll(0, 1000, "Judicializacion.Clave=" + Id, "").Resource.Judicializacions;
				
				if (JudicializacionsData != null && JudicializacionsData.Count > 0)
                {
					var JudicializacionData = JudicializacionsData.First();
					varJudicializacion= new JudicializacionModel
					{
						Clave  = JudicializacionData.Clave 
	                    ,Expediente_MP = JudicializacionData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(JudicializacionData.Expediente_MP), "expediente_ministerio_publico") ??  (string)JudicializacionData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Resolucion = JudicializacionData.Resolucion
                    ,ResolucionObservaciones = CultureHelper.GetTraduction(Convert.ToString(JudicializacionData.Resolucion), "Resolucion_MP") ??  (string)JudicializacionData.Resolucion_Resolucion_MP.Observaciones
                    ,Tipo = JudicializacionData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(JudicializacionData.Tipo), "Tipo_de_Judicializacion") ??  (string)JudicializacionData.Tipo_Tipo_de_Judicializacion.Descripcion
                    ,causa_o_cuadernillo = JudicializacionData.causa_o_cuadernillo
                    ,Fase_Actual = JudicializacionData.Fase_Actual
                    ,Fase_ActualDescripcion = CultureHelper.GetTraduction(Convert.ToString(JudicializacionData.Fase_Actual), "Fase_de_Judicializacion") ??  (string)JudicializacionData.Fase_Actual_Fase_de_Judicializacion.Descripcion
                    ,Fecha_Actos = (JudicializacionData.Fecha_Actos == null ? string.Empty : Convert.ToDateTime(JudicializacionData.Fecha_Actos).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Actos = JudicializacionData.Hora_Actos
                    ,Observaciones_Actos = JudicializacionData.Observaciones_Actos
                    ,Fecha_Genericos = (JudicializacionData.Fecha_Genericos == null ? string.Empty : Convert.ToDateTime(JudicializacionData.Fecha_Genericos).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Genericos = JudicializacionData.Hora_Genericos
                    ,Observaciones_Genericos = JudicializacionData.Observaciones_Genericos
                    ,Fecha_Fase_Inicial = (JudicializacionData.Fecha_Fase_Inicial == null ? string.Empty : Convert.ToDateTime(JudicializacionData.Fecha_Fase_Inicial).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Fase_Inicial = JudicializacionData.Hora_Fase_Inicial
                    ,Observaciones_Fase_Inicial = JudicializacionData.Observaciones_Fase_Inicial
                    ,Fecha_Fase_Intermedia = (JudicializacionData.Fecha_Fase_Intermedia == null ? string.Empty : Convert.ToDateTime(JudicializacionData.Fecha_Fase_Intermedia).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Fase_Intermedia = JudicializacionData.Hora_Fase_Intermedia
                    ,Observaciones_Fase_Intermedia = JudicializacionData.Observaciones_Fase_Intermedia
                    ,Fecha_de_Audiencia_de_Juicio = (JudicializacionData.Fecha_de_Audiencia_de_Juicio == null ? string.Empty : Convert.ToDateTime(JudicializacionData.Fecha_de_Audiencia_de_Juicio).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Audiencia_de_Juicio = JudicializacionData.Hora_de_Audiencia_de_Juicio
                    ,Tribunal_de_Enjuiciamiento = JudicializacionData.Tribunal_de_Enjuiciamiento
                    ,Tribunal_de_EnjuiciamientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(JudicializacionData.Tribunal_de_Enjuiciamiento), "Tribunal_de_Enjuiciamiento") ??  (string)JudicializacionData.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Descripcion
                    ,Nombre_del_Juez = JudicializacionData.Nombre_del_Juez
                    ,Juez_Presidente = JudicializacionData.Juez_Presidente
                    ,Juez_Relator = JudicializacionData.Juez_Relator
                    ,Juez_Vocal = JudicializacionData.Juez_Vocal
                    ,medios_desahogo = JudicializacionData.medios_desahogo
                    ,Tipo_de_Sentencia = JudicializacionData.Tipo_de_Sentencia
                    ,Tipo_de_SentenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(JudicializacionData.Tipo_de_Sentencia), "Sentencia") ??  (string)JudicializacionData.Tipo_de_Sentencia_Sentencia.Descripcion
                    ,Cuantia_de_Pena_Anos = JudicializacionData.Cuantia_de_Pena_Anos
                    ,Cuantia_de_Pena_Meses = JudicializacionData.Cuantia_de_Pena_Meses
                    ,Monto_de_Reparacion_del_Dano = JudicializacionData.Monto_de_Reparacion_del_Dano
                    ,Observaciones_Fase_Juicio_Oral = JudicializacionData.Observaciones_Fase_Juicio_Oral
                    ,Fecha_Fase_Salidas_Alternas = (JudicializacionData.Fecha_Fase_Salidas_Alternas == null ? string.Empty : Convert.ToDateTime(JudicializacionData.Fecha_Fase_Salidas_Alternas).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Fase_Salidas_Alternas = JudicializacionData.Hora_Fase_Salidas_Alternas
                    ,Observaciones_Fase_Salidas_Alternas = JudicializacionData.Observaciones_Fase_Salidas_Alternas
                    ,Fecha_Fase_Sobreseimientos = (JudicializacionData.Fecha_Fase_Sobreseimientos == null ? string.Empty : Convert.ToDateTime(JudicializacionData.Fecha_Fase_Sobreseimientos).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Fase_Sobreseimientos = JudicializacionData.Hora_Fase_Sobreseimientos
                    ,Observaciones_Fase_Sobreseimientos = JudicializacionData.Observaciones_Fase_Sobreseimientos
                    ,Observaciones = JudicializacionData.Observaciones

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
            _IFase_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fase_de_Judicializacions_Fase_Actual = _IFase_de_JudicializacionApiConsumer.SelAll(true);
            if (Fase_de_Judicializacions_Fase_Actual != null && Fase_de_Judicializacions_Fase_Actual.Resource != null)
                ViewBag.Fase_de_Judicializacions_Fase_Actual = Fase_de_Judicializacions_Fase_Actual.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fase_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITribunal_de_EnjuiciamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = _ITribunal_de_EnjuiciamientoApiConsumer.SelAll(true);
            if (Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento != null && Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource != null)
                ViewBag.Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tribunal_de_Enjuiciamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sentencias_Tipo_de_Sentencia = _ISentenciaApiConsumer.SelAll(true);
            if (Sentencias_Tipo_de_Sentencia != null && Sentencias_Tipo_de_Sentencia.Resource != null)
                ViewBag.Sentencias_Tipo_de_Sentencia = Sentencias_Tipo_de_Sentencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varJudicializacion);
        }
		
	[HttpGet]
        public ActionResult AddJudicializacion(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45637);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			JudicializacionModel varJudicializacion= new JudicializacionModel();
            var permissionDetalle_Vinculacion_Judicializacion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45638, ModuleId);
            ViewBag.PermissionDetalle_Vinculacion_Judicializacion = permissionDetalle_Vinculacion_Judicializacion;


            if (id.ToString() != "0")
            {
                var JudicializacionsData = _IJudicializacionApiConsumer.ListaSelAll(0, 1000, "Judicializacion.Clave=" + id, "").Resource.Judicializacions;
				
				if (JudicializacionsData != null && JudicializacionsData.Count > 0)
                {
					var JudicializacionData = JudicializacionsData.First();
					varJudicializacion= new JudicializacionModel
					{
						Clave  = JudicializacionData.Clave 
	                    ,Expediente_MP = JudicializacionData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(JudicializacionData.Expediente_MP), "expediente_ministerio_publico") ??  (string)JudicializacionData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Resolucion = JudicializacionData.Resolucion
                    ,ResolucionObservaciones = CultureHelper.GetTraduction(Convert.ToString(JudicializacionData.Resolucion), "Resolucion_MP") ??  (string)JudicializacionData.Resolucion_Resolucion_MP.Observaciones
                    ,Tipo = JudicializacionData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(JudicializacionData.Tipo), "Tipo_de_Judicializacion") ??  (string)JudicializacionData.Tipo_Tipo_de_Judicializacion.Descripcion
                    ,causa_o_cuadernillo = JudicializacionData.causa_o_cuadernillo
                    ,Fase_Actual = JudicializacionData.Fase_Actual
                    ,Fase_ActualDescripcion = CultureHelper.GetTraduction(Convert.ToString(JudicializacionData.Fase_Actual), "Fase_de_Judicializacion") ??  (string)JudicializacionData.Fase_Actual_Fase_de_Judicializacion.Descripcion
                    ,Fecha_Actos = (JudicializacionData.Fecha_Actos == null ? string.Empty : Convert.ToDateTime(JudicializacionData.Fecha_Actos).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Actos = JudicializacionData.Hora_Actos
                    ,Observaciones_Actos = JudicializacionData.Observaciones_Actos
                    ,Fecha_Genericos = (JudicializacionData.Fecha_Genericos == null ? string.Empty : Convert.ToDateTime(JudicializacionData.Fecha_Genericos).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Genericos = JudicializacionData.Hora_Genericos
                    ,Observaciones_Genericos = JudicializacionData.Observaciones_Genericos
                    ,Fecha_Fase_Inicial = (JudicializacionData.Fecha_Fase_Inicial == null ? string.Empty : Convert.ToDateTime(JudicializacionData.Fecha_Fase_Inicial).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Fase_Inicial = JudicializacionData.Hora_Fase_Inicial
                    ,Observaciones_Fase_Inicial = JudicializacionData.Observaciones_Fase_Inicial
                    ,Fecha_Fase_Intermedia = (JudicializacionData.Fecha_Fase_Intermedia == null ? string.Empty : Convert.ToDateTime(JudicializacionData.Fecha_Fase_Intermedia).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Fase_Intermedia = JudicializacionData.Hora_Fase_Intermedia
                    ,Observaciones_Fase_Intermedia = JudicializacionData.Observaciones_Fase_Intermedia
                    ,Fecha_de_Audiencia_de_Juicio = (JudicializacionData.Fecha_de_Audiencia_de_Juicio == null ? string.Empty : Convert.ToDateTime(JudicializacionData.Fecha_de_Audiencia_de_Juicio).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Audiencia_de_Juicio = JudicializacionData.Hora_de_Audiencia_de_Juicio
                    ,Tribunal_de_Enjuiciamiento = JudicializacionData.Tribunal_de_Enjuiciamiento
                    ,Tribunal_de_EnjuiciamientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(JudicializacionData.Tribunal_de_Enjuiciamiento), "Tribunal_de_Enjuiciamiento") ??  (string)JudicializacionData.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Descripcion
                    ,Nombre_del_Juez = JudicializacionData.Nombre_del_Juez
                    ,Juez_Presidente = JudicializacionData.Juez_Presidente
                    ,Juez_Relator = JudicializacionData.Juez_Relator
                    ,Juez_Vocal = JudicializacionData.Juez_Vocal
                    ,medios_desahogo = JudicializacionData.medios_desahogo
                    ,Tipo_de_Sentencia = JudicializacionData.Tipo_de_Sentencia
                    ,Tipo_de_SentenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(JudicializacionData.Tipo_de_Sentencia), "Sentencia") ??  (string)JudicializacionData.Tipo_de_Sentencia_Sentencia.Descripcion
                    ,Cuantia_de_Pena_Anos = JudicializacionData.Cuantia_de_Pena_Anos
                    ,Cuantia_de_Pena_Meses = JudicializacionData.Cuantia_de_Pena_Meses
                    ,Monto_de_Reparacion_del_Dano = JudicializacionData.Monto_de_Reparacion_del_Dano
                    ,Observaciones_Fase_Juicio_Oral = JudicializacionData.Observaciones_Fase_Juicio_Oral
                    ,Fecha_Fase_Salidas_Alternas = (JudicializacionData.Fecha_Fase_Salidas_Alternas == null ? string.Empty : Convert.ToDateTime(JudicializacionData.Fecha_Fase_Salidas_Alternas).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Fase_Salidas_Alternas = JudicializacionData.Hora_Fase_Salidas_Alternas
                    ,Observaciones_Fase_Salidas_Alternas = JudicializacionData.Observaciones_Fase_Salidas_Alternas
                    ,Fecha_Fase_Sobreseimientos = (JudicializacionData.Fecha_Fase_Sobreseimientos == null ? string.Empty : Convert.ToDateTime(JudicializacionData.Fecha_Fase_Sobreseimientos).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Fase_Sobreseimientos = JudicializacionData.Hora_Fase_Sobreseimientos
                    ,Observaciones_Fase_Sobreseimientos = JudicializacionData.Observaciones_Fase_Sobreseimientos
                    ,Observaciones = JudicializacionData.Observaciones

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
            _IFase_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fase_de_Judicializacions_Fase_Actual = _IFase_de_JudicializacionApiConsumer.SelAll(true);
            if (Fase_de_Judicializacions_Fase_Actual != null && Fase_de_Judicializacions_Fase_Actual.Resource != null)
                ViewBag.Fase_de_Judicializacions_Fase_Actual = Fase_de_Judicializacions_Fase_Actual.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fase_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITribunal_de_EnjuiciamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = _ITribunal_de_EnjuiciamientoApiConsumer.SelAll(true);
            if (Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento != null && Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource != null)
                ViewBag.Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tribunal_de_Enjuiciamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sentencias_Tipo_de_Sentencia = _ISentenciaApiConsumer.SelAll(true);
            if (Sentencias_Tipo_de_Sentencia != null && Sentencias_Tipo_de_Sentencia.Resource != null)
                ViewBag.Sentencias_Tipo_de_Sentencia = Sentencias_Tipo_de_Sentencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddJudicializacion", varJudicializacion);
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
        public ActionResult GetResolucion_MPAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResolucion_MPApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Observaciones).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_MP", "Observaciones")?? m.Observaciones,
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
        public ActionResult GetTribunal_de_EnjuiciamientoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITribunal_de_EnjuiciamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITribunal_de_EnjuiciamientoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tribunal_de_Enjuiciamiento", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetSentenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISentenciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(JudicializacionAdvanceSearchModel model, int idFilter = -1)
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
            _IFase_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fase_de_Judicializacions_Fase_Actual = _IFase_de_JudicializacionApiConsumer.SelAll(true);
            if (Fase_de_Judicializacions_Fase_Actual != null && Fase_de_Judicializacions_Fase_Actual.Resource != null)
                ViewBag.Fase_de_Judicializacions_Fase_Actual = Fase_de_Judicializacions_Fase_Actual.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fase_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITribunal_de_EnjuiciamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = _ITribunal_de_EnjuiciamientoApiConsumer.SelAll(true);
            if (Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento != null && Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource != null)
                ViewBag.Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tribunal_de_Enjuiciamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sentencias_Tipo_de_Sentencia = _ISentenciaApiConsumer.SelAll(true);
            if (Sentencias_Tipo_de_Sentencia != null && Sentencias_Tipo_de_Sentencia.Resource != null)
                ViewBag.Sentencias_Tipo_de_Sentencia = Sentencias_Tipo_de_Sentencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IFase_de_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fase_de_Judicializacions_Fase_Actual = _IFase_de_JudicializacionApiConsumer.SelAll(true);
            if (Fase_de_Judicializacions_Fase_Actual != null && Fase_de_Judicializacions_Fase_Actual.Resource != null)
                ViewBag.Fase_de_Judicializacions_Fase_Actual = Fase_de_Judicializacions_Fase_Actual.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fase_de_Judicializacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITribunal_de_EnjuiciamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = _ITribunal_de_EnjuiciamientoApiConsumer.SelAll(true);
            if (Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento != null && Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource != null)
                ViewBag.Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento = Tribunal_de_Enjuiciamientos_Tribunal_de_Enjuiciamiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tribunal_de_Enjuiciamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sentencias_Tipo_de_Sentencia = _ISentenciaApiConsumer.SelAll(true);
            if (Sentencias_Tipo_de_Sentencia != null && Sentencias_Tipo_de_Sentencia.Resource != null)
                ViewBag.Sentencias_Tipo_de_Sentencia = Sentencias_Tipo_de_Sentencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new JudicializacionAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (JudicializacionAdvanceSearchModel)(Session["AdvanceSearch"] ?? new JudicializacionAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new JudicializacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IJudicializacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Judicializacions == null)
                result.Judicializacions = new List<Judicializacion>();

            return Json(new
            {
                data = result.Judicializacions.Select(m => new JudicializacionGridModel
                    {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,ResolucionObservaciones = CultureHelper.GetTraduction(m.Resolucion_Resolucion_MP.Clave.ToString(), "Resolucion_MP") ?? (string)m.Resolucion_Resolucion_MP.Observaciones
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,causa_o_cuadernillo = m.causa_o_cuadernillo
                        ,Fase_ActualDescripcion = CultureHelper.GetTraduction(m.Fase_Actual_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Actual_Fase_de_Judicializacion.Descripcion
                        ,Fecha_Actos = (m.Fecha_Actos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Actos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Actos = m.Hora_Actos
			,Observaciones_Actos = m.Observaciones_Actos
                        ,Fecha_Genericos = (m.Fecha_Genericos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Genericos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Genericos = m.Hora_Genericos
			,Observaciones_Genericos = m.Observaciones_Genericos
                        ,Fecha_Fase_Inicial = (m.Fecha_Fase_Inicial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Inicial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Inicial = m.Hora_Fase_Inicial
			,Observaciones_Fase_Inicial = m.Observaciones_Fase_Inicial
                        ,Fecha_Fase_Intermedia = (m.Fecha_Fase_Intermedia == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Intermedia).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Intermedia = m.Hora_Fase_Intermedia
			,Observaciones_Fase_Intermedia = m.Observaciones_Fase_Intermedia
                        ,Fecha_de_Audiencia_de_Juicio = (m.Fecha_de_Audiencia_de_Juicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_de_Juicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_de_Juicio = m.Hora_de_Audiencia_de_Juicio
                        ,Tribunal_de_EnjuiciamientoDescripcion = CultureHelper.GetTraduction(m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Descripcion
			,Nombre_del_Juez = m.Nombre_del_Juez
			,Juez_Presidente = m.Juez_Presidente
			,Juez_Relator = m.Juez_Relator
			,Juez_Vocal = m.Juez_Vocal
			,medios_desahogo = m.medios_desahogo
                        ,Tipo_de_SentenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sentencia_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sentencia_Sentencia.Descripcion
			,Cuantia_de_Pena_Anos = m.Cuantia_de_Pena_Anos
			,Cuantia_de_Pena_Meses = m.Cuantia_de_Pena_Meses
			,Monto_de_Reparacion_del_Dano = m.Monto_de_Reparacion_del_Dano
			,Observaciones_Fase_Juicio_Oral = m.Observaciones_Fase_Juicio_Oral
                        ,Fecha_Fase_Salidas_Alternas = (m.Fecha_Fase_Salidas_Alternas == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Salidas_Alternas).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Salidas_Alternas = m.Hora_Fase_Salidas_Alternas
			,Observaciones_Fase_Salidas_Alternas = m.Observaciones_Fase_Salidas_Alternas
                        ,Fecha_Fase_Sobreseimientos = (m.Fecha_Fase_Sobreseimientos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Sobreseimientos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Sobreseimientos = m.Hora_Fase_Sobreseimientos
			,Observaciones_Fase_Sobreseimientos = m.Observaciones_Fase_Sobreseimientos
			,Observaciones = m.Observaciones

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetJudicializacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IJudicializacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Judicializacion", m.),
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
        /// Get List of Judicializacion from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Judicializacion Entity</returns>
        public ActionResult GetJudicializacionList(UrlParametersModel param)
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
            _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new JudicializacionPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(JudicializacionAdvanceSearchModel))
                {
					var advanceFilter =
                    (JudicializacionAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            JudicializacionPropertyMapper oJudicializacionPropertyMapper = new JudicializacionPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oJudicializacionPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IJudicializacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Judicializacions == null)
                result.Judicializacions = new List<Judicializacion>();

            return Json(new
            {
                aaData = result.Judicializacions.Select(m => new JudicializacionGridModel
            {
                    Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,ResolucionObservaciones = CultureHelper.GetTraduction(m.Resolucion_Resolucion_MP.Clave.ToString(), "Resolucion_MP") ?? (string)m.Resolucion_Resolucion_MP.Observaciones
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,causa_o_cuadernillo = m.causa_o_cuadernillo
                        ,Fase_ActualDescripcion = CultureHelper.GetTraduction(m.Fase_Actual_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Actual_Fase_de_Judicializacion.Descripcion
                        ,Fecha_Actos = (m.Fecha_Actos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Actos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Actos = m.Hora_Actos
			,Observaciones_Actos = m.Observaciones_Actos
                        ,Fecha_Genericos = (m.Fecha_Genericos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Genericos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Genericos = m.Hora_Genericos
			,Observaciones_Genericos = m.Observaciones_Genericos
                        ,Fecha_Fase_Inicial = (m.Fecha_Fase_Inicial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Inicial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Inicial = m.Hora_Fase_Inicial
			,Observaciones_Fase_Inicial = m.Observaciones_Fase_Inicial
                        ,Fecha_Fase_Intermedia = (m.Fecha_Fase_Intermedia == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Intermedia).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Intermedia = m.Hora_Fase_Intermedia
			,Observaciones_Fase_Intermedia = m.Observaciones_Fase_Intermedia
                        ,Fecha_de_Audiencia_de_Juicio = (m.Fecha_de_Audiencia_de_Juicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_de_Juicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_de_Juicio = m.Hora_de_Audiencia_de_Juicio
                        ,Tribunal_de_EnjuiciamientoDescripcion = CultureHelper.GetTraduction(m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Descripcion
			,Nombre_del_Juez = m.Nombre_del_Juez
			,Juez_Presidente = m.Juez_Presidente
			,Juez_Relator = m.Juez_Relator
			,Juez_Vocal = m.Juez_Vocal
			,medios_desahogo = m.medios_desahogo
                        ,Tipo_de_SentenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sentencia_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sentencia_Sentencia.Descripcion
			,Cuantia_de_Pena_Anos = m.Cuantia_de_Pena_Anos
			,Cuantia_de_Pena_Meses = m.Cuantia_de_Pena_Meses
			,Monto_de_Reparacion_del_Dano = m.Monto_de_Reparacion_del_Dano
			,Observaciones_Fase_Juicio_Oral = m.Observaciones_Fase_Juicio_Oral
                        ,Fecha_Fase_Salidas_Alternas = (m.Fecha_Fase_Salidas_Alternas == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Salidas_Alternas).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Salidas_Alternas = m.Hora_Fase_Salidas_Alternas
			,Observaciones_Fase_Salidas_Alternas = m.Observaciones_Fase_Salidas_Alternas
                        ,Fecha_Fase_Sobreseimientos = (m.Fecha_Fase_Sobreseimientos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Sobreseimientos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Sobreseimientos = m.Hora_Fase_Sobreseimientos
			,Observaciones_Fase_Sobreseimientos = m.Observaciones_Fase_Sobreseimientos
			,Observaciones = m.Observaciones

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetJudicializacion_Expediente_MP_expediente_ministerio_publico(string query, string where)
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
        public JsonResult GetJudicializacion_Resolucion_Resolucion_MP(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Resolucion_MP.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Resolucion_MP.Observaciones as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IResolucion_MPApiConsumer.ListaSelAll(1, 20,elWhere , " Resolucion_MP.Observaciones ASC ").Resource;
               
                foreach (var item in result.Resolucion_MPs)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Resolucion_MP", "Observaciones");
                    item.Observaciones =trans ??item.Observaciones;
                }
                return Json(result.Resolucion_MPs.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(JudicializacionAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Judicializacion.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Judicializacion.Clave <= " + filter.ToClave;
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

                where += " AND Judicializacion.Expediente_MP In (" + Expediente_MPIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResolucion))
            {
                switch (filter.ResolucionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion_MP.Observaciones LIKE '" + filter.AdvanceResolucion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion_MP.Observaciones LIKE '%" + filter.AdvanceResolucion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion_MP.Observaciones = '" + filter.AdvanceResolucion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion_MP.Observaciones LIKE '%" + filter.AdvanceResolucion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResolucionMultiple != null && filter.AdvanceResolucionMultiple.Count() > 0)
            {
                var ResolucionIds = string.Join(",", filter.AdvanceResolucionMultiple);

                where += " AND Judicializacion.Resolucion In (" + ResolucionIds + ")";
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

                where += " AND Judicializacion.Tipo In (" + TipoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.causa_o_cuadernillo))
            {
                switch (filter.causa_o_cuadernilloFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.causa_o_cuadernillo LIKE '" + filter.causa_o_cuadernillo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.causa_o_cuadernillo LIKE '%" + filter.causa_o_cuadernillo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.causa_o_cuadernillo = '" + filter.causa_o_cuadernillo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.causa_o_cuadernillo LIKE '%" + filter.causa_o_cuadernillo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceFase_Actual))
            {
                switch (filter.Fase_ActualFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Fase_de_Judicializacion.Descripcion LIKE '" + filter.AdvanceFase_Actual + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Fase_de_Judicializacion.Descripcion LIKE '%" + filter.AdvanceFase_Actual + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Fase_de_Judicializacion.Descripcion = '" + filter.AdvanceFase_Actual + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Fase_de_Judicializacion.Descripcion LIKE '%" + filter.AdvanceFase_Actual + "%'";
                        break;
                }
            }
            else if (filter.AdvanceFase_ActualMultiple != null && filter.AdvanceFase_ActualMultiple.Count() > 0)
            {
                var Fase_ActualIds = string.Join(",", filter.AdvanceFase_ActualMultiple);

                where += " AND Judicializacion.Fase_Actual In (" + Fase_ActualIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Actos) || !string.IsNullOrEmpty(filter.ToFecha_Actos))
            {
                var Fecha_ActosFrom = DateTime.ParseExact(filter.FromFecha_Actos, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_ActosTo = DateTime.ParseExact(filter.ToFecha_Actos, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Actos))
                    where += " AND Judicializacion.Fecha_Actos >= '" + Fecha_ActosFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Actos))
                    where += " AND Judicializacion.Fecha_Actos <= '" + Fecha_ActosTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Actos) || !string.IsNullOrEmpty(filter.ToHora_Actos))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Actos))
                    where += " AND Convert(TIME,Judicializacion.Hora_Actos) >='" + filter.FromHora_Actos + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Actos))
                    where += " AND Convert(TIME,Judicializacion.Hora_Actos) <='" + filter.ToHora_Actos + "'";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_Actos))
            {
                switch (filter.Observaciones_ActosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.Observaciones_Actos LIKE '" + filter.Observaciones_Actos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.Observaciones_Actos LIKE '%" + filter.Observaciones_Actos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.Observaciones_Actos = '" + filter.Observaciones_Actos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.Observaciones_Actos LIKE '%" + filter.Observaciones_Actos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Genericos) || !string.IsNullOrEmpty(filter.ToFecha_Genericos))
            {
                var Fecha_GenericosFrom = DateTime.ParseExact(filter.FromFecha_Genericos, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_GenericosTo = DateTime.ParseExact(filter.ToFecha_Genericos, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Genericos))
                    where += " AND Judicializacion.Fecha_Genericos >= '" + Fecha_GenericosFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Genericos))
                    where += " AND Judicializacion.Fecha_Genericos <= '" + Fecha_GenericosTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Genericos) || !string.IsNullOrEmpty(filter.ToHora_Genericos))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Genericos))
                    where += " AND Convert(TIME,Judicializacion.Hora_Genericos) >='" + filter.FromHora_Genericos + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Genericos))
                    where += " AND Convert(TIME,Judicializacion.Hora_Genericos) <='" + filter.ToHora_Genericos + "'";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_Genericos))
            {
                switch (filter.Observaciones_GenericosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.Observaciones_Genericos LIKE '" + filter.Observaciones_Genericos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.Observaciones_Genericos LIKE '%" + filter.Observaciones_Genericos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.Observaciones_Genericos = '" + filter.Observaciones_Genericos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.Observaciones_Genericos LIKE '%" + filter.Observaciones_Genericos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Fase_Inicial) || !string.IsNullOrEmpty(filter.ToFecha_Fase_Inicial))
            {
                var Fecha_Fase_InicialFrom = DateTime.ParseExact(filter.FromFecha_Fase_Inicial, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_Fase_InicialTo = DateTime.ParseExact(filter.ToFecha_Fase_Inicial, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Fase_Inicial))
                    where += " AND Judicializacion.Fecha_Fase_Inicial >= '" + Fecha_Fase_InicialFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Fase_Inicial))
                    where += " AND Judicializacion.Fecha_Fase_Inicial <= '" + Fecha_Fase_InicialTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Fase_Inicial) || !string.IsNullOrEmpty(filter.ToHora_Fase_Inicial))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Fase_Inicial))
                    where += " AND Convert(TIME,Judicializacion.Hora_Fase_Inicial) >='" + filter.FromHora_Fase_Inicial + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Fase_Inicial))
                    where += " AND Convert(TIME,Judicializacion.Hora_Fase_Inicial) <='" + filter.ToHora_Fase_Inicial + "'";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_Fase_Inicial))
            {
                switch (filter.Observaciones_Fase_InicialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.Observaciones_Fase_Inicial LIKE '" + filter.Observaciones_Fase_Inicial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.Observaciones_Fase_Inicial LIKE '%" + filter.Observaciones_Fase_Inicial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.Observaciones_Fase_Inicial = '" + filter.Observaciones_Fase_Inicial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.Observaciones_Fase_Inicial LIKE '%" + filter.Observaciones_Fase_Inicial + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Fase_Intermedia) || !string.IsNullOrEmpty(filter.ToFecha_Fase_Intermedia))
            {
                var Fecha_Fase_IntermediaFrom = DateTime.ParseExact(filter.FromFecha_Fase_Intermedia, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_Fase_IntermediaTo = DateTime.ParseExact(filter.ToFecha_Fase_Intermedia, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Fase_Intermedia))
                    where += " AND Judicializacion.Fecha_Fase_Intermedia >= '" + Fecha_Fase_IntermediaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Fase_Intermedia))
                    where += " AND Judicializacion.Fecha_Fase_Intermedia <= '" + Fecha_Fase_IntermediaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Fase_Intermedia) || !string.IsNullOrEmpty(filter.ToHora_Fase_Intermedia))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Fase_Intermedia))
                    where += " AND Convert(TIME,Judicializacion.Hora_Fase_Intermedia) >='" + filter.FromHora_Fase_Intermedia + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Fase_Intermedia))
                    where += " AND Convert(TIME,Judicializacion.Hora_Fase_Intermedia) <='" + filter.ToHora_Fase_Intermedia + "'";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_Fase_Intermedia))
            {
                switch (filter.Observaciones_Fase_IntermediaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.Observaciones_Fase_Intermedia LIKE '" + filter.Observaciones_Fase_Intermedia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.Observaciones_Fase_Intermedia LIKE '%" + filter.Observaciones_Fase_Intermedia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.Observaciones_Fase_Intermedia = '" + filter.Observaciones_Fase_Intermedia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.Observaciones_Fase_Intermedia LIKE '%" + filter.Observaciones_Fase_Intermedia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Audiencia_de_Juicio) || !string.IsNullOrEmpty(filter.ToFecha_de_Audiencia_de_Juicio))
            {
                var Fecha_de_Audiencia_de_JuicioFrom = DateTime.ParseExact(filter.FromFecha_de_Audiencia_de_Juicio, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Audiencia_de_JuicioTo = DateTime.ParseExact(filter.ToFecha_de_Audiencia_de_Juicio, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Audiencia_de_Juicio))
                    where += " AND Judicializacion.Fecha_de_Audiencia_de_Juicio >= '" + Fecha_de_Audiencia_de_JuicioFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Audiencia_de_Juicio))
                    where += " AND Judicializacion.Fecha_de_Audiencia_de_Juicio <= '" + Fecha_de_Audiencia_de_JuicioTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Audiencia_de_Juicio) || !string.IsNullOrEmpty(filter.ToHora_de_Audiencia_de_Juicio))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Audiencia_de_Juicio))
                    where += " AND Convert(TIME,Judicializacion.Hora_de_Audiencia_de_Juicio) >='" + filter.FromHora_de_Audiencia_de_Juicio + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Audiencia_de_Juicio))
                    where += " AND Convert(TIME,Judicializacion.Hora_de_Audiencia_de_Juicio) <='" + filter.ToHora_de_Audiencia_de_Juicio + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTribunal_de_Enjuiciamiento))
            {
                switch (filter.Tribunal_de_EnjuiciamientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tribunal_de_Enjuiciamiento.Descripcion LIKE '" + filter.AdvanceTribunal_de_Enjuiciamiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tribunal_de_Enjuiciamiento.Descripcion LIKE '%" + filter.AdvanceTribunal_de_Enjuiciamiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tribunal_de_Enjuiciamiento.Descripcion = '" + filter.AdvanceTribunal_de_Enjuiciamiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tribunal_de_Enjuiciamiento.Descripcion LIKE '%" + filter.AdvanceTribunal_de_Enjuiciamiento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTribunal_de_EnjuiciamientoMultiple != null && filter.AdvanceTribunal_de_EnjuiciamientoMultiple.Count() > 0)
            {
                var Tribunal_de_EnjuiciamientoIds = string.Join(",", filter.AdvanceTribunal_de_EnjuiciamientoMultiple);

                where += " AND Judicializacion.Tribunal_de_Enjuiciamiento In (" + Tribunal_de_EnjuiciamientoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombre_del_Juez))
            {
                switch (filter.Nombre_del_JuezFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.Nombre_del_Juez LIKE '" + filter.Nombre_del_Juez + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.Nombre_del_Juez LIKE '%" + filter.Nombre_del_Juez + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.Nombre_del_Juez = '" + filter.Nombre_del_Juez + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.Nombre_del_Juez LIKE '%" + filter.Nombre_del_Juez + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Juez_Presidente))
            {
                switch (filter.Juez_PresidenteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.Juez_Presidente LIKE '" + filter.Juez_Presidente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.Juez_Presidente LIKE '%" + filter.Juez_Presidente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.Juez_Presidente = '" + filter.Juez_Presidente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.Juez_Presidente LIKE '%" + filter.Juez_Presidente + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Juez_Relator))
            {
                switch (filter.Juez_RelatorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.Juez_Relator LIKE '" + filter.Juez_Relator + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.Juez_Relator LIKE '%" + filter.Juez_Relator + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.Juez_Relator = '" + filter.Juez_Relator + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.Juez_Relator LIKE '%" + filter.Juez_Relator + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Juez_Vocal))
            {
                switch (filter.Juez_VocalFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.Juez_Vocal LIKE '" + filter.Juez_Vocal + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.Juez_Vocal LIKE '%" + filter.Juez_Vocal + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.Juez_Vocal = '" + filter.Juez_Vocal + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.Juez_Vocal LIKE '%" + filter.Juez_Vocal + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.medios_desahogo))
            {
                switch (filter.medios_desahogoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.medios_desahogo LIKE '" + filter.medios_desahogo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.medios_desahogo LIKE '%" + filter.medios_desahogo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.medios_desahogo = '" + filter.medios_desahogo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.medios_desahogo LIKE '%" + filter.medios_desahogo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Sentencia))
            {
                switch (filter.Tipo_de_SentenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Sentencia.Descripcion LIKE '" + filter.AdvanceTipo_de_Sentencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Sentencia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Sentencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Sentencia.Descripcion = '" + filter.AdvanceTipo_de_Sentencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Sentencia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Sentencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_SentenciaMultiple != null && filter.AdvanceTipo_de_SentenciaMultiple.Count() > 0)
            {
                var Tipo_de_SentenciaIds = string.Join(",", filter.AdvanceTipo_de_SentenciaMultiple);

                where += " AND Judicializacion.Tipo_de_Sentencia In (" + Tipo_de_SentenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCuantia_de_Pena_Anos) || !string.IsNullOrEmpty(filter.ToCuantia_de_Pena_Anos))
            {
                if (!string.IsNullOrEmpty(filter.FromCuantia_de_Pena_Anos))
                    where += " AND Judicializacion.Cuantia_de_Pena_Anos >= " + filter.FromCuantia_de_Pena_Anos;
                if (!string.IsNullOrEmpty(filter.ToCuantia_de_Pena_Anos))
                    where += " AND Judicializacion.Cuantia_de_Pena_Anos <= " + filter.ToCuantia_de_Pena_Anos;
            }

            if (!string.IsNullOrEmpty(filter.FromCuantia_de_Pena_Meses) || !string.IsNullOrEmpty(filter.ToCuantia_de_Pena_Meses))
            {
                if (!string.IsNullOrEmpty(filter.FromCuantia_de_Pena_Meses))
                    where += " AND Judicializacion.Cuantia_de_Pena_Meses >= " + filter.FromCuantia_de_Pena_Meses;
                if (!string.IsNullOrEmpty(filter.ToCuantia_de_Pena_Meses))
                    where += " AND Judicializacion.Cuantia_de_Pena_Meses <= " + filter.ToCuantia_de_Pena_Meses;
            }

            if (!string.IsNullOrEmpty(filter.FromMonto_de_Reparacion_del_Dano) || !string.IsNullOrEmpty(filter.ToMonto_de_Reparacion_del_Dano))
            {
                if (!string.IsNullOrEmpty(filter.FromMonto_de_Reparacion_del_Dano))
                    where += " AND Judicializacion.Monto_de_Reparacion_del_Dano >= " + filter.FromMonto_de_Reparacion_del_Dano;
                if (!string.IsNullOrEmpty(filter.ToMonto_de_Reparacion_del_Dano))
                    where += " AND Judicializacion.Monto_de_Reparacion_del_Dano <= " + filter.ToMonto_de_Reparacion_del_Dano;
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_Fase_Juicio_Oral))
            {
                switch (filter.Observaciones_Fase_Juicio_OralFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.Observaciones_Fase_Juicio_Oral LIKE '" + filter.Observaciones_Fase_Juicio_Oral + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.Observaciones_Fase_Juicio_Oral LIKE '%" + filter.Observaciones_Fase_Juicio_Oral + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.Observaciones_Fase_Juicio_Oral = '" + filter.Observaciones_Fase_Juicio_Oral + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.Observaciones_Fase_Juicio_Oral LIKE '%" + filter.Observaciones_Fase_Juicio_Oral + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Fase_Salidas_Alternas) || !string.IsNullOrEmpty(filter.ToFecha_Fase_Salidas_Alternas))
            {
                var Fecha_Fase_Salidas_AlternasFrom = DateTime.ParseExact(filter.FromFecha_Fase_Salidas_Alternas, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_Fase_Salidas_AlternasTo = DateTime.ParseExact(filter.ToFecha_Fase_Salidas_Alternas, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Fase_Salidas_Alternas))
                    where += " AND Judicializacion.Fecha_Fase_Salidas_Alternas >= '" + Fecha_Fase_Salidas_AlternasFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Fase_Salidas_Alternas))
                    where += " AND Judicializacion.Fecha_Fase_Salidas_Alternas <= '" + Fecha_Fase_Salidas_AlternasTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Fase_Salidas_Alternas) || !string.IsNullOrEmpty(filter.ToHora_Fase_Salidas_Alternas))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Fase_Salidas_Alternas))
                    where += " AND Convert(TIME,Judicializacion.Hora_Fase_Salidas_Alternas) >='" + filter.FromHora_Fase_Salidas_Alternas + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Fase_Salidas_Alternas))
                    where += " AND Convert(TIME,Judicializacion.Hora_Fase_Salidas_Alternas) <='" + filter.ToHora_Fase_Salidas_Alternas + "'";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_Fase_Salidas_Alternas))
            {
                switch (filter.Observaciones_Fase_Salidas_AlternasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.Observaciones_Fase_Salidas_Alternas LIKE '" + filter.Observaciones_Fase_Salidas_Alternas + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.Observaciones_Fase_Salidas_Alternas LIKE '%" + filter.Observaciones_Fase_Salidas_Alternas + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.Observaciones_Fase_Salidas_Alternas = '" + filter.Observaciones_Fase_Salidas_Alternas + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.Observaciones_Fase_Salidas_Alternas LIKE '%" + filter.Observaciones_Fase_Salidas_Alternas + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Fase_Sobreseimientos) || !string.IsNullOrEmpty(filter.ToFecha_Fase_Sobreseimientos))
            {
                var Fecha_Fase_SobreseimientosFrom = DateTime.ParseExact(filter.FromFecha_Fase_Sobreseimientos, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_Fase_SobreseimientosTo = DateTime.ParseExact(filter.ToFecha_Fase_Sobreseimientos, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Fase_Sobreseimientos))
                    where += " AND Judicializacion.Fecha_Fase_Sobreseimientos >= '" + Fecha_Fase_SobreseimientosFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Fase_Sobreseimientos))
                    where += " AND Judicializacion.Fecha_Fase_Sobreseimientos <= '" + Fecha_Fase_SobreseimientosTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Fase_Sobreseimientos) || !string.IsNullOrEmpty(filter.ToHora_Fase_Sobreseimientos))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Fase_Sobreseimientos))
                    where += " AND Convert(TIME,Judicializacion.Hora_Fase_Sobreseimientos) >='" + filter.FromHora_Fase_Sobreseimientos + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Fase_Sobreseimientos))
                    where += " AND Convert(TIME,Judicializacion.Hora_Fase_Sobreseimientos) <='" + filter.ToHora_Fase_Sobreseimientos + "'";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_Fase_Sobreseimientos))
            {
                switch (filter.Observaciones_Fase_SobreseimientosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.Observaciones_Fase_Sobreseimientos LIKE '" + filter.Observaciones_Fase_Sobreseimientos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.Observaciones_Fase_Sobreseimientos LIKE '%" + filter.Observaciones_Fase_Sobreseimientos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.Observaciones_Fase_Sobreseimientos = '" + filter.Observaciones_Fase_Sobreseimientos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.Observaciones_Fase_Sobreseimientos LIKE '%" + filter.Observaciones_Fase_Sobreseimientos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.Observaciones LIKE '%" + filter.Observaciones + "%'";
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

        public ActionResult GetDetalle_Vinculacion_Judicializacion(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Vinculacion_JudicializacionGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Vinculacion_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Vinculacion_Judicializacion.Judicializacion=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Vinculacion_Judicializacion.Judicializacion='" + RelationId + "'";
            }
            var result = _IDetalle_Vinculacion_JudicializacionApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Vinculacion_Judicializacions == null)
                result.Detalle_Vinculacion_Judicializacions = new List<Detalle_Vinculacion_Judicializacion>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Vinculacion_Judicializacions.Select(m => new Detalle_Vinculacion_JudicializacionGridModel
                {
                    Clave = m.Clave

			,Relacion = m.Relacion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Vinculacion_JudicializacionGridModel> GetDetalle_Vinculacion_JudicializacionData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Vinculacion_JudicializacionGridModel> resultData = new List<Detalle_Vinculacion_JudicializacionGridModel>();
            string where = "Detalle_Vinculacion_Judicializacion.Judicializacion=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Vinculacion_Judicializacion.Judicializacion='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Vinculacion_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Vinculacion_JudicializacionApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Vinculacion_Judicializacions != null)
            {
                resultData = result.Detalle_Vinculacion_Judicializacions.Select(m => new Detalle_Vinculacion_JudicializacionGridModel
                    {
                        Clave = m.Clave

			,Relacion = m.Relacion


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
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Judicializacion varJudicializacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_Vinculacion_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Vinculacion_Judicializacion.Judicializacion=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Vinculacion_Judicializacion.Judicializacion='" + id + "'";
                    }
                    var Detalle_Vinculacion_JudicializacionInfo =
                        _IDetalle_Vinculacion_JudicializacionApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Vinculacion_JudicializacionInfo.Detalle_Vinculacion_Judicializacions.Count > 0)
                    {
                        var resultDetalle_Vinculacion_Judicializacion = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Vinculacion_JudicializacionItem in Detalle_Vinculacion_JudicializacionInfo.Detalle_Vinculacion_Judicializacions)
                            resultDetalle_Vinculacion_Judicializacion = resultDetalle_Vinculacion_Judicializacion
                                              && _IDetalle_Vinculacion_JudicializacionApiConsumer.Delete(Detalle_Vinculacion_JudicializacionItem.Clave, null,null).Resource;

                        if (!resultDetalle_Vinculacion_Judicializacion)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IJudicializacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, JudicializacionModel varJudicializacion)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var JudicializacionInfo = new Judicializacion
                    {
                        Clave = varJudicializacion.Clave
                        ,Expediente_MP = varJudicializacion.Expediente_MP
                        ,Resolucion = varJudicializacion.Resolucion
                        ,Tipo = varJudicializacion.Tipo
                        ,causa_o_cuadernillo = varJudicializacion.causa_o_cuadernillo
                        ,Fase_Actual = varJudicializacion.Fase_Actual
                        ,Fecha_Actos = (!String.IsNullOrEmpty(varJudicializacion.Fecha_Actos)) ? DateTime.ParseExact(varJudicializacion.Fecha_Actos, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Actos = varJudicializacion.Hora_Actos
                        ,Observaciones_Actos = varJudicializacion.Observaciones_Actos
                        ,Fecha_Genericos = (!String.IsNullOrEmpty(varJudicializacion.Fecha_Genericos)) ? DateTime.ParseExact(varJudicializacion.Fecha_Genericos, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Genericos = varJudicializacion.Hora_Genericos
                        ,Observaciones_Genericos = varJudicializacion.Observaciones_Genericos
                        ,Fecha_Fase_Inicial = (!String.IsNullOrEmpty(varJudicializacion.Fecha_Fase_Inicial)) ? DateTime.ParseExact(varJudicializacion.Fecha_Fase_Inicial, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Fase_Inicial = varJudicializacion.Hora_Fase_Inicial
                        ,Observaciones_Fase_Inicial = varJudicializacion.Observaciones_Fase_Inicial
                        ,Fecha_Fase_Intermedia = (!String.IsNullOrEmpty(varJudicializacion.Fecha_Fase_Intermedia)) ? DateTime.ParseExact(varJudicializacion.Fecha_Fase_Intermedia, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Fase_Intermedia = varJudicializacion.Hora_Fase_Intermedia
                        ,Observaciones_Fase_Intermedia = varJudicializacion.Observaciones_Fase_Intermedia
                        ,Fecha_de_Audiencia_de_Juicio = (!String.IsNullOrEmpty(varJudicializacion.Fecha_de_Audiencia_de_Juicio)) ? DateTime.ParseExact(varJudicializacion.Fecha_de_Audiencia_de_Juicio, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Audiencia_de_Juicio = varJudicializacion.Hora_de_Audiencia_de_Juicio
                        ,Tribunal_de_Enjuiciamiento = varJudicializacion.Tribunal_de_Enjuiciamiento
                        ,Nombre_del_Juez = varJudicializacion.Nombre_del_Juez
                        ,Juez_Presidente = varJudicializacion.Juez_Presidente
                        ,Juez_Relator = varJudicializacion.Juez_Relator
                        ,Juez_Vocal = varJudicializacion.Juez_Vocal
                        ,medios_desahogo = varJudicializacion.medios_desahogo
                        ,Tipo_de_Sentencia = varJudicializacion.Tipo_de_Sentencia
                        ,Cuantia_de_Pena_Anos = varJudicializacion.Cuantia_de_Pena_Anos
                        ,Cuantia_de_Pena_Meses = varJudicializacion.Cuantia_de_Pena_Meses
                        ,Monto_de_Reparacion_del_Dano = varJudicializacion.Monto_de_Reparacion_del_Dano
                        ,Observaciones_Fase_Juicio_Oral = varJudicializacion.Observaciones_Fase_Juicio_Oral
                        ,Fecha_Fase_Salidas_Alternas = (!String.IsNullOrEmpty(varJudicializacion.Fecha_Fase_Salidas_Alternas)) ? DateTime.ParseExact(varJudicializacion.Fecha_Fase_Salidas_Alternas, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Fase_Salidas_Alternas = varJudicializacion.Hora_Fase_Salidas_Alternas
                        ,Observaciones_Fase_Salidas_Alternas = varJudicializacion.Observaciones_Fase_Salidas_Alternas
                        ,Fecha_Fase_Sobreseimientos = (!String.IsNullOrEmpty(varJudicializacion.Fecha_Fase_Sobreseimientos)) ? DateTime.ParseExact(varJudicializacion.Fecha_Fase_Sobreseimientos, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Fase_Sobreseimientos = varJudicializacion.Hora_Fase_Sobreseimientos
                        ,Observaciones_Fase_Sobreseimientos = varJudicializacion.Observaciones_Fase_Sobreseimientos
                        ,Observaciones = varJudicializacion.Observaciones

                    };

                    result = !IsNew ?
                        _IJudicializacionApiConsumer.Update(JudicializacionInfo, null, null).Resource.ToString() :
                         _IJudicializacionApiConsumer.Insert(JudicializacionInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Vinculacion_Judicializacion(int MasterId, int referenceId, List<Detalle_Vinculacion_JudicializacionGridModelPost> Detalle_Vinculacion_JudicializacionItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Vinculacion_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Vinculacion_JudicializacionData = _IDetalle_Vinculacion_JudicializacionApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Vinculacion_Judicializacion.Judicializacion=" + referenceId,"").Resource;
                if (Detalle_Vinculacion_JudicializacionData == null || Detalle_Vinculacion_JudicializacionData.Detalle_Vinculacion_Judicializacions.Count == 0)
                    return true;

                var result = true;

                Detalle_Vinculacion_JudicializacionGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Vinculacion_Judicializacion in Detalle_Vinculacion_JudicializacionData.Detalle_Vinculacion_Judicializacions)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Vinculacion_Judicializacion Detalle_Vinculacion_Judicializacion1 = varDetalle_Vinculacion_Judicializacion;

                    if (Detalle_Vinculacion_JudicializacionItems != null && Detalle_Vinculacion_JudicializacionItems.Any(m => m.Clave == Detalle_Vinculacion_Judicializacion1.Clave))
                    {
                        modelDataToChange = Detalle_Vinculacion_JudicializacionItems.FirstOrDefault(m => m.Clave == Detalle_Vinculacion_Judicializacion1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Vinculacion_Judicializacion.Judicializacion = MasterId;
                    var insertId = _IDetalle_Vinculacion_JudicializacionApiConsumer.Insert(varDetalle_Vinculacion_Judicializacion,null,null).Resource;
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
        public ActionResult PostDetalle_Vinculacion_Judicializacion(List<Detalle_Vinculacion_JudicializacionGridModelPost> Detalle_Vinculacion_JudicializacionItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Vinculacion_Judicializacion(MasterId, referenceId, Detalle_Vinculacion_JudicializacionItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Vinculacion_JudicializacionItems != null && Detalle_Vinculacion_JudicializacionItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Vinculacion_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Vinculacion_JudicializacionItem in Detalle_Vinculacion_JudicializacionItems)
                    {



                        //Removal Request
                        if (Detalle_Vinculacion_JudicializacionItem.Removed)
                        {
                            result = result && _IDetalle_Vinculacion_JudicializacionApiConsumer.Delete(Detalle_Vinculacion_JudicializacionItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Vinculacion_JudicializacionItem.Clave = 0;

                        var Detalle_Vinculacion_JudicializacionData = new Detalle_Vinculacion_Judicializacion
                        {
                            Judicializacion = MasterId
                            ,Clave = Detalle_Vinculacion_JudicializacionItem.Clave
                            ,Relacion = Detalle_Vinculacion_JudicializacionItem.Relacion

                        };

                        var resultId = Detalle_Vinculacion_JudicializacionItem.Clave > 0
                           ? _IDetalle_Vinculacion_JudicializacionApiConsumer.Update(Detalle_Vinculacion_JudicializacionData,null,null).Resource
                           : _IDetalle_Vinculacion_JudicializacionApiConsumer.Insert(Detalle_Vinculacion_JudicializacionData,null,null).Resource;

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
        /// Write Element Array of Judicializacion script
        /// </summary>
        /// <param name="oJudicializacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew JudicializacionModuleAttributeList)
        {
            for (int i = 0; i < JudicializacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(JudicializacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    JudicializacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(JudicializacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    JudicializacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (JudicializacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < JudicializacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < JudicializacionModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(JudicializacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							JudicializacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(JudicializacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							JudicializacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strJudicializacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Judicializacion.js")))
            {
                strJudicializacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Judicializacion element attributes
            string userChangeJson = jsSerialize.Serialize(JudicializacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strJudicializacionScript.IndexOf("inpuElementArray");
            string splittedString = strJudicializacionScript.Substring(indexOfArray, strJudicializacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(JudicializacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (JudicializacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strJudicializacionScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strJudicializacionScript.Substring(indexOfArrayHistory, strJudicializacionScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strJudicializacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strJudicializacionScript.Substring(endIndexOfMainElement + indexOfArray, strJudicializacionScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (JudicializacionModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in JudicializacionModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Judicializacion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Judicializacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Judicializacion.js")))
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
        public ActionResult JudicializacionPropertyBag()
        {
            return PartialView("JudicializacionPropertyBag", "Judicializacion");
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
        public ActionResult AddDetalle_Vinculacion_Judicializacion(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Vinculacion_Judicializacion/AddDetalle_Vinculacion_Judicializacion");
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
                var whereClauseFormat = "Object = 45637 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Judicializacion.Clave= " + RecordId;
                            var result = _IJudicializacionApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new JudicializacionPropertyMapper());
			
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
                    (JudicializacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            JudicializacionPropertyMapper oJudicializacionPropertyMapper = new JudicializacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oJudicializacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IJudicializacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Judicializacions == null)
                result.Judicializacions = new List<Judicializacion>();

            var data = result.Judicializacions.Select(m => new JudicializacionGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,ResolucionObservaciones = CultureHelper.GetTraduction(m.Resolucion_Resolucion_MP.Clave.ToString(), "Resolucion_MP") ?? (string)m.Resolucion_Resolucion_MP.Observaciones
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,causa_o_cuadernillo = m.causa_o_cuadernillo
                        ,Fase_ActualDescripcion = CultureHelper.GetTraduction(m.Fase_Actual_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Actual_Fase_de_Judicializacion.Descripcion
                        ,Fecha_Actos = (m.Fecha_Actos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Actos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Actos = m.Hora_Actos
			,Observaciones_Actos = m.Observaciones_Actos
                        ,Fecha_Genericos = (m.Fecha_Genericos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Genericos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Genericos = m.Hora_Genericos
			,Observaciones_Genericos = m.Observaciones_Genericos
                        ,Fecha_Fase_Inicial = (m.Fecha_Fase_Inicial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Inicial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Inicial = m.Hora_Fase_Inicial
			,Observaciones_Fase_Inicial = m.Observaciones_Fase_Inicial
                        ,Fecha_Fase_Intermedia = (m.Fecha_Fase_Intermedia == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Intermedia).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Intermedia = m.Hora_Fase_Intermedia
			,Observaciones_Fase_Intermedia = m.Observaciones_Fase_Intermedia
                        ,Fecha_de_Audiencia_de_Juicio = (m.Fecha_de_Audiencia_de_Juicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_de_Juicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_de_Juicio = m.Hora_de_Audiencia_de_Juicio
                        ,Tribunal_de_EnjuiciamientoDescripcion = CultureHelper.GetTraduction(m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Descripcion
			,Nombre_del_Juez = m.Nombre_del_Juez
			,Juez_Presidente = m.Juez_Presidente
			,Juez_Relator = m.Juez_Relator
			,Juez_Vocal = m.Juez_Vocal
			,medios_desahogo = m.medios_desahogo
                        ,Tipo_de_SentenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sentencia_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sentencia_Sentencia.Descripcion
			,Cuantia_de_Pena_Anos = m.Cuantia_de_Pena_Anos
			,Cuantia_de_Pena_Meses = m.Cuantia_de_Pena_Meses
			,Monto_de_Reparacion_del_Dano = m.Monto_de_Reparacion_del_Dano
			,Observaciones_Fase_Juicio_Oral = m.Observaciones_Fase_Juicio_Oral
                        ,Fecha_Fase_Salidas_Alternas = (m.Fecha_Fase_Salidas_Alternas == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Salidas_Alternas).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Salidas_Alternas = m.Hora_Fase_Salidas_Alternas
			,Observaciones_Fase_Salidas_Alternas = m.Observaciones_Fase_Salidas_Alternas
                        ,Fecha_Fase_Sobreseimientos = (m.Fecha_Fase_Sobreseimientos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Sobreseimientos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Sobreseimientos = m.Hora_Fase_Sobreseimientos
			,Observaciones_Fase_Sobreseimientos = m.Observaciones_Fase_Sobreseimientos
			,Observaciones = m.Observaciones

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45637, arrayColumnsVisible), "JudicializacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45637, arrayColumnsVisible), "JudicializacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45637, arrayColumnsVisible), "JudicializacionList_" + DateTime.Now.ToString());
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

            _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new JudicializacionPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (JudicializacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            JudicializacionPropertyMapper oJudicializacionPropertyMapper = new JudicializacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oJudicializacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IJudicializacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Judicializacions == null)
                result.Judicializacions = new List<Judicializacion>();

            var data = result.Judicializacions.Select(m => new JudicializacionGridModel
            {
                Clave = m.Clave
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,ResolucionObservaciones = CultureHelper.GetTraduction(m.Resolucion_Resolucion_MP.Clave.ToString(), "Resolucion_MP") ?? (string)m.Resolucion_Resolucion_MP.Observaciones
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,causa_o_cuadernillo = m.causa_o_cuadernillo
                        ,Fase_ActualDescripcion = CultureHelper.GetTraduction(m.Fase_Actual_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Actual_Fase_de_Judicializacion.Descripcion
                        ,Fecha_Actos = (m.Fecha_Actos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Actos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Actos = m.Hora_Actos
			,Observaciones_Actos = m.Observaciones_Actos
                        ,Fecha_Genericos = (m.Fecha_Genericos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Genericos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Genericos = m.Hora_Genericos
			,Observaciones_Genericos = m.Observaciones_Genericos
                        ,Fecha_Fase_Inicial = (m.Fecha_Fase_Inicial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Inicial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Inicial = m.Hora_Fase_Inicial
			,Observaciones_Fase_Inicial = m.Observaciones_Fase_Inicial
                        ,Fecha_Fase_Intermedia = (m.Fecha_Fase_Intermedia == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Intermedia).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Intermedia = m.Hora_Fase_Intermedia
			,Observaciones_Fase_Intermedia = m.Observaciones_Fase_Intermedia
                        ,Fecha_de_Audiencia_de_Juicio = (m.Fecha_de_Audiencia_de_Juicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_de_Juicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_de_Juicio = m.Hora_de_Audiencia_de_Juicio
                        ,Tribunal_de_EnjuiciamientoDescripcion = CultureHelper.GetTraduction(m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Descripcion
			,Nombre_del_Juez = m.Nombre_del_Juez
			,Juez_Presidente = m.Juez_Presidente
			,Juez_Relator = m.Juez_Relator
			,Juez_Vocal = m.Juez_Vocal
			,medios_desahogo = m.medios_desahogo
                        ,Tipo_de_SentenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sentencia_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sentencia_Sentencia.Descripcion
			,Cuantia_de_Pena_Anos = m.Cuantia_de_Pena_Anos
			,Cuantia_de_Pena_Meses = m.Cuantia_de_Pena_Meses
			,Monto_de_Reparacion_del_Dano = m.Monto_de_Reparacion_del_Dano
			,Observaciones_Fase_Juicio_Oral = m.Observaciones_Fase_Juicio_Oral
                        ,Fecha_Fase_Salidas_Alternas = (m.Fecha_Fase_Salidas_Alternas == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Salidas_Alternas).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Salidas_Alternas = m.Hora_Fase_Salidas_Alternas
			,Observaciones_Fase_Salidas_Alternas = m.Observaciones_Fase_Salidas_Alternas
                        ,Fecha_Fase_Sobreseimientos = (m.Fecha_Fase_Sobreseimientos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Sobreseimientos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Sobreseimientos = m.Hora_Fase_Sobreseimientos
			,Observaciones_Fase_Sobreseimientos = m.Observaciones_Fase_Sobreseimientos
			,Observaciones = m.Observaciones

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
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IJudicializacionApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Judicializacion_Datos_GeneralesModel varJudicializacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Judicializacion_Datos_GeneralesInfo = new Judicializacion_Datos_Generales
                {
                    Clave = varJudicializacion.Clave
                                            ,Expediente_MP = varJudicializacion.Expediente_MP
                        ,Resolucion = varJudicializacion.Resolucion
                        ,Tipo = varJudicializacion.Tipo
                        ,causa_o_cuadernillo = varJudicializacion.causa_o_cuadernillo
                        ,Fase_Actual = varJudicializacion.Fase_Actual
                    
                };

                result = _IJudicializacionApiConsumer.Update_Datos_Generales(Judicializacion_Datos_GeneralesInfo).Resource.ToString();
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
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IJudicializacionApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Vinculacion_Judicializacion;
                var Detalle_Vinculacion_JudicializacionData = GetDetalle_Vinculacion_JudicializacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Vinculacion_Judicializacion);

                var result = new Judicializacion_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Expediente_MP = m.Expediente_MP
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Resolucion = m.Resolucion
                        ,ResolucionObservaciones = CultureHelper.GetTraduction(m.Resolucion_Resolucion_MP.Clave.ToString(), "Resolucion_MP") ?? (string)m.Resolucion_Resolucion_MP.Observaciones
                        ,Tipo = m.Tipo
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Judicializacion.Descripcion
			,causa_o_cuadernillo = m.causa_o_cuadernillo
                        ,Fase_Actual = m.Fase_Actual
                        ,Fase_ActualDescripcion = CultureHelper.GetTraduction(m.Fase_Actual_Fase_de_Judicializacion.Clave.ToString(), "Descripcion") ?? (string)m.Fase_Actual_Fase_de_Judicializacion.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Vinculacion = Detalle_Vinculacion_JudicializacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Actos_de_Investigacion(Judicializacion_Actos_de_InvestigacionModel varJudicializacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Judicializacion_Actos_de_InvestigacionInfo = new Judicializacion_Actos_de_Investigacion
                {
                    Clave = varJudicializacion.Clave
                                            ,Fecha_Actos = (!String.IsNullOrEmpty(varJudicializacion.Fecha_Actos)) ? DateTime.ParseExact(varJudicializacion.Fecha_Actos, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Actos = varJudicializacion.Hora_Actos
                        ,Observaciones_Actos = varJudicializacion.Observaciones_Actos
                    
                };

                result = _IJudicializacionApiConsumer.Update_Actos_de_Investigacion(Judicializacion_Actos_de_InvestigacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Actos_de_Investigacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IJudicializacionApiConsumer.Get_Actos_de_Investigacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Vinculacion_Judicializacion;
                var Detalle_Vinculacion_JudicializacionData = GetDetalle_Vinculacion_JudicializacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Vinculacion_Judicializacion);

                var result = new Judicializacion_Actos_de_InvestigacionModel
                {
                    Clave = m.Clave
                        ,Fecha_Actos = (m.Fecha_Actos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Actos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Actos = m.Hora_Actos
			,Observaciones_Actos = m.Observaciones_Actos

                    
                };
				var resultData = new
                {
                    data = result
                    ,Vinculacion = Detalle_Vinculacion_JudicializacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Genericos(Judicializacion_GenericosModel varJudicializacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Judicializacion_GenericosInfo = new Judicializacion_Genericos
                {
                    Clave = varJudicializacion.Clave
                                            ,Fecha_Genericos = (!String.IsNullOrEmpty(varJudicializacion.Fecha_Genericos)) ? DateTime.ParseExact(varJudicializacion.Fecha_Genericos, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Genericos = varJudicializacion.Hora_Genericos
                        ,Observaciones_Genericos = varJudicializacion.Observaciones_Genericos
                    
                };

                result = _IJudicializacionApiConsumer.Update_Genericos(Judicializacion_GenericosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Genericos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IJudicializacionApiConsumer.Get_Genericos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Vinculacion_Judicializacion;
                var Detalle_Vinculacion_JudicializacionData = GetDetalle_Vinculacion_JudicializacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Vinculacion_Judicializacion);

                var result = new Judicializacion_GenericosModel
                {
                    Clave = m.Clave
                        ,Fecha_Genericos = (m.Fecha_Genericos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Genericos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Genericos = m.Hora_Genericos
			,Observaciones_Genericos = m.Observaciones_Genericos

                    
                };
				var resultData = new
                {
                    data = result
                    ,Vinculacion = Detalle_Vinculacion_JudicializacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Fase_Inicial(Judicializacion_Fase_InicialModel varJudicializacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Judicializacion_Fase_InicialInfo = new Judicializacion_Fase_Inicial
                {
                    Clave = varJudicializacion.Clave
                                            ,Fecha_Fase_Inicial = (!String.IsNullOrEmpty(varJudicializacion.Fecha_Fase_Inicial)) ? DateTime.ParseExact(varJudicializacion.Fecha_Fase_Inicial, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Fase_Inicial = varJudicializacion.Hora_Fase_Inicial
                        ,Observaciones_Fase_Inicial = varJudicializacion.Observaciones_Fase_Inicial
                    
                };

                result = _IJudicializacionApiConsumer.Update_Fase_Inicial(Judicializacion_Fase_InicialInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Fase_Inicial(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IJudicializacionApiConsumer.Get_Fase_Inicial(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Vinculacion_Judicializacion;
                var Detalle_Vinculacion_JudicializacionData = GetDetalle_Vinculacion_JudicializacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Vinculacion_Judicializacion);

                var result = new Judicializacion_Fase_InicialModel
                {
                    Clave = m.Clave
                        ,Fecha_Fase_Inicial = (m.Fecha_Fase_Inicial == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Inicial).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Inicial = m.Hora_Fase_Inicial
			,Observaciones_Fase_Inicial = m.Observaciones_Fase_Inicial

                    
                };
				var resultData = new
                {
                    data = result
                    ,Vinculacion = Detalle_Vinculacion_JudicializacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Fase_Intermedia(Judicializacion_Fase_IntermediaModel varJudicializacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Judicializacion_Fase_IntermediaInfo = new Judicializacion_Fase_Intermedia
                {
                    Clave = varJudicializacion.Clave
                                            ,Fecha_Fase_Intermedia = (!String.IsNullOrEmpty(varJudicializacion.Fecha_Fase_Intermedia)) ? DateTime.ParseExact(varJudicializacion.Fecha_Fase_Intermedia, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Fase_Intermedia = varJudicializacion.Hora_Fase_Intermedia
                        ,Observaciones_Fase_Intermedia = varJudicializacion.Observaciones_Fase_Intermedia
                    
                };

                result = _IJudicializacionApiConsumer.Update_Fase_Intermedia(Judicializacion_Fase_IntermediaInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Fase_Intermedia(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IJudicializacionApiConsumer.Get_Fase_Intermedia(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Vinculacion_Judicializacion;
                var Detalle_Vinculacion_JudicializacionData = GetDetalle_Vinculacion_JudicializacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Vinculacion_Judicializacion);

                var result = new Judicializacion_Fase_IntermediaModel
                {
                    Clave = m.Clave
                        ,Fecha_Fase_Intermedia = (m.Fecha_Fase_Intermedia == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Intermedia).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Intermedia = m.Hora_Fase_Intermedia
			,Observaciones_Fase_Intermedia = m.Observaciones_Fase_Intermedia

                    
                };
				var resultData = new
                {
                    data = result
                    ,Vinculacion = Detalle_Vinculacion_JudicializacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Fase_Juicio_Oral(Judicializacion_Fase_Juicio_OralModel varJudicializacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Judicializacion_Fase_Juicio_OralInfo = new Judicializacion_Fase_Juicio_Oral
                {
                    Clave = varJudicializacion.Clave
                                            ,Fecha_de_Audiencia_de_Juicio = (!String.IsNullOrEmpty(varJudicializacion.Fecha_de_Audiencia_de_Juicio)) ? DateTime.ParseExact(varJudicializacion.Fecha_de_Audiencia_de_Juicio, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Audiencia_de_Juicio = varJudicializacion.Hora_de_Audiencia_de_Juicio
                        ,Tribunal_de_Enjuiciamiento = varJudicializacion.Tribunal_de_Enjuiciamiento
                        ,Nombre_del_Juez = varJudicializacion.Nombre_del_Juez
                        ,Juez_Presidente = varJudicializacion.Juez_Presidente
                        ,Juez_Relator = varJudicializacion.Juez_Relator
                        ,Juez_Vocal = varJudicializacion.Juez_Vocal
                        ,medios_desahogo = varJudicializacion.medios_desahogo
                        ,Tipo_de_Sentencia = varJudicializacion.Tipo_de_Sentencia
                        ,Cuantia_de_Pena_Anos = varJudicializacion.Cuantia_de_Pena_Anos
                        ,Cuantia_de_Pena_Meses = varJudicializacion.Cuantia_de_Pena_Meses
                        ,Monto_de_Reparacion_del_Dano = varJudicializacion.Monto_de_Reparacion_del_Dano
                        ,Observaciones_Fase_Juicio_Oral = varJudicializacion.Observaciones_Fase_Juicio_Oral
                    
                };

                result = _IJudicializacionApiConsumer.Update_Fase_Juicio_Oral(Judicializacion_Fase_Juicio_OralInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Fase_Juicio_Oral(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IJudicializacionApiConsumer.Get_Fase_Juicio_Oral(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Vinculacion_Judicializacion;
                var Detalle_Vinculacion_JudicializacionData = GetDetalle_Vinculacion_JudicializacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Vinculacion_Judicializacion);

                var result = new Judicializacion_Fase_Juicio_OralModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Audiencia_de_Juicio = (m.Fecha_de_Audiencia_de_Juicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Audiencia_de_Juicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Audiencia_de_Juicio = m.Hora_de_Audiencia_de_Juicio
                        ,Tribunal_de_Enjuiciamiento = m.Tribunal_de_Enjuiciamiento
                        ,Tribunal_de_EnjuiciamientoDescripcion = CultureHelper.GetTraduction(m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tribunal_de_Enjuiciamiento_Tribunal_de_Enjuiciamiento.Descripcion
			,Nombre_del_Juez = m.Nombre_del_Juez
			,Juez_Presidente = m.Juez_Presidente
			,Juez_Relator = m.Juez_Relator
			,Juez_Vocal = m.Juez_Vocal
			,medios_desahogo = m.medios_desahogo
                        ,Tipo_de_Sentencia = m.Tipo_de_Sentencia
                        ,Tipo_de_SentenciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Sentencia_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Sentencia_Sentencia.Descripcion
			,Cuantia_de_Pena_Anos = m.Cuantia_de_Pena_Anos
			,Cuantia_de_Pena_Meses = m.Cuantia_de_Pena_Meses
			,Monto_de_Reparacion_del_Dano = m.Monto_de_Reparacion_del_Dano
			,Observaciones_Fase_Juicio_Oral = m.Observaciones_Fase_Juicio_Oral

                    
                };
				var resultData = new
                {
                    data = result
                    ,Vinculacion = Detalle_Vinculacion_JudicializacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Salidas_Alternas(Judicializacion_Salidas_AlternasModel varJudicializacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Judicializacion_Salidas_AlternasInfo = new Judicializacion_Salidas_Alternas
                {
                    Clave = varJudicializacion.Clave
                                            ,Fecha_Fase_Salidas_Alternas = (!String.IsNullOrEmpty(varJudicializacion.Fecha_Fase_Salidas_Alternas)) ? DateTime.ParseExact(varJudicializacion.Fecha_Fase_Salidas_Alternas, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Fase_Salidas_Alternas = varJudicializacion.Hora_Fase_Salidas_Alternas
                        ,Observaciones_Fase_Salidas_Alternas = varJudicializacion.Observaciones_Fase_Salidas_Alternas
                    
                };

                result = _IJudicializacionApiConsumer.Update_Salidas_Alternas(Judicializacion_Salidas_AlternasInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Salidas_Alternas(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IJudicializacionApiConsumer.Get_Salidas_Alternas(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Vinculacion_Judicializacion;
                var Detalle_Vinculacion_JudicializacionData = GetDetalle_Vinculacion_JudicializacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Vinculacion_Judicializacion);

                var result = new Judicializacion_Salidas_AlternasModel
                {
                    Clave = m.Clave
                        ,Fecha_Fase_Salidas_Alternas = (m.Fecha_Fase_Salidas_Alternas == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Salidas_Alternas).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Salidas_Alternas = m.Hora_Fase_Salidas_Alternas
			,Observaciones_Fase_Salidas_Alternas = m.Observaciones_Fase_Salidas_Alternas

                    
                };
				var resultData = new
                {
                    data = result
                    ,Vinculacion = Detalle_Vinculacion_JudicializacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Sobreseimientos(Judicializacion_SobreseimientosModel varJudicializacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Judicializacion_SobreseimientosInfo = new Judicializacion_Sobreseimientos
                {
                    Clave = varJudicializacion.Clave
                                            ,Fecha_Fase_Sobreseimientos = (!String.IsNullOrEmpty(varJudicializacion.Fecha_Fase_Sobreseimientos)) ? DateTime.ParseExact(varJudicializacion.Fecha_Fase_Sobreseimientos, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Fase_Sobreseimientos = varJudicializacion.Hora_Fase_Sobreseimientos
                        ,Observaciones_Fase_Sobreseimientos = varJudicializacion.Observaciones_Fase_Sobreseimientos
                    
                };

                result = _IJudicializacionApiConsumer.Update_Sobreseimientos(Judicializacion_SobreseimientosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Sobreseimientos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IJudicializacionApiConsumer.Get_Sobreseimientos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Vinculacion_Judicializacion;
                var Detalle_Vinculacion_JudicializacionData = GetDetalle_Vinculacion_JudicializacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Vinculacion_Judicializacion);

                var result = new Judicializacion_SobreseimientosModel
                {
                    Clave = m.Clave
                        ,Fecha_Fase_Sobreseimientos = (m.Fecha_Fase_Sobreseimientos == null ? string.Empty : Convert.ToDateTime(m.Fecha_Fase_Sobreseimientos).ToString(ConfigurationProperty.DateFormat))
			,Hora_Fase_Sobreseimientos = m.Hora_Fase_Sobreseimientos
			,Observaciones_Fase_Sobreseimientos = m.Observaciones_Fase_Sobreseimientos

                    
                };
				var resultData = new
                {
                    data = result
                    ,Vinculacion = Detalle_Vinculacion_JudicializacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Movimientos(Judicializacion_MovimientosModel varJudicializacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Judicializacion_MovimientosInfo = new Judicializacion_Movimientos
                {
                    Clave = varJudicializacion.Clave
                                            ,Observaciones = varJudicializacion.Observaciones
                    
                };

                result = _IJudicializacionApiConsumer.Update_Movimientos(Judicializacion_MovimientosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Movimientos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IJudicializacionApiConsumer.Get_Movimientos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Vinculacion_Judicializacion;
                var Detalle_Vinculacion_JudicializacionData = GetDetalle_Vinculacion_JudicializacionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Vinculacion_Judicializacion);

                var result = new Judicializacion_MovimientosModel
                {
                    Clave = m.Clave
			,Observaciones = m.Observaciones

                    
                };
				var resultData = new
                {
                    data = result
                    ,Vinculacion = Detalle_Vinculacion_JudicializacionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

