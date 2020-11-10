using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Solicitud_Historial_de_Asignaciones;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_User;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Solicitud_Historial_de_Asignaciones;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Solicitud_Historial_de_Asignaciones;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;

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
    public class Detalle_Solicitud_Historial_de_AsignacionesController : Controller
    {
        #region "variable declaration"

        private IDetalle_Solicitud_Historial_de_AsignacionesService service = null;
        private IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Solicitud_Historial_de_AsignacionesController(IDetalle_Solicitud_Historial_de_AsignacionesService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer Detalle_Solicitud_Historial_de_AsignacionesApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer = Detalle_Solicitud_Historial_de_AsignacionesApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Solicitud_Historial_de_Asignaciones
        [ObjectAuth(ObjectId = (ModuleObjectId)45392, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45392);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Solicitud_Historial_de_Asignaciones/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45392, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45392);
            ViewBag.Permission = permission;
            var varDetalle_Solicitud_Historial_de_Asignaciones = new Detalle_Solicitud_Historial_de_AsignacionesModel();
			
            ViewBag.ObjectId = "45392";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Solicitud_Historial_de_AsignacionesData = _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Solicitud_Historial_de_Asignacioness[0];
                if (Detalle_Solicitud_Historial_de_AsignacionesData == null)
                    return HttpNotFound();

                varDetalle_Solicitud_Historial_de_Asignaciones = new Detalle_Solicitud_Historial_de_AsignacionesModel
                {
                    Folio = (int)Detalle_Solicitud_Historial_de_AsignacionesData.Folio
                    ,Fecha_cambio = (Detalle_Solicitud_Historial_de_AsignacionesData.Fecha_cambio == null ? string.Empty : Convert.ToDateTime(Detalle_Solicitud_Historial_de_AsignacionesData.Fecha_cambio).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_cambio = Detalle_Solicitud_Historial_de_AsignacionesData.Hora_cambio
                    ,Usuario = Detalle_Solicitud_Historial_de_AsignacionesData.Usuario
                    ,UsuarioName = CultureHelper.GetTraduction(Convert.ToString(Detalle_Solicitud_Historial_de_AsignacionesData.Usuario), "Spartan_User") ??  (string)Detalle_Solicitud_Historial_de_AsignacionesData.Usuario_Spartan_User.Name
                    ,Facilitador_Asignado = Detalle_Solicitud_Historial_de_AsignacionesData.Facilitador_Asignado
                    ,Facilitador_AsignadoName = CultureHelper.GetTraduction(Convert.ToString(Detalle_Solicitud_Historial_de_AsignacionesData.Facilitador_Asignado), "Spartan_User") ??  (string)Detalle_Solicitud_Historial_de_AsignacionesData.Facilitador_Asignado_Spartan_User.Name
                    ,Motivo_cambio = Detalle_Solicitud_Historial_de_AsignacionesData.Motivo_cambio

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Solicitud_Historial_de_Asignaciones);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Solicitud_Historial_de_Asignaciones(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45392);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Solicitud_Historial_de_AsignacionesModel varDetalle_Solicitud_Historial_de_Asignaciones= new Detalle_Solicitud_Historial_de_AsignacionesModel();


            if (id.ToString() != "0")
            {
                var Detalle_Solicitud_Historial_de_AsignacionessData = _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.ListaSelAll(0, 1000, "Detalle_Solicitud_Historial_de_Asignaciones.Folio=" + id, "").Resource.Detalle_Solicitud_Historial_de_Asignacioness;
				
				if (Detalle_Solicitud_Historial_de_AsignacionessData != null && Detalle_Solicitud_Historial_de_AsignacionessData.Count > 0)
                {
					var Detalle_Solicitud_Historial_de_AsignacionesData = Detalle_Solicitud_Historial_de_AsignacionessData.First();
					varDetalle_Solicitud_Historial_de_Asignaciones= new Detalle_Solicitud_Historial_de_AsignacionesModel
					{
						Folio  = Detalle_Solicitud_Historial_de_AsignacionesData.Folio 
	                    ,Fecha_cambio = (Detalle_Solicitud_Historial_de_AsignacionesData.Fecha_cambio == null ? string.Empty : Convert.ToDateTime(Detalle_Solicitud_Historial_de_AsignacionesData.Fecha_cambio).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_cambio = Detalle_Solicitud_Historial_de_AsignacionesData.Hora_cambio
                    ,Usuario = Detalle_Solicitud_Historial_de_AsignacionesData.Usuario
                    ,UsuarioName = CultureHelper.GetTraduction(Convert.ToString(Detalle_Solicitud_Historial_de_AsignacionesData.Usuario), "Spartan_User") ??  (string)Detalle_Solicitud_Historial_de_AsignacionesData.Usuario_Spartan_User.Name
                    ,Facilitador_Asignado = Detalle_Solicitud_Historial_de_AsignacionesData.Facilitador_Asignado
                    ,Facilitador_AsignadoName = CultureHelper.GetTraduction(Convert.ToString(Detalle_Solicitud_Historial_de_AsignacionesData.Facilitador_Asignado), "Spartan_User") ??  (string)Detalle_Solicitud_Historial_de_AsignacionesData.Facilitador_Asignado_Spartan_User.Name
                    ,Motivo_cambio = Detalle_Solicitud_Historial_de_AsignacionesData.Motivo_cambio

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDetalle_Solicitud_Historial_de_Asignaciones", varDetalle_Solicitud_Historial_de_Asignaciones);
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
        public ActionResult GetSpartan_UserAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISpartan_UserApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name")?? m.Name,
                    Value = Convert.ToString(m.Id_User)
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Solicitud_Historial_de_AsignacionesPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Solicitud_Historial_de_Asignacioness == null)
                result.Detalle_Solicitud_Historial_de_Asignacioness = new List<Detalle_Solicitud_Historial_de_Asignaciones>();

            return Json(new
            {
                data = result.Detalle_Solicitud_Historial_de_Asignacioness.Select(m => new Detalle_Solicitud_Historial_de_AsignacionesGridModel
                    {
                    Folio = m.Folio
                        ,Fecha_cambio = (m.Fecha_cambio == null ? string.Empty : Convert.ToDateTime(m.Fecha_cambio).ToString(ConfigurationProperty.DateFormat))
			,Hora_cambio = m.Hora_cambio
                        ,UsuarioName = CultureHelper.GetTraduction(m.Usuario_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_Spartan_User.Name
                        ,Facilitador_AsignadoName = CultureHelper.GetTraduction(m.Facilitador_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Facilitador_Asignado_Spartan_User.Name
			,Motivo_cambio = m.Motivo_cambio

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_Solicitud_Historial_de_Asignaciones_Usuario_Spartan_User(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Spartan_User.Id_User as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Spartan_User.Name as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISpartan_UserApiConsumer.ListaSelAll(1, 20,elWhere , " Spartan_User.Name ASC ").Resource;
               
                foreach (var item in result.Spartan_Users)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                    item.Name =trans ??item.Name;
                }
                return Json(result.Spartan_Users.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_Solicitud_Historial_de_Asignaciones_Facilitador_Asignado_Spartan_User(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Spartan_User.Id_User as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Spartan_User.Name as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISpartan_UserApiConsumer.ListaSelAll(1, 20,elWhere , " Spartan_User.Name ASC ").Resource;
               
                foreach (var item in result.Spartan_Users)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                    item.Name =trans ??item.Name;
                }
                return Json(result.Spartan_Users.ToArray(), JsonRequestBehavior.AllowGet);
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
                _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Solicitud_Historial_de_Asignaciones varDetalle_Solicitud_Historial_de_Asignaciones = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Solicitud_Historial_de_AsignacionesModel varDetalle_Solicitud_Historial_de_Asignaciones)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Solicitud_Historial_de_AsignacionesInfo = new Detalle_Solicitud_Historial_de_Asignaciones
                    {
                        Folio = varDetalle_Solicitud_Historial_de_Asignaciones.Folio
                        ,Fecha_cambio = (!String.IsNullOrEmpty(varDetalle_Solicitud_Historial_de_Asignaciones.Fecha_cambio)) ? DateTime.ParseExact(varDetalle_Solicitud_Historial_de_Asignaciones.Fecha_cambio, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_cambio = varDetalle_Solicitud_Historial_de_Asignaciones.Hora_cambio
                        ,Usuario = varDetalle_Solicitud_Historial_de_Asignaciones.Usuario
                        ,Facilitador_Asignado = varDetalle_Solicitud_Historial_de_Asignaciones.Facilitador_Asignado
                        ,Motivo_cambio = varDetalle_Solicitud_Historial_de_Asignaciones.Motivo_cambio

                    };

                    result = !IsNew ?
                        _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.Update(Detalle_Solicitud_Historial_de_AsignacionesInfo, null, null).Resource.ToString() :
                         _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.Insert(Detalle_Solicitud_Historial_de_AsignacionesInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Solicitud_Historial_de_Asignaciones script
        /// </summary>
        /// <param name="oDetalle_Solicitud_Historial_de_AsignacionesElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Solicitud_Historial_de_AsignacionesScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Solicitud_Historial_de_Asignaciones.js")))
            {
                strDetalle_Solicitud_Historial_de_AsignacionesScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Solicitud_Historial_de_Asignaciones element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Solicitud_Historial_de_AsignacionesScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Solicitud_Historial_de_AsignacionesScript.Substring(indexOfArray, strDetalle_Solicitud_Historial_de_AsignacionesScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Solicitud_Historial_de_AsignacionesScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Solicitud_Historial_de_AsignacionesScript.Substring(indexOfArrayHistory, strDetalle_Solicitud_Historial_de_AsignacionesScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Solicitud_Historial_de_AsignacionesScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Solicitud_Historial_de_AsignacionesScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Solicitud_Historial_de_AsignacionesScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Solicitud_Historial_de_AsignacionesModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Solicitud_Historial_de_AsignacionesScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Solicitud_Historial_de_AsignacionesScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Solicitud_Historial_de_AsignacionesScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Solicitud_Historial_de_AsignacionesScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Solicitud_Historial_de_Asignaciones.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Solicitud_Historial_de_Asignaciones.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Solicitud_Historial_de_Asignaciones.js")))
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
        public ActionResult Detalle_Solicitud_Historial_de_AsignacionesPropertyBag()
        {
            return PartialView("Detalle_Solicitud_Historial_de_AsignacionesPropertyBag", "Detalle_Solicitud_Historial_de_Asignaciones");
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

            _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Solicitud_Historial_de_AsignacionesPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Solicitud_Historial_de_Asignacioness == null)
                result.Detalle_Solicitud_Historial_de_Asignacioness = new List<Detalle_Solicitud_Historial_de_Asignaciones>();

            var data = result.Detalle_Solicitud_Historial_de_Asignacioness.Select(m => new Detalle_Solicitud_Historial_de_AsignacionesGridModel
            {
                Folio = m.Folio
                ,Fecha_cambio = (m.Fecha_cambio == null ? string.Empty : Convert.ToDateTime(m.Fecha_cambio).ToString(ConfigurationProperty.DateFormat))
                ,Hora_cambio = m.Hora_cambio
                ,UsuarioName = (string)m.Usuario_Spartan_User.Name
                ,Facilitador_AsignadoName = (string)m.Facilitador_Asignado_Spartan_User.Name
                ,Motivo_cambio = m.Motivo_cambio

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Solicitud_Historial_de_AsignacionesList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Solicitud_Historial_de_AsignacionesList_" + DateTime.Now.ToString());
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

            _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Solicitud_Historial_de_AsignacionesPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Solicitud_Historial_de_AsignacionesApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Solicitud_Historial_de_Asignacioness == null)
                result.Detalle_Solicitud_Historial_de_Asignacioness = new List<Detalle_Solicitud_Historial_de_Asignaciones>();

            var data = result.Detalle_Solicitud_Historial_de_Asignacioness.Select(m => new Detalle_Solicitud_Historial_de_AsignacionesGridModel
            {
                Folio = m.Folio
                ,Fecha_cambio = (m.Fecha_cambio == null ? string.Empty : Convert.ToDateTime(m.Fecha_cambio).ToString(ConfigurationProperty.DateFormat))
                ,Hora_cambio = m.Hora_cambio
                ,UsuarioName = (string)m.Usuario_Spartan_User.Name
                ,Facilitador_AsignadoName = (string)m.Facilitador_Asignado_Spartan_User.Name
                ,Motivo_cambio = m.Motivo_cambio

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
