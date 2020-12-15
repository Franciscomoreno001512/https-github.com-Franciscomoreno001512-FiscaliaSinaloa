using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Vinculacion_Judicializacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Vinculacion_Judicializacion;

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
    public class Detalle_Vinculacion_JudicializacionController : Controller
    {
        #region "variable declaration"

        private IDetalle_Vinculacion_JudicializacionService service = null;
        private IDetalle_Vinculacion_JudicializacionApiConsumer _IDetalle_Vinculacion_JudicializacionApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Vinculacion_JudicializacionController(IDetalle_Vinculacion_JudicializacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Vinculacion_JudicializacionApiConsumer Detalle_Vinculacion_JudicializacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Vinculacion_JudicializacionApiConsumer = Detalle_Vinculacion_JudicializacionApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Vinculacion_Judicializacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45638, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45638);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Vinculacion_Judicializacion/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45638, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45638);
            ViewBag.Permission = permission;
            var varDetalle_Vinculacion_Judicializacion = new Detalle_Vinculacion_JudicializacionModel();
			
            ViewBag.ObjectId = "45638";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Vinculacion_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Vinculacion_JudicializacionData = _IDetalle_Vinculacion_JudicializacionApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Vinculacion_Judicializacions[0];
                if (Detalle_Vinculacion_JudicializacionData == null)
                    return HttpNotFound();

                varDetalle_Vinculacion_Judicializacion = new Detalle_Vinculacion_JudicializacionModel
                {
                    Clave = (int)Detalle_Vinculacion_JudicializacionData.Clave
                    ,Relacion = Detalle_Vinculacion_JudicializacionData.Relacion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Vinculacion_Judicializacion);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Vinculacion_Judicializacion(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45638);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Vinculacion_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Vinculacion_JudicializacionModel varDetalle_Vinculacion_Judicializacion= new Detalle_Vinculacion_JudicializacionModel();


            if (id.ToString() != "0")
            {
                var Detalle_Vinculacion_JudicializacionsData = _IDetalle_Vinculacion_JudicializacionApiConsumer.ListaSelAll(0, 1000, "Detalle_Vinculacion_Judicializacion.Clave=" + id, "").Resource.Detalle_Vinculacion_Judicializacions;
				
				if (Detalle_Vinculacion_JudicializacionsData != null && Detalle_Vinculacion_JudicializacionsData.Count > 0)
                {
					var Detalle_Vinculacion_JudicializacionData = Detalle_Vinculacion_JudicializacionsData.First();
					varDetalle_Vinculacion_Judicializacion= new Detalle_Vinculacion_JudicializacionModel
					{
						Clave  = Detalle_Vinculacion_JudicializacionData.Clave 
	                    ,Relacion = Detalle_Vinculacion_JudicializacionData.Relacion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDetalle_Vinculacion_Judicializacion", varDetalle_Vinculacion_Judicializacion);
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Vinculacion_JudicializacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Vinculacion_JudicializacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Vinculacion_Judicializacions == null)
                result.Detalle_Vinculacion_Judicializacions = new List<Detalle_Vinculacion_Judicializacion>();

            return Json(new
            {
                data = result.Detalle_Vinculacion_Judicializacions.Select(m => new Detalle_Vinculacion_JudicializacionGridModel
                    {
                    Clave = m.Clave
			,Relacion = m.Relacion

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
                _IDetalle_Vinculacion_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Vinculacion_Judicializacion varDetalle_Vinculacion_Judicializacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Vinculacion_JudicializacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Vinculacion_JudicializacionModel varDetalle_Vinculacion_Judicializacion)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Vinculacion_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Vinculacion_JudicializacionInfo = new Detalle_Vinculacion_Judicializacion
                    {
                        Clave = varDetalle_Vinculacion_Judicializacion.Clave
                        ,Relacion = varDetalle_Vinculacion_Judicializacion.Relacion

                    };

                    result = !IsNew ?
                        _IDetalle_Vinculacion_JudicializacionApiConsumer.Update(Detalle_Vinculacion_JudicializacionInfo, null, null).Resource.ToString() :
                         _IDetalle_Vinculacion_JudicializacionApiConsumer.Insert(Detalle_Vinculacion_JudicializacionInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Vinculacion_Judicializacion script
        /// </summary>
        /// <param name="oDetalle_Vinculacion_JudicializacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Vinculacion_JudicializacionModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Vinculacion_JudicializacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Vinculacion_JudicializacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Vinculacion_JudicializacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Vinculacion_JudicializacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Vinculacion_JudicializacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Vinculacion_JudicializacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Vinculacion_JudicializacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Vinculacion_JudicializacionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Vinculacion_JudicializacionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Vinculacion_JudicializacionModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Vinculacion_JudicializacionModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Vinculacion_JudicializacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Vinculacion_Judicializacion.js")))
            {
                strDetalle_Vinculacion_JudicializacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Vinculacion_Judicializacion element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Vinculacion_JudicializacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Vinculacion_JudicializacionScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Vinculacion_JudicializacionScript.Substring(indexOfArray, strDetalle_Vinculacion_JudicializacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Vinculacion_JudicializacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Vinculacion_JudicializacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Vinculacion_JudicializacionScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Vinculacion_JudicializacionScript.Substring(indexOfArrayHistory, strDetalle_Vinculacion_JudicializacionScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Vinculacion_JudicializacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Vinculacion_JudicializacionScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Vinculacion_JudicializacionScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Vinculacion_JudicializacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Vinculacion_JudicializacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Vinculacion_JudicializacionScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Vinculacion_JudicializacionScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Vinculacion_JudicializacionScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Vinculacion_Judicializacion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Vinculacion_Judicializacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Vinculacion_Judicializacion.js")))
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
        public ActionResult Detalle_Vinculacion_JudicializacionPropertyBag()
        {
            return PartialView("Detalle_Vinculacion_JudicializacionPropertyBag", "Detalle_Vinculacion_Judicializacion");
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

            _IDetalle_Vinculacion_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Vinculacion_JudicializacionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Vinculacion_JudicializacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Vinculacion_Judicializacions == null)
                result.Detalle_Vinculacion_Judicializacions = new List<Detalle_Vinculacion_Judicializacion>();

            var data = result.Detalle_Vinculacion_Judicializacions.Select(m => new Detalle_Vinculacion_JudicializacionGridModel
            {
                Clave = m.Clave
                ,Relacion = m.Relacion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Vinculacion_JudicializacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Vinculacion_JudicializacionList_" + DateTime.Now.ToString());
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

            _IDetalle_Vinculacion_JudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Vinculacion_JudicializacionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Vinculacion_JudicializacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Vinculacion_Judicializacions == null)
                result.Detalle_Vinculacion_Judicializacions = new List<Detalle_Vinculacion_Judicializacion>();

            var data = result.Detalle_Vinculacion_Judicializacions.Select(m => new Detalle_Vinculacion_JudicializacionGridModel
            {
                Clave = m.Clave
                ,Relacion = m.Relacion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
