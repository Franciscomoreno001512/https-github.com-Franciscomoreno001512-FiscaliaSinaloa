using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Registro_de_Intervinientes_CC;
using Spartane.Core.Domain.Genero;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.Tipo_de_Identificacion;
using Spartane.Core.Domain.Escolaridad;
using Spartane.Core.Domain.Ocupacion;
using Spartane.Core.Domain.Nacionalidad;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes;




using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Tipo_de_Compareciente;
using Spartane.Core.Domain.Tipo_de_Inimputabilidad;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Registro_de_Intervinientes_CC;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Registro_de_Intervinientes_CC;
using Spartane.Web.Areas.WebApiConsumer.Genero;
using Spartane.Web.Areas.WebApiConsumer.Estado_Civil;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;
using Spartane.Web.Areas.WebApiConsumer.Escolaridad;
using Spartane.Web.Areas.WebApiConsumer.Ocupacion;
using Spartane.Web.Areas.WebApiConsumer.Nacionalidad;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Galeria_de_Intervinientes;


using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Inimputabilidad;

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
    public class Detalle_de_Registro_de_Intervinientes_CCController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Registro_de_Intervinientes_CCService service = null;
        private IDetalle_de_Registro_de_Intervinientes_CCApiConsumer _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer;
        private IGeneroApiConsumer _IGeneroApiConsumer;
        private IEstado_CivilApiConsumer _IEstado_CivilApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;
        private IEscolaridadApiConsumer _IEscolaridadApiConsumer;
        private IOcupacionApiConsumer _IOcupacionApiConsumer;
        private INacionalidadApiConsumer _INacionalidadApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IDetalle_de_Galeria_de_IntervinientesApiConsumer _IDetalle_de_Galeria_de_IntervinientesApiConsumer;


        private ITipo_de_ComparecienteApiConsumer _ITipo_de_ComparecienteApiConsumer;
        private ITipo_de_InimputabilidadApiConsumer _ITipo_de_InimputabilidadApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_de_Registro_de_Intervinientes_CCController(IDetalle_de_Registro_de_Intervinientes_CCService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Registro_de_Intervinientes_CCApiConsumer Detalle_de_Registro_de_Intervinientes_CCApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IGeneroApiConsumer GeneroApiConsumer , IEstado_CivilApiConsumer Estado_CivilApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer , IEscolaridadApiConsumer EscolaridadApiConsumer , IOcupacionApiConsumer OcupacionApiConsumer , INacionalidadApiConsumer NacionalidadApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IPaisApiConsumer PaisApiConsumer , IDetalle_de_Galeria_de_IntervinientesApiConsumer Detalle_de_Galeria_de_IntervinientesApiConsumer  , ITipo_de_ComparecienteApiConsumer Tipo_de_ComparecienteApiConsumer , ITipo_de_InimputabilidadApiConsumer Tipo_de_InimputabilidadApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Registro_de_Intervinientes_CCApiConsumer = Detalle_de_Registro_de_Intervinientes_CCApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IGeneroApiConsumer = GeneroApiConsumer;
            this._IEstado_CivilApiConsumer = Estado_CivilApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;
            this._IEscolaridadApiConsumer = EscolaridadApiConsumer;
            this._IOcupacionApiConsumer = OcupacionApiConsumer;
            this._INacionalidadApiConsumer = NacionalidadApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IDetalle_de_Galeria_de_IntervinientesApiConsumer = Detalle_de_Galeria_de_IntervinientesApiConsumer;


            this._IPaisApiConsumer = PaisApiConsumer;
            this._ITipo_de_ComparecienteApiConsumer = Tipo_de_ComparecienteApiConsumer;
            this._ITipo_de_InimputabilidadApiConsumer = Tipo_de_InimputabilidadApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Registro_de_Intervinientes_CC
        [ObjectAuth(ObjectId = (ModuleObjectId)45139, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45139);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_de_Registro_de_Intervinientes_CC/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45139, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45139);
            ViewBag.Permission = permission;
            var varDetalle_de_Registro_de_Intervinientes_CC = new Detalle_de_Registro_de_Intervinientes_CCModel();
			
            ViewBag.ObjectId = "45139";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_de_Galeria_de_Intervinientes = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45217, ModuleId);
            ViewBag.PermissionDetalle_de_Galeria_de_Intervinientes = permissionDetalle_de_Galeria_de_Intervinientes;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Registro_de_Intervinientes_CCData = _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.GetByKeyComplete(Id).Resource.Detalle_de_Registro_de_Intervinientes_CCs[0];
                if (Detalle_de_Registro_de_Intervinientes_CCData == null)
                    return HttpNotFound();

                varDetalle_de_Registro_de_Intervinientes_CC = new Detalle_de_Registro_de_Intervinientes_CCModel
                {
                    Clave = (int)Detalle_de_Registro_de_Intervinientes_CCData.Clave
                    ,Nombres = Detalle_de_Registro_de_Intervinientes_CCData.Nombres
                    ,Apellido_Paterno = Detalle_de_Registro_de_Intervinientes_CCData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Registro_de_Intervinientes_CCData.Apellido_Materno
                    ,Alias = Detalle_de_Registro_de_Intervinientes_CCData.Alias
                    ,Anonimo = Detalle_de_Registro_de_Intervinientes_CCData.Anonimo.GetValueOrDefault()
                    ,Fecha_de_Nacimiento = (Detalle_de_Registro_de_Intervinientes_CCData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Registro_de_Intervinientes_CCData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Detalle_de_Registro_de_Intervinientes_CCData.Edad
                    ,Sexo = Detalle_de_Registro_de_Intervinientes_CCData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Sexo), "Genero") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Detalle_de_Registro_de_Intervinientes_CCData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Estado_Civil), "Estado_Civil") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Detalle_de_Registro_de_Intervinientes_CCData.Numero_de_Identificacion
                    ,Escolaridad = Detalle_de_Registro_de_Intervinientes_CCData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Escolaridad), "Escolaridad") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Detalle_de_Registro_de_Intervinientes_CCData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Ocupacion), "Ocupacion") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Ocupacion_Ocupacion.Descripcion
                    ,Nacionalidad = Detalle_de_Registro_de_Intervinientes_CCData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Estado = Detalle_de_Registro_de_Intervinientes_CCData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Estado), "Estado") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Registro_de_Intervinientes_CCData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Municipio), "Municipio") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Municipio_Municipio.Nombre
                    ,Colonia = Detalle_de_Registro_de_Intervinientes_CCData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Colonia), "Colonia") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Detalle_de_Registro_de_Intervinientes_CCData.Codigo_Postal
                    ,Calle = Detalle_de_Registro_de_Intervinientes_CCData.Calle
                    ,Numero_Exterior = Detalle_de_Registro_de_Intervinientes_CCData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Registro_de_Intervinientes_CCData.Numero_Interior
                    ,Telefono = Detalle_de_Registro_de_Intervinientes_CCData.Telefono
                    ,Celular = Detalle_de_Registro_de_Intervinientes_CCData.Celular
                    ,Correo_Electronico = Detalle_de_Registro_de_Intervinientes_CCData.Correo_Electronico
                    ,Pais = Detalle_de_Registro_de_Intervinientes_CCData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Pais), "Pais") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Pais_Pais.Nombre
                    ,Entre_calle = Detalle_de_Registro_de_Intervinientes_CCData.Entre_calle
                    ,Especifique = Detalle_de_Registro_de_Intervinientes_CCData.Especifique
                    ,Extension = Detalle_de_Registro_de_Intervinientes_CCData.Extension
                    ,Inimputable = Detalle_de_Registro_de_Intervinientes_CCData.Inimputable.GetValueOrDefault()
                    ,Nombre_Completo = Detalle_de_Registro_de_Intervinientes_CCData.Nombre_Completo
                    ,Originario_de = Detalle_de_Registro_de_Intervinientes_CCData.Originario_de
                    ,Pais_de_Origen = Detalle_de_Registro_de_Intervinientes_CCData.Pais_de_Origen
                    ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Pais_de_Origen), "Pais") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Pais_de_Origen_Pais.Nombre
                    ,Proteccion_de_Datos = Detalle_de_Registro_de_Intervinientes_CCData.Proteccion_de_Datos.GetValueOrDefault()
                    ,Referencia_de_Domicilio = Detalle_de_Registro_de_Intervinientes_CCData.Referencia_de_Domicilio
                    ,Y_calle = Detalle_de_Registro_de_Intervinientes_CCData.Y_calle
                    ,Tipo_de_Compareciente = Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_Compareciente
                    ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_Compareciente), "Tipo_de_Compareciente") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                    ,Tipo_de_inimputabilidad = Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_inimputabilidad
                    ,Tipo_de_inimputabilidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_inimputabilidad), "Tipo_de_Inimputabilidad") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
                    ,Nombre = Detalle_de_Registro_de_Intervinientes_CCData.Nombre

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
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad != null && Nacionalidads_Nacionalidad.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad = Nacionalidads_Nacionalidad.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
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
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais != null && Paiss_Pais.Resource != null)
                ViewBag.Paiss_Pais = Paiss_Pais.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_de_Origen = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_de_Origen != null && Paiss_Pais_de_Origen.Resource != null)
                ViewBag.Paiss_Pais_de_Origen = Paiss_Pais_de_Origen.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inimputabilidads_Tipo_de_inimputabilidad = _ITipo_de_InimputabilidadApiConsumer.SelAll(true);
            if (Tipo_de_Inimputabilidads_Tipo_de_inimputabilidad != null && Tipo_de_Inimputabilidads_Tipo_de_inimputabilidad.Resource != null)
                ViewBag.Tipo_de_Inimputabilidads_Tipo_de_inimputabilidad = Tipo_de_Inimputabilidads_Tipo_de_inimputabilidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_de_Registro_de_Intervinientes_CC);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Registro_de_Intervinientes_CC(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45139);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Registro_de_Intervinientes_CCModel varDetalle_de_Registro_de_Intervinientes_CC= new Detalle_de_Registro_de_Intervinientes_CCModel();
            var permissionDetalle_de_Galeria_de_Intervinientes = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45217, ModuleId);
            ViewBag.PermissionDetalle_de_Galeria_de_Intervinientes = permissionDetalle_de_Galeria_de_Intervinientes;


            if (id.ToString() != "0")
            {
                var Detalle_de_Registro_de_Intervinientes_CCsData = _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Registro_de_Intervinientes_CC.Clave=" + id, "").Resource.Detalle_de_Registro_de_Intervinientes_CCs;
				
				if (Detalle_de_Registro_de_Intervinientes_CCsData != null && Detalle_de_Registro_de_Intervinientes_CCsData.Count > 0)
                {
					var Detalle_de_Registro_de_Intervinientes_CCData = Detalle_de_Registro_de_Intervinientes_CCsData.First();
					varDetalle_de_Registro_de_Intervinientes_CC= new Detalle_de_Registro_de_Intervinientes_CCModel
					{
						Clave  = Detalle_de_Registro_de_Intervinientes_CCData.Clave 
	                    ,Nombres = Detalle_de_Registro_de_Intervinientes_CCData.Nombres
                    ,Apellido_Paterno = Detalle_de_Registro_de_Intervinientes_CCData.Apellido_Paterno
                    ,Apellido_Materno = Detalle_de_Registro_de_Intervinientes_CCData.Apellido_Materno
                    ,Alias = Detalle_de_Registro_de_Intervinientes_CCData.Alias
                    ,Anonimo = Detalle_de_Registro_de_Intervinientes_CCData.Anonimo.GetValueOrDefault()
                    ,Fecha_de_Nacimiento = (Detalle_de_Registro_de_Intervinientes_CCData.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Registro_de_Intervinientes_CCData.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Edad = Detalle_de_Registro_de_Intervinientes_CCData.Edad
                    ,Sexo = Detalle_de_Registro_de_Intervinientes_CCData.Sexo
                    ,SexoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Sexo), "Genero") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Sexo_Genero.Descripcion
                    ,Estado_Civil = Detalle_de_Registro_de_Intervinientes_CCData.Estado_Civil
                    ,Estado_CivilDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Estado_Civil), "Estado_Civil") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Estado_Civil_Estado_Civil.Descripcion
                    ,Tipo_de_Identificacion = Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_Identificacion
                    ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_Identificacion), "Tipo_de_Identificacion") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                    ,Numero_de_Identificacion = Detalle_de_Registro_de_Intervinientes_CCData.Numero_de_Identificacion
                    ,Escolaridad = Detalle_de_Registro_de_Intervinientes_CCData.Escolaridad
                    ,EscolaridadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Escolaridad), "Escolaridad") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Escolaridad_Escolaridad.Descripcion
                    ,Ocupacion = Detalle_de_Registro_de_Intervinientes_CCData.Ocupacion
                    ,OcupacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Ocupacion), "Ocupacion") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Ocupacion_Ocupacion.Descripcion
                    ,Nacionalidad = Detalle_de_Registro_de_Intervinientes_CCData.Nacionalidad
                    ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Nacionalidad), "Nacionalidad") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Nacionalidad_Nacionalidad.NacionalidadC
                    ,Estado = Detalle_de_Registro_de_Intervinientes_CCData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Estado), "Estado") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Registro_de_Intervinientes_CCData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Municipio), "Municipio") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Municipio_Municipio.Nombre
                    ,Colonia = Detalle_de_Registro_de_Intervinientes_CCData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Colonia), "Colonia") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Detalle_de_Registro_de_Intervinientes_CCData.Codigo_Postal
                    ,Calle = Detalle_de_Registro_de_Intervinientes_CCData.Calle
                    ,Numero_Exterior = Detalle_de_Registro_de_Intervinientes_CCData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Registro_de_Intervinientes_CCData.Numero_Interior
                    ,Telefono = Detalle_de_Registro_de_Intervinientes_CCData.Telefono
                    ,Celular = Detalle_de_Registro_de_Intervinientes_CCData.Celular
                    ,Correo_Electronico = Detalle_de_Registro_de_Intervinientes_CCData.Correo_Electronico
                    ,Pais = Detalle_de_Registro_de_Intervinientes_CCData.Pais
                    ,PaisNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Pais), "Pais") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Pais_Pais.Nombre
                    ,Entre_calle = Detalle_de_Registro_de_Intervinientes_CCData.Entre_calle
                    ,Especifique = Detalle_de_Registro_de_Intervinientes_CCData.Especifique
                    ,Extension = Detalle_de_Registro_de_Intervinientes_CCData.Extension
                    ,Inimputable = Detalle_de_Registro_de_Intervinientes_CCData.Inimputable.GetValueOrDefault()
                    ,Nombre_Completo = Detalle_de_Registro_de_Intervinientes_CCData.Nombre_Completo
                    ,Originario_de = Detalle_de_Registro_de_Intervinientes_CCData.Originario_de
                    ,Pais_de_Origen = Detalle_de_Registro_de_Intervinientes_CCData.Pais_de_Origen
                    ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Pais_de_Origen), "Pais") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Pais_de_Origen_Pais.Nombre
                    ,Proteccion_de_Datos = Detalle_de_Registro_de_Intervinientes_CCData.Proteccion_de_Datos.GetValueOrDefault()
                    ,Referencia_de_Domicilio = Detalle_de_Registro_de_Intervinientes_CCData.Referencia_de_Domicilio
                    ,Y_calle = Detalle_de_Registro_de_Intervinientes_CCData.Y_calle
                    ,Tipo_de_Compareciente = Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_Compareciente
                    ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_Compareciente), "Tipo_de_Compareciente") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                    ,Tipo_de_inimputabilidad = Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_inimputabilidad
                    ,Tipo_de_inimputabilidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_inimputabilidad), "Tipo_de_Inimputabilidad") ??  (string)Detalle_de_Registro_de_Intervinientes_CCData.Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
                    ,Nombre = Detalle_de_Registro_de_Intervinientes_CCData.Nombre

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
            _INacionalidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Nacionalidads_Nacionalidad = _INacionalidadApiConsumer.SelAll(true);
            if (Nacionalidads_Nacionalidad != null && Nacionalidads_Nacionalidad.Resource != null)
                ViewBag.Nacionalidads_Nacionalidad = Nacionalidads_Nacionalidad.Resource.Where(m => m.NacionalidadC != null).OrderBy(m => m.NacionalidadC).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Nacionalidad", "NacionalidadC") ?? m.NacionalidadC.ToString(), Value = Convert.ToString(m.Clave)
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
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais != null && Paiss_Pais.Resource != null)
                ViewBag.Paiss_Pais = Paiss_Pais.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Paiss_Pais_de_Origen = _IPaisApiConsumer.SelAll(true);
            if (Paiss_Pais_de_Origen != null && Paiss_Pais_de_Origen.Resource != null)
                ViewBag.Paiss_Pais_de_Origen = Paiss_Pais_de_Origen.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Comparecientes_Tipo_de_Compareciente = _ITipo_de_ComparecienteApiConsumer.SelAll(true);
            if (Tipo_de_Comparecientes_Tipo_de_Compareciente != null && Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource != null)
                ViewBag.Tipo_de_Comparecientes_Tipo_de_Compareciente = Tipo_de_Comparecientes_Tipo_de_Compareciente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Compareciente", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InimputabilidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inimputabilidads_Tipo_de_inimputabilidad = _ITipo_de_InimputabilidadApiConsumer.SelAll(true);
            if (Tipo_de_Inimputabilidads_Tipo_de_inimputabilidad != null && Tipo_de_Inimputabilidads_Tipo_de_inimputabilidad.Resource != null)
                ViewBag.Tipo_de_Inimputabilidads_Tipo_de_inimputabilidad = Tipo_de_Inimputabilidads_Tipo_de_inimputabilidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inimputabilidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Registro_de_Intervinientes_CC", varDetalle_de_Registro_de_Intervinientes_CC);
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



        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Registro_de_Intervinientes_CCPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Registro_de_Intervinientes_CCs == null)
                result.Detalle_de_Registro_de_Intervinientes_CCs = new List<Detalle_de_Registro_de_Intervinientes_CC>();

            return Json(new
            {
                data = result.Detalle_de_Registro_de_Intervinientes_CCs.Select(m => new Detalle_de_Registro_de_Intervinientes_CCGridModel
                    {
                    Clave = m.Clave
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Alias = m.Alias
			,Anonimo = m.Anonimo
                        ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
			,Edad = m.Edad
                        ,SexoDescripcion = CultureHelper.GetTraduction(m.Sexo_Genero.Clave.ToString(), "Descripcion") ?? (string)m.Sexo_Genero.Descripcion
                        ,Estado_CivilDescripcion = CultureHelper.GetTraduction(m.Estado_Civil_Estado_Civil.Clave.ToString(), "Descripcion") ?? (string)m.Estado_Civil_Estado_Civil.Descripcion
                        ,Tipo_de_IdentificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_Identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
			,Numero_de_Identificacion = m.Numero_de_Identificacion
                        ,EscolaridadDescripcion = CultureHelper.GetTraduction(m.Escolaridad_Escolaridad.Clave.ToString(), "Descripcion") ?? (string)m.Escolaridad_Escolaridad.Descripcion
                        ,OcupacionDescripcion = CultureHelper.GetTraduction(m.Ocupacion_Ocupacion.Clave.ToString(), "Descripcion") ?? (string)m.Ocupacion_Ocupacion.Descripcion
                        ,NacionalidadNacionalidadC = CultureHelper.GetTraduction(m.Nacionalidad_Nacionalidad.Clave.ToString(), "NacionalidadC") ?? (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Nombre") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Nombre") ?? (string)m.Municipio_Municipio.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Nombre") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior
			,Telefono = m.Telefono
			,Celular = m.Celular
			,Correo_Electronico = m.Correo_Electronico
                        ,PaisNombre = CultureHelper.GetTraduction(m.Pais_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_Pais.Nombre
			,Entre_calle = m.Entre_calle
			,Especifique = m.Especifique
			,Extension = m.Extension
			,Inimputable = m.Inimputable
			,Nombre_Completo = m.Nombre_Completo
			,Originario_de = m.Originario_de
                        ,Pais_de_OrigenNombre = CultureHelper.GetTraduction(m.Pais_de_Origen_Pais.Clave.ToString(), "Nombre") ?? (string)m.Pais_de_Origen_Pais.Nombre
			,Proteccion_de_Datos = m.Proteccion_de_Datos
			,Referencia_de_Domicilio = m.Referencia_de_Domicilio
			,Y_calle = m.Y_calle
                        ,Tipo_de_ComparecienteDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Compareciente_Tipo_de_Compareciente.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                        ,Tipo_de_inimputabilidadDescripcion = CultureHelper.GetTraduction(m.Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
			,Nombre = m.Nombre

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

        public ActionResult GetDetalle_de_Galeria_de_Intervinientes(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Galeria_de_IntervinientesGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Galeria_de_IntervinientesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Galeria_de_Intervinientes.Detalle_de_Intervinientes=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Galeria_de_Intervinientes.Detalle_de_Intervinientes='" + RelationId + "'";
            }
            var result = _IDetalle_de_Galeria_de_IntervinientesApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Galeria_de_Intervinientess == null)
                result.Detalle_de_Galeria_de_Intervinientess = new List<Detalle_de_Galeria_de_Intervinientes>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Galeria_de_Intervinientess.Select(m => new Detalle_de_Galeria_de_IntervinientesGridModel
                {
                    Clave = m.Clave

			,Nombre = m.Nombre
			,Archivo = m.Archivo

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Galeria_de_IntervinientesGridModel> GetDetalle_de_Galeria_de_IntervinientesData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Galeria_de_IntervinientesGridModel> resultData = new List<Detalle_de_Galeria_de_IntervinientesGridModel>();
            string where = "Detalle_de_Galeria_de_Intervinientes.Detalle_de_Intervinientes=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Galeria_de_Intervinientes.Detalle_de_Intervinientes='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Galeria_de_IntervinientesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Galeria_de_IntervinientesApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Galeria_de_Intervinientess != null)
            {
                resultData = result.Detalle_de_Galeria_de_Intervinientess.Select(m => new Detalle_de_Galeria_de_IntervinientesGridModel
                    {
                        Clave = m.Clave

			,Nombre = m.Nombre
			,Archivo = m.Archivo


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
                _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Registro_de_Intervinientes_CC varDetalle_de_Registro_de_Intervinientes_CC = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_de_Galeria_de_IntervinientesApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Galeria_de_Intervinientes.Detalle_de_Intervinientes=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Galeria_de_Intervinientes.Detalle_de_Intervinientes='" + id + "'";
                    }
                    var Detalle_de_Galeria_de_IntervinientesInfo =
                        _IDetalle_de_Galeria_de_IntervinientesApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Galeria_de_IntervinientesInfo.Detalle_de_Galeria_de_Intervinientess.Count > 0)
                    {
                        var resultDetalle_de_Galeria_de_Intervinientes = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Galeria_de_IntervinientesItem in Detalle_de_Galeria_de_IntervinientesInfo.Detalle_de_Galeria_de_Intervinientess)
                            resultDetalle_de_Galeria_de_Intervinientes = resultDetalle_de_Galeria_de_Intervinientes
                                              && _IDetalle_de_Galeria_de_IntervinientesApiConsumer.Delete(Detalle_de_Galeria_de_IntervinientesItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Galeria_de_Intervinientes)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Registro_de_Intervinientes_CCModel varDetalle_de_Registro_de_Intervinientes_CC)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_Registro_de_Intervinientes_CCInfo = new Detalle_de_Registro_de_Intervinientes_CC
                    {
                        Clave = varDetalle_de_Registro_de_Intervinientes_CC.Clave
                        ,Nombres = varDetalle_de_Registro_de_Intervinientes_CC.Nombres
                        ,Apellido_Paterno = varDetalle_de_Registro_de_Intervinientes_CC.Apellido_Paterno
                        ,Apellido_Materno = varDetalle_de_Registro_de_Intervinientes_CC.Apellido_Materno
                        ,Alias = varDetalle_de_Registro_de_Intervinientes_CC.Alias
                        ,Anonimo = varDetalle_de_Registro_de_Intervinientes_CC.Anonimo
                        ,Fecha_de_Nacimiento = (!String.IsNullOrEmpty(varDetalle_de_Registro_de_Intervinientes_CC.Fecha_de_Nacimiento)) ? DateTime.ParseExact(varDetalle_de_Registro_de_Intervinientes_CC.Fecha_de_Nacimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Edad = varDetalle_de_Registro_de_Intervinientes_CC.Edad
                        ,Sexo = varDetalle_de_Registro_de_Intervinientes_CC.Sexo
                        ,Estado_Civil = varDetalle_de_Registro_de_Intervinientes_CC.Estado_Civil
                        ,Tipo_de_Identificacion = varDetalle_de_Registro_de_Intervinientes_CC.Tipo_de_Identificacion
                        ,Numero_de_Identificacion = varDetalle_de_Registro_de_Intervinientes_CC.Numero_de_Identificacion
                        ,Escolaridad = varDetalle_de_Registro_de_Intervinientes_CC.Escolaridad
                        ,Ocupacion = varDetalle_de_Registro_de_Intervinientes_CC.Ocupacion
                        ,Nacionalidad = varDetalle_de_Registro_de_Intervinientes_CC.Nacionalidad
                        ,Estado = varDetalle_de_Registro_de_Intervinientes_CC.Estado
                        ,Municipio = varDetalle_de_Registro_de_Intervinientes_CC.Municipio
                        ,Colonia = varDetalle_de_Registro_de_Intervinientes_CC.Colonia
                        ,Codigo_Postal = varDetalle_de_Registro_de_Intervinientes_CC.Codigo_Postal
                        ,Calle = varDetalle_de_Registro_de_Intervinientes_CC.Calle
                        ,Numero_Exterior = varDetalle_de_Registro_de_Intervinientes_CC.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Registro_de_Intervinientes_CC.Numero_Interior
                        ,Telefono = varDetalle_de_Registro_de_Intervinientes_CC.Telefono
                        ,Celular = varDetalle_de_Registro_de_Intervinientes_CC.Celular
                        ,Correo_Electronico = varDetalle_de_Registro_de_Intervinientes_CC.Correo_Electronico
                        ,Pais = varDetalle_de_Registro_de_Intervinientes_CC.Pais
                        ,Entre_calle = varDetalle_de_Registro_de_Intervinientes_CC.Entre_calle
                        ,Especifique = varDetalle_de_Registro_de_Intervinientes_CC.Especifique
                        ,Extension = varDetalle_de_Registro_de_Intervinientes_CC.Extension
                        ,Inimputable = varDetalle_de_Registro_de_Intervinientes_CC.Inimputable
                        ,Nombre_Completo = varDetalle_de_Registro_de_Intervinientes_CC.Nombre_Completo
                        ,Originario_de = varDetalle_de_Registro_de_Intervinientes_CC.Originario_de
                        ,Pais_de_Origen = varDetalle_de_Registro_de_Intervinientes_CC.Pais_de_Origen
                        ,Proteccion_de_Datos = varDetalle_de_Registro_de_Intervinientes_CC.Proteccion_de_Datos
                        ,Referencia_de_Domicilio = varDetalle_de_Registro_de_Intervinientes_CC.Referencia_de_Domicilio
                        ,Y_calle = varDetalle_de_Registro_de_Intervinientes_CC.Y_calle
                        ,Tipo_de_Compareciente = varDetalle_de_Registro_de_Intervinientes_CC.Tipo_de_Compareciente
                        ,Tipo_de_inimputabilidad = varDetalle_de_Registro_de_Intervinientes_CC.Tipo_de_inimputabilidad
                        ,Nombre = varDetalle_de_Registro_de_Intervinientes_CC.Nombre

                    };

                    result = !IsNew ?
                        _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.Update(Detalle_de_Registro_de_Intervinientes_CCInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.Insert(Detalle_de_Registro_de_Intervinientes_CCInfo, null, null).Resource.ToString();

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
        public bool CopyDetalle_de_Galeria_de_Intervinientes(int MasterId, int referenceId, List<Detalle_de_Galeria_de_IntervinientesGridModelPost> Detalle_de_Galeria_de_IntervinientesItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Galeria_de_IntervinientesApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Galeria_de_IntervinientesData = _IDetalle_de_Galeria_de_IntervinientesApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Galeria_de_Intervinientes.Detalle_de_Intervinientes=" + referenceId,"").Resource;
                if (Detalle_de_Galeria_de_IntervinientesData == null || Detalle_de_Galeria_de_IntervinientesData.Detalle_de_Galeria_de_Intervinientess.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Galeria_de_IntervinientesGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Galeria_de_Intervinientes in Detalle_de_Galeria_de_IntervinientesData.Detalle_de_Galeria_de_Intervinientess)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Galeria_de_Intervinientes Detalle_de_Galeria_de_Intervinientes1 = varDetalle_de_Galeria_de_Intervinientes;

                    if (Detalle_de_Galeria_de_IntervinientesItems != null && Detalle_de_Galeria_de_IntervinientesItems.Any(m => m.Clave == Detalle_de_Galeria_de_Intervinientes1.Clave))
                    {
                        modelDataToChange = Detalle_de_Galeria_de_IntervinientesItems.FirstOrDefault(m => m.Clave == Detalle_de_Galeria_de_Intervinientes1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Galeria_de_Intervinientes.Detalle_de_Intervinientes = MasterId;
                    var insertId = _IDetalle_de_Galeria_de_IntervinientesApiConsumer.Insert(varDetalle_de_Galeria_de_Intervinientes,null,null).Resource;
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
        public ActionResult PostDetalle_de_Galeria_de_Intervinientes(List<Detalle_de_Galeria_de_IntervinientesGridModelPost> Detalle_de_Galeria_de_IntervinientesItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Galeria_de_Intervinientes(MasterId, referenceId, Detalle_de_Galeria_de_IntervinientesItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Galeria_de_IntervinientesItems != null && Detalle_de_Galeria_de_IntervinientesItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Galeria_de_IntervinientesApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Galeria_de_IntervinientesItem in Detalle_de_Galeria_de_IntervinientesItems)
                    {




                        //Removal Request
                        if (Detalle_de_Galeria_de_IntervinientesItem.Removed)
                        {
                            result = result && _IDetalle_de_Galeria_de_IntervinientesApiConsumer.Delete(Detalle_de_Galeria_de_IntervinientesItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Galeria_de_IntervinientesItem.Clave = 0;

                        var Detalle_de_Galeria_de_IntervinientesData = new Detalle_de_Galeria_de_Intervinientes
                        {
                            Detalle_de_Intervinientes = MasterId
                            ,Clave = Detalle_de_Galeria_de_IntervinientesItem.Clave
                            ,Nombre = Detalle_de_Galeria_de_IntervinientesItem.Nombre
                            ,Archivo = Detalle_de_Galeria_de_IntervinientesItem.Archivo

                        };

                        var resultId = Detalle_de_Galeria_de_IntervinientesItem.Clave > 0
                           ? _IDetalle_de_Galeria_de_IntervinientesApiConsumer.Update(Detalle_de_Galeria_de_IntervinientesData,null,null).Resource
                           : _IDetalle_de_Galeria_de_IntervinientesApiConsumer.Insert(Detalle_de_Galeria_de_IntervinientesData,null,null).Resource;

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







        /// <summary>
        /// Write Element Array of Detalle_de_Registro_de_Intervinientes_CC script
        /// </summary>
        /// <param name="oDetalle_de_Registro_de_Intervinientes_CCElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_de_Registro_de_Intervinientes_CCScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Registro_de_Intervinientes_CC.js")))
            {
                strDetalle_de_Registro_de_Intervinientes_CCScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Registro_de_Intervinientes_CC element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Registro_de_Intervinientes_CCScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Registro_de_Intervinientes_CCScript.Substring(indexOfArray, strDetalle_de_Registro_de_Intervinientes_CCScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Registro_de_Intervinientes_CCScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_de_Registro_de_Intervinientes_CCScript.Substring(indexOfArrayHistory, strDetalle_de_Registro_de_Intervinientes_CCScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_de_Registro_de_Intervinientes_CCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Registro_de_Intervinientes_CCScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Registro_de_Intervinientes_CCScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_de_Registro_de_Intervinientes_CCModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_de_Registro_de_Intervinientes_CCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_de_Registro_de_Intervinientes_CCScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_de_Registro_de_Intervinientes_CCScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_de_Registro_de_Intervinientes_CCScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Registro_de_Intervinientes_CC.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Registro_de_Intervinientes_CC.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Registro_de_Intervinientes_CC.js")))
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
        public ActionResult Detalle_de_Registro_de_Intervinientes_CCPropertyBag()
        {
            return PartialView("Detalle_de_Registro_de_Intervinientes_CCPropertyBag", "Detalle_de_Registro_de_Intervinientes_CC");
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
        public ActionResult AddDetalle_de_Galeria_de_Intervinientes(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Galeria_de_Intervinientes/AddDetalle_de_Galeria_de_Intervinientes");
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

            _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Registro_de_Intervinientes_CCPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Registro_de_Intervinientes_CCs == null)
                result.Detalle_de_Registro_de_Intervinientes_CCs = new List<Detalle_de_Registro_de_Intervinientes_CC>();

            var data = result.Detalle_de_Registro_de_Intervinientes_CCs.Select(m => new Detalle_de_Registro_de_Intervinientes_CCGridModel
            {
                Clave = m.Clave
                ,Nombres = m.Nombres
                ,Apellido_Paterno = m.Apellido_Paterno
                ,Apellido_Materno = m.Apellido_Materno
                ,Alias = m.Alias
                ,Anonimo = m.Anonimo
                ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                ,Edad = m.Edad
                ,SexoDescripcion = (string)m.Sexo_Genero.Descripcion
                ,Estado_CivilDescripcion = (string)m.Estado_Civil_Estado_Civil.Descripcion
                ,Tipo_de_IdentificacionNombre = (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                ,Numero_de_Identificacion = m.Numero_de_Identificacion
                ,EscolaridadDescripcion = (string)m.Escolaridad_Escolaridad.Descripcion
                ,OcupacionDescripcion = (string)m.Ocupacion_Ocupacion.Descripcion
                ,NacionalidadNacionalidadC = (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                ,EstadoNombre = (string)m.Estado_Estado.Nombre
                ,MunicipioNombre = (string)m.Municipio_Municipio.Nombre
                ,ColoniaNombre = (string)m.Colonia_Colonia.Nombre
                ,Codigo_Postal = m.Codigo_Postal
                ,Calle = m.Calle
                ,Numero_Exterior = m.Numero_Exterior
                ,Numero_Interior = m.Numero_Interior
                ,Telefono = m.Telefono
                ,Celular = m.Celular
                ,Correo_Electronico = m.Correo_Electronico
                ,PaisNombre = (string)m.Pais_Pais.Nombre
                ,Entre_calle = m.Entre_calle
                ,Especifique = m.Especifique
                ,Extension = m.Extension
                ,Inimputable = m.Inimputable
                ,Nombre_Completo = m.Nombre_Completo
                ,Originario_de = m.Originario_de
                ,Pais_de_OrigenNombre = (string)m.Pais_de_Origen_Pais.Nombre
                ,Proteccion_de_Datos = m.Proteccion_de_Datos
                ,Referencia_de_Domicilio = m.Referencia_de_Domicilio
                ,Y_calle = m.Y_calle
                ,Tipo_de_ComparecienteDescripcion = (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                ,Tipo_de_inimputabilidadDescripcion = (string)m.Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
                ,Nombre = m.Nombre

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_de_Registro_de_Intervinientes_CCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_de_Registro_de_Intervinientes_CCList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Registro_de_Intervinientes_CCPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Registro_de_Intervinientes_CCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Registro_de_Intervinientes_CCs == null)
                result.Detalle_de_Registro_de_Intervinientes_CCs = new List<Detalle_de_Registro_de_Intervinientes_CC>();

            var data = result.Detalle_de_Registro_de_Intervinientes_CCs.Select(m => new Detalle_de_Registro_de_Intervinientes_CCGridModel
            {
                Clave = m.Clave
                ,Nombres = m.Nombres
                ,Apellido_Paterno = m.Apellido_Paterno
                ,Apellido_Materno = m.Apellido_Materno
                ,Alias = m.Alias
                ,Anonimo = m.Anonimo
                ,Fecha_de_Nacimiento = (m.Fecha_de_Nacimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Nacimiento).ToString(ConfigurationProperty.DateFormat))
                ,Edad = m.Edad
                ,SexoDescripcion = (string)m.Sexo_Genero.Descripcion
                ,Estado_CivilDescripcion = (string)m.Estado_Civil_Estado_Civil.Descripcion
                ,Tipo_de_IdentificacionNombre = (string)m.Tipo_de_Identificacion_Tipo_de_Identificacion.Nombre
                ,Numero_de_Identificacion = m.Numero_de_Identificacion
                ,EscolaridadDescripcion = (string)m.Escolaridad_Escolaridad.Descripcion
                ,OcupacionDescripcion = (string)m.Ocupacion_Ocupacion.Descripcion
                ,NacionalidadNacionalidadC = (string)m.Nacionalidad_Nacionalidad.NacionalidadC
                ,EstadoNombre = (string)m.Estado_Estado.Nombre
                ,MunicipioNombre = (string)m.Municipio_Municipio.Nombre
                ,ColoniaNombre = (string)m.Colonia_Colonia.Nombre
                ,Codigo_Postal = m.Codigo_Postal
                ,Calle = m.Calle
                ,Numero_Exterior = m.Numero_Exterior
                ,Numero_Interior = m.Numero_Interior
                ,Telefono = m.Telefono
                ,Celular = m.Celular
                ,Correo_Electronico = m.Correo_Electronico
                ,PaisNombre = (string)m.Pais_Pais.Nombre
                ,Entre_calle = m.Entre_calle
                ,Especifique = m.Especifique
                ,Extension = m.Extension
                ,Inimputable = m.Inimputable
                ,Nombre_Completo = m.Nombre_Completo
                ,Originario_de = m.Originario_de
                ,Pais_de_OrigenNombre = (string)m.Pais_de_Origen_Pais.Nombre
                ,Proteccion_de_Datos = m.Proteccion_de_Datos
                ,Referencia_de_Domicilio = m.Referencia_de_Domicilio
                ,Y_calle = m.Y_calle
                ,Tipo_de_ComparecienteDescripcion = (string)m.Tipo_de_Compareciente_Tipo_de_Compareciente.Descripcion
                ,Tipo_de_inimputabilidadDescripcion = (string)m.Tipo_de_inimputabilidad_Tipo_de_Inimputabilidad.Descripcion
                ,Nombre = m.Nombre

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
