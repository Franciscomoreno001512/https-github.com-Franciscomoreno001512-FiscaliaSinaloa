using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Aseguramiento_Otros;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Aseguramiento_Otros;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Otros;

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
    public class Detalle_Aseguramiento_OtrosController : Controller
    {
        #region "variable declaration"

        private IDetalle_Aseguramiento_OtrosService service = null;
        private IDetalle_Aseguramiento_OtrosApiConsumer _IDetalle_Aseguramiento_OtrosApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Aseguramiento_OtrosController(IDetalle_Aseguramiento_OtrosService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Aseguramiento_OtrosApiConsumer Detalle_Aseguramiento_OtrosApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Aseguramiento_OtrosApiConsumer = Detalle_Aseguramiento_OtrosApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Aseguramiento_Otros
        [ObjectAuth(ObjectId = (ModuleObjectId)45531, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45531);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Aseguramiento_Otros/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45531, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45531);
            ViewBag.Permission = permission;
            var varDetalle_Aseguramiento_Otros = new Detalle_Aseguramiento_OtrosModel();
			
            ViewBag.ObjectId = "45531";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Aseguramiento_OtrosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Aseguramiento_OtrosData = _IDetalle_Aseguramiento_OtrosApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Aseguramiento_Otross[0];
                if (Detalle_Aseguramiento_OtrosData == null)
                    return HttpNotFound();

                varDetalle_Aseguramiento_Otros = new Detalle_Aseguramiento_OtrosModel
                {
                    Clave = (int)Detalle_Aseguramiento_OtrosData.Clave
                    ,Tipo = Detalle_Aseguramiento_OtrosData.Tipo
                    ,Unidad_de_medida = Detalle_Aseguramiento_OtrosData.Unidad_de_medida
                    ,Cantidad = Detalle_Aseguramiento_OtrosData.Cantidad
                    ,Descripcion = Detalle_Aseguramiento_OtrosData.Descripcion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Aseguramiento_Otros);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Aseguramiento_Otros(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45531);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Aseguramiento_OtrosApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Aseguramiento_OtrosModel varDetalle_Aseguramiento_Otros= new Detalle_Aseguramiento_OtrosModel();


            if (id.ToString() != "0")
            {
                var Detalle_Aseguramiento_OtrossData = _IDetalle_Aseguramiento_OtrosApiConsumer.ListaSelAll(0, 1000, "Detalle_Aseguramiento_Otros.Clave=" + id, "").Resource.Detalle_Aseguramiento_Otross;
				
				if (Detalle_Aseguramiento_OtrossData != null && Detalle_Aseguramiento_OtrossData.Count > 0)
                {
					var Detalle_Aseguramiento_OtrosData = Detalle_Aseguramiento_OtrossData.First();
					varDetalle_Aseguramiento_Otros= new Detalle_Aseguramiento_OtrosModel
					{
						Clave  = Detalle_Aseguramiento_OtrosData.Clave 
	                    ,Tipo = Detalle_Aseguramiento_OtrosData.Tipo
                    ,Unidad_de_medida = Detalle_Aseguramiento_OtrosData.Unidad_de_medida
                    ,Cantidad = Detalle_Aseguramiento_OtrosData.Cantidad
                    ,Descripcion = Detalle_Aseguramiento_OtrosData.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDetalle_Aseguramiento_Otros", varDetalle_Aseguramiento_Otros);
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_OtrosPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Aseguramiento_OtrosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Otross == null)
                result.Detalle_Aseguramiento_Otross = new List<Detalle_Aseguramiento_Otros>();

            return Json(new
            {
                data = result.Detalle_Aseguramiento_Otross.Select(m => new Detalle_Aseguramiento_OtrosGridModel
                    {
                    Clave = m.Clave
			,Tipo = m.Tipo
			,Unidad_de_medida = m.Unidad_de_medida
			,Cantidad = m.Cantidad
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
                _IDetalle_Aseguramiento_OtrosApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Aseguramiento_Otros varDetalle_Aseguramiento_Otros = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Aseguramiento_OtrosApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Aseguramiento_OtrosModel varDetalle_Aseguramiento_Otros)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Aseguramiento_OtrosApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Aseguramiento_OtrosInfo = new Detalle_Aseguramiento_Otros
                    {
                        Clave = varDetalle_Aseguramiento_Otros.Clave
                        ,Tipo = varDetalle_Aseguramiento_Otros.Tipo
                        ,Unidad_de_medida = varDetalle_Aseguramiento_Otros.Unidad_de_medida
                        ,Cantidad = varDetalle_Aseguramiento_Otros.Cantidad
                        ,Descripcion = varDetalle_Aseguramiento_Otros.Descripcion

                    };

                    result = !IsNew ?
                        _IDetalle_Aseguramiento_OtrosApiConsumer.Update(Detalle_Aseguramiento_OtrosInfo, null, null).Resource.ToString() :
                         _IDetalle_Aseguramiento_OtrosApiConsumer.Insert(Detalle_Aseguramiento_OtrosInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Aseguramiento_Otros script
        /// </summary>
        /// <param name="oDetalle_Aseguramiento_OtrosElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Aseguramiento_OtrosModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Aseguramiento_OtrosModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Aseguramiento_OtrosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Aseguramiento_OtrosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Aseguramiento_OtrosModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Aseguramiento_OtrosModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Aseguramiento_OtrosModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Aseguramiento_OtrosModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Aseguramiento_OtrosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Aseguramiento_OtrosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Aseguramiento_OtrosModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Aseguramiento_OtrosModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Aseguramiento_OtrosScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Otros.js")))
            {
                strDetalle_Aseguramiento_OtrosScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Aseguramiento_Otros element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Aseguramiento_OtrosModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Aseguramiento_OtrosScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Aseguramiento_OtrosScript.Substring(indexOfArray, strDetalle_Aseguramiento_OtrosScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Aseguramiento_OtrosModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Aseguramiento_OtrosModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Aseguramiento_OtrosScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Aseguramiento_OtrosScript.Substring(indexOfArrayHistory, strDetalle_Aseguramiento_OtrosScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Aseguramiento_OtrosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Aseguramiento_OtrosScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Aseguramiento_OtrosScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Aseguramiento_OtrosModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Aseguramiento_OtrosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Aseguramiento_OtrosScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Aseguramiento_OtrosScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Aseguramiento_OtrosScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Otros.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Otros.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Aseguramiento_Otros.js")))
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
        public ActionResult Detalle_Aseguramiento_OtrosPropertyBag()
        {
            return PartialView("Detalle_Aseguramiento_OtrosPropertyBag", "Detalle_Aseguramiento_Otros");
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

            _IDetalle_Aseguramiento_OtrosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_OtrosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Aseguramiento_OtrosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Otross == null)
                result.Detalle_Aseguramiento_Otross = new List<Detalle_Aseguramiento_Otros>();

            var data = result.Detalle_Aseguramiento_Otross.Select(m => new Detalle_Aseguramiento_OtrosGridModel
            {
                Clave = m.Clave
                ,Tipo = m.Tipo
                ,Unidad_de_medida = m.Unidad_de_medida
                ,Cantidad = m.Cantidad
                ,Descripcion = m.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Aseguramiento_OtrosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Aseguramiento_OtrosList_" + DateTime.Now.ToString());
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

            _IDetalle_Aseguramiento_OtrosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Aseguramiento_OtrosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Aseguramiento_OtrosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Aseguramiento_Otross == null)
                result.Detalle_Aseguramiento_Otross = new List<Detalle_Aseguramiento_Otros>();

            var data = result.Detalle_Aseguramiento_Otross.Select(m => new Detalle_Aseguramiento_OtrosGridModel
            {
                Clave = m.Clave
                ,Tipo = m.Tipo
                ,Unidad_de_medida = m.Unidad_de_medida
                ,Cantidad = m.Cantidad
                ,Descripcion = m.Descripcion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
