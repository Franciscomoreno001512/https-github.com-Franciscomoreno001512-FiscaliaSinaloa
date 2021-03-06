﻿using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Invitado_de_Notificacion;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Colonia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Invitado_de_Notificacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Invitado_de_Notificacion;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
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

namespace Spartane.Web.Areas.Frontal.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class Detalle_de_Invitado_de_NotificacionController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Invitado_de_NotificacionService service = null;
        private IDetalle_de_Invitado_de_NotificacionApiConsumer _IDetalle_de_Invitado_de_NotificacionApiConsumer;
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

        
        public Detalle_de_Invitado_de_NotificacionController(IDetalle_de_Invitado_de_NotificacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Invitado_de_NotificacionApiConsumer Detalle_de_Invitado_de_NotificacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Invitado_de_NotificacionApiConsumer = Detalle_de_Invitado_de_NotificacionApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Invitado_de_Notificacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45358, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45358);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_de_Invitado_de_Notificacion/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45358, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45358);
            ViewBag.Permission = permission;
            var varDetalle_de_Invitado_de_Notificacion = new Detalle_de_Invitado_de_NotificacionModel();
			
            ViewBag.ObjectId = "45358";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Invitado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Invitado_de_NotificacionData = _IDetalle_de_Invitado_de_NotificacionApiConsumer.GetByKeyComplete(Id).Resource.Detalle_de_Invitado_de_Notificacions[0];
                if (Detalle_de_Invitado_de_NotificacionData == null)
                    return HttpNotFound();

                varDetalle_de_Invitado_de_Notificacion = new Detalle_de_Invitado_de_NotificacionModel
                {
                    Folio = (int)Detalle_de_Invitado_de_NotificacionData.Folio
                    ,Nombre_Completo = Detalle_de_Invitado_de_NotificacionData.Nombre_Completo
                    ,Telefono = Detalle_de_Invitado_de_NotificacionData.Telefono
                    ,Correo_Electronico = Detalle_de_Invitado_de_NotificacionData.Correo_Electronico
                    ,Estado = Detalle_de_Invitado_de_NotificacionData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Invitado_de_NotificacionData.Estado), "Estado") ??  (string)Detalle_de_Invitado_de_NotificacionData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Invitado_de_NotificacionData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Invitado_de_NotificacionData.Municipio), "Municipio") ??  (string)Detalle_de_Invitado_de_NotificacionData.Municipio_Municipio.Nombre
                    ,Poblacion = Detalle_de_Invitado_de_NotificacionData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Invitado_de_NotificacionData.Poblacion), "Colonia") ??  (string)Detalle_de_Invitado_de_NotificacionData.Poblacion_Colonia.Nombre
                    ,Colonia = Detalle_de_Invitado_de_NotificacionData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Invitado_de_NotificacionData.Colonia), "Colonia") ??  (string)Detalle_de_Invitado_de_NotificacionData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Detalle_de_Invitado_de_NotificacionData.Codigo_Postal
                    ,Calle = Detalle_de_Invitado_de_NotificacionData.Calle
                    ,Numero_Exterior = Detalle_de_Invitado_de_NotificacionData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Invitado_de_NotificacionData.Numero_Interior

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_de_Invitado_de_Notificacion);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Invitado_de_Notificacion(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45358);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Invitado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Invitado_de_NotificacionModel varDetalle_de_Invitado_de_Notificacion= new Detalle_de_Invitado_de_NotificacionModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_Invitado_de_NotificacionsData = _IDetalle_de_Invitado_de_NotificacionApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Invitado_de_Notificacion.Folio=" + id, "").Resource.Detalle_de_Invitado_de_Notificacions;
				
				if (Detalle_de_Invitado_de_NotificacionsData != null && Detalle_de_Invitado_de_NotificacionsData.Count > 0)
                {
					var Detalle_de_Invitado_de_NotificacionData = Detalle_de_Invitado_de_NotificacionsData.First();
					varDetalle_de_Invitado_de_Notificacion= new Detalle_de_Invitado_de_NotificacionModel
					{
						Folio  = Detalle_de_Invitado_de_NotificacionData.Folio 
	                    ,Nombre_Completo = Detalle_de_Invitado_de_NotificacionData.Nombre_Completo
                    ,Telefono = Detalle_de_Invitado_de_NotificacionData.Telefono
                    ,Correo_Electronico = Detalle_de_Invitado_de_NotificacionData.Correo_Electronico
                    ,Estado = Detalle_de_Invitado_de_NotificacionData.Estado
                    ,EstadoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Invitado_de_NotificacionData.Estado), "Estado") ??  (string)Detalle_de_Invitado_de_NotificacionData.Estado_Estado.Nombre
                    ,Municipio = Detalle_de_Invitado_de_NotificacionData.Municipio
                    ,MunicipioNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Invitado_de_NotificacionData.Municipio), "Municipio") ??  (string)Detalle_de_Invitado_de_NotificacionData.Municipio_Municipio.Nombre
                    ,Poblacion = Detalle_de_Invitado_de_NotificacionData.Poblacion
                    ,PoblacionNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Invitado_de_NotificacionData.Poblacion), "Colonia") ??  (string)Detalle_de_Invitado_de_NotificacionData.Poblacion_Colonia.Nombre
                    ,Colonia = Detalle_de_Invitado_de_NotificacionData.Colonia
                    ,ColoniaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Invitado_de_NotificacionData.Colonia), "Colonia") ??  (string)Detalle_de_Invitado_de_NotificacionData.Colonia_Colonia.Nombre
                    ,Codigo_Postal = Detalle_de_Invitado_de_NotificacionData.Codigo_Postal
                    ,Calle = Detalle_de_Invitado_de_NotificacionData.Calle
                    ,Numero_Exterior = Detalle_de_Invitado_de_NotificacionData.Numero_Exterior
                    ,Numero_Interior = Detalle_de_Invitado_de_NotificacionData.Numero_Interior

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDetalle_de_Invitado_de_Notificacion", varDetalle_de_Invitado_de_Notificacion);
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Invitado_de_NotificacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Invitado_de_NotificacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Invitado_de_Notificacions == null)
                result.Detalle_de_Invitado_de_Notificacions = new List<Detalle_de_Invitado_de_Notificacion>();

            return Json(new
            {
                data = result.Detalle_de_Invitado_de_Notificacions.Select(m => new Detalle_de_Invitado_de_NotificacionGridModel
                    {
                    Folio = m.Folio
			,Nombre_Completo = m.Nombre_Completo
			,Telefono = m.Telefono
			,Correo_Electronico = m.Correo_Electronico
                        ,EstadoNombre = CultureHelper.GetTraduction(m.Estado_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_Estado.Nombre
                        ,MunicipioNombre = CultureHelper.GetTraduction(m.Municipio_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_Municipio.Nombre
                        ,PoblacionNombre = CultureHelper.GetTraduction(m.Poblacion_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Poblacion_Colonia.Nombre
                        ,ColoniaNombre = CultureHelper.GetTraduction(m.Colonia_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle = m.Calle
			,Numero_Exterior = m.Numero_Exterior
			,Numero_Interior = m.Numero_Interior

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Invitado_de_Notificacion_Estado_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Invitado_de_Notificacion_Municipio_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Invitado_de_Notificacion_Poblacion_Colonia(string query, string where)
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
        public JsonResult GetDetalle_de_Invitado_de_Notificacion_Colonia_Colonia(string query, string where)
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
                _IDetalle_de_Invitado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Invitado_de_Notificacion varDetalle_de_Invitado_de_Notificacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_Invitado_de_NotificacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Invitado_de_NotificacionModel varDetalle_de_Invitado_de_Notificacion)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Invitado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_Invitado_de_NotificacionInfo = new Detalle_de_Invitado_de_Notificacion
                    {
                        Folio = varDetalle_de_Invitado_de_Notificacion.Folio
                        ,Nombre_Completo = varDetalle_de_Invitado_de_Notificacion.Nombre_Completo
                        ,Telefono = varDetalle_de_Invitado_de_Notificacion.Telefono
                        ,Correo_Electronico = varDetalle_de_Invitado_de_Notificacion.Correo_Electronico
                        ,Estado = varDetalle_de_Invitado_de_Notificacion.Estado
                        ,Municipio = varDetalle_de_Invitado_de_Notificacion.Municipio
                        ,Poblacion = varDetalle_de_Invitado_de_Notificacion.Poblacion
                        ,Colonia = varDetalle_de_Invitado_de_Notificacion.Colonia
                        ,Codigo_Postal = varDetalle_de_Invitado_de_Notificacion.Codigo_Postal
                        ,Calle = varDetalle_de_Invitado_de_Notificacion.Calle
                        ,Numero_Exterior = varDetalle_de_Invitado_de_Notificacion.Numero_Exterior
                        ,Numero_Interior = varDetalle_de_Invitado_de_Notificacion.Numero_Interior

                    };

                    result = !IsNew ?
                        _IDetalle_de_Invitado_de_NotificacionApiConsumer.Update(Detalle_de_Invitado_de_NotificacionInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Invitado_de_NotificacionApiConsumer.Insert(Detalle_de_Invitado_de_NotificacionInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_de_Invitado_de_Notificacion script
        /// </summary>
        /// <param name="oDetalle_de_Invitado_de_NotificacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_de_Invitado_de_NotificacionModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Invitado_de_NotificacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Invitado_de_NotificacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Invitado_de_NotificacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Invitado_de_NotificacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Invitado_de_NotificacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Invitado_de_NotificacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Invitado_de_NotificacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_de_Invitado_de_NotificacionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_de_Invitado_de_NotificacionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_de_Invitado_de_NotificacionModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_de_Invitado_de_NotificacionModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_de_Invitado_de_NotificacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Invitado_de_Notificacion.js")))
            {
                strDetalle_de_Invitado_de_NotificacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Invitado_de_Notificacion element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Invitado_de_NotificacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Invitado_de_NotificacionScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Invitado_de_NotificacionScript.Substring(indexOfArray, strDetalle_de_Invitado_de_NotificacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Invitado_de_NotificacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Invitado_de_NotificacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Invitado_de_NotificacionScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_de_Invitado_de_NotificacionScript.Substring(indexOfArrayHistory, strDetalle_de_Invitado_de_NotificacionScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_de_Invitado_de_NotificacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Invitado_de_NotificacionScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Invitado_de_NotificacionScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_de_Invitado_de_NotificacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_de_Invitado_de_NotificacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_de_Invitado_de_NotificacionScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_de_Invitado_de_NotificacionScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_de_Invitado_de_NotificacionScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Invitado_de_Notificacion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Invitado_de_Notificacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Invitado_de_Notificacion.js")))
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
        public ActionResult Detalle_de_Invitado_de_NotificacionPropertyBag()
        {
            return PartialView("Detalle_de_Invitado_de_NotificacionPropertyBag", "Detalle_de_Invitado_de_Notificacion");
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

            _IDetalle_de_Invitado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Invitado_de_NotificacionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Invitado_de_NotificacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Invitado_de_Notificacions == null)
                result.Detalle_de_Invitado_de_Notificacions = new List<Detalle_de_Invitado_de_Notificacion>();

            var data = result.Detalle_de_Invitado_de_Notificacions.Select(m => new Detalle_de_Invitado_de_NotificacionGridModel
            {
                Folio = m.Folio
                ,Nombre_Completo = m.Nombre_Completo
                ,Telefono = m.Telefono
                ,Correo_Electronico = m.Correo_Electronico
                ,EstadoNombre = (string)m.Estado_Estado.Nombre
                ,MunicipioNombre = (string)m.Municipio_Municipio.Nombre
                ,PoblacionNombre = (string)m.Poblacion_Colonia.Nombre
                ,ColoniaNombre = (string)m.Colonia_Colonia.Nombre
                ,Codigo_Postal = m.Codigo_Postal
                ,Calle = m.Calle
                ,Numero_Exterior = m.Numero_Exterior
                ,Numero_Interior = m.Numero_Interior

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_de_Invitado_de_NotificacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_de_Invitado_de_NotificacionList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Invitado_de_NotificacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Invitado_de_NotificacionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Invitado_de_NotificacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Invitado_de_Notificacions == null)
                result.Detalle_de_Invitado_de_Notificacions = new List<Detalle_de_Invitado_de_Notificacion>();

            var data = result.Detalle_de_Invitado_de_Notificacions.Select(m => new Detalle_de_Invitado_de_NotificacionGridModel
            {
                Folio = m.Folio
                ,Nombre_Completo = m.Nombre_Completo
                ,Telefono = m.Telefono
                ,Correo_Electronico = m.Correo_Electronico
                ,EstadoNombre = (string)m.Estado_Estado.Nombre
                ,MunicipioNombre = (string)m.Municipio_Municipio.Nombre
                ,PoblacionNombre = (string)m.Poblacion_Colonia.Nombre
                ,ColoniaNombre = (string)m.Colonia_Colonia.Nombre
                ,Codigo_Postal = m.Codigo_Postal
                ,Calle = m.Calle
                ,Numero_Exterior = m.Numero_Exterior
                ,Numero_Interior = m.Numero_Interior

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
