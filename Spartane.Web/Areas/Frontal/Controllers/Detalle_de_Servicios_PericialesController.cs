using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Servicios_Periciales;
using Spartane.Core.Domain.Servicios_Periciales;
using Spartane.Core.Domain.Estatus_del_Dictamen;
using Spartane.Core.Domain.Rol_de_Diligencia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Servicios_Periciales;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Servicios_Periciales;
using Spartane.Web.Areas.WebApiConsumer.Servicios_Periciales;
using Spartane.Web.Areas.WebApiConsumer.Estatus_del_Dictamen;
using Spartane.Web.Areas.WebApiConsumer.Rol_de_Diligencia;

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
    public class Detalle_de_Servicios_PericialesController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Servicios_PericialesService service = null;
        private IDetalle_de_Servicios_PericialesApiConsumer _IDetalle_de_Servicios_PericialesApiConsumer;
        private IServicios_PericialesApiConsumer _IServicios_PericialesApiConsumer;
        private IEstatus_del_DictamenApiConsumer _IEstatus_del_DictamenApiConsumer;
        private IRol_de_DiligenciaApiConsumer _IRol_de_DiligenciaApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_de_Servicios_PericialesController(IDetalle_de_Servicios_PericialesService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Servicios_PericialesApiConsumer Detalle_de_Servicios_PericialesApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IServicios_PericialesApiConsumer Servicios_PericialesApiConsumer , IEstatus_del_DictamenApiConsumer Estatus_del_DictamenApiConsumer , IRol_de_DiligenciaApiConsumer Rol_de_DiligenciaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Servicios_PericialesApiConsumer = Detalle_de_Servicios_PericialesApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IServicios_PericialesApiConsumer = Servicios_PericialesApiConsumer;
            this._IEstatus_del_DictamenApiConsumer = Estatus_del_DictamenApiConsumer;
            this._IRol_de_DiligenciaApiConsumer = Rol_de_DiligenciaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Servicios_Periciales
        [ObjectAuth(ObjectId = (ModuleObjectId)45157, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45157);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_de_Servicios_Periciales/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45157, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45157);
            ViewBag.Permission = permission;
            var varDetalle_de_Servicios_Periciales = new Detalle_de_Servicios_PericialesModel();
			
            ViewBag.ObjectId = "45157";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Servicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Servicios_PericialesData = _IDetalle_de_Servicios_PericialesApiConsumer.GetByKeyComplete(Id).Resource.Detalle_de_Servicios_Pericialess[0];
                if (Detalle_de_Servicios_PericialesData == null)
                    return HttpNotFound();

                varDetalle_de_Servicios_Periciales = new Detalle_de_Servicios_PericialesModel
                {
                    Clave = (int)Detalle_de_Servicios_PericialesData.Clave
                    ,Servicio = Detalle_de_Servicios_PericialesData.Servicio
                    ,ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicios_PericialesData.Servicio), "Servicios_Periciales") ??  (string)Detalle_de_Servicios_PericialesData.Servicio_Servicios_Periciales.Servicio
                    ,Especialista = Detalle_de_Servicios_PericialesData.Especialista
                    ,Estatus_del_Dictamen = Detalle_de_Servicios_PericialesData.Estatus_del_Dictamen
                    ,Estatus_del_DictamenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicios_PericialesData.Estatus_del_Dictamen), "Estatus_del_Dictamen") ??  (string)Detalle_de_Servicios_PericialesData.Estatus_del_Dictamen_Estatus_del_Dictamen.Descripcion
                    ,Observaciones = Detalle_de_Servicios_PericialesData.Observaciones
                    ,Fecha_del_Dictamen = (Detalle_de_Servicios_PericialesData.Fecha_del_Dictamen == null ? string.Empty : Convert.ToDateTime(Detalle_de_Servicios_PericialesData.Fecha_del_Dictamen).ToString(ConfigurationProperty.DateFormat))
                    ,Dictamen = Detalle_de_Servicios_PericialesData.Dictamen
                    ,Rol_de_Donde_Proviene = Detalle_de_Servicios_PericialesData.Rol_de_Donde_Proviene
                    ,Rol_de_Donde_ProvieneDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicios_PericialesData.Rol_de_Donde_Proviene), "Rol_de_Diligencia") ??  (string)Detalle_de_Servicios_PericialesData.Rol_de_Donde_Proviene_Rol_de_Diligencia.Descripcion
                    ,ObservacionesD = Detalle_de_Servicios_PericialesData.ObservacionesD

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicios_Pericialess_Servicio = _IServicios_PericialesApiConsumer.SelAll(true);
            if (Servicios_Pericialess_Servicio != null && Servicios_Pericialess_Servicio.Resource != null)
                ViewBag.Servicios_Pericialess_Servicio = Servicios_Pericialess_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicios_Periciales", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_del_DictamenApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_del_Dictamens_Estatus_del_Dictamen = _IEstatus_del_DictamenApiConsumer.SelAll(true);
            if (Estatus_del_Dictamens_Estatus_del_Dictamen != null && Estatus_del_Dictamens_Estatus_del_Dictamen.Resource != null)
                ViewBag.Estatus_del_Dictamens_Estatus_del_Dictamen = Estatus_del_Dictamens_Estatus_del_Dictamen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_del_Dictamen", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRol_de_DiligenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Rol_de_Diligencias_Rol_de_Donde_Proviene = _IRol_de_DiligenciaApiConsumer.SelAll(true);
            if (Rol_de_Diligencias_Rol_de_Donde_Proviene != null && Rol_de_Diligencias_Rol_de_Donde_Proviene.Resource != null)
                ViewBag.Rol_de_Diligencias_Rol_de_Donde_Proviene = Rol_de_Diligencias_Rol_de_Donde_Proviene.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Rol_de_Diligencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_de_Servicios_Periciales);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Servicios_Periciales(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45157);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Servicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Servicios_PericialesModel varDetalle_de_Servicios_Periciales= new Detalle_de_Servicios_PericialesModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_Servicios_PericialessData = _IDetalle_de_Servicios_PericialesApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Servicios_Periciales.Clave=" + id, "").Resource.Detalle_de_Servicios_Pericialess;
				
				if (Detalle_de_Servicios_PericialessData != null && Detalle_de_Servicios_PericialessData.Count > 0)
                {
					var Detalle_de_Servicios_PericialesData = Detalle_de_Servicios_PericialessData.First();
					varDetalle_de_Servicios_Periciales= new Detalle_de_Servicios_PericialesModel
					{
						Clave  = Detalle_de_Servicios_PericialesData.Clave 
	                    ,Servicio = Detalle_de_Servicios_PericialesData.Servicio
                    ,ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicios_PericialesData.Servicio), "Servicios_Periciales") ??  (string)Detalle_de_Servicios_PericialesData.Servicio_Servicios_Periciales.Servicio
                    ,Especialista = Detalle_de_Servicios_PericialesData.Especialista
                    ,Estatus_del_Dictamen = Detalle_de_Servicios_PericialesData.Estatus_del_Dictamen
                    ,Estatus_del_DictamenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicios_PericialesData.Estatus_del_Dictamen), "Estatus_del_Dictamen") ??  (string)Detalle_de_Servicios_PericialesData.Estatus_del_Dictamen_Estatus_del_Dictamen.Descripcion
                    ,Observaciones = Detalle_de_Servicios_PericialesData.Observaciones
                    ,Fecha_del_Dictamen = (Detalle_de_Servicios_PericialesData.Fecha_del_Dictamen == null ? string.Empty : Convert.ToDateTime(Detalle_de_Servicios_PericialesData.Fecha_del_Dictamen).ToString(ConfigurationProperty.DateFormat))
                    ,Dictamen = Detalle_de_Servicios_PericialesData.Dictamen
                    ,Rol_de_Donde_Proviene = Detalle_de_Servicios_PericialesData.Rol_de_Donde_Proviene
                    ,Rol_de_Donde_ProvieneDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicios_PericialesData.Rol_de_Donde_Proviene), "Rol_de_Diligencia") ??  (string)Detalle_de_Servicios_PericialesData.Rol_de_Donde_Proviene_Rol_de_Diligencia.Descripcion
                    ,ObservacionesD = Detalle_de_Servicios_PericialesData.ObservacionesD

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicios_Pericialess_Servicio = _IServicios_PericialesApiConsumer.SelAll(true);
            if (Servicios_Pericialess_Servicio != null && Servicios_Pericialess_Servicio.Resource != null)
                ViewBag.Servicios_Pericialess_Servicio = Servicios_Pericialess_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicios_Periciales", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_del_DictamenApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_del_Dictamens_Estatus_del_Dictamen = _IEstatus_del_DictamenApiConsumer.SelAll(true);
            if (Estatus_del_Dictamens_Estatus_del_Dictamen != null && Estatus_del_Dictamens_Estatus_del_Dictamen.Resource != null)
                ViewBag.Estatus_del_Dictamens_Estatus_del_Dictamen = Estatus_del_Dictamens_Estatus_del_Dictamen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_del_Dictamen", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRol_de_DiligenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Rol_de_Diligencias_Rol_de_Donde_Proviene = _IRol_de_DiligenciaApiConsumer.SelAll(true);
            if (Rol_de_Diligencias_Rol_de_Donde_Proviene != null && Rol_de_Diligencias_Rol_de_Donde_Proviene.Resource != null)
                ViewBag.Rol_de_Diligencias_Rol_de_Donde_Proviene = Rol_de_Diligencias_Rol_de_Donde_Proviene.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Rol_de_Diligencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Servicios_Periciales", varDetalle_de_Servicios_Periciales);
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
        public ActionResult GetServicios_PericialesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IServicios_PericialesApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicios_Periciales", "Servicio")?? m.Servicio,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatus_del_DictamenAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_del_DictamenApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_del_DictamenApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_del_Dictamen", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetRol_de_DiligenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRol_de_DiligenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRol_de_DiligenciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Rol_de_Diligencia", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Servicios_PericialesPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Servicios_PericialesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Servicios_Pericialess == null)
                result.Detalle_de_Servicios_Pericialess = new List<Detalle_de_Servicios_Periciales>();

            return Json(new
            {
                data = result.Detalle_de_Servicios_Pericialess.Select(m => new Detalle_de_Servicios_PericialesGridModel
                    {
                    Clave = m.Clave
                        ,ServicioServicio = CultureHelper.GetTraduction(m.Servicio_Servicios_Periciales.Clave.ToString(), "Servicio") ?? (string)m.Servicio_Servicios_Periciales.Servicio
			,Especialista = m.Especialista
                        ,Estatus_del_DictamenDescripcion = CultureHelper.GetTraduction(m.Estatus_del_Dictamen_Estatus_del_Dictamen.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_del_Dictamen_Estatus_del_Dictamen.Descripcion
			,Observaciones = m.Observaciones
                        ,Fecha_del_Dictamen = (m.Fecha_del_Dictamen == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Dictamen).ToString(ConfigurationProperty.DateFormat))
			,Dictamen = m.Dictamen
                        ,Rol_de_Donde_ProvieneDescripcion = CultureHelper.GetTraduction(m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Clave.ToString(), "Descripcion") ?? (string)m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Descripcion
			,ObservacionesD = m.ObservacionesD

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
                _IDetalle_de_Servicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Servicios_Periciales varDetalle_de_Servicios_Periciales = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_Servicios_PericialesApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Servicios_PericialesModel varDetalle_de_Servicios_Periciales)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Servicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_Servicios_PericialesInfo = new Detalle_de_Servicios_Periciales
                    {
                        Clave = varDetalle_de_Servicios_Periciales.Clave
                        ,Servicio = varDetalle_de_Servicios_Periciales.Servicio
                        ,Especialista = varDetalle_de_Servicios_Periciales.Especialista
                        ,Estatus_del_Dictamen = varDetalle_de_Servicios_Periciales.Estatus_del_Dictamen
                        ,Observaciones = varDetalle_de_Servicios_Periciales.Observaciones
                        ,Fecha_del_Dictamen = (!String.IsNullOrEmpty(varDetalle_de_Servicios_Periciales.Fecha_del_Dictamen)) ? DateTime.ParseExact(varDetalle_de_Servicios_Periciales.Fecha_del_Dictamen, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Dictamen = varDetalle_de_Servicios_Periciales.Dictamen
                        ,Rol_de_Donde_Proviene = varDetalle_de_Servicios_Periciales.Rol_de_Donde_Proviene
                        ,ObservacionesD = varDetalle_de_Servicios_Periciales.ObservacionesD

                    };

                    result = !IsNew ?
                        _IDetalle_de_Servicios_PericialesApiConsumer.Update(Detalle_de_Servicios_PericialesInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Servicios_PericialesApiConsumer.Insert(Detalle_de_Servicios_PericialesInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_de_Servicios_Periciales script
        /// </summary>
        /// <param name="oDetalle_de_Servicios_PericialesElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_de_Servicios_PericialesModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Servicios_PericialesModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Servicios_PericialesModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Servicios_PericialesModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Servicios_PericialesModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Servicios_PericialesModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Servicios_PericialesModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Servicios_PericialesModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_de_Servicios_PericialesModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_de_Servicios_PericialesModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_de_Servicios_PericialesModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_de_Servicios_PericialesModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_de_Servicios_PericialesScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Servicios_Periciales.js")))
            {
                strDetalle_de_Servicios_PericialesScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Servicios_Periciales element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Servicios_PericialesModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Servicios_PericialesScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Servicios_PericialesScript.Substring(indexOfArray, strDetalle_de_Servicios_PericialesScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Servicios_PericialesModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Servicios_PericialesModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Servicios_PericialesScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_de_Servicios_PericialesScript.Substring(indexOfArrayHistory, strDetalle_de_Servicios_PericialesScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_de_Servicios_PericialesScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Servicios_PericialesScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Servicios_PericialesScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_de_Servicios_PericialesModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_de_Servicios_PericialesScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_de_Servicios_PericialesScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_de_Servicios_PericialesScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_de_Servicios_PericialesScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Servicios_Periciales.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Servicios_Periciales.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Servicios_Periciales.js")))
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
        public ActionResult Detalle_de_Servicios_PericialesPropertyBag()
        {
            return PartialView("Detalle_de_Servicios_PericialesPropertyBag", "Detalle_de_Servicios_Periciales");
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

            _IDetalle_de_Servicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Servicios_PericialesPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Servicios_PericialesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Servicios_Pericialess == null)
                result.Detalle_de_Servicios_Pericialess = new List<Detalle_de_Servicios_Periciales>();

            var data = result.Detalle_de_Servicios_Pericialess.Select(m => new Detalle_de_Servicios_PericialesGridModel
            {
                Clave = m.Clave
                ,ServicioServicio = (string)m.Servicio_Servicios_Periciales.Servicio
                ,Especialista = m.Especialista
                ,Estatus_del_DictamenDescripcion = (string)m.Estatus_del_Dictamen_Estatus_del_Dictamen.Descripcion
                ,Observaciones = m.Observaciones
                ,Fecha_del_Dictamen = (m.Fecha_del_Dictamen == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Dictamen).ToString(ConfigurationProperty.DateFormat))
                ,Dictamen = m.Dictamen
                ,Rol_de_Donde_ProvieneDescripcion = (string)m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Descripcion
                ,ObservacionesD = m.ObservacionesD

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_de_Servicios_PericialesList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_de_Servicios_PericialesList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Servicios_PericialesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Servicios_PericialesPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Servicios_PericialesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Servicios_Pericialess == null)
                result.Detalle_de_Servicios_Pericialess = new List<Detalle_de_Servicios_Periciales>();

            var data = result.Detalle_de_Servicios_Pericialess.Select(m => new Detalle_de_Servicios_PericialesGridModel
            {
                Clave = m.Clave
                ,ServicioServicio = (string)m.Servicio_Servicios_Periciales.Servicio
                ,Especialista = m.Especialista
                ,Estatus_del_DictamenDescripcion = (string)m.Estatus_del_Dictamen_Estatus_del_Dictamen.Descripcion
                ,Observaciones = m.Observaciones
                ,Fecha_del_Dictamen = (m.Fecha_del_Dictamen == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Dictamen).ToString(ConfigurationProperty.DateFormat))
                ,Dictamen = m.Dictamen
                ,Rol_de_Donde_ProvieneDescripcion = (string)m.Rol_de_Donde_Proviene_Rol_de_Diligencia.Descripcion
                ,ObservacionesD = m.ObservacionesD

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
