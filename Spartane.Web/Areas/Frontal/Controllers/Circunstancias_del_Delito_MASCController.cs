using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Circunstancias_del_Delito_MASC;
using Spartane.Core.Domain.Circunstancias;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Circunstancias_del_Delito_MASC;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Circunstancias_del_Delito_MASC;
using Spartane.Web.Areas.WebApiConsumer.Circunstancias;

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
    public class Circunstancias_del_Delito_MASCController : Controller
    {
        #region "variable declaration"

        private ICircunstancias_del_Delito_MASCService service = null;
        private ICircunstancias_del_Delito_MASCApiConsumer _ICircunstancias_del_Delito_MASCApiConsumer;
        private ICircunstanciasApiConsumer _ICircunstanciasApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Circunstancias_del_Delito_MASCController(ICircunstancias_del_Delito_MASCService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ICircunstancias_del_Delito_MASCApiConsumer Circunstancias_del_Delito_MASCApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ICircunstanciasApiConsumer CircunstanciasApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ICircunstancias_del_Delito_MASCApiConsumer = Circunstancias_del_Delito_MASCApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ICircunstanciasApiConsumer = CircunstanciasApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Circunstancias_del_Delito_MASC
        [ObjectAuth(ObjectId = (ModuleObjectId)45332, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45332);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Circunstancias_del_Delito_MASC/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45332, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45332);
            ViewBag.Permission = permission;
            var varCircunstancias_del_Delito_MASC = new Circunstancias_del_Delito_MASCModel();
			
            ViewBag.ObjectId = "45332";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancias_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Circunstancias_del_Delito_MASCData = _ICircunstancias_del_Delito_MASCApiConsumer.GetByKeyComplete(Id).Resource.Circunstancias_del_Delito_MASCs[0];
                if (Circunstancias_del_Delito_MASCData == null)
                    return HttpNotFound();

                varCircunstancias_del_Delito_MASC = new Circunstancias_del_Delito_MASCModel
                {
                    Clave = (int)Circunstancias_del_Delito_MASCData.Clave
                    ,Tipo_de_Lugar = Circunstancias_del_Delito_MASCData.Tipo_de_Lugar
                    ,Tipo_de_LugarDescripcion = CultureHelper.GetTraduction(Convert.ToString(Circunstancias_del_Delito_MASCData.Tipo_de_Lugar), "Circunstancias") ??  (string)Circunstancias_del_Delito_MASCData.Tipo_de_Lugar_Circunstancias.Descripcion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICircunstanciasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstanciass_Tipo_de_Lugar = _ICircunstanciasApiConsumer.SelAll(true);
            if (Circunstanciass_Tipo_de_Lugar != null && Circunstanciass_Tipo_de_Lugar.Resource != null)
                ViewBag.Circunstanciass_Tipo_de_Lugar = Circunstanciass_Tipo_de_Lugar.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancias", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varCircunstancias_del_Delito_MASC);
        }
		
	[HttpGet]
        public ActionResult AddCircunstancias_del_Delito_MASC(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45332);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ICircunstancias_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
			Circunstancias_del_Delito_MASCModel varCircunstancias_del_Delito_MASC= new Circunstancias_del_Delito_MASCModel();


            if (id.ToString() != "0")
            {
                var Circunstancias_del_Delito_MASCsData = _ICircunstancias_del_Delito_MASCApiConsumer.ListaSelAll(0, 1000, "Circunstancias_del_Delito_MASC.Clave=" + id, "").Resource.Circunstancias_del_Delito_MASCs;
				
				if (Circunstancias_del_Delito_MASCsData != null && Circunstancias_del_Delito_MASCsData.Count > 0)
                {
					var Circunstancias_del_Delito_MASCData = Circunstancias_del_Delito_MASCsData.First();
					varCircunstancias_del_Delito_MASC= new Circunstancias_del_Delito_MASCModel
					{
						Clave  = Circunstancias_del_Delito_MASCData.Clave 
	                    ,Tipo_de_Lugar = Circunstancias_del_Delito_MASCData.Tipo_de_Lugar
                    ,Tipo_de_LugarDescripcion = CultureHelper.GetTraduction(Convert.ToString(Circunstancias_del_Delito_MASCData.Tipo_de_Lugar), "Circunstancias") ??  (string)Circunstancias_del_Delito_MASCData.Tipo_de_Lugar_Circunstancias.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICircunstanciasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstanciass_Tipo_de_Lugar = _ICircunstanciasApiConsumer.SelAll(true);
            if (Circunstanciass_Tipo_de_Lugar != null && Circunstanciass_Tipo_de_Lugar.Resource != null)
                ViewBag.Circunstanciass_Tipo_de_Lugar = Circunstanciass_Tipo_de_Lugar.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancias", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddCircunstancias_del_Delito_MASC", varCircunstancias_del_Delito_MASC);
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
        public ActionResult GetCircunstanciasAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstanciasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstanciasApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancias", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Circunstancias_del_Delito_MASCPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ICircunstancias_del_Delito_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Circunstancias_del_Delito_MASCs == null)
                result.Circunstancias_del_Delito_MASCs = new List<Circunstancias_del_Delito_MASC>();

            return Json(new
            {
                data = result.Circunstancias_del_Delito_MASCs.Select(m => new Circunstancias_del_Delito_MASCGridModel
                    {
                    Clave = m.Clave
                        ,Tipo_de_LugarDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_Circunstancias.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_Circunstancias.Descripcion

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
                _ICircunstancias_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                Circunstancias_del_Delito_MASC varCircunstancias_del_Delito_MASC = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _ICircunstancias_del_Delito_MASCApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Circunstancias_del_Delito_MASCModel varCircunstancias_del_Delito_MASC)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ICircunstancias_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Circunstancias_del_Delito_MASCInfo = new Circunstancias_del_Delito_MASC
                    {
                        Clave = varCircunstancias_del_Delito_MASC.Clave
                        ,Tipo_de_Lugar = varCircunstancias_del_Delito_MASC.Tipo_de_Lugar

                    };

                    result = !IsNew ?
                        _ICircunstancias_del_Delito_MASCApiConsumer.Update(Circunstancias_del_Delito_MASCInfo, null, null).Resource.ToString() :
                         _ICircunstancias_del_Delito_MASCApiConsumer.Insert(Circunstancias_del_Delito_MASCInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Circunstancias_del_Delito_MASC script
        /// </summary>
        /// <param name="oCircunstancias_del_Delito_MASCElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Circunstancias_del_Delito_MASCModuleAttributeList)
        {
            for (int i = 0; i < Circunstancias_del_Delito_MASCModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Circunstancias_del_Delito_MASCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Circunstancias_del_Delito_MASCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Circunstancias_del_Delito_MASCModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Circunstancias_del_Delito_MASCModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Circunstancias_del_Delito_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Circunstancias_del_Delito_MASCModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Circunstancias_del_Delito_MASCModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Circunstancias_del_Delito_MASCModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Circunstancias_del_Delito_MASCModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Circunstancias_del_Delito_MASCModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strCircunstancias_del_Delito_MASCScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Circunstancias_del_Delito_MASC.js")))
            {
                strCircunstancias_del_Delito_MASCScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Circunstancias_del_Delito_MASC element attributes
            string userChangeJson = jsSerialize.Serialize(Circunstancias_del_Delito_MASCModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strCircunstancias_del_Delito_MASCScript.IndexOf("inpuElementArray");
            string splittedString = strCircunstancias_del_Delito_MASCScript.Substring(indexOfArray, strCircunstancias_del_Delito_MASCScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Circunstancias_del_Delito_MASCModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Circunstancias_del_Delito_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strCircunstancias_del_Delito_MASCScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strCircunstancias_del_Delito_MASCScript.Substring(indexOfArrayHistory, strCircunstancias_del_Delito_MASCScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strCircunstancias_del_Delito_MASCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strCircunstancias_del_Delito_MASCScript.Substring(endIndexOfMainElement + indexOfArray, strCircunstancias_del_Delito_MASCScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Circunstancias_del_Delito_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strCircunstancias_del_Delito_MASCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strCircunstancias_del_Delito_MASCScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strCircunstancias_del_Delito_MASCScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strCircunstancias_del_Delito_MASCScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Circunstancias_del_Delito_MASC.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Circunstancias_del_Delito_MASC.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Circunstancias_del_Delito_MASC.js")))
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
        public ActionResult Circunstancias_del_Delito_MASCPropertyBag()
        {
            return PartialView("Circunstancias_del_Delito_MASCPropertyBag", "Circunstancias_del_Delito_MASC");
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

            _ICircunstancias_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Circunstancias_del_Delito_MASCPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ICircunstancias_del_Delito_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Circunstancias_del_Delito_MASCs == null)
                result.Circunstancias_del_Delito_MASCs = new List<Circunstancias_del_Delito_MASC>();

            var data = result.Circunstancias_del_Delito_MASCs.Select(m => new Circunstancias_del_Delito_MASCGridModel
            {
                Clave = m.Clave
                ,Tipo_de_LugarDescripcion = (string)m.Tipo_de_Lugar_Circunstancias.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Circunstancias_del_Delito_MASCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Circunstancias_del_Delito_MASCList_" + DateTime.Now.ToString());
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

            _ICircunstancias_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Circunstancias_del_Delito_MASCPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ICircunstancias_del_Delito_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Circunstancias_del_Delito_MASCs == null)
                result.Circunstancias_del_Delito_MASCs = new List<Circunstancias_del_Delito_MASC>();

            var data = result.Circunstancias_del_Delito_MASCs.Select(m => new Circunstancias_del_Delito_MASCGridModel
            {
                Clave = m.Clave
                ,Tipo_de_LugarDescripcion = (string)m.Tipo_de_Lugar_Circunstancias.Descripcion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
