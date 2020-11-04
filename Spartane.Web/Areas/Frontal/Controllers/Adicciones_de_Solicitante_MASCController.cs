using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Adicciones_de_Solicitante_MASC;
using Spartane.Core.Domain.Adicciones;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Adicciones_de_Solicitante_MASC;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Adicciones_de_Solicitante_MASC;
using Spartane.Web.Areas.WebApiConsumer.Adicciones;

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
    public class Adicciones_de_Solicitante_MASCController : Controller
    {
        #region "variable declaration"

        private IAdicciones_de_Solicitante_MASCService service = null;
        private IAdicciones_de_Solicitante_MASCApiConsumer _IAdicciones_de_Solicitante_MASCApiConsumer;
        private IAdiccionesApiConsumer _IAdiccionesApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Adicciones_de_Solicitante_MASCController(IAdicciones_de_Solicitante_MASCService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IAdicciones_de_Solicitante_MASCApiConsumer Adicciones_de_Solicitante_MASCApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IAdiccionesApiConsumer AdiccionesApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IAdicciones_de_Solicitante_MASCApiConsumer = Adicciones_de_Solicitante_MASCApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IAdiccionesApiConsumer = AdiccionesApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Adicciones_de_Solicitante_MASC
        [ObjectAuth(ObjectId = (ModuleObjectId)45341, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45341);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Adicciones_de_Solicitante_MASC/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45341, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45341);
            ViewBag.Permission = permission;
            var varAdicciones_de_Solicitante_MASC = new Adicciones_de_Solicitante_MASCModel();
			
            ViewBag.ObjectId = "45341";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAdicciones_de_Solicitante_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Adicciones_de_Solicitante_MASCData = _IAdicciones_de_Solicitante_MASCApiConsumer.GetByKeyComplete(Id).Resource.Adicciones_de_Solicitante_MASCs[0];
                if (Adicciones_de_Solicitante_MASCData == null)
                    return HttpNotFound();

                varAdicciones_de_Solicitante_MASC = new Adicciones_de_Solicitante_MASCModel
                {
                    Clave = (int)Adicciones_de_Solicitante_MASCData.Clave
                    ,Descripcion = Adicciones_de_Solicitante_MASCData.Descripcion
                    ,DescripcionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Adicciones_de_Solicitante_MASCData.Descripcion), "Adicciones") ??  (string)Adicciones_de_Solicitante_MASCData.Descripcion_Adicciones.Descripcion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IAdiccionesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Adiccioness_Descripcion = _IAdiccionesApiConsumer.SelAll(true);
            if (Adiccioness_Descripcion != null && Adiccioness_Descripcion.Resource != null)
                ViewBag.Adiccioness_Descripcion = Adiccioness_Descripcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Adicciones", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varAdicciones_de_Solicitante_MASC);
        }
		
	[HttpGet]
        public ActionResult AddAdicciones_de_Solicitante_MASC(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45341);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IAdicciones_de_Solicitante_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
			Adicciones_de_Solicitante_MASCModel varAdicciones_de_Solicitante_MASC= new Adicciones_de_Solicitante_MASCModel();


            if (id.ToString() != "0")
            {
                var Adicciones_de_Solicitante_MASCsData = _IAdicciones_de_Solicitante_MASCApiConsumer.ListaSelAll(0, 1000, "Adicciones_de_Solicitante_MASC.Clave=" + id, "").Resource.Adicciones_de_Solicitante_MASCs;
				
				if (Adicciones_de_Solicitante_MASCsData != null && Adicciones_de_Solicitante_MASCsData.Count > 0)
                {
					var Adicciones_de_Solicitante_MASCData = Adicciones_de_Solicitante_MASCsData.First();
					varAdicciones_de_Solicitante_MASC= new Adicciones_de_Solicitante_MASCModel
					{
						Clave  = Adicciones_de_Solicitante_MASCData.Clave 
	                    ,Descripcion = Adicciones_de_Solicitante_MASCData.Descripcion
                    ,DescripcionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Adicciones_de_Solicitante_MASCData.Descripcion), "Adicciones") ??  (string)Adicciones_de_Solicitante_MASCData.Descripcion_Adicciones.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IAdiccionesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Adiccioness_Descripcion = _IAdiccionesApiConsumer.SelAll(true);
            if (Adiccioness_Descripcion != null && Adiccioness_Descripcion.Resource != null)
                ViewBag.Adiccioness_Descripcion = Adiccioness_Descripcion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Adicciones", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddAdicciones_de_Solicitante_MASC", varAdicciones_de_Solicitante_MASC);
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
        public ActionResult GetAdiccionesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAdiccionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAdiccionesApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Adicciones", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Adicciones_de_Solicitante_MASCPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IAdicciones_de_Solicitante_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Adicciones_de_Solicitante_MASCs == null)
                result.Adicciones_de_Solicitante_MASCs = new List<Adicciones_de_Solicitante_MASC>();

            return Json(new
            {
                data = result.Adicciones_de_Solicitante_MASCs.Select(m => new Adicciones_de_Solicitante_MASCGridModel
                    {
                    Clave = m.Clave
                        ,DescripcionDescripcion = CultureHelper.GetTraduction(m.Descripcion_Adicciones.Clave.ToString(), "Descripcion") ?? (string)m.Descripcion_Adicciones.Descripcion

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
                _IAdicciones_de_Solicitante_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                Adicciones_de_Solicitante_MASC varAdicciones_de_Solicitante_MASC = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IAdicciones_de_Solicitante_MASCApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Adicciones_de_Solicitante_MASCModel varAdicciones_de_Solicitante_MASC)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IAdicciones_de_Solicitante_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Adicciones_de_Solicitante_MASCInfo = new Adicciones_de_Solicitante_MASC
                    {
                        Clave = varAdicciones_de_Solicitante_MASC.Clave
                        ,Descripcion = varAdicciones_de_Solicitante_MASC.Descripcion

                    };

                    result = !IsNew ?
                        _IAdicciones_de_Solicitante_MASCApiConsumer.Update(Adicciones_de_Solicitante_MASCInfo, null, null).Resource.ToString() :
                         _IAdicciones_de_Solicitante_MASCApiConsumer.Insert(Adicciones_de_Solicitante_MASCInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Adicciones_de_Solicitante_MASC script
        /// </summary>
        /// <param name="oAdicciones_de_Solicitante_MASCElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Adicciones_de_Solicitante_MASCModuleAttributeList)
        {
            for (int i = 0; i < Adicciones_de_Solicitante_MASCModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Adicciones_de_Solicitante_MASCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Adicciones_de_Solicitante_MASCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Adicciones_de_Solicitante_MASCModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Adicciones_de_Solicitante_MASCModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Adicciones_de_Solicitante_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Adicciones_de_Solicitante_MASCModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Adicciones_de_Solicitante_MASCModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Adicciones_de_Solicitante_MASCModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Adicciones_de_Solicitante_MASCModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Adicciones_de_Solicitante_MASCModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strAdicciones_de_Solicitante_MASCScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Adicciones_de_Solicitante_MASC.js")))
            {
                strAdicciones_de_Solicitante_MASCScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Adicciones_de_Solicitante_MASC element attributes
            string userChangeJson = jsSerialize.Serialize(Adicciones_de_Solicitante_MASCModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strAdicciones_de_Solicitante_MASCScript.IndexOf("inpuElementArray");
            string splittedString = strAdicciones_de_Solicitante_MASCScript.Substring(indexOfArray, strAdicciones_de_Solicitante_MASCScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Adicciones_de_Solicitante_MASCModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Adicciones_de_Solicitante_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strAdicciones_de_Solicitante_MASCScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strAdicciones_de_Solicitante_MASCScript.Substring(indexOfArrayHistory, strAdicciones_de_Solicitante_MASCScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strAdicciones_de_Solicitante_MASCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strAdicciones_de_Solicitante_MASCScript.Substring(endIndexOfMainElement + indexOfArray, strAdicciones_de_Solicitante_MASCScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Adicciones_de_Solicitante_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strAdicciones_de_Solicitante_MASCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strAdicciones_de_Solicitante_MASCScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strAdicciones_de_Solicitante_MASCScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strAdicciones_de_Solicitante_MASCScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Adicciones_de_Solicitante_MASC.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Adicciones_de_Solicitante_MASC.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Adicciones_de_Solicitante_MASC.js")))
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
        public ActionResult Adicciones_de_Solicitante_MASCPropertyBag()
        {
            return PartialView("Adicciones_de_Solicitante_MASCPropertyBag", "Adicciones_de_Solicitante_MASC");
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

            _IAdicciones_de_Solicitante_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Adicciones_de_Solicitante_MASCPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IAdicciones_de_Solicitante_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Adicciones_de_Solicitante_MASCs == null)
                result.Adicciones_de_Solicitante_MASCs = new List<Adicciones_de_Solicitante_MASC>();

            var data = result.Adicciones_de_Solicitante_MASCs.Select(m => new Adicciones_de_Solicitante_MASCGridModel
            {
                Clave = m.Clave
                ,DescripcionDescripcion = (string)m.Descripcion_Adicciones.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Adicciones_de_Solicitante_MASCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Adicciones_de_Solicitante_MASCList_" + DateTime.Now.ToString());
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

            _IAdicciones_de_Solicitante_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Adicciones_de_Solicitante_MASCPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IAdicciones_de_Solicitante_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Adicciones_de_Solicitante_MASCs == null)
                result.Adicciones_de_Solicitante_MASCs = new List<Adicciones_de_Solicitante_MASC>();

            var data = result.Adicciones_de_Solicitante_MASCs.Select(m => new Adicciones_de_Solicitante_MASCGridModel
            {
                Clave = m.Clave
                ,DescripcionDescripcion = (string)m.Descripcion_Adicciones.Descripcion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
