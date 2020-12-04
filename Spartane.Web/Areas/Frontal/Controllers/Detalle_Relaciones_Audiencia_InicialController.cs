using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Relaciones_Audiencia_Inicial;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.Delito;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Relaciones_Audiencia_Inicial;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Relaciones_Audiencia_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Imputado;
using Spartane.Web.Areas.WebApiConsumer.Delito;

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
    public class Detalle_Relaciones_Audiencia_InicialController : Controller
    {
        #region "variable declaration"

        private IDetalle_Relaciones_Audiencia_InicialService service = null;
        private IDetalle_Relaciones_Audiencia_InicialApiConsumer _IDetalle_Relaciones_Audiencia_InicialApiConsumer;
        private IDetalle_de_ImputadoApiConsumer _IDetalle_de_ImputadoApiConsumer;
        private IDelitoApiConsumer _IDelitoApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Relaciones_Audiencia_InicialController(IDetalle_Relaciones_Audiencia_InicialService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Relaciones_Audiencia_InicialApiConsumer Detalle_Relaciones_Audiencia_InicialApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IDetalle_de_ImputadoApiConsumer Detalle_de_ImputadoApiConsumer , IDelitoApiConsumer DelitoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Relaciones_Audiencia_InicialApiConsumer = Detalle_Relaciones_Audiencia_InicialApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IDetalle_de_ImputadoApiConsumer = Detalle_de_ImputadoApiConsumer;
            this._IDelitoApiConsumer = DelitoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Relaciones_Audiencia_Inicial
        [ObjectAuth(ObjectId = (ModuleObjectId)45562, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45562);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Relaciones_Audiencia_Inicial/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45562, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45562);
            ViewBag.Permission = permission;
            var varDetalle_Relaciones_Audiencia_Inicial = new Detalle_Relaciones_Audiencia_InicialModel();
			
            ViewBag.ObjectId = "45562";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Relaciones_Audiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Relaciones_Audiencia_InicialData = _IDetalle_Relaciones_Audiencia_InicialApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Relaciones_Audiencia_Inicials[0];
                if (Detalle_Relaciones_Audiencia_InicialData == null)
                    return HttpNotFound();

                varDetalle_Relaciones_Audiencia_Inicial = new Detalle_Relaciones_Audiencia_InicialModel
                {
                    Clave = (int)Detalle_Relaciones_Audiencia_InicialData.Clave
                    ,Imputado = Detalle_Relaciones_Audiencia_InicialData.Imputado
                    ,ImputadoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(Convert.ToString(Detalle_Relaciones_Audiencia_InicialData.Imputado), "Detalle_de_Imputado") ??  (string)Detalle_Relaciones_Audiencia_InicialData.Imputado_Detalle_de_Imputado.Nombre_Completo_del_Tutor
                    ,Delito = Detalle_Relaciones_Audiencia_InicialData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Relaciones_Audiencia_InicialData.Delito), "Delito") ??  (string)Detalle_Relaciones_Audiencia_InicialData.Delito_Delito.Descripcion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Relaciones_Audiencia_Inicial);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Relaciones_Audiencia_Inicial(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45562);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Relaciones_Audiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Relaciones_Audiencia_InicialModel varDetalle_Relaciones_Audiencia_Inicial= new Detalle_Relaciones_Audiencia_InicialModel();


            if (id.ToString() != "0")
            {
                var Detalle_Relaciones_Audiencia_InicialsData = _IDetalle_Relaciones_Audiencia_InicialApiConsumer.ListaSelAll(0, 1000, "Detalle_Relaciones_Audiencia_Inicial.Clave=" + id, "").Resource.Detalle_Relaciones_Audiencia_Inicials;
				
				if (Detalle_Relaciones_Audiencia_InicialsData != null && Detalle_Relaciones_Audiencia_InicialsData.Count > 0)
                {
					var Detalle_Relaciones_Audiencia_InicialData = Detalle_Relaciones_Audiencia_InicialsData.First();
					varDetalle_Relaciones_Audiencia_Inicial= new Detalle_Relaciones_Audiencia_InicialModel
					{
						Clave  = Detalle_Relaciones_Audiencia_InicialData.Clave 
	                    ,Imputado = Detalle_Relaciones_Audiencia_InicialData.Imputado
                    ,ImputadoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(Convert.ToString(Detalle_Relaciones_Audiencia_InicialData.Imputado), "Detalle_de_Imputado") ??  (string)Detalle_Relaciones_Audiencia_InicialData.Imputado_Detalle_de_Imputado.Nombre_Completo_del_Tutor
                    ,Delito = Detalle_Relaciones_Audiencia_InicialData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Relaciones_Audiencia_InicialData.Delito), "Delito") ??  (string)Detalle_Relaciones_Audiencia_InicialData.Delito_Delito.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDetalle_Relaciones_Audiencia_Inicial", varDetalle_Relaciones_Audiencia_Inicial);
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
        public ActionResult GetDetalle_de_ImputadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_ImputadoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre_Completo_del_Tutor).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Imputado", "Nombre_Completo_del_Tutor")?? m.Nombre_Completo_del_Tutor,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
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



        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Relaciones_Audiencia_InicialPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Relaciones_Audiencia_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Relaciones_Audiencia_Inicials == null)
                result.Detalle_Relaciones_Audiencia_Inicials = new List<Detalle_Relaciones_Audiencia_Inicial>();

            return Json(new
            {
                data = result.Detalle_Relaciones_Audiencia_Inicials.Select(m => new Detalle_Relaciones_Audiencia_InicialGridModel
                    {
                    Clave = m.Clave
                        ,ImputadoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(m.Imputado_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Imputado_Detalle_de_Imputado.Nombre_Completo_del_Tutor
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Delito") ?? (string)m.Delito_Delito.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_Relaciones_Audiencia_Inicial_Imputado_Detalle_de_Imputado(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_ImputadoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Imputado.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Imputado.Nombre_Completo_del_Tutor as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_ImputadoApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Imputado.Nombre_Completo_del_Tutor ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Imputados)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Imputado", "Nombre_Completo_del_Tutor");
                    item.Nombre_Completo_del_Tutor =trans ??item.Nombre_Completo_del_Tutor;
                }
                return Json(result.Detalle_de_Imputados.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_Relaciones_Audiencia_Inicial_Delito_Delito(string query, string where)
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
                _IDetalle_Relaciones_Audiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Relaciones_Audiencia_Inicial varDetalle_Relaciones_Audiencia_Inicial = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Relaciones_Audiencia_InicialApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Relaciones_Audiencia_InicialModel varDetalle_Relaciones_Audiencia_Inicial)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Relaciones_Audiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Relaciones_Audiencia_InicialInfo = new Detalle_Relaciones_Audiencia_Inicial
                    {
                        Clave = varDetalle_Relaciones_Audiencia_Inicial.Clave
                        ,Imputado = varDetalle_Relaciones_Audiencia_Inicial.Imputado
                        ,Delito = varDetalle_Relaciones_Audiencia_Inicial.Delito

                    };

                    result = !IsNew ?
                        _IDetalle_Relaciones_Audiencia_InicialApiConsumer.Update(Detalle_Relaciones_Audiencia_InicialInfo, null, null).Resource.ToString() :
                         _IDetalle_Relaciones_Audiencia_InicialApiConsumer.Insert(Detalle_Relaciones_Audiencia_InicialInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Relaciones_Audiencia_Inicial script
        /// </summary>
        /// <param name="oDetalle_Relaciones_Audiencia_InicialElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Relaciones_Audiencia_InicialModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Relaciones_Audiencia_InicialModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Relaciones_Audiencia_InicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Relaciones_Audiencia_InicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Relaciones_Audiencia_InicialModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Relaciones_Audiencia_InicialModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Relaciones_Audiencia_InicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Relaciones_Audiencia_InicialModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Relaciones_Audiencia_InicialModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Relaciones_Audiencia_InicialModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Relaciones_Audiencia_InicialModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Relaciones_Audiencia_InicialModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Relaciones_Audiencia_InicialScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Relaciones_Audiencia_Inicial.js")))
            {
                strDetalle_Relaciones_Audiencia_InicialScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Relaciones_Audiencia_Inicial element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Relaciones_Audiencia_InicialModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Relaciones_Audiencia_InicialScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Relaciones_Audiencia_InicialScript.Substring(indexOfArray, strDetalle_Relaciones_Audiencia_InicialScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Relaciones_Audiencia_InicialModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Relaciones_Audiencia_InicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Relaciones_Audiencia_InicialScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Relaciones_Audiencia_InicialScript.Substring(indexOfArrayHistory, strDetalle_Relaciones_Audiencia_InicialScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Relaciones_Audiencia_InicialScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Relaciones_Audiencia_InicialScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Relaciones_Audiencia_InicialScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Relaciones_Audiencia_InicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Relaciones_Audiencia_InicialScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Relaciones_Audiencia_InicialScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Relaciones_Audiencia_InicialScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Relaciones_Audiencia_InicialScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Relaciones_Audiencia_Inicial.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Relaciones_Audiencia_Inicial.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Relaciones_Audiencia_Inicial.js")))
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
        public ActionResult Detalle_Relaciones_Audiencia_InicialPropertyBag()
        {
            return PartialView("Detalle_Relaciones_Audiencia_InicialPropertyBag", "Detalle_Relaciones_Audiencia_Inicial");
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

            _IDetalle_Relaciones_Audiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Relaciones_Audiencia_InicialPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Relaciones_Audiencia_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Relaciones_Audiencia_Inicials == null)
                result.Detalle_Relaciones_Audiencia_Inicials = new List<Detalle_Relaciones_Audiencia_Inicial>();

            var data = result.Detalle_Relaciones_Audiencia_Inicials.Select(m => new Detalle_Relaciones_Audiencia_InicialGridModel
            {
                Clave = m.Clave
                ,ImputadoNombre_Completo_del_Tutor = (string)m.Imputado_Detalle_de_Imputado.Nombre_Completo_del_Tutor
                ,DelitoDescripcion = (string)m.Delito_Delito.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Relaciones_Audiencia_InicialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Relaciones_Audiencia_InicialList_" + DateTime.Now.ToString());
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

            _IDetalle_Relaciones_Audiencia_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Relaciones_Audiencia_InicialPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Relaciones_Audiencia_InicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Relaciones_Audiencia_Inicials == null)
                result.Detalle_Relaciones_Audiencia_Inicials = new List<Detalle_Relaciones_Audiencia_Inicial>();

            var data = result.Detalle_Relaciones_Audiencia_Inicials.Select(m => new Detalle_Relaciones_Audiencia_InicialGridModel
            {
                Clave = m.Clave
                ,ImputadoNombre_Completo_del_Tutor = (string)m.Imputado_Detalle_de_Imputado.Nombre_Completo_del_Tutor
                ,DelitoDescripcion = (string)m.Delito_Delito.Descripcion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
