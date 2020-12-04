using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Medios_Prueba_Victima;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Medios_Prueba_Victima;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Medios_Prueba_Victima;

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
    public class Detalle_Medios_Prueba_VictimaController : Controller
    {
        #region "variable declaration"

        private IDetalle_Medios_Prueba_VictimaService service = null;
        private IDetalle_Medios_Prueba_VictimaApiConsumer _IDetalle_Medios_Prueba_VictimaApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Medios_Prueba_VictimaController(IDetalle_Medios_Prueba_VictimaService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Medios_Prueba_VictimaApiConsumer Detalle_Medios_Prueba_VictimaApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Medios_Prueba_VictimaApiConsumer = Detalle_Medios_Prueba_VictimaApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Medios_Prueba_Victima
        [ObjectAuth(ObjectId = (ModuleObjectId)45557, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45557);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Medios_Prueba_Victima/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45557, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45557);
            ViewBag.Permission = permission;
            var varDetalle_Medios_Prueba_Victima = new Detalle_Medios_Prueba_VictimaModel();
			
            ViewBag.ObjectId = "45557";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Medios_Prueba_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Medios_Prueba_VictimaData = _IDetalle_Medios_Prueba_VictimaApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Medios_Prueba_Victimas[0];
                if (Detalle_Medios_Prueba_VictimaData == null)
                    return HttpNotFound();

                varDetalle_Medios_Prueba_Victima = new Detalle_Medios_Prueba_VictimaModel
                {
                    Clave = (int)Detalle_Medios_Prueba_VictimaData.Clave
                    ,Medio_de_Prueba_Presentado = Detalle_Medios_Prueba_VictimaData.Medio_de_Prueba_Presentado
                    ,Fecha_de_Presentacion = (Detalle_Medios_Prueba_VictimaData.Fecha_de_Presentacion == null ? string.Empty : Convert.ToDateTime(Detalle_Medios_Prueba_VictimaData.Fecha_de_Presentacion).ToString(ConfigurationProperty.DateFormat))
                    ,Archivo_Adjunto = Detalle_Medios_Prueba_VictimaData.Archivo_Adjunto

                };
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_AdjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_Medios_Prueba_Victima.Archivo_Adjunto).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Medios_Prueba_Victima);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Medios_Prueba_Victima(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45557);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Medios_Prueba_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Medios_Prueba_VictimaModel varDetalle_Medios_Prueba_Victima= new Detalle_Medios_Prueba_VictimaModel();


            if (id.ToString() != "0")
            {
                var Detalle_Medios_Prueba_VictimasData = _IDetalle_Medios_Prueba_VictimaApiConsumer.ListaSelAll(0, 1000, "Detalle_Medios_Prueba_Victima.Clave=" + id, "").Resource.Detalle_Medios_Prueba_Victimas;
				
				if (Detalle_Medios_Prueba_VictimasData != null && Detalle_Medios_Prueba_VictimasData.Count > 0)
                {
					var Detalle_Medios_Prueba_VictimaData = Detalle_Medios_Prueba_VictimasData.First();
					varDetalle_Medios_Prueba_Victima= new Detalle_Medios_Prueba_VictimaModel
					{
						Clave  = Detalle_Medios_Prueba_VictimaData.Clave 
	                    ,Medio_de_Prueba_Presentado = Detalle_Medios_Prueba_VictimaData.Medio_de_Prueba_Presentado
                    ,Fecha_de_Presentacion = (Detalle_Medios_Prueba_VictimaData.Fecha_de_Presentacion == null ? string.Empty : Convert.ToDateTime(Detalle_Medios_Prueba_VictimaData.Fecha_de_Presentacion).ToString(ConfigurationProperty.DateFormat))
                    ,Archivo_Adjunto = Detalle_Medios_Prueba_VictimaData.Archivo_Adjunto

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Archivo_AdjuntoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_Medios_Prueba_Victima.Archivo_Adjunto).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDetalle_Medios_Prueba_Victima", varDetalle_Medios_Prueba_Victima);
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Medios_Prueba_VictimaPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Medios_Prueba_VictimaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Medios_Prueba_Victimas == null)
                result.Detalle_Medios_Prueba_Victimas = new List<Detalle_Medios_Prueba_Victima>();

            return Json(new
            {
                data = result.Detalle_Medios_Prueba_Victimas.Select(m => new Detalle_Medios_Prueba_VictimaGridModel
                    {
                    Clave = m.Clave
			,Medio_de_Prueba_Presentado = m.Medio_de_Prueba_Presentado
                        ,Fecha_de_Presentacion = (m.Fecha_de_Presentacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Presentacion).ToString(ConfigurationProperty.DateFormat))
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
                _IDetalle_Medios_Prueba_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Medios_Prueba_Victima varDetalle_Medios_Prueba_Victima = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Medios_Prueba_VictimaApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Medios_Prueba_VictimaModel varDetalle_Medios_Prueba_Victima)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Medios_Prueba_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varDetalle_Medios_Prueba_Victima.Archivo_AdjuntoRemoveAttachment != 0 && varDetalle_Medios_Prueba_Victima.Archivo_AdjuntoFile == null)
                    {
                        varDetalle_Medios_Prueba_Victima.Archivo_Adjunto = 0;
                    }

                    if (varDetalle_Medios_Prueba_Victima.Archivo_AdjuntoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_Medios_Prueba_Victima.Archivo_AdjuntoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_Medios_Prueba_Victima.Archivo_Adjunto = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_Medios_Prueba_Victima.Archivo_AdjuntoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Detalle_Medios_Prueba_VictimaInfo = new Detalle_Medios_Prueba_Victima
                    {
                        Clave = varDetalle_Medios_Prueba_Victima.Clave
                        ,Medio_de_Prueba_Presentado = varDetalle_Medios_Prueba_Victima.Medio_de_Prueba_Presentado
                        ,Fecha_de_Presentacion = (!String.IsNullOrEmpty(varDetalle_Medios_Prueba_Victima.Fecha_de_Presentacion)) ? DateTime.ParseExact(varDetalle_Medios_Prueba_Victima.Fecha_de_Presentacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Archivo_Adjunto = (varDetalle_Medios_Prueba_Victima.Archivo_Adjunto.HasValue && varDetalle_Medios_Prueba_Victima.Archivo_Adjunto != 0) ? ((int?)Convert.ToInt32(varDetalle_Medios_Prueba_Victima.Archivo_Adjunto.Value)) : null


                    };

                    result = !IsNew ?
                        _IDetalle_Medios_Prueba_VictimaApiConsumer.Update(Detalle_Medios_Prueba_VictimaInfo, null, null).Resource.ToString() :
                         _IDetalle_Medios_Prueba_VictimaApiConsumer.Insert(Detalle_Medios_Prueba_VictimaInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Medios_Prueba_Victima script
        /// </summary>
        /// <param name="oDetalle_Medios_Prueba_VictimaElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Medios_Prueba_VictimaModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Medios_Prueba_VictimaModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Medios_Prueba_VictimaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Medios_Prueba_VictimaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Medios_Prueba_VictimaModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Medios_Prueba_VictimaModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Medios_Prueba_VictimaModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Medios_Prueba_VictimaModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Medios_Prueba_VictimaModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Medios_Prueba_VictimaModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Medios_Prueba_VictimaModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Medios_Prueba_VictimaModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Medios_Prueba_VictimaScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Medios_Prueba_Victima.js")))
            {
                strDetalle_Medios_Prueba_VictimaScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Medios_Prueba_Victima element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Medios_Prueba_VictimaModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Medios_Prueba_VictimaScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Medios_Prueba_VictimaScript.Substring(indexOfArray, strDetalle_Medios_Prueba_VictimaScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Medios_Prueba_VictimaModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Medios_Prueba_VictimaModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Medios_Prueba_VictimaScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Medios_Prueba_VictimaScript.Substring(indexOfArrayHistory, strDetalle_Medios_Prueba_VictimaScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Medios_Prueba_VictimaScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Medios_Prueba_VictimaScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Medios_Prueba_VictimaScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Medios_Prueba_VictimaModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Medios_Prueba_VictimaScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Medios_Prueba_VictimaScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Medios_Prueba_VictimaScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Medios_Prueba_VictimaScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Medios_Prueba_Victima.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Medios_Prueba_Victima.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Medios_Prueba_Victima.js")))
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
        public ActionResult Detalle_Medios_Prueba_VictimaPropertyBag()
        {
            return PartialView("Detalle_Medios_Prueba_VictimaPropertyBag", "Detalle_Medios_Prueba_Victima");
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

            _IDetalle_Medios_Prueba_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Medios_Prueba_VictimaPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Medios_Prueba_VictimaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Medios_Prueba_Victimas == null)
                result.Detalle_Medios_Prueba_Victimas = new List<Detalle_Medios_Prueba_Victima>();

            var data = result.Detalle_Medios_Prueba_Victimas.Select(m => new Detalle_Medios_Prueba_VictimaGridModel
            {
                Clave = m.Clave
                ,Medio_de_Prueba_Presentado = m.Medio_de_Prueba_Presentado
                ,Fecha_de_Presentacion = (m.Fecha_de_Presentacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Presentacion).ToString(ConfigurationProperty.DateFormat))

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Medios_Prueba_VictimaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Medios_Prueba_VictimaList_" + DateTime.Now.ToString());
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

            _IDetalle_Medios_Prueba_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Medios_Prueba_VictimaPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Medios_Prueba_VictimaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Medios_Prueba_Victimas == null)
                result.Detalle_Medios_Prueba_Victimas = new List<Detalle_Medios_Prueba_Victima>();

            var data = result.Detalle_Medios_Prueba_Victimas.Select(m => new Detalle_Medios_Prueba_VictimaGridModel
            {
                Clave = m.Clave
                ,Medio_de_Prueba_Presentado = m.Medio_de_Prueba_Presentado
                ,Fecha_de_Presentacion = (m.Fecha_de_Presentacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Presentacion).ToString(ConfigurationProperty.DateFormat))

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
