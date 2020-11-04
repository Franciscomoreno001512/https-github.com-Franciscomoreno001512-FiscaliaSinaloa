using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Compareciente;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Solicitud_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Compareciente;

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
    public class Solicitud_de_Servicios_de_ApoyoController : Controller
    {
        #region "variable declaration"

        private ISolicitud_de_Servicios_de_ApoyoService service = null;
        private ISolicitud_de_Servicios_de_ApoyoApiConsumer _ISolicitud_de_Servicios_de_ApoyoApiConsumer;
        private ITipo_de_Servicio_de_ApoyoApiConsumer _ITipo_de_Servicio_de_ApoyoApiConsumer;
        private IComparecienteApiConsumer _IComparecienteApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Solicitud_de_Servicios_de_ApoyoController(ISolicitud_de_Servicios_de_ApoyoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ISolicitud_de_Servicios_de_ApoyoApiConsumer Solicitud_de_Servicios_de_ApoyoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ITipo_de_Servicio_de_ApoyoApiConsumer Tipo_de_Servicio_de_ApoyoApiConsumer , IComparecienteApiConsumer ComparecienteApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ISolicitud_de_Servicios_de_ApoyoApiConsumer = Solicitud_de_Servicios_de_ApoyoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ITipo_de_Servicio_de_ApoyoApiConsumer = Tipo_de_Servicio_de_ApoyoApiConsumer;
            this._IComparecienteApiConsumer = ComparecienteApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Solicitud_de_Servicios_de_Apoyo
        [ObjectAuth(ObjectId = (ModuleObjectId)45042, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45042);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Solicitud_de_Servicios_de_Apoyo/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45042, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45042);
            ViewBag.Permission = permission;
            var varSolicitud_de_Servicios_de_Apoyo = new Solicitud_de_Servicios_de_ApoyoModel();
			
            ViewBag.ObjectId = "45042";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Solicitud_de_Servicios_de_ApoyoData = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.GetByKeyComplete(Id).Resource.Solicitud_de_Servicios_de_Apoyos[0];
                if (Solicitud_de_Servicios_de_ApoyoData == null)
                    return HttpNotFound();

                varSolicitud_de_Servicios_de_Apoyo = new Solicitud_de_Servicios_de_ApoyoModel
                {
                    Clave = (int)Solicitud_de_Servicios_de_ApoyoData.Clave
                    ,Tipo_de_Servicio = Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Servicio
                    ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Servicio), "Tipo_de_Servicio_de_Apoyo") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                    ,Dictamen = Solicitud_de_Servicios_de_ApoyoData.Dictamen
                    ,Responsable = Solicitud_de_Servicios_de_ApoyoData.Responsable
                    ,Clave_MR = Solicitud_de_Servicios_de_ApoyoData.Clave_MR
                    ,Compareciente = Solicitud_de_Servicios_de_ApoyoData.Compareciente
                    ,ComparecienteNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Compareciente), "Compareciente") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Compareciente_Compareciente.Nombre_Completo

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio != null && Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Comparecientes_Compareciente = _IComparecienteApiConsumer.SelAll(true);
            if (Comparecientes_Compareciente != null && Comparecientes_Compareciente.Resource != null)
                ViewBag.Comparecientes_Compareciente = Comparecientes_Compareciente.Resource.Where(m => m.Nombre_Completo != null).OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Compareciente", "Nombre_Completo") ?? m.Nombre_Completo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varSolicitud_de_Servicios_de_Apoyo);
        }
		
	[HttpGet]
        public ActionResult AddSolicitud_de_Servicios_de_Apoyo(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45042);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Solicitud_de_Servicios_de_ApoyoModel varSolicitud_de_Servicios_de_Apoyo= new Solicitud_de_Servicios_de_ApoyoModel();


            if (id.ToString() != "0")
            {
                var Solicitud_de_Servicios_de_ApoyosData = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.ListaSelAll(0, 1000, "Solicitud_de_Servicios_de_Apoyo.Clave=" + id, "").Resource.Solicitud_de_Servicios_de_Apoyos;
				
				if (Solicitud_de_Servicios_de_ApoyosData != null && Solicitud_de_Servicios_de_ApoyosData.Count > 0)
                {
					var Solicitud_de_Servicios_de_ApoyoData = Solicitud_de_Servicios_de_ApoyosData.First();
					varSolicitud_de_Servicios_de_Apoyo= new Solicitud_de_Servicios_de_ApoyoModel
					{
						Clave  = Solicitud_de_Servicios_de_ApoyoData.Clave 
	                    ,Tipo_de_Servicio = Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Servicio
                    ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Servicio), "Tipo_de_Servicio_de_Apoyo") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                    ,Dictamen = Solicitud_de_Servicios_de_ApoyoData.Dictamen
                    ,Responsable = Solicitud_de_Servicios_de_ApoyoData.Responsable
                    ,Clave_MR = Solicitud_de_Servicios_de_ApoyoData.Clave_MR
                    ,Compareciente = Solicitud_de_Servicios_de_ApoyoData.Compareciente
                    ,ComparecienteNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Compareciente), "Compareciente") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Compareciente_Compareciente.Nombre_Completo

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio != null && Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Comparecientes_Compareciente = _IComparecienteApiConsumer.SelAll(true);
            if (Comparecientes_Compareciente != null && Comparecientes_Compareciente.Resource != null)
                ViewBag.Comparecientes_Compareciente = Comparecientes_Compareciente.Resource.Where(m => m.Nombre_Completo != null).OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Compareciente", "Nombre_Completo") ?? m.Nombre_Completo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddSolicitud_de_Servicios_de_Apoyo", varSolicitud_de_Servicios_de_Apoyo);
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
        public ActionResult GetTipo_de_Servicio_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio")?? m.Servicio,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetComparecienteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IComparecienteApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Compareciente", "Nombre_Completo")?? m.Nombre_Completo,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Solicitud_de_Servicios_de_ApoyoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Servicios_de_Apoyos == null)
                result.Solicitud_de_Servicios_de_Apoyos = new List<Solicitud_de_Servicios_de_Apoyo>();

            return Json(new
            {
                data = result.Solicitud_de_Servicios_de_Apoyos.Select(m => new Solicitud_de_Servicios_de_ApoyoGridModel
                    {
                    Clave = m.Clave
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Dictamen = m.Dictamen
			,Responsable = m.Responsable
			,Clave_MR = m.Clave_MR
                        ,ComparecienteNombre_Completo = CultureHelper.GetTraduction(m.Compareciente_Compareciente.Clave.ToString(), "Nombre_Completo") ?? (string)m.Compareciente_Compareciente.Nombre_Completo

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
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Solicitud_de_Servicios_de_Apoyo varSolicitud_de_Servicios_de_Apoyo = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Solicitud_de_Servicios_de_ApoyoModel varSolicitud_de_Servicios_de_Apoyo)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Solicitud_de_Servicios_de_ApoyoInfo = new Solicitud_de_Servicios_de_Apoyo
                    {
                        Clave = varSolicitud_de_Servicios_de_Apoyo.Clave
                        ,Tipo_de_Servicio = varSolicitud_de_Servicios_de_Apoyo.Tipo_de_Servicio
                        ,Dictamen = varSolicitud_de_Servicios_de_Apoyo.Dictamen
                        ,Responsable = varSolicitud_de_Servicios_de_Apoyo.Responsable
                        ,Clave_MR = varSolicitud_de_Servicios_de_Apoyo.Clave_MR
                        ,Compareciente = varSolicitud_de_Servicios_de_Apoyo.Compareciente

                    };

                    result = !IsNew ?
                        _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Update(Solicitud_de_Servicios_de_ApoyoInfo, null, null).Resource.ToString() :
                         _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Insert(Solicitud_de_Servicios_de_ApoyoInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Solicitud_de_Servicios_de_Apoyo script
        /// </summary>
        /// <param name="oSolicitud_de_Servicios_de_ApoyoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Solicitud_de_Servicios_de_ApoyoModuleAttributeList)
        {
            for (int i = 0; i < Solicitud_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Solicitud_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Solicitud_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Solicitud_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Solicitud_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strSolicitud_de_Servicios_de_ApoyoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Servicios_de_Apoyo.js")))
            {
                strSolicitud_de_Servicios_de_ApoyoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Solicitud_de_Servicios_de_Apoyo element attributes
            string userChangeJson = jsSerialize.Serialize(Solicitud_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strSolicitud_de_Servicios_de_ApoyoScript.IndexOf("inpuElementArray");
            string splittedString = strSolicitud_de_Servicios_de_ApoyoScript.Substring(indexOfArray, strSolicitud_de_Servicios_de_ApoyoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strSolicitud_de_Servicios_de_ApoyoScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strSolicitud_de_Servicios_de_ApoyoScript.Substring(indexOfArrayHistory, strSolicitud_de_Servicios_de_ApoyoScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strSolicitud_de_Servicios_de_ApoyoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strSolicitud_de_Servicios_de_ApoyoScript.Substring(endIndexOfMainElement + indexOfArray, strSolicitud_de_Servicios_de_ApoyoScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strSolicitud_de_Servicios_de_ApoyoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strSolicitud_de_Servicios_de_ApoyoScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strSolicitud_de_Servicios_de_ApoyoScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strSolicitud_de_Servicios_de_ApoyoScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Servicios_de_Apoyo.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Servicios_de_Apoyo.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Servicios_de_Apoyo.js")))
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
        public ActionResult Solicitud_de_Servicios_de_ApoyoPropertyBag()
        {
            return PartialView("Solicitud_de_Servicios_de_ApoyoPropertyBag", "Solicitud_de_Servicios_de_Apoyo");
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

            _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Solicitud_de_Servicios_de_ApoyoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Servicios_de_Apoyos == null)
                result.Solicitud_de_Servicios_de_Apoyos = new List<Solicitud_de_Servicios_de_Apoyo>();

            var data = result.Solicitud_de_Servicios_de_Apoyos.Select(m => new Solicitud_de_Servicios_de_ApoyoGridModel
            {
                Clave = m.Clave
                ,Tipo_de_ServicioServicio = (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                ,Dictamen = m.Dictamen
                ,Responsable = m.Responsable
                ,Clave_MR = m.Clave_MR
                ,ComparecienteNombre_Completo = (string)m.Compareciente_Compareciente.Nombre_Completo

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Solicitud_de_Servicios_de_ApoyoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Solicitud_de_Servicios_de_ApoyoList_" + DateTime.Now.ToString());
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

            _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Solicitud_de_Servicios_de_ApoyoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Servicios_de_Apoyos == null)
                result.Solicitud_de_Servicios_de_Apoyos = new List<Solicitud_de_Servicios_de_Apoyo>();

            var data = result.Solicitud_de_Servicios_de_Apoyos.Select(m => new Solicitud_de_Servicios_de_ApoyoGridModel
            {
                Clave = m.Clave
                ,Tipo_de_ServicioServicio = (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                ,Dictamen = m.Dictamen
                ,Responsable = m.Responsable
                ,Clave_MR = m.Clave_MR
                ,ComparecienteNombre_Completo = (string)m.Compareciente_Compareciente.Nombre_Completo

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
