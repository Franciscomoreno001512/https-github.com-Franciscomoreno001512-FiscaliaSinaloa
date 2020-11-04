using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Retroalimentacion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Retroalimentacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Retroalimentacion;

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
    public class Detalle_de_RetroalimentacionController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_RetroalimentacionService service = null;
        private IDetalle_de_RetroalimentacionApiConsumer _IDetalle_de_RetroalimentacionApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_de_RetroalimentacionController(IDetalle_de_RetroalimentacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_RetroalimentacionApiConsumer Detalle_de_RetroalimentacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_RetroalimentacionApiConsumer = Detalle_de_RetroalimentacionApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Retroalimentacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45218, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45218);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_de_Retroalimentacion/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45218, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45218);
            ViewBag.Permission = permission;
            var varDetalle_de_Retroalimentacion = new Detalle_de_RetroalimentacionModel();
			
            ViewBag.ObjectId = "45218";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_RetroalimentacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_RetroalimentacionData = _IDetalle_de_RetroalimentacionApiConsumer.GetByKeyComplete(Id).Resource.Detalle_de_Retroalimentacions[0];
                if (Detalle_de_RetroalimentacionData == null)
                    return HttpNotFound();

                varDetalle_de_Retroalimentacion = new Detalle_de_RetroalimentacionModel
                {
                    Clave = (int)Detalle_de_RetroalimentacionData.Clave
                    ,Usuario_que_Registra = Detalle_de_RetroalimentacionData.Usuario_que_Registra
                    ,Fecha_de_Registro = (Detalle_de_RetroalimentacionData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Detalle_de_RetroalimentacionData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Detalle_de_RetroalimentacionData.Hora_de_Registro
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData.Retroalimentacion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_de_Retroalimentacion);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Retroalimentacion(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45218);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_RetroalimentacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_RetroalimentacionModel varDetalle_de_Retroalimentacion= new Detalle_de_RetroalimentacionModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_RetroalimentacionsData = _IDetalle_de_RetroalimentacionApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Retroalimentacion.Clave=" + id, "").Resource.Detalle_de_Retroalimentacions;
				
				if (Detalle_de_RetroalimentacionsData != null && Detalle_de_RetroalimentacionsData.Count > 0)
                {
					var Detalle_de_RetroalimentacionData = Detalle_de_RetroalimentacionsData.First();
					varDetalle_de_Retroalimentacion= new Detalle_de_RetroalimentacionModel
					{
						Clave  = Detalle_de_RetroalimentacionData.Clave 
	                    ,Usuario_que_Registra = Detalle_de_RetroalimentacionData.Usuario_que_Registra
                    ,Fecha_de_Registro = (Detalle_de_RetroalimentacionData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Detalle_de_RetroalimentacionData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Detalle_de_RetroalimentacionData.Hora_de_Registro
                    ,Retroalimentacion = Detalle_de_RetroalimentacionData.Retroalimentacion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDetalle_de_Retroalimentacion", varDetalle_de_Retroalimentacion);
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_RetroalimentacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_RetroalimentacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Retroalimentacions == null)
                result.Detalle_de_Retroalimentacions = new List<Detalle_de_Retroalimentacion>();

            return Json(new
            {
                data = result.Detalle_de_Retroalimentacions.Select(m => new Detalle_de_RetroalimentacionGridModel
                    {
                    Clave = m.Clave
			,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
			,Retroalimentacion = m.Retroalimentacion

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
                _IDetalle_de_RetroalimentacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Retroalimentacion varDetalle_de_Retroalimentacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_RetroalimentacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_RetroalimentacionModel varDetalle_de_Retroalimentacion)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_RetroalimentacionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_RetroalimentacionInfo = new Detalle_de_Retroalimentacion
                    {
                        Clave = varDetalle_de_Retroalimentacion.Clave
                        ,Usuario_que_Registra = varDetalle_de_Retroalimentacion.Usuario_que_Registra
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varDetalle_de_Retroalimentacion.Fecha_de_Registro)) ? DateTime.ParseExact(varDetalle_de_Retroalimentacion.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varDetalle_de_Retroalimentacion.Hora_de_Registro
                        ,Retroalimentacion = varDetalle_de_Retroalimentacion.Retroalimentacion

                    };

                    result = !IsNew ?
                        _IDetalle_de_RetroalimentacionApiConsumer.Update(Detalle_de_RetroalimentacionInfo, null, null).Resource.ToString() :
                         _IDetalle_de_RetroalimentacionApiConsumer.Insert(Detalle_de_RetroalimentacionInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_de_Retroalimentacion script
        /// </summary>
        /// <param name="oDetalle_de_RetroalimentacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_de_RetroalimentacionModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_RetroalimentacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_RetroalimentacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_RetroalimentacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_RetroalimentacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_RetroalimentacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_RetroalimentacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_RetroalimentacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_de_RetroalimentacionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_de_RetroalimentacionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_de_RetroalimentacionModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_de_RetroalimentacionModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_de_RetroalimentacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Retroalimentacion.js")))
            {
                strDetalle_de_RetroalimentacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Retroalimentacion element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_RetroalimentacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_RetroalimentacionScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_RetroalimentacionScript.Substring(indexOfArray, strDetalle_de_RetroalimentacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_RetroalimentacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_RetroalimentacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_RetroalimentacionScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_de_RetroalimentacionScript.Substring(indexOfArrayHistory, strDetalle_de_RetroalimentacionScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_de_RetroalimentacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_RetroalimentacionScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_RetroalimentacionScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_de_RetroalimentacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_de_RetroalimentacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_de_RetroalimentacionScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_de_RetroalimentacionScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_de_RetroalimentacionScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Retroalimentacion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Retroalimentacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Retroalimentacion.js")))
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
        public ActionResult Detalle_de_RetroalimentacionPropertyBag()
        {
            return PartialView("Detalle_de_RetroalimentacionPropertyBag", "Detalle_de_Retroalimentacion");
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

            _IDetalle_de_RetroalimentacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_RetroalimentacionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_RetroalimentacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Retroalimentacions == null)
                result.Detalle_de_Retroalimentacions = new List<Detalle_de_Retroalimentacion>();

            var data = result.Detalle_de_Retroalimentacions.Select(m => new Detalle_de_RetroalimentacionGridModel
            {
                Clave = m.Clave
                ,Usuario_que_Registra = m.Usuario_que_Registra
                ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Registro = m.Hora_de_Registro
                ,Retroalimentacion = m.Retroalimentacion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_de_RetroalimentacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_de_RetroalimentacionList_" + DateTime.Now.ToString());
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

            _IDetalle_de_RetroalimentacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_RetroalimentacionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_RetroalimentacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Retroalimentacions == null)
                result.Detalle_de_Retroalimentacions = new List<Detalle_de_Retroalimentacion>();

            var data = result.Detalle_de_Retroalimentacions.Select(m => new Detalle_de_RetroalimentacionGridModel
            {
                Clave = m.Clave
                ,Usuario_que_Registra = m.Usuario_que_Registra
                ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Registro = m.Hora_de_Registro
                ,Retroalimentacion = m.Retroalimentacion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
