using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Amparo;
using Spartane.Core.Domain.Tipo_de_Amparo;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Tipo_de_Resolucion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Amparo;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Amparo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Amparo;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Resolucion;

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
    public class Detalle_de_AmparoController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_AmparoService service = null;
        private IDetalle_de_AmparoApiConsumer _IDetalle_de_AmparoApiConsumer;
        private ITipo_de_AmparoApiConsumer _ITipo_de_AmparoApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private ITipo_de_ResolucionApiConsumer _ITipo_de_ResolucionApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_de_AmparoController(IDetalle_de_AmparoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_AmparoApiConsumer Detalle_de_AmparoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ITipo_de_AmparoApiConsumer Tipo_de_AmparoApiConsumer , IEstadoApiConsumer EstadoApiConsumer , ITipo_de_ResolucionApiConsumer Tipo_de_ResolucionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_AmparoApiConsumer = Detalle_de_AmparoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ITipo_de_AmparoApiConsumer = Tipo_de_AmparoApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._ITipo_de_ResolucionApiConsumer = Tipo_de_ResolucionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Amparo
        [ObjectAuth(ObjectId = (ModuleObjectId)45663, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45663);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_de_Amparo/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45663, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45663);
            ViewBag.Permission = permission;
            var varDetalle_de_Amparo = new Detalle_de_AmparoModel();
			
            ViewBag.ObjectId = "45663";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_AmparoData = _IDetalle_de_AmparoApiConsumer.GetByKeyComplete(Id).Resource.Detalle_de_Amparos[0];
                if (Detalle_de_AmparoData == null)
                    return HttpNotFound();

                varDetalle_de_Amparo = new Detalle_de_AmparoModel
                {
                    Clave = (int)Detalle_de_AmparoData.Clave
                    ,Tipo_de_Amparo = Detalle_de_AmparoData.Tipo_de_Amparo
                    ,Tipo_de_AmparoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_AmparoData.Tipo_de_Amparo), "Tipo_de_Amparo") ??  (string)Detalle_de_AmparoData.Tipo_de_Amparo_Tipo_de_Amparo.Descripcion
                    ,Numero_de_Amparo = Detalle_de_AmparoData.Numero_de_Amparo
                    ,Fecha_Amparo = (Detalle_de_AmparoData.Fecha_Amparo == null ? string.Empty : Convert.ToDateTime(Detalle_de_AmparoData.Fecha_Amparo).ToString(ConfigurationProperty.DateFormat))
                    ,Entidad_que_Emitio_Amparo = Detalle_de_AmparoData.Entidad_que_Emitio_Amparo
                    ,Entidad_que_Emitio_AmparoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_AmparoData.Entidad_que_Emitio_Amparo), "Estado") ??  (string)Detalle_de_AmparoData.Entidad_que_Emitio_Amparo_Estado.Nombre
                    ,Resolucion = Detalle_de_AmparoData.Resolucion
                    ,ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_AmparoData.Resolucion), "Tipo_de_Resolucion") ??  (string)Detalle_de_AmparoData.Resolucion_Tipo_de_Resolucion.Descripcion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Amparos_Tipo_de_Amparo = _ITipo_de_AmparoApiConsumer.SelAll(true);
            if (Tipo_de_Amparos_Tipo_de_Amparo != null && Tipo_de_Amparos_Tipo_de_Amparo.Resource != null)
                ViewBag.Tipo_de_Amparos_Tipo_de_Amparo = Tipo_de_Amparos_Tipo_de_Amparo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Amparo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Resolucions_Resolucion = _ITipo_de_ResolucionApiConsumer.SelAll(true);
            if (Tipo_de_Resolucions_Resolucion != null && Tipo_de_Resolucions_Resolucion.Resource != null)
                ViewBag.Tipo_de_Resolucions_Resolucion = Tipo_de_Resolucions_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_de_Amparo);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Amparo(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45663);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_AmparoModel varDetalle_de_Amparo= new Detalle_de_AmparoModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_AmparosData = _IDetalle_de_AmparoApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Amparo.Clave=" + id, "").Resource.Detalle_de_Amparos;
				
				if (Detalle_de_AmparosData != null && Detalle_de_AmparosData.Count > 0)
                {
					var Detalle_de_AmparoData = Detalle_de_AmparosData.First();
					varDetalle_de_Amparo= new Detalle_de_AmparoModel
					{
						Clave  = Detalle_de_AmparoData.Clave 
	                    ,Tipo_de_Amparo = Detalle_de_AmparoData.Tipo_de_Amparo
                    ,Tipo_de_AmparoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_AmparoData.Tipo_de_Amparo), "Tipo_de_Amparo") ??  (string)Detalle_de_AmparoData.Tipo_de_Amparo_Tipo_de_Amparo.Descripcion
                    ,Numero_de_Amparo = Detalle_de_AmparoData.Numero_de_Amparo
                    ,Fecha_Amparo = (Detalle_de_AmparoData.Fecha_Amparo == null ? string.Empty : Convert.ToDateTime(Detalle_de_AmparoData.Fecha_Amparo).ToString(ConfigurationProperty.DateFormat))
                    ,Entidad_que_Emitio_Amparo = Detalle_de_AmparoData.Entidad_que_Emitio_Amparo
                    ,Entidad_que_Emitio_AmparoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_AmparoData.Entidad_que_Emitio_Amparo), "Estado") ??  (string)Detalle_de_AmparoData.Entidad_que_Emitio_Amparo_Estado.Nombre
                    ,Resolucion = Detalle_de_AmparoData.Resolucion
                    ,ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_AmparoData.Resolucion), "Tipo_de_Resolucion") ??  (string)Detalle_de_AmparoData.Resolucion_Tipo_de_Resolucion.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Amparos_Tipo_de_Amparo = _ITipo_de_AmparoApiConsumer.SelAll(true);
            if (Tipo_de_Amparos_Tipo_de_Amparo != null && Tipo_de_Amparos_Tipo_de_Amparo.Resource != null)
                ViewBag.Tipo_de_Amparos_Tipo_de_Amparo = Tipo_de_Amparos_Tipo_de_Amparo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Amparo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Resolucions_Resolucion = _ITipo_de_ResolucionApiConsumer.SelAll(true);
            if (Tipo_de_Resolucions_Resolucion != null && Tipo_de_Resolucions_Resolucion.Resource != null)
                ViewBag.Tipo_de_Resolucions_Resolucion = Tipo_de_Resolucions_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Resolucion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Amparo", varDetalle_de_Amparo);
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
        public ActionResult GetTipo_de_AmparoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_AmparoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Amparo", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetTipo_de_ResolucionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_ResolucionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_ResolucionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Resolucion", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_AmparoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_AmparoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Amparos == null)
                result.Detalle_de_Amparos = new List<Detalle_de_Amparo>();

            return Json(new
            {
                data = result.Detalle_de_Amparos.Select(m => new Detalle_de_AmparoGridModel
                    {
                    Clave = m.Clave
                        ,Tipo_de_AmparoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Amparo_Tipo_de_Amparo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Amparo_Tipo_de_Amparo.Descripcion
			,Numero_de_Amparo = m.Numero_de_Amparo
                        ,Fecha_Amparo = (m.Fecha_Amparo == null ? string.Empty : Convert.ToDateTime(m.Fecha_Amparo).ToString(ConfigurationProperty.DateFormat))
                        ,Entidad_que_Emitio_AmparoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emitio_Amparo_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emitio_Amparo_Estado.Nombre
                        ,ResolucionDescripcion = CultureHelper.GetTraduction(m.Resolucion_Tipo_de_Resolucion.Clave.ToString(), "Descripcion") ?? (string)m.Resolucion_Tipo_de_Resolucion.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Amparo_Entidad_que_Emitio_Amparo_Estado(string query, string where)
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
                _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Amparo varDetalle_de_Amparo = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_AmparoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_AmparoModel varDetalle_de_Amparo)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_AmparoInfo = new Detalle_de_Amparo
                    {
                        Clave = varDetalle_de_Amparo.Clave
                        ,Tipo_de_Amparo = varDetalle_de_Amparo.Tipo_de_Amparo
                        ,Numero_de_Amparo = varDetalle_de_Amparo.Numero_de_Amparo
                        ,Fecha_Amparo = (!String.IsNullOrEmpty(varDetalle_de_Amparo.Fecha_Amparo)) ? DateTime.ParseExact(varDetalle_de_Amparo.Fecha_Amparo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Entidad_que_Emitio_Amparo = varDetalle_de_Amparo.Entidad_que_Emitio_Amparo
                        ,Resolucion = varDetalle_de_Amparo.Resolucion

                    };

                    result = !IsNew ?
                        _IDetalle_de_AmparoApiConsumer.Update(Detalle_de_AmparoInfo, null, null).Resource.ToString() :
                         _IDetalle_de_AmparoApiConsumer.Insert(Detalle_de_AmparoInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_de_Amparo script
        /// </summary>
        /// <param name="oDetalle_de_AmparoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_de_AmparoModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_AmparoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_AmparoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_AmparoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_AmparoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_AmparoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_de_AmparoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Amparo.js")))
            {
                strDetalle_de_AmparoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Amparo element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_AmparoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_AmparoScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_AmparoScript.Substring(indexOfArray, strDetalle_de_AmparoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_AmparoScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_de_AmparoScript.Substring(indexOfArrayHistory, strDetalle_de_AmparoScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_de_AmparoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_AmparoScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_AmparoScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_de_AmparoModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_de_AmparoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_de_AmparoScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_de_AmparoScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_de_AmparoScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Amparo.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Amparo.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Amparo.js")))
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
        public ActionResult Detalle_de_AmparoPropertyBag()
        {
            return PartialView("Detalle_de_AmparoPropertyBag", "Detalle_de_Amparo");
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

            _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_AmparoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_AmparoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Amparos == null)
                result.Detalle_de_Amparos = new List<Detalle_de_Amparo>();

            var data = result.Detalle_de_Amparos.Select(m => new Detalle_de_AmparoGridModel
            {
                Clave = m.Clave
                ,Tipo_de_AmparoDescripcion = (string)m.Tipo_de_Amparo_Tipo_de_Amparo.Descripcion
                ,Numero_de_Amparo = m.Numero_de_Amparo
                ,Fecha_Amparo = (m.Fecha_Amparo == null ? string.Empty : Convert.ToDateTime(m.Fecha_Amparo).ToString(ConfigurationProperty.DateFormat))
                ,Entidad_que_Emitio_AmparoNombre = (string)m.Entidad_que_Emitio_Amparo_Estado.Nombre
                ,ResolucionDescripcion = (string)m.Resolucion_Tipo_de_Resolucion.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_de_AmparoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_de_AmparoList_" + DateTime.Now.ToString());
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

            _IDetalle_de_AmparoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_AmparoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_AmparoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Amparos == null)
                result.Detalle_de_Amparos = new List<Detalle_de_Amparo>();

            var data = result.Detalle_de_Amparos.Select(m => new Detalle_de_AmparoGridModel
            {
                Clave = m.Clave
                ,Tipo_de_AmparoDescripcion = (string)m.Tipo_de_Amparo_Tipo_de_Amparo.Descripcion
                ,Numero_de_Amparo = m.Numero_de_Amparo
                ,Fecha_Amparo = (m.Fecha_Amparo == null ? string.Empty : Convert.ToDateTime(m.Fecha_Amparo).ToString(ConfigurationProperty.DateFormat))
                ,Entidad_que_Emitio_AmparoNombre = (string)m.Entidad_que_Emitio_Amparo_Estado.Nombre
                ,ResolucionDescripcion = (string)m.Resolucion_Tipo_de_Resolucion.Descripcion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
