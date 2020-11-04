using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Solicitante_Acuerdo;
using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Solicitante_Acuerdo;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Solicitante_Acuerdo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Solicitante;

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
    public class Detalle_Solicitante_AcuerdoController : Controller
    {
        #region "variable declaration"

        private IDetalle_Solicitante_AcuerdoService service = null;
        private IDetalle_Solicitante_AcuerdoApiConsumer _IDetalle_Solicitante_AcuerdoApiConsumer;
        private IDetalle_de_Solicitud_SolicitanteApiConsumer _IDetalle_de_Solicitud_SolicitanteApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Solicitante_AcuerdoController(IDetalle_Solicitante_AcuerdoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Solicitante_AcuerdoApiConsumer Detalle_Solicitante_AcuerdoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IDetalle_de_Solicitud_SolicitanteApiConsumer Detalle_de_Solicitud_SolicitanteApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Solicitante_AcuerdoApiConsumer = Detalle_Solicitante_AcuerdoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IDetalle_de_Solicitud_SolicitanteApiConsumer = Detalle_de_Solicitud_SolicitanteApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Solicitante_Acuerdo
        [ObjectAuth(ObjectId = (ModuleObjectId)45380, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45380);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Solicitante_Acuerdo/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45380, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45380);
            ViewBag.Permission = permission;
            var varDetalle_Solicitante_Acuerdo = new Detalle_Solicitante_AcuerdoModel();
			
            ViewBag.ObjectId = "45380";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Solicitante_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Solicitante_AcuerdoData = _IDetalle_Solicitante_AcuerdoApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Solicitante_Acuerdos[0];
                if (Detalle_Solicitante_AcuerdoData == null)
                    return HttpNotFound();

                varDetalle_Solicitante_Acuerdo = new Detalle_Solicitante_AcuerdoModel
                {
                    Folio = (int)Detalle_Solicitante_AcuerdoData.Folio
                    ,Solicitante = Detalle_Solicitante_AcuerdoData.Solicitante
                    ,SolicitanteNombre_Completo_tutor = CultureHelper.GetTraduction(Convert.ToString(Detalle_Solicitante_AcuerdoData.Solicitante), "Detalle_de_Solicitud_Solicitante") ??  (string)Detalle_Solicitante_AcuerdoData.Solicitante_Detalle_de_Solicitud_Solicitante.Nombre_Completo_tutor

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Solicitante_Acuerdo);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Solicitante_Acuerdo(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45380);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Solicitante_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Solicitante_AcuerdoModel varDetalle_Solicitante_Acuerdo= new Detalle_Solicitante_AcuerdoModel();


            if (id.ToString() != "0")
            {
                var Detalle_Solicitante_AcuerdosData = _IDetalle_Solicitante_AcuerdoApiConsumer.ListaSelAll(0, 1000, "Detalle_Solicitante_Acuerdo.Folio=" + id, "").Resource.Detalle_Solicitante_Acuerdos;
				
				if (Detalle_Solicitante_AcuerdosData != null && Detalle_Solicitante_AcuerdosData.Count > 0)
                {
					var Detalle_Solicitante_AcuerdoData = Detalle_Solicitante_AcuerdosData.First();
					varDetalle_Solicitante_Acuerdo= new Detalle_Solicitante_AcuerdoModel
					{
						Folio  = Detalle_Solicitante_AcuerdoData.Folio 
	                    ,Solicitante = Detalle_Solicitante_AcuerdoData.Solicitante
                    ,SolicitanteNombre_Completo_tutor = CultureHelper.GetTraduction(Convert.ToString(Detalle_Solicitante_AcuerdoData.Solicitante), "Detalle_de_Solicitud_Solicitante") ??  (string)Detalle_Solicitante_AcuerdoData.Solicitante_Detalle_de_Solicitud_Solicitante.Nombre_Completo_tutor

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDetalle_Solicitante_Acuerdo", varDetalle_Solicitante_Acuerdo);
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
        public ActionResult GetDetalle_de_Solicitud_SolicitanteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre_Completo_tutor).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Solicitud_Solicitante", "Nombre_Completo_tutor")?? m.Nombre_Completo_tutor,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Solicitante_AcuerdoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Solicitante_AcuerdoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Solicitante_Acuerdos == null)
                result.Detalle_Solicitante_Acuerdos = new List<Detalle_Solicitante_Acuerdo>();

            return Json(new
            {
                data = result.Detalle_Solicitante_Acuerdos.Select(m => new Detalle_Solicitante_AcuerdoGridModel
                    {
                    Folio = m.Folio
                        ,SolicitanteNombre_Completo_tutor = CultureHelper.GetTraduction(m.Solicitante_Detalle_de_Solicitud_Solicitante.Clave.ToString(), "Detalle_de_Solicitud_Solicitante") ?? (string)m.Solicitante_Detalle_de_Solicitud_Solicitante.Nombre_Completo_tutor

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_Solicitante_Acuerdo_Solicitante_Detalle_de_Solicitud_Solicitante(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Solicitud_Solicitante.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Solicitud_Solicitante.Nombre_Completo_tutor as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Solicitud_Solicitante.Nombre_Completo_tutor ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Solicitud_Solicitantes)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Solicitud_Solicitante", "Nombre_Completo_tutor");
                    item.Nombre_Completo_tutor =trans ??item.Nombre_Completo_tutor;
                }
                return Json(result.Detalle_de_Solicitud_Solicitantes.ToArray(), JsonRequestBehavior.AllowGet);
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
                _IDetalle_Solicitante_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Solicitante_Acuerdo varDetalle_Solicitante_Acuerdo = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Solicitante_AcuerdoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Solicitante_AcuerdoModel varDetalle_Solicitante_Acuerdo)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Solicitante_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Solicitante_AcuerdoInfo = new Detalle_Solicitante_Acuerdo
                    {
                        Folio = varDetalle_Solicitante_Acuerdo.Folio
                        ,Solicitante = varDetalle_Solicitante_Acuerdo.Solicitante

                    };

                    result = !IsNew ?
                        _IDetalle_Solicitante_AcuerdoApiConsumer.Update(Detalle_Solicitante_AcuerdoInfo, null, null).Resource.ToString() :
                         _IDetalle_Solicitante_AcuerdoApiConsumer.Insert(Detalle_Solicitante_AcuerdoInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Solicitante_Acuerdo script
        /// </summary>
        /// <param name="oDetalle_Solicitante_AcuerdoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Solicitante_AcuerdoModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Solicitante_AcuerdoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Solicitante_AcuerdoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Solicitante_AcuerdoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Solicitante_AcuerdoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Solicitante_AcuerdoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Solicitante_AcuerdoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Solicitante_AcuerdoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Solicitante_AcuerdoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Solicitante_AcuerdoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Solicitante_AcuerdoModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Solicitante_AcuerdoModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Solicitante_AcuerdoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Solicitante_Acuerdo.js")))
            {
                strDetalle_Solicitante_AcuerdoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Solicitante_Acuerdo element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Solicitante_AcuerdoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Solicitante_AcuerdoScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Solicitante_AcuerdoScript.Substring(indexOfArray, strDetalle_Solicitante_AcuerdoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Solicitante_AcuerdoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Solicitante_AcuerdoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Solicitante_AcuerdoScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Solicitante_AcuerdoScript.Substring(indexOfArrayHistory, strDetalle_Solicitante_AcuerdoScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Solicitante_AcuerdoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Solicitante_AcuerdoScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Solicitante_AcuerdoScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Solicitante_AcuerdoModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Solicitante_AcuerdoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Solicitante_AcuerdoScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Solicitante_AcuerdoScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Solicitante_AcuerdoScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Solicitante_Acuerdo.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Solicitante_Acuerdo.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Solicitante_Acuerdo.js")))
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
        public ActionResult Detalle_Solicitante_AcuerdoPropertyBag()
        {
            return PartialView("Detalle_Solicitante_AcuerdoPropertyBag", "Detalle_Solicitante_Acuerdo");
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

            _IDetalle_Solicitante_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Solicitante_AcuerdoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Solicitante_AcuerdoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Solicitante_Acuerdos == null)
                result.Detalle_Solicitante_Acuerdos = new List<Detalle_Solicitante_Acuerdo>();

            var data = result.Detalle_Solicitante_Acuerdos.Select(m => new Detalle_Solicitante_AcuerdoGridModel
            {
                Folio = m.Folio
                ,SolicitanteNombre_Completo_tutor = (string)m.Solicitante_Detalle_de_Solicitud_Solicitante.Nombre_Completo_tutor

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Solicitante_AcuerdoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Solicitante_AcuerdoList_" + DateTime.Now.ToString());
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

            _IDetalle_Solicitante_AcuerdoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Solicitante_AcuerdoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Solicitante_AcuerdoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Solicitante_Acuerdos == null)
                result.Detalle_Solicitante_Acuerdos = new List<Detalle_Solicitante_Acuerdo>();

            var data = result.Detalle_Solicitante_Acuerdos.Select(m => new Detalle_Solicitante_AcuerdoGridModel
            {
                Folio = m.Folio
                ,SolicitanteNombre_Completo_tutor = (string)m.Solicitante_Detalle_de_Solicitud_Solicitante.Nombre_Completo_tutor

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
