using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Localidad;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Forma_Cara;
using Spartane.Core.Domain.Cejas;
using Spartane.Core.Domain.Cantidad_Cabello;
using Spartane.Core.Domain.Implantacion_Cabello;
using Spartane.Core.Domain.Complexion;
using Spartane.Core.Domain.Color_Piel;
using Spartane.Core.Domain.Frente;
using Spartane.Core.Domain.Forma_Cabello;
using Spartane.Core.Domain.Calvicie;
using Spartane.Core.Domain.Color_Ojos;
using Spartane.Core.Domain.Ojos;
using Spartane.Core.Domain.Froma_Ojos;
using Spartane.Core.Domain.Nariz_Base;
using Spartane.Core.Domain.Labios;
using Spartane.Core.Domain.Boca;
using Spartane.Core.Domain.Menton;
using Spartane.Core.Domain.Barba;
using Spartane.Core.Domain.Forma_Orejas;
using Spartane.Core.Domain.Forma_Orejas;
using Spartane.Core.Domain.Tipo_Lobulo;
using Spartane.Core.Domain.Bigote;
using Spartane.Core.Domain.Situacion_Fisica;
using Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI;
using Spartane.Core.Domain.Medidas_Cautelares;
using Spartane.Core.Domain.Medidas_Cautelares;
using Spartane.Core.Domain.Prioridad_del_Hecho;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Lugar_Tipo;
using Spartane.Core.Domain.Detalle_del_Abogado_Imputado_MPI;

using Spartane.Core.Domain.Abogado;





using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using Spartane.Core.Domain.Nacionalidad;

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
using Spartane.Core.Domain.Detalle_de_Sentencias_Imputado_MPI;

using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Sentencia;





using Spartane.Core.Domain.Estatus_del_Imputado;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Datos_del_Imputado_MPI;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_del_Imputado_MPI;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Localidad;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Forma_Cara;
using Spartane.Web.Areas.WebApiConsumer.Cejas;
using Spartane.Web.Areas.WebApiConsumer.Cantidad_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Implantacion_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Complexion;
using Spartane.Web.Areas.WebApiConsumer.Color_Piel;
using Spartane.Web.Areas.WebApiConsumer.Frente;
using Spartane.Web.Areas.WebApiConsumer.Forma_Cabello;
using Spartane.Web.Areas.WebApiConsumer.Calvicie;
using Spartane.Web.Areas.WebApiConsumer.Color_Ojos;
using Spartane.Web.Areas.WebApiConsumer.Ojos;
using Spartane.Web.Areas.WebApiConsumer.Froma_Ojos;
using Spartane.Web.Areas.WebApiConsumer.Nariz_Base;
using Spartane.Web.Areas.WebApiConsumer.Labios;
using Spartane.Web.Areas.WebApiConsumer.Boca;
using Spartane.Web.Areas.WebApiConsumer.Menton;
using Spartane.Web.Areas.WebApiConsumer.Barba;
using Spartane.Web.Areas.WebApiConsumer.Forma_Orejas;
using Spartane.Web.Areas.WebApiConsumer.Forma_Orejas;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Lobulo;
using Spartane.Web.Areas.WebApiConsumer.Bigote;
using Spartane.Web.Areas.WebApiConsumer.Situacion_Fisica;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Estatus_Detenido_MPI;
using Spartane.Web.Areas.WebApiConsumer.Medidas_Cautelares;
using Spartane.Web.Areas.WebApiConsumer.Medidas_Cautelares;
using Spartane.Web.Areas.WebApiConsumer.Prioridad_del_Hecho;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Lugar_Tipo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_del_Abogado_Imputado_MPI;

using Spartane.Web.Areas.WebApiConsumer.Abogado;

using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
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
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Sentencias_Imputado_MPI;

using Spartane.Web.Areas.WebApiConsumer.Delito;
using Spartane.Web.Areas.WebApiConsumer.Sentencia;




