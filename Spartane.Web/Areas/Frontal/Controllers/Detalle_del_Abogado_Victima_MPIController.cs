using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
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

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_del_Abogado_Victima_MPI;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
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
    public class Detalle_del_Abogado_Victima_MPIController : Controller
    {
        #region "variable declaration"

        private IDetalle_del_Abogado_Victima_MPIService service = null;
        private IDetalle_del_Abogado_Victima_MPIApiConsumer _IDetalle_del_Abogado_Victima_MPIApiConsumer;
        private IAbogadoApiConsumer _IAbogadoApiConsumer;
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

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_del_Abogado_Victima_MPIController(IDetalle_del_Abogado_Victima_MPIService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_del_Abogado_Victima_MPIApiConsumer Detalle_del_Abogado_Victima_MPIApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IAbogadoApiConsumer AbogadoApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_del_Abogado_Victima_MPIApiConsumer = Detalle_del_Abogado_Victima_MPIApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IAbogadoApiConsumer = AbogadoApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_del_Abogado_Victima_MPI
        [ObjectAuth(ObjectId = (ModuleObjectId)45153, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45153);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_del_Abogado_Victima_MPI/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45153, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45153);
            ViewBag.Permission = permission;
            var varDetalle_del_Abogado_Victima_MPI = new Detalle_del_Abogado_Victima_MPIModel();
			
            ViewBag.ObjectId = "45153";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_del_Abogado_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_del_Abogado_Victima_MPIData = _IDetalle_del_Abogado_Victima_MPIApiConsumer.GetByKeyComplete(Id).Resource.Detalle_del_Abogado_Victima_MPIs[0];
                if (Detalle_del_Abogado_Victima_MPIData == null)
                    return HttpNotFound();

                varDetalle_del_Abogado_Victima_MPI = new Detalle_del_Abogado_Victima_MPIModel
                {
                    Consecutivo_Victima = (int)Detalle_del_Abogado_Victima_MPIData.Consecutivo_Victima
                    ,Nombre_Completo_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Nombre_Completo_del_Abogado_Victima
                    ,Nombre_Completo_del_Abogado_VictimaNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Nombre_Completo_del_Abogado_Victima), "Abogado") ??  (string)Detalle_del_Abogado_Victima_MPIData.Nombre_Completo_del_Abogado_Victima_Abogado.Nombre_Completo
                    ,Nombre_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Nombre_del_Abogado_Victima
                    ,Apellido_Paterno_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Apellido_Paterno_del_Abogado_Victima
                    ,Apellido_Materno_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Apellido_Materno_del_Abogado_Victima
                    ,Fecha_de_Nacimiento_del_Abogado_Victima = (Detalle_del_Abogado_Victima_MPIData.Fecha_de_Nacimiento_del_Abogado_Victima == null ? string.Empty : Convert.ToDateTime(Detalle_del_Abogado_Victima_MPIData.Fecha_de_Nacimiento_del_Abogado_Victima).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Edad_del_Abogado_Victima
                    ,Sexo_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Sexo_del_Abogado_Victima
                    ,Sexo_del_Abogado_VictimaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Sexo_del_Abogado_Victima), "Genero") ??  (string)Detalle_del_Abogado_Victima_MPIData.Sexo_del_Abogado_Victima_Genero.Descripcion
                    ,Estado_Civil_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Estado_Civil_del_Abogado_Victima
                    ,Estado_Civil_del_Abogado_VictimaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Estado_Civil_del_Abogado_Victima), "Estado_Civil") ??  (string)Detalle_del_Abogado_Victima_MPIData.Estado_Civil_del_Abogado_Victima_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Tipo_de_Identificacion_Abogado_Victima
                    ,Tipo_de_Identificacion_Abogado_VictimaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Tipo_de_Identificacion_Abogado_Victima), "Tipo_de_Identificacion") ??  (string)Detalle_del_Abogado_Victima_MPIData.Tipo_de_Identificacion_Abogado_Victima_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Numero_de_Identificacion_Abogado_Victima
                    ,Nacionalidad_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Nacionalidad_del_Abogado_Victima
                    ,Nacionalidad_del_Abogado_VictimaNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Nacionalidad_del_Abogado_Victima), "Nacionalidad") ??  (string)Detalle_del_Abogado_Victima_MPIData.Nacionalidad_del_Abogado_Victima_Nacionalidad.NacionalidadC
                    ,Cedula_Profesional_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Cedula_Profesional_del_Abogado_Victima
                    ,Pais_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Pais_del_Abogado_Victima
                    ,Pais_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Pais_del_Abogado_Victima), "Pais") ??  (string)Detalle_del_Abogado_Victima_MPIData.Pais_del_Abogado_Victima_Pais.Nombre
                    ,Estado_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Estado_del_Abogado_Victima
                    ,Estado_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Estado_del_Abogado_Victima), "Estado") ??  (string)Detalle_del_Abogado_Victima_MPIData.Estado_del_Abogado_Victima_Estado.Nombre
                    ,Municipio_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Municipio_del_Abogado_Victima
                    ,Municipio_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Municipio_del_Abogado_Victima), "Municipio") ??  (string)Detalle_del_Abogado_Victima_MPIData.Municipio_del_Abogado_Victima_Municipio.Nombre
                    ,Colonia_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Colonia_del_Abogado_Victima
                    ,Colonia_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Colonia_del_Abogado_Victima), "Colonia") ??  (string)Detalle_del_Abogado_Victima_MPIData.Colonia_del_Abogado_Victima_Colonia.Nombre
                    ,Codigo_Postal_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Codigo_Postal_del_Abogado_Victima
                    ,Calle_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Calle_del_Abogado_Victima
                    ,Numero_Exterior_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Numero_Exterior_del_Abogado_Victima
                    ,Numero_Interior_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Numero_Interior_del_Abogado_Victima
                    ,Telefono_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Telefono_del_Abogado_Victima
                    ,Celular_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Celular_del_Abogado_Victima
                    ,Correo_Electronico_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Correo_Electronico_del_Abogado_Victima
                    ,Aceptar_Notificaciones = Detalle_del_Abogado_Victima_MPIData.Aceptar_Notificaciones.GetValueOrDefault()

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IAbogadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Abogados_Nombre_Completo_del_Abogado_Victima = _IAbogadoApiConsumer.SelAll(true);
            if (Abogados_Nombre_Completo_del_Abogado_Victima != null && Abogados_Nombre_Completo_del_Abogado_Victima.Resource != null)
                ViewBag.Abogados_Nombre_Completo_del_Abogado_Victima = Abogados_Nombre_Completo_del_Abogado_Victima.Resource.Where(m => m.Nombre_Completo != null).OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Abogado", "Nombre_Completo") ?? m.Nombre_Completo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_del_Abogado_Victima = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_del_Abogado_Victima != null && Generos_Sexo_del_Abogado_Victima.Resource != null)
                ViewBag.Generos_Sexo_del_Abogado_Victima = Generos_Sexo_del_Abogado_Victima.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_del_Abogado_Victima = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_del_Abogado_Victima != null && Estado_Civils_Estado_Civil_del_Abogado_Victima.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_del_Abogado_Victima = Estado_Civils_Estado_Civil_del_Abogado_Victima.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_Abogado_Victima = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_Abogado_Victima != null && Tipo_de_Identificacions_Tipo_de_Identificacion_Abogado_Victima.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_Abogado_Victima = Tipo_de_Identificacions_Tipo_de_Identificacion_Abogado_Victima.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_del_Abogado_Victima = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_del_Abogado_Victima != null && Nacionalidads_Nacionalidad_del_Abogado_Victima.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_del_Abogado_Victima = Nacionalidads_Nacionalidad_del_Abogado_Victima.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_del_Abogado_Victima = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_del_Abogado_Victima != null && Paiss_Pais_del_Abogado_Victima.Resource != null)
                ViewBag.Paiss_Pais_del_Abogado_Victima = Paiss_Pais_del_Abogado_Victima.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Abogado_Victima = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Abogado_Victima != null && Estados_Estado_del_Abogado_Victima.Resource != null)
                ViewBag.Estados_Estado_del_Abogado_Victima = Estados_Estado_del_Abogado_Victima.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Abogado_Victima = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Abogado_Victima != null && Municipios_Municipio_del_Abogado_Victima.Resource != null)
                ViewBag.Municipios_Municipio_del_Abogado_Victima = Municipios_Municipio_del_Abogado_Victima.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Abogado_Victima = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Abogado_Victima != null && Colonias_Colonia_del_Abogado_Victima.Resource != null)
                ViewBag.Colonias_Colonia_del_Abogado_Victima = Colonias_Colonia_del_Abogado_Victima.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_del_Abogado_Victima_MPI);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_del_Abogado_Victima_MPI(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45153);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_del_Abogado_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_del_Abogado_Victima_MPIModel varDetalle_del_Abogado_Victima_MPI= new Detalle_del_Abogado_Victima_MPIModel();


            if (id.ToString() != "0")
            {
                var Detalle_del_Abogado_Victima_MPIsData = _IDetalle_del_Abogado_Victima_MPIApiConsumer.ListaSelAll(0, 1000, "Detalle_del_Abogado_Victima_MPI.Consecutivo_Victima=" + id, "").Resource.Detalle_del_Abogado_Victima_MPIs;
				
				if (Detalle_del_Abogado_Victima_MPIsData != null && Detalle_del_Abogado_Victima_MPIsData.Count > 0)
                {
					var Detalle_del_Abogado_Victima_MPIData = Detalle_del_Abogado_Victima_MPIsData.First();
					varDetalle_del_Abogado_Victima_MPI= new Detalle_del_Abogado_Victima_MPIModel
					{
						Consecutivo_Victima  = Detalle_del_Abogado_Victima_MPIData.Consecutivo_Victima 
	                    ,Nombre_Completo_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Nombre_Completo_del_Abogado_Victima
                    ,Nombre_Completo_del_Abogado_VictimaNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Nombre_Completo_del_Abogado_Victima), "Abogado") ??  (string)Detalle_del_Abogado_Victima_MPIData.Nombre_Completo_del_Abogado_Victima_Abogado.Nombre_Completo
                    ,Nombre_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Nombre_del_Abogado_Victima
                    ,Apellido_Paterno_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Apellido_Paterno_del_Abogado_Victima
                    ,Apellido_Materno_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Apellido_Materno_del_Abogado_Victima
                    ,Fecha_de_Nacimiento_del_Abogado_Victima = (Detalle_del_Abogado_Victima_MPIData.Fecha_de_Nacimiento_del_Abogado_Victima == null ? string.Empty : Convert.ToDateTime(Detalle_del_Abogado_Victima_MPIData.Fecha_de_Nacimiento_del_Abogado_Victima).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Edad_del_Abogado_Victima
                    ,Sexo_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Sexo_del_Abogado_Victima
                    ,Sexo_del_Abogado_VictimaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Sexo_del_Abogado_Victima), "Genero") ??  (string)Detalle_del_Abogado_Victima_MPIData.Sexo_del_Abogado_Victima_Genero.Descripcion
                    ,Estado_Civil_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Estado_Civil_del_Abogado_Victima
                    ,Estado_Civil_del_Abogado_VictimaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Estado_Civil_del_Abogado_Victima), "Estado_Civil") ??  (string)Detalle_del_Abogado_Victima_MPIData.Estado_Civil_del_Abogado_Victima_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Tipo_de_Identificacion_Abogado_Victima
                    ,Tipo_de_Identificacion_Abogado_VictimaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Tipo_de_Identificacion_Abogado_Victima), "Tipo_de_Identificacion") ??  (string)Detalle_del_Abogado_Victima_MPIData.Tipo_de_Identificacion_Abogado_Victima_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Numero_de_Identificacion_Abogado_Victima
                    ,Nacionalidad_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Nacionalidad_del_Abogado_Victima
                    ,Nacionalidad_del_Abogado_VictimaNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Nacionalidad_del_Abogado_Victima), "Nacionalidad") ??  (string)Detalle_del_Abogado_Victima_MPIData.Nacionalidad_del_Abogado_Victima_Nacionalidad.NacionalidadC
                    ,Cedula_Profesional_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Cedula_Profesional_del_Abogado_Victima
                    ,Pais_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Pais_del_Abogado_Victima
                    ,Pais_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Pais_del_Abogado_Victima), "Pais") ??  (string)Detalle_del_Abogado_Victima_MPIData.Pais_del_Abogado_Victima_Pais.Nombre
                    ,Estado_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Estado_del_Abogado_Victima
                    ,Estado_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Estado_del_Abogado_Victima), "Estado") ??  (string)Detalle_del_Abogado_Victima_MPIData.Estado_del_Abogado_Victima_Estado.Nombre
                    ,Municipio_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Municipio_del_Abogado_Victima
                    ,Municipio_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Municipio_del_Abogado_Victima), "Municipio") ??  (string)Detalle_del_Abogado_Victima_MPIData.Municipio_del_Abogado_Victima_Municipio.Nombre
                    ,Colonia_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Colonia_del_Abogado_Victima
                    ,Colonia_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Victima_MPIData.Colonia_del_Abogado_Victima), "Colonia") ??  (string)Detalle_del_Abogado_Victima_MPIData.Colonia_del_Abogado_Victima_Colonia.Nombre
                    ,Codigo_Postal_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Codigo_Postal_del_Abogado_Victima
                    ,Calle_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Calle_del_Abogado_Victima
                    ,Numero_Exterior_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Numero_Exterior_del_Abogado_Victima
                    ,Numero_Interior_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Numero_Interior_del_Abogado_Victima
                    ,Telefono_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Telefono_del_Abogado_Victima
                    ,Celular_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Celular_del_Abogado_Victima
                    ,Correo_Electronico_del_Abogado_Victima = Detalle_del_Abogado_Victima_MPIData.Correo_Electronico_del_Abogado_Victima
                    ,Aceptar_Notificaciones = Detalle_del_Abogado_Victima_MPIData.Aceptar_Notificaciones.GetValueOrDefault()

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IAbogadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Abogados_Nombre_Completo_del_Abogado_Victima = _IAbogadoApiConsumer.SelAll(true);
            if (Abogados_Nombre_Completo_del_Abogado_Victima != null && Abogados_Nombre_Completo_del_Abogado_Victima.Resource != null)
                ViewBag.Abogados_Nombre_Completo_del_Abogado_Victima = Abogados_Nombre_Completo_del_Abogado_Victima.Resource.Where(m => m.Nombre_Completo != null).OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Abogado", "Nombre_Completo") ?? m.Nombre_Completo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_del_Abogado_Victima = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_del_Abogado_Victima != null && Generos_Sexo_del_Abogado_Victima.Resource != null)
                ViewBag.Generos_Sexo_del_Abogado_Victima = Generos_Sexo_del_Abogado_Victima.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_del_Abogado_Victima = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_del_Abogado_Victima != null && Estado_Civils_Estado_Civil_del_Abogado_Victima.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_del_Abogado_Victima = Estado_Civils_Estado_Civil_del_Abogado_Victima.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_Abogado_Victima = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_Abogado_Victima != null && Tipo_de_Identificacions_Tipo_de_Identificacion_Abogado_Victima.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_Abogado_Victima = Tipo_de_Identificacions_Tipo_de_Identificacion_Abogado_Victima.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_del_Abogado_Victima = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_del_Abogado_Victima != null && Nacionalidads_Nacionalidad_del_Abogado_Victima.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_del_Abogado_Victima = Nacionalidads_Nacionalidad_del_Abogado_Victima.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_del_Abogado_Victima = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_del_Abogado_Victima != null && Paiss_Pais_del_Abogado_Victima.Resource != null)
                ViewBag.Paiss_Pais_del_Abogado_Victima = Paiss_Pais_del_Abogado_Victima.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Abogado_Victima = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Abogado_Victima != null && Estados_Estado_del_Abogado_Victima.Resource != null)
                ViewBag.Estados_Estado_del_Abogado_Victima = Estados_Estado_del_Abogado_Victima.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Abogado_Victima = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Abogado_Victima != null && Municipios_Municipio_del_Abogado_Victima.Resource != null)
                ViewBag.Municipios_Municipio_del_Abogado_Victima = Municipios_Municipio_del_Abogado_Victima.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Abogado_Victima = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Abogado_Victima != null && Colonias_Colonia_del_Abogado_Victima.Resource != null)
                ViewBag.Colonias_Colonia_del_Abogado_Victima = Colonias_Colonia_del_Abogado_Victima.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_del_Abogado_Victima_MPI", varDetalle_del_Abogado_Victima_MPI);
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
        public ActionResult GetAbogadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAbogadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAbogadoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Abogado", "Nombre_Completo")?? m.Nombre_Completo,
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



        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_del_Abogado_Victima_MPIPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_del_Abogado_Victima_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_del_Abogado_Victima_MPIs == null)
                result.Detalle_del_Abogado_Victima_MPIs = new List<Detalle_del_Abogado_Victima_MPI>();

            return Json(new
            {
                data = result.Detalle_del_Abogado_Victima_MPIs.Select(m => new Detalle_del_Abogado_Victima_MPIGridModel
                    {
                    Consecutivo_Victima = m.Consecutivo_Victima
                        ,Nombre_Completo_del_Abogado_VictimaNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Completo_del_Abogado_Victima_Abogado.Clave.ToString(), "Nombre_Completo") ?? (string)m.Nombre_Completo_del_Abogado_Victima_Abogado.Nombre_Completo
			,Nombre_del_Abogado_Victima = m.Nombre_del_Abogado_Victima
			,Apellido_Paterno_del_Abogado_Victima = m.Apellido_Paterno_del_Abogado_Victima
			,Apellido_Materno_del_Abogado_Victima = m.Apellido_Materno_del_Abogado_Victima
                        ,Fecha_de_Nacimiento_del_Abogado_Victima = (m.Fecha_de_Nacimiento_del_Abogado_Victima == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Abogado_Victima).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Abogado_Victima = m.Edad_del_Abogado_Victima
                        ,Sexo_del_Abogado_VictimaDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Abogado_Victima_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_del_Abogado_Victima_Genero.Descripcion
                        ,Estado_Civil_del_Abogado_VictimaDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Abogado_Victima_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_del_Abogado_Victima_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Abogado_Victima_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Abogado_Victima_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_Abogado_Victima = m.Numero_de_Identificacion_Abogado_Victima
                        ,Nacionalidad_del_Abogado_VictimaNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Abogado_Victima_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_del_Abogado_Victima_Nacionalidad.NacionalidadC
			,Cedula_Profesional_del_Abogado_Victima = m.Cedula_Profesional_del_Abogado_Victima
                        ,Pais_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Pais_del_Abogado_Victima_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_del_Abogado_Victima_Pais.Nombre
                        ,Estado_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Estado_del_Abogado_Victima_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Abogado_Victima_Estado.Nombre
                        ,Municipio_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Municipio_del_Abogado_Victima_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Abogado_Victima_Municipio.Nombre
                        ,Colonia_del_Abogado_VictimaNombre = CultureHelper.GetTraduction(m.Colonia_del_Abogado_Victima_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Abogado_Victima_Colonia.Nombre
			,Codigo_Postal_del_Abogado_Victima = m.Codigo_Postal_del_Abogado_Victima
			,Calle_del_Abogado_Victima = m.Calle_del_Abogado_Victima
			,Numero_Exterior_del_Abogado_Victima = m.Numero_Exterior_del_Abogado_Victima
			,Numero_Interior_del_Abogado_Victima = m.Numero_Interior_del_Abogado_Victima
			,Telefono_del_Abogado_Victima = m.Telefono_del_Abogado_Victima
			,Celular_del_Abogado_Victima = m.Celular_del_Abogado_Victima
			,Correo_Electronico_del_Abogado_Victima = m.Correo_Electronico_del_Abogado_Victima
			,Aceptar_Notificaciones = m.Aceptar_Notificaciones

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
                _IDetalle_del_Abogado_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_del_Abogado_Victima_MPI varDetalle_del_Abogado_Victima_MPI = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_del_Abogado_Victima_MPIApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_del_Abogado_Victima_MPIModel varDetalle_del_Abogado_Victima_MPI)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_del_Abogado_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_del_Abogado_Victima_MPIInfo = new Detalle_del_Abogado_Victima_MPI
                    {
                        Consecutivo_Victima = varDetalle_del_Abogado_Victima_MPI.Consecutivo_Victima
                        ,Nombre_Completo_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Nombre_Completo_del_Abogado_Victima
                        ,Nombre_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Nombre_del_Abogado_Victima
                        ,Apellido_Paterno_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Apellido_Paterno_del_Abogado_Victima
                        ,Apellido_Materno_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Apellido_Materno_del_Abogado_Victima
                        ,Fecha_de_Nacimiento_del_Abogado_Victima = (!String.IsNullOrEmpty(varDetalle_del_Abogado_Victima_MPI.Fecha_de_Nacimiento_del_Abogado_Victima)) ? DateTime.ParseExact(varDetalle_del_Abogado_Victima_MPI.Fecha_de_Nacimiento_del_Abogado_Victima, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Edad_del_Abogado_Victima
                        ,Sexo_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Sexo_del_Abogado_Victima
                        ,Estado_Civil_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Estado_Civil_del_Abogado_Victima
                        ,Tipo_de_Identificacion_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Tipo_de_Identificacion_Abogado_Victima
                        ,Numero_de_Identificacion_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Numero_de_Identificacion_Abogado_Victima
                        ,Nacionalidad_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Nacionalidad_del_Abogado_Victima
                        ,Cedula_Profesional_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Cedula_Profesional_del_Abogado_Victima
                        ,Pais_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Pais_del_Abogado_Victima
                        ,Estado_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Estado_del_Abogado_Victima
                        ,Municipio_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Municipio_del_Abogado_Victima
                        ,Colonia_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Colonia_del_Abogado_Victima
                        ,Codigo_Postal_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Codigo_Postal_del_Abogado_Victima
                        ,Calle_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Calle_del_Abogado_Victima
                        ,Numero_Exterior_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Numero_Exterior_del_Abogado_Victima
                        ,Numero_Interior_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Numero_Interior_del_Abogado_Victima
                        ,Telefono_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Telefono_del_Abogado_Victima
                        ,Celular_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Celular_del_Abogado_Victima
                        ,Correo_Electronico_del_Abogado_Victima = varDetalle_del_Abogado_Victima_MPI.Correo_Electronico_del_Abogado_Victima
                        ,Aceptar_Notificaciones = varDetalle_del_Abogado_Victima_MPI.Aceptar_Notificaciones

                    };

                    result = !IsNew ?
                        _IDetalle_del_Abogado_Victima_MPIApiConsumer.Update(Detalle_del_Abogado_Victima_MPIInfo, null, null).Resource.ToString() :
                         _IDetalle_del_Abogado_Victima_MPIApiConsumer.Insert(Detalle_del_Abogado_Victima_MPIInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_del_Abogado_Victima_MPI script
        /// </summary>
        /// <param name="oDetalle_del_Abogado_Victima_MPIElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_del_Abogado_Victima_MPIModuleAttributeList)
        {
            for (int i = 0; i < Detalle_del_Abogado_Victima_MPIModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_del_Abogado_Victima_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_del_Abogado_Victima_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_del_Abogado_Victima_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_del_Abogado_Victima_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_del_Abogado_Victima_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_del_Abogado_Victima_MPIModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_del_Abogado_Victima_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_del_Abogado_Victima_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_del_Abogado_Victima_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_del_Abogado_Victima_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_del_Abogado_Victima_MPIScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_del_Abogado_Victima_MPI.js")))
            {
                strDetalle_del_Abogado_Victima_MPIScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_del_Abogado_Victima_MPI element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_del_Abogado_Victima_MPIModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_del_Abogado_Victima_MPIScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_del_Abogado_Victima_MPIScript.Substring(indexOfArray, strDetalle_del_Abogado_Victima_MPIScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_del_Abogado_Victima_MPIModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_del_Abogado_Victima_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_del_Abogado_Victima_MPIScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_del_Abogado_Victima_MPIScript.Substring(indexOfArrayHistory, strDetalle_del_Abogado_Victima_MPIScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_del_Abogado_Victima_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_del_Abogado_Victima_MPIScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_del_Abogado_Victima_MPIScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_del_Abogado_Victima_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_del_Abogado_Victima_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_del_Abogado_Victima_MPIScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_del_Abogado_Victima_MPIScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_del_Abogado_Victima_MPIScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_del_Abogado_Victima_MPI.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_del_Abogado_Victima_MPI.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_del_Abogado_Victima_MPI.js")))
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
        public ActionResult Detalle_del_Abogado_Victima_MPIPropertyBag()
        {
            return PartialView("Detalle_del_Abogado_Victima_MPIPropertyBag", "Detalle_del_Abogado_Victima_MPI");
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

            _IDetalle_del_Abogado_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_del_Abogado_Victima_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_del_Abogado_Victima_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_del_Abogado_Victima_MPIs == null)
                result.Detalle_del_Abogado_Victima_MPIs = new List<Detalle_del_Abogado_Victima_MPI>();

            var data = result.Detalle_del_Abogado_Victima_MPIs.Select(m => new Detalle_del_Abogado_Victima_MPIGridModel
            {
                Consecutivo_Victima = m.Consecutivo_Victima
                ,Nombre_Completo_del_Abogado_VictimaNombre_Completo = (string)m.Nombre_Completo_del_Abogado_Victima_Abogado.Nombre_Completo
                ,Nombre_del_Abogado_Victima = m.Nombre_del_Abogado_Victima
                ,Apellido_Paterno_del_Abogado_Victima = m.Apellido_Paterno_del_Abogado_Victima
                ,Apellido_Materno_del_Abogado_Victima = m.Apellido_Materno_del_Abogado_Victima
                ,Fecha_de_Nacimiento_del_Abogado_Victima = (m.Fecha_de_Nacimiento_del_Abogado_Victima == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Abogado_Victima).ToString(ConfigurationProperty.DateFormat))
                ,Edad_del_Abogado_Victima = m.Edad_del_Abogado_Victima
                ,Sexo_del_Abogado_VictimaDescripcion = (string)m.Sexo_del_Abogado_Victima_Genero.Descripcion
                ,Estado_Civil_del_Abogado_VictimaDescripcion = (string)m.Estado_Civil_del_Abogado_Victima_Estado_Civil.Descripcion
                ,Tipo_de_Identificacion_Abogado_VictimaNombre = (string)m.Tipo_de_Identificacion_Abogado_Victima_Tipo_de_Identificacion.Nombre
                ,Numero_de_Identificacion_Abogado_Victima = m.Numero_de_Identificacion_Abogado_Victima
                ,Nacionalidad_del_Abogado_VictimaNacionalidadC = (string)m.Nacionalidad_del_Abogado_Victima_Nacionalidad.NacionalidadC
                ,Cedula_Profesional_del_Abogado_Victima = m.Cedula_Profesional_del_Abogado_Victima
                ,Pais_del_Abogado_VictimaNombre = (string)m.Pais_del_Abogado_Victima_Pais.Nombre
                ,Estado_del_Abogado_VictimaNombre = (string)m.Estado_del_Abogado_Victima_Estado.Nombre
                ,Municipio_del_Abogado_VictimaNombre = (string)m.Municipio_del_Abogado_Victima_Municipio.Nombre
                ,Colonia_del_Abogado_VictimaNombre = (string)m.Colonia_del_Abogado_Victima_Colonia.Nombre
                ,Codigo_Postal_del_Abogado_Victima = m.Codigo_Postal_del_Abogado_Victima
                ,Calle_del_Abogado_Victima = m.Calle_del_Abogado_Victima
                ,Numero_Exterior_del_Abogado_Victima = m.Numero_Exterior_del_Abogado_Victima
                ,Numero_Interior_del_Abogado_Victima = m.Numero_Interior_del_Abogado_Victima
                ,Telefono_del_Abogado_Victima = m.Telefono_del_Abogado_Victima
                ,Celular_del_Abogado_Victima = m.Celular_del_Abogado_Victima
                ,Correo_Electronico_del_Abogado_Victima = m.Correo_Electronico_del_Abogado_Victima
                ,Aceptar_Notificaciones = m.Aceptar_Notificaciones

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_del_Abogado_Victima_MPIList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_del_Abogado_Victima_MPIList_" + DateTime.Now.ToString());
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

            _IDetalle_del_Abogado_Victima_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_del_Abogado_Victima_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_del_Abogado_Victima_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_del_Abogado_Victima_MPIs == null)
                result.Detalle_del_Abogado_Victima_MPIs = new List<Detalle_del_Abogado_Victima_MPI>();

            var data = result.Detalle_del_Abogado_Victima_MPIs.Select(m => new Detalle_del_Abogado_Victima_MPIGridModel
            {
                Consecutivo_Victima = m.Consecutivo_Victima
                ,Nombre_Completo_del_Abogado_VictimaNombre_Completo = (string)m.Nombre_Completo_del_Abogado_Victima_Abogado.Nombre_Completo
                ,Nombre_del_Abogado_Victima = m.Nombre_del_Abogado_Victima
                ,Apellido_Paterno_del_Abogado_Victima = m.Apellido_Paterno_del_Abogado_Victima
                ,Apellido_Materno_del_Abogado_Victima = m.Apellido_Materno_del_Abogado_Victima
                ,Fecha_de_Nacimiento_del_Abogado_Victima = (m.Fecha_de_Nacimiento_del_Abogado_Victima == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Abogado_Victima).ToString(ConfigurationProperty.DateFormat))
                ,Edad_del_Abogado_Victima = m.Edad_del_Abogado_Victima
                ,Sexo_del_Abogado_VictimaDescripcion = (string)m.Sexo_del_Abogado_Victima_Genero.Descripcion
                ,Estado_Civil_del_Abogado_VictimaDescripcion = (string)m.Estado_Civil_del_Abogado_Victima_Estado_Civil.Descripcion
                ,Tipo_de_Identificacion_Abogado_VictimaNombre = (string)m.Tipo_de_Identificacion_Abogado_Victima_Tipo_de_Identificacion.Nombre
                ,Numero_de_Identificacion_Abogado_Victima = m.Numero_de_Identificacion_Abogado_Victima
                ,Nacionalidad_del_Abogado_VictimaNacionalidadC = (string)m.Nacionalidad_del_Abogado_Victima_Nacionalidad.NacionalidadC
                ,Cedula_Profesional_del_Abogado_Victima = m.Cedula_Profesional_del_Abogado_Victima
                ,Pais_del_Abogado_VictimaNombre = (string)m.Pais_del_Abogado_Victima_Pais.Nombre
                ,Estado_del_Abogado_VictimaNombre = (string)m.Estado_del_Abogado_Victima_Estado.Nombre
                ,Municipio_del_Abogado_VictimaNombre = (string)m.Municipio_del_Abogado_Victima_Municipio.Nombre
                ,Colonia_del_Abogado_VictimaNombre = (string)m.Colonia_del_Abogado_Victima_Colonia.Nombre
                ,Codigo_Postal_del_Abogado_Victima = m.Codigo_Postal_del_Abogado_Victima
                ,Calle_del_Abogado_Victima = m.Calle_del_Abogado_Victima
                ,Numero_Exterior_del_Abogado_Victima = m.Numero_Exterior_del_Abogado_Victima
                ,Numero_Interior_del_Abogado_Victima = m.Numero_Interior_del_Abogado_Victima
                ,Telefono_del_Abogado_Victima = m.Telefono_del_Abogado_Victima
                ,Celular_del_Abogado_Victima = m.Celular_del_Abogado_Victima
                ,Correo_Electronico_del_Abogado_Victima = m.Correo_Electronico_del_Abogado_Victima
                ,Aceptar_Notificaciones = m.Aceptar_Notificaciones

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
