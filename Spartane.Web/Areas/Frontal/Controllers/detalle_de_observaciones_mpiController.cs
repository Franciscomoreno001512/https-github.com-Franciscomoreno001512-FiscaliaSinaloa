using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.detalle_de_observaciones_mpi;
using Spartane.Core.Domain.Spartan_User;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.detalle_de_observaciones_mpi;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.detalle_de_observaciones_mpi;
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
    public class detalle_de_observaciones_mpiController : Controller
    {
        #region "variable declaration"

        private Idetalle_de_observaciones_mpiService service = null;
        private Idetalle_de_observaciones_mpiApiConsumer _Idetalle_de_observaciones_mpiApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public detalle_de_observaciones_mpiController(Idetalle_de_observaciones_mpiService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, Idetalle_de_observaciones_mpiApiConsumer detalle_de_observaciones_mpiApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._Idetalle_de_observaciones_mpiApiConsumer = detalle_de_observaciones_mpiApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/detalle_de_observaciones_mpi
        [ObjectAuth(ObjectId = (ModuleObjectId)45469, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45469);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/detalle_de_observaciones_mpi/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45469, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45469);
            ViewBag.Permission = permission;
            var vardetalle_de_observaciones_mpi = new detalle_de_observaciones_mpiModel();
			
            ViewBag.ObjectId = "45469";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Idetalle_de_observaciones_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);
                var detalle_de_observaciones_mpiData = _Idetalle_de_observaciones_mpiApiConsumer.GetByKeyComplete(Id).Resource.detalle_de_observaciones_mpis[0];
                if (detalle_de_observaciones_mpiData == null)
                    return HttpNotFound();

                vardetalle_de_observaciones_mpi = new detalle_de_observaciones_mpiModel
                {
                    clave = (int)detalle_de_observaciones_mpiData.clave
                    ,observaciones = detalle_de_observaciones_mpiData.observaciones
                    ,fecha = (detalle_de_observaciones_mpiData.fecha == null ? string.Empty : Convert.ToDateTime(detalle_de_observaciones_mpiData.fecha).ToString(ConfigurationProperty.DateFormat))
                    ,hora = detalle_de_observaciones_mpiData.hora
                    ,usuario_que_realiza_observacion = detalle_de_observaciones_mpiData.usuario_que_realiza_observacion
                    ,usuario_que_realiza_observacionName = CultureHelper.GetTraduction(Convert.ToString(detalle_de_observaciones_mpiData.usuario_que_realiza_observacion), "Spartan_User") ??  (string)detalle_de_observaciones_mpiData.usuario_que_realiza_observacion_Spartan_User.Name

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_usuario_que_realiza_observacion = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_usuario_que_realiza_observacion != null && Spartan_Users_usuario_que_realiza_observacion.Resource != null)
                ViewBag.Spartan_Users_usuario_que_realiza_observacion = Spartan_Users_usuario_que_realiza_observacion.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(vardetalle_de_observaciones_mpi);
        }
		
	[HttpGet]
        public ActionResult Adddetalle_de_observaciones_mpi(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45469);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _Idetalle_de_observaciones_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);
			detalle_de_observaciones_mpiModel vardetalle_de_observaciones_mpi= new detalle_de_observaciones_mpiModel();


            if (id.ToString() != "0")
            {
                var detalle_de_observaciones_mpisData = _Idetalle_de_observaciones_mpiApiConsumer.ListaSelAll(0, 1000, "detalle_de_observaciones_mpi.clave=" + id, "").Resource.detalle_de_observaciones_mpis;
				
				if (detalle_de_observaciones_mpisData != null && detalle_de_observaciones_mpisData.Count > 0)
                {
					var detalle_de_observaciones_mpiData = detalle_de_observaciones_mpisData.First();
					vardetalle_de_observaciones_mpi= new detalle_de_observaciones_mpiModel
					{
						clave  = detalle_de_observaciones_mpiData.clave 
	                    ,observaciones = detalle_de_observaciones_mpiData.observaciones
                    ,fecha = (detalle_de_observaciones_mpiData.fecha == null ? string.Empty : Convert.ToDateTime(detalle_de_observaciones_mpiData.fecha).ToString(ConfigurationProperty.DateFormat))
                    ,hora = detalle_de_observaciones_mpiData.hora
                    ,usuario_que_realiza_observacion = detalle_de_observaciones_mpiData.usuario_que_realiza_observacion
                    ,usuario_que_realiza_observacionName = CultureHelper.GetTraduction(Convert.ToString(detalle_de_observaciones_mpiData.usuario_que_realiza_observacion), "Spartan_User") ??  (string)detalle_de_observaciones_mpiData.usuario_que_realiza_observacion_Spartan_User.Name

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_usuario_que_realiza_observacion = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_usuario_que_realiza_observacion != null && Spartan_Users_usuario_que_realiza_observacion.Resource != null)
                ViewBag.Spartan_Users_usuario_que_realiza_observacion = Spartan_Users_usuario_que_realiza_observacion.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();


            return PartialView("Adddetalle_de_observaciones_mpi", vardetalle_de_observaciones_mpi);
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
                configuration = GridQueryHelper.GetConfiguration(filter, new detalle_de_observaciones_mpiPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _Idetalle_de_observaciones_mpiApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.detalle_de_observaciones_mpis == null)
                result.detalle_de_observaciones_mpis = new List<detalle_de_observaciones_mpi>();

            return Json(new
            {
                data = result.detalle_de_observaciones_mpis.Select(m => new detalle_de_observaciones_mpiGridModel
                    {
                    clave = m.clave
			,observaciones = m.observaciones
                        ,fecha = (m.fecha == null ? string.Empty : Convert.ToDateTime(m.fecha).ToString(ConfigurationProperty.DateFormat))
			,hora = m.hora
                        ,usuario_que_realiza_observacionName = CultureHelper.GetTraduction(m.usuario_que_realiza_observacion_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.usuario_que_realiza_observacion_Spartan_User.Name

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
                _Idetalle_de_observaciones_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);

                detalle_de_observaciones_mpi vardetalle_de_observaciones_mpi = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _Idetalle_de_observaciones_mpiApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, detalle_de_observaciones_mpiModel vardetalle_de_observaciones_mpi)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _Idetalle_de_observaciones_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var detalle_de_observaciones_mpiInfo = new detalle_de_observaciones_mpi
                    {
                        clave = vardetalle_de_observaciones_mpi.clave
                        ,observaciones = vardetalle_de_observaciones_mpi.observaciones
                        ,fecha = (!String.IsNullOrEmpty(vardetalle_de_observaciones_mpi.fecha)) ? DateTime.ParseExact(vardetalle_de_observaciones_mpi.fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,hora = vardetalle_de_observaciones_mpi.hora
                        ,usuario_que_realiza_observacion = vardetalle_de_observaciones_mpi.usuario_que_realiza_observacion

                    };

                    result = !IsNew ?
                        _Idetalle_de_observaciones_mpiApiConsumer.Update(detalle_de_observaciones_mpiInfo, null, null).Resource.ToString() :
                         _Idetalle_de_observaciones_mpiApiConsumer.Insert(detalle_de_observaciones_mpiInfo, null, null).Resource.ToString();

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
        /// Write Element Array of detalle_de_observaciones_mpi script
        /// </summary>
        /// <param name="odetalle_de_observaciones_mpiElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements detalle_de_observaciones_mpiModuleAttributeList)
        {
            for (int i = 0; i < detalle_de_observaciones_mpiModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(detalle_de_observaciones_mpiModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    detalle_de_observaciones_mpiModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(detalle_de_observaciones_mpiModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    detalle_de_observaciones_mpiModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (detalle_de_observaciones_mpiModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < detalle_de_observaciones_mpiModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(detalle_de_observaciones_mpiModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						detalle_de_observaciones_mpiModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(detalle_de_observaciones_mpiModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						detalle_de_observaciones_mpiModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strdetalle_de_observaciones_mpiScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/detalle_de_observaciones_mpi.js")))
            {
                strdetalle_de_observaciones_mpiScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change detalle_de_observaciones_mpi element attributes
            string userChangeJson = jsSerialize.Serialize(detalle_de_observaciones_mpiModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strdetalle_de_observaciones_mpiScript.IndexOf("inpuElementArray");
            string splittedString = strdetalle_de_observaciones_mpiScript.Substring(indexOfArray, strdetalle_de_observaciones_mpiScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(detalle_de_observaciones_mpiModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (detalle_de_observaciones_mpiModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strdetalle_de_observaciones_mpiScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strdetalle_de_observaciones_mpiScript.Substring(indexOfArrayHistory, strdetalle_de_observaciones_mpiScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strdetalle_de_observaciones_mpiScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strdetalle_de_observaciones_mpiScript.Substring(endIndexOfMainElement + indexOfArray, strdetalle_de_observaciones_mpiScript.Length - (endIndexOfMainElement + indexOfArray));
            if (detalle_de_observaciones_mpiModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strdetalle_de_observaciones_mpiScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strdetalle_de_observaciones_mpiScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strdetalle_de_observaciones_mpiScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strdetalle_de_observaciones_mpiScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/detalle_de_observaciones_mpi.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/detalle_de_observaciones_mpi.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/detalle_de_observaciones_mpi.js")))
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
        public ActionResult detalle_de_observaciones_mpiPropertyBag()
        {
            return PartialView("detalle_de_observaciones_mpiPropertyBag", "detalle_de_observaciones_mpi");
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

            _Idetalle_de_observaciones_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new detalle_de_observaciones_mpiPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _Idetalle_de_observaciones_mpiApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.detalle_de_observaciones_mpis == null)
                result.detalle_de_observaciones_mpis = new List<detalle_de_observaciones_mpi>();

            var data = result.detalle_de_observaciones_mpis.Select(m => new detalle_de_observaciones_mpiGridModel
            {
                clave = m.clave
                ,observaciones = m.observaciones
                ,fecha = (m.fecha == null ? string.Empty : Convert.ToDateTime(m.fecha).ToString(ConfigurationProperty.DateFormat))
                ,hora = m.hora
                ,usuario_que_realiza_observacionName = (string)m.usuario_que_realiza_observacion_Spartan_User.Name

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "detalle_de_observaciones_mpiList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "detalle_de_observaciones_mpiList_" + DateTime.Now.ToString());
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

            _Idetalle_de_observaciones_mpiApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new detalle_de_observaciones_mpiPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _Idetalle_de_observaciones_mpiApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.detalle_de_observaciones_mpis == null)
                result.detalle_de_observaciones_mpis = new List<detalle_de_observaciones_mpi>();

            var data = result.detalle_de_observaciones_mpis.Select(m => new detalle_de_observaciones_mpiGridModel
            {
                clave = m.clave
                ,observaciones = m.observaciones
                ,fecha = (m.fecha == null ? string.Empty : Convert.ToDateTime(m.fecha).ToString(ConfigurationProperty.DateFormat))
                ,hora = m.hora
                ,usuario_que_realiza_observacionName = (string)m.usuario_que_realiza_observacion_Spartan_User.Name

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
