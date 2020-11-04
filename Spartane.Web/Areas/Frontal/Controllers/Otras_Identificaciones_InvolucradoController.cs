using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Otras_Identificaciones_Involucrado;
using Spartane.Core.Domain.Tipo_de_Identificacion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Otras_Identificaciones_Involucrado;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Otras_Identificaciones_Involucrado;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Identificacion;

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
    public class Otras_Identificaciones_InvolucradoController : Controller
    {
        #region "variable declaration"

        private IOtras_Identificaciones_InvolucradoService service = null;
        private IOtras_Identificaciones_InvolucradoApiConsumer _IOtras_Identificaciones_InvolucradoApiConsumer;
        private ITipo_de_IdentificacionApiConsumer _ITipo_de_IdentificacionApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Otras_Identificaciones_InvolucradoController(IOtras_Identificaciones_InvolucradoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IOtras_Identificaciones_InvolucradoApiConsumer Otras_Identificaciones_InvolucradoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ITipo_de_IdentificacionApiConsumer Tipo_de_IdentificacionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IOtras_Identificaciones_InvolucradoApiConsumer = Otras_Identificaciones_InvolucradoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ITipo_de_IdentificacionApiConsumer = Tipo_de_IdentificacionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Otras_Identificaciones_Involucrado
        [ObjectAuth(ObjectId = (ModuleObjectId)45309, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45309);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Otras_Identificaciones_Involucrado/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45309, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45309);
            ViewBag.Permission = permission;
            var varOtras_Identificaciones_Involucrado = new Otras_Identificaciones_InvolucradoModel();
			
            ViewBag.ObjectId = "45309";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOtras_Identificaciones_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Otras_Identificaciones_InvolucradoData = _IOtras_Identificaciones_InvolucradoApiConsumer.GetByKeyComplete(Id).Resource.Otras_Identificaciones_Involucrados[0];
                if (Otras_Identificaciones_InvolucradoData == null)
                    return HttpNotFound();

                varOtras_Identificaciones_Involucrado = new Otras_Identificaciones_InvolucradoModel
                {
                    Clave = (int)Otras_Identificaciones_InvolucradoData.Clave
                    ,Tipo_de_identificacion = Otras_Identificaciones_InvolucradoData.Tipo_de_identificacion
                    ,Tipo_de_identificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Otras_Identificaciones_InvolucradoData.Tipo_de_identificacion), "Tipo_de_Identificacion") ??  (string)Otras_Identificaciones_InvolucradoData.Tipo_de_identificacion_Tipo_de_Identificacion.Nombre
                    ,Descripcion = Otras_Identificaciones_InvolucradoData.Descripcion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_identificacion != null && Tipo_de_Identificacions_Tipo_de_identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_identificacion = Tipo_de_Identificacions_Tipo_de_identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varOtras_Identificaciones_Involucrado);
        }
		
	[HttpGet]
        public ActionResult AddOtras_Identificaciones_Involucrado(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45309);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IOtras_Identificaciones_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Otras_Identificaciones_InvolucradoModel varOtras_Identificaciones_Involucrado= new Otras_Identificaciones_InvolucradoModel();


            if (id.ToString() != "0")
            {
                var Otras_Identificaciones_InvolucradosData = _IOtras_Identificaciones_InvolucradoApiConsumer.ListaSelAll(0, 1000, "Otras_Identificaciones_Involucrado.Clave=" + id, "").Resource.Otras_Identificaciones_Involucrados;
				
				if (Otras_Identificaciones_InvolucradosData != null && Otras_Identificaciones_InvolucradosData.Count > 0)
                {
					var Otras_Identificaciones_InvolucradoData = Otras_Identificaciones_InvolucradosData.First();
					varOtras_Identificaciones_Involucrado= new Otras_Identificaciones_InvolucradoModel
					{
						Clave  = Otras_Identificaciones_InvolucradoData.Clave 
	                    ,Tipo_de_identificacion = Otras_Identificaciones_InvolucradoData.Tipo_de_identificacion
                    ,Tipo_de_identificacionNombre = CultureHelper.GetTraduction(Convert.ToString(Otras_Identificaciones_InvolucradoData.Tipo_de_identificacion), "Tipo_de_Identificacion") ??  (string)Otras_Identificaciones_InvolucradoData.Tipo_de_identificacion_Tipo_de_Identificacion.Nombre
                    ,Descripcion = Otras_Identificaciones_InvolucradoData.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Identificacions_Tipo_de_identificacion = _ITipo_de_IdentificacionApiConsumer.SelAll(true);
            if (Tipo_de_Identificacions_Tipo_de_identificacion != null && Tipo_de_Identificacions_Tipo_de_identificacion.Resource != null)
                ViewBag.Tipo_de_Identificacions_Tipo_de_identificacion = Tipo_de_Identificacions_Tipo_de_identificacion.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddOtras_Identificaciones_Involucrado", varOtras_Identificaciones_Involucrado);
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
        public ActionResult GetTipo_de_IdentificacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_IdentificacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_IdentificacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Identificacion", "Nombre")?? m.Nombre,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Otras_Identificaciones_InvolucradoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IOtras_Identificaciones_InvolucradoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Otras_Identificaciones_Involucrados == null)
                result.Otras_Identificaciones_Involucrados = new List<Otras_Identificaciones_Involucrado>();

            return Json(new
            {
                data = result.Otras_Identificaciones_Involucrados.Select(m => new Otras_Identificaciones_InvolucradoGridModel
                    {
                    Clave = m.Clave
                        ,Tipo_de_identificacionNombre = CultureHelper.GetTraduction(m.Tipo_de_identificacion_Tipo_de_Identificacion.Clave.ToString(), "Nombre") ?? (string)m.Tipo_de_identificacion_Tipo_de_Identificacion.Nombre
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
                _IOtras_Identificaciones_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Otras_Identificaciones_Involucrado varOtras_Identificaciones_Involucrado = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IOtras_Identificaciones_InvolucradoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Otras_Identificaciones_InvolucradoModel varOtras_Identificaciones_Involucrado)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IOtras_Identificaciones_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Otras_Identificaciones_InvolucradoInfo = new Otras_Identificaciones_Involucrado
                    {
                        Clave = varOtras_Identificaciones_Involucrado.Clave
                        ,Tipo_de_identificacion = varOtras_Identificaciones_Involucrado.Tipo_de_identificacion
                        ,Descripcion = varOtras_Identificaciones_Involucrado.Descripcion

                    };

                    result = !IsNew ?
                        _IOtras_Identificaciones_InvolucradoApiConsumer.Update(Otras_Identificaciones_InvolucradoInfo, null, null).Resource.ToString() :
                         _IOtras_Identificaciones_InvolucradoApiConsumer.Insert(Otras_Identificaciones_InvolucradoInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Otras_Identificaciones_Involucrado script
        /// </summary>
        /// <param name="oOtras_Identificaciones_InvolucradoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Otras_Identificaciones_InvolucradoModuleAttributeList)
        {
            for (int i = 0; i < Otras_Identificaciones_InvolucradoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Otras_Identificaciones_InvolucradoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Otras_Identificaciones_InvolucradoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Otras_Identificaciones_InvolucradoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Otras_Identificaciones_InvolucradoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Otras_Identificaciones_InvolucradoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Otras_Identificaciones_InvolucradoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Otras_Identificaciones_InvolucradoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Otras_Identificaciones_InvolucradoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Otras_Identificaciones_InvolucradoModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Otras_Identificaciones_InvolucradoModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strOtras_Identificaciones_InvolucradoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Otras_Identificaciones_Involucrado.js")))
            {
                strOtras_Identificaciones_InvolucradoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Otras_Identificaciones_Involucrado element attributes
            string userChangeJson = jsSerialize.Serialize(Otras_Identificaciones_InvolucradoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strOtras_Identificaciones_InvolucradoScript.IndexOf("inpuElementArray");
            string splittedString = strOtras_Identificaciones_InvolucradoScript.Substring(indexOfArray, strOtras_Identificaciones_InvolucradoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Otras_Identificaciones_InvolucradoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Otras_Identificaciones_InvolucradoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strOtras_Identificaciones_InvolucradoScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strOtras_Identificaciones_InvolucradoScript.Substring(indexOfArrayHistory, strOtras_Identificaciones_InvolucradoScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strOtras_Identificaciones_InvolucradoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strOtras_Identificaciones_InvolucradoScript.Substring(endIndexOfMainElement + indexOfArray, strOtras_Identificaciones_InvolucradoScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Otras_Identificaciones_InvolucradoModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strOtras_Identificaciones_InvolucradoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strOtras_Identificaciones_InvolucradoScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strOtras_Identificaciones_InvolucradoScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strOtras_Identificaciones_InvolucradoScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Otras_Identificaciones_Involucrado.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Otras_Identificaciones_Involucrado.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Otras_Identificaciones_Involucrado.js")))
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
        public ActionResult Otras_Identificaciones_InvolucradoPropertyBag()
        {
            return PartialView("Otras_Identificaciones_InvolucradoPropertyBag", "Otras_Identificaciones_Involucrado");
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

            _IOtras_Identificaciones_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Otras_Identificaciones_InvolucradoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IOtras_Identificaciones_InvolucradoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Otras_Identificaciones_Involucrados == null)
                result.Otras_Identificaciones_Involucrados = new List<Otras_Identificaciones_Involucrado>();

            var data = result.Otras_Identificaciones_Involucrados.Select(m => new Otras_Identificaciones_InvolucradoGridModel
            {
                Clave = m.Clave
                ,Tipo_de_identificacionNombre = (string)m.Tipo_de_identificacion_Tipo_de_Identificacion.Nombre
                ,Descripcion = m.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Otras_Identificaciones_InvolucradoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Otras_Identificaciones_InvolucradoList_" + DateTime.Now.ToString());
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

            _IOtras_Identificaciones_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Otras_Identificaciones_InvolucradoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IOtras_Identificaciones_InvolucradoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Otras_Identificaciones_Involucrados == null)
                result.Otras_Identificaciones_Involucrados = new List<Otras_Identificaciones_Involucrado>();

            var data = result.Otras_Identificaciones_Involucrados.Select(m => new Otras_Identificaciones_InvolucradoGridModel
            {
                Clave = m.Clave
                ,Tipo_de_identificacionNombre = (string)m.Tipo_de_identificacion_Tipo_de_Identificacion.Nombre
                ,Descripcion = m.Descripcion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
