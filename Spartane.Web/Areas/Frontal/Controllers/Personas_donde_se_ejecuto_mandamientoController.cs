using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Personas_donde_se_ejecuto_mandamiento;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Personas_donde_se_ejecuto_mandamiento;

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
    public class Personas_donde_se_ejecuto_mandamientoController : Controller
    {
        #region "variable declaration"

        private IPersonas_donde_se_ejecuto_mandamientoService service = null;
        private IPersonas_donde_se_ejecuto_mandamientoApiConsumer _IPersonas_donde_se_ejecuto_mandamientoApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Personas_donde_se_ejecuto_mandamientoController(IPersonas_donde_se_ejecuto_mandamientoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IPersonas_donde_se_ejecuto_mandamientoApiConsumer Personas_donde_se_ejecuto_mandamientoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IPersonas_donde_se_ejecuto_mandamientoApiConsumer = Personas_donde_se_ejecuto_mandamientoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Personas_donde_se_ejecuto_mandamiento
        [ObjectAuth(ObjectId = (ModuleObjectId)46304, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46304);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Personas_donde_se_ejecuto_mandamiento/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)46304, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46304);
            ViewBag.Permission = permission;
            var varPersonas_donde_se_ejecuto_mandamiento = new Personas_donde_se_ejecuto_mandamientoModel();
			
            ViewBag.ObjectId = "46304";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Personas_donde_se_ejecuto_mandamientoData = _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.GetByKeyComplete(Id).Resource.Personas_donde_se_ejecuto_mandamientos[0];
                if (Personas_donde_se_ejecuto_mandamientoData == null)
                    return HttpNotFound();

                varPersonas_donde_se_ejecuto_mandamiento = new Personas_donde_se_ejecuto_mandamientoModel
                {
                    Folio = (int)Personas_donde_se_ejecuto_mandamientoData.Folio
                    ,Persona = Personas_donde_se_ejecuto_mandamientoData.Persona
                    ,Seleccionar = Personas_donde_se_ejecuto_mandamientoData.Seleccionar.GetValueOrDefault()
                    ,PersonaId = Personas_donde_se_ejecuto_mandamientoData.PersonaId

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varPersonas_donde_se_ejecuto_mandamiento);
        }
		
	[HttpGet]
        public ActionResult AddPersonas_donde_se_ejecuto_mandamiento(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46304);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Personas_donde_se_ejecuto_mandamientoModel varPersonas_donde_se_ejecuto_mandamiento= new Personas_donde_se_ejecuto_mandamientoModel();


            if (id.ToString() != "0")
            {
                var Personas_donde_se_ejecuto_mandamientosData = _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.ListaSelAll(0, 1000, "Personas_donde_se_ejecuto_mandamiento.Folio=" + id, "").Resource.Personas_donde_se_ejecuto_mandamientos;
				
				if (Personas_donde_se_ejecuto_mandamientosData != null && Personas_donde_se_ejecuto_mandamientosData.Count > 0)
                {
					var Personas_donde_se_ejecuto_mandamientoData = Personas_donde_se_ejecuto_mandamientosData.First();
					varPersonas_donde_se_ejecuto_mandamiento= new Personas_donde_se_ejecuto_mandamientoModel
					{
						Folio  = Personas_donde_se_ejecuto_mandamientoData.Folio 
	                    ,Persona = Personas_donde_se_ejecuto_mandamientoData.Persona
                    ,Seleccionar = Personas_donde_se_ejecuto_mandamientoData.Seleccionar.GetValueOrDefault()
                    ,PersonaId = Personas_donde_se_ejecuto_mandamientoData.PersonaId

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddPersonas_donde_se_ejecuto_mandamiento", varPersonas_donde_se_ejecuto_mandamiento);
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Personas_donde_se_ejecuto_mandamientoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Personas_donde_se_ejecuto_mandamientos == null)
                result.Personas_donde_se_ejecuto_mandamientos = new List<Personas_donde_se_ejecuto_mandamiento>();

            return Json(new
            {
                data = result.Personas_donde_se_ejecuto_mandamientos.Select(m => new Personas_donde_se_ejecuto_mandamientoGridModel
                    {
                    Folio = m.Folio
			,Persona = m.Persona
			,Seleccionar = m.Seleccionar
			,PersonaId = m.PersonaId

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
                _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Personas_donde_se_ejecuto_mandamiento varPersonas_donde_se_ejecuto_mandamiento = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Personas_donde_se_ejecuto_mandamientoModel varPersonas_donde_se_ejecuto_mandamiento)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Personas_donde_se_ejecuto_mandamientoInfo = new Personas_donde_se_ejecuto_mandamiento
                    {
                        Folio = varPersonas_donde_se_ejecuto_mandamiento.Folio
                        ,Persona = varPersonas_donde_se_ejecuto_mandamiento.Persona
                        ,Seleccionar = varPersonas_donde_se_ejecuto_mandamiento.Seleccionar
                        ,PersonaId = varPersonas_donde_se_ejecuto_mandamiento.PersonaId

                    };

                    result = !IsNew ?
                        _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.Update(Personas_donde_se_ejecuto_mandamientoInfo, null, null).Resource.ToString() :
                         _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.Insert(Personas_donde_se_ejecuto_mandamientoInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Personas_donde_se_ejecuto_mandamiento script
        /// </summary>
        /// <param name="oPersonas_donde_se_ejecuto_mandamientoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Personas_donde_se_ejecuto_mandamientoModuleAttributeList)
        {
            for (int i = 0; i < Personas_donde_se_ejecuto_mandamientoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Personas_donde_se_ejecuto_mandamientoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Personas_donde_se_ejecuto_mandamientoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Personas_donde_se_ejecuto_mandamientoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Personas_donde_se_ejecuto_mandamientoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Personas_donde_se_ejecuto_mandamientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Personas_donde_se_ejecuto_mandamientoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Personas_donde_se_ejecuto_mandamientoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Personas_donde_se_ejecuto_mandamientoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Personas_donde_se_ejecuto_mandamientoModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Personas_donde_se_ejecuto_mandamientoModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strPersonas_donde_se_ejecuto_mandamientoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Personas_donde_se_ejecuto_mandamiento.js")))
            {
                strPersonas_donde_se_ejecuto_mandamientoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Personas_donde_se_ejecuto_mandamiento element attributes
            string userChangeJson = jsSerialize.Serialize(Personas_donde_se_ejecuto_mandamientoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strPersonas_donde_se_ejecuto_mandamientoScript.IndexOf("inpuElementArray");
            string splittedString = strPersonas_donde_se_ejecuto_mandamientoScript.Substring(indexOfArray, strPersonas_donde_se_ejecuto_mandamientoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Personas_donde_se_ejecuto_mandamientoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Personas_donde_se_ejecuto_mandamientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strPersonas_donde_se_ejecuto_mandamientoScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strPersonas_donde_se_ejecuto_mandamientoScript.Substring(indexOfArrayHistory, strPersonas_donde_se_ejecuto_mandamientoScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strPersonas_donde_se_ejecuto_mandamientoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strPersonas_donde_se_ejecuto_mandamientoScript.Substring(endIndexOfMainElement + indexOfArray, strPersonas_donde_se_ejecuto_mandamientoScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Personas_donde_se_ejecuto_mandamientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strPersonas_donde_se_ejecuto_mandamientoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strPersonas_donde_se_ejecuto_mandamientoScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strPersonas_donde_se_ejecuto_mandamientoScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strPersonas_donde_se_ejecuto_mandamientoScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Personas_donde_se_ejecuto_mandamiento.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Personas_donde_se_ejecuto_mandamiento.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Personas_donde_se_ejecuto_mandamiento.js")))
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
        public ActionResult Personas_donde_se_ejecuto_mandamientoPropertyBag()
        {
            return PartialView("Personas_donde_se_ejecuto_mandamientoPropertyBag", "Personas_donde_se_ejecuto_mandamiento");
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

            _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Personas_donde_se_ejecuto_mandamientoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Personas_donde_se_ejecuto_mandamientos == null)
                result.Personas_donde_se_ejecuto_mandamientos = new List<Personas_donde_se_ejecuto_mandamiento>();

            var data = result.Personas_donde_se_ejecuto_mandamientos.Select(m => new Personas_donde_se_ejecuto_mandamientoGridModel
            {
                Folio = m.Folio
                ,Persona = m.Persona
                ,Seleccionar = m.Seleccionar
                ,PersonaId = m.PersonaId

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Personas_donde_se_ejecuto_mandamientoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Personas_donde_se_ejecuto_mandamientoList_" + DateTime.Now.ToString());
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

            _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Personas_donde_se_ejecuto_mandamientoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IPersonas_donde_se_ejecuto_mandamientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Personas_donde_se_ejecuto_mandamientos == null)
                result.Personas_donde_se_ejecuto_mandamientos = new List<Personas_donde_se_ejecuto_mandamiento>();

            var data = result.Personas_donde_se_ejecuto_mandamientos.Select(m => new Personas_donde_se_ejecuto_mandamientoGridModel
            {
                Folio = m.Folio
                ,Persona = m.Persona
                ,Seleccionar = m.Seleccionar
                ,PersonaId = m.PersonaId

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
