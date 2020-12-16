using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Tipo_de_Inimputabilidad;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Localidad;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Solicitud_Solicitante;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Solicitante;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Inimputabilidad;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Localidad;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
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
    public class Detalle_de_Solicitud_SolicitanteController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Solicitud_SolicitanteService service = null;
        private IDetalle_de_Solicitud_SolicitanteApiConsumer _IDetalle_de_Solicitud_SolicitanteApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private IGeneroApiConsumer _IGeneroApiConsumer;
        private IEstado_CivilApiConsumer _IEstado_CivilApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private INacionalidadApiConsumer _INacionalidadApiConsumer;
        private IEscolaridadApiConsumer _IEscolaridadApiConsumer;
        private IOcupacionApiConsumer _IOcupacionApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private ITipo_de_ComparecienteApiConsumer _ITipo_de_ComparecienteApiConsumer;
        private ITipo_de_InimputabilidadApiConsumer _ITipo_de_InimputabilidadApiConsumer;
        private ILocalidadApiConsumer _ILocalidadApiConsumer;
        private ILugar_TipoApiConsumer _ILugar_TipoApiConsumer;

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

        
        public Detalle_de_Solicitud_SolicitanteController(IDetalle_de_Solicitud_SolicitanteService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Solicitud_SolicitanteApiConsumer Detalle_de_Solicitud_SolicitanteApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IEscolaridadApiConsumer EscolaridadApiConsumer , IOcupacionApiConsumer OcupacionApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , ITipo_de_ComparecienteApiConsumer Tipo_de_ComparecienteApiConsumer , ITipo_de_InimputabilidadApiConsumer Tipo_de_InimputabilidadApiConsumer , ILocalidadApiConsumer LocalidadApiConsumer , ILugar_TipoApiConsumer Lugar_TipoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Solicitud_SolicitanteApiConsumer = Detalle_de_Solicitud_SolicitanteApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ISolicitudApiConsumer = SolicitudApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._ITipo_de_ComparecienteApiConsumer = Tipo_de_ComparecienteApiConsumer;
            this._ITipo_de_InimputabilidadApiConsumer = Tipo_de_InimputabilidadApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._ILocalidadApiConsumer = LocalidadApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Solicitud_Solicitante
        [ObjectAuth(ObjectId = (ModuleObjectId)45090, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45090, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_de_Solicitud_Solicitante/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45090, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45090, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_de_Solicitud_Solicitante = new Detalle_de_Solicitud_SolicitanteModel();
			varDetalle_de_Solicitud_Solicitante.Clave = Id;
			
            ViewBag.ObjectId = "45090";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Solicitud_SolicitantesData = _IDetalle_de_Solicitud_SolicitanteApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Solicitud_Solicitante.Clave=" + Id, "").Resource.Detalle_de_Solicitud_Solicitantes;
				
				if (Detalle_de_Solicitud_SolicitantesData != null && Detalle_de_Solicitud_SolicitantesData.Count > 0)
                {
					var Detalle_de_Solicitud_SolicitanteData = Detalle_de_Solicitud_SolicitantesData.First();
					varDetalle_de_Solicitud_Solicitante= new Detalle_de_Solicitud_SolicitanteModel
					{
						Clave  = Detalle_de_Solicitud_SolicitanteData.Clave 
	                    ,idRegistroAT = Detalle_de_Solicitud_SolicitanteData.idRegistroAT
                    ,idRegistroUI = Detalle_de_Solicitud_SolicitanteData.idRegistroUI
                    ,Solicitud = Detalle_de_Solicitud_SolicitanteData.Solicitud
                    ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Solicitud), "Solicitud") ??  (string)Detalle_de_Solicitud_SolicitanteData.Solicitud_Solicitud.Numero_de_Folio
                    ,Nombre = Detalle_de_Solicitud_SolicitanteData.Nombre
                    ,Apellido_Paterno = Detalle_de_Solicitud_SolicitanteData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Solicitud_SolicitanteData.Apellido_Materno
                    ,Nombre_Completo = Detalle_de_Solicitud_SolicitanteData.Nombre_Completo
                    ,Fecha_de_Nacimiento = (Detalle_de_Solicitud_SolicitanteData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_SolicitanteData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,CURP = Detalle_de_Solicitud_SolicitanteData.CURP
                    ,RFC = Detalle_de_Solicitud_SolicitanteData.RFC
                    ,Edad = Detalle_de_Solicitud_SolicitanteData.Edad
                    ,Sexo = Detalle_de_Solicitud_SolicitanteData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Sexo), "Genero") ??  (string)Detalle_de_Solicitud_SolicitanteData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Detalle_de_Solicitud_SolicitanteData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Estado_Civil), "Estado_Civil") ??  (string)Detalle_de_Solicitud_SolicitanteData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Detalle_de_Solicitud_SolicitanteData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Detalle_de_Solicitud_SolicitanteData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Indentificacion = Detalle_de_Solicitud_SolicitanteData.Numero_de_Indentificacion
                    ,Nacionalidad = Detalle_de_Solicitud_SolicitanteData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Solicitud_SolicitanteData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = Detalle_de_Solicitud_SolicitanteData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Escolaridad), "Escolaridad") ??  (string)Detalle_de_Solicitud_SolicitanteData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Detalle_de_Solicitud_SolicitanteData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Ocupacion), "Ocupacion") ??  (string)Detalle_de_Solicitud_SolicitanteData.Ocupacion_Ocupacion.Descripcion
                    ,Pais = Detalle_de_Solicitud_SolicitanteData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Pais), "Pais") ??  (string)Detalle_de_Solicitud_SolicitanteData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_Solicitud_SolicitanteData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Estado), "Estado") ??  (string)Detalle_de_Solicitud_SolicitanteData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Solicitud_SolicitanteData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Municipio), "Municipio") ??  (string)Detalle_de_Solicitud_SolicitanteData.Municipio_Municipio.Nombre
                    ,Codigo_Postal = Detalle_de_Solicitud_SolicitanteData.Codigo_Postal
                    ,Poblacion = Detalle_de_Solicitud_SolicitanteData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Poblacion), "Colonia") ??  (string)Detalle_de_Solicitud_SolicitanteData.Poblacion_Colonia.Nombre
                    ,Colonia = Detalle_de_Solicitud_SolicitanteData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Colonia), "Colonia") ??  (string)Detalle_de_Solicitud_SolicitanteData.Colonia_Colonia.Nombre
                    ,Calle = Detalle_de_Solicitud_SolicitanteData.Calle
                    ,Numero_Exterior = Detalle_de_Solicitud_SolicitanteData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Solicitud_SolicitanteData.Numero_Interior
                    ,Entre_Calle = Detalle_de_Solicitud_SolicitanteData.Entre_Calle
                    ,Y_Calle = Detalle_de_Solicitud_SolicitanteData.Y_Calle
                    ,Longitud = Detalle_de_Solicitud_SolicitanteData.Longitud
                    ,Latitud = Detalle_de_Solicitud_SolicitanteData.Latitud
                    ,Telefono = Detalle_de_Solicitud_SolicitanteData.Telefono
                    ,Celular = Detalle_de_Solicitud_SolicitanteData.Celular
                    ,Correo_Electronico = Detalle_de_Solicitud_SolicitanteData.Correo_Electronico
                    ,Pais_de_Origen = Detalle_de_Solicitud_SolicitanteData.Pais_de_Origen
                    ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Pais_de_Origen), "Pais") ??  (string)Detalle_de_Solicitud_SolicitanteData.Pais_de_Origen_Pais.Nombre
                    ,Originario_de = Detalle_de_Solicitud_SolicitanteData.Originario_de
                    ,Tipo_de_Compareciente = Detalle_de_Solicitud_SolicitanteData.Tipo_de_Compareciente
                    ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Tipo_de_Compareciente), "Tipo_de_Compareciente") ??  (string)Detalle_de_Solicitud_SolicitanteData.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                    ,Incapaz = Detalle_de_Solicitud_SolicitanteData.Incapaz.GetValueOrDefault()
                    ,Tipo_de_Inimputabilidad = Detalle_de_Solicitud_SolicitanteData.Tipo_de_Inimputabilidad
                    ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Tipo_de_Inimputabilidad), "Tipo_de_Inimputabilidad") ??  (string)Detalle_de_Solicitud_SolicitanteData.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
                    ,Nombre_tutor = Detalle_de_Solicitud_SolicitanteData.Nombre_tutor
                    ,Apellido_Paterno_tutor = Detalle_de_Solicitud_SolicitanteData.Apellido_Paterno_tutor
                    ,Apellido_Materno_tutor = Detalle_de_Solicitud_SolicitanteData.Apellido_Materno_tutor
                    ,Nombre_Completo_tutor = Detalle_de_Solicitud_SolicitanteData.Nombre_Completo_tutor
                    ,Fecha_de_Nacimiento_tutor = (Detalle_de_Solicitud_SolicitanteData.Fecha_de_Nacimiento_tutor == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_SolicitanteData.Fecha_de_Nacimiento_tutor).ToString(ConfigurationProperty.DateFormat))
                    ,CURP_Tutor = Detalle_de_Solicitud_SolicitanteData.CURP_Tutor
                    ,RFC_Tutor = Detalle_de_Solicitud_SolicitanteData.RFC_Tutor
                    ,Edad_tutor = Detalle_de_Solicitud_SolicitanteData.Edad_tutor
                    ,Sexo_tutor = Detalle_de_Solicitud_SolicitanteData.Sexo_tutor
                    ,Sexo_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Sexo_tutor), "Genero") ??  (string)Detalle_de_Solicitud_SolicitanteData.Sexo_tutor_Genero.Descripcion
                    ,Estado_Civil_tutor = Detalle_de_Solicitud_SolicitanteData.Estado_Civil_tutor
                    ,Estado_Civil_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Estado_Civil_tutor), "Estado_Civil") ??  (string)Detalle_de_Solicitud_SolicitanteData.Estado_Civil_tutor_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_tutor = Detalle_de_Solicitud_SolicitanteData.Tipo_de_Identificacion_tutor
                    ,Tipo_de_Identificacion_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Tipo_de_Identificacion_tutor), "Tipo_de_Identificacion") ??  (string)Detalle_de_Solicitud_SolicitanteData.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_tutor = Detalle_de_Solicitud_SolicitanteData.Numero_de_Identificacion_tutor
                    ,Nacionalidad_tutor = Detalle_de_Solicitud_SolicitanteData.Nacionalidad_tutor
                    ,Nacionalidad_tutorNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Nacionalidad_tutor), "Nacionalidad") ??  (string)Detalle_de_Solicitud_SolicitanteData.Nacionalidad_tutor_Nacionalidad.NacionalidadC
                    ,Escolaridad_tutor = Detalle_de_Solicitud_SolicitanteData.Escolaridad_tutor
                    ,Escolaridad_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Escolaridad_tutor), "Escolaridad") ??  (string)Detalle_de_Solicitud_SolicitanteData.Escolaridad_tutor_Escolaridad.Descripcion
                    ,Ocupacion_tutor = Detalle_de_Solicitud_SolicitanteData.Ocupacion_tutor
                    ,Ocupacion_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Ocupacion_tutor), "Ocupacion") ??  (string)Detalle_de_Solicitud_SolicitanteData.Ocupacion_tutor_Ocupacion.Descripcion
                    ,Pais_tutor = Detalle_de_Solicitud_SolicitanteData.Pais_tutor
                    ,Pais_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Pais_tutor), "Pais") ??  (string)Detalle_de_Solicitud_SolicitanteData.Pais_tutor_Pais.Nombre
                    ,Estado_tutor = Detalle_de_Solicitud_SolicitanteData.Estado_tutor
                    ,Estado_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Estado_tutor), "Estado") ??  (string)Detalle_de_Solicitud_SolicitanteData.Estado_tutor_Estado.Nombre
                    ,Municipio_tutor = Detalle_de_Solicitud_SolicitanteData.Municipio_tutor
                    ,Municipio_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Municipio_tutor), "Municipio") ??  (string)Detalle_de_Solicitud_SolicitanteData.Municipio_tutor_Municipio.Nombre
                    ,Localidad_tutor = Detalle_de_Solicitud_SolicitanteData.Localidad_tutor
                    ,Localidad_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Localidad_tutor), "Localidad") ??  (string)Detalle_de_Solicitud_SolicitanteData.Localidad_tutor_Localidad.Descripcion
                    ,Colonia_tutor = Detalle_de_Solicitud_SolicitanteData.Colonia_tutor
                    ,Colonia_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Colonia_tutor), "Colonia") ??  (string)Detalle_de_Solicitud_SolicitanteData.Colonia_tutor_Colonia.Nombre
                    ,Codigo_Postal_tutor = Detalle_de_Solicitud_SolicitanteData.Codigo_Postal_tutor
                    ,Calle_tutor = Detalle_de_Solicitud_SolicitanteData.Calle_tutor
                    ,Numero_Exterior_tutor = Detalle_de_Solicitud_SolicitanteData.Numero_Exterior_tutor
                    ,Numero_Interior_tutor = Detalle_de_Solicitud_SolicitanteData.Numero_Interior_tutor
                    ,Telefono_tutor = Detalle_de_Solicitud_SolicitanteData.Telefono_tutor
                    ,Extension_tutor = Detalle_de_Solicitud_SolicitanteData.Extension_tutor
                    ,Celular_tutor = Detalle_de_Solicitud_SolicitanteData.Celular_tutor
                    ,Correo_Electronico_tutor = Detalle_de_Solicitud_SolicitanteData.Correo_Electronico_tutor
                    ,Pais_de_Origen_T = Detalle_de_Solicitud_SolicitanteData.Pais_de_Origen_T
                    ,Pais_de_Origen_TNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Pais_de_Origen_T), "Pais") ??  (string)Detalle_de_Solicitud_SolicitanteData.Pais_de_Origen_T_Pais.Nombre
                    ,Originario_de_T = Detalle_de_Solicitud_SolicitanteData.Originario_de_T
                    ,Titulo_del_Hecho = Detalle_de_Solicitud_SolicitanteData.Titulo_del_Hecho
                    ,Narrativa_Breve_de_los_Hechos = Detalle_de_Solicitud_SolicitanteData.Narrativa_Breve_de_los_Hechos
                    ,Fecha_del_Hecho = (Detalle_de_Solicitud_SolicitanteData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_SolicitanteData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Aproximada_del_Hecho = Detalle_de_Solicitud_SolicitanteData.Hora_Aproximada_del_Hecho
                    ,Lugar_de_los_Hechos = Detalle_de_Solicitud_SolicitanteData.Lugar_de_los_Hechos
                    ,Lugar_de_los_HechosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Lugar_de_los_Hechos), "Lugar_Tipo") ??  (string)Detalle_de_Solicitud_SolicitanteData.Lugar_de_los_Hechos_Lugar_Tipo.Descripcion
                    ,Pais_Hechos = Detalle_de_Solicitud_SolicitanteData.Pais_Hechos
                    ,Pais_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Pais_Hechos), "Pais") ??  (string)Detalle_de_Solicitud_SolicitanteData.Pais_Hechos_Pais.Nombre
                    ,Estado_Hechos = Detalle_de_Solicitud_SolicitanteData.Estado_Hechos
                    ,Estado_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Estado_Hechos), "Estado") ??  (string)Detalle_de_Solicitud_SolicitanteData.Estado_Hechos_Estado.Nombre
                    ,Municipio_Hechos = Detalle_de_Solicitud_SolicitanteData.Municipio_Hechos
                    ,Municipio_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Municipio_Hechos), "Municipio") ??  (string)Detalle_de_Solicitud_SolicitanteData.Municipio_Hechos_Municipio.Nombre
                    ,Colonia_Hechos = Detalle_de_Solicitud_SolicitanteData.Colonia_Hechos
                    ,Colonia_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Colonia_Hechos), "Colonia") ??  (string)Detalle_de_Solicitud_SolicitanteData.Colonia_Hechos_Colonia.Nombre
                    ,Codigo_Postal_Hechos = Detalle_de_Solicitud_SolicitanteData.Codigo_Postal_Hechos
                    ,Calle_Hechos = Detalle_de_Solicitud_SolicitanteData.Calle_Hechos
                    ,Numero_Exterior_Hechos = Detalle_de_Solicitud_SolicitanteData.Numero_Exterior_Hechos
                    ,Numero_Interior_Hechos = Detalle_de_Solicitud_SolicitanteData.Numero_Interior_Hechos
                    ,Entre_Calle_Hechos = Detalle_de_Solicitud_SolicitanteData.Entre_Calle_Hechos
                    ,y_Calle_Hechos = Detalle_de_Solicitud_SolicitanteData.y_Calle_Hechos
                    ,Longitud_Hechos = Detalle_de_Solicitud_SolicitanteData.Longitud_Hechos
                    ,Latitud_H = Detalle_de_Solicitud_SolicitanteData.Latitud_H

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

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
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = _ITipo_de_InimputabilidadApiConsumer.SelAll(true);
            if (Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad != null && Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource != null)
                ViewBag.Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_tutor != null && Generos_Sexo_tutor.Resource != null)
                ViewBag.Generos_Sexo_tutor = Generos_Sexo_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_tutor != null && Estado_Civils_Estado_Civil_tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_tutor = Estado_Civils_Estado_Civil_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_tutor != null && Nacionalidads_Nacionalidad_tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_tutor = Nacionalidads_Nacionalidad_tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_tutor != null && Escolaridads_Escolaridad_tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_tutor = Escolaridads_Escolaridad_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_tutor != null && Ocupacions_Ocupacion_tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_tutor = Ocupacions_Ocupacion_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_tutor = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_tutor != null && Localidads_Localidad_tutor.Resource != null)
                ViewBag.Localidads_Localidad_tutor = Localidads_Localidad_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Lugar_de_los_Hechos = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Lugar_de_los_Hechos != null && Lugar_Tipos_Lugar_de_los_Hechos.Resource != null)
                ViewBag.Lugar_Tipos_Lugar_de_los_Hechos = Lugar_Tipos_Lugar_de_los_Hechos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDetalle_de_Solicitud_Solicitante);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Solicitud_Solicitante(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45090);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Solicitud_SolicitanteModel varDetalle_de_Solicitud_Solicitante= new Detalle_de_Solicitud_SolicitanteModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_Solicitud_SolicitantesData = _IDetalle_de_Solicitud_SolicitanteApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Solicitud_Solicitante.Clave=" + id, "").Resource.Detalle_de_Solicitud_Solicitantes;
				
				if (Detalle_de_Solicitud_SolicitantesData != null && Detalle_de_Solicitud_SolicitantesData.Count > 0)
                {
					var Detalle_de_Solicitud_SolicitanteData = Detalle_de_Solicitud_SolicitantesData.First();
					varDetalle_de_Solicitud_Solicitante= new Detalle_de_Solicitud_SolicitanteModel
					{
						Clave  = Detalle_de_Solicitud_SolicitanteData.Clave 
	                    ,idRegistroAT = Detalle_de_Solicitud_SolicitanteData.idRegistroAT
                    ,idRegistroUI = Detalle_de_Solicitud_SolicitanteData.idRegistroUI
                    ,Solicitud = Detalle_de_Solicitud_SolicitanteData.Solicitud
                    ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Solicitud), "Solicitud") ??  (string)Detalle_de_Solicitud_SolicitanteData.Solicitud_Solicitud.Numero_de_Folio
                    ,Nombre = Detalle_de_Solicitud_SolicitanteData.Nombre
                    ,Apellido_Paterno = Detalle_de_Solicitud_SolicitanteData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Solicitud_SolicitanteData.Apellido_Materno
                    ,Nombre_Completo = Detalle_de_Solicitud_SolicitanteData.Nombre_Completo
                    ,Fecha_de_Nacimiento = (Detalle_de_Solicitud_SolicitanteData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_SolicitanteData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,CURP = Detalle_de_Solicitud_SolicitanteData.CURP
                    ,RFC = Detalle_de_Solicitud_SolicitanteData.RFC
                    ,Edad = Detalle_de_Solicitud_SolicitanteData.Edad
                    ,Sexo = Detalle_de_Solicitud_SolicitanteData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Sexo), "Genero") ??  (string)Detalle_de_Solicitud_SolicitanteData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Detalle_de_Solicitud_SolicitanteData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Estado_Civil), "Estado_Civil") ??  (string)Detalle_de_Solicitud_SolicitanteData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Detalle_de_Solicitud_SolicitanteData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Detalle_de_Solicitud_SolicitanteData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Indentificacion = Detalle_de_Solicitud_SolicitanteData.Numero_de_Indentificacion
                    ,Nacionalidad = Detalle_de_Solicitud_SolicitanteData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Solicitud_SolicitanteData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = Detalle_de_Solicitud_SolicitanteData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Escolaridad), "Escolaridad") ??  (string)Detalle_de_Solicitud_SolicitanteData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Detalle_de_Solicitud_SolicitanteData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Ocupacion), "Ocupacion") ??  (string)Detalle_de_Solicitud_SolicitanteData.Ocupacion_Ocupacion.Descripcion
                    ,Pais = Detalle_de_Solicitud_SolicitanteData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Pais), "Pais") ??  (string)Detalle_de_Solicitud_SolicitanteData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_Solicitud_SolicitanteData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Estado), "Estado") ??  (string)Detalle_de_Solicitud_SolicitanteData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Solicitud_SolicitanteData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Municipio), "Municipio") ??  (string)Detalle_de_Solicitud_SolicitanteData.Municipio_Municipio.Nombre
                    ,Codigo_Postal = Detalle_de_Solicitud_SolicitanteData.Codigo_Postal
                    ,Poblacion = Detalle_de_Solicitud_SolicitanteData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Poblacion), "Colonia") ??  (string)Detalle_de_Solicitud_SolicitanteData.Poblacion_Colonia.Nombre
                    ,Colonia = Detalle_de_Solicitud_SolicitanteData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Colonia), "Colonia") ??  (string)Detalle_de_Solicitud_SolicitanteData.Colonia_Colonia.Nombre
                    ,Calle = Detalle_de_Solicitud_SolicitanteData.Calle
                    ,Numero_Exterior = Detalle_de_Solicitud_SolicitanteData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Solicitud_SolicitanteData.Numero_Interior
                    ,Entre_Calle = Detalle_de_Solicitud_SolicitanteData.Entre_Calle
                    ,Y_Calle = Detalle_de_Solicitud_SolicitanteData.Y_Calle
                    ,Longitud = Detalle_de_Solicitud_SolicitanteData.Longitud
                    ,Latitud = Detalle_de_Solicitud_SolicitanteData.Latitud
                    ,Telefono = Detalle_de_Solicitud_SolicitanteData.Telefono
                    ,Celular = Detalle_de_Solicitud_SolicitanteData.Celular
                    ,Correo_Electronico = Detalle_de_Solicitud_SolicitanteData.Correo_Electronico
                    ,Pais_de_Origen = Detalle_de_Solicitud_SolicitanteData.Pais_de_Origen
                    ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Pais_de_Origen), "Pais") ??  (string)Detalle_de_Solicitud_SolicitanteData.Pais_de_Origen_Pais.Nombre
                    ,Originario_de = Detalle_de_Solicitud_SolicitanteData.Originario_de
                    ,Tipo_de_Compareciente = Detalle_de_Solicitud_SolicitanteData.Tipo_de_Compareciente
                    ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Tipo_de_Compareciente), "Tipo_de_Compareciente") ??  (string)Detalle_de_Solicitud_SolicitanteData.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                    ,Incapaz = Detalle_de_Solicitud_SolicitanteData.Incapaz.GetValueOrDefault()
                    ,Tipo_de_Inimputabilidad = Detalle_de_Solicitud_SolicitanteData.Tipo_de_Inimputabilidad
                    ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Tipo_de_Inimputabilidad), "Tipo_de_Inimputabilidad") ??  (string)Detalle_de_Solicitud_SolicitanteData.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
                    ,Nombre_tutor = Detalle_de_Solicitud_SolicitanteData.Nombre_tutor
                    ,Apellido_Paterno_tutor = Detalle_de_Solicitud_SolicitanteData.Apellido_Paterno_tutor
                    ,Apellido_Materno_tutor = Detalle_de_Solicitud_SolicitanteData.Apellido_Materno_tutor
                    ,Nombre_Completo_tutor = Detalle_de_Solicitud_SolicitanteData.Nombre_Completo_tutor
                    ,Fecha_de_Nacimiento_tutor = (Detalle_de_Solicitud_SolicitanteData.Fecha_de_Nacimiento_tutor == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_SolicitanteData.Fecha_de_Nacimiento_tutor).ToString(ConfigurationProperty.DateFormat))
                    ,CURP_Tutor = Detalle_de_Solicitud_SolicitanteData.CURP_Tutor
                    ,RFC_Tutor = Detalle_de_Solicitud_SolicitanteData.RFC_Tutor
                    ,Edad_tutor = Detalle_de_Solicitud_SolicitanteData.Edad_tutor
                    ,Sexo_tutor = Detalle_de_Solicitud_SolicitanteData.Sexo_tutor
                    ,Sexo_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Sexo_tutor), "Genero") ??  (string)Detalle_de_Solicitud_SolicitanteData.Sexo_tutor_Genero.Descripcion
                    ,Estado_Civil_tutor = Detalle_de_Solicitud_SolicitanteData.Estado_Civil_tutor
                    ,Estado_Civil_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Estado_Civil_tutor), "Estado_Civil") ??  (string)Detalle_de_Solicitud_SolicitanteData.Estado_Civil_tutor_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_tutor = Detalle_de_Solicitud_SolicitanteData.Tipo_de_Identificacion_tutor
                    ,Tipo_de_Identificacion_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Tipo_de_Identificacion_tutor), "Tipo_de_Identificacion") ??  (string)Detalle_de_Solicitud_SolicitanteData.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_tutor = Detalle_de_Solicitud_SolicitanteData.Numero_de_Identificacion_tutor
                    ,Nacionalidad_tutor = Detalle_de_Solicitud_SolicitanteData.Nacionalidad_tutor
                    ,Nacionalidad_tutorNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Nacionalidad_tutor), "Nacionalidad") ??  (string)Detalle_de_Solicitud_SolicitanteData.Nacionalidad_tutor_Nacionalidad.NacionalidadC
                    ,Escolaridad_tutor = Detalle_de_Solicitud_SolicitanteData.Escolaridad_tutor
                    ,Escolaridad_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Escolaridad_tutor), "Escolaridad") ??  (string)Detalle_de_Solicitud_SolicitanteData.Escolaridad_tutor_Escolaridad.Descripcion
                    ,Ocupacion_tutor = Detalle_de_Solicitud_SolicitanteData.Ocupacion_tutor
                    ,Ocupacion_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Ocupacion_tutor), "Ocupacion") ??  (string)Detalle_de_Solicitud_SolicitanteData.Ocupacion_tutor_Ocupacion.Descripcion
                    ,Pais_tutor = Detalle_de_Solicitud_SolicitanteData.Pais_tutor
                    ,Pais_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Pais_tutor), "Pais") ??  (string)Detalle_de_Solicitud_SolicitanteData.Pais_tutor_Pais.Nombre
                    ,Estado_tutor = Detalle_de_Solicitud_SolicitanteData.Estado_tutor
                    ,Estado_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Estado_tutor), "Estado") ??  (string)Detalle_de_Solicitud_SolicitanteData.Estado_tutor_Estado.Nombre
                    ,Municipio_tutor = Detalle_de_Solicitud_SolicitanteData.Municipio_tutor
                    ,Municipio_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Municipio_tutor), "Municipio") ??  (string)Detalle_de_Solicitud_SolicitanteData.Municipio_tutor_Municipio.Nombre
                    ,Localidad_tutor = Detalle_de_Solicitud_SolicitanteData.Localidad_tutor
                    ,Localidad_tutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Localidad_tutor), "Localidad") ??  (string)Detalle_de_Solicitud_SolicitanteData.Localidad_tutor_Localidad.Descripcion
                    ,Colonia_tutor = Detalle_de_Solicitud_SolicitanteData.Colonia_tutor
                    ,Colonia_tutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Colonia_tutor), "Colonia") ??  (string)Detalle_de_Solicitud_SolicitanteData.Colonia_tutor_Colonia.Nombre
                    ,Codigo_Postal_tutor = Detalle_de_Solicitud_SolicitanteData.Codigo_Postal_tutor
                    ,Calle_tutor = Detalle_de_Solicitud_SolicitanteData.Calle_tutor
                    ,Numero_Exterior_tutor = Detalle_de_Solicitud_SolicitanteData.Numero_Exterior_tutor
                    ,Numero_Interior_tutor = Detalle_de_Solicitud_SolicitanteData.Numero_Interior_tutor
                    ,Telefono_tutor = Detalle_de_Solicitud_SolicitanteData.Telefono_tutor
                    ,Extension_tutor = Detalle_de_Solicitud_SolicitanteData.Extension_tutor
                    ,Celular_tutor = Detalle_de_Solicitud_SolicitanteData.Celular_tutor
                    ,Correo_Electronico_tutor = Detalle_de_Solicitud_SolicitanteData.Correo_Electronico_tutor
                    ,Pais_de_Origen_T = Detalle_de_Solicitud_SolicitanteData.Pais_de_Origen_T
                    ,Pais_de_Origen_TNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Pais_de_Origen_T), "Pais") ??  (string)Detalle_de_Solicitud_SolicitanteData.Pais_de_Origen_T_Pais.Nombre
                    ,Originario_de_T = Detalle_de_Solicitud_SolicitanteData.Originario_de_T
                    ,Titulo_del_Hecho = Detalle_de_Solicitud_SolicitanteData.Titulo_del_Hecho
                    ,Narrativa_Breve_de_los_Hechos = Detalle_de_Solicitud_SolicitanteData.Narrativa_Breve_de_los_Hechos
                    ,Fecha_del_Hecho = (Detalle_de_Solicitud_SolicitanteData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_SolicitanteData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Aproximada_del_Hecho = Detalle_de_Solicitud_SolicitanteData.Hora_Aproximada_del_Hecho
                    ,Lugar_de_los_Hechos = Detalle_de_Solicitud_SolicitanteData.Lugar_de_los_Hechos
                    ,Lugar_de_los_HechosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Lugar_de_los_Hechos), "Lugar_Tipo") ??  (string)Detalle_de_Solicitud_SolicitanteData.Lugar_de_los_Hechos_Lugar_Tipo.Descripcion
                    ,Pais_Hechos = Detalle_de_Solicitud_SolicitanteData.Pais_Hechos
                    ,Pais_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Pais_Hechos), "Pais") ??  (string)Detalle_de_Solicitud_SolicitanteData.Pais_Hechos_Pais.Nombre
                    ,Estado_Hechos = Detalle_de_Solicitud_SolicitanteData.Estado_Hechos
                    ,Estado_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Estado_Hechos), "Estado") ??  (string)Detalle_de_Solicitud_SolicitanteData.Estado_Hechos_Estado.Nombre
                    ,Municipio_Hechos = Detalle_de_Solicitud_SolicitanteData.Municipio_Hechos
                    ,Municipio_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Municipio_Hechos), "Municipio") ??  (string)Detalle_de_Solicitud_SolicitanteData.Municipio_Hechos_Municipio.Nombre
                    ,Colonia_Hechos = Detalle_de_Solicitud_SolicitanteData.Colonia_Hechos
                    ,Colonia_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SolicitanteData.Colonia_Hechos), "Colonia") ??  (string)Detalle_de_Solicitud_SolicitanteData.Colonia_Hechos_Colonia.Nombre
                    ,Codigo_Postal_Hechos = Detalle_de_Solicitud_SolicitanteData.Codigo_Postal_Hechos
                    ,Calle_Hechos = Detalle_de_Solicitud_SolicitanteData.Calle_Hechos
                    ,Numero_Exterior_Hechos = Detalle_de_Solicitud_SolicitanteData.Numero_Exterior_Hechos
                    ,Numero_Interior_Hechos = Detalle_de_Solicitud_SolicitanteData.Numero_Interior_Hechos
                    ,Entre_Calle_Hechos = Detalle_de_Solicitud_SolicitanteData.Entre_Calle_Hechos
                    ,y_Calle_Hechos = Detalle_de_Solicitud_SolicitanteData.y_Calle_Hechos
                    ,Longitud_Hechos = Detalle_de_Solicitud_SolicitanteData.Longitud_Hechos
                    ,Latitud_H = Detalle_de_Solicitud_SolicitanteData.Latitud_H

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

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
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = _ITipo_de_InimputabilidadApiConsumer.SelAll(true);
            if (Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad != null && Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource != null)
                ViewBag.Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_tutor != null && Generos_Sexo_tutor.Resource != null)
                ViewBag.Generos_Sexo_tutor = Generos_Sexo_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_tutor != null && Estado_Civils_Estado_Civil_tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_tutor = Estado_Civils_Estado_Civil_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_tutor != null && Nacionalidads_Nacionalidad_tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_tutor = Nacionalidads_Nacionalidad_tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_tutor != null && Escolaridads_Escolaridad_tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_tutor = Escolaridads_Escolaridad_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_tutor != null && Ocupacions_Ocupacion_tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_tutor = Ocupacions_Ocupacion_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_tutor = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_tutor != null && Localidads_Localidad_tutor.Resource != null)
                ViewBag.Localidads_Localidad_tutor = Localidads_Localidad_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Lugar_de_los_Hechos = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Lugar_de_los_Hechos != null && Lugar_Tipos_Lugar_de_los_Hechos.Resource != null)
                ViewBag.Lugar_Tipos_Lugar_de_los_Hechos = Lugar_Tipos_Lugar_de_los_Hechos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Solicitud_Solicitante", varDetalle_de_Solicitud_Solicitante);
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
        public ActionResult GetSolicitudAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitudApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Numero_de_Folio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitud", "Numero_de_Folio")?? m.Numero_de_Folio,
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
        public ActionResult GetTipo_de_InimputabilidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_InimputabilidadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetLugar_TipoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILugar_TipoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Detalle_de_Solicitud_SolicitanteAdvanceSearchModel model, int idFilter = -1)
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
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = _ITipo_de_InimputabilidadApiConsumer.SelAll(true);
            if (Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad != null && Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource != null)
                ViewBag.Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_tutor != null && Generos_Sexo_tutor.Resource != null)
                ViewBag.Generos_Sexo_tutor = Generos_Sexo_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_tutor != null && Estado_Civils_Estado_Civil_tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_tutor = Estado_Civils_Estado_Civil_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_tutor != null && Nacionalidads_Nacionalidad_tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_tutor = Nacionalidads_Nacionalidad_tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_tutor != null && Escolaridads_Escolaridad_tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_tutor = Escolaridads_Escolaridad_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_tutor != null && Ocupacions_Ocupacion_tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_tutor = Ocupacions_Ocupacion_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_tutor = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_tutor != null && Localidads_Localidad_tutor.Resource != null)
                ViewBag.Localidads_Localidad_tutor = Localidads_Localidad_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Lugar_de_los_Hechos = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Lugar_de_los_Hechos != null && Lugar_Tipos_Lugar_de_los_Hechos.Resource != null)
                ViewBag.Lugar_Tipos_Lugar_de_los_Hechos = Lugar_Tipos_Lugar_de_los_Hechos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

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
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = _ITipo_de_InimputabilidadApiConsumer.SelAll(true);
            if (Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad != null && Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource != null)
                ViewBag.Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad = Tipo_de_Inimputabilidads_Tipo_de_Inimputabilidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_tutor = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_tutor != null && Generos_Sexo_tutor.Resource != null)
                ViewBag.Generos_Sexo_tutor = Generos_Sexo_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_tutor = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_tutor != null && Estado_Civils_Estado_Civil_tutor.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_tutor = Estado_Civils_Estado_Civil_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_tutor != null && Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_tutor = Tipo_de_Identificacions_Tipo_de_Identificacion_tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_tutor = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_tutor != null && Nacionalidads_Nacionalidad_tutor.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_tutor = Nacionalidads_Nacionalidad_tutor.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_tutor = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_tutor != null && Escolaridads_Escolaridad_tutor.Resource != null)
                ViewBag.Escolaridads_Escolaridad_tutor = Escolaridads_Escolaridad_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_tutor = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_tutor != null && Ocupacions_Ocupacion_tutor.Resource != null)
                ViewBag.Ocupacions_Ocupacion_tutor = Ocupacions_Ocupacion_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_tutor = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_tutor != null && Localidads_Localidad_tutor.Resource != null)
                ViewBag.Localidads_Localidad_tutor = Localidads_Localidad_tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Lugar_de_los_Hechos = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Lugar_de_los_Hechos != null && Lugar_Tipos_Lugar_de_los_Hechos.Resource != null)
                ViewBag.Lugar_Tipos_Lugar_de_los_Hechos = Lugar_Tipos_Lugar_de_los_Hechos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Detalle_de_Solicitud_SolicitanteAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_de_Solicitud_SolicitanteAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_de_Solicitud_SolicitanteAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Solicitud_SolicitantePropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitud_Solicitantes == null)
                result.Detalle_de_Solicitud_Solicitantes = new List<Detalle_de_Solicitud_Solicitante>();

            return Json(new
            {
                data = result.Detalle_de_Solicitud_Solicitantes.Select(m => new Detalle_de_Solicitud_SolicitanteGridModel
                    {
                    Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,CURP = m.CURP
			,RFC = m.RFC
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Indentificacion = m.Numero_de_Indentificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Longitud = m.Longitud
			,Latitud = m.Latitud
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Incapaz = m.Incapaz
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Nombre_tutor = m.Nombre_tutor
			,Apellido_Paterno_tutor = m.Apellido_Paterno_tutor
			,Apellido_Materno_tutor = m.Apellido_Materno_tutor
			,Nombre_Completo_tutor = m.Nombre_Completo_tutor
                        ,Fecha_de_Nacimiento_tutor = (m.Fecha_de_Nacimiento_tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_tutor).ToString(ConfigurationProperty.DateFormat))
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor
			,Edad_tutor = m.Edad_tutor
                        ,Sexo_tutorDescripcion = CultureHelper.GetTraduction(m.Sexo_tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_tutor_Genero.Descripcion
                        ,Estado_Civil_tutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_tutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_tutor = m.Numero_de_Identificacion_tutor
                        ,Nacionalidad_tutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_tutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_tutor_Escolaridad.Descripcion
                        ,Ocupacion_tutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_tutor_Ocupacion.Descripcion
                        ,Pais_tutorNombre = CultureHelper.GetTraduction(m.Pais_tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_tutor_Pais.Nombre
                        ,Estado_tutorNombre = CultureHelper.GetTraduction(m.Estado_tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_tutor_Estado.Nombre
                        ,Municipio_tutorNombre = CultureHelper.GetTraduction(m.Municipio_tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_tutor_Municipio.Nombre
                        ,Localidad_tutorDescripcion = CultureHelper.GetTraduction(m.Localidad_tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_tutor_Localidad.Descripcion
                        ,Colonia_tutorNombre = CultureHelper.GetTraduction(m.Colonia_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_tutor_Colonia.Nombre
			,Codigo_Postal_tutor = m.Codigo_Postal_tutor
			,Calle_tutor = m.Calle_tutor
			,Numero_Exterior_tutor = m.Numero_Exterior_tutor
			,Numero_Interior_tutor = m.Numero_Interior_tutor
			,Telefono_tutor = m.Telefono_tutor
			,Extension_tutor = m.Extension_tutor
			,Celular_tutor = m.Celular_tutor
			,Correo_Electronico_tutor = m.Correo_Electronico_tutor
                        ,Pais_de_Origen_TNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_T_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_T_Pais.Nombre
			,Originario_de_T = m.Originario_de_T
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Lugar_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Lugar_de_los_Hechos_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_los_Hechos_Lugar_Tipo.Descripcion
                        ,Pais_HechosNombre = CultureHelper.GetTraduction(m.Pais_Hechos_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Hechos_Pais.Nombre
                        ,Estado_HechosNombre = CultureHelper.GetTraduction(m.Estado_Hechos_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Hechos_Estado.Nombre
                        ,Municipio_HechosNombre = CultureHelper.GetTraduction(m.Municipio_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Hechos_Municipio.Nombre
                        ,Colonia_HechosNombre = CultureHelper.GetTraduction(m.Colonia_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Hechos_Colonia.Nombre
			,Codigo_Postal_Hechos = m.Codigo_Postal_Hechos
			,Calle_Hechos = m.Calle_Hechos
			,Numero_Exterior_Hechos = m.Numero_Exterior_Hechos
			,Numero_Interior_Hechos = m.Numero_Interior_Hechos
			,Entre_Calle_Hechos = m.Entre_Calle_Hechos
			,y_Calle_Hechos = m.y_Calle_Hechos
			,Longitud_Hechos = m.Longitud_Hechos
			,Latitud_H = m.Latitud_H

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_de_Solicitud_SolicitanteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_de_Solicitud_Solicitante", m.),
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
        /// Get List of Detalle_de_Solicitud_Solicitante from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_de_Solicitud_Solicitante Entity</returns>
        public ActionResult GetDetalle_de_Solicitud_SolicitanteList(UrlParametersModel param)
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
            _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_de_Solicitud_SolicitantePropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_de_Solicitud_SolicitanteAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_de_Solicitud_SolicitanteAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_de_Solicitud_SolicitantePropertyMapper oDetalle_de_Solicitud_SolicitantePropertyMapper = new Detalle_de_Solicitud_SolicitantePropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_de_Solicitud_SolicitantePropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitud_Solicitantes == null)
                result.Detalle_de_Solicitud_Solicitantes = new List<Detalle_de_Solicitud_Solicitante>();

            return Json(new
            {
                aaData = result.Detalle_de_Solicitud_Solicitantes.Select(m => new Detalle_de_Solicitud_SolicitanteGridModel
            {
                    Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,CURP = m.CURP
			,RFC = m.RFC
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Indentificacion = m.Numero_de_Indentificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Longitud = m.Longitud
			,Latitud = m.Latitud
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Incapaz = m.Incapaz
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Nombre_tutor = m.Nombre_tutor
			,Apellido_Paterno_tutor = m.Apellido_Paterno_tutor
			,Apellido_Materno_tutor = m.Apellido_Materno_tutor
			,Nombre_Completo_tutor = m.Nombre_Completo_tutor
                        ,Fecha_de_Nacimiento_tutor = (m.Fecha_de_Nacimiento_tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_tutor).ToString(ConfigurationProperty.DateFormat))
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor
			,Edad_tutor = m.Edad_tutor
                        ,Sexo_tutorDescripcion = CultureHelper.GetTraduction(m.Sexo_tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_tutor_Genero.Descripcion
                        ,Estado_Civil_tutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_tutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_tutor = m.Numero_de_Identificacion_tutor
                        ,Nacionalidad_tutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_tutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_tutor_Escolaridad.Descripcion
                        ,Ocupacion_tutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_tutor_Ocupacion.Descripcion
                        ,Pais_tutorNombre = CultureHelper.GetTraduction(m.Pais_tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_tutor_Pais.Nombre
                        ,Estado_tutorNombre = CultureHelper.GetTraduction(m.Estado_tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_tutor_Estado.Nombre
                        ,Municipio_tutorNombre = CultureHelper.GetTraduction(m.Municipio_tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_tutor_Municipio.Nombre
                        ,Localidad_tutorDescripcion = CultureHelper.GetTraduction(m.Localidad_tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_tutor_Localidad.Descripcion
                        ,Colonia_tutorNombre = CultureHelper.GetTraduction(m.Colonia_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_tutor_Colonia.Nombre
			,Codigo_Postal_tutor = m.Codigo_Postal_tutor
			,Calle_tutor = m.Calle_tutor
			,Numero_Exterior_tutor = m.Numero_Exterior_tutor
			,Numero_Interior_tutor = m.Numero_Interior_tutor
			,Telefono_tutor = m.Telefono_tutor
			,Extension_tutor = m.Extension_tutor
			,Celular_tutor = m.Celular_tutor
			,Correo_Electronico_tutor = m.Correo_Electronico_tutor
                        ,Pais_de_Origen_TNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_T_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_T_Pais.Nombre
			,Originario_de_T = m.Originario_de_T
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Lugar_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Lugar_de_los_Hechos_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_los_Hechos_Lugar_Tipo.Descripcion
                        ,Pais_HechosNombre = CultureHelper.GetTraduction(m.Pais_Hechos_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Hechos_Pais.Nombre
                        ,Estado_HechosNombre = CultureHelper.GetTraduction(m.Estado_Hechos_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Hechos_Estado.Nombre
                        ,Municipio_HechosNombre = CultureHelper.GetTraduction(m.Municipio_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Hechos_Municipio.Nombre
                        ,Colonia_HechosNombre = CultureHelper.GetTraduction(m.Colonia_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Hechos_Colonia.Nombre
			,Codigo_Postal_Hechos = m.Codigo_Postal_Hechos
			,Calle_Hechos = m.Calle_Hechos
			,Numero_Exterior_Hechos = m.Numero_Exterior_Hechos
			,Numero_Interior_Hechos = m.Numero_Interior_Hechos
			,Entre_Calle_Hechos = m.Entre_Calle_Hechos
			,y_Calle_Hechos = m.y_Calle_Hechos
			,Longitud_Hechos = m.Longitud_Hechos
			,Latitud_H = m.Latitud_H

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Solicitud_Solicitud(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Solicitud.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Solicitud.Numero_de_Folio as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISolicitudApiConsumer.ListaSelAll(1, 20,elWhere , " Solicitud.Numero_de_Folio ASC ").Resource;
               
                foreach (var item in result.Solicituds)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Solicitud", "Numero_de_Folio");
                    item.Numero_de_Folio =trans ??item.Numero_de_Folio;
                }
                return Json(result.Solicituds.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Pais_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Estado_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Municipio_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Poblacion_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Colonia_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Pais_de_Origen_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Pais_tutor_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Estado_tutor_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Municipio_tutor_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Colonia_tutor_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Pais_de_Origen_T_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Pais_Hechos_Pais(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Estado_Hechos_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Municipio_Hechos_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Solicitud_Solicitante_Colonia_Hechos_Colonia(string query, string where)
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
        public string GetAdvanceFilter(Detalle_de_Solicitud_SolicitanteAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_de_Solicitud_Solicitante.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_de_Solicitud_Solicitante.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.FromidRegistroAT) || !string.IsNullOrEmpty(filter.ToidRegistroAT))
            {
                if (!string.IsNullOrEmpty(filter.FromidRegistroAT))
                    where += " AND Detalle_de_Solicitud_Solicitante.idRegistroAT >= " + filter.FromidRegistroAT;
                if (!string.IsNullOrEmpty(filter.ToidRegistroAT))
                    where += " AND Detalle_de_Solicitud_Solicitante.idRegistroAT <= " + filter.ToidRegistroAT;
            }

            if (!string.IsNullOrEmpty(filter.FromidRegistroUI) || !string.IsNullOrEmpty(filter.ToidRegistroUI))
            {
                if (!string.IsNullOrEmpty(filter.FromidRegistroUI))
                    where += " AND Detalle_de_Solicitud_Solicitante.idRegistroUI >= " + filter.FromidRegistroUI;
                if (!string.IsNullOrEmpty(filter.ToidRegistroUI))
                    where += " AND Detalle_de_Solicitud_Solicitante.idRegistroUI <= " + filter.ToidRegistroUI;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSolicitud))
            {
                switch (filter.SolicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '" + filter.AdvanceSolicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Numero_de_Folio = '" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceSolicitud + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSolicitudMultiple != null && filter.AdvanceSolicitudMultiple.Count() > 0)
            {
                var SolicitudIds = string.Join(",", filter.AdvanceSolicitudMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Solicitud In (" + SolicitudIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombre))
            {
                switch (filter.NombreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre LIKE '" + filter.Nombre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre LIKE '%" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre = '" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre LIKE '%" + filter.Nombre + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno))
            {
                switch (filter.Apellido_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Paterno LIKE '" + filter.Apellido_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Paterno = '" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno))
            {
                switch (filter.Apellido_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Materno LIKE '" + filter.Apellido_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Materno = '" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo))
            {
                switch (filter.Nombre_CompletoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre_Completo LIKE '" + filter.Nombre_Completo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre_Completo = '" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "%'";
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
                    where += " AND Detalle_de_Solicitud_Solicitante.Fecha_de_Nacimiento >= '" + Fecha_de_NacimientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento))
                    where += " AND Detalle_de_Solicitud_Solicitante.Fecha_de_Nacimiento <= '" + Fecha_de_NacimientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.CURP))
            {
                switch (filter.CURPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.CURP LIKE '" + filter.CURP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.CURP LIKE '%" + filter.CURP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.CURP = '" + filter.CURP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.CURP LIKE '%" + filter.CURP + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.RFC))
            {
                switch (filter.RFCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.RFC LIKE '" + filter.RFC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.RFC LIKE '%" + filter.RFC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.RFC = '" + filter.RFC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.RFC LIKE '%" + filter.RFC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromEdad) || !string.IsNullOrEmpty(filter.ToEdad))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad))
                    where += " AND Detalle_de_Solicitud_Solicitante.Edad >= " + filter.FromEdad;
                if (!string.IsNullOrEmpty(filter.ToEdad))
                    where += " AND Detalle_de_Solicitud_Solicitante.Edad <= " + filter.ToEdad;
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

                where += " AND Detalle_de_Solicitud_Solicitante.Sexo In (" + SexoIds + ")";
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

                where += " AND Detalle_de_Solicitud_Solicitante.Estado_Civil In (" + Estado_CivilIds + ")";
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

                where += " AND Detalle_de_Solicitud_Solicitante.Tipo_de_Identificacion In (" + Tipo_de_IdentificacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Indentificacion))
            {
                switch (filter.Numero_de_IndentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_de_Indentificacion LIKE '" + filter.Numero_de_Indentificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_de_Indentificacion LIKE '%" + filter.Numero_de_Indentificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_de_Indentificacion = '" + filter.Numero_de_Indentificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_de_Indentificacion LIKE '%" + filter.Numero_de_Indentificacion + "%'";
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

                where += " AND Detalle_de_Solicitud_Solicitante.Nacionalidad In (" + NacionalidadIds + ")";
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

                where += " AND Detalle_de_Solicitud_Solicitante.Escolaridad In (" + EscolaridadIds + ")";
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

                where += " AND Detalle_de_Solicitud_Solicitante.Ocupacion In (" + OcupacionIds + ")";
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

                where += " AND Detalle_de_Solicitud_Solicitante.Pais In (" + PaisIds + ")";
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

                where += " AND Detalle_de_Solicitud_Solicitante.Estado In (" + EstadoIds + ")";
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

                where += " AND Detalle_de_Solicitud_Solicitante.Municipio In (" + MunicipioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal) || !string.IsNullOrEmpty(filter.ToCodigo_Postal))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal))
                    where += " AND Detalle_de_Solicitud_Solicitante.Codigo_Postal >= " + filter.FromCodigo_Postal;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal))
                    where += " AND Detalle_de_Solicitud_Solicitante.Codigo_Postal <= " + filter.ToCodigo_Postal;
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

                where += " AND Detalle_de_Solicitud_Solicitante.Poblacion In (" + PoblacionIds + ")";
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

                where += " AND Detalle_de_Solicitud_Solicitante.Colonia In (" + ColoniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Calle))
            {
                switch (filter.CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Calle LIKE '" + filter.Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Calle LIKE '%" + filter.Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Calle = '" + filter.Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Calle LIKE '%" + filter.Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior))
            {
                switch (filter.Numero_ExteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Exterior LIKE '" + filter.Numero_Exterior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Exterior = '" + filter.Numero_Exterior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Exterior LIKE '%" + filter.Numero_Exterior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior))
            {
                switch (filter.Numero_InteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Interior LIKE '" + filter.Numero_Interior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Interior LIKE '%" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Interior = '" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Interior LIKE '%" + filter.Numero_Interior + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle))
            {
                switch (filter.Entre_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Entre_Calle LIKE '" + filter.Entre_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Entre_Calle LIKE '%" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Entre_Calle = '" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Entre_Calle LIKE '%" + filter.Entre_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Y_Calle))
            {
                switch (filter.Y_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Y_Calle LIKE '" + filter.Y_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Y_Calle LIKE '%" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Y_Calle = '" + filter.Y_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Y_Calle LIKE '%" + filter.Y_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud))
            {
                switch (filter.LongitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Longitud LIKE '" + filter.Longitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Longitud LIKE '%" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Longitud = '" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Longitud LIKE '%" + filter.Longitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud))
            {
                switch (filter.LatitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Latitud LIKE '" + filter.Latitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Latitud LIKE '%" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Latitud = '" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Latitud LIKE '%" + filter.Latitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Telefono))
            {
                switch (filter.TelefonoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Telefono LIKE '" + filter.Telefono + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Telefono LIKE '%" + filter.Telefono + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Telefono = '" + filter.Telefono + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Telefono LIKE '%" + filter.Telefono + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Celular))
            {
                switch (filter.CelularFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Celular LIKE '" + filter.Celular + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Celular LIKE '%" + filter.Celular + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Celular = '" + filter.Celular + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Celular LIKE '%" + filter.Celular + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Electronico))
            {
                switch (filter.Correo_ElectronicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Correo_Electronico LIKE '" + filter.Correo_Electronico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Correo_Electronico = '" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais_de_Origen))
            {
                switch (filter.Pais_de_OrigenFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais_de_Origen + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_de_Origen + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais_de_Origen + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_de_Origen + "%'";
                        break;
                }
            }
            else if (filter.AdvancePais_de_OrigenMultiple != null && filter.AdvancePais_de_OrigenMultiple.Count() > 0)
            {
                var Pais_de_OrigenIds = string.Join(",", filter.AdvancePais_de_OrigenMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Pais_de_Origen In (" + Pais_de_OrigenIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Originario_de))
            {
                switch (filter.Originario_deFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Originario_de LIKE '" + filter.Originario_de + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Originario_de LIKE '%" + filter.Originario_de + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Originario_de = '" + filter.Originario_de + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Originario_de LIKE '%" + filter.Originario_de + "%'";
                        break;
                }
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

                where += " AND Detalle_de_Solicitud_Solicitante.Tipo_de_Compareciente In (" + Tipo_de_ComparecienteIds + ")";
            }

            if (filter.Incapaz != RadioOptions.NoApply)
                where += " AND Detalle_de_Solicitud_Solicitante.Incapaz = " + Convert.ToInt32(filter.Incapaz);

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Inimputabilidad))
            {
                switch (filter.Tipo_de_InimputabilidadFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Inimputabilidad.Descripcion LIKE '" + filter.AdvanceTipo_de_Inimputabilidad + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Inimputabilidad.Descripcion LIKE '%" + filter.AdvanceTipo_de_Inimputabilidad + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Inimputabilidad.Descripcion = '" + filter.AdvanceTipo_de_Inimputabilidad + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Inimputabilidad.Descripcion LIKE '%" + filter.AdvanceTipo_de_Inimputabilidad + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_InimputabilidadMultiple != null && filter.AdvanceTipo_de_InimputabilidadMultiple.Count() > 0)
            {
                var Tipo_de_InimputabilidadIds = string.Join(",", filter.AdvanceTipo_de_InimputabilidadMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Tipo_de_Inimputabilidad In (" + Tipo_de_InimputabilidadIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombre_tutor))
            {
                switch (filter.Nombre_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre_tutor LIKE '" + filter.Nombre_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre_tutor LIKE '%" + filter.Nombre_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre_tutor = '" + filter.Nombre_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre_tutor LIKE '%" + filter.Nombre_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno_tutor))
            {
                switch (filter.Apellido_Paterno_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Paterno_tutor LIKE '" + filter.Apellido_Paterno_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Paterno_tutor LIKE '%" + filter.Apellido_Paterno_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Paterno_tutor = '" + filter.Apellido_Paterno_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Paterno_tutor LIKE '%" + filter.Apellido_Paterno_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno_tutor))
            {
                switch (filter.Apellido_Materno_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Materno_tutor LIKE '" + filter.Apellido_Materno_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Materno_tutor LIKE '%" + filter.Apellido_Materno_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Materno_tutor = '" + filter.Apellido_Materno_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Apellido_Materno_tutor LIKE '%" + filter.Apellido_Materno_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo_tutor))
            {
                switch (filter.Nombre_Completo_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre_Completo_tutor LIKE '" + filter.Nombre_Completo_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre_Completo_tutor LIKE '%" + filter.Nombre_Completo_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre_Completo_tutor = '" + filter.Nombre_Completo_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre_Completo_tutor LIKE '%" + filter.Nombre_Completo_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Nacimiento_tutor) || !string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento_tutor))
            {
                var Fecha_de_Nacimiento_tutorFrom = DateTime.ParseExact(filter.FromFecha_de_Nacimiento_tutor, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_Nacimiento_tutorTo = DateTime.ParseExact(filter.ToFecha_de_Nacimiento_tutor, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Nacimiento_tutor))
                    where += " AND Detalle_de_Solicitud_Solicitante.Fecha_de_Nacimiento_tutor >= '" + Fecha_de_Nacimiento_tutorFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento_tutor))
                    where += " AND Detalle_de_Solicitud_Solicitante.Fecha_de_Nacimiento_tutor <= '" + Fecha_de_Nacimiento_tutorTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.CURP_Tutor))
            {
                switch (filter.CURP_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.CURP_Tutor LIKE '" + filter.CURP_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.CURP_Tutor LIKE '%" + filter.CURP_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.CURP_Tutor = '" + filter.CURP_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.CURP_Tutor LIKE '%" + filter.CURP_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.RFC_Tutor))
            {
                switch (filter.RFC_TutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.RFC_Tutor LIKE '" + filter.RFC_Tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.RFC_Tutor LIKE '%" + filter.RFC_Tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.RFC_Tutor = '" + filter.RFC_Tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.RFC_Tutor LIKE '%" + filter.RFC_Tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromEdad_tutor) || !string.IsNullOrEmpty(filter.ToEdad_tutor))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad_tutor))
                    where += " AND Detalle_de_Solicitud_Solicitante.Edad_tutor >= " + filter.FromEdad_tutor;
                if (!string.IsNullOrEmpty(filter.ToEdad_tutor))
                    where += " AND Detalle_de_Solicitud_Solicitante.Edad_tutor <= " + filter.ToEdad_tutor;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSexo_tutor))
            {
                switch (filter.Sexo_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Genero.Descripcion LIKE '" + filter.AdvanceSexo_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Genero.Descripcion = '" + filter.AdvanceSexo_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Genero.Descripcion LIKE '%" + filter.AdvanceSexo_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSexo_tutorMultiple != null && filter.AdvanceSexo_tutorMultiple.Count() > 0)
            {
                var Sexo_tutorIds = string.Join(",", filter.AdvanceSexo_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Sexo_tutor In (" + Sexo_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_Civil_tutor))
            {
                switch (filter.Estado_Civil_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado_Civil.Descripcion LIKE '" + filter.AdvanceEstado_Civil_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado_Civil.Descripcion LIKE '%" + filter.AdvanceEstado_Civil_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado_Civil.Descripcion = '" + filter.AdvanceEstado_Civil_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado_Civil.Descripcion LIKE '%" + filter.AdvanceEstado_Civil_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_Civil_tutorMultiple != null && filter.AdvanceEstado_Civil_tutorMultiple.Count() > 0)
            {
                var Estado_Civil_tutorIds = string.Join(",", filter.AdvanceEstado_Civil_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Estado_Civil_tutor In (" + Estado_Civil_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Identificacion_tutor))
            {
                switch (filter.Tipo_de_Identificacion_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '" + filter.AdvanceTipo_de_Identificacion_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Identificacion.Nombre = '" + filter.AdvanceTipo_de_Identificacion_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Identificacion.Nombre LIKE '%" + filter.AdvanceTipo_de_Identificacion_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Identificacion_tutorMultiple != null && filter.AdvanceTipo_de_Identificacion_tutorMultiple.Count() > 0)
            {
                var Tipo_de_Identificacion_tutorIds = string.Join(",", filter.AdvanceTipo_de_Identificacion_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Tipo_de_Identificacion_tutor In (" + Tipo_de_Identificacion_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Identificacion_tutor))
            {
                switch (filter.Numero_de_Identificacion_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_de_Identificacion_tutor LIKE '" + filter.Numero_de_Identificacion_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_de_Identificacion_tutor LIKE '%" + filter.Numero_de_Identificacion_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_de_Identificacion_tutor = '" + filter.Numero_de_Identificacion_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_de_Identificacion_tutor LIKE '%" + filter.Numero_de_Identificacion_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNacionalidad_tutor))
            {
                switch (filter.Nacionalidad_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '" + filter.AdvanceNacionalidad_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Nacionalidad.NacionalidadC = '" + filter.AdvanceNacionalidad_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Nacionalidad.NacionalidadC LIKE '%" + filter.AdvanceNacionalidad_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNacionalidad_tutorMultiple != null && filter.AdvanceNacionalidad_tutorMultiple.Count() > 0)
            {
                var Nacionalidad_tutorIds = string.Join(",", filter.AdvanceNacionalidad_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Nacionalidad_tutor In (" + Nacionalidad_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEscolaridad_tutor))
            {
                switch (filter.Escolaridad_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Escolaridad.Descripcion LIKE '" + filter.AdvanceEscolaridad_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Escolaridad.Descripcion = '" + filter.AdvanceEscolaridad_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Escolaridad.Descripcion LIKE '%" + filter.AdvanceEscolaridad_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEscolaridad_tutorMultiple != null && filter.AdvanceEscolaridad_tutorMultiple.Count() > 0)
            {
                var Escolaridad_tutorIds = string.Join(",", filter.AdvanceEscolaridad_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Escolaridad_tutor In (" + Escolaridad_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceOcupacion_tutor))
            {
                switch (filter.Ocupacion_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Ocupacion.Descripcion LIKE '" + filter.AdvanceOcupacion_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Ocupacion.Descripcion LIKE '%" + filter.AdvanceOcupacion_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Ocupacion.Descripcion = '" + filter.AdvanceOcupacion_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Ocupacion.Descripcion LIKE '%" + filter.AdvanceOcupacion_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceOcupacion_tutorMultiple != null && filter.AdvanceOcupacion_tutorMultiple.Count() > 0)
            {
                var Ocupacion_tutorIds = string.Join(",", filter.AdvanceOcupacion_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Ocupacion_tutor In (" + Ocupacion_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais_tutor))
            {
                switch (filter.Pais_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvancePais_tutorMultiple != null && filter.AdvancePais_tutorMultiple.Count() > 0)
            {
                var Pais_tutorIds = string.Join(",", filter.AdvancePais_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Pais_tutor In (" + Pais_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_tutor))
            {
                switch (filter.Estado_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_tutorMultiple != null && filter.AdvanceEstado_tutorMultiple.Count() > 0)
            {
                var Estado_tutorIds = string.Join(",", filter.AdvanceEstado_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Estado_tutor In (" + Estado_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_tutor))
            {
                switch (filter.Municipio_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_tutorMultiple != null && filter.AdvanceMunicipio_tutorMultiple.Count() > 0)
            {
                var Municipio_tutorIds = string.Join(",", filter.AdvanceMunicipio_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Municipio_tutor In (" + Municipio_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceLocalidad_tutor))
            {
                switch (filter.Localidad_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Localidad.Descripcion LIKE '" + filter.AdvanceLocalidad_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Localidad.Descripcion LIKE '%" + filter.AdvanceLocalidad_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Localidad.Descripcion = '" + filter.AdvanceLocalidad_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Localidad.Descripcion LIKE '%" + filter.AdvanceLocalidad_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceLocalidad_tutorMultiple != null && filter.AdvanceLocalidad_tutorMultiple.Count() > 0)
            {
                var Localidad_tutorIds = string.Join(",", filter.AdvanceLocalidad_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Localidad_tutor In (" + Localidad_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia_tutor))
            {
                switch (filter.Colonia_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_tutor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia_tutorMultiple != null && filter.AdvanceColonia_tutorMultiple.Count() > 0)
            {
                var Colonia_tutorIds = string.Join(",", filter.AdvanceColonia_tutorMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Colonia_tutor In (" + Colonia_tutorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_tutor) || !string.IsNullOrEmpty(filter.ToCodigo_Postal_tutor))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_tutor))
                    where += " AND Detalle_de_Solicitud_Solicitante.Codigo_Postal_tutor >= " + filter.FromCodigo_Postal_tutor;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal_tutor))
                    where += " AND Detalle_de_Solicitud_Solicitante.Codigo_Postal_tutor <= " + filter.ToCodigo_Postal_tutor;
            }

            if (!string.IsNullOrEmpty(filter.Calle_tutor))
            {
                switch (filter.Calle_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Calle_tutor LIKE '" + filter.Calle_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Calle_tutor LIKE '%" + filter.Calle_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Calle_tutor = '" + filter.Calle_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Calle_tutor LIKE '%" + filter.Calle_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior_tutor))
            {
                switch (filter.Numero_Exterior_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Exterior_tutor LIKE '" + filter.Numero_Exterior_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Exterior_tutor LIKE '%" + filter.Numero_Exterior_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Exterior_tutor = '" + filter.Numero_Exterior_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Exterior_tutor LIKE '%" + filter.Numero_Exterior_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior_tutor))
            {
                switch (filter.Numero_Interior_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Interior_tutor LIKE '" + filter.Numero_Interior_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Interior_tutor LIKE '%" + filter.Numero_Interior_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Interior_tutor = '" + filter.Numero_Interior_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Interior_tutor LIKE '%" + filter.Numero_Interior_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Telefono_tutor))
            {
                switch (filter.Telefono_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Telefono_tutor LIKE '" + filter.Telefono_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Telefono_tutor LIKE '%" + filter.Telefono_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Telefono_tutor = '" + filter.Telefono_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Telefono_tutor LIKE '%" + filter.Telefono_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromExtension_tutor) || !string.IsNullOrEmpty(filter.ToExtension_tutor))
            {
                if (!string.IsNullOrEmpty(filter.FromExtension_tutor))
                    where += " AND Detalle_de_Solicitud_Solicitante.Extension_tutor >= " + filter.FromExtension_tutor;
                if (!string.IsNullOrEmpty(filter.ToExtension_tutor))
                    where += " AND Detalle_de_Solicitud_Solicitante.Extension_tutor <= " + filter.ToExtension_tutor;
            }

            if (!string.IsNullOrEmpty(filter.Celular_tutor))
            {
                switch (filter.Celular_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Celular_tutor LIKE '" + filter.Celular_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Celular_tutor LIKE '%" + filter.Celular_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Celular_tutor = '" + filter.Celular_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Celular_tutor LIKE '%" + filter.Celular_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Electronico_tutor))
            {
                switch (filter.Correo_Electronico_tutorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Correo_Electronico_tutor LIKE '" + filter.Correo_Electronico_tutor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Correo_Electronico_tutor LIKE '%" + filter.Correo_Electronico_tutor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Correo_Electronico_tutor = '" + filter.Correo_Electronico_tutor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Correo_Electronico_tutor LIKE '%" + filter.Correo_Electronico_tutor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais_de_Origen_T))
            {
                switch (filter.Pais_de_Origen_TFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais_de_Origen_T + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_de_Origen_T + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais_de_Origen_T + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_de_Origen_T + "%'";
                        break;
                }
            }
            else if (filter.AdvancePais_de_Origen_TMultiple != null && filter.AdvancePais_de_Origen_TMultiple.Count() > 0)
            {
                var Pais_de_Origen_TIds = string.Join(",", filter.AdvancePais_de_Origen_TMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Pais_de_Origen_T In (" + Pais_de_Origen_TIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Originario_de_T))
            {
                switch (filter.Originario_de_TFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Originario_de_T LIKE '" + filter.Originario_de_T + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Originario_de_T LIKE '%" + filter.Originario_de_T + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Originario_de_T = '" + filter.Originario_de_T + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Originario_de_T LIKE '%" + filter.Originario_de_T + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Titulo_del_Hecho))
            {
                switch (filter.Titulo_del_HechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Titulo_del_Hecho LIKE '" + filter.Titulo_del_Hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Titulo_del_Hecho LIKE '%" + filter.Titulo_del_Hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Titulo_del_Hecho = '" + filter.Titulo_del_Hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Titulo_del_Hecho LIKE '%" + filter.Titulo_del_Hecho + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Narrativa_Breve_de_los_Hechos))
            {
                switch (filter.Narrativa_Breve_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Narrativa_Breve_de_los_Hechos LIKE '" + filter.Narrativa_Breve_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Narrativa_Breve_de_los_Hechos LIKE '%" + filter.Narrativa_Breve_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Narrativa_Breve_de_los_Hechos = '" + filter.Narrativa_Breve_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Narrativa_Breve_de_los_Hechos LIKE '%" + filter.Narrativa_Breve_de_los_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_del_Hecho) || !string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
            {
                var Fecha_del_HechoFrom = DateTime.ParseExact(filter.FromFecha_del_Hecho, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_del_HechoTo = DateTime.ParseExact(filter.ToFecha_del_Hecho, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_del_Hecho))
                    where += " AND Detalle_de_Solicitud_Solicitante.Fecha_del_Hecho >= '" + Fecha_del_HechoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
                    where += " AND Detalle_de_Solicitud_Solicitante.Fecha_del_Hecho <= '" + Fecha_del_HechoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Aproximada_del_Hecho) || !string.IsNullOrEmpty(filter.ToHora_Aproximada_del_Hecho))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Aproximada_del_Hecho))
                    where += " AND Convert(TIME,Detalle_de_Solicitud_Solicitante.Hora_Aproximada_del_Hecho) >='" + filter.FromHora_Aproximada_del_Hecho + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Aproximada_del_Hecho))
                    where += " AND Convert(TIME,Detalle_de_Solicitud_Solicitante.Hora_Aproximada_del_Hecho) <='" + filter.ToHora_Aproximada_del_Hecho + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceLugar_de_los_Hechos))
            {
                switch (filter.Lugar_de_los_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Lugar_Tipo.Descripcion LIKE '" + filter.AdvanceLugar_de_los_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Lugar_Tipo.Descripcion LIKE '%" + filter.AdvanceLugar_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Lugar_Tipo.Descripcion = '" + filter.AdvanceLugar_de_los_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Lugar_Tipo.Descripcion LIKE '%" + filter.AdvanceLugar_de_los_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceLugar_de_los_HechosMultiple != null && filter.AdvanceLugar_de_los_HechosMultiple.Count() > 0)
            {
                var Lugar_de_los_HechosIds = string.Join(",", filter.AdvanceLugar_de_los_HechosMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Lugar_de_los_Hechos In (" + Lugar_de_los_HechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais_Hechos))
            {
                switch (filter.Pais_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvancePais_HechosMultiple != null && filter.AdvancePais_HechosMultiple.Count() > 0)
            {
                var Pais_HechosIds = string.Join(",", filter.AdvancePais_HechosMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Pais_Hechos In (" + Pais_HechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_Hechos))
            {
                switch (filter.Estado_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_HechosMultiple != null && filter.AdvanceEstado_HechosMultiple.Count() > 0)
            {
                var Estado_HechosIds = string.Join(",", filter.AdvanceEstado_HechosMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Estado_Hechos In (" + Estado_HechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_Hechos))
            {
                switch (filter.Municipio_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_HechosMultiple != null && filter.AdvanceMunicipio_HechosMultiple.Count() > 0)
            {
                var Municipio_HechosIds = string.Join(",", filter.AdvanceMunicipio_HechosMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Municipio_Hechos In (" + Municipio_HechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia_Hechos))
            {
                switch (filter.Colonia_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_Hechos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia_HechosMultiple != null && filter.AdvanceColonia_HechosMultiple.Count() > 0)
            {
                var Colonia_HechosIds = string.Join(",", filter.AdvanceColonia_HechosMultiple);

                where += " AND Detalle_de_Solicitud_Solicitante.Colonia_Hechos In (" + Colonia_HechosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_Hechos) || !string.IsNullOrEmpty(filter.ToCodigo_Postal_Hechos))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_Hechos))
                    where += " AND Detalle_de_Solicitud_Solicitante.Codigo_Postal_Hechos >= " + filter.FromCodigo_Postal_Hechos;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal_Hechos))
                    where += " AND Detalle_de_Solicitud_Solicitante.Codigo_Postal_Hechos <= " + filter.ToCodigo_Postal_Hechos;
            }

            if (!string.IsNullOrEmpty(filter.Calle_Hechos))
            {
                switch (filter.Calle_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Calle_Hechos LIKE '" + filter.Calle_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Calle_Hechos LIKE '%" + filter.Calle_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Calle_Hechos = '" + filter.Calle_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Calle_Hechos LIKE '%" + filter.Calle_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior_Hechos))
            {
                switch (filter.Numero_Exterior_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Exterior_Hechos LIKE '" + filter.Numero_Exterior_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Exterior_Hechos LIKE '%" + filter.Numero_Exterior_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Exterior_Hechos = '" + filter.Numero_Exterior_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Exterior_Hechos LIKE '%" + filter.Numero_Exterior_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior_Hechos))
            {
                switch (filter.Numero_Interior_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Interior_Hechos LIKE '" + filter.Numero_Interior_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Interior_Hechos LIKE '%" + filter.Numero_Interior_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Interior_Hechos = '" + filter.Numero_Interior_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Numero_Interior_Hechos LIKE '%" + filter.Numero_Interior_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle_Hechos))
            {
                switch (filter.Entre_Calle_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Entre_Calle_Hechos LIKE '" + filter.Entre_Calle_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Entre_Calle_Hechos LIKE '%" + filter.Entre_Calle_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Entre_Calle_Hechos = '" + filter.Entre_Calle_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Entre_Calle_Hechos LIKE '%" + filter.Entre_Calle_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.y_Calle_Hechos))
            {
                switch (filter.y_Calle_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.y_Calle_Hechos LIKE '" + filter.y_Calle_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.y_Calle_Hechos LIKE '%" + filter.y_Calle_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.y_Calle_Hechos = '" + filter.y_Calle_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.y_Calle_Hechos LIKE '%" + filter.y_Calle_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud_Hechos))
            {
                switch (filter.Longitud_HechosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Longitud_Hechos LIKE '" + filter.Longitud_Hechos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Longitud_Hechos LIKE '%" + filter.Longitud_Hechos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Longitud_Hechos = '" + filter.Longitud_Hechos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Longitud_Hechos LIKE '%" + filter.Longitud_Hechos + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud_H))
            {
                switch (filter.Latitud_HFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Latitud_H LIKE '" + filter.Latitud_H + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Latitud_H LIKE '%" + filter.Latitud_H + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Latitud_H = '" + filter.Latitud_H + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Latitud_H LIKE '%" + filter.Latitud_H + "%'";
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
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Solicitud_Solicitante varDetalle_de_Solicitud_Solicitante = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Solicitud_SolicitanteModel varDetalle_de_Solicitud_Solicitante)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_Solicitud_SolicitanteInfo = new Detalle_de_Solicitud_Solicitante
                    {
                        Clave = varDetalle_de_Solicitud_Solicitante.Clave
                        ,idRegistroAT = varDetalle_de_Solicitud_Solicitante.idRegistroAT
                        ,idRegistroUI = varDetalle_de_Solicitud_Solicitante.idRegistroUI
                        ,Solicitud = varDetalle_de_Solicitud_Solicitante.Solicitud
                        ,Nombre = varDetalle_de_Solicitud_Solicitante.Nombre
                        ,Apellido_Paterno = varDetalle_de_Solicitud_Solicitante.Apellido_Paterno
                        ,Apellido_Materno = varDetalle_de_Solicitud_Solicitante.Apellido_Materno
                        ,Nombre_Completo = varDetalle_de_Solicitud_Solicitante.Nombre_Completo
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Solicitante.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Solicitante.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,CURP = varDetalle_de_Solicitud_Solicitante.CURP
                        ,RFC = varDetalle_de_Solicitud_Solicitante.RFC
                        ,Edad = varDetalle_de_Solicitud_Solicitante.Edad
                        ,Sexo = varDetalle_de_Solicitud_Solicitante.Sexo
                        ,Estado_Civil = varDetalle_de_Solicitud_Solicitante.Estado_Civil
                        ,Tipo_de_Identificacion = varDetalle_de_Solicitud_Solicitante.Tipo_de_Identificacion
                        ,Numero_de_Indentificacion = varDetalle_de_Solicitud_Solicitante.Numero_de_Indentificacion
                        ,Nacionalidad = varDetalle_de_Solicitud_Solicitante.Nacionalidad
                        ,Escolaridad = varDetalle_de_Solicitud_Solicitante.Escolaridad
                        ,Ocupacion = varDetalle_de_Solicitud_Solicitante.Ocupacion
                        ,Pais = varDetalle_de_Solicitud_Solicitante.Pais
                        ,Estado = varDetalle_de_Solicitud_Solicitante.Estado
                        ,Municipio = varDetalle_de_Solicitud_Solicitante.Municipio
                        ,Codigo_Postal = varDetalle_de_Solicitud_Solicitante.Codigo_Postal
                        ,Poblacion = varDetalle_de_Solicitud_Solicitante.Poblacion
                        ,Colonia = varDetalle_de_Solicitud_Solicitante.Colonia
                        ,Calle = varDetalle_de_Solicitud_Solicitante.Calle
                        ,Numero_Exterior = varDetalle_de_Solicitud_Solicitante.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Solicitud_Solicitante.Numero_Interior
                        ,Entre_Calle = varDetalle_de_Solicitud_Solicitante.Entre_Calle
                        ,Y_Calle = varDetalle_de_Solicitud_Solicitante.Y_Calle
                        ,Longitud = varDetalle_de_Solicitud_Solicitante.Longitud
                        ,Latitud = varDetalle_de_Solicitud_Solicitante.Latitud
                        ,Telefono = varDetalle_de_Solicitud_Solicitante.Telefono
                        ,Celular = varDetalle_de_Solicitud_Solicitante.Celular
                        ,Correo_Electronico = varDetalle_de_Solicitud_Solicitante.Correo_Electronico
                        ,Pais_de_Origen = varDetalle_de_Solicitud_Solicitante.Pais_de_Origen
                        ,Originario_de = varDetalle_de_Solicitud_Solicitante.Originario_de
                        ,Tipo_de_Compareciente = varDetalle_de_Solicitud_Solicitante.Tipo_de_Compareciente
                        ,Incapaz = varDetalle_de_Solicitud_Solicitante.Incapaz
                        ,Tipo_de_Inimputabilidad = varDetalle_de_Solicitud_Solicitante.Tipo_de_Inimputabilidad
                        ,Nombre_tutor = varDetalle_de_Solicitud_Solicitante.Nombre_tutor
                        ,Apellido_Paterno_tutor = varDetalle_de_Solicitud_Solicitante.Apellido_Paterno_tutor
                        ,Apellido_Materno_tutor = varDetalle_de_Solicitud_Solicitante.Apellido_Materno_tutor
                        ,Nombre_Completo_tutor = varDetalle_de_Solicitud_Solicitante.Nombre_Completo_tutor
                        ,Fecha_de_Nacimiento_tutor = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Solicitante.Fecha_de_Nacimiento_tutor)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Solicitante.Fecha_de_Nacimiento_tutor, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,CURP_Tutor = varDetalle_de_Solicitud_Solicitante.CURP_Tutor
                        ,RFC_Tutor = varDetalle_de_Solicitud_Solicitante.RFC_Tutor
                        ,Edad_tutor = varDetalle_de_Solicitud_Solicitante.Edad_tutor
                        ,Sexo_tutor = varDetalle_de_Solicitud_Solicitante.Sexo_tutor
                        ,Estado_Civil_tutor = varDetalle_de_Solicitud_Solicitante.Estado_Civil_tutor
                        ,Tipo_de_Identificacion_tutor = varDetalle_de_Solicitud_Solicitante.Tipo_de_Identificacion_tutor
                        ,Numero_de_Identificacion_tutor = varDetalle_de_Solicitud_Solicitante.Numero_de_Identificacion_tutor
                        ,Nacionalidad_tutor = varDetalle_de_Solicitud_Solicitante.Nacionalidad_tutor
                        ,Escolaridad_tutor = varDetalle_de_Solicitud_Solicitante.Escolaridad_tutor
                        ,Ocupacion_tutor = varDetalle_de_Solicitud_Solicitante.Ocupacion_tutor
                        ,Pais_tutor = varDetalle_de_Solicitud_Solicitante.Pais_tutor
                        ,Estado_tutor = varDetalle_de_Solicitud_Solicitante.Estado_tutor
                        ,Municipio_tutor = varDetalle_de_Solicitud_Solicitante.Municipio_tutor
                        ,Localidad_tutor = varDetalle_de_Solicitud_Solicitante.Localidad_tutor
                        ,Colonia_tutor = varDetalle_de_Solicitud_Solicitante.Colonia_tutor
                        ,Codigo_Postal_tutor = varDetalle_de_Solicitud_Solicitante.Codigo_Postal_tutor
                        ,Calle_tutor = varDetalle_de_Solicitud_Solicitante.Calle_tutor
                        ,Numero_Exterior_tutor = varDetalle_de_Solicitud_Solicitante.Numero_Exterior_tutor
                        ,Numero_Interior_tutor = varDetalle_de_Solicitud_Solicitante.Numero_Interior_tutor
                        ,Telefono_tutor = varDetalle_de_Solicitud_Solicitante.Telefono_tutor
                        ,Extension_tutor = varDetalle_de_Solicitud_Solicitante.Extension_tutor
                        ,Celular_tutor = varDetalle_de_Solicitud_Solicitante.Celular_tutor
                        ,Correo_Electronico_tutor = varDetalle_de_Solicitud_Solicitante.Correo_Electronico_tutor
                        ,Pais_de_Origen_T = varDetalle_de_Solicitud_Solicitante.Pais_de_Origen_T
                        ,Originario_de_T = varDetalle_de_Solicitud_Solicitante.Originario_de_T
                        ,Titulo_del_Hecho = varDetalle_de_Solicitud_Solicitante.Titulo_del_Hecho
                        ,Narrativa_Breve_de_los_Hechos = varDetalle_de_Solicitud_Solicitante.Narrativa_Breve_de_los_Hechos
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Solicitante.Fecha_del_Hecho)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Solicitante.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Aproximada_del_Hecho = varDetalle_de_Solicitud_Solicitante.Hora_Aproximada_del_Hecho
                        ,Lugar_de_los_Hechos = varDetalle_de_Solicitud_Solicitante.Lugar_de_los_Hechos
                        ,Pais_Hechos = varDetalle_de_Solicitud_Solicitante.Pais_Hechos
                        ,Estado_Hechos = varDetalle_de_Solicitud_Solicitante.Estado_Hechos
                        ,Municipio_Hechos = varDetalle_de_Solicitud_Solicitante.Municipio_Hechos
                        ,Colonia_Hechos = varDetalle_de_Solicitud_Solicitante.Colonia_Hechos
                        ,Codigo_Postal_Hechos = varDetalle_de_Solicitud_Solicitante.Codigo_Postal_Hechos
                        ,Calle_Hechos = varDetalle_de_Solicitud_Solicitante.Calle_Hechos
                        ,Numero_Exterior_Hechos = varDetalle_de_Solicitud_Solicitante.Numero_Exterior_Hechos
                        ,Numero_Interior_Hechos = varDetalle_de_Solicitud_Solicitante.Numero_Interior_Hechos
                        ,Entre_Calle_Hechos = varDetalle_de_Solicitud_Solicitante.Entre_Calle_Hechos
                        ,y_Calle_Hechos = varDetalle_de_Solicitud_Solicitante.y_Calle_Hechos
                        ,Longitud_Hechos = varDetalle_de_Solicitud_Solicitante.Longitud_Hechos
                        ,Latitud_H = varDetalle_de_Solicitud_Solicitante.Latitud_H

                    };

                    result = !IsNew ?
                        _IDetalle_de_Solicitud_SolicitanteApiConsumer.Update(Detalle_de_Solicitud_SolicitanteInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Solicitud_SolicitanteApiConsumer.Insert(Detalle_de_Solicitud_SolicitanteInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Detalle_de_Solicitud_Solicitante script
        /// </summary>
        /// <param name="oDetalle_de_Solicitud_SolicitanteElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_de_Solicitud_SolicitanteModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Solicitud_SolicitanteModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Solicitud_SolicitanteModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Solicitud_SolicitanteModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Solicitud_SolicitanteModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Solicitud_SolicitanteModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Solicitud_SolicitanteModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Solicitud_SolicitanteModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_de_Solicitud_SolicitanteModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_de_Solicitud_SolicitanteModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_de_Solicitud_SolicitanteModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_de_Solicitud_SolicitanteModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_de_Solicitud_SolicitanteModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_de_Solicitud_SolicitanteScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitud_Solicitante.js")))
            {
                strDetalle_de_Solicitud_SolicitanteScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Solicitud_Solicitante element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Solicitud_SolicitanteModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Solicitud_SolicitanteScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Solicitud_SolicitanteScript.Substring(indexOfArray, strDetalle_de_Solicitud_SolicitanteScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Solicitud_SolicitanteModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Solicitud_SolicitanteModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Solicitud_SolicitanteScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_de_Solicitud_SolicitanteScript.Substring(indexOfArrayHistory, strDetalle_de_Solicitud_SolicitanteScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_de_Solicitud_SolicitanteScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Solicitud_SolicitanteScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Solicitud_SolicitanteScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_de_Solicitud_SolicitanteModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_de_Solicitud_SolicitanteModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitud_Solicitante.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitud_Solicitante.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitud_Solicitante.js")))
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
        public ActionResult Detalle_de_Solicitud_SolicitantePropertyBag()
        {
            return PartialView("Detalle_de_Solicitud_SolicitantePropertyBag", "Detalle_de_Solicitud_Solicitante");
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
                var whereClauseFormat = "Object = 45090 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_de_Solicitud_Solicitante.Clave= " + RecordId;
                            var result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Solicitud_SolicitantePropertyMapper());
			
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
                    (Detalle_de_Solicitud_SolicitanteAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_de_Solicitud_SolicitantePropertyMapper oDetalle_de_Solicitud_SolicitantePropertyMapper = new Detalle_de_Solicitud_SolicitantePropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Solicitud_SolicitantePropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitud_Solicitantes == null)
                result.Detalle_de_Solicitud_Solicitantes = new List<Detalle_de_Solicitud_Solicitante>();

            var data = result.Detalle_de_Solicitud_Solicitantes.Select(m => new Detalle_de_Solicitud_SolicitanteGridModel
            {
                Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,CURP = m.CURP
			,RFC = m.RFC
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Indentificacion = m.Numero_de_Indentificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Longitud = m.Longitud
			,Latitud = m.Latitud
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Incapaz = m.Incapaz
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Nombre_tutor = m.Nombre_tutor
			,Apellido_Paterno_tutor = m.Apellido_Paterno_tutor
			,Apellido_Materno_tutor = m.Apellido_Materno_tutor
			,Nombre_Completo_tutor = m.Nombre_Completo_tutor
                        ,Fecha_de_Nacimiento_tutor = (m.Fecha_de_Nacimiento_tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_tutor).ToString(ConfigurationProperty.DateFormat))
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor
			,Edad_tutor = m.Edad_tutor
                        ,Sexo_tutorDescripcion = CultureHelper.GetTraduction(m.Sexo_tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_tutor_Genero.Descripcion
                        ,Estado_Civil_tutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_tutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_tutor = m.Numero_de_Identificacion_tutor
                        ,Nacionalidad_tutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_tutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_tutor_Escolaridad.Descripcion
                        ,Ocupacion_tutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_tutor_Ocupacion.Descripcion
                        ,Pais_tutorNombre = CultureHelper.GetTraduction(m.Pais_tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_tutor_Pais.Nombre
                        ,Estado_tutorNombre = CultureHelper.GetTraduction(m.Estado_tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_tutor_Estado.Nombre
                        ,Municipio_tutorNombre = CultureHelper.GetTraduction(m.Municipio_tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_tutor_Municipio.Nombre
                        ,Localidad_tutorDescripcion = CultureHelper.GetTraduction(m.Localidad_tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_tutor_Localidad.Descripcion
                        ,Colonia_tutorNombre = CultureHelper.GetTraduction(m.Colonia_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_tutor_Colonia.Nombre
			,Codigo_Postal_tutor = m.Codigo_Postal_tutor
			,Calle_tutor = m.Calle_tutor
			,Numero_Exterior_tutor = m.Numero_Exterior_tutor
			,Numero_Interior_tutor = m.Numero_Interior_tutor
			,Telefono_tutor = m.Telefono_tutor
			,Extension_tutor = m.Extension_tutor
			,Celular_tutor = m.Celular_tutor
			,Correo_Electronico_tutor = m.Correo_Electronico_tutor
                        ,Pais_de_Origen_TNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_T_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_T_Pais.Nombre
			,Originario_de_T = m.Originario_de_T
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Lugar_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Lugar_de_los_Hechos_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_los_Hechos_Lugar_Tipo.Descripcion
                        ,Pais_HechosNombre = CultureHelper.GetTraduction(m.Pais_Hechos_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Hechos_Pais.Nombre
                        ,Estado_HechosNombre = CultureHelper.GetTraduction(m.Estado_Hechos_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Hechos_Estado.Nombre
                        ,Municipio_HechosNombre = CultureHelper.GetTraduction(m.Municipio_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Hechos_Municipio.Nombre
                        ,Colonia_HechosNombre = CultureHelper.GetTraduction(m.Colonia_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Hechos_Colonia.Nombre
			,Codigo_Postal_Hechos = m.Codigo_Postal_Hechos
			,Calle_Hechos = m.Calle_Hechos
			,Numero_Exterior_Hechos = m.Numero_Exterior_Hechos
			,Numero_Interior_Hechos = m.Numero_Interior_Hechos
			,Entre_Calle_Hechos = m.Entre_Calle_Hechos
			,y_Calle_Hechos = m.y_Calle_Hechos
			,Longitud_Hechos = m.Longitud_Hechos
			,Latitud_H = m.Latitud_H

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45090, arrayColumnsVisible), "Detalle_de_Solicitud_SolicitanteList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45090, arrayColumnsVisible), "Detalle_de_Solicitud_SolicitanteList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45090, arrayColumnsVisible), "Detalle_de_Solicitud_SolicitanteList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Solicitud_SolicitantePropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_de_Solicitud_SolicitanteAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_de_Solicitud_SolicitantePropertyMapper oDetalle_de_Solicitud_SolicitantePropertyMapper = new Detalle_de_Solicitud_SolicitantePropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Solicitud_SolicitantePropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitud_Solicitantes == null)
                result.Detalle_de_Solicitud_Solicitantes = new List<Detalle_de_Solicitud_Solicitante>();

            var data = result.Detalle_de_Solicitud_Solicitantes.Select(m => new Detalle_de_Solicitud_SolicitanteGridModel
            {
                Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,CURP = m.CURP
			,RFC = m.RFC
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Indentificacion = m.Numero_de_Indentificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Longitud = m.Longitud
			,Latitud = m.Latitud
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Incapaz = m.Incapaz
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Nombre_tutor = m.Nombre_tutor
			,Apellido_Paterno_tutor = m.Apellido_Paterno_tutor
			,Apellido_Materno_tutor = m.Apellido_Materno_tutor
			,Nombre_Completo_tutor = m.Nombre_Completo_tutor
                        ,Fecha_de_Nacimiento_tutor = (m.Fecha_de_Nacimiento_tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_tutor).ToString(ConfigurationProperty.DateFormat))
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor
			,Edad_tutor = m.Edad_tutor
                        ,Sexo_tutorDescripcion = CultureHelper.GetTraduction(m.Sexo_tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_tutor_Genero.Descripcion
                        ,Estado_Civil_tutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_tutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_tutor = m.Numero_de_Identificacion_tutor
                        ,Nacionalidad_tutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_tutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_tutor_Escolaridad.Descripcion
                        ,Ocupacion_tutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_tutor_Ocupacion.Descripcion
                        ,Pais_tutorNombre = CultureHelper.GetTraduction(m.Pais_tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_tutor_Pais.Nombre
                        ,Estado_tutorNombre = CultureHelper.GetTraduction(m.Estado_tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_tutor_Estado.Nombre
                        ,Municipio_tutorNombre = CultureHelper.GetTraduction(m.Municipio_tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_tutor_Municipio.Nombre
                        ,Localidad_tutorDescripcion = CultureHelper.GetTraduction(m.Localidad_tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_tutor_Localidad.Descripcion
                        ,Colonia_tutorNombre = CultureHelper.GetTraduction(m.Colonia_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_tutor_Colonia.Nombre
			,Codigo_Postal_tutor = m.Codigo_Postal_tutor
			,Calle_tutor = m.Calle_tutor
			,Numero_Exterior_tutor = m.Numero_Exterior_tutor
			,Numero_Interior_tutor = m.Numero_Interior_tutor
			,Telefono_tutor = m.Telefono_tutor
			,Extension_tutor = m.Extension_tutor
			,Celular_tutor = m.Celular_tutor
			,Correo_Electronico_tutor = m.Correo_Electronico_tutor
                        ,Pais_de_Origen_TNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_T_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_T_Pais.Nombre
			,Originario_de_T = m.Originario_de_T
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Lugar_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Lugar_de_los_Hechos_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_los_Hechos_Lugar_Tipo.Descripcion
                        ,Pais_HechosNombre = CultureHelper.GetTraduction(m.Pais_Hechos_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Hechos_Pais.Nombre
                        ,Estado_HechosNombre = CultureHelper.GetTraduction(m.Estado_Hechos_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Hechos_Estado.Nombre
                        ,Municipio_HechosNombre = CultureHelper.GetTraduction(m.Municipio_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Hechos_Municipio.Nombre
                        ,Colonia_HechosNombre = CultureHelper.GetTraduction(m.Colonia_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Hechos_Colonia.Nombre
			,Codigo_Postal_Hechos = m.Codigo_Postal_Hechos
			,Calle_Hechos = m.Calle_Hechos
			,Numero_Exterior_Hechos = m.Numero_Exterior_Hechos
			,Numero_Interior_Hechos = m.Numero_Interior_Hechos
			,Entre_Calle_Hechos = m.Entre_Calle_Hechos
			,y_Calle_Hechos = m.y_Calle_Hechos
			,Longitud_Hechos = m.Longitud_Hechos
			,Latitud_H = m.Latitud_H

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
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_de_Solicitud_Solicitante_Datos_GeneralesModel varDetalle_de_Solicitud_Solicitante)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Solicitud_Solicitante_Datos_GeneralesInfo = new Detalle_de_Solicitud_Solicitante_Datos_Generales
                {
                    Clave = varDetalle_de_Solicitud_Solicitante.Clave
                                            ,idRegistroAT = varDetalle_de_Solicitud_Solicitante.idRegistroAT
                        ,idRegistroUI = varDetalle_de_Solicitud_Solicitante.idRegistroUI
                        ,Solicitud = varDetalle_de_Solicitud_Solicitante.Solicitud
                        ,Nombre = varDetalle_de_Solicitud_Solicitante.Nombre
                        ,Apellido_Paterno = varDetalle_de_Solicitud_Solicitante.Apellido_Paterno
                        ,Apellido_Materno = varDetalle_de_Solicitud_Solicitante.Apellido_Materno
                        ,Nombre_Completo = varDetalle_de_Solicitud_Solicitante.Nombre_Completo
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Solicitante.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Solicitante.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,CURP = varDetalle_de_Solicitud_Solicitante.CURP
                        ,RFC = varDetalle_de_Solicitud_Solicitante.RFC
                        ,Edad = varDetalle_de_Solicitud_Solicitante.Edad
                        ,Sexo = varDetalle_de_Solicitud_Solicitante.Sexo
                        ,Estado_Civil = varDetalle_de_Solicitud_Solicitante.Estado_Civil
                        ,Tipo_de_Identificacion = varDetalle_de_Solicitud_Solicitante.Tipo_de_Identificacion
                        ,Numero_de_Indentificacion = varDetalle_de_Solicitud_Solicitante.Numero_de_Indentificacion
                        ,Nacionalidad = varDetalle_de_Solicitud_Solicitante.Nacionalidad
                        ,Escolaridad = varDetalle_de_Solicitud_Solicitante.Escolaridad
                        ,Ocupacion = varDetalle_de_Solicitud_Solicitante.Ocupacion
                        ,Pais = varDetalle_de_Solicitud_Solicitante.Pais
                        ,Estado = varDetalle_de_Solicitud_Solicitante.Estado
                        ,Municipio = varDetalle_de_Solicitud_Solicitante.Municipio
                        ,Codigo_Postal = varDetalle_de_Solicitud_Solicitante.Codigo_Postal
                        ,Poblacion = varDetalle_de_Solicitud_Solicitante.Poblacion
                        ,Colonia = varDetalle_de_Solicitud_Solicitante.Colonia
                        ,Calle = varDetalle_de_Solicitud_Solicitante.Calle
                        ,Numero_Exterior = varDetalle_de_Solicitud_Solicitante.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Solicitud_Solicitante.Numero_Interior
                        ,Entre_Calle = varDetalle_de_Solicitud_Solicitante.Entre_Calle
                        ,Y_Calle = varDetalle_de_Solicitud_Solicitante.Y_Calle
                        ,Longitud = varDetalle_de_Solicitud_Solicitante.Longitud
                        ,Latitud = varDetalle_de_Solicitud_Solicitante.Latitud
                        ,Telefono = varDetalle_de_Solicitud_Solicitante.Telefono
                        ,Celular = varDetalle_de_Solicitud_Solicitante.Celular
                        ,Correo_Electronico = varDetalle_de_Solicitud_Solicitante.Correo_Electronico
                        ,Pais_de_Origen = varDetalle_de_Solicitud_Solicitante.Pais_de_Origen
                        ,Originario_de = varDetalle_de_Solicitud_Solicitante.Originario_de
                        ,Tipo_de_Compareciente = varDetalle_de_Solicitud_Solicitante.Tipo_de_Compareciente
                        ,Incapaz = varDetalle_de_Solicitud_Solicitante.Incapaz
                        ,Tipo_de_Inimputabilidad = varDetalle_de_Solicitud_Solicitante.Tipo_de_Inimputabilidad
                    
                };

                result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.Update_Datos_Generales(Detalle_de_Solicitud_Solicitante_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Solicitud_SolicitanteApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Detalle_de_Solicitud_Solicitante_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,Solicitud = m.Solicitud
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,CURP = m.CURP
			,RFC = m.RFC
			,Edad = m.Edad
                        ,Sexo = m.Sexo
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_Civil = m.Estado_Civil
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion = m.Tipo_de_Identificacion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Indentificacion = m.Numero_de_Indentificacion
                        ,Nacionalidad = m.Nacionalidad
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,Escolaridad = m.Escolaridad
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,Ocupacion = m.Ocupacion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,Pais = m.Pais
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Pais.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,Poblacion = m.Poblacion
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,Colonia = m.Colonia
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Entre_Calle = m.Entre_Calle
			,Y_Calle = m.Y_Calle
			,Longitud = m.Longitud
			,Latitud = m.Latitud
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Pais_de_Origen = m.Pais_de_Origen
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Originario_de = m.Originario_de
                        ,Tipo_de_Compareciente = m.Tipo_de_Compareciente
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Incapaz = m.Incapaz
                        ,Tipo_de_Inimputabilidad = m.Tipo_de_Inimputabilidad
                        ,Tipo_de_InimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Inimputabilidad_Tipo_de_Inimputabilidad.Descripcion

                    
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
        public ActionResult Post_Datos_del_Tutor(Detalle_de_Solicitud_Solicitante_Datos_del_TutorModel varDetalle_de_Solicitud_Solicitante)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Solicitud_Solicitante_Datos_del_TutorInfo = new Detalle_de_Solicitud_Solicitante_Datos_del_Tutor
                {
                    Clave = varDetalle_de_Solicitud_Solicitante.Clave
                                            ,Nombre_tutor = varDetalle_de_Solicitud_Solicitante.Nombre_tutor
                        ,Apellido_Paterno_tutor = varDetalle_de_Solicitud_Solicitante.Apellido_Paterno_tutor
                        ,Apellido_Materno_tutor = varDetalle_de_Solicitud_Solicitante.Apellido_Materno_tutor
                        ,Nombre_Completo_tutor = varDetalle_de_Solicitud_Solicitante.Nombre_Completo_tutor
                        ,Fecha_de_Nacimiento_tutor = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Solicitante.Fecha_de_Nacimiento_tutor)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Solicitante.Fecha_de_Nacimiento_tutor, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,CURP_Tutor = varDetalle_de_Solicitud_Solicitante.CURP_Tutor
                        ,RFC_Tutor = varDetalle_de_Solicitud_Solicitante.RFC_Tutor
                        ,Edad_tutor = varDetalle_de_Solicitud_Solicitante.Edad_tutor
                        ,Sexo_tutor = varDetalle_de_Solicitud_Solicitante.Sexo_tutor
                        ,Estado_Civil_tutor = varDetalle_de_Solicitud_Solicitante.Estado_Civil_tutor
                        ,Tipo_de_Identificacion_tutor = varDetalle_de_Solicitud_Solicitante.Tipo_de_Identificacion_tutor
                        ,Numero_de_Identificacion_tutor = varDetalle_de_Solicitud_Solicitante.Numero_de_Identificacion_tutor
                        ,Nacionalidad_tutor = varDetalle_de_Solicitud_Solicitante.Nacionalidad_tutor
                        ,Escolaridad_tutor = varDetalle_de_Solicitud_Solicitante.Escolaridad_tutor
                        ,Ocupacion_tutor = varDetalle_de_Solicitud_Solicitante.Ocupacion_tutor
                        ,Pais_tutor = varDetalle_de_Solicitud_Solicitante.Pais_tutor
                        ,Estado_tutor = varDetalle_de_Solicitud_Solicitante.Estado_tutor
                        ,Municipio_tutor = varDetalle_de_Solicitud_Solicitante.Municipio_tutor
                        ,Localidad_tutor = varDetalle_de_Solicitud_Solicitante.Localidad_tutor
                        ,Colonia_tutor = varDetalle_de_Solicitud_Solicitante.Colonia_tutor
                        ,Codigo_Postal_tutor = varDetalle_de_Solicitud_Solicitante.Codigo_Postal_tutor
                        ,Calle_tutor = varDetalle_de_Solicitud_Solicitante.Calle_tutor
                        ,Numero_Exterior_tutor = varDetalle_de_Solicitud_Solicitante.Numero_Exterior_tutor
                        ,Numero_Interior_tutor = varDetalle_de_Solicitud_Solicitante.Numero_Interior_tutor
                        ,Telefono_tutor = varDetalle_de_Solicitud_Solicitante.Telefono_tutor
                        ,Extension_tutor = varDetalle_de_Solicitud_Solicitante.Extension_tutor
                        ,Celular_tutor = varDetalle_de_Solicitud_Solicitante.Celular_tutor
                        ,Correo_Electronico_tutor = varDetalle_de_Solicitud_Solicitante.Correo_Electronico_tutor
                        ,Pais_de_Origen_T = varDetalle_de_Solicitud_Solicitante.Pais_de_Origen_T
                        ,Originario_de_T = varDetalle_de_Solicitud_Solicitante.Originario_de_T
                    
                };

                result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.Update_Datos_del_Tutor(Detalle_de_Solicitud_Solicitante_Datos_del_TutorInfo).Resource.ToString();
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
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Solicitud_SolicitanteApiConsumer.Get_Datos_del_Tutor(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Detalle_de_Solicitud_Solicitante_Datos_del_TutorModel
                {
                    Clave = m.Clave
			,Nombre_tutor = m.Nombre_tutor
			,Apellido_Paterno_tutor = m.Apellido_Paterno_tutor
			,Apellido_Materno_tutor = m.Apellido_Materno_tutor
			,Nombre_Completo_tutor = m.Nombre_Completo_tutor
                        ,Fecha_de_Nacimiento_tutor = (m.Fecha_de_Nacimiento_tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_tutor).ToString(ConfigurationProperty.DateFormat))
			,CURP_Tutor = m.CURP_Tutor
			,RFC_Tutor = m.RFC_Tutor
			,Edad_tutor = m.Edad_tutor
                        ,Sexo_tutor = m.Sexo_tutor
                        ,Sexo_tutorDescripcion = CultureHelper.GetTraduction(m.Sexo_tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_tutor_Genero.Descripcion
                        ,Estado_Civil_tutor = m.Estado_Civil_tutor
                        ,Estado_Civil_tutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_tutor = m.Tipo_de_Identificacion_tutor
                        ,Tipo_de_Identificacion_tutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_tutor = m.Numero_de_Identificacion_tutor
                        ,Nacionalidad_tutor = m.Nacionalidad_tutor
                        ,Nacionalidad_tutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_tutor = m.Escolaridad_tutor
                        ,Escolaridad_tutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_tutor_Escolaridad.Descripcion
                        ,Ocupacion_tutor = m.Ocupacion_tutor
                        ,Ocupacion_tutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_tutor_Ocupacion.Descripcion
                        ,Pais_tutor = m.Pais_tutor
                        ,Pais_tutorNombre = CultureHelper.GetTraduction(m.Pais_tutor_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_tutor_Pais.Nombre
                        ,Estado_tutor = m.Estado_tutor
                        ,Estado_tutorNombre = CultureHelper.GetTraduction(m.Estado_tutor_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_tutor_Estado.Nombre
                        ,Municipio_tutor = m.Municipio_tutor
                        ,Municipio_tutorNombre = CultureHelper.GetTraduction(m.Municipio_tutor_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_tutor_Municipio.Nombre
                        ,Localidad_tutor = m.Localidad_tutor
                        ,Localidad_tutorDescripcion = CultureHelper.GetTraduction(m.Localidad_tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_tutor_Localidad.Descripcion
                        ,Colonia_tutor = m.Colonia_tutor
                        ,Colonia_tutorNombre = CultureHelper.GetTraduction(m.Colonia_tutor_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_tutor_Colonia.Nombre
			,Codigo_Postal_tutor = m.Codigo_Postal_tutor
			,Calle_tutor = m.Calle_tutor
			,Numero_Exterior_tutor = m.Numero_Exterior_tutor
			,Numero_Interior_tutor = m.Numero_Interior_tutor
			,Telefono_tutor = m.Telefono_tutor
			,Extension_tutor = m.Extension_tutor
			,Celular_tutor = m.Celular_tutor
			,Correo_Electronico_tutor = m.Correo_Electronico_tutor
                        ,Pais_de_Origen_T = m.Pais_de_Origen_T
                        ,Pais_de_Origen_TNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_T_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_de_Origen_T_Pais.Nombre
			,Originario_de_T = m.Originario_de_T

                    
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
        public ActionResult Post_Datos_de_los_Hechos(Detalle_de_Solicitud_Solicitante_Datos_de_los_HechosModel varDetalle_de_Solicitud_Solicitante)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Solicitud_Solicitante_Datos_de_los_HechosInfo = new Detalle_de_Solicitud_Solicitante_Datos_de_los_Hechos
                {
                    Clave = varDetalle_de_Solicitud_Solicitante.Clave
                                            ,Titulo_del_Hecho = varDetalle_de_Solicitud_Solicitante.Titulo_del_Hecho
                        ,Narrativa_Breve_de_los_Hechos = varDetalle_de_Solicitud_Solicitante.Narrativa_Breve_de_los_Hechos
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Solicitante.Fecha_del_Hecho)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Solicitante.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Aproximada_del_Hecho = varDetalle_de_Solicitud_Solicitante.Hora_Aproximada_del_Hecho
                        ,Lugar_de_los_Hechos = varDetalle_de_Solicitud_Solicitante.Lugar_de_los_Hechos
                        ,Pais_Hechos = varDetalle_de_Solicitud_Solicitante.Pais_Hechos
                        ,Estado_Hechos = varDetalle_de_Solicitud_Solicitante.Estado_Hechos
                        ,Municipio_Hechos = varDetalle_de_Solicitud_Solicitante.Municipio_Hechos
                        ,Colonia_Hechos = varDetalle_de_Solicitud_Solicitante.Colonia_Hechos
                        ,Codigo_Postal_Hechos = varDetalle_de_Solicitud_Solicitante.Codigo_Postal_Hechos
                        ,Calle_Hechos = varDetalle_de_Solicitud_Solicitante.Calle_Hechos
                        ,Numero_Exterior_Hechos = varDetalle_de_Solicitud_Solicitante.Numero_Exterior_Hechos
                        ,Numero_Interior_Hechos = varDetalle_de_Solicitud_Solicitante.Numero_Interior_Hechos
                        ,Entre_Calle_Hechos = varDetalle_de_Solicitud_Solicitante.Entre_Calle_Hechos
                        ,y_Calle_Hechos = varDetalle_de_Solicitud_Solicitante.y_Calle_Hechos
                        ,Longitud_Hechos = varDetalle_de_Solicitud_Solicitante.Longitud_Hechos
                        ,Latitud_H = varDetalle_de_Solicitud_Solicitante.Latitud_H
                    
                };

                result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.Update_Datos_de_los_Hechos(Detalle_de_Solicitud_Solicitante_Datos_de_los_HechosInfo).Resource.ToString();
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
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Solicitud_SolicitanteApiConsumer.Get_Datos_de_los_Hechos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Detalle_de_Solicitud_Solicitante_Datos_de_los_HechosModel
                {
                    Clave = m.Clave
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Lugar_de_los_Hechos = m.Lugar_de_los_Hechos
                        ,Lugar_de_los_HechosDescripcion = CultureHelper.GetTraduction(m.Lugar_de_los_Hechos_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_los_Hechos_Lugar_Tipo.Descripcion
                        ,Pais_Hechos = m.Pais_Hechos
                        ,Pais_HechosNombre = CultureHelper.GetTraduction(m.Pais_Hechos_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_Hechos_Pais.Nombre
                        ,Estado_Hechos = m.Estado_Hechos
                        ,Estado_HechosNombre = CultureHelper.GetTraduction(m.Estado_Hechos_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Hechos_Estado.Nombre
                        ,Municipio_Hechos = m.Municipio_Hechos
                        ,Municipio_HechosNombre = CultureHelper.GetTraduction(m.Municipio_Hechos_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Hechos_Municipio.Nombre
                        ,Colonia_Hechos = m.Colonia_Hechos
                        ,Colonia_HechosNombre = CultureHelper.GetTraduction(m.Colonia_Hechos_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Hechos_Colonia.Nombre
			,Codigo_Postal_Hechos = m.Codigo_Postal_Hechos
			,Calle_Hechos = m.Calle_Hechos
			,Numero_Exterior_Hechos = m.Numero_Exterior_Hechos
			,Numero_Interior_Hechos = m.Numero_Interior_Hechos
			,Entre_Calle_Hechos = m.Entre_Calle_Hechos
			,y_Calle_Hechos = m.y_Calle_Hechos
			,Longitud_Hechos = m.Longitud_Hechos
			,Latitud_H = m.Latitud_H

                    
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

