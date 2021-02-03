using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Delito_Mandamiento_Judicial;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Modalidad_Delito;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Delito_Mandamiento_Judicial;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Delito_Mandamiento_Judicial;
using Spartane.Web.Areas.WebApiConsumer.Delito;
using Spartane.Web.Areas.WebApiConsumer.Modalidad_Delito;

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
    public class Detalle_de_Delito_Mandamiento_JudicialController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Delito_Mandamiento_JudicialService service = null;
        private IDetalle_de_Delito_Mandamiento_JudicialApiConsumer _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer;
        private IDelitoApiConsumer _IDelitoApiConsumer;
        private IModalidad_DelitoApiConsumer _IModalidad_DelitoApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_de_Delito_Mandamiento_JudicialController(IDetalle_de_Delito_Mandamiento_JudicialService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Delito_Mandamiento_JudicialApiConsumer Detalle_de_Delito_Mandamiento_JudicialApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IDelitoApiConsumer DelitoApiConsumer , IModalidad_DelitoApiConsumer Modalidad_DelitoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Delito_Mandamiento_JudicialApiConsumer = Detalle_de_Delito_Mandamiento_JudicialApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IDelitoApiConsumer = DelitoApiConsumer;
            this._IModalidad_DelitoApiConsumer = Modalidad_DelitoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Delito_Mandamiento_Judicial
        [ObjectAuth(ObjectId = (ModuleObjectId)45665, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45665);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_de_Delito_Mandamiento_Judicial/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45665, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45665);
            ViewBag.Permission = permission;
            var varDetalle_de_Delito_Mandamiento_Judicial = new Detalle_de_Delito_Mandamiento_JudicialModel();
			
            ViewBag.ObjectId = "45665";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Delito_Mandamiento_JudicialData = _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.GetByKeyComplete(Id).Resource.Detalle_de_Delito_Mandamiento_Judicials[0];
                if (Detalle_de_Delito_Mandamiento_JudicialData == null)
                    return HttpNotFound();

                varDetalle_de_Delito_Mandamiento_Judicial = new Detalle_de_Delito_Mandamiento_JudicialModel
                {
                    Clave = (int)Detalle_de_Delito_Mandamiento_JudicialData.Clave
                    ,Delito = Detalle_de_Delito_Mandamiento_JudicialData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_Mandamiento_JudicialData.Delito), "Delito") ??  (string)Detalle_de_Delito_Mandamiento_JudicialData.Delito_Delito.Descripcion
                    ,Modalidad = Detalle_de_Delito_Mandamiento_JudicialData.Modalidad
                    ,ModalidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_Mandamiento_JudicialData.Modalidad), "Modalidad_Delito") ??  (string)Detalle_de_Delito_Mandamiento_JudicialData.Modalidad_Modalidad_Delito.Descripcion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad != null && Modalidad_Delitos_Modalidad.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad = Modalidad_Delitos_Modalidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_de_Delito_Mandamiento_Judicial);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Delito_Mandamiento_Judicial(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45665);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Delito_Mandamiento_JudicialModel varDetalle_de_Delito_Mandamiento_Judicial= new Detalle_de_Delito_Mandamiento_JudicialModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_Delito_Mandamiento_JudicialsData = _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Delito_Mandamiento_Judicial.Clave=" + id, "").Resource.Detalle_de_Delito_Mandamiento_Judicials;
				
				if (Detalle_de_Delito_Mandamiento_JudicialsData != null && Detalle_de_Delito_Mandamiento_JudicialsData.Count > 0)
                {
					var Detalle_de_Delito_Mandamiento_JudicialData = Detalle_de_Delito_Mandamiento_JudicialsData.First();
					varDetalle_de_Delito_Mandamiento_Judicial= new Detalle_de_Delito_Mandamiento_JudicialModel
					{
						Clave  = Detalle_de_Delito_Mandamiento_JudicialData.Clave 
	                    ,Delito = Detalle_de_Delito_Mandamiento_JudicialData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_Mandamiento_JudicialData.Delito), "Delito") ??  (string)Detalle_de_Delito_Mandamiento_JudicialData.Delito_Delito.Descripcion
                    ,Modalidad = Detalle_de_Delito_Mandamiento_JudicialData.Modalidad
                    ,ModalidadDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_Mandamiento_JudicialData.Modalidad), "Modalidad_Delito") ??  (string)Detalle_de_Delito_Mandamiento_JudicialData.Modalidad_Modalidad_Delito.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad != null && Modalidad_Delitos_Modalidad.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad = Modalidad_Delitos_Modalidad.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Delito_Mandamiento_Judicial", varDetalle_de_Delito_Mandamiento_Judicial);
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
        public ActionResult GetDelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelitoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetModalidad_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModalidad_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Delito_Mandamiento_JudicialPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Delito_Mandamiento_Judicials == null)
                result.Detalle_de_Delito_Mandamiento_Judicials = new List<Detalle_de_Delito_Mandamiento_Judicial>();

            return Json(new
            {
                data = result.Detalle_de_Delito_Mandamiento_Judicials.Select(m => new Detalle_de_Delito_Mandamiento_JudicialGridModel
                    {
                    Clave = m.Clave
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Delito") ?? (string)m.Delito_Delito.Descripcion
                        ,ModalidadDescripcion = CultureHelper.GetTraduction(m.Modalidad_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_Modalidad_Delito.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Delito_Mandamiento_Judicial_Delito_Delito(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Delito.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Delito.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDelitoApiConsumer.ListaSelAll(1, 20,elWhere , " Delito.Descripcion ASC ").Resource;
               
                foreach (var item in result.Delitos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Delito", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Delitos.ToArray(), JsonRequestBehavior.AllowGet);
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
                _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Delito_Mandamiento_Judicial varDetalle_de_Delito_Mandamiento_Judicial = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Delito_Mandamiento_JudicialModel varDetalle_de_Delito_Mandamiento_Judicial)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_Delito_Mandamiento_JudicialInfo = new Detalle_de_Delito_Mandamiento_Judicial
                    {
                        Clave = varDetalle_de_Delito_Mandamiento_Judicial.Clave
                        ,Delito = varDetalle_de_Delito_Mandamiento_Judicial.Delito
                        ,Modalidad = varDetalle_de_Delito_Mandamiento_Judicial.Modalidad

                    };

                    result = !IsNew ?
                        _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.Update(Detalle_de_Delito_Mandamiento_JudicialInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.Insert(Detalle_de_Delito_Mandamiento_JudicialInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_de_Delito_Mandamiento_Judicial script
        /// </summary>
        /// <param name="oDetalle_de_Delito_Mandamiento_JudicialElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_de_Delito_Mandamiento_JudicialScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Delito_Mandamiento_Judicial.js")))
            {
                strDetalle_de_Delito_Mandamiento_JudicialScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Delito_Mandamiento_Judicial element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Delito_Mandamiento_JudicialScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Delito_Mandamiento_JudicialScript.Substring(indexOfArray, strDetalle_de_Delito_Mandamiento_JudicialScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Delito_Mandamiento_JudicialScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_de_Delito_Mandamiento_JudicialScript.Substring(indexOfArrayHistory, strDetalle_de_Delito_Mandamiento_JudicialScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_de_Delito_Mandamiento_JudicialScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Delito_Mandamiento_JudicialScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Delito_Mandamiento_JudicialScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_de_Delito_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_de_Delito_Mandamiento_JudicialScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_de_Delito_Mandamiento_JudicialScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_de_Delito_Mandamiento_JudicialScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_de_Delito_Mandamiento_JudicialScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Delito_Mandamiento_Judicial.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Delito_Mandamiento_Judicial.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Delito_Mandamiento_Judicial.js")))
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
        public ActionResult Detalle_de_Delito_Mandamiento_JudicialPropertyBag()
        {
            return PartialView("Detalle_de_Delito_Mandamiento_JudicialPropertyBag", "Detalle_de_Delito_Mandamiento_Judicial");
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

            _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Delito_Mandamiento_JudicialPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Delito_Mandamiento_Judicials == null)
                result.Detalle_de_Delito_Mandamiento_Judicials = new List<Detalle_de_Delito_Mandamiento_Judicial>();

            var data = result.Detalle_de_Delito_Mandamiento_Judicials.Select(m => new Detalle_de_Delito_Mandamiento_JudicialGridModel
            {
                Clave = m.Clave
                ,DelitoDescripcion = (string)m.Delito_Delito.Descripcion
                ,ModalidadDescripcion = (string)m.Modalidad_Modalidad_Delito.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_de_Delito_Mandamiento_JudicialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_de_Delito_Mandamiento_JudicialList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Delito_Mandamiento_JudicialPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Delito_Mandamiento_JudicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Delito_Mandamiento_Judicials == null)
                result.Detalle_de_Delito_Mandamiento_Judicials = new List<Detalle_de_Delito_Mandamiento_Judicial>();

            var data = result.Detalle_de_Delito_Mandamiento_Judicials.Select(m => new Detalle_de_Delito_Mandamiento_JudicialGridModel
            {
                Clave = m.Clave
                ,DelitoDescripcion = (string)m.Delito_Delito.Descripcion
                ,ModalidadDescripcion = (string)m.Modalidad_Modalidad_Delito.Descripcion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
