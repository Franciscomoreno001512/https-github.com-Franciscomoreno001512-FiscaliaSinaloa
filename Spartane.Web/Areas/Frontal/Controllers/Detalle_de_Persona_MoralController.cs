using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Persona_Moral;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Localidad;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Nacionalidad;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Persona_Moral;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Persona_Moral;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Localidad;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;

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
    public class Detalle_de_Persona_MoralController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Persona_MoralService service = null;
        private IDetalle_de_Persona_MoralApiConsumer _IDetalle_de_Persona_MoralApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private ILocalidadApiConsumer _ILocalidadApiConsumer;
        private IGeneroApiConsumer _IGeneroApiConsumer;
        private INacionalidadApiConsumer _INacionalidadApiConsumer;

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

        
        public Detalle_de_Persona_MoralController(IDetalle_de_Persona_MoralService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Persona_MoralApiConsumer Detalle_de_Persona_MoralApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , ILocalidadApiConsumer LocalidadApiConsumer , IGeneroApiConsumer GeneroApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Persona_MoralApiConsumer = Detalle_de_Persona_MoralApiConsumer;
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
            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ILocalidadApiConsumer = LocalidadApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Persona_Moral
        [ObjectAuth(ObjectId = (ModuleObjectId)45108, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45108, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_de_Persona_Moral/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45108, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45108, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_de_Persona_Moral = new Detalle_de_Persona_MoralModel();
			varDetalle_de_Persona_Moral.Clave = Id;
			
            ViewBag.ObjectId = "45108";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Persona_MoralsData = _IDetalle_de_Persona_MoralApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Persona_Moral.Clave=" + Id, "").Resource.Detalle_de_Persona_Morals;
				
				if (Detalle_de_Persona_MoralsData != null && Detalle_de_Persona_MoralsData.Count > 0)
                {
					var Detalle_de_Persona_MoralData = Detalle_de_Persona_MoralsData.First();
					varDetalle_de_Persona_Moral= new Detalle_de_Persona_MoralModel
					{
						Clave  = Detalle_de_Persona_MoralData.Clave 
	                    ,Modulo_Atencion_Inicial = Detalle_de_Persona_MoralData.Modulo_Atencion_Inicial
                    ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Modulo_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Detalle_de_Persona_MoralData.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Expediente_MP = Detalle_de_Persona_MoralData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Detalle_de_Persona_MoralData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Nombre = Detalle_de_Persona_MoralData.Nombre
                    ,Apellido_Paterno = Detalle_de_Persona_MoralData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Persona_MoralData.Apellido_Materno
                    ,Nombre_Completo = Detalle_de_Persona_MoralData.Nombre_Completo
                    ,Calidad_Juridica = Detalle_de_Persona_MoralData.Calidad_Juridica
                    ,Razon_Social = Detalle_de_Persona_MoralData.Razon_Social
                    ,Pais = Detalle_de_Persona_MoralData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Pais), "Pais") ??  (string)Detalle_de_Persona_MoralData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_Persona_MoralData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Estado), "Estado") ??  (string)Detalle_de_Persona_MoralData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Persona_MoralData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Municipio), "Municipio") ??  (string)Detalle_de_Persona_MoralData.Municipio_Municipio.Nombre
                    ,Poblacion = Detalle_de_Persona_MoralData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Poblacion), "Colonia") ??  (string)Detalle_de_Persona_MoralData.Poblacion_Colonia.Nombre
                    ,Localidad = Detalle_de_Persona_MoralData.Localidad
                    ,LocalidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Localidad), "Localidad") ??  (string)Detalle_de_Persona_MoralData.Localidad_Localidad.Descripcion
                    ,Colonia = Detalle_de_Persona_MoralData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Colonia), "Colonia") ??  (string)Detalle_de_Persona_MoralData.Colonia_Colonia.Nombre
                    ,Calle = Detalle_de_Persona_MoralData.Calle
                    ,Numero_Exterior = Detalle_de_Persona_MoralData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Persona_MoralData.Numero_Interior
                    ,Referencia = Detalle_de_Persona_MoralData.Referencia
                    ,Latitud = Detalle_de_Persona_MoralData.Latitud
                    ,Longitud = Detalle_de_Persona_MoralData.Longitud
                    ,Telefono = Detalle_de_Persona_MoralData.Telefono
                    ,Extension = Detalle_de_Persona_MoralData.Extension
                    ,Celular = Detalle_de_Persona_MoralData.Celular
                    ,Correo_Electronico = Detalle_de_Persona_MoralData.Correo_Electronico
                    ,Codigo_Postal = Detalle_de_Persona_MoralData.Codigo_Postal
                    ,RFC = Detalle_de_Persona_MoralData.RFC
                    ,CURP = Detalle_de_Persona_MoralData.CURP
                    ,ID_Estado_Institucion = Detalle_de_Persona_MoralData.ID_Estado_Institucion
                    ,Nombres = Detalle_de_Persona_MoralData.Nombres
                    ,Apellido_Paterno2 = Detalle_de_Persona_MoralData.Apellido_Paterno2
                    ,Apellido_Materno2 = Detalle_de_Persona_MoralData.Apellido_Materno2
                    ,Nombre_Completo2 = Detalle_de_Persona_MoralData.Nombre_Completo2
                    ,Sexo = Detalle_de_Persona_MoralData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Sexo), "Genero") ??  (string)Detalle_de_Persona_MoralData.Sexo_Genero.Descripcion
                    ,Nacionalidad = Detalle_de_Persona_MoralData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Persona_MoralData.Nacionalidad_Nacionalidad.NacionalidadC

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad != null && Localidads_Localidad.Resource != null)
                ViewBag.Localidads_Localidad = Localidads_Localidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad != null && Nacionalidads_Nacionalidad.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad = Nacionalidads_Nacionalidad.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDetalle_de_Persona_Moral);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Persona_Moral(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45108);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Persona_MoralModel varDetalle_de_Persona_Moral= new Detalle_de_Persona_MoralModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_Persona_MoralsData = _IDetalle_de_Persona_MoralApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Persona_Moral.Clave=" + id, "").Resource.Detalle_de_Persona_Morals;
				
				if (Detalle_de_Persona_MoralsData != null && Detalle_de_Persona_MoralsData.Count > 0)
                {
					var Detalle_de_Persona_MoralData = Detalle_de_Persona_MoralsData.First();
					varDetalle_de_Persona_Moral= new Detalle_de_Persona_MoralModel
					{
						Clave  = Detalle_de_Persona_MoralData.Clave 
	                    ,Modulo_Atencion_Inicial = Detalle_de_Persona_MoralData.Modulo_Atencion_Inicial
                    ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Modulo_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Detalle_de_Persona_MoralData.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Expediente_MP = Detalle_de_Persona_MoralData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Detalle_de_Persona_MoralData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Nombre = Detalle_de_Persona_MoralData.Nombre
                    ,Apellido_Paterno = Detalle_de_Persona_MoralData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Persona_MoralData.Apellido_Materno
                    ,Nombre_Completo = Detalle_de_Persona_MoralData.Nombre_Completo
                    ,Calidad_Juridica = Detalle_de_Persona_MoralData.Calidad_Juridica
                    ,Razon_Social = Detalle_de_Persona_MoralData.Razon_Social
                    ,Pais = Detalle_de_Persona_MoralData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Pais), "Pais") ??  (string)Detalle_de_Persona_MoralData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_Persona_MoralData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Estado), "Estado") ??  (string)Detalle_de_Persona_MoralData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Persona_MoralData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Municipio), "Municipio") ??  (string)Detalle_de_Persona_MoralData.Municipio_Municipio.Nombre
                    ,Poblacion = Detalle_de_Persona_MoralData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Poblacion), "Colonia") ??  (string)Detalle_de_Persona_MoralData.Poblacion_Colonia.Nombre
                    ,Localidad = Detalle_de_Persona_MoralData.Localidad
                    ,LocalidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Localidad), "Localidad") ??  (string)Detalle_de_Persona_MoralData.Localidad_Localidad.Descripcion
                    ,Colonia = Detalle_de_Persona_MoralData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Colonia), "Colonia") ??  (string)Detalle_de_Persona_MoralData.Colonia_Colonia.Nombre
                    ,Calle = Detalle_de_Persona_MoralData.Calle
                    ,Numero_Exterior = Detalle_de_Persona_MoralData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Persona_MoralData.Numero_Interior
                    ,Referencia = Detalle_de_Persona_MoralData.Referencia
                    ,Latitud = Detalle_de_Persona_MoralData.Latitud
                    ,Longitud = Detalle_de_Persona_MoralData.Longitud
                    ,Telefono = Detalle_de_Persona_MoralData.Telefono
                    ,Extension = Detalle_de_Persona_MoralData.Extension
                    ,Celular = Detalle_de_Persona_MoralData.Celular
                    ,Correo_Electronico = Detalle_de_Persona_MoralData.Correo_Electronico
                    ,Codigo_Postal = Detalle_de_Persona_MoralData.Codigo_Postal
                    ,RFC = Detalle_de_Persona_MoralData.RFC
                    ,CURP = Detalle_de_Persona_MoralData.CURP
                    ,ID_Estado_Institucion = Detalle_de_Persona_MoralData.ID_Estado_Institucion
                    ,Nombres = Detalle_de_Persona_MoralData.Nombres
                    ,Apellido_Paterno2 = Detalle_de_Persona_MoralData.Apellido_Paterno2
                    ,Apellido_Materno2 = Detalle_de_Persona_MoralData.Apellido_Materno2
                    ,Nombre_Completo2 = Detalle_de_Persona_MoralData.Nombre_Completo2
                    ,Sexo = Detalle_de_Persona_MoralData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Sexo), "Genero") ??  (string)Detalle_de_Persona_MoralData.Sexo_Genero.Descripcion
                    ,Nacionalidad = Detalle_de_Persona_MoralData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Persona_MoralData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Persona_MoralData.Nacionalidad_Nacionalidad.NacionalidadC

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad != null && Localidads_Localidad.Resource != null)
                ViewBag.Localidads_Localidad = Localidads_Localidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad != null && Nacionalidads_Nacionalidad.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad = Nacionalidads_Nacionalidad.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Persona_Moral", varDetalle_de_Persona_Moral);
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
        [HttpGet]
        public ActionResult GetLocalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILocalidadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion")?? m.Descripcion,
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



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Detalle_de_Persona_MoralAdvanceSearchModel model, int idFilter = -1)
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

            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad != null && Localidads_Localidad.Resource != null)
                ViewBag.Localidads_Localidad = Localidads_Localidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad != null && Nacionalidads_Nacionalidad.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad = Nacionalidads_Nacionalidad.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad != null && Localidads_Localidad.Resource != null)
                ViewBag.Localidads_Localidad = Localidads_Localidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo != null && Generos_Sexo.Resource != null)
                ViewBag.Generos_Sexo = Generos_Sexo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad != null && Nacionalidads_Nacionalidad.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad = Nacionalidads_Nacionalidad.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Detalle_de_Persona_MoralAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_de_Persona_MoralAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_de_Persona_MoralAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Persona_MoralPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Persona_MoralApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Persona_Morals == null)
                result.Detalle_de_Persona_Morals = new List<Detalle_de_Persona_Moral>();

            return Json(new
            {
                data = result.Detalle_de_Persona_Morals.Select(m => new Detalle_de_Persona_MoralGridModel
                    {
                    Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Calidad_Juridica = m.Calidad_Juridica
			,Razon_Social = m.Razon_Social
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_Localidad.Descripcion
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extension = m.Extension
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Codigo_Postal = m.Codigo_Postal
			,RFC = m.RFC
			,CURP = m.CURP
			,ID_Estado_Institucion = m.ID_Estado_Institucion
			,Nombres = m.Nombres
			,Apellido_Paterno2 = m.Apellido_Paterno2
			,Apellido_Materno2 = m.Apellido_Materno2
			,Nombre_Completo2 = m.Nombre_Completo2
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_de_Persona_MoralAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Persona_MoralApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_de_Persona_Moral", m.),
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
        /// Get List of Detalle_de_Persona_Moral from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_de_Persona_Moral Entity</returns>
        public ActionResult GetDetalle_de_Persona_MoralList(UrlParametersModel param)
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
            _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_de_Persona_MoralPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_de_Persona_MoralAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_de_Persona_MoralAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_de_Persona_MoralPropertyMapper oDetalle_de_Persona_MoralPropertyMapper = new Detalle_de_Persona_MoralPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_de_Persona_MoralPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_de_Persona_MoralApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Persona_Morals == null)
                result.Detalle_de_Persona_Morals = new List<Detalle_de_Persona_Moral>();

            return Json(new
            {
                aaData = result.Detalle_de_Persona_Morals.Select(m => new Detalle_de_Persona_MoralGridModel
            {
                    Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Calidad_Juridica = m.Calidad_Juridica
			,Razon_Social = m.Razon_Social
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_Localidad.Descripcion
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extension = m.Extension
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Codigo_Postal = m.Codigo_Postal
			,RFC = m.RFC
			,CURP = m.CURP
			,ID_Estado_Institucion = m.ID_Estado_Institucion
			,Nombres = m.Nombres
			,Apellido_Paterno2 = m.Apellido_Paterno2
			,Apellido_Materno2 = m.Apellido_Materno2
			,Nombre_Completo2 = m.Nombre_Completo2
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Persona_Moral_Modulo_Atencion_Inicial_Modulo_Atencion_Inicial(string query, string where)
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
        public JsonResult GetDetalle_de_Persona_Moral_Expediente_MP_expediente_ministerio_publico(string query, string where)
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
        public JsonResult GetDetalle_de_Persona_Moral_Pais_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Persona_Moral_Estado_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Persona_Moral_Municipio_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Persona_Moral_Poblacion_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Persona_Moral_Colonia_Colonia(string query, string where)
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
        public string GetAdvanceFilter(Detalle_de_Persona_MoralAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_de_Persona_Moral.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_de_Persona_Moral.Clave <= " + filter.ToClave;
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

                where += " AND Detalle_de_Persona_Moral.Modulo_Atencion_Inicial In (" + Modulo_Atencion_InicialIds + ")";
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

                where += " AND Detalle_de_Persona_Moral.Expediente_MP In (" + Expediente_MPIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombre))
            {
                switch (filter.NombreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Nombre LIKE '" + filter.Nombre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Nombre LIKE '%" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Nombre = '" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Nombre LIKE '%" + filter.Nombre + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno))
            {
                switch (filter.Apellido_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Paterno LIKE '" + filter.Apellido_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Paterno = '" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno))
            {
                switch (filter.Apellido_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Materno LIKE '" + filter.Apellido_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Materno = '" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo))
            {
                switch (filter.Nombre_CompletoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Nombre_Completo LIKE '" + filter.Nombre_Completo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Nombre_Completo = '" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Calidad_Juridica))
            {
                switch (filter.Calidad_JuridicaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Calidad_Juridica LIKE '" + filter.Calidad_Juridica + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Calidad_Juridica LIKE '%" + filter.Calidad_Juridica + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Calidad_Juridica = '" + filter.Calidad_Juridica + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Calidad_Juridica LIKE '%" + filter.Calidad_Juridica + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Razon_Social))
            {
                switch (filter.Razon_SocialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Razon_Social LIKE '" + filter.Razon_Social + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Razon_Social LIKE '%" + filter.Razon_Social + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Razon_Social = '" + filter.Razon_Social + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Razon_Social LIKE '%" + filter.Razon_Social + "%'";
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

                where += " AND Detalle_de_Persona_Moral.Pais In (" + PaisIds + ")";
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

                where += " AND Detalle_de_Persona_Moral.Estado In (" + EstadoIds + ")";
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

                where += " AND Detalle_de_Persona_Moral.Municipio In (" + MunicipioIds + ")";
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

                where += " AND Detalle_de_Persona_Moral.Poblacion In (" + PoblacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceLocalidad))
            {
                switch (filter.LocalidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Localidad.Descripcion LIKE '" + filter.AdvanceLocalidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Localidad.Descripcion LIKE '%" + filter.AdvanceLocalidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Localidad.Descripcion = '" + filter.AdvanceLocalidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Localidad.Descripcion LIKE '%" + filter.AdvanceLocalidad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceLocalidadMultiple != null && filter.AdvanceLocalidadMultiple.Count() > 0)
            {
                var LocalidadIds = string.Join(",", filter.AdvanceLocalidadMultiple);

                where += " AND Detalle_de_Persona_Moral.Localidad In (" + LocalidadIds + ")";
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

                where += " AND Detalle_de_Persona_Moral.Colonia In (" + ColoniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Calle))
            {
                switch (filter.CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Calle LIKE '" + filter.Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Calle LIKE '%" + filter.Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Calle = '" + filter.Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Calle LIKE '%" + filter.Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior))
            {
                switch (filter.Numero_ExteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Numero_Exterior LIKE '" + filter.Numero_Exterior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Numero_Exterior = '" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior))
            {
                switch (filter.Numero_InteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Numero_Interior LIKE '" + filter.Numero_Interior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Numero_Interior LIKE '%" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Numero_Interior = '" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Numero_Interior LIKE '%" + filter.Numero_Interior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencia))
            {
                switch (filter.ReferenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Referencia LIKE '" + filter.Referencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Referencia LIKE '%" + filter.Referencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Referencia = '" + filter.Referencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Referencia LIKE '%" + filter.Referencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud))
            {
                switch (filter.LatitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Latitud LIKE '" + filter.Latitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Latitud LIKE '%" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Latitud = '" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Latitud LIKE '%" + filter.Latitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud))
            {
                switch (filter.LongitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Longitud LIKE '" + filter.Longitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Longitud LIKE '%" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Longitud = '" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Longitud LIKE '%" + filter.Longitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Telefono))
            {
                switch (filter.TelefonoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Telefono LIKE '" + filter.Telefono + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Telefono LIKE '%" + filter.Telefono + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Telefono = '" + filter.Telefono + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Telefono LIKE '%" + filter.Telefono + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromExtension) || !string.IsNullOrEmpty(filter.ToExtension))
            {
                if (!string.IsNullOrEmpty(filter.FromExtension))
                    where += " AND Detalle_de_Persona_Moral.Extension >= " + filter.FromExtension;
                if (!string.IsNullOrEmpty(filter.ToExtension))
                    where += " AND Detalle_de_Persona_Moral.Extension <= " + filter.ToExtension;
            }

            if (!string.IsNullOrEmpty(filter.Celular))
            {
                switch (filter.CelularFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Celular LIKE '" + filter.Celular + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Celular LIKE '%" + filter.Celular + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Celular = '" + filter.Celular + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Celular LIKE '%" + filter.Celular + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Electronico))
            {
                switch (filter.Correo_ElectronicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Correo_Electronico LIKE '" + filter.Correo_Electronico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Correo_Electronico = '" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal) || !string.IsNullOrEmpty(filter.ToCodigo_Postal))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal))
                    where += " AND Detalle_de_Persona_Moral.Codigo_Postal >= " + filter.FromCodigo_Postal;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal))
                    where += " AND Detalle_de_Persona_Moral.Codigo_Postal <= " + filter.ToCodigo_Postal;
            }

            if (!string.IsNullOrEmpty(filter.RFC))
            {
                switch (filter.RFCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.RFC LIKE '" + filter.RFC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.RFC LIKE '%" + filter.RFC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.RFC = '" + filter.RFC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.RFC LIKE '%" + filter.RFC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.CURP))
            {
                switch (filter.CURPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.CURP LIKE '" + filter.CURP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.CURP LIKE '%" + filter.CURP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.CURP = '" + filter.CURP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.CURP LIKE '%" + filter.CURP + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.ID_Estado_Institucion))
            {
                switch (filter.ID_Estado_InstitucionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.ID_Estado_Institucion LIKE '" + filter.ID_Estado_Institucion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.ID_Estado_Institucion LIKE '%" + filter.ID_Estado_Institucion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.ID_Estado_Institucion = '" + filter.ID_Estado_Institucion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.ID_Estado_Institucion LIKE '%" + filter.ID_Estado_Institucion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombres))
            {
                switch (filter.NombresFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Nombres LIKE '" + filter.Nombres + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Nombres LIKE '%" + filter.Nombres + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Nombres = '" + filter.Nombres + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Nombres LIKE '%" + filter.Nombres + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno2))
            {
                switch (filter.Apellido_Paterno2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Paterno2 LIKE '" + filter.Apellido_Paterno2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Paterno2 LIKE '%" + filter.Apellido_Paterno2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Paterno2 = '" + filter.Apellido_Paterno2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Paterno2 LIKE '%" + filter.Apellido_Paterno2 + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno2))
            {
                switch (filter.Apellido_Materno2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Materno2 LIKE '" + filter.Apellido_Materno2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Materno2 LIKE '%" + filter.Apellido_Materno2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Materno2 = '" + filter.Apellido_Materno2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Apellido_Materno2 LIKE '%" + filter.Apellido_Materno2 + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo2))
            {
                switch (filter.Nombre_Completo2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral.Nombre_Completo2 LIKE '" + filter.Nombre_Completo2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral.Nombre_Completo2 LIKE '%" + filter.Nombre_Completo2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral.Nombre_Completo2 = '" + filter.Nombre_Completo2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral.Nombre_Completo2 LIKE '%" + filter.Nombre_Completo2 + "%'";
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

                where += " AND Detalle_de_Persona_Moral.Sexo In (" + SexoIds + ")";
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

                where += " AND Detalle_de_Persona_Moral.Nacionalidad In (" + NacionalidadIds + ")";
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
                _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Persona_Moral varDetalle_de_Persona_Moral = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_Persona_MoralApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Persona_MoralModel varDetalle_de_Persona_Moral)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_Persona_MoralInfo = new Detalle_de_Persona_Moral
                    {
                        Clave = varDetalle_de_Persona_Moral.Clave
                        ,Modulo_Atencion_Inicial = varDetalle_de_Persona_Moral.Modulo_Atencion_Inicial
                        ,Expediente_MP = varDetalle_de_Persona_Moral.Expediente_MP
                        ,Nombre = varDetalle_de_Persona_Moral.Nombre
                        ,Apellido_Paterno = varDetalle_de_Persona_Moral.Apellido_Paterno
                        ,Apellido_Materno = varDetalle_de_Persona_Moral.Apellido_Materno
                        ,Nombre_Completo = varDetalle_de_Persona_Moral.Nombre_Completo
                        ,Calidad_Juridica = varDetalle_de_Persona_Moral.Calidad_Juridica
                        ,Razon_Social = varDetalle_de_Persona_Moral.Razon_Social
                        ,Pais = varDetalle_de_Persona_Moral.Pais
                        ,Estado = varDetalle_de_Persona_Moral.Estado
                        ,Municipio = varDetalle_de_Persona_Moral.Municipio
                        ,Poblacion = varDetalle_de_Persona_Moral.Poblacion
                        ,Localidad = varDetalle_de_Persona_Moral.Localidad
                        ,Colonia = varDetalle_de_Persona_Moral.Colonia
                        ,Calle = varDetalle_de_Persona_Moral.Calle
                        ,Numero_Exterior = varDetalle_de_Persona_Moral.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Persona_Moral.Numero_Interior
                        ,Referencia = varDetalle_de_Persona_Moral.Referencia
                        ,Latitud = varDetalle_de_Persona_Moral.Latitud
                        ,Longitud = varDetalle_de_Persona_Moral.Longitud
                        ,Telefono = varDetalle_de_Persona_Moral.Telefono
                        ,Extension = varDetalle_de_Persona_Moral.Extension
                        ,Celular = varDetalle_de_Persona_Moral.Celular
                        ,Correo_Electronico = varDetalle_de_Persona_Moral.Correo_Electronico
                        ,Codigo_Postal = varDetalle_de_Persona_Moral.Codigo_Postal
                        ,RFC = varDetalle_de_Persona_Moral.RFC
                        ,CURP = varDetalle_de_Persona_Moral.CURP
                        ,ID_Estado_Institucion = varDetalle_de_Persona_Moral.ID_Estado_Institucion
                        ,Nombres = varDetalle_de_Persona_Moral.Nombres
                        ,Apellido_Paterno2 = varDetalle_de_Persona_Moral.Apellido_Paterno2
                        ,Apellido_Materno2 = varDetalle_de_Persona_Moral.Apellido_Materno2
                        ,Nombre_Completo2 = varDetalle_de_Persona_Moral.Nombre_Completo2
                        ,Sexo = varDetalle_de_Persona_Moral.Sexo
                        ,Nacionalidad = varDetalle_de_Persona_Moral.Nacionalidad

                    };

                    result = !IsNew ?
                        _IDetalle_de_Persona_MoralApiConsumer.Update(Detalle_de_Persona_MoralInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Persona_MoralApiConsumer.Insert(Detalle_de_Persona_MoralInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Detalle_de_Persona_Moral script
        /// </summary>
        /// <param name="oDetalle_de_Persona_MoralElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_de_Persona_MoralModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Persona_MoralModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Persona_MoralModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Persona_MoralModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Persona_MoralModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Persona_MoralModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Persona_MoralModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Persona_MoralModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_de_Persona_MoralModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_de_Persona_MoralModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_de_Persona_MoralModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_de_Persona_MoralModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_de_Persona_MoralModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_de_Persona_MoralScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Persona_Moral.js")))
            {
                strDetalle_de_Persona_MoralScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Persona_Moral element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Persona_MoralModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Persona_MoralScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Persona_MoralScript.Substring(indexOfArray, strDetalle_de_Persona_MoralScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Persona_MoralModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Persona_MoralModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Persona_MoralScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_de_Persona_MoralScript.Substring(indexOfArrayHistory, strDetalle_de_Persona_MoralScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_de_Persona_MoralScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Persona_MoralScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Persona_MoralScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_de_Persona_MoralModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_de_Persona_MoralModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Persona_Moral.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Persona_Moral.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Persona_Moral.js")))
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
        public ActionResult Detalle_de_Persona_MoralPropertyBag()
        {
            return PartialView("Detalle_de_Persona_MoralPropertyBag", "Detalle_de_Persona_Moral");
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
                var whereClauseFormat = "Object = 45108 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_de_Persona_Moral.Clave= " + RecordId;
                            var result = _IDetalle_de_Persona_MoralApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Persona_MoralPropertyMapper());
			
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
                    (Detalle_de_Persona_MoralAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_de_Persona_MoralPropertyMapper oDetalle_de_Persona_MoralPropertyMapper = new Detalle_de_Persona_MoralPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Persona_MoralPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Persona_MoralApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Persona_Morals == null)
                result.Detalle_de_Persona_Morals = new List<Detalle_de_Persona_Moral>();

            var data = result.Detalle_de_Persona_Morals.Select(m => new Detalle_de_Persona_MoralGridModel
            {
                Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Calidad_Juridica = m.Calidad_Juridica
			,Razon_Social = m.Razon_Social
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_Localidad.Descripcion
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extension = m.Extension
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Codigo_Postal = m.Codigo_Postal
			,RFC = m.RFC
			,CURP = m.CURP
			,ID_Estado_Institucion = m.ID_Estado_Institucion
			,Nombres = m.Nombres
			,Apellido_Paterno2 = m.Apellido_Paterno2
			,Apellido_Materno2 = m.Apellido_Materno2
			,Nombre_Completo2 = m.Nombre_Completo2
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45108, arrayColumnsVisible), "Detalle_de_Persona_MoralList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45108, arrayColumnsVisible), "Detalle_de_Persona_MoralList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45108, arrayColumnsVisible), "Detalle_de_Persona_MoralList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Persona_MoralPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_de_Persona_MoralAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_de_Persona_MoralPropertyMapper oDetalle_de_Persona_MoralPropertyMapper = new Detalle_de_Persona_MoralPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Persona_MoralPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Persona_MoralApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Persona_Morals == null)
                result.Detalle_de_Persona_Morals = new List<Detalle_de_Persona_Moral>();

            var data = result.Detalle_de_Persona_Morals.Select(m => new Detalle_de_Persona_MoralGridModel
            {
                Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Calidad_Juridica = m.Calidad_Juridica
			,Razon_Social = m.Razon_Social
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_Localidad.Descripcion
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extension = m.Extension
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Codigo_Postal = m.Codigo_Postal
			,RFC = m.RFC
			,CURP = m.CURP
			,ID_Estado_Institucion = m.ID_Estado_Institucion
			,Nombres = m.Nombres
			,Apellido_Paterno2 = m.Apellido_Paterno2
			,Apellido_Materno2 = m.Apellido_Materno2
			,Nombre_Completo2 = m.Nombre_Completo2
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC

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
                _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Persona_MoralApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_de_Persona_Moral_Datos_GeneralesModel varDetalle_de_Persona_Moral)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Persona_Moral_Datos_GeneralesInfo = new Detalle_de_Persona_Moral_Datos_Generales
                {
                    Clave = varDetalle_de_Persona_Moral.Clave
                                            ,Modulo_Atencion_Inicial = varDetalle_de_Persona_Moral.Modulo_Atencion_Inicial
                        ,Expediente_MP = varDetalle_de_Persona_Moral.Expediente_MP
                        ,Nombre = varDetalle_de_Persona_Moral.Nombre
                        ,Apellido_Paterno = varDetalle_de_Persona_Moral.Apellido_Paterno
                        ,Apellido_Materno = varDetalle_de_Persona_Moral.Apellido_Materno
                        ,Nombre_Completo = varDetalle_de_Persona_Moral.Nombre_Completo
                        ,Calidad_Juridica = varDetalle_de_Persona_Moral.Calidad_Juridica
                        ,Razon_Social = varDetalle_de_Persona_Moral.Razon_Social
                        ,Pais = varDetalle_de_Persona_Moral.Pais
                        ,Estado = varDetalle_de_Persona_Moral.Estado
                        ,Municipio = varDetalle_de_Persona_Moral.Municipio
                        ,Poblacion = varDetalle_de_Persona_Moral.Poblacion
                        ,Localidad = varDetalle_de_Persona_Moral.Localidad
                        ,Colonia = varDetalle_de_Persona_Moral.Colonia
                        ,Calle = varDetalle_de_Persona_Moral.Calle
                        ,Numero_Exterior = varDetalle_de_Persona_Moral.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Persona_Moral.Numero_Interior
                        ,Referencia = varDetalle_de_Persona_Moral.Referencia
                        ,Latitud = varDetalle_de_Persona_Moral.Latitud
                        ,Longitud = varDetalle_de_Persona_Moral.Longitud
                        ,Telefono = varDetalle_de_Persona_Moral.Telefono
                        ,Extension = varDetalle_de_Persona_Moral.Extension
                        ,Celular = varDetalle_de_Persona_Moral.Celular
                        ,Correo_Electronico = varDetalle_de_Persona_Moral.Correo_Electronico
                        ,Codigo_Postal = varDetalle_de_Persona_Moral.Codigo_Postal
                        ,RFC = varDetalle_de_Persona_Moral.RFC
                        ,CURP = varDetalle_de_Persona_Moral.CURP
                        ,ID_Estado_Institucion = varDetalle_de_Persona_Moral.ID_Estado_Institucion
                    
                };

                result = _IDetalle_de_Persona_MoralApiConsumer.Update_Datos_Generales(Detalle_de_Persona_Moral_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Persona_MoralApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Detalle_de_Persona_Moral_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Modulo_Atencion_Inicial = m.Modulo_Atencion_Inicial
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MP = m.Expediente_MP
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Calidad_Juridica = m.Calidad_Juridica
			,Razon_Social = m.Razon_Social
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Localidad = m.Localidad
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_Localidad.Descripcion
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Telefono = m.Telefono
			,Extension = m.Extension
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Codigo_Postal = m.Codigo_Postal
			,RFC = m.RFC
			,CURP = m.CURP
			,ID_Estado_Institucion = m.ID_Estado_Institucion

                    
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
        public ActionResult Post_Representante_Legal(Detalle_de_Persona_Moral_Representante_LegalModel varDetalle_de_Persona_Moral)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Persona_Moral_Representante_LegalInfo = new Detalle_de_Persona_Moral_Representante_Legal
                {
                    Clave = varDetalle_de_Persona_Moral.Clave
                                            ,Nombres = varDetalle_de_Persona_Moral.Nombres
                        ,Apellido_Paterno2 = varDetalle_de_Persona_Moral.Apellido_Paterno2
                        ,Apellido_Materno2 = varDetalle_de_Persona_Moral.Apellido_Materno2
                        ,Nombre_Completo2 = varDetalle_de_Persona_Moral.Nombre_Completo2
                        ,Sexo = varDetalle_de_Persona_Moral.Sexo
                        ,Nacionalidad = varDetalle_de_Persona_Moral.Nacionalidad
                    
                };

                result = _IDetalle_de_Persona_MoralApiConsumer.Update_Representante_Legal(Detalle_de_Persona_Moral_Representante_LegalInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Representante_Legal(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Persona_MoralApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Persona_MoralApiConsumer.Get_Representante_Legal(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Detalle_de_Persona_Moral_Representante_LegalModel
                {
                    Clave = m.Clave
			,Nombres = m.Nombres
			,Apellido_Paterno2 = m.Apellido_Paterno2
			,Apellido_Materno2 = m.Apellido_Materno2
			,Nombre_Completo2 = m.Nombre_Completo2
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC

                    
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

