using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_telefono;
using Spartane.Core.Domain.Tipo_de_Telefono;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_telefono;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_telefono;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Telefono;

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
    public class Detalle_de_telefonoController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_telefonoService service = null;
        private IDetalle_de_telefonoApiConsumer _IDetalle_de_telefonoApiConsumer;
        private ITipo_de_TelefonoApiConsumer _ITipo_de_TelefonoApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_de_telefonoController(IDetalle_de_telefonoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_telefonoApiConsumer Detalle_de_telefonoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ITipo_de_TelefonoApiConsumer Tipo_de_TelefonoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_telefonoApiConsumer = Detalle_de_telefonoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ITipo_de_TelefonoApiConsumer = Tipo_de_TelefonoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_telefono
        [ObjectAuth(ObjectId = (ModuleObjectId)45678, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45678);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_de_telefono/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45678, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45678);
            ViewBag.Permission = permission;
            var varDetalle_de_telefono = new Detalle_de_telefonoModel();
			
            ViewBag.ObjectId = "45678";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_telefonoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_telefonoData = _IDetalle_de_telefonoApiConsumer.GetByKeyComplete(Id).Resource.Detalle_de_telefonos[0];
                if (Detalle_de_telefonoData == null)
                    return HttpNotFound();

                varDetalle_de_telefono = new Detalle_de_telefonoModel
                {
                    Clave = (int)Detalle_de_telefonoData.Clave
                    ,Tipo_de_Telefono = Detalle_de_telefonoData.Tipo_de_Telefono
                    ,Tipo_de_TelefonoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_telefonoData.Tipo_de_Telefono), "Tipo_de_Telefono") ??  (string)Detalle_de_telefonoData.Tipo_de_Telefono_Tipo_de_Telefono.Descripcion
                    ,Telefono = Detalle_de_telefonoData.Telefono
                    ,Extension = Detalle_de_telefonoData.Extension

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_TelefonoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Telefonos_Tipo_de_Telefono = _ITipo_de_TelefonoApiConsumer.SelAll(true);
            if (Tipo_de_Telefonos_Tipo_de_Telefono != null && Tipo_de_Telefonos_Tipo_de_Telefono.Resource != null)
                ViewBag.Tipo_de_Telefonos_Tipo_de_Telefono = Tipo_de_Telefonos_Tipo_de_Telefono.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Telefono", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_de_telefono);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_telefono(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45678);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_telefonoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_telefonoModel varDetalle_de_telefono= new Detalle_de_telefonoModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_telefonosData = _IDetalle_de_telefonoApiConsumer.ListaSelAll(0, 1000, "Detalle_de_telefono.Clave=" + id, "").Resource.Detalle_de_telefonos;
				
				if (Detalle_de_telefonosData != null && Detalle_de_telefonosData.Count > 0)
                {
					var Detalle_de_telefonoData = Detalle_de_telefonosData.First();
					varDetalle_de_telefono= new Detalle_de_telefonoModel
					{
						Clave  = Detalle_de_telefonoData.Clave 
	                    ,Tipo_de_Telefono = Detalle_de_telefonoData.Tipo_de_Telefono
                    ,Tipo_de_TelefonoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_telefonoData.Tipo_de_Telefono), "Tipo_de_Telefono") ??  (string)Detalle_de_telefonoData.Tipo_de_Telefono_Tipo_de_Telefono.Descripcion
                    ,Telefono = Detalle_de_telefonoData.Telefono
                    ,Extension = Detalle_de_telefonoData.Extension

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_TelefonoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Telefonos_Tipo_de_Telefono = _ITipo_de_TelefonoApiConsumer.SelAll(true);
            if (Tipo_de_Telefonos_Tipo_de_Telefono != null && Tipo_de_Telefonos_Tipo_de_Telefono.Resource != null)
                ViewBag.Tipo_de_Telefonos_Tipo_de_Telefono = Tipo_de_Telefonos_Tipo_de_Telefono.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Telefono", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_telefono", varDetalle_de_telefono);
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
        public ActionResult GetTipo_de_TelefonoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_TelefonoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_TelefonoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Telefono", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_telefonoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_telefonoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_telefonos == null)
                result.Detalle_de_telefonos = new List<Detalle_de_telefono>();

            return Json(new
            {
                data = result.Detalle_de_telefonos.Select(m => new Detalle_de_telefonoGridModel
                    {
                    Clave = m.Clave
                        ,Tipo_de_TelefonoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Telefono_Tipo_de_Telefono.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Telefono_Tipo_de_Telefono.Descripcion
			,Telefono = m.Telefono
			,Extension = m.Extension

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
                _IDetalle_de_telefonoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_telefono varDetalle_de_telefono = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_telefonoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_telefonoModel varDetalle_de_telefono)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_telefonoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_telefonoInfo = new Detalle_de_telefono
                    {
                        Clave = varDetalle_de_telefono.Clave
                        ,Tipo_de_Telefono = varDetalle_de_telefono.Tipo_de_Telefono
                        ,Telefono = varDetalle_de_telefono.Telefono
                        ,Extension = varDetalle_de_telefono.Extension

                    };

                    result = !IsNew ?
                        _IDetalle_de_telefonoApiConsumer.Update(Detalle_de_telefonoInfo, null, null).Resource.ToString() :
                         _IDetalle_de_telefonoApiConsumer.Insert(Detalle_de_telefonoInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_de_telefono script
        /// </summary>
        /// <param name="oDetalle_de_telefonoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_de_telefonoModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_telefonoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_telefonoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_telefonoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_telefonoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_telefonoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_telefonoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_telefonoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_de_telefonoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_de_telefonoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_de_telefonoModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_de_telefonoModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_de_telefonoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_telefono.js")))
            {
                strDetalle_de_telefonoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_telefono element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_telefonoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_telefonoScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_telefonoScript.Substring(indexOfArray, strDetalle_de_telefonoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_telefonoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_telefonoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_telefonoScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_de_telefonoScript.Substring(indexOfArrayHistory, strDetalle_de_telefonoScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_de_telefonoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_telefonoScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_telefonoScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_de_telefonoModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_de_telefonoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_de_telefonoScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_de_telefonoScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_de_telefonoScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_telefono.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_telefono.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_telefono.js")))
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
        public ActionResult Detalle_de_telefonoPropertyBag()
        {
            return PartialView("Detalle_de_telefonoPropertyBag", "Detalle_de_telefono");
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

            _IDetalle_de_telefonoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_telefonoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_telefonoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_telefonos == null)
                result.Detalle_de_telefonos = new List<Detalle_de_telefono>();

            var data = result.Detalle_de_telefonos.Select(m => new Detalle_de_telefonoGridModel
            {
                Clave = m.Clave
                ,Tipo_de_TelefonoDescripcion = (string)m.Tipo_de_Telefono_Tipo_de_Telefono.Descripcion
                ,Telefono = m.Telefono
                ,Extension = m.Extension

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_de_telefonoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_de_telefonoList_" + DateTime.Now.ToString());
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

            _IDetalle_de_telefonoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_telefonoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_telefonoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_telefonos == null)
                result.Detalle_de_telefonos = new List<Detalle_de_telefono>();

            var data = result.Detalle_de_telefonos.Select(m => new Detalle_de_telefonoGridModel
            {
                Clave = m.Clave
                ,Tipo_de_TelefonoDescripcion = (string)m.Tipo_de_Telefono_Tipo_de_Telefono.Descripcion
                ,Telefono = m.Telefono
                ,Extension = m.Extension

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
