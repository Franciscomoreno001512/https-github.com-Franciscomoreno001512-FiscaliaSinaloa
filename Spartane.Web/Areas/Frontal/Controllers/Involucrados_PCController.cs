using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Involucrados_PC;
using Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Core.Domain.Tipo_de_Solicitud;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Involucrados_PC;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Involucrados_PC;
using Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;

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
    public class Involucrados_PCController : Controller
    {
        #region "variable declaration"

        private IInvolucrados_PCService service = null;
        private IInvolucrados_PCApiConsumer _IInvolucrados_PCApiConsumer;
        private ISolicitud_de_Denuncia_CiudadanaApiConsumer _ISolicitud_de_Denuncia_CiudadanaApiConsumer;
        private ITipo_de_SolicitudApiConsumer _ITipo_de_SolicitudApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ITipo_de_ComparecienteApiConsumer _ITipo_de_ComparecienteApiConsumer;
        private IGeneroApiConsumer _IGeneroApiConsumer;
        private IEstado_CivilApiConsumer _IEstado_CivilApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private INacionalidadApiConsumer _INacionalidadApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;

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

        
        public Involucrados_PCController(IInvolucrados_PCService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IInvolucrados_PCApiConsumer Involucrados_PCApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISolicitud_de_Denuncia_CiudadanaApiConsumer Solicitud_de_Denuncia_CiudadanaApiConsumer , ITipo_de_SolicitudApiConsumer Tipo_de_SolicitudApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ITipo_de_ComparecienteApiConsumer Tipo_de_ComparecienteApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IInvolucrados_PCApiConsumer = Involucrados_PCApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ISolicitud_de_Denuncia_CiudadanaApiConsumer = Solicitud_de_Denuncia_CiudadanaApiConsumer;
            this._ITipo_de_SolicitudApiConsumer = Tipo_de_SolicitudApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ITipo_de_ComparecienteApiConsumer = Tipo_de_ComparecienteApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Involucrados_PC
        [ObjectAuth(ObjectId = (ModuleObjectId)45713, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45713, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Involucrados_PC/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45713, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45713, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varInvolucrados_PC = new Involucrados_PCModel();
			varInvolucrados_PC.Clave = Id;
			
            ViewBag.ObjectId = "45713";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IInvolucrados_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Involucrados_PCsData = _IInvolucrados_PCApiConsumer.ListaSelAll(0, 1000, "Involucrados_PC.Clave=" + Id, "").Resource.Involucrados_PCs;
				
				if (Involucrados_PCsData != null && Involucrados_PCsData.Count > 0)
                {
					var Involucrados_PCData = Involucrados_PCsData.First();
					varInvolucrados_PC= new Involucrados_PCModel
					{
						Clave  = Involucrados_PCData.Clave 
	                    ,Solicitud = Involucrados_PCData.Solicitud
                    ,SolicitudFolio = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Solicitud), "Solicitud_de_Denuncia_Ciudadana") ??  (string)Involucrados_PCData.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                    ,Tipo_de_Solicitud = Involucrados_PCData.Tipo_de_Solicitud
                    ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Tipo_de_Solicitud), "Tipo_de_Solicitud") ??  (string)Involucrados_PCData.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                    ,Usuario_que_Registra = Involucrados_PCData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Usuario_que_Registra), "Spartan_User") ??  (string)Involucrados_PCData.Usuario_que_Registra_Spartan_User.Name
                    ,Tipo_de_Compareciente = Involucrados_PCData.Tipo_de_Compareciente
                    ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Tipo_de_Compareciente), "Tipo_de_Compareciente") ??  (string)Involucrados_PCData.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                    ,Nombres = Involucrados_PCData.Nombres
                    ,Apellido_Paterno = Involucrados_PCData.Apellido_Paterno
                    ,Apellido_Materno = Involucrados_PCData.Apellido_Materno
                    ,Nombre_Completo = Involucrados_PCData.Nombre_Completo
                    ,Fecha_de_Nacimiento = (Involucrados_PCData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Involucrados_PCData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Involucrados_PCData.Edad
                    ,Sexo = Involucrados_PCData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Sexo), "Genero") ??  (string)Involucrados_PCData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Involucrados_PCData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Estado_Civil), "Estado_Civil") ??  (string)Involucrados_PCData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Involucrados_PCData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Involucrados_PCData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Involucrados_PCData.Numero_de_Identificacion
                    ,Fotografia_de_la_identificacion = Involucrados_PCData.Fotografia_de_la_identificacion
                    ,CURP = Involucrados_PCData.CURP
                    ,Nacionalidad = Involucrados_PCData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Nacionalidad), "Nacionalidad") ??  (string)Involucrados_PCData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Originario_de = Involucrados_PCData.Originario_de
                    ,Pais = Involucrados_PCData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Pais), "Pais") ??  (string)Involucrados_PCData.Pais_Pais.Nombre
                    ,Estado = Involucrados_PCData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Estado), "Estado") ??  (string)Involucrados_PCData.Estado_Estado.Nombre
                    ,Municipio = Involucrados_PCData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Municipio), "Municipio") ??  (string)Involucrados_PCData.Municipio_Municipio.Nombre
                    ,Poblacion = Involucrados_PCData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Poblacion), "Colonia") ??  (string)Involucrados_PCData.Poblacion_Colonia.Nombre
                    ,Colonia = Involucrados_PCData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Colonia), "Colonia") ??  (string)Involucrados_PCData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Involucrados_PCData.Codigo_Postal
                    ,Calle = Involucrados_PCData.Calle
                    ,Entre_Calle = Involucrados_PCData.Entre_Calle
                    ,Y_Calle = Involucrados_PCData.Y_Calle
                    ,Numero_Exterior = Involucrados_PCData.Numero_Exterior
                    ,Numero_Interior = Involucrados_PCData.Numero_Interior
                    ,Referencia_de_Domicilio = Involucrados_PCData.Referencia_de_Domicilio
                    ,Latitud = Involucrados_PCData.Latitud
                    ,Longitud = Involucrados_PCData.Longitud

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Fotografia_de_la_identificacionSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varInvolucrados_PC.Fotografia_de_la_identificacion).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Solicituds_Tipo_de_Solicitud = _ITipo_de_SolicitudApiConsumer.SelAll(true);
            if (Tipo_de_Solicituds_Tipo_de_Solicitud != null && Tipo_de_Solicituds_Tipo_de_Solicitud.Resource != null)
                ViewBag.Tipo_de_Solicituds_Tipo_de_Solicitud = Tipo_de_Solicituds_Tipo_de_Solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil != null && Estado_Civils_Estado_Civil.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil = Estado_Civils_Estado_Civil.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varInvolucrados_PC);
        }
		
	[HttpGet]
        public ActionResult AddInvolucrados_PC(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45713);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IInvolucrados_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
			Involucrados_PCModel varInvolucrados_PC= new Involucrados_PCModel();


            if (id.ToString() != "0")
            {
                var Involucrados_PCsData = _IInvolucrados_PCApiConsumer.ListaSelAll(0, 1000, "Involucrados_PC.Clave=" + id, "").Resource.Involucrados_PCs;
				
				if (Involucrados_PCsData != null && Involucrados_PCsData.Count > 0)
                {
					var Involucrados_PCData = Involucrados_PCsData.First();
					varInvolucrados_PC= new Involucrados_PCModel
					{
						Clave  = Involucrados_PCData.Clave 
	                    ,Solicitud = Involucrados_PCData.Solicitud
                    ,SolicitudFolio = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Solicitud), "Solicitud_de_Denuncia_Ciudadana") ??  (string)Involucrados_PCData.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                    ,Tipo_de_Solicitud = Involucrados_PCData.Tipo_de_Solicitud
                    ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Tipo_de_Solicitud), "Tipo_de_Solicitud") ??  (string)Involucrados_PCData.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                    ,Usuario_que_Registra = Involucrados_PCData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Usuario_que_Registra), "Spartan_User") ??  (string)Involucrados_PCData.Usuario_que_Registra_Spartan_User.Name
                    ,Tipo_de_Compareciente = Involucrados_PCData.Tipo_de_Compareciente
                    ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Tipo_de_Compareciente), "Tipo_de_Compareciente") ??  (string)Involucrados_PCData.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                    ,Nombres = Involucrados_PCData.Nombres
                    ,Apellido_Paterno = Involucrados_PCData.Apellido_Paterno
                    ,Apellido_Materno = Involucrados_PCData.Apellido_Materno
                    ,Nombre_Completo = Involucrados_PCData.Nombre_Completo
                    ,Fecha_de_Nacimiento = (Involucrados_PCData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Involucrados_PCData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Involucrados_PCData.Edad
                    ,Sexo = Involucrados_PCData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Sexo), "Genero") ??  (string)Involucrados_PCData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Involucrados_PCData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Estado_Civil), "Estado_Civil") ??  (string)Involucrados_PCData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Involucrados_PCData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Involucrados_PCData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Involucrados_PCData.Numero_de_Identificacion
                    ,Fotografia_de_la_identificacion = Involucrados_PCData.Fotografia_de_la_identificacion
                    ,CURP = Involucrados_PCData.CURP
                    ,Nacionalidad = Involucrados_PCData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Nacionalidad), "Nacionalidad") ??  (string)Involucrados_PCData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Originario_de = Involucrados_PCData.Originario_de
                    ,Pais = Involucrados_PCData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Pais), "Pais") ??  (string)Involucrados_PCData.Pais_Pais.Nombre
                    ,Estado = Involucrados_PCData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Estado), "Estado") ??  (string)Involucrados_PCData.Estado_Estado.Nombre
                    ,Municipio = Involucrados_PCData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Municipio), "Municipio") ??  (string)Involucrados_PCData.Municipio_Municipio.Nombre
                    ,Poblacion = Involucrados_PCData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Poblacion), "Colonia") ??  (string)Involucrados_PCData.Poblacion_Colonia.Nombre
                    ,Colonia = Involucrados_PCData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Involucrados_PCData.Colonia), "Colonia") ??  (string)Involucrados_PCData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Involucrados_PCData.Codigo_Postal
                    ,Calle = Involucrados_PCData.Calle
                    ,Entre_Calle = Involucrados_PCData.Entre_Calle
                    ,Y_Calle = Involucrados_PCData.Y_Calle
                    ,Numero_Exterior = Involucrados_PCData.Numero_Exterior
                    ,Numero_Interior = Involucrados_PCData.Numero_Interior
                    ,Referencia_de_Domicilio = Involucrados_PCData.Referencia_de_Domicilio
                    ,Latitud = Involucrados_PCData.Latitud
                    ,Longitud = Involucrados_PCData.Longitud

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Fotografia_de_la_identificacionSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varInvolucrados_PC.Fotografia_de_la_identificacion).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Solicituds_Tipo_de_Solicitud = _ITipo_de_SolicitudApiConsumer.SelAll(true);
            if (Tipo_de_Solicituds_Tipo_de_Solicitud != null && Tipo_de_Solicituds_Tipo_de_Solicitud.Resource != null)
                ViewBag.Tipo_de_Solicituds_Tipo_de_Solicitud = Tipo_de_Solicituds_Tipo_de_Solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil != null && Estado_Civils_Estado_Civil.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil = Estado_Civils_Estado_Civil.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddInvolucrados_PC", varInvolucrados_PC);
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
        public ActionResult GetSolicitud_de_Denuncia_CiudadanaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Folio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitud_de_Denuncia_Ciudadana", "Folio")?? m.Folio,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_SolicitudAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_SolicitudApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Solicitud", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetTipo_de_ComparecienteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ComparecienteApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
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
        public ActionResult GetEstado_CivilAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstado_CivilApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetNacionalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _INacionalidadApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC")?? m.NacionalidadC,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetPaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre")?? m.Nombre,
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
        public ActionResult ShowAdvanceFilter(Involucrados_PCAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Solicituds_Tipo_de_Solicitud = _ITipo_de_SolicitudApiConsumer.SelAll(true);
            if (Tipo_de_Solicituds_Tipo_de_Solicitud != null && Tipo_de_Solicituds_Tipo_de_Solicitud.Resource != null)
                ViewBag.Tipo_de_Solicituds_Tipo_de_Solicitud = Tipo_de_Solicituds_Tipo_de_Solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil != null && Estado_Civils_Estado_Civil.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil = Estado_Civils_Estado_Civil.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Solicituds_Tipo_de_Solicitud = _ITipo_de_SolicitudApiConsumer.SelAll(true);
            if (Tipo_de_Solicituds_Tipo_de_Solicitud != null && Tipo_de_Solicituds_Tipo_de_Solicitud.Resource != null)
                ViewBag.Tipo_de_Solicituds_Tipo_de_Solicitud = Tipo_de_Solicituds_Tipo_de_Solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Registra = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Registra != null && Spartan_Users_Usuario_que_Registra.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Registra = Spartan_Users_Usuario_que_Registra.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil != null && Estado_Civils_Estado_Civil.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil = Estado_Civils_Estado_Civil.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion != null && Tipo_de_Identificacions_Tipo_de_Identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion = Tipo_de_Identificacions_Tipo_de_Identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Involucrados_PCAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Involucrados_PCAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Involucrados_PCAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Involucrados_PCPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IInvolucrados_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Involucrados_PCs == null)
                result.Involucrados_PCs = new List<Involucrados_PC>();

            return Json(new
            {
                data = result.Involucrados_PCs.Select(m => new Involucrados_PCGridModel
                    {
                    Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Fotografia_de_la_identificacion = m.Fotografia_de_la_identificacion
			,CURP = m.CURP
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
			,Originario_de = m.Originario_de
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetInvolucrados_PCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IInvolucrados_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IInvolucrados_PCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Involucrados_PC", m.),
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
        /// Get List of Involucrados_PC from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Involucrados_PC Entity</returns>
        public ActionResult GetInvolucrados_PCList(UrlParametersModel param)
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
            _IInvolucrados_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Involucrados_PCPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Involucrados_PCAdvanceSearchModel))
                {
					var advanceFilter =
                    (Involucrados_PCAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Involucrados_PCPropertyMapper oInvolucrados_PCPropertyMapper = new Involucrados_PCPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oInvolucrados_PCPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IInvolucrados_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Involucrados_PCs == null)
                result.Involucrados_PCs = new List<Involucrados_PC>();

            return Json(new
            {
                aaData = result.Involucrados_PCs.Select(m => new Involucrados_PCGridModel
            {
                    Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Fotografia_de_la_identificacion = m.Fotografia_de_la_identificacion
			,CURP = m.CURP
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
			,Originario_de = m.Originario_de
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetInvolucrados_PC_Solicitud_Solicitud_de_Denuncia_Ciudadana(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Solicitud_de_Denuncia_Ciudadana.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Solicitud_de_Denuncia_Ciudadana.Folio as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.ListaSelAll(1, 20,elWhere , " Solicitud_de_Denuncia_Ciudadana.Folio ASC ").Resource;
               
                foreach (var item in result.Solicitud_de_Denuncia_Ciudadanas)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Solicitud_de_Denuncia_Ciudadana", "Folio");
                    item.Folio =trans ??item.Folio;
                }
                return Json(result.Solicitud_de_Denuncia_Ciudadanas.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetInvolucrados_PC_Nacionalidad_Nacionalidad(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Nacionalidad.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Nacionalidad.NacionalidadC as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _INacionalidadApiConsumer.ListaSelAll(1, 20,elWhere , " Nacionalidad.NacionalidadC ASC ").Resource;
               
                foreach (var item in result.Nacionalidads)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Nacionalidad", "NacionalidadC");
                    item.NacionalidadC =trans ??item.NacionalidadC;
                }
                return Json(result.Nacionalidads.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetInvolucrados_PC_Pais_Pais(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Pais.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Pais.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IPaisApiConsumer.ListaSelAll(1, 20,elWhere , " Pais.Nombre ASC ").Resource;
               
                foreach (var item in result.Paiss)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Paiss.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetInvolucrados_PC_Estado_Estado(string query, string where)
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
        public JsonResult GetInvolucrados_PC_Municipio_Municipio(string query, string where)
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
        public JsonResult GetInvolucrados_PC_Poblacion_Colonia(string query, string where)
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
        public JsonResult GetInvolucrados_PC_Colonia_Colonia(string query, string where)
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





        [NonAction]
        public string GetAdvanceFilter(Involucrados_PCAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Involucrados_PC.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Involucrados_PC.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSolicitud))
            {
                switch (filter.SolicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '" + filter.AdvanceSolicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '%" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio = '" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '%" + filter.AdvanceSolicitud + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSolicitudMultiple != null && filter.AdvanceSolicitudMultiple.Count() > 0)
            {
                var SolicitudIds = string.Join(",", filter.AdvanceSolicitudMultiple);

                where += " AND Involucrados_PC.Solicitud In (" + SolicitudIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Solicitud))
            {
                switch (filter.Tipo_de_SolicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Solicitud.Descripcion LIKE '" + filter.AdvanceTipo_de_Solicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Solicitud.Descripcion LIKE '%" + filter.AdvanceTipo_de_Solicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Solicitud.Descripcion = '" + filter.AdvanceTipo_de_Solicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Solicitud.Descripcion LIKE '%" + filter.AdvanceTipo_de_Solicitud + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_SolicitudMultiple != null && filter.AdvanceTipo_de_SolicitudMultiple.Count() > 0)
            {
                var Tipo_de_SolicitudIds = string.Join(",", filter.AdvanceTipo_de_SolicitudMultiple);

                where += " AND Involucrados_PC.Tipo_de_Solicitud In (" + Tipo_de_SolicitudIds + ")";
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

                where += " AND Involucrados_PC.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Compareciente))
            {
                switch (filter.Tipo_de_ComparecienteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Compareciente.Descripcion LIKE '" + filter.AdvanceTipo_de_Compareciente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Compareciente.Descripcion LIKE '%" + filter.AdvanceTipo_de_Compareciente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Compareciente.Descripcion = '" + filter.AdvanceTipo_de_Compareciente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Compareciente.Descripcion LIKE '%" + filter.AdvanceTipo_de_Compareciente + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_ComparecienteMultiple != null && filter.AdvanceTipo_de_ComparecienteMultiple.Count() > 0)
            {
                var Tipo_de_ComparecienteIds = string.Join(",", filter.AdvanceTipo_de_ComparecienteMultiple);

                where += " AND Involucrados_PC.Tipo_de_Compareciente In (" + Tipo_de_ComparecienteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombres))
            {
                switch (filter.NombresFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.Nombres LIKE '" + filter.Nombres + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.Nombres LIKE '%" + filter.Nombres + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.Nombres = '" + filter.Nombres + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.Nombres LIKE '%" + filter.Nombres + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno))
            {
                switch (filter.Apellido_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.Apellido_Paterno LIKE '" + filter.Apellido_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.Apellido_Paterno = '" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno))
            {
                switch (filter.Apellido_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.Apellido_Materno LIKE '" + filter.Apellido_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.Apellido_Materno = '" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo))
            {
                switch (filter.Nombre_CompletoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.Nombre_Completo LIKE '" + filter.Nombre_Completo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.Nombre_Completo = '" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Nacimiento) || !string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento))
            {
                var Fecha_de_NacimientoFrom = DateTime.ParseExact(filter.FromFecha_de_Nacimiento, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_NacimientoTo = DateTime.ParseExact(filter.ToFecha_de_Nacimiento, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Nacimiento))
                    where += " AND Involucrados_PC.Fecha_de_Nacimiento >= '" + Fecha_de_NacimientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento))
                    where += " AND Involucrados_PC.Fecha_de_Nacimiento <= '" + Fecha_de_NacimientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromEdad) || !string.IsNullOrEmpty(filter.ToEdad))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad))
                    where += " AND Involucrados_PC.Edad >= " + filter.FromEdad;
                if (!string.IsNullOrEmpty(filter.ToEdad))
                    where += " AND Involucrados_PC.Edad <= " + filter.ToEdad;
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

                where += " AND Involucrados_PC.Sexo In (" + SexoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_Civil))
            {
                switch (filter.Estado_CivilFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado_Civil.Descripcion LIKE '" + filter.AdvanceEstado_Civil + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado_Civil.Descripcion LIKE '%" + filter.AdvanceEstado_Civil + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado_Civil.Descripcion = '" + filter.AdvanceEstado_Civil + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado_Civil.Descripcion LIKE '%" + filter.AdvanceEstado_Civil + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_CivilMultiple != null && filter.AdvanceEstado_CivilMultiple.Count() > 0)
            {
                var Estado_CivilIds = string.Join(",", filter.AdvanceEstado_CivilMultiple);

                where += " AND Involucrados_PC.Estado_Civil In (" + Estado_CivilIds + ")";
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

                where += " AND Involucrados_PC.Tipo_de_Identificacion In (" + Tipo_de_IdentificacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Identificacion))
            {
                switch (filter.Numero_de_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.Numero_de_Identificacion LIKE '" + filter.Numero_de_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.Numero_de_Identificacion = '" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "%'";
                        break;
                }
            }

            if (filter.Fotografia_de_la_identificacion != RadioOptions.NoApply)
                where += " AND Involucrados_PC.Fotografia_de_la_identificacion " + (filter.Fotografia_de_la_identificacion == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.CURP))
            {
                switch (filter.CURPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.CURP LIKE '" + filter.CURP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.CURP LIKE '%" + filter.CURP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.CURP = '" + filter.CURP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.CURP LIKE '%" + filter.CURP + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNacionalidad))
            {
                switch (filter.NacionalidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '" + filter.AdvanceNacionalidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Nacionalidad.NacionalidadC = '" + filter.AdvanceNacionalidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNacionalidadMultiple != null && filter.AdvanceNacionalidadMultiple.Count() > 0)
            {
                var NacionalidadIds = string.Join(",", filter.AdvanceNacionalidadMultiple);

                where += " AND Involucrados_PC.Nacionalidad In (" + NacionalidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Originario_de))
            {
                switch (filter.Originario_deFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.Originario_de LIKE '" + filter.Originario_de + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.Originario_de LIKE '%" + filter.Originario_de + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.Originario_de = '" + filter.Originario_de + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.Originario_de LIKE '%" + filter.Originario_de + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais))
            {
                switch (filter.PaisFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais + "%'";
                        break;
                }
            }
            else if (filter.AdvancePaisMultiple != null && filter.AdvancePaisMultiple.Count() > 0)
            {
                var PaisIds = string.Join(",", filter.AdvancePaisMultiple);

                where += " AND Involucrados_PC.Pais In (" + PaisIds + ")";
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

                where += " AND Involucrados_PC.Estado In (" + EstadoIds + ")";
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

                where += " AND Involucrados_PC.Municipio In (" + MunicipioIds + ")";
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

                where += " AND Involucrados_PC.Poblacion In (" + PoblacionIds + ")";
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

                where += " AND Involucrados_PC.Colonia In (" + ColoniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal) || !string.IsNullOrEmpty(filter.ToCodigo_Postal))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal))
                    where += " AND Involucrados_PC.Codigo_Postal >= " + filter.FromCodigo_Postal;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal))
                    where += " AND Involucrados_PC.Codigo_Postal <= " + filter.ToCodigo_Postal;
            }

            if (!string.IsNullOrEmpty(filter.Calle))
            {
                switch (filter.CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.Calle LIKE '" + filter.Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.Calle LIKE '%" + filter.Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.Calle = '" + filter.Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.Calle LIKE '%" + filter.Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle))
            {
                switch (filter.Entre_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.Entre_Calle LIKE '" + filter.Entre_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.Entre_Calle LIKE '%" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.Entre_Calle = '" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.Entre_Calle LIKE '%" + filter.Entre_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Y_Calle))
            {
                switch (filter.Y_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.Y_Calle LIKE '" + filter.Y_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.Y_Calle LIKE '%" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.Y_Calle = '" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.Y_Calle LIKE '%" + filter.Y_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior))
            {
                switch (filter.Numero_ExteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.Numero_Exterior LIKE '" + filter.Numero_Exterior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.Numero_Exterior = '" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior))
            {
                switch (filter.Numero_InteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.Numero_Interior LIKE '" + filter.Numero_Interior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.Numero_Interior LIKE '%" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.Numero_Interior = '" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.Numero_Interior LIKE '%" + filter.Numero_Interior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencia_de_Domicilio))
            {
                switch (filter.Referencia_de_DomicilioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.Referencia_de_Domicilio LIKE '" + filter.Referencia_de_Domicilio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.Referencia_de_Domicilio LIKE '%" + filter.Referencia_de_Domicilio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.Referencia_de_Domicilio = '" + filter.Referencia_de_Domicilio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.Referencia_de_Domicilio LIKE '%" + filter.Referencia_de_Domicilio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud))
            {
                switch (filter.LatitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.Latitud LIKE '" + filter.Latitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.Latitud LIKE '%" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.Latitud = '" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.Latitud LIKE '%" + filter.Latitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud))
            {
                switch (filter.LongitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Involucrados_PC.Longitud LIKE '" + filter.Longitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Involucrados_PC.Longitud LIKE '%" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Involucrados_PC.Longitud = '" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Involucrados_PC.Longitud LIKE '%" + filter.Longitud + "%'";
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
                _IInvolucrados_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

                Involucrados_PC varInvolucrados_PC = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IInvolucrados_PCApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Involucrados_PCModel varInvolucrados_PC)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IInvolucrados_PCApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varInvolucrados_PC.Fotografia_de_la_identificacionRemoveAttachment != 0 && varInvolucrados_PC.Fotografia_de_la_identificacionFile == null)
                    {
                        varInvolucrados_PC.Fotografia_de_la_identificacion = 0;
                    }

                    if (varInvolucrados_PC.Fotografia_de_la_identificacionFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varInvolucrados_PC.Fotografia_de_la_identificacionFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varInvolucrados_PC.Fotografia_de_la_identificacion = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varInvolucrados_PC.Fotografia_de_la_identificacionFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Involucrados_PCInfo = new Involucrados_PC
                    {
                        Clave = varInvolucrados_PC.Clave
                        ,Solicitud = varInvolucrados_PC.Solicitud
                        ,Tipo_de_Solicitud = varInvolucrados_PC.Tipo_de_Solicitud
                        ,Usuario_que_Registra = varInvolucrados_PC.Usuario_que_Registra
                        ,Tipo_de_Compareciente = varInvolucrados_PC.Tipo_de_Compareciente
                        ,Nombres = varInvolucrados_PC.Nombres
                        ,Apellido_Paterno = varInvolucrados_PC.Apellido_Paterno
                        ,Apellido_Materno = varInvolucrados_PC.Apellido_Materno
                        ,Nombre_Completo = varInvolucrados_PC.Nombre_Completo
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varInvolucrados_PC.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varInvolucrados_PC.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varInvolucrados_PC.Edad
                        ,Sexo = varInvolucrados_PC.Sexo
                        ,Estado_Civil = varInvolucrados_PC.Estado_Civil
                        ,Tipo_de_Identificacion = varInvolucrados_PC.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varInvolucrados_PC.Numero_de_Identificacion
                        ,Fotografia_de_la_identificacion = (varInvolucrados_PC.Fotografia_de_la_identificacion.HasValue && varInvolucrados_PC.Fotografia_de_la_identificacion != 0) ? ((int?)Convert.ToInt32(varInvolucrados_PC.Fotografia_de_la_identificacion.Value)) : null

                        ,CURP = varInvolucrados_PC.CURP
                        ,Nacionalidad = varInvolucrados_PC.Nacionalidad
                        ,Originario_de = varInvolucrados_PC.Originario_de
                        ,Pais = varInvolucrados_PC.Pais
                        ,Estado = varInvolucrados_PC.Estado
                        ,Municipio = varInvolucrados_PC.Municipio
                        ,Poblacion = varInvolucrados_PC.Poblacion
                        ,Colonia = varInvolucrados_PC.Colonia
                        ,Codigo_Postal = varInvolucrados_PC.Codigo_Postal
                        ,Calle = varInvolucrados_PC.Calle
                        ,Entre_Calle = varInvolucrados_PC.Entre_Calle
                        ,Y_Calle = varInvolucrados_PC.Y_Calle
                        ,Numero_Exterior = varInvolucrados_PC.Numero_Exterior
                        ,Numero_Interior = varInvolucrados_PC.Numero_Interior
                        ,Referencia_de_Domicilio = varInvolucrados_PC.Referencia_de_Domicilio
                        ,Latitud = varInvolucrados_PC.Latitud
                        ,Longitud = varInvolucrados_PC.Longitud

                    };

                    result = !IsNew ?
                        _IInvolucrados_PCApiConsumer.Update(Involucrados_PCInfo, null, null).Resource.ToString() :
                         _IInvolucrados_PCApiConsumer.Insert(Involucrados_PCInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Involucrados_PC script
        /// </summary>
        /// <param name="oInvolucrados_PCElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Involucrados_PCModuleAttributeList)
        {
            for (int i = 0; i < Involucrados_PCModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Involucrados_PCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Involucrados_PCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Involucrados_PCModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Involucrados_PCModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Involucrados_PCModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Involucrados_PCModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Involucrados_PCModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Involucrados_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Involucrados_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Involucrados_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Involucrados_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strInvolucrados_PCScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Involucrados_PC.js")))
            {
                strInvolucrados_PCScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Involucrados_PC element attributes
            string userChangeJson = jsSerialize.Serialize(Involucrados_PCModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strInvolucrados_PCScript.IndexOf("inpuElementArray");
            string splittedString = strInvolucrados_PCScript.Substring(indexOfArray, strInvolucrados_PCScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Involucrados_PCModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Involucrados_PCModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strInvolucrados_PCScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strInvolucrados_PCScript.Substring(indexOfArrayHistory, strInvolucrados_PCScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strInvolucrados_PCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strInvolucrados_PCScript.Substring(endIndexOfMainElement + indexOfArray, strInvolucrados_PCScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Involucrados_PCModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Involucrados_PCModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Involucrados_PC.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Involucrados_PC.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Involucrados_PC.js")))
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
        public ActionResult Involucrados_PCPropertyBag()
        {
            return PartialView("Involucrados_PCPropertyBag", "Involucrados_PC");
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
                var whereClauseFormat = "Object = 45713 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IInvolucrados_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Involucrados_PC.Clave= " + RecordId;
                            var result = _IInvolucrados_PCApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IInvolucrados_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Involucrados_PCPropertyMapper());
			
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
                    (Involucrados_PCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Involucrados_PCPropertyMapper oInvolucrados_PCPropertyMapper = new Involucrados_PCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oInvolucrados_PCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IInvolucrados_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Involucrados_PCs == null)
                result.Involucrados_PCs = new List<Involucrados_PC>();

            var data = result.Involucrados_PCs.Select(m => new Involucrados_PCGridModel
            {
                Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Fotografia_de_la_identificacion = m.Fotografia_de_la_identificacion
			,CURP = m.CURP
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
			,Originario_de = m.Originario_de
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45713, arrayColumnsVisible), "Involucrados_PCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45713, arrayColumnsVisible), "Involucrados_PCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45713, arrayColumnsVisible), "Involucrados_PCList_" + DateTime.Now.ToString());
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

            _IInvolucrados_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Involucrados_PCPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Involucrados_PCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Involucrados_PCPropertyMapper oInvolucrados_PCPropertyMapper = new Involucrados_PCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oInvolucrados_PCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IInvolucrados_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Involucrados_PCs == null)
                result.Involucrados_PCs = new List<Involucrados_PC>();

            var data = result.Involucrados_PCs.Select(m => new Involucrados_PCGridModel
            {
                Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Fotografia_de_la_identificacion = m.Fotografia_de_la_identificacion
			,CURP = m.CURP
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
			,Originario_de = m.Originario_de
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud

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
                _IInvolucrados_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IInvolucrados_PCApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Involucrados_PC_Datos_GeneralesModel varInvolucrados_PC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IInvolucrados_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varInvolucrados_PC.Fotografia_de_la_identificacionRemoveAttachment != 0 && varInvolucrados_PC.Fotografia_de_la_identificacionFile == null)
                    {
                        varInvolucrados_PC.Fotografia_de_la_identificacion = 0;
                    }

                    if (varInvolucrados_PC.Fotografia_de_la_identificacionFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varInvolucrados_PC.Fotografia_de_la_identificacionFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varInvolucrados_PC.Fotografia_de_la_identificacion = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varInvolucrados_PC.Fotografia_de_la_identificacionFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Involucrados_PC_Datos_GeneralesInfo = new Involucrados_PC_Datos_Generales
                {
                    Clave = varInvolucrados_PC.Clave
                                            ,Solicitud = varInvolucrados_PC.Solicitud
                        ,Tipo_de_Solicitud = varInvolucrados_PC.Tipo_de_Solicitud
                        ,Usuario_que_Registra = varInvolucrados_PC.Usuario_que_Registra
                        ,Tipo_de_Compareciente = varInvolucrados_PC.Tipo_de_Compareciente
                        ,Nombres = varInvolucrados_PC.Nombres
                        ,Apellido_Paterno = varInvolucrados_PC.Apellido_Paterno
                        ,Apellido_Materno = varInvolucrados_PC.Apellido_Materno
                        ,Nombre_Completo = varInvolucrados_PC.Nombre_Completo
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varInvolucrados_PC.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varInvolucrados_PC.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varInvolucrados_PC.Edad
                        ,Sexo = varInvolucrados_PC.Sexo
                        ,Estado_Civil = varInvolucrados_PC.Estado_Civil
                        ,Tipo_de_Identificacion = varInvolucrados_PC.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varInvolucrados_PC.Numero_de_Identificacion
                        ,Fotografia_de_la_identificacion = (varInvolucrados_PC.Fotografia_de_la_identificacion.HasValue && varInvolucrados_PC.Fotografia_de_la_identificacion != 0) ? ((int?)Convert.ToInt32(varInvolucrados_PC.Fotografia_de_la_identificacion.Value)) : null

                        ,CURP = varInvolucrados_PC.CURP
                        ,Nacionalidad = varInvolucrados_PC.Nacionalidad
                        ,Originario_de = varInvolucrados_PC.Originario_de
                    
                };

                result = _IInvolucrados_PCApiConsumer.Update_Datos_Generales(Involucrados_PC_Datos_GeneralesInfo).Resource.ToString();
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
                _IInvolucrados_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IInvolucrados_PCApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Involucrados_PC_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Solicitud = m.Solicitud
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_Solicitud = m.Tipo_de_Solicitud
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_Compareciente = m.Tipo_de_Compareciente
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
			,Fotografia_de_la_identificacion = m.Fotografia_de_la_identificacion
			,CURP = m.CURP
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "Nacionalidad") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
			,Originario_de = m.Originario_de

                    
                };
				var resultData = new
                {
                    data = result

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Domicilio(Involucrados_PC_DomicilioModel varInvolucrados_PC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IInvolucrados_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Involucrados_PC_DomicilioInfo = new Involucrados_PC_Domicilio
                {
                    Clave = varInvolucrados_PC.Clave
                                            ,Pais = varInvolucrados_PC.Pais
                        ,Estado = varInvolucrados_PC.Estado
                        ,Municipio = varInvolucrados_PC.Municipio
                        ,Poblacion = varInvolucrados_PC.Poblacion
                        ,Colonia = varInvolucrados_PC.Colonia
                        ,Codigo_Postal = varInvolucrados_PC.Codigo_Postal
                        ,Calle = varInvolucrados_PC.Calle
                        ,Entre_Calle = varInvolucrados_PC.Entre_Calle
                        ,Y_Calle = varInvolucrados_PC.Y_Calle
                        ,Numero_Exterior = varInvolucrados_PC.Numero_Exterior
                        ,Numero_Interior = varInvolucrados_PC.Numero_Interior
                        ,Referencia_de_Domicilio = varInvolucrados_PC.Referencia_de_Domicilio
                        ,Latitud = varInvolucrados_PC.Latitud
                        ,Longitud = varInvolucrados_PC.Longitud
                    
                };

                result = _IInvolucrados_PCApiConsumer.Update_Domicilio(Involucrados_PC_DomicilioInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Domicilio(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IInvolucrados_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IInvolucrados_PCApiConsumer.Get_Domicilio(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Involucrados_PC_DomicilioModel
                {
                    Clave = m.Clave
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Latitud = m.Latitud
			,Longitud = m.Longitud

                    
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

