using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Lugar_de_Detencion;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Corporacion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Lugar_de_Detencion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Lugar_de_Detencion;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Corporacion;

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
    public class Lugar_de_DetencionController : Controller
    {
        #region "variable declaration"

        private ILugar_de_DetencionService service = null;
        private ILugar_de_DetencionApiConsumer _ILugar_de_DetencionApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private ICorporacionApiConsumer _ICorporacionApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Lugar_de_DetencionController(ILugar_de_DetencionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ILugar_de_DetencionApiConsumer Lugar_de_DetencionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , ICorporacionApiConsumer CorporacionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ILugar_de_DetencionApiConsumer = Lugar_de_DetencionApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._ICorporacionApiConsumer = CorporacionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Lugar_de_Detencion
        [ObjectAuth(ObjectId = (ModuleObjectId)45303, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45303);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Lugar_de_Detencion/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45303, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45303);
            ViewBag.Permission = permission;
            var varLugar_de_Detencion = new Lugar_de_DetencionModel();
			
            ViewBag.ObjectId = "45303";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILugar_de_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Lugar_de_DetencionData = _ILugar_de_DetencionApiConsumer.GetByKeyComplete(Id).Resource.Lugar_de_Detencions[0];
                if (Lugar_de_DetencionData == null)
                    return HttpNotFound();

                varLugar_de_Detencion = new Lugar_de_DetencionModel
                {
                    Clave = (int)Lugar_de_DetencionData.Clave
                    ,Fecha_de_Detencion = (Lugar_de_DetencionData.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(Lugar_de_DetencionData.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                    ,Municipio_de_Detencion = Lugar_de_DetencionData.Municipio_de_Detencion
                    ,Municipio_de_DetencionNombre = CultureHelper.GetTraduction(Convert.ToString(Lugar_de_DetencionData.Municipio_de_Detencion), "Municipio") ??  (string)Lugar_de_DetencionData.Municipio_de_Detencion_Municipio.Nombre
                    ,Corporacion = Lugar_de_DetencionData.Corporacion
                    ,CorporacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Lugar_de_DetencionData.Corporacion), "Corporacion") ??  (string)Lugar_de_DetencionData.Corporacion_Corporacion.Descripcion
                    ,Suspension_Condicional = Lugar_de_DetencionData.Suspension_Condicional.GetValueOrDefault()
                    ,Fecha_de_Suspension_Condicional = (Lugar_de_DetencionData.Fecha_de_Suspension_Condicional == null ? string.Empty : Convert.ToDateTime(Lugar_de_DetencionData.Fecha_de_Suspension_Condicional).ToString(ConfigurationProperty.DateFormat))

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICorporacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Corporacions_Corporacion = _ICorporacionApiConsumer.SelAll(true);
            if (Corporacions_Corporacion != null && Corporacions_Corporacion.Resource != null)
                ViewBag.Corporacions_Corporacion = Corporacions_Corporacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Corporacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varLugar_de_Detencion);
        }
		
	[HttpGet]
        public ActionResult AddLugar_de_Detencion(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45303);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ILugar_de_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Lugar_de_DetencionModel varLugar_de_Detencion= new Lugar_de_DetencionModel();


            if (id.ToString() != "0")
            {
                var Lugar_de_DetencionsData = _ILugar_de_DetencionApiConsumer.ListaSelAll(0, 1000, "Lugar_de_Detencion.Clave=" + id, "").Resource.Lugar_de_Detencions;
				
				if (Lugar_de_DetencionsData != null && Lugar_de_DetencionsData.Count > 0)
                {
					var Lugar_de_DetencionData = Lugar_de_DetencionsData.First();
					varLugar_de_Detencion= new Lugar_de_DetencionModel
					{
						Clave  = Lugar_de_DetencionData.Clave 
	                    ,Fecha_de_Detencion = (Lugar_de_DetencionData.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(Lugar_de_DetencionData.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                    ,Municipio_de_Detencion = Lugar_de_DetencionData.Municipio_de_Detencion
                    ,Municipio_de_DetencionNombre = CultureHelper.GetTraduction(Convert.ToString(Lugar_de_DetencionData.Municipio_de_Detencion), "Municipio") ??  (string)Lugar_de_DetencionData.Municipio_de_Detencion_Municipio.Nombre
                    ,Corporacion = Lugar_de_DetencionData.Corporacion
                    ,CorporacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Lugar_de_DetencionData.Corporacion), "Corporacion") ??  (string)Lugar_de_DetencionData.Corporacion_Corporacion.Descripcion
                    ,Suspension_Condicional = Lugar_de_DetencionData.Suspension_Condicional.GetValueOrDefault()
                    ,Fecha_de_Suspension_Condicional = (Lugar_de_DetencionData.Fecha_de_Suspension_Condicional == null ? string.Empty : Convert.ToDateTime(Lugar_de_DetencionData.Fecha_de_Suspension_Condicional).ToString(ConfigurationProperty.DateFormat))

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICorporacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Corporacions_Corporacion = _ICorporacionApiConsumer.SelAll(true);
            if (Corporacions_Corporacion != null && Corporacions_Corporacion.Resource != null)
                ViewBag.Corporacions_Corporacion = Corporacions_Corporacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Corporacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddLugar_de_Detencion", varLugar_de_Detencion);
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
        public ActionResult GetCorporacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICorporacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICorporacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Corporacion", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Lugar_de_DetencionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ILugar_de_DetencionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Lugar_de_Detencions == null)
                result.Lugar_de_Detencions = new List<Lugar_de_Detencion>();

            return Json(new
            {
                data = result.Lugar_de_Detencions.Select(m => new Lugar_de_DetencionGridModel
                    {
                    Clave = m.Clave
                        ,Fecha_de_Detencion = (m.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                        ,Municipio_de_DetencionNombre = CultureHelper.GetTraduction(m.Municipio_de_Detencion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Detencion_Municipio.Nombre
                        ,CorporacionDescripcion = CultureHelper.GetTraduction(m.Corporacion_Corporacion.Clave.ToString(), "Descripcion") ?? (string)m.Corporacion_Corporacion.Descripcion
			,Suspension_Condicional = m.Suspension_Condicional
                        ,Fecha_de_Suspension_Condicional = (m.Fecha_de_Suspension_Condicional == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Suspension_Condicional).ToString(ConfigurationProperty.DateFormat))

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetLugar_de_Detencion_Municipio_de_Detencion_Municipio(string query, string where)
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
                _ILugar_de_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Lugar_de_Detencion varLugar_de_Detencion = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _ILugar_de_DetencionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Lugar_de_DetencionModel varLugar_de_Detencion)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ILugar_de_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Lugar_de_DetencionInfo = new Lugar_de_Detencion
                    {
                        Clave = varLugar_de_Detencion.Clave
                        ,Fecha_de_Detencion = (!String.IsNullOrEmpty(varLugar_de_Detencion.Fecha_de_Detencion)) ? DateTime.ParseExact(varLugar_de_Detencion.Fecha_de_Detencion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Municipio_de_Detencion = varLugar_de_Detencion.Municipio_de_Detencion
                        ,Corporacion = varLugar_de_Detencion.Corporacion
                        ,Suspension_Condicional = varLugar_de_Detencion.Suspension_Condicional
                        ,Fecha_de_Suspension_Condicional = (!String.IsNullOrEmpty(varLugar_de_Detencion.Fecha_de_Suspension_Condicional)) ? DateTime.ParseExact(varLugar_de_Detencion.Fecha_de_Suspension_Condicional, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null

                    };

                    result = !IsNew ?
                        _ILugar_de_DetencionApiConsumer.Update(Lugar_de_DetencionInfo, null, null).Resource.ToString() :
                         _ILugar_de_DetencionApiConsumer.Insert(Lugar_de_DetencionInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Lugar_de_Detencion script
        /// </summary>
        /// <param name="oLugar_de_DetencionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Lugar_de_DetencionModuleAttributeList)
        {
            for (int i = 0; i < Lugar_de_DetencionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Lugar_de_DetencionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Lugar_de_DetencionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Lugar_de_DetencionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Lugar_de_DetencionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Lugar_de_DetencionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Lugar_de_DetencionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Lugar_de_DetencionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Lugar_de_DetencionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Lugar_de_DetencionModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Lugar_de_DetencionModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strLugar_de_DetencionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Lugar_de_Detencion.js")))
            {
                strLugar_de_DetencionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Lugar_de_Detencion element attributes
            string userChangeJson = jsSerialize.Serialize(Lugar_de_DetencionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strLugar_de_DetencionScript.IndexOf("inpuElementArray");
            string splittedString = strLugar_de_DetencionScript.Substring(indexOfArray, strLugar_de_DetencionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Lugar_de_DetencionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Lugar_de_DetencionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strLugar_de_DetencionScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strLugar_de_DetencionScript.Substring(indexOfArrayHistory, strLugar_de_DetencionScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strLugar_de_DetencionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strLugar_de_DetencionScript.Substring(endIndexOfMainElement + indexOfArray, strLugar_de_DetencionScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Lugar_de_DetencionModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strLugar_de_DetencionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strLugar_de_DetencionScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strLugar_de_DetencionScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strLugar_de_DetencionScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Lugar_de_Detencion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Lugar_de_Detencion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Lugar_de_Detencion.js")))
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
        public ActionResult Lugar_de_DetencionPropertyBag()
        {
            return PartialView("Lugar_de_DetencionPropertyBag", "Lugar_de_Detencion");
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

            _ILugar_de_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Lugar_de_DetencionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ILugar_de_DetencionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Lugar_de_Detencions == null)
                result.Lugar_de_Detencions = new List<Lugar_de_Detencion>();

            var data = result.Lugar_de_Detencions.Select(m => new Lugar_de_DetencionGridModel
            {
                Clave = m.Clave
                ,Fecha_de_Detencion = (m.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                ,Municipio_de_DetencionNombre = (string)m.Municipio_de_Detencion_Municipio.Nombre
                ,CorporacionDescripcion = (string)m.Corporacion_Corporacion.Descripcion
                ,Suspension_Condicional = m.Suspension_Condicional
                ,Fecha_de_Suspension_Condicional = (m.Fecha_de_Suspension_Condicional == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Suspension_Condicional).ToString(ConfigurationProperty.DateFormat))

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Lugar_de_DetencionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Lugar_de_DetencionList_" + DateTime.Now.ToString());
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

            _ILugar_de_DetencionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Lugar_de_DetencionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ILugar_de_DetencionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Lugar_de_Detencions == null)
                result.Lugar_de_Detencions = new List<Lugar_de_Detencion>();

            var data = result.Lugar_de_Detencions.Select(m => new Lugar_de_DetencionGridModel
            {
                Clave = m.Clave
                ,Fecha_de_Detencion = (m.Fecha_de_Detencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Detencion).ToString(ConfigurationProperty.DateFormat))
                ,Municipio_de_DetencionNombre = (string)m.Municipio_de_Detencion_Municipio.Nombre
                ,CorporacionDescripcion = (string)m.Corporacion_Corporacion.Descripcion
                ,Suspension_Condicional = m.Suspension_Condicional
                ,Fecha_de_Suspension_Condicional = (m.Fecha_de_Suspension_Condicional == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Suspension_Condicional).ToString(ConfigurationProperty.DateFormat))

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
