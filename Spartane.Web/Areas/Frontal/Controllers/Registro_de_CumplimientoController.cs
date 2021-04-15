using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Registro_de_Cumplimiento;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resolucion_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Partida_que_Cumplimenta;
using Spartane.Core.Domain.Area_envia_Cumplimiento;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento;






using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Registro_de_Cumplimiento;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Registro_de_Cumplimiento;
using Spartane.Web.Areas.WebApiConsumer.Registro_de_Mandamiento_Judicial;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Resolucion_de_Mandamiento_Judicial;
using Spartane.Web.Areas.WebApiConsumer.Partida_que_Cumplimenta;
using Spartane.Web.Areas.WebApiConsumer.Area_envia_Cumplimiento;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Personas_donde_se_ejecuto_mandamiento;




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
    public class Registro_de_CumplimientoController : Controller
    {
        #region "variable declaration"

        private IRegistro_de_CumplimientoService service = null;
        private IRegistro_de_CumplimientoApiConsumer _IRegistro_de_CumplimientoApiConsumer;
        private IRegistro_de_Mandamiento_JudicialApiConsumer _IRegistro_de_Mandamiento_JudicialApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IResolucion_de_Mandamiento_JudicialApiConsumer _IResolucion_de_Mandamiento_JudicialApiConsumer;
        private IPartida_que_CumplimentaApiConsumer _IPartida_que_CumplimentaApiConsumer;
        private IArea_envia_CumplimientoApiConsumer _IArea_envia_CumplimientoApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IPersonas_donde_se_ejecuto_mandamientoApiConsumer _IPersonas_donde_se_ejecuto_mandamientoApiConsumer;




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

        
        public Registro_de_CumplimientoController(IRegistro_de_CumplimientoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IRegistro_de_CumplimientoApiConsumer Registro_de_CumplimientoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IRegistro_de_Mandamiento_JudicialApiConsumer Registro_de_Mandamiento_JudicialApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IResolucion_de_Mandamiento_JudicialApiConsumer Resolucion_de_Mandamiento_JudicialApiConsumer , IPartida_que_CumplimentaApiConsumer Partida_que_CumplimentaApiConsumer , IArea_envia_CumplimientoApiConsumer Area_envia_CumplimientoApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IPersonas_donde_se_ejecuto_mandamientoApiConsumer Personas_donde_se_ejecuto_mandamientoApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IRegistro_de_CumplimientoApiConsumer = Registro_de_CumplimientoApiConsumer;
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
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IResolucion_de_Mandamiento_JudicialApiConsumer = Resolucion_de_Mandamiento_JudicialApiConsumer;
            this._IPartida_que_CumplimentaApiConsumer = Partida_que_CumplimentaApiConsumer;
            this._IArea_envia_CumplimientoApiConsumer = Area_envia_CumplimientoApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IPersonas_donde_se_ejecuto_mandamientoApiConsumer = Personas_donde_se_ejecuto_mandamientoApiConsumer;




        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Registro_de_Cumplimiento
        [ObjectAuth(ObjectId = (ModuleObjectId)46299, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46299, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Registro_de_Cumplimiento/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)46299, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46299, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varRegistro_de_Cumplimiento = new Registro_de_CumplimientoModel();
			varRegistro_de_Cumplimiento.Clave = Id;
			
            ViewBag.ObjectId = "46299";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionPersonas_donde_se_ejecuto_mandamiento = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46304, ModuleId);
            ViewBag.PermissionPersonas_donde_se_ejecuto_mandamiento = permissionPersonas_donde_se_ejecuto_mandamiento;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IRegistro_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Registro_de_CumplimientosData = _IRegistro_de_CumplimientoApiConsumer.ListaSelAll(0, 1000, "Registro_de_Cumplimiento.Clave=" + Id, "").Resource.Registro_de_Cumplimientos;
				
				if (Registro_de_CumplimientosData != null && Registro_de_CumplimientosData.Count > 0)
                {
					var Registro_de_CumplimientoData = Registro_de_CumplimientosData.First();
					varRegistro_de_Cumplimiento= new Registro_de_CumplimientoModel
					{
						Clave  = Registro_de_CumplimientoData.Clave 
	                    ,Mandamiento_Judicial = Registro_de_CumplimientoData.Mandamiento_Judicial
                    ,Mandamiento_JudicialNumero_de_Mandamiento = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Mandamiento_Judicial), "Registro_de_Mandamiento_Judicial") ??  (string)Registro_de_CumplimientoData.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                    ,Fecha_de_Registro = (Registro_de_CumplimientoData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Registro_de_CumplimientoData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Registro_de_CumplimientoData.Hora_de_Registro
                    ,Usuario_de_Registro = Registro_de_CumplimientoData.Usuario_de_Registro
                    ,Usuario_de_RegistroName = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Usuario_de_Registro), "Spartan_User") ??  (string)Registro_de_CumplimientoData.Usuario_de_Registro_Spartan_User.Name
                    ,Resolucion = Registro_de_CumplimientoData.Resolucion
                    ,ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Resolucion), "Resolucion_de_Mandamiento_Judicial") ??  (string)Registro_de_CumplimientoData.Resolucion_Resolucion_de_Mandamiento_Judicial.Descripcion
                    ,Fecha_de_Resolucion = (Registro_de_CumplimientoData.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(Registro_de_CumplimientoData.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                    ,Numero_de_Oficio = Registro_de_CumplimientoData.Numero_de_Oficio
                    ,Radiograma = Registro_de_CumplimientoData.Radiograma
                    ,Partida_que_cumplimenta = Registro_de_CumplimientoData.Partida_que_cumplimenta
                    ,Partida_que_cumplimentaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Partida_que_cumplimenta), "Partida_que_Cumplimenta") ??  (string)Registro_de_CumplimientoData.Partida_que_cumplimenta_Partida_que_Cumplimenta.Descripcion
                    ,Area_que_envia_cumplimiento = Registro_de_CumplimientoData.Area_que_envia_cumplimiento
                    ,Area_que_envia_cumplimientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Area_que_envia_cumplimiento), "Area_envia_Cumplimiento") ??  (string)Registro_de_CumplimientoData.Area_que_envia_cumplimiento_Area_envia_Cumplimiento.Descripcion
                    ,Estado = Registro_de_CumplimientoData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Estado), "Estado") ??  (string)Registro_de_CumplimientoData.Estado_Estado.Nombre
                    ,Municipio = Registro_de_CumplimientoData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Municipio), "Municipio") ??  (string)Registro_de_CumplimientoData.Municipio_Municipio.Nombre
                    ,Poblacion = Registro_de_CumplimientoData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Poblacion), "Colonia") ??  (string)Registro_de_CumplimientoData.Poblacion_Colonia.Nombre
                    ,Colonia = Registro_de_CumplimientoData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Colonia), "Colonia") ??  (string)Registro_de_CumplimientoData.Colonia_Colonia.Nombre
                    ,Observaciones_del_Cumplimiento = Registro_de_CumplimientoData.Observaciones_del_Cumplimiento

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IResolucion_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucion_de_Mandamiento_Judicials_Resolucion = _IResolucion_de_Mandamiento_JudicialApiConsumer.SelAll(true);
            if (Resolucion_de_Mandamiento_Judicials_Resolucion != null && Resolucion_de_Mandamiento_Judicials_Resolucion.Resource != null)
                ViewBag.Resolucion_de_Mandamiento_Judicials_Resolucion = Resolucion_de_Mandamiento_Judicials_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_de_Mandamiento_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPartida_que_CumplimentaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Partida_que_Cumplimentas_Partida_que_cumplimenta = _IPartida_que_CumplimentaApiConsumer.SelAll(true);
            if (Partida_que_Cumplimentas_Partida_que_cumplimenta != null && Partida_que_Cumplimentas_Partida_que_cumplimenta.Resource != null)
                ViewBag.Partida_que_Cumplimentas_Partida_que_cumplimenta = Partida_que_Cumplimentas_Partida_que_cumplimenta.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Partida_que_Cumplimenta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varRegistro_de_Cumplimiento);
        }
		
	[HttpGet]
        public ActionResult AddRegistro_de_Cumplimiento(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46299);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IRegistro_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Registro_de_CumplimientoModel varRegistro_de_Cumplimiento= new Registro_de_CumplimientoModel();
            var permissionPersonas_donde_se_ejecuto_mandamiento = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46304, ModuleId);
            ViewBag.PermissionPersonas_donde_se_ejecuto_mandamiento = permissionPersonas_donde_se_ejecuto_mandamiento;


            if (id.ToString() != "0")
            {
                var Registro_de_CumplimientosData = _IRegistro_de_CumplimientoApiConsumer.ListaSelAll(0, 1000, "Registro_de_Cumplimiento.Clave=" + id, "").Resource.Registro_de_Cumplimientos;
				
				if (Registro_de_CumplimientosData != null && Registro_de_CumplimientosData.Count > 0)
                {
					var Registro_de_CumplimientoData = Registro_de_CumplimientosData.First();
					varRegistro_de_Cumplimiento= new Registro_de_CumplimientoModel
					{
						Clave  = Registro_de_CumplimientoData.Clave 
	                    ,Mandamiento_Judicial = Registro_de_CumplimientoData.Mandamiento_Judicial
                    ,Mandamiento_JudicialNumero_de_Mandamiento = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Mandamiento_Judicial), "Registro_de_Mandamiento_Judicial") ??  (string)Registro_de_CumplimientoData.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                    ,Fecha_de_Registro = (Registro_de_CumplimientoData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Registro_de_CumplimientoData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Registro_de_CumplimientoData.Hora_de_Registro
                    ,Usuario_de_Registro = Registro_de_CumplimientoData.Usuario_de_Registro
                    ,Usuario_de_RegistroName = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Usuario_de_Registro), "Spartan_User") ??  (string)Registro_de_CumplimientoData.Usuario_de_Registro_Spartan_User.Name
                    ,Resolucion = Registro_de_CumplimientoData.Resolucion
                    ,ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Resolucion), "Resolucion_de_Mandamiento_Judicial") ??  (string)Registro_de_CumplimientoData.Resolucion_Resolucion_de_Mandamiento_Judicial.Descripcion
                    ,Fecha_de_Resolucion = (Registro_de_CumplimientoData.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(Registro_de_CumplimientoData.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
                    ,Numero_de_Oficio = Registro_de_CumplimientoData.Numero_de_Oficio
                    ,Radiograma = Registro_de_CumplimientoData.Radiograma
                    ,Partida_que_cumplimenta = Registro_de_CumplimientoData.Partida_que_cumplimenta
                    ,Partida_que_cumplimentaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Partida_que_cumplimenta), "Partida_que_Cumplimenta") ??  (string)Registro_de_CumplimientoData.Partida_que_cumplimenta_Partida_que_Cumplimenta.Descripcion
                    ,Area_que_envia_cumplimiento = Registro_de_CumplimientoData.Area_que_envia_cumplimiento
                    ,Area_que_envia_cumplimientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Area_que_envia_cumplimiento), "Area_envia_Cumplimiento") ??  (string)Registro_de_CumplimientoData.Area_que_envia_cumplimiento_Area_envia_Cumplimiento.Descripcion
                    ,Estado = Registro_de_CumplimientoData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Estado), "Estado") ??  (string)Registro_de_CumplimientoData.Estado_Estado.Nombre
                    ,Municipio = Registro_de_CumplimientoData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Municipio), "Municipio") ??  (string)Registro_de_CumplimientoData.Municipio_Municipio.Nombre
                    ,Poblacion = Registro_de_CumplimientoData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Poblacion), "Colonia") ??  (string)Registro_de_CumplimientoData.Poblacion_Colonia.Nombre
                    ,Colonia = Registro_de_CumplimientoData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_CumplimientoData.Colonia), "Colonia") ??  (string)Registro_de_CumplimientoData.Colonia_Colonia.Nombre
                    ,Observaciones_del_Cumplimiento = Registro_de_CumplimientoData.Observaciones_del_Cumplimiento

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IResolucion_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucion_de_Mandamiento_Judicials_Resolucion = _IResolucion_de_Mandamiento_JudicialApiConsumer.SelAll(true);
            if (Resolucion_de_Mandamiento_Judicials_Resolucion != null && Resolucion_de_Mandamiento_Judicials_Resolucion.Resource != null)
                ViewBag.Resolucion_de_Mandamiento_Judicials_Resolucion = Resolucion_de_Mandamiento_Judicials_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_de_Mandamiento_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPartida_que_CumplimentaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Partida_que_Cumplimentas_Partida_que_cumplimenta = _IPartida_que_CumplimentaApiConsumer.SelAll(true);
            if (Partida_que_Cumplimentas_Partida_que_cumplimenta != null && Partida_que_Cumplimentas_Partida_que_cumplimenta.Resource != null)
                ViewBag.Partida_que_Cumplimentas_Partida_que_cumplimenta = Partida_que_Cumplimentas_Partida_que_cumplimenta.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Partida_que_Cumplimenta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddRegistro_de_Cumplimiento", varRegistro_de_Cumplimiento);
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
        public ActionResult GetResolucion_de_Mandamiento_JudicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResolucion_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResolucion_de_Mandamiento_JudicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_de_Mandamiento_Judicial", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetPartida_que_CumplimentaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPartida_que_CumplimentaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPartida_que_CumplimentaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Partida_que_Cumplimenta", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetArea_envia_CumplimientoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IArea_envia_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IArea_envia_CumplimientoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_envia_Cumplimiento", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetMunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre")?? m.Nombre,
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
        public ActionResult ShowAdvanceFilter(Registro_de_CumplimientoAdvanceSearchModel model, int idFilter = -1)
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

            _IResolucion_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucion_de_Mandamiento_Judicials_Resolucion = _IResolucion_de_Mandamiento_JudicialApiConsumer.SelAll(true);
            if (Resolucion_de_Mandamiento_Judicials_Resolucion != null && Resolucion_de_Mandamiento_Judicials_Resolucion.Resource != null)
                ViewBag.Resolucion_de_Mandamiento_Judicials_Resolucion = Resolucion_de_Mandamiento_Judicials_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_de_Mandamiento_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPartida_que_CumplimentaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Partida_que_Cumplimentas_Partida_que_cumplimenta = _IPartida_que_CumplimentaApiConsumer.SelAll(true);
            if (Partida_que_Cumplimentas_Partida_que_cumplimenta != null && Partida_que_Cumplimentas_Partida_que_cumplimenta.Resource != null)
                ViewBag.Partida_que_Cumplimentas_Partida_que_cumplimenta = Partida_que_Cumplimentas_Partida_que_cumplimenta.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Partida_que_Cumplimenta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IResolucion_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resolucion_de_Mandamiento_Judicials_Resolucion = _IResolucion_de_Mandamiento_JudicialApiConsumer.SelAll(true);
            if (Resolucion_de_Mandamiento_Judicials_Resolucion != null && Resolucion_de_Mandamiento_Judicials_Resolucion.Resource != null)
                ViewBag.Resolucion_de_Mandamiento_Judicials_Resolucion = Resolucion_de_Mandamiento_Judicials_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resolucion_de_Mandamiento_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPartida_que_CumplimentaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Partida_que_Cumplimentas_Partida_que_cumplimenta = _IPartida_que_CumplimentaApiConsumer.SelAll(true);
            if (Partida_que_Cumplimentas_Partida_que_cumplimenta != null && Partida_que_Cumplimentas_Partida_que_cumplimenta.Resource != null)
                ViewBag.Partida_que_Cumplimentas_Partida_que_cumplimenta = Partida_que_Cumplimentas_Partida_que_cumplimenta.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Partida_que_Cumplimenta", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Registro_de_CumplimientoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Registro_de_CumplimientoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Registro_de_CumplimientoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Registro_de_CumplimientoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IRegistro_de_CumplimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Cumplimientos == null)
                result.Registro_de_Cumplimientos = new List<Registro_de_Cumplimiento>();

            return Json(new
            {
                data = result.Registro_de_Cumplimientos.Select(m => new Registro_de_CumplimientoGridModel
                    {
                    Clave = m.Clave
                        ,Mandamiento_JudicialNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_de_RegistroName = CultureHelper.GetTraduction(m.Usuario_de_Registro_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_de_Registro_Spartan_User.Name
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion_de_Mandamiento_Judicial.Descripcion
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
			,Numero_de_Oficio = m.Numero_de_Oficio
			,Radiograma = m.Radiograma
                        ,Partida_que_cumplimentaDescripcion = CultureHelper.GetTraduction(m.Partida_que_cumplimenta_Partida_que_Cumplimenta.Clave.ToString(), "Descripcion") ?? (string)m.Partida_que_cumplimenta_Partida_que_Cumplimenta.Descripcion
                        ,Area_que_envia_cumplimientoDescripcion = CultureHelper.GetTraduction(m.Area_que_envia_cumplimiento_Area_envia_Cumplimiento.Clave.ToString(), "Area_envia_Cumplimiento") ?? (string)m.Area_que_envia_cumplimiento_Area_envia_Cumplimiento.Descripcion
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Observaciones_del_Cumplimiento = m.Observaciones_del_Cumplimiento

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetRegistro_de_CumplimientoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegistro_de_CumplimientoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Registro_de_Cumplimiento", m.),
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
        /// Get List of Registro_de_Cumplimiento from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Registro_de_Cumplimiento Entity</returns>
        public ActionResult GetRegistro_de_CumplimientoList(UrlParametersModel param)
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
            _IRegistro_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Registro_de_CumplimientoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Registro_de_CumplimientoAdvanceSearchModel))
                {
					var advanceFilter =
                    (Registro_de_CumplimientoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Registro_de_CumplimientoPropertyMapper oRegistro_de_CumplimientoPropertyMapper = new Registro_de_CumplimientoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oRegistro_de_CumplimientoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IRegistro_de_CumplimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Cumplimientos == null)
                result.Registro_de_Cumplimientos = new List<Registro_de_Cumplimiento>();

            return Json(new
            {
                aaData = result.Registro_de_Cumplimientos.Select(m => new Registro_de_CumplimientoGridModel
            {
                    Clave = m.Clave
                        ,Mandamiento_JudicialNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_de_RegistroName = CultureHelper.GetTraduction(m.Usuario_de_Registro_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_de_Registro_Spartan_User.Name
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion_de_Mandamiento_Judicial.Descripcion
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
			,Numero_de_Oficio = m.Numero_de_Oficio
			,Radiograma = m.Radiograma
                        ,Partida_que_cumplimentaDescripcion = CultureHelper.GetTraduction(m.Partida_que_cumplimenta_Partida_que_Cumplimenta.Clave.ToString(), "Descripcion") ?? (string)m.Partida_que_cumplimenta_Partida_que_Cumplimenta.Descripcion
                        ,Area_que_envia_cumplimientoDescripcion = CultureHelper.GetTraduction(m.Area_que_envia_cumplimiento_Area_envia_Cumplimiento.Clave.ToString(), "Area_envia_Cumplimiento") ?? (string)m.Area_que_envia_cumplimiento_Area_envia_Cumplimiento.Descripcion
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Observaciones_del_Cumplimiento = m.Observaciones_del_Cumplimiento

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetRegistro_de_Cumplimiento_Mandamiento_Judicial_Registro_de_Mandamiento_Judicial(string query, string where)
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
        public JsonResult GetRegistro_de_Cumplimiento_Usuario_de_Registro_Spartan_User(string query, string where)
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
        public JsonResult GetRegistro_de_Cumplimiento_Area_que_envia_cumplimiento_Area_envia_Cumplimiento(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IArea_envia_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Area_envia_Cumplimiento.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Area_envia_Cumplimiento.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IArea_envia_CumplimientoApiConsumer.ListaSelAll(1, 20,elWhere , " Area_envia_Cumplimiento.Descripcion ASC ").Resource;
               
                foreach (var item in result.Area_envia_Cumplimientos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Area_envia_Cumplimiento", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Area_envia_Cumplimientos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetRegistro_de_Cumplimiento_Estado_Estado(string query, string where)
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
        [HttpGet]
        public JsonResult GetRegistro_de_Cumplimiento_Municipio_Municipio(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Municipio.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Municipio.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IMunicipioApiConsumer.ListaSelAll(1, 20,elWhere , " Municipio.Nombre ASC ").Resource;
               
                foreach (var item in result.Municipios)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Municipios.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetRegistro_de_Cumplimiento_Poblacion_Colonia(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Colonia.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Colonia.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IColoniaApiConsumer.ListaSelAll(1, 20,elWhere , " Colonia.Nombre ASC ").Resource;
               
                foreach (var item in result.Colonias)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Colonias.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetRegistro_de_Cumplimiento_Colonia_Colonia(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Colonia.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Colonia.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IColoniaApiConsumer.ListaSelAll(1, 20,elWhere , " Colonia.Nombre ASC ").Resource;
               
                foreach (var item in result.Colonias)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Colonias.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(Registro_de_CumplimientoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Registro_de_Cumplimiento.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Registro_de_Cumplimiento.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMandamiento_Judicial))
            {
                switch (filter.Mandamiento_JudicialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento LIKE '" + filter.AdvanceMandamiento_Judicial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento LIKE '%" + filter.AdvanceMandamiento_Judicial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento = '" + filter.AdvanceMandamiento_Judicial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento LIKE '%" + filter.AdvanceMandamiento_Judicial + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMandamiento_JudicialMultiple != null && filter.AdvanceMandamiento_JudicialMultiple.Count() > 0)
            {
                var Mandamiento_JudicialIds = string.Join(",", filter.AdvanceMandamiento_JudicialMultiple);

                where += " AND Registro_de_Cumplimiento.Mandamiento_Judicial In (" + Mandamiento_JudicialIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Registro_de_Cumplimiento.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Registro_de_Cumplimiento.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Registro_de_Cumplimiento.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Registro_de_Cumplimiento.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_de_Registro))
            {
                switch (filter.Usuario_de_RegistroFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_de_Registro + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_de_Registro + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_de_Registro + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_de_Registro + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_de_RegistroMultiple != null && filter.AdvanceUsuario_de_RegistroMultiple.Count() > 0)
            {
                var Usuario_de_RegistroIds = string.Join(",", filter.AdvanceUsuario_de_RegistroMultiple);

                where += " AND Registro_de_Cumplimiento.Usuario_de_Registro In (" + Usuario_de_RegistroIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResolucion))
            {
                switch (filter.ResolucionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resolucion_de_Mandamiento_Judicial.Descripcion LIKE '" + filter.AdvanceResolucion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resolucion_de_Mandamiento_Judicial.Descripcion LIKE '%" + filter.AdvanceResolucion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resolucion_de_Mandamiento_Judicial.Descripcion = '" + filter.AdvanceResolucion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resolucion_de_Mandamiento_Judicial.Descripcion LIKE '%" + filter.AdvanceResolucion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResolucionMultiple != null && filter.AdvanceResolucionMultiple.Count() > 0)
            {
                var ResolucionIds = string.Join(",", filter.AdvanceResolucionMultiple);

                where += " AND Registro_de_Cumplimiento.Resolucion In (" + ResolucionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Resolucion) || !string.IsNullOrEmpty(filter.ToFecha_de_Resolucion))
            {
                var Fecha_de_ResolucionFrom = DateTime.ParseExact(filter.FromFecha_de_Resolucion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_ResolucionTo = DateTime.ParseExact(filter.ToFecha_de_Resolucion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Resolucion))
                    where += " AND Registro_de_Cumplimiento.Fecha_de_Resolucion >= '" + Fecha_de_ResolucionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Resolucion))
                    where += " AND Registro_de_Cumplimiento.Fecha_de_Resolucion <= '" + Fecha_de_ResolucionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Oficio))
            {
                switch (filter.Numero_de_OficioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Cumplimiento.Numero_de_Oficio LIKE '" + filter.Numero_de_Oficio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Cumplimiento.Numero_de_Oficio LIKE '%" + filter.Numero_de_Oficio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Cumplimiento.Numero_de_Oficio = '" + filter.Numero_de_Oficio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Cumplimiento.Numero_de_Oficio LIKE '%" + filter.Numero_de_Oficio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Radiograma))
            {
                switch (filter.RadiogramaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Cumplimiento.Radiograma LIKE '" + filter.Radiograma + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Cumplimiento.Radiograma LIKE '%" + filter.Radiograma + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Cumplimiento.Radiograma = '" + filter.Radiograma + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Cumplimiento.Radiograma LIKE '%" + filter.Radiograma + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvancePartida_que_cumplimenta))
            {
                switch (filter.Partida_que_cumplimentaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Partida_que_Cumplimenta.Descripcion LIKE '" + filter.AdvancePartida_que_cumplimenta + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Partida_que_Cumplimenta.Descripcion LIKE '%" + filter.AdvancePartida_que_cumplimenta + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Partida_que_Cumplimenta.Descripcion = '" + filter.AdvancePartida_que_cumplimenta + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Partida_que_Cumplimenta.Descripcion LIKE '%" + filter.AdvancePartida_que_cumplimenta + "%'";
                        break;
                }
            }
            else if (filter.AdvancePartida_que_cumplimentaMultiple != null && filter.AdvancePartida_que_cumplimentaMultiple.Count() > 0)
            {
                var Partida_que_cumplimentaIds = string.Join(",", filter.AdvancePartida_que_cumplimentaMultiple);

                where += " AND Registro_de_Cumplimiento.Partida_que_cumplimenta In (" + Partida_que_cumplimentaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceArea_que_envia_cumplimiento))
            {
                switch (filter.Area_que_envia_cumplimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Area_envia_Cumplimiento.Descripcion LIKE '" + filter.AdvanceArea_que_envia_cumplimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Area_envia_Cumplimiento.Descripcion LIKE '%" + filter.AdvanceArea_que_envia_cumplimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Area_envia_Cumplimiento.Descripcion = '" + filter.AdvanceArea_que_envia_cumplimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Area_envia_Cumplimiento.Descripcion LIKE '%" + filter.AdvanceArea_que_envia_cumplimiento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceArea_que_envia_cumplimientoMultiple != null && filter.AdvanceArea_que_envia_cumplimientoMultiple.Count() > 0)
            {
                var Area_que_envia_cumplimientoIds = string.Join(",", filter.AdvanceArea_que_envia_cumplimientoMultiple);

                where += " AND Registro_de_Cumplimiento.Area_que_envia_cumplimiento In (" + Area_que_envia_cumplimientoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado))
            {
                switch (filter.EstadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstadoMultiple != null && filter.AdvanceEstadoMultiple.Count() > 0)
            {
                var EstadoIds = string.Join(",", filter.AdvanceEstadoMultiple);

                where += " AND Registro_de_Cumplimiento.Estado In (" + EstadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio))
            {
                switch (filter.MunicipioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipioMultiple != null && filter.AdvanceMunicipioMultiple.Count() > 0)
            {
                var MunicipioIds = string.Join(",", filter.AdvanceMunicipioMultiple);

                where += " AND Registro_de_Cumplimiento.Municipio In (" + MunicipioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePoblacion))
            {
                switch (filter.PoblacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvancePoblacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvancePoblacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvancePoblacion + "%'";
                        break;
                }
            }
            else if (filter.AdvancePoblacionMultiple != null && filter.AdvancePoblacionMultiple.Count() > 0)
            {
                var PoblacionIds = string.Join(",", filter.AdvancePoblacionMultiple);

                where += " AND Registro_de_Cumplimiento.Poblacion In (" + PoblacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia))
            {
                switch (filter.ColoniaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColoniaMultiple != null && filter.AdvanceColoniaMultiple.Count() > 0)
            {
                var ColoniaIds = string.Join(",", filter.AdvanceColoniaMultiple);

                where += " AND Registro_de_Cumplimiento.Colonia In (" + ColoniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_del_Cumplimiento))
            {
                switch (filter.Observaciones_del_CumplimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Cumplimiento.Observaciones_del_Cumplimiento LIKE '" + filter.Observaciones_del_Cumplimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Cumplimiento.Observaciones_del_Cumplimiento LIKE '%" + filter.Observaciones_del_Cumplimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Cumplimiento.Observaciones_del_Cumplimiento = '" + filter.Observaciones_del_Cumplimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Cumplimiento.Observaciones_del_Cumplimiento LIKE '%" + filter.Observaciones_del_Cumplimiento + "%'";
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

        public ActionResult GetPersonas_donde_se_ejecuto_mandamiento(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Personas_donde_se_ejecuto_mandamientoGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Personas_donde_se_ejecuto_mandamiento.Cumplimiento=" + RelationId;
            if("int" == "string")
            {
	           where = "Personas_donde_se_ejecuto_mandamiento.Cumplimiento='" + RelationId + "'";
            }
            var result = _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Personas_donde_se_ejecuto_mandamientos == null)
                result.Personas_donde_se_ejecuto_mandamientos = new List<Personas_donde_se_ejecuto_mandamiento>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Personas_donde_se_ejecuto_mandamientos.Select(m => new Personas_donde_se_ejecuto_mandamientoGridModel
                {
                    Folio = m.Folio

			,Persona = m.Persona
			,Seleccionar = m.Seleccionar
			,PersonaId = m.PersonaId

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Personas_donde_se_ejecuto_mandamientoGridModel> GetPersonas_donde_se_ejecuto_mandamientoData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Personas_donde_se_ejecuto_mandamientoGridModel> resultData = new List<Personas_donde_se_ejecuto_mandamientoGridModel>();
            string where = "Personas_donde_se_ejecuto_mandamiento.Cumplimiento=" + Id;
            if("int" == "string")
            {
                where = "Personas_donde_se_ejecuto_mandamiento.Cumplimiento='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Personas_donde_se_ejecuto_mandamientos != null)
            {
                resultData = result.Personas_donde_se_ejecuto_mandamientos.Select(m => new Personas_donde_se_ejecuto_mandamientoGridModel
                    {
                        Folio = m.Folio

			,Persona = m.Persona
			,Seleccionar = m.Seleccionar
			,PersonaId = m.PersonaId


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
                _IRegistro_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Registro_de_Cumplimiento varRegistro_de_Cumplimiento = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Personas_donde_se_ejecuto_mandamiento.Cumplimiento=" + id;
                    if("int" == "string")
                    {
	                where = "Personas_donde_se_ejecuto_mandamiento.Cumplimiento='" + id + "'";
                    }
                    var Personas_donde_se_ejecuto_mandamientoInfo =
                        _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Personas_donde_se_ejecuto_mandamientoInfo.Personas_donde_se_ejecuto_mandamientos.Count > 0)
                    {
                        var resultPersonas_donde_se_ejecuto_mandamiento = true;
                        //Removing associated job history with attachment
                        foreach (var Personas_donde_se_ejecuto_mandamientoItem in Personas_donde_se_ejecuto_mandamientoInfo.Personas_donde_se_ejecuto_mandamientos)
                            resultPersonas_donde_se_ejecuto_mandamiento = resultPersonas_donde_se_ejecuto_mandamiento
                                              && _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.Delete(Personas_donde_se_ejecuto_mandamientoItem.Folio, null,null).Resource;

                        if (!resultPersonas_donde_se_ejecuto_mandamiento)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IRegistro_de_CumplimientoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Registro_de_CumplimientoModel varRegistro_de_Cumplimiento)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IRegistro_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Registro_de_CumplimientoInfo = new Registro_de_Cumplimiento
                    {
                        Clave = varRegistro_de_Cumplimiento.Clave
                        ,Mandamiento_Judicial = varRegistro_de_Cumplimiento.Mandamiento_Judicial
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varRegistro_de_Cumplimiento.Fecha_de_Registro)) ? DateTime.ParseExact(varRegistro_de_Cumplimiento.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varRegistro_de_Cumplimiento.Hora_de_Registro
                        ,Usuario_de_Registro = varRegistro_de_Cumplimiento.Usuario_de_Registro
                        ,Resolucion = varRegistro_de_Cumplimiento.Resolucion
                        ,Fecha_de_Resolucion = (!String.IsNullOrEmpty(varRegistro_de_Cumplimiento.Fecha_de_Resolucion)) ? DateTime.ParseExact(varRegistro_de_Cumplimiento.Fecha_de_Resolucion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Numero_de_Oficio = varRegistro_de_Cumplimiento.Numero_de_Oficio
                        ,Radiograma = varRegistro_de_Cumplimiento.Radiograma
                        ,Partida_que_cumplimenta = varRegistro_de_Cumplimiento.Partida_que_cumplimenta
                        ,Area_que_envia_cumplimiento = varRegistro_de_Cumplimiento.Area_que_envia_cumplimiento
                        ,Estado = varRegistro_de_Cumplimiento.Estado
                        ,Municipio = varRegistro_de_Cumplimiento.Municipio
                        ,Poblacion = varRegistro_de_Cumplimiento.Poblacion
                        ,Colonia = varRegistro_de_Cumplimiento.Colonia
                        ,Observaciones_del_Cumplimiento = varRegistro_de_Cumplimiento.Observaciones_del_Cumplimiento

                    };

                    result = !IsNew ?
                        _IRegistro_de_CumplimientoApiConsumer.Update(Registro_de_CumplimientoInfo, null, null).Resource.ToString() :
                         _IRegistro_de_CumplimientoApiConsumer.Insert(Registro_de_CumplimientoInfo, null, null).Resource.ToString();
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
        public bool CopyPersonas_donde_se_ejecuto_mandamiento(int MasterId, int referenceId, List<Personas_donde_se_ejecuto_mandamientoGridModelPost> Personas_donde_se_ejecuto_mandamientoItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Personas_donde_se_ejecuto_mandamientoData = _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.ListaSelAll(1, int.MaxValue, "Personas_donde_se_ejecuto_mandamiento.Cumplimiento=" + referenceId,"").Resource;
                if (Personas_donde_se_ejecuto_mandamientoData == null || Personas_donde_se_ejecuto_mandamientoData.Personas_donde_se_ejecuto_mandamientos.Count == 0)
                    return true;

                var result = true;

                Personas_donde_se_ejecuto_mandamientoGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varPersonas_donde_se_ejecuto_mandamiento in Personas_donde_se_ejecuto_mandamientoData.Personas_donde_se_ejecuto_mandamientos)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Personas_donde_se_ejecuto_mandamiento Personas_donde_se_ejecuto_mandamiento1 = varPersonas_donde_se_ejecuto_mandamiento;

                    if (Personas_donde_se_ejecuto_mandamientoItems != null && Personas_donde_se_ejecuto_mandamientoItems.Any(m => m.Folio == Personas_donde_se_ejecuto_mandamiento1.Folio))
                    {
                        modelDataToChange = Personas_donde_se_ejecuto_mandamientoItems.FirstOrDefault(m => m.Folio == Personas_donde_se_ejecuto_mandamiento1.Folio);
                    }
                    //Chaning Id Value
                    varPersonas_donde_se_ejecuto_mandamiento.Cumplimiento = MasterId;
                    var insertId = _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.Insert(varPersonas_donde_se_ejecuto_mandamiento,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Folio = insertId;

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
        public ActionResult PostPersonas_donde_se_ejecuto_mandamiento(List<Personas_donde_se_ejecuto_mandamientoGridModelPost> Personas_donde_se_ejecuto_mandamientoItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyPersonas_donde_se_ejecuto_mandamiento(MasterId, referenceId, Personas_donde_se_ejecuto_mandamientoItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Personas_donde_se_ejecuto_mandamientoItems != null && Personas_donde_se_ejecuto_mandamientoItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Personas_donde_se_ejecuto_mandamientoItem in Personas_donde_se_ejecuto_mandamientoItems)
                    {





                        //Removal Request
                        if (Personas_donde_se_ejecuto_mandamientoItem.Removed)
                        {
                            result = result && _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.Delete(Personas_donde_se_ejecuto_mandamientoItem.Folio, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Personas_donde_se_ejecuto_mandamientoItem.Folio = 0;

                        var Personas_donde_se_ejecuto_mandamientoData = new Personas_donde_se_ejecuto_mandamiento
                        {
                            Cumplimiento = MasterId
                            ,Folio = Personas_donde_se_ejecuto_mandamientoItem.Folio
                            ,Persona = Personas_donde_se_ejecuto_mandamientoItem.Persona
                            ,Seleccionar = Personas_donde_se_ejecuto_mandamientoItem.Seleccionar
                            ,PersonaId = Personas_donde_se_ejecuto_mandamientoItem.PersonaId

                        };

                        var resultId = Personas_donde_se_ejecuto_mandamientoItem.Folio > 0
                           ? _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.Update(Personas_donde_se_ejecuto_mandamientoData,null,null).Resource
                           : _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.Insert(Personas_donde_se_ejecuto_mandamientoData,null,null).Resource;

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
        /// Write Element Array of Registro_de_Cumplimiento script
        /// </summary>
        /// <param name="oRegistro_de_CumplimientoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Registro_de_CumplimientoModuleAttributeList)
        {
            for (int i = 0; i < Registro_de_CumplimientoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Registro_de_CumplimientoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Registro_de_CumplimientoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Registro_de_CumplimientoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Registro_de_CumplimientoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Registro_de_CumplimientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Registro_de_CumplimientoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Registro_de_CumplimientoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Registro_de_CumplimientoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Registro_de_CumplimientoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Registro_de_CumplimientoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Registro_de_CumplimientoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strRegistro_de_CumplimientoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Registro_de_Cumplimiento.js")))
            {
                strRegistro_de_CumplimientoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Registro_de_Cumplimiento element attributes
            string userChangeJson = jsSerialize.Serialize(Registro_de_CumplimientoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strRegistro_de_CumplimientoScript.IndexOf("inpuElementArray");
            string splittedString = strRegistro_de_CumplimientoScript.Substring(indexOfArray, strRegistro_de_CumplimientoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Registro_de_CumplimientoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Registro_de_CumplimientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strRegistro_de_CumplimientoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strRegistro_de_CumplimientoScript.Substring(indexOfArrayHistory, strRegistro_de_CumplimientoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strRegistro_de_CumplimientoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strRegistro_de_CumplimientoScript.Substring(endIndexOfMainElement + indexOfArray, strRegistro_de_CumplimientoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Registro_de_CumplimientoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Registro_de_CumplimientoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Registro_de_Cumplimiento.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Registro_de_Cumplimiento.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Registro_de_Cumplimiento.js")))
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
        public ActionResult Registro_de_CumplimientoPropertyBag()
        {
            return PartialView("Registro_de_CumplimientoPropertyBag", "Registro_de_Cumplimiento");
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
        public ActionResult AddPersonas_donde_se_ejecuto_mandamiento(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Personas_donde_se_ejecuto_mandamiento/AddPersonas_donde_se_ejecuto_mandamiento");
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
                var whereClauseFormat = "Object = 46299 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IRegistro_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Registro_de_Cumplimiento.Clave= " + RecordId;
                            var result = _IRegistro_de_CumplimientoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IRegistro_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Registro_de_CumplimientoPropertyMapper());
			
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
                    (Registro_de_CumplimientoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Registro_de_CumplimientoPropertyMapper oRegistro_de_CumplimientoPropertyMapper = new Registro_de_CumplimientoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRegistro_de_CumplimientoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRegistro_de_CumplimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Cumplimientos == null)
                result.Registro_de_Cumplimientos = new List<Registro_de_Cumplimiento>();

            var data = result.Registro_de_Cumplimientos.Select(m => new Registro_de_CumplimientoGridModel
            {
                Clave = m.Clave
                        ,Mandamiento_JudicialNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_de_RegistroName = CultureHelper.GetTraduction(m.Usuario_de_Registro_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_de_Registro_Spartan_User.Name
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion_de_Mandamiento_Judicial.Descripcion
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
			,Numero_de_Oficio = m.Numero_de_Oficio
			,Radiograma = m.Radiograma
                        ,Partida_que_cumplimentaDescripcion = CultureHelper.GetTraduction(m.Partida_que_cumplimenta_Partida_que_Cumplimenta.Clave.ToString(), "Descripcion") ?? (string)m.Partida_que_cumplimenta_Partida_que_Cumplimenta.Descripcion
                        ,Area_que_envia_cumplimientoDescripcion = CultureHelper.GetTraduction(m.Area_que_envia_cumplimiento_Area_envia_Cumplimiento.Clave.ToString(), "Area_envia_Cumplimiento") ?? (string)m.Area_que_envia_cumplimiento_Area_envia_Cumplimiento.Descripcion
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Observaciones_del_Cumplimiento = m.Observaciones_del_Cumplimiento

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(46299, arrayColumnsVisible), "Registro_de_CumplimientoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(46299, arrayColumnsVisible), "Registro_de_CumplimientoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(46299, arrayColumnsVisible), "Registro_de_CumplimientoList_" + DateTime.Now.ToString());
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

            _IRegistro_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Registro_de_CumplimientoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Registro_de_CumplimientoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Registro_de_CumplimientoPropertyMapper oRegistro_de_CumplimientoPropertyMapper = new Registro_de_CumplimientoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRegistro_de_CumplimientoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRegistro_de_CumplimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Cumplimientos == null)
                result.Registro_de_Cumplimientos = new List<Registro_de_Cumplimiento>();

            var data = result.Registro_de_Cumplimientos.Select(m => new Registro_de_CumplimientoGridModel
            {
                Clave = m.Clave
                        ,Mandamiento_JudicialNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_de_RegistroName = CultureHelper.GetTraduction(m.Usuario_de_Registro_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_de_Registro_Spartan_User.Name
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion_de_Mandamiento_Judicial.Descripcion
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
			,Numero_de_Oficio = m.Numero_de_Oficio
			,Radiograma = m.Radiograma
                        ,Partida_que_cumplimentaDescripcion = CultureHelper.GetTraduction(m.Partida_que_cumplimenta_Partida_que_Cumplimenta.Clave.ToString(), "Descripcion") ?? (string)m.Partida_que_cumplimenta_Partida_que_Cumplimenta.Descripcion
                        ,Area_que_envia_cumplimientoDescripcion = CultureHelper.GetTraduction(m.Area_que_envia_cumplimiento_Area_envia_Cumplimiento.Clave.ToString(), "Area_envia_Cumplimiento") ?? (string)m.Area_que_envia_cumplimiento_Area_envia_Cumplimiento.Descripcion
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Observaciones_del_Cumplimiento = m.Observaciones_del_Cumplimiento

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
                _IRegistro_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegistro_de_CumplimientoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Registro_de_Cumplimiento_Datos_GeneralesModel varRegistro_de_Cumplimiento)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Cumplimiento_Datos_GeneralesInfo = new Registro_de_Cumplimiento_Datos_Generales
                {
                    Clave = varRegistro_de_Cumplimiento.Clave
                                            ,Mandamiento_Judicial = varRegistro_de_Cumplimiento.Mandamiento_Judicial
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varRegistro_de_Cumplimiento.Fecha_de_Registro)) ? DateTime.ParseExact(varRegistro_de_Cumplimiento.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varRegistro_de_Cumplimiento.Hora_de_Registro
                        ,Usuario_de_Registro = varRegistro_de_Cumplimiento.Usuario_de_Registro
                        ,Resolucion = varRegistro_de_Cumplimiento.Resolucion
                        ,Fecha_de_Resolucion = (!String.IsNullOrEmpty(varRegistro_de_Cumplimiento.Fecha_de_Resolucion)) ? DateTime.ParseExact(varRegistro_de_Cumplimiento.Fecha_de_Resolucion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Numero_de_Oficio = varRegistro_de_Cumplimiento.Numero_de_Oficio
                        ,Radiograma = varRegistro_de_Cumplimiento.Radiograma
                        ,Partida_que_cumplimenta = varRegistro_de_Cumplimiento.Partida_que_cumplimenta
                        ,Area_que_envia_cumplimiento = varRegistro_de_Cumplimiento.Area_que_envia_cumplimiento
                        ,Estado = varRegistro_de_Cumplimiento.Estado
                        ,Municipio = varRegistro_de_Cumplimiento.Municipio
                        ,Poblacion = varRegistro_de_Cumplimiento.Poblacion
                        ,Colonia = varRegistro_de_Cumplimiento.Colonia
                        ,Observaciones_del_Cumplimiento = varRegistro_de_Cumplimiento.Observaciones_del_Cumplimiento
                    
                };

                result = _IRegistro_de_CumplimientoApiConsumer.Update_Datos_Generales(Registro_de_Cumplimiento_Datos_GeneralesInfo).Resource.ToString();
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
                _IRegistro_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_CumplimientoApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Personas_donde_se_ejecuto_mandamiento;
                var Personas_donde_se_ejecuto_mandamientoData = GetPersonas_donde_se_ejecuto_mandamientoData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Personas_donde_se_ejecuto_mandamiento);

                var result = new Registro_de_Cumplimiento_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Mandamiento_Judicial = m.Mandamiento_Judicial
                        ,Mandamiento_JudicialNumero_de_Mandamiento = CultureHelper.GetTraduction(m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Clave.ToString(), "Registro_de_Mandamiento_Judicial") ?? (string)m.Mandamiento_Judicial_Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_de_Registro = m.Usuario_de_Registro
                        ,Usuario_de_RegistroName = CultureHelper.GetTraduction(m.Usuario_de_Registro_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_de_Registro_Spartan_User.Name
                        ,Resolucion = m.Resolucion
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Resolucion_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Resolucion_de_Mandamiento_Judicial.Descripcion
                        ,Fecha_de_Resolucion = (m.Fecha_de_Resolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Resolucion).ToString(ConfigurationProperty.DateFormat))
			,Numero_de_Oficio = m.Numero_de_Oficio
			,Radiograma = m.Radiograma
                        ,Partida_que_cumplimenta = m.Partida_que_cumplimenta
                        ,Partida_que_cumplimentaDescripcion = CultureHelper.GetTraduction(m.Partida_que_cumplimenta_Partida_que_Cumplimenta.Clave.ToString(), "Descripcion") ?? (string)m.Partida_que_cumplimenta_Partida_que_Cumplimenta.Descripcion
                        ,Area_que_envia_cumplimiento = m.Area_que_envia_cumplimiento
                        ,Area_que_envia_cumplimientoDescripcion = CultureHelper.GetTraduction(m.Area_que_envia_cumplimiento_Area_envia_Cumplimiento.Clave.ToString(), "Area_envia_Cumplimiento") ?? (string)m.Area_que_envia_cumplimiento_Area_envia_Cumplimiento.Descripcion
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Observaciones_del_Cumplimiento = m.Observaciones_del_Cumplimiento

                    
                };
				var resultData = new
                {
                    data = result
                    ,Personas_donde_se_ejecuto_mandamiento = Personas_donde_se_ejecuto_mandamientoData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

