using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Servicio_de_Apoyo_MPI;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Solicitante_MPI;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Servicio_de_Apoyo_MPI;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Servicio_de_Apoyo_MPI;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Solicitante_MPI;

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
    public class Detalle_de_Servicio_de_Apoyo_MPIController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Servicio_de_Apoyo_MPIService service = null;
        private IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer;
        private ITipo_de_Servicio_de_ApoyoApiConsumer _ITipo_de_Servicio_de_ApoyoApiConsumer;
        private ISolicitante_MPIApiConsumer _ISolicitante_MPIApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_de_Servicio_de_Apoyo_MPIController(IDetalle_de_Servicio_de_Apoyo_MPIService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer Detalle_de_Servicio_de_Apoyo_MPIApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ITipo_de_Servicio_de_ApoyoApiConsumer Tipo_de_Servicio_de_ApoyoApiConsumer , ISolicitante_MPIApiConsumer Solicitante_MPIApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer = Detalle_de_Servicio_de_Apoyo_MPIApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ITipo_de_Servicio_de_ApoyoApiConsumer = Tipo_de_Servicio_de_ApoyoApiConsumer;
            this._ISolicitante_MPIApiConsumer = Solicitante_MPIApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Servicio_de_Apoyo_MPI
        [ObjectAuth(ObjectId = (ModuleObjectId)45122, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45122);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_de_Servicio_de_Apoyo_MPI/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45122, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45122);
            ViewBag.Permission = permission;
            var varDetalle_de_Servicio_de_Apoyo_MPI = new Detalle_de_Servicio_de_Apoyo_MPIModel();
			
            ViewBag.ObjectId = "45122";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Servicio_de_Apoyo_MPIData = _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.GetByKeyComplete(Id).Resource.Detalle_de_Servicio_de_Apoyo_MPIs[0];
                if (Detalle_de_Servicio_de_Apoyo_MPIData == null)
                    return HttpNotFound();

                varDetalle_de_Servicio_de_Apoyo_MPI = new Detalle_de_Servicio_de_Apoyo_MPIModel
                {
                    Clave = (int)Detalle_de_Servicio_de_Apoyo_MPIData.Clave
                    ,Tipo_de_Servicio = Detalle_de_Servicio_de_Apoyo_MPIData.Tipo_de_Servicio
                    ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_Apoyo_MPIData.Tipo_de_Servicio), "Tipo_de_Servicio_de_Apoyo") ??  (string)Detalle_de_Servicio_de_Apoyo_MPIData.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                    ,Dictamen = Detalle_de_Servicio_de_Apoyo_MPIData.Dictamen
                    ,Responsable = Detalle_de_Servicio_de_Apoyo_MPIData.Responsable
                    ,Victima = Detalle_de_Servicio_de_Apoyo_MPIData.Victima
                    ,VictimaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_Apoyo_MPIData.Victima), "Solicitante_MPI") ??  (string)Detalle_de_Servicio_de_Apoyo_MPIData.Victima_Solicitante_MPI.Nombre

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
            _ISolicitante_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Solicitante_MPIs_Victima = _ISolicitante_MPIApiConsumer.SelAll(true);
            if (Solicitante_MPIs_Victima != null && Solicitante_MPIs_Victima.Resource != null)
                ViewBag.Solicitante_MPIs_Victima = Solicitante_MPIs_Victima.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitante_MPI", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_de_Servicio_de_Apoyo_MPI);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Servicio_de_Apoyo_MPI(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45122);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Servicio_de_Apoyo_MPIModel varDetalle_de_Servicio_de_Apoyo_MPI= new Detalle_de_Servicio_de_Apoyo_MPIModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_Servicio_de_Apoyo_MPIsData = _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Servicio_de_Apoyo_MPI.Clave=" + id, "").Resource.Detalle_de_Servicio_de_Apoyo_MPIs;
				
				if (Detalle_de_Servicio_de_Apoyo_MPIsData != null && Detalle_de_Servicio_de_Apoyo_MPIsData.Count > 0)
                {
					var Detalle_de_Servicio_de_Apoyo_MPIData = Detalle_de_Servicio_de_Apoyo_MPIsData.First();
					varDetalle_de_Servicio_de_Apoyo_MPI= new Detalle_de_Servicio_de_Apoyo_MPIModel
					{
						Clave  = Detalle_de_Servicio_de_Apoyo_MPIData.Clave 
	                    ,Tipo_de_Servicio = Detalle_de_Servicio_de_Apoyo_MPIData.Tipo_de_Servicio
                    ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_Apoyo_MPIData.Tipo_de_Servicio), "Tipo_de_Servicio_de_Apoyo") ??  (string)Detalle_de_Servicio_de_Apoyo_MPIData.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                    ,Dictamen = Detalle_de_Servicio_de_Apoyo_MPIData.Dictamen
                    ,Responsable = Detalle_de_Servicio_de_Apoyo_MPIData.Responsable
                    ,Victima = Detalle_de_Servicio_de_Apoyo_MPIData.Victima
                    ,VictimaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_Apoyo_MPIData.Victima), "Solicitante_MPI") ??  (string)Detalle_de_Servicio_de_Apoyo_MPIData.Victima_Solicitante_MPI.Nombre

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
            _ISolicitante_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Solicitante_MPIs_Victima = _ISolicitante_MPIApiConsumer.SelAll(true);
            if (Solicitante_MPIs_Victima != null && Solicitante_MPIs_Victima.Resource != null)
                ViewBag.Solicitante_MPIs_Victima = Solicitante_MPIs_Victima.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitante_MPI", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Servicio_de_Apoyo_MPI", varDetalle_de_Servicio_de_Apoyo_MPI);
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
        public ActionResult GetSolicitante_MPIAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitante_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitante_MPIApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitante_MPI", "Nombre")?? m.Nombre,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Servicio_de_Apoyo_MPIPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Servicio_de_Apoyo_MPIs == null)
                result.Detalle_de_Servicio_de_Apoyo_MPIs = new List<Detalle_de_Servicio_de_Apoyo_MPI>();

            return Json(new
            {
                data = result.Detalle_de_Servicio_de_Apoyo_MPIs.Select(m => new Detalle_de_Servicio_de_Apoyo_MPIGridModel
                    {
                    Clave = m.Clave
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Dictamen = m.Dictamen
			,Responsable = m.Responsable
                        ,VictimaNombre = CultureHelper.GetTraduction(m.Victima_Solicitante_MPI.Clave.ToString(), "Nombre") ?? (string)m.Victima_Solicitante_MPI.Nombre

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
                _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Servicio_de_Apoyo_MPI varDetalle_de_Servicio_de_Apoyo_MPI = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Servicio_de_Apoyo_MPIModel varDetalle_de_Servicio_de_Apoyo_MPI)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_Servicio_de_Apoyo_MPIInfo = new Detalle_de_Servicio_de_Apoyo_MPI
                    {
                        Clave = varDetalle_de_Servicio_de_Apoyo_MPI.Clave
                        ,Tipo_de_Servicio = varDetalle_de_Servicio_de_Apoyo_MPI.Tipo_de_Servicio
                        ,Dictamen = varDetalle_de_Servicio_de_Apoyo_MPI.Dictamen
                        ,Responsable = varDetalle_de_Servicio_de_Apoyo_MPI.Responsable
                        ,Victima = varDetalle_de_Servicio_de_Apoyo_MPI.Victima

                    };

                    result = !IsNew ?
                        _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.Update(Detalle_de_Servicio_de_Apoyo_MPIInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.Insert(Detalle_de_Servicio_de_Apoyo_MPIInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_de_Servicio_de_Apoyo_MPI script
        /// </summary>
        /// <param name="oDetalle_de_Servicio_de_Apoyo_MPIElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_de_Servicio_de_Apoyo_MPIScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Servicio_de_Apoyo_MPI.js")))
            {
                strDetalle_de_Servicio_de_Apoyo_MPIScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Servicio_de_Apoyo_MPI element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Servicio_de_Apoyo_MPIScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Servicio_de_Apoyo_MPIScript.Substring(indexOfArray, strDetalle_de_Servicio_de_Apoyo_MPIScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Servicio_de_Apoyo_MPIScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_de_Servicio_de_Apoyo_MPIScript.Substring(indexOfArrayHistory, strDetalle_de_Servicio_de_Apoyo_MPIScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_de_Servicio_de_Apoyo_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Servicio_de_Apoyo_MPIScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Servicio_de_Apoyo_MPIScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_de_Servicio_de_Apoyo_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_de_Servicio_de_Apoyo_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_de_Servicio_de_Apoyo_MPIScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_de_Servicio_de_Apoyo_MPIScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_de_Servicio_de_Apoyo_MPIScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Servicio_de_Apoyo_MPI.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Servicio_de_Apoyo_MPI.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Servicio_de_Apoyo_MPI.js")))
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
        public ActionResult Detalle_de_Servicio_de_Apoyo_MPIPropertyBag()
        {
            return PartialView("Detalle_de_Servicio_de_Apoyo_MPIPropertyBag", "Detalle_de_Servicio_de_Apoyo_MPI");
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

            _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Servicio_de_Apoyo_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Servicio_de_Apoyo_MPIs == null)
                result.Detalle_de_Servicio_de_Apoyo_MPIs = new List<Detalle_de_Servicio_de_Apoyo_MPI>();

            var data = result.Detalle_de_Servicio_de_Apoyo_MPIs.Select(m => new Detalle_de_Servicio_de_Apoyo_MPIGridModel
            {
                Clave = m.Clave
                ,Tipo_de_ServicioServicio = (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                ,Dictamen = m.Dictamen
                ,Responsable = m.Responsable
                ,VictimaNombre = (string)m.Victima_Solicitante_MPI.Nombre

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_de_Servicio_de_Apoyo_MPIList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_de_Servicio_de_Apoyo_MPIList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Servicio_de_Apoyo_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Servicio_de_Apoyo_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Servicio_de_Apoyo_MPIs == null)
                result.Detalle_de_Servicio_de_Apoyo_MPIs = new List<Detalle_de_Servicio_de_Apoyo_MPI>();

            var data = result.Detalle_de_Servicio_de_Apoyo_MPIs.Select(m => new Detalle_de_Servicio_de_Apoyo_MPIGridModel
            {
                Clave = m.Clave
                ,Tipo_de_ServicioServicio = (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                ,Dictamen = m.Dictamen
                ,Responsable = m.Responsable
                ,VictimaNombre = (string)m.Victima_Solicitante_MPI.Nombre

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
