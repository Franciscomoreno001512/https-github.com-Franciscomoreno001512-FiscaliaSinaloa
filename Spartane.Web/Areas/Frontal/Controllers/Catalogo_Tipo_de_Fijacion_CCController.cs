using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Catalogo_Tipo_de_Fijacion_CC;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Catalogo_Tipo_de_Fijacion_CC;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Catalogo_Tipo_de_Fijacion_CC;

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
    public class Catalogo_Tipo_de_Fijacion_CCController : Controller
    {
        #region "variable declaration"

        private ICatalogo_Tipo_de_Fijacion_CCService service = null;
        private ICatalogo_Tipo_de_Fijacion_CCApiConsumer _ICatalogo_Tipo_de_Fijacion_CCApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Catalogo_Tipo_de_Fijacion_CCController(ICatalogo_Tipo_de_Fijacion_CCService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ICatalogo_Tipo_de_Fijacion_CCApiConsumer Catalogo_Tipo_de_Fijacion_CCApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ICatalogo_Tipo_de_Fijacion_CCApiConsumer = Catalogo_Tipo_de_Fijacion_CCApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Catalogo_Tipo_de_Fijacion_CC
        [ObjectAuth(ObjectId = (ModuleObjectId)45144, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45144);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Catalogo_Tipo_de_Fijacion_CC/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45144, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45144);
            ViewBag.Permission = permission;
            var varCatalogo_Tipo_de_Fijacion_CC = new Catalogo_Tipo_de_Fijacion_CCModel();
			
            ViewBag.ObjectId = "45144";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Catalogo_Tipo_de_Fijacion_CCData = _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.GetByKeyComplete(Id).Resource.Catalogo_Tipo_de_Fijacion_CCs[0];
                if (Catalogo_Tipo_de_Fijacion_CCData == null)
                    return HttpNotFound();

                varCatalogo_Tipo_de_Fijacion_CC = new Catalogo_Tipo_de_Fijacion_CCModel
                {
                    Clave = (int)Catalogo_Tipo_de_Fijacion_CCData.Clave
                    ,Descripcion = Catalogo_Tipo_de_Fijacion_CCData.Descripcion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varCatalogo_Tipo_de_Fijacion_CC);
        }
		
	[HttpGet]
        public ActionResult AddCatalogo_Tipo_de_Fijacion_CC(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45144);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);
			Catalogo_Tipo_de_Fijacion_CCModel varCatalogo_Tipo_de_Fijacion_CC= new Catalogo_Tipo_de_Fijacion_CCModel();


            if (id.ToString() != "0")
            {
                var Catalogo_Tipo_de_Fijacion_CCsData = _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.ListaSelAll(0, 1000, "Catalogo_Tipo_de_Fijacion_CC.Clave=" + id, "").Resource.Catalogo_Tipo_de_Fijacion_CCs;
				
				if (Catalogo_Tipo_de_Fijacion_CCsData != null && Catalogo_Tipo_de_Fijacion_CCsData.Count > 0)
                {
					var Catalogo_Tipo_de_Fijacion_CCData = Catalogo_Tipo_de_Fijacion_CCsData.First();
					varCatalogo_Tipo_de_Fijacion_CC= new Catalogo_Tipo_de_Fijacion_CCModel
					{
						Clave  = Catalogo_Tipo_de_Fijacion_CCData.Clave 
	                    ,Descripcion = Catalogo_Tipo_de_Fijacion_CCData.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddCatalogo_Tipo_de_Fijacion_CC", varCatalogo_Tipo_de_Fijacion_CC);
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




        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Catalogo_Tipo_de_Fijacion_CCPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Catalogo_Tipo_de_Fijacion_CCs == null)
                result.Catalogo_Tipo_de_Fijacion_CCs = new List<Catalogo_Tipo_de_Fijacion_CC>();

            return Json(new
            {
                data = result.Catalogo_Tipo_de_Fijacion_CCs.Select(m => new Catalogo_Tipo_de_Fijacion_CCGridModel
                    {
                    Clave = m.Clave
			,Descripcion = m.Descripcion

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
                _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

                Catalogo_Tipo_de_Fijacion_CC varCatalogo_Tipo_de_Fijacion_CC = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Catalogo_Tipo_de_Fijacion_CCModel varCatalogo_Tipo_de_Fijacion_CC)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Catalogo_Tipo_de_Fijacion_CCInfo = new Catalogo_Tipo_de_Fijacion_CC
                    {
                        Clave = varCatalogo_Tipo_de_Fijacion_CC.Clave
                        ,Descripcion = varCatalogo_Tipo_de_Fijacion_CC.Descripcion

                    };

                    result = !IsNew ?
                        _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.Update(Catalogo_Tipo_de_Fijacion_CCInfo, null, null).Resource.ToString() :
                         _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.Insert(Catalogo_Tipo_de_Fijacion_CCInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Catalogo_Tipo_de_Fijacion_CC script
        /// </summary>
        /// <param name="oCatalogo_Tipo_de_Fijacion_CCElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Catalogo_Tipo_de_Fijacion_CCModuleAttributeList)
        {
            for (int i = 0; i < Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strCatalogo_Tipo_de_Fijacion_CCScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Catalogo_Tipo_de_Fijacion_CC.js")))
            {
                strCatalogo_Tipo_de_Fijacion_CCScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Catalogo_Tipo_de_Fijacion_CC element attributes
            string userChangeJson = jsSerialize.Serialize(Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strCatalogo_Tipo_de_Fijacion_CCScript.IndexOf("inpuElementArray");
            string splittedString = strCatalogo_Tipo_de_Fijacion_CCScript.Substring(indexOfArray, strCatalogo_Tipo_de_Fijacion_CCScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strCatalogo_Tipo_de_Fijacion_CCScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strCatalogo_Tipo_de_Fijacion_CCScript.Substring(indexOfArrayHistory, strCatalogo_Tipo_de_Fijacion_CCScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strCatalogo_Tipo_de_Fijacion_CCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strCatalogo_Tipo_de_Fijacion_CCScript.Substring(endIndexOfMainElement + indexOfArray, strCatalogo_Tipo_de_Fijacion_CCScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Catalogo_Tipo_de_Fijacion_CCModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strCatalogo_Tipo_de_Fijacion_CCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strCatalogo_Tipo_de_Fijacion_CCScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strCatalogo_Tipo_de_Fijacion_CCScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strCatalogo_Tipo_de_Fijacion_CCScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Catalogo_Tipo_de_Fijacion_CC.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Catalogo_Tipo_de_Fijacion_CC.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Catalogo_Tipo_de_Fijacion_CC.js")))
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
        public ActionResult Catalogo_Tipo_de_Fijacion_CCPropertyBag()
        {
            return PartialView("Catalogo_Tipo_de_Fijacion_CCPropertyBag", "Catalogo_Tipo_de_Fijacion_CC");
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

            _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Catalogo_Tipo_de_Fijacion_CCPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Catalogo_Tipo_de_Fijacion_CCs == null)
                result.Catalogo_Tipo_de_Fijacion_CCs = new List<Catalogo_Tipo_de_Fijacion_CC>();

            var data = result.Catalogo_Tipo_de_Fijacion_CCs.Select(m => new Catalogo_Tipo_de_Fijacion_CCGridModel
            {
                Clave = m.Clave
                ,Descripcion = m.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Catalogo_Tipo_de_Fijacion_CCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Catalogo_Tipo_de_Fijacion_CCList_" + DateTime.Now.ToString());
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

            _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Catalogo_Tipo_de_Fijacion_CCPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ICatalogo_Tipo_de_Fijacion_CCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Catalogo_Tipo_de_Fijacion_CCs == null)
                result.Catalogo_Tipo_de_Fijacion_CCs = new List<Catalogo_Tipo_de_Fijacion_CC>();

            var data = result.Catalogo_Tipo_de_Fijacion_CCs.Select(m => new Catalogo_Tipo_de_Fijacion_CCGridModel
            {
                Clave = m.Clave
                ,Descripcion = m.Descripcion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
