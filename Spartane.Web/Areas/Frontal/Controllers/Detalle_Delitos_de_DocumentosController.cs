using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Delitos_de_Documentos;
using Spartane.Core.Domain.Detalle_de_Delito;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Delitos_de_Documentos;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Delitos_de_Documentos;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Delito;

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
    public class Detalle_Delitos_de_DocumentosController : Controller
    {
        #region "variable declaration"

        private IDetalle_Delitos_de_DocumentosService service = null;
        private IDetalle_Delitos_de_DocumentosApiConsumer _IDetalle_Delitos_de_DocumentosApiConsumer;
        private IDetalle_de_DelitoApiConsumer _IDetalle_de_DelitoApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Delitos_de_DocumentosController(IDetalle_Delitos_de_DocumentosService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Delitos_de_DocumentosApiConsumer Detalle_Delitos_de_DocumentosApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IDetalle_de_DelitoApiConsumer Detalle_de_DelitoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Delitos_de_DocumentosApiConsumer = Detalle_Delitos_de_DocumentosApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IDetalle_de_DelitoApiConsumer = Detalle_de_DelitoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Delitos_de_Documentos
        [ObjectAuth(ObjectId = (ModuleObjectId)45390, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45390);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Delitos_de_Documentos/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45390, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45390);
            ViewBag.Permission = permission;
            var varDetalle_Delitos_de_Documentos = new Detalle_Delitos_de_DocumentosModel();
			
            ViewBag.ObjectId = "45390";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Delitos_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Delitos_de_DocumentosData = _IDetalle_Delitos_de_DocumentosApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Delitos_de_Documentoss[0];
                if (Detalle_Delitos_de_DocumentosData == null)
                    return HttpNotFound();

                varDetalle_Delitos_de_Documentos = new Detalle_Delitos_de_DocumentosModel
                {
                    Clave = (int)Detalle_Delitos_de_DocumentosData.Clave
                    ,Delito = Detalle_Delitos_de_DocumentosData.Delito
                    ,DelitoDescripcion_corta = CultureHelper.GetTraduction(Convert.ToString(Detalle_Delitos_de_DocumentosData.Delito), "Detalle_de_Delito") ??  (string)Detalle_Delitos_de_DocumentosData.Delito_Detalle_de_Delito.Descripcion_corta

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Delitos_de_Documentos);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Delitos_de_Documentos(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45390);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Delitos_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Delitos_de_DocumentosModel varDetalle_Delitos_de_Documentos= new Detalle_Delitos_de_DocumentosModel();


            if (id.ToString() != "0")
            {
                var Detalle_Delitos_de_DocumentossData = _IDetalle_Delitos_de_DocumentosApiConsumer.ListaSelAll(0, 1000, "Detalle_Delitos_de_Documentos.Clave=" + id, "").Resource.Detalle_Delitos_de_Documentoss;
				
				if (Detalle_Delitos_de_DocumentossData != null && Detalle_Delitos_de_DocumentossData.Count > 0)
                {
					var Detalle_Delitos_de_DocumentosData = Detalle_Delitos_de_DocumentossData.First();
					varDetalle_Delitos_de_Documentos= new Detalle_Delitos_de_DocumentosModel
					{
						Clave  = Detalle_Delitos_de_DocumentosData.Clave 
	                    ,Delito = Detalle_Delitos_de_DocumentosData.Delito
                    ,DelitoDescripcion_corta = CultureHelper.GetTraduction(Convert.ToString(Detalle_Delitos_de_DocumentosData.Delito), "Detalle_de_Delito") ??  (string)Detalle_Delitos_de_DocumentosData.Delito_Detalle_de_Delito.Descripcion_corta

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDetalle_Delitos_de_Documentos", varDetalle_Delitos_de_Documentos);
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
        public ActionResult GetDetalle_de_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_DelitoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion_corta).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Delito", "Descripcion_corta")?? m.Descripcion_corta,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Delitos_de_DocumentosPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Delitos_de_DocumentosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Delitos_de_Documentoss == null)
                result.Detalle_Delitos_de_Documentoss = new List<Detalle_Delitos_de_Documentos>();

            return Json(new
            {
                data = result.Detalle_Delitos_de_Documentoss.Select(m => new Detalle_Delitos_de_DocumentosGridModel
                    {
                    Clave = m.Clave
                        ,DelitoDescripcion_corta = CultureHelper.GetTraduction(m.Delito_Detalle_de_Delito.Clave.ToString(), "Detalle_de_Delito") ?? (string)m.Delito_Detalle_de_Delito.Descripcion_corta

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_Delitos_de_Documentos_Delito_Detalle_de_Delito(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Delito.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Delito.Descripcion_corta as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_DelitoApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Delito.Descripcion_corta ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Delitos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Delito", "Descripcion_corta");
                    item.Descripcion_corta =trans ??item.Descripcion_corta;
                }
                return Json(result.Detalle_de_Delitos.ToArray(), JsonRequestBehavior.AllowGet);
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
                _IDetalle_Delitos_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Delitos_de_Documentos varDetalle_Delitos_de_Documentos = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Delitos_de_DocumentosApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Delitos_de_DocumentosModel varDetalle_Delitos_de_Documentos)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Delitos_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Delitos_de_DocumentosInfo = new Detalle_Delitos_de_Documentos
                    {
                        Clave = varDetalle_Delitos_de_Documentos.Clave
                        ,Delito = varDetalle_Delitos_de_Documentos.Delito

                    };

                    result = !IsNew ?
                        _IDetalle_Delitos_de_DocumentosApiConsumer.Update(Detalle_Delitos_de_DocumentosInfo, null, null).Resource.ToString() :
                         _IDetalle_Delitos_de_DocumentosApiConsumer.Insert(Detalle_Delitos_de_DocumentosInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Delitos_de_Documentos script
        /// </summary>
        /// <param name="oDetalle_Delitos_de_DocumentosElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Delitos_de_DocumentosModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Delitos_de_DocumentosModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Delitos_de_DocumentosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Delitos_de_DocumentosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Delitos_de_DocumentosModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Delitos_de_DocumentosModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Delitos_de_DocumentosModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Delitos_de_DocumentosModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Delitos_de_DocumentosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Delitos_de_DocumentosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Delitos_de_DocumentosModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Delitos_de_DocumentosModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Delitos_de_DocumentosScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Delitos_de_Documentos.js")))
            {
                strDetalle_Delitos_de_DocumentosScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Delitos_de_Documentos element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Delitos_de_DocumentosModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Delitos_de_DocumentosScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Delitos_de_DocumentosScript.Substring(indexOfArray, strDetalle_Delitos_de_DocumentosScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Delitos_de_DocumentosModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Delitos_de_DocumentosModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Delitos_de_DocumentosScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Delitos_de_DocumentosScript.Substring(indexOfArrayHistory, strDetalle_Delitos_de_DocumentosScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Delitos_de_DocumentosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Delitos_de_DocumentosScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Delitos_de_DocumentosScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Delitos_de_DocumentosModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Delitos_de_DocumentosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Delitos_de_DocumentosScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Delitos_de_DocumentosScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Delitos_de_DocumentosScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Delitos_de_Documentos.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Delitos_de_Documentos.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Delitos_de_Documentos.js")))
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
        public ActionResult Detalle_Delitos_de_DocumentosPropertyBag()
        {
            return PartialView("Detalle_Delitos_de_DocumentosPropertyBag", "Detalle_Delitos_de_Documentos");
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

            _IDetalle_Delitos_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Delitos_de_DocumentosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Delitos_de_DocumentosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Delitos_de_Documentoss == null)
                result.Detalle_Delitos_de_Documentoss = new List<Detalle_Delitos_de_Documentos>();

            var data = result.Detalle_Delitos_de_Documentoss.Select(m => new Detalle_Delitos_de_DocumentosGridModel
            {
                Clave = m.Clave
                ,DelitoDescripcion_corta = (string)m.Delito_Detalle_de_Delito.Descripcion_corta

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Delitos_de_DocumentosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Delitos_de_DocumentosList_" + DateTime.Now.ToString());
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

            _IDetalle_Delitos_de_DocumentosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Delitos_de_DocumentosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Delitos_de_DocumentosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Delitos_de_Documentoss == null)
                result.Detalle_Delitos_de_Documentoss = new List<Detalle_Delitos_de_Documentos>();

            var data = result.Detalle_Delitos_de_Documentoss.Select(m => new Detalle_Delitos_de_DocumentosGridModel
            {
                Clave = m.Clave
                ,DelitoDescripcion_corta = (string)m.Delito_Detalle_de_Delito.Descripcion_corta

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
