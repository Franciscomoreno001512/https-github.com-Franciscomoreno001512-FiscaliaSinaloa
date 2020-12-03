using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Audiencia_Defensor_Victima;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Audiencia_Defensor_Victima;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_Generales;

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
    public class Detalle_Audiencia_Defensor_VictimaController : Controller
    {
        #region "variable declaration"

        private IDetalle_Audiencia_Defensor_VictimaService service = null;
        private IDetalle_Audiencia_Defensor_VictimaApiConsumer _IDetalle_Audiencia_Defensor_VictimaApiConsumer;
        private IDetalle_de_Datos_GeneralesApiConsumer _IDetalle_de_Datos_GeneralesApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Audiencia_Defensor_VictimaController(IDetalle_Audiencia_Defensor_VictimaService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Audiencia_Defensor_VictimaApiConsumer Detalle_Audiencia_Defensor_VictimaApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IDetalle_de_Datos_GeneralesApiConsumer Detalle_de_Datos_GeneralesApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Audiencia_Defensor_VictimaApiConsumer = Detalle_Audiencia_Defensor_VictimaApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IDetalle_de_Datos_GeneralesApiConsumer = Detalle_de_Datos_GeneralesApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Audiencia_Defensor_Victima
        [ObjectAuth(ObjectId = (ModuleObjectId)45485, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45485);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Audiencia_Defensor_Victima/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45485, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45485);
            ViewBag.Permission = permission;
            var varDetalle_Audiencia_Defensor_Victima = new Detalle_Audiencia_Defensor_VictimaModel();
			
            ViewBag.ObjectId = "45485";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Audiencia_Defensor_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Audiencia_Defensor_VictimaData = _IDetalle_Audiencia_Defensor_VictimaApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Audiencia_Defensor_Victimas[0];
                if (Detalle_Audiencia_Defensor_VictimaData == null)
                    return HttpNotFound();

                varDetalle_Audiencia_Defensor_Victima = new Detalle_Audiencia_Defensor_VictimaModel
                {
                    Clave = (int)Detalle_Audiencia_Defensor_VictimaData.Clave
                    ,Nombre_del_Imputado = Detalle_Audiencia_Defensor_VictimaData.Nombre_del_Imputado
                    ,Nombre_del_ImputadoNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Detalle_Audiencia_Defensor_VictimaData.Nombre_del_Imputado), "Detalle_de_Datos_Generales") ??  (string)Detalle_Audiencia_Defensor_VictimaData.Nombre_del_Imputado_Detalle_de_Datos_Generales.Nombre_Completo
                    ,Abogado = Detalle_Audiencia_Defensor_VictimaData.Abogado
                    ,Cedula_Profesional = Detalle_Audiencia_Defensor_VictimaData.Cedula_Profesional

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Audiencia_Defensor_Victima);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Audiencia_Defensor_Victima(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45485);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Audiencia_Defensor_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Audiencia_Defensor_VictimaModel varDetalle_Audiencia_Defensor_Victima= new Detalle_Audiencia_Defensor_VictimaModel();


            if (id.ToString() != "0")
            {
                var Detalle_Audiencia_Defensor_VictimasData = _IDetalle_Audiencia_Defensor_VictimaApiConsumer.ListaSelAll(0, 1000, "Detalle_Audiencia_Defensor_Victima.Clave=" + id, "").Resource.Detalle_Audiencia_Defensor_Victimas;
				
				if (Detalle_Audiencia_Defensor_VictimasData != null && Detalle_Audiencia_Defensor_VictimasData.Count > 0)
                {
					var Detalle_Audiencia_Defensor_VictimaData = Detalle_Audiencia_Defensor_VictimasData.First();
					varDetalle_Audiencia_Defensor_Victima= new Detalle_Audiencia_Defensor_VictimaModel
					{
						Clave  = Detalle_Audiencia_Defensor_VictimaData.Clave 
	                    ,Nombre_del_Imputado = Detalle_Audiencia_Defensor_VictimaData.Nombre_del_Imputado
                    ,Nombre_del_ImputadoNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Detalle_Audiencia_Defensor_VictimaData.Nombre_del_Imputado), "Detalle_de_Datos_Generales") ??  (string)Detalle_Audiencia_Defensor_VictimaData.Nombre_del_Imputado_Detalle_de_Datos_Generales.Nombre_Completo
                    ,Abogado = Detalle_Audiencia_Defensor_VictimaData.Abogado
                    ,Cedula_Profesional = Detalle_Audiencia_Defensor_VictimaData.Cedula_Profesional

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDetalle_Audiencia_Defensor_Victima", varDetalle_Audiencia_Defensor_Victima);
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
        public ActionResult GetDetalle_de_Datos_GeneralesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_Completo")?? m.Nombre_Completo,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Audiencia_Defensor_VictimaPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Audiencia_Defensor_VictimaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Audiencia_Defensor_Victimas == null)
                result.Detalle_Audiencia_Defensor_Victimas = new List<Detalle_Audiencia_Defensor_Victima>();

            return Json(new
            {
                data = result.Detalle_Audiencia_Defensor_Victimas.Select(m => new Detalle_Audiencia_Defensor_VictimaGridModel
                    {
                    Clave = m.Clave
                        ,Nombre_del_ImputadoNombre_Completo = CultureHelper.GetTraduction(m.Nombre_del_Imputado_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Nombre_del_Imputado_Detalle_de_Datos_Generales.Nombre_Completo
			,Abogado = m.Abogado
			,Cedula_Profesional = m.Cedula_Profesional

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_Audiencia_Defensor_Victima_Nombre_del_Imputado_Detalle_de_Datos_Generales(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Datos_Generales.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Datos_Generales.Nombre_Completo as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_Datos_GeneralesApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Datos_Generales.Nombre_Completo ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Datos_Generaless)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Datos_Generales", "Nombre_Completo");
                    item.Nombre_Completo =trans ??item.Nombre_Completo;
                }
                return Json(result.Detalle_de_Datos_Generaless.ToArray(), JsonRequestBehavior.AllowGet);
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
                _IDetalle_Audiencia_Defensor_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Audiencia_Defensor_Victima varDetalle_Audiencia_Defensor_Victima = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Audiencia_Defensor_VictimaApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Audiencia_Defensor_VictimaModel varDetalle_Audiencia_Defensor_Victima)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Audiencia_Defensor_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Audiencia_Defensor_VictimaInfo = new Detalle_Audiencia_Defensor_Victima
                    {
                        Clave = varDetalle_Audiencia_Defensor_Victima.Clave
                        ,Nombre_del_Imputado = varDetalle_Audiencia_Defensor_Victima.Nombre_del_Imputado
                        ,Abogado = varDetalle_Audiencia_Defensor_Victima.Abogado
                        ,Cedula_Profesional = varDetalle_Audiencia_Defensor_Victima.Cedula_Profesional

                    };

                    result = !IsNew ?
                        _IDetalle_Audiencia_Defensor_VictimaApiConsumer.Update(Detalle_Audiencia_Defensor_VictimaInfo, null, null).Resource.ToString() :
                         _IDetalle_Audiencia_Defensor_VictimaApiConsumer.Insert(Detalle_Audiencia_Defensor_VictimaInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Audiencia_Defensor_Victima script
        /// </summary>
        /// <param name="oDetalle_Audiencia_Defensor_VictimaElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Audiencia_Defensor_VictimaModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Audiencia_Defensor_VictimaModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Audiencia_Defensor_VictimaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Audiencia_Defensor_VictimaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Audiencia_Defensor_VictimaModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Audiencia_Defensor_VictimaModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Audiencia_Defensor_VictimaModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Audiencia_Defensor_VictimaModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Audiencia_Defensor_VictimaModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Audiencia_Defensor_VictimaModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Audiencia_Defensor_VictimaModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Audiencia_Defensor_VictimaModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Audiencia_Defensor_VictimaScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Audiencia_Defensor_Victima.js")))
            {
                strDetalle_Audiencia_Defensor_VictimaScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Audiencia_Defensor_Victima element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Audiencia_Defensor_VictimaModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Audiencia_Defensor_VictimaScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Audiencia_Defensor_VictimaScript.Substring(indexOfArray, strDetalle_Audiencia_Defensor_VictimaScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Audiencia_Defensor_VictimaModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Audiencia_Defensor_VictimaModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Audiencia_Defensor_VictimaScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Audiencia_Defensor_VictimaScript.Substring(indexOfArrayHistory, strDetalle_Audiencia_Defensor_VictimaScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Audiencia_Defensor_VictimaScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Audiencia_Defensor_VictimaScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Audiencia_Defensor_VictimaScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Audiencia_Defensor_VictimaModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Audiencia_Defensor_VictimaScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Audiencia_Defensor_VictimaScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Audiencia_Defensor_VictimaScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Audiencia_Defensor_VictimaScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Audiencia_Defensor_Victima.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Audiencia_Defensor_Victima.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Audiencia_Defensor_Victima.js")))
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
        public ActionResult Detalle_Audiencia_Defensor_VictimaPropertyBag()
        {
            return PartialView("Detalle_Audiencia_Defensor_VictimaPropertyBag", "Detalle_Audiencia_Defensor_Victima");
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

            _IDetalle_Audiencia_Defensor_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Audiencia_Defensor_VictimaPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Audiencia_Defensor_VictimaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Audiencia_Defensor_Victimas == null)
                result.Detalle_Audiencia_Defensor_Victimas = new List<Detalle_Audiencia_Defensor_Victima>();

            var data = result.Detalle_Audiencia_Defensor_Victimas.Select(m => new Detalle_Audiencia_Defensor_VictimaGridModel
            {
                Clave = m.Clave
                ,Nombre_del_ImputadoNombre_Completo = (string)m.Nombre_del_Imputado_Detalle_de_Datos_Generales.Nombre_Completo
                ,Abogado = m.Abogado
                ,Cedula_Profesional = m.Cedula_Profesional

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Audiencia_Defensor_VictimaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Audiencia_Defensor_VictimaList_" + DateTime.Now.ToString());
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

            _IDetalle_Audiencia_Defensor_VictimaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Audiencia_Defensor_VictimaPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Audiencia_Defensor_VictimaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Audiencia_Defensor_Victimas == null)
                result.Detalle_Audiencia_Defensor_Victimas = new List<Detalle_Audiencia_Defensor_Victima>();

            var data = result.Detalle_Audiencia_Defensor_Victimas.Select(m => new Detalle_Audiencia_Defensor_VictimaGridModel
            {
                Clave = m.Clave
                ,Nombre_del_ImputadoNombre_Completo = (string)m.Nombre_del_Imputado_Detalle_de_Datos_Generales.Nombre_Completo
                ,Abogado = m.Abogado
                ,Cedula_Profesional = m.Cedula_Profesional

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
