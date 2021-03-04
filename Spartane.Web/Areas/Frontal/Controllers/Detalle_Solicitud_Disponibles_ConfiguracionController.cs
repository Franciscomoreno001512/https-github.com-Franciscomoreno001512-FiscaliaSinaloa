using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion;
using Spartane.Core.Domain.Documento;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Solicitud_Disponibles_Configuracion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Solicitud_Disponibles_Configuracion;
using Spartane.Web.Areas.WebApiConsumer.Documento;

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
    public class Detalle_Solicitud_Disponibles_ConfiguracionController : Controller
    {
        #region "variable declaration"

        private IDetalle_Solicitud_Disponibles_ConfiguracionService service = null;
        private IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer;
        private IDocumentoApiConsumer _IDocumentoApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Solicitud_Disponibles_ConfiguracionController(IDetalle_Solicitud_Disponibles_ConfiguracionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer Detalle_Solicitud_Disponibles_ConfiguracionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IDocumentoApiConsumer DocumentoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer = Detalle_Solicitud_Disponibles_ConfiguracionApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IDocumentoApiConsumer = DocumentoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Solicitud_Disponibles_Configuracion
        [ObjectAuth(ObjectId = (ModuleObjectId)46225, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46225);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Solicitud_Disponibles_Configuracion/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)46225, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46225);
            ViewBag.Permission = permission;
            var varDetalle_Solicitud_Disponibles_Configuracion = new Detalle_Solicitud_Disponibles_ConfiguracionModel();
			
            ViewBag.ObjectId = "46225";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Solicitud_Disponibles_ConfiguracionData = _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Solicitud_Disponibles_Configuracions[0];
                if (Detalle_Solicitud_Disponibles_ConfiguracionData == null)
                    return HttpNotFound();

                varDetalle_Solicitud_Disponibles_Configuracion = new Detalle_Solicitud_Disponibles_ConfiguracionModel
                {
                    Clave = (int)Detalle_Solicitud_Disponibles_ConfiguracionData.Clave
                    ,Documento = Detalle_Solicitud_Disponibles_ConfiguracionData.Documento
                    ,DocumentoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Solicitud_Disponibles_ConfiguracionData.Documento), "Documento") ??  (string)Detalle_Solicitud_Disponibles_ConfiguracionData.Documento_Documento.Descripcion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Solicitud_Disponibles_Configuracion);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Solicitud_Disponibles_Configuracion(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46225);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Solicitud_Disponibles_ConfiguracionModel varDetalle_Solicitud_Disponibles_Configuracion= new Detalle_Solicitud_Disponibles_ConfiguracionModel();


            if (id.ToString() != "0")
            {
                var Detalle_Solicitud_Disponibles_ConfiguracionsData = _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.ListaSelAll(0, 1000, "Detalle_Solicitud_Disponibles_Configuracion.Clave=" + id, "").Resource.Detalle_Solicitud_Disponibles_Configuracions;
				
				if (Detalle_Solicitud_Disponibles_ConfiguracionsData != null && Detalle_Solicitud_Disponibles_ConfiguracionsData.Count > 0)
                {
					var Detalle_Solicitud_Disponibles_ConfiguracionData = Detalle_Solicitud_Disponibles_ConfiguracionsData.First();
					varDetalle_Solicitud_Disponibles_Configuracion= new Detalle_Solicitud_Disponibles_ConfiguracionModel
					{
						Clave  = Detalle_Solicitud_Disponibles_ConfiguracionData.Clave 
	                    ,Documento = Detalle_Solicitud_Disponibles_ConfiguracionData.Documento
                    ,DocumentoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Solicitud_Disponibles_ConfiguracionData.Documento), "Documento") ??  (string)Detalle_Solicitud_Disponibles_ConfiguracionData.Documento_Documento.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDetalle_Solicitud_Disponibles_Configuracion", varDetalle_Solicitud_Disponibles_Configuracion);
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
        public ActionResult GetDocumentoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDocumentoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Solicitud_Disponibles_ConfiguracionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Solicitud_Disponibles_Configuracions == null)
                result.Detalle_Solicitud_Disponibles_Configuracions = new List<Detalle_Solicitud_Disponibles_Configuracion>();

            return Json(new
            {
                data = result.Detalle_Solicitud_Disponibles_Configuracions.Select(m => new Detalle_Solicitud_Disponibles_ConfiguracionGridModel
                    {
                    Clave = m.Clave
                        ,DocumentoDescripcion = CultureHelper.GetTraduction(m.Documento_Documento.Clave.ToString(), "Documento") ?? (string)m.Documento_Documento.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_Solicitud_Disponibles_Configuracion_Documento_Documento(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Documento.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Documento.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDocumentoApiConsumer.ListaSelAll(1, 20,elWhere , " Documento.Descripcion ASC ").Resource;
               
                foreach (var item in result.Documentos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Documento", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Documentos.ToArray(), JsonRequestBehavior.AllowGet);
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
                _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Solicitud_Disponibles_Configuracion varDetalle_Solicitud_Disponibles_Configuracion = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Solicitud_Disponibles_ConfiguracionModel varDetalle_Solicitud_Disponibles_Configuracion)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Solicitud_Disponibles_ConfiguracionInfo = new Detalle_Solicitud_Disponibles_Configuracion
                    {
                        Clave = varDetalle_Solicitud_Disponibles_Configuracion.Clave
                        ,Documento = varDetalle_Solicitud_Disponibles_Configuracion.Documento

                    };

                    result = !IsNew ?
                        _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.Update(Detalle_Solicitud_Disponibles_ConfiguracionInfo, null, null).Resource.ToString() :
                         _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.Insert(Detalle_Solicitud_Disponibles_ConfiguracionInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Solicitud_Disponibles_Configuracion script
        /// </summary>
        /// <param name="oDetalle_Solicitud_Disponibles_ConfiguracionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Solicitud_Disponibles_ConfiguracionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Solicitud_Disponibles_Configuracion.js")))
            {
                strDetalle_Solicitud_Disponibles_ConfiguracionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Solicitud_Disponibles_Configuracion element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Solicitud_Disponibles_ConfiguracionScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Solicitud_Disponibles_ConfiguracionScript.Substring(indexOfArray, strDetalle_Solicitud_Disponibles_ConfiguracionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Solicitud_Disponibles_ConfiguracionScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Solicitud_Disponibles_ConfiguracionScript.Substring(indexOfArrayHistory, strDetalle_Solicitud_Disponibles_ConfiguracionScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Solicitud_Disponibles_ConfiguracionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Solicitud_Disponibles_ConfiguracionScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Solicitud_Disponibles_ConfiguracionScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Solicitud_Disponibles_ConfiguracionModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Solicitud_Disponibles_ConfiguracionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Solicitud_Disponibles_ConfiguracionScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Solicitud_Disponibles_ConfiguracionScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Solicitud_Disponibles_ConfiguracionScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Solicitud_Disponibles_Configuracion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Solicitud_Disponibles_Configuracion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Solicitud_Disponibles_Configuracion.js")))
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
        public ActionResult Detalle_Solicitud_Disponibles_ConfiguracionPropertyBag()
        {
            return PartialView("Detalle_Solicitud_Disponibles_ConfiguracionPropertyBag", "Detalle_Solicitud_Disponibles_Configuracion");
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

            _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Solicitud_Disponibles_ConfiguracionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Solicitud_Disponibles_Configuracions == null)
                result.Detalle_Solicitud_Disponibles_Configuracions = new List<Detalle_Solicitud_Disponibles_Configuracion>();

            var data = result.Detalle_Solicitud_Disponibles_Configuracions.Select(m => new Detalle_Solicitud_Disponibles_ConfiguracionGridModel
            {
                Clave = m.Clave
                ,DocumentoDescripcion = (string)m.Documento_Documento.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Solicitud_Disponibles_ConfiguracionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Solicitud_Disponibles_ConfiguracionList_" + DateTime.Now.ToString());
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

            _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Solicitud_Disponibles_ConfiguracionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Solicitud_Disponibles_Configuracions == null)
                result.Detalle_Solicitud_Disponibles_Configuracions = new List<Detalle_Solicitud_Disponibles_Configuracion>();

            var data = result.Detalle_Solicitud_Disponibles_Configuracions.Select(m => new Detalle_Solicitud_Disponibles_ConfiguracionGridModel
            {
                Clave = m.Clave
                ,DocumentoDescripcion = (string)m.Documento_Documento.Descripcion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
