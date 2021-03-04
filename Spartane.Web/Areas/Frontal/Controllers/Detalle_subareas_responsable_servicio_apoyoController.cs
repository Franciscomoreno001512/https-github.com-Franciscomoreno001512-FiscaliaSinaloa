using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo;
using Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_subareas_responsable_servicio_apoyo;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_subareas_responsable_servicio_apoyo;
using Spartane.Web.Areas.WebApiConsumer.SubArea_de_Servicios_de_Apoyo;

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
    public class Detalle_subareas_responsable_servicio_apoyoController : Controller
    {
        #region "variable declaration"

        private IDetalle_subareas_responsable_servicio_apoyoService service = null;
        private IDetalle_subareas_responsable_servicio_apoyoApiConsumer _IDetalle_subareas_responsable_servicio_apoyoApiConsumer;
        private ISubArea_de_Servicios_de_ApoyoApiConsumer _ISubArea_de_Servicios_de_ApoyoApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_subareas_responsable_servicio_apoyoController(IDetalle_subareas_responsable_servicio_apoyoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_subareas_responsable_servicio_apoyoApiConsumer Detalle_subareas_responsable_servicio_apoyoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ISubArea_de_Servicios_de_ApoyoApiConsumer SubArea_de_Servicios_de_ApoyoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_subareas_responsable_servicio_apoyoApiConsumer = Detalle_subareas_responsable_servicio_apoyoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISubArea_de_Servicios_de_ApoyoApiConsumer = SubArea_de_Servicios_de_ApoyoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_subareas_responsable_servicio_apoyo
        [ObjectAuth(ObjectId = (ModuleObjectId)46227, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46227);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_subareas_responsable_servicio_apoyo/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)46227, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46227);
            ViewBag.Permission = permission;
            var varDetalle_subareas_responsable_servicio_apoyo = new Detalle_subareas_responsable_servicio_apoyoModel();
			
            ViewBag.ObjectId = "46227";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_subareas_responsable_servicio_apoyoData = _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.GetByKeyComplete(Id).Resource.Detalle_subareas_responsable_servicio_apoyos[0];
                if (Detalle_subareas_responsable_servicio_apoyoData == null)
                    return HttpNotFound();

                varDetalle_subareas_responsable_servicio_apoyo = new Detalle_subareas_responsable_servicio_apoyoModel
                {
                    Clave = (int)Detalle_subareas_responsable_servicio_apoyoData.Clave
                    ,SubArea_Asignada = Detalle_subareas_responsable_servicio_apoyoData.SubArea_Asignada
                    ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_subareas_responsable_servicio_apoyoData.SubArea_Asignada), "SubArea_de_Servicios_de_Apoyo") ??  (string)Detalle_subareas_responsable_servicio_apoyoData.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea_Asignada != null && SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_subareas_responsable_servicio_apoyo);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_subareas_responsable_servicio_apoyo(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46227);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_subareas_responsable_servicio_apoyoModel varDetalle_subareas_responsable_servicio_apoyo= new Detalle_subareas_responsable_servicio_apoyoModel();


            if (id.ToString() != "0")
            {
                var Detalle_subareas_responsable_servicio_apoyosData = _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.ListaSelAll(0, 1000, "Detalle_subareas_responsable_servicio_apoyo.Clave=" + id, "").Resource.Detalle_subareas_responsable_servicio_apoyos;
				
				if (Detalle_subareas_responsable_servicio_apoyosData != null && Detalle_subareas_responsable_servicio_apoyosData.Count > 0)
                {
					var Detalle_subareas_responsable_servicio_apoyoData = Detalle_subareas_responsable_servicio_apoyosData.First();
					varDetalle_subareas_responsable_servicio_apoyo= new Detalle_subareas_responsable_servicio_apoyoModel
					{
						Clave  = Detalle_subareas_responsable_servicio_apoyoData.Clave 
	                    ,SubArea_Asignada = Detalle_subareas_responsable_servicio_apoyoData.SubArea_Asignada
                    ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_subareas_responsable_servicio_apoyoData.SubArea_Asignada), "SubArea_de_Servicios_de_Apoyo") ??  (string)Detalle_subareas_responsable_servicio_apoyoData.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea_Asignada != null && SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_subareas_responsable_servicio_apoyo", varDetalle_subareas_responsable_servicio_apoyo);
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
        public ActionResult GetSubArea_de_Servicios_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_subareas_responsable_servicio_apoyoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_subareas_responsable_servicio_apoyos == null)
                result.Detalle_subareas_responsable_servicio_apoyos = new List<Detalle_subareas_responsable_servicio_apoyo>();

            return Json(new
            {
                data = result.Detalle_subareas_responsable_servicio_apoyos.Select(m => new Detalle_subareas_responsable_servicio_apoyoGridModel
                    {
                    Clave = m.Clave
                        ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion

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
                _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_subareas_responsable_servicio_apoyo varDetalle_subareas_responsable_servicio_apoyo = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_subareas_responsable_servicio_apoyoModel varDetalle_subareas_responsable_servicio_apoyo)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_subareas_responsable_servicio_apoyoInfo = new Detalle_subareas_responsable_servicio_apoyo
                    {
                        Clave = varDetalle_subareas_responsable_servicio_apoyo.Clave
                        ,SubArea_Asignada = varDetalle_subareas_responsable_servicio_apoyo.SubArea_Asignada

                    };

                    result = !IsNew ?
                        _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.Update(Detalle_subareas_responsable_servicio_apoyoInfo, null, null).Resource.ToString() :
                         _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.Insert(Detalle_subareas_responsable_servicio_apoyoInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_subareas_responsable_servicio_apoyo script
        /// </summary>
        /// <param name="oDetalle_subareas_responsable_servicio_apoyoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_subareas_responsable_servicio_apoyoModuleAttributeList)
        {
            for (int i = 0; i < Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_subareas_responsable_servicio_apoyoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_subareas_responsable_servicio_apoyo.js")))
            {
                strDetalle_subareas_responsable_servicio_apoyoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_subareas_responsable_servicio_apoyo element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_subareas_responsable_servicio_apoyoScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_subareas_responsable_servicio_apoyoScript.Substring(indexOfArray, strDetalle_subareas_responsable_servicio_apoyoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_subareas_responsable_servicio_apoyoScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_subareas_responsable_servicio_apoyoScript.Substring(indexOfArrayHistory, strDetalle_subareas_responsable_servicio_apoyoScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_subareas_responsable_servicio_apoyoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_subareas_responsable_servicio_apoyoScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_subareas_responsable_servicio_apoyoScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_subareas_responsable_servicio_apoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_subareas_responsable_servicio_apoyoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_subareas_responsable_servicio_apoyoScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_subareas_responsable_servicio_apoyoScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_subareas_responsable_servicio_apoyoScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_subareas_responsable_servicio_apoyo.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_subareas_responsable_servicio_apoyo.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_subareas_responsable_servicio_apoyo.js")))
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
        public ActionResult Detalle_subareas_responsable_servicio_apoyoPropertyBag()
        {
            return PartialView("Detalle_subareas_responsable_servicio_apoyoPropertyBag", "Detalle_subareas_responsable_servicio_apoyo");
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

            _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_subareas_responsable_servicio_apoyoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_subareas_responsable_servicio_apoyos == null)
                result.Detalle_subareas_responsable_servicio_apoyos = new List<Detalle_subareas_responsable_servicio_apoyo>();

            var data = result.Detalle_subareas_responsable_servicio_apoyos.Select(m => new Detalle_subareas_responsable_servicio_apoyoGridModel
            {
                Clave = m.Clave
                ,SubArea_AsignadaDescripcion = (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_subareas_responsable_servicio_apoyoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_subareas_responsable_servicio_apoyoList_" + DateTime.Now.ToString());
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

            _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_subareas_responsable_servicio_apoyoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_subareas_responsable_servicio_apoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_subareas_responsable_servicio_apoyos == null)
                result.Detalle_subareas_responsable_servicio_apoyos = new List<Detalle_subareas_responsable_servicio_apoyo>();

            var data = result.Detalle_subareas_responsable_servicio_apoyos.Select(m => new Detalle_subareas_responsable_servicio_apoyoGridModel
            {
                Clave = m.Clave
                ,SubArea_AsignadaDescripcion = (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
