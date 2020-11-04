using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Datos_del_Testigo_MPI;
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
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Prioridad_del_Hecho;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Lugar_Tipo;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Datos_del_Testigo_MPI;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_del_Testigo_MPI;
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
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Prioridad_del_Hecho;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;

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
    public class Detalle_de_Datos_del_Testigo_MPIController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Datos_del_Testigo_MPIService service = null;
        private IDetalle_de_Datos_del_Testigo_MPIApiConsumer _IDetalle_de_Datos_del_Testigo_MPIApiConsumer;
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

        
        public Detalle_de_Datos_del_Testigo_MPIController(IDetalle_de_Datos_del_Testigo_MPIService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Datos_del_Testigo_MPIApiConsumer Detalle_de_Datos_del_Testigo_MPIApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IEscolaridadApiConsumer EscolaridadApiConsumer , IOcupacionApiConsumer OcupacionApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , ITipo_de_ComparecienteApiConsumer Tipo_de_ComparecienteApiConsumer , IPrioridad_del_HechoApiConsumer Prioridad_del_HechoApiConsumer , ILugar_TipoApiConsumer Lugar_TipoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Datos_del_Testigo_MPIApiConsumer = Detalle_de_Datos_del_Testigo_MPIApiConsumer;
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
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ITipo_de_ComparecienteApiConsumer = Tipo_de_ComparecienteApiConsumer;
            this._IPrioridad_del_HechoApiConsumer = Prioridad_del_HechoApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Datos_del_Testigo_MPI
        [ObjectAuth(ObjectId = (ModuleObjectId)45130, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45130);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_de_Datos_del_Testigo_MPI/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45130, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45130);
            ViewBag.Permission = permission;
            var varDetalle_de_Datos_del_Testigo_MPI = new Detalle_de_Datos_del_Testigo_MPIModel();
			
            ViewBag.ObjectId = "45130";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Datos_del_Testigo_MPIData = _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.GetByKeyComplete(Id).Resource.Detalle_de_Datos_del_Testigo_MPIs[0];
                if (Detalle_de_Datos_del_Testigo_MPIData == null)
                    return HttpNotFound();

                varDetalle_de_Datos_del_Testigo_MPI = new Detalle_de_Datos_del_Testigo_MPIModel
                {
                    Clave = (int)Detalle_de_Datos_del_Testigo_MPIData.Clave
                    ,Nombre = Detalle_de_Datos_del_Testigo_MPIData.Nombre
                    ,Apellido_Paterno = Detalle_de_Datos_del_Testigo_MPIData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Datos_del_Testigo_MPIData.Apellido_Materno
                    ,Nombre_Completo = Detalle_de_Datos_del_Testigo_MPIData.Nombre_Completo
                    ,Fecha_de_Nacimiento = (Detalle_de_Datos_del_Testigo_MPIData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Testigo_MPIData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Detalle_de_Datos_del_Testigo_MPIData.Edad
                    ,Sexo = Detalle_de_Datos_del_Testigo_MPIData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Sexo), "Genero") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Detalle_de_Datos_del_Testigo_MPIData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Estado_Civil), "Estado_Civil") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Detalle_de_Datos_del_Testigo_MPIData.Numero_de_Identificacion
                    ,Nacionalidad = Detalle_de_Datos_del_Testigo_MPIData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = Detalle_de_Datos_del_Testigo_MPIData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Escolaridad), "Escolaridad") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Detalle_de_Datos_del_Testigo_MPIData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Ocupacion), "Ocupacion") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Ocupacion_Ocupacion.Descripcion
                    ,Pais = Detalle_de_Datos_del_Testigo_MPIData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Pais), "Pais") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_Datos_del_Testigo_MPIData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Estado), "Estado") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Datos_del_Testigo_MPIData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Municipio), "Municipio") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Municipio_Municipio.Nombre
                    ,Colonia = Detalle_de_Datos_del_Testigo_MPIData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Colonia), "Colonia") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Detalle_de_Datos_del_Testigo_MPIData.Codigo_Postal
                    ,Calle = Detalle_de_Datos_del_Testigo_MPIData.Calle
                    ,Numero_Exterior = Detalle_de_Datos_del_Testigo_MPIData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Datos_del_Testigo_MPIData.Numero_Interior
                    ,Telefono = Detalle_de_Datos_del_Testigo_MPIData.Telefono
                    ,Extencion = Detalle_de_Datos_del_Testigo_MPIData.Extencion
                    ,Celular = Detalle_de_Datos_del_Testigo_MPIData.Celular
                    ,Correo_Electronico = Detalle_de_Datos_del_Testigo_MPIData.Correo_Electronico
                    ,Incapaz = Detalle_de_Datos_del_Testigo_MPIData.Incapaz.GetValueOrDefault()
                    ,Nombre_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Nombre_del_Tutor
                    ,Apellido_Paterno_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Apellido_Paterno_del_Tutor
                    ,Apellido_Materno_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Apellido_Materno_del_Tutor
                    ,Nombre_Completo_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Nombre_Completo_del_Tutor
                    ,Fecha_de_Nacimento_del_Tutor = (Detalle_de_Datos_del_Testigo_MPIData.Fecha_de_Nacimento_del_Tutor == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Testigo_MPIData.Fecha_de_Nacimento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Edad_del_Tutor
                    ,Sexo_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Sexo_del_Tutor
                    ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Sexo_del_Tutor), "Genero") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Sexo_del_Tutor_Genero.Descripcion
                    ,Estado_Civil_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Estado_Civil_del_Tutor
                    ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Estado_Civil_del_Tutor), "Estado_Civil") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Identificacion_del_Tutor
                    ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Identificacion_del_Tutor), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Numero_de_Identificacion_del_Tutor
                    ,Nacionalidad_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Nacionalidad_del_Tutor
                    ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Nacionalidad_del_Tutor), "Nacionalidad") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                    ,Escolaridad_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Escolaridad_del_Tutor
                    ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Escolaridad_del_Tutor), "Escolaridad") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Escolaridad_del_Tutor_Escolaridad.Descripcion
                    ,Ocupacion_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Ocupacion_del_Tutor
                    ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Ocupacion_del_Tutor), "Ocupacion") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Ocupacion_del_Tutor_Ocupacion.Descripcion
                    ,Pais_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Pais_del_Tutor
                    ,Pais_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Pais_del_Tutor), "Pais") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Pais_del_Tutor_Pais.Nombre
                    ,Estado_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Estado_del_Tutor
                    ,Estado_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Estado_del_Tutor), "Estado") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Estado_del_Tutor_Estado.Nombre
                    ,Municipio_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Municipio_del_Tutor
                    ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Municipio_del_Tutor), "Municipio") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Municipio_del_Tutor_Municipio.Nombre
                    ,Colonia_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Colonia_del_Tutor
                    ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Colonia_del_Tutor), "Colonia") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Colonia_del_Tutor_Colonia.Nombre
                    ,Codigo_Postal_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Codigo_Postal_del_Tutor
                    ,Calle_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Calle_del_Tutor
                    ,Numero_Exterior_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Numero_Exterior_del_Tutor
                    ,Numero_Interior_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Numero_Interior_del_Tutor
                    ,Telefono_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Telefono_del_Tutor
                    ,Extencion_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Extencion_del_Tutor
                    ,Celular_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Celular_del_Tutor
                    ,Correo_Electronico_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Correo_Electronico_del_Tutor
                    ,Tipo_de_Compareciente = Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Compareciente
                    ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Compareciente), "Tipo_de_Compareciente") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                    ,Narrativa_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData.Narrativa_del_Testigo
                    ,Titulo_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Titulo_del_Hecho
                    ,Prioridad_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Prioridad_del_Hecho
                    ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Prioridad_del_Hecho), "Prioridad_del_Hecho") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                    ,Fecha_del_Hecho = (Detalle_de_Datos_del_Testigo_MPIData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Testigo_MPIData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Aproximada_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Hora_Aproximada_del_Hecho
                    ,Pais_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Pais_del_Hecho
                    ,Pais_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Pais_del_Hecho), "Pais") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Pais_del_Hecho_Pais.Nombre
                    ,Estado_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Estado_del_Hecho
                    ,Estado_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Estado_del_Hecho), "Estado") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Estado_del_Hecho_Estado.Nombre
                    ,Municipio_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Municipio_del_Hecho
                    ,Municipio_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Municipio_del_Hecho), "Municipio") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Municipio_del_Hecho_Municipio.Nombre
                    ,Colonia_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Colonia_del_Hecho
                    ,Colonia_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Colonia_del_Hecho), "Colonia") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Colonia_del_Hecho_Colonia.Nombre
                    ,Codigo_Postal_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Codigo_Postal_del_Hecho
                    ,Calle_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Calle_del_Hecho
                    ,Entre_Calle_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Entre_Calle_del_Hecho
                    ,Y_Calle_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Y_Calle_del_Hecho
                    ,Numero_Exterior_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Numero_Exterior_del_Hecho
                    ,Numero_Interior_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Numero_Interior_del_Hecho
                    ,Latitud_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Latitud_del_Hecho
                    ,Longitud_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Longitud_del_Hecho
                    ,Tipo_del_Lugar_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Tipo_del_Lugar_del_Hecho
                    ,Tipo_del_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Tipo_del_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Tipo_del_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,Proteccion_de_Datos = Detalle_de_Datos_del_Testigo_MPIData.Proteccion_de_Datos.GetValueOrDefault()

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
            var Paiss_Pais_del_Hecho = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_del_Hecho != null && Paiss_Pais_del_Hecho.Resource != null)
                ViewBag.Paiss_Pais_del_Hecho = Paiss_Pais_del_Hecho.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Hecho = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Hecho != null && Estados_Estado_del_Hecho.Resource != null)
                ViewBag.Estados_Estado_del_Hecho = Estados_Estado_del_Hecho.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Hecho = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Hecho != null && Municipios_Municipio_del_Hecho.Resource != null)
                ViewBag.Municipios_Municipio_del_Hecho = Municipios_Municipio_del_Hecho.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Hecho = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Hecho != null && Colonias_Colonia_del_Hecho.Resource != null)
                ViewBag.Colonias_Colonia_del_Hecho = Colonias_Colonia_del_Hecho.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_del_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_del_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_del_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_del_Lugar_del_Hecho = Lugar_Tipos_Tipo_del_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_de_Datos_del_Testigo_MPI);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Datos_del_Testigo_MPI(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45130);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Datos_del_Testigo_MPIModel varDetalle_de_Datos_del_Testigo_MPI= new Detalle_de_Datos_del_Testigo_MPIModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_Datos_del_Testigo_MPIsData = _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Datos_del_Testigo_MPI.Clave=" + id, "").Resource.Detalle_de_Datos_del_Testigo_MPIs;
				
				if (Detalle_de_Datos_del_Testigo_MPIsData != null && Detalle_de_Datos_del_Testigo_MPIsData.Count > 0)
                {
					var Detalle_de_Datos_del_Testigo_MPIData = Detalle_de_Datos_del_Testigo_MPIsData.First();
					varDetalle_de_Datos_del_Testigo_MPI= new Detalle_de_Datos_del_Testigo_MPIModel
					{
						Clave  = Detalle_de_Datos_del_Testigo_MPIData.Clave 
	                    ,Nombre = Detalle_de_Datos_del_Testigo_MPIData.Nombre
                    ,Apellido_Paterno = Detalle_de_Datos_del_Testigo_MPIData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Datos_del_Testigo_MPIData.Apellido_Materno
                    ,Nombre_Completo = Detalle_de_Datos_del_Testigo_MPIData.Nombre_Completo
                    ,Fecha_de_Nacimiento = (Detalle_de_Datos_del_Testigo_MPIData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Testigo_MPIData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Detalle_de_Datos_del_Testigo_MPIData.Edad
                    ,Sexo = Detalle_de_Datos_del_Testigo_MPIData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Sexo), "Genero") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Detalle_de_Datos_del_Testigo_MPIData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Estado_Civil), "Estado_Civil") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Detalle_de_Datos_del_Testigo_MPIData.Numero_de_Identificacion
                    ,Nacionalidad = Detalle_de_Datos_del_Testigo_MPIData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = Detalle_de_Datos_del_Testigo_MPIData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Escolaridad), "Escolaridad") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Detalle_de_Datos_del_Testigo_MPIData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Ocupacion), "Ocupacion") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Ocupacion_Ocupacion.Descripcion
                    ,Pais = Detalle_de_Datos_del_Testigo_MPIData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Pais), "Pais") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Pais_Pais.Nombre
                    ,Estado = Detalle_de_Datos_del_Testigo_MPIData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Estado), "Estado") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Datos_del_Testigo_MPIData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Municipio), "Municipio") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Municipio_Municipio.Nombre
                    ,Colonia = Detalle_de_Datos_del_Testigo_MPIData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Colonia), "Colonia") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Detalle_de_Datos_del_Testigo_MPIData.Codigo_Postal
                    ,Calle = Detalle_de_Datos_del_Testigo_MPIData.Calle
                    ,Numero_Exterior = Detalle_de_Datos_del_Testigo_MPIData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Datos_del_Testigo_MPIData.Numero_Interior
                    ,Telefono = Detalle_de_Datos_del_Testigo_MPIData.Telefono
                    ,Extencion = Detalle_de_Datos_del_Testigo_MPIData.Extencion
                    ,Celular = Detalle_de_Datos_del_Testigo_MPIData.Celular
                    ,Correo_Electronico = Detalle_de_Datos_del_Testigo_MPIData.Correo_Electronico
                    ,Incapaz = Detalle_de_Datos_del_Testigo_MPIData.Incapaz.GetValueOrDefault()
                    ,Nombre_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Nombre_del_Tutor
                    ,Apellido_Paterno_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Apellido_Paterno_del_Tutor
                    ,Apellido_Materno_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Apellido_Materno_del_Tutor
                    ,Nombre_Completo_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Nombre_Completo_del_Tutor
                    ,Fecha_de_Nacimento_del_Tutor = (Detalle_de_Datos_del_Testigo_MPIData.Fecha_de_Nacimento_del_Tutor == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Testigo_MPIData.Fecha_de_Nacimento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Edad_del_Tutor
                    ,Sexo_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Sexo_del_Tutor
                    ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Sexo_del_Tutor), "Genero") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Sexo_del_Tutor_Genero.Descripcion
                    ,Estado_Civil_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Estado_Civil_del_Tutor
                    ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Estado_Civil_del_Tutor), "Estado_Civil") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Identificacion_del_Tutor
                    ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Identificacion_del_Tutor), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Numero_de_Identificacion_del_Tutor
                    ,Nacionalidad_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Nacionalidad_del_Tutor
                    ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Nacionalidad_del_Tutor), "Nacionalidad") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                    ,Escolaridad_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Escolaridad_del_Tutor
                    ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Escolaridad_del_Tutor), "Escolaridad") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Escolaridad_del_Tutor_Escolaridad.Descripcion
                    ,Ocupacion_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Ocupacion_del_Tutor
                    ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Ocupacion_del_Tutor), "Ocupacion") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Ocupacion_del_Tutor_Ocupacion.Descripcion
                    ,Pais_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Pais_del_Tutor
                    ,Pais_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Pais_del_Tutor), "Pais") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Pais_del_Tutor_Pais.Nombre
                    ,Estado_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Estado_del_Tutor
                    ,Estado_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Estado_del_Tutor), "Estado") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Estado_del_Tutor_Estado.Nombre
                    ,Municipio_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Municipio_del_Tutor
                    ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Municipio_del_Tutor), "Municipio") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Municipio_del_Tutor_Municipio.Nombre
                    ,Colonia_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Colonia_del_Tutor
                    ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Colonia_del_Tutor), "Colonia") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Colonia_del_Tutor_Colonia.Nombre
                    ,Codigo_Postal_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Codigo_Postal_del_Tutor
                    ,Calle_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Calle_del_Tutor
                    ,Numero_Exterior_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Numero_Exterior_del_Tutor
                    ,Numero_Interior_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Numero_Interior_del_Tutor
                    ,Telefono_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Telefono_del_Tutor
                    ,Extencion_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Extencion_del_Tutor
                    ,Celular_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Celular_del_Tutor
                    ,Correo_Electronico_del_Tutor = Detalle_de_Datos_del_Testigo_MPIData.Correo_Electronico_del_Tutor
                    ,Tipo_de_Compareciente = Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Compareciente
                    ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Compareciente), "Tipo_de_Compareciente") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                    ,Narrativa_del_Testigo = Detalle_de_Datos_del_Testigo_MPIData.Narrativa_del_Testigo
                    ,Titulo_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Titulo_del_Hecho
                    ,Prioridad_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Prioridad_del_Hecho
                    ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Prioridad_del_Hecho), "Prioridad_del_Hecho") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                    ,Fecha_del_Hecho = (Detalle_de_Datos_del_Testigo_MPIData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Testigo_MPIData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Aproximada_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Hora_Aproximada_del_Hecho
                    ,Pais_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Pais_del_Hecho
                    ,Pais_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Pais_del_Hecho), "Pais") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Pais_del_Hecho_Pais.Nombre
                    ,Estado_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Estado_del_Hecho
                    ,Estado_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Estado_del_Hecho), "Estado") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Estado_del_Hecho_Estado.Nombre
                    ,Municipio_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Municipio_del_Hecho
                    ,Municipio_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Municipio_del_Hecho), "Municipio") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Municipio_del_Hecho_Municipio.Nombre
                    ,Colonia_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Colonia_del_Hecho
                    ,Colonia_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Colonia_del_Hecho), "Colonia") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Colonia_del_Hecho_Colonia.Nombre
                    ,Codigo_Postal_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Codigo_Postal_del_Hecho
                    ,Calle_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Calle_del_Hecho
                    ,Entre_Calle_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Entre_Calle_del_Hecho
                    ,Y_Calle_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Y_Calle_del_Hecho
                    ,Numero_Exterior_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Numero_Exterior_del_Hecho
                    ,Numero_Interior_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Numero_Interior_del_Hecho
                    ,Latitud_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Latitud_del_Hecho
                    ,Longitud_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Longitud_del_Hecho
                    ,Tipo_del_Lugar_del_Hecho = Detalle_de_Datos_del_Testigo_MPIData.Tipo_del_Lugar_del_Hecho
                    ,Tipo_del_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Testigo_MPIData.Tipo_del_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)Detalle_de_Datos_del_Testigo_MPIData.Tipo_del_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,Proteccion_de_Datos = Detalle_de_Datos_del_Testigo_MPIData.Proteccion_de_Datos.GetValueOrDefault()

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
            var Paiss_Pais_del_Hecho = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_del_Hecho != null && Paiss_Pais_del_Hecho.Resource != null)
                ViewBag.Paiss_Pais_del_Hecho = Paiss_Pais_del_Hecho.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Hecho = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Hecho != null && Estados_Estado_del_Hecho.Resource != null)
                ViewBag.Estados_Estado_del_Hecho = Estados_Estado_del_Hecho.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Hecho = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Hecho != null && Municipios_Municipio_del_Hecho.Resource != null)
                ViewBag.Municipios_Municipio_del_Hecho = Municipios_Municipio_del_Hecho.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Hecho = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Hecho != null && Colonias_Colonia_del_Hecho.Resource != null)
                ViewBag.Colonias_Colonia_del_Hecho = Colonias_Colonia_del_Hecho.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILugar_TipoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_Tipos_Tipo_del_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_del_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_del_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_del_Lugar_del_Hecho = Lugar_Tipos_Tipo_del_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Datos_del_Testigo_MPI", varDetalle_de_Datos_del_Testigo_MPI);
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Datos_del_Testigo_MPIPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Datos_del_Testigo_MPIs == null)
                result.Detalle_de_Datos_del_Testigo_MPIs = new List<Detalle_de_Datos_del_Testigo_MPI>();

            return Json(new
            {
                data = result.Detalle_de_Datos_del_Testigo_MPIs.Select(m => new Detalle_de_Datos_del_Testigo_MPIGridModel
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
                        ,Fecha_de_Nacimento_del_Tutor = (m.Fecha_de_Nacimento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
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
			,Narrativa_del_Testigo = m.Narrativa_del_Testigo
			,Titulo_del_Hecho = m.Titulo_del_Hecho
                        ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(m.Prioridad_del_Hecho_Prioridad_del_Hecho.Clave.ToString(), "Descripcion") ?? (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                        ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
			,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                        ,Pais_del_HechoNombre = CultureHelper.GetTraduction(m.Pais_del_Hecho_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_del_Hecho_Pais.Nombre
                        ,Estado_del_HechoNombre = CultureHelper.GetTraduction(m.Estado_del_Hecho_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Hecho_Estado.Nombre
                        ,Municipio_del_HechoNombre = CultureHelper.GetTraduction(m.Municipio_del_Hecho_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Hecho_Municipio.Nombre
                        ,Colonia_del_HechoNombre = CultureHelper.GetTraduction(m.Colonia_del_Hecho_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Hecho_Colonia.Nombre
			,Codigo_Postal_del_Hecho = m.Codigo_Postal_del_Hecho
			,Calle_del_Hecho = m.Calle_del_Hecho
			,Entre_Calle_del_Hecho = m.Entre_Calle_del_Hecho
			,Y_Calle_del_Hecho = m.Y_Calle_del_Hecho
			,Numero_Exterior_del_Hecho = m.Numero_Exterior_del_Hecho
			,Numero_Interior_del_Hecho = m.Numero_Interior_del_Hecho
			,Latitud_del_Hecho = m.Latitud_del_Hecho
			,Longitud_del_Hecho = m.Longitud_del_Hecho
                        ,Tipo_del_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_del_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_del_Lugar_del_Hecho_Lugar_Tipo.Descripcion
			,Proteccion_de_Datos = m.Proteccion_de_Datos

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
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
                _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Datos_del_Testigo_MPI varDetalle_de_Datos_del_Testigo_MPI = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Datos_del_Testigo_MPIModel varDetalle_de_Datos_del_Testigo_MPI)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_Datos_del_Testigo_MPIInfo = new Detalle_de_Datos_del_Testigo_MPI
                    {
                        Clave = varDetalle_de_Datos_del_Testigo_MPI.Clave
                        ,Nombre = varDetalle_de_Datos_del_Testigo_MPI.Nombre
                        ,Apellido_Paterno = varDetalle_de_Datos_del_Testigo_MPI.Apellido_Paterno
                        ,Apellido_Materno = varDetalle_de_Datos_del_Testigo_MPI.Apellido_Materno
                        ,Nombre_Completo = varDetalle_de_Datos_del_Testigo_MPI.Nombre_Completo
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varDetalle_de_Datos_del_Testigo_MPI.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varDetalle_de_Datos_del_Testigo_MPI.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varDetalle_de_Datos_del_Testigo_MPI.Edad
                        ,Sexo = varDetalle_de_Datos_del_Testigo_MPI.Sexo
                        ,Estado_Civil = varDetalle_de_Datos_del_Testigo_MPI.Estado_Civil
                        ,Tipo_de_Identificacion = varDetalle_de_Datos_del_Testigo_MPI.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varDetalle_de_Datos_del_Testigo_MPI.Numero_de_Identificacion
                        ,Nacionalidad = varDetalle_de_Datos_del_Testigo_MPI.Nacionalidad
                        ,Escolaridad = varDetalle_de_Datos_del_Testigo_MPI.Escolaridad
                        ,Ocupacion = varDetalle_de_Datos_del_Testigo_MPI.Ocupacion
                        ,Pais = varDetalle_de_Datos_del_Testigo_MPI.Pais
                        ,Estado = varDetalle_de_Datos_del_Testigo_MPI.Estado
                        ,Municipio = varDetalle_de_Datos_del_Testigo_MPI.Municipio
                        ,Colonia = varDetalle_de_Datos_del_Testigo_MPI.Colonia
                        ,Codigo_Postal = varDetalle_de_Datos_del_Testigo_MPI.Codigo_Postal
                        ,Calle = varDetalle_de_Datos_del_Testigo_MPI.Calle
                        ,Numero_Exterior = varDetalle_de_Datos_del_Testigo_MPI.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Datos_del_Testigo_MPI.Numero_Interior
                        ,Telefono = varDetalle_de_Datos_del_Testigo_MPI.Telefono
                        ,Extencion = varDetalle_de_Datos_del_Testigo_MPI.Extencion
                        ,Celular = varDetalle_de_Datos_del_Testigo_MPI.Celular
                        ,Correo_Electronico = varDetalle_de_Datos_del_Testigo_MPI.Correo_Electronico
                        ,Incapaz = varDetalle_de_Datos_del_Testigo_MPI.Incapaz
                        ,Nombre_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Nombre_del_Tutor
                        ,Apellido_Paterno_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Apellido_Paterno_del_Tutor
                        ,Apellido_Materno_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Apellido_Materno_del_Tutor
                        ,Nombre_Completo_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Nombre_Completo_del_Tutor
                        ,Fecha_de_Nacimento_del_Tutor = (!String.IsNullOrEmpty(varDetalle_de_Datos_del_Testigo_MPI.Fecha_de_Nacimento_del_Tutor)) ? DateTime.ParseExact(varDetalle_de_Datos_del_Testigo_MPI.Fecha_de_Nacimento_del_Tutor, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Edad_del_Tutor
                        ,Sexo_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Sexo_del_Tutor
                        ,Estado_Civil_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Estado_Civil_del_Tutor
                        ,Tipo_de_Identificacion_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Tipo_de_Identificacion_del_Tutor
                        ,Numero_de_Identificacion_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Nacionalidad_del_Tutor
                        ,Escolaridad_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Escolaridad_del_Tutor
                        ,Ocupacion_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Ocupacion_del_Tutor
                        ,Pais_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Pais_del_Tutor
                        ,Estado_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Estado_del_Tutor
                        ,Municipio_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Municipio_del_Tutor
                        ,Colonia_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Colonia_del_Tutor
                        ,Codigo_Postal_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Codigo_Postal_del_Tutor
                        ,Calle_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Calle_del_Tutor
                        ,Numero_Exterior_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Numero_Exterior_del_Tutor
                        ,Numero_Interior_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Numero_Interior_del_Tutor
                        ,Telefono_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Telefono_del_Tutor
                        ,Extencion_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Extencion_del_Tutor
                        ,Celular_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Celular_del_Tutor
                        ,Correo_Electronico_del_Tutor = varDetalle_de_Datos_del_Testigo_MPI.Correo_Electronico_del_Tutor
                        ,Tipo_de_Compareciente = varDetalle_de_Datos_del_Testigo_MPI.Tipo_de_Compareciente
                        ,Narrativa_del_Testigo = varDetalle_de_Datos_del_Testigo_MPI.Narrativa_del_Testigo
                        ,Titulo_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Titulo_del_Hecho
                        ,Prioridad_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Prioridad_del_Hecho
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varDetalle_de_Datos_del_Testigo_MPI.Fecha_del_Hecho)) ? DateTime.ParseExact(varDetalle_de_Datos_del_Testigo_MPI.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Aproximada_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Hora_Aproximada_del_Hecho
                        ,Pais_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Pais_del_Hecho
                        ,Estado_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Estado_del_Hecho
                        ,Municipio_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Municipio_del_Hecho
                        ,Colonia_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Colonia_del_Hecho
                        ,Codigo_Postal_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Codigo_Postal_del_Hecho
                        ,Calle_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Calle_del_Hecho
                        ,Entre_Calle_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Entre_Calle_del_Hecho
                        ,Y_Calle_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Y_Calle_del_Hecho
                        ,Numero_Exterior_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Numero_Exterior_del_Hecho
                        ,Numero_Interior_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Numero_Interior_del_Hecho
                        ,Latitud_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Latitud_del_Hecho
                        ,Longitud_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Longitud_del_Hecho
                        ,Tipo_del_Lugar_del_Hecho = varDetalle_de_Datos_del_Testigo_MPI.Tipo_del_Lugar_del_Hecho
                        ,Proteccion_de_Datos = varDetalle_de_Datos_del_Testigo_MPI.Proteccion_de_Datos

                    };

                    result = !IsNew ?
                        _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.Update(Detalle_de_Datos_del_Testigo_MPIInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.Insert(Detalle_de_Datos_del_Testigo_MPIInfo, null, null).Resource.ToString();

                    return Json(result, JsonRequestBehavior.AllowGet);
				}
				return Json(false, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of Detalle_de_Datos_del_Testigo_MPI script
        /// </summary>
        /// <param name="oDetalle_de_Datos_del_Testigo_MPIElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_de_Datos_del_Testigo_MPIModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_de_Datos_del_Testigo_MPIScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_del_Testigo_MPI.js")))
            {
                strDetalle_de_Datos_del_Testigo_MPIScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Datos_del_Testigo_MPI element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Datos_del_Testigo_MPIScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Datos_del_Testigo_MPIScript.Substring(indexOfArray, strDetalle_de_Datos_del_Testigo_MPIScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Datos_del_Testigo_MPIScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_de_Datos_del_Testigo_MPIScript.Substring(indexOfArrayHistory, strDetalle_de_Datos_del_Testigo_MPIScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_de_Datos_del_Testigo_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Datos_del_Testigo_MPIScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Datos_del_Testigo_MPIScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_de_Datos_del_Testigo_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_de_Datos_del_Testigo_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_de_Datos_del_Testigo_MPIScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_de_Datos_del_Testigo_MPIScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_de_Datos_del_Testigo_MPIScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_del_Testigo_MPI.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_del_Testigo_MPI.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_del_Testigo_MPI.js")))
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
        public ActionResult Detalle_de_Datos_del_Testigo_MPIPropertyBag()
        {
            return PartialView("Detalle_de_Datos_del_Testigo_MPIPropertyBag", "Detalle_de_Datos_del_Testigo_MPI");
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
        public void Export(string format, int pageIndex, int pageSize)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);

            if (!_tokenManager.GenerateToken())
                return;

            _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Datos_del_Testigo_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Datos_del_Testigo_MPIs == null)
                result.Detalle_de_Datos_del_Testigo_MPIs = new List<Detalle_de_Datos_del_Testigo_MPI>();

            var data = result.Detalle_de_Datos_del_Testigo_MPIs.Select(m => new Detalle_de_Datos_del_Testigo_MPIGridModel
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
                ,Fecha_de_Nacimento_del_Tutor = (m.Fecha_de_Nacimento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
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
                ,Narrativa_del_Testigo = m.Narrativa_del_Testigo
                ,Titulo_del_Hecho = m.Titulo_del_Hecho
                ,Prioridad_del_HechoDescripcion = (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                ,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                ,Pais_del_HechoNombre = (string)m.Pais_del_Hecho_Pais.Nombre
                ,Estado_del_HechoNombre = (string)m.Estado_del_Hecho_Estado.Nombre
                ,Municipio_del_HechoNombre = (string)m.Municipio_del_Hecho_Municipio.Nombre
                ,Colonia_del_HechoNombre = (string)m.Colonia_del_Hecho_Colonia.Nombre
                ,Codigo_Postal_del_Hecho = m.Codigo_Postal_del_Hecho
                ,Calle_del_Hecho = m.Calle_del_Hecho
                ,Entre_Calle_del_Hecho = m.Entre_Calle_del_Hecho
                ,Y_Calle_del_Hecho = m.Y_Calle_del_Hecho
                ,Numero_Exterior_del_Hecho = m.Numero_Exterior_del_Hecho
                ,Numero_Interior_del_Hecho = m.Numero_Interior_del_Hecho
                ,Latitud_del_Hecho = m.Latitud_del_Hecho
                ,Longitud_del_Hecho = m.Longitud_del_Hecho
                ,Tipo_del_Lugar_del_HechoDescripcion = (string)m.Tipo_del_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                ,Proteccion_de_Datos = m.Proteccion_de_Datos

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_de_Datos_del_Testigo_MPIList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_de_Datos_del_Testigo_MPIList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Datos_del_Testigo_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Datos_del_Testigo_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Datos_del_Testigo_MPIs == null)
                result.Detalle_de_Datos_del_Testigo_MPIs = new List<Detalle_de_Datos_del_Testigo_MPI>();

            var data = result.Detalle_de_Datos_del_Testigo_MPIs.Select(m => new Detalle_de_Datos_del_Testigo_MPIGridModel
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
                ,Fecha_de_Nacimento_del_Tutor = (m.Fecha_de_Nacimento_del_Tutor == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
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
                ,Narrativa_del_Testigo = m.Narrativa_del_Testigo
                ,Titulo_del_Hecho = m.Titulo_del_Hecho
                ,Prioridad_del_HechoDescripcion = (string)m.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                ,Fecha_del_Hecho = (m.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                ,Hora_Aproximada_del_Hecho = m.Hora_Aproximada_del_Hecho
                ,Pais_del_HechoNombre = (string)m.Pais_del_Hecho_Pais.Nombre
                ,Estado_del_HechoNombre = (string)m.Estado_del_Hecho_Estado.Nombre
                ,Municipio_del_HechoNombre = (string)m.Municipio_del_Hecho_Municipio.Nombre
                ,Colonia_del_HechoNombre = (string)m.Colonia_del_Hecho_Colonia.Nombre
                ,Codigo_Postal_del_Hecho = m.Codigo_Postal_del_Hecho
                ,Calle_del_Hecho = m.Calle_del_Hecho
                ,Entre_Calle_del_Hecho = m.Entre_Calle_del_Hecho
                ,Y_Calle_del_Hecho = m.Y_Calle_del_Hecho
                ,Numero_Exterior_del_Hecho = m.Numero_Exterior_del_Hecho
                ,Numero_Interior_del_Hecho = m.Numero_Interior_del_Hecho
                ,Latitud_del_Hecho = m.Latitud_del_Hecho
                ,Longitud_del_Hecho = m.Longitud_del_Hecho
                ,Tipo_del_Lugar_del_HechoDescripcion = (string)m.Tipo_del_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                ,Proteccion_de_Datos = m.Proteccion_de_Datos

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
