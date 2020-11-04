using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Spartan_RDM_Operations_Detail;
using Spartane.Core.Domain.Spartan_Object_ByPass;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Spartan_RDM_Operations_Detail;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Spartan_RDM_Operations_Detail;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Object_ByPass;

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
    public class Spartan_RDM_Operations_DetailController : Controller
    {
        #region "variable declaration"

        private ISpartan_RDM_Operations_DetailService service = null;
        private ISpartan_RDM_Operations_DetailApiConsumer _ISpartan_RDM_Operations_DetailApiConsumer;
        private ISpartan_Object_ByPassApiConsumer _ISpartan_Object_ByPassApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Spartan_RDM_Operations_DetailController(ISpartan_RDM_Operations_DetailService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ISpartan_RDM_Operations_DetailApiConsumer Spartan_RDM_Operations_DetailApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ISpartan_Object_ByPassApiConsumer Spartan_Object_ByPassApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ISpartan_RDM_Operations_DetailApiConsumer = Spartan_RDM_Operations_DetailApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_Object_ByPassApiConsumer = Spartan_Object_ByPassApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Spartan_RDM_Operations_Detail
        [ObjectAuth(ObjectId = (ModuleObjectId)45363, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45363);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Spartan_RDM_Operations_Detail/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45363, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45363);
            ViewBag.Permission = permission;
            var varSpartan_RDM_Operations_Detail = new Spartan_RDM_Operations_DetailModel();
			
            ViewBag.ObjectId = "45363";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_RDM_Operations_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Spartan_RDM_Operations_DetailData = _ISpartan_RDM_Operations_DetailApiConsumer.GetByKeyComplete(Id).Resource.Spartan_RDM_Operations_Details[0];
                if (Spartan_RDM_Operations_DetailData == null)
                    return HttpNotFound();

                varSpartan_RDM_Operations_Detail = new Spartan_RDM_Operations_DetailModel
                {
                    DetailId = (int)Spartan_RDM_Operations_DetailData.DetailId
                    ,Object_Name = Spartan_RDM_Operations_DetailData.Object_Name
                    ,Object_NameDescription = CultureHelper.GetTraduction(Convert.ToString(Spartan_RDM_Operations_DetailData.Object_Name), "Spartan_Object_ByPass") ??  (string)Spartan_RDM_Operations_DetailData.Object_Name_Spartan_Object_ByPass.Description
                    ,Object_Label = Spartan_RDM_Operations_DetailData.Object_Label
                    ,Order_Shown = Spartan_RDM_Operations_DetailData.Order_Shown
                    ,Count_Query = Spartan_RDM_Operations_DetailData.Count_Query
                    ,Query_Data = Spartan_RDM_Operations_DetailData.Query_Data
                    ,Icono = Spartan_RDM_Operations_DetailData.Icono

                };
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.IconoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varSpartan_RDM_Operations_Detail.Icono).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_Object_ByPassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Object_ByPasss_Object_Name = _ISpartan_Object_ByPassApiConsumer.SelAll(true);
            if (Spartan_Object_ByPasss_Object_Name != null && Spartan_Object_ByPasss_Object_Name.Resource != null)
                ViewBag.Spartan_Object_ByPasss_Object_Name = Spartan_Object_ByPasss_Object_Name.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ObjectId), "Spartan_Object_ByPass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.ObjectId)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varSpartan_RDM_Operations_Detail);
        }
		
	[HttpGet]
        public ActionResult AddSpartan_RDM_Operations_Detail(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45363);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ISpartan_RDM_Operations_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);
			Spartan_RDM_Operations_DetailModel varSpartan_RDM_Operations_Detail= new Spartan_RDM_Operations_DetailModel();


            if (id.ToString() != "0")
            {
                var Spartan_RDM_Operations_DetailsData = _ISpartan_RDM_Operations_DetailApiConsumer.ListaSelAll(0, 1000, "Spartan_RDM_Operations_Detail.DetailId=" + id, "").Resource.Spartan_RDM_Operations_Details;
				
				if (Spartan_RDM_Operations_DetailsData != null && Spartan_RDM_Operations_DetailsData.Count > 0)
                {
					var Spartan_RDM_Operations_DetailData = Spartan_RDM_Operations_DetailsData.First();
					varSpartan_RDM_Operations_Detail= new Spartan_RDM_Operations_DetailModel
					{
						DetailId  = Spartan_RDM_Operations_DetailData.DetailId 
	                    ,Object_Name = Spartan_RDM_Operations_DetailData.Object_Name
                    ,Object_NameDescription = CultureHelper.GetTraduction(Convert.ToString(Spartan_RDM_Operations_DetailData.Object_Name), "Spartan_Object_ByPass") ??  (string)Spartan_RDM_Operations_DetailData.Object_Name_Spartan_Object_ByPass.Description
                    ,Object_Label = Spartan_RDM_Operations_DetailData.Object_Label
                    ,Order_Shown = Spartan_RDM_Operations_DetailData.Order_Shown
                    ,Count_Query = Spartan_RDM_Operations_DetailData.Count_Query
                    ,Query_Data = Spartan_RDM_Operations_DetailData.Query_Data
                    ,Icono = Spartan_RDM_Operations_DetailData.Icono

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.IconoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varSpartan_RDM_Operations_Detail.Icono).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_Object_ByPassApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Object_ByPasss_Object_Name = _ISpartan_Object_ByPassApiConsumer.SelAll(true);
            if (Spartan_Object_ByPasss_Object_Name != null && Spartan_Object_ByPasss_Object_Name.Resource != null)
                ViewBag.Spartan_Object_ByPasss_Object_Name = Spartan_Object_ByPasss_Object_Name.Resource.Where(m => m.Description != null).OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.ObjectId), "Spartan_Object_ByPass", "Description") ?? m.Description.ToString(), Value = Convert.ToString(m.ObjectId)
                }).ToList();


            return PartialView("AddSpartan_RDM_Operations_Detail", varSpartan_RDM_Operations_Detail);
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
        public ActionResult GetSpartan_Object_ByPassAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_Object_ByPassApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_Object_ByPassApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Description).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.ObjectId), "Spartan_Object_ByPass", "Description")?? m.Description,
                    Value = Convert.ToString(m.ObjectId)
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Spartan_RDM_Operations_DetailPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ISpartan_RDM_Operations_DetailApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Spartan_RDM_Operations_Details == null)
                result.Spartan_RDM_Operations_Details = new List<Spartan_RDM_Operations_Detail>();

            return Json(new
            {
                data = result.Spartan_RDM_Operations_Details.Select(m => new Spartan_RDM_Operations_DetailGridModel
                    {
                    DetailId = m.DetailId
                        ,Object_NameDescription = CultureHelper.GetTraduction(m.Object_Name_Spartan_Object_ByPass.ObjectId.ToString(), "Description") ?? (string)m.Object_Name_Spartan_Object_ByPass.Description
			,Object_Label = m.Object_Label
			,Order_Shown = m.Order_Shown
			,Count_Query = m.Count_Query
			,Query_Data = m.Query_Data
			,Icono = m.Icono

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
                _ISpartan_RDM_Operations_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);

                Spartan_RDM_Operations_Detail varSpartan_RDM_Operations_Detail = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _ISpartan_RDM_Operations_DetailApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Spartan_RDM_Operations_DetailModel varSpartan_RDM_Operations_Detail)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ISpartan_RDM_Operations_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varSpartan_RDM_Operations_Detail.IconoRemoveAttachment != 0 && varSpartan_RDM_Operations_Detail.IconoFile == null)
                    {
                        varSpartan_RDM_Operations_Detail.Icono = 0;
                    }

                    if (varSpartan_RDM_Operations_Detail.IconoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varSpartan_RDM_Operations_Detail.IconoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varSpartan_RDM_Operations_Detail.Icono = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varSpartan_RDM_Operations_Detail.IconoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Spartan_RDM_Operations_DetailInfo = new Spartan_RDM_Operations_Detail
                    {
                        DetailId = varSpartan_RDM_Operations_Detail.DetailId
                        ,Object_Name = varSpartan_RDM_Operations_Detail.Object_Name
                        ,Object_Label = varSpartan_RDM_Operations_Detail.Object_Label
                        ,Order_Shown = varSpartan_RDM_Operations_Detail.Order_Shown
                        ,Count_Query = varSpartan_RDM_Operations_Detail.Count_Query
                        ,Query_Data = varSpartan_RDM_Operations_Detail.Query_Data
                        ,Icono = (varSpartan_RDM_Operations_Detail.Icono.HasValue && varSpartan_RDM_Operations_Detail.Icono != 0) ? ((int?)Convert.ToInt32(varSpartan_RDM_Operations_Detail.Icono.Value)) : null


                    };

                    result = !IsNew ?
                        _ISpartan_RDM_Operations_DetailApiConsumer.Update(Spartan_RDM_Operations_DetailInfo, null, null).Resource.ToString() :
                         _ISpartan_RDM_Operations_DetailApiConsumer.Insert(Spartan_RDM_Operations_DetailInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Spartan_RDM_Operations_Detail script
        /// </summary>
        /// <param name="oSpartan_RDM_Operations_DetailElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Spartan_RDM_Operations_DetailModuleAttributeList)
        {
            for (int i = 0; i < Spartan_RDM_Operations_DetailModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Spartan_RDM_Operations_DetailModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Spartan_RDM_Operations_DetailModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Spartan_RDM_Operations_DetailModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Spartan_RDM_Operations_DetailModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Spartan_RDM_Operations_DetailModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Spartan_RDM_Operations_DetailModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Spartan_RDM_Operations_DetailModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Spartan_RDM_Operations_DetailModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Spartan_RDM_Operations_DetailModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Spartan_RDM_Operations_DetailModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strSpartan_RDM_Operations_DetailScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Spartan_RDM_Operations_Detail.js")))
            {
                strSpartan_RDM_Operations_DetailScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Spartan_RDM_Operations_Detail element attributes
            string userChangeJson = jsSerialize.Serialize(Spartan_RDM_Operations_DetailModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strSpartan_RDM_Operations_DetailScript.IndexOf("inpuElementArray");
            string splittedString = strSpartan_RDM_Operations_DetailScript.Substring(indexOfArray, strSpartan_RDM_Operations_DetailScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Spartan_RDM_Operations_DetailModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Spartan_RDM_Operations_DetailModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strSpartan_RDM_Operations_DetailScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strSpartan_RDM_Operations_DetailScript.Substring(indexOfArrayHistory, strSpartan_RDM_Operations_DetailScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strSpartan_RDM_Operations_DetailScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strSpartan_RDM_Operations_DetailScript.Substring(endIndexOfMainElement + indexOfArray, strSpartan_RDM_Operations_DetailScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Spartan_RDM_Operations_DetailModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strSpartan_RDM_Operations_DetailScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strSpartan_RDM_Operations_DetailScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strSpartan_RDM_Operations_DetailScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strSpartan_RDM_Operations_DetailScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Spartan_RDM_Operations_Detail.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Spartan_RDM_Operations_Detail.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Spartan_RDM_Operations_Detail.js")))
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
        public ActionResult Spartan_RDM_Operations_DetailPropertyBag()
        {
            return PartialView("Spartan_RDM_Operations_DetailPropertyBag", "Spartan_RDM_Operations_Detail");
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

            _ISpartan_RDM_Operations_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Spartan_RDM_Operations_DetailPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISpartan_RDM_Operations_DetailApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Spartan_RDM_Operations_Details == null)
                result.Spartan_RDM_Operations_Details = new List<Spartan_RDM_Operations_Detail>();

            var data = result.Spartan_RDM_Operations_Details.Select(m => new Spartan_RDM_Operations_DetailGridModel
            {
                DetailId = m.DetailId
                ,Object_NameDescription = (string)m.Object_Name_Spartan_Object_ByPass.Description
                ,Object_Label = m.Object_Label
                ,Order_Shown = m.Order_Shown
                ,Count_Query = m.Count_Query
                ,Query_Data = m.Query_Data

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Spartan_RDM_Operations_DetailList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Spartan_RDM_Operations_DetailList_" + DateTime.Now.ToString());
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

            _ISpartan_RDM_Operations_DetailApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Spartan_RDM_Operations_DetailPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISpartan_RDM_Operations_DetailApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Spartan_RDM_Operations_Details == null)
                result.Spartan_RDM_Operations_Details = new List<Spartan_RDM_Operations_Detail>();

            var data = result.Spartan_RDM_Operations_Details.Select(m => new Spartan_RDM_Operations_DetailGridModel
            {
                DetailId = m.DetailId
                ,Object_NameDescription = (string)m.Object_Name_Spartan_Object_ByPass.Description
                ,Object_Label = m.Object_Label
                ,Order_Shown = m.Order_Shown
                ,Count_Query = m.Count_Query
                ,Query_Data = m.Query_Data

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
