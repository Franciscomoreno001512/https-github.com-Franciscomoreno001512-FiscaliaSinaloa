using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
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

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_del_Abogado_Imputado_MPI;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
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
    public class Detalle_del_Abogado_Imputado_MPIController : Controller
    {
        #region "variable declaration"

        private IDetalle_del_Abogado_Imputado_MPIService service = null;
        private IDetalle_del_Abogado_Imputado_MPIApiConsumer _IDetalle_del_Abogado_Imputado_MPIApiConsumer;
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

        
        public Detalle_del_Abogado_Imputado_MPIController(IDetalle_del_Abogado_Imputado_MPIService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_del_Abogado_Imputado_MPIApiConsumer Detalle_del_Abogado_Imputado_MPIApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IAbogadoApiConsumer AbogadoApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_del_Abogado_Imputado_MPIApiConsumer = Detalle_del_Abogado_Imputado_MPIApiConsumer;
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

        // GET: Frontal/Detalle_del_Abogado_Imputado_MPI
        [ObjectAuth(ObjectId = (ModuleObjectId)45150, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45150);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_del_Abogado_Imputado_MPI/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45150, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45150);
            ViewBag.Permission = permission;
            var varDetalle_del_Abogado_Imputado_MPI = new Detalle_del_Abogado_Imputado_MPIModel();
			
            ViewBag.ObjectId = "45150";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_del_Abogado_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_del_Abogado_Imputado_MPIData = _IDetalle_del_Abogado_Imputado_MPIApiConsumer.GetByKeyComplete(Id).Resource.Detalle_del_Abogado_Imputado_MPIs[0];
                if (Detalle_del_Abogado_Imputado_MPIData == null)
                    return HttpNotFound();

                varDetalle_del_Abogado_Imputado_MPI = new Detalle_del_Abogado_Imputado_MPIModel
                {
                    Consecutivo = (int)Detalle_del_Abogado_Imputado_MPIData.Consecutivo
                    ,Nombre_Completo_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Nombre_Completo_del_Abogado
                    ,Nombre_Completo_del_AbogadoNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Nombre_Completo_del_Abogado), "Abogado") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Nombre_Completo_del_Abogado_Abogado.Nombre_Completo
                    ,Nombre_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Nombre_del_Abogado
                    ,Apellido_Paterno_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Apellido_Paterno_del_Abogado
                    ,Apellido_Materno_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Apellido_Materno_del_Abogado
                    ,Fecha_de_Nacimiento_del_Abogado = (Detalle_del_Abogado_Imputado_MPIData.Fecha_de_Nacimiento_del_Abogado == null ? string.Empty : Convert.ToDateTime(Detalle_del_Abogado_Imputado_MPIData.Fecha_de_Nacimiento_del_Abogado).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Edad_del_Abogado
                    ,Sexo_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Sexo_del_Abogado
                    ,Sexo_del_AbogadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Sexo_del_Abogado), "Genero") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Sexo_del_Abogado_Genero.Descripcion
                    ,Estado_Civil_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Estado_Civil_del_Abogado
                    ,Estado_Civil_del_AbogadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Estado_Civil_del_Abogado), "Estado_Civil") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Estado_Civil_del_Abogado_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Tipo_de_Identificacion_del_Abogado
                    ,Tipo_de_Identificacion_del_AbogadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Tipo_de_Identificacion_del_Abogado), "Tipo_de_Identificacion") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Tipo_de_Identificacion_del_Abogado_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Numero_de_Identificacion_del_Abogado
                    ,Nacionalidad_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Nacionalidad_del_Abogado
                    ,Nacionalidad_del_AbogadoNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Nacionalidad_del_Abogado), "Nacionalidad") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Nacionalidad_del_Abogado_Nacionalidad.NacionalidadC
                    ,Cedula_Profesional_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Cedula_Profesional_del_Abogado
                    ,Pais_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Pais_del_Abogado
                    ,Pais_del_AbogadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Pais_del_Abogado), "Pais") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Pais_del_Abogado_Pais.Nombre
                    ,Estado_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Estado_del_Abogado
                    ,Estado_del_AbogadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Estado_del_Abogado), "Estado") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Estado_del_Abogado_Estado.Nombre
                    ,Municipio_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Municipio_del_Abogado
                    ,Municipio_del_AbogadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Municipio_del_Abogado), "Municipio") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Municipio_del_Abogado_Municipio.Nombre
                    ,Colonia_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Colonia_del_Abogado
                    ,Colonia_del_AbogadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Colonia_del_Abogado), "Colonia") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Colonia_del_Abogado_Colonia.Nombre
                    ,Codigo_Postal_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Codigo_Postal_del_Abogado
                    ,Calle_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Calle_del_Abogado
                    ,Numero_Exterior_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Numero_Exterior_del_Abogado
                    ,Numero_Interior_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Numero_Interior_del_Abogado
                    ,Telefono_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Telefono_del_Abogado
                    ,Celular_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Celular_del_Abogado
                    ,Correo_Electronico_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Correo_Electronico_del_Abogado
                    ,Aceptar_Notificaciones = Detalle_del_Abogado_Imputado_MPIData.Aceptar_Notificaciones.GetValueOrDefault()

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IAbogadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Abogados_Nombre_Completo_del_Abogado = _IAbogadoApiConsumer.SelAll(true);
            if (Abogados_Nombre_Completo_del_Abogado != null && Abogados_Nombre_Completo_del_Abogado.Resource != null)
                ViewBag.Abogados_Nombre_Completo_del_Abogado = Abogados_Nombre_Completo_del_Abogado.Resource.Where(m => m.Nombre_Completo != null).OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Abogado", "Nombre_Completo") ?? m.Nombre_Completo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_del_Abogado = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_del_Abogado != null && Generos_Sexo_del_Abogado.Resource != null)
                ViewBag.Generos_Sexo_del_Abogado = Generos_Sexo_del_Abogado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_del_Abogado = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_del_Abogado != null && Estado_Civils_Estado_Civil_del_Abogado.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_del_Abogado = Estado_Civils_Estado_Civil_del_Abogado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_del_Abogado = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_del_Abogado != null && Tipo_de_Identificacions_Tipo_de_Identificacion_del_Abogado.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_del_Abogado = Tipo_de_Identificacions_Tipo_de_Identificacion_del_Abogado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_del_Abogado = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_del_Abogado != null && Nacionalidads_Nacionalidad_del_Abogado.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_del_Abogado = Nacionalidads_Nacionalidad_del_Abogado.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_del_Abogado = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_del_Abogado != null && Paiss_Pais_del_Abogado.Resource != null)
                ViewBag.Paiss_Pais_del_Abogado = Paiss_Pais_del_Abogado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Abogado = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Abogado != null && Estados_Estado_del_Abogado.Resource != null)
                ViewBag.Estados_Estado_del_Abogado = Estados_Estado_del_Abogado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Abogado = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Abogado != null && Municipios_Municipio_del_Abogado.Resource != null)
                ViewBag.Municipios_Municipio_del_Abogado = Municipios_Municipio_del_Abogado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Abogado = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Abogado != null && Colonias_Colonia_del_Abogado.Resource != null)
                ViewBag.Colonias_Colonia_del_Abogado = Colonias_Colonia_del_Abogado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_del_Abogado_Imputado_MPI);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_del_Abogado_Imputado_MPI(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45150);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_del_Abogado_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_del_Abogado_Imputado_MPIModel varDetalle_del_Abogado_Imputado_MPI= new Detalle_del_Abogado_Imputado_MPIModel();


            if (id.ToString() != "0")
            {
                var Detalle_del_Abogado_Imputado_MPIsData = _IDetalle_del_Abogado_Imputado_MPIApiConsumer.ListaSelAll(0, 1000, "Detalle_del_Abogado_Imputado_MPI.Consecutivo=" + id, "").Resource.Detalle_del_Abogado_Imputado_MPIs;
				
				if (Detalle_del_Abogado_Imputado_MPIsData != null && Detalle_del_Abogado_Imputado_MPIsData.Count > 0)
                {
					var Detalle_del_Abogado_Imputado_MPIData = Detalle_del_Abogado_Imputado_MPIsData.First();
					varDetalle_del_Abogado_Imputado_MPI= new Detalle_del_Abogado_Imputado_MPIModel
					{
						Consecutivo  = Detalle_del_Abogado_Imputado_MPIData.Consecutivo 
	                    ,Nombre_Completo_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Nombre_Completo_del_Abogado
                    ,Nombre_Completo_del_AbogadoNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Nombre_Completo_del_Abogado), "Abogado") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Nombre_Completo_del_Abogado_Abogado.Nombre_Completo
                    ,Nombre_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Nombre_del_Abogado
                    ,Apellido_Paterno_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Apellido_Paterno_del_Abogado
                    ,Apellido_Materno_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Apellido_Materno_del_Abogado
                    ,Fecha_de_Nacimiento_del_Abogado = (Detalle_del_Abogado_Imputado_MPIData.Fecha_de_Nacimiento_del_Abogado == null ? string.Empty : Convert.ToDateTime(Detalle_del_Abogado_Imputado_MPIData.Fecha_de_Nacimiento_del_Abogado).ToString(ConfigurationProperty.DateFormat))
                    ,Edad_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Edad_del_Abogado
                    ,Sexo_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Sexo_del_Abogado
                    ,Sexo_del_AbogadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Sexo_del_Abogado), "Genero") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Sexo_del_Abogado_Genero.Descripcion
                    ,Estado_Civil_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Estado_Civil_del_Abogado
                    ,Estado_Civil_del_AbogadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Estado_Civil_del_Abogado), "Estado_Civil") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Estado_Civil_del_Abogado_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Tipo_de_Identificacion_del_Abogado
                    ,Tipo_de_Identificacion_del_AbogadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Tipo_de_Identificacion_del_Abogado), "Tipo_de_Identificacion") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Tipo_de_Identificacion_del_Abogado_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Numero_de_Identificacion_del_Abogado
                    ,Nacionalidad_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Nacionalidad_del_Abogado
                    ,Nacionalidad_del_AbogadoNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Nacionalidad_del_Abogado), "Nacionalidad") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Nacionalidad_del_Abogado_Nacionalidad.NacionalidadC
                    ,Cedula_Profesional_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Cedula_Profesional_del_Abogado
                    ,Pais_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Pais_del_Abogado
                    ,Pais_del_AbogadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Pais_del_Abogado), "Pais") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Pais_del_Abogado_Pais.Nombre
                    ,Estado_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Estado_del_Abogado
                    ,Estado_del_AbogadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Estado_del_Abogado), "Estado") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Estado_del_Abogado_Estado.Nombre
                    ,Municipio_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Municipio_del_Abogado
                    ,Municipio_del_AbogadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Municipio_del_Abogado), "Municipio") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Municipio_del_Abogado_Municipio.Nombre
                    ,Colonia_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Colonia_del_Abogado
                    ,Colonia_del_AbogadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_Abogado_Imputado_MPIData.Colonia_del_Abogado), "Colonia") ??  (string)Detalle_del_Abogado_Imputado_MPIData.Colonia_del_Abogado_Colonia.Nombre
                    ,Codigo_Postal_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Codigo_Postal_del_Abogado
                    ,Calle_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Calle_del_Abogado
                    ,Numero_Exterior_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Numero_Exterior_del_Abogado
                    ,Numero_Interior_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Numero_Interior_del_Abogado
                    ,Telefono_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Telefono_del_Abogado
                    ,Celular_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Celular_del_Abogado
                    ,Correo_Electronico_del_Abogado = Detalle_del_Abogado_Imputado_MPIData.Correo_Electronico_del_Abogado
                    ,Aceptar_Notificaciones = Detalle_del_Abogado_Imputado_MPIData.Aceptar_Notificaciones.GetValueOrDefault()

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IAbogadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Abogados_Nombre_Completo_del_Abogado = _IAbogadoApiConsumer.SelAll(true);
            if (Abogados_Nombre_Completo_del_Abogado != null && Abogados_Nombre_Completo_del_Abogado.Resource != null)
                ViewBag.Abogados_Nombre_Completo_del_Abogado = Abogados_Nombre_Completo_del_Abogado.Resource.Where(m => m.Nombre_Completo != null).OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Abogado", "Nombre_Completo") ?? m.Nombre_Completo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Generos_Sexo_del_Abogado = _IGeneroApiConsumer.SelAll(true);
            if (Generos_Sexo_del_Abogado != null && Generos_Sexo_del_Abogado.Resource != null)
                ViewBag.Generos_Sexo_del_Abogado = Generos_Sexo_del_Abogado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Genero", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstado_CivilApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estado_Civils_Estado_Civil_del_Abogado = _IEstado_CivilApiConsumer.SelAll(true);
            if (Estado_Civils_Estado_Civil_del_Abogado != null && Estado_Civils_Estado_Civil_del_Abogado.Resource != null)
                ViewBag.Estado_Civils_Estado_Civil_del_Abogado = Estado_Civils_Estado_Civil_del_Abogado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado_Civil", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_Identificacion_del_Abogado = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_Identificacion_del_Abogado != null && Tipo_de_Identificacions_Tipo_de_Identificacion_del_Abogado.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_Identificacion_del_Abogado = Tipo_de_Identificacions_Tipo_de_Identificacion_del_Abogado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad_del_Abogado = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad_del_Abogado != null && Nacionalidads_Nacionalidad_del_Abogado.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad_del_Abogado = Nacionalidads_Nacionalidad_del_Abogado.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_del_Abogado = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_del_Abogado != null && Paiss_Pais_del_Abogado.Resource != null)
                ViewBag.Paiss_Pais_del_Abogado = Paiss_Pais_del_Abogado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estados_Estado_del_Abogado = _IEstadoApiConsumer.SelAll(true);
            if (Estados_Estado_del_Abogado != null && Estados_Estado_del_Abogado.Resource != null)
                ViewBag.Estados_Estado_del_Abogado = Estados_Estado_del_Abogado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Municipios_Municipio_del_Abogado = _IMunicipioApiConsumer.SelAll(true);
            if (Municipios_Municipio_del_Abogado != null && Municipios_Municipio_del_Abogado.Resource != null)
                ViewBag.Municipios_Municipio_del_Abogado = Municipios_Municipio_del_Abogado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Colonias_Colonia_del_Abogado = _IColoniaApiConsumer.SelAll(true);
            if (Colonias_Colonia_del_Abogado != null && Colonias_Colonia_del_Abogado.Resource != null)
                ViewBag.Colonias_Colonia_del_Abogado = Colonias_Colonia_del_Abogado.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_del_Abogado_Imputado_MPI", varDetalle_del_Abogado_Imputado_MPI);
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_del_Abogado_Imputado_MPIPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_del_Abogado_Imputado_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_del_Abogado_Imputado_MPIs == null)
                result.Detalle_del_Abogado_Imputado_MPIs = new List<Detalle_del_Abogado_Imputado_MPI>();

            return Json(new
            {
                data = result.Detalle_del_Abogado_Imputado_MPIs.Select(m => new Detalle_del_Abogado_Imputado_MPIGridModel
                    {
                    Consecutivo = m.Consecutivo
                        ,Nombre_Completo_del_AbogadoNombre_Completo = CultureHelper.GetTraduction(m.Nombre_Completo_del_Abogado_Abogado.Clave.ToString(), "Nombre_Completo") ?? (string)m.Nombre_Completo_del_Abogado_Abogado.Nombre_Completo
			,Nombre_del_Abogado = m.Nombre_del_Abogado
			,Apellido_Paterno_del_Abogado = m.Apellido_Paterno_del_Abogado
			,Apellido_Materno_del_Abogado = m.Apellido_Materno_del_Abogado
                        ,Fecha_de_Nacimiento_del_Abogado = (m.Fecha_de_Nacimiento_del_Abogado == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Abogado).ToString(ConfigurationProperty.DateFormat))
			,Edad_del_Abogado = m.Edad_del_Abogado
                        ,Sexo_del_AbogadoDescripcion = CultureHelper.GetTraduction(m.Sexo_del_Abogado_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_del_Abogado_Genero.Descripcion
                        ,Estado_Civil_del_AbogadoDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_del_Abogado_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_del_Abogado_Estado_Civil.Descripcion
                        ,Tipo_de_Identificacion_del_AbogadoNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_del_Abogado_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_del_Abogado_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion_del_Abogado = m.Numero_de_Identificacion_del_Abogado
                        ,Nacionalidad_del_AbogadoNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_del_Abogado_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_del_Abogado_Nacionalidad.NacionalidadC
			,Cedula_Profesional_del_Abogado = m.Cedula_Profesional_del_Abogado
                        ,Pais_del_AbogadoNombre = CultureHelper.GetTraduction(m.Pais_del_Abogado_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_del_Abogado_Pais.Nombre
                        ,Estado_del_AbogadoNombre = CultureHelper.GetTraduction(m.Estado_del_Abogado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_del_Abogado_Estado.Nombre
                        ,Municipio_del_AbogadoNombre = CultureHelper.GetTraduction(m.Municipio_del_Abogado_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_del_Abogado_Municipio.Nombre
                        ,Colonia_del_AbogadoNombre = CultureHelper.GetTraduction(m.Colonia_del_Abogado_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_del_Abogado_Colonia.Nombre
			,Codigo_Postal_del_Abogado = m.Codigo_Postal_del_Abogado
			,Calle_del_Abogado = m.Calle_del_Abogado
			,Numero_Exterior_del_Abogado = m.Numero_Exterior_del_Abogado
			,Numero_Interior_del_Abogado = m.Numero_Interior_del_Abogado
			,Telefono_del_Abogado = m.Telefono_del_Abogado
			,Celular_del_Abogado = m.Celular_del_Abogado
			,Correo_Electronico_del_Abogado = m.Correo_Electronico_del_Abogado
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
                _IDetalle_del_Abogado_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_del_Abogado_Imputado_MPI varDetalle_del_Abogado_Imputado_MPI = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_del_Abogado_Imputado_MPIApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_del_Abogado_Imputado_MPIModel varDetalle_del_Abogado_Imputado_MPI)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_del_Abogado_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_del_Abogado_Imputado_MPIInfo = new Detalle_del_Abogado_Imputado_MPI
                    {
                        Consecutivo = varDetalle_del_Abogado_Imputado_MPI.Consecutivo
                        ,Nombre_Completo_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Nombre_Completo_del_Abogado
                        ,Nombre_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Nombre_del_Abogado
                        ,Apellido_Paterno_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Apellido_Paterno_del_Abogado
                        ,Apellido_Materno_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Apellido_Materno_del_Abogado
                        ,Fecha_de_Nacimiento_del_Abogado = (!String.IsNullOrEmpty(varDetalle_del_Abogado_Imputado_MPI.Fecha_de_Nacimiento_del_Abogado)) ? DateTime.ParseExact(varDetalle_del_Abogado_Imputado_MPI.Fecha_de_Nacimiento_del_Abogado, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Edad_del_Abogado
                        ,Sexo_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Sexo_del_Abogado
                        ,Estado_Civil_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Estado_Civil_del_Abogado
                        ,Tipo_de_Identificacion_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Tipo_de_Identificacion_del_Abogado
                        ,Numero_de_Identificacion_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Numero_de_Identificacion_del_Abogado
                        ,Nacionalidad_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Nacionalidad_del_Abogado
                        ,Cedula_Profesional_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Cedula_Profesional_del_Abogado
                        ,Pais_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Pais_del_Abogado
                        ,Estado_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Estado_del_Abogado
                        ,Municipio_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Municipio_del_Abogado
                        ,Colonia_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Colonia_del_Abogado
                        ,Codigo_Postal_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Codigo_Postal_del_Abogado
                        ,Calle_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Calle_del_Abogado
                        ,Numero_Exterior_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Numero_Exterior_del_Abogado
                        ,Numero_Interior_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Numero_Interior_del_Abogado
                        ,Telefono_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Telefono_del_Abogado
                        ,Celular_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Celular_del_Abogado
                        ,Correo_Electronico_del_Abogado = varDetalle_del_Abogado_Imputado_MPI.Correo_Electronico_del_Abogado
                        ,Aceptar_Notificaciones = varDetalle_del_Abogado_Imputado_MPI.Aceptar_Notificaciones

                    };

                    result = !IsNew ?
                        _IDetalle_del_Abogado_Imputado_MPIApiConsumer.Update(Detalle_del_Abogado_Imputado_MPIInfo, null, null).Resource.ToString() :
                         _IDetalle_del_Abogado_Imputado_MPIApiConsumer.Insert(Detalle_del_Abogado_Imputado_MPIInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_del_Abogado_Imputado_MPI script
        /// </summary>
        /// <param name="oDetalle_del_Abogado_Imputado_MPIElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_del_Abogado_Imputado_MPIModuleAttributeList)
        {
            for (int i = 0; i < Detalle_del_Abogado_Imputado_MPIModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_del_Abogado_Imputado_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_del_Abogado_Imputado_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_del_Abogado_Imputado_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_del_Abogado_Imputado_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_del_Abogado_Imputado_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_del_Abogado_Imputado_MPIModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_del_Abogado_Imputado_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_del_Abogado_Imputado_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_del_Abogado_Imputado_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_del_Abogado_Imputado_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_del_Abogado_Imputado_MPIScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_del_Abogado_Imputado_MPI.js")))
            {
                strDetalle_del_Abogado_Imputado_MPIScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_del_Abogado_Imputado_MPI element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_del_Abogado_Imputado_MPIModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_del_Abogado_Imputado_MPIScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_del_Abogado_Imputado_MPIScript.Substring(indexOfArray, strDetalle_del_Abogado_Imputado_MPIScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_del_Abogado_Imputado_MPIModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_del_Abogado_Imputado_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_del_Abogado_Imputado_MPIScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_del_Abogado_Imputado_MPIScript.Substring(indexOfArrayHistory, strDetalle_del_Abogado_Imputado_MPIScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_del_Abogado_Imputado_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_del_Abogado_Imputado_MPIScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_del_Abogado_Imputado_MPIScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_del_Abogado_Imputado_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_del_Abogado_Imputado_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_del_Abogado_Imputado_MPIScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_del_Abogado_Imputado_MPIScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_del_Abogado_Imputado_MPIScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_del_Abogado_Imputado_MPI.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_del_Abogado_Imputado_MPI.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_del_Abogado_Imputado_MPI.js")))
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
        public ActionResult Detalle_del_Abogado_Imputado_MPIPropertyBag()
        {
            return PartialView("Detalle_del_Abogado_Imputado_MPIPropertyBag", "Detalle_del_Abogado_Imputado_MPI");
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

            _IDetalle_del_Abogado_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_del_Abogado_Imputado_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_del_Abogado_Imputado_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_del_Abogado_Imputado_MPIs == null)
                result.Detalle_del_Abogado_Imputado_MPIs = new List<Detalle_del_Abogado_Imputado_MPI>();

            var data = result.Detalle_del_Abogado_Imputado_MPIs.Select(m => new Detalle_del_Abogado_Imputado_MPIGridModel
            {
                Consecutivo = m.Consecutivo
                ,Nombre_Completo_del_AbogadoNombre_Completo = (string)m.Nombre_Completo_del_Abogado_Abogado.Nombre_Completo
                ,Nombre_del_Abogado = m.Nombre_del_Abogado
                ,Apellido_Paterno_del_Abogado = m.Apellido_Paterno_del_Abogado
                ,Apellido_Materno_del_Abogado = m.Apellido_Materno_del_Abogado
                ,Fecha_de_Nacimiento_del_Abogado = (m.Fecha_de_Nacimiento_del_Abogado == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Abogado).ToString(ConfigurationProperty.DateFormat))
                ,Edad_del_Abogado = m.Edad_del_Abogado
                ,Sexo_del_AbogadoDescripcion = (string)m.Sexo_del_Abogado_Genero.Descripcion
                ,Estado_Civil_del_AbogadoDescripcion = (string)m.Estado_Civil_del_Abogado_Estado_Civil.Descripcion
                ,Tipo_de_Identificacion_del_AbogadoNombre = (string)m.Tipo_de_Identificacion_del_Abogado_Tipo_de_Identificacion.Nombre
                ,Numero_de_Identificacion_del_Abogado = m.Numero_de_Identificacion_del_Abogado
                ,Nacionalidad_del_AbogadoNacionalidadC = (string)m.Nacionalidad_del_Abogado_Nacionalidad.NacionalidadC
                ,Cedula_Profesional_del_Abogado = m.Cedula_Profesional_del_Abogado
                ,Pais_del_AbogadoNombre = (string)m.Pais_del_Abogado_Pais.Nombre
                ,Estado_del_AbogadoNombre = (string)m.Estado_del_Abogado_Estado.Nombre
                ,Municipio_del_AbogadoNombre = (string)m.Municipio_del_Abogado_Municipio.Nombre
                ,Colonia_del_AbogadoNombre = (string)m.Colonia_del_Abogado_Colonia.Nombre
                ,Codigo_Postal_del_Abogado = m.Codigo_Postal_del_Abogado
                ,Calle_del_Abogado = m.Calle_del_Abogado
                ,Numero_Exterior_del_Abogado = m.Numero_Exterior_del_Abogado
                ,Numero_Interior_del_Abogado = m.Numero_Interior_del_Abogado
                ,Telefono_del_Abogado = m.Telefono_del_Abogado
                ,Celular_del_Abogado = m.Celular_del_Abogado
                ,Correo_Electronico_del_Abogado = m.Correo_Electronico_del_Abogado
                ,Aceptar_Notificaciones = m.Aceptar_Notificaciones

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_del_Abogado_Imputado_MPIList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_del_Abogado_Imputado_MPIList_" + DateTime.Now.ToString());
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

            _IDetalle_del_Abogado_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_del_Abogado_Imputado_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_del_Abogado_Imputado_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_del_Abogado_Imputado_MPIs == null)
                result.Detalle_del_Abogado_Imputado_MPIs = new List<Detalle_del_Abogado_Imputado_MPI>();

            var data = result.Detalle_del_Abogado_Imputado_MPIs.Select(m => new Detalle_del_Abogado_Imputado_MPIGridModel
            {
                Consecutivo = m.Consecutivo
                ,Nombre_Completo_del_AbogadoNombre_Completo = (string)m.Nombre_Completo_del_Abogado_Abogado.Nombre_Completo
                ,Nombre_del_Abogado = m.Nombre_del_Abogado
                ,Apellido_Paterno_del_Abogado = m.Apellido_Paterno_del_Abogado
                ,Apellido_Materno_del_Abogado = m.Apellido_Materno_del_Abogado
                ,Fecha_de_Nacimiento_del_Abogado = (m.Fecha_de_Nacimiento_del_Abogado == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento_del_Abogado).ToString(ConfigurationProperty.DateFormat))
                ,Edad_del_Abogado = m.Edad_del_Abogado
                ,Sexo_del_AbogadoDescripcion = (string)m.Sexo_del_Abogado_Genero.Descripcion
                ,Estado_Civil_del_AbogadoDescripcion = (string)m.Estado_Civil_del_Abogado_Estado_Civil.Descripcion
                ,Tipo_de_Identificacion_del_AbogadoNombre = (string)m.Tipo_de_Identificacion_del_Abogado_Tipo_de_Identificacion.Nombre
                ,Numero_de_Identificacion_del_Abogado = m.Numero_de_Identificacion_del_Abogado
                ,Nacionalidad_del_AbogadoNacionalidadC = (string)m.Nacionalidad_del_Abogado_Nacionalidad.NacionalidadC
                ,Cedula_Profesional_del_Abogado = m.Cedula_Profesional_del_Abogado
                ,Pais_del_AbogadoNombre = (string)m.Pais_del_Abogado_Pais.Nombre
                ,Estado_del_AbogadoNombre = (string)m.Estado_del_Abogado_Estado.Nombre
                ,Municipio_del_AbogadoNombre = (string)m.Municipio_del_Abogado_Municipio.Nombre
                ,Colonia_del_AbogadoNombre = (string)m.Colonia_del_Abogado_Colonia.Nombre
                ,Codigo_Postal_del_Abogado = m.Codigo_Postal_del_Abogado
                ,Calle_del_Abogado = m.Calle_del_Abogado
                ,Numero_Exterior_del_Abogado = m.Numero_Exterior_del_Abogado
                ,Numero_Interior_del_Abogado = m.Numero_Interior_del_Abogado
                ,Telefono_del_Abogado = m.Telefono_del_Abogado
                ,Celular_del_Abogado = m.Celular_del_Abogado
                ,Correo_Electronico_del_Abogado = m.Correo_Electronico_del_Abogado
                ,Aceptar_Notificaciones = m.Aceptar_Notificaciones

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
