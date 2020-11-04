using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Sentencias_Imputado_MPI;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Sentencia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Sentencias_Imputado_MPI;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Sentencias_Imputado_MPI;
using Spartane.Web.Areas.WebApiConsumer.Delito;
using Spartane.Web.Areas.WebApiConsumer.Sentencia;

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
    public class Detalle_de_Sentencias_Imputado_MPIController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Sentencias_Imputado_MPIService service = null;
        private IDetalle_de_Sentencias_Imputado_MPIApiConsumer _IDetalle_de_Sentencias_Imputado_MPIApiConsumer;
        private IDelitoApiConsumer _IDelitoApiConsumer;
        private ISentenciaApiConsumer _ISentenciaApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_de_Sentencias_Imputado_MPIController(IDetalle_de_Sentencias_Imputado_MPIService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Sentencias_Imputado_MPIApiConsumer Detalle_de_Sentencias_Imputado_MPIApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IDelitoApiConsumer DelitoApiConsumer , ISentenciaApiConsumer SentenciaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Sentencias_Imputado_MPIApiConsumer = Detalle_de_Sentencias_Imputado_MPIApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IDelitoApiConsumer = DelitoApiConsumer;
            this._ISentenciaApiConsumer = SentenciaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Sentencias_Imputado_MPI
        [ObjectAuth(ObjectId = (ModuleObjectId)45180, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45180);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_de_Sentencias_Imputado_MPI/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45180, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45180);
            ViewBag.Permission = permission;
            var varDetalle_de_Sentencias_Imputado_MPI = new Detalle_de_Sentencias_Imputado_MPIModel();
			
            ViewBag.ObjectId = "45180";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Sentencias_Imputado_MPIData = _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.GetByKeyComplete(Id).Resource.Detalle_de_Sentencias_Imputado_MPIs[0];
                if (Detalle_de_Sentencias_Imputado_MPIData == null)
                    return HttpNotFound();

                varDetalle_de_Sentencias_Imputado_MPI = new Detalle_de_Sentencias_Imputado_MPIModel
                {
                    Clave = (int)Detalle_de_Sentencias_Imputado_MPIData.Clave
                    ,Delito = Detalle_de_Sentencias_Imputado_MPIData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Sentencias_Imputado_MPIData.Delito), "Delito") ??  (string)Detalle_de_Sentencias_Imputado_MPIData.Delito_Delito.Descripcion
                    ,Sentencia = Detalle_de_Sentencias_Imputado_MPIData.Sentencia
                    ,SentenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Sentencias_Imputado_MPIData.Sentencia), "Sentencia") ??  (string)Detalle_de_Sentencias_Imputado_MPIData.Sentencia_Sentencia.Descripcion
                    ,Fecha_de_Devolucion = (Detalle_de_Sentencias_Imputado_MPIData.Fecha_de_Devolucion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Sentencias_Imputado_MPIData.Fecha_de_Devolucion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Devolucion = Detalle_de_Sentencias_Imputado_MPIData.Hora_de_Devolucion
                    ,Repacion_del_Dano = Detalle_de_Sentencias_Imputado_MPIData.Repacion_del_Dano
                    ,Resolucion = Detalle_de_Sentencias_Imputado_MPIData.Resolucion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sentencias_Sentencia = _ISentenciaApiConsumer.SelAll(true);
            if (Sentencias_Sentencia != null && Sentencias_Sentencia.Resource != null)
                ViewBag.Sentencias_Sentencia = Sentencias_Sentencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_de_Sentencias_Imputado_MPI);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Sentencias_Imputado_MPI(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45180);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Sentencias_Imputado_MPIModel varDetalle_de_Sentencias_Imputado_MPI= new Detalle_de_Sentencias_Imputado_MPIModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_Sentencias_Imputado_MPIsData = _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Sentencias_Imputado_MPI.Clave=" + id, "").Resource.Detalle_de_Sentencias_Imputado_MPIs;
				
				if (Detalle_de_Sentencias_Imputado_MPIsData != null && Detalle_de_Sentencias_Imputado_MPIsData.Count > 0)
                {
					var Detalle_de_Sentencias_Imputado_MPIData = Detalle_de_Sentencias_Imputado_MPIsData.First();
					varDetalle_de_Sentencias_Imputado_MPI= new Detalle_de_Sentencias_Imputado_MPIModel
					{
						Clave  = Detalle_de_Sentencias_Imputado_MPIData.Clave 
	                    ,Delito = Detalle_de_Sentencias_Imputado_MPIData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Sentencias_Imputado_MPIData.Delito), "Delito") ??  (string)Detalle_de_Sentencias_Imputado_MPIData.Delito_Delito.Descripcion
                    ,Sentencia = Detalle_de_Sentencias_Imputado_MPIData.Sentencia
                    ,SentenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Sentencias_Imputado_MPIData.Sentencia), "Sentencia") ??  (string)Detalle_de_Sentencias_Imputado_MPIData.Sentencia_Sentencia.Descripcion
                    ,Fecha_de_Devolucion = (Detalle_de_Sentencias_Imputado_MPIData.Fecha_de_Devolucion == null ? string.Empty : Convert.ToDateTime(Detalle_de_Sentencias_Imputado_MPIData.Fecha_de_Devolucion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Devolucion = Detalle_de_Sentencias_Imputado_MPIData.Hora_de_Devolucion
                    ,Repacion_del_Dano = Detalle_de_Sentencias_Imputado_MPIData.Repacion_del_Dano
                    ,Resolucion = Detalle_de_Sentencias_Imputado_MPIData.Resolucion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sentencias_Sentencia = _ISentenciaApiConsumer.SelAll(true);
            if (Sentencias_Sentencia != null && Sentencias_Sentencia.Resource != null)
                ViewBag.Sentencias_Sentencia = Sentencias_Sentencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Sentencias_Imputado_MPI", varDetalle_de_Sentencias_Imputado_MPI);
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
        public ActionResult GetSentenciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISentenciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISentenciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sentencia", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Sentencias_Imputado_MPIPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Sentencias_Imputado_MPIs == null)
                result.Detalle_de_Sentencias_Imputado_MPIs = new List<Detalle_de_Sentencias_Imputado_MPI>();

            return Json(new
            {
                data = result.Detalle_de_Sentencias_Imputado_MPIs.Select(m => new Detalle_de_Sentencias_Imputado_MPIGridModel
                    {
                    Clave = m.Clave
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
                        ,SentenciaDescripcion = CultureHelper.GetTraduction(m.Sentencia_Sentencia.Clave.ToString(), "Descripcion") ?? (string)m.Sentencia_Sentencia.Descripcion
                        ,Fecha_de_Devolucion = (m.Fecha_de_Devolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Devolucion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Devolucion = m.Hora_de_Devolucion
			,Repacion_del_Dano = m.Repacion_del_Dano
			,Resolucion = m.Resolucion

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
                _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Sentencias_Imputado_MPI varDetalle_de_Sentencias_Imputado_MPI = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Sentencias_Imputado_MPIModel varDetalle_de_Sentencias_Imputado_MPI)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_Sentencias_Imputado_MPIInfo = new Detalle_de_Sentencias_Imputado_MPI
                    {
                        Clave = varDetalle_de_Sentencias_Imputado_MPI.Clave
                        ,Delito = varDetalle_de_Sentencias_Imputado_MPI.Delito
                        ,Sentencia = varDetalle_de_Sentencias_Imputado_MPI.Sentencia
                        ,Fecha_de_Devolucion = (!String.IsNullOrEmpty(varDetalle_de_Sentencias_Imputado_MPI.Fecha_de_Devolucion)) ? DateTime.ParseExact(varDetalle_de_Sentencias_Imputado_MPI.Fecha_de_Devolucion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Devolucion = varDetalle_de_Sentencias_Imputado_MPI.Hora_de_Devolucion
                        ,Repacion_del_Dano = varDetalle_de_Sentencias_Imputado_MPI.Repacion_del_Dano
                        ,Resolucion = varDetalle_de_Sentencias_Imputado_MPI.Resolucion

                    };

                    result = !IsNew ?
                        _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.Update(Detalle_de_Sentencias_Imputado_MPIInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.Insert(Detalle_de_Sentencias_Imputado_MPIInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_de_Sentencias_Imputado_MPI script
        /// </summary>
        /// <param name="oDetalle_de_Sentencias_Imputado_MPIElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_de_Sentencias_Imputado_MPIModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_de_Sentencias_Imputado_MPIScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Sentencias_Imputado_MPI.js")))
            {
                strDetalle_de_Sentencias_Imputado_MPIScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Sentencias_Imputado_MPI element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Sentencias_Imputado_MPIScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Sentencias_Imputado_MPIScript.Substring(indexOfArray, strDetalle_de_Sentencias_Imputado_MPIScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Sentencias_Imputado_MPIScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_de_Sentencias_Imputado_MPIScript.Substring(indexOfArrayHistory, strDetalle_de_Sentencias_Imputado_MPIScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_de_Sentencias_Imputado_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Sentencias_Imputado_MPIScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Sentencias_Imputado_MPIScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_de_Sentencias_Imputado_MPIModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_de_Sentencias_Imputado_MPIScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_de_Sentencias_Imputado_MPIScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_de_Sentencias_Imputado_MPIScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_de_Sentencias_Imputado_MPIScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Sentencias_Imputado_MPI.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Sentencias_Imputado_MPI.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Sentencias_Imputado_MPI.js")))
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
        public ActionResult Detalle_de_Sentencias_Imputado_MPIPropertyBag()
        {
            return PartialView("Detalle_de_Sentencias_Imputado_MPIPropertyBag", "Detalle_de_Sentencias_Imputado_MPI");
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

            _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Sentencias_Imputado_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Sentencias_Imputado_MPIs == null)
                result.Detalle_de_Sentencias_Imputado_MPIs = new List<Detalle_de_Sentencias_Imputado_MPI>();

            var data = result.Detalle_de_Sentencias_Imputado_MPIs.Select(m => new Detalle_de_Sentencias_Imputado_MPIGridModel
            {
                Clave = m.Clave
                ,DelitoDescripcion = (string)m.Delito_Delito.Descripcion
                ,SentenciaDescripcion = (string)m.Sentencia_Sentencia.Descripcion
                ,Fecha_de_Devolucion = (m.Fecha_de_Devolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Devolucion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Devolucion = m.Hora_de_Devolucion
                ,Repacion_del_Dano = m.Repacion_del_Dano
                ,Resolucion = m.Resolucion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_de_Sentencias_Imputado_MPIList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_de_Sentencias_Imputado_MPIList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Sentencias_Imputado_MPIPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Sentencias_Imputado_MPIApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Sentencias_Imputado_MPIs == null)
                result.Detalle_de_Sentencias_Imputado_MPIs = new List<Detalle_de_Sentencias_Imputado_MPI>();

            var data = result.Detalle_de_Sentencias_Imputado_MPIs.Select(m => new Detalle_de_Sentencias_Imputado_MPIGridModel
            {
                Clave = m.Clave
                ,DelitoDescripcion = (string)m.Delito_Delito.Descripcion
                ,SentenciaDescripcion = (string)m.Sentencia_Sentencia.Descripcion
                ,Fecha_de_Devolucion = (m.Fecha_de_Devolucion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Devolucion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Devolucion = m.Hora_de_Devolucion
                ,Repacion_del_Dano = m.Repacion_del_Dano
                ,Resolucion = m.Resolucion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
