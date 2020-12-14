using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Orientador;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Idioma;
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
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Zona;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Grupo_del_Delito;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Circunstancia_del_Delito;
using Spartane.Core.Domain.Tipo_Delito;
using Spartane.Core.Domain.Forma_Comision_Delito;
using Spartane.Core.Domain.Forma_Accion_Delito;
using Spartane.Core.Domain.Modalidad_Delito;
using Spartane.Core.Domain.Elementos_Comision_Delito;
using Spartane.Core.Domain.Circunstancia_Vehiculo;
using Spartane.Core.Domain.Especifica_Vehiculo;
using Spartane.Core.Domain.Marca_del_Vehiculo;
using Spartane.Core.Domain.Sub_Marca_del_Vehiculo;
using Spartane.Core.Domain.Tipo_de_Vehiculo;
using Spartane.Core.Domain.Color_Vehiculo;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Aseguradora_de_Vehiculo;
using Spartane.Core.Domain.Servicio_del_Vehiculo;
using Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo;
using Spartane.Core.Domain.Circunstancia_Defuncion;
using Spartane.Core.Domain.Consecuencia_Defuncion;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Zona;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Zona;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Procedencia_del_Vehiculo;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Orientador;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Orientador;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Idioma;
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
using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Zona;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Grupo_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Delito;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Delito;
using Spartane.Web.Areas.WebApiConsumer.Forma_Comision_Delito;
using Spartane.Web.Areas.WebApiConsumer.Forma_Accion_Delito;
using Spartane.Web.Areas.WebApiConsumer.Modalidad_Delito;
using Spartane.Web.Areas.WebApiConsumer.Elementos_Comision_Delito;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Especifica_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Marca_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Sub_Marca_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Color_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Aseguradora_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Servicio_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Modalidad_de_Robo_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_Defuncion;
using Spartane.Web.Areas.WebApiConsumer.Consecuencia_Defuncion;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Zona;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Zona;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Procedencia_del_Vehiculo;

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
    public class OrientadorController : Controller
    {
        #region "variable declaration"

        private IOrientadorService service = null;
        private IOrientadorApiConsumer _IOrientadorApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IIdiomaApiConsumer _IIdiomaApiConsumer;
        private IGeneroApiConsumer _IGeneroApiConsumer;
        private IEstado_CivilApiConsumer _IEstado_CivilApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private INacionalidadApiConsumer _INacionalidadApiConsumer;
        private IEscolaridadApiConsumer _IEscolaridadApiConsumer;
        private IOcupacionApiConsumer _IOcupacionApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private ILocalidadApiConsumer _ILocalidadApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private ILugar_TipoApiConsumer _ILugar_TipoApiConsumer;
        private IZonaApiConsumer _IZonaApiConsumer;
        private IGrupo_del_DelitoApiConsumer _IGrupo_del_DelitoApiConsumer;
        private IDelitoApiConsumer _IDelitoApiConsumer;
        private ICircunstancia_del_DelitoApiConsumer _ICircunstancia_del_DelitoApiConsumer;
        private ITipo_DelitoApiConsumer _ITipo_DelitoApiConsumer;
        private IForma_Comision_DelitoApiConsumer _IForma_Comision_DelitoApiConsumer;
        private IForma_Accion_DelitoApiConsumer _IForma_Accion_DelitoApiConsumer;
        private IModalidad_DelitoApiConsumer _IModalidad_DelitoApiConsumer;
        private IElementos_Comision_DelitoApiConsumer _IElementos_Comision_DelitoApiConsumer;
        private ICircunstancia_VehiculoApiConsumer _ICircunstancia_VehiculoApiConsumer;
        private IEspecifica_VehiculoApiConsumer _IEspecifica_VehiculoApiConsumer;
        private IMarca_del_VehiculoApiConsumer _IMarca_del_VehiculoApiConsumer;
        private ISub_Marca_del_VehiculoApiConsumer _ISub_Marca_del_VehiculoApiConsumer;
        private ITipo_de_VehiculoApiConsumer _ITipo_de_VehiculoApiConsumer;
        private IColor_VehiculoApiConsumer _IColor_VehiculoApiConsumer;
        private IAseguradora_de_VehiculoApiConsumer _IAseguradora_de_VehiculoApiConsumer;
        private IServicio_del_VehiculoApiConsumer _IServicio_del_VehiculoApiConsumer;
        private IModalidad_de_Robo_de_VehiculoApiConsumer _IModalidad_de_Robo_de_VehiculoApiConsumer;
        private ICircunstancia_DefuncionApiConsumer _ICircunstancia_DefuncionApiConsumer;
        private IConsecuencia_DefuncionApiConsumer _IConsecuencia_DefuncionApiConsumer;
        private ITipo_de_ComparecienteApiConsumer _ITipo_de_ComparecienteApiConsumer;
        private IProcedencia_del_VehiculoApiConsumer _IProcedencia_del_VehiculoApiConsumer;

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

        
        public OrientadorController(IOrientadorService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IOrientadorApiConsumer OrientadorApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IIdiomaApiConsumer IdiomaApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IEscolaridadApiConsumer EscolaridadApiConsumer , IOcupacionApiConsumer OcupacionApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , ILocalidadApiConsumer LocalidadApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IEstadoApiConsumer EstadoApiConsumer , ILugar_TipoApiConsumer Lugar_TipoApiConsumer , IZonaApiConsumer ZonaApiConsumer , IGrupo_del_DelitoApiConsumer Grupo_del_DelitoApiConsumer , IDelitoApiConsumer DelitoApiConsumer , ICircunstancia_del_DelitoApiConsumer Circunstancia_del_DelitoApiConsumer , ITipo_DelitoApiConsumer Tipo_DelitoApiConsumer , IForma_Comision_DelitoApiConsumer Forma_Comision_DelitoApiConsumer , IForma_Accion_DelitoApiConsumer Forma_Accion_DelitoApiConsumer , IModalidad_DelitoApiConsumer Modalidad_DelitoApiConsumer , IElementos_Comision_DelitoApiConsumer Elementos_Comision_DelitoApiConsumer , ICircunstancia_VehiculoApiConsumer Circunstancia_VehiculoApiConsumer , IEspecifica_VehiculoApiConsumer Especifica_VehiculoApiConsumer , IMarca_del_VehiculoApiConsumer Marca_del_VehiculoApiConsumer , ISub_Marca_del_VehiculoApiConsumer Sub_Marca_del_VehiculoApiConsumer , ITipo_de_VehiculoApiConsumer Tipo_de_VehiculoApiConsumer , IColor_VehiculoApiConsumer Color_VehiculoApiConsumer , IAseguradora_de_VehiculoApiConsumer Aseguradora_de_VehiculoApiConsumer , IServicio_del_VehiculoApiConsumer Servicio_del_VehiculoApiConsumer , IModalidad_de_Robo_de_VehiculoApiConsumer Modalidad_de_Robo_de_VehiculoApiConsumer , ICircunstancia_DefuncionApiConsumer Circunstancia_DefuncionApiConsumer , IConsecuencia_DefuncionApiConsumer Consecuencia_DefuncionApiConsumer , ITipo_de_ComparecienteApiConsumer Tipo_de_ComparecienteApiConsumer , IProcedencia_del_VehiculoApiConsumer Procedencia_del_VehiculoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IOrientadorApiConsumer = OrientadorApiConsumer;
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
            this._IIdiomaApiConsumer = IdiomaApiConsumer;
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
            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IZonaApiConsumer = ZonaApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IGrupo_del_DelitoApiConsumer = Grupo_del_DelitoApiConsumer;
            this._IDelitoApiConsumer = DelitoApiConsumer;
            this._ICircunstancia_del_DelitoApiConsumer = Circunstancia_del_DelitoApiConsumer;
            this._ITipo_DelitoApiConsumer = Tipo_DelitoApiConsumer;
            this._IForma_Comision_DelitoApiConsumer = Forma_Comision_DelitoApiConsumer;
            this._IForma_Accion_DelitoApiConsumer = Forma_Accion_DelitoApiConsumer;
            this._IModalidad_DelitoApiConsumer = Modalidad_DelitoApiConsumer;
            this._IElementos_Comision_DelitoApiConsumer = Elementos_Comision_DelitoApiConsumer;
            this._ICircunstancia_VehiculoApiConsumer = Circunstancia_VehiculoApiConsumer;
            this._IEspecifica_VehiculoApiConsumer = Especifica_VehiculoApiConsumer;
            this._IMarca_del_VehiculoApiConsumer = Marca_del_VehiculoApiConsumer;
            this._ISub_Marca_del_VehiculoApiConsumer = Sub_Marca_del_VehiculoApiConsumer;
            this._ITipo_de_VehiculoApiConsumer = Tipo_de_VehiculoApiConsumer;
            this._IColor_VehiculoApiConsumer = Color_VehiculoApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IAseguradora_de_VehiculoApiConsumer = Aseguradora_de_VehiculoApiConsumer;
            this._IServicio_del_VehiculoApiConsumer = Servicio_del_VehiculoApiConsumer;
            this._IModalidad_de_Robo_de_VehiculoApiConsumer = Modalidad_de_Robo_de_VehiculoApiConsumer;
            this._ICircunstancia_DefuncionApiConsumer = Circunstancia_DefuncionApiConsumer;
            this._IConsecuencia_DefuncionApiConsumer = Consecuencia_DefuncionApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IZonaApiConsumer = ZonaApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._ITipo_de_ComparecienteApiConsumer = Tipo_de_ComparecienteApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IZonaApiConsumer = ZonaApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IProcedencia_del_VehiculoApiConsumer = Procedencia_del_VehiculoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Orientador
        [ObjectAuth(ObjectId = (ModuleObjectId)44998, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44998, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Orientador/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)44998, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44998, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varOrientador = new OrientadorModel();
			varOrientador.Clave = Id;
			
            ViewBag.ObjectId = "44998";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
                var OrientadorsData = _IOrientadorApiConsumer.ListaSelAll(0, 1000, "Orientador.Clave=" + Id, "").Resource.Orientadors;
				
				if (OrientadorsData != null && OrientadorsData.Count > 0)
                {
					var OrientadorData = OrientadorsData.First();
					varOrientador= new OrientadorModel
					{
						Clave  = OrientadorData.Clave 
	                    ,Fecha_de_Registro = (OrientadorData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(OrientadorData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = OrientadorData.Hora_de_Registro
                    ,Usuario_que_Registra = OrientadorData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Usuario_que_Registra), "Spartan_User") ??  (string)OrientadorData.Usuario_que_Registra_Spartan_User.Name
                    ,Atencion_Medica = OrientadorData.Atencion_Medica.GetValueOrDefault()
                    ,Atencion_Psicologica = OrientadorData.Atencion_Psicologica.GetValueOrDefault()
                    ,Traductor = OrientadorData.Traductor.GetValueOrDefault()
                    ,Narrativa_DM = OrientadorData.Narrativa_DM
                    ,Narrativa_DP = OrientadorData.Narrativa_DP
                    ,Idioma = OrientadorData.Idioma
                    ,IdiomaDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Idioma), "Idioma") ??  (string)OrientadorData.Idioma_Idioma.Descripcion
                    ,Nombre = OrientadorData.Nombre
                    ,Apellido_Paterno = OrientadorData.Apellido_Paterno
                    ,Apellido_Materno = OrientadorData.Apellido_Materno
                    ,Fecha_de_Nacimiento = (OrientadorData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(OrientadorData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = OrientadorData.Edad
                    ,Sexo = OrientadorData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Sexo), "Genero") ??  (string)OrientadorData.Sexo_Genero.Descripcion
                    ,Estado_Civil = OrientadorData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Estado_Civil), "Estado_Civil") ??  (string)OrientadorData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = OrientadorData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)OrientadorData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = OrientadorData.Numero_de_Identificacion
                    ,Nacionalidad = OrientadorData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Nacionalidad), "Nacionalidad") ??  (string)OrientadorData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = OrientadorData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Escolaridad), "Escolaridad") ??  (string)OrientadorData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = OrientadorData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Ocupacion), "Ocupacion") ??  (string)OrientadorData.Ocupacion_Ocupacion.Descripcion
                    ,Calle = OrientadorData.Calle
                    ,Numero_Exterior = OrientadorData.Numero_Exterior
                    ,Numero_Interior = OrientadorData.Numero_Interior
                    ,Colonia = OrientadorData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Colonia), "Colonia") ??  (string)OrientadorData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = OrientadorData.Codigo_Postal
                    ,Localidad = OrientadorData.Localidad
                    ,LocalidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Localidad), "Localidad") ??  (string)OrientadorData.Localidad_Localidad.Descripcion
                    ,Municipio = OrientadorData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Municipio), "Municipio") ??  (string)OrientadorData.Municipio_Municipio.Nombre
                    ,Estado = OrientadorData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Estado), "Estado") ??  (string)OrientadorData.Estado_Estado.Nombre
                    ,Telefono = OrientadorData.Telefono
                    ,Celular = OrientadorData.Celular
                    ,Correo_Electronico = OrientadorData.Correo_Electronico
                    ,Fecha_del_Hecho = (OrientadorData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(OrientadorData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Aproximada_del_Hecho = OrientadorData.Hora_Aproximada_del_Hecho
                    ,Tipo_de_Lugar_del_Hecho = OrientadorData.Tipo_de_Lugar_del_Hecho
                    ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Tipo_de_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)OrientadorData.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,Calle2 = OrientadorData.Calle2
                    ,Numero_Exterior2 = OrientadorData.Numero_Exterior2
                    ,Numero_Interior2 = OrientadorData.Numero_Interior2
                    ,Colonia2 = OrientadorData.Colonia2
                    ,Colonia2Nombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Colonia2), "Colonia") ??  (string)OrientadorData.Colonia2_Colonia.Nombre
                    ,Codigo_Postal2 = OrientadorData.Codigo_Postal2
                    ,Zona = OrientadorData.Zona
                    ,ZonaDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Zona), "Zona") ??  (string)OrientadorData.Zona_Zona.Descripcion
                    ,Municipio2 = OrientadorData.Municipio2
                    ,Municipio2Nombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Municipio2), "Municipio") ??  (string)OrientadorData.Municipio2_Municipio.Nombre
                    ,Estado2 = OrientadorData.Estado2
                    ,Estado2Nombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Estado2), "Estado") ??  (string)OrientadorData.Estado2_Estado.Nombre
                    ,Grupo_Delito = OrientadorData.Grupo_Delito
                    ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Grupo_Delito), "Grupo_del_Delito") ??  (string)OrientadorData.Grupo_Delito_Grupo_del_Delito.Descripcion
                    ,Delito = OrientadorData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Delito), "Delito") ??  (string)OrientadorData.Delito_Delito.Descripcion
                    ,Circunstancia = OrientadorData.Circunstancia
                    ,CircunstanciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Circunstancia), "Circunstancia_del_Delito") ??  (string)OrientadorData.Circunstancia_Circunstancia_del_Delito.Descripcion
                    ,Tipo_Delito = OrientadorData.Tipo_Delito
                    ,Tipo_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Tipo_Delito), "Tipo_Delito") ??  (string)OrientadorData.Tipo_Delito_Tipo_Delito.Descripcion
                    ,Forma_Comision_Delito = OrientadorData.Forma_Comision_Delito
                    ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Forma_Comision_Delito), "Forma_Comision_Delito") ??  (string)OrientadorData.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                    ,Forma_Accion_Delito = OrientadorData.Forma_Accion_Delito
                    ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Forma_Accion_Delito), "Forma_Accion_Delito") ??  (string)OrientadorData.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                    ,Modalidad_Delito = OrientadorData.Modalidad_Delito
                    ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Modalidad_Delito), "Modalidad_Delito") ??  (string)OrientadorData.Modalidad_Delito_Modalidad_Delito.Descripcion
                    ,Elementos_Comision_Delito = OrientadorData.Elementos_Comision_Delito
                    ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Elementos_Comision_Delito), "Elementos_Comision_Delito") ??  (string)OrientadorData.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
                    ,Monto = OrientadorData.Monto
                    ,HViolencia_de_Genero = OrientadorData.HViolencia_de_Genero.GetValueOrDefault()
                    ,Calificacion_del_Delito = OrientadorData.Calificacion_del_Delito
                    ,CircunstanciaV = OrientadorData.CircunstanciaV
                    ,CircunstanciaVDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.CircunstanciaV), "Circunstancia_Vehiculo") ??  (string)OrientadorData.CircunstanciaV_Circunstancia_Vehiculo.Descripcion
                    ,Clase_Especifica = OrientadorData.Clase_Especifica
                    ,Clase_EspecificaDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Clase_Especifica), "Especifica_Vehiculo") ??  (string)OrientadorData.Clase_Especifica_Especifica_Vehiculo.Descripcion
                    ,Marca = OrientadorData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Marca), "Marca_del_Vehiculo") ??  (string)OrientadorData.Marca_Marca_del_Vehiculo.Descripcion
                    ,Sub_Marca = OrientadorData.Sub_Marca
                    ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Sub_Marca), "Sub_Marca_del_Vehiculo") ??  (string)OrientadorData.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                    ,Tipo_de_Vehiculo = OrientadorData.Tipo_de_Vehiculo
                    ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Tipo_de_Vehiculo), "Tipo_de_Vehiculo") ??  (string)OrientadorData.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
                    ,Modelo = OrientadorData.Modelo
                    ,Color = OrientadorData.Color
                    ,ColorDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Color), "Color_Vehiculo") ??  (string)OrientadorData.Color_Color_Vehiculo.Descripcion
                    ,Placas = OrientadorData.Placas
                    ,Estado_Placas = OrientadorData.Estado_Placas
                    ,Estado_PlacasNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Estado_Placas), "Estado") ??  (string)OrientadorData.Estado_Placas_Estado.Nombre
                    ,Vehiculo_Robado = OrientadorData.Vehiculo_Robado.GetValueOrDefault()
                    ,Seguro = OrientadorData.Seguro.GetValueOrDefault()
                    ,Aseguradora = OrientadorData.Aseguradora
                    ,AseguradoraDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Aseguradora), "Aseguradora_de_Vehiculo") ??  (string)OrientadorData.Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                    ,Tipo_de_Servicio = OrientadorData.Tipo_de_Servicio
                    ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Tipo_de_Servicio), "Servicio_del_Vehiculo") ??  (string)OrientadorData.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
                    ,Ruta_del_Servicio_Publico = OrientadorData.Ruta_del_Servicio_Publico
                    ,Mercancia = OrientadorData.Mercancia.GetValueOrDefault()
                    ,Descripcion = OrientadorData.Descripcion
                    ,Monto_de_la_Carga = OrientadorData.Monto_de_la_Carga
                    ,Senas_Particulares = OrientadorData.Senas_Particulares
                    ,Modalidad_del_Robo = OrientadorData.Modalidad_del_Robo
                    ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Modalidad_del_Robo), "Modalidad_de_Robo_de_Vehiculo") ??  (string)OrientadorData.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
                    ,Circunstancia_Defuncion = OrientadorData.Circunstancia_Defuncion
                    ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Circunstancia_Defuncion), "Circunstancia_Defuncion") ??  (string)OrientadorData.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                    ,Consecuencia_Defuncion = OrientadorData.Consecuencia_Defuncion
                    ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Consecuencia_Defuncion), "Consecuencia_Defuncion") ??  (string)OrientadorData.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                    ,Fecha_Levantamiento = (OrientadorData.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(OrientadorData.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Levantamiento = OrientadorData.Hora_Levantamiento
                    ,Domicilio = OrientadorData.Domicilio
                    ,Numero_Interior3 = OrientadorData.Numero_Interior3
                    ,Numero_Exterior3 = OrientadorData.Numero_Exterior3
                    ,Colonia3 = OrientadorData.Colonia3
                    ,Colonia3Nombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Colonia3), "Colonia") ??  (string)OrientadorData.Colonia3_Colonia.Nombre
                    ,Colonia_no_Catalogada = OrientadorData.Colonia_no_Catalogada
                    ,Zona2 = OrientadorData.Zona2
                    ,Zona2Descripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Zona2), "Zona") ??  (string)OrientadorData.Zona2_Zona.Descripcion
                    ,Municipio3 = OrientadorData.Municipio3
                    ,Municipio3Nombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Municipio3), "Municipio") ??  (string)OrientadorData.Municipio3_Municipio.Nombre
                    ,Estado3 = OrientadorData.Estado3
                    ,Estado3Nombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Estado3), "Estado") ??  (string)OrientadorData.Estado3_Estado.Nombre
                    ,Necropsia = OrientadorData.Necropsia
                    ,Cronotanatodiagnostico = OrientadorData.Cronotanatodiagnostico
                    ,Ruta = OrientadorData.Ruta
                    ,Estado_Operador = OrientadorData.Estado_Operador.GetValueOrDefault()
                    ,Delito_Principal_o_Secundario = OrientadorData.Delito_Principal_o_Secundario.GetValueOrDefault()
                    ,Concurso = OrientadorData.Concurso
                    ,Compareciente = OrientadorData.Compareciente
                    ,ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Compareciente), "Tipo_de_Compareciente") ??  (string)OrientadorData.Compareciente_Tipo_de_Compareciente.Descripcion
                    ,NombreC = OrientadorData.NombreC
                    ,Apellido_PaternoC = OrientadorData.Apellido_PaternoC
                    ,Apellido_MaternoC = OrientadorData.Apellido_MaternoC
                    ,NombreT = OrientadorData.NombreT
                    ,Apellido_PaternoT = OrientadorData.Apellido_PaternoT
                    ,Apellido_MaternoT = OrientadorData.Apellido_MaternoT
                    ,CalleC = OrientadorData.CalleC
                    ,Numero_ExteriorC = OrientadorData.Numero_ExteriorC
                    ,Numero_InteriorC = OrientadorData.Numero_InteriorC
                    ,ColoniaC = OrientadorData.ColoniaC
                    ,ColoniaCNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.ColoniaC), "Colonia") ??  (string)OrientadorData.ColoniaC_Colonia.Nombre
                    ,Codigo_PostalC = OrientadorData.Codigo_PostalC
                    ,ZonaC = OrientadorData.ZonaC
                    ,ZonaCDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.ZonaC), "Zona") ??  (string)OrientadorData.ZonaC_Zona.Descripcion
                    ,MunicipioC = OrientadorData.MunicipioC
                    ,MunicipioCNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.MunicipioC), "Municipio") ??  (string)OrientadorData.MunicipioC_Municipio.Nombre
                    ,EstadoC = OrientadorData.EstadoC
                    ,EstadoCNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.EstadoC), "Estado") ??  (string)OrientadorData.EstadoC_Estado.Nombre
                    ,NarrativaC = OrientadorData.NarrativaC
                    ,Conocido = OrientadorData.Conocido.GetValueOrDefault()
                    ,Desconocido = OrientadorData.Desconocido.GetValueOrDefault()
                    ,Numero_de_Imputados = OrientadorData.Numero_de_Imputados
                    ,Procedencia = OrientadorData.Procedencia
                    ,ProcedenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Procedencia), "Procedencia_del_Vehiculo") ??  (string)OrientadorData.Procedencia_Procedencia_del_Vehiculo.Descripcion
                    ,Motor = OrientadorData.Motor
                    ,Serie = OrientadorData.Serie
                    ,Causa_de_Muerte = OrientadorData.Causa_de_Muerte
                    ,Entre_Calle = OrientadorData.Entre_Calle
                    ,Entre_Calle2 = OrientadorData.Entre_Calle2
                    ,Autoriza = OrientadorData.Autoriza.GetValueOrDefault()
                    ,Autoriza2 = OrientadorData.Autoriza2.GetValueOrDefault()
                    ,Autoriza3 = OrientadorData.Autoriza3.GetValueOrDefault()
                    ,Menor_de_Edad = OrientadorData.Menor_de_Edad.GetValueOrDefault()

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
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad != null && Localidads_Localidad.Resource != null)
                ViewBag.Localidads_Localidad = Localidads_Localidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia2 = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia2 != null && Colonias_Colonia2.Resource != null)
                ViewBag.Colonias_Colonia2 = Colonias_Colonia2.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
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
            var Municipios_Municipio2 = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio2 != null && Municipios_Municipio2.Resource != null)
                ViewBag.Municipios_Municipio2 = Municipios_Municipio2.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado2 = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado2 != null && Estados_Estado2.Resource != null)
                ViewBag.Estados_Estado2 = Estados_Estado2.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_del_Delitos_Grupo_Delito = _IGrupo_del_DelitoApiConsumer.SelAll(true);
            if (Grupo_del_Delitos_Grupo_Delito != null && Grupo_del_Delitos_Grupo_Delito.Resource != null)
                ViewBag.Grupo_del_Delitos_Grupo_Delito = Grupo_del_Delitos_Grupo_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_del_Delitos_Circunstancia = _ICircunstancia_del_DelitoApiConsumer.SelAll(true);
            if (Circunstancia_del_Delitos_Circunstancia != null && Circunstancia_del_Delitos_Circunstancia.Resource != null)
                ViewBag.Circunstancia_del_Delitos_Circunstancia = Circunstancia_del_Delitos_Circunstancia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Delitos_Tipo_Delito = _ITipo_DelitoApiConsumer.SelAll(true);
            if (Tipo_Delitos_Tipo_Delito != null && Tipo_Delitos_Tipo_Delito.Resource != null)
                ViewBag.Tipo_Delitos_Tipo_Delito = Tipo_Delitos_Tipo_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Comision_Delitos_Forma_Comision_Delito = _IForma_Comision_DelitoApiConsumer.SelAll(true);
            if (Forma_Comision_Delitos_Forma_Comision_Delito != null && Forma_Comision_Delitos_Forma_Comision_Delito.Resource != null)
                ViewBag.Forma_Comision_Delitos_Forma_Comision_Delito = Forma_Comision_Delitos_Forma_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Accion_Delitos_Forma_Accion_Delito = _IForma_Accion_DelitoApiConsumer.SelAll(true);
            if (Forma_Accion_Delitos_Forma_Accion_Delito != null && Forma_Accion_Delitos_Forma_Accion_Delito.Resource != null)
                ViewBag.Forma_Accion_Delitos_Forma_Accion_Delito = Forma_Accion_Delitos_Forma_Accion_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad_Delito = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad_Delito != null && Modalidad_Delitos_Modalidad_Delito.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad_Delito = Modalidad_Delitos_Modalidad_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elementos_Comision_Delitos_Elementos_Comision_Delito = _IElementos_Comision_DelitoApiConsumer.SelAll(true);
            if (Elementos_Comision_Delitos_Elementos_Comision_Delito != null && Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource != null)
                ViewBag.Elementos_Comision_Delitos_Elementos_Comision_Delito = Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elementos_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Vehiculos_CircunstanciaV = _ICircunstancia_VehiculoApiConsumer.SelAll(true);
            if (Circunstancia_Vehiculos_CircunstanciaV != null && Circunstancia_Vehiculos_CircunstanciaV.Resource != null)
                ViewBag.Circunstancia_Vehiculos_CircunstanciaV = Circunstancia_Vehiculos_CircunstanciaV.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecifica_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especifica_Vehiculos_Clase_Especifica = _IEspecifica_VehiculoApiConsumer.SelAll(true);
            if (Especifica_Vehiculos_Clase_Especifica != null && Especifica_Vehiculos_Clase_Especifica.Resource != null)
                ViewBag.Especifica_Vehiculos_Clase_Especifica = Especifica_Vehiculos_Clase_Especifica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especifica_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_del_Vehiculos_Marca = _IMarca_del_VehiculoApiConsumer.SelAll(true);
            if (Marca_del_Vehiculos_Marca != null && Marca_del_Vehiculos_Marca.Resource != null)
                ViewBag.Marca_del_Vehiculos_Marca = Marca_del_Vehiculos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sub_Marca_del_Vehiculos_Sub_Marca = _ISub_Marca_del_VehiculoApiConsumer.SelAll(true);
            if (Sub_Marca_del_Vehiculos_Sub_Marca != null && Sub_Marca_del_Vehiculos_Sub_Marca.Resource != null)
                ViewBag.Sub_Marca_del_Vehiculos_Sub_Marca = Sub_Marca_del_Vehiculos_Sub_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_Vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_Vehiculo != null && Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_Vehiculo = Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Vehiculos_Color = _IColor_VehiculoApiConsumer.SelAll(true);
            if (Color_Vehiculos_Color != null && Color_Vehiculos_Color.Resource != null)
                ViewBag.Color_Vehiculos_Color = Color_Vehiculos_Color.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_Placas = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_Placas != null && Estados_Estado_Placas.Resource != null)
                ViewBag.Estados_Estado_Placas = Estados_Estado_Placas.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Aseguradora_de_Vehiculos_Aseguradora = _IAseguradora_de_VehiculoApiConsumer.SelAll(true);
            if (Aseguradora_de_Vehiculos_Aseguradora != null && Aseguradora_de_Vehiculos_Aseguradora.Resource != null)
                ViewBag.Aseguradora_de_Vehiculos_Aseguradora = Aseguradora_de_Vehiculos_Aseguradora.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Aseguradora_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_del_Vehiculos_Tipo_de_Servicio = _IServicio_del_VehiculoApiConsumer.SelAll(true);
            if (Servicio_del_Vehiculos_Tipo_de_Servicio != null && Servicio_del_Vehiculos_Tipo_de_Servicio.Resource != null)
                ViewBag.Servicio_del_Vehiculos_Tipo_de_Servicio = Servicio_del_Vehiculos_Tipo_de_Servicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_de_Robo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = _IModalidad_de_Robo_de_VehiculoApiConsumer.SelAll(true);
            if (Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo != null && Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource != null)
                ViewBag.Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_de_Robo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Defuncions_Circunstancia_Defuncion = _ICircunstancia_DefuncionApiConsumer.SelAll(true);
            if (Circunstancia_Defuncions_Circunstancia_Defuncion != null && Circunstancia_Defuncions_Circunstancia_Defuncion.Resource != null)
                ViewBag.Circunstancia_Defuncions_Circunstancia_Defuncion = Circunstancia_Defuncions_Circunstancia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Consecuencia_Defuncions_Consecuencia_Defuncion = _IConsecuencia_DefuncionApiConsumer.SelAll(true);
            if (Consecuencia_Defuncions_Consecuencia_Defuncion != null && Consecuencia_Defuncions_Consecuencia_Defuncion.Resource != null)
                ViewBag.Consecuencia_Defuncions_Consecuencia_Defuncion = Consecuencia_Defuncions_Consecuencia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Consecuencia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia3 = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia3 != null && Colonias_Colonia3.Resource != null)
                ViewBag.Colonias_Colonia3 = Colonias_Colonia3.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_Zona2 = _IZonaApiConsumer.SelAll(true);
            if (Zonas_Zona2 != null && Zonas_Zona2.Resource != null)
                ViewBag.Zonas_Zona2 = Zonas_Zona2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio3 = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio3 != null && Municipios_Municipio3.Resource != null)
                ViewBag.Municipios_Municipio3 = Municipios_Municipio3.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado3 = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado3 != null && Estados_Estado3.Resource != null)
                ViewBag.Estados_Estado3 = Estados_Estado3.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Compareciente != null && Tipo_de_Comparecientes_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Compareciente = Tipo_de_Comparecientes_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_ColoniaC = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_ColoniaC != null && Colonias_ColoniaC.Resource != null)
                ViewBag.Colonias_ColoniaC = Colonias_ColoniaC.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_ZonaC = _IZonaApiConsumer.SelAll(true);
            if (Zonas_ZonaC != null && Zonas_ZonaC.Resource != null)
                ViewBag.Zonas_ZonaC = Zonas_ZonaC.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_MunicipioC = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_MunicipioC != null && Municipios_MunicipioC.Resource != null)
                ViewBag.Municipios_MunicipioC = Municipios_MunicipioC.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_EstadoC = _IEstadoApiConsumer.SelAll(true);
            if (Estados_EstadoC != null && Estados_EstadoC.Resource != null)
                ViewBag.Estados_EstadoC = Estados_EstadoC.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IProcedencia_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Procedencia_del_Vehiculos_Procedencia = _IProcedencia_del_VehiculoApiConsumer.SelAll(true);
            if (Procedencia_del_Vehiculos_Procedencia != null && Procedencia_del_Vehiculos_Procedencia.Resource != null)
                ViewBag.Procedencia_del_Vehiculos_Procedencia = Procedencia_del_Vehiculos_Procedencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varOrientador);
        }
		
	[HttpGet]
        public ActionResult AddOrientador(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 44998);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
			OrientadorModel varOrientador= new OrientadorModel();


            if (id.ToString() != "0")
            {
                var OrientadorsData = _IOrientadorApiConsumer.ListaSelAll(0, 1000, "Orientador.Clave=" + id, "").Resource.Orientadors;
				
				if (OrientadorsData != null && OrientadorsData.Count > 0)
                {
					var OrientadorData = OrientadorsData.First();
					varOrientador= new OrientadorModel
					{
						Clave  = OrientadorData.Clave 
	                    ,Fecha_de_Registro = (OrientadorData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(OrientadorData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = OrientadorData.Hora_de_Registro
                    ,Usuario_que_Registra = OrientadorData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Usuario_que_Registra), "Spartan_User") ??  (string)OrientadorData.Usuario_que_Registra_Spartan_User.Name
                    ,Atencion_Medica = OrientadorData.Atencion_Medica.GetValueOrDefault()
                    ,Atencion_Psicologica = OrientadorData.Atencion_Psicologica.GetValueOrDefault()
                    ,Traductor = OrientadorData.Traductor.GetValueOrDefault()
                    ,Narrativa_DM = OrientadorData.Narrativa_DM
                    ,Narrativa_DP = OrientadorData.Narrativa_DP
                    ,Idioma = OrientadorData.Idioma
                    ,IdiomaDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Idioma), "Idioma") ??  (string)OrientadorData.Idioma_Idioma.Descripcion
                    ,Nombre = OrientadorData.Nombre
                    ,Apellido_Paterno = OrientadorData.Apellido_Paterno
                    ,Apellido_Materno = OrientadorData.Apellido_Materno
                    ,Fecha_de_Nacimiento = (OrientadorData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(OrientadorData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = OrientadorData.Edad
                    ,Sexo = OrientadorData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Sexo), "Genero") ??  (string)OrientadorData.Sexo_Genero.Descripcion
                    ,Estado_Civil = OrientadorData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Estado_Civil), "Estado_Civil") ??  (string)OrientadorData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = OrientadorData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)OrientadorData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = OrientadorData.Numero_de_Identificacion
                    ,Nacionalidad = OrientadorData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Nacionalidad), "Nacionalidad") ??  (string)OrientadorData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = OrientadorData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Escolaridad), "Escolaridad") ??  (string)OrientadorData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = OrientadorData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Ocupacion), "Ocupacion") ??  (string)OrientadorData.Ocupacion_Ocupacion.Descripcion
                    ,Calle = OrientadorData.Calle
                    ,Numero_Exterior = OrientadorData.Numero_Exterior
                    ,Numero_Interior = OrientadorData.Numero_Interior
                    ,Colonia = OrientadorData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Colonia), "Colonia") ??  (string)OrientadorData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = OrientadorData.Codigo_Postal
                    ,Localidad = OrientadorData.Localidad
                    ,LocalidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Localidad), "Localidad") ??  (string)OrientadorData.Localidad_Localidad.Descripcion
                    ,Municipio = OrientadorData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Municipio), "Municipio") ??  (string)OrientadorData.Municipio_Municipio.Nombre
                    ,Estado = OrientadorData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Estado), "Estado") ??  (string)OrientadorData.Estado_Estado.Nombre
                    ,Telefono = OrientadorData.Telefono
                    ,Celular = OrientadorData.Celular
                    ,Correo_Electronico = OrientadorData.Correo_Electronico
                    ,Fecha_del_Hecho = (OrientadorData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(OrientadorData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Aproximada_del_Hecho = OrientadorData.Hora_Aproximada_del_Hecho
                    ,Tipo_de_Lugar_del_Hecho = OrientadorData.Tipo_de_Lugar_del_Hecho
                    ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Tipo_de_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)OrientadorData.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,Calle2 = OrientadorData.Calle2
                    ,Numero_Exterior2 = OrientadorData.Numero_Exterior2
                    ,Numero_Interior2 = OrientadorData.Numero_Interior2
                    ,Colonia2 = OrientadorData.Colonia2
                    ,Colonia2Nombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Colonia2), "Colonia") ??  (string)OrientadorData.Colonia2_Colonia.Nombre
                    ,Codigo_Postal2 = OrientadorData.Codigo_Postal2
                    ,Zona = OrientadorData.Zona
                    ,ZonaDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Zona), "Zona") ??  (string)OrientadorData.Zona_Zona.Descripcion
                    ,Municipio2 = OrientadorData.Municipio2
                    ,Municipio2Nombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Municipio2), "Municipio") ??  (string)OrientadorData.Municipio2_Municipio.Nombre
                    ,Estado2 = OrientadorData.Estado2
                    ,Estado2Nombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Estado2), "Estado") ??  (string)OrientadorData.Estado2_Estado.Nombre
                    ,Grupo_Delito = OrientadorData.Grupo_Delito
                    ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Grupo_Delito), "Grupo_del_Delito") ??  (string)OrientadorData.Grupo_Delito_Grupo_del_Delito.Descripcion
                    ,Delito = OrientadorData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Delito), "Delito") ??  (string)OrientadorData.Delito_Delito.Descripcion
                    ,Circunstancia = OrientadorData.Circunstancia
                    ,CircunstanciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Circunstancia), "Circunstancia_del_Delito") ??  (string)OrientadorData.Circunstancia_Circunstancia_del_Delito.Descripcion
                    ,Tipo_Delito = OrientadorData.Tipo_Delito
                    ,Tipo_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Tipo_Delito), "Tipo_Delito") ??  (string)OrientadorData.Tipo_Delito_Tipo_Delito.Descripcion
                    ,Forma_Comision_Delito = OrientadorData.Forma_Comision_Delito
                    ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Forma_Comision_Delito), "Forma_Comision_Delito") ??  (string)OrientadorData.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                    ,Forma_Accion_Delito = OrientadorData.Forma_Accion_Delito
                    ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Forma_Accion_Delito), "Forma_Accion_Delito") ??  (string)OrientadorData.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                    ,Modalidad_Delito = OrientadorData.Modalidad_Delito
                    ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Modalidad_Delito), "Modalidad_Delito") ??  (string)OrientadorData.Modalidad_Delito_Modalidad_Delito.Descripcion
                    ,Elementos_Comision_Delito = OrientadorData.Elementos_Comision_Delito
                    ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Elementos_Comision_Delito), "Elementos_Comision_Delito") ??  (string)OrientadorData.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
                    ,Monto = OrientadorData.Monto
                    ,HViolencia_de_Genero = OrientadorData.HViolencia_de_Genero.GetValueOrDefault()
                    ,Calificacion_del_Delito = OrientadorData.Calificacion_del_Delito
                    ,CircunstanciaV = OrientadorData.CircunstanciaV
                    ,CircunstanciaVDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.CircunstanciaV), "Circunstancia_Vehiculo") ??  (string)OrientadorData.CircunstanciaV_Circunstancia_Vehiculo.Descripcion
                    ,Clase_Especifica = OrientadorData.Clase_Especifica
                    ,Clase_EspecificaDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Clase_Especifica), "Especifica_Vehiculo") ??  (string)OrientadorData.Clase_Especifica_Especifica_Vehiculo.Descripcion
                    ,Marca = OrientadorData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Marca), "Marca_del_Vehiculo") ??  (string)OrientadorData.Marca_Marca_del_Vehiculo.Descripcion
                    ,Sub_Marca = OrientadorData.Sub_Marca
                    ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Sub_Marca), "Sub_Marca_del_Vehiculo") ??  (string)OrientadorData.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                    ,Tipo_de_Vehiculo = OrientadorData.Tipo_de_Vehiculo
                    ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Tipo_de_Vehiculo), "Tipo_de_Vehiculo") ??  (string)OrientadorData.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
                    ,Modelo = OrientadorData.Modelo
                    ,Color = OrientadorData.Color
                    ,ColorDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Color), "Color_Vehiculo") ??  (string)OrientadorData.Color_Color_Vehiculo.Descripcion
                    ,Placas = OrientadorData.Placas
                    ,Estado_Placas = OrientadorData.Estado_Placas
                    ,Estado_PlacasNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Estado_Placas), "Estado") ??  (string)OrientadorData.Estado_Placas_Estado.Nombre
                    ,Vehiculo_Robado = OrientadorData.Vehiculo_Robado.GetValueOrDefault()
                    ,Seguro = OrientadorData.Seguro.GetValueOrDefault()
                    ,Aseguradora = OrientadorData.Aseguradora
                    ,AseguradoraDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Aseguradora), "Aseguradora_de_Vehiculo") ??  (string)OrientadorData.Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                    ,Tipo_de_Servicio = OrientadorData.Tipo_de_Servicio
                    ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Tipo_de_Servicio), "Servicio_del_Vehiculo") ??  (string)OrientadorData.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
                    ,Ruta_del_Servicio_Publico = OrientadorData.Ruta_del_Servicio_Publico
                    ,Mercancia = OrientadorData.Mercancia.GetValueOrDefault()
                    ,Descripcion = OrientadorData.Descripcion
                    ,Monto_de_la_Carga = OrientadorData.Monto_de_la_Carga
                    ,Senas_Particulares = OrientadorData.Senas_Particulares
                    ,Modalidad_del_Robo = OrientadorData.Modalidad_del_Robo
                    ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Modalidad_del_Robo), "Modalidad_de_Robo_de_Vehiculo") ??  (string)OrientadorData.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
                    ,Circunstancia_Defuncion = OrientadorData.Circunstancia_Defuncion
                    ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Circunstancia_Defuncion), "Circunstancia_Defuncion") ??  (string)OrientadorData.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                    ,Consecuencia_Defuncion = OrientadorData.Consecuencia_Defuncion
                    ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Consecuencia_Defuncion), "Consecuencia_Defuncion") ??  (string)OrientadorData.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                    ,Fecha_Levantamiento = (OrientadorData.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(OrientadorData.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Levantamiento = OrientadorData.Hora_Levantamiento
                    ,Domicilio = OrientadorData.Domicilio
                    ,Numero_Interior3 = OrientadorData.Numero_Interior3
                    ,Numero_Exterior3 = OrientadorData.Numero_Exterior3
                    ,Colonia3 = OrientadorData.Colonia3
                    ,Colonia3Nombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Colonia3), "Colonia") ??  (string)OrientadorData.Colonia3_Colonia.Nombre
                    ,Colonia_no_Catalogada = OrientadorData.Colonia_no_Catalogada
                    ,Zona2 = OrientadorData.Zona2
                    ,Zona2Descripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Zona2), "Zona") ??  (string)OrientadorData.Zona2_Zona.Descripcion
                    ,Municipio3 = OrientadorData.Municipio3
                    ,Municipio3Nombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Municipio3), "Municipio") ??  (string)OrientadorData.Municipio3_Municipio.Nombre
                    ,Estado3 = OrientadorData.Estado3
                    ,Estado3Nombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Estado3), "Estado") ??  (string)OrientadorData.Estado3_Estado.Nombre
                    ,Necropsia = OrientadorData.Necropsia
                    ,Cronotanatodiagnostico = OrientadorData.Cronotanatodiagnostico
                    ,Ruta = OrientadorData.Ruta
                    ,Estado_Operador = OrientadorData.Estado_Operador.GetValueOrDefault()
                    ,Delito_Principal_o_Secundario = OrientadorData.Delito_Principal_o_Secundario.GetValueOrDefault()
                    ,Concurso = OrientadorData.Concurso
                    ,Compareciente = OrientadorData.Compareciente
                    ,ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Compareciente), "Tipo_de_Compareciente") ??  (string)OrientadorData.Compareciente_Tipo_de_Compareciente.Descripcion
                    ,NombreC = OrientadorData.NombreC
                    ,Apellido_PaternoC = OrientadorData.Apellido_PaternoC
                    ,Apellido_MaternoC = OrientadorData.Apellido_MaternoC
                    ,NombreT = OrientadorData.NombreT
                    ,Apellido_PaternoT = OrientadorData.Apellido_PaternoT
                    ,Apellido_MaternoT = OrientadorData.Apellido_MaternoT
                    ,CalleC = OrientadorData.CalleC
                    ,Numero_ExteriorC = OrientadorData.Numero_ExteriorC
                    ,Numero_InteriorC = OrientadorData.Numero_InteriorC
                    ,ColoniaC = OrientadorData.ColoniaC
                    ,ColoniaCNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.ColoniaC), "Colonia") ??  (string)OrientadorData.ColoniaC_Colonia.Nombre
                    ,Codigo_PostalC = OrientadorData.Codigo_PostalC
                    ,ZonaC = OrientadorData.ZonaC
                    ,ZonaCDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.ZonaC), "Zona") ??  (string)OrientadorData.ZonaC_Zona.Descripcion
                    ,MunicipioC = OrientadorData.MunicipioC
                    ,MunicipioCNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.MunicipioC), "Municipio") ??  (string)OrientadorData.MunicipioC_Municipio.Nombre
                    ,EstadoC = OrientadorData.EstadoC
                    ,EstadoCNombre = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.EstadoC), "Estado") ??  (string)OrientadorData.EstadoC_Estado.Nombre
                    ,NarrativaC = OrientadorData.NarrativaC
                    ,Conocido = OrientadorData.Conocido.GetValueOrDefault()
                    ,Desconocido = OrientadorData.Desconocido.GetValueOrDefault()
                    ,Numero_de_Imputados = OrientadorData.Numero_de_Imputados
                    ,Procedencia = OrientadorData.Procedencia
                    ,ProcedenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(OrientadorData.Procedencia), "Procedencia_del_Vehiculo") ??  (string)OrientadorData.Procedencia_Procedencia_del_Vehiculo.Descripcion
                    ,Motor = OrientadorData.Motor
                    ,Serie = OrientadorData.Serie
                    ,Causa_de_Muerte = OrientadorData.Causa_de_Muerte
                    ,Entre_Calle = OrientadorData.Entre_Calle
                    ,Entre_Calle2 = OrientadorData.Entre_Calle2
                    ,Autoriza = OrientadorData.Autoriza.GetValueOrDefault()
                    ,Autoriza2 = OrientadorData.Autoriza2.GetValueOrDefault()
                    ,Autoriza3 = OrientadorData.Autoriza3.GetValueOrDefault()
                    ,Menor_de_Edad = OrientadorData.Menor_de_Edad.GetValueOrDefault()

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
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad != null && Localidads_Localidad.Resource != null)
                ViewBag.Localidads_Localidad = Localidads_Localidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia2 = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia2 != null && Colonias_Colonia2.Resource != null)
                ViewBag.Colonias_Colonia2 = Colonias_Colonia2.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
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
            var Municipios_Municipio2 = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio2 != null && Municipios_Municipio2.Resource != null)
                ViewBag.Municipios_Municipio2 = Municipios_Municipio2.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado2 = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado2 != null && Estados_Estado2.Resource != null)
                ViewBag.Estados_Estado2 = Estados_Estado2.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_del_Delitos_Grupo_Delito = _IGrupo_del_DelitoApiConsumer.SelAll(true);
            if (Grupo_del_Delitos_Grupo_Delito != null && Grupo_del_Delitos_Grupo_Delito.Resource != null)
                ViewBag.Grupo_del_Delitos_Grupo_Delito = Grupo_del_Delitos_Grupo_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_del_Delitos_Circunstancia = _ICircunstancia_del_DelitoApiConsumer.SelAll(true);
            if (Circunstancia_del_Delitos_Circunstancia != null && Circunstancia_del_Delitos_Circunstancia.Resource != null)
                ViewBag.Circunstancia_del_Delitos_Circunstancia = Circunstancia_del_Delitos_Circunstancia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Delitos_Tipo_Delito = _ITipo_DelitoApiConsumer.SelAll(true);
            if (Tipo_Delitos_Tipo_Delito != null && Tipo_Delitos_Tipo_Delito.Resource != null)
                ViewBag.Tipo_Delitos_Tipo_Delito = Tipo_Delitos_Tipo_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Comision_Delitos_Forma_Comision_Delito = _IForma_Comision_DelitoApiConsumer.SelAll(true);
            if (Forma_Comision_Delitos_Forma_Comision_Delito != null && Forma_Comision_Delitos_Forma_Comision_Delito.Resource != null)
                ViewBag.Forma_Comision_Delitos_Forma_Comision_Delito = Forma_Comision_Delitos_Forma_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Accion_Delitos_Forma_Accion_Delito = _IForma_Accion_DelitoApiConsumer.SelAll(true);
            if (Forma_Accion_Delitos_Forma_Accion_Delito != null && Forma_Accion_Delitos_Forma_Accion_Delito.Resource != null)
                ViewBag.Forma_Accion_Delitos_Forma_Accion_Delito = Forma_Accion_Delitos_Forma_Accion_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad_Delito = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad_Delito != null && Modalidad_Delitos_Modalidad_Delito.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad_Delito = Modalidad_Delitos_Modalidad_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elementos_Comision_Delitos_Elementos_Comision_Delito = _IElementos_Comision_DelitoApiConsumer.SelAll(true);
            if (Elementos_Comision_Delitos_Elementos_Comision_Delito != null && Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource != null)
                ViewBag.Elementos_Comision_Delitos_Elementos_Comision_Delito = Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elementos_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Vehiculos_CircunstanciaV = _ICircunstancia_VehiculoApiConsumer.SelAll(true);
            if (Circunstancia_Vehiculos_CircunstanciaV != null && Circunstancia_Vehiculos_CircunstanciaV.Resource != null)
                ViewBag.Circunstancia_Vehiculos_CircunstanciaV = Circunstancia_Vehiculos_CircunstanciaV.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecifica_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especifica_Vehiculos_Clase_Especifica = _IEspecifica_VehiculoApiConsumer.SelAll(true);
            if (Especifica_Vehiculos_Clase_Especifica != null && Especifica_Vehiculos_Clase_Especifica.Resource != null)
                ViewBag.Especifica_Vehiculos_Clase_Especifica = Especifica_Vehiculos_Clase_Especifica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especifica_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_del_Vehiculos_Marca = _IMarca_del_VehiculoApiConsumer.SelAll(true);
            if (Marca_del_Vehiculos_Marca != null && Marca_del_Vehiculos_Marca.Resource != null)
                ViewBag.Marca_del_Vehiculos_Marca = Marca_del_Vehiculos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sub_Marca_del_Vehiculos_Sub_Marca = _ISub_Marca_del_VehiculoApiConsumer.SelAll(true);
            if (Sub_Marca_del_Vehiculos_Sub_Marca != null && Sub_Marca_del_Vehiculos_Sub_Marca.Resource != null)
                ViewBag.Sub_Marca_del_Vehiculos_Sub_Marca = Sub_Marca_del_Vehiculos_Sub_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_Vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_Vehiculo != null && Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_Vehiculo = Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Vehiculos_Color = _IColor_VehiculoApiConsumer.SelAll(true);
            if (Color_Vehiculos_Color != null && Color_Vehiculos_Color.Resource != null)
                ViewBag.Color_Vehiculos_Color = Color_Vehiculos_Color.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_Placas = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_Placas != null && Estados_Estado_Placas.Resource != null)
                ViewBag.Estados_Estado_Placas = Estados_Estado_Placas.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Aseguradora_de_Vehiculos_Aseguradora = _IAseguradora_de_VehiculoApiConsumer.SelAll(true);
            if (Aseguradora_de_Vehiculos_Aseguradora != null && Aseguradora_de_Vehiculos_Aseguradora.Resource != null)
                ViewBag.Aseguradora_de_Vehiculos_Aseguradora = Aseguradora_de_Vehiculos_Aseguradora.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Aseguradora_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_del_Vehiculos_Tipo_de_Servicio = _IServicio_del_VehiculoApiConsumer.SelAll(true);
            if (Servicio_del_Vehiculos_Tipo_de_Servicio != null && Servicio_del_Vehiculos_Tipo_de_Servicio.Resource != null)
                ViewBag.Servicio_del_Vehiculos_Tipo_de_Servicio = Servicio_del_Vehiculos_Tipo_de_Servicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_de_Robo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = _IModalidad_de_Robo_de_VehiculoApiConsumer.SelAll(true);
            if (Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo != null && Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource != null)
                ViewBag.Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_de_Robo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Defuncions_Circunstancia_Defuncion = _ICircunstancia_DefuncionApiConsumer.SelAll(true);
            if (Circunstancia_Defuncions_Circunstancia_Defuncion != null && Circunstancia_Defuncions_Circunstancia_Defuncion.Resource != null)
                ViewBag.Circunstancia_Defuncions_Circunstancia_Defuncion = Circunstancia_Defuncions_Circunstancia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Consecuencia_Defuncions_Consecuencia_Defuncion = _IConsecuencia_DefuncionApiConsumer.SelAll(true);
            if (Consecuencia_Defuncions_Consecuencia_Defuncion != null && Consecuencia_Defuncions_Consecuencia_Defuncion.Resource != null)
                ViewBag.Consecuencia_Defuncions_Consecuencia_Defuncion = Consecuencia_Defuncions_Consecuencia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Consecuencia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia3 = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia3 != null && Colonias_Colonia3.Resource != null)
                ViewBag.Colonias_Colonia3 = Colonias_Colonia3.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_Zona2 = _IZonaApiConsumer.SelAll(true);
            if (Zonas_Zona2 != null && Zonas_Zona2.Resource != null)
                ViewBag.Zonas_Zona2 = Zonas_Zona2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio3 = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio3 != null && Municipios_Municipio3.Resource != null)
                ViewBag.Municipios_Municipio3 = Municipios_Municipio3.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado3 = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado3 != null && Estados_Estado3.Resource != null)
                ViewBag.Estados_Estado3 = Estados_Estado3.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Compareciente != null && Tipo_de_Comparecientes_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Compareciente = Tipo_de_Comparecientes_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_ColoniaC = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_ColoniaC != null && Colonias_ColoniaC.Resource != null)
                ViewBag.Colonias_ColoniaC = Colonias_ColoniaC.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_ZonaC = _IZonaApiConsumer.SelAll(true);
            if (Zonas_ZonaC != null && Zonas_ZonaC.Resource != null)
                ViewBag.Zonas_ZonaC = Zonas_ZonaC.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_MunicipioC = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_MunicipioC != null && Municipios_MunicipioC.Resource != null)
                ViewBag.Municipios_MunicipioC = Municipios_MunicipioC.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_EstadoC = _IEstadoApiConsumer.SelAll(true);
            if (Estados_EstadoC != null && Estados_EstadoC.Resource != null)
                ViewBag.Estados_EstadoC = Estados_EstadoC.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IProcedencia_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Procedencia_del_Vehiculos_Procedencia = _IProcedencia_del_VehiculoApiConsumer.SelAll(true);
            if (Procedencia_del_Vehiculos_Procedencia != null && Procedencia_del_Vehiculos_Procedencia.Resource != null)
                ViewBag.Procedencia_del_Vehiculos_Procedencia = Procedencia_del_Vehiculos_Procedencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddOrientador", varOrientador);
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
        public ActionResult GetIdiomaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IIdiomaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetGrupo_del_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGrupo_del_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCircunstancia_del_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstancia_del_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_del_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetForma_Comision_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_Comision_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetForma_Accion_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_Accion_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetModalidad_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModalidad_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetElementos_Comision_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IElementos_Comision_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elementos_Comision_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCircunstancia_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstancia_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEspecifica_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEspecifica_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEspecifica_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especifica_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetMarca_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMarca_del_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetSub_Marca_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISub_Marca_del_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetColor_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColor_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColor_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetAseguradora_de_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAseguradora_de_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Aseguradora_de_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetServicio_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IServicio_del_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetModalidad_de_Robo_de_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModalidad_de_Robo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModalidad_de_Robo_de_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_de_Robo_de_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCircunstancia_DefuncionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstancia_DefuncionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Defuncion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetConsecuencia_DefuncionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConsecuencia_DefuncionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Consecuencia_Defuncion", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetProcedencia_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IProcedencia_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IProcedencia_del_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_Vehiculo", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(OrientadorAdvanceSearchModel model, int idFilter = -1)
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
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad != null && Localidads_Localidad.Resource != null)
                ViewBag.Localidads_Localidad = Localidads_Localidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia2 = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia2 != null && Colonias_Colonia2.Resource != null)
                ViewBag.Colonias_Colonia2 = Colonias_Colonia2.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
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
            var Municipios_Municipio2 = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio2 != null && Municipios_Municipio2.Resource != null)
                ViewBag.Municipios_Municipio2 = Municipios_Municipio2.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado2 = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado2 != null && Estados_Estado2.Resource != null)
                ViewBag.Estados_Estado2 = Estados_Estado2.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_del_Delitos_Grupo_Delito = _IGrupo_del_DelitoApiConsumer.SelAll(true);
            if (Grupo_del_Delitos_Grupo_Delito != null && Grupo_del_Delitos_Grupo_Delito.Resource != null)
                ViewBag.Grupo_del_Delitos_Grupo_Delito = Grupo_del_Delitos_Grupo_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_del_Delitos_Circunstancia = _ICircunstancia_del_DelitoApiConsumer.SelAll(true);
            if (Circunstancia_del_Delitos_Circunstancia != null && Circunstancia_del_Delitos_Circunstancia.Resource != null)
                ViewBag.Circunstancia_del_Delitos_Circunstancia = Circunstancia_del_Delitos_Circunstancia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Delitos_Tipo_Delito = _ITipo_DelitoApiConsumer.SelAll(true);
            if (Tipo_Delitos_Tipo_Delito != null && Tipo_Delitos_Tipo_Delito.Resource != null)
                ViewBag.Tipo_Delitos_Tipo_Delito = Tipo_Delitos_Tipo_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Comision_Delitos_Forma_Comision_Delito = _IForma_Comision_DelitoApiConsumer.SelAll(true);
            if (Forma_Comision_Delitos_Forma_Comision_Delito != null && Forma_Comision_Delitos_Forma_Comision_Delito.Resource != null)
                ViewBag.Forma_Comision_Delitos_Forma_Comision_Delito = Forma_Comision_Delitos_Forma_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Accion_Delitos_Forma_Accion_Delito = _IForma_Accion_DelitoApiConsumer.SelAll(true);
            if (Forma_Accion_Delitos_Forma_Accion_Delito != null && Forma_Accion_Delitos_Forma_Accion_Delito.Resource != null)
                ViewBag.Forma_Accion_Delitos_Forma_Accion_Delito = Forma_Accion_Delitos_Forma_Accion_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad_Delito = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad_Delito != null && Modalidad_Delitos_Modalidad_Delito.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad_Delito = Modalidad_Delitos_Modalidad_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elementos_Comision_Delitos_Elementos_Comision_Delito = _IElementos_Comision_DelitoApiConsumer.SelAll(true);
            if (Elementos_Comision_Delitos_Elementos_Comision_Delito != null && Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource != null)
                ViewBag.Elementos_Comision_Delitos_Elementos_Comision_Delito = Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elementos_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Vehiculos_CircunstanciaV = _ICircunstancia_VehiculoApiConsumer.SelAll(true);
            if (Circunstancia_Vehiculos_CircunstanciaV != null && Circunstancia_Vehiculos_CircunstanciaV.Resource != null)
                ViewBag.Circunstancia_Vehiculos_CircunstanciaV = Circunstancia_Vehiculos_CircunstanciaV.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecifica_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especifica_Vehiculos_Clase_Especifica = _IEspecifica_VehiculoApiConsumer.SelAll(true);
            if (Especifica_Vehiculos_Clase_Especifica != null && Especifica_Vehiculos_Clase_Especifica.Resource != null)
                ViewBag.Especifica_Vehiculos_Clase_Especifica = Especifica_Vehiculos_Clase_Especifica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especifica_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_del_Vehiculos_Marca = _IMarca_del_VehiculoApiConsumer.SelAll(true);
            if (Marca_del_Vehiculos_Marca != null && Marca_del_Vehiculos_Marca.Resource != null)
                ViewBag.Marca_del_Vehiculos_Marca = Marca_del_Vehiculos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sub_Marca_del_Vehiculos_Sub_Marca = _ISub_Marca_del_VehiculoApiConsumer.SelAll(true);
            if (Sub_Marca_del_Vehiculos_Sub_Marca != null && Sub_Marca_del_Vehiculos_Sub_Marca.Resource != null)
                ViewBag.Sub_Marca_del_Vehiculos_Sub_Marca = Sub_Marca_del_Vehiculos_Sub_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_Vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_Vehiculo != null && Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_Vehiculo = Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Vehiculos_Color = _IColor_VehiculoApiConsumer.SelAll(true);
            if (Color_Vehiculos_Color != null && Color_Vehiculos_Color.Resource != null)
                ViewBag.Color_Vehiculos_Color = Color_Vehiculos_Color.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_Placas = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_Placas != null && Estados_Estado_Placas.Resource != null)
                ViewBag.Estados_Estado_Placas = Estados_Estado_Placas.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Aseguradora_de_Vehiculos_Aseguradora = _IAseguradora_de_VehiculoApiConsumer.SelAll(true);
            if (Aseguradora_de_Vehiculos_Aseguradora != null && Aseguradora_de_Vehiculos_Aseguradora.Resource != null)
                ViewBag.Aseguradora_de_Vehiculos_Aseguradora = Aseguradora_de_Vehiculos_Aseguradora.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Aseguradora_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_del_Vehiculos_Tipo_de_Servicio = _IServicio_del_VehiculoApiConsumer.SelAll(true);
            if (Servicio_del_Vehiculos_Tipo_de_Servicio != null && Servicio_del_Vehiculos_Tipo_de_Servicio.Resource != null)
                ViewBag.Servicio_del_Vehiculos_Tipo_de_Servicio = Servicio_del_Vehiculos_Tipo_de_Servicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_de_Robo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = _IModalidad_de_Robo_de_VehiculoApiConsumer.SelAll(true);
            if (Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo != null && Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource != null)
                ViewBag.Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_de_Robo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Defuncions_Circunstancia_Defuncion = _ICircunstancia_DefuncionApiConsumer.SelAll(true);
            if (Circunstancia_Defuncions_Circunstancia_Defuncion != null && Circunstancia_Defuncions_Circunstancia_Defuncion.Resource != null)
                ViewBag.Circunstancia_Defuncions_Circunstancia_Defuncion = Circunstancia_Defuncions_Circunstancia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Consecuencia_Defuncions_Consecuencia_Defuncion = _IConsecuencia_DefuncionApiConsumer.SelAll(true);
            if (Consecuencia_Defuncions_Consecuencia_Defuncion != null && Consecuencia_Defuncions_Consecuencia_Defuncion.Resource != null)
                ViewBag.Consecuencia_Defuncions_Consecuencia_Defuncion = Consecuencia_Defuncions_Consecuencia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Consecuencia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia3 = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia3 != null && Colonias_Colonia3.Resource != null)
                ViewBag.Colonias_Colonia3 = Colonias_Colonia3.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_Zona2 = _IZonaApiConsumer.SelAll(true);
            if (Zonas_Zona2 != null && Zonas_Zona2.Resource != null)
                ViewBag.Zonas_Zona2 = Zonas_Zona2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio3 = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio3 != null && Municipios_Municipio3.Resource != null)
                ViewBag.Municipios_Municipio3 = Municipios_Municipio3.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado3 = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado3 != null && Estados_Estado3.Resource != null)
                ViewBag.Estados_Estado3 = Estados_Estado3.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Compareciente != null && Tipo_de_Comparecientes_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Compareciente = Tipo_de_Comparecientes_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_ColoniaC = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_ColoniaC != null && Colonias_ColoniaC.Resource != null)
                ViewBag.Colonias_ColoniaC = Colonias_ColoniaC.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_ZonaC = _IZonaApiConsumer.SelAll(true);
            if (Zonas_ZonaC != null && Zonas_ZonaC.Resource != null)
                ViewBag.Zonas_ZonaC = Zonas_ZonaC.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_MunicipioC = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_MunicipioC != null && Municipios_MunicipioC.Resource != null)
                ViewBag.Municipios_MunicipioC = Municipios_MunicipioC.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_EstadoC = _IEstadoApiConsumer.SelAll(true);
            if (Estados_EstadoC != null && Estados_EstadoC.Resource != null)
                ViewBag.Estados_EstadoC = Estados_EstadoC.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IProcedencia_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Procedencia_del_Vehiculos_Procedencia = _IProcedencia_del_VehiculoApiConsumer.SelAll(true);
            if (Procedencia_del_Vehiculos_Procedencia != null && Procedencia_del_Vehiculos_Procedencia.Resource != null)
                ViewBag.Procedencia_del_Vehiculos_Procedencia = Procedencia_del_Vehiculos_Procedencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad != null && Localidads_Localidad.Resource != null)
                ViewBag.Localidads_Localidad = Localidads_Localidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia2 = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia2 != null && Colonias_Colonia2.Resource != null)
                ViewBag.Colonias_Colonia2 = Colonias_Colonia2.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
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
            var Municipios_Municipio2 = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio2 != null && Municipios_Municipio2.Resource != null)
                ViewBag.Municipios_Municipio2 = Municipios_Municipio2.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado2 = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado2 != null && Estados_Estado2.Resource != null)
                ViewBag.Estados_Estado2 = Estados_Estado2.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_del_Delitos_Grupo_Delito = _IGrupo_del_DelitoApiConsumer.SelAll(true);
            if (Grupo_del_Delitos_Grupo_Delito != null && Grupo_del_Delitos_Grupo_Delito.Resource != null)
                ViewBag.Grupo_del_Delitos_Grupo_Delito = Grupo_del_Delitos_Grupo_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_del_Delitos_Circunstancia = _ICircunstancia_del_DelitoApiConsumer.SelAll(true);
            if (Circunstancia_del_Delitos_Circunstancia != null && Circunstancia_del_Delitos_Circunstancia.Resource != null)
                ViewBag.Circunstancia_del_Delitos_Circunstancia = Circunstancia_del_Delitos_Circunstancia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Delitos_Tipo_Delito = _ITipo_DelitoApiConsumer.SelAll(true);
            if (Tipo_Delitos_Tipo_Delito != null && Tipo_Delitos_Tipo_Delito.Resource != null)
                ViewBag.Tipo_Delitos_Tipo_Delito = Tipo_Delitos_Tipo_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Comision_Delitos_Forma_Comision_Delito = _IForma_Comision_DelitoApiConsumer.SelAll(true);
            if (Forma_Comision_Delitos_Forma_Comision_Delito != null && Forma_Comision_Delitos_Forma_Comision_Delito.Resource != null)
                ViewBag.Forma_Comision_Delitos_Forma_Comision_Delito = Forma_Comision_Delitos_Forma_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Accion_Delitos_Forma_Accion_Delito = _IForma_Accion_DelitoApiConsumer.SelAll(true);
            if (Forma_Accion_Delitos_Forma_Accion_Delito != null && Forma_Accion_Delitos_Forma_Accion_Delito.Resource != null)
                ViewBag.Forma_Accion_Delitos_Forma_Accion_Delito = Forma_Accion_Delitos_Forma_Accion_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad_Delito = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad_Delito != null && Modalidad_Delitos_Modalidad_Delito.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad_Delito = Modalidad_Delitos_Modalidad_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elementos_Comision_Delitos_Elementos_Comision_Delito = _IElementos_Comision_DelitoApiConsumer.SelAll(true);
            if (Elementos_Comision_Delitos_Elementos_Comision_Delito != null && Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource != null)
                ViewBag.Elementos_Comision_Delitos_Elementos_Comision_Delito = Elementos_Comision_Delitos_Elementos_Comision_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elementos_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Vehiculos_CircunstanciaV = _ICircunstancia_VehiculoApiConsumer.SelAll(true);
            if (Circunstancia_Vehiculos_CircunstanciaV != null && Circunstancia_Vehiculos_CircunstanciaV.Resource != null)
                ViewBag.Circunstancia_Vehiculos_CircunstanciaV = Circunstancia_Vehiculos_CircunstanciaV.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEspecifica_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Especifica_Vehiculos_Clase_Especifica = _IEspecifica_VehiculoApiConsumer.SelAll(true);
            if (Especifica_Vehiculos_Clase_Especifica != null && Especifica_Vehiculos_Clase_Especifica.Resource != null)
                ViewBag.Especifica_Vehiculos_Clase_Especifica = Especifica_Vehiculos_Clase_Especifica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Especifica_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_del_Vehiculos_Marca = _IMarca_del_VehiculoApiConsumer.SelAll(true);
            if (Marca_del_Vehiculos_Marca != null && Marca_del_Vehiculos_Marca.Resource != null)
                ViewBag.Marca_del_Vehiculos_Marca = Marca_del_Vehiculos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sub_Marca_del_Vehiculos_Sub_Marca = _ISub_Marca_del_VehiculoApiConsumer.SelAll(true);
            if (Sub_Marca_del_Vehiculos_Sub_Marca != null && Sub_Marca_del_Vehiculos_Sub_Marca.Resource != null)
                ViewBag.Sub_Marca_del_Vehiculos_Sub_Marca = Sub_Marca_del_Vehiculos_Sub_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_Vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_Vehiculo != null && Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_Vehiculo = Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Vehiculos_Color = _IColor_VehiculoApiConsumer.SelAll(true);
            if (Color_Vehiculos_Color != null && Color_Vehiculos_Color.Resource != null)
                ViewBag.Color_Vehiculos_Color = Color_Vehiculos_Color.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_Placas = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_Placas != null && Estados_Estado_Placas.Resource != null)
                ViewBag.Estados_Estado_Placas = Estados_Estado_Placas.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Aseguradora_de_Vehiculos_Aseguradora = _IAseguradora_de_VehiculoApiConsumer.SelAll(true);
            if (Aseguradora_de_Vehiculos_Aseguradora != null && Aseguradora_de_Vehiculos_Aseguradora.Resource != null)
                ViewBag.Aseguradora_de_Vehiculos_Aseguradora = Aseguradora_de_Vehiculos_Aseguradora.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Aseguradora_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_del_Vehiculos_Tipo_de_Servicio = _IServicio_del_VehiculoApiConsumer.SelAll(true);
            if (Servicio_del_Vehiculos_Tipo_de_Servicio != null && Servicio_del_Vehiculos_Tipo_de_Servicio.Resource != null)
                ViewBag.Servicio_del_Vehiculos_Tipo_de_Servicio = Servicio_del_Vehiculos_Tipo_de_Servicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_de_Robo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = _IModalidad_de_Robo_de_VehiculoApiConsumer.SelAll(true);
            if (Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo != null && Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource != null)
                ViewBag.Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo = Modalidad_de_Robo_de_Vehiculos_Modalidad_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_de_Robo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Defuncions_Circunstancia_Defuncion = _ICircunstancia_DefuncionApiConsumer.SelAll(true);
            if (Circunstancia_Defuncions_Circunstancia_Defuncion != null && Circunstancia_Defuncions_Circunstancia_Defuncion.Resource != null)
                ViewBag.Circunstancia_Defuncions_Circunstancia_Defuncion = Circunstancia_Defuncions_Circunstancia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IConsecuencia_DefuncionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Consecuencia_Defuncions_Consecuencia_Defuncion = _IConsecuencia_DefuncionApiConsumer.SelAll(true);
            if (Consecuencia_Defuncions_Consecuencia_Defuncion != null && Consecuencia_Defuncions_Consecuencia_Defuncion.Resource != null)
                ViewBag.Consecuencia_Defuncions_Consecuencia_Defuncion = Consecuencia_Defuncions_Consecuencia_Defuncion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Consecuencia_Defuncion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia3 = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia3 != null && Colonias_Colonia3.Resource != null)
                ViewBag.Colonias_Colonia3 = Colonias_Colonia3.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_Zona2 = _IZonaApiConsumer.SelAll(true);
            if (Zonas_Zona2 != null && Zonas_Zona2.Resource != null)
                ViewBag.Zonas_Zona2 = Zonas_Zona2.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio3 = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio3 != null && Municipios_Municipio3.Resource != null)
                ViewBag.Municipios_Municipio3 = Municipios_Municipio3.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado3 = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado3 != null && Estados_Estado3.Resource != null)
                ViewBag.Estados_Estado3 = Estados_Estado3.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Compareciente != null && Tipo_de_Comparecientes_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Compareciente = Tipo_de_Comparecientes_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_ColoniaC = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_ColoniaC != null && Colonias_ColoniaC.Resource != null)
                ViewBag.Colonias_ColoniaC = Colonias_ColoniaC.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Zonas_ZonaC = _IZonaApiConsumer.SelAll(true);
            if (Zonas_ZonaC != null && Zonas_ZonaC.Resource != null)
                ViewBag.Zonas_ZonaC = Zonas_ZonaC.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_MunicipioC = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_MunicipioC != null && Municipios_MunicipioC.Resource != null)
                ViewBag.Municipios_MunicipioC = Municipios_MunicipioC.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
	    _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_EstadoC = _IEstadoApiConsumer.SelAll(true);
            if (Estados_EstadoC != null && Estados_EstadoC.Resource != null)
                ViewBag.Estados_EstadoC = Estados_EstadoC.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IProcedencia_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Procedencia_del_Vehiculos_Procedencia = _IProcedencia_del_VehiculoApiConsumer.SelAll(true);
            if (Procedencia_del_Vehiculos_Procedencia != null && Procedencia_del_Vehiculos_Procedencia.Resource != null)
                ViewBag.Procedencia_del_Vehiculos_Procedencia = Procedencia_del_Vehiculos_Procedencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Procedencia_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new OrientadorAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (OrientadorAdvanceSearchModel)(Session["AdvanceSearch"] ?? new OrientadorAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new OrientadorPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IOrientadorApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Orientadors == null)
                result.Orientadors = new List<Orientador>();

            return Json(new
            {
                data = result.Orientadors.Select(m => new OrientadorGridModel
                    {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Atencion_Medica = m.Atencion_Medica
			,Atencion_Psicologica = m.Atencion_Psicologica
			,Traductor = m.Traductor
			,Narrativa_DM = m.Narrativa_DM
			,Narrativa_DP = m.Narrativa_DP
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
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
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_Localidad.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
			,Calle2 = m.Calle2
			,Numero_Exterior2 = m.Numero_Exterior2
			,Numero_Interior2 = m.Numero_Interior2
                        ,Colonia2Nombre = CultureHelper.GetTraduction(m.Colonia2_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia2_Colonia.Nombre
			,Codigo_Postal2 = m.Codigo_Postal2
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Zona.Descripcion
                        ,Municipio2Nombre = CultureHelper.GetTraduction(m.Municipio2_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio2_Municipio.Nombre
                        ,Estado2Nombre = CultureHelper.GetTraduction(m.Estado2_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado2_Estado.Nombre
                        ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
                        ,CircunstanciaDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Circunstancia_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Circunstancia_del_Delito.Descripcion
                        ,Tipo_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_Delito_Tipo_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Delito_Tipo_Delito.Descripcion
                        ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Comision_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Accion_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_Comision_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
			,Monto = m.Monto
			,HViolencia_de_Genero = m.HViolencia_de_Genero
			,Calificacion_del_Delito = m.Calificacion_del_Delito
                        ,CircunstanciaVDescripcion = CultureHelper.GetTraduction(m.CircunstanciaV_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.CircunstanciaV_Circunstancia_Vehiculo.Descripcion
                        ,Clase_EspecificaDescripcion = CultureHelper.GetTraduction(m.Clase_Especifica_Especifica_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Clase_Especifica_Especifica_Vehiculo.Descripcion
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_PlacasNombre = CultureHelper.GetTraduction(m.Estado_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Placas_Estado.Nombre
			,Vehiculo_Robado = m.Vehiculo_Robado
			,Seguro = m.Seguro
                        ,AseguradoraDescripcion = CultureHelper.GetTraduction(m.Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
			,Mercancia = m.Mercancia
			,Descripcion = m.Descripcion
			,Monto_de_la_Carga = m.Monto_de_la_Carga
			,Senas_Particulares = m.Senas_Particulares
                        ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
                        ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Defuncion_Circunstancia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                        ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Consecuencia_Defuncion_Consecuencia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                        ,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_Levantamiento = m.Hora_Levantamiento
			,Domicilio = m.Domicilio
			,Numero_Interior3 = m.Numero_Interior3
			,Numero_Exterior3 = m.Numero_Exterior3
                        ,Colonia3Nombre = CultureHelper.GetTraduction(m.Colonia3_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia3_Colonia.Nombre
			,Colonia_no_Catalogada = m.Colonia_no_Catalogada
                        ,Zona2Descripcion = CultureHelper.GetTraduction(m.Zona2_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona2_Zona.Descripcion
                        ,Municipio3Nombre = CultureHelper.GetTraduction(m.Municipio3_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio3_Municipio.Nombre
                        ,Estado3Nombre = CultureHelper.GetTraduction(m.Estado3_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado3_Estado.Nombre
			,Necropsia = m.Necropsia
			,Cronotanatodiagnostico = m.Cronotanatodiagnostico
			,Ruta = m.Ruta
			,Estado_Operador = m.Estado_Operador
			,Delito_Principal_o_Secundario = m.Delito_Principal_o_Secundario
			,Concurso = m.Concurso
                        ,ComparecienteDescripcion = CultureHelper.GetTraduction(m.Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Compareciente_Tipo_de_Compareciente.Descripcion
			,NombreC = m.NombreC
			,Apellido_PaternoC = m.Apellido_PaternoC
			,Apellido_MaternoC = m.Apellido_MaternoC
			,NombreT = m.NombreT
			,Apellido_PaternoT = m.Apellido_PaternoT
			,Apellido_MaternoT = m.Apellido_MaternoT
			,CalleC = m.CalleC
			,Numero_ExteriorC = m.Numero_ExteriorC
			,Numero_InteriorC = m.Numero_InteriorC
                        ,ColoniaCNombre = CultureHelper.GetTraduction(m.ColoniaC_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaC_Colonia.Nombre
			,Codigo_PostalC = m.Codigo_PostalC
                        ,ZonaCDescripcion = CultureHelper.GetTraduction(m.ZonaC_Zona.Clave.ToString(), "Descripcion") ?? (string)m.ZonaC_Zona.Descripcion
                        ,MunicipioCNombre = CultureHelper.GetTraduction(m.MunicipioC_Municipio.Clave.ToString(), "Municipio") ?? (string)m.MunicipioC_Municipio.Nombre
                        ,EstadoCNombre = CultureHelper.GetTraduction(m.EstadoC_Estado.Clave.ToString(), "Estado") ?? (string)m.EstadoC_Estado.Nombre
			,NarrativaC = m.NarrativaC
			,Conocido = m.Conocido
			,Desconocido = m.Desconocido
			,Numero_de_Imputados = m.Numero_de_Imputados
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
			,Motor = m.Motor
			,Serie = m.Serie
			,Causa_de_Muerte = m.Causa_de_Muerte
			,Entre_Calle = m.Entre_Calle
			,Entre_Calle2 = m.Entre_Calle2
			,Autoriza = m.Autoriza
			,Autoriza2 = m.Autoriza2
			,Autoriza3 = m.Autoriza3
			,Menor_de_Edad = m.Menor_de_Edad

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetOrientadorAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOrientadorApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Orientador", m.),
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
        /// Get List of Orientador from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Orientador Entity</returns>
        public ActionResult GetOrientadorList(UrlParametersModel param)
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
            _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new OrientadorPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(OrientadorAdvanceSearchModel))
                {
					var advanceFilter =
                    (OrientadorAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            OrientadorPropertyMapper oOrientadorPropertyMapper = new OrientadorPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oOrientadorPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IOrientadorApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Orientadors == null)
                result.Orientadors = new List<Orientador>();

            return Json(new
            {
                aaData = result.Orientadors.Select(m => new OrientadorGridModel
            {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Atencion_Medica = m.Atencion_Medica
			,Atencion_Psicologica = m.Atencion_Psicologica
			,Traductor = m.Traductor
			,Narrativa_DM = m.Narrativa_DM
			,Narrativa_DP = m.Narrativa_DP
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
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
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_Localidad.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
			,Calle2 = m.Calle2
			,Numero_Exterior2 = m.Numero_Exterior2
			,Numero_Interior2 = m.Numero_Interior2
                        ,Colonia2Nombre = CultureHelper.GetTraduction(m.Colonia2_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia2_Colonia.Nombre
			,Codigo_Postal2 = m.Codigo_Postal2
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Zona.Descripcion
                        ,Municipio2Nombre = CultureHelper.GetTraduction(m.Municipio2_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio2_Municipio.Nombre
                        ,Estado2Nombre = CultureHelper.GetTraduction(m.Estado2_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado2_Estado.Nombre
                        ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
                        ,CircunstanciaDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Circunstancia_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Circunstancia_del_Delito.Descripcion
                        ,Tipo_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_Delito_Tipo_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Delito_Tipo_Delito.Descripcion
                        ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Comision_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Accion_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_Comision_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
			,Monto = m.Monto
			,HViolencia_de_Genero = m.HViolencia_de_Genero
			,Calificacion_del_Delito = m.Calificacion_del_Delito
                        ,CircunstanciaVDescripcion = CultureHelper.GetTraduction(m.CircunstanciaV_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.CircunstanciaV_Circunstancia_Vehiculo.Descripcion
                        ,Clase_EspecificaDescripcion = CultureHelper.GetTraduction(m.Clase_Especifica_Especifica_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Clase_Especifica_Especifica_Vehiculo.Descripcion
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_PlacasNombre = CultureHelper.GetTraduction(m.Estado_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Placas_Estado.Nombre
			,Vehiculo_Robado = m.Vehiculo_Robado
			,Seguro = m.Seguro
                        ,AseguradoraDescripcion = CultureHelper.GetTraduction(m.Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
			,Mercancia = m.Mercancia
			,Descripcion = m.Descripcion
			,Monto_de_la_Carga = m.Monto_de_la_Carga
			,Senas_Particulares = m.Senas_Particulares
                        ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
                        ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Defuncion_Circunstancia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                        ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Consecuencia_Defuncion_Consecuencia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                        ,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_Levantamiento = m.Hora_Levantamiento
			,Domicilio = m.Domicilio
			,Numero_Interior3 = m.Numero_Interior3
			,Numero_Exterior3 = m.Numero_Exterior3
                        ,Colonia3Nombre = CultureHelper.GetTraduction(m.Colonia3_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia3_Colonia.Nombre
			,Colonia_no_Catalogada = m.Colonia_no_Catalogada
                        ,Zona2Descripcion = CultureHelper.GetTraduction(m.Zona2_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona2_Zona.Descripcion
                        ,Municipio3Nombre = CultureHelper.GetTraduction(m.Municipio3_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio3_Municipio.Nombre
                        ,Estado3Nombre = CultureHelper.GetTraduction(m.Estado3_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado3_Estado.Nombre
			,Necropsia = m.Necropsia
			,Cronotanatodiagnostico = m.Cronotanatodiagnostico
			,Ruta = m.Ruta
			,Estado_Operador = m.Estado_Operador
			,Delito_Principal_o_Secundario = m.Delito_Principal_o_Secundario
			,Concurso = m.Concurso
                        ,ComparecienteDescripcion = CultureHelper.GetTraduction(m.Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Compareciente_Tipo_de_Compareciente.Descripcion
			,NombreC = m.NombreC
			,Apellido_PaternoC = m.Apellido_PaternoC
			,Apellido_MaternoC = m.Apellido_MaternoC
			,NombreT = m.NombreT
			,Apellido_PaternoT = m.Apellido_PaternoT
			,Apellido_MaternoT = m.Apellido_MaternoT
			,CalleC = m.CalleC
			,Numero_ExteriorC = m.Numero_ExteriorC
			,Numero_InteriorC = m.Numero_InteriorC
                        ,ColoniaCNombre = CultureHelper.GetTraduction(m.ColoniaC_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaC_Colonia.Nombre
			,Codigo_PostalC = m.Codigo_PostalC
                        ,ZonaCDescripcion = CultureHelper.GetTraduction(m.ZonaC_Zona.Clave.ToString(), "Descripcion") ?? (string)m.ZonaC_Zona.Descripcion
                        ,MunicipioCNombre = CultureHelper.GetTraduction(m.MunicipioC_Municipio.Clave.ToString(), "Municipio") ?? (string)m.MunicipioC_Municipio.Nombre
                        ,EstadoCNombre = CultureHelper.GetTraduction(m.EstadoC_Estado.Clave.ToString(), "Estado") ?? (string)m.EstadoC_Estado.Nombre
			,NarrativaC = m.NarrativaC
			,Conocido = m.Conocido
			,Desconocido = m.Desconocido
			,Numero_de_Imputados = m.Numero_de_Imputados
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
			,Motor = m.Motor
			,Serie = m.Serie
			,Causa_de_Muerte = m.Causa_de_Muerte
			,Entre_Calle = m.Entre_Calle
			,Entre_Calle2 = m.Entre_Calle2
			,Autoriza = m.Autoriza
			,Autoriza2 = m.Autoriza2
			,Autoriza3 = m.Autoriza3
			,Menor_de_Edad = m.Menor_de_Edad

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetOrientador_Usuario_que_Registra_Spartan_User(string query, string where)
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
        public JsonResult GetOrientador_Colonia_Colonia(string query, string where)
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
        public JsonResult GetOrientador_Municipio_Municipio(string query, string where)
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
        public JsonResult GetOrientador_Estado_Estado(string query, string where)
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
        public JsonResult GetOrientador_Colonia2_Colonia(string query, string where)
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
        public JsonResult GetOrientador_Municipio2_Municipio(string query, string where)
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
        public JsonResult GetOrientador_Estado2_Estado(string query, string where)
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
        public JsonResult GetOrientador_Estado_Placas_Estado(string query, string where)
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
        public JsonResult GetOrientador_Colonia3_Colonia(string query, string where)
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
        public JsonResult GetOrientador_Municipio3_Municipio(string query, string where)
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
        public JsonResult GetOrientador_Estado3_Estado(string query, string where)
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
        public JsonResult GetOrientador_ColoniaC_Colonia(string query, string where)
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
        public JsonResult GetOrientador_MunicipioC_Municipio(string query, string where)
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
        public JsonResult GetOrientador_EstadoC_Estado(string query, string where)
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





        [NonAction]
        public string GetAdvanceFilter(OrientadorAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Orientador.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Orientador.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Orientador.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Orientador.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Orientador.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Orientador.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
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

                where += " AND Orientador.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (filter.Atencion_Medica != RadioOptions.NoApply)
                where += " AND Orientador.Atencion_Medica = " + Convert.ToInt32(filter.Atencion_Medica);

            if (filter.Atencion_Psicologica != RadioOptions.NoApply)
                where += " AND Orientador.Atencion_Psicologica = " + Convert.ToInt32(filter.Atencion_Psicologica);

            if (filter.Traductor != RadioOptions.NoApply)
                where += " AND Orientador.Traductor = " + Convert.ToInt32(filter.Traductor);

            if (!string.IsNullOrEmpty(filter.Narrativa_DM))
            {
                switch (filter.Narrativa_DMFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Narrativa_DM LIKE '" + filter.Narrativa_DM + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Narrativa_DM LIKE '%" + filter.Narrativa_DM + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Narrativa_DM = '" + filter.Narrativa_DM + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Narrativa_DM LIKE '%" + filter.Narrativa_DM + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Narrativa_DP))
            {
                switch (filter.Narrativa_DPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Narrativa_DP LIKE '" + filter.Narrativa_DP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Narrativa_DP LIKE '%" + filter.Narrativa_DP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Narrativa_DP = '" + filter.Narrativa_DP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Narrativa_DP LIKE '%" + filter.Narrativa_DP + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceIdioma))
            {
                switch (filter.IdiomaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Idioma.Descripcion LIKE '" + filter.AdvanceIdioma + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Idioma.Descripcion LIKE '%" + filter.AdvanceIdioma + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Idioma.Descripcion = '" + filter.AdvanceIdioma + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Idioma.Descripcion LIKE '%" + filter.AdvanceIdioma + "%'";
                        break;
                }
            }
            else if (filter.AdvanceIdiomaMultiple != null && filter.AdvanceIdiomaMultiple.Count() > 0)
            {
                var IdiomaIds = string.Join(",", filter.AdvanceIdiomaMultiple);

                where += " AND Orientador.Idioma In (" + IdiomaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Nombre))
            {
                switch (filter.NombreFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Nombre LIKE '" + filter.Nombre + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Nombre LIKE '%" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Nombre = '" + filter.Nombre + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Nombre LIKE '%" + filter.Nombre + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno))
            {
                switch (filter.Apellido_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Apellido_Paterno LIKE '" + filter.Apellido_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Apellido_Paterno = '" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno))
            {
                switch (filter.Apellido_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Apellido_Materno LIKE '" + filter.Apellido_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Apellido_Materno = '" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "%'";
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
                    where += " AND Orientador.Fecha_de_Nacimiento >= '" + Fecha_de_NacimientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Nacimiento))
                    where += " AND Orientador.Fecha_de_Nacimiento <= '" + Fecha_de_NacimientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromEdad) || !string.IsNullOrEmpty(filter.ToEdad))
            {
                if (!string.IsNullOrEmpty(filter.FromEdad))
                    where += " AND Orientador.Edad >= " + filter.FromEdad;
                if (!string.IsNullOrEmpty(filter.ToEdad))
                    where += " AND Orientador.Edad <= " + filter.ToEdad;
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

                where += " AND Orientador.Sexo In (" + SexoIds + ")";
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

                where += " AND Orientador.Estado_Civil In (" + Estado_CivilIds + ")";
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

                where += " AND Orientador.Tipo_de_Identificacion In (" + Tipo_de_IdentificacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Identificacion))
            {
                switch (filter.Numero_de_IdentificacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Numero_de_Identificacion LIKE '" + filter.Numero_de_Identificacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Numero_de_Identificacion = '" + filter.Numero_de_Identificacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Numero_de_Identificacion LIKE '%" + filter.Numero_de_Identificacion + "%'";
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

                where += " AND Orientador.Nacionalidad In (" + NacionalidadIds + ")";
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

                where += " AND Orientador.Escolaridad In (" + EscolaridadIds + ")";
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

                where += " AND Orientador.Ocupacion In (" + OcupacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Calle))
            {
                switch (filter.CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Calle LIKE '" + filter.Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Calle LIKE '%" + filter.Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Calle = '" + filter.Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Calle LIKE '%" + filter.Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromNumero_Exterior) || !string.IsNullOrEmpty(filter.ToNumero_Exterior))
            {
                if (!string.IsNullOrEmpty(filter.FromNumero_Exterior))
                    where += " AND Orientador.Numero_Exterior >= " + filter.FromNumero_Exterior;
                if (!string.IsNullOrEmpty(filter.ToNumero_Exterior))
                    where += " AND Orientador.Numero_Exterior <= " + filter.ToNumero_Exterior;
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior))
            {
                switch (filter.Numero_InteriorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Numero_Interior LIKE '" + filter.Numero_Interior + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Numero_Interior LIKE '%" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Numero_Interior = '" + filter.Numero_Interior + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Numero_Interior LIKE '%" + filter.Numero_Interior + "%'";
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

                where += " AND Orientador.Colonia In (" + ColoniaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal) || !string.IsNullOrEmpty(filter.ToCodigo_Postal))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal))
                    where += " AND Orientador.Codigo_Postal >= " + filter.FromCodigo_Postal;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal))
                    where += " AND Orientador.Codigo_Postal <= " + filter.ToCodigo_Postal;
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

                where += " AND Orientador.Localidad In (" + LocalidadIds + ")";
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

                where += " AND Orientador.Municipio In (" + MunicipioIds + ")";
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

                where += " AND Orientador.Estado In (" + EstadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Telefono))
            {
                switch (filter.TelefonoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Telefono LIKE '" + filter.Telefono + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Telefono LIKE '%" + filter.Telefono + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Telefono = '" + filter.Telefono + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Telefono LIKE '%" + filter.Telefono + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Celular))
            {
                switch (filter.CelularFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Celular LIKE '" + filter.Celular + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Celular LIKE '%" + filter.Celular + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Celular = '" + filter.Celular + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Celular LIKE '%" + filter.Celular + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo_Electronico))
            {
                switch (filter.Correo_ElectronicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Correo_Electronico LIKE '" + filter.Correo_Electronico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Correo_Electronico = '" + filter.Correo_Electronico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Correo_Electronico LIKE '%" + filter.Correo_Electronico + "%'";
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
                    where += " AND Orientador.Fecha_del_Hecho >= '" + Fecha_del_HechoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_del_Hecho))
                    where += " AND Orientador.Fecha_del_Hecho <= '" + Fecha_del_HechoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Aproximada_del_Hecho) || !string.IsNullOrEmpty(filter.ToHora_Aproximada_del_Hecho))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Aproximada_del_Hecho))
                    where += " AND Convert(TIME,Orientador.Hora_Aproximada_del_Hecho) >='" + filter.FromHora_Aproximada_del_Hecho + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Aproximada_del_Hecho))
                    where += " AND Convert(TIME,Orientador.Hora_Aproximada_del_Hecho) <='" + filter.ToHora_Aproximada_del_Hecho + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Lugar_del_Hecho))
            {
                switch (filter.Tipo_de_Lugar_del_HechoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Lugar_Tipo.Descripcion LIKE '" + filter.AdvanceTipo_de_Lugar_del_Hecho + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Lugar_Tipo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Lugar_del_Hecho + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Lugar_Tipo.Descripcion = '" + filter.AdvanceTipo_de_Lugar_del_Hecho + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Lugar_Tipo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Lugar_del_Hecho + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Lugar_del_HechoMultiple != null && filter.AdvanceTipo_de_Lugar_del_HechoMultiple.Count() > 0)
            {
                var Tipo_de_Lugar_del_HechoIds = string.Join(",", filter.AdvanceTipo_de_Lugar_del_HechoMultiple);

                where += " AND Orientador.Tipo_de_Lugar_del_Hecho In (" + Tipo_de_Lugar_del_HechoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Calle2))
            {
                switch (filter.Calle2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Calle2 LIKE '" + filter.Calle2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Calle2 LIKE '%" + filter.Calle2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Calle2 = '" + filter.Calle2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Calle2 LIKE '%" + filter.Calle2 + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromNumero_Exterior2) || !string.IsNullOrEmpty(filter.ToNumero_Exterior2))
            {
                if (!string.IsNullOrEmpty(filter.FromNumero_Exterior2))
                    where += " AND Orientador.Numero_Exterior2 >= " + filter.FromNumero_Exterior2;
                if (!string.IsNullOrEmpty(filter.ToNumero_Exterior2))
                    where += " AND Orientador.Numero_Exterior2 <= " + filter.ToNumero_Exterior2;
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior2))
            {
                switch (filter.Numero_Interior2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Numero_Interior2 LIKE '" + filter.Numero_Interior2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Numero_Interior2 LIKE '%" + filter.Numero_Interior2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Numero_Interior2 = '" + filter.Numero_Interior2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Numero_Interior2 LIKE '%" + filter.Numero_Interior2 + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia2))
            {
                switch (filter.Colonia2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia2 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia2Multiple != null && filter.AdvanceColonia2Multiple.Count() > 0)
            {
                var Colonia2Ids = string.Join(",", filter.AdvanceColonia2Multiple);

                where += " AND Orientador.Colonia2 In (" + Colonia2Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal2) || !string.IsNullOrEmpty(filter.ToCodigo_Postal2))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal2))
                    where += " AND Orientador.Codigo_Postal2 >= " + filter.FromCodigo_Postal2;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal2))
                    where += " AND Orientador.Codigo_Postal2 <= " + filter.ToCodigo_Postal2;
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

                where += " AND Orientador.Zona In (" + ZonaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio2))
            {
                switch (filter.Municipio2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio2 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio2Multiple != null && filter.AdvanceMunicipio2Multiple.Count() > 0)
            {
                var Municipio2Ids = string.Join(",", filter.AdvanceMunicipio2Multiple);

                where += " AND Orientador.Municipio2 In (" + Municipio2Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado2))
            {
                switch (filter.Estado2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado2 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado2Multiple != null && filter.AdvanceEstado2Multiple.Count() > 0)
            {
                var Estado2Ids = string.Join(",", filter.AdvanceEstado2Multiple);

                where += " AND Orientador.Estado2 In (" + Estado2Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceGrupo_Delito))
            {
                switch (filter.Grupo_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Grupo_del_Delito.Descripcion LIKE '" + filter.AdvanceGrupo_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Grupo_del_Delito.Descripcion LIKE '%" + filter.AdvanceGrupo_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Grupo_del_Delito.Descripcion = '" + filter.AdvanceGrupo_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Grupo_del_Delito.Descripcion LIKE '%" + filter.AdvanceGrupo_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceGrupo_DelitoMultiple != null && filter.AdvanceGrupo_DelitoMultiple.Count() > 0)
            {
                var Grupo_DelitoIds = string.Join(",", filter.AdvanceGrupo_DelitoMultiple);

                where += " AND Orientador.Grupo_Delito In (" + Grupo_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDelito))
            {
                switch (filter.DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delito.Descripcion LIKE '" + filter.AdvanceDelito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delito.Descripcion LIKE '%" + filter.AdvanceDelito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delito.Descripcion = '" + filter.AdvanceDelito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delito.Descripcion LIKE '%" + filter.AdvanceDelito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDelitoMultiple != null && filter.AdvanceDelitoMultiple.Count() > 0)
            {
                var DelitoIds = string.Join(",", filter.AdvanceDelitoMultiple);

                where += " AND Orientador.Delito In (" + DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCircunstancia))
            {
                switch (filter.CircunstanciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Circunstancia_del_Delito.Descripcion LIKE '" + filter.AdvanceCircunstancia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Circunstancia_del_Delito.Descripcion LIKE '%" + filter.AdvanceCircunstancia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Circunstancia_del_Delito.Descripcion = '" + filter.AdvanceCircunstancia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Circunstancia_del_Delito.Descripcion LIKE '%" + filter.AdvanceCircunstancia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCircunstanciaMultiple != null && filter.AdvanceCircunstanciaMultiple.Count() > 0)
            {
                var CircunstanciaIds = string.Join(",", filter.AdvanceCircunstanciaMultiple);

                where += " AND Orientador.Circunstancia In (" + CircunstanciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_Delito))
            {
                switch (filter.Tipo_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_Delito.Descripcion LIKE '" + filter.AdvanceTipo_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_Delito.Descripcion LIKE '%" + filter.AdvanceTipo_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_Delito.Descripcion = '" + filter.AdvanceTipo_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_Delito.Descripcion LIKE '%" + filter.AdvanceTipo_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_DelitoMultiple != null && filter.AdvanceTipo_DelitoMultiple.Count() > 0)
            {
                var Tipo_DelitoIds = string.Join(",", filter.AdvanceTipo_DelitoMultiple);

                where += " AND Orientador.Tipo_Delito In (" + Tipo_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_Comision_Delito))
            {
                switch (filter.Forma_Comision_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_Comision_Delito.Descripcion LIKE '" + filter.AdvanceForma_Comision_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_Comision_Delito.Descripcion LIKE '%" + filter.AdvanceForma_Comision_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_Comision_Delito.Descripcion = '" + filter.AdvanceForma_Comision_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_Comision_Delito.Descripcion LIKE '%" + filter.AdvanceForma_Comision_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_Comision_DelitoMultiple != null && filter.AdvanceForma_Comision_DelitoMultiple.Count() > 0)
            {
                var Forma_Comision_DelitoIds = string.Join(",", filter.AdvanceForma_Comision_DelitoMultiple);

                where += " AND Orientador.Forma_Comision_Delito In (" + Forma_Comision_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_Accion_Delito))
            {
                switch (filter.Forma_Accion_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_Accion_Delito.Descripcion LIKE '" + filter.AdvanceForma_Accion_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_Accion_Delito.Descripcion LIKE '%" + filter.AdvanceForma_Accion_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_Accion_Delito.Descripcion = '" + filter.AdvanceForma_Accion_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_Accion_Delito.Descripcion LIKE '%" + filter.AdvanceForma_Accion_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_Accion_DelitoMultiple != null && filter.AdvanceForma_Accion_DelitoMultiple.Count() > 0)
            {
                var Forma_Accion_DelitoIds = string.Join(",", filter.AdvanceForma_Accion_DelitoMultiple);

                where += " AND Orientador.Forma_Accion_Delito In (" + Forma_Accion_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModalidad_Delito))
            {
                switch (filter.Modalidad_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modalidad_Delito.Descripcion LIKE '" + filter.AdvanceModalidad_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modalidad_Delito.Descripcion LIKE '%" + filter.AdvanceModalidad_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modalidad_Delito.Descripcion = '" + filter.AdvanceModalidad_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modalidad_Delito.Descripcion LIKE '%" + filter.AdvanceModalidad_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModalidad_DelitoMultiple != null && filter.AdvanceModalidad_DelitoMultiple.Count() > 0)
            {
                var Modalidad_DelitoIds = string.Join(",", filter.AdvanceModalidad_DelitoMultiple);

                where += " AND Orientador.Modalidad_Delito In (" + Modalidad_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceElementos_Comision_Delito))
            {
                switch (filter.Elementos_Comision_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Elementos_Comision_Delito.Descripcion LIKE '" + filter.AdvanceElementos_Comision_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Elementos_Comision_Delito.Descripcion LIKE '%" + filter.AdvanceElementos_Comision_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Elementos_Comision_Delito.Descripcion = '" + filter.AdvanceElementos_Comision_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Elementos_Comision_Delito.Descripcion LIKE '%" + filter.AdvanceElementos_Comision_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceElementos_Comision_DelitoMultiple != null && filter.AdvanceElementos_Comision_DelitoMultiple.Count() > 0)
            {
                var Elementos_Comision_DelitoIds = string.Join(",", filter.AdvanceElementos_Comision_DelitoMultiple);

                where += " AND Orientador.Elementos_Comision_Delito In (" + Elementos_Comision_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromMonto) || !string.IsNullOrEmpty(filter.ToMonto))
            {
                if (!string.IsNullOrEmpty(filter.FromMonto))
                    where += " AND Orientador.Monto >= " + filter.FromMonto;
                if (!string.IsNullOrEmpty(filter.ToMonto))
                    where += " AND Orientador.Monto <= " + filter.ToMonto;
            }

            if (filter.HViolencia_de_Genero != RadioOptions.NoApply)
                where += " AND Orientador.HViolencia_de_Genero = " + Convert.ToInt32(filter.HViolencia_de_Genero);

            if (!string.IsNullOrEmpty(filter.Calificacion_del_Delito))
            {
                switch (filter.Calificacion_del_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Calificacion_del_Delito LIKE '" + filter.Calificacion_del_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Calificacion_del_Delito LIKE '%" + filter.Calificacion_del_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Calificacion_del_Delito = '" + filter.Calificacion_del_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Calificacion_del_Delito LIKE '%" + filter.Calificacion_del_Delito + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCircunstanciaV))
            {
                switch (filter.CircunstanciaVFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Circunstancia_Vehiculo.Descripcion LIKE '" + filter.AdvanceCircunstanciaV + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Circunstancia_Vehiculo.Descripcion LIKE '%" + filter.AdvanceCircunstanciaV + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Circunstancia_Vehiculo.Descripcion = '" + filter.AdvanceCircunstanciaV + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Circunstancia_Vehiculo.Descripcion LIKE '%" + filter.AdvanceCircunstanciaV + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCircunstanciaVMultiple != null && filter.AdvanceCircunstanciaVMultiple.Count() > 0)
            {
                var CircunstanciaVIds = string.Join(",", filter.AdvanceCircunstanciaVMultiple);

                where += " AND Orientador.CircunstanciaV In (" + CircunstanciaVIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceClase_Especifica))
            {
                switch (filter.Clase_EspecificaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Especifica_Vehiculo.Descripcion LIKE '" + filter.AdvanceClase_Especifica + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Especifica_Vehiculo.Descripcion LIKE '%" + filter.AdvanceClase_Especifica + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Especifica_Vehiculo.Descripcion = '" + filter.AdvanceClase_Especifica + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Especifica_Vehiculo.Descripcion LIKE '%" + filter.AdvanceClase_Especifica + "%'";
                        break;
                }
            }
            else if (filter.AdvanceClase_EspecificaMultiple != null && filter.AdvanceClase_EspecificaMultiple.Count() > 0)
            {
                var Clase_EspecificaIds = string.Join(",", filter.AdvanceClase_EspecificaMultiple);

                where += " AND Orientador.Clase_Especifica In (" + Clase_EspecificaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMarca))
            {
                switch (filter.MarcaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Marca_del_Vehiculo.Descripcion LIKE '" + filter.AdvanceMarca + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Marca_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceMarca + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Marca_del_Vehiculo.Descripcion = '" + filter.AdvanceMarca + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Marca_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceMarca + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMarcaMultiple != null && filter.AdvanceMarcaMultiple.Count() > 0)
            {
                var MarcaIds = string.Join(",", filter.AdvanceMarcaMultiple);

                where += " AND Orientador.Marca In (" + MarcaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSub_Marca))
            {
                switch (filter.Sub_MarcaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Sub_Marca_del_Vehiculo.Descripcion LIKE '" + filter.AdvanceSub_Marca + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Sub_Marca_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceSub_Marca + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Sub_Marca_del_Vehiculo.Descripcion = '" + filter.AdvanceSub_Marca + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Sub_Marca_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceSub_Marca + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSub_MarcaMultiple != null && filter.AdvanceSub_MarcaMultiple.Count() > 0)
            {
                var Sub_MarcaIds = string.Join(",", filter.AdvanceSub_MarcaMultiple);

                where += " AND Orientador.Sub_Marca In (" + Sub_MarcaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Vehiculo))
            {
                switch (filter.Tipo_de_VehiculoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Vehiculo.Descripcion LIKE '" + filter.AdvanceTipo_de_Vehiculo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Vehiculo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Vehiculo.Descripcion = '" + filter.AdvanceTipo_de_Vehiculo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Vehiculo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_VehiculoMultiple != null && filter.AdvanceTipo_de_VehiculoMultiple.Count() > 0)
            {
                var Tipo_de_VehiculoIds = string.Join(",", filter.AdvanceTipo_de_VehiculoMultiple);

                where += " AND Orientador.Tipo_de_Vehiculo In (" + Tipo_de_VehiculoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Modelo))
            {
                switch (filter.ModeloFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Modelo LIKE '" + filter.Modelo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Modelo LIKE '%" + filter.Modelo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Modelo = '" + filter.Modelo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Modelo LIKE '%" + filter.Modelo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColor))
            {
                switch (filter.ColorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Color_Vehiculo.Descripcion LIKE '" + filter.AdvanceColor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Color_Vehiculo.Descripcion LIKE '%" + filter.AdvanceColor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Color_Vehiculo.Descripcion = '" + filter.AdvanceColor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Color_Vehiculo.Descripcion LIKE '%" + filter.AdvanceColor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColorMultiple != null && filter.AdvanceColorMultiple.Count() > 0)
            {
                var ColorIds = string.Join(",", filter.AdvanceColorMultiple);

                where += " AND Orientador.Color In (" + ColorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Placas))
            {
                switch (filter.PlacasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Placas LIKE '" + filter.Placas + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Placas LIKE '%" + filter.Placas + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Placas = '" + filter.Placas + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Placas LIKE '%" + filter.Placas + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_Placas))
            {
                switch (filter.Estado_PlacasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_Placas + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_Placas + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_Placas + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_Placas + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_PlacasMultiple != null && filter.AdvanceEstado_PlacasMultiple.Count() > 0)
            {
                var Estado_PlacasIds = string.Join(",", filter.AdvanceEstado_PlacasMultiple);

                where += " AND Orientador.Estado_Placas In (" + Estado_PlacasIds + ")";
            }

            if (filter.Vehiculo_Robado != RadioOptions.NoApply)
                where += " AND Orientador.Vehiculo_Robado = " + Convert.ToInt32(filter.Vehiculo_Robado);

            if (filter.Seguro != RadioOptions.NoApply)
                where += " AND Orientador.Seguro = " + Convert.ToInt32(filter.Seguro);

            if (!string.IsNullOrEmpty(filter.AdvanceAseguradora))
            {
                switch (filter.AseguradoraFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Aseguradora_de_Vehiculo.Descripcion LIKE '" + filter.AdvanceAseguradora + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Aseguradora_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceAseguradora + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Aseguradora_de_Vehiculo.Descripcion = '" + filter.AdvanceAseguradora + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Aseguradora_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceAseguradora + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAseguradoraMultiple != null && filter.AdvanceAseguradoraMultiple.Count() > 0)
            {
                var AseguradoraIds = string.Join(",", filter.AdvanceAseguradoraMultiple);

                where += " AND Orientador.Aseguradora In (" + AseguradoraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Servicio))
            {
                switch (filter.Tipo_de_ServicioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Servicio_del_Vehiculo.Descripcion LIKE '" + filter.AdvanceTipo_de_Servicio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Servicio_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Servicio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Servicio_del_Vehiculo.Descripcion = '" + filter.AdvanceTipo_de_Servicio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Servicio_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Servicio + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_ServicioMultiple != null && filter.AdvanceTipo_de_ServicioMultiple.Count() > 0)
            {
                var Tipo_de_ServicioIds = string.Join(",", filter.AdvanceTipo_de_ServicioMultiple);

                where += " AND Orientador.Tipo_de_Servicio In (" + Tipo_de_ServicioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Ruta_del_Servicio_Publico))
            {
                switch (filter.Ruta_del_Servicio_PublicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Ruta_del_Servicio_Publico LIKE '" + filter.Ruta_del_Servicio_Publico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Ruta_del_Servicio_Publico LIKE '%" + filter.Ruta_del_Servicio_Publico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Ruta_del_Servicio_Publico = '" + filter.Ruta_del_Servicio_Publico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Ruta_del_Servicio_Publico LIKE '%" + filter.Ruta_del_Servicio_Publico + "%'";
                        break;
                }
            }

            if (filter.Mercancia != RadioOptions.NoApply)
                where += " AND Orientador.Mercancia = " + Convert.ToInt32(filter.Mercancia);

            if (!string.IsNullOrEmpty(filter.Descripcion))
            {
                switch (filter.DescripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Descripcion LIKE '" + filter.Descripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Descripcion LIKE '%" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Descripcion = '" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Descripcion LIKE '%" + filter.Descripcion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromMonto_de_la_Carga) || !string.IsNullOrEmpty(filter.ToMonto_de_la_Carga))
            {
                if (!string.IsNullOrEmpty(filter.FromMonto_de_la_Carga))
                    where += " AND Orientador.Monto_de_la_Carga >= " + filter.FromMonto_de_la_Carga;
                if (!string.IsNullOrEmpty(filter.ToMonto_de_la_Carga))
                    where += " AND Orientador.Monto_de_la_Carga <= " + filter.ToMonto_de_la_Carga;
            }

            if (!string.IsNullOrEmpty(filter.Senas_Particulares))
            {
                switch (filter.Senas_ParticularesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Senas_Particulares LIKE '" + filter.Senas_Particulares + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Senas_Particulares LIKE '%" + filter.Senas_Particulares + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Senas_Particulares = '" + filter.Senas_Particulares + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Senas_Particulares LIKE '%" + filter.Senas_Particulares + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModalidad_del_Robo))
            {
                switch (filter.Modalidad_del_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modalidad_de_Robo_de_Vehiculo.Descripcion LIKE '" + filter.AdvanceModalidad_del_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modalidad_de_Robo_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceModalidad_del_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modalidad_de_Robo_de_Vehiculo.Descripcion = '" + filter.AdvanceModalidad_del_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modalidad_de_Robo_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceModalidad_del_Robo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModalidad_del_RoboMultiple != null && filter.AdvanceModalidad_del_RoboMultiple.Count() > 0)
            {
                var Modalidad_del_RoboIds = string.Join(",", filter.AdvanceModalidad_del_RoboMultiple);

                where += " AND Orientador.Modalidad_del_Robo In (" + Modalidad_del_RoboIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCircunstancia_Defuncion))
            {
                switch (filter.Circunstancia_DefuncionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Circunstancia_Defuncion.Descripcion LIKE '" + filter.AdvanceCircunstancia_Defuncion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Circunstancia_Defuncion.Descripcion LIKE '%" + filter.AdvanceCircunstancia_Defuncion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Circunstancia_Defuncion.Descripcion = '" + filter.AdvanceCircunstancia_Defuncion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Circunstancia_Defuncion.Descripcion LIKE '%" + filter.AdvanceCircunstancia_Defuncion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCircunstancia_DefuncionMultiple != null && filter.AdvanceCircunstancia_DefuncionMultiple.Count() > 0)
            {
                var Circunstancia_DefuncionIds = string.Join(",", filter.AdvanceCircunstancia_DefuncionMultiple);

                where += " AND Orientador.Circunstancia_Defuncion In (" + Circunstancia_DefuncionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceConsecuencia_Defuncion))
            {
                switch (filter.Consecuencia_DefuncionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Consecuencia_Defuncion.Descripcion LIKE '" + filter.AdvanceConsecuencia_Defuncion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Consecuencia_Defuncion.Descripcion LIKE '%" + filter.AdvanceConsecuencia_Defuncion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Consecuencia_Defuncion.Descripcion = '" + filter.AdvanceConsecuencia_Defuncion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Consecuencia_Defuncion.Descripcion LIKE '%" + filter.AdvanceConsecuencia_Defuncion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceConsecuencia_DefuncionMultiple != null && filter.AdvanceConsecuencia_DefuncionMultiple.Count() > 0)
            {
                var Consecuencia_DefuncionIds = string.Join(",", filter.AdvanceConsecuencia_DefuncionMultiple);

                where += " AND Orientador.Consecuencia_Defuncion In (" + Consecuencia_DefuncionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Levantamiento) || !string.IsNullOrEmpty(filter.ToFecha_Levantamiento))
            {
                var Fecha_LevantamientoFrom = DateTime.ParseExact(filter.FromFecha_Levantamiento, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_LevantamientoTo = DateTime.ParseExact(filter.ToFecha_Levantamiento, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Levantamiento))
                    where += " AND Orientador.Fecha_Levantamiento >= '" + Fecha_LevantamientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Levantamiento))
                    where += " AND Orientador.Fecha_Levantamiento <= '" + Fecha_LevantamientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_Levantamiento) || !string.IsNullOrEmpty(filter.ToHora_Levantamiento))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_Levantamiento))
                    where += " AND Convert(TIME,Orientador.Hora_Levantamiento) >='" + filter.FromHora_Levantamiento + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_Levantamiento))
                    where += " AND Convert(TIME,Orientador.Hora_Levantamiento) <='" + filter.ToHora_Levantamiento + "'";
            }

            if (!string.IsNullOrEmpty(filter.Domicilio))
            {
                switch (filter.DomicilioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Domicilio LIKE '" + filter.Domicilio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Domicilio LIKE '%" + filter.Domicilio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Domicilio = '" + filter.Domicilio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Domicilio LIKE '%" + filter.Domicilio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior3))
            {
                switch (filter.Numero_Interior3Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Numero_Interior3 LIKE '" + filter.Numero_Interior3 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Numero_Interior3 LIKE '%" + filter.Numero_Interior3 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Numero_Interior3 = '" + filter.Numero_Interior3 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Numero_Interior3 LIKE '%" + filter.Numero_Interior3 + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromNumero_Exterior3) || !string.IsNullOrEmpty(filter.ToNumero_Exterior3))
            {
                if (!string.IsNullOrEmpty(filter.FromNumero_Exterior3))
                    where += " AND Orientador.Numero_Exterior3 >= " + filter.FromNumero_Exterior3;
                if (!string.IsNullOrEmpty(filter.ToNumero_Exterior3))
                    where += " AND Orientador.Numero_Exterior3 <= " + filter.ToNumero_Exterior3;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia3))
            {
                switch (filter.Colonia3Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia3 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia3 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia3 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia3 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia3Multiple != null && filter.AdvanceColonia3Multiple.Count() > 0)
            {
                var Colonia3Ids = string.Join(",", filter.AdvanceColonia3Multiple);

                where += " AND Orientador.Colonia3 In (" + Colonia3Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.Colonia_no_Catalogada))
            {
                switch (filter.Colonia_no_CatalogadaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Colonia_no_Catalogada LIKE '" + filter.Colonia_no_Catalogada + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Colonia_no_Catalogada LIKE '%" + filter.Colonia_no_Catalogada + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Colonia_no_Catalogada = '" + filter.Colonia_no_Catalogada + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Colonia_no_Catalogada LIKE '%" + filter.Colonia_no_Catalogada + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceZona2))
            {
                switch (filter.Zona2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Zona.Descripcion LIKE '" + filter.AdvanceZona2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Zona.Descripcion LIKE '%" + filter.AdvanceZona2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Zona.Descripcion = '" + filter.AdvanceZona2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Zona.Descripcion LIKE '%" + filter.AdvanceZona2 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceZona2Multiple != null && filter.AdvanceZona2Multiple.Count() > 0)
            {
                var Zona2Ids = string.Join(",", filter.AdvanceZona2Multiple);

                where += " AND Orientador.Zona2 In (" + Zona2Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio3))
            {
                switch (filter.Municipio3Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio3 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio3 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio3 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio3 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio3Multiple != null && filter.AdvanceMunicipio3Multiple.Count() > 0)
            {
                var Municipio3Ids = string.Join(",", filter.AdvanceMunicipio3Multiple);

                where += " AND Orientador.Municipio3 In (" + Municipio3Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado3))
            {
                switch (filter.Estado3Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado3 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado3 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado3 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado3 + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado3Multiple != null && filter.AdvanceEstado3Multiple.Count() > 0)
            {
                var Estado3Ids = string.Join(",", filter.AdvanceEstado3Multiple);

                where += " AND Orientador.Estado3 In (" + Estado3Ids + ")";
            }

            if (!string.IsNullOrEmpty(filter.Necropsia))
            {
                switch (filter.NecropsiaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Necropsia LIKE '" + filter.Necropsia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Necropsia LIKE '%" + filter.Necropsia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Necropsia = '" + filter.Necropsia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Necropsia LIKE '%" + filter.Necropsia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Cronotanatodiagnostico))
            {
                switch (filter.CronotanatodiagnosticoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Cronotanatodiagnostico LIKE '" + filter.Cronotanatodiagnostico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Cronotanatodiagnostico LIKE '%" + filter.Cronotanatodiagnostico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Cronotanatodiagnostico = '" + filter.Cronotanatodiagnostico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Cronotanatodiagnostico LIKE '%" + filter.Cronotanatodiagnostico + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Ruta))
            {
                switch (filter.RutaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Ruta LIKE '" + filter.Ruta + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Ruta LIKE '%" + filter.Ruta + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Ruta = '" + filter.Ruta + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Ruta LIKE '%" + filter.Ruta + "%'";
                        break;
                }
            }

            if (filter.Estado_Operador != RadioOptions.NoApply)
                where += " AND Orientador.Estado_Operador = " + Convert.ToInt32(filter.Estado_Operador);

            if (filter.Delito_Principal_o_Secundario != RadioOptions.NoApply)
                where += " AND Orientador.Delito_Principal_o_Secundario = " + Convert.ToInt32(filter.Delito_Principal_o_Secundario);

            if (!string.IsNullOrEmpty(filter.Concurso))
            {
                switch (filter.ConcursoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Concurso LIKE '" + filter.Concurso + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Concurso LIKE '%" + filter.Concurso + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Concurso = '" + filter.Concurso + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Concurso LIKE '%" + filter.Concurso + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCompareciente))
            {
                switch (filter.ComparecienteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Compareciente.Descripcion LIKE '" + filter.AdvanceCompareciente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Compareciente.Descripcion LIKE '%" + filter.AdvanceCompareciente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Compareciente.Descripcion = '" + filter.AdvanceCompareciente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Compareciente.Descripcion LIKE '%" + filter.AdvanceCompareciente + "%'";
                        break;
                }
            }
            else if (filter.AdvanceComparecienteMultiple != null && filter.AdvanceComparecienteMultiple.Count() > 0)
            {
                var ComparecienteIds = string.Join(",", filter.AdvanceComparecienteMultiple);

                where += " AND Orientador.Compareciente In (" + ComparecienteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.NombreC))
            {
                switch (filter.NombreCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.NombreC LIKE '" + filter.NombreC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.NombreC LIKE '%" + filter.NombreC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.NombreC = '" + filter.NombreC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.NombreC LIKE '%" + filter.NombreC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_PaternoC))
            {
                switch (filter.Apellido_PaternoCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Apellido_PaternoC LIKE '" + filter.Apellido_PaternoC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Apellido_PaternoC LIKE '%" + filter.Apellido_PaternoC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Apellido_PaternoC = '" + filter.Apellido_PaternoC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Apellido_PaternoC LIKE '%" + filter.Apellido_PaternoC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_MaternoC))
            {
                switch (filter.Apellido_MaternoCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Apellido_MaternoC LIKE '" + filter.Apellido_MaternoC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Apellido_MaternoC LIKE '%" + filter.Apellido_MaternoC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Apellido_MaternoC = '" + filter.Apellido_MaternoC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Apellido_MaternoC LIKE '%" + filter.Apellido_MaternoC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.NombreT))
            {
                switch (filter.NombreTFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.NombreT LIKE '" + filter.NombreT + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.NombreT LIKE '%" + filter.NombreT + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.NombreT = '" + filter.NombreT + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.NombreT LIKE '%" + filter.NombreT + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_PaternoT))
            {
                switch (filter.Apellido_PaternoTFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Apellido_PaternoT LIKE '" + filter.Apellido_PaternoT + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Apellido_PaternoT LIKE '%" + filter.Apellido_PaternoT + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Apellido_PaternoT = '" + filter.Apellido_PaternoT + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Apellido_PaternoT LIKE '%" + filter.Apellido_PaternoT + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_MaternoT))
            {
                switch (filter.Apellido_MaternoTFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Apellido_MaternoT LIKE '" + filter.Apellido_MaternoT + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Apellido_MaternoT LIKE '%" + filter.Apellido_MaternoT + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Apellido_MaternoT = '" + filter.Apellido_MaternoT + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Apellido_MaternoT LIKE '%" + filter.Apellido_MaternoT + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.CalleC))
            {
                switch (filter.CalleCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.CalleC LIKE '" + filter.CalleC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.CalleC LIKE '%" + filter.CalleC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.CalleC = '" + filter.CalleC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.CalleC LIKE '%" + filter.CalleC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromNumero_ExteriorC) || !string.IsNullOrEmpty(filter.ToNumero_ExteriorC))
            {
                if (!string.IsNullOrEmpty(filter.FromNumero_ExteriorC))
                    where += " AND Orientador.Numero_ExteriorC >= " + filter.FromNumero_ExteriorC;
                if (!string.IsNullOrEmpty(filter.ToNumero_ExteriorC))
                    where += " AND Orientador.Numero_ExteriorC <= " + filter.ToNumero_ExteriorC;
            }

            if (!string.IsNullOrEmpty(filter.Numero_InteriorC))
            {
                switch (filter.Numero_InteriorCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Numero_InteriorC LIKE '" + filter.Numero_InteriorC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Numero_InteriorC LIKE '%" + filter.Numero_InteriorC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Numero_InteriorC = '" + filter.Numero_InteriorC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Numero_InteriorC LIKE '%" + filter.Numero_InteriorC + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColoniaC))
            {
                switch (filter.ColoniaCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColoniaC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColoniaC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColoniaC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColoniaC + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColoniaCMultiple != null && filter.AdvanceColoniaCMultiple.Count() > 0)
            {
                var ColoniaCIds = string.Join(",", filter.AdvanceColoniaCMultiple);

                where += " AND Orientador.ColoniaC In (" + ColoniaCIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_PostalC) || !string.IsNullOrEmpty(filter.ToCodigo_PostalC))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_PostalC))
                    where += " AND Orientador.Codigo_PostalC >= " + filter.FromCodigo_PostalC;
                if (!string.IsNullOrEmpty(filter.ToCodigo_PostalC))
                    where += " AND Orientador.Codigo_PostalC <= " + filter.ToCodigo_PostalC;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceZonaC))
            {
                switch (filter.ZonaCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Zona.Descripcion LIKE '" + filter.AdvanceZonaC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Zona.Descripcion LIKE '%" + filter.AdvanceZonaC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Zona.Descripcion = '" + filter.AdvanceZonaC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Zona.Descripcion LIKE '%" + filter.AdvanceZonaC + "%'";
                        break;
                }
            }
            else if (filter.AdvanceZonaCMultiple != null && filter.AdvanceZonaCMultiple.Count() > 0)
            {
                var ZonaCIds = string.Join(",", filter.AdvanceZonaCMultiple);

                where += " AND Orientador.ZonaC In (" + ZonaCIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipioC))
            {
                switch (filter.MunicipioCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipioC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipioC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipioC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipioC + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipioCMultiple != null && filter.AdvanceMunicipioCMultiple.Count() > 0)
            {
                var MunicipioCIds = string.Join(",", filter.AdvanceMunicipioCMultiple);

                where += " AND Orientador.MunicipioC In (" + MunicipioCIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstadoC))
            {
                switch (filter.EstadoCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstadoC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstadoC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstadoC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstadoC + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstadoCMultiple != null && filter.AdvanceEstadoCMultiple.Count() > 0)
            {
                var EstadoCIds = string.Join(",", filter.AdvanceEstadoCMultiple);

                where += " AND Orientador.EstadoC In (" + EstadoCIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.NarrativaC))
            {
                switch (filter.NarrativaCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.NarrativaC LIKE '" + filter.NarrativaC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.NarrativaC LIKE '%" + filter.NarrativaC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.NarrativaC = '" + filter.NarrativaC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.NarrativaC LIKE '%" + filter.NarrativaC + "%'";
                        break;
                }
            }

            if (filter.Conocido != RadioOptions.NoApply)
                where += " AND Orientador.Conocido = " + Convert.ToInt32(filter.Conocido);

            if (filter.Desconocido != RadioOptions.NoApply)
                where += " AND Orientador.Desconocido = " + Convert.ToInt32(filter.Desconocido);

            if (!string.IsNullOrEmpty(filter.FromNumero_de_Imputados) || !string.IsNullOrEmpty(filter.ToNumero_de_Imputados))
            {
                if (!string.IsNullOrEmpty(filter.FromNumero_de_Imputados))
                    where += " AND Orientador.Numero_de_Imputados >= " + filter.FromNumero_de_Imputados;
                if (!string.IsNullOrEmpty(filter.ToNumero_de_Imputados))
                    where += " AND Orientador.Numero_de_Imputados <= " + filter.ToNumero_de_Imputados;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceProcedencia))
            {
                switch (filter.ProcedenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Procedencia_del_Vehiculo.Descripcion LIKE '" + filter.AdvanceProcedencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Procedencia_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceProcedencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Procedencia_del_Vehiculo.Descripcion = '" + filter.AdvanceProcedencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Procedencia_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceProcedencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceProcedenciaMultiple != null && filter.AdvanceProcedenciaMultiple.Count() > 0)
            {
                var ProcedenciaIds = string.Join(",", filter.AdvanceProcedenciaMultiple);

                where += " AND Orientador.Procedencia In (" + ProcedenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Motor))
            {
                switch (filter.MotorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Motor LIKE '" + filter.Motor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Motor LIKE '%" + filter.Motor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Motor = '" + filter.Motor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Motor LIKE '%" + filter.Motor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Serie))
            {
                switch (filter.SerieFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Serie LIKE '" + filter.Serie + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Serie LIKE '%" + filter.Serie + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Serie = '" + filter.Serie + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Serie LIKE '%" + filter.Serie + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Causa_de_Muerte))
            {
                switch (filter.Causa_de_MuerteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Causa_de_Muerte LIKE '" + filter.Causa_de_Muerte + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Causa_de_Muerte LIKE '%" + filter.Causa_de_Muerte + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Causa_de_Muerte = '" + filter.Causa_de_Muerte + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Causa_de_Muerte LIKE '%" + filter.Causa_de_Muerte + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle))
            {
                switch (filter.Entre_CalleFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Entre_Calle LIKE '" + filter.Entre_Calle + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Entre_Calle LIKE '%" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Entre_Calle = '" + filter.Entre_Calle + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Entre_Calle LIKE '%" + filter.Entre_Calle + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle2))
            {
                switch (filter.Entre_Calle2Filter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Orientador.Entre_Calle2 LIKE '" + filter.Entre_Calle2 + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Orientador.Entre_Calle2 LIKE '%" + filter.Entre_Calle2 + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Orientador.Entre_Calle2 = '" + filter.Entre_Calle2 + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Orientador.Entre_Calle2 LIKE '%" + filter.Entre_Calle2 + "%'";
                        break;
                }
            }

            if (filter.Autoriza != RadioOptions.NoApply)
                where += " AND Orientador.Autoriza = " + Convert.ToInt32(filter.Autoriza);

            if (filter.Autoriza2 != RadioOptions.NoApply)
                where += " AND Orientador.Autoriza2 = " + Convert.ToInt32(filter.Autoriza2);

            if (filter.Autoriza3 != RadioOptions.NoApply)
                where += " AND Orientador.Autoriza3 = " + Convert.ToInt32(filter.Autoriza3);

            if (filter.Menor_de_Edad != RadioOptions.NoApply)
                where += " AND Orientador.Menor_de_Edad = " + Convert.ToInt32(filter.Menor_de_Edad);


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
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);

                Orientador varOrientador = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IOrientadorApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, OrientadorModel varOrientador)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var OrientadorInfo = new Orientador
                    {
                        Clave = varOrientador.Clave
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varOrientador.Fecha_de_Registro)) ? DateTime.ParseExact(varOrientador.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varOrientador.Hora_de_Registro
                        ,Usuario_que_Registra = varOrientador.Usuario_que_Registra
                        ,Atencion_Medica = varOrientador.Atencion_Medica
                        ,Atencion_Psicologica = varOrientador.Atencion_Psicologica
                        ,Traductor = varOrientador.Traductor
                        ,Narrativa_DM = varOrientador.Narrativa_DM
                        ,Narrativa_DP = varOrientador.Narrativa_DP
                        ,Idioma = varOrientador.Idioma
                        ,Nombre = varOrientador.Nombre
                        ,Apellido_Paterno = varOrientador.Apellido_Paterno
                        ,Apellido_Materno = varOrientador.Apellido_Materno
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varOrientador.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varOrientador.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varOrientador.Edad
                        ,Sexo = varOrientador.Sexo
                        ,Estado_Civil = varOrientador.Estado_Civil
                        ,Tipo_de_Identificacion = varOrientador.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varOrientador.Numero_de_Identificacion
                        ,Nacionalidad = varOrientador.Nacionalidad
                        ,Escolaridad = varOrientador.Escolaridad
                        ,Ocupacion = varOrientador.Ocupacion
                        ,Calle = varOrientador.Calle
                        ,Numero_Exterior = varOrientador.Numero_Exterior
                        ,Numero_Interior = varOrientador.Numero_Interior
                        ,Colonia = varOrientador.Colonia
                        ,Codigo_Postal = varOrientador.Codigo_Postal
                        ,Localidad = varOrientador.Localidad
                        ,Municipio = varOrientador.Municipio
                        ,Estado = varOrientador.Estado
                        ,Telefono = varOrientador.Telefono
                        ,Celular = varOrientador.Celular
                        ,Correo_Electronico = varOrientador.Correo_Electronico
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varOrientador.Fecha_del_Hecho)) ? DateTime.ParseExact(varOrientador.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Aproximada_del_Hecho = varOrientador.Hora_Aproximada_del_Hecho
                        ,Tipo_de_Lugar_del_Hecho = varOrientador.Tipo_de_Lugar_del_Hecho
                        ,Calle2 = varOrientador.Calle2
                        ,Numero_Exterior2 = varOrientador.Numero_Exterior2
                        ,Numero_Interior2 = varOrientador.Numero_Interior2
                        ,Colonia2 = varOrientador.Colonia2
                        ,Codigo_Postal2 = varOrientador.Codigo_Postal2
                        ,Zona = varOrientador.Zona
                        ,Municipio2 = varOrientador.Municipio2
                        ,Estado2 = varOrientador.Estado2
                        ,Grupo_Delito = varOrientador.Grupo_Delito
                        ,Delito = varOrientador.Delito
                        ,Circunstancia = varOrientador.Circunstancia
                        ,Tipo_Delito = varOrientador.Tipo_Delito
                        ,Forma_Comision_Delito = varOrientador.Forma_Comision_Delito
                        ,Forma_Accion_Delito = varOrientador.Forma_Accion_Delito
                        ,Modalidad_Delito = varOrientador.Modalidad_Delito
                        ,Elementos_Comision_Delito = varOrientador.Elementos_Comision_Delito
                        ,Monto = varOrientador.Monto
                        ,HViolencia_de_Genero = varOrientador.HViolencia_de_Genero
                        ,Calificacion_del_Delito = varOrientador.Calificacion_del_Delito
                        ,CircunstanciaV = varOrientador.CircunstanciaV
                        ,Clase_Especifica = varOrientador.Clase_Especifica
                        ,Marca = varOrientador.Marca
                        ,Sub_Marca = varOrientador.Sub_Marca
                        ,Tipo_de_Vehiculo = varOrientador.Tipo_de_Vehiculo
                        ,Modelo = varOrientador.Modelo
                        ,Color = varOrientador.Color
                        ,Placas = varOrientador.Placas
                        ,Estado_Placas = varOrientador.Estado_Placas
                        ,Vehiculo_Robado = varOrientador.Vehiculo_Robado
                        ,Seguro = varOrientador.Seguro
                        ,Aseguradora = varOrientador.Aseguradora
                        ,Tipo_de_Servicio = varOrientador.Tipo_de_Servicio
                        ,Ruta_del_Servicio_Publico = varOrientador.Ruta_del_Servicio_Publico
                        ,Mercancia = varOrientador.Mercancia
                        ,Descripcion = varOrientador.Descripcion
                        ,Monto_de_la_Carga = varOrientador.Monto_de_la_Carga
                        ,Senas_Particulares = varOrientador.Senas_Particulares
                        ,Modalidad_del_Robo = varOrientador.Modalidad_del_Robo
                        ,Circunstancia_Defuncion = varOrientador.Circunstancia_Defuncion
                        ,Consecuencia_Defuncion = varOrientador.Consecuencia_Defuncion
                        ,Fecha_Levantamiento = (!String.IsNullOrEmpty(varOrientador.Fecha_Levantamiento)) ? DateTime.ParseExact(varOrientador.Fecha_Levantamiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Levantamiento = varOrientador.Hora_Levantamiento
                        ,Domicilio = varOrientador.Domicilio
                        ,Numero_Interior3 = varOrientador.Numero_Interior3
                        ,Numero_Exterior3 = varOrientador.Numero_Exterior3
                        ,Colonia3 = varOrientador.Colonia3
                        ,Colonia_no_Catalogada = varOrientador.Colonia_no_Catalogada
                        ,Zona2 = varOrientador.Zona2
                        ,Municipio3 = varOrientador.Municipio3
                        ,Estado3 = varOrientador.Estado3
                        ,Necropsia = varOrientador.Necropsia
                        ,Cronotanatodiagnostico = varOrientador.Cronotanatodiagnostico
                        ,Ruta = varOrientador.Ruta
                        ,Estado_Operador = varOrientador.Estado_Operador
                        ,Delito_Principal_o_Secundario = varOrientador.Delito_Principal_o_Secundario
                        ,Concurso = varOrientador.Concurso
                        ,Compareciente = varOrientador.Compareciente
                        ,NombreC = varOrientador.NombreC
                        ,Apellido_PaternoC = varOrientador.Apellido_PaternoC
                        ,Apellido_MaternoC = varOrientador.Apellido_MaternoC
                        ,NombreT = varOrientador.NombreT
                        ,Apellido_PaternoT = varOrientador.Apellido_PaternoT
                        ,Apellido_MaternoT = varOrientador.Apellido_MaternoT
                        ,CalleC = varOrientador.CalleC
                        ,Numero_ExteriorC = varOrientador.Numero_ExteriorC
                        ,Numero_InteriorC = varOrientador.Numero_InteriorC
                        ,ColoniaC = varOrientador.ColoniaC
                        ,Codigo_PostalC = varOrientador.Codigo_PostalC
                        ,ZonaC = varOrientador.ZonaC
                        ,MunicipioC = varOrientador.MunicipioC
                        ,EstadoC = varOrientador.EstadoC
                        ,NarrativaC = varOrientador.NarrativaC
                        ,Conocido = varOrientador.Conocido
                        ,Desconocido = varOrientador.Desconocido
                        ,Numero_de_Imputados = varOrientador.Numero_de_Imputados
                        ,Procedencia = varOrientador.Procedencia
                        ,Motor = varOrientador.Motor
                        ,Serie = varOrientador.Serie
                        ,Causa_de_Muerte = varOrientador.Causa_de_Muerte
                        ,Entre_Calle = varOrientador.Entre_Calle
                        ,Entre_Calle2 = varOrientador.Entre_Calle2
                        ,Autoriza = varOrientador.Autoriza
                        ,Autoriza2 = varOrientador.Autoriza2
                        ,Autoriza3 = varOrientador.Autoriza3
                        ,Menor_de_Edad = varOrientador.Menor_de_Edad

                    };

                    result = !IsNew ?
                        _IOrientadorApiConsumer.Update(OrientadorInfo, null, null).Resource.ToString() :
                         _IOrientadorApiConsumer.Insert(OrientadorInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Orientador script
        /// </summary>
        /// <param name="oOrientadorElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew OrientadorModuleAttributeList)
        {
            for (int i = 0; i < OrientadorModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(OrientadorModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    OrientadorModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(OrientadorModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    OrientadorModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (OrientadorModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < OrientadorModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < OrientadorModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(OrientadorModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							OrientadorModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(OrientadorModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							OrientadorModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strOrientadorScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Orientador.js")))
            {
                strOrientadorScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Orientador element attributes
            string userChangeJson = jsSerialize.Serialize(OrientadorModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strOrientadorScript.IndexOf("inpuElementArray");
            string splittedString = strOrientadorScript.Substring(indexOfArray, strOrientadorScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(OrientadorModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (OrientadorModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strOrientadorScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strOrientadorScript.Substring(indexOfArrayHistory, strOrientadorScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strOrientadorScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strOrientadorScript.Substring(endIndexOfMainElement + indexOfArray, strOrientadorScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (OrientadorModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in OrientadorModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Orientador.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Orientador.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Orientador.js")))
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
        public ActionResult OrientadorPropertyBag()
        {
            return PartialView("OrientadorPropertyBag", "Orientador");
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
                var whereClauseFormat = "Object = 44998 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Orientador.Clave= " + RecordId;
                            var result = _IOrientadorApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new OrientadorPropertyMapper());
			
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
                    (OrientadorAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            OrientadorPropertyMapper oOrientadorPropertyMapper = new OrientadorPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oOrientadorPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IOrientadorApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Orientadors == null)
                result.Orientadors = new List<Orientador>();

            var data = result.Orientadors.Select(m => new OrientadorGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Atencion_Medica = m.Atencion_Medica
			,Atencion_Psicologica = m.Atencion_Psicologica
			,Traductor = m.Traductor
			,Narrativa_DM = m.Narrativa_DM
			,Narrativa_DP = m.Narrativa_DP
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
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
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_Localidad.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
			,Calle2 = m.Calle2
			,Numero_Exterior2 = m.Numero_Exterior2
			,Numero_Interior2 = m.Numero_Interior2
                        ,Colonia2Nombre = CultureHelper.GetTraduction(m.Colonia2_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia2_Colonia.Nombre
			,Codigo_Postal2 = m.Codigo_Postal2
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Zona.Descripcion
                        ,Municipio2Nombre = CultureHelper.GetTraduction(m.Municipio2_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio2_Municipio.Nombre
                        ,Estado2Nombre = CultureHelper.GetTraduction(m.Estado2_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado2_Estado.Nombre
                        ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
                        ,CircunstanciaDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Circunstancia_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Circunstancia_del_Delito.Descripcion
                        ,Tipo_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_Delito_Tipo_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Delito_Tipo_Delito.Descripcion
                        ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Comision_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Accion_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_Comision_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
			,Monto = m.Monto
			,HViolencia_de_Genero = m.HViolencia_de_Genero
			,Calificacion_del_Delito = m.Calificacion_del_Delito
                        ,CircunstanciaVDescripcion = CultureHelper.GetTraduction(m.CircunstanciaV_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.CircunstanciaV_Circunstancia_Vehiculo.Descripcion
                        ,Clase_EspecificaDescripcion = CultureHelper.GetTraduction(m.Clase_Especifica_Especifica_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Clase_Especifica_Especifica_Vehiculo.Descripcion
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_PlacasNombre = CultureHelper.GetTraduction(m.Estado_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Placas_Estado.Nombre
			,Vehiculo_Robado = m.Vehiculo_Robado
			,Seguro = m.Seguro
                        ,AseguradoraDescripcion = CultureHelper.GetTraduction(m.Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
			,Mercancia = m.Mercancia
			,Descripcion = m.Descripcion
			,Monto_de_la_Carga = m.Monto_de_la_Carga
			,Senas_Particulares = m.Senas_Particulares
                        ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
                        ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Defuncion_Circunstancia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                        ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Consecuencia_Defuncion_Consecuencia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                        ,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_Levantamiento = m.Hora_Levantamiento
			,Domicilio = m.Domicilio
			,Numero_Interior3 = m.Numero_Interior3
			,Numero_Exterior3 = m.Numero_Exterior3
                        ,Colonia3Nombre = CultureHelper.GetTraduction(m.Colonia3_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia3_Colonia.Nombre
			,Colonia_no_Catalogada = m.Colonia_no_Catalogada
                        ,Zona2Descripcion = CultureHelper.GetTraduction(m.Zona2_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona2_Zona.Descripcion
                        ,Municipio3Nombre = CultureHelper.GetTraduction(m.Municipio3_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio3_Municipio.Nombre
                        ,Estado3Nombre = CultureHelper.GetTraduction(m.Estado3_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado3_Estado.Nombre
			,Necropsia = m.Necropsia
			,Cronotanatodiagnostico = m.Cronotanatodiagnostico
			,Ruta = m.Ruta
			,Estado_Operador = m.Estado_Operador
			,Delito_Principal_o_Secundario = m.Delito_Principal_o_Secundario
			,Concurso = m.Concurso
                        ,ComparecienteDescripcion = CultureHelper.GetTraduction(m.Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Compareciente_Tipo_de_Compareciente.Descripcion
			,NombreC = m.NombreC
			,Apellido_PaternoC = m.Apellido_PaternoC
			,Apellido_MaternoC = m.Apellido_MaternoC
			,NombreT = m.NombreT
			,Apellido_PaternoT = m.Apellido_PaternoT
			,Apellido_MaternoT = m.Apellido_MaternoT
			,CalleC = m.CalleC
			,Numero_ExteriorC = m.Numero_ExteriorC
			,Numero_InteriorC = m.Numero_InteriorC
                        ,ColoniaCNombre = CultureHelper.GetTraduction(m.ColoniaC_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaC_Colonia.Nombre
			,Codigo_PostalC = m.Codigo_PostalC
                        ,ZonaCDescripcion = CultureHelper.GetTraduction(m.ZonaC_Zona.Clave.ToString(), "Descripcion") ?? (string)m.ZonaC_Zona.Descripcion
                        ,MunicipioCNombre = CultureHelper.GetTraduction(m.MunicipioC_Municipio.Clave.ToString(), "Municipio") ?? (string)m.MunicipioC_Municipio.Nombre
                        ,EstadoCNombre = CultureHelper.GetTraduction(m.EstadoC_Estado.Clave.ToString(), "Estado") ?? (string)m.EstadoC_Estado.Nombre
			,NarrativaC = m.NarrativaC
			,Conocido = m.Conocido
			,Desconocido = m.Desconocido
			,Numero_de_Imputados = m.Numero_de_Imputados
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
			,Motor = m.Motor
			,Serie = m.Serie
			,Causa_de_Muerte = m.Causa_de_Muerte
			,Entre_Calle = m.Entre_Calle
			,Entre_Calle2 = m.Entre_Calle2
			,Autoriza = m.Autoriza
			,Autoriza2 = m.Autoriza2
			,Autoriza3 = m.Autoriza3
			,Menor_de_Edad = m.Menor_de_Edad

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(44998, arrayColumnsVisible), "OrientadorList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(44998, arrayColumnsVisible), "OrientadorList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(44998, arrayColumnsVisible), "OrientadorList_" + DateTime.Now.ToString());
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

            _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new OrientadorPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (OrientadorAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            OrientadorPropertyMapper oOrientadorPropertyMapper = new OrientadorPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oOrientadorPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IOrientadorApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Orientadors == null)
                result.Orientadors = new List<Orientador>();

            var data = result.Orientadors.Select(m => new OrientadorGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Atencion_Medica = m.Atencion_Medica
			,Atencion_Psicologica = m.Atencion_Psicologica
			,Traductor = m.Traductor
			,Narrativa_DM = m.Narrativa_DM
			,Narrativa_DP = m.Narrativa_DP
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
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
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_Localidad.Descripcion
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
			,Calle2 = m.Calle2
			,Numero_Exterior2 = m.Numero_Exterior2
			,Numero_Interior2 = m.Numero_Interior2
                        ,Colonia2Nombre = CultureHelper.GetTraduction(m.Colonia2_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia2_Colonia.Nombre
			,Codigo_Postal2 = m.Codigo_Postal2
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Zona.Descripcion
                        ,Municipio2Nombre = CultureHelper.GetTraduction(m.Municipio2_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio2_Municipio.Nombre
                        ,Estado2Nombre = CultureHelper.GetTraduction(m.Estado2_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado2_Estado.Nombre
                        ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
                        ,CircunstanciaDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Circunstancia_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Circunstancia_del_Delito.Descripcion
                        ,Tipo_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_Delito_Tipo_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Delito_Tipo_Delito.Descripcion
                        ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Comision_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Accion_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_Comision_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
			,Monto = m.Monto
			,HViolencia_de_Genero = m.HViolencia_de_Genero
			,Calificacion_del_Delito = m.Calificacion_del_Delito
                        ,CircunstanciaVDescripcion = CultureHelper.GetTraduction(m.CircunstanciaV_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.CircunstanciaV_Circunstancia_Vehiculo.Descripcion
                        ,Clase_EspecificaDescripcion = CultureHelper.GetTraduction(m.Clase_Especifica_Especifica_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Clase_Especifica_Especifica_Vehiculo.Descripcion
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_PlacasNombre = CultureHelper.GetTraduction(m.Estado_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Placas_Estado.Nombre
			,Vehiculo_Robado = m.Vehiculo_Robado
			,Seguro = m.Seguro
                        ,AseguradoraDescripcion = CultureHelper.GetTraduction(m.Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
			,Mercancia = m.Mercancia
			,Descripcion = m.Descripcion
			,Monto_de_la_Carga = m.Monto_de_la_Carga
			,Senas_Particulares = m.Senas_Particulares
                        ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
                        ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Defuncion_Circunstancia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                        ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Consecuencia_Defuncion_Consecuencia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                        ,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_Levantamiento = m.Hora_Levantamiento
			,Domicilio = m.Domicilio
			,Numero_Interior3 = m.Numero_Interior3
			,Numero_Exterior3 = m.Numero_Exterior3
                        ,Colonia3Nombre = CultureHelper.GetTraduction(m.Colonia3_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia3_Colonia.Nombre
			,Colonia_no_Catalogada = m.Colonia_no_Catalogada
                        ,Zona2Descripcion = CultureHelper.GetTraduction(m.Zona2_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona2_Zona.Descripcion
                        ,Municipio3Nombre = CultureHelper.GetTraduction(m.Municipio3_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio3_Municipio.Nombre
                        ,Estado3Nombre = CultureHelper.GetTraduction(m.Estado3_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado3_Estado.Nombre
			,Necropsia = m.Necropsia
			,Cronotanatodiagnostico = m.Cronotanatodiagnostico
			,Ruta = m.Ruta
			,Estado_Operador = m.Estado_Operador
			,Delito_Principal_o_Secundario = m.Delito_Principal_o_Secundario
			,Concurso = m.Concurso
                        ,ComparecienteDescripcion = CultureHelper.GetTraduction(m.Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Compareciente_Tipo_de_Compareciente.Descripcion
			,NombreC = m.NombreC
			,Apellido_PaternoC = m.Apellido_PaternoC
			,Apellido_MaternoC = m.Apellido_MaternoC
			,NombreT = m.NombreT
			,Apellido_PaternoT = m.Apellido_PaternoT
			,Apellido_MaternoT = m.Apellido_MaternoT
			,CalleC = m.CalleC
			,Numero_ExteriorC = m.Numero_ExteriorC
			,Numero_InteriorC = m.Numero_InteriorC
                        ,ColoniaCNombre = CultureHelper.GetTraduction(m.ColoniaC_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaC_Colonia.Nombre
			,Codigo_PostalC = m.Codigo_PostalC
                        ,ZonaCDescripcion = CultureHelper.GetTraduction(m.ZonaC_Zona.Clave.ToString(), "Descripcion") ?? (string)m.ZonaC_Zona.Descripcion
                        ,MunicipioCNombre = CultureHelper.GetTraduction(m.MunicipioC_Municipio.Clave.ToString(), "Municipio") ?? (string)m.MunicipioC_Municipio.Nombre
                        ,EstadoCNombre = CultureHelper.GetTraduction(m.EstadoC_Estado.Clave.ToString(), "Estado") ?? (string)m.EstadoC_Estado.Nombre
			,NarrativaC = m.NarrativaC
			,Conocido = m.Conocido
			,Desconocido = m.Desconocido
			,Numero_de_Imputados = m.Numero_de_Imputados
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
			,Motor = m.Motor
			,Serie = m.Serie
			,Causa_de_Muerte = m.Causa_de_Muerte
			,Entre_Calle = m.Entre_Calle
			,Entre_Calle2 = m.Entre_Calle2
			,Autoriza = m.Autoriza
			,Autoriza2 = m.Autoriza2
			,Autoriza3 = m.Autoriza3
			,Menor_de_Edad = m.Menor_de_Edad

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
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOrientadorApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_de_Servicios_de_Apoyo(Orientador_Datos_de_Servicios_de_ApoyoModel varOrientador)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Orientador_Datos_de_Servicios_de_ApoyoInfo = new Orientador_Datos_de_Servicios_de_Apoyo
                {
                    Clave = varOrientador.Clave
                                            ,Fecha_de_Registro = (!String.IsNullOrEmpty(varOrientador.Fecha_de_Registro)) ? DateTime.ParseExact(varOrientador.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varOrientador.Hora_de_Registro
                        ,Usuario_que_Registra = varOrientador.Usuario_que_Registra
                        ,Atencion_Medica = varOrientador.Atencion_Medica
                        ,Atencion_Psicologica = varOrientador.Atencion_Psicologica
                        ,Traductor = varOrientador.Traductor
                        ,Narrativa_DM = varOrientador.Narrativa_DM
                        ,Narrativa_DP = varOrientador.Narrativa_DP
                        ,Idioma = varOrientador.Idioma
                        ,Compareciente = varOrientador.Compareciente
                        ,NombreC = varOrientador.NombreC
                        ,Apellido_PaternoC = varOrientador.Apellido_PaternoC
                        ,Apellido_MaternoC = varOrientador.Apellido_MaternoC
                        ,NombreT = varOrientador.NombreT
                        ,Apellido_PaternoT = varOrientador.Apellido_PaternoT
                        ,Apellido_MaternoT = varOrientador.Apellido_MaternoT
                        ,CalleC = varOrientador.CalleC
                        ,Numero_ExteriorC = varOrientador.Numero_ExteriorC
                        ,Numero_InteriorC = varOrientador.Numero_InteriorC
                        ,ColoniaC = varOrientador.ColoniaC
                        ,Codigo_PostalC = varOrientador.Codigo_PostalC
                        ,ZonaC = varOrientador.ZonaC
                        ,MunicipioC = varOrientador.MunicipioC
                        ,EstadoC = varOrientador.EstadoC
                        ,NarrativaC = varOrientador.NarrativaC
                        ,Autoriza = varOrientador.Autoriza
                        ,Autoriza2 = varOrientador.Autoriza2
                        ,Autoriza3 = varOrientador.Autoriza3
                        ,Menor_de_Edad = varOrientador.Menor_de_Edad
                    
                };

                result = _IOrientadorApiConsumer.Update_Datos_de_Servicios_de_Apoyo(Orientador_Datos_de_Servicios_de_ApoyoInfo).Resource.ToString();
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
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IOrientadorApiConsumer.Get_Datos_de_Servicios_de_Apoyo(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Orientador_Datos_de_Servicios_de_ApoyoModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Atencion_Medica = m.Atencion_Medica
			,Atencion_Psicologica = m.Atencion_Psicologica
			,Traductor = m.Traductor
			,Narrativa_DM = m.Narrativa_DM
			,Narrativa_DP = m.Narrativa_DP
                        ,Idioma = m.Idioma
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
                        ,Compareciente = m.Compareciente
                        ,ComparecienteDescripcion = CultureHelper.GetTraduction(m.Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Compareciente_Tipo_de_Compareciente.Descripcion
			,NombreC = m.NombreC
			,Apellido_PaternoC = m.Apellido_PaternoC
			,Apellido_MaternoC = m.Apellido_MaternoC
			,NombreT = m.NombreT
			,Apellido_PaternoT = m.Apellido_PaternoT
			,Apellido_MaternoT = m.Apellido_MaternoT
			,CalleC = m.CalleC
			,Numero_ExteriorC = m.Numero_ExteriorC
			,Numero_InteriorC = m.Numero_InteriorC
                        ,ColoniaC = m.ColoniaC
                        ,ColoniaCNombre = CultureHelper.GetTraduction(m.ColoniaC_Colonia.Clave.ToString(), "Colonia") ?? (string)m.ColoniaC_Colonia.Nombre
			,Codigo_PostalC = m.Codigo_PostalC
                        ,ZonaC = m.ZonaC
                        ,ZonaCDescripcion = CultureHelper.GetTraduction(m.ZonaC_Zona.Clave.ToString(), "Descripcion") ?? (string)m.ZonaC_Zona.Descripcion
                        ,MunicipioC = m.MunicipioC
                        ,MunicipioCNombre = CultureHelper.GetTraduction(m.MunicipioC_Municipio.Clave.ToString(), "Municipio") ?? (string)m.MunicipioC_Municipio.Nombre
                        ,EstadoC = m.EstadoC
                        ,EstadoCNombre = CultureHelper.GetTraduction(m.EstadoC_Estado.Clave.ToString(), "Estado") ?? (string)m.EstadoC_Estado.Nombre
			,NarrativaC = m.NarrativaC
			,Autoriza = m.Autoriza
			,Autoriza2 = m.Autoriza2
			,Autoriza3 = m.Autoriza3
			,Menor_de_Edad = m.Menor_de_Edad

                    
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
        public ActionResult Post_Datos_del_Imputado(Orientador_Datos_del_ImputadoModel varOrientador)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Orientador_Datos_del_ImputadoInfo = new Orientador_Datos_del_Imputado
                {
                    Clave = varOrientador.Clave
                                            ,Nombre = varOrientador.Nombre
                        ,Apellido_Paterno = varOrientador.Apellido_Paterno
                        ,Apellido_Materno = varOrientador.Apellido_Materno
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varOrientador.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varOrientador.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varOrientador.Edad
                        ,Sexo = varOrientador.Sexo
                        ,Estado_Civil = varOrientador.Estado_Civil
                        ,Tipo_de_Identificacion = varOrientador.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varOrientador.Numero_de_Identificacion
                        ,Nacionalidad = varOrientador.Nacionalidad
                        ,Escolaridad = varOrientador.Escolaridad
                        ,Ocupacion = varOrientador.Ocupacion
                        ,Calle = varOrientador.Calle
                        ,Numero_Exterior = varOrientador.Numero_Exterior
                        ,Numero_Interior = varOrientador.Numero_Interior
                        ,Colonia = varOrientador.Colonia
                        ,Codigo_Postal = varOrientador.Codigo_Postal
                        ,Localidad = varOrientador.Localidad
                        ,Municipio = varOrientador.Municipio
                        ,Estado = varOrientador.Estado
                        ,Telefono = varOrientador.Telefono
                        ,Celular = varOrientador.Celular
                        ,Correo_Electronico = varOrientador.Correo_Electronico
                    
                };

                result = _IOrientadorApiConsumer.Update_Datos_del_Imputado(Orientador_Datos_del_ImputadoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Imputado(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IOrientadorApiConsumer.Get_Datos_del_Imputado(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Orientador_Datos_del_ImputadoModel
                {
                    Clave = m.Clave
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
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,Localidad = m.Localidad
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_Localidad.Descripcion
                        ,Municipio = m.Municipio
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,Estado = m.Estado
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico

                    
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
        public ActionResult Post_Datos_de_los_Hechos(Orientador_Datos_de_los_HechosModel varOrientador)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Orientador_Datos_de_los_HechosInfo = new Orientador_Datos_de_los_Hechos
                {
                    Clave = varOrientador.Clave
                                            ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varOrientador.Fecha_del_Hecho)) ? DateTime.ParseExact(varOrientador.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Aproximada_del_Hecho = varOrientador.Hora_Aproximada_del_Hecho
                        ,Tipo_de_Lugar_del_Hecho = varOrientador.Tipo_de_Lugar_del_Hecho
                        ,Calle2 = varOrientador.Calle2
                        ,Numero_Exterior2 = varOrientador.Numero_Exterior2
                        ,Numero_Interior2 = varOrientador.Numero_Interior2
                        ,Colonia2 = varOrientador.Colonia2
                        ,Codigo_Postal2 = varOrientador.Codigo_Postal2
                        ,Zona = varOrientador.Zona
                        ,Municipio2 = varOrientador.Municipio2
                        ,Estado2 = varOrientador.Estado2
                        ,Entre_Calle = varOrientador.Entre_Calle
                        ,Entre_Calle2 = varOrientador.Entre_Calle2
                    
                };

                result = _IOrientadorApiConsumer.Update_Datos_de_los_Hechos(Orientador_Datos_de_los_HechosInfo).Resource.ToString();
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
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IOrientadorApiConsumer.Get_Datos_de_los_Hechos(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Orientador_Datos_de_los_HechosModel
                {
                    Clave = m.Clave
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Tipo_de_Lugar_del_Hecho = m.Tipo_de_Lugar_del_Hecho
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
			,Calle2 = m.Calle2
			,Numero_Exterior2 = m.Numero_Exterior2
			,Numero_Interior2 = m.Numero_Interior2
                        ,Colonia2 = m.Colonia2
                        ,Colonia2Nombre = CultureHelper.GetTraduction(m.Colonia2_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia2_Colonia.Nombre
			,Codigo_Postal2 = m.Codigo_Postal2
                        ,Zona = m.Zona
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Zona.Descripcion
                        ,Municipio2 = m.Municipio2
                        ,Municipio2Nombre = CultureHelper.GetTraduction(m.Municipio2_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio2_Municipio.Nombre
                        ,Estado2 = m.Estado2
                        ,Estado2Nombre = CultureHelper.GetTraduction(m.Estado2_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado2_Estado.Nombre
			,Entre_Calle = m.Entre_Calle
			,Entre_Calle2 = m.Entre_Calle2

                    
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
        public ActionResult Post_Datos_del_Delito(Orientador_Datos_del_DelitoModel varOrientador)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Orientador_Datos_del_DelitoInfo = new Orientador_Datos_del_Delito
                {
                    Clave = varOrientador.Clave
                                            ,Grupo_Delito = varOrientador.Grupo_Delito
                        ,Delito = varOrientador.Delito
                        ,Circunstancia = varOrientador.Circunstancia
                        ,Tipo_Delito = varOrientador.Tipo_Delito
                        ,Forma_Comision_Delito = varOrientador.Forma_Comision_Delito
                        ,Forma_Accion_Delito = varOrientador.Forma_Accion_Delito
                        ,Modalidad_Delito = varOrientador.Modalidad_Delito
                        ,Elementos_Comision_Delito = varOrientador.Elementos_Comision_Delito
                        ,Monto = varOrientador.Monto
                        ,HViolencia_de_Genero = varOrientador.HViolencia_de_Genero
                        ,Calificacion_del_Delito = varOrientador.Calificacion_del_Delito
                        ,Delito_Principal_o_Secundario = varOrientador.Delito_Principal_o_Secundario
                        ,Concurso = varOrientador.Concurso
                    
                };

                result = _IOrientadorApiConsumer.Update_Datos_del_Delito(Orientador_Datos_del_DelitoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_del_Delito(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IOrientadorApiConsumer.Get_Datos_del_Delito(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Orientador_Datos_del_DelitoModel
                {
                    Clave = m.Clave
                        ,Grupo_Delito = m.Grupo_Delito
                        ,Grupo_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_Delito_Grupo_del_Delito.Descripcion
                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
                        ,Circunstancia = m.Circunstancia
                        ,CircunstanciaDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Circunstancia_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Circunstancia_del_Delito.Descripcion
                        ,Tipo_Delito = m.Tipo_Delito
                        ,Tipo_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_Delito_Tipo_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Delito_Tipo_Delito.Descripcion
                        ,Forma_Comision_Delito = m.Forma_Comision_Delito
                        ,Forma_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Comision_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Comision_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_Accion_Delito = m.Forma_Accion_Delito
                        ,Forma_Accion_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_Accion_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Accion_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_Delito = m.Modalidad_Delito
                        ,Modalidad_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_Comision_Delito = m.Elementos_Comision_Delito
                        ,Elementos_Comision_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_Comision_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_Comision_Delito_Elementos_Comision_Delito.Descripcion
			,Monto = m.Monto
			,HViolencia_de_Genero = m.HViolencia_de_Genero
			,Calificacion_del_Delito = m.Calificacion_del_Delito
			,Delito_Principal_o_Secundario = m.Delito_Principal_o_Secundario
			,Concurso = m.Concurso

                    
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
        public ActionResult Post_Datos_de_Robo_de_Vehiculo(Orientador_Datos_de_Robo_de_VehiculoModel varOrientador)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Orientador_Datos_de_Robo_de_VehiculoInfo = new Orientador_Datos_de_Robo_de_Vehiculo
                {
                    Clave = varOrientador.Clave
                                            ,CircunstanciaV = varOrientador.CircunstanciaV
                        ,Clase_Especifica = varOrientador.Clase_Especifica
                        ,Marca = varOrientador.Marca
                        ,Sub_Marca = varOrientador.Sub_Marca
                        ,Tipo_de_Vehiculo = varOrientador.Tipo_de_Vehiculo
                        ,Modelo = varOrientador.Modelo
                        ,Color = varOrientador.Color
                        ,Placas = varOrientador.Placas
                        ,Estado_Placas = varOrientador.Estado_Placas
                        ,Vehiculo_Robado = varOrientador.Vehiculo_Robado
                        ,Seguro = varOrientador.Seguro
                        ,Aseguradora = varOrientador.Aseguradora
                        ,Tipo_de_Servicio = varOrientador.Tipo_de_Servicio
                        ,Ruta_del_Servicio_Publico = varOrientador.Ruta_del_Servicio_Publico
                        ,Mercancia = varOrientador.Mercancia
                        ,Descripcion = varOrientador.Descripcion
                        ,Monto_de_la_Carga = varOrientador.Monto_de_la_Carga
                        ,Senas_Particulares = varOrientador.Senas_Particulares
                        ,Modalidad_del_Robo = varOrientador.Modalidad_del_Robo
                        ,Procedencia = varOrientador.Procedencia
                        ,Motor = varOrientador.Motor
                        ,Serie = varOrientador.Serie
                    
                };

                result = _IOrientadorApiConsumer.Update_Datos_de_Robo_de_Vehiculo(Orientador_Datos_de_Robo_de_VehiculoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_Robo_de_Vehiculo(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IOrientadorApiConsumer.Get_Datos_de_Robo_de_Vehiculo(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Orientador_Datos_de_Robo_de_VehiculoModel
                {
                    Clave = m.Clave
                        ,CircunstanciaV = m.CircunstanciaV
                        ,CircunstanciaVDescripcion = CultureHelper.GetTraduction(m.CircunstanciaV_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.CircunstanciaV_Circunstancia_Vehiculo.Descripcion
                        ,Clase_Especifica = m.Clase_Especifica
                        ,Clase_EspecificaDescripcion = CultureHelper.GetTraduction(m.Clase_Especifica_Especifica_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Clase_Especifica_Especifica_Vehiculo.Descripcion
                        ,Marca = m.Marca
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_Marca = m.Sub_Marca
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_Vehiculo = m.Tipo_de_Vehiculo
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,Color = m.Color
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_Placas = m.Estado_Placas
                        ,Estado_PlacasNombre = CultureHelper.GetTraduction(m.Estado_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Placas_Estado.Nombre
			,Vehiculo_Robado = m.Vehiculo_Robado
			,Seguro = m.Seguro
                        ,Aseguradora = m.Aseguradora
                        ,AseguradoraDescripcion = CultureHelper.GetTraduction(m.Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                        ,Tipo_de_Servicio = m.Tipo_de_Servicio
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
			,Mercancia = m.Mercancia
			,Descripcion = m.Descripcion
			,Monto_de_la_Carga = m.Monto_de_la_Carga
			,Senas_Particulares = m.Senas_Particulares
                        ,Modalidad_del_Robo = m.Modalidad_del_Robo
                        ,Modalidad_del_RoboDescripcion = CultureHelper.GetTraduction(m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_del_Robo_Modalidad_de_Robo_de_Vehiculo.Descripcion
                        ,Procedencia = m.Procedencia
                        ,ProcedenciaDescripcion = CultureHelper.GetTraduction(m.Procedencia_Procedencia_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Procedencia_Procedencia_del_Vehiculo.Descripcion
			,Motor = m.Motor
			,Serie = m.Serie

                    
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
        public ActionResult Post_Datos_de_Levantamiento_de_Cadaver(Orientador_Datos_de_Levantamiento_de_CadaverModel varOrientador)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Orientador_Datos_de_Levantamiento_de_CadaverInfo = new Orientador_Datos_de_Levantamiento_de_Cadaver
                {
                    Clave = varOrientador.Clave
                                            ,Circunstancia_Defuncion = varOrientador.Circunstancia_Defuncion
                        ,Consecuencia_Defuncion = varOrientador.Consecuencia_Defuncion
                        ,Fecha_Levantamiento = (!String.IsNullOrEmpty(varOrientador.Fecha_Levantamiento)) ? DateTime.ParseExact(varOrientador.Fecha_Levantamiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Levantamiento = varOrientador.Hora_Levantamiento
                        ,Domicilio = varOrientador.Domicilio
                        ,Numero_Interior3 = varOrientador.Numero_Interior3
                        ,Numero_Exterior3 = varOrientador.Numero_Exterior3
                        ,Colonia3 = varOrientador.Colonia3
                        ,Colonia_no_Catalogada = varOrientador.Colonia_no_Catalogada
                        ,Zona2 = varOrientador.Zona2
                        ,Municipio3 = varOrientador.Municipio3
                        ,Estado3 = varOrientador.Estado3
                        ,Necropsia = varOrientador.Necropsia
                        ,Cronotanatodiagnostico = varOrientador.Cronotanatodiagnostico
                        ,Ruta = varOrientador.Ruta
                        ,Estado_Operador = varOrientador.Estado_Operador
                        ,Causa_de_Muerte = varOrientador.Causa_de_Muerte
                    
                };

                result = _IOrientadorApiConsumer.Update_Datos_de_Levantamiento_de_Cadaver(Orientador_Datos_de_Levantamiento_de_CadaverInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_Levantamiento_de_Cadaver(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IOrientadorApiConsumer.Get_Datos_de_Levantamiento_de_Cadaver(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Orientador_Datos_de_Levantamiento_de_CadaverModel
                {
                    Clave = m.Clave
                        ,Circunstancia_Defuncion = m.Circunstancia_Defuncion
                        ,Circunstancia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Circunstancia_Defuncion_Circunstancia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_Defuncion_Circunstancia_Defuncion.Descripcion
                        ,Consecuencia_Defuncion = m.Consecuencia_Defuncion
                        ,Consecuencia_DefuncionDescripcion = CultureHelper.GetTraduction(m.Consecuencia_Defuncion_Consecuencia_Defuncion.Clave.ToString(), "Descripcion") ?? (string)m.Consecuencia_Defuncion_Consecuencia_Defuncion.Descripcion
                        ,Fecha_Levantamiento = (m.Fecha_Levantamiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_Levantamiento).ToString(ConfigurationProperty.DateFormat))
			,Hora_Levantamiento = m.Hora_Levantamiento
			,Domicilio = m.Domicilio
			,Numero_Interior3 = m.Numero_Interior3
			,Numero_Exterior3 = m.Numero_Exterior3
                        ,Colonia3 = m.Colonia3
                        ,Colonia3Nombre = CultureHelper.GetTraduction(m.Colonia3_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia3_Colonia.Nombre
			,Colonia_no_Catalogada = m.Colonia_no_Catalogada
                        ,Zona2 = m.Zona2
                        ,Zona2Descripcion = CultureHelper.GetTraduction(m.Zona2_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona2_Zona.Descripcion
                        ,Municipio3 = m.Municipio3
                        ,Municipio3Nombre = CultureHelper.GetTraduction(m.Municipio3_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio3_Municipio.Nombre
                        ,Estado3 = m.Estado3
                        ,Estado3Nombre = CultureHelper.GetTraduction(m.Estado3_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado3_Estado.Nombre
			,Necropsia = m.Necropsia
			,Cronotanatodiagnostico = m.Cronotanatodiagnostico
			,Ruta = m.Ruta
			,Estado_Operador = m.Estado_Operador
			,Causa_de_Muerte = m.Causa_de_Muerte

                    
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
        public ActionResult Post_Imputado(Orientador_ImputadoModel varOrientador)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Orientador_ImputadoInfo = new Orientador_Imputado
                {
                    Clave = varOrientador.Clave
                                            ,Conocido = varOrientador.Conocido
                        ,Desconocido = varOrientador.Desconocido
                        ,Numero_de_Imputados = varOrientador.Numero_de_Imputados
                    
                };

                result = _IOrientadorApiConsumer.Update_Imputado(Orientador_ImputadoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Imputado(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrientadorApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IOrientadorApiConsumer.Get_Imputado(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Orientador_ImputadoModel
                {
                    Clave = m.Clave
			,Conocido = m.Conocido
			,Desconocido = m.Desconocido
			,Numero_de_Imputados = m.Numero_de_Imputados

                    
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