using Spartane.Web.Areas.WebApiConsumer.Estatus_del_Imputado;

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
    public class Detalle_de_Datos_del_Imputado_MPIController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Datos_del_Imputado_MPIService service = null;
        private IDetalle_de_Datos_del_Imputado_MPIApiConsumer _IDetalle_de_Datos_del_Imputado_MPIApiConsumer;
        private IGeneroApiConsumer _IGeneroApiConsumer;
        private IEstado_CivilApiConsumer _IEstado_CivilApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private INacionalidadApiConsumer _INacionalidadApiConsumer;
        private IEscolaridadApiConsumer _IEscolaridadApiConsumer;
        private IOcupacionApiConsumer _IOcupacionApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private ILocalidadApiConsumer _ILocalidadApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IForma_CaraApiConsumer _IForma_CaraApiConsumer;
        private ICejasApiConsumer _ICejasApiConsumer;
        private ICantidad_CabelloApiConsumer _ICantidad_CabelloApiConsumer;
        private IImplantacion_CabelloApiConsumer _IImplantacion_CabelloApiConsumer;
        private IComplexionApiConsumer _IComplexionApiConsumer;
        private IColor_PielApiConsumer _IColor_PielApiConsumer;
        private IFrenteApiConsumer _IFrenteApiConsumer;
        private IForma_CabelloApiConsumer _IForma_CabelloApiConsumer;
        private ICalvicieApiConsumer _ICalvicieApiConsumer;
        private IColor_OjosApiConsumer _IColor_OjosApiConsumer;
        private IOjosApiConsumer _IOjosApiConsumer;
        private IFroma_OjosApiConsumer _IFroma_OjosApiConsumer;
        private INariz_BaseApiConsumer _INariz_BaseApiConsumer;
        private ILabiosApiConsumer _ILabiosApiConsumer;
        private IBocaApiConsumer _IBocaApiConsumer;
        private IMentonApiConsumer _IMentonApiConsumer;
        private IBarbaApiConsumer _IBarbaApiConsumer;
        private IForma_OrejasApiConsumer _IForma_OrejasApiConsumer;
        private ITipo_LobuloApiConsumer _ITipo_LobuloApiConsumer;
        private IBigoteApiConsumer _IBigoteApiConsumer;
        private ISituacion_FisicaApiConsumer _ISituacion_FisicaApiConsumer;
        private ICatalogo_Estatus_Detenido_MPIApiConsumer _ICatalogo_Estatus_Detenido_MPIApiConsumer;
        private IMedidas_CautelaresApiConsumer _IMedidas_CautelaresApiConsumer;
        private IPrioridad_del_HechoApiConsumer _IPrioridad_del_HechoApiConsumer;
        private ILugar_TipoApiConsumer _ILugar_TipoApiConsumer;
        private IDetalle_del_Abogado_Imputado_MPIApiConsumer _IDetalle_del_Abogado_Imputado_MPIApiConsumer;

        private IAbogadoApiConsumer _IAbogadoApiConsumer;



        private IDetalle_de_Sentencias_Imputado_MPIApiConsumer _IDetalle_de_Sentencias_Imputado_MPIApiConsumer;

        private IDelitoApiConsumer _IDelitoApiConsumer;
        private ISentenciaApiConsumer _ISentenciaApiConsumer;




        private IEstatus_del_ImputadoApiConsumer _IEstatus_del_ImputadoApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_de_Datos_del_Imputado_MPIController(IDetalle_de_Datos_del_Imputado_MPIService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Datos_del_Imputado_MPIApiConsumer Detalle_de_Datos_del_Imputado_MPIApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IEscolaridadApiConsumer EscolaridadApiConsumer , IOcupacionApiConsumer OcupacionApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , ILocalidadApiConsumer LocalidadApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IPaisApiConsumer PaisApiConsumer , IForma_CaraApiConsumer Forma_CaraApiConsumer , ICejasApiConsumer CejasApiConsumer , ICantidad_CabelloApiConsumer Cantidad_CabelloApiConsumer , IImplantacion_CabelloApiConsumer Implantacion_CabelloApiConsumer , IComplexionApiConsumer ComplexionApiConsumer , IColor_PielApiConsumer Color_PielApiConsumer , IFrenteApiConsumer FrenteApiConsumer , IForma_CabelloApiConsumer Forma_CabelloApiConsumer , ICalvicieApiConsumer CalvicieApiConsumer , IColor_OjosApiConsumer Color_OjosApiConsumer , IOjosApiConsumer OjosApiConsumer , IFroma_OjosApiConsumer Froma_OjosApiConsumer , INariz_BaseApiConsumer Nariz_BaseApiConsumer , ILabiosApiConsumer LabiosApiConsumer , IBocaApiConsumer BocaApiConsumer , IMentonApiConsumer MentonApiConsumer , IBarbaApiConsumer BarbaApiConsumer , IForma_OrejasApiConsumer Forma_OrejasApiConsumer , ITipo_LobuloApiConsumer Tipo_LobuloApiConsumer , IBigoteApiConsumer BigoteApiConsumer , ISituacion_FisicaApiConsumer Situacion_FisicaApiConsumer , ICatalogo_Estatus_Detenido_MPIApiConsumer Catalogo_Estatus_Detenido_MPIApiConsumer , IMedidas_CautelaresApiConsumer Medidas_CautelaresApiConsumer , IPrioridad_del_HechoApiConsumer Prioridad_del_HechoApiConsumer , ILugar_TipoApiConsumer Lugar_TipoApiConsumer , IDetalle_del_Abogado_Imputado_MPIApiConsumer Detalle_del_Abogado_Imputado_MPIApiConsumer , IAbogadoApiConsumer AbogadoApiConsumer  , IDetalle_de_Sentencias_Imputado_MPIApiConsumer Detalle_de_Sentencias_Imputado_MPIApiConsumer , IDelitoApiConsumer DelitoApiConsumer , ISentenciaApiConsumer SentenciaApiConsumer  , IEstatus_del_ImputadoApiConsumer Estatus_del_ImputadoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Datos_del_Imputado_MPIApiConsumer = Detalle_de_Datos_del_Imputado_MPIApiConsumer;
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
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._ILocalidadApiConsumer = LocalidadApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IForma_CaraApiConsumer = Forma_CaraApiConsumer;
            this._ICejasApiConsumer = CejasApiConsumer;
            this._ICantidad_CabelloApiConsumer = Cantidad_CabelloApiConsumer;
            this._IImplantacion_CabelloApiConsumer = Implantacion_CabelloApiConsumer;
            this._IComplexionApiConsumer = ComplexionApiConsumer;
            this._IColor_PielApiConsumer = Color_PielApiConsumer;
            this._IFrenteApiConsumer = FrenteApiConsumer;
            this._IForma_CabelloApiConsumer = Forma_CabelloApiConsumer;
            this._ICalvicieApiConsumer = CalvicieApiConsumer;
            this._IColor_OjosApiConsumer = Color_OjosApiConsumer;
            this._IOjosApiConsumer = OjosApiConsumer;
            this._IFroma_OjosApiConsumer = Froma_OjosApiConsumer;
            this._INariz_BaseApiConsumer = Nariz_BaseApiConsumer;
            this._ILabiosApiConsumer = LabiosApiConsumer;
            this._IBocaApiConsumer = BocaApiConsumer;
            this._IMentonApiConsumer = MentonApiConsumer;
            this._IBarbaApiConsumer = BarbaApiConsumer;
            this._IForma_OrejasApiConsumer = Forma_OrejasApiConsumer;
            this._IForma_OrejasApiConsumer = Forma_OrejasApiConsumer;
            this._ITipo_LobuloApiConsumer = Tipo_LobuloApiConsumer;
            this._IBigoteApiConsumer = BigoteApiConsumer;
            this._ISituacion_FisicaApiConsumer = Situacion_FisicaApiConsumer;
            this._ICatalogo_Estatus_Detenido_MPIApiConsumer = Catalogo_Estatus_Detenido_MPIApiConsumer;
            this._IMedidas_CautelaresApiConsumer = Medidas_CautelaresApiConsumer;
            this._IMedidas_CautelaresApiConsumer = Medidas_CautelaresApiConsumer;
            this._IPrioridad_del_HechoApiConsumer = Prioridad_del_HechoApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ILugar_TipoApiConsumer = Lugar_TipoApiConsumer;
            this._IDetalle_del_Abogado_Imputado_MPIApiConsumer = Detalle_del_Abogado_Imputado_MPIApiConsumer;

            this._IAbogadoApiConsumer = AbogadoApiConsumer;

            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
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
            this._IDetalle_de_Sentencias_Imputado_MPIApiConsumer = Detalle_de_Sentencias_Imputado_MPIApiConsumer;

            this._IDelitoApiConsumer = DelitoApiConsumer;
            this._ISentenciaApiConsumer = SentenciaApiConsumer;




            this._IEstatus_del_ImputadoApiConsumer = Estatus_del_ImputadoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Datos_del_Imputado_MPI
        [ObjectAuth(ObjectId = (ModuleObjectId)45123, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45123);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_de_Datos_del_Imputado_MPI/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45123, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45123);
            ViewBag.Permission = permission;
            var varDetalle_de_Datos_del_Imputado_MPI = new Detalle_de_Datos_del_Imputado_MPIModel();
			
            ViewBag.ObjectId = "45123";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_del_Abogado_Imputado_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45150, ModuleId);
            ViewBag.PermissionDetalle_del_Abogado_Imputado_MPI = permissionDetalle_del_Abogado_Imputado_MPI;
            var permissionDetalle_de_Sentencias_Imputado_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45180, ModuleId);
            ViewBag.PermissionDetalle_de_Sentencias_Imputado_MPI = permissionDetalle_de_Sentencias_Imputado_MPI;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Datos_del_Imputado_MPIData = _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.GetByKeyComplete(Id).Resource.Detalle_de_Datos_del_Imputado_MPIs[0];
                if (Detalle_de_Datos_del_Imputado_MPIData == null)
                    return HttpNotFound();

                varDetalle_de_Datos_del_Imputado_MPI = new Detalle_de_Datos_del_Imputado_MPIModel
                {
                    Clave = (int)Detalle_de_Datos_del_Imputado_MPIData.Clave
                    ,Nombre = Detalle_de_Datos_del_Imputado_MPIData.Nombre
                    ,Apellido_Paterno = Detalle_de_Datos_del_Imputado_MPIData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Datos_del_Imputado_MPIData.Apellido_Materno
                    ,Fecha_de_Nacimiento = (Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Detalle_de_Datos_del_Imputado_MPIData.Edad
                    ,Sexo = Detalle_de_Datos_del_Imputado_MPIData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Sexo), "Genero") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Detalle_de_Datos_del_Imputado_MPIData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Estado_Civil), "Estado_Civil") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Detalle_de_Datos_del_Imputado_MPIData.Numero_de_Identificacion
                    ,Nacionalidad = Detalle_de_Datos_del_Imputado_MPIData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = Detalle_de_Datos_del_Imputado_MPIData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Escolaridad), "Escolaridad") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Detalle_de_Datos_del_Imputado_MPIData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Ocupacion), "Ocupacion") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Ocupacion_Ocupacion.Descripcion
                    ,Estado = Detalle_de_Datos_del_Imputado_MPIData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Estado), "Estado") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Datos_del_Imputado_MPIData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Municipio), "Municipio") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Municipio_Municipio.Nombre
                    ,Codigo_Postal = Detalle_de_Datos_del_Imputado_MPIData.Codigo_Postal
                    ,Localidad = Detalle_de_Datos_del_Imputado_MPIData.Localidad
                    ,LocalidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Localidad), "Localidad") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Localidad_Localidad.Descripcion
                    ,Colonia = Detalle_de_Datos_del_Imputado_MPIData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Colonia), "Colonia") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Colonia_Colonia.Nombre
                    ,Calle_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData.Calle_del_Imputado
                    ,Numero_Exterior = Detalle_de_Datos_del_Imputado_MPIData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Datos_del_Imputado_MPIData.Numero_Interior
                    ,Telefono = Detalle_de_Datos_del_Imputado_MPIData.Telefono
                    ,Extencion = Detalle_de_Datos_del_Imputado_MPIData.Extencion
                    ,Celular = Detalle_de_Datos_del_Imputado_MPIData.Celular
                    ,Correo_Electronico = Detalle_de_Datos_del_Imputado_MPIData.Correo_Electronico
                    ,Pais = Detalle_de_Datos_del_Imputado_MPIData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Pais), "Pais") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Pais_Pais.Nombre
                    ,Forma_Cara = Detalle_de_Datos_del_Imputado_MPIData.Forma_Cara
                    ,Forma_CaraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Forma_Cara), "Forma_Cara") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Forma_Cara_Forma_Cara.Descripcion
                    ,Cejas = Detalle_de_Datos_del_Imputado_MPIData.Cejas
                    ,CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Cejas), "Cejas") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Cejas_Cejas.Descripcion
                    ,Cantidad_Cabello = Detalle_de_Datos_del_Imputado_MPIData.Cantidad_Cabello
                    ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Cantidad_Cabello), "Cantidad_Cabello") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                    ,Implantacion_Cabello = Detalle_de_Datos_del_Imputado_MPIData.Implantacion_Cabello
                    ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Implantacion_Cabello), "Implantacion_Cabello") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                    ,Complexion = Detalle_de_Datos_del_Imputado_MPIData.Complexion
                    ,ComplexionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Complexion), "Complexion") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Complexion_Complexion.Descripcion
                    ,Color_Piel = Detalle_de_Datos_del_Imputado_MPIData.Color_Piel
                    ,Color_PielDescrpicion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Color_Piel), "Color_Piel") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Color_Piel_Color_Piel.Descrpicion
                    ,Frente = Detalle_de_Datos_del_Imputado_MPIData.Frente
                    ,FrenteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Frente), "Frente") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Frente_Frente.Descripcion
                    ,Forma_Cabello = Detalle_de_Datos_del_Imputado_MPIData.Forma_Cabello
                    ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Forma_Cabello), "Forma_Cabello") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Forma_Cabello_Forma_Cabello.Descripcion
                    ,Calvicie = Detalle_de_Datos_del_Imputado_MPIData.Calvicie
                    ,CalvicieDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Calvicie), "Calvicie") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Calvicie_Calvicie.Descripcion
                    ,Color_Ojos = Detalle_de_Datos_del_Imputado_MPIData.Color_Ojos
                    ,Color_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Color_Ojos), "Color_Ojos") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Color_Ojos_Color_Ojos.Descripcion
                    ,Ojos = Detalle_de_Datos_del_Imputado_MPIData.Ojos
                    ,OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Ojos), "Ojos") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Ojos_Ojos.Descripcion
                    ,Forma_Ojos = Detalle_de_Datos_del_Imputado_MPIData.Forma_Ojos
                    ,Forma_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Forma_Ojos), "Froma_Ojos") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Forma_Ojos_Froma_Ojos.Descripcion
                    ,Nariz_Base = Detalle_de_Datos_del_Imputado_MPIData.Nariz_Base
                    ,Nariz_BaseDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Nariz_Base), "Nariz_Base") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Nariz_Base_Nariz_Base.Descripcion
                    ,Labios = Detalle_de_Datos_del_Imputado_MPIData.Labios
                    ,LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Labios), "Labios") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Labios_Labios.Descripcion
                    ,Boca = Detalle_de_Datos_del_Imputado_MPIData.Boca
                    ,BocaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Boca), "Boca") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Boca_Boca.Descripcion
                    ,Menton = Detalle_de_Datos_del_Imputado_MPIData.Menton
                    ,MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Menton), "Menton") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Menton_Menton.Descripcion
                    ,Barba = Detalle_de_Datos_del_Imputado_MPIData.Barba
                    ,BarbaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Barba), "Barba") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Barba_Barba.Descripcion
                    ,Forma_Orejas = Detalle_de_Datos_del_Imputado_MPIData.Forma_Orejas
                    ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Forma_Orejas), "Forma_Orejas") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Forma_Orejas_Forma_Orejas.Descripcion
                    ,Tamano_Orejas = Detalle_de_Datos_del_Imputado_MPIData.Tamano_Orejas
                    ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Tamano_Orejas), "Forma_Orejas") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Tamano_Orejas_Forma_Orejas.Descripcion
                    ,Tipo_Lobulo = Detalle_de_Datos_del_Imputado_MPIData.Tipo_Lobulo
                    ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Tipo_Lobulo), "Tipo_Lobulo") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                    ,Bigote = Detalle_de_Datos_del_Imputado_MPIData.Bigote
                    ,BigoteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Bigote), "Bigote") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Bigote_Bigote.Descripcion
                    ,Situacion_Fisica = Detalle_de_Datos_del_Imputado_MPIData.Situacion_Fisica
                    ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Situacion_Fisica), "Situacion_Fisica") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Situacion_Fisica_Situacion_Fisica.Descripcion
                    ,Alias_media_diliacion = Detalle_de_Datos_del_Imputado_MPIData.Alias_media_diliacion
                    ,Fecha_de_Detencion = (Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Detencion = Detalle_de_Datos_del_Imputado_MPIData.Hora_de_Detencion
                    ,Fecha_de_Puesto_a_Disposicion = (Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Puesto_a_Disposicion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Puesto_a_Disposicion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Puesto_a_Disposicion = Detalle_de_Datos_del_Imputado_MPIData.Hora_de_Puesto_a_Disposicion
                    ,Con_Detenido = Detalle_de_Datos_del_Imputado_MPIData.Con_Detenido
                    ,Con_DetenidoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Con_Detenido), "Catalogo_Estatus_Detenido_MPI") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Con_Detenido_Catalogo_Estatus_Detenido_MPI.Descripcion
                    ,A_Quien_Resulte_Responsable = Detalle_de_Datos_del_Imputado_MPIData.A_Quien_Resulte_Responsable.GetValueOrDefault()
                    ,Tiempo_Restante_para_Vinculacion = Detalle_de_Datos_del_Imputado_MPIData.Tiempo_Restante_para_Vinculacion
                    ,Vincular = Detalle_de_Datos_del_Imputado_MPIData.Vincular.GetValueOrDefault()
                    ,Medidas_Cautelares = Detalle_de_Datos_del_Imputado_MPIData.Medidas_Cautelares
                    ,Medidas_CautelaresDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Medidas_Cautelares), "Medidas_Cautelares") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Medidas_Cautelares_Medidas_Cautelares.Descripcion
                    ,Solicitar_Prorroga = Detalle_de_Datos_del_Imputado_MPIData.Solicitar_Prorroga
                    ,Nuevo_Plazo = Detalle_de_Datos_del_Imputado_MPIData.Nuevo_Plazo
                    ,Orden_de_Aprehension = Detalle_de_Datos_del_Imputado_MPIData.Orden_de_Aprehension.GetValueOrDefault()
                    ,Medidas_Cautelares_en_Imputado = Detalle_de_Datos_del_Imputado_MPIData.Medidas_Cautelares_en_Imputado
                    ,Medidas_Cautelares_en_ImputadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Medidas_Cautelares_en_Imputado), "Medidas_Cautelares") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Medidas_Cautelares_en_Imputado_Medidas_Cautelares.Descripcion
                    ,Titulo_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Titulo_del_Hecho
                    ,Narrativa_Breve_de_los_Hechos = Detalle_de_Datos_del_Imputado_MPIData.Narrativa_Breve_de_los_Hechos
                    ,Prioridad_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Prioridad_del_Hecho
                    ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Prioridad_del_Hecho), "Prioridad_del_Hecho") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                    ,Fecha_del_Hecho = (Detalle_de_Datos_del_Imputado_MPIData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Imputado_MPIData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Aproximada_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Hora_Aproximada_del_Hecho
                    ,Pais_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Pais_del_Hecho
                    ,Pais_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Pais_del_Hecho), "Pais") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Pais_del_Hecho_Pais.Nombre
                    ,Estado_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Estado_del_Hecho
                    ,Estado_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Estado_del_Hecho), "Estado") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Estado_del_Hecho_Estado.Nombre
                    ,Municipio_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Municipio_del_Hecho
                    ,Municipio_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Municipio_del_Hecho), "Municipio") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Municipio_del_Hecho_Municipio.Nombre
                    ,Colonia_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Colonia_del_Hecho
                    ,Colonia_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Colonia_del_Hecho), "Colonia") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Colonia_del_Hecho_Colonia.Nombre
                    ,Codigo_Postal_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Codigo_Postal_del_Hecho
                    ,Calle_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Calle_del_Hecho
                    ,Entre_Calle_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Entre_Calle_del_Hecho
                    ,Y_Calle_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Y_Calle_del_Hecho
                    ,Numero_Exterior_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Numero_Exterior_del_Hecho
                    ,Numero_Interior_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Numero_Interior_del_Hecho
                    ,Latitud_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Latitud_del_Hecho
                    ,Longitud_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Longitud_del_Hecho
                    ,Tipo_de_Lugar_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Lugar_del_Hecho
                    ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,Incapaz = Detalle_de_Datos_del_Imputado_MPIData.Incapaz.GetValueOrDefault()
                    ,Nombre_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Nombre_del_Tutor
                    ,Apellido_Paterno_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Apellido_Paterno_del_Tutor
                    ,Apellido_Materno_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Apellido_Materno_del_Tutor
                    ,Fecha_de_Nacimiento_del_Tutor = (Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Edad_del_Tutor
                    ,Sexo_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Sexo_del_Tutor
                    ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Sexo_del_Tutor), "Genero") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Sexo_del_Tutor_Genero.Descripcion
                    ,Estado_Civil_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Estado_Civil_del_Tutor
                    ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Estado_Civil_del_Tutor), "Estado_Civil") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Identificacion_del_Tutor
                    ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Identificacion_del_Tutor), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Numero_de_Identificacion_del_Tutor
                    ,Nacionalidad_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Nacionalidad_del_Tutor
                    ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Nacionalidad_del_Tutor), "Nacionalidad") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                    ,Escolaridad_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Escolaridad_del_Tutor
                    ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Escolaridad_del_Tutor), "Escolaridad") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Escolaridad_del_Tutor_Escolaridad.Descripcion
                    ,Ocupacion_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Ocupacion_del_Tutor
                    ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Ocupacion_del_Tutor), "Ocupacion") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Ocupacion_del_Tutor_Ocupacion.Descripcion
                    ,Pais_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Pais_del_Tutor
                    ,Pais_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Pais_del_Tutor), "Pais") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Pais_del_Tutor_Pais.Nombre
                    ,Estado_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Estado_del_Tutor
                    ,Estado_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Estado_del_Tutor), "Estado") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Estado_del_Tutor_Estado.Nombre
                    ,Municipio_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Municipio_del_Tutor
                    ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Municipio_del_Tutor), "Municipio") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Municipio_del_Tutor_Municipio.Nombre
                    ,Colonia_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Colonia_del_Tutor
                    ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Colonia_del_Tutor), "Colonia") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Colonia_del_Tutor_Colonia.Nombre
                    ,Codigo_Postal_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Codigo_Postal_del_Tutor
                    ,Calle_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Calle_del_Tutor
                    ,Numero_Exterior_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Numero_Exterior_del_Tutor
                    ,Numero_Interior_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Numero_Interior_del_Tutor
                    ,Telefono_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Telefono_del_Tutor
                    ,Extension_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Extension_del_Tutor
                    ,Celular_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Celular_del_Tutor
                    ,Correo_Electronico_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Correo_Electronico_del_Tutor
                    ,Proteccion_de_Datos = Detalle_de_Datos_del_Imputado_MPIData.Proteccion_de_Datos.GetValueOrDefault()
                    ,Estatus = Detalle_de_Datos_del_Imputado_MPIData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Estatus), "Estatus_del_Imputado") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Estatus_Estatus_del_Imputado.Descripcion
                    ,Judicializar = Detalle_de_Datos_del_Imputado_MPIData.Judicializar.GetValueOrDefault()

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
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad != null && Localidads_Localidad.Resource != null)
                ViewBag.Localidads_Localidad = Localidads_Localidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia != null && Colonias_Colonia.Resource != null)
                ViewBag.Colonias_Colonia = Colonias_Colonia.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais != null && Paiss_Pais.Resource != null)
                ViewBag.Paiss_Pais = Paiss_Pais.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CaraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Caras_Forma_Cara = _IForma_CaraApiConsumer.SelAll(true);
            if (Forma_Caras_Forma_Cara != null && Forma_Caras_Forma_Cara.Resource != null)
                ViewBag.Forma_Caras_Forma_Cara = Forma_Caras_Forma_Cara.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cara", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cejass_Cejas = _ICejasApiConsumer.SelAll(true);
            if (Cejass_Cejas != null && Cejass_Cejas.Resource != null)
                ViewBag.Cejass_Cejas = Cejass_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICantidad_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cantidad_Cabellos_Cantidad_Cabello = _ICantidad_CabelloApiConsumer.SelAll(true);
            if (Cantidad_Cabellos_Cantidad_Cabello != null && Cantidad_Cabellos_Cantidad_Cabello.Resource != null)
                ViewBag.Cantidad_Cabellos_Cantidad_Cabello = Cantidad_Cabellos_Cantidad_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cantidad_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IImplantacion_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Implantacion_Cabellos_Implantacion_Cabello = _IImplantacion_CabelloApiConsumer.SelAll(true);
            if (Implantacion_Cabellos_Implantacion_Cabello != null && Implantacion_Cabellos_Implantacion_Cabello.Resource != null)
                ViewBag.Implantacion_Cabellos_Implantacion_Cabello = Implantacion_Cabellos_Implantacion_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Implantacion_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IComplexionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Complexions_Complexion = _IComplexionApiConsumer.SelAll(true);
            if (Complexions_Complexion != null && Complexions_Complexion.Resource != null)
                ViewBag.Complexions_Complexion = Complexions_Complexion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Complexion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_PielApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Piels_Color_Piel = _IColor_PielApiConsumer.SelAll(true);
            if (Color_Piels_Color_Piel != null && Color_Piels_Color_Piel.Resource != null)
                ViewBag.Color_Piels_Color_Piel = Color_Piels_Color_Piel.Resource.Where(m => m.Descrpicion != null).OrderBy(m => m.Descrpicion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Piel", "Descrpicion") ?? m.Descrpicion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFrenteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Frentes_Frente = _IFrenteApiConsumer.SelAll(true);
            if (Frentes_Frente != null && Frentes_Frente.Resource != null)
                ViewBag.Frentes_Frente = Frentes_Frente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Frente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Cabellos_Forma_Cabello = _IForma_CabelloApiConsumer.SelAll(true);
            if (Forma_Cabellos_Forma_Cabello != null && Forma_Cabellos_Forma_Cabello.Resource != null)
                ViewBag.Forma_Cabellos_Forma_Cabello = Forma_Cabellos_Forma_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICalvicieApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Calvicies_Calvicie = _ICalvicieApiConsumer.SelAll(true);
            if (Calvicies_Calvicie != null && Calvicies_Calvicie.Resource != null)
                ViewBag.Calvicies_Calvicie = Calvicies_Calvicie.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calvicie", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Ojoss_Color_Ojos = _IColor_OjosApiConsumer.SelAll(true);
            if (Color_Ojoss_Color_Ojos != null && Color_Ojoss_Color_Ojos.Resource != null)
                ViewBag.Color_Ojoss_Color_Ojos = Color_Ojoss_Color_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ojoss_Ojos = _IOjosApiConsumer.SelAll(true);
            if (Ojoss_Ojos != null && Ojoss_Ojos.Resource != null)
                ViewBag.Ojoss_Ojos = Ojoss_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFroma_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Froma_Ojoss_Forma_Ojos = _IFroma_OjosApiConsumer.SelAll(true);
            if (Froma_Ojoss_Forma_Ojos != null && Froma_Ojoss_Forma_Ojos.Resource != null)
                ViewBag.Froma_Ojoss_Forma_Ojos = Froma_Ojoss_Forma_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Froma_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INariz_BaseApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nariz_Bases_Nariz_Base = _INariz_BaseApiConsumer.SelAll(true);
            if (Nariz_Bases_Nariz_Base != null && Nariz_Bases_Nariz_Base.Resource != null)
                ViewBag.Nariz_Bases_Nariz_Base = Nariz_Bases_Nariz_Base.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nariz_Base", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Labioss_Labios = _ILabiosApiConsumer.SelAll(true);
            if (Labioss_Labios != null && Labioss_Labios.Resource != null)
                ViewBag.Labioss_Labios = Labioss_Labios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Labios", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBocaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Bocas_Boca = _IBocaApiConsumer.SelAll(true);
            if (Bocas_Boca != null && Bocas_Boca.Resource != null)
                ViewBag.Bocas_Boca = Bocas_Boca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Boca", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Mentons_Menton = _IMentonApiConsumer.SelAll(true);
            if (Mentons_Menton != null && Mentons_Menton.Resource != null)
                ViewBag.Mentons_Menton = Mentons_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBarbaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Barbas_Barba = _IBarbaApiConsumer.SelAll(true);
            if (Barbas_Barba != null && Barbas_Barba.Resource != null)
                ViewBag.Barbas_Barba = Barbas_Barba.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Barba", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Orejass_Forma_Orejas = _IForma_OrejasApiConsumer.SelAll(true);
            if (Forma_Orejass_Forma_Orejas != null && Forma_Orejass_Forma_Orejas.Resource != null)
                ViewBag.Forma_Orejass_Forma_Orejas = Forma_Orejass_Forma_Orejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Orejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Orejass_Tamano_Orejas = _IForma_OrejasApiConsumer.SelAll(true);
            if (Forma_Orejass_Tamano_Orejas != null && Forma_Orejass_Tamano_Orejas.Resource != null)
                ViewBag.Forma_Orejass_Tamano_Orejas = Forma_Orejass_Tamano_Orejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Orejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_LobuloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Lobulos_Tipo_Lobulo = _ITipo_LobuloApiConsumer.SelAll(true);
            if (Tipo_Lobulos_Tipo_Lobulo != null && Tipo_Lobulos_Tipo_Lobulo.Resource != null)
                ViewBag.Tipo_Lobulos_Tipo_Lobulo = Tipo_Lobulos_Tipo_Lobulo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Lobulo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBigoteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Bigotes_Bigote = _IBigoteApiConsumer.SelAll(true);
            if (Bigotes_Bigote != null && Bigotes_Bigote.Resource != null)
                ViewBag.Bigotes_Bigote = Bigotes_Bigote.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Bigote", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISituacion_FisicaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Situacion_Fisicas_Situacion_Fisica = _ISituacion_FisicaApiConsumer.SelAll(true);
            if (Situacion_Fisicas_Situacion_Fisica != null && Situacion_Fisicas_Situacion_Fisica.Resource != null)
                ViewBag.Situacion_Fisicas_Situacion_Fisica = Situacion_Fisicas_Situacion_Fisica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Situacion_Fisica", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Estatus_Detenido_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Estatus_Detenido_MPIs_Con_Detenido = _ICatalogo_Estatus_Detenido_MPIApiConsumer.SelAll(true);
            if (Catalogo_Estatus_Detenido_MPIs_Con_Detenido != null && Catalogo_Estatus_Detenido_MPIs_Con_Detenido.Resource != null)
                ViewBag.Catalogo_Estatus_Detenido_MPIs_Con_Detenido = Catalogo_Estatus_Detenido_MPIs_Con_Detenido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Estatus_Detenido_MPI", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMedidas_CautelaresApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Medidas_Cautelaress_Medidas_Cautelares = _IMedidas_CautelaresApiConsumer.SelAll(true);
            if (Medidas_Cautelaress_Medidas_Cautelares != null && Medidas_Cautelaress_Medidas_Cautelares.Resource != null)
                ViewBag.Medidas_Cautelaress_Medidas_Cautelares = Medidas_Cautelaress_Medidas_Cautelares.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Medidas_Cautelares", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMedidas_CautelaresApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Medidas_Cautelaress_Medidas_Cautelares_en_Imputado = _IMedidas_CautelaresApiConsumer.SelAll(true);
            if (Medidas_Cautelaress_Medidas_Cautelares_en_Imputado != null && Medidas_Cautelaress_Medidas_Cautelares_en_Imputado.Resource != null)
                ViewBag.Medidas_Cautelaress_Medidas_Cautelares_en_Imputado = Medidas_Cautelaress_Medidas_Cautelares_en_Imputado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Medidas_Cautelares", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IEstatus_del_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_del_Imputados_Estatus = _IEstatus_del_ImputadoApiConsumer.SelAll(true);
            if (Estatus_del_Imputados_Estatus != null && Estatus_del_Imputados_Estatus.Resource != null)
                ViewBag.Estatus_del_Imputados_Estatus = Estatus_del_Imputados_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_del_Imputado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_de_Datos_del_Imputado_MPI);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Datos_del_Imputado_MPI(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45123);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Datos_del_Imputado_MPIModel varDetalle_de_Datos_del_Imputado_MPI= new Detalle_de_Datos_del_Imputado_MPIModel();
            var permissionDetalle_del_Abogado_Imputado_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45150, ModuleId);
            ViewBag.PermissionDetalle_del_Abogado_Imputado_MPI = permissionDetalle_del_Abogado_Imputado_MPI;
            var permissionDetalle_de_Sentencias_Imputado_MPI = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45180, ModuleId);
            ViewBag.PermissionDetalle_de_Sentencias_Imputado_MPI = permissionDetalle_de_Sentencias_Imputado_MPI;


            if (id.ToString() != "0")
            {
                var Detalle_de_Datos_del_Imputado_MPIsData = _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Datos_del_Imputado_MPI.Clave=" + id, "").Resource.Detalle_de_Datos_del_Imputado_MPIs;
				
				if (Detalle_de_Datos_del_Imputado_MPIsData != null && Detalle_de_Datos_del_Imputado_MPIsData.Count > 0)
                {
					var Detalle_de_Datos_del_Imputado_MPIData = Detalle_de_Datos_del_Imputado_MPIsData.First();
					varDetalle_de_Datos_del_Imputado_MPI= new Detalle_de_Datos_del_Imputado_MPIModel
					{
						Clave  = Detalle_de_Datos_del_Imputado_MPIData.Clave 
	                    ,Nombre = Detalle_de_Datos_del_Imputado_MPIData.Nombre
                    ,Apellido_Paterno = Detalle_de_Datos_del_Imputado_MPIData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Datos_del_Imputado_MPIData.Apellido_Materno
                    ,Fecha_de_Nacimiento = (Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Detalle_de_Datos_del_Imputado_MPIData.Edad
                    ,Sexo = Detalle_de_Datos_del_Imputado_MPIData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Sexo), "Genero") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Detalle_de_Datos_del_Imputado_MPIData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Estado_Civil), "Estado_Civil") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Detalle_de_Datos_del_Imputado_MPIData.Numero_de_Identificacion
                    ,Nacionalidad = Detalle_de_Datos_del_Imputado_MPIData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Escolaridad = Detalle_de_Datos_del_Imputado_MPIData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Escolaridad), "Escolaridad") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Detalle_de_Datos_del_Imputado_MPIData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Ocupacion), "Ocupacion") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Ocupacion_Ocupacion.Descripcion
                    ,Estado = Detalle_de_Datos_del_Imputado_MPIData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Estado), "Estado") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Datos_del_Imputado_MPIData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Municipio), "Municipio") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Municipio_Municipio.Nombre
                    ,Codigo_Postal = Detalle_de_Datos_del_Imputado_MPIData.Codigo_Postal
                    ,Localidad = Detalle_de_Datos_del_Imputado_MPIData.Localidad
                    ,LocalidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Localidad), "Localidad") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Localidad_Localidad.Descripcion
                    ,Colonia = Detalle_de_Datos_del_Imputado_MPIData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Colonia), "Colonia") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Colonia_Colonia.Nombre
                    ,Calle_del_Imputado = Detalle_de_Datos_del_Imputado_MPIData.Calle_del_Imputado
                    ,Numero_Exterior = Detalle_de_Datos_del_Imputado_MPIData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Datos_del_Imputado_MPIData.Numero_Interior
                    ,Telefono = Detalle_de_Datos_del_Imputado_MPIData.Telefono
                    ,Extencion = Detalle_de_Datos_del_Imputado_MPIData.Extencion
                    ,Celular = Detalle_de_Datos_del_Imputado_MPIData.Celular
                    ,Correo_Electronico = Detalle_de_Datos_del_Imputado_MPIData.Correo_Electronico
                    ,Pais = Detalle_de_Datos_del_Imputado_MPIData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Pais), "Pais") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Pais_Pais.Nombre
                    ,Forma_Cara = Detalle_de_Datos_del_Imputado_MPIData.Forma_Cara
                    ,Forma_CaraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Forma_Cara), "Forma_Cara") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Forma_Cara_Forma_Cara.Descripcion
                    ,Cejas = Detalle_de_Datos_del_Imputado_MPIData.Cejas
                    ,CejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Cejas), "Cejas") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Cejas_Cejas.Descripcion
                    ,Cantidad_Cabello = Detalle_de_Datos_del_Imputado_MPIData.Cantidad_Cabello
                    ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Cantidad_Cabello), "Cantidad_Cabello") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                    ,Implantacion_Cabello = Detalle_de_Datos_del_Imputado_MPIData.Implantacion_Cabello
                    ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Implantacion_Cabello), "Implantacion_Cabello") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                    ,Complexion = Detalle_de_Datos_del_Imputado_MPIData.Complexion
                    ,ComplexionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Complexion), "Complexion") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Complexion_Complexion.Descripcion
                    ,Color_Piel = Detalle_de_Datos_del_Imputado_MPIData.Color_Piel
                    ,Color_PielDescrpicion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Color_Piel), "Color_Piel") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Color_Piel_Color_Piel.Descrpicion
                    ,Frente = Detalle_de_Datos_del_Imputado_MPIData.Frente
                    ,FrenteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Frente), "Frente") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Frente_Frente.Descripcion
                    ,Forma_Cabello = Detalle_de_Datos_del_Imputado_MPIData.Forma_Cabello
                    ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Forma_Cabello), "Forma_Cabello") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Forma_Cabello_Forma_Cabello.Descripcion
                    ,Calvicie = Detalle_de_Datos_del_Imputado_MPIData.Calvicie
                    ,CalvicieDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Calvicie), "Calvicie") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Calvicie_Calvicie.Descripcion
                    ,Color_Ojos = Detalle_de_Datos_del_Imputado_MPIData.Color_Ojos
                    ,Color_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Color_Ojos), "Color_Ojos") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Color_Ojos_Color_Ojos.Descripcion
                    ,Ojos = Detalle_de_Datos_del_Imputado_MPIData.Ojos
                    ,OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Ojos), "Ojos") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Ojos_Ojos.Descripcion
                    ,Forma_Ojos = Detalle_de_Datos_del_Imputado_MPIData.Forma_Ojos
                    ,Forma_OjosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Forma_Ojos), "Froma_Ojos") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Forma_Ojos_Froma_Ojos.Descripcion
                    ,Nariz_Base = Detalle_de_Datos_del_Imputado_MPIData.Nariz_Base
                    ,Nariz_BaseDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Nariz_Base), "Nariz_Base") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Nariz_Base_Nariz_Base.Descripcion
                    ,Labios = Detalle_de_Datos_del_Imputado_MPIData.Labios
                    ,LabiosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Labios), "Labios") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Labios_Labios.Descripcion
                    ,Boca = Detalle_de_Datos_del_Imputado_MPIData.Boca
                    ,BocaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Boca), "Boca") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Boca_Boca.Descripcion
                    ,Menton = Detalle_de_Datos_del_Imputado_MPIData.Menton
                    ,MentonDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Menton), "Menton") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Menton_Menton.Descripcion
                    ,Barba = Detalle_de_Datos_del_Imputado_MPIData.Barba
                    ,BarbaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Barba), "Barba") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Barba_Barba.Descripcion
                    ,Forma_Orejas = Detalle_de_Datos_del_Imputado_MPIData.Forma_Orejas
                    ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Forma_Orejas), "Forma_Orejas") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Forma_Orejas_Forma_Orejas.Descripcion
                    ,Tamano_Orejas = Detalle_de_Datos_del_Imputado_MPIData.Tamano_Orejas
                    ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Tamano_Orejas), "Forma_Orejas") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Tamano_Orejas_Forma_Orejas.Descripcion
                    ,Tipo_Lobulo = Detalle_de_Datos_del_Imputado_MPIData.Tipo_Lobulo
                    ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Tipo_Lobulo), "Tipo_Lobulo") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                    ,Bigote = Detalle_de_Datos_del_Imputado_MPIData.Bigote
                    ,BigoteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Bigote), "Bigote") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Bigote_Bigote.Descripcion
                    ,Situacion_Fisica = Detalle_de_Datos_del_Imputado_MPIData.Situacion_Fisica
                    ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Situacion_Fisica), "Situacion_Fisica") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Situacion_Fisica_Situacion_Fisica.Descripcion
                    ,Alias_media_diliacion = Detalle_de_Datos_del_Imputado_MPIData.Alias_media_diliacion
                    ,Fecha_de_Detencion = (Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Detencion = Detalle_de_Datos_del_Imputado_MPIData.Hora_de_Detencion
                    ,Fecha_de_Puesto_a_Disposicion = (Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Puesto_a_Disposicion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Puesto_a_Disposicion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Puesto_a_Disposicion = Detalle_de_Datos_del_Imputado_MPIData.Hora_de_Puesto_a_Disposicion
                    ,Con_Detenido = Detalle_de_Datos_del_Imputado_MPIData.Con_Detenido
                    ,Con_DetenidoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Con_Detenido), "Catalogo_Estatus_Detenido_MPI") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Con_Detenido_Catalogo_Estatus_Detenido_MPI.Descripcion
                    ,A_Quien_Resulte_Responsable = Detalle_de_Datos_del_Imputado_MPIData.A_Quien_Resulte_Responsable.GetValueOrDefault()
                    ,Tiempo_Restante_para_Vinculacion = Detalle_de_Datos_del_Imputado_MPIData.Tiempo_Restante_para_Vinculacion
                    ,Vincular = Detalle_de_Datos_del_Imputado_MPIData.Vincular.GetValueOrDefault()
                    ,Medidas_Cautelares = Detalle_de_Datos_del_Imputado_MPIData.Medidas_Cautelares
                    ,Medidas_CautelaresDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Medidas_Cautelares), "Medidas_Cautelares") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Medidas_Cautelares_Medidas_Cautelares.Descripcion
                    ,Solicitar_Prorroga = Detalle_de_Datos_del_Imputado_MPIData.Solicitar_Prorroga
                    ,Nuevo_Plazo = Detalle_de_Datos_del_Imputado_MPIData.Nuevo_Plazo
                    ,Orden_de_Aprehension = Detalle_de_Datos_del_Imputado_MPIData.Orden_de_Aprehension.GetValueOrDefault()
                    ,Medidas_Cautelares_en_Imputado = Detalle_de_Datos_del_Imputado_MPIData.Medidas_Cautelares_en_Imputado
                    ,Medidas_Cautelares_en_ImputadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Medidas_Cautelares_en_Imputado), "Medidas_Cautelares") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Medidas_Cautelares_en_Imputado_Medidas_Cautelares.Descripcion
                    ,Titulo_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Titulo_del_Hecho
                    ,Narrativa_Breve_de_los_Hechos = Detalle_de_Datos_del_Imputado_MPIData.Narrativa_Breve_de_los_Hechos
                    ,Prioridad_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Prioridad_del_Hecho
                    ,Prioridad_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Prioridad_del_Hecho), "Prioridad_del_Hecho") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Prioridad_del_Hecho_Prioridad_del_Hecho.Descripcion
                    ,Fecha_del_Hecho = (Detalle_de_Datos_del_Imputado_MPIData.Fecha_del_Hecho == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Imputado_MPIData.Fecha_del_Hecho).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_Aproximada_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Hora_Aproximada_del_Hecho
                    ,Pais_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Pais_del_Hecho
                    ,Pais_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Pais_del_Hecho), "Pais") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Pais_del_Hecho_Pais.Nombre
                    ,Estado_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Estado_del_Hecho
                    ,Estado_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Estado_del_Hecho), "Estado") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Estado_del_Hecho_Estado.Nombre
                    ,Municipio_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Municipio_del_Hecho
                    ,Municipio_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Municipio_del_Hecho), "Municipio") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Municipio_del_Hecho_Municipio.Nombre
                    ,Colonia_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Colonia_del_Hecho
                    ,Colonia_del_HechoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Colonia_del_Hecho), "Colonia") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Colonia_del_Hecho_Colonia.Nombre
                    ,Codigo_Postal_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Codigo_Postal_del_Hecho
                    ,Calle_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Calle_del_Hecho
                    ,Entre_Calle_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Entre_Calle_del_Hecho
                    ,Y_Calle_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Y_Calle_del_Hecho
                    ,Numero_Exterior_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Numero_Exterior_del_Hecho
                    ,Numero_Interior_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Numero_Interior_del_Hecho
                    ,Latitud_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Latitud_del_Hecho
                    ,Longitud_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Longitud_del_Hecho
                    ,Tipo_de_Lugar_del_Hecho = Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Lugar_del_Hecho
                    ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Lugar_del_Hecho), "Lugar_Tipo") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                    ,Incapaz = Detalle_de_Datos_del_Imputado_MPIData.Incapaz.GetValueOrDefault()
                    ,Nombre_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Nombre_del_Tutor
                    ,Apellido_Paterno_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Apellido_Paterno_del_Tutor
                    ,Apellido_Materno_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Apellido_Materno_del_Tutor
                    ,Fecha_de_Nacimiento_del_Tutor = (Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Nacimiento_del_Tutor == null ? string.Empty : Convert.ToDateTime(Detalle_de_Datos_del_Imputado_MPIData.Fecha_de_Nacimiento_del_Tutor).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Edad_del_Tutor
                    ,Sexo_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Sexo_del_Tutor
                    ,Sexo_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Sexo_del_Tutor), "Genero") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Sexo_del_Tutor_Genero.Descripcion
                    ,Estado_Civil_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Estado_Civil_del_Tutor
                    ,Estado_Civil_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Estado_Civil_del_Tutor), "Estado_Civil") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Estado_Civil_del_Tutor_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Identificacion_del_Tutor
                    ,Tipo_de_Identificacion_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Identificacion_del_Tutor), "Tipo_de_Identificacion") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Tipo_de_Identificacion_del_Tutor_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Numero_de_Identificacion_del_Tutor
                    ,Nacionalidad_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Nacionalidad_del_Tutor
                    ,Nacionalidad_del_TutorNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Nacionalidad_del_Tutor), "Nacionalidad") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Nacionalidad_del_Tutor_Nacionalidad.NacionalidadC
                    ,Escolaridad_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Escolaridad_del_Tutor
                    ,Escolaridad_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Escolaridad_del_Tutor), "Escolaridad") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Escolaridad_del_Tutor_Escolaridad.Descripcion
                    ,Ocupacion_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Ocupacion_del_Tutor
                    ,Ocupacion_del_TutorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Ocupacion_del_Tutor), "Ocupacion") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Ocupacion_del_Tutor_Ocupacion.Descripcion
                    ,Pais_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Pais_del_Tutor
                    ,Pais_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Pais_del_Tutor), "Pais") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Pais_del_Tutor_Pais.Nombre
                    ,Estado_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Estado_del_Tutor
                    ,Estado_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Estado_del_Tutor), "Estado") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Estado_del_Tutor_Estado.Nombre
                    ,Municipio_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Municipio_del_Tutor
                    ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Municipio_del_Tutor), "Municipio") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Municipio_del_Tutor_Municipio.Nombre
                    ,Colonia_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Colonia_del_Tutor
                    ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Colonia_del_Tutor), "Colonia") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Colonia_del_Tutor_Colonia.Nombre
                    ,Codigo_Postal_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Codigo_Postal_del_Tutor
                    ,Calle_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Calle_del_Tutor
                    ,Numero_Exterior_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Numero_Exterior_del_Tutor
                    ,Numero_Interior_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Numero_Interior_del_Tutor
                    ,Telefono_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Telefono_del_Tutor
                    ,Extension_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Extension_del_Tutor
                    ,Celular_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Celular_del_Tutor
                    ,Correo_Electronico_del_Tutor = Detalle_de_Datos_del_Imputado_MPIData.Correo_Electronico_del_Tutor
                    ,Proteccion_de_Datos = Detalle_de_Datos_del_Imputado_MPIData.Proteccion_de_Datos.GetValueOrDefault()
                    ,Estatus = Detalle_de_Datos_del_Imputado_MPIData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Datos_del_Imputado_MPIData.Estatus), "Estatus_del_Imputado") ??  (string)Detalle_de_Datos_del_Imputado_MPIData.Estatus_Estatus_del_Imputado.Descripcion
                    ,Judicializar = Detalle_de_Datos_del_Imputado_MPIData.Judicializar.GetValueOrDefault()

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
            _ILocalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Localidads_Localidad = _ILocalidadApiConsumer.SelAll(true);
            if (Localidads_Localidad != null && Localidads_Localidad.Resource != null)
                ViewBag.Localidads_Localidad = Localidads_Localidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Localidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia != null && Colonias_Colonia.Resource != null)
                ViewBag.Colonias_Colonia = Colonias_Colonia.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais != null && Paiss_Pais.Resource != null)
                ViewBag.Paiss_Pais = Paiss_Pais.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CaraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Caras_Forma_Cara = _IForma_CaraApiConsumer.SelAll(true);
            if (Forma_Caras_Forma_Cara != null && Forma_Caras_Forma_Cara.Resource != null)
                ViewBag.Forma_Caras_Forma_Cara = Forma_Caras_Forma_Cara.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cara", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cejass_Cejas = _ICejasApiConsumer.SelAll(true);
            if (Cejass_Cejas != null && Cejass_Cejas.Resource != null)
                ViewBag.Cejass_Cejas = Cejass_Cejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICantidad_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cantidad_Cabellos_Cantidad_Cabello = _ICantidad_CabelloApiConsumer.SelAll(true);
            if (Cantidad_Cabellos_Cantidad_Cabello != null && Cantidad_Cabellos_Cantidad_Cabello.Resource != null)
                ViewBag.Cantidad_Cabellos_Cantidad_Cabello = Cantidad_Cabellos_Cantidad_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cantidad_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IImplantacion_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Implantacion_Cabellos_Implantacion_Cabello = _IImplantacion_CabelloApiConsumer.SelAll(true);
            if (Implantacion_Cabellos_Implantacion_Cabello != null && Implantacion_Cabellos_Implantacion_Cabello.Resource != null)
                ViewBag.Implantacion_Cabellos_Implantacion_Cabello = Implantacion_Cabellos_Implantacion_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Implantacion_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IComplexionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Complexions_Complexion = _IComplexionApiConsumer.SelAll(true);
            if (Complexions_Complexion != null && Complexions_Complexion.Resource != null)
                ViewBag.Complexions_Complexion = Complexions_Complexion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Complexion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_PielApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Piels_Color_Piel = _IColor_PielApiConsumer.SelAll(true);
            if (Color_Piels_Color_Piel != null && Color_Piels_Color_Piel.Resource != null)
                ViewBag.Color_Piels_Color_Piel = Color_Piels_Color_Piel.Resource.Where(m => m.Descrpicion != null).OrderBy(m => m.Descrpicion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Piel", "Descrpicion") ?? m.Descrpicion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFrenteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Frentes_Frente = _IFrenteApiConsumer.SelAll(true);
            if (Frentes_Frente != null && Frentes_Frente.Resource != null)
                ViewBag.Frentes_Frente = Frentes_Frente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Frente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Cabellos_Forma_Cabello = _IForma_CabelloApiConsumer.SelAll(true);
            if (Forma_Cabellos_Forma_Cabello != null && Forma_Cabellos_Forma_Cabello.Resource != null)
                ViewBag.Forma_Cabellos_Forma_Cabello = Forma_Cabellos_Forma_Cabello.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cabello", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICalvicieApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Calvicies_Calvicie = _ICalvicieApiConsumer.SelAll(true);
            if (Calvicies_Calvicie != null && Calvicies_Calvicie.Resource != null)
                ViewBag.Calvicies_Calvicie = Calvicies_Calvicie.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calvicie", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Ojoss_Color_Ojos = _IColor_OjosApiConsumer.SelAll(true);
            if (Color_Ojoss_Color_Ojos != null && Color_Ojoss_Color_Ojos.Resource != null)
                ViewBag.Color_Ojoss_Color_Ojos = Color_Ojoss_Color_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Ojoss_Ojos = _IOjosApiConsumer.SelAll(true);
            if (Ojoss_Ojos != null && Ojoss_Ojos.Resource != null)
                ViewBag.Ojoss_Ojos = Ojoss_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFroma_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Froma_Ojoss_Forma_Ojos = _IFroma_OjosApiConsumer.SelAll(true);
            if (Froma_Ojoss_Forma_Ojos != null && Froma_Ojoss_Forma_Ojos.Resource != null)
                ViewBag.Froma_Ojoss_Forma_Ojos = Froma_Ojoss_Forma_Ojos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Froma_Ojos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INariz_BaseApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nariz_Bases_Nariz_Base = _INariz_BaseApiConsumer.SelAll(true);
            if (Nariz_Bases_Nariz_Base != null && Nariz_Bases_Nariz_Base.Resource != null)
                ViewBag.Nariz_Bases_Nariz_Base = Nariz_Bases_Nariz_Base.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nariz_Base", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ILabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Labioss_Labios = _ILabiosApiConsumer.SelAll(true);
            if (Labioss_Labios != null && Labioss_Labios.Resource != null)
                ViewBag.Labioss_Labios = Labioss_Labios.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Labios", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBocaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Bocas_Boca = _IBocaApiConsumer.SelAll(true);
            if (Bocas_Boca != null && Bocas_Boca.Resource != null)
                ViewBag.Bocas_Boca = Bocas_Boca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Boca", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMentonApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Mentons_Menton = _IMentonApiConsumer.SelAll(true);
            if (Mentons_Menton != null && Mentons_Menton.Resource != null)
                ViewBag.Mentons_Menton = Mentons_Menton.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Menton", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBarbaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Barbas_Barba = _IBarbaApiConsumer.SelAll(true);
            if (Barbas_Barba != null && Barbas_Barba.Resource != null)
                ViewBag.Barbas_Barba = Barbas_Barba.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Barba", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Orejass_Forma_Orejas = _IForma_OrejasApiConsumer.SelAll(true);
            if (Forma_Orejass_Forma_Orejas != null && Forma_Orejass_Forma_Orejas.Resource != null)
                ViewBag.Forma_Orejass_Forma_Orejas = Forma_Orejass_Forma_Orejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Orejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Orejass_Tamano_Orejas = _IForma_OrejasApiConsumer.SelAll(true);
            if (Forma_Orejass_Tamano_Orejas != null && Forma_Orejass_Tamano_Orejas.Resource != null)
                ViewBag.Forma_Orejass_Tamano_Orejas = Forma_Orejass_Tamano_Orejas.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Orejas", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_LobuloApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Lobulos_Tipo_Lobulo = _ITipo_LobuloApiConsumer.SelAll(true);
            if (Tipo_Lobulos_Tipo_Lobulo != null && Tipo_Lobulos_Tipo_Lobulo.Resource != null)
                ViewBag.Tipo_Lobulos_Tipo_Lobulo = Tipo_Lobulos_Tipo_Lobulo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Lobulo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBigoteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Bigotes_Bigote = _IBigoteApiConsumer.SelAll(true);
            if (Bigotes_Bigote != null && Bigotes_Bigote.Resource != null)
                ViewBag.Bigotes_Bigote = Bigotes_Bigote.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Bigote", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISituacion_FisicaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Situacion_Fisicas_Situacion_Fisica = _ISituacion_FisicaApiConsumer.SelAll(true);
            if (Situacion_Fisicas_Situacion_Fisica != null && Situacion_Fisicas_Situacion_Fisica.Resource != null)
                ViewBag.Situacion_Fisicas_Situacion_Fisica = Situacion_Fisicas_Situacion_Fisica.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Situacion_Fisica", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICatalogo_Estatus_Detenido_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Catalogo_Estatus_Detenido_MPIs_Con_Detenido = _ICatalogo_Estatus_Detenido_MPIApiConsumer.SelAll(true);
            if (Catalogo_Estatus_Detenido_MPIs_Con_Detenido != null && Catalogo_Estatus_Detenido_MPIs_Con_Detenido.Resource != null)
                ViewBag.Catalogo_Estatus_Detenido_MPIs_Con_Detenido = Catalogo_Estatus_Detenido_MPIs_Con_Detenido.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Estatus_Detenido_MPI", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMedidas_CautelaresApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Medidas_Cautelaress_Medidas_Cautelares = _IMedidas_CautelaresApiConsumer.SelAll(true);
            if (Medidas_Cautelaress_Medidas_Cautelares != null && Medidas_Cautelaress_Medidas_Cautelares.Resource != null)
                ViewBag.Medidas_Cautelaress_Medidas_Cautelares = Medidas_Cautelaress_Medidas_Cautelares.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Medidas_Cautelares", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMedidas_CautelaresApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Medidas_Cautelaress_Medidas_Cautelares_en_Imputado = _IMedidas_CautelaresApiConsumer.SelAll(true);
            if (Medidas_Cautelaress_Medidas_Cautelares_en_Imputado != null && Medidas_Cautelaress_Medidas_Cautelares_en_Imputado.Resource != null)
                ViewBag.Medidas_Cautelaress_Medidas_Cautelares_en_Imputado = Medidas_Cautelaress_Medidas_Cautelares_en_Imputado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Medidas_Cautelares", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            var Lugar_Tipos_Tipo_de_Lugar_del_Hecho = _ILugar_TipoApiConsumer.SelAll(true);
            if (Lugar_Tipos_Tipo_de_Lugar_del_Hecho != null && Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource != null)
                ViewBag.Lugar_Tipos_Tipo_de_Lugar_del_Hecho = Lugar_Tipos_Tipo_de_Lugar_del_Hecho.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_Tipo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IEstatus_del_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_del_Imputados_Estatus = _IEstatus_del_ImputadoApiConsumer.SelAll(true);
            if (Estatus_del_Imputados_Estatus != null && Estatus_del_Imputados_Estatus.Resource != null)
                ViewBag.Estatus_del_Imputados_Estatus = Estatus_del_Imputados_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_del_Imputado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Datos_del_Imputado_MPI", varDetalle_de_Datos_del_Imputado_MPI);
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
        public ActionResult GetForma_CaraAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_CaraApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_CaraApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cara", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCejasAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICejasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICejasApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cejas", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCantidad_CabelloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICantidad_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICantidad_CabelloApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cantidad_Cabello", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetImplantacion_CabelloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IImplantacion_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IImplantacion_CabelloApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Implantacion_Cabello", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetComplexionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IComplexionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IComplexionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Complexion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetColor_PielAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColor_PielApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColor_PielApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descrpicion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Piel", "Descrpicion")?? m.Descrpicion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetFrenteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IFrenteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IFrenteApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Frente", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetForma_CabelloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_CabelloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_CabelloApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Cabello", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCalvicieAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICalvicieApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICalvicieApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Calvicie", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetColor_OjosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColor_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColor_OjosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Ojos", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetOjosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOjosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOjosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Ojos", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetFroma_OjosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IFroma_OjosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IFroma_OjosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Froma_Ojos", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetNariz_BaseAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _INariz_BaseApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _INariz_BaseApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nariz_Base", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetLabiosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILabiosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILabiosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Labios", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetBocaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IBocaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IBocaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Boca", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetMentonAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMentonApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMentonApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Menton", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetBarbaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IBarbaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IBarbaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Barba", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetForma_OrejasAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_OrejasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_OrejasApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Orejas", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_LobuloAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_LobuloApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_LobuloApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Lobulo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetBigoteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IBigoteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IBigoteApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Bigote", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetSituacion_FisicaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISituacion_FisicaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISituacion_FisicaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Situacion_Fisica", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCatalogo_Estatus_Detenido_MPIAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_Estatus_Detenido_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICatalogo_Estatus_Detenido_MPIApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Catalogo_Estatus_Detenido_MPI", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetMedidas_CautelaresAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMedidas_CautelaresApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMedidas_CautelaresApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Medidas_Cautelares", "Descripcion")?? m.Descripcion,
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
        [HttpGet]
        public ActionResult GetEstatus_del_ImputadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_del_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_del_ImputadoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_del_Imputado", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Datos_del_Imputado_MPIPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Datos_del_Imputado_MPIs == null)
                result.Detalle_de_Datos_del_Imputado_MPIs = new List<Detalle_de_Datos_del_Imputado_MPI>();

            return Json(new
            {
                data = result.Detalle_de_Datos_del_Imputado_MPIs.Select(m => new Detalle_de_Datos_del_Imputado_MPIGridModel
                    {
                    Clave = m.Clave
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
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
			,Codigo_Postal = m.Codigo_Postal
                        ,LocalidadDescripcion = CultureHelper.GetTraduction(m.Localidad_Localidad.Clave.ToString(), "Descripcion") ?? (string)m.Localidad_Localidad.Descripcion
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Colonia.Nombre
			,Calle_del_Imputado = m.Calle_del_Imputado
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Telefono = m.Telefono
			,Extencion = m.Extencion
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_Pais.Nombre
                        ,Forma_CaraDescripcion = CultureHelper.GetTraduction(m.Forma_Cara_Forma_Cara.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cara_Forma_Cara.Descripcion
                        ,CejasDescripcion = CultureHelper.GetTraduction(m.Cejas_Cejas.Clave.ToString(), "Descripcion") ?? (string)m.Cejas_Cejas.Descripcion
                        ,Cantidad_CabelloDescripcion = CultureHelper.GetTraduction(m.Cantidad_Cabello_Cantidad_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                        ,Implantacion_CabelloDescripcion = CultureHelper.GetTraduction(m.Implantacion_Cabello_Implantacion_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                        ,ComplexionDescripcion = CultureHelper.GetTraduction(m.Complexion_Complexion.Clave.ToString(), "Descripcion") ?? (string)m.Complexion_Complexion.Descripcion
                        ,Color_PielDescrpicion = CultureHelper.GetTraduction(m.Color_Piel_Color_Piel.Clave.ToString(), "Descrpicion") ?? (string)m.Color_Piel_Color_Piel.Descrpicion
                        ,FrenteDescripcion = CultureHelper.GetTraduction(m.Frente_Frente.Clave.ToString(), "Descripcion") ?? (string)m.Frente_Frente.Descripcion
                        ,Forma_CabelloDescripcion = CultureHelper.GetTraduction(m.Forma_Cabello_Forma_Cabello.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Cabello_Forma_Cabello.Descripcion
                        ,CalvicieDescripcion = CultureHelper.GetTraduction(m.Calvicie_Calvicie.Clave.ToString(), "Descripcion") ?? (string)m.Calvicie_Calvicie.Descripcion
                        ,Color_OjosDescripcion = CultureHelper.GetTraduction(m.Color_Ojos_Color_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Color_Ojos_Color_Ojos.Descripcion
                        ,OjosDescripcion = CultureHelper.GetTraduction(m.Ojos_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Ojos_Ojos.Descripcion
                        ,Forma_OjosDescripcion = CultureHelper.GetTraduction(m.Forma_Ojos_Froma_Ojos.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                        ,Nariz_BaseDescripcion = CultureHelper.GetTraduction(m.Nariz_Base_Nariz_Base.Clave.ToString(), "Descripcion") ?? (string)m.Nariz_Base_Nariz_Base.Descripcion
                        ,LabiosDescripcion = CultureHelper.GetTraduction(m.Labios_Labios.Clave.ToString(), "Descripcion") ?? (string)m.Labios_Labios.Descripcion
                        ,BocaDescripcion = CultureHelper.GetTraduction(m.Boca_Boca.Clave.ToString(), "Descripcion") ?? (string)m.Boca_Boca.Descripcion
                        ,MentonDescripcion = CultureHelper.GetTraduction(m.Menton_Menton.Clave.ToString(), "Descripcion") ?? (string)m.Menton_Menton.Descripcion
                        ,BarbaDescripcion = CultureHelper.GetTraduction(m.Barba_Barba.Clave.ToString(), "Descripcion") ?? (string)m.Barba_Barba.Descripcion
                        ,Forma_OrejasDescripcion = CultureHelper.GetTraduction(m.Forma_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Forma_Orejas_Forma_Orejas.Descripcion
                        ,Tamano_OrejasDescripcion = CultureHelper.GetTraduction(m.Tamano_Orejas_Forma_Orejas.Clave.ToString(), "Descripcion") ?? (string)m.Tamano_Orejas_Forma_Orejas.Descripcion
                        ,Tipo_LobuloDescripcion = CultureHelper.GetTraduction(m.Tipo_Lobulo_Tipo_Lobulo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                        ,BigoteDescripcion = CultureHelper.GetTraduction(m.Bigote_Bigote.Clave.ToString(), "Descripcion") ?? (string)m.Bigote_Bigote.Descripcion
                        ,Situacion_FisicaDescripcion = CultureHelper.GetTraduction(m.Situacion_Fisica_Situacion_Fisica.Clave.ToString(), "Descripcion") ?? (string)m.Situacion_Fisica_Situacion_Fisica.Descripcion
			,Alias_media_diliacion = m.Alias_media_diliacion
                        ,Fecha_de_Detencion = (m.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Detencion = m.Hora_de_Detencion
                        ,Fecha_de_Puesto_a_Disposicion = (m.Fecha_de_Puesto_a_Disposicion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Puesto_a_Disposicion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Puesto_a_Disposicion = m.Hora_de_Puesto_a_Disposicion
                        ,Con_DetenidoDescripcion = CultureHelper.GetTraduction(m.Con_Detenido_Catalogo_Estatus_Detenido_MPI.Clave.ToString(), "Descripcion") ?? (string)m.Con_Detenido_Catalogo_Estatus_Detenido_MPI.Descripcion
			,A_Quien_Resulte_Responsable = m.A_Quien_Resulte_Responsable
			,Tiempo_Restante_para_Vinculacion = m.Tiempo_Restante_para_Vinculacion
			,Vincular = m.Vincular
                        ,Medidas_CautelaresDescripcion = CultureHelper.GetTraduction(m.Medidas_Cautelares_Medidas_Cautelares.Clave.ToString(), "Descripcion") ?? (string)m.Medidas_Cautelares_Medidas_Cautelares.Descripcion
			,Solicitar_Prorroga = m.Solicitar_Prorroga
			,Nuevo_Plazo = m.Nuevo_Plazo
			,Orden_de_Aprehension = m.Orden_de_Aprehension
                        ,Medidas_Cautelares_en_ImputadoDescripcion = CultureHelper.GetTraduction(m.Medidas_Cautelares_en_Imputado_Medidas_Cautelares.Clave.ToString(), "Descripcion") ?? (string)m.Medidas_Cautelares_en_Imputado_Medidas_Cautelares.Descripcion
			,Titulo_del_Hecho = m.Titulo_del_Hecho
			,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
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
                        ,Tipo_de_Lugar_del_HechoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
			,Incapaz = m.Incapaz
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
                        ,Pais_del_TutorNombre = CultureHelper.GetTraduction(m.Pais_del_Tutor_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_del_Tutor_Pais.Nombre
                        ,Estado_del_TutorNombre = CultureHelper.GetTraduction(m.Estado_del_Tutor_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Tutor_Estado.Nombre
                        ,Municipio_del_TutorNombre = CultureHelper.GetTraduction(m.Municipio_del_Tutor_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Tutor_Municipio.Nombre
                        ,Colonia_del_TutorNombre = CultureHelper.GetTraduction(m.Colonia_del_Tutor_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Tutor_Colonia.Nombre
			,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
			,Calle_del_Tutor = m.Calle_del_Tutor
			,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
			,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
			,Telefono_del_Tutor = m.Telefono_del_Tutor
			,Extension_del_Tutor = m.Extension_del_Tutor
			,Celular_del_Tutor = m.Celular_del_Tutor
			,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
			,Proteccion_de_Datos = m.Proteccion_de_Datos
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_del_Imputado.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_del_Imputado.Descripcion
			,Judicializar = m.Judicializar

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


//Grid GetAutoComplete

//Grid GetAutoComplete






       

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_del_Abogado_Imputado_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_del_Abogado_Imputado_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_del_Abogado_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_del_Abogado_Imputado_MPI.Requerido=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_del_Abogado_Imputado_MPI.Requerido='" + RelationId + "'";
            }
            var result = _IDetalle_del_Abogado_Imputado_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_del_Abogado_Imputado_MPIs == null)
                result.Detalle_del_Abogado_Imputado_MPIs = new List<Detalle_del_Abogado_Imputado_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_del_Abogado_Imputado_MPIs.Select(m => new Detalle_del_Abogado_Imputado_MPIGridModel
                {
                    Consecutivo = m.Consecutivo

                        ,Nombre_Completo_del_Abogado = m.Nombre_Completo_del_Abogado
                        ,Nombre_Completo_del_AbogadoNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Completo_del_Abogado_Abogado.Clave.ToString(), "Nombre_Completo") ??(string)m.Nombre_Completo_del_Abogado_Abogado.Nombre_Completo
			,Nombre_del_Abogado = m.Nombre_del_Abogado
			,Apellido_Paterno_del_Abogado = m.Apellido_Paterno_del_Abogado
			,Apellido_Materno_del_Abogado = m.Apellido_Materno_del_Abogado
			,Fecha_de_Nacimiento_del_Abogado = (m.Fecha_de_Nacimiento_del_Abogado == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Abogado).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Abogado = m.Edad_del_Abogado
                        ,Sexo_del_Abogado = m.Sexo_del_Abogado
                        ,Sexo_del_AbogadoDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Abogado_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_del_Abogado_Genero.Descripcion
                        ,Estado_Civil_del_Abogado = m.Estado_Civil_del_Abogado
                        ,Estado_Civil_del_AbogadoDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Abogado_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_del_Abogado_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_Abogado = m.Tipo_de_Identificacion_del_Abogado
                        ,Tipo_de_Identificacion_del_AbogadoNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Abogado_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_del_Abogado_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Abogado = m.Numero_de_Identificacion_del_Abogado
                        ,Nacionalidad_del_Abogado = m.Nacionalidad_del_Abogado
                        ,Nacionalidad_del_AbogadoNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Abogado_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_del_Abogado_Nacionalidad.NacionalidadC
			,Cedula_Profesional_del_Abogado = m.Cedula_Profesional_del_Abogado
                        ,Pais_del_Abogado = m.Pais_del_Abogado
                        ,Pais_del_AbogadoNombre = CultureHelper.GetTraduction(m.Pais_del_Abogado_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_del_Abogado_Pais.Nombre
                        ,Estado_del_Abogado = m.Estado_del_Abogado
                        ,Estado_del_AbogadoNombre = CultureHelper.GetTraduction(m.Estado_del_Abogado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_del_Abogado_Estado.Nombre
                        ,Municipio_del_Abogado = m.Municipio_del_Abogado
                        ,Municipio_del_AbogadoNombre = CultureHelper.GetTraduction(m.Municipio_del_Abogado_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_del_Abogado_Municipio.Nombre
                        ,Colonia_del_Abogado = m.Colonia_del_Abogado
                        ,Colonia_del_AbogadoNombre = CultureHelper.GetTraduction(m.Colonia_del_Abogado_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_del_Abogado_Colonia.Nombre
			,Codigo_Postal_del_Abogado = m.Codigo_Postal_del_Abogado
			,Calle_del_Abogado = m.Calle_del_Abogado
			,Numero_Exterior_del_Abogado = m.Numero_Exterior_del_Abogado
			,Numero_Interior_del_Abogado = m.Numero_Interior_del_Abogado
			,Telefono_del_Abogado = m.Telefono_del_Abogado
			,Celular_del_Abogado = m.Celular_del_Abogado
			,Correo_Electronico_del_Abogado = m.Correo_Electronico_del_Abogado
			,Aceptar_Notificaciones = m.Aceptar_Notificaciones

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_del_Abogado_Imputado_MPIGridModel> GetDetalle_del_Abogado_Imputado_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_del_Abogado_Imputado_MPIGridModel> resultData = new List<Detalle_del_Abogado_Imputado_MPIGridModel>();
            string where = "Detalle_del_Abogado_Imputado_MPI.Requerido=" + Id;
            if("int" == "string")
            {
                where = "Detalle_del_Abogado_Imputado_MPI.Requerido='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_del_Abogado_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_del_Abogado_Imputado_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_del_Abogado_Imputado_MPIs != null)
            {
                resultData = result.Detalle_del_Abogado_Imputado_MPIs.Select(m => new Detalle_del_Abogado_Imputado_MPIGridModel
                    {
                        Consecutivo = m.Consecutivo

                        ,Nombre_Completo_del_Abogado = m.Nombre_Completo_del_Abogado
                        ,Nombre_Completo_del_AbogadoNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Completo_del_Abogado_Abogado.Clave.ToString(), "Nombre_Completo") ??(string)m.Nombre_Completo_del_Abogado_Abogado.Nombre_Completo
			,Nombre_del_Abogado = m.Nombre_del_Abogado
			,Apellido_Paterno_del_Abogado = m.Apellido_Paterno_del_Abogado
			,Apellido_Materno_del_Abogado = m.Apellido_Materno_del_Abogado
			,Fecha_de_Nacimiento_del_Abogado = (m.Fecha_de_Nacimiento_del_Abogado == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Abogado).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Abogado = m.Edad_del_Abogado
                        ,Sexo_del_Abogado = m.Sexo_del_Abogado
                        ,Sexo_del_AbogadoDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Abogado_Genero.Clave.ToString(), "Descripcion") ??(string)m.Sexo_del_Abogado_Genero.Descripcion
                        ,Estado_Civil_del_Abogado = m.Estado_Civil_del_Abogado
                        ,Estado_Civil_del_AbogadoDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Abogado_Estado_Civil.Clave.ToString(), "Descripcion") ??(string)m.Estado_Civil_del_Abogado_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_Abogado = m.Tipo_de_Identificacion_del_Abogado
                        ,Tipo_de_Identificacion_del_AbogadoNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Abogado_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ??(string)m.Tipo_de_Identificacion_del_Abogado_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Abogado = m.Numero_de_Identificacion_del_Abogado
                        ,Nacionalidad_del_Abogado = m.Nacionalidad_del_Abogado
                        ,Nacionalidad_del_AbogadoNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Abogado_Nacionalidad.Clave.ToString(), "NacionalidadC") ??(string)m.Nacionalidad_del_Abogado_Nacionalidad.NacionalidadC
			,Cedula_Profesional_del_Abogado = m.Cedula_Profesional_del_Abogado
                        ,Pais_del_Abogado = m.Pais_del_Abogado
                        ,Pais_del_AbogadoNombre = CultureHelper.GetTraduction(m.Pais_del_Abogado_Pais.Clave.ToString(), "Nombre") ??(string)m.Pais_del_Abogado_Pais.Nombre
                        ,Estado_del_Abogado = m.Estado_del_Abogado
                        ,Estado_del_AbogadoNombre = CultureHelper.GetTraduction(m.Estado_del_Abogado_Estado.Clave.ToString(), "Nombre") ??(string)m.Estado_del_Abogado_Estado.Nombre
                        ,Municipio_del_Abogado = m.Municipio_del_Abogado
                        ,Municipio_del_AbogadoNombre = CultureHelper.GetTraduction(m.Municipio_del_Abogado_Municipio.Clave.ToString(), "Nombre") ??(string)m.Municipio_del_Abogado_Municipio.Nombre
                        ,Colonia_del_Abogado = m.Colonia_del_Abogado
                        ,Colonia_del_AbogadoNombre = CultureHelper.GetTraduction(m.Colonia_del_Abogado_Colonia.Clave.ToString(), "Nombre") ??(string)m.Colonia_del_Abogado_Colonia.Nombre
			,Codigo_Postal_del_Abogado = m.Codigo_Postal_del_Abogado
			,Calle_del_Abogado = m.Calle_del_Abogado
			,Numero_Exterior_del_Abogado = m.Numero_Exterior_del_Abogado
			,Numero_Interior_del_Abogado = m.Numero_Interior_del_Abogado
			,Telefono_del_Abogado = m.Telefono_del_Abogado
			,Celular_del_Abogado = m.Celular_del_Abogado
			,Correo_Electronico_del_Abogado = m.Correo_Electronico_del_Abogado
			,Aceptar_Notificaciones = m.Aceptar_Notificaciones


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetDetalle_de_Sentencias_Imputado_MPI(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Sentencias_Imputado_MPIGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Sentencias_Imputado_MPI.Detalle_Datos_del_Imputado_MPI=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Sentencias_Imputado_MPI.Detalle_Datos_del_Imputado_MPI='" + RelationId + "'";
            }
            var result = _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Sentencias_Imputado_MPIs == null)
                result.Detalle_de_Sentencias_Imputado_MPIs = new List<Detalle_de_Sentencias_Imputado_MPI>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Sentencias_Imputado_MPIs.Select(m => new Detalle_de_Sentencias_Imputado_MPIGridModel
                {
                    Clave = m.Clave

                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ??(string)m.Delito_Delito.Descripcion
                        ,Sentencia = m.Sentencia
                        ,SentenciaDescripcion = CultureHelper.GetTraduction(m.Sentencia_Sentencia.Clave.ToString(), "Descripcion") ??(string)m.Sentencia_Sentencia.Descripcion
			,Fecha_de_Devolucion = (m.Fecha_de_Devolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Devolucion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Devolucion = m.Hora_de_Devolucion
			,Repacion_del_Dano = m.Repacion_del_Dano
			,Resolucion = m.Resolucion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Sentencias_Imputado_MPIGridModel> GetDetalle_de_Sentencias_Imputado_MPIData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Sentencias_Imputado_MPIGridModel> resultData = new List<Detalle_de_Sentencias_Imputado_MPIGridModel>();
            string where = "Detalle_de_Sentencias_Imputado_MPI.Detalle_Datos_del_Imputado_MPI=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Sentencias_Imputado_MPI.Detalle_Datos_del_Imputado_MPI='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Sentencias_Imputado_MPIs != null)
            {
                resultData = result.Detalle_de_Sentencias_Imputado_MPIs.Select(m => new Detalle_de_Sentencias_Imputado_MPIGridModel
                    {
                        Clave = m.Clave

                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ??(string)m.Delito_Delito.Descripcion
                        ,Sentencia = m.Sentencia
                        ,SentenciaDescripcion = CultureHelper.GetTraduction(m.Sentencia_Sentencia.Clave.ToString(), "Descripcion") ??(string)m.Sentencia_Sentencia.Descripcion
			,Fecha_de_Devolucion = (m.Fecha_de_Devolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Devolucion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Devolucion = m.Hora_de_Devolucion
			,Repacion_del_Dano = m.Repacion_del_Dano
			,Resolucion = m.Resolucion


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
                _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Datos_del_Imputado_MPI varDetalle_de_Datos_del_Imputado_MPI = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_del_Abogado_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_del_Abogado_Imputado_MPI.Requerido=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_del_Abogado_Imputado_MPI.Requerido='" + id + "'";
                    }
                    var Detalle_del_Abogado_Imputado_MPIInfo =
                        _IDetalle_del_Abogado_Imputado_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_del_Abogado_Imputado_MPIInfo.Detalle_del_Abogado_Imputado_MPIs.Count > 0)
                    {
                        var resultDetalle_del_Abogado_Imputado_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_del_Abogado_Imputado_MPIItem in Detalle_del_Abogado_Imputado_MPIInfo.Detalle_del_Abogado_Imputado_MPIs)
                            resultDetalle_del_Abogado_Imputado_MPI = resultDetalle_del_Abogado_Imputado_MPI
                                              && _IDetalle_del_Abogado_Imputado_MPIApiConsumer.Delete(Detalle_del_Abogado_Imputado_MPIItem.Consecutivo, null,null).Resource;

                        if (!resultDetalle_del_Abogado_Imputado_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Sentencias_Imputado_MPI.Detalle_Datos_del_Imputado_MPI=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Sentencias_Imputado_MPI.Detalle_Datos_del_Imputado_MPI='" + id + "'";
                    }
                    var Detalle_de_Sentencias_Imputado_MPIInfo =
                        _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Sentencias_Imputado_MPIInfo.Detalle_de_Sentencias_Imputado_MPIs.Count > 0)
                    {
                        var resultDetalle_de_Sentencias_Imputado_MPI = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Sentencias_Imputado_MPIItem in Detalle_de_Sentencias_Imputado_MPIInfo.Detalle_de_Sentencias_Imputado_MPIs)
                            resultDetalle_de_Sentencias_Imputado_MPI = resultDetalle_de_Sentencias_Imputado_MPI
                                              && _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.Delete(Detalle_de_Sentencias_Imputado_MPIItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Sentencias_Imputado_MPI)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Datos_del_Imputado_MPIModel varDetalle_de_Datos_del_Imputado_MPI)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_Datos_del_Imputado_MPIInfo = new Detalle_de_Datos_del_Imputado_MPI
                    {
                        Clave = varDetalle_de_Datos_del_Imputado_MPI.Clave
                        ,Nombre = varDetalle_de_Datos_del_Imputado_MPI.Nombre
                        ,Apellido_Paterno = varDetalle_de_Datos_del_Imputado_MPI.Apellido_Paterno
                        ,Apellido_Materno = varDetalle_de_Datos_del_Imputado_MPI.Apellido_Materno
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varDetalle_de_Datos_del_Imputado_MPI.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varDetalle_de_Datos_del_Imputado_MPI.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varDetalle_de_Datos_del_Imputado_MPI.Edad
                        ,Sexo = varDetalle_de_Datos_del_Imputado_MPI.Sexo
                        ,Estado_Civil = varDetalle_de_Datos_del_Imputado_MPI.Estado_Civil
                        ,Tipo_de_Identificacion = varDetalle_de_Datos_del_Imputado_MPI.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varDetalle_de_Datos_del_Imputado_MPI.Numero_de_Identificacion
                        ,Nacionalidad = varDetalle_de_Datos_del_Imputado_MPI.Nacionalidad
                        ,Escolaridad = varDetalle_de_Datos_del_Imputado_MPI.Escolaridad
                        ,Ocupacion = varDetalle_de_Datos_del_Imputado_MPI.Ocupacion
                        ,Estado = varDetalle_de_Datos_del_Imputado_MPI.Estado
                        ,Municipio = varDetalle_de_Datos_del_Imputado_MPI.Municipio
                        ,Codigo_Postal = varDetalle_de_Datos_del_Imputado_MPI.Codigo_Postal
                        ,Localidad = varDetalle_de_Datos_del_Imputado_MPI.Localidad
                        ,Colonia = varDetalle_de_Datos_del_Imputado_MPI.Colonia
                        ,Calle_del_Imputado = varDetalle_de_Datos_del_Imputado_MPI.Calle_del_Imputado
                        ,Numero_Exterior = varDetalle_de_Datos_del_Imputado_MPI.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Datos_del_Imputado_MPI.Numero_Interior
                        ,Telefono = varDetalle_de_Datos_del_Imputado_MPI.Telefono
                        ,Extencion = varDetalle_de_Datos_del_Imputado_MPI.Extencion
                        ,Celular = varDetalle_de_Datos_del_Imputado_MPI.Celular
                        ,Correo_Electronico = varDetalle_de_Datos_del_Imputado_MPI.Correo_Electronico
                        ,Pais = varDetalle_de_Datos_del_Imputado_MPI.Pais
                        ,Forma_Cara = varDetalle_de_Datos_del_Imputado_MPI.Forma_Cara
                        ,Cejas = varDetalle_de_Datos_del_Imputado_MPI.Cejas
                        ,Cantidad_Cabello = varDetalle_de_Datos_del_Imputado_MPI.Cantidad_Cabello
                        ,Implantacion_Cabello = varDetalle_de_Datos_del_Imputado_MPI.Implantacion_Cabello
                        ,Complexion = varDetalle_de_Datos_del_Imputado_MPI.Complexion
                        ,Color_Piel = varDetalle_de_Datos_del_Imputado_MPI.Color_Piel
                        ,Frente = varDetalle_de_Datos_del_Imputado_MPI.Frente
                        ,Forma_Cabello = varDetalle_de_Datos_del_Imputado_MPI.Forma_Cabello
                        ,Calvicie = varDetalle_de_Datos_del_Imputado_MPI.Calvicie
                        ,Color_Ojos = varDetalle_de_Datos_del_Imputado_MPI.Color_Ojos
                        ,Ojos = varDetalle_de_Datos_del_Imputado_MPI.Ojos
                        ,Forma_Ojos = varDetalle_de_Datos_del_Imputado_MPI.Forma_Ojos
                        ,Nariz_Base = varDetalle_de_Datos_del_Imputado_MPI.Nariz_Base
                        ,Labios = varDetalle_de_Datos_del_Imputado_MPI.Labios
                        ,Boca = varDetalle_de_Datos_del_Imputado_MPI.Boca
                        ,Menton = varDetalle_de_Datos_del_Imputado_MPI.Menton
                        ,Barba = varDetalle_de_Datos_del_Imputado_MPI.Barba
                        ,Forma_Orejas = varDetalle_de_Datos_del_Imputado_MPI.Forma_Orejas
                        ,Tamano_Orejas = varDetalle_de_Datos_del_Imputado_MPI.Tamano_Orejas
                        ,Tipo_Lobulo = varDetalle_de_Datos_del_Imputado_MPI.Tipo_Lobulo
                        ,Bigote = varDetalle_de_Datos_del_Imputado_MPI.Bigote
                        ,Situacion_Fisica = varDetalle_de_Datos_del_Imputado_MPI.Situacion_Fisica
                        ,Alias_media_diliacion = varDetalle_de_Datos_del_Imputado_MPI.Alias_media_diliacion
                        ,Fecha_de_Detencion = (!String.IsNullOrEmpty(varDetalle_de_Datos_del_Imputado_MPI.Fecha_de_Detencion)) ? DateTime.ParseExact(varDetalle_de_Datos_del_Imputado_MPI.Fecha_de_Detencion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Detencion = varDetalle_de_Datos_del_Imputado_MPI.Hora_de_Detencion
                        ,Fecha_de_Puesto_a_Disposicion = (!String.IsNullOrEmpty(varDetalle_de_Datos_del_Imputado_MPI.Fecha_de_Puesto_a_Disposicion)) ? DateTime.ParseExact(varDetalle_de_Datos_del_Imputado_MPI.Fecha_de_Puesto_a_Disposicion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Puesto_a_Disposicion = varDetalle_de_Datos_del_Imputado_MPI.Hora_de_Puesto_a_Disposicion
                        ,Con_Detenido = varDetalle_de_Datos_del_Imputado_MPI.Con_Detenido
                        ,A_Quien_Resulte_Responsable = varDetalle_de_Datos_del_Imputado_MPI.A_Quien_Resulte_Responsable
                        ,Tiempo_Restante_para_Vinculacion = varDetalle_de_Datos_del_Imputado_MPI.Tiempo_Restante_para_Vinculacion
                        ,Vincular = varDetalle_de_Datos_del_Imputado_MPI.Vincular
                        ,Medidas_Cautelares = varDetalle_de_Datos_del_Imputado_MPI.Medidas_Cautelares
                        ,Solicitar_Prorroga = varDetalle_de_Datos_del_Imputado_MPI.Solicitar_Prorroga
                        ,Nuevo_Plazo = varDetalle_de_Datos_del_Imputado_MPI.Nuevo_Plazo
                        ,Orden_de_Aprehension = varDetalle_de_Datos_del_Imputado_MPI.Orden_de_Aprehension
                        ,Medidas_Cautelares_en_Imputado = varDetalle_de_Datos_del_Imputado_MPI.Medidas_Cautelares_en_Imputado
                        ,Titulo_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Titulo_del_Hecho
                        ,Narrativa_Breve_de_los_Hechos = varDetalle_de_Datos_del_Imputado_MPI.Narrativa_Breve_de_los_Hechos
                        ,Prioridad_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Prioridad_del_Hecho
                        ,Fecha_del_Hecho = (!String.IsNullOrEmpty(varDetalle_de_Datos_del_Imputado_MPI.Fecha_del_Hecho)) ? DateTime.ParseExact(varDetalle_de_Datos_del_Imputado_MPI.Fecha_del_Hecho, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_Aproximada_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Hora_Aproximada_del_Hecho
                        ,Pais_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Pais_del_Hecho
                        ,Estado_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Estado_del_Hecho
                        ,Municipio_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Municipio_del_Hecho
                        ,Colonia_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Colonia_del_Hecho
                        ,Codigo_Postal_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Codigo_Postal_del_Hecho
                        ,Calle_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Calle_del_Hecho
                        ,Entre_Calle_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Entre_Calle_del_Hecho
                        ,Y_Calle_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Y_Calle_del_Hecho
                        ,Numero_Exterior_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Numero_Exterior_del_Hecho
                        ,Numero_Interior_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Numero_Interior_del_Hecho
                        ,Latitud_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Latitud_del_Hecho
                        ,Longitud_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Longitud_del_Hecho
                        ,Tipo_de_Lugar_del_Hecho = varDetalle_de_Datos_del_Imputado_MPI.Tipo_de_Lugar_del_Hecho
                        ,Incapaz = varDetalle_de_Datos_del_Imputado_MPI.Incapaz
                        ,Nombre_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Nombre_del_Tutor
                        ,Apellido_Paterno_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Apellido_Paterno_del_Tutor
                        ,Apellido_Materno_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Apellido_Materno_del_Tutor
                        ,Fecha_de_Nacimiento_del_Tutor = (!String.IsNullOrEmpty(varDetalle_de_Datos_del_Imputado_MPI.Fecha_de_Nacimiento_del_Tutor)) ? DateTime.ParseExact(varDetalle_de_Datos_del_Imputado_MPI.Fecha_de_Nacimiento_del_Tutor, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Edad_del_Tutor
                        ,Sexo_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Sexo_del_Tutor
                        ,Estado_Civil_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Estado_Civil_del_Tutor
                        ,Tipo_de_Identificacion_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Tipo_de_Identificacion_del_Tutor
                        ,Numero_de_Identificacion_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Numero_de_Identificacion_del_Tutor
                        ,Nacionalidad_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Nacionalidad_del_Tutor
                        ,Escolaridad_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Escolaridad_del_Tutor
                        ,Ocupacion_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Ocupacion_del_Tutor
                        ,Pais_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Pais_del_Tutor
                        ,Estado_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Estado_del_Tutor
                        ,Municipio_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Municipio_del_Tutor
                        ,Colonia_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Colonia_del_Tutor
                        ,Codigo_Postal_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Codigo_Postal_del_Tutor
                        ,Calle_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Calle_del_Tutor
                        ,Numero_Exterior_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Numero_Exterior_del_Tutor
                        ,Numero_Interior_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Numero_Interior_del_Tutor
                        ,Telefono_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Telefono_del_Tutor
                        ,Extension_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Extension_del_Tutor
                        ,Celular_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Celular_del_Tutor
                        ,Correo_Electronico_del_Tutor = varDetalle_de_Datos_del_Imputado_MPI.Correo_Electronico_del_Tutor
                        ,Proteccion_de_Datos = varDetalle_de_Datos_del_Imputado_MPI.Proteccion_de_Datos
                        ,Estatus = varDetalle_de_Datos_del_Imputado_MPI.Estatus
                        ,Judicializar = varDetalle_de_Datos_del_Imputado_MPI.Judicializar

                    };

                    result = !IsNew ?
                        _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.Update(Detalle_de_Datos_del_Imputado_MPIInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.Insert(Detalle_de_Datos_del_Imputado_MPIInfo, null, null).Resource.ToString();

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
        public bool CopyDetalle_del_Abogado_Imputado_MPI(int MasterId, int referenceId, List<Detalle_del_Abogado_Imputado_MPIGridModelPost> Detalle_del_Abogado_Imputado_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_del_Abogado_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_del_Abogado_Imputado_MPIData = _IDetalle_del_Abogado_Imputado_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_del_Abogado_Imputado_MPI.Requerido=" + referenceId,"").Resource;
                if (Detalle_del_Abogado_Imputado_MPIData == null || Detalle_del_Abogado_Imputado_MPIData.Detalle_del_Abogado_Imputado_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_del_Abogado_Imputado_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_del_Abogado_Imputado_MPI in Detalle_del_Abogado_Imputado_MPIData.Detalle_del_Abogado_Imputado_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_del_Abogado_Imputado_MPI Detalle_del_Abogado_Imputado_MPI1 = varDetalle_del_Abogado_Imputado_MPI;

                    if (Detalle_del_Abogado_Imputado_MPIItems != null && Detalle_del_Abogado_Imputado_MPIItems.Any(m => m.Consecutivo == Detalle_del_Abogado_Imputado_MPI1.Consecutivo))
                    {
                        modelDataToChange = Detalle_del_Abogado_Imputado_MPIItems.FirstOrDefault(m => m.Consecutivo == Detalle_del_Abogado_Imputado_MPI1.Consecutivo);
                    }
                    //Chaning Id Value
                    varDetalle_del_Abogado_Imputado_MPI.Requerido = MasterId;
                    var insertId = _IDetalle_del_Abogado_Imputado_MPIApiConsumer.Insert(varDetalle_del_Abogado_Imputado_MPI,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Consecutivo = insertId;

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
        public ActionResult PostDetalle_del_Abogado_Imputado_MPI(List<Detalle_del_Abogado_Imputado_MPIGridModelPost> Detalle_del_Abogado_Imputado_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_del_Abogado_Imputado_MPI(MasterId, referenceId, Detalle_del_Abogado_Imputado_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_del_Abogado_Imputado_MPIItems != null && Detalle_del_Abogado_Imputado_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_del_Abogado_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_del_Abogado_Imputado_MPIItem in Detalle_del_Abogado_Imputado_MPIItems)
                    {


























                        //Removal Request
                        if (Detalle_del_Abogado_Imputado_MPIItem.Removed)
                        {
                            result = result && _IDetalle_del_Abogado_Imputado_MPIApiConsumer.Delete(Detalle_del_Abogado_Imputado_MPIItem.Consecutivo, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_del_Abogado_Imputado_MPIItem.Consecutivo = 0;

                        var Detalle_del_Abogado_Imputado_MPIData = new Detalle_del_Abogado_Imputado_MPI
                        {
                            Requerido = MasterId
                            ,Consecutivo = Detalle_del_Abogado_Imputado_MPIItem.Consecutivo
                            ,Nombre_Completo_del_Abogado = (Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Nombre_Completo_del_Abogado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Nombre_Completo_del_Abogado))
                            ,Nombre_del_Abogado = Detalle_del_Abogado_Imputado_MPIItem.Nombre_del_Abogado
                            ,Apellido_Paterno_del_Abogado = Detalle_del_Abogado_Imputado_MPIItem.Apellido_Paterno_del_Abogado
                            ,Apellido_Materno_del_Abogado = Detalle_del_Abogado_Imputado_MPIItem.Apellido_Materno_del_Abogado
                            ,Fecha_de_Nacimiento_del_Abogado = (Detalle_del_Abogado_Imputado_MPIItem.Fecha_de_Nacimiento_del_Abogado!= null) ? DateTime.ParseExact(Detalle_del_Abogado_Imputado_MPIItem.Fecha_de_Nacimiento_del_Abogado, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Edad_del_Abogado = Detalle_del_Abogado_Imputado_MPIItem.Edad_del_Abogado
                            ,Sexo_del_Abogado = (Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Sexo_del_Abogado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Sexo_del_Abogado))
                            ,Estado_Civil_del_Abogado = (Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Estado_Civil_del_Abogado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Estado_Civil_del_Abogado))
                            ,Tipo_de_Identificacion_del_Abogado = (Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Tipo_de_Identificacion_del_Abogado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Tipo_de_Identificacion_del_Abogado))
                            ,Numero_de_Identificacion_del_Abogado = Detalle_del_Abogado_Imputado_MPIItem.Numero_de_Identificacion_del_Abogado
                            ,Nacionalidad_del_Abogado = (Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Nacionalidad_del_Abogado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Nacionalidad_del_Abogado))
                            ,Cedula_Profesional_del_Abogado = Detalle_del_Abogado_Imputado_MPIItem.Cedula_Profesional_del_Abogado
                            ,Pais_del_Abogado = (Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Pais_del_Abogado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Pais_del_Abogado))
                            ,Estado_del_Abogado = (Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Estado_del_Abogado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Estado_del_Abogado))
                            ,Municipio_del_Abogado = (Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Municipio_del_Abogado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Municipio_del_Abogado))
                            ,Colonia_del_Abogado = (Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Colonia_del_Abogado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_del_Abogado_Imputado_MPIItem.Colonia_del_Abogado))
                            ,Codigo_Postal_del_Abogado = Detalle_del_Abogado_Imputado_MPIItem.Codigo_Postal_del_Abogado
                            ,Calle_del_Abogado = Detalle_del_Abogado_Imputado_MPIItem.Calle_del_Abogado
                            ,Numero_Exterior_del_Abogado = Detalle_del_Abogado_Imputado_MPIItem.Numero_Exterior_del_Abogado
                            ,Numero_Interior_del_Abogado = Detalle_del_Abogado_Imputado_MPIItem.Numero_Interior_del_Abogado
                            ,Telefono_del_Abogado = Detalle_del_Abogado_Imputado_MPIItem.Telefono_del_Abogado
                            ,Celular_del_Abogado = Detalle_del_Abogado_Imputado_MPIItem.Celular_del_Abogado
                            ,Correo_Electronico_del_Abogado = Detalle_del_Abogado_Imputado_MPIItem.Correo_Electronico_del_Abogado
                            ,Aceptar_Notificaciones = Detalle_del_Abogado_Imputado_MPIItem.Aceptar_Notificaciones

                        };

                        var resultId = Detalle_del_Abogado_Imputado_MPIItem.Consecutivo > 0
                           ? _IDetalle_del_Abogado_Imputado_MPIApiConsumer.Update(Detalle_del_Abogado_Imputado_MPIData,null,null).Resource
                           : _IDetalle_del_Abogado_Imputado_MPIApiConsumer.Insert(Detalle_del_Abogado_Imputado_MPIData,null,null).Resource;

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
        public ActionResult GetDetalle_del_Abogado_Imputado_MPI_AbogadoAll()
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
        public ActionResult GetDetalle_del_Abogado_Imputado_MPI_GeneroAll()
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
        public ActionResult GetDetalle_del_Abogado_Imputado_MPI_Estado_CivilAll()
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
        public ActionResult GetDetalle_del_Abogado_Imputado_MPI_Tipo_de_IdentificacionAll()
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
        public ActionResult GetDetalle_del_Abogado_Imputado_MPI_NacionalidadAll()
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
        public ActionResult GetDetalle_del_Abogado_Imputado_MPI_PaisAll()
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
        public ActionResult GetDetalle_del_Abogado_Imputado_MPI_EstadoAll()
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
        public ActionResult GetDetalle_del_Abogado_Imputado_MPI_MunicipioAll()
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
        public ActionResult GetDetalle_del_Abogado_Imputado_MPI_ColoniaAll()
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









        [NonAction]
        public bool CopyDetalle_de_Sentencias_Imputado_MPI(int MasterId, int referenceId, List<Detalle_de_Sentencias_Imputado_MPIGridModelPost> Detalle_de_Sentencias_Imputado_MPIItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Sentencias_Imputado_MPIData = _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Sentencias_Imputado_MPI.Detalle_Datos_del_Imputado_MPI=" + referenceId,"").Resource;
                if (Detalle_de_Sentencias_Imputado_MPIData == null || Detalle_de_Sentencias_Imputado_MPIData.Detalle_de_Sentencias_Imputado_MPIs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Sentencias_Imputado_MPIGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Sentencias_Imputado_MPI in Detalle_de_Sentencias_Imputado_MPIData.Detalle_de_Sentencias_Imputado_MPIs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Sentencias_Imputado_MPI Detalle_de_Sentencias_Imputado_MPI1 = varDetalle_de_Sentencias_Imputado_MPI;

                    if (Detalle_de_Sentencias_Imputado_MPIItems != null && Detalle_de_Sentencias_Imputado_MPIItems.Any(m => m.Clave == Detalle_de_Sentencias_Imputado_MPI1.Clave))
                    {
                        modelDataToChange = Detalle_de_Sentencias_Imputado_MPIItems.FirstOrDefault(m => m.Clave == Detalle_de_Sentencias_Imputado_MPI1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Sentencias_Imputado_MPI.Detalle_Datos_del_Imputado_MPI = MasterId;
                    var insertId = _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.Insert(varDetalle_de_Sentencias_Imputado_MPI,null,null).Resource;
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
        public ActionResult PostDetalle_de_Sentencias_Imputado_MPI(List<Detalle_de_Sentencias_Imputado_MPIGridModelPost> Detalle_de_Sentencias_Imputado_MPIItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Sentencias_Imputado_MPI(MasterId, referenceId, Detalle_de_Sentencias_Imputado_MPIItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Sentencias_Imputado_MPIItems != null && Detalle_de_Sentencias_Imputado_MPIItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Sentencias_Imputado_MPIItem in Detalle_de_Sentencias_Imputado_MPIItems)
                    {








                        //Removal Request
                        if (Detalle_de_Sentencias_Imputado_MPIItem.Removed)
                        {
                            result = result && _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.Delete(Detalle_de_Sentencias_Imputado_MPIItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Sentencias_Imputado_MPIItem.Clave = 0;

                        var Detalle_de_Sentencias_Imputado_MPIData = new Detalle_de_Sentencias_Imputado_MPI
                        {
                            Detalle_Datos_del_Imputado_MPI = MasterId
                            ,Clave = Detalle_de_Sentencias_Imputado_MPIItem.Clave
                            ,Delito = (Convert.ToInt32(Detalle_de_Sentencias_Imputado_MPIItem.Delito) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Sentencias_Imputado_MPIItem.Delito))
                            ,Sentencia = (Convert.ToInt32(Detalle_de_Sentencias_Imputado_MPIItem.Sentencia) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Sentencias_Imputado_MPIItem.Sentencia))
                            ,Fecha_de_Devolucion = (Detalle_de_Sentencias_Imputado_MPIItem.Fecha_de_Devolucion!= null) ? DateTime.ParseExact(Detalle_de_Sentencias_Imputado_MPIItem.Fecha_de_Devolucion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                            ,Hora_de_Devolucion = Detalle_de_Sentencias_Imputado_MPIItem.Hora_de_Devolucion
                            ,Repacion_del_Dano = Detalle_de_Sentencias_Imputado_MPIItem.Repacion_del_Dano
                            ,Resolucion = Detalle_de_Sentencias_Imputado_MPIItem.Resolucion

                        };

                        var resultId = Detalle_de_Sentencias_Imputado_MPIItem.Clave > 0
                           ? _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.Update(Detalle_de_Sentencias_Imputado_MPIData,null,null).Resource
                           : _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.Insert(Detalle_de_Sentencias_Imputado_MPIData,null,null).Resource;

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
        public ActionResult GetDetalle_de_Sentencias_Imputado_MPI_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelitoApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Delito", "Descripcion");
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
        public ActionResult GetDetalle_de_Sentencias_Imputado_MPI_SentenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISentenciaApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Sentencia", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }







        /// <summary>
        /// Write Element Array of Detalle_de_Datos_del_Imputado_MPI script
        /// </summary>
        /// <param name="oDetalle_de_Datos_del_Imputado_MPIElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_de_Datos_del_Imputado_MPIModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_de_Datos_del_Imputado_MPIScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_del_Imputado_MPI.js")))
            {
                strDetalle_de_Datos_del_Imputado_MPIScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Datos_del_Imputado_MPI element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Datos_del_Imputado_MPIScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Datos_del_Imputado_MPIScript.Substring(indexOfArray, strDetalle_de_Datos_del_Imputado_MPIScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Datos_del_Imputado_MPIScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_de_Datos_del_Imputado_MPIScript.Substring(indexOfArrayHistory, strDetalle_de_Datos_del_Imputado_MPIScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_de_Datos_del_Imputado_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Datos_del_Imputado_MPIScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Datos_del_Imputado_MPIScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_de_Datos_del_Imputado_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_de_Datos_del_Imputado_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_de_Datos_del_Imputado_MPIScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_de_Datos_del_Imputado_MPIScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_de_Datos_del_Imputado_MPIScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_del_Imputado_MPI.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_del_Imputado_MPI.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Datos_del_Imputado_MPI.js")))
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
        public ActionResult Detalle_de_Datos_del_Imputado_MPIPropertyBag()
        {
            return PartialView("Detalle_de_Datos_del_Imputado_MPIPropertyBag", "Detalle_de_Datos_del_Imputado_MPI");
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
        public ActionResult AddDetalle_del_Abogado_Imputado_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_del_Abogado_Imputado_MPI/AddDetalle_del_Abogado_Imputado_MPI");
        }

        [HttpGet]
        public ActionResult AddDetalle_de_Sentencias_Imputado_MPI(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Sentencias_Imputado_MPI/AddDetalle_de_Sentencias_Imputado_MPI");
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

            _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Datos_del_Imputado_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Datos_del_Imputado_MPIs == null)
                result.Detalle_de_Datos_del_Imputado_MPIs = new List<Detalle_de_Datos_del_Imputado_MPI>();

            var data = result.Detalle_de_Datos_del_Imputado_MPIs.Select(m => new Detalle_de_Datos_del_Imputado_MPIGridModel
            {
                Clave = m.Clave
                ,Nombre = m.Nombre
                ,Apellido_Paterno = m.Apellido_Paterno
                ,Apellido_Materno = m.Apellido_Materno
                ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                ,Edad = m.Edad
                ,SexoDescripcion = (string)m.Sexo_Genero.Descripcion
                ,Estado_CivilDescripcion = (string)m.Estado_Civil_Estado_Civil.Descripcion
                ,Tipo_de_IdentificacionNombre = (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                ,Numero_de_Identificacion = m.Numero_de_Identificacion
                ,NacionalidadNacionalidadC = (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                ,EscolaridadDescripcion = (string)m.Escolaridad_Escolaridad.Descripcion
                ,OcupacionDescripcion = (string)m.Ocupacion_Ocupacion.Descripcion
                ,EstadoNombre = (string)m.Estado_Estado.Nombre
                ,MunicipioNombre = (string)m.Municipio_Municipio.Nombre
                ,Codigo_Postal = m.Codigo_Postal
                ,LocalidadDescripcion = (string)m.Localidad_Localidad.Descripcion
                ,ColoniaNombre = (string)m.Colonia_Colonia.Nombre
                ,Calle_del_Imputado = m.Calle_del_Imputado
                ,Numero_Exterior = m.Numero_Exterior
                ,Numero_Interior = m.Numero_Interior
                ,Telefono = m.Telefono
                ,Extencion = m.Extencion
                ,Celular = m.Celular
                ,Correo_Electronico = m.Correo_Electronico
                ,PaisNombre = (string)m.Pais_Pais.Nombre
                ,Forma_CaraDescripcion = (string)m.Forma_Cara_Forma_Cara.Descripcion
                ,CejasDescripcion = (string)m.Cejas_Cejas.Descripcion
                ,Cantidad_CabelloDescripcion = (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                ,Implantacion_CabelloDescripcion = (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                ,ComplexionDescripcion = (string)m.Complexion_Complexion.Descripcion
                ,Color_PielDescrpicion = (string)m.Color_Piel_Color_Piel.Descrpicion
                ,FrenteDescripcion = (string)m.Frente_Frente.Descripcion
                ,Forma_CabelloDescripcion = (string)m.Forma_Cabello_Forma_Cabello.Descripcion
                ,CalvicieDescripcion = (string)m.Calvicie_Calvicie.Descripcion
                ,Color_OjosDescripcion = (string)m.Color_Ojos_Color_Ojos.Descripcion
                ,OjosDescripcion = (string)m.Ojos_Ojos.Descripcion
                ,Forma_OjosDescripcion = (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                ,Nariz_BaseDescripcion = (string)m.Nariz_Base_Nariz_Base.Descripcion
                ,LabiosDescripcion = (string)m.Labios_Labios.Descripcion
                ,BocaDescripcion = (string)m.Boca_Boca.Descripcion
                ,MentonDescripcion = (string)m.Menton_Menton.Descripcion
                ,BarbaDescripcion = (string)m.Barba_Barba.Descripcion
                ,Forma_OrejasDescripcion = (string)m.Forma_Orejas_Forma_Orejas.Descripcion
                ,Tamano_OrejasDescripcion = (string)m.Tamano_Orejas_Forma_Orejas.Descripcion
                ,Tipo_LobuloDescripcion = (string)m.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                ,BigoteDescripcion = (string)m.Bigote_Bigote.Descripcion
                ,Situacion_FisicaDescripcion = (string)m.Situacion_Fisica_Situacion_Fisica.Descripcion
                ,Alias_media_diliacion = m.Alias_media_diliacion
                ,Fecha_de_Detencion = (m.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Detencion = m.Hora_de_Detencion
                ,Fecha_de_Puesto_a_Disposicion = (m.Fecha_de_Puesto_a_Disposicion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Puesto_a_Disposicion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Puesto_a_Disposicion = m.Hora_de_Puesto_a_Disposicion
                ,Con_DetenidoDescripcion = (string)m.Con_Detenido_Catalogo_Estatus_Detenido_MPI.Descripcion
                ,A_Quien_Resulte_Responsable = m.A_Quien_Resulte_Responsable
                ,Tiempo_Restante_para_Vinculacion = m.Tiempo_Restante_para_Vinculacion
                ,Vincular = m.Vincular
                ,Medidas_CautelaresDescripcion = (string)m.Medidas_Cautelares_Medidas_Cautelares.Descripcion
                ,Solicitar_Prorroga = m.Solicitar_Prorroga
                ,Nuevo_Plazo = m.Nuevo_Plazo
                ,Orden_de_Aprehension = m.Orden_de_Aprehension
                ,Medidas_Cautelares_en_ImputadoDescripcion = (string)m.Medidas_Cautelares_en_Imputado_Medidas_Cautelares.Descripcion
                ,Titulo_del_Hecho = m.Titulo_del_Hecho
                ,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
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
                ,Tipo_de_Lugar_del_HechoDescripcion = (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                ,Incapaz = m.Incapaz
                ,Nombre_del_Tutor = m.Nombre_del_Tutor
                ,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
                ,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
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
                ,Colonia_del_TutorNombre = (string)m.Colonia_del_Tutor_Colonia.Nombre
                ,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
                ,Calle_del_Tutor = m.Calle_del_Tutor
                ,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
                ,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
                ,Telefono_del_Tutor = m.Telefono_del_Tutor
                ,Extension_del_Tutor = m.Extension_del_Tutor
                ,Celular_del_Tutor = m.Celular_del_Tutor
                ,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
                ,Proteccion_de_Datos = m.Proteccion_de_Datos
                ,EstatusDescripcion = (string)m.Estatus_Estatus_del_Imputado.Descripcion
                ,Judicializar = m.Judicializar

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_de_Datos_del_Imputado_MPIList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_de_Datos_del_Imputado_MPIList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Datos_del_Imputado_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Datos_del_Imputado_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Datos_del_Imputado_MPIs == null)
                result.Detalle_de_Datos_del_Imputado_MPIs = new List<Detalle_de_Datos_del_Imputado_MPI>();

            var data = result.Detalle_de_Datos_del_Imputado_MPIs.Select(m => new Detalle_de_Datos_del_Imputado_MPIGridModel
            {
                Clave = m.Clave
                ,Nombre = m.Nombre
                ,Apellido_Paterno = m.Apellido_Paterno
                ,Apellido_Materno = m.Apellido_Materno
                ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                ,Edad = m.Edad
                ,SexoDescripcion = (string)m.Sexo_Genero.Descripcion
                ,Estado_CivilDescripcion = (string)m.Estado_Civil_Estado_Civil.Descripcion
                ,Tipo_de_IdentificacionNombre = (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                ,Numero_de_Identificacion = m.Numero_de_Identificacion
                ,NacionalidadNacionalidadC = (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                ,EscolaridadDescripcion = (string)m.Escolaridad_Escolaridad.Descripcion
                ,OcupacionDescripcion = (string)m.Ocupacion_Ocupacion.Descripcion
                ,EstadoNombre = (string)m.Estado_Estado.Nombre
                ,MunicipioNombre = (string)m.Municipio_Municipio.Nombre
                ,Codigo_Postal = m.Codigo_Postal
                ,LocalidadDescripcion = (string)m.Localidad_Localidad.Descripcion
                ,ColoniaNombre = (string)m.Colonia_Colonia.Nombre
                ,Calle_del_Imputado = m.Calle_del_Imputado
                ,Numero_Exterior = m.Numero_Exterior
                ,Numero_Interior = m.Numero_Interior
                ,Telefono = m.Telefono
                ,Extencion = m.Extencion
                ,Celular = m.Celular
                ,Correo_Electronico = m.Correo_Electronico
                ,PaisNombre = (string)m.Pais_Pais.Nombre
                ,Forma_CaraDescripcion = (string)m.Forma_Cara_Forma_Cara.Descripcion
                ,CejasDescripcion = (string)m.Cejas_Cejas.Descripcion
                ,Cantidad_CabelloDescripcion = (string)m.Cantidad_Cabello_Cantidad_Cabello.Descripcion
                ,Implantacion_CabelloDescripcion = (string)m.Implantacion_Cabello_Implantacion_Cabello.Descripcion
                ,ComplexionDescripcion = (string)m.Complexion_Complexion.Descripcion
                ,Color_PielDescrpicion = (string)m.Color_Piel_Color_Piel.Descrpicion
                ,FrenteDescripcion = (string)m.Frente_Frente.Descripcion
                ,Forma_CabelloDescripcion = (string)m.Forma_Cabello_Forma_Cabello.Descripcion
                ,CalvicieDescripcion = (string)m.Calvicie_Calvicie.Descripcion
                ,Color_OjosDescripcion = (string)m.Color_Ojos_Color_Ojos.Descripcion
                ,OjosDescripcion = (string)m.Ojos_Ojos.Descripcion
                ,Forma_OjosDescripcion = (string)m.Forma_Ojos_Froma_Ojos.Descripcion
                ,Nariz_BaseDescripcion = (string)m.Nariz_Base_Nariz_Base.Descripcion
                ,LabiosDescripcion = (string)m.Labios_Labios.Descripcion
                ,BocaDescripcion = (string)m.Boca_Boca.Descripcion
                ,MentonDescripcion = (string)m.Menton_Menton.Descripcion
                ,BarbaDescripcion = (string)m.Barba_Barba.Descripcion
                ,Forma_OrejasDescripcion = (string)m.Forma_Orejas_Forma_Orejas.Descripcion
                ,Tamano_OrejasDescripcion = (string)m.Tamano_Orejas_Forma_Orejas.Descripcion
                ,Tipo_LobuloDescripcion = (string)m.Tipo_Lobulo_Tipo_Lobulo.Descripcion
                ,BigoteDescripcion = (string)m.Bigote_Bigote.Descripcion
                ,Situacion_FisicaDescripcion = (string)m.Situacion_Fisica_Situacion_Fisica.Descripcion
                ,Alias_media_diliacion = m.Alias_media_diliacion
                ,Fecha_de_Detencion = (m.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Detencion = m.Hora_de_Detencion
                ,Fecha_de_Puesto_a_Disposicion = (m.Fecha_de_Puesto_a_Disposicion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Puesto_a_Disposicion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Puesto_a_Disposicion = m.Hora_de_Puesto_a_Disposicion
                ,Con_DetenidoDescripcion = (string)m.Con_Detenido_Catalogo_Estatus_Detenido_MPI.Descripcion
                ,A_Quien_Resulte_Responsable = m.A_Quien_Resulte_Responsable
                ,Tiempo_Restante_para_Vinculacion = m.Tiempo_Restante_para_Vinculacion
                ,Vincular = m.Vincular
                ,Medidas_CautelaresDescripcion = (string)m.Medidas_Cautelares_Medidas_Cautelares.Descripcion
                ,Solicitar_Prorroga = m.Solicitar_Prorroga
                ,Nuevo_Plazo = m.Nuevo_Plazo
                ,Orden_de_Aprehension = m.Orden_de_Aprehension
                ,Medidas_Cautelares_en_ImputadoDescripcion = (string)m.Medidas_Cautelares_en_Imputado_Medidas_Cautelares.Descripcion
                ,Titulo_del_Hecho = m.Titulo_del_Hecho
                ,Narrativa_Breve_de_los_Hechos = m.Narrativa_Breve_de_los_Hechos
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
                ,Tipo_de_Lugar_del_HechoDescripcion = (string)m.Tipo_de_Lugar_del_Hecho_Lugar_Tipo.Descripcion
                ,Incapaz = m.Incapaz
                ,Nombre_del_Tutor = m.Nombre_del_Tutor
                ,Apellido_Paterno_del_Tutor = m.Apellido_Paterno_del_Tutor
                ,Apellido_Materno_del_Tutor = m.Apellido_Materno_del_Tutor
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
                ,Colonia_del_TutorNombre = (string)m.Colonia_del_Tutor_Colonia.Nombre
                ,Codigo_Postal_del_Tutor = m.Codigo_Postal_del_Tutor
                ,Calle_del_Tutor = m.Calle_del_Tutor
                ,Numero_Exterior_del_Tutor = m.Numero_Exterior_del_Tutor
                ,Numero_Interior_del_Tutor = m.Numero_Interior_del_Tutor
                ,Telefono_del_Tutor = m.Telefono_del_Tutor
                ,Extension_del_Tutor = m.Extension_del_Tutor
                ,Celular_del_Tutor = m.Celular_del_Tutor
                ,Correo_Electronico_del_Tutor = m.Correo_Electronico_del_Tutor
                ,Proteccion_de_Datos = m.Proteccion_de_Datos
                ,EstatusDescripcion = (string)m.Estatus_Estatus_del_Imputado.Descripcion
                ,Judicializar = m.Judicializar

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
