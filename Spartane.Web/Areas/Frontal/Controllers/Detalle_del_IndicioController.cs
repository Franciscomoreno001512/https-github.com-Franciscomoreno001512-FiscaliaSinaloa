using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_del_Indicio;
using Spartane.Core.Domain.Estatus_de_Indicio;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_del_Indicio;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_del_Indicio;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Indicio;

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
    public class Detalle_del_IndicioController : Controller
    {
        #region "variable declaration"

        private IDetalle_del_IndicioService service = null;
        private IDetalle_del_IndicioApiConsumer _IDetalle_del_IndicioApiConsumer;
        private IEstatus_de_IndicioApiConsumer _IEstatus_de_IndicioApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_del_IndicioController(IDetalle_del_IndicioService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_del_IndicioApiConsumer Detalle_del_IndicioApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IEstatus_de_IndicioApiConsumer Estatus_de_IndicioApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_del_IndicioApiConsumer = Detalle_del_IndicioApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IEstatus_de_IndicioApiConsumer = Estatus_de_IndicioApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_del_Indicio
        [ObjectAuth(ObjectId = (ModuleObjectId)45185, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45185);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_del_Indicio/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45185, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45185);
            ViewBag.Permission = permission;
            var varDetalle_del_Indicio = new Detalle_del_IndicioModel();
			
            ViewBag.ObjectId = "45185";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_del_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_del_IndicioData = _IDetalle_del_IndicioApiConsumer.GetByKeyComplete(Id).Resource.Detalle_del_Indicios[0];
                if (Detalle_del_IndicioData == null)
                    return HttpNotFound();

                varDetalle_del_Indicio = new Detalle_del_IndicioModel
                {
                    Clave = (int)Detalle_del_IndicioData.Clave
                    ,Numero_de_Indicio = Detalle_del_IndicioData.Numero_de_Indicio
                    ,Nombre_del_Indicio = Detalle_del_IndicioData.Nombre_del_Indicio
                    ,Descripcion_del_Indicio = Detalle_del_IndicioData.Descripcion_del_Indicio
                    ,Motivo = Detalle_del_IndicioData.Motivo
                    ,Estatus = Detalle_del_IndicioData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_IndicioData.Estatus), "Estatus_de_Indicio") ??  (string)Detalle_del_IndicioData.Estatus_Estatus_de_Indicio.Descripcion
                    ,Ubicacion_de_Indicio = Detalle_del_IndicioData.Ubicacion_de_Indicio

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_de_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Indicios_Estatus = _IEstatus_de_IndicioApiConsumer.SelAll(true);
            if (Estatus_de_Indicios_Estatus != null && Estatus_de_Indicios_Estatus.Resource != null)
                ViewBag.Estatus_de_Indicios_Estatus = Estatus_de_Indicios_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Indicio", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_del_Indicio);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_del_Indicio(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45185);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_del_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_del_IndicioModel varDetalle_del_Indicio= new Detalle_del_IndicioModel();


            if (id.ToString() != "0")
            {
                var Detalle_del_IndiciosData = _IDetalle_del_IndicioApiConsumer.ListaSelAll(0, 1000, "Detalle_del_Indicio.Clave=" + id, "").Resource.Detalle_del_Indicios;
				
				if (Detalle_del_IndiciosData != null && Detalle_del_IndiciosData.Count > 0)
                {
					var Detalle_del_IndicioData = Detalle_del_IndiciosData.First();
					varDetalle_del_Indicio= new Detalle_del_IndicioModel
					{
						Clave  = Detalle_del_IndicioData.Clave 
	                    ,Numero_de_Indicio = Detalle_del_IndicioData.Numero_de_Indicio
                    ,Nombre_del_Indicio = Detalle_del_IndicioData.Nombre_del_Indicio
                    ,Descripcion_del_Indicio = Detalle_del_IndicioData.Descripcion_del_Indicio
                    ,Motivo = Detalle_del_IndicioData.Motivo
                    ,Estatus = Detalle_del_IndicioData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_del_IndicioData.Estatus), "Estatus_de_Indicio") ??  (string)Detalle_del_IndicioData.Estatus_Estatus_de_Indicio.Descripcion
                    ,Ubicacion_de_Indicio = Detalle_del_IndicioData.Ubicacion_de_Indicio

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_de_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Indicios_Estatus = _IEstatus_de_IndicioApiConsumer.SelAll(true);
            if (Estatus_de_Indicios_Estatus != null && Estatus_de_Indicios_Estatus.Resource != null)
                ViewBag.Estatus_de_Indicios_Estatus = Estatus_de_Indicios_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Indicio", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_del_Indicio", varDetalle_del_Indicio);
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
        public ActionResult GetEstatus_de_IndicioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_IndicioApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Indicio", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_del_IndicioPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_del_IndicioApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_del_Indicios == null)
                result.Detalle_del_Indicios = new List<Detalle_del_Indicio>();

            return Json(new
            {
                data = result.Detalle_del_Indicios.Select(m => new Detalle_del_IndicioGridModel
                    {
                    Clave = m.Clave
			,Numero_de_Indicio = m.Numero_de_Indicio
			,Nombre_del_Indicio = m.Nombre_del_Indicio
			,Descripcion_del_Indicio = m.Descripcion_del_Indicio
			,Motivo = m.Motivo
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Indicio.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Indicio.Descripcion
			,Ubicacion_de_Indicio = m.Ubicacion_de_Indicio

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
                _IDetalle_del_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_del_Indicio varDetalle_del_Indicio = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_del_IndicioApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_del_IndicioModel varDetalle_del_Indicio)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_del_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_del_IndicioInfo = new Detalle_del_Indicio
                    {
                        Clave = varDetalle_del_Indicio.Clave
                        ,Numero_de_Indicio = varDetalle_del_Indicio.Numero_de_Indicio
                        ,Nombre_del_Indicio = varDetalle_del_Indicio.Nombre_del_Indicio
                        ,Descripcion_del_Indicio = varDetalle_del_Indicio.Descripcion_del_Indicio
                        ,Motivo = varDetalle_del_Indicio.Motivo
                        ,Estatus = varDetalle_del_Indicio.Estatus
                        ,Ubicacion_de_Indicio = varDetalle_del_Indicio.Ubicacion_de_Indicio

                    };

                    result = !IsNew ?
                        _IDetalle_del_IndicioApiConsumer.Update(Detalle_del_IndicioInfo, null, null).Resource.ToString() :
                         _IDetalle_del_IndicioApiConsumer.Insert(Detalle_del_IndicioInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_del_Indicio script
        /// </summary>
        /// <param name="oDetalle_del_IndicioElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_del_IndicioModuleAttributeList)
        {
            for (int i = 0; i < Detalle_del_IndicioModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_del_IndicioModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_del_IndicioModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_del_IndicioModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_del_IndicioModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_del_IndicioModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_del_IndicioModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_del_IndicioModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_del_IndicioModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_del_IndicioModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_del_IndicioModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_del_IndicioScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_del_Indicio.js")))
            {
                strDetalle_del_IndicioScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_del_Indicio element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_del_IndicioModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_del_IndicioScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_del_IndicioScript.Substring(indexOfArray, strDetalle_del_IndicioScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_del_IndicioModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_del_IndicioModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_del_IndicioScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_del_IndicioScript.Substring(indexOfArrayHistory, strDetalle_del_IndicioScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_del_IndicioScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_del_IndicioScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_del_IndicioScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_del_IndicioModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_del_IndicioScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_del_IndicioScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_del_IndicioScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_del_IndicioScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_del_Indicio.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_del_Indicio.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_del_Indicio.js")))
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
        public ActionResult Detalle_del_IndicioPropertyBag()
        {
            return PartialView("Detalle_del_IndicioPropertyBag", "Detalle_del_Indicio");
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

            _IDetalle_del_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_del_IndicioPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_del_IndicioApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_del_Indicios == null)
                result.Detalle_del_Indicios = new List<Detalle_del_Indicio>();

            var data = result.Detalle_del_Indicios.Select(m => new Detalle_del_IndicioGridModel
            {
                Clave = m.Clave
                ,Numero_de_Indicio = m.Numero_de_Indicio
                ,Nombre_del_Indicio = m.Nombre_del_Indicio
                ,Descripcion_del_Indicio = m.Descripcion_del_Indicio
                ,Motivo = m.Motivo
                ,EstatusDescripcion = (string)m.Estatus_Estatus_de_Indicio.Descripcion
                ,Ubicacion_de_Indicio = m.Ubicacion_de_Indicio

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_del_IndicioList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_del_IndicioList_" + DateTime.Now.ToString());
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

            _IDetalle_del_IndicioApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_del_IndicioPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_del_IndicioApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_del_Indicios == null)
                result.Detalle_del_Indicios = new List<Detalle_del_Indicio>();

            var data = result.Detalle_del_Indicios.Select(m => new Detalle_del_IndicioGridModel
            {
                Clave = m.Clave
                ,Numero_de_Indicio = m.Numero_de_Indicio
                ,Nombre_del_Indicio = m.Nombre_del_Indicio
                ,Descripcion_del_Indicio = m.Descripcion_del_Indicio
                ,Motivo = m.Motivo
                ,EstatusDescripcion = (string)m.Estatus_Estatus_de_Indicio.Descripcion
                ,Ubicacion_de_Indicio = m.Ubicacion_de_Indicio

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
