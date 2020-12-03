using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles;
using Spartane.Core.Domain.Tipo_de_Zona;
using Spartane.Core.Domain.Tipo_de_Inmueble;
using Spartane.Core.Domain.Terreno_de_Inmuebles;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Aseguramiento_Inmuebles;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Inmuebles;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Zona;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Inmueble;
using Spartane.Web.Areas.WebApiConsumer.Terreno_de_Inmuebles;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;

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
    public class Detalle_Aseguramiento_InmueblesController : Controller
    {
        #region "variable declaration"

        private IDetalle_Aseguramiento_InmueblesService service = null;
        private IDetalle_Aseguramiento_InmueblesApiConsumer _IDetalle_Aseguramiento_InmueblesApiConsumer;
        private ITipo_de_ZonaApiConsumer _ITipo_de_ZonaApiConsumer;
        private ITipo_de_InmuebleApiConsumer _ITipo_de_InmuebleApiConsumer;
        private ITerreno_de_InmueblesApiConsumer _ITerreno_de_InmueblesApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Aseguramiento_InmueblesController(IDetalle_Aseguramiento_InmueblesService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Aseguramiento_InmueblesApiConsumer Detalle_Aseguramiento_InmueblesApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ITipo_de_ZonaApiConsumer Tipo_de_ZonaApiConsumer , ITipo_de_InmuebleApiConsumer Tipo_de_InmuebleApiConsumer , ITerreno_de_InmueblesApiConsumer Terreno_de_InmueblesApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Aseguramiento_InmueblesApiConsumer = Detalle_Aseguramiento_InmueblesApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ITipo_de_ZonaApiConsumer = Tipo_de_ZonaApiConsumer;
            this._ITipo_de_InmuebleApiConsumer = Tipo_de_InmuebleApiConsumer;
            this._ITerreno_de_InmueblesApiConsumer = Terreno_de_InmueblesApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Aseguramiento_Inmuebles
        [ObjectAuth(ObjectId = (ModuleObjectId)45511, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45511);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Aseguramiento_Inmuebles/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45511, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45511);
            ViewBag.Permission = permission;
            var varDetalle_Aseguramiento_Inmuebles = new Detalle_Aseguramiento_InmueblesModel();
			
            ViewBag.ObjectId = "45511";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Aseguramiento_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Aseguramiento_InmueblesData = _IDetalle_Aseguramiento_InmueblesApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Aseguramiento_Inmuebless[0];
                if (Detalle_Aseguramiento_InmueblesData == null)
                    return HttpNotFound();

                varDetalle_Aseguramiento_Inmuebles = new Detalle_Aseguramiento_InmueblesModel
                {
                    Clave = (int)Detalle_Aseguramiento_InmueblesData.Clave
                    ,Zona = Detalle_Aseguramiento_InmueblesData.Zona
                    ,ZonaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_InmueblesData.Zona), "Tipo_de_Zona") ??  (string)Detalle_Aseguramiento_InmueblesData.Zona_Tipo_de_Zona.Descripcion
                    ,Tipo = Detalle_Aseguramiento_InmueblesData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_InmueblesData.Tipo), "Tipo_de_Inmueble") ??  (string)Detalle_Aseguramiento_InmueblesData.Tipo_Tipo_de_Inmueble.Descripcion
                    ,Terreno = Detalle_Aseguramiento_InmueblesData.Terreno
                    ,TerrenoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_InmueblesData.Terreno), "Terreno_de_Inmuebles") ??  (string)Detalle_Aseguramiento_InmueblesData.Terreno_Terreno_de_Inmuebles.Descripcion
                    ,Especifique_Otro = Detalle_Aseguramiento_InmueblesData.Especifique_Otro
                    ,Calle = Detalle_Aseguramiento_InmueblesData.Calle
                    ,Exterior = Detalle_Aseguramiento_InmueblesData.Exterior
                    ,Interior = Detalle_Aseguramiento_InmueblesData.Interior
                    ,C_P = Detalle_Aseguramiento_InmueblesData.C_P
                    ,Estado = Detalle_Aseguramiento_InmueblesData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_InmueblesData.Estado), "Estado") ??  (string)Detalle_Aseguramiento_InmueblesData.Estado_Estado.Nombre
                    ,Municipio = Detalle_Aseguramiento_InmueblesData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_InmueblesData.Municipio), "Municipio") ??  (string)Detalle_Aseguramiento_InmueblesData.Municipio_Municipio.Nombre
                    ,Colonia = Detalle_Aseguramiento_InmueblesData.Colonia
                    ,Registro_Publico_Propiedad = Detalle_Aseguramiento_InmueblesData.Registro_Publico_Propiedad
                    ,Entrecalles = Detalle_Aseguramiento_InmueblesData.Entrecalles
                    ,Propietario = Detalle_Aseguramiento_InmueblesData.Propietario
                    ,Observaciones = Detalle_Aseguramiento_InmueblesData.Observaciones

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_ZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Zonas_Zona = _ITipo_de_ZonaApiConsumer.SelAll(true);
            if (Tipo_de_Zonas_Zona != null && Tipo_de_Zonas_Zona.Resource != null)
                ViewBag.Tipo_de_Zonas_Zona = Tipo_de_Zonas_Zona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InmuebleApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inmuebles_Tipo = _ITipo_de_InmuebleApiConsumer.SelAll(true);
            if (Tipo_de_Inmuebles_Tipo != null && Tipo_de_Inmuebles_Tipo.Resource != null)
                ViewBag.Tipo_de_Inmuebles_Tipo = Tipo_de_Inmuebles_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inmueble", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITerreno_de_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Terreno_de_Inmuebless_Terreno = _ITerreno_de_InmueblesApiConsumer.SelAll(true);
            if (Terreno_de_Inmuebless_Terreno != null && Terreno_de_Inmuebless_Terreno.Resource != null)
                ViewBag.Terreno_de_Inmuebless_Terreno = Terreno_de_Inmuebless_Terreno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Terreno_de_Inmuebles", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Aseguramiento_Inmuebles);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Inmuebles(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45511);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Aseguramiento_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Aseguramiento_InmueblesModel varDetalle_Aseguramiento_Inmuebles= new Detalle_Aseguramiento_InmueblesModel();


            if (id.ToString() != "0")
            {
                var Detalle_Aseguramiento_InmueblessData = _IDetalle_Aseguramiento_InmueblesApiConsumer.ListaSelAll(0, 1000, "Detalle_Aseguramiento_Inmuebles.Clave=" + id, "").Resource.Detalle_Aseguramiento_Inmuebless;
				
				if (Detalle_Aseguramiento_InmueblessData != null && Detalle_Aseguramiento_InmueblessData.Count > 0)
                {
					var Detalle_Aseguramiento_InmueblesData = Detalle_Aseguramiento_InmueblessData.First();
					varDetalle_Aseguramiento_Inmuebles= new Detalle_Aseguramiento_InmueblesModel
					{
						Clave  = Detalle_Aseguramiento_InmueblesData.Clave 
	                    ,Zona = Detalle_Aseguramiento_InmueblesData.Zona
                    ,ZonaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_InmueblesData.Zona), "Tipo_de_Zona") ??  (string)Detalle_Aseguramiento_InmueblesData.Zona_Tipo_de_Zona.Descripcion
                    ,Tipo = Detalle_Aseguramiento_InmueblesData.Tipo
                    ,TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_InmueblesData.Tipo), "Tipo_de_Inmueble") ??  (string)Detalle_Aseguramiento_InmueblesData.Tipo_Tipo_de_Inmueble.Descripcion
                    ,Terreno = Detalle_Aseguramiento_InmueblesData.Terreno
                    ,TerrenoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_InmueblesData.Terreno), "Terreno_de_Inmuebles") ??  (string)Detalle_Aseguramiento_InmueblesData.Terreno_Terreno_de_Inmuebles.Descripcion
                    ,Especifique_Otro = Detalle_Aseguramiento_InmueblesData.Especifique_Otro
                    ,Calle = Detalle_Aseguramiento_InmueblesData.Calle
                    ,Exterior = Detalle_Aseguramiento_InmueblesData.Exterior
                    ,Interior = Detalle_Aseguramiento_InmueblesData.Interior
                    ,C_P = Detalle_Aseguramiento_InmueblesData.C_P
                    ,Estado = Detalle_Aseguramiento_InmueblesData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_InmueblesData.Estado), "Estado") ??  (string)Detalle_Aseguramiento_InmueblesData.Estado_Estado.Nombre
                    ,Municipio = Detalle_Aseguramiento_InmueblesData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_Aseguramiento_InmueblesData.Municipio), "Municipio") ??  (string)Detalle_Aseguramiento_InmueblesData.Municipio_Municipio.Nombre
                    ,Colonia = Detalle_Aseguramiento_InmueblesData.Colonia
                    ,Registro_Publico_Propiedad = Detalle_Aseguramiento_InmueblesData.Registro_Publico_Propiedad
                    ,Entrecalles = Detalle_Aseguramiento_InmueblesData.Entrecalles
                    ,Propietario = Detalle_Aseguramiento_InmueblesData.Propietario
                    ,Observaciones = Detalle_Aseguramiento_InmueblesData.Observaciones

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_ZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Zonas_Zona = _ITipo_de_ZonaApiConsumer.SelAll(true);
            if (Tipo_de_Zonas_Zona != null && Tipo_de_Zonas_Zona.Resource != null)
                ViewBag.Tipo_de_Zonas_Zona = Tipo_de_Zonas_Zona.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Zona", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InmuebleApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Inmuebles_Tipo = _ITipo_de_InmuebleApiConsumer.SelAll(true);
            if (Tipo_de_Inmuebles_Tipo != null && Tipo_de_Inmuebles_Tipo.Resource != null)
                ViewBag.Tipo_de_Inmuebles_Tipo = Tipo_de_Inmuebles_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inmueble", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITerreno_de_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Terreno_de_Inmuebless_Terreno = _ITerreno_de_InmueblesApiConsumer.SelAll(true);
            if (Terreno_de_Inmuebless_Terreno != null && Terreno_de_Inmuebless_Terreno.Resource != null)
                ViewBag.Terreno_de_Inmuebless_Terreno = Terreno_de_Inmuebless_Terreno.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Terreno_de_Inmuebles", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_Aseguramiento_Inmuebles", varDetalle_Aseguramiento_Inmuebles);
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
        public ActionResult GetTipo_de_ZonaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ZonaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ZonaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Zona", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_InmuebleAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_InmuebleApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_InmuebleApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Inmueble", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTerreno_de_InmueblesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITerreno_de_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITerreno_de_InmueblesApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Terreno_de_Inmuebles", "Descripcion")?? m.Descripcion,
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



        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_InmueblesPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Aseguramiento_InmueblesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Inmuebless == null)
                result.Detalle_Aseguramiento_Inmuebless = new List<Detalle_Aseguramiento_Inmuebles>();

            return Json(new
            {
                data = result.Detalle_Aseguramiento_Inmuebless.Select(m => new Detalle_Aseguramiento_InmueblesGridModel
                    {
                    Clave = m.Clave
                        ,ZonaDescripcion = CultureHelper.GetTraduction(m.Zona_Tipo_de_Zona.Clave.ToString(), "Descripcion") ?? (string)m.Zona_Tipo_de_Zona.Descripcion
                        ,TipoDescripcion = CultureHelper.GetTraduction(m.Tipo_Tipo_de_Inmueble.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Tipo_de_Inmueble.Descripcion
                        ,TerrenoDescripcion = CultureHelper.GetTraduction(m.Terreno_Terreno_de_Inmuebles.Clave.ToString(), "Descripcion") ?? (string)m.Terreno_Terreno_de_Inmuebles.Descripcion
			,Especifique_Otro = m.Especifique_Otro
			,Calle = m.Calle
			,Exterior = m.Exterior
			,Interior = m.Interior
			,C_P = m.C_P
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
			,Colonia = m.Colonia
			,Registro_Publico_Propiedad = m.Registro_Publico_Propiedad
			,Entrecalles = m.Entrecalles
			,Propietario = m.Propietario
			,Observaciones = m.Observaciones

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_Aseguramiento_Inmuebles_Estado_Estado(string query, string where)
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
        public JsonResult GetDetalle_Aseguramiento_Inmuebles_Municipio_Municipio(string query, string where)
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
                _IDetalle_Aseguramiento_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Aseguramiento_Inmuebles varDetalle_Aseguramiento_Inmuebles = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Aseguramiento_InmueblesApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Aseguramiento_InmueblesModel varDetalle_Aseguramiento_Inmuebles)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Aseguramiento_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Aseguramiento_InmueblesInfo = new Detalle_Aseguramiento_Inmuebles
                    {
                        Clave = varDetalle_Aseguramiento_Inmuebles.Clave
                        ,Zona = varDetalle_Aseguramiento_Inmuebles.Zona
                        ,Tipo = varDetalle_Aseguramiento_Inmuebles.Tipo
                        ,Terreno = varDetalle_Aseguramiento_Inmuebles.Terreno
                        ,Especifique_Otro = varDetalle_Aseguramiento_Inmuebles.Especifique_Otro
                        ,Calle = varDetalle_Aseguramiento_Inmuebles.Calle
                        ,Exterior = varDetalle_Aseguramiento_Inmuebles.Exterior
                        ,Interior = varDetalle_Aseguramiento_Inmuebles.Interior
                        ,C_P = varDetalle_Aseguramiento_Inmuebles.C_P
                        ,Estado = varDetalle_Aseguramiento_Inmuebles.Estado
                        ,Municipio = varDetalle_Aseguramiento_Inmuebles.Municipio
                        ,Colonia = varDetalle_Aseguramiento_Inmuebles.Colonia
                        ,Registro_Publico_Propiedad = varDetalle_Aseguramiento_Inmuebles.Registro_Publico_Propiedad
                        ,Entrecalles = varDetalle_Aseguramiento_Inmuebles.Entrecalles
                        ,Propietario = varDetalle_Aseguramiento_Inmuebles.Propietario
                        ,Observaciones = varDetalle_Aseguramiento_Inmuebles.Observaciones

                    };

                    result = !IsNew ?
                        _IDetalle_Aseguramiento_InmueblesApiConsumer.Update(Detalle_Aseguramiento_InmueblesInfo, null, null).Resource.ToString() :
                         _IDetalle_Aseguramiento_InmueblesApiConsumer.Insert(Detalle_Aseguramiento_InmueblesInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Aseguramiento_Inmuebles script
        /// </summary>
        /// <param name="oDetalle_Aseguramiento_InmueblesElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Aseguramiento_InmueblesModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Aseguramiento_InmueblesModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Aseguramiento_InmueblesModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Aseguramiento_InmueblesModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Aseguramiento_InmueblesModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Aseguramiento_InmueblesModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Aseguramiento_InmueblesModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Aseguramiento_InmueblesModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Aseguramiento_InmueblesModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Aseguramiento_InmueblesModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Aseguramiento_InmueblesModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Aseguramiento_InmueblesModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Aseguramiento_InmueblesScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Inmuebles.js")))
            {
                strDetalle_Aseguramiento_InmueblesScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Aseguramiento_Inmuebles element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Aseguramiento_InmueblesModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Aseguramiento_InmueblesScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Aseguramiento_InmueblesScript.Substring(indexOfArray, strDetalle_Aseguramiento_InmueblesScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Aseguramiento_InmueblesModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Aseguramiento_InmueblesModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Aseguramiento_InmueblesScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Aseguramiento_InmueblesScript.Substring(indexOfArrayHistory, strDetalle_Aseguramiento_InmueblesScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Aseguramiento_InmueblesScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Aseguramiento_InmueblesScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Aseguramiento_InmueblesScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Aseguramiento_InmueblesModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Aseguramiento_InmueblesScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Aseguramiento_InmueblesScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Aseguramiento_InmueblesScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Aseguramiento_InmueblesScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Inmuebles.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Inmuebles.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Inmuebles.js")))
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
        public ActionResult Detalle_Aseguramiento_InmueblesPropertyBag()
        {
            return PartialView("Detalle_Aseguramiento_InmueblesPropertyBag", "Detalle_Aseguramiento_Inmuebles");
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

            _IDetalle_Aseguramiento_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_InmueblesPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Aseguramiento_InmueblesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Inmuebless == null)
                result.Detalle_Aseguramiento_Inmuebless = new List<Detalle_Aseguramiento_Inmuebles>();

            var data = result.Detalle_Aseguramiento_Inmuebless.Select(m => new Detalle_Aseguramiento_InmueblesGridModel
            {
                Clave = m.Clave
                ,ZonaDescripcion = (string)m.Zona_Tipo_de_Zona.Descripcion
                ,TipoDescripcion = (string)m.Tipo_Tipo_de_Inmueble.Descripcion
                ,TerrenoDescripcion = (string)m.Terreno_Terreno_de_Inmuebles.Descripcion
                ,Especifique_Otro = m.Especifique_Otro
                ,Calle = m.Calle
                ,Exterior = m.Exterior
                ,Interior = m.Interior
                ,C_P = m.C_P
                ,EstadoNombre = (string)m.Estado_Estado.Nombre
                ,MunicipioNombre = (string)m.Municipio_Municipio.Nombre
                ,Colonia = m.Colonia
                ,Registro_Publico_Propiedad = m.Registro_Publico_Propiedad
                ,Entrecalles = m.Entrecalles
                ,Propietario = m.Propietario
                ,Observaciones = m.Observaciones

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Aseguramiento_InmueblesList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Aseguramiento_InmueblesList_" + DateTime.Now.ToString());
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

            _IDetalle_Aseguramiento_InmueblesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_InmueblesPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Aseguramiento_InmueblesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Inmuebless == null)
                result.Detalle_Aseguramiento_Inmuebless = new List<Detalle_Aseguramiento_Inmuebles>();

            var data = result.Detalle_Aseguramiento_Inmuebless.Select(m => new Detalle_Aseguramiento_InmueblesGridModel
            {
                Clave = m.Clave
                ,ZonaDescripcion = (string)m.Zona_Tipo_de_Zona.Descripcion
                ,TipoDescripcion = (string)m.Tipo_Tipo_de_Inmueble.Descripcion
                ,TerrenoDescripcion = (string)m.Terreno_Terreno_de_Inmuebles.Descripcion
                ,Especifique_Otro = m.Especifique_Otro
                ,Calle = m.Calle
                ,Exterior = m.Exterior
                ,Interior = m.Interior
                ,C_P = m.C_P
                ,EstadoNombre = (string)m.Estado_Estado.Nombre
                ,MunicipioNombre = (string)m.Municipio_Municipio.Nombre
                ,Colonia = m.Colonia
                ,Registro_Publico_Propiedad = m.Registro_Publico_Propiedad
                ,Entrecalles = m.Entrecalles
                ,Propietario = m.Propietario
                ,Observaciones = m.Observaciones

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
