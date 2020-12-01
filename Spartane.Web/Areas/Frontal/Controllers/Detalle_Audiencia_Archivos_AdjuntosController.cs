using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Audiencia_Archivos_Adjuntos;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Audiencia_Archivos_Adjuntos;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Audiencia_Archivos_Adjuntos;

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
    public class Detalle_Audiencia_Archivos_AdjuntosController : Controller
    {
        #region "variable declaration"

        private IDetalle_Audiencia_Archivos_AdjuntosService service = null;
        private IDetalle_Audiencia_Archivos_AdjuntosApiConsumer _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Audiencia_Archivos_AdjuntosController(IDetalle_Audiencia_Archivos_AdjuntosService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Audiencia_Archivos_AdjuntosApiConsumer Detalle_Audiencia_Archivos_AdjuntosApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Audiencia_Archivos_AdjuntosApiConsumer = Detalle_Audiencia_Archivos_AdjuntosApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Audiencia_Archivos_Adjuntos
        [ObjectAuth(ObjectId = (ModuleObjectId)45486, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45486);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Audiencia_Archivos_Adjuntos/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45486, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45486);
            ViewBag.Permission = permission;
            var varDetalle_Audiencia_Archivos_Adjuntos = new Detalle_Audiencia_Archivos_AdjuntosModel();
			
            ViewBag.ObjectId = "45486";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Audiencia_Archivos_AdjuntosData = _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Audiencia_Archivos_Adjuntoss[0];
                if (Detalle_Audiencia_Archivos_AdjuntosData == null)
                    return HttpNotFound();

                varDetalle_Audiencia_Archivos_Adjuntos = new Detalle_Audiencia_Archivos_AdjuntosModel
                {
                    Clave = (int)Detalle_Audiencia_Archivos_AdjuntosData.Clave
                    ,Nombre_Archivo = Detalle_Audiencia_Archivos_AdjuntosData.Nombre_Archivo
                    ,Archivo_Adjunto = Detalle_Audiencia_Archivos_AdjuntosData.Archivo_Adjunto

                };
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_AdjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_Audiencia_Archivos_Adjuntos.Archivo_Adjunto).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Audiencia_Archivos_Adjuntos);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Audiencia_Archivos_Adjuntos(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45486);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Audiencia_Archivos_AdjuntosModel varDetalle_Audiencia_Archivos_Adjuntos= new Detalle_Audiencia_Archivos_AdjuntosModel();


            if (id.ToString() != "0")
            {
                var Detalle_Audiencia_Archivos_AdjuntossData = _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.ListaSelAll(0, 1000, "Detalle_Audiencia_Archivos_Adjuntos.Clave=" + id, "").Resource.Detalle_Audiencia_Archivos_Adjuntoss;
				
				if (Detalle_Audiencia_Archivos_AdjuntossData != null && Detalle_Audiencia_Archivos_AdjuntossData.Count > 0)
                {
					var Detalle_Audiencia_Archivos_AdjuntosData = Detalle_Audiencia_Archivos_AdjuntossData.First();
					varDetalle_Audiencia_Archivos_Adjuntos= new Detalle_Audiencia_Archivos_AdjuntosModel
					{
						Clave  = Detalle_Audiencia_Archivos_AdjuntosData.Clave 
	                    ,Nombre_Archivo = Detalle_Audiencia_Archivos_AdjuntosData.Nombre_Archivo
                    ,Archivo_Adjunto = Detalle_Audiencia_Archivos_AdjuntosData.Archivo_Adjunto

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_AdjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_Audiencia_Archivos_Adjuntos.Archivo_Adjunto).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDetalle_Audiencia_Archivos_Adjuntos", varDetalle_Audiencia_Archivos_Adjuntos);
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Audiencia_Archivos_AdjuntosPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Audiencia_Archivos_Adjuntoss == null)
                result.Detalle_Audiencia_Archivos_Adjuntoss = new List<Detalle_Audiencia_Archivos_Adjuntos>();

            return Json(new
            {
                data = result.Detalle_Audiencia_Archivos_Adjuntoss.Select(m => new Detalle_Audiencia_Archivos_AdjuntosGridModel
                    {
                    Clave = m.Clave
			,Nombre_Archivo = m.Nombre_Archivo
			,Archivo_Adjunto = m.Archivo_Adjunto

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
                _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Audiencia_Archivos_Adjuntos varDetalle_Audiencia_Archivos_Adjuntos = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Audiencia_Archivos_AdjuntosModel varDetalle_Audiencia_Archivos_Adjuntos)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varDetalle_Audiencia_Archivos_Adjuntos.Archivo_AdjuntoRemoveAttachment != 0 && varDetalle_Audiencia_Archivos_Adjuntos.Archivo_AdjuntoFile == null)
                    {
                        varDetalle_Audiencia_Archivos_Adjuntos.Archivo_Adjunto = 0;
                    }

                    if (varDetalle_Audiencia_Archivos_Adjuntos.Archivo_AdjuntoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_Audiencia_Archivos_Adjuntos.Archivo_AdjuntoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_Audiencia_Archivos_Adjuntos.Archivo_Adjunto = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_Audiencia_Archivos_Adjuntos.Archivo_AdjuntoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Detalle_Audiencia_Archivos_AdjuntosInfo = new Detalle_Audiencia_Archivos_Adjuntos
                    {
                        Clave = varDetalle_Audiencia_Archivos_Adjuntos.Clave
                        ,Nombre_Archivo = varDetalle_Audiencia_Archivos_Adjuntos.Nombre_Archivo
                        ,Archivo_Adjunto = (varDetalle_Audiencia_Archivos_Adjuntos.Archivo_Adjunto.HasValue && varDetalle_Audiencia_Archivos_Adjuntos.Archivo_Adjunto != 0) ? ((int?)Convert.ToInt32(varDetalle_Audiencia_Archivos_Adjuntos.Archivo_Adjunto.Value)) : null


                    };

                    result = !IsNew ?
                        _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.Update(Detalle_Audiencia_Archivos_AdjuntosInfo, null, null).Resource.ToString() :
                         _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.Insert(Detalle_Audiencia_Archivos_AdjuntosInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Audiencia_Archivos_Adjuntos script
        /// </summary>
        /// <param name="oDetalle_Audiencia_Archivos_AdjuntosElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Audiencia_Archivos_AdjuntosScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Audiencia_Archivos_Adjuntos.js")))
            {
                strDetalle_Audiencia_Archivos_AdjuntosScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Audiencia_Archivos_Adjuntos element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Audiencia_Archivos_AdjuntosScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Audiencia_Archivos_AdjuntosScript.Substring(indexOfArray, strDetalle_Audiencia_Archivos_AdjuntosScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Audiencia_Archivos_AdjuntosScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Audiencia_Archivos_AdjuntosScript.Substring(indexOfArrayHistory, strDetalle_Audiencia_Archivos_AdjuntosScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Audiencia_Archivos_AdjuntosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Audiencia_Archivos_AdjuntosScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Audiencia_Archivos_AdjuntosScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Audiencia_Archivos_AdjuntosModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Audiencia_Archivos_AdjuntosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Audiencia_Archivos_AdjuntosScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Audiencia_Archivos_AdjuntosScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Audiencia_Archivos_AdjuntosScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Audiencia_Archivos_Adjuntos.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Audiencia_Archivos_Adjuntos.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Audiencia_Archivos_Adjuntos.js")))
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
        public ActionResult Detalle_Audiencia_Archivos_AdjuntosPropertyBag()
        {
            return PartialView("Detalle_Audiencia_Archivos_AdjuntosPropertyBag", "Detalle_Audiencia_Archivos_Adjuntos");
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

            _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Audiencia_Archivos_AdjuntosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Audiencia_Archivos_Adjuntoss == null)
                result.Detalle_Audiencia_Archivos_Adjuntoss = new List<Detalle_Audiencia_Archivos_Adjuntos>();

            var data = result.Detalle_Audiencia_Archivos_Adjuntoss.Select(m => new Detalle_Audiencia_Archivos_AdjuntosGridModel
            {
                Clave = m.Clave
                ,Nombre_Archivo = m.Nombre_Archivo

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Audiencia_Archivos_AdjuntosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Audiencia_Archivos_AdjuntosList_" + DateTime.Now.ToString());
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

            _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Audiencia_Archivos_AdjuntosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Audiencia_Archivos_AdjuntosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Audiencia_Archivos_Adjuntoss == null)
                result.Detalle_Audiencia_Archivos_Adjuntoss = new List<Detalle_Audiencia_Archivos_Adjuntos>();

            var data = result.Detalle_Audiencia_Archivos_Adjuntoss.Select(m => new Detalle_Audiencia_Archivos_AdjuntosGridModel
            {
                Clave = m.Clave
                ,Nombre_Archivo = m.Nombre_Archivo

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
