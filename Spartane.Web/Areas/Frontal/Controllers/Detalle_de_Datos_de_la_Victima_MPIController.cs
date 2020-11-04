using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Datos_de_la_Victima_MPI;
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
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Detalle_del_Abogado_Victima_MPI;

using Spartane.Core.Domain.Abogado;





using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using Spartane.Core.Domain.Nacionalidad;

using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;









using Spartane.Core.Domain.Prioridad_del_Hecho;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Lugar_Tipo;
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

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Datos_de_la_Victima_MPI;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_de_la_Victima_MPI;
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
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Detalle_del_Abogado_Victima_MPI;

using Spartane.Web.Areas.WebApiConsumer.Abogado;

using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;


using Spartane.Web.Areas.WebApiConsumer.Prioridad_del_Hecho;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;
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

namespace Spartane.Web.Areas.Frontal.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class Detalle_de_Datos_de_la_Victima_MPIController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Datos_de_la_Victima_MPIService service = null;
        private IDetalle_de_Datos_de_la_Victima_MPIApiConsumer _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer;
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
        private ILocalidadApiConsumer _ILocalidadApiConsumer;
        private ITipo_de_ComparecienteApiConsumer _ITipo_de_ComparecienteApiConsumer;
        private IDetalle_del_Abogado_Victima_MPIApiConsumer _IDetalle_del_Abogado_Victima_MPIApiConsumer;

        private IAbogadoApiConsumer _IAbogadoApiConsumer;



        private IPrioridad_del_HechoApiConsumer _IPrioridad_del_HechoApiConsumer;
        private ILugar_TipoApiConsumer _ILugar_TipoApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_de_Datos_de_la_Victima_MPIController(IDetalle_de_Datos_de_la_Victima_MPIService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Datos_de_la_Victima_MPIApiConsumer Detalle_de_Datos_de_la_Victima_MPIApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IEscolaridadApiConsumer EscolaridadApiConsumer , IOcupacionApiConsumer OcupacionApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , ILocalidadApiConsumer LocalidadApiConsumer , ITipo_de_ComparecienteApiConsumer Tipo_de_ComparecienteApiConsumer , IDetalle_del_Abogado_Victima_MPIApiConsumer Detalle_del_Abogado_Victima_MPIApiConsumer , IAbogadoApiConsumer AbogadoApiConsumer  , IPrioridad_del_HechoApiConsumer Prioridad_del_HechoApiConsumer , ILugar_TipoApiConsumer Lugar_TipoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Datos_de_la_Victima_MPIApiConsumer = Detalle_de_Datos_de_la_Victima_MPIApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
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
            this._ITipo_de_ComparecienteApiConsumer = Tipo_de_ComparecienteApiConsumer;
            this._IDetalle_del_Abogado_Victima_MPIApiConsumer = Detalle_del_Abogado_Victima_MPIApiConsumer;

            this._IAbogadoApiConsumer = AbogadoApiConsumer;

            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;


            this._IPrioridad_del_HechoApiConsumer = Prioridad_del_HechoApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;
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

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Datos_de_la_Victima_MPI
        [ObjectAuth(ObjectId = (ModuleObjectId)45120, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45120);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_de_Datos_de_la_Victima_MPI/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45120, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45120);
            ViewBag.Permission = permission;
            var varDetalle_de_Datos_de_la_Victima_MPI = new Detalle_de_Datos_de_la_Victima_MPIModel();
			
            ViewBag.ObjectId = "45120";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_del_Abogado_Victima_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45153, ModuleId);
            ViewBag.PermissionDetalle_del_Abogado_Victima_MPI = permissionDetalle_del_Abogado_Victima_MPI;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Datos_de_la_Victima_MPIData = _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.GetByKeyComplete(Id).Resource.Detalle_de_Datos_de_la_Victima_MPIs[0];
                if (Detalle_de_Datos_de_la_Victima_MPIData == null)
                    return HttpNotFound();

                varDetalle_de_Datos_de_la_Victima_MPI = new Detalle_de_Datos_de_la_Victima_MPIModel
                {
                    Clave = (int)Detalle_de_Datos_de_la_Victima_MPIData.Clave
                    ,Nombre = Detalle_de_Datos_de_la_Victima_MPIData.Nombre
                    ,Apellido_Paterno = Detalle_de_Datos_de_la_Victima_MPIData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Datos_de_la_Victima_MPIData.Apellido_Materno
                    ,Nombre_Completo = Detalle_de_Datos_de_la_Victima_MPIData.Nombre_Completo
                    ,Fecha_de_Nacimiento = (Detalle_de_Datos_de_la_Victima_MPIData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_de_la_Victima_MPIData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Detalle_de_Datos_de_la_Victima_MPIData.Edad
                    ,Sexo = Detalle_de_Datos_de_la_Victima_MPIData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Sexo), "Genero") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil), "Estado_Civil") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Detalle_de_Datos_de_la_Victima_MPIData.Numero_de_Identificacion
                    ,Nacionalidad = Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad), "Escolaridad") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion), "Ocupacion") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion_Ocupacion.Descripcion
                    ,Pais = Detalle_de_Datos_de_la_Victima_MPIData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Pais), "Pais") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_Datos_de_la_Victima_MPIData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Estado), "Estado") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Datos_de_la_Victima_MPIData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Municipio), "Municipio") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Municipio_Municipio.Nombre
                    ,Colonia = Detalle_de_Datos_de_la_Victima_MPIData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Colonia), "Colonia") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Detalle_de_Datos_de_la_Victima_MPIData.Codigo_Postal
                    ,Calle = Detalle_de_Datos_de_la_Victima_MPIData.Calle
                    ,Numero_Exterior = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Interior
                    ,Telefono = Detalle_de_Datos_de_la_Victima_MPIData.Telefono
                    ,Extencion = Detalle_de_Datos_de_la_Victima_MPIData.Extencion
                    ,Celular = Detalle_de_Datos_de_la_Victima_MPIData.Celular
                    ,Correo_Electronico = Detalle_de_Datos_de_la_Victima_MPIData.Correo_Electronico
                    ,Incapaz = Detalle_de_Datos_de_la_Victima_MPIData.Incapaz.GetValueOrDefault()
                    ,Nombre_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Nombre_del_Tutor
                    ,Apellido_Paterno_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Apellido_Paterno_del_Tutor
                    ,Apellido_Materno_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Apellido_Materno_del_Tutor
                    ,Nombre_Completo_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Nombre_Completo_del_Tutor
                    ,Fecha_de_Nacimiento_del_Tutor = (Detalle_de_Datos_de_la_Victima_MPIData.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_de_la_Victima_MPIData.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Edad_del_Tutor
                    ,Sexo_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Sexo_del_Tutor
                    ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Sexo_del_Tutor), "Genero") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Sexo_del_Tutor_Genero.Descripcion
                    ,Estado_Civil_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil_del_Tutor
                    ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil_del_Tutor), "Estado_Civil") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion_del_Tutor
                    ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion_del_Tutor), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Numero_de_Identificacion_del_Tutor
                    ,Nacionalidad_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad_del_Tutor
                    ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad_del_Tutor), "Nacionalidad") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                    ,Escolaridad_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad_del_Tutor
                    ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad_del_Tutor), "Escolaridad") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad_del_Tutor_Escolaridad.Descripcion
                    ,Ocupacion_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion_del_Tutor
                    ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion_del_Tutor), "Ocupacion") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion_del_Tutor_Ocupacion.Descripcion
                    ,Pais_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Pais_del_Tutor
                    ,Pais_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Pais_del_Tutor), "Pais") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Pais_del_Tutor_Pais.Nombre
                    ,Estado_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Estado_del_Tutor
                    ,Estado_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Estado_del_Tutor), "Estado") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Estado_del_Tutor_Estado.Nombre
                    ,Municipio_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Municipio_del_Tutor
                    ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Municipio_del_Tutor), "Municipio") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Municipio_del_Tutor_Municipio.Nombre
                    ,Localidad_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Localidad_del_Tutor
                    ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Localidad_del_Tutor), "Localidad") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Localidad_del_Tutor_Localidad.Descripcion
                    ,Colonia_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Colonia_del_Tutor
                    ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Colonia_del_Tutor), "Colonia") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Colonia_del_Tutor_Colonia.Nombre
                    ,Codigo_Postal_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Codigo_Postal_del_Tutor
                    ,Calle_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Calle_del_Tutor
                    ,Numero_Exterior_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Exterior_del_Tutor
                    ,Numero_Interior_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Interior_del_Tutor
                    ,Telefono_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Telefono_del_Tutor
                    ,Extencion_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Extencion_del_Tutor
                    ,Celular_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Celular_del_Tutor
                    ,Correo_Electronico_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Correo_Electronico_del_Tutor
                    ,Tipo_de_Compareciente = Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Compareciente
                    ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Compareciente), "Tipo_de_Compareciente") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                    ,Narrativa_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Narrativa_de_los_Hechos
                    ,Titulo_del_Hecho = Detalle_de_Datos_de_la_Victima_MPIData.Titulo_del_Hecho
                    ,Prioridad_del_Hecho = Detalle_de_Datos_de_la_Victima_MPIData.Prioridad_del_Hecho
                    ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Prioridad_del_Hecho), "Prioridad_del_Hecho") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                    ,Fecha_del_Hecho = (Detalle_de_Datos_de_la_Victima_MPIData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_de_la_Victima_MPIData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Aproximada_del_Hecho = Detalle_de_Datos_de_la_Victima_MPIData.Hora_Aproximada_del_Hecho
                    ,Pais_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Pais_de_los_Hechos
                    ,Pais_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Pais_de_los_Hechos), "Pais") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Pais_de_los_Hechos_Pais.Nombre
                    ,Estado_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Estado_de_los_Hechos
                    ,Estado_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Estado_de_los_Hechos), "Estado") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Estado_de_los_Hechos_Estado.Nombre
                    ,Municipio_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Municipio_de_los_Hechos
                    ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Municipio_de_los_Hechos), "Municipio") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Municipio_de_los_Hechos_Municipio.Nombre
                    ,Colonia_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Colonia_de_los_Hechos
                    ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Colonia_de_los_Hechos), "Colonia") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Colonia_de_los_Hechos_Colonia.Nombre
                    ,Codigo_Postal_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Codigo_Postal_de_los_Hechos
                    ,Calle_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Calle_de_los_Hechos
                    ,Entre_Calle_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Entre_Calle_de_los_Hechos
                    ,Y_Calle_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Y_Calle_de_los_Hechos
                    ,Numero_Exterior_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Exterior_de_los_Hechos
                    ,Numero_Interior_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Interior_de_los_Hechos
                    ,Latitud_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Latitud_de_los_Hechos
                    ,Longitud_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Longitud_de_los_Hechos
                    ,Tipo_de_Lugar_del_Hecho = Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Lugar_del_Hecho
                    ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,Proteccion_de_Datos = Detalle_de_Datos_de_la_Victima_MPIData.Proteccion_de_Datos.GetValueOrDefault()
                    ,Nombre_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Nombre_de_Persona_Moral
                    ,Apellido_Paterno_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Apellido_Paterno_de_Persona_Moral
                    ,Apellido_Materno_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Apellido_Materno_de_Persona_Moral
                    ,Fecha_de_Nacimiento_de_Persona_Moral = (Detalle_de_Datos_de_la_Victima_MPIData.Fecha_de_Nacimiento_de_Persona_Moral == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_de_la_Victima_MPIData.Fecha_de_Nacimiento_de_Persona_Moral).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Edad_de_Persona_Moral
                    ,Sexo_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Sexo_de_Persona_Moral
                    ,Sexo_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Sexo_de_Persona_Moral), "Genero") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Sexo_de_Persona_Moral_Genero.Descripcion
                    ,Estado_Civil_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil_de_Persona_Moral
                    ,Estado_Civil_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil_de_Persona_Moral), "Estado_Civil") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil_de_Persona_Moral_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion_de_Persona_Moral
                    ,Tipo_de_Identificacion_de_Persona_MoralNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion_de_Persona_Moral), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion_de_Persona_Moral_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_de_Persona_Mora = Detalle_de_Datos_de_la_Victima_MPIData.Numero_de_Identificacion_de_Persona_Mora
                    ,Nacionalidad_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad_de_Persona_Moral
                    ,Nacionalidad_de_Persona_MoralNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad_de_Persona_Moral), "Nacionalidad") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad_de_Persona_Moral_Nacionalidad.NacionalidadC
                    ,Escolaridad_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad_de_Persona_Moral
                    ,Escolaridad_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad_de_Persona_Moral), "Escolaridad") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad_de_Persona_Moral_Escolaridad.Descripcion
                    ,Ocupacion_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion_de_Persona_Moral
                    ,Ocupacion_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion_de_Persona_Moral), "Ocupacion") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion_de_Persona_Moral_Ocupacion.Descripcion
                    ,Pais_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Pais_de_Persona_Moral
                    ,Pais_de_Persona_MoralNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Pais_de_Persona_Moral), "Pais") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Pais_de_Persona_Moral_Pais.Nombre
                    ,Estado_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Estado_de_Persona_Moral
                    ,Estado_de_Persona_MoralNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Estado_de_Persona_Moral), "Estado") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Estado_de_Persona_Moral_Estado.Nombre
                    ,Municipio_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Municipio_de_Persona_Moral
                    ,Municipio_de_Persona_MoralNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Municipio_de_Persona_Moral), "Municipio") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Municipio_de_Persona_Moral_Municipio.Nombre
                    ,Colonia_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Colonia_de_Persona_Moral
                    ,Colonia_de_Persona_MoralNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Colonia_de_Persona_Moral), "Colonia") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Colonia_de_Persona_Moral_Colonia.Nombre
                    ,Codigo_Postal_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Codigo_Postal_de_Persona_Moral
                    ,Calle_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Calle_de_Persona_Moral
                    ,Numero_Exterior_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Exterior_de_Persona_Moral
                    ,Numero_Interior_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Interior_de_Persona_Moral
                    ,Entre_Calle_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Entre_Calle_de_Persona_Moral
                    ,Y_Calle_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Y_Calle_de_Persona_Moral
                    ,Longitud_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Longitud_de_Persona_Moral
                    ,Latitud_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Latitud_de_Persona_Moral
                    ,Telefono_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Telefono_de_Persona_Moral
                    ,Extension_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Extension_de_Persona_Moral
                    ,Celular_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Celular_de_Persona_Moral
                    ,Correo_Electronico_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Correo_Electronico_de_Persona_Moral
                    ,Persona_Moral_Victima = Detalle_de_Datos_de_la_Victima_MPIData.Persona_Moral_Victima.GetValueOrDefault()

                };

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
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais != null && Paiss_Pais.Resource != null)
                ViewBag.Paiss_Pais = Paiss_Pais.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado != null && Estados_Estado.Resource != null)
                ViewBag.Estados_Estado = Estados_Estado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia != null && Colonias_Colonia.Resource != null)
                ViewBag.Colonias_Colonia = Colonias_Colonia.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
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
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_del_Tutor = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_del_Tutor != null && Paiss_Pais_del_Tutor.Resource != null)
                ViewBag.Paiss_Pais_del_Tutor = Paiss_Pais_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Tutor = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Tutor != null && Estados_Estado_del_Tutor.Resource != null)
                ViewBag.Estados_Estado_del_Tutor = Estados_Estado_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Tutor = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Tutor != null && Municipios_Municipio_del_Tutor.Resource != null)
                ViewBag.Municipios_Municipio_del_Tutor = Municipios_Municipio_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_del_Tutor = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_del_Tutor != null && Localidads_Localidad_del_Tutor.Resource != null)
                ViewBag.Localidads_Localidad_del_Tutor = Localidads_Localidad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Tutor = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Tutor != null && Colonias_Colonia_del_Tutor.Resource != null)
                ViewBag.Colonias_Colonia_del_Tutor = Colonias_Colonia_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Prioridad_del_Hechos_Prioridad_del_Hecho = _IPrioridad_del_HechoApiConsumer.SelAll(true);
            if (Prioridad_del_Hechos_Prioridad_del_Hecho != null && Prioridad_del_Hechos_Prioridad_del_Hecho.Resource != null)
                ViewBag.Prioridad_del_Hechos_Prioridad_del_Hecho = Prioridad_del_Hechos_Prioridad_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_de_los_Hechos = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_de_los_Hechos != null && Paiss_Pais_de_los_Hechos.Resource != null)
                ViewBag.Paiss_Pais_de_los_Hechos = Paiss_Pais_de_los_Hechos.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_de_los_Hechos = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_de_los_Hechos != null && Estados_Estado_de_los_Hechos.Resource != null)
                ViewBag.Estados_Estado_de_los_Hechos = Estados_Estado_de_los_Hechos.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_de_los_Hechos = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_de_los_Hechos != null && Municipios_Municipio_de_los_Hechos.Resource != null)
                ViewBag.Municipios_Municipio_de_los_Hechos = Municipios_Municipio_de_los_Hechos.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_de_los_Hechos = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_de_los_Hechos != null && Colonias_Colonia_de_los_Hechos.Resource != null)
                ViewBag.Colonias_Colonia_de_los_Hechos = Colonias_Colonia_de_los_Hechos.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_de_Persona_Moral = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_de_Persona_Moral != null && Generos_Sexo_de_Persona_Moral.Resource != null)
                ViewBag.Generos_Sexo_de_Persona_Moral = Generos_Sexo_de_Persona_Moral.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_de_Persona_Moral = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_de_Persona_Moral != null && Estado_Civils_Estado_Civil_de_Persona_Moral.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_de_Persona_Moral = Estado_Civils_Estado_Civil_de_Persona_Moral.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_de_Persona_Moral = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_de_Persona_Moral != null && Tipo_de_Identificacions_Tipo_de_Identificacion_de_Persona_Moral.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_de_Persona_Moral = Tipo_de_Identificacions_Tipo_de_Identificacion_de_Persona_Moral.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_de_Persona_Moral = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_de_Persona_Moral != null && Nacionalidads_Nacionalidad_de_Persona_Moral.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_de_Persona_Moral = Nacionalidads_Nacionalidad_de_Persona_Moral.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_de_Persona_Moral = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_de_Persona_Moral != null && Escolaridads_Escolaridad_de_Persona_Moral.Resource != null)
                ViewBag.Escolaridads_Escolaridad_de_Persona_Moral = Escolaridads_Escolaridad_de_Persona_Moral.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_de_Persona_Moral = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_de_Persona_Moral != null && Ocupacions_Ocupacion_de_Persona_Moral.Resource != null)
                ViewBag.Ocupacions_Ocupacion_de_Persona_Moral = Ocupacions_Ocupacion_de_Persona_Moral.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_de_Persona_Moral = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_de_Persona_Moral != null && Paiss_Pais_de_Persona_Moral.Resource != null)
                ViewBag.Paiss_Pais_de_Persona_Moral = Paiss_Pais_de_Persona_Moral.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_de_Persona_Moral = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_de_Persona_Moral != null && Estados_Estado_de_Persona_Moral.Resource != null)
                ViewBag.Estados_Estado_de_Persona_Moral = Estados_Estado_de_Persona_Moral.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_de_Persona_Moral = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_de_Persona_Moral != null && Municipios_Municipio_de_Persona_Moral.Resource != null)
                ViewBag.Municipios_Municipio_de_Persona_Moral = Municipios_Municipio_de_Persona_Moral.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_de_Persona_Moral = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_de_Persona_Moral != null && Colonias_Colonia_de_Persona_Moral.Resource != null)
                ViewBag.Colonias_Colonia_de_Persona_Moral = Colonias_Colonia_de_Persona_Moral.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_de_Datos_de_la_Victima_MPI);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Datos_de_la_Victima_MPI(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45120);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Datos_de_la_Victima_MPIModel varDetalle_de_Datos_de_la_Victima_MPI= new Detalle_de_Datos_de_la_Victima_MPIModel();
            var permissionDetalle_del_Abogado_Victima_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45153, ModuleId);
            ViewBag.PermissionDetalle_del_Abogado_Victima_MPI = permissionDetalle_del_Abogado_Victima_MPI;


            if (id.ToString() != "0")
            {
                var Detalle_de_Datos_de_la_Victima_MPIsData = _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Datos_de_la_Victima_MPI.Clave=" + id, "").Resource.Detalle_de_Datos_de_la_Victima_MPIs;
				
				if (Detalle_de_Datos_de_la_Victima_MPIsData != null && Detalle_de_Datos_de_la_Victima_MPIsData.Count > 0)
                {
					var Detalle_de_Datos_de_la_Victima_MPIData = Detalle_de_Datos_de_la_Victima_MPIsData.First();
					varDetalle_de_Datos_de_la_Victima_MPI= new Detalle_de_Datos_de_la_Victima_MPIModel
					{
						Clave  = Detalle_de_Datos_de_la_Victima_MPIData.Clave 
	                    ,Nombre = Detalle_de_Datos_de_la_Victima_MPIData.Nombre
                    ,Apellido_Paterno = Detalle_de_Datos_de_la_Victima_MPIData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Datos_de_la_Victima_MPIData.Apellido_Materno
                    ,Nombre_Completo = Detalle_de_Datos_de_la_Victima_MPIData.Nombre_Completo
                    ,Fecha_de_Nacimiento = (Detalle_de_Datos_de_la_Victima_MPIData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_de_la_Victima_MPIData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Detalle_de_Datos_de_la_Victima_MPIData.Edad
                    ,Sexo = Detalle_de_Datos_de_la_Victima_MPIData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Sexo), "Genero") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil), "Estado_Civil") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Detalle_de_Datos_de_la_Victima_MPIData.Numero_de_Identificacion
                    ,Nacionalidad = Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad), "Escolaridad") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion), "Ocupacion") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion_Ocupacion.Descripcion
                    ,Pais = Detalle_de_Datos_de_la_Victima_MPIData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Pais), "Pais") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_Datos_de_la_Victima_MPIData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Estado), "Estado") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Datos_de_la_Victima_MPIData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Municipio), "Municipio") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Municipio_Municipio.Nombre
                    ,Colonia = Detalle_de_Datos_de_la_Victima_MPIData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Colonia), "Colonia") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Detalle_de_Datos_de_la_Victima_MPIData.Codigo_Postal
                    ,Calle = Detalle_de_Datos_de_la_Victima_MPIData.Calle
                    ,Numero_Exterior = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Interior
                    ,Telefono = Detalle_de_Datos_de_la_Victima_MPIData.Telefono
                    ,Extencion = Detalle_de_Datos_de_la_Victima_MPIData.Extencion
                    ,Celular = Detalle_de_Datos_de_la_Victima_MPIData.Celular
                    ,Correo_Electronico = Detalle_de_Datos_de_la_Victima_MPIData.Correo_Electronico
                    ,Incapaz = Detalle_de_Datos_de_la_Victima_MPIData.Incapaz.GetValueOrDefault()
                    ,Nombre_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Nombre_del_Tutor
                    ,Apellido_Paterno_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Apellido_Paterno_del_Tutor
                    ,Apellido_Materno_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Apellido_Materno_del_Tutor
                    ,Nombre_Completo_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Nombre_Completo_del_Tutor
                    ,Fecha_de_Nacimiento_del_Tutor = (Detalle_de_Datos_de_la_Victima_MPIData.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_de_la_Victima_MPIData.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Edad_del_Tutor
                    ,Sexo_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Sexo_del_Tutor
                    ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Sexo_del_Tutor), "Genero") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Sexo_del_Tutor_Genero.Descripcion
                    ,Estado_Civil_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil_del_Tutor
                    ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil_del_Tutor), "Estado_Civil") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion_del_Tutor
                    ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion_del_Tutor), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Numero_de_Identificacion_del_Tutor
                    ,Nacionalidad_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad_del_Tutor
                    ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad_del_Tutor), "Nacionalidad") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                    ,Escolaridad_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad_del_Tutor
                    ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad_del_Tutor), "Escolaridad") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad_del_Tutor_Escolaridad.Descripcion
                    ,Ocupacion_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion_del_Tutor
                    ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion_del_Tutor), "Ocupacion") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion_del_Tutor_Ocupacion.Descripcion
                    ,Pais_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Pais_del_Tutor
                    ,Pais_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Pais_del_Tutor), "Pais") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Pais_del_Tutor_Pais.Nombre
                    ,Estado_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Estado_del_Tutor
                    ,Estado_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Estado_del_Tutor), "Estado") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Estado_del_Tutor_Estado.Nombre
                    ,Municipio_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Municipio_del_Tutor
                    ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Municipio_del_Tutor), "Municipio") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Municipio_del_Tutor_Municipio.Nombre
                    ,Localidad_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Localidad_del_Tutor
                    ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Localidad_del_Tutor), "Localidad") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Localidad_del_Tutor_Localidad.Descripcion
                    ,Colonia_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Colonia_del_Tutor
                    ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Colonia_del_Tutor), "Colonia") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Colonia_del_Tutor_Colonia.Nombre
                    ,Codigo_Postal_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Codigo_Postal_del_Tutor
                    ,Calle_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Calle_del_Tutor
                    ,Numero_Exterior_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Exterior_del_Tutor
                    ,Numero_Interior_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Interior_del_Tutor
                    ,Telefono_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Telefono_del_Tutor
                    ,Extencion_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Extencion_del_Tutor
                    ,Celular_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Celular_del_Tutor
                    ,Correo_Electronico_del_Tutor = Detalle_de_Datos_de_la_Victima_MPIData.Correo_Electronico_del_Tutor
                    ,Tipo_de_Compareciente = Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Compareciente
                    ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Compareciente), "Tipo_de_Compareciente") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                    ,Narrativa_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Narrativa_de_los_Hechos
                    ,Titulo_del_Hecho = Detalle_de_Datos_de_la_Victima_MPIData.Titulo_del_Hecho
                    ,Prioridad_del_Hecho = Detalle_de_Datos_de_la_Victima_MPIData.Prioridad_del_Hecho
                    ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Prioridad_del_Hecho), "Prioridad_del_Hecho") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                    ,Fecha_del_Hecho = (Detalle_de_Datos_de_la_Victima_MPIData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_de_la_Victima_MPIData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Aproximada_del_Hecho = Detalle_de_Datos_de_la_Victima_MPIData.Hora_Aproximada_del_Hecho
                    ,Pais_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Pais_de_los_Hechos
                    ,Pais_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Pais_de_los_Hechos), "Pais") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Pais_de_los_Hechos_Pais.Nombre
                    ,Estado_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Estado_de_los_Hechos
                    ,Estado_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Estado_de_los_Hechos), "Estado") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Estado_de_los_Hechos_Estado.Nombre
                    ,Municipio_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Municipio_de_los_Hechos
                    ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Municipio_de_los_Hechos), "Municipio") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Municipio_de_los_Hechos_Municipio.Nombre
                    ,Colonia_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Colonia_de_los_Hechos
                    ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Colonia_de_los_Hechos), "Colonia") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Colonia_de_los_Hechos_Colonia.Nombre
                    ,Codigo_Postal_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Codigo_Postal_de_los_Hechos
                    ,Calle_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Calle_de_los_Hechos
                    ,Entre_Calle_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Entre_Calle_de_los_Hechos
                    ,Y_Calle_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Y_Calle_de_los_Hechos
                    ,Numero_Exterior_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Exterior_de_los_Hechos
                    ,Numero_Interior_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Interior_de_los_Hechos
                    ,Latitud_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Latitud_de_los_Hechos
                    ,Longitud_de_los_Hechos = Detalle_de_Datos_de_la_Victima_MPIData.Longitud_de_los_Hechos
                    ,Tipo_de_Lugar_del_Hecho = Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Lugar_del_Hecho
                    ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,Proteccion_de_Datos = Detalle_de_Datos_de_la_Victima_MPIData.Proteccion_de_Datos.GetValueOrDefault()
                    ,Nombre_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Nombre_de_Persona_Moral
                    ,Apellido_Paterno_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Apellido_Paterno_de_Persona_Moral
                    ,Apellido_Materno_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Apellido_Materno_de_Persona_Moral
                    ,Fecha_de_Nacimiento_de_Persona_Moral = (Detalle_de_Datos_de_la_Victima_MPIData.Fecha_de_Nacimiento_de_Persona_Moral == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_de_la_Victima_MPIData.Fecha_de_Nacimiento_de_Persona_Moral).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Edad_de_Persona_Moral
                    ,Sexo_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Sexo_de_Persona_Moral
                    ,Sexo_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Sexo_de_Persona_Moral), "Genero") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Sexo_de_Persona_Moral_Genero.Descripcion
                    ,Estado_Civil_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil_de_Persona_Moral
                    ,Estado_Civil_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil_de_Persona_Moral), "Estado_Civil") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Estado_Civil_de_Persona_Moral_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion_de_Persona_Moral
                    ,Tipo_de_Identificacion_de_Persona_MoralNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion_de_Persona_Moral), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Tipo_de_Identificacion_de_Persona_Moral_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_de_Persona_Mora = Detalle_de_Datos_de_la_Victima_MPIData.Numero_de_Identificacion_de_Persona_Mora
                    ,Nacionalidad_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad_de_Persona_Moral
                    ,Nacionalidad_de_Persona_MoralNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad_de_Persona_Moral), "Nacionalidad") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Nacionalidad_de_Persona_Moral_Nacionalidad.NacionalidadC
                    ,Escolaridad_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad_de_Persona_Moral
                    ,Escolaridad_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad_de_Persona_Moral), "Escolaridad") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Escolaridad_de_Persona_Moral_Escolaridad.Descripcion
                    ,Ocupacion_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion_de_Persona_Moral
                    ,Ocupacion_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion_de_Persona_Moral), "Ocupacion") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Ocupacion_de_Persona_Moral_Ocupacion.Descripcion
                    ,Pais_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Pais_de_Persona_Moral
                    ,Pais_de_Persona_MoralNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Pais_de_Persona_Moral), "Pais") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Pais_de_Persona_Moral_Pais.Nombre
                    ,Estado_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Estado_de_Persona_Moral
                    ,Estado_de_Persona_MoralNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Estado_de_Persona_Moral), "Estado") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Estado_de_Persona_Moral_Estado.Nombre
                    ,Municipio_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Municipio_de_Persona_Moral
                    ,Municipio_de_Persona_MoralNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Municipio_de_Persona_Moral), "Municipio") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Municipio_de_Persona_Moral_Municipio.Nombre
                    ,Colonia_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Colonia_de_Persona_Moral
                    ,Colonia_de_Persona_MoralNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_de_la_Victima_MPIData.Colonia_de_Persona_Moral), "Colonia") ??  (string)Detalle_de_Datos_de_la_Victima_MPIData.Colonia_de_Persona_Moral_Colonia.Nombre
                    ,Codigo_Postal_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Codigo_Postal_de_Persona_Moral
                    ,Calle_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Calle_de_Persona_Moral
                    ,Numero_Exterior_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Exterior_de_Persona_Moral
                    ,Numero_Interior_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Numero_Interior_de_Persona_Moral
                    ,Entre_Calle_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Entre_Calle_de_Persona_Moral
                    ,Y_Calle_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Y_Calle_de_Persona_Moral
                    ,Longitud_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Longitud_de_Persona_Moral
                    ,Latitud_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Latitud_de_Persona_Moral
                    ,Telefono_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Telefono_de_Persona_Moral
                    ,Extension_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Extension_de_Persona_Moral
                    ,Celular_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Celular_de_Persona_Moral
                    ,Correo_Electronico_de_Persona_Moral = Detalle_de_Datos_de_la_Victima_MPIData.Correo_Electronico_de_Persona_Moral
                    ,Persona_Moral_Victima = Detalle_de_Datos_de_la_Victima_MPIData.Persona_Moral_Victima.GetValueOrDefault()

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
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais != null && Paiss_Pais.Resource != null)
                ViewBag.Paiss_Pais = Paiss_Pais.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado != null && Estados_Estado.Resource != null)
                ViewBag.Estados_Estado = Estados_Estado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio != null && Municipios_Municipio.Resource != null)
                ViewBag.Municipios_Municipio = Municipios_Municipio.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia != null && Colonias_Colonia.Resource != null)
                ViewBag.Colonias_Colonia = Colonias_Colonia.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
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
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_del_Tutor = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_del_Tutor != null && Paiss_Pais_del_Tutor.Resource != null)
                ViewBag.Paiss_Pais_del_Tutor = Paiss_Pais_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Tutor = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Tutor != null && Estados_Estado_del_Tutor.Resource != null)
                ViewBag.Estados_Estado_del_Tutor = Estados_Estado_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Tutor = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Tutor != null && Municipios_Municipio_del_Tutor.Resource != null)
                ViewBag.Municipios_Municipio_del_Tutor = Municipios_Municipio_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad_del_Tutor = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad_del_Tutor != null && Localidads_Localidad_del_Tutor.Resource != null)
                ViewBag.Localidads_Localidad_del_Tutor = Localidads_Localidad_del_Tutor.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Tutor = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Tutor != null && Colonias_Colonia_del_Tutor.Resource != null)
                ViewBag.Colonias_Colonia_del_Tutor = Colonias_Colonia_del_Tutor.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Prioridad_del_Hechos_Prioridad_del_Hecho = _IPrioridad_del_HechoApiConsumer.SelAll(true);
            if (Prioridad_del_Hechos_Prioridad_del_Hecho != null && Prioridad_del_Hechos_Prioridad_del_Hecho.Resource != null)
                ViewBag.Prioridad_del_Hechos_Prioridad_del_Hecho = Prioridad_del_Hechos_Prioridad_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_de_los_Hechos = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_de_los_Hechos != null && Paiss_Pais_de_los_Hechos.Resource != null)
                ViewBag.Paiss_Pais_de_los_Hechos = Paiss_Pais_de_los_Hechos.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_de_los_Hechos = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_de_los_Hechos != null && Estados_Estado_de_los_Hechos.Resource != null)
                ViewBag.Estados_Estado_de_los_Hechos = Estados_Estado_de_los_Hechos.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_de_los_Hechos = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_de_los_Hechos != null && Municipios_Municipio_de_los_Hechos.Resource != null)
                ViewBag.Municipios_Municipio_de_los_Hechos = Municipios_Municipio_de_los_Hechos.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_de_los_Hechos = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_de_los_Hechos != null && Colonias_Colonia_de_los_Hechos.Resource != null)
                ViewBag.Colonias_Colonia_de_los_Hechos = Colonias_Colonia_de_los_Hechos.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_de_Persona_Moral = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_de_Persona_Moral != null && Generos_Sexo_de_Persona_Moral.Resource != null)
                ViewBag.Generos_Sexo_de_Persona_Moral = Generos_Sexo_de_Persona_Moral.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_de_Persona_Moral = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_de_Persona_Moral != null && Estado_Civils_Estado_Civil_de_Persona_Moral.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_de_Persona_Moral = Estado_Civils_Estado_Civil_de_Persona_Moral.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_de_Persona_Moral = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_de_Persona_Moral != null && Tipo_de_Identificacions_Tipo_de_Identificacion_de_Persona_Moral.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_de_Persona_Moral = Tipo_de_Identificacions_Tipo_de_Identificacion_de_Persona_Moral.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_de_Persona_Moral = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_de_Persona_Moral != null && Nacionalidads_Nacionalidad_de_Persona_Moral.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_de_Persona_Moral = Nacionalidads_Nacionalidad_de_Persona_Moral.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEscolaridadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Escolaridads_Escolaridad_de_Persona_Moral = _IEscolaridadApiConsumer.SelAll(true);
            if (Escolaridads_Escolaridad_de_Persona_Moral != null && Escolaridads_Escolaridad_de_Persona_Moral.Resource != null)
                ViewBag.Escolaridads_Escolaridad_de_Persona_Moral = Escolaridads_Escolaridad_de_Persona_Moral.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Escolaridad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOcupacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ocupacions_Ocupacion_de_Persona_Moral = _IOcupacionApiConsumer.SelAll(true);
            if (Ocupacions_Ocupacion_de_Persona_Moral != null && Ocupacions_Ocupacion_de_Persona_Moral.Resource != null)
                ViewBag.Ocupacions_Ocupacion_de_Persona_Moral = Ocupacions_Ocupacion_de_Persona_Moral.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ocupacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_de_Persona_Moral = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_de_Persona_Moral != null && Paiss_Pais_de_Persona_Moral.Resource != null)
                ViewBag.Paiss_Pais_de_Persona_Moral = Paiss_Pais_de_Persona_Moral.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_de_Persona_Moral = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_de_Persona_Moral != null && Estados_Estado_de_Persona_Moral.Resource != null)
                ViewBag.Estados_Estado_de_Persona_Moral = Estados_Estado_de_Persona_Moral.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_de_Persona_Moral = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_de_Persona_Moral != null && Municipios_Municipio_de_Persona_Moral.Resource != null)
                ViewBag.Municipios_Municipio_de_Persona_Moral = Municipios_Municipio_de_Persona_Moral.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_de_Persona_Moral = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_de_Persona_Moral != null && Colonias_Colonia_de_Persona_Moral.Resource != null)
                ViewBag.Colonias_Colonia_de_Persona_Moral = Colonias_Colonia_de_Persona_Moral.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Datos_de_la_Victima_MPI", varDetalle_de_Datos_de_la_Victima_MPI);
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
        public ActionResult GetPrioridad_del_HechoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPrioridad_del_HechoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPrioridad_del_HechoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Prioridad_del_Hecho", "Descripcion")?? m.Descripcion,
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



        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Datos_de_la_Victima_MPIPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Datos_de_la_Victima_MPIs == null)
                result.Detalle_de_Datos_de_la_Victima_MPIs = new List<Detalle_de_Datos_de_la_Victima_MPI>();

            return Json(new
            {
                data = result.Detalle_de_Datos_de_la_Victima_MPIs.Select(m => new Detalle_de_Datos_de_la_Victima_MPIGridModel
                    {
                    Clave = m.Clave
			,Nombre = m.Nombre
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_Pais.Nombre
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Telefono = m.Telefono
			,Extencion = m.Extencion
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
			,Incapaz = m.Incapaz
			,Nombre_del_Tutor = m.Nombre_del_Tutor
			,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
			,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
			,Nombre_Completo_del_Tutor = m.Nombre_Completo_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Tutor = m.Edad_del_Tutor
                        ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Tutor_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_del_Tutor_Genero.Descripcion
                        ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Tutor_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Tutor_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                        ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Escolaridad_del_Tutor_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                        ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(m.Ocupacion_del_Tutor_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
                        ,Pais_del_TutorNombre = CultureHelper.GetTraduction(m.Pais_del_Tutor_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_del_Tutor_Pais.Nombre
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Tutor_Estado.Nombre
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Localidad_del_TutorDescripcion = CultureHelper.GetTraduction(m.Localidad_del_Tutor_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_del_Tutor_Localidad.Descripcion
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Extencion_del_Tutor = m.Extencion_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
			,Narrativa_de_los_Hechos = m.Narrativa_de_los_Hechos
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Pais_de_los_HechosNombre = CultureHelper.GetTraduction(m.Pais_de_los_Hechos_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_de_los_Hechos_Pais.Nombre
                        ,Estado_de_los_HechosNombre = CultureHelper.GetTraduction(m.Estado_de_los_Hechos_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_de_los_Hechos_Estado.Nombre
                        ,Municipio_de_los_HechosNombre = CultureHelper.GetTraduction(m.Municipio_de_los_Hechos_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_de_los_Hechos_Municipio.Nombre
                        ,Colonia_de_los_HechosNombre = CultureHelper.GetTraduction(m.Colonia_de_los_Hechos_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_de_los_Hechos_Colonia.Nombre
			,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
			,Calle_de_los_Hechos = m.Calle_de_los_Hechos
			,Entre_Calle_de_los_Hechos = m.Entre_Calle_de_los_Hechos
			,Y_Calle_de_los_Hechos = m.Y_Calle_de_los_Hechos
			,Numero_Exterior_de_los_Hechos = m.Numero_Exterior_de_los_Hechos
			,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
			,Latitud_de_los_Hechos = m.Latitud_de_los_Hechos
			,Longitud_de_los_Hechos = m.Longitud_de_los_Hechos
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
			,Proteccion_de_Datos = m.Proteccion_de_Datos
			,Nombre_de_Persona_Moral = m.Nombre_de_Persona_Moral
			,Apellido_Paterno_de_Persona_Moral = m.Apellido_Paterno_de_Persona_Moral
			,Apellido_Materno_de_Persona_Moral = m.Apellido_Materno_de_Persona_Moral
                        ,Fecha_de_Nacimiento_de_Persona_Moral = (m.Fecha_de_Nacimiento_de_Persona_Moral == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_de_Persona_Moral).ToString(ConfigurationProperty.DateFormat))
			,Edad_de_Persona_Moral = m.Edad_de_Persona_Moral
                        ,Sexo_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(m.Sexo_de_Persona_Moral_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_de_Persona_Moral_Genero.Descripcion
                        ,Estado_Civil_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_de_Persona_Moral_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_de_Persona_Moral_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_de_Persona_Moral_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_de_Persona_Moral_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_de_Persona_Mora = m.Numero_de_Identificacion_de_Persona_Mora
                        ,Nacionalidad_de_Persona_MoralNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_de_Persona_Moral_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_de_Persona_Moral_Nacionalidad.NacionalidadC
                        ,Escolaridad_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(m.Escolaridad_de_Persona_Moral_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_de_Persona_Moral_Escolaridad.Descripcion
                        ,Ocupacion_de_Persona_MoralDescripcion = CultureHelper.GetTraduction(m.Ocupacion_de_Persona_Moral_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_de_Persona_Moral_Ocupacion.Descripcion
                        ,Pais_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Pais_de_Persona_Moral_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_de_Persona_Moral_Pais.Nombre
                        ,Estado_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Estado_de_Persona_Moral_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_de_Persona_Moral_Estado.Nombre
                        ,Municipio_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Municipio_de_Persona_Moral_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_de_Persona_Moral_Municipio.Nombre
                        ,Colonia_de_Persona_MoralNombre = CultureHelper.GetTraduction(m.Colonia_de_Persona_Moral_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_de_Persona_Moral_Colonia.Nombre
			,Codigo_Postal_de_Persona_Moral = m.Codigo_Postal_de_Persona_Moral
			,Calle_de_Persona_Moral = m.Calle_de_Persona_Moral
			,Numero_Exterior_de_Persona_Moral = m.Numero_Exterior_de_Persona_Moral
			,Numero_Interior_de_Persona_Moral = m.Numero_Interior_de_Persona_Moral
			,Entre_Calle_de_Persona_Moral = m.Entre_Calle_de_Persona_Moral
			,Y_Calle_de_Persona_Moral = m.Y_Calle_de_Persona_Moral
			,Longitud_de_Persona_Moral = m.Longitud_de_Persona_Moral
			,Latitud_de_Persona_Moral = m.Latitud_de_Persona_Moral
			,Telefono_de_Persona_Moral = m.Telefono_de_Persona_Moral
			,Extension_de_Persona_Moral = m.Extension_de_Persona_Moral
			,Celular_de_Persona_Moral = m.Celular_de_Persona_Moral
			,Correo_Electronico_de_Persona_Moral = m.Correo_Electronico_de_Persona_Moral
			,Persona_Moral_Victima = m.Persona_Moral_Victima

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


//Grid GetAutoComplete






       

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_del_Abogado_Victima_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_del_Abogado_Victima_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_del_Abogado_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_del_Abogado_Victima_MPI.Compareciente=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_del_Abogado_Victima_MPI.Compareciente='" + RelationId + "'";
            }
            var result = _IDetalle_del_Abogado_Victima_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_del_Abogado_Victima_MPIs == null)
                result.Detalle_del_Abogado_Victima_MPIs = new List<Detalle_del_Abogado_Victima_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_del_Abogado_Victima_MPIs.Select(m => new Detalle_del_Abogado_Victima_MPIGridModel
                {
                    Consecutivo_Victima = m.Consecutivo_Victima

                        ,Nombre_Completo_del_Abogado_Victima = m.Nombre_Completo_del_Abogado_Victima
                        ,Nombre_Completo_del_Abogado_VictimaNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Completo_del_Abogado_Victima_Abogado.Clave.ToString(), "Nombre_Completo") ??(string)m.Nombre_Completo_del_Abogado_Victima_Abogado.Nombre_Completo
			,Nombre_del_Abogado_Victima = m.Nombre_del_Abogado_Victima
			,Apellido_Paterno_del_Abogado_Victima = m.Apellido_Paterno_del_Abogado_Victima
			,Apellido_Materno_del_Abogado_Victima = m.Apellido_Materno_del_Abogado_Victima
			,Fecha_de_Nacimiento_del_Abogado_Victima = (m.Fecha_de_Nacimiento_del_Abogado_Victima == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Abogado_Victima).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Abogado_Victima = m.Edad_del_Abogado_Victima
                        ,Sexo_del_Abogado_Victima = m.Sexo_del_Abogado_Victima
                        ,Sexo_del_Abogado_VictimaDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Abogado_Victima_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_del_Abogado_Victima_Genero.Descripcion
                        ,Estado_Civil_del_Abogado_Victima = m.Estado_Civil_del_Abogado_Victima
                        ,Estado_Civil_del_Abogado_VictimaDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Abogado_Victima_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_del_Abogado_Victima_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_Abogado_Victima = m.Tipo_de_Identificacion_Abogado_Victima
                        ,Tipo_de_Identificacion_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Abogado_Victima_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_Abogado_Victima_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_Abogado_Victima = m.Numero_de_Identificacion_Abogado_Victima
                        ,Nacionalidad_del_Abogado_Victima = m.Nacionalidad_del_Abogado_Victima
                        ,Nacionalidad_del_Abogado_VictimaNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Abogado_Victima_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_del_Abogado_Victima_Nacionalidad.NacionalidadC
			,Cedula_Profesional_del_Abogado_Victima = m.Cedula_Profesional_del_Abogado_Victima
                        ,Pais_del_Abogado_Victima = m.Pais_del_Abogado_Victima
                        ,Pais_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Pais_del_Abogado_Victima_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_del_Abogado_Victima_Pais.Nombre
                        ,Estado_del_Abogado_Victima = m.Estado_del_Abogado_Victima
                        ,Estado_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Estado_del_Abogado_Victima_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_del_Abogado_Victima_Estado.Nombre
                        ,Municipio_del_Abogado_Victima = m.Municipio_del_Abogado_Victima
                        ,Municipio_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Municipio_del_Abogado_Victima_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_del_Abogado_Victima_Municipio.Nombre
                        ,Colonia_del_Abogado_Victima = m.Colonia_del_Abogado_Victima
                        ,Colonia_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Colonia_del_Abogado_Victima_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_del_Abogado_Victima_Colonia.Nombre
			,Codigo_Postal_del_Abogado_Victima = m.Codigo_Postal_del_Abogado_Victima
			,Calle_del_Abogado_Victima = m.Calle_del_Abogado_Victima
			,Numero_Exterior_del_Abogado_Victima = m.Numero_Exterior_del_Abogado_Victima
			,Numero_Interior_del_Abogado_Victima = m.Numero_Interior_del_Abogado_Victima
			,Telefono_del_Abogado_Victima = m.Telefono_del_Abogado_Victima
			,Celular_del_Abogado_Victima = m.Celular_del_Abogado_Victima
			,Correo_Electronico_del_Abogado_Victima = m.Correo_Electronico_del_Abogado_Victima
			,Aceptar_Notificaciones = m.Aceptar_Notificaciones

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_del_Abogado_Victima_MPIGridModel> GetDetalle_del_Abogado_Victima_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_del_Abogado_Victima_MPIGridModel> resultData = new List<Detalle_del_Abogado_Victima_MPIGridModel>();
            string where = "Detalle_del_Abogado_Victima_MPI.Compareciente=" + Id;
            if("int" == "string")
            {
                where = "Detalle_del_Abogado_Victima_MPI.Compareciente='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_del_Abogado_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_del_Abogado_Victima_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_del_Abogado_Victima_MPIs != null)
            {
                resultData = result.Detalle_del_Abogado_Victima_MPIs.Select(m => new Detalle_del_Abogado_Victima_MPIGridModel
                    {
                        Consecutivo_Victima = m.Consecutivo_Victima

                        ,Nombre_Completo_del_Abogado_Victima = m.Nombre_Completo_del_Abogado_Victima
                        ,Nombre_Completo_del_Abogado_VictimaNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Completo_del_Abogado_Victima_Abogado.Clave.ToString(), "Nombre_Completo") ??(string)m.Nombre_Completo_del_Abogado_Victima_Abogado.Nombre_Completo
			,Nombre_del_Abogado_Victima = m.Nombre_del_Abogado_Victima
			,Apellido_Paterno_del_Abogado_Victima = m.Apellido_Paterno_del_Abogado_Victima
			,Apellido_Materno_del_Abogado_Victima = m.Apellido_Materno_del_Abogado_Victima
			,Fecha_de_Nacimiento_del_Abogado_Victima = (m.Fecha_de_Nacimiento_del_Abogado_Victima == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Abogado_Victima).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Abogado_Victima = m.Edad_del_Abogado_Victima
                        ,Sexo_del_Abogado_Victima = m.Sexo_del_Abogado_Victima
                        ,Sexo_del_Abogado_VictimaDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Abogado_Victima_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_del_Abogado_Victima_Genero.Descripcion
                        ,Estado_Civil_del_Abogado_Victima = m.Estado_Civil_del_Abogado_Victima
                        ,Estado_Civil_del_Abogado_VictimaDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Abogado_Victima_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_del_Abogado_Victima_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_Abogado_Victima = m.Tipo_de_Identificacion_Abogado_Victima
                        ,Tipo_de_Identificacion_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Abogado_Victima_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_Abogado_Victima_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_Abogado_Victima = m.Numero_de_Identificacion_Abogado_Victima
                        ,Nacionalidad_del_Abogado_Victima = m.Nacionalidad_del_Abogado_Victima
                        ,Nacionalidad_del_Abogado_VictimaNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Abogado_Victima_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_del_Abogado_Victima_Nacionalidad.NacionalidadC
			,Cedula_Profesional_del_Abogado_Victima = m.Cedula_Profesional_del_Abogado_Victima
                        ,Pais_del_Abogado_Victima = m.Pais_del_Abogado_Victima
                        ,Pais_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Pais_del_Abogado_Victima_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_del_Abogado_Victima_Pais.Nombre
                        ,Estado_del_Abogado_Victima = m.Estado_del_Abogado_Victima
                        ,Estado_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Estado_del_Abogado_Victima_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_del_Abogado_Victima_Estado.Nombre
                        ,Municipio_del_Abogado_Victima = m.Municipio_del_Abogado_Victima
                        ,Municipio_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Municipio_del_Abogado_Victima_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_del_Abogado_Victima_Municipio.Nombre
                        ,Colonia_del_Abogado_Victima = m.Colonia_del_Abogado_Victima
                        ,Colonia_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Colonia_del_Abogado_Victima_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_del_Abogado_Victima_Colonia.Nombre
			,Codigo_Postal_del_Abogado_Victima = m.Codigo_Postal_del_Abogado_Victima
			,Calle_del_Abogado_Victima = m.Calle_del_Abogado_Victima
			,Numero_Exterior_del_Abogado_Victima = m.Numero_Exterior_del_Abogado_Victima
			,Numero_Interior_del_Abogado_Victima = m.Numero_Interior_del_Abogado_Victima
			,Telefono_del_Abogado_Victima = m.Telefono_del_Abogado_Victima
			,Celular_del_Abogado_Victima = m.Celular_del_Abogado_Victima
			,Correo_Electronico_del_Abogado_Victima = m.Correo_Electronico_del_Abogado_Victima
			,Aceptar_Notificaciones = m.Aceptar_Notificaciones


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
                _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Datos_de_la_Victima_MPI varDetalle_de_Datos_de_la_Victima_MPI = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_del_Abogado_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_del_Abogado_Victima_MPI.Compareciente=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_del_Abogado_Victima_MPI.Compareciente='" + id + "'";
                    }
                    var Detalle_del_Abogado_Victima_MPIInfo =
                        _IDetalle_del_Abogado_Victima_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_del_Abogado_Victima_MPIInfo.Detalle_del_Abogado_Victima_MPIs.Count > 0)
                    {
                        var resultDetalle_del_Abogado_Victima_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_del_Abogado_Victima_MPIItem in Detalle_del_Abogado_Victima_MPIInfo.Detalle_del_Abogado_Victima_MPIs)
                            resultDetalle_del_Abogado_Victima_MPI = resultDetalle_del_Abogado_Victima_MPI
                                              && _IDetalle_del_Abogado_Victima_MPIApiConsumer.Delete(Detalle_del_Abogado_Victima_MPIItem.Consecutivo_Victima, null,null).Resource;

                        if (!resultDetalle_del_Abogado_Victima_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Datos_de_la_Victima_MPIModel varDetalle_de_Datos_de_la_Victima_MPI)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_Datos_de_la_Victima_MPIInfo = new Detalle_de_Datos_de_la_Victima_MPI
                    {
                        Clave = varDetalle_de_Datos_de_la_Victima_MPI.Clave
                        ,Nombre = varDetalle_de_Datos_de_la_Victima_MPI.Nombre
                        ,Apellido_Paterno = varDetalle_de_Datos_de_la_Victima_MPI.Apellido_Paterno
                        ,Apellido_Materno = varDetalle_de_Datos_de_la_Victima_MPI.Apellido_Materno
                        ,Nombre_Completo = varDetalle_de_Datos_de_la_Victima_MPI.Nombre_Completo
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varDetalle_de_Datos_de_la_Victima_MPI.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varDetalle_de_Datos_de_la_Victima_MPI.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varDetalle_de_Datos_de_la_Victima_MPI.Edad
                        ,Sexo = varDetalle_de_Datos_de_la_Victima_MPI.Sexo
                        ,Estado_Civil = varDetalle_de_Datos_de_la_Victima_MPI.Estado_Civil
                        ,Tipo_de_Identificacion = varDetalle_de_Datos_de_la_Victima_MPI.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varDetalle_de_Datos_de_la_Victima_MPI.Numero_de_Identificacion
                        ,Nacionalidad = varDetalle_de_Datos_de_la_Victima_MPI.Nacionalidad
                        ,Escolaridad = varDetalle_de_Datos_de_la_Victima_MPI.Escolaridad
                        ,Ocupacion = varDetalle_de_Datos_de_la_Victima_MPI.Ocupacion
                        ,Pais = varDetalle_de_Datos_de_la_Victima_MPI.Pais
                        ,Estado = varDetalle_de_Datos_de_la_Victima_MPI.Estado
                        ,Municipio = varDetalle_de_Datos_de_la_Victima_MPI.Municipio
                        ,Colonia = varDetalle_de_Datos_de_la_Victima_MPI.Colonia
                        ,Codigo_Postal = varDetalle_de_Datos_de_la_Victima_MPI.Codigo_Postal
                        ,Calle = varDetalle_de_Datos_de_la_Victima_MPI.Calle
                        ,Numero_Exterior = varDetalle_de_Datos_de_la_Victima_MPI.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Datos_de_la_Victima_MPI.Numero_Interior
                        ,Telefono = varDetalle_de_Datos_de_la_Victima_MPI.Telefono
                        ,Extencion = varDetalle_de_Datos_de_la_Victima_MPI.Extencion
                        ,Celular = varDetalle_de_Datos_de_la_Victima_MPI.Celular
                        ,Correo_Electronico = varDetalle_de_Datos_de_la_Victima_MPI.Correo_Electronico
                        ,Incapaz = varDetalle_de_Datos_de_la_Victima_MPI.Incapaz
                        ,Nombre_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Nombre_del_Tutor
                        ,Apellido_Paterno_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Apellido_Paterno_del_Tutor
                        ,Apellido_Materno_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Apellido_Materno_del_Tutor
                        ,Nombre_Completo_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Nombre_Completo_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (!String.IsNullOrEmpty(varDetalle_de_Datos_de_la_Victima_MPI.Fecha_de_Nacimiento_del_Tutor)) ? DateTime.ParseExact(varDetalle_de_Datos_de_la_Victima_MPI.Fecha_de_Nacimiento_del_Tutor, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Edad_del_Tutor
                        ,Sexo_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Sexo_del_Tutor
                        ,Estado_Civil_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Estado_Civil_del_Tutor
                        ,Tipo_de_Identificacion_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Tipo_de_Identificacion_del_Tutor
                        ,Numero_de_Identificacion_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Nacionalidad_del_Tutor
                        ,Escolaridad_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Escolaridad_del_Tutor
                        ,Ocupacion_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Ocupacion_del_Tutor
                        ,Pais_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Pais_del_Tutor
                        ,Estado_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Estado_del_Tutor
                        ,Municipio_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Municipio_del_Tutor
                        ,Localidad_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Localidad_del_Tutor
                        ,Colonia_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Colonia_del_Tutor
                        ,Codigo_Postal_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Codigo_Postal_del_Tutor
                        ,Calle_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Calle_del_Tutor
                        ,Numero_Exterior_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Numero_Exterior_del_Tutor
                        ,Numero_Interior_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Numero_Interior_del_Tutor
                        ,Telefono_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Telefono_del_Tutor
                        ,Extencion_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Extencion_del_Tutor
                        ,Celular_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Celular_del_Tutor
                        ,Correo_Electronico_del_Tutor = varDetalle_de_Datos_de_la_Victima_MPI.Correo_Electronico_del_Tutor
                        ,Tipo_de_Compareciente = varDetalle_de_Datos_de_la_Victima_MPI.Tipo_de_Compareciente
                        ,Narrativa_de_los_Hechos = varDetalle_de_Datos_de_la_Victima_MPI.Narrativa_de_los_Hechos
                        ,Titulo_del_Hecho = varDetalle_de_Datos_de_la_Victima_MPI.Titulo_del_Hecho
                        ,Prioridad_del_Hecho = varDetalle_de_Datos_de_la_Victima_MPI.Prioridad_del_Hecho
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varDetalle_de_Datos_de_la_Victima_MPI.Fecha_del_Hecho)) ? DateTime.ParseExact(varDetalle_de_Datos_de_la_Victima_MPI.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Aproximada_del_Hecho = varDetalle_de_Datos_de_la_Victima_MPI.Hora_Aproximada_del_Hecho
                        ,Pais_de_los_Hechos = varDetalle_de_Datos_de_la_Victima_MPI.Pais_de_los_Hechos
                        ,Estado_de_los_Hechos = varDetalle_de_Datos_de_la_Victima_MPI.Estado_de_los_Hechos
                        ,Municipio_de_los_Hechos = varDetalle_de_Datos_de_la_Victima_MPI.Municipio_de_los_Hechos
                        ,Colonia_de_los_Hechos = varDetalle_de_Datos_de_la_Victima_MPI.Colonia_de_los_Hechos
                        ,Codigo_Postal_de_los_Hechos = varDetalle_de_Datos_de_la_Victima_MPI.Codigo_Postal_de_los_Hechos
                        ,Calle_de_los_Hechos = varDetalle_de_Datos_de_la_Victima_MPI.Calle_de_los_Hechos
                        ,Entre_Calle_de_los_Hechos = varDetalle_de_Datos_de_la_Victima_MPI.Entre_Calle_de_los_Hechos
                        ,Y_Calle_de_los_Hechos = varDetalle_de_Datos_de_la_Victima_MPI.Y_Calle_de_los_Hechos
                        ,Numero_Exterior_de_los_Hechos = varDetalle_de_Datos_de_la_Victima_MPI.Numero_Exterior_de_los_Hechos
                        ,Numero_Interior_de_los_Hechos = varDetalle_de_Datos_de_la_Victima_MPI.Numero_Interior_de_los_Hechos
                        ,Latitud_de_los_Hechos = varDetalle_de_Datos_de_la_Victima_MPI.Latitud_de_los_Hechos
                        ,Longitud_de_los_Hechos = varDetalle_de_Datos_de_la_Victima_MPI.Longitud_de_los_Hechos
                        ,Tipo_de_Lugar_del_Hecho = varDetalle_de_Datos_de_la_Victima_MPI.Tipo_de_Lugar_del_Hecho
                        ,Proteccion_de_Datos = varDetalle_de_Datos_de_la_Victima_MPI.Proteccion_de_Datos
                        ,Nombre_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Nombre_de_Persona_Moral
                        ,Apellido_Paterno_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Apellido_Paterno_de_Persona_Moral
                        ,Apellido_Materno_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Apellido_Materno_de_Persona_Moral
                        ,Fecha_de_Nacimiento_de_Persona_Moral = (!String.IsNullOrEmpty(varDetalle_de_Datos_de_la_Victima_MPI.Fecha_de_Nacimiento_de_Persona_Moral)) ? DateTime.ParseExact(varDetalle_de_Datos_de_la_Victima_MPI.Fecha_de_Nacimiento_de_Persona_Moral, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Edad_de_Persona_Moral
                        ,Sexo_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Sexo_de_Persona_Moral
                        ,Estado_Civil_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Estado_Civil_de_Persona_Moral
                        ,Tipo_de_Identificacion_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Tipo_de_Identificacion_de_Persona_Moral
                        ,Numero_de_Identificacion_de_Persona_Mora = varDetalle_de_Datos_de_la_Victima_MPI.Numero_de_Identificacion_de_Persona_Mora
                        ,Nacionalidad_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Nacionalidad_de_Persona_Moral
                        ,Escolaridad_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Escolaridad_de_Persona_Moral
                        ,Ocupacion_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Ocupacion_de_Persona_Moral
                        ,Pais_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Pais_de_Persona_Moral
                        ,Estado_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Estado_de_Persona_Moral
                        ,Municipio_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Municipio_de_Persona_Moral
                        ,Colonia_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Colonia_de_Persona_Moral
                        ,Codigo_Postal_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Codigo_Postal_de_Persona_Moral
                        ,Calle_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Calle_de_Persona_Moral
                        ,Numero_Exterior_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Numero_Exterior_de_Persona_Moral
                        ,Numero_Interior_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Numero_Interior_de_Persona_Moral
                        ,Entre_Calle_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Entre_Calle_de_Persona_Moral
                        ,Y_Calle_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Y_Calle_de_Persona_Moral
                        ,Longitud_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Longitud_de_Persona_Moral
                        ,Latitud_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Latitud_de_Persona_Moral
                        ,Telefono_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Telefono_de_Persona_Moral
                        ,Extension_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Extension_de_Persona_Moral
                        ,Celular_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Celular_de_Persona_Moral
                        ,Correo_Electronico_de_Persona_Moral = varDetalle_de_Datos_de_la_Victima_MPI.Correo_Electronico_de_Persona_Moral
                        ,Persona_Moral_Victima = varDetalle_de_Datos_de_la_Victima_MPI.Persona_Moral_Victima

                    };

                    result = !IsNew ?
                        _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.Update(Detalle_de_Datos_de_la_Victima_MPIInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.Insert(Detalle_de_Datos_de_la_Victima_MPIInfo, null, null).Resource.ToString();

                    return Json(result, JsonRequestBehavior.AllowGet);
				}
				return Json(false, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [NonAction]
        public bool CopyDetalle_del_Abogado_Victima_MPI(int MasterId, int referenceId, List<Detalle_del_Abogado_Victima_MPIGridModelPost> Detalle_del_Abogado_Victima_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_del_Abogado_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_del_Abogado_Victima_MPIData = _IDetalle_del_Abogado_Victima_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_del_Abogado_Victima_MPI.Compareciente=" + referenceId,"").Resource;
                if (Detalle_del_Abogado_Victima_MPIData == null || Detalle_del_Abogado_Victima_MPIData.Detalle_del_Abogado_Victima_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_del_Abogado_Victima_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_del_Abogado_Victima_MPI in Detalle_del_Abogado_Victima_MPIData.Detalle_del_Abogado_Victima_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_del_Abogado_Victima_MPI Detalle_del_Abogado_Victima_MPI1 = varDetalle_del_Abogado_Victima_MPI;

                    if (Detalle_del_Abogado_Victima_MPIItems != null && Detalle_del_Abogado_Victima_MPIItems.Any(m => m.Consecutivo_Victima == Detalle_del_Abogado_Victima_MPI1.Consecutivo_Victima))
                    {
                        modelDataToChange = Detalle_del_Abogado_Victima_MPIItems.FirstOrDefault(m => m.Consecutivo_Victima == Detalle_del_Abogado_Victima_MPI1.Consecutivo_Victima);
                    }
                    //Chaning Id Value
                    varDetalle_del_Abogado_Victima_MPI.Compareciente = MasterId;
                    var insertId = _IDetalle_del_Abogado_Victima_MPIApiConsumer.Insert(varDetalle_del_Abogado_Victima_MPI,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Consecutivo_Victima = insertId;

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
        public ActionResult PostDetalle_del_Abogado_Victima_MPI(List<Detalle_del_Abogado_Victima_MPIGridModelPost> Detalle_del_Abogado_Victima_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_del_Abogado_Victima_MPI(MasterId, referenceId, Detalle_del_Abogado_Victima_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_del_Abogado_Victima_MPIItems != null && Detalle_del_Abogado_Victima_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_del_Abogado_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_del_Abogado_Victima_MPIItem in Detalle_del_Abogado_Victima_MPIItems)
                    {


























                        //Removal Request
                        if (Detalle_del_Abogado_Victima_MPIItem.Removed)
                        {
                            result = result && _IDetalle_del_Abogado_Victima_MPIApiConsumer.Delete(Detalle_del_Abogado_Victima_MPIItem.Consecutivo_Victima, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_del_Abogado_Victima_MPIItem.Consecutivo_Victima = 0;

                        var Detalle_del_Abogado_Victima_MPIData = new Detalle_del_Abogado_Victima_MPI
                        {
                            Compareciente = MasterId
                            ,Consecutivo_Victima = Detalle_del_Abogado_Victima_MPIItem.Consecutivo_Victima
                            ,Nombre_Completo_del_Abogado_Victima = (Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Nombre_Completo_del_Abogado_Victima) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Nombre_Completo_del_Abogado_Victima))
                            ,Nombre_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIItem.Nombre_del_Abogado_Victima
                            ,Apellido_Paterno_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIItem.Apellido_Paterno_del_Abogado_Victima
                            ,Apellido_Materno_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIItem.Apellido_Materno_del_Abogado_Victima
                            ,Fecha_de_Nacimiento_del_Abogado_Victima = (Detalle_del_Abogado_Victima_MPIItem.Fecha_de_Nacimiento_del_Abogado_Victima!= null) ? DateTime.ParseExact(Detalle_del_Abogado_Victima_MPIItem.Fecha_de_Nacimiento_del_Abogado_Victima, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Edad_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIItem.Edad_del_Abogado_Victima
                            ,Sexo_del_Abogado_Victima = (Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Sexo_del_Abogado_Victima) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Sexo_del_Abogado_Victima))
                            ,Estado_Civil_del_Abogado_Victima = (Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Estado_Civil_del_Abogado_Victima) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Estado_Civil_del_Abogado_Victima))
                            ,Tipo_de_Identificacion_Abogado_Victima = (Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Tipo_de_Identificacion_Abogado_Victima) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Tipo_de_Identificacion_Abogado_Victima))
                            ,Numero_de_Identificacion_Abogado_Victima = Detalle_del_Abogado_Victima_MPIItem.Numero_de_Identificacion_Abogado_Victima
                            ,Nacionalidad_del_Abogado_Victima = (Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Nacionalidad_del_Abogado_Victima) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Nacionalidad_del_Abogado_Victima))
                            ,Cedula_Profesional_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIItem.Cedula_Profesional_del_Abogado_Victima
                            ,Pais_del_Abogado_Victima = (Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Pais_del_Abogado_Victima) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Pais_del_Abogado_Victima))
                            ,Estado_del_Abogado_Victima = (Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Estado_del_Abogado_Victima) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Estado_del_Abogado_Victima))
                            ,Municipio_del_Abogado_Victima = (Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Municipio_del_Abogado_Victima) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Municipio_del_Abogado_Victima))
                            ,Colonia_del_Abogado_Victima = (Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Colonia_del_Abogado_Victima) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Victima_MPIItem.Colonia_del_Abogado_Victima))
                            ,Codigo_Postal_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIItem.Codigo_Postal_del_Abogado_Victima
                            ,Calle_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIItem.Calle_del_Abogado_Victima
                            ,Numero_Exterior_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIItem.Numero_Exterior_del_Abogado_Victima
                            ,Numero_Interior_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIItem.Numero_Interior_del_Abogado_Victima
                            ,Telefono_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIItem.Telefono_del_Abogado_Victima
                            ,Celular_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIItem.Celular_del_Abogado_Victima
                            ,Correo_Electronico_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIItem.Correo_Electronico_del_Abogado_Victima
                            ,Aceptar_Notificaciones = Detalle_del_Abogado_Victima_MPIItem.Aceptar_Notificaciones

                        };

                        var resultId = Detalle_del_Abogado_Victima_MPIItem.Consecutivo_Victima > 0
                           ? _IDetalle_del_Abogado_Victima_MPIApiConsumer.Update(Detalle_del_Abogado_Victima_MPIData,null,null).Resource
                           : _IDetalle_del_Abogado_Victima_MPIApiConsumer.Insert(Detalle_del_Abogado_Victima_MPIData,null,null).Resource;

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
        public ActionResult GetDetalle_del_Abogado_Victima_MPI_AbogadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAbogadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAbogadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Abogado", "Nombre_Completo");
                  item.Nombre_Completo= trans??item.Nombre_Completo;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [HttpGet]
        public ActionResult GetDetalle_del_Abogado_Victima_MPI_GeneroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGeneroApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Genero", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_del_Abogado_Victima_MPI_Estado_CivilAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstado_CivilApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado_Civil", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_del_Abogado_Victima_MPI_Tipo_de_IdentificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_IdentificacionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Tipo_de_Identificacion", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_del_Abogado_Victima_MPI_NacionalidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _INacionalidadApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Nacionalidad", "NacionalidadC");
                  item.NacionalidadC= trans??item.NacionalidadC;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult GetDetalle_del_Abogado_Victima_MPI_PaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_del_Abogado_Victima_MPI_EstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_del_Abogado_Victima_MPI_MunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_del_Abogado_Victima_MPI_ColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                  item.Nombre= trans??item.Nombre;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }











        /// <summary>
        /// Write Element Array of Detalle_de_Datos_de_la_Victima_MPI script
        /// </summary>
        /// <param name="oDetalle_de_Datos_de_la_Victima_MPIElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_de_Datos_de_la_Victima_MPIScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_de_la_Victima_MPI.js")))
            {
                strDetalle_de_Datos_de_la_Victima_MPIScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Datos_de_la_Victima_MPI element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Datos_de_la_Victima_MPIScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Datos_de_la_Victima_MPIScript.Substring(indexOfArray, strDetalle_de_Datos_de_la_Victima_MPIScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Datos_de_la_Victima_MPIScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_de_Datos_de_la_Victima_MPIScript.Substring(indexOfArrayHistory, strDetalle_de_Datos_de_la_Victima_MPIScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_de_Datos_de_la_Victima_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Datos_de_la_Victima_MPIScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Datos_de_la_Victima_MPIScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_de_Datos_de_la_Victima_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_de_Datos_de_la_Victima_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_de_Datos_de_la_Victima_MPIScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_de_Datos_de_la_Victima_MPIScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_de_Datos_de_la_Victima_MPIScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_de_la_Victima_MPI.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_de_la_Victima_MPI.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_de_la_Victima_MPI.js")))
                {
                    strCustomScript = r.ReadToEnd();
                
                }

                int indexOfArray = strCustomScript.IndexOf("inpuElementArray");
                string splittedString = strCustomScript.Substring(indexOfArray, strCustomScript.Length - indexOfArray);                
                int indexOfMainElement = splittedString.IndexOf('[');                
                int endIndexOfMainElement = splittedString.IndexOf(']') + 1;                
                string mainJsonArray = splittedString.Substring(indexOfMainElement, endIndexOfMainElement - indexOfMainElement);

                int indexOfChildArray = strCustomScript.IndexOf("inpuElementChildArray");
				string childJsonArray = "";
                if (indexOfChildArray != -1)
                {
					string splittedChildString = strCustomScript.Substring(indexOfChildArray, strCustomScript.Length - indexOfChildArray);
					int indexOfChildElement = splittedChildString.IndexOf('[');
					int endIndexOfChildElement = splittedChildString.IndexOf(']') + 1;
					childJsonArray = splittedChildString.Substring(indexOfChildElement, endIndexOfChildElement - indexOfChildElement);
				}
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
        public ActionResult Detalle_de_Datos_de_la_Victima_MPIPropertyBag()
        {
            return PartialView("Detalle_de_Datos_de_la_Victima_MPIPropertyBag", "Detalle_de_Datos_de_la_Victima_MPI");
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
        public ActionResult AddDetalle_del_Abogado_Victima_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_del_Abogado_Victima_MPI/AddDetalle_del_Abogado_Victima_MPI");
        }



        #endregion "Controller Methods"

        #region "Custom methods"

        [HttpGet]
        public void Export(string format, int pageIndex, int pageSize)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);

            if (!_tokenManager.GenerateToken())
                return;

            _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Datos_de_la_Victima_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Datos_de_la_Victima_MPIs == null)
                result.Detalle_de_Datos_de_la_Victima_MPIs = new List<Detalle_de_Datos_de_la_Victima_MPI>();

            var data = result.Detalle_de_Datos_de_la_Victima_MPIs.Select(m => new Detalle_de_Datos_de_la_Victima_MPIGridModel
            {
                Clave = m.Clave
                ,Nombre = m.Nombre
                ,Apellido_Paterno = m.Apellido_Paterno
                ,Apellido_Materno = m.Apellido_Materno
                ,Nombre_Completo = m.Nombre_Completo
                ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                ,Edad = m.Edad
                ,SexoDescripcion = (string)m.Sexo_Genero.Descripcion
                ,Estado_CivilDescripcion = (string)m.Estado_Civil_Estado_Civil.Descripcion
                ,Tipo_de_IdentificacionNombre = (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                ,Numero_de_Identificacion = m.Numero_de_Identificacion
                ,NacionalidadNacionalidadC = (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                ,EscolaridadDescripcion = (string)m.Escolaridad_Escolaridad.Descripcion
                ,OcupacionDescripcion = (string)m.Ocupacion_Ocupacion.Descripcion
                ,PaisNombre = (string)m.Pais_Pais.Nombre
                ,EstadoNombre = (string)m.Estado_Estado.Nombre
                ,MunicipioNombre = (string)m.Municipio_Municipio.Nombre
                ,ColoniaNombre = (string)m.Colonia_Colonia.Nombre
                ,Codigo_Postal = m.Codigo_Postal
                ,Calle = m.Calle
                ,Numero_Exterior = m.Numero_Exterior
                ,Numero_Interior = m.Numero_Interior
                ,Telefono = m.Telefono
                ,Extencion = m.Extencion
                ,Celular = m.Celular
                ,Correo_Electronico = m.Correo_Electronico
                ,Incapaz = m.Incapaz
                ,Nombre_del_Tutor = m.Nombre_del_Tutor
                ,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
                ,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
                ,Nombre_Completo_del_Tutor = m.Nombre_Completo_del_Tutor
                ,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
                ,Edad_del_Tutor = m.Edad_del_Tutor
                ,Sexo_del_TutorDescripcion = (string)m.Sexo_del_Tutor_Genero.Descripcion
                ,Estado_Civil_del_TutorDescripcion = (string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                ,Tipo_de_Identificacion_del_TutorNombre = (string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
                ,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
                ,Nacionalidad_del_TutorNacionalidadC = (string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                ,Escolaridad_del_TutorDescripcion = (string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                ,Ocupacion_del_TutorDescripcion = (string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
                ,Pais_del_TutorNombre = (string)m.Pais_del_Tutor_Pais.Nombre
                ,Estado_del_TutorNombre = (string)m.Estado_del_Tutor_Estado.Nombre
                ,Municipio_del_TutorNombre = (string)m.Municipio_del_Tutor_Municipio.Nombre
                ,Localidad_del_TutorDescripcion = (string)m.Localidad_del_Tutor_Localidad.Descripcion
                ,Colonia_del_TutorNombre = (string)m.Colonia_del_Tutor_Colonia.Nombre
                ,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
                ,Calle_del_Tutor = m.Calle_del_Tutor
                ,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
                ,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
                ,Telefono_del_Tutor = m.Telefono_del_Tutor
                ,Extencion_del_Tutor = m.Extencion_del_Tutor
                ,Celular_del_Tutor = m.Celular_del_Tutor
                ,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
                ,Tipo_de_ComparecienteDescripcion = (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                ,Narrativa_de_los_Hechos = m.Narrativa_de_los_Hechos
                ,Titulo_del_Hecho = m.Titulo_del_Hecho
                ,Prioridad_del_HechoDescripcion = (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                ,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                ,Pais_de_los_HechosNombre = (string)m.Pais_de_los_Hechos_Pais.Nombre
                ,Estado_de_los_HechosNombre = (string)m.Estado_de_los_Hechos_Estado.Nombre
                ,Municipio_de_los_HechosNombre = (string)m.Municipio_de_los_Hechos_Municipio.Nombre
                ,Colonia_de_los_HechosNombre = (string)m.Colonia_de_los_Hechos_Colonia.Nombre
                ,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
                ,Calle_de_los_Hechos = m.Calle_de_los_Hechos
                ,Entre_Calle_de_los_Hechos = m.Entre_Calle_de_los_Hechos
                ,Y_Calle_de_los_Hechos = m.Y_Calle_de_los_Hechos
                ,Numero_Exterior_de_los_Hechos = m.Numero_Exterior_de_los_Hechos
                ,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
                ,Latitud_de_los_Hechos = m.Latitud_de_los_Hechos
                ,Longitud_de_los_Hechos = m.Longitud_de_los_Hechos
                ,Tipo_de_Lugar_del_HechoDescripcion = (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                ,Proteccion_de_Datos = m.Proteccion_de_Datos
                ,Nombre_de_Persona_Moral = m.Nombre_de_Persona_Moral
                ,Apellido_Paterno_de_Persona_Moral = m.Apellido_Paterno_de_Persona_Moral
                ,Apellido_Materno_de_Persona_Moral = m.Apellido_Materno_de_Persona_Moral
                ,Fecha_de_Nacimiento_de_Persona_Moral = (m.Fecha_de_Nacimiento_de_Persona_Moral == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_de_Persona_Moral).ToString(ConfigurationProperty.DateFormat))
                ,Edad_de_Persona_Moral = m.Edad_de_Persona_Moral
                ,Sexo_de_Persona_MoralDescripcion = (string)m.Sexo_de_Persona_Moral_Genero.Descripcion
                ,Estado_Civil_de_Persona_MoralDescripcion = (string)m.Estado_Civil_de_Persona_Moral_Estado_Civil.Descripcion
                ,Tipo_de_Identificacion_de_Persona_MoralNombre = (string)m.Tipo_de_Identificacion_de_Persona_Moral_Tipo_de_Identificacion.Nombre
                ,Numero_de_Identificacion_de_Persona_Mora = m.Numero_de_Identificacion_de_Persona_Mora
                ,Nacionalidad_de_Persona_MoralNacionalidadC = (string)m.Nacionalidad_de_Persona_Moral_Nacionalidad.NacionalidadC
                ,Escolaridad_de_Persona_MoralDescripcion = (string)m.Escolaridad_de_Persona_Moral_Escolaridad.Descripcion
                ,Ocupacion_de_Persona_MoralDescripcion = (string)m.Ocupacion_de_Persona_Moral_Ocupacion.Descripcion
                ,Pais_de_Persona_MoralNombre = (string)m.Pais_de_Persona_Moral_Pais.Nombre
                ,Estado_de_Persona_MoralNombre = (string)m.Estado_de_Persona_Moral_Estado.Nombre
                ,Municipio_de_Persona_MoralNombre = (string)m.Municipio_de_Persona_Moral_Municipio.Nombre
                ,Colonia_de_Persona_MoralNombre = (string)m.Colonia_de_Persona_Moral_Colonia.Nombre
                ,Codigo_Postal_de_Persona_Moral = m.Codigo_Postal_de_Persona_Moral
                ,Calle_de_Persona_Moral = m.Calle_de_Persona_Moral
                ,Numero_Exterior_de_Persona_Moral = m.Numero_Exterior_de_Persona_Moral
                ,Numero_Interior_de_Persona_Moral = m.Numero_Interior_de_Persona_Moral
                ,Entre_Calle_de_Persona_Moral = m.Entre_Calle_de_Persona_Moral
                ,Y_Calle_de_Persona_Moral = m.Y_Calle_de_Persona_Moral
                ,Longitud_de_Persona_Moral = m.Longitud_de_Persona_Moral
                ,Latitud_de_Persona_Moral = m.Latitud_de_Persona_Moral
                ,Telefono_de_Persona_Moral = m.Telefono_de_Persona_Moral
                ,Extension_de_Persona_Moral = m.Extension_de_Persona_Moral
                ,Celular_de_Persona_Moral = m.Celular_de_Persona_Moral
                ,Correo_Electronico_de_Persona_Moral = m.Correo_Electronico_de_Persona_Moral
                ,Persona_Moral_Victima = m.Persona_Moral_Victima

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_de_Datos_de_la_Victima_MPIList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_de_Datos_de_la_Victima_MPIList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(), "EmployeeList_" + DateTime.Now.ToString());
                    break;
            }
        }

        [HttpGet]
        //[ObjectAuth(ObjectId = ModuleObjectId.EMPLEADOS_OBJECT, PermissionType = PermissionTypes.Export)]
        public ActionResult Print(string format, int pageIndex, int pageSize)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);

            if (!_tokenManager.GenerateToken())
                return null;

            _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Datos_de_la_Victima_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Datos_de_la_Victima_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Datos_de_la_Victima_MPIs == null)
                result.Detalle_de_Datos_de_la_Victima_MPIs = new List<Detalle_de_Datos_de_la_Victima_MPI>();

            var data = result.Detalle_de_Datos_de_la_Victima_MPIs.Select(m => new Detalle_de_Datos_de_la_Victima_MPIGridModel
            {
                Clave = m.Clave
                ,Nombre = m.Nombre
                ,Apellido_Paterno = m.Apellido_Paterno
                ,Apellido_Materno = m.Apellido_Materno
                ,Nombre_Completo = m.Nombre_Completo
                ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                ,Edad = m.Edad
                ,SexoDescripcion = (string)m.Sexo_Genero.Descripcion
                ,Estado_CivilDescripcion = (string)m.Estado_Civil_Estado_Civil.Descripcion
                ,Tipo_de_IdentificacionNombre = (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                ,Numero_de_Identificacion = m.Numero_de_Identificacion
                ,NacionalidadNacionalidadC = (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                ,EscolaridadDescripcion = (string)m.Escolaridad_Escolaridad.Descripcion
                ,OcupacionDescripcion = (string)m.Ocupacion_Ocupacion.Descripcion
                ,PaisNombre = (string)m.Pais_Pais.Nombre
                ,EstadoNombre = (string)m.Estado_Estado.Nombre
                ,MunicipioNombre = (string)m.Municipio_Municipio.Nombre
                ,ColoniaNombre = (string)m.Colonia_Colonia.Nombre
                ,Codigo_Postal = m.Codigo_Postal
                ,Calle = m.Calle
                ,Numero_Exterior = m.Numero_Exterior
                ,Numero_Interior = m.Numero_Interior
                ,Telefono = m.Telefono
                ,Extencion = m.Extencion
                ,Celular = m.Celular
                ,Correo_Electronico = m.Correo_Electronico
                ,Incapaz = m.Incapaz
                ,Nombre_del_Tutor = m.Nombre_del_Tutor
                ,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
                ,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
                ,Nombre_Completo_del_Tutor = m.Nombre_Completo_del_Tutor
                ,Fecha_de_Nacimiento_del_Tutor = (m.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
                ,Edad_del_Tutor = m.Edad_del_Tutor
                ,Sexo_del_TutorDescripcion = (string)m.Sexo_del_Tutor_Genero.Descripcion
                ,Estado_Civil_del_TutorDescripcion = (string)m.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                ,Tipo_de_Identificacion_del_TutorNombre = (string)m.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
                ,Numero_de_Identificacion_del_Tutor = m.Numero_de_Identificacion_del_Tutor
                ,Nacionalidad_del_TutorNacionalidadC = (string)m.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                ,Escolaridad_del_TutorDescripcion = (string)m.Escolaridad_del_Tutor_Escolaridad.Descripcion
                ,Ocupacion_del_TutorDescripcion = (string)m.Ocupacion_del_Tutor_Ocupacion.Descripcion
                ,Pais_del_TutorNombre = (string)m.Pais_del_Tutor_Pais.Nombre
                ,Estado_del_TutorNombre = (string)m.Estado_del_Tutor_Estado.Nombre
                ,Municipio_del_TutorNombre = (string)m.Municipio_del_Tutor_Municipio.Nombre
                ,Localidad_del_TutorDescripcion = (string)m.Localidad_del_Tutor_Localidad.Descripcion
                ,Colonia_del_TutorNombre = (string)m.Colonia_del_Tutor_Colonia.Nombre
                ,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
                ,Calle_del_Tutor = m.Calle_del_Tutor
                ,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
                ,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
                ,Telefono_del_Tutor = m.Telefono_del_Tutor
                ,Extencion_del_Tutor = m.Extencion_del_Tutor
                ,Celular_del_Tutor = m.Celular_del_Tutor
                ,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
                ,Tipo_de_ComparecienteDescripcion = (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                ,Narrativa_de_los_Hechos = m.Narrativa_de_los_Hechos
                ,Titulo_del_Hecho = m.Titulo_del_Hecho
                ,Prioridad_del_HechoDescripcion = (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                ,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                ,Pais_de_los_HechosNombre = (string)m.Pais_de_los_Hechos_Pais.Nombre
                ,Estado_de_los_HechosNombre = (string)m.Estado_de_los_Hechos_Estado.Nombre
                ,Municipio_de_los_HechosNombre = (string)m.Municipio_de_los_Hechos_Municipio.Nombre
                ,Colonia_de_los_HechosNombre = (string)m.Colonia_de_los_Hechos_Colonia.Nombre
                ,Codigo_Postal_de_los_Hechos = m.Codigo_Postal_de_los_Hechos
                ,Calle_de_los_Hechos = m.Calle_de_los_Hechos
                ,Entre_Calle_de_los_Hechos = m.Entre_Calle_de_los_Hechos
                ,Y_Calle_de_los_Hechos = m.Y_Calle_de_los_Hechos
                ,Numero_Exterior_de_los_Hechos = m.Numero_Exterior_de_los_Hechos
                ,Numero_Interior_de_los_Hechos = m.Numero_Interior_de_los_Hechos
                ,Latitud_de_los_Hechos = m.Latitud_de_los_Hechos
                ,Longitud_de_los_Hechos = m.Longitud_de_los_Hechos
                ,Tipo_de_Lugar_del_HechoDescripcion = (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                ,Proteccion_de_Datos = m.Proteccion_de_Datos
                ,Nombre_de_Persona_Moral = m.Nombre_de_Persona_Moral
                ,Apellido_Paterno_de_Persona_Moral = m.Apellido_Paterno_de_Persona_Moral
                ,Apellido_Materno_de_Persona_Moral = m.Apellido_Materno_de_Persona_Moral
                ,Fecha_de_Nacimiento_de_Persona_Moral = (m.Fecha_de_Nacimiento_de_Persona_Moral == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_de_Persona_Moral).ToString(ConfigurationProperty.DateFormat))
                ,Edad_de_Persona_Moral = m.Edad_de_Persona_Moral
                ,Sexo_de_Persona_MoralDescripcion = (string)m.Sexo_de_Persona_Moral_Genero.Descripcion
                ,Estado_Civil_de_Persona_MoralDescripcion = (string)m.Estado_Civil_de_Persona_Moral_Estado_Civil.Descripcion
                ,Tipo_de_Identificacion_de_Persona_MoralNombre = (string)m.Tipo_de_Identificacion_de_Persona_Moral_Tipo_de_Identificacion.Nombre
                ,Numero_de_Identificacion_de_Persona_Mora = m.Numero_de_Identificacion_de_Persona_Mora
                ,Nacionalidad_de_Persona_MoralNacionalidadC = (string)m.Nacionalidad_de_Persona_Moral_Nacionalidad.NacionalidadC
                ,Escolaridad_de_Persona_MoralDescripcion = (string)m.Escolaridad_de_Persona_Moral_Escolaridad.Descripcion
                ,Ocupacion_de_Persona_MoralDescripcion = (string)m.Ocupacion_de_Persona_Moral_Ocupacion.Descripcion
                ,Pais_de_Persona_MoralNombre = (string)m.Pais_de_Persona_Moral_Pais.Nombre
                ,Estado_de_Persona_MoralNombre = (string)m.Estado_de_Persona_Moral_Estado.Nombre
                ,Municipio_de_Persona_MoralNombre = (string)m.Municipio_de_Persona_Moral_Municipio.Nombre
                ,Colonia_de_Persona_MoralNombre = (string)m.Colonia_de_Persona_Moral_Colonia.Nombre
                ,Codigo_Postal_de_Persona_Moral = m.Codigo_Postal_de_Persona_Moral
                ,Calle_de_Persona_Moral = m.Calle_de_Persona_Moral
                ,Numero_Exterior_de_Persona_Moral = m.Numero_Exterior_de_Persona_Moral
                ,Numero_Interior_de_Persona_Moral = m.Numero_Interior_de_Persona_Moral
                ,Entre_Calle_de_Persona_Moral = m.Entre_Calle_de_Persona_Moral
                ,Y_Calle_de_Persona_Moral = m.Y_Calle_de_Persona_Moral
                ,Longitud_de_Persona_Moral = m.Longitud_de_Persona_Moral
                ,Latitud_de_Persona_Moral = m.Latitud_de_Persona_Moral
                ,Telefono_de_Persona_Moral = m.Telefono_de_Persona_Moral
                ,Extension_de_Persona_Moral = m.Extension_de_Persona_Moral
                ,Celular_de_Persona_Moral = m.Celular_de_Persona_Moral
                ,Correo_Electronico_de_Persona_Moral = m.Correo_Electronico_de_Persona_Moral
                ,Persona_Moral_Victima = m.Persona_Moral_Victima

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
