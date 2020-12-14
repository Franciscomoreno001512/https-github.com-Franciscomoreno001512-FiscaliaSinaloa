using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Medidas_Proteccion;
using Spartane.Core.Domain.Medida_de_Proteccion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Medidas_Proteccion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Medidas_Proteccion;
using Spartane.Web.Areas.WebApiConsumer.Medida_de_Proteccion;

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
    public class Detalle_Medidas_ProteccionController : Controller
    {
        #region "variable declaration"

        private IDetalle_Medidas_ProteccionService service = null;
        private IDetalle_Medidas_ProteccionApiConsumer _IDetalle_Medidas_ProteccionApiConsumer;
        private IMedida_de_ProteccionApiConsumer _IMedida_de_ProteccionApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Medidas_ProteccionController(IDetalle_Medidas_ProteccionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Medidas_ProteccionApiConsumer Detalle_Medidas_ProteccionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IMedida_de_ProteccionApiConsumer Medida_de_ProteccionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Medidas_ProteccionApiConsumer = Detalle_Medidas_ProteccionApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IMedida_de_ProteccionApiConsumer = Medida_de_ProteccionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Medidas_Proteccion
        [ObjectAuth(ObjectId = (ModuleObjectId)45625, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45625);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Medidas_Proteccion/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45625, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45625);
            ViewBag.Permission = permission;
            var varDetalle_Medidas_Proteccion = new Detalle_Medidas_ProteccionModel();
			
            ViewBag.ObjectId = "45625";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Medidas_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Medidas_ProteccionData = _IDetalle_Medidas_ProteccionApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Medidas_Proteccions[0];
                if (Detalle_Medidas_ProteccionData == null)
                    return HttpNotFound();

                varDetalle_Medidas_Proteccion = new Detalle_Medidas_ProteccionModel
                {
                    Clave = (int)Detalle_Medidas_ProteccionData.Clave
                    ,Seleccionar = Detalle_Medidas_ProteccionData.Seleccionar.GetValueOrDefault()
                    ,Medida = Detalle_Medidas_ProteccionData.Medida
                    ,MedidaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Medidas_ProteccionData.Medida), "Medida_de_Proteccion") ??  (string)Detalle_Medidas_ProteccionData.Medida_Medida_de_Proteccion.Descripcion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IMedida_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Medida_de_Proteccions_Medida = _IMedida_de_ProteccionApiConsumer.SelAll(true);
            if (Medida_de_Proteccions_Medida != null && Medida_de_Proteccions_Medida.Resource != null)
                ViewBag.Medida_de_Proteccions_Medida = Medida_de_Proteccions_Medida.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Medida_de_Proteccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Medidas_Proteccion);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Medidas_Proteccion(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45625);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Medidas_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Medidas_ProteccionModel varDetalle_Medidas_Proteccion= new Detalle_Medidas_ProteccionModel();


            if (id.ToString() != "0")
            {
                var Detalle_Medidas_ProteccionsData = _IDetalle_Medidas_ProteccionApiConsumer.ListaSelAll(0, 1000, "Detalle_Medidas_Proteccion.Clave=" + id, "").Resource.Detalle_Medidas_Proteccions;
				
				if (Detalle_Medidas_ProteccionsData != null && Detalle_Medidas_ProteccionsData.Count > 0)
                {
					var Detalle_Medidas_ProteccionData = Detalle_Medidas_ProteccionsData.First();
					varDetalle_Medidas_Proteccion= new Detalle_Medidas_ProteccionModel
					{
						Clave  = Detalle_Medidas_ProteccionData.Clave 
	                    ,Seleccionar = Detalle_Medidas_ProteccionData.Seleccionar.GetValueOrDefault()
                    ,Medida = Detalle_Medidas_ProteccionData.Medida
                    ,MedidaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Medidas_ProteccionData.Medida), "Medida_de_Proteccion") ??  (string)Detalle_Medidas_ProteccionData.Medida_Medida_de_Proteccion.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IMedida_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Medida_de_Proteccions_Medida = _IMedida_de_ProteccionApiConsumer.SelAll(true);
            if (Medida_de_Proteccions_Medida != null && Medida_de_Proteccions_Medida.Resource != null)
                ViewBag.Medida_de_Proteccions_Medida = Medida_de_Proteccions_Medida.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Medida_de_Proteccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_Medidas_Proteccion", varDetalle_Medidas_Proteccion);
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
        public ActionResult GetMedida_de_ProteccionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMedida_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMedida_de_ProteccionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Medida_de_Proteccion", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Medidas_ProteccionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Medidas_ProteccionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Medidas_Proteccions == null)
                result.Detalle_Medidas_Proteccions = new List<Detalle_Medidas_Proteccion>();

            return Json(new
            {
                data = result.Detalle_Medidas_Proteccions.Select(m => new Detalle_Medidas_ProteccionGridModel
                    {
                    Clave = m.Clave
			,Seleccionar = m.Seleccionar
                        ,MedidaDescripcion = CultureHelper.GetTraduction(m.Medida_Medida_de_Proteccion.Clave.ToString(), "Descripcion") ?? (string)m.Medida_Medida_de_Proteccion.Descripcion

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
                _IDetalle_Medidas_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Medidas_Proteccion varDetalle_Medidas_Proteccion = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Medidas_ProteccionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Medidas_ProteccionModel varDetalle_Medidas_Proteccion)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Medidas_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Medidas_ProteccionInfo = new Detalle_Medidas_Proteccion
                    {
                        Clave = varDetalle_Medidas_Proteccion.Clave
                        ,Seleccionar = varDetalle_Medidas_Proteccion.Seleccionar
                        ,Medida = varDetalle_Medidas_Proteccion.Medida

                    };

                    result = !IsNew ?
                        _IDetalle_Medidas_ProteccionApiConsumer.Update(Detalle_Medidas_ProteccionInfo, null, null).Resource.ToString() :
                         _IDetalle_Medidas_ProteccionApiConsumer.Insert(Detalle_Medidas_ProteccionInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Medidas_Proteccion script
        /// </summary>
        /// <param name="oDetalle_Medidas_ProteccionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Medidas_ProteccionModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Medidas_ProteccionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Medidas_ProteccionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Medidas_ProteccionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Medidas_ProteccionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Medidas_ProteccionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Medidas_ProteccionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Medidas_ProteccionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Medidas_ProteccionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Medidas_ProteccionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Medidas_ProteccionModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Medidas_ProteccionModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Medidas_ProteccionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Medidas_Proteccion.js")))
            {
                strDetalle_Medidas_ProteccionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Medidas_Proteccion element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Medidas_ProteccionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Medidas_ProteccionScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Medidas_ProteccionScript.Substring(indexOfArray, strDetalle_Medidas_ProteccionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Medidas_ProteccionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Medidas_ProteccionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Medidas_ProteccionScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Medidas_ProteccionScript.Substring(indexOfArrayHistory, strDetalle_Medidas_ProteccionScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Medidas_ProteccionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Medidas_ProteccionScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Medidas_ProteccionScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Medidas_ProteccionModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Medidas_ProteccionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Medidas_ProteccionScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Medidas_ProteccionScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Medidas_ProteccionScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Medidas_Proteccion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Medidas_Proteccion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Medidas_Proteccion.js")))
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
        public ActionResult Detalle_Medidas_ProteccionPropertyBag()
        {
            return PartialView("Detalle_Medidas_ProteccionPropertyBag", "Detalle_Medidas_Proteccion");
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

            _IDetalle_Medidas_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Medidas_ProteccionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Medidas_ProteccionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Medidas_Proteccions == null)
                result.Detalle_Medidas_Proteccions = new List<Detalle_Medidas_Proteccion>();

            var data = result.Detalle_Medidas_Proteccions.Select(m => new Detalle_Medidas_ProteccionGridModel
            {
                Clave = m.Clave
                ,Seleccionar = m.Seleccionar
                ,MedidaDescripcion = (string)m.Medida_Medida_de_Proteccion.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Medidas_ProteccionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Medidas_ProteccionList_" + DateTime.Now.ToString());
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

            _IDetalle_Medidas_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Medidas_ProteccionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Medidas_ProteccionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Medidas_Proteccions == null)
                result.Detalle_Medidas_Proteccions = new List<Detalle_Medidas_Proteccion>();

            var data = result.Detalle_Medidas_Proteccions.Select(m => new Detalle_Medidas_ProteccionGridModel
            {
                Clave = m.Clave
                ,Seleccionar = m.Seleccionar
                ,MedidaDescripcion = (string)m.Medida_Medida_de_Proteccion.Descripcion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
