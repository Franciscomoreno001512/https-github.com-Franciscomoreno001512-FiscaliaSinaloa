using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Modulo_de_Atencion_Inicial;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Zona;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Localidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Localidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Estatus;
using Spartane.Core.Domain.Asignacion_de_Turnos;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Tipo_de_Denuncia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Modulo_de_Atencion_Inicial;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Modulo_de_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Zona;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Localidad;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Localidad;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Estatus;
using Spartane.Web.Areas.WebApiConsumer.Asignacion_de_Turnos;
using Spartane.Web.Areas.WebApiConsumer.Unidad;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Denuncia;
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
    public class Modulo_de_Atencion_InicialController : Controller
    {
        #region "variable declaration"

        private IModulo_de_Atencion_InicialService service = null;
        private IModulo_de_Atencion_InicialApiConsumer _IModulo_de_Atencion_InicialApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IGeneroApiConsumer _IGeneroApiConsumer;
        private IEstado_CivilApiConsumer _IEstado_CivilApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private INacionalidadApiConsumer _INacionalidadApiConsumer;
        private IEscolaridadApiConsumer _IEscolaridadApiConsumer;
        private IOcupacionApiConsumer _IOcupacionApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IZonaApiConsumer _IZonaApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private ILocalidadApiConsumer _ILocalidadApiConsumer;
        private ITipo_de_ComparecienteApiConsumer _ITipo_de_ComparecienteApiConsumer;
        private IEstatusApiConsumer _IEstatusApiConsumer;
        private IAsignacion_de_TurnosApiConsumer _IAsignacion_de_TurnosApiConsumer;
        private IUnidadApiConsumer _IUnidadApiConsumer;
        private ITipo_de_DenunciaApiConsumer _ITipo_de_DenunciaApiConsumer;

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

        
        public Modulo_de_Atencion_InicialController(IModulo_de_Atencion_InicialService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IModulo_de_Atencion_InicialApiConsumer Modulo_de_Atencion_InicialApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IEscolaridadApiConsumer EscolaridadApiConsumer , IOcupacionApiConsumer OcupacionApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IZonaApiConsumer ZonaApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IEstadoApiConsumer EstadoApiConsumer , ILocalidadApiConsumer LocalidadApiConsumer , ITipo_de_ComparecienteApiConsumer Tipo_de_ComparecienteApiConsumer , IEstatusApiConsumer EstatusApiConsumer , IAsignacion_de_TurnosApiConsumer Asignacion_de_TurnosApiConsumer , IUnidadApiConsumer UnidadApiConsumer , ITipo_de_DenunciaApiConsumer Tipo_de_DenunciaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IModulo_de_Atencion_InicialApiConsumer = Modulo_de_Atencion_InicialApiConsumer;
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
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IZonaApiConsumer = ZonaApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ILocalidadApiConsumer = LocalidadApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ILocalidadApiConsumer = LocalidadApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._ITipo_de_ComparecienteApiConsumer = Tipo_de_ComparecienteApiConsumer;
            this._IEstatusApiConsumer = EstatusApiConsumer;
            this._IAsignacion_de_TurnosApiConsumer = Asignacion_de_TurnosApiConsumer;
            this._IUnidadApiConsumer = UnidadApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._ITipo_de_DenunciaApiConsumer = Tipo_de_DenunciaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Modulo_de_Atencion_Inicial
        [ObjectAuth(ObjectId = (ModuleObjectId)44997, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44997, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Modulo_de_Atencion_Inicial/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)44997, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44997, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varModulo_de_Atencion_Inicial = new Modulo_de_Atencion_InicialModel();
			varModulo_de_Atencion_Inicial.Folio = Id;
			
            ViewBag.ObjectId = "44997";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Modulo_de_Atencion_InicialsData = _IModulo_de_Atencion_InicialApiConsumer.ListaSelAll(0, 1000, "Modulo_de_Atencion_Inicial.Folio=" + Id, "").Resource.Modulo_de_Atencion_Inicials;
				
				if (Modulo_de_Atencion_InicialsData != null && Modulo_de_Atencion_InicialsData.Count > 0)
                {
					var Modulo_de_Atencion_InicialData = Modulo_de_Atencion_InicialsData.First();
					varModulo_de_Atencion_Inicial= new Modulo_de_Atencion_InicialModel
					{
						Folio  = Modulo_de_Atencion_InicialData.Folio 
	                    ,Fecha_de_Registro = (Modulo_de_Atencion_InicialData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Modulo_de_Atencion_InicialData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Modulo_de_Atencion_InicialData.Hora_de_Registro
                    ,NUAT = Modulo_de_Atencion_InicialData.NUAT
                    ,Usuario_que_Registra = Modulo_de_Atencion_InicialData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Usuario_que_Registra), "Spartan_User") ??  (string)Modulo_de_Atencion_InicialData.Usuario_que_Registra_Spartan_User.Name
                    ,Nombre = Modulo_de_Atencion_InicialData.Nombre
                    ,Apellido_Paterno = Modulo_de_Atencion_InicialData.Apellido_Paterno
                    ,Apellido_Materno = Modulo_de_Atencion_InicialData.Apellido_Materno
                    ,Fecha_de_Nacimiento = (Modulo_de_Atencion_InicialData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Modulo_de_Atencion_InicialData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Modulo_de_Atencion_InicialData.Edad
                    ,Sexo = Modulo_de_Atencion_InicialData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Sexo), "Genero") ??  (string)Modulo_de_Atencion_InicialData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Modulo_de_Atencion_InicialData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Estado_Civil), "Estado_Civil") ??  (string)Modulo_de_Atencion_InicialData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Modulo_de_Atencion_InicialData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Modulo_de_Atencion_InicialData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Modulo_de_Atencion_InicialData.Numero_de_Identificacion
                    ,Nacionalidad = Modulo_de_Atencion_InicialData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Nacionalidad), "Nacionalidad") ??  (string)Modulo_de_Atencion_InicialData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = Modulo_de_Atencion_InicialData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Escolaridad), "Escolaridad") ??  (string)Modulo_de_Atencion_InicialData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Modulo_de_Atencion_InicialData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Ocupacion), "Ocupacion") ??  (string)Modulo_de_Atencion_InicialData.Ocupacion_Ocupacion.Descripcion
                    ,Calle = Modulo_de_Atencion_InicialData.Calle
                    ,Numero_Exterior = Modulo_de_Atencion_InicialData.Numero_Exterior
                    ,Numero_Interior = Modulo_de_Atencion_InicialData.Numero_Interior
                    ,Colonia = Modulo_de_Atencion_InicialData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Colonia), "Colonia") ??  (string)Modulo_de_Atencion_InicialData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Modulo_de_Atencion_InicialData.Codigo_Postal
                    ,Zona = Modulo_de_Atencion_InicialData.Zona
                    ,ZonaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Zona), "Zona") ??  (string)Modulo_de_Atencion_InicialData.Zona_Zona.Descripcion
                    ,Municipio = Modulo_de_Atencion_InicialData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Municipio), "Municipio") ??  (string)Modulo_de_Atencion_InicialData.Municipio_Municipio.Nombre
                    ,Estado = Modulo_de_Atencion_InicialData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Estado), "Estado") ??  (string)Modulo_de_Atencion_InicialData.Estado_Estado.Nombre
                    ,Telefono = Modulo_de_Atencion_InicialData.Telefono
                    ,Celular = Modulo_de_Atencion_InicialData.Celular
                    ,Correo_Electronico = Modulo_de_Atencion_InicialData.Correo_Electronico
                    ,Menor_de_Edad = Modulo_de_Atencion_InicialData.Menor_de_Edad.GetValueOrDefault()
                    ,Representante_Legal = Modulo_de_Atencion_InicialData.Representante_Legal.GetValueOrDefault()
                    ,Nombre_del_Tutor = Modulo_de_Atencion_InicialData.Nombre_del_Tutor
                    ,Apellido_Paterno_del_Tutor = Modulo_de_Atencion_InicialData.Apellido_Paterno_del_Tutor
                    ,Apellido_Materno_del_Tutor = Modulo_de_Atencion_InicialData.Apellido_Materno_del_Tutor
                    ,Fecha_de_Nacimiento_del_Tutor = (Modulo_de_Atencion_InicialData.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(Modulo_de_Atencion_InicialData.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_del_Tutor = Modulo_de_Atencion_InicialData.Edad_del_Tutor
                    ,Sexo_del_Tutor = Modulo_de_Atencion_InicialData.Sexo_del_Tutor
                    ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Sexo_del_Tutor), "Genero") ??  (string)Modulo_de_Atencion_InicialData.Sexo_del_Tutor_Genero.Descripcion
                    ,Estado_Civil_del_Tutor = Modulo_de_Atencion_InicialData.Estado_Civil_del_Tutor
                    ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Estado_Civil_del_Tutor), "Estado_Civil") ??  (string)Modulo_de_Atencion_InicialData.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_del_Tutor = Modulo_de_Atencion_InicialData.Tipo_de_Identificacion_del_Tutor
                    ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Tipo_de_Identificacion_del_Tutor), "Tipo_de_Identificacion") ??  (string)Modulo_de_Atencion_InicialData.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_del_Tutor = Modulo_de_Atencion_InicialData.Numero_de_Identificacion_del_Tutor
                    ,Nacionalidad_del_Tutor = Modulo_de_Atencion_InicialData.Nacionalidad_del_Tutor
                    ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Nacionalidad_del_Tutor), "Nacionalidad") ??  (string)Modulo_de_Atencion_InicialData.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                    ,Escolaridad_del_Tutor = Modulo_de_Atencion_InicialData.Escolaridad_del_Tutor
                    ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Escolaridad_del_Tutor), "Escolaridad") ??  (string)Modulo_de_Atencion_InicialData.Escolaridad_del_Tutor_Escolaridad.Descripcion
                    ,Ocupacion_del_Tutor = Modulo_de_Atencion_InicialData.Ocupacion_del_Tutor
                    ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Ocupacion_del_Tutor), "Ocupacion") ??  (string)Modulo_de_Atencion_InicialData.Ocupacion_del_Tutor_Ocupacion.Descripcion
                    ,Calle_del_Tutor = Modulo_de_Atencion_InicialData.Calle_del_Tutor
                    ,Numero_Exterior_del_Tutor = Modulo_de_Atencion_InicialData.Numero_Exterior_del_Tutor
                    ,Numero_Interior_del_Tutor = Modulo_de_Atencion_InicialData.Numero_Interior_del_Tutor
                    ,Colonia_del_Tutor = Modulo_de_Atencion_InicialData.Colonia_del_Tutor
                    ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Colonia_del_Tutor), "Colonia") ??  (string)Modulo_de_Atencion_InicialData.Colonia_del_Tutor_Colonia.Nombre
                    ,Codigo_Postal_del_Tutor = Modulo_de_Atencion_InicialData.Codigo_Postal_del_Tutor
                    ,Localidad_del_Tutor = Modulo_de_Atencion_InicialData.Localidad_del_Tutor
                    ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Localidad_del_Tutor), "Localidad") ??  (string)Modulo_de_Atencion_InicialData.Localidad_del_Tutor_Localidad.Descripcion
                    ,Municipio_del_Tutor = Modulo_de_Atencion_InicialData.Municipio_del_Tutor
                    ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Municipio_del_Tutor), "Municipio") ??  (string)Modulo_de_Atencion_InicialData.Municipio_del_Tutor_Municipio.Nombre
                    ,Estado_del_Tutor = Modulo_de_Atencion_InicialData.Estado_del_Tutor
                    ,Estado_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Estado_del_Tutor), "Estado") ??  (string)Modulo_de_Atencion_InicialData.Estado_del_Tutor_Estado.Nombre
                    ,Telefono_del_Tutor = Modulo_de_Atencion_InicialData.Telefono_del_Tutor
                    ,Celular_del_Tutor = Modulo_de_Atencion_InicialData.Celular_del_Tutor
                    ,Correo_Electronico_del_Tutor = Modulo_de_Atencion_InicialData.Correo_Electronico_del_Tutor
                    ,Nombre_del_Representante = Modulo_de_Atencion_InicialData.Nombre_del_Representante
                    ,Apellido_Paterno_del_Representante = Modulo_de_Atencion_InicialData.Apellido_Paterno_del_Representante
                    ,Apellido_Materno_del_Representante = Modulo_de_Atencion_InicialData.Apellido_Materno_del_Representante
                    ,Calidad_Juridica = Modulo_de_Atencion_InicialData.Calidad_Juridica
                    ,Calle_del_Representante = Modulo_de_Atencion_InicialData.Calle_del_Representante
                    ,Numero_Exterior_del_Representante = Modulo_de_Atencion_InicialData.Numero_Exterior_del_Representante
                    ,Numero_Interior_del_Representante = Modulo_de_Atencion_InicialData.Numero_Interior_del_Representante
                    ,Colonia_del_Representante = Modulo_de_Atencion_InicialData.Colonia_del_Representante
                    ,Colonia_del_RepresentanteNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Colonia_del_Representante), "Colonia") ??  (string)Modulo_de_Atencion_InicialData.Colonia_del_Representante_Colonia.Nombre
                    ,Localidad_del_Representante = Modulo_de_Atencion_InicialData.Localidad_del_Representante
                    ,Localidad_del_RepresentanteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Localidad_del_Representante), "Localidad") ??  (string)Modulo_de_Atencion_InicialData.Localidad_del_Representante_Localidad.Descripcion
                    ,Municipio_del_Representante = Modulo_de_Atencion_InicialData.Municipio_del_Representante
                    ,Municipio_del_RepresentanteNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Municipio_del_Representante), "Municipio") ??  (string)Modulo_de_Atencion_InicialData.Municipio_del_Representante_Municipio.Nombre
                    ,Estado_del_Representante = Modulo_de_Atencion_InicialData.Estado_del_Representante
                    ,Estado_del_RepresentanteNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Estado_del_Representante), "Estado") ??  (string)Modulo_de_Atencion_InicialData.Estado_del_Representante_Estado.Nombre
                    ,Telefono_del_Representante = Modulo_de_Atencion_InicialData.Telefono_del_Representante
                    ,Celular_del_Representante = Modulo_de_Atencion_InicialData.Celular_del_Representante
                    ,Correo_Electronico_del_Representante = Modulo_de_Atencion_InicialData.Correo_Electronico_del_Representante
                    ,Narrativa = Modulo_de_Atencion_InicialData.Narrativa
                    ,Atencion_Medica = Modulo_de_Atencion_InicialData.Atencion_Medica.GetValueOrDefault()
                    ,Atencion_Psicologica = Modulo_de_Atencion_InicialData.Atencion_Psicologica.GetValueOrDefault()
                    ,Requiere_Traductor = Modulo_de_Atencion_InicialData.Requiere_Traductor.GetValueOrDefault()
                    ,Tipo_de_Compareciente = Modulo_de_Atencion_InicialData.Tipo_de_Compareciente
                    ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Tipo_de_Compareciente), "Tipo_de_Compareciente") ??  (string)Modulo_de_Atencion_InicialData.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                    ,Estatus = Modulo_de_Atencion_InicialData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Estatus), "Estatus") ??  (string)Modulo_de_Atencion_InicialData.Estatus_Estatus.Descripcion
                    ,Turno_Asignado = Modulo_de_Atencion_InicialData.Turno_Asignado
                    ,Turno_AsignadoNumero_de_Turno = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Turno_Asignado), "Asignacion_de_Turnos") ??  (string)Modulo_de_Atencion_InicialData.Turno_Asignado_Asignacion_de_Turnos.Numero_de_Turno
                    ,Unidad = Modulo_de_Atencion_InicialData.Unidad
                    ,UnidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Unidad), "Unidad") ??  (string)Modulo_de_Atencion_InicialData.Unidad_Unidad.Descripcion
                    ,Municipio_Caso = Modulo_de_Atencion_InicialData.Municipio_Caso
                    ,Municipio_CasoNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Municipio_Caso), "Municipio") ??  (string)Modulo_de_Atencion_InicialData.Municipio_Caso_Municipio.Nombre
                    ,Tipo_de_Denuncia = Modulo_de_Atencion_InicialData.Tipo_de_Denuncia
                    ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Tipo_de_Denuncia), "Tipo_de_Denuncia") ??  (string)Modulo_de_Atencion_InicialData.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                    ,Numero_de_Expediente = Modulo_de_Atencion_InicialData.Numero_de_Expediente
                    ,Poblacion = Modulo_de_Atencion_InicialData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Poblacion), "Colonia") ??  (string)Modulo_de_Atencion_InicialData.Poblacion_Colonia.Nombre
                    ,Colonia_Hechos_MPO = Modulo_de_Atencion_InicialData.Colonia_Hechos_MPO
                    ,Colonia_Hechos_MPONombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Colonia_Hechos_MPO), "Colonia") ??  (string)Modulo_de_Atencion_InicialData.Colonia_Hechos_MPO_Colonia.Nombre

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
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad != null && Nacionalidads_Nacionalidad.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad = Nacionalidads_Nacionalidad.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad != null && Escolaridads_Escolaridad.Resource != null)
                ViewBag.Escolaridads_Escolaridad = Escolaridads_Escolaridad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion != null && Ocupacions_Ocupacion.Resource != null)
                ViewBag.Ocupacions_Ocupacion = Ocupacions_Ocupacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia != null && Colonias_Colonia.Resource != null)
                ViewBag.Colonias_Colonia = Colonias_Colonia.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_Zona = _IZonaApiConsumer.SelAll(true);
            if (Zonas_Zona != null && Zonas_Zona.Resource != null)
                ViewBag.Zonas_Zona = Zonas_Zona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado != null && Estados_Estado.Resource != null)
                ViewBag.Estados_Estado = Estados_Estado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_del_Tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_del_Tutor != null && Generos_Sexo_del_Tutor.Resource != null)
                ViewBag.Generos_Sexo_del_Tutor = Generos_Sexo_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_del_Tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_del_Tutor != null && Estado_Civils_Estado_Civil_del_Tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_del_Tutor = Estado_Civils_Estado_Civil_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_del_Tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_del_Tutor != null && Nacionalidads_Nacionalidad_del_Tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_del_Tutor = Nacionalidads_Nacionalidad_del_Tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_del_Tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_del_Tutor != null && Escolaridads_Escolaridad_del_Tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_del_Tutor = Escolaridads_Escolaridad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_del_Tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_del_Tutor != null && Ocupacions_Ocupacion_del_Tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_del_Tutor = Ocupacions_Ocupacion_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Tutor = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Tutor != null && Colonias_Colonia_del_Tutor.Resource != null)
                ViewBag.Colonias_Colonia_del_Tutor = Colonias_Colonia_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_del_Tutor = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_del_Tutor != null && Localidads_Localidad_del_Tutor.Resource != null)
                ViewBag.Localidads_Localidad_del_Tutor = Localidads_Localidad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Tutor = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Tutor != null && Municipios_Municipio_del_Tutor.Resource != null)
                ViewBag.Municipios_Municipio_del_Tutor = Municipios_Municipio_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Tutor = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Tutor != null && Estados_Estado_del_Tutor.Resource != null)
                ViewBag.Estados_Estado_del_Tutor = Estados_Estado_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Representante = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Representante != null && Colonias_Colonia_del_Representante.Resource != null)
                ViewBag.Colonias_Colonia_del_Representante = Colonias_Colonia_del_Representante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_del_Representante = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_del_Representante != null && Localidads_Localidad_del_Representante.Resource != null)
                ViewBag.Localidads_Localidad_del_Representante = Localidads_Localidad_del_Representante.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Representante = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Representante != null && Municipios_Municipio_del_Representante.Resource != null)
                ViewBag.Municipios_Municipio_del_Representante = Municipios_Municipio_del_Representante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Representante = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Representante != null && Estados_Estado_del_Representante.Resource != null)
                ViewBag.Estados_Estado_del_Representante = Estados_Estado_del_Representante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Estatus = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Estatus != null && Estatuss_Estatus.Resource != null)
                ViewBag.Estatuss_Estatus = Estatuss_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Asignacion_de_Turnoss_Turno_Asignado = _IAsignacion_de_TurnosApiConsumer.SelAll(true);
            if (Asignacion_de_Turnoss_Turno_Asignado != null && Asignacion_de_Turnoss_Turno_Asignado.Resource != null)
                ViewBag.Asignacion_de_Turnoss_Turno_Asignado = Asignacion_de_Turnoss_Turno_Asignado.Resource.Where(m => m.Numero_de_Turno != null).OrderBy(m => m.Numero_de_Turno).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Folio), "Asignacion_de_Turnos", "Numero_de_Turno") ?? m.Numero_de_Turno.ToString(), Value = Convert.ToString(m.Folio)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_Caso = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_Caso != null && Municipios_Municipio_Caso.Resource != null)
                ViewBag.Municipios_Municipio_Caso = Municipios_Municipio_Caso.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Poblacion = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Poblacion != null && Colonias_Poblacion.Resource != null)
                ViewBag.Colonias_Poblacion = Colonias_Poblacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_Hechos_MPO = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_Hechos_MPO != null && Colonias_Colonia_Hechos_MPO.Resource != null)
                ViewBag.Colonias_Colonia_Hechos_MPO = Colonias_Colonia_Hechos_MPO.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varModulo_de_Atencion_Inicial);
        }
		
	[HttpGet]
        public ActionResult AddModulo_de_Atencion_Inicial(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44997);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
			Modulo_de_Atencion_InicialModel varModulo_de_Atencion_Inicial= new Modulo_de_Atencion_InicialModel();


            if (id.ToString() != "0")
            {
                var Modulo_de_Atencion_InicialsData = _IModulo_de_Atencion_InicialApiConsumer.ListaSelAll(0, 1000, "Modulo_de_Atencion_Inicial.Folio=" + id, "").Resource.Modulo_de_Atencion_Inicials;
				
				if (Modulo_de_Atencion_InicialsData != null && Modulo_de_Atencion_InicialsData.Count > 0)
                {
					var Modulo_de_Atencion_InicialData = Modulo_de_Atencion_InicialsData.First();
					varModulo_de_Atencion_Inicial= new Modulo_de_Atencion_InicialModel
					{
						Folio  = Modulo_de_Atencion_InicialData.Folio 
	                    ,Fecha_de_Registro = (Modulo_de_Atencion_InicialData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Modulo_de_Atencion_InicialData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Modulo_de_Atencion_InicialData.Hora_de_Registro
                    ,NUAT = Modulo_de_Atencion_InicialData.NUAT
                    ,Usuario_que_Registra = Modulo_de_Atencion_InicialData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Usuario_que_Registra), "Spartan_User") ??  (string)Modulo_de_Atencion_InicialData.Usuario_que_Registra_Spartan_User.Name
                    ,Nombre = Modulo_de_Atencion_InicialData.Nombre
                    ,Apellido_Paterno = Modulo_de_Atencion_InicialData.Apellido_Paterno
                    ,Apellido_Materno = Modulo_de_Atencion_InicialData.Apellido_Materno
                    ,Fecha_de_Nacimiento = (Modulo_de_Atencion_InicialData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Modulo_de_Atencion_InicialData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Modulo_de_Atencion_InicialData.Edad
                    ,Sexo = Modulo_de_Atencion_InicialData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Sexo), "Genero") ??  (string)Modulo_de_Atencion_InicialData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Modulo_de_Atencion_InicialData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Estado_Civil), "Estado_Civil") ??  (string)Modulo_de_Atencion_InicialData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Modulo_de_Atencion_InicialData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Modulo_de_Atencion_InicialData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Modulo_de_Atencion_InicialData.Numero_de_Identificacion
                    ,Nacionalidad = Modulo_de_Atencion_InicialData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Nacionalidad), "Nacionalidad") ??  (string)Modulo_de_Atencion_InicialData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = Modulo_de_Atencion_InicialData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Escolaridad), "Escolaridad") ??  (string)Modulo_de_Atencion_InicialData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Modulo_de_Atencion_InicialData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Ocupacion), "Ocupacion") ??  (string)Modulo_de_Atencion_InicialData.Ocupacion_Ocupacion.Descripcion
                    ,Calle = Modulo_de_Atencion_InicialData.Calle
                    ,Numero_Exterior = Modulo_de_Atencion_InicialData.Numero_Exterior
                    ,Numero_Interior = Modulo_de_Atencion_InicialData.Numero_Interior
                    ,Colonia = Modulo_de_Atencion_InicialData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Colonia), "Colonia") ??  (string)Modulo_de_Atencion_InicialData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Modulo_de_Atencion_InicialData.Codigo_Postal
                    ,Zona = Modulo_de_Atencion_InicialData.Zona
                    ,ZonaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Zona), "Zona") ??  (string)Modulo_de_Atencion_InicialData.Zona_Zona.Descripcion
                    ,Municipio = Modulo_de_Atencion_InicialData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Municipio), "Municipio") ??  (string)Modulo_de_Atencion_InicialData.Municipio_Municipio.Nombre
                    ,Estado = Modulo_de_Atencion_InicialData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Estado), "Estado") ??  (string)Modulo_de_Atencion_InicialData.Estado_Estado.Nombre
                    ,Telefono = Modulo_de_Atencion_InicialData.Telefono
                    ,Celular = Modulo_de_Atencion_InicialData.Celular
                    ,Correo_Electronico = Modulo_de_Atencion_InicialData.Correo_Electronico
                    ,Menor_de_Edad = Modulo_de_Atencion_InicialData.Menor_de_Edad.GetValueOrDefault()
                    ,Representante_Legal = Modulo_de_Atencion_InicialData.Representante_Legal.GetValueOrDefault()
                    ,Nombre_del_Tutor = Modulo_de_Atencion_InicialData.Nombre_del_Tutor
                    ,Apellido_Paterno_del_Tutor = Modulo_de_Atencion_InicialData.Apellido_Paterno_del_Tutor
                    ,Apellido_Materno_del_Tutor = Modulo_de_Atencion_InicialData.Apellido_Materno_del_Tutor
                    ,Fecha_de_Nacimiento_del_Tutor = (Modulo_de_Atencion_InicialData.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(Modulo_de_Atencion_InicialData.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_del_Tutor = Modulo_de_Atencion_InicialData.Edad_del_Tutor
                    ,Sexo_del_Tutor = Modulo_de_Atencion_InicialData.Sexo_del_Tutor
                    ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Sexo_del_Tutor), "Genero") ??  (string)Modulo_de_Atencion_InicialData.Sexo_del_Tutor_Genero.Descripcion
                    ,Estado_Civil_del_Tutor = Modulo_de_Atencion_InicialData.Estado_Civil_del_Tutor
                    ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Estado_Civil_del_Tutor), "Estado_Civil") ??  (string)Modulo_de_Atencion_InicialData.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_del_Tutor = Modulo_de_Atencion_InicialData.Tipo_de_Identificacion_del_Tutor
                    ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Tipo_de_Identificacion_del_Tutor), "Tipo_de_Identificacion") ??  (string)Modulo_de_Atencion_InicialData.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_del_Tutor = Modulo_de_Atencion_InicialData.Numero_de_Identificacion_del_Tutor
                    ,Nacionalidad_del_Tutor = Modulo_de_Atencion_InicialData.Nacionalidad_del_Tutor
                    ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Nacionalidad_del_Tutor), "Nacionalidad") ??  (string)Modulo_de_Atencion_InicialData.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                    ,Escolaridad_del_Tutor = Modulo_de_Atencion_InicialData.Escolaridad_del_Tutor
                    ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Escolaridad_del_Tutor), "Escolaridad") ??  (string)Modulo_de_Atencion_InicialData.Escolaridad_del_Tutor_Escolaridad.Descripcion
                    ,Ocupacion_del_Tutor = Modulo_de_Atencion_InicialData.Ocupacion_del_Tutor
                    ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Ocupacion_del_Tutor), "Ocupacion") ??  (string)Modulo_de_Atencion_InicialData.Ocupacion_del_Tutor_Ocupacion.Descripcion
                    ,Calle_del_Tutor = Modulo_de_Atencion_InicialData.Calle_del_Tutor
                    ,Numero_Exterior_del_Tutor = Modulo_de_Atencion_InicialData.Numero_Exterior_del_Tutor
                    ,Numero_Interior_del_Tutor = Modulo_de_Atencion_InicialData.Numero_Interior_del_Tutor
                    ,Colonia_del_Tutor = Modulo_de_Atencion_InicialData.Colonia_del_Tutor
                    ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Colonia_del_Tutor), "Colonia") ??  (string)Modulo_de_Atencion_InicialData.Colonia_del_Tutor_Colonia.Nombre
                    ,Codigo_Postal_del_Tutor = Modulo_de_Atencion_InicialData.Codigo_Postal_del_Tutor
                    ,Localidad_del_Tutor = Modulo_de_Atencion_InicialData.Localidad_del_Tutor
                    ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Localidad_del_Tutor), "Localidad") ??  (string)Modulo_de_Atencion_InicialData.Localidad_del_Tutor_Localidad.Descripcion
                    ,Municipio_del_Tutor = Modulo_de_Atencion_InicialData.Municipio_del_Tutor
                    ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Municipio_del_Tutor), "Municipio") ??  (string)Modulo_de_Atencion_InicialData.Municipio_del_Tutor_Municipio.Nombre
                    ,Estado_del_Tutor = Modulo_de_Atencion_InicialData.Estado_del_Tutor
                    ,Estado_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Estado_del_Tutor), "Estado") ??  (string)Modulo_de_Atencion_InicialData.Estado_del_Tutor_Estado.Nombre
                    ,Telefono_del_Tutor = Modulo_de_Atencion_InicialData.Telefono_del_Tutor
                    ,Celular_del_Tutor = Modulo_de_Atencion_InicialData.Celular_del_Tutor
                    ,Correo_Electronico_del_Tutor = Modulo_de_Atencion_InicialData.Correo_Electronico_del_Tutor
                    ,Nombre_del_Representante = Modulo_de_Atencion_InicialData.Nombre_del_Representante
                    ,Apellido_Paterno_del_Representante = Modulo_de_Atencion_InicialData.Apellido_Paterno_del_Representante
                    ,Apellido_Materno_del_Representante = Modulo_de_Atencion_InicialData.Apellido_Materno_del_Representante
                    ,Calidad_Juridica = Modulo_de_Atencion_InicialData.Calidad_Juridica
                    ,Calle_del_Representante = Modulo_de_Atencion_InicialData.Calle_del_Representante
                    ,Numero_Exterior_del_Representante = Modulo_de_Atencion_InicialData.Numero_Exterior_del_Representante
                    ,Numero_Interior_del_Representante = Modulo_de_Atencion_InicialData.Numero_Interior_del_Representante
                    ,Colonia_del_Representante = Modulo_de_Atencion_InicialData.Colonia_del_Representante
                    ,Colonia_del_RepresentanteNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Colonia_del_Representante), "Colonia") ??  (string)Modulo_de_Atencion_InicialData.Colonia_del_Representante_Colonia.Nombre
                    ,Localidad_del_Representante = Modulo_de_Atencion_InicialData.Localidad_del_Representante
                    ,Localidad_del_RepresentanteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Localidad_del_Representante), "Localidad") ??  (string)Modulo_de_Atencion_InicialData.Localidad_del_Representante_Localidad.Descripcion
                    ,Municipio_del_Representante = Modulo_de_Atencion_InicialData.Municipio_del_Representante
                    ,Municipio_del_RepresentanteNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Municipio_del_Representante), "Municipio") ??  (string)Modulo_de_Atencion_InicialData.Municipio_del_Representante_Municipio.Nombre
                    ,Estado_del_Representante = Modulo_de_Atencion_InicialData.Estado_del_Representante
                    ,Estado_del_RepresentanteNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Estado_del_Representante), "Estado") ??  (string)Modulo_de_Atencion_InicialData.Estado_del_Representante_Estado.Nombre
                    ,Telefono_del_Representante = Modulo_de_Atencion_InicialData.Telefono_del_Representante
                    ,Celular_del_Representante = Modulo_de_Atencion_InicialData.Celular_del_Representante
                    ,Correo_Electronico_del_Representante = Modulo_de_Atencion_InicialData.Correo_Electronico_del_Representante
                    ,Narrativa = Modulo_de_Atencion_InicialData.Narrativa
                    ,Atencion_Medica = Modulo_de_Atencion_InicialData.Atencion_Medica.GetValueOrDefault()
                    ,Atencion_Psicologica = Modulo_de_Atencion_InicialData.Atencion_Psicologica.GetValueOrDefault()
                    ,Requiere_Traductor = Modulo_de_Atencion_InicialData.Requiere_Traductor.GetValueOrDefault()
                    ,Tipo_de_Compareciente = Modulo_de_Atencion_InicialData.Tipo_de_Compareciente
                    ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Tipo_de_Compareciente), "Tipo_de_Compareciente") ??  (string)Modulo_de_Atencion_InicialData.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                    ,Estatus = Modulo_de_Atencion_InicialData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Estatus), "Estatus") ??  (string)Modulo_de_Atencion_InicialData.Estatus_Estatus.Descripcion
                    ,Turno_Asignado = Modulo_de_Atencion_InicialData.Turno_Asignado
                    ,Turno_AsignadoNumero_de_Turno = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Turno_Asignado), "Asignacion_de_Turnos") ??  (string)Modulo_de_Atencion_InicialData.Turno_Asignado_Asignacion_de_Turnos.Numero_de_Turno
                    ,Unidad = Modulo_de_Atencion_InicialData.Unidad
                    ,UnidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Unidad), "Unidad") ??  (string)Modulo_de_Atencion_InicialData.Unidad_Unidad.Descripcion
                    ,Municipio_Caso = Modulo_de_Atencion_InicialData.Municipio_Caso
                    ,Municipio_CasoNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Municipio_Caso), "Municipio") ??  (string)Modulo_de_Atencion_InicialData.Municipio_Caso_Municipio.Nombre
                    ,Tipo_de_Denuncia = Modulo_de_Atencion_InicialData.Tipo_de_Denuncia
                    ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Tipo_de_Denuncia), "Tipo_de_Denuncia") ??  (string)Modulo_de_Atencion_InicialData.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                    ,Numero_de_Expediente = Modulo_de_Atencion_InicialData.Numero_de_Expediente
                    ,Poblacion = Modulo_de_Atencion_InicialData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Poblacion), "Colonia") ??  (string)Modulo_de_Atencion_InicialData.Poblacion_Colonia.Nombre
                    ,Colonia_Hechos_MPO = Modulo_de_Atencion_InicialData.Colonia_Hechos_MPO
                    ,Colonia_Hechos_MPONombre = CultureHelper.GetTraduction(Convert.ToString(Modulo_de_Atencion_InicialData.Colonia_Hechos_MPO), "Colonia") ??  (string)Modulo_de_Atencion_InicialData.Colonia_Hechos_MPO_Colonia.Nombre

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
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad != null && Nacionalidads_Nacionalidad.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad = Nacionalidads_Nacionalidad.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad != null && Escolaridads_Escolaridad.Resource != null)
                ViewBag.Escolaridads_Escolaridad = Escolaridads_Escolaridad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion != null && Ocupacions_Ocupacion.Resource != null)
                ViewBag.Ocupacions_Ocupacion = Ocupacions_Ocupacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia != null && Colonias_Colonia.Resource != null)
                ViewBag.Colonias_Colonia = Colonias_Colonia.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_Zona = _IZonaApiConsumer.SelAll(true);
            if (Zonas_Zona != null && Zonas_Zona.Resource != null)
                ViewBag.Zonas_Zona = Zonas_Zona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado != null && Estados_Estado.Resource != null)
                ViewBag.Estados_Estado = Estados_Estado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_del_Tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_del_Tutor != null && Generos_Sexo_del_Tutor.Resource != null)
                ViewBag.Generos_Sexo_del_Tutor = Generos_Sexo_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_del_Tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_del_Tutor != null && Estado_Civils_Estado_Civil_del_Tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_del_Tutor = Estado_Civils_Estado_Civil_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_del_Tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_del_Tutor != null && Nacionalidads_Nacionalidad_del_Tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_del_Tutor = Nacionalidads_Nacionalidad_del_Tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_del_Tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_del_Tutor != null && Escolaridads_Escolaridad_del_Tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_del_Tutor = Escolaridads_Escolaridad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_del_Tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_del_Tutor != null && Ocupacions_Ocupacion_del_Tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_del_Tutor = Ocupacions_Ocupacion_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Tutor = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Tutor != null && Colonias_Colonia_del_Tutor.Resource != null)
                ViewBag.Colonias_Colonia_del_Tutor = Colonias_Colonia_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_del_Tutor = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_del_Tutor != null && Localidads_Localidad_del_Tutor.Resource != null)
                ViewBag.Localidads_Localidad_del_Tutor = Localidads_Localidad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Tutor = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Tutor != null && Municipios_Municipio_del_Tutor.Resource != null)
                ViewBag.Municipios_Municipio_del_Tutor = Municipios_Municipio_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Tutor = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Tutor != null && Estados_Estado_del_Tutor.Resource != null)
                ViewBag.Estados_Estado_del_Tutor = Estados_Estado_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Representante = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Representante != null && Colonias_Colonia_del_Representante.Resource != null)
                ViewBag.Colonias_Colonia_del_Representante = Colonias_Colonia_del_Representante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_del_Representante = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_del_Representante != null && Localidads_Localidad_del_Representante.Resource != null)
                ViewBag.Localidads_Localidad_del_Representante = Localidads_Localidad_del_Representante.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Representante = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Representante != null && Municipios_Municipio_del_Representante.Resource != null)
                ViewBag.Municipios_Municipio_del_Representante = Municipios_Municipio_del_Representante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Representante = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Representante != null && Estados_Estado_del_Representante.Resource != null)
                ViewBag.Estados_Estado_del_Representante = Estados_Estado_del_Representante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Estatus = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Estatus != null && Estatuss_Estatus.Resource != null)
                ViewBag.Estatuss_Estatus = Estatuss_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Asignacion_de_Turnoss_Turno_Asignado = _IAsignacion_de_TurnosApiConsumer.SelAll(true);
            if (Asignacion_de_Turnoss_Turno_Asignado != null && Asignacion_de_Turnoss_Turno_Asignado.Resource != null)
                ViewBag.Asignacion_de_Turnoss_Turno_Asignado = Asignacion_de_Turnoss_Turno_Asignado.Resource.Where(m => m.Numero_de_Turno != null).OrderBy(m => m.Numero_de_Turno).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Folio), "Asignacion_de_Turnos", "Numero_de_Turno") ?? m.Numero_de_Turno.ToString(), Value = Convert.ToString(m.Folio)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_Caso = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_Caso != null && Municipios_Municipio_Caso.Resource != null)
                ViewBag.Municipios_Municipio_Caso = Municipios_Municipio_Caso.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Poblacion = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Poblacion != null && Colonias_Poblacion.Resource != null)
                ViewBag.Colonias_Poblacion = Colonias_Poblacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_Hechos_MPO = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_Hechos_MPO != null && Colonias_Colonia_Hechos_MPO.Resource != null)
                ViewBag.Colonias_Colonia_Hechos_MPO = Colonias_Colonia_Hechos_MPO.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddModulo_de_Atencion_Inicial", varModulo_de_Atencion_Inicial);
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
        public ActionResult GetEscolaridadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEscolaridadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetOcupacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOcupacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetZonaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IZonaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetEstatusAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatusApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetAsignacion_de_TurnosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAsignacion_de_TurnosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Numero_de_Turno).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Folio), "Asignacion_de_Turnos", "Numero_de_Turno")?? m.Numero_de_Turno,
                    Value = Convert.ToString(m.Folio)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
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
        public ActionResult GetTipo_de_DenunciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_DenunciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Modulo_de_Atencion_InicialAdvanceSearchModel model, int idFilter = -1)
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
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad != null && Nacionalidads_Nacionalidad.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad = Nacionalidads_Nacionalidad.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad != null && Escolaridads_Escolaridad.Resource != null)
                ViewBag.Escolaridads_Escolaridad = Escolaridads_Escolaridad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion != null && Ocupacions_Ocupacion.Resource != null)
                ViewBag.Ocupacions_Ocupacion = Ocupacions_Ocupacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia != null && Colonias_Colonia.Resource != null)
                ViewBag.Colonias_Colonia = Colonias_Colonia.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_Zona = _IZonaApiConsumer.SelAll(true);
            if (Zonas_Zona != null && Zonas_Zona.Resource != null)
                ViewBag.Zonas_Zona = Zonas_Zona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado != null && Estados_Estado.Resource != null)
                ViewBag.Estados_Estado = Estados_Estado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_del_Tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_del_Tutor != null && Generos_Sexo_del_Tutor.Resource != null)
                ViewBag.Generos_Sexo_del_Tutor = Generos_Sexo_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_del_Tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_del_Tutor != null && Estado_Civils_Estado_Civil_del_Tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_del_Tutor = Estado_Civils_Estado_Civil_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_del_Tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_del_Tutor != null && Nacionalidads_Nacionalidad_del_Tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_del_Tutor = Nacionalidads_Nacionalidad_del_Tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_del_Tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_del_Tutor != null && Escolaridads_Escolaridad_del_Tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_del_Tutor = Escolaridads_Escolaridad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_del_Tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_del_Tutor != null && Ocupacions_Ocupacion_del_Tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_del_Tutor = Ocupacions_Ocupacion_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Tutor = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Tutor != null && Colonias_Colonia_del_Tutor.Resource != null)
                ViewBag.Colonias_Colonia_del_Tutor = Colonias_Colonia_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_del_Tutor = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_del_Tutor != null && Localidads_Localidad_del_Tutor.Resource != null)
                ViewBag.Localidads_Localidad_del_Tutor = Localidads_Localidad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Tutor = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Tutor != null && Municipios_Municipio_del_Tutor.Resource != null)
                ViewBag.Municipios_Municipio_del_Tutor = Municipios_Municipio_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Tutor = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Tutor != null && Estados_Estado_del_Tutor.Resource != null)
                ViewBag.Estados_Estado_del_Tutor = Estados_Estado_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Representante = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Representante != null && Colonias_Colonia_del_Representante.Resource != null)
                ViewBag.Colonias_Colonia_del_Representante = Colonias_Colonia_del_Representante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_del_Representante = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_del_Representante != null && Localidads_Localidad_del_Representante.Resource != null)
                ViewBag.Localidads_Localidad_del_Representante = Localidads_Localidad_del_Representante.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Representante = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Representante != null && Municipios_Municipio_del_Representante.Resource != null)
                ViewBag.Municipios_Municipio_del_Representante = Municipios_Municipio_del_Representante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Representante = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Representante != null && Estados_Estado_del_Representante.Resource != null)
                ViewBag.Estados_Estado_del_Representante = Estados_Estado_del_Representante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Estatus = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Estatus != null && Estatuss_Estatus.Resource != null)
                ViewBag.Estatuss_Estatus = Estatuss_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Asignacion_de_Turnoss_Turno_Asignado = _IAsignacion_de_TurnosApiConsumer.SelAll(true);
            if (Asignacion_de_Turnoss_Turno_Asignado != null && Asignacion_de_Turnoss_Turno_Asignado.Resource != null)
                ViewBag.Asignacion_de_Turnoss_Turno_Asignado = Asignacion_de_Turnoss_Turno_Asignado.Resource.Where(m => m.Numero_de_Turno != null).OrderBy(m => m.Numero_de_Turno).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Folio), "Asignacion_de_Turnos", "Numero_de_Turno") ?? m.Numero_de_Turno.ToString(), Value = Convert.ToString(m.Folio)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_Caso = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_Caso != null && Municipios_Municipio_Caso.Resource != null)
                ViewBag.Municipios_Municipio_Caso = Municipios_Municipio_Caso.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Poblacion = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Poblacion != null && Colonias_Poblacion.Resource != null)
                ViewBag.Colonias_Poblacion = Colonias_Poblacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_Hechos_MPO = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_Hechos_MPO != null && Colonias_Colonia_Hechos_MPO.Resource != null)
                ViewBag.Colonias_Colonia_Hechos_MPO = Colonias_Colonia_Hechos_MPO.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
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
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad != null && Nacionalidads_Nacionalidad.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad = Nacionalidads_Nacionalidad.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad != null && Escolaridads_Escolaridad.Resource != null)
                ViewBag.Escolaridads_Escolaridad = Escolaridads_Escolaridad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion != null && Ocupacions_Ocupacion.Resource != null)
                ViewBag.Ocupacions_Ocupacion = Ocupacions_Ocupacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia != null && Colonias_Colonia.Resource != null)
                ViewBag.Colonias_Colonia = Colonias_Colonia.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_Zona = _IZonaApiConsumer.SelAll(true);
            if (Zonas_Zona != null && Zonas_Zona.Resource != null)
                ViewBag.Zonas_Zona = Zonas_Zona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado != null && Estados_Estado.Resource != null)
                ViewBag.Estados_Estado = Estados_Estado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_del_Tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_del_Tutor != null && Generos_Sexo_del_Tutor.Resource != null)
                ViewBag.Generos_Sexo_del_Tutor = Generos_Sexo_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_del_Tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_del_Tutor != null && Estado_Civils_Estado_Civil_del_Tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_del_Tutor = Estado_Civils_Estado_Civil_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_del_Tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_del_Tutor != null && Nacionalidads_Nacionalidad_del_Tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_del_Tutor = Nacionalidads_Nacionalidad_del_Tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_del_Tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_del_Tutor != null && Escolaridads_Escolaridad_del_Tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_del_Tutor = Escolaridads_Escolaridad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_del_Tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_del_Tutor != null && Ocupacions_Ocupacion_del_Tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_del_Tutor = Ocupacions_Ocupacion_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Tutor = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Tutor != null && Colonias_Colonia_del_Tutor.Resource != null)
                ViewBag.Colonias_Colonia_del_Tutor = Colonias_Colonia_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_del_Tutor = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_del_Tutor != null && Localidads_Localidad_del_Tutor.Resource != null)
                ViewBag.Localidads_Localidad_del_Tutor = Localidads_Localidad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Tutor = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Tutor != null && Municipios_Municipio_del_Tutor.Resource != null)
                ViewBag.Municipios_Municipio_del_Tutor = Municipios_Municipio_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Tutor = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Tutor != null && Estados_Estado_del_Tutor.Resource != null)
                ViewBag.Estados_Estado_del_Tutor = Estados_Estado_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Representante = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Representante != null && Colonias_Colonia_del_Representante.Resource != null)
                ViewBag.Colonias_Colonia_del_Representante = Colonias_Colonia_del_Representante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_del_Representante = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_del_Representante != null && Localidads_Localidad_del_Representante.Resource != null)
                ViewBag.Localidads_Localidad_del_Representante = Localidads_Localidad_del_Representante.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Representante = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Representante != null && Municipios_Municipio_del_Representante.Resource != null)
                ViewBag.Municipios_Municipio_del_Representante = Municipios_Municipio_del_Representante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Representante = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Representante != null && Estados_Estado_del_Representante.Resource != null)
                ViewBag.Estados_Estado_del_Representante = Estados_Estado_del_Representante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatusApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatuss_Estatus = _IEstatusApiConsumer.SelAll(true);
            if (Estatuss_Estatus != null && Estatuss_Estatus.Resource != null)
                ViewBag.Estatuss_Estatus = Estatuss_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAsignacion_de_TurnosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Asignacion_de_Turnoss_Turno_Asignado = _IAsignacion_de_TurnosApiConsumer.SelAll(true);
            if (Asignacion_de_Turnoss_Turno_Asignado != null && Asignacion_de_Turnoss_Turno_Asignado.Resource != null)
                ViewBag.Asignacion_de_Turnoss_Turno_Asignado = Asignacion_de_Turnoss_Turno_Asignado.Resource.Where(m => m.Numero_de_Turno != null).OrderBy(m => m.Numero_de_Turno).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Folio), "Asignacion_de_Turnos", "Numero_de_Turno") ?? m.Numero_de_Turno.ToString(), Value = Convert.ToString(m.Folio)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad != null && Unidads_Unidad.Resource != null)
                ViewBag.Unidads_Unidad = Unidads_Unidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_Caso = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_Caso != null && Municipios_Municipio_Caso.Resource != null)
                ViewBag.Municipios_Municipio_Caso = Municipios_Municipio_Caso.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Poblacion = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Poblacion != null && Colonias_Poblacion.Resource != null)
                ViewBag.Colonias_Poblacion = Colonias_Poblacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_Hechos_MPO = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_Hechos_MPO != null && Colonias_Colonia_Hechos_MPO.Resource != null)
                ViewBag.Colonias_Colonia_Hechos_MPO = Colonias_Colonia_Hechos_MPO.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Modulo_de_Atencion_InicialAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Modulo_de_Atencion_InicialAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Modulo_de_Atencion_InicialAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Modulo_de_Atencion_InicialPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IModulo_de_Atencion_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Modulo_de_Atencion_Inicials == null)
                result.Modulo_de_Atencion_Inicials = new List<Modulo_de_Atencion_Inicial>();

            return Json(new
            {
                data = result.Modulo_de_Atencion_Inicials.Select(m => new Modulo_de_Atencion_InicialGridModel
                    {
                    Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
			,NUAT = m.NUAT
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Zona.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_Estado.Nombre
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Menor_de_Edad = m.Menor_de_Edad
			,Representante_Legal = m.Representante_Legal
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
                        ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Tutor_Localidad.Descripcion
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Tutor_Estado.Nombre
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
			,Nombre_del_Representante = m.Nombre_del_Representante
			,Apellido_Paterno_del_Representante = m.Apellido_Paterno_del_Representante
			,Apellido_Materno_del_Representante = m.Apellido_Materno_del_Representante
			,Calidad_Juridica = m.Calidad_Juridica
			,Calle_del_Representante = m.Calle_del_Representante
			,Numero_Exterior_del_Representante = m.Numero_Exterior_del_Representante
			,Numero_Interior_del_Representante = m.Numero_Interior_del_Representante
                        ,Colonia_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Colonia_del_Representante_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Representante_Colonia.Nombre
                        ,Localidad_del_RepresentanteDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Representante_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Representante_Localidad.Descripcion
                        ,Municipio_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Municipio_del_Representante_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Representante_Municipio.Nombre
                        ,Estado_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Estado_del_Representante_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Representante_Estado.Nombre
			,Telefono_del_Representante = m.Telefono_del_Representante
			,Celular_del_Representante = m.Celular_del_Representante
			,Correo_Electronico_del_Representante = m.Correo_Electronico_del_Representante
			,Narrativa = m.Narrativa
			,Atencion_Medica = m.Atencion_Medica
			,Atencion_Psicologica = m.Atencion_Psicologica
			,Requiere_Traductor = m.Requiere_Traductor
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus.Descripcion
                        ,Turno_AsignadoNumero_de_Turno = CultureHelper.GetTraduction(m.Turno_Asignado_Asignacion_de_Turnos.Folio.ToString(), "Numero_de_Turno") ?? (string)m.Turno_Asignado_Asignacion_de_Turnos.Numero_de_Turno
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,Municipio_CasoNombre = CultureHelper.GetTraduction(m.Municipio_Caso_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Caso_Municipio.Nombre
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
			,Numero_de_Expediente = m.Numero_de_Expediente
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia_Hechos_MPONombre = CultureHelper.GetTraduction(m.Colonia_Hechos_MPO_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Hechos_MPO_Colonia.Nombre

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetModulo_de_Atencion_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModulo_de_Atencion_InicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Folio), "Modulo_de_Atencion_Inicial", m.),
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
        /// Get List of Modulo_de_Atencion_Inicial from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Modulo_de_Atencion_Inicial Entity</returns>
        public ActionResult GetModulo_de_Atencion_InicialList(UrlParametersModel param)
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
            _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Modulo_de_Atencion_InicialPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Modulo_de_Atencion_InicialAdvanceSearchModel))
                {
					var advanceFilter =
                    (Modulo_de_Atencion_InicialAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Modulo_de_Atencion_InicialPropertyMapper oModulo_de_Atencion_InicialPropertyMapper = new Modulo_de_Atencion_InicialPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oModulo_de_Atencion_InicialPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IModulo_de_Atencion_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Modulo_de_Atencion_Inicials == null)
                result.Modulo_de_Atencion_Inicials = new List<Modulo_de_Atencion_Inicial>();

            return Json(new
            {
                aaData = result.Modulo_de_Atencion_Inicials.Select(m => new Modulo_de_Atencion_InicialGridModel
            {
                    Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
			,NUAT = m.NUAT
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Zona.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_Estado.Nombre
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Menor_de_Edad = m.Menor_de_Edad
			,Representante_Legal = m.Representante_Legal
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
                        ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Tutor_Localidad.Descripcion
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Tutor_Estado.Nombre
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
			,Nombre_del_Representante = m.Nombre_del_Representante
			,Apellido_Paterno_del_Representante = m.Apellido_Paterno_del_Representante
			,Apellido_Materno_del_Representante = m.Apellido_Materno_del_Representante
			,Calidad_Juridica = m.Calidad_Juridica
			,Calle_del_Representante = m.Calle_del_Representante
			,Numero_Exterior_del_Representante = m.Numero_Exterior_del_Representante
			,Numero_Interior_del_Representante = m.Numero_Interior_del_Representante
                        ,Colonia_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Colonia_del_Representante_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Representante_Colonia.Nombre
                        ,Localidad_del_RepresentanteDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Representante_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Representante_Localidad.Descripcion
                        ,Municipio_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Municipio_del_Representante_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Representante_Municipio.Nombre
                        ,Estado_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Estado_del_Representante_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Representante_Estado.Nombre
			,Telefono_del_Representante = m.Telefono_del_Representante
			,Celular_del_Representante = m.Celular_del_Representante
			,Correo_Electronico_del_Representante = m.Correo_Electronico_del_Representante
			,Narrativa = m.Narrativa
			,Atencion_Medica = m.Atencion_Medica
			,Atencion_Psicologica = m.Atencion_Psicologica
			,Requiere_Traductor = m.Requiere_Traductor
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus.Descripcion
                        ,Turno_AsignadoNumero_de_Turno = CultureHelper.GetTraduction(m.Turno_Asignado_Asignacion_de_Turnos.Folio.ToString(), "Numero_de_Turno") ?? (string)m.Turno_Asignado_Asignacion_de_Turnos.Numero_de_Turno
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,Municipio_CasoNombre = CultureHelper.GetTraduction(m.Municipio_Caso_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Caso_Municipio.Nombre
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
			,Numero_de_Expediente = m.Numero_de_Expediente
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia_Hechos_MPONombre = CultureHelper.GetTraduction(m.Colonia_Hechos_MPO_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Hechos_MPO_Colonia.Nombre

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetModulo_de_Atencion_Inicial_Usuario_que_Registra_Spartan_User(string query, string where)
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
        public string GetAdvanceFilter(Modulo_de_Atencion_InicialAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromFolio) || !string.IsNullOrEmpty(filter.ToFolio))
            {
                if (!string.IsNullOrEmpty(filter.FromFolio))
                    where += " AND Modulo_de_Atencion_Inicial.Folio >= " + filter.FromFolio;
                if (!string.IsNullOrEmpty(filter.ToFolio))
                    where += " AND Modulo_de_Atencion_Inicial.Folio <= " + filter.ToFolio;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Modulo_de_Atencion_Inicial.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Modulo_de_Atencion_Inicial.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Modulo_de_Atencion_Inicial.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Modulo_de_Atencion_Inicial.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
            }

            if (!string.IsNullOrEmpty(filter.NUAT))
            {
                switch (filter.NUATFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.NUAT LIKE '" + filter.NUAT + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.NUAT LIKE '%" + filter.NUAT + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.NUAT = '" + filter.NUAT + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.NUAT LIKE '%" + filter.NUAT + "%'";
                        break;
                }
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

                where += " AND Modulo_de_Atencion_Inicial.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombre))
            {
                switch (filter.NombreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Nombre LIKE '" + filter.Nombre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Nombre LIKE '%" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Nombre = '" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Nombre LIKE '%" + filter.Nombre + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno))
            {
                switch (filter.Apellido_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Paterno LIKE '" + filter.Apellido_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Paterno = '" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno))
            {
                switch (filter.Apellido_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Materno LIKE '" + filter.Apellido_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Materno = '" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "%'";
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
                    where += " AND Modulo_de_Atencion_Inicial.Fecha_de_Nacimiento >= '" + Fecha_de_NacimientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento))
                    where += " AND Modulo_de_Atencion_Inicial.Fecha_de_Nacimiento <= '" + Fecha_de_NacimientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromEdad) || !string.IsNullOrEmpty(filter.ToEdad))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad))
                    where += " AND Modulo_de_Atencion_Inicial.Edad >= " + filter.FromEdad;
                if (!string.IsNullOrEmpty(filter.ToEdad))
                    where += " AND Modulo_de_Atencion_Inicial.Edad <= " + filter.ToEdad;
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

                where += " AND Modulo_de_Atencion_Inicial.Sexo In (" + SexoIds + ")";
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

                where += " AND Modulo_de_Atencion_Inicial.Estado_Civil In (" + Estado_CivilIds + ")";
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

                where += " AND Modulo_de_Atencion_Inicial.Tipo_de_Identificacion In (" + Tipo_de_IdentificacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Identificacion))
            {
                switch (filter.Numero_de_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_de_Identificacion LIKE '" + filter.Numero_de_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_de_Identificacion = '" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "%'";
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

                where += " AND Modulo_de_Atencion_Inicial.Nacionalidad In (" + NacionalidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEscolaridad))
            {
                switch (filter.EscolaridadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Escolaridad.Descripcion LIKE '" + filter.AdvanceEscolaridad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Escolaridad.Descripcion = '" + filter.AdvanceEscolaridad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEscolaridadMultiple != null && filter.AdvanceEscolaridadMultiple.Count() > 0)
            {
                var EscolaridadIds = string.Join(",", filter.AdvanceEscolaridadMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Escolaridad In (" + EscolaridadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceOcupacion))
            {
                switch (filter.OcupacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Ocupacion.Descripcion LIKE '" + filter.AdvanceOcupacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Ocupacion.Descripcion LIKE '%" + filter.AdvanceOcupacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Ocupacion.Descripcion = '" + filter.AdvanceOcupacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Ocupacion.Descripcion LIKE '%" + filter.AdvanceOcupacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceOcupacionMultiple != null && filter.AdvanceOcupacionMultiple.Count() > 0)
            {
                var OcupacionIds = string.Join(",", filter.AdvanceOcupacionMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Ocupacion In (" + OcupacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Calle))
            {
                switch (filter.CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Calle LIKE '" + filter.Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Calle LIKE '%" + filter.Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Calle = '" + filter.Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Calle LIKE '%" + filter.Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromNumero_Exterior) || !string.IsNullOrEmpty(filter.ToNumero_Exterior))
            {
                if (!string.IsNullOrEmpty(filter.FromNumero_Exterior))
                    where += " AND Modulo_de_Atencion_Inicial.Numero_Exterior >= " + filter.FromNumero_Exterior;
                if (!string.IsNullOrEmpty(filter.ToNumero_Exterior))
                    where += " AND Modulo_de_Atencion_Inicial.Numero_Exterior <= " + filter.ToNumero_Exterior;
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior))
            {
                switch (filter.Numero_InteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_Interior LIKE '" + filter.Numero_Interior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_Interior LIKE '%" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_Interior = '" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_Interior LIKE '%" + filter.Numero_Interior + "%'";
                        break;
                }
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

                where += " AND Modulo_de_Atencion_Inicial.Colonia In (" + ColoniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal) || !string.IsNullOrEmpty(filter.ToCodigo_Postal))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal))
                    where += " AND Modulo_de_Atencion_Inicial.Codigo_Postal >= " + filter.FromCodigo_Postal;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal))
                    where += " AND Modulo_de_Atencion_Inicial.Codigo_Postal <= " + filter.ToCodigo_Postal;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceZona))
            {
                switch (filter.ZonaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Zona.Descripcion LIKE '" + filter.AdvanceZona + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Zona.Descripcion LIKE '%" + filter.AdvanceZona + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Zona.Descripcion = '" + filter.AdvanceZona + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Zona.Descripcion LIKE '%" + filter.AdvanceZona + "%'";
                        break;
                }
            }
            else if (filter.AdvanceZonaMultiple != null && filter.AdvanceZonaMultiple.Count() > 0)
            {
                var ZonaIds = string.Join(",", filter.AdvanceZonaMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Zona In (" + ZonaIds + ")";
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

                where += " AND Modulo_de_Atencion_Inicial.Municipio In (" + MunicipioIds + ")";
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

                where += " AND Modulo_de_Atencion_Inicial.Estado In (" + EstadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Telefono))
            {
                switch (filter.TelefonoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Telefono LIKE '" + filter.Telefono + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Telefono LIKE '%" + filter.Telefono + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Telefono = '" + filter.Telefono + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Telefono LIKE '%" + filter.Telefono + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Celular))
            {
                switch (filter.CelularFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Celular LIKE '" + filter.Celular + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Celular LIKE '%" + filter.Celular + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Celular = '" + filter.Celular + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Celular LIKE '%" + filter.Celular + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Electronico))
            {
                switch (filter.Correo_ElectronicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Correo_Electronico LIKE '" + filter.Correo_Electronico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Correo_Electronico = '" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "%'";
                        break;
                }
            }

            if (filter.Menor_de_Edad != RadioOptions.NoApply)
                where += " AND Modulo_de_Atencion_Inicial.Menor_de_Edad = " + Convert.ToInt32(filter.Menor_de_Edad);

            if (filter.Representante_Legal != RadioOptions.NoApply)
                where += " AND Modulo_de_Atencion_Inicial.Representante_Legal = " + Convert.ToInt32(filter.Representante_Legal);

            if (!string.IsNullOrEmpty(filter.Nombre_del_Tutor))
            {
                switch (filter.Nombre_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Nombre_del_Tutor LIKE '" + filter.Nombre_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Nombre_del_Tutor LIKE '%" + filter.Nombre_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Nombre_del_Tutor = '" + filter.Nombre_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Nombre_del_Tutor LIKE '%" + filter.Nombre_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno_del_Tutor))
            {
                switch (filter.Apellido_Paterno_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Paterno_del_Tutor LIKE '" + filter.Apellido_Paterno_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Paterno_del_Tutor LIKE '%" + filter.Apellido_Paterno_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Paterno_del_Tutor = '" + filter.Apellido_Paterno_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Paterno_del_Tutor LIKE '%" + filter.Apellido_Paterno_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno_del_Tutor))
            {
                switch (filter.Apellido_Materno_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Materno_del_Tutor LIKE '" + filter.Apellido_Materno_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Materno_del_Tutor LIKE '%" + filter.Apellido_Materno_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Materno_del_Tutor = '" + filter.Apellido_Materno_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Materno_del_Tutor LIKE '%" + filter.Apellido_Materno_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Nacimiento_del_Tutor) || !string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento_del_Tutor))
            {
                var Fecha_de_Nacimiento_del_TutorFrom = DateTime.ParseExact(filter.FromFecha_de_Nacimiento_del_Tutor, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Nacimiento_del_TutorTo = DateTime.ParseExact(filter.ToFecha_de_Nacimiento_del_Tutor, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Nacimiento_del_Tutor))
                    where += " AND Modulo_de_Atencion_Inicial.Fecha_de_Nacimiento_del_Tutor >= '" + Fecha_de_Nacimiento_del_TutorFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento_del_Tutor))
                    where += " AND Modulo_de_Atencion_Inicial.Fecha_de_Nacimiento_del_Tutor <= '" + Fecha_de_Nacimiento_del_TutorTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromEdad_del_Tutor) || !string.IsNullOrEmpty(filter.ToEdad_del_Tutor))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad_del_Tutor))
                    where += " AND Modulo_de_Atencion_Inicial.Edad_del_Tutor >= " + filter.FromEdad_del_Tutor;
                if (!string.IsNullOrEmpty(filter.ToEdad_del_Tutor))
                    where += " AND Modulo_de_Atencion_Inicial.Edad_del_Tutor <= " + filter.ToEdad_del_Tutor;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSexo_del_Tutor))
            {
                switch (filter.Sexo_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Genero.Descripcion LIKE '" + filter.AdvanceSexo_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Genero.Descripcion = '" + filter.AdvanceSexo_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSexo_del_TutorMultiple != null && filter.AdvanceSexo_del_TutorMultiple.Count() > 0)
            {
                var Sexo_del_TutorIds = string.Join(",", filter.AdvanceSexo_del_TutorMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Sexo_del_Tutor In (" + Sexo_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_Civil_del_Tutor))
            {
                switch (filter.Estado_Civil_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado_Civil.Descripcion LIKE '" + filter.AdvanceEstado_Civil_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado_Civil.Descripcion LIKE '%" + filter.AdvanceEstado_Civil_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado_Civil.Descripcion = '" + filter.AdvanceEstado_Civil_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado_Civil.Descripcion LIKE '%" + filter.AdvanceEstado_Civil_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_Civil_del_TutorMultiple != null && filter.AdvanceEstado_Civil_del_TutorMultiple.Count() > 0)
            {
                var Estado_Civil_del_TutorIds = string.Join(",", filter.AdvanceEstado_Civil_del_TutorMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Estado_Civil_del_Tutor In (" + Estado_Civil_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Identificacion_del_Tutor))
            {
                switch (filter.Tipo_de_Identificacion_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '" + filter.AdvanceTipo_de_Identificacion_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Identificacion.Nombre = '" + filter.AdvanceTipo_de_Identificacion_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Identificacion_del_TutorMultiple != null && filter.AdvanceTipo_de_Identificacion_del_TutorMultiple.Count() > 0)
            {
                var Tipo_de_Identificacion_del_TutorIds = string.Join(",", filter.AdvanceTipo_de_Identificacion_del_TutorMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Tipo_de_Identificacion_del_Tutor In (" + Tipo_de_Identificacion_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Identificacion_del_Tutor))
            {
                switch (filter.Numero_de_Identificacion_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_de_Identificacion_del_Tutor LIKE '" + filter.Numero_de_Identificacion_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_de_Identificacion_del_Tutor LIKE '%" + filter.Numero_de_Identificacion_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_de_Identificacion_del_Tutor = '" + filter.Numero_de_Identificacion_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_de_Identificacion_del_Tutor LIKE '%" + filter.Numero_de_Identificacion_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNacionalidad_del_Tutor))
            {
                switch (filter.Nacionalidad_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '" + filter.AdvanceNacionalidad_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Nacionalidad.NacionalidadC = '" + filter.AdvanceNacionalidad_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNacionalidad_del_TutorMultiple != null && filter.AdvanceNacionalidad_del_TutorMultiple.Count() > 0)
            {
                var Nacionalidad_del_TutorIds = string.Join(",", filter.AdvanceNacionalidad_del_TutorMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Nacionalidad_del_Tutor In (" + Nacionalidad_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEscolaridad_del_Tutor))
            {
                switch (filter.Escolaridad_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Escolaridad.Descripcion LIKE '" + filter.AdvanceEscolaridad_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Escolaridad.Descripcion = '" + filter.AdvanceEscolaridad_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEscolaridad_del_TutorMultiple != null && filter.AdvanceEscolaridad_del_TutorMultiple.Count() > 0)
            {
                var Escolaridad_del_TutorIds = string.Join(",", filter.AdvanceEscolaridad_del_TutorMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Escolaridad_del_Tutor In (" + Escolaridad_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceOcupacion_del_Tutor))
            {
                switch (filter.Ocupacion_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Ocupacion.Descripcion LIKE '" + filter.AdvanceOcupacion_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Ocupacion.Descripcion LIKE '%" + filter.AdvanceOcupacion_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Ocupacion.Descripcion = '" + filter.AdvanceOcupacion_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Ocupacion.Descripcion LIKE '%" + filter.AdvanceOcupacion_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceOcupacion_del_TutorMultiple != null && filter.AdvanceOcupacion_del_TutorMultiple.Count() > 0)
            {
                var Ocupacion_del_TutorIds = string.Join(",", filter.AdvanceOcupacion_del_TutorMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Ocupacion_del_Tutor In (" + Ocupacion_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Calle_del_Tutor))
            {
                switch (filter.Calle_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Calle_del_Tutor LIKE '" + filter.Calle_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Calle_del_Tutor LIKE '%" + filter.Calle_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Calle_del_Tutor = '" + filter.Calle_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Calle_del_Tutor LIKE '%" + filter.Calle_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromNumero_Exterior_del_Tutor) || !string.IsNullOrEmpty(filter.ToNumero_Exterior_del_Tutor))
            {
                if (!string.IsNullOrEmpty(filter.FromNumero_Exterior_del_Tutor))
                    where += " AND Modulo_de_Atencion_Inicial.Numero_Exterior_del_Tutor >= " + filter.FromNumero_Exterior_del_Tutor;
                if (!string.IsNullOrEmpty(filter.ToNumero_Exterior_del_Tutor))
                    where += " AND Modulo_de_Atencion_Inicial.Numero_Exterior_del_Tutor <= " + filter.ToNumero_Exterior_del_Tutor;
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior_del_Tutor))
            {
                switch (filter.Numero_Interior_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_Interior_del_Tutor LIKE '" + filter.Numero_Interior_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_Interior_del_Tutor LIKE '%" + filter.Numero_Interior_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_Interior_del_Tutor = '" + filter.Numero_Interior_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_Interior_del_Tutor LIKE '%" + filter.Numero_Interior_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia_del_Tutor))
            {
                switch (filter.Colonia_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia_del_TutorMultiple != null && filter.AdvanceColonia_del_TutorMultiple.Count() > 0)
            {
                var Colonia_del_TutorIds = string.Join(",", filter.AdvanceColonia_del_TutorMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Colonia_del_Tutor In (" + Colonia_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_del_Tutor) || !string.IsNullOrEmpty(filter.ToCodigo_Postal_del_Tutor))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_del_Tutor))
                    where += " AND Modulo_de_Atencion_Inicial.Codigo_Postal_del_Tutor >= " + filter.FromCodigo_Postal_del_Tutor;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal_del_Tutor))
                    where += " AND Modulo_de_Atencion_Inicial.Codigo_Postal_del_Tutor <= " + filter.ToCodigo_Postal_del_Tutor;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceLocalidad_del_Tutor))
            {
                switch (filter.Localidad_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Localidad.Descripcion LIKE '" + filter.AdvanceLocalidad_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Localidad.Descripcion LIKE '%" + filter.AdvanceLocalidad_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Localidad.Descripcion = '" + filter.AdvanceLocalidad_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Localidad.Descripcion LIKE '%" + filter.AdvanceLocalidad_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceLocalidad_del_TutorMultiple != null && filter.AdvanceLocalidad_del_TutorMultiple.Count() > 0)
            {
                var Localidad_del_TutorIds = string.Join(",", filter.AdvanceLocalidad_del_TutorMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Localidad_del_Tutor In (" + Localidad_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_del_Tutor))
            {
                switch (filter.Municipio_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_del_TutorMultiple != null && filter.AdvanceMunicipio_del_TutorMultiple.Count() > 0)
            {
                var Municipio_del_TutorIds = string.Join(",", filter.AdvanceMunicipio_del_TutorMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Municipio_del_Tutor In (" + Municipio_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_del_Tutor))
            {
                switch (filter.Estado_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_del_Tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_del_TutorMultiple != null && filter.AdvanceEstado_del_TutorMultiple.Count() > 0)
            {
                var Estado_del_TutorIds = string.Join(",", filter.AdvanceEstado_del_TutorMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Estado_del_Tutor In (" + Estado_del_TutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Telefono_del_Tutor))
            {
                switch (filter.Telefono_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Telefono_del_Tutor LIKE '" + filter.Telefono_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Telefono_del_Tutor LIKE '%" + filter.Telefono_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Telefono_del_Tutor = '" + filter.Telefono_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Telefono_del_Tutor LIKE '%" + filter.Telefono_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Celular_del_Tutor))
            {
                switch (filter.Celular_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Celular_del_Tutor LIKE '" + filter.Celular_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Celular_del_Tutor LIKE '%" + filter.Celular_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Celular_del_Tutor = '" + filter.Celular_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Celular_del_Tutor LIKE '%" + filter.Celular_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Electronico_del_Tutor))
            {
                switch (filter.Correo_Electronico_del_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Correo_Electronico_del_Tutor LIKE '" + filter.Correo_Electronico_del_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Correo_Electronico_del_Tutor LIKE '%" + filter.Correo_Electronico_del_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Correo_Electronico_del_Tutor = '" + filter.Correo_Electronico_del_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Correo_Electronico_del_Tutor LIKE '%" + filter.Correo_Electronico_del_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_del_Representante))
            {
                switch (filter.Nombre_del_RepresentanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Nombre_del_Representante LIKE '" + filter.Nombre_del_Representante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Nombre_del_Representante LIKE '%" + filter.Nombre_del_Representante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Nombre_del_Representante = '" + filter.Nombre_del_Representante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Nombre_del_Representante LIKE '%" + filter.Nombre_del_Representante + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno_del_Representante))
            {
                switch (filter.Apellido_Paterno_del_RepresentanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Paterno_del_Representante LIKE '" + filter.Apellido_Paterno_del_Representante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Paterno_del_Representante LIKE '%" + filter.Apellido_Paterno_del_Representante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Paterno_del_Representante = '" + filter.Apellido_Paterno_del_Representante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Paterno_del_Representante LIKE '%" + filter.Apellido_Paterno_del_Representante + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno_del_Representante))
            {
                switch (filter.Apellido_Materno_del_RepresentanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Materno_del_Representante LIKE '" + filter.Apellido_Materno_del_Representante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Materno_del_Representante LIKE '%" + filter.Apellido_Materno_del_Representante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Materno_del_Representante = '" + filter.Apellido_Materno_del_Representante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Apellido_Materno_del_Representante LIKE '%" + filter.Apellido_Materno_del_Representante + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Calidad_Juridica))
            {
                switch (filter.Calidad_JuridicaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Calidad_Juridica LIKE '" + filter.Calidad_Juridica + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Calidad_Juridica LIKE '%" + filter.Calidad_Juridica + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Calidad_Juridica = '" + filter.Calidad_Juridica + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Calidad_Juridica LIKE '%" + filter.Calidad_Juridica + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Calle_del_Representante))
            {
                switch (filter.Calle_del_RepresentanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Calle_del_Representante LIKE '" + filter.Calle_del_Representante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Calle_del_Representante LIKE '%" + filter.Calle_del_Representante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Calle_del_Representante = '" + filter.Calle_del_Representante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Calle_del_Representante LIKE '%" + filter.Calle_del_Representante + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromNumero_Exterior_del_Representante) || !string.IsNullOrEmpty(filter.ToNumero_Exterior_del_Representante))
            {
                if (!string.IsNullOrEmpty(filter.FromNumero_Exterior_del_Representante))
                    where += " AND Modulo_de_Atencion_Inicial.Numero_Exterior_del_Representante >= " + filter.FromNumero_Exterior_del_Representante;
                if (!string.IsNullOrEmpty(filter.ToNumero_Exterior_del_Representante))
                    where += " AND Modulo_de_Atencion_Inicial.Numero_Exterior_del_Representante <= " + filter.ToNumero_Exterior_del_Representante;
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior_del_Representante))
            {
                switch (filter.Numero_Interior_del_RepresentanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_Interior_del_Representante LIKE '" + filter.Numero_Interior_del_Representante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_Interior_del_Representante LIKE '%" + filter.Numero_Interior_del_Representante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_Interior_del_Representante = '" + filter.Numero_Interior_del_Representante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Numero_Interior_del_Representante LIKE '%" + filter.Numero_Interior_del_Representante + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia_del_Representante))
            {
                switch (filter.Colonia_del_RepresentanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia_del_Representante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_del_Representante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia_del_Representante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_del_Representante + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia_del_RepresentanteMultiple != null && filter.AdvanceColonia_del_RepresentanteMultiple.Count() > 0)
            {
                var Colonia_del_RepresentanteIds = string.Join(",", filter.AdvanceColonia_del_RepresentanteMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Colonia_del_Representante In (" + Colonia_del_RepresentanteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceLocalidad_del_Representante))
            {
                switch (filter.Localidad_del_RepresentanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Localidad.Descripcion LIKE '" + filter.AdvanceLocalidad_del_Representante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Localidad.Descripcion LIKE '%" + filter.AdvanceLocalidad_del_Representante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Localidad.Descripcion = '" + filter.AdvanceLocalidad_del_Representante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Localidad.Descripcion LIKE '%" + filter.AdvanceLocalidad_del_Representante + "%'";
                        break;
                }
            }
            else if (filter.AdvanceLocalidad_del_RepresentanteMultiple != null && filter.AdvanceLocalidad_del_RepresentanteMultiple.Count() > 0)
            {
                var Localidad_del_RepresentanteIds = string.Join(",", filter.AdvanceLocalidad_del_RepresentanteMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Localidad_del_Representante In (" + Localidad_del_RepresentanteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_del_Representante))
            {
                switch (filter.Municipio_del_RepresentanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_del_Representante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_del_Representante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_del_Representante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_del_Representante + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_del_RepresentanteMultiple != null && filter.AdvanceMunicipio_del_RepresentanteMultiple.Count() > 0)
            {
                var Municipio_del_RepresentanteIds = string.Join(",", filter.AdvanceMunicipio_del_RepresentanteMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Municipio_del_Representante In (" + Municipio_del_RepresentanteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_del_Representante))
            {
                switch (filter.Estado_del_RepresentanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_del_Representante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_del_Representante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_del_Representante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_del_Representante + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_del_RepresentanteMultiple != null && filter.AdvanceEstado_del_RepresentanteMultiple.Count() > 0)
            {
                var Estado_del_RepresentanteIds = string.Join(",", filter.AdvanceEstado_del_RepresentanteMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Estado_del_Representante In (" + Estado_del_RepresentanteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Telefono_del_Representante))
            {
                switch (filter.Telefono_del_RepresentanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Telefono_del_Representante LIKE '" + filter.Telefono_del_Representante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Telefono_del_Representante LIKE '%" + filter.Telefono_del_Representante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Telefono_del_Representante = '" + filter.Telefono_del_Representante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Telefono_del_Representante LIKE '%" + filter.Telefono_del_Representante + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Celular_del_Representante))
            {
                switch (filter.Celular_del_RepresentanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Celular_del_Representante LIKE '" + filter.Celular_del_Representante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Celular_del_Representante LIKE '%" + filter.Celular_del_Representante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Celular_del_Representante = '" + filter.Celular_del_Representante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Celular_del_Representante LIKE '%" + filter.Celular_del_Representante + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Electronico_del_Representante))
            {
                switch (filter.Correo_Electronico_del_RepresentanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Correo_Electronico_del_Representante LIKE '" + filter.Correo_Electronico_del_Representante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Correo_Electronico_del_Representante LIKE '%" + filter.Correo_Electronico_del_Representante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Correo_Electronico_del_Representante = '" + filter.Correo_Electronico_del_Representante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Correo_Electronico_del_Representante LIKE '%" + filter.Correo_Electronico_del_Representante + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Narrativa))
            {
                switch (filter.NarrativaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_de_Atencion_Inicial.Narrativa LIKE '" + filter.Narrativa + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_de_Atencion_Inicial.Narrativa LIKE '%" + filter.Narrativa + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_de_Atencion_Inicial.Narrativa = '" + filter.Narrativa + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_de_Atencion_Inicial.Narrativa LIKE '%" + filter.Narrativa + "%'";
                        break;
                }
            }

            if (filter.Atencion_Medica != RadioOptions.NoApply)
                where += " AND Modulo_de_Atencion_Inicial.Atencion_Medica = " + Convert.ToInt32(filter.Atencion_Medica);

            if (filter.Atencion_Psicologica != RadioOptions.NoApply)
                where += " AND Modulo_de_Atencion_Inicial.Atencion_Psicologica = " + Convert.ToInt32(filter.Atencion_Psicologica);

            if (filter.Requiere_Traductor != RadioOptions.NoApply)
                where += " AND Modulo_de_Atencion_Inicial.Requiere_Traductor = " + Convert.ToInt32(filter.Requiere_Traductor);

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

                where += " AND Modulo_de_Atencion_Inicial.Tipo_de_Compareciente In (" + Tipo_de_ComparecienteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTurno_Asignado))
            {
                switch (filter.Turno_AsignadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Asignacion_de_Turnos.Numero_de_Turno LIKE '" + filter.AdvanceTurno_Asignado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Asignacion_de_Turnos.Numero_de_Turno LIKE '%" + filter.AdvanceTurno_Asignado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Asignacion_de_Turnos.Numero_de_Turno = '" + filter.AdvanceTurno_Asignado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Asignacion_de_Turnos.Numero_de_Turno LIKE '%" + filter.AdvanceTurno_Asignado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTurno_AsignadoMultiple != null && filter.AdvanceTurno_AsignadoMultiple.Count() > 0)
            {
                var Turno_AsignadoIds = string.Join(",", filter.AdvanceTurno_AsignadoMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Turno_Asignado In (" + Turno_AsignadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUnidad))
            {
                switch (filter.UnidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Unidad.Descripcion LIKE '" + filter.AdvanceUnidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.AdvanceUnidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Unidad.Descripcion = '" + filter.AdvanceUnidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.AdvanceUnidad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUnidadMultiple != null && filter.AdvanceUnidadMultiple.Count() > 0)
            {
                var UnidadIds = string.Join(",", filter.AdvanceUnidadMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Unidad In (" + UnidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_Caso))
            {
                switch (filter.Municipio_CasoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_Caso + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_Caso + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_Caso + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_Caso + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_CasoMultiple != null && filter.AdvanceMunicipio_CasoMultiple.Count() > 0)
            {
                var Municipio_CasoIds = string.Join(",", filter.AdvanceMunicipio_CasoMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Municipio_Caso In (" + Municipio_CasoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Denuncia))
            {
                switch (filter.Tipo_de_DenunciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '" + filter.AdvanceTipo_de_Denuncia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Denuncia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Denuncia.Descripcion = '" + filter.AdvanceTipo_de_Denuncia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Denuncia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_DenunciaMultiple != null && filter.AdvanceTipo_de_DenunciaMultiple.Count() > 0)
            {
                var Tipo_de_DenunciaIds = string.Join(",", filter.AdvanceTipo_de_DenunciaMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Tipo_de_Denuncia In (" + Tipo_de_DenunciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromNumero_de_Expediente) || !string.IsNullOrEmpty(filter.ToNumero_de_Expediente))
            {
                if (!string.IsNullOrEmpty(filter.FromNumero_de_Expediente))
                    where += " AND Modulo_de_Atencion_Inicial.Numero_de_Expediente >= " + filter.FromNumero_de_Expediente;
                if (!string.IsNullOrEmpty(filter.ToNumero_de_Expediente))
                    where += " AND Modulo_de_Atencion_Inicial.Numero_de_Expediente <= " + filter.ToNumero_de_Expediente;
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

                where += " AND Modulo_de_Atencion_Inicial.Poblacion In (" + PoblacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia_Hechos_MPO))
            {
                switch (filter.Colonia_Hechos_MPOFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia_Hechos_MPO + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_Hechos_MPO + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia_Hechos_MPO + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_Hechos_MPO + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia_Hechos_MPOMultiple != null && filter.AdvanceColonia_Hechos_MPOMultiple.Count() > 0)
            {
                var Colonia_Hechos_MPOIds = string.Join(",", filter.AdvanceColonia_Hechos_MPOMultiple);

                where += " AND Modulo_de_Atencion_Inicial.Colonia_Hechos_MPO In (" + Colonia_Hechos_MPOIds + ")";
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
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

                Modulo_de_Atencion_Inicial varModulo_de_Atencion_Inicial = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IModulo_de_Atencion_InicialApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Modulo_de_Atencion_InicialModel varModulo_de_Atencion_Inicial)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Modulo_de_Atencion_InicialInfo = new Modulo_de_Atencion_Inicial
                    {
                        Folio = varModulo_de_Atencion_Inicial.Folio
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varModulo_de_Atencion_Inicial.Fecha_de_Registro)) ? DateTime.ParseExact(varModulo_de_Atencion_Inicial.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varModulo_de_Atencion_Inicial.Hora_de_Registro
                        ,NUAT = varModulo_de_Atencion_Inicial.NUAT
                        ,Usuario_que_Registra = varModulo_de_Atencion_Inicial.Usuario_que_Registra
                        ,Nombre = varModulo_de_Atencion_Inicial.Nombre
                        ,Apellido_Paterno = varModulo_de_Atencion_Inicial.Apellido_Paterno
                        ,Apellido_Materno = varModulo_de_Atencion_Inicial.Apellido_Materno
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varModulo_de_Atencion_Inicial.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varModulo_de_Atencion_Inicial.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varModulo_de_Atencion_Inicial.Edad
                        ,Sexo = varModulo_de_Atencion_Inicial.Sexo
                        ,Estado_Civil = varModulo_de_Atencion_Inicial.Estado_Civil
                        ,Tipo_de_Identificacion = varModulo_de_Atencion_Inicial.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varModulo_de_Atencion_Inicial.Numero_de_Identificacion
                        ,Nacionalidad = varModulo_de_Atencion_Inicial.Nacionalidad
                        ,Escolaridad = varModulo_de_Atencion_Inicial.Escolaridad
                        ,Ocupacion = varModulo_de_Atencion_Inicial.Ocupacion
                        ,Calle = varModulo_de_Atencion_Inicial.Calle
                        ,Numero_Exterior = varModulo_de_Atencion_Inicial.Numero_Exterior
                        ,Numero_Interior = varModulo_de_Atencion_Inicial.Numero_Interior
                        ,Colonia = varModulo_de_Atencion_Inicial.Colonia
                        ,Codigo_Postal = varModulo_de_Atencion_Inicial.Codigo_Postal
                        ,Zona = varModulo_de_Atencion_Inicial.Zona
                        ,Municipio = varModulo_de_Atencion_Inicial.Municipio
                        ,Estado = varModulo_de_Atencion_Inicial.Estado
                        ,Telefono = varModulo_de_Atencion_Inicial.Telefono
                        ,Celular = varModulo_de_Atencion_Inicial.Celular
                        ,Correo_Electronico = varModulo_de_Atencion_Inicial.Correo_Electronico
                        ,Menor_de_Edad = varModulo_de_Atencion_Inicial.Menor_de_Edad
                        ,Representante_Legal = varModulo_de_Atencion_Inicial.Representante_Legal
                        ,Nombre_del_Tutor = varModulo_de_Atencion_Inicial.Nombre_del_Tutor
                        ,Apellido_Paterno_del_Tutor = varModulo_de_Atencion_Inicial.Apellido_Paterno_del_Tutor
                        ,Apellido_Materno_del_Tutor = varModulo_de_Atencion_Inicial.Apellido_Materno_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (!String.IsNullOrEmpty(varModulo_de_Atencion_Inicial.Fecha_de_Nacimiento_del_Tutor)) ? DateTime.ParseExact(varModulo_de_Atencion_Inicial.Fecha_de_Nacimiento_del_Tutor, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad_del_Tutor = varModulo_de_Atencion_Inicial.Edad_del_Tutor
                        ,Sexo_del_Tutor = varModulo_de_Atencion_Inicial.Sexo_del_Tutor
                        ,Estado_Civil_del_Tutor = varModulo_de_Atencion_Inicial.Estado_Civil_del_Tutor
                        ,Tipo_de_Identificacion_del_Tutor = varModulo_de_Atencion_Inicial.Tipo_de_Identificacion_del_Tutor
                        ,Numero_de_Identificacion_del_Tutor = varModulo_de_Atencion_Inicial.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_Tutor = varModulo_de_Atencion_Inicial.Nacionalidad_del_Tutor
                        ,Escolaridad_del_Tutor = varModulo_de_Atencion_Inicial.Escolaridad_del_Tutor
                        ,Ocupacion_del_Tutor = varModulo_de_Atencion_Inicial.Ocupacion_del_Tutor
                        ,Calle_del_Tutor = varModulo_de_Atencion_Inicial.Calle_del_Tutor
                        ,Numero_Exterior_del_Tutor = varModulo_de_Atencion_Inicial.Numero_Exterior_del_Tutor
                        ,Numero_Interior_del_Tutor = varModulo_de_Atencion_Inicial.Numero_Interior_del_Tutor
                        ,Colonia_del_Tutor = varModulo_de_Atencion_Inicial.Colonia_del_Tutor
                        ,Codigo_Postal_del_Tutor = varModulo_de_Atencion_Inicial.Codigo_Postal_del_Tutor
                        ,Localidad_del_Tutor = varModulo_de_Atencion_Inicial.Localidad_del_Tutor
                        ,Municipio_del_Tutor = varModulo_de_Atencion_Inicial.Municipio_del_Tutor
                        ,Estado_del_Tutor = varModulo_de_Atencion_Inicial.Estado_del_Tutor
                        ,Telefono_del_Tutor = varModulo_de_Atencion_Inicial.Telefono_del_Tutor
                        ,Celular_del_Tutor = varModulo_de_Atencion_Inicial.Celular_del_Tutor
                        ,Correo_Electronico_del_Tutor = varModulo_de_Atencion_Inicial.Correo_Electronico_del_Tutor
                        ,Nombre_del_Representante = varModulo_de_Atencion_Inicial.Nombre_del_Representante
                        ,Apellido_Paterno_del_Representante = varModulo_de_Atencion_Inicial.Apellido_Paterno_del_Representante
                        ,Apellido_Materno_del_Representante = varModulo_de_Atencion_Inicial.Apellido_Materno_del_Representante
                        ,Calidad_Juridica = varModulo_de_Atencion_Inicial.Calidad_Juridica
                        ,Calle_del_Representante = varModulo_de_Atencion_Inicial.Calle_del_Representante
                        ,Numero_Exterior_del_Representante = varModulo_de_Atencion_Inicial.Numero_Exterior_del_Representante
                        ,Numero_Interior_del_Representante = varModulo_de_Atencion_Inicial.Numero_Interior_del_Representante
                        ,Colonia_del_Representante = varModulo_de_Atencion_Inicial.Colonia_del_Representante
                        ,Localidad_del_Representante = varModulo_de_Atencion_Inicial.Localidad_del_Representante
                        ,Municipio_del_Representante = varModulo_de_Atencion_Inicial.Municipio_del_Representante
                        ,Estado_del_Representante = varModulo_de_Atencion_Inicial.Estado_del_Representante
                        ,Telefono_del_Representante = varModulo_de_Atencion_Inicial.Telefono_del_Representante
                        ,Celular_del_Representante = varModulo_de_Atencion_Inicial.Celular_del_Representante
                        ,Correo_Electronico_del_Representante = varModulo_de_Atencion_Inicial.Correo_Electronico_del_Representante
                        ,Narrativa = varModulo_de_Atencion_Inicial.Narrativa
                        ,Atencion_Medica = varModulo_de_Atencion_Inicial.Atencion_Medica
                        ,Atencion_Psicologica = varModulo_de_Atencion_Inicial.Atencion_Psicologica
                        ,Requiere_Traductor = varModulo_de_Atencion_Inicial.Requiere_Traductor
                        ,Tipo_de_Compareciente = varModulo_de_Atencion_Inicial.Tipo_de_Compareciente
                        ,Estatus = varModulo_de_Atencion_Inicial.Estatus
                        ,Turno_Asignado = varModulo_de_Atencion_Inicial.Turno_Asignado
                        ,Unidad = varModulo_de_Atencion_Inicial.Unidad
                        ,Municipio_Caso = varModulo_de_Atencion_Inicial.Municipio_Caso
                        ,Tipo_de_Denuncia = varModulo_de_Atencion_Inicial.Tipo_de_Denuncia
                        ,Numero_de_Expediente = varModulo_de_Atencion_Inicial.Numero_de_Expediente
                        ,Poblacion = varModulo_de_Atencion_Inicial.Poblacion
                        ,Colonia_Hechos_MPO = varModulo_de_Atencion_Inicial.Colonia_Hechos_MPO

                    };

                    result = !IsNew ?
                        _IModulo_de_Atencion_InicialApiConsumer.Update(Modulo_de_Atencion_InicialInfo, null, null).Resource.ToString() :
                         _IModulo_de_Atencion_InicialApiConsumer.Insert(Modulo_de_Atencion_InicialInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Modulo_de_Atencion_Inicial script
        /// </summary>
        /// <param name="oModulo_de_Atencion_InicialElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Modulo_de_Atencion_InicialModuleAttributeList)
        {
            for (int i = 0; i < Modulo_de_Atencion_InicialModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Modulo_de_Atencion_InicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Modulo_de_Atencion_InicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Modulo_de_Atencion_InicialModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Modulo_de_Atencion_InicialModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Modulo_de_Atencion_InicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Modulo_de_Atencion_InicialModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Modulo_de_Atencion_InicialModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Modulo_de_Atencion_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Modulo_de_Atencion_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Modulo_de_Atencion_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Modulo_de_Atencion_InicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strModulo_de_Atencion_InicialScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Modulo_de_Atencion_Inicial.js")))
            {
                strModulo_de_Atencion_InicialScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Modulo_de_Atencion_Inicial element attributes
            string userChangeJson = jsSerialize.Serialize(Modulo_de_Atencion_InicialModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strModulo_de_Atencion_InicialScript.IndexOf("inpuElementArray");
            string splittedString = strModulo_de_Atencion_InicialScript.Substring(indexOfArray, strModulo_de_Atencion_InicialScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Modulo_de_Atencion_InicialModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Modulo_de_Atencion_InicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strModulo_de_Atencion_InicialScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strModulo_de_Atencion_InicialScript.Substring(indexOfArrayHistory, strModulo_de_Atencion_InicialScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strModulo_de_Atencion_InicialScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strModulo_de_Atencion_InicialScript.Substring(endIndexOfMainElement + indexOfArray, strModulo_de_Atencion_InicialScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Modulo_de_Atencion_InicialModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Modulo_de_Atencion_InicialModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Modulo_de_Atencion_Inicial.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Modulo_de_Atencion_Inicial.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Modulo_de_Atencion_Inicial.js")))
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
        public ActionResult Modulo_de_Atencion_InicialPropertyBag()
        {
            return PartialView("Modulo_de_Atencion_InicialPropertyBag", "Modulo_de_Atencion_Inicial");
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
                var whereClauseFormat = "Object = 44997 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Modulo_de_Atencion_Inicial.Folio= " + RecordId;
                            var result = _IModulo_de_Atencion_InicialApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Modulo_de_Atencion_InicialPropertyMapper());
			
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
                    (Modulo_de_Atencion_InicialAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Modulo_de_Atencion_InicialPropertyMapper oModulo_de_Atencion_InicialPropertyMapper = new Modulo_de_Atencion_InicialPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oModulo_de_Atencion_InicialPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IModulo_de_Atencion_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Modulo_de_Atencion_Inicials == null)
                result.Modulo_de_Atencion_Inicials = new List<Modulo_de_Atencion_Inicial>();

            var data = result.Modulo_de_Atencion_Inicials.Select(m => new Modulo_de_Atencion_InicialGridModel
            {
                Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
			,NUAT = m.NUAT
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Zona.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_Estado.Nombre
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Menor_de_Edad = m.Menor_de_Edad
			,Representante_Legal = m.Representante_Legal
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
                        ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Tutor_Localidad.Descripcion
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Tutor_Estado.Nombre
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
			,Nombre_del_Representante = m.Nombre_del_Representante
			,Apellido_Paterno_del_Representante = m.Apellido_Paterno_del_Representante
			,Apellido_Materno_del_Representante = m.Apellido_Materno_del_Representante
			,Calidad_Juridica = m.Calidad_Juridica
			,Calle_del_Representante = m.Calle_del_Representante
			,Numero_Exterior_del_Representante = m.Numero_Exterior_del_Representante
			,Numero_Interior_del_Representante = m.Numero_Interior_del_Representante
                        ,Colonia_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Colonia_del_Representante_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Representante_Colonia.Nombre
                        ,Localidad_del_RepresentanteDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Representante_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Representante_Localidad.Descripcion
                        ,Municipio_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Municipio_del_Representante_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Representante_Municipio.Nombre
                        ,Estado_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Estado_del_Representante_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Representante_Estado.Nombre
			,Telefono_del_Representante = m.Telefono_del_Representante
			,Celular_del_Representante = m.Celular_del_Representante
			,Correo_Electronico_del_Representante = m.Correo_Electronico_del_Representante
			,Narrativa = m.Narrativa
			,Atencion_Medica = m.Atencion_Medica
			,Atencion_Psicologica = m.Atencion_Psicologica
			,Requiere_Traductor = m.Requiere_Traductor
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus.Descripcion
                        ,Turno_AsignadoNumero_de_Turno = CultureHelper.GetTraduction(m.Turno_Asignado_Asignacion_de_Turnos.Folio.ToString(), "Numero_de_Turno") ?? (string)m.Turno_Asignado_Asignacion_de_Turnos.Numero_de_Turno
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,Municipio_CasoNombre = CultureHelper.GetTraduction(m.Municipio_Caso_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Caso_Municipio.Nombre
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
			,Numero_de_Expediente = m.Numero_de_Expediente
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia_Hechos_MPONombre = CultureHelper.GetTraduction(m.Colonia_Hechos_MPO_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Hechos_MPO_Colonia.Nombre

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(44997, arrayColumnsVisible), "Modulo_de_Atencion_InicialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(44997, arrayColumnsVisible), "Modulo_de_Atencion_InicialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(44997, arrayColumnsVisible), "Modulo_de_Atencion_InicialList_" + DateTime.Now.ToString());
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

            _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Modulo_de_Atencion_InicialPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Modulo_de_Atencion_InicialAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Modulo_de_Atencion_InicialPropertyMapper oModulo_de_Atencion_InicialPropertyMapper = new Modulo_de_Atencion_InicialPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oModulo_de_Atencion_InicialPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IModulo_de_Atencion_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Modulo_de_Atencion_Inicials == null)
                result.Modulo_de_Atencion_Inicials = new List<Modulo_de_Atencion_Inicial>();

            var data = result.Modulo_de_Atencion_Inicials.Select(m => new Modulo_de_Atencion_InicialGridModel
            {
                Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
			,NUAT = m.NUAT
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Zona.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_Estado.Nombre
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Menor_de_Edad = m.Menor_de_Edad
			,Representante_Legal = m.Representante_Legal
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
                        ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Tutor_Localidad.Descripcion
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Tutor_Estado.Nombre
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
			,Nombre_del_Representante = m.Nombre_del_Representante
			,Apellido_Paterno_del_Representante = m.Apellido_Paterno_del_Representante
			,Apellido_Materno_del_Representante = m.Apellido_Materno_del_Representante
			,Calidad_Juridica = m.Calidad_Juridica
			,Calle_del_Representante = m.Calle_del_Representante
			,Numero_Exterior_del_Representante = m.Numero_Exterior_del_Representante
			,Numero_Interior_del_Representante = m.Numero_Interior_del_Representante
                        ,Colonia_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Colonia_del_Representante_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Representante_Colonia.Nombre
                        ,Localidad_del_RepresentanteDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Representante_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Representante_Localidad.Descripcion
                        ,Municipio_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Municipio_del_Representante_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Representante_Municipio.Nombre
                        ,Estado_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Estado_del_Representante_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Representante_Estado.Nombre
			,Telefono_del_Representante = m.Telefono_del_Representante
			,Celular_del_Representante = m.Celular_del_Representante
			,Correo_Electronico_del_Representante = m.Correo_Electronico_del_Representante
			,Narrativa = m.Narrativa
			,Atencion_Medica = m.Atencion_Medica
			,Atencion_Psicologica = m.Atencion_Psicologica
			,Requiere_Traductor = m.Requiere_Traductor
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus.Descripcion
                        ,Turno_AsignadoNumero_de_Turno = CultureHelper.GetTraduction(m.Turno_Asignado_Asignacion_de_Turnos.Folio.ToString(), "Numero_de_Turno") ?? (string)m.Turno_Asignado_Asignacion_de_Turnos.Numero_de_Turno
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,Municipio_CasoNombre = CultureHelper.GetTraduction(m.Municipio_Caso_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Caso_Municipio.Nombre
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
			,Numero_de_Expediente = m.Numero_de_Expediente
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia_Hechos_MPONombre = CultureHelper.GetTraduction(m.Colonia_Hechos_MPO_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Hechos_MPO_Colonia.Nombre

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
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModulo_de_Atencion_InicialApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_del_Caso(Modulo_de_Atencion_Inicial_Datos_del_CasoModel varModulo_de_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_de_Atencion_Inicial_Datos_del_CasoInfo = new Modulo_de_Atencion_Inicial_Datos_del_Caso
                {
                    Folio = varModulo_de_Atencion_Inicial.Folio
                                            ,Fecha_de_Registro = (!String.IsNullOrEmpty(varModulo_de_Atencion_Inicial.Fecha_de_Registro)) ? DateTime.ParseExact(varModulo_de_Atencion_Inicial.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varModulo_de_Atencion_Inicial.Hora_de_Registro
                        ,NUAT = varModulo_de_Atencion_Inicial.NUAT
                        ,Usuario_que_Registra = varModulo_de_Atencion_Inicial.Usuario_que_Registra
                        ,Estatus = varModulo_de_Atencion_Inicial.Estatus
                        ,Turno_Asignado = varModulo_de_Atencion_Inicial.Turno_Asignado
                        ,Unidad = varModulo_de_Atencion_Inicial.Unidad
                        ,Municipio_Caso = varModulo_de_Atencion_Inicial.Municipio_Caso
                        ,Tipo_de_Denuncia = varModulo_de_Atencion_Inicial.Tipo_de_Denuncia
                        ,Numero_de_Expediente = varModulo_de_Atencion_Inicial.Numero_de_Expediente
                    
                };

                result = _IModulo_de_Atencion_InicialApiConsumer.Update_Datos_del_Caso(Modulo_de_Atencion_Inicial_Datos_del_CasoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Caso(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_de_Atencion_InicialApiConsumer.Get_Datos_del_Caso(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Modulo_de_Atencion_Inicial_Datos_del_CasoModel
                {
                    Folio = m.Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
			,NUAT = m.NUAT
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus.Descripcion
                        ,Turno_Asignado = m.Turno_Asignado
                        ,Turno_AsignadoNumero_de_Turno = CultureHelper.GetTraduction(m.Turno_Asignado_Asignacion_de_Turnos.Folio.ToString(), "Numero_de_Turno") ?? (string)m.Turno_Asignado_Asignacion_de_Turnos.Numero_de_Turno
                        ,Unidad = m.Unidad
                        ,UnidadDescripcion = CultureHelper.GetTraduction(m.Unidad_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_Unidad.Descripcion
                        ,Municipio_Caso = m.Municipio_Caso
                        ,Municipio_CasoNombre = CultureHelper.GetTraduction(m.Municipio_Caso_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Caso_Municipio.Nombre
                        ,Tipo_de_Denuncia = m.Tipo_de_Denuncia
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
			,Numero_de_Expediente = m.Numero_de_Expediente

                    
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
        public ActionResult Post_Datos_Generales(Modulo_de_Atencion_Inicial_Datos_GeneralesModel varModulo_de_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_de_Atencion_Inicial_Datos_GeneralesInfo = new Modulo_de_Atencion_Inicial_Datos_Generales
                {
                    Folio = varModulo_de_Atencion_Inicial.Folio
                                            ,Nombre = varModulo_de_Atencion_Inicial.Nombre
                        ,Apellido_Paterno = varModulo_de_Atencion_Inicial.Apellido_Paterno
                        ,Apellido_Materno = varModulo_de_Atencion_Inicial.Apellido_Materno
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varModulo_de_Atencion_Inicial.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varModulo_de_Atencion_Inicial.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varModulo_de_Atencion_Inicial.Edad
                        ,Sexo = varModulo_de_Atencion_Inicial.Sexo
                        ,Estado_Civil = varModulo_de_Atencion_Inicial.Estado_Civil
                        ,Tipo_de_Identificacion = varModulo_de_Atencion_Inicial.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varModulo_de_Atencion_Inicial.Numero_de_Identificacion
                        ,Nacionalidad = varModulo_de_Atencion_Inicial.Nacionalidad
                        ,Escolaridad = varModulo_de_Atencion_Inicial.Escolaridad
                        ,Ocupacion = varModulo_de_Atencion_Inicial.Ocupacion
                        ,Calle = varModulo_de_Atencion_Inicial.Calle
                        ,Numero_Exterior = varModulo_de_Atencion_Inicial.Numero_Exterior
                        ,Numero_Interior = varModulo_de_Atencion_Inicial.Numero_Interior
                        ,Colonia = varModulo_de_Atencion_Inicial.Colonia
                        ,Codigo_Postal = varModulo_de_Atencion_Inicial.Codigo_Postal
                        ,Zona = varModulo_de_Atencion_Inicial.Zona
                        ,Municipio = varModulo_de_Atencion_Inicial.Municipio
                        ,Estado = varModulo_de_Atencion_Inicial.Estado
                        ,Telefono = varModulo_de_Atencion_Inicial.Telefono
                        ,Celular = varModulo_de_Atencion_Inicial.Celular
                        ,Correo_Electronico = varModulo_de_Atencion_Inicial.Correo_Electronico
                        ,Menor_de_Edad = varModulo_de_Atencion_Inicial.Menor_de_Edad
                        ,Representante_Legal = varModulo_de_Atencion_Inicial.Representante_Legal
                    
                };

                result = _IModulo_de_Atencion_InicialApiConsumer.Update_Datos_Generales(Modulo_de_Atencion_Inicial_Datos_GeneralesInfo).Resource.ToString();
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
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_de_Atencion_InicialApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Modulo_de_Atencion_Inicial_Datos_GeneralesModel
                {
                    Folio = m.Folio
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,Escolaridad = m.Escolaridad
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,Zona = m.Zona
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Zona.Descripcion
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_Estado.Nombre
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Menor_de_Edad = m.Menor_de_Edad
			,Representante_Legal = m.Representante_Legal

                    
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
        public ActionResult Post_Datos_del_Tutor(Modulo_de_Atencion_Inicial_Datos_del_TutorModel varModulo_de_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_de_Atencion_Inicial_Datos_del_TutorInfo = new Modulo_de_Atencion_Inicial_Datos_del_Tutor
                {
                    Folio = varModulo_de_Atencion_Inicial.Folio
                                            ,Nombre_del_Tutor = varModulo_de_Atencion_Inicial.Nombre_del_Tutor
                        ,Apellido_Paterno_del_Tutor = varModulo_de_Atencion_Inicial.Apellido_Paterno_del_Tutor
                        ,Apellido_Materno_del_Tutor = varModulo_de_Atencion_Inicial.Apellido_Materno_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (!String.IsNullOrEmpty(varModulo_de_Atencion_Inicial.Fecha_de_Nacimiento_del_Tutor)) ? DateTime.ParseExact(varModulo_de_Atencion_Inicial.Fecha_de_Nacimiento_del_Tutor, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad_del_Tutor = varModulo_de_Atencion_Inicial.Edad_del_Tutor
                        ,Sexo_del_Tutor = varModulo_de_Atencion_Inicial.Sexo_del_Tutor
                        ,Estado_Civil_del_Tutor = varModulo_de_Atencion_Inicial.Estado_Civil_del_Tutor
                        ,Tipo_de_Identificacion_del_Tutor = varModulo_de_Atencion_Inicial.Tipo_de_Identificacion_del_Tutor
                        ,Numero_de_Identificacion_del_Tutor = varModulo_de_Atencion_Inicial.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_Tutor = varModulo_de_Atencion_Inicial.Nacionalidad_del_Tutor
                        ,Escolaridad_del_Tutor = varModulo_de_Atencion_Inicial.Escolaridad_del_Tutor
                        ,Ocupacion_del_Tutor = varModulo_de_Atencion_Inicial.Ocupacion_del_Tutor
                        ,Calle_del_Tutor = varModulo_de_Atencion_Inicial.Calle_del_Tutor
                        ,Numero_Exterior_del_Tutor = varModulo_de_Atencion_Inicial.Numero_Exterior_del_Tutor
                        ,Numero_Interior_del_Tutor = varModulo_de_Atencion_Inicial.Numero_Interior_del_Tutor
                        ,Colonia_del_Tutor = varModulo_de_Atencion_Inicial.Colonia_del_Tutor
                        ,Codigo_Postal_del_Tutor = varModulo_de_Atencion_Inicial.Codigo_Postal_del_Tutor
                        ,Localidad_del_Tutor = varModulo_de_Atencion_Inicial.Localidad_del_Tutor
                        ,Municipio_del_Tutor = varModulo_de_Atencion_Inicial.Municipio_del_Tutor
                        ,Estado_del_Tutor = varModulo_de_Atencion_Inicial.Estado_del_Tutor
                        ,Telefono_del_Tutor = varModulo_de_Atencion_Inicial.Telefono_del_Tutor
                        ,Celular_del_Tutor = varModulo_de_Atencion_Inicial.Celular_del_Tutor
                        ,Correo_Electronico_del_Tutor = varModulo_de_Atencion_Inicial.Correo_Electronico_del_Tutor
                    
                };

                result = _IModulo_de_Atencion_InicialApiConsumer.Update_Datos_del_Tutor(Modulo_de_Atencion_Inicial_Datos_del_TutorInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Tutor(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_de_Atencion_InicialApiConsumer.Get_Datos_del_Tutor(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Modulo_de_Atencion_Inicial_Datos_del_TutorModel
                {
                    Folio = m.Folio
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_Tutor = m.Sexo_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_Tutor = m.Estado_Civil_del_Tutor
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_Tutor = m.Tipo_de_Identificacion_del_Tutor
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_Tutor = m.Nacionalidad_del_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_Tutor = m.Escolaridad_del_Tutor
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_Tutor = m.Ocupacion_del_Tutor
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
                        ,Colonia_del_Tutor = m.Colonia_del_Tutor
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
                        ,Localidad_del_Tutor = m.Localidad_del_Tutor
                        ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Tutor_Localidad.Descripcion
                        ,Municipio_del_Tutor = m.Municipio_del_Tutor
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Estado_del_Tutor = m.Estado_del_Tutor
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Tutor_Estado.Nombre
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor

                    
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
        public ActionResult Post_Datos_del_Representante_Legal(Modulo_de_Atencion_Inicial_Datos_del_Representante_LegalModel varModulo_de_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_de_Atencion_Inicial_Datos_del_Representante_LegalInfo = new Modulo_de_Atencion_Inicial_Datos_del_Representante_Legal
                {
                    Folio = varModulo_de_Atencion_Inicial.Folio
                                            ,Nombre_del_Representante = varModulo_de_Atencion_Inicial.Nombre_del_Representante
                        ,Apellido_Paterno_del_Representante = varModulo_de_Atencion_Inicial.Apellido_Paterno_del_Representante
                        ,Apellido_Materno_del_Representante = varModulo_de_Atencion_Inicial.Apellido_Materno_del_Representante
                        ,Calidad_Juridica = varModulo_de_Atencion_Inicial.Calidad_Juridica
                        ,Calle_del_Representante = varModulo_de_Atencion_Inicial.Calle_del_Representante
                        ,Numero_Exterior_del_Representante = varModulo_de_Atencion_Inicial.Numero_Exterior_del_Representante
                        ,Numero_Interior_del_Representante = varModulo_de_Atencion_Inicial.Numero_Interior_del_Representante
                        ,Colonia_del_Representante = varModulo_de_Atencion_Inicial.Colonia_del_Representante
                        ,Localidad_del_Representante = varModulo_de_Atencion_Inicial.Localidad_del_Representante
                        ,Municipio_del_Representante = varModulo_de_Atencion_Inicial.Municipio_del_Representante
                        ,Estado_del_Representante = varModulo_de_Atencion_Inicial.Estado_del_Representante
                        ,Telefono_del_Representante = varModulo_de_Atencion_Inicial.Telefono_del_Representante
                        ,Celular_del_Representante = varModulo_de_Atencion_Inicial.Celular_del_Representante
                        ,Correo_Electronico_del_Representante = varModulo_de_Atencion_Inicial.Correo_Electronico_del_Representante
                    
                };

                result = _IModulo_de_Atencion_InicialApiConsumer.Update_Datos_del_Representante_Legal(Modulo_de_Atencion_Inicial_Datos_del_Representante_LegalInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Representante_Legal(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_de_Atencion_InicialApiConsumer.Get_Datos_del_Representante_Legal(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Modulo_de_Atencion_Inicial_Datos_del_Representante_LegalModel
                {
                    Folio = m.Folio
			,Nombre_del_Representante = m.Nombre_del_Representante
			,Apellido_Paterno_del_Representante = m.Apellido_Paterno_del_Representante
			,Apellido_Materno_del_Representante = m.Apellido_Materno_del_Representante
			,Calidad_Juridica = m.Calidad_Juridica
			,Calle_del_Representante = m.Calle_del_Representante
			,Numero_Exterior_del_Representante = m.Numero_Exterior_del_Representante
			,Numero_Interior_del_Representante = m.Numero_Interior_del_Representante
                        ,Colonia_del_Representante = m.Colonia_del_Representante
                        ,Colonia_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Colonia_del_Representante_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Representante_Colonia.Nombre
                        ,Localidad_del_Representante = m.Localidad_del_Representante
                        ,Localidad_del_RepresentanteDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Representante_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Representante_Localidad.Descripcion
                        ,Municipio_del_Representante = m.Municipio_del_Representante
                        ,Municipio_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Municipio_del_Representante_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Representante_Municipio.Nombre
                        ,Estado_del_Representante = m.Estado_del_Representante
                        ,Estado_del_RepresentanteNombre = CultureHelper.GetTraduction(m.Estado_del_Representante_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Representante_Estado.Nombre
			,Telefono_del_Representante = m.Telefono_del_Representante
			,Celular_del_Representante = m.Celular_del_Representante
			,Correo_Electronico_del_Representante = m.Correo_Electronico_del_Representante

                    
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
        public ActionResult Post_Datos_de_los_Hechos(Modulo_de_Atencion_Inicial_Datos_de_los_HechosModel varModulo_de_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_de_Atencion_Inicial_Datos_de_los_HechosInfo = new Modulo_de_Atencion_Inicial_Datos_de_los_Hechos
                {
                    Folio = varModulo_de_Atencion_Inicial.Folio
                                            ,Narrativa = varModulo_de_Atencion_Inicial.Narrativa
                    
                };

                result = _IModulo_de_Atencion_InicialApiConsumer.Update_Datos_de_los_Hechos(Modulo_de_Atencion_Inicial_Datos_de_los_HechosInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_los_Hechos(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_de_Atencion_InicialApiConsumer.Get_Datos_de_los_Hechos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Modulo_de_Atencion_Inicial_Datos_de_los_HechosModel
                {
                    Folio = m.Folio
			,Narrativa = m.Narrativa

                    
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
        public ActionResult Post_Datos_de_Servicios_de_Apoyo(Modulo_de_Atencion_Inicial_Datos_de_Servicios_de_ApoyoModel varModulo_de_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_de_Atencion_Inicial_Datos_de_Servicios_de_ApoyoInfo = new Modulo_de_Atencion_Inicial_Datos_de_Servicios_de_Apoyo
                {
                    Folio = varModulo_de_Atencion_Inicial.Folio
                                            ,Atencion_Medica = varModulo_de_Atencion_Inicial.Atencion_Medica
                        ,Atencion_Psicologica = varModulo_de_Atencion_Inicial.Atencion_Psicologica
                    
                };

                result = _IModulo_de_Atencion_InicialApiConsumer.Update_Datos_de_Servicios_de_Apoyo(Modulo_de_Atencion_Inicial_Datos_de_Servicios_de_ApoyoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_Servicios_de_Apoyo(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_de_Atencion_InicialApiConsumer.Get_Datos_de_Servicios_de_Apoyo(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Modulo_de_Atencion_Inicial_Datos_de_Servicios_de_ApoyoModel
                {
                    Folio = m.Folio
			,Atencion_Medica = m.Atencion_Medica
			,Atencion_Psicologica = m.Atencion_Psicologica

                    
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
        public ActionResult Post_Servicios_de_Apoyo(Modulo_de_Atencion_Inicial_Servicios_de_ApoyoModel varModulo_de_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_de_Atencion_Inicial_Servicios_de_ApoyoInfo = new Modulo_de_Atencion_Inicial_Servicios_de_Apoyo
                {
                    Folio = varModulo_de_Atencion_Inicial.Folio
                                            ,Requiere_Traductor = varModulo_de_Atencion_Inicial.Requiere_Traductor
                    
                };

                result = _IModulo_de_Atencion_InicialApiConsumer.Update_Servicios_de_Apoyo(Modulo_de_Atencion_Inicial_Servicios_de_ApoyoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Servicios_de_Apoyo(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_de_Atencion_InicialApiConsumer.Get_Servicios_de_Apoyo(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Modulo_de_Atencion_Inicial_Servicios_de_ApoyoModel
                {
                    Folio = m.Folio
			,Requiere_Traductor = m.Requiere_Traductor

                    
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
        public ActionResult Post_Tipo_de_Compareciente(Modulo_de_Atencion_Inicial_Tipo_de_ComparecienteModel varModulo_de_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_de_Atencion_Inicial_Tipo_de_ComparecienteInfo = new Modulo_de_Atencion_Inicial_Tipo_de_Compareciente
                {
                    Folio = varModulo_de_Atencion_Inicial.Folio
                                            ,Tipo_de_Compareciente = varModulo_de_Atencion_Inicial.Tipo_de_Compareciente
                    
                };

                result = _IModulo_de_Atencion_InicialApiConsumer.Update_Tipo_de_Compareciente(Modulo_de_Atencion_Inicial_Tipo_de_ComparecienteInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Tipo_de_Compareciente(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_de_Atencion_InicialApiConsumer.Get_Tipo_de_Compareciente(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Modulo_de_Atencion_Inicial_Tipo_de_ComparecienteModel
                {
                    Folio = m.Folio
                        ,Tipo_de_Compareciente = m.Tipo_de_Compareciente
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion

                    
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
        public ActionResult Post_Datos_de_los_Hechos_en_MPO(Modulo_de_Atencion_Inicial_Datos_de_los_Hechos_en_MPOModel varModulo_de_Atencion_Inicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_de_Atencion_Inicial_Datos_de_los_Hechos_en_MPOInfo = new Modulo_de_Atencion_Inicial_Datos_de_los_Hechos_en_MPO
                {
                    Folio = varModulo_de_Atencion_Inicial.Folio
                                            ,Poblacion = varModulo_de_Atencion_Inicial.Poblacion
                        ,Colonia_Hechos_MPO = varModulo_de_Atencion_Inicial.Colonia_Hechos_MPO
                    
                };

                result = _IModulo_de_Atencion_InicialApiConsumer.Update_Datos_de_los_Hechos_en_MPO(Modulo_de_Atencion_Inicial_Datos_de_los_Hechos_en_MPOInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_los_Hechos_en_MPO(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_de_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_de_Atencion_InicialApiConsumer.Get_Datos_de_los_Hechos_en_MPO(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Modulo_de_Atencion_Inicial_Datos_de_los_Hechos_en_MPOModel
                {
                    Folio = m.Folio
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia_Hechos_MPO = m.Colonia_Hechos_MPO
                        ,Colonia_Hechos_MPONombre = CultureHelper.GetTraduction(m.Colonia_Hechos_MPO_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Hechos_MPO_Colonia.Nombre

                    
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

