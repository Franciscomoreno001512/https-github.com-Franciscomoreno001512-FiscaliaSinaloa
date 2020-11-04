using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado;
using Spartane.Core.Domain.Redes_Sociales;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Datos_Personales_Adicionales_Involucrado;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Datos_Personales_Adicionales_Involucrado;
using Spartane.Web.Areas.WebApiConsumer.Redes_Sociales;

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
    public class Datos_Personales_Adicionales_InvolucradoController : Controller
    {
        #region "variable declaration"

        private IDatos_Personales_Adicionales_InvolucradoService service = null;
        private IDatos_Personales_Adicionales_InvolucradoApiConsumer _IDatos_Personales_Adicionales_InvolucradoApiConsumer;
        private IRedes_SocialesApiConsumer _IRedes_SocialesApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Datos_Personales_Adicionales_InvolucradoController(IDatos_Personales_Adicionales_InvolucradoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDatos_Personales_Adicionales_InvolucradoApiConsumer Datos_Personales_Adicionales_InvolucradoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IRedes_SocialesApiConsumer Redes_SocialesApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDatos_Personales_Adicionales_InvolucradoApiConsumer = Datos_Personales_Adicionales_InvolucradoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IRedes_SocialesApiConsumer = Redes_SocialesApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Datos_Personales_Adicionales_Involucrado
        [ObjectAuth(ObjectId = (ModuleObjectId)45310, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45310);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Datos_Personales_Adicionales_Involucrado/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45310, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45310);
            ViewBag.Permission = permission;
            var varDatos_Personales_Adicionales_Involucrado = new Datos_Personales_Adicionales_InvolucradoModel();
			
            ViewBag.ObjectId = "45310";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDatos_Personales_Adicionales_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Datos_Personales_Adicionales_InvolucradoData = _IDatos_Personales_Adicionales_InvolucradoApiConsumer.GetByKeyComplete(Id).Resource.Datos_Personales_Adicionales_Involucrados[0];
                if (Datos_Personales_Adicionales_InvolucradoData == null)
                    return HttpNotFound();

                varDatos_Personales_Adicionales_Involucrado = new Datos_Personales_Adicionales_InvolucradoModel
                {
                    Clave = (int)Datos_Personales_Adicionales_InvolucradoData.Clave
                    ,Correo_Electronico = Datos_Personales_Adicionales_InvolucradoData.Correo_Electronico
                    ,Numero_Telefonico = Datos_Personales_Adicionales_InvolucradoData.Numero_Telefonico
                    ,Redes_Sociales = Datos_Personales_Adicionales_InvolucradoData.Redes_Sociales
                    ,Redes_SocialesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Datos_Personales_Adicionales_InvolucradoData.Redes_Sociales), "Redes_Sociales") ??  (string)Datos_Personales_Adicionales_InvolucradoData.Redes_Sociales_Redes_Sociales.Descripcion
                    ,Observaciones = Datos_Personales_Adicionales_InvolucradoData.Observaciones

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IRedes_SocialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Redes_Socialess_Redes_Sociales = _IRedes_SocialesApiConsumer.SelAll(true);
            if (Redes_Socialess_Redes_Sociales != null && Redes_Socialess_Redes_Sociales.Resource != null)
                ViewBag.Redes_Socialess_Redes_Sociales = Redes_Socialess_Redes_Sociales.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Redes_Sociales", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDatos_Personales_Adicionales_Involucrado);
        }
		
	[HttpGet]
        public ActionResult AddDatos_Personales_Adicionales_Involucrado(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45310);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDatos_Personales_Adicionales_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Datos_Personales_Adicionales_InvolucradoModel varDatos_Personales_Adicionales_Involucrado= new Datos_Personales_Adicionales_InvolucradoModel();


            if (id.ToString() != "0")
            {
                var Datos_Personales_Adicionales_InvolucradosData = _IDatos_Personales_Adicionales_InvolucradoApiConsumer.ListaSelAll(0, 1000, "Datos_Personales_Adicionales_Involucrado.Clave=" + id, "").Resource.Datos_Personales_Adicionales_Involucrados;
				
				if (Datos_Personales_Adicionales_InvolucradosData != null && Datos_Personales_Adicionales_InvolucradosData.Count > 0)
                {
					var Datos_Personales_Adicionales_InvolucradoData = Datos_Personales_Adicionales_InvolucradosData.First();
					varDatos_Personales_Adicionales_Involucrado= new Datos_Personales_Adicionales_InvolucradoModel
					{
						Clave  = Datos_Personales_Adicionales_InvolucradoData.Clave 
	                    ,Correo_Electronico = Datos_Personales_Adicionales_InvolucradoData.Correo_Electronico
                    ,Numero_Telefonico = Datos_Personales_Adicionales_InvolucradoData.Numero_Telefonico
                    ,Redes_Sociales = Datos_Personales_Adicionales_InvolucradoData.Redes_Sociales
                    ,Redes_SocialesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Datos_Personales_Adicionales_InvolucradoData.Redes_Sociales), "Redes_Sociales") ??  (string)Datos_Personales_Adicionales_InvolucradoData.Redes_Sociales_Redes_Sociales.Descripcion
                    ,Observaciones = Datos_Personales_Adicionales_InvolucradoData.Observaciones

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IRedes_SocialesApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Redes_Socialess_Redes_Sociales = _IRedes_SocialesApiConsumer.SelAll(true);
            if (Redes_Socialess_Redes_Sociales != null && Redes_Socialess_Redes_Sociales.Resource != null)
                ViewBag.Redes_Socialess_Redes_Sociales = Redes_Socialess_Redes_Sociales.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Redes_Sociales", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDatos_Personales_Adicionales_Involucrado", varDatos_Personales_Adicionales_Involucrado);
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
        public ActionResult GetRedes_SocialesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRedes_SocialesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRedes_SocialesApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Redes_Sociales", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Datos_Personales_Adicionales_InvolucradoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDatos_Personales_Adicionales_InvolucradoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Datos_Personales_Adicionales_Involucrados == null)
                result.Datos_Personales_Adicionales_Involucrados = new List<Datos_Personales_Adicionales_Involucrado>();

            return Json(new
            {
                data = result.Datos_Personales_Adicionales_Involucrados.Select(m => new Datos_Personales_Adicionales_InvolucradoGridModel
                    {
                    Clave = m.Clave
			,Correo_Electronico = m.Correo_Electronico
			,Numero_Telefonico = m.Numero_Telefonico
                        ,Redes_SocialesDescripcion = CultureHelper.GetTraduction(m.Redes_Sociales_Redes_Sociales.Clave.ToString(), "Descripcion") ?? (string)m.Redes_Sociales_Redes_Sociales.Descripcion
			,Observaciones = m.Observaciones

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
                _IDatos_Personales_Adicionales_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Datos_Personales_Adicionales_Involucrado varDatos_Personales_Adicionales_Involucrado = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDatos_Personales_Adicionales_InvolucradoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Datos_Personales_Adicionales_InvolucradoModel varDatos_Personales_Adicionales_Involucrado)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDatos_Personales_Adicionales_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Datos_Personales_Adicionales_InvolucradoInfo = new Datos_Personales_Adicionales_Involucrado
                    {
                        Clave = varDatos_Personales_Adicionales_Involucrado.Clave
                        ,Correo_Electronico = varDatos_Personales_Adicionales_Involucrado.Correo_Electronico
                        ,Numero_Telefonico = varDatos_Personales_Adicionales_Involucrado.Numero_Telefonico
                        ,Redes_Sociales = varDatos_Personales_Adicionales_Involucrado.Redes_Sociales
                        ,Observaciones = varDatos_Personales_Adicionales_Involucrado.Observaciones

                    };

                    result = !IsNew ?
                        _IDatos_Personales_Adicionales_InvolucradoApiConsumer.Update(Datos_Personales_Adicionales_InvolucradoInfo, null, null).Resource.ToString() :
                         _IDatos_Personales_Adicionales_InvolucradoApiConsumer.Insert(Datos_Personales_Adicionales_InvolucradoInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Datos_Personales_Adicionales_Involucrado script
        /// </summary>
        /// <param name="oDatos_Personales_Adicionales_InvolucradoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Datos_Personales_Adicionales_InvolucradoModuleAttributeList)
        {
            for (int i = 0; i < Datos_Personales_Adicionales_InvolucradoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Datos_Personales_Adicionales_InvolucradoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Datos_Personales_Adicionales_InvolucradoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Datos_Personales_Adicionales_InvolucradoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Datos_Personales_Adicionales_InvolucradoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Datos_Personales_Adicionales_InvolucradoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Datos_Personales_Adicionales_InvolucradoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Datos_Personales_Adicionales_InvolucradoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Datos_Personales_Adicionales_InvolucradoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Datos_Personales_Adicionales_InvolucradoModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Datos_Personales_Adicionales_InvolucradoModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDatos_Personales_Adicionales_InvolucradoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Datos_Personales_Adicionales_Involucrado.js")))
            {
                strDatos_Personales_Adicionales_InvolucradoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Datos_Personales_Adicionales_Involucrado element attributes
            string userChangeJson = jsSerialize.Serialize(Datos_Personales_Adicionales_InvolucradoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDatos_Personales_Adicionales_InvolucradoScript.IndexOf("inpuElementArray");
            string splittedString = strDatos_Personales_Adicionales_InvolucradoScript.Substring(indexOfArray, strDatos_Personales_Adicionales_InvolucradoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Datos_Personales_Adicionales_InvolucradoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Datos_Personales_Adicionales_InvolucradoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDatos_Personales_Adicionales_InvolucradoScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDatos_Personales_Adicionales_InvolucradoScript.Substring(indexOfArrayHistory, strDatos_Personales_Adicionales_InvolucradoScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDatos_Personales_Adicionales_InvolucradoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDatos_Personales_Adicionales_InvolucradoScript.Substring(endIndexOfMainElement + indexOfArray, strDatos_Personales_Adicionales_InvolucradoScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Datos_Personales_Adicionales_InvolucradoModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDatos_Personales_Adicionales_InvolucradoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDatos_Personales_Adicionales_InvolucradoScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDatos_Personales_Adicionales_InvolucradoScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDatos_Personales_Adicionales_InvolucradoScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Datos_Personales_Adicionales_Involucrado.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Datos_Personales_Adicionales_Involucrado.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Datos_Personales_Adicionales_Involucrado.js")))
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
        public ActionResult Datos_Personales_Adicionales_InvolucradoPropertyBag()
        {
            return PartialView("Datos_Personales_Adicionales_InvolucradoPropertyBag", "Datos_Personales_Adicionales_Involucrado");
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

            _IDatos_Personales_Adicionales_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Datos_Personales_Adicionales_InvolucradoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDatos_Personales_Adicionales_InvolucradoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Datos_Personales_Adicionales_Involucrados == null)
                result.Datos_Personales_Adicionales_Involucrados = new List<Datos_Personales_Adicionales_Involucrado>();

            var data = result.Datos_Personales_Adicionales_Involucrados.Select(m => new Datos_Personales_Adicionales_InvolucradoGridModel
            {
                Clave = m.Clave
                ,Correo_Electronico = m.Correo_Electronico
                ,Numero_Telefonico = m.Numero_Telefonico
                ,Redes_SocialesDescripcion = (string)m.Redes_Sociales_Redes_Sociales.Descripcion
                ,Observaciones = m.Observaciones

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Datos_Personales_Adicionales_InvolucradoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Datos_Personales_Adicionales_InvolucradoList_" + DateTime.Now.ToString());
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

            _IDatos_Personales_Adicionales_InvolucradoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Datos_Personales_Adicionales_InvolucradoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDatos_Personales_Adicionales_InvolucradoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Datos_Personales_Adicionales_Involucrados == null)
                result.Datos_Personales_Adicionales_Involucrados = new List<Datos_Personales_Adicionales_Involucrado>();

            var data = result.Datos_Personales_Adicionales_Involucrados.Select(m => new Datos_Personales_Adicionales_InvolucradoGridModel
            {
                Clave = m.Clave
                ,Correo_Electronico = m.Correo_Electronico
                ,Numero_Telefonico = m.Numero_Telefonico
                ,Redes_SocialesDescripcion = (string)m.Redes_Sociales_Redes_Sociales.Descripcion
                ,Observaciones = m.Observaciones

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
