using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.PreRequisito_de_Movimiento;
using Spartane.Core.Domain.Configurador_de_Movimientos;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.PreRequisito_de_Movimiento;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.PreRequisito_de_Movimiento;
using Spartane.Web.Areas.WebApiConsumer.Configurador_de_Movimientos;

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
    public class PreRequisito_de_MovimientoController : Controller
    {
        #region "variable declaration"

        private IPreRequisito_de_MovimientoService service = null;
        private IPreRequisito_de_MovimientoApiConsumer _IPreRequisito_de_MovimientoApiConsumer;
        private IConfigurador_de_MovimientosApiConsumer _IConfigurador_de_MovimientosApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public PreRequisito_de_MovimientoController(IPreRequisito_de_MovimientoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IPreRequisito_de_MovimientoApiConsumer PreRequisito_de_MovimientoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IConfigurador_de_MovimientosApiConsumer Configurador_de_MovimientosApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IPreRequisito_de_MovimientoApiConsumer = PreRequisito_de_MovimientoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IConfigurador_de_MovimientosApiConsumer = Configurador_de_MovimientosApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/PreRequisito_de_Movimiento
        [ObjectAuth(ObjectId = (ModuleObjectId)45737, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45737);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/PreRequisito_de_Movimiento/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45737, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45737);
            ViewBag.Permission = permission;
            var varPreRequisito_de_Movimiento = new PreRequisito_de_MovimientoModel();
			
            ViewBag.ObjectId = "45737";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPreRequisito_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var PreRequisito_de_MovimientoData = _IPreRequisito_de_MovimientoApiConsumer.GetByKeyComplete(Id).Resource.PreRequisito_de_Movimientos[0];
                if (PreRequisito_de_MovimientoData == null)
                    return HttpNotFound();

                varPreRequisito_de_Movimiento = new PreRequisito_de_MovimientoModel
                {
                    Clave = (int)PreRequisito_de_MovimientoData.Clave
                    ,PreRequisito = PreRequisito_de_MovimientoData.PreRequisito
                    ,PreRequisitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(PreRequisito_de_MovimientoData.PreRequisito), "Configurador_de_Movimientos") ??  (string)PreRequisito_de_MovimientoData.PreRequisito_Configurador_de_Movimientos.Descripcion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varPreRequisito_de_Movimiento);
        }
		
	[HttpGet]
        public ActionResult AddPreRequisito_de_Movimiento(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45737);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IPreRequisito_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
			PreRequisito_de_MovimientoModel varPreRequisito_de_Movimiento= new PreRequisito_de_MovimientoModel();


            if (id.ToString() != "0")
            {
                var PreRequisito_de_MovimientosData = _IPreRequisito_de_MovimientoApiConsumer.ListaSelAll(0, 1000, "PreRequisito_de_Movimiento.Clave=" + id, "").Resource.PreRequisito_de_Movimientos;
				
				if (PreRequisito_de_MovimientosData != null && PreRequisito_de_MovimientosData.Count > 0)
                {
					var PreRequisito_de_MovimientoData = PreRequisito_de_MovimientosData.First();
					varPreRequisito_de_Movimiento= new PreRequisito_de_MovimientoModel
					{
						Clave  = PreRequisito_de_MovimientoData.Clave 
	                    ,PreRequisito = PreRequisito_de_MovimientoData.PreRequisito
                    ,PreRequisitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(PreRequisito_de_MovimientoData.PreRequisito), "Configurador_de_Movimientos") ??  (string)PreRequisito_de_MovimientoData.PreRequisito_Configurador_de_Movimientos.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddPreRequisito_de_Movimiento", varPreRequisito_de_Movimiento);
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
        public ActionResult GetConfigurador_de_MovimientosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConfigurador_de_MovimientosApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Configurador_de_Movimientos", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new PreRequisito_de_MovimientoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IPreRequisito_de_MovimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.PreRequisito_de_Movimientos == null)
                result.PreRequisito_de_Movimientos = new List<PreRequisito_de_Movimiento>();

            return Json(new
            {
                data = result.PreRequisito_de_Movimientos.Select(m => new PreRequisito_de_MovimientoGridModel
                    {
                    Clave = m.Clave
                        ,PreRequisitoDescripcion = CultureHelper.GetTraduction(m.PreRequisito_Configurador_de_Movimientos.Clave.ToString(), "Configurador_de_Movimientos") ?? (string)m.PreRequisito_Configurador_de_Movimientos.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetPreRequisito_de_Movimiento_PreRequisito_Configurador_de_Movimientos(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConfigurador_de_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Configurador_de_Movimientos.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Configurador_de_Movimientos.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IConfigurador_de_MovimientosApiConsumer.ListaSelAll(1, 20,elWhere , " Configurador_de_Movimientos.Descripcion ASC ").Resource;
               
                foreach (var item in result.Configurador_de_Movimientoss)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Configurador_de_Movimientos", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Configurador_de_Movimientoss.ToArray(), JsonRequestBehavior.AllowGet);
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
                _IPreRequisito_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

                PreRequisito_de_Movimiento varPreRequisito_de_Movimiento = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IPreRequisito_de_MovimientoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, PreRequisito_de_MovimientoModel varPreRequisito_de_Movimiento)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IPreRequisito_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var PreRequisito_de_MovimientoInfo = new PreRequisito_de_Movimiento
                    {
                        Clave = varPreRequisito_de_Movimiento.Clave
                        ,PreRequisito = varPreRequisito_de_Movimiento.PreRequisito

                    };

                    result = !IsNew ?
                        _IPreRequisito_de_MovimientoApiConsumer.Update(PreRequisito_de_MovimientoInfo, null, null).Resource.ToString() :
                         _IPreRequisito_de_MovimientoApiConsumer.Insert(PreRequisito_de_MovimientoInfo, null, null).Resource.ToString();

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
        /// Write Element Array of PreRequisito_de_Movimiento script
        /// </summary>
        /// <param name="oPreRequisito_de_MovimientoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements PreRequisito_de_MovimientoModuleAttributeList)
        {
            for (int i = 0; i < PreRequisito_de_MovimientoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(PreRequisito_de_MovimientoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    PreRequisito_de_MovimientoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(PreRequisito_de_MovimientoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    PreRequisito_de_MovimientoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (PreRequisito_de_MovimientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < PreRequisito_de_MovimientoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(PreRequisito_de_MovimientoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						PreRequisito_de_MovimientoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(PreRequisito_de_MovimientoModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						PreRequisito_de_MovimientoModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strPreRequisito_de_MovimientoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/PreRequisito_de_Movimiento.js")))
            {
                strPreRequisito_de_MovimientoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change PreRequisito_de_Movimiento element attributes
            string userChangeJson = jsSerialize.Serialize(PreRequisito_de_MovimientoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strPreRequisito_de_MovimientoScript.IndexOf("inpuElementArray");
            string splittedString = strPreRequisito_de_MovimientoScript.Substring(indexOfArray, strPreRequisito_de_MovimientoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(PreRequisito_de_MovimientoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (PreRequisito_de_MovimientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strPreRequisito_de_MovimientoScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strPreRequisito_de_MovimientoScript.Substring(indexOfArrayHistory, strPreRequisito_de_MovimientoScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strPreRequisito_de_MovimientoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strPreRequisito_de_MovimientoScript.Substring(endIndexOfMainElement + indexOfArray, strPreRequisito_de_MovimientoScript.Length - (endIndexOfMainElement + indexOfArray));
            if (PreRequisito_de_MovimientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strPreRequisito_de_MovimientoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strPreRequisito_de_MovimientoScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strPreRequisito_de_MovimientoScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strPreRequisito_de_MovimientoScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/PreRequisito_de_Movimiento.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/PreRequisito_de_Movimiento.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/PreRequisito_de_Movimiento.js")))
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
        public ActionResult PreRequisito_de_MovimientoPropertyBag()
        {
            return PartialView("PreRequisito_de_MovimientoPropertyBag", "PreRequisito_de_Movimiento");
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

            _IPreRequisito_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new PreRequisito_de_MovimientoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IPreRequisito_de_MovimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.PreRequisito_de_Movimientos == null)
                result.PreRequisito_de_Movimientos = new List<PreRequisito_de_Movimiento>();

            var data = result.PreRequisito_de_Movimientos.Select(m => new PreRequisito_de_MovimientoGridModel
            {
                Clave = m.Clave
                ,PreRequisitoDescripcion = (string)m.PreRequisito_Configurador_de_Movimientos.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "PreRequisito_de_MovimientoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "PreRequisito_de_MovimientoList_" + DateTime.Now.ToString());
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

            _IPreRequisito_de_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new PreRequisito_de_MovimientoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IPreRequisito_de_MovimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.PreRequisito_de_Movimientos == null)
                result.PreRequisito_de_Movimientos = new List<PreRequisito_de_Movimiento>();

            var data = result.PreRequisito_de_Movimientos.Select(m => new PreRequisito_de_MovimientoGridModel
            {
                Clave = m.Clave
                ,PreRequisitoDescripcion = (string)m.PreRequisito_Configurador_de_Movimientos.Descripcion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
