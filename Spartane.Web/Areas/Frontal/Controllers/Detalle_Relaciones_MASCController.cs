using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Relaciones_MASC;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Relaciones_MASC;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Relaciones_MASC;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Imputado;
using Spartane.Web.Areas.WebApiConsumer.Delito;
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
    public class Detalle_Relaciones_MASCController : Controller
    {
        #region "variable declaration"

        private IDetalle_Relaciones_MASCService service = null;
        private IDetalle_Relaciones_MASCApiConsumer _IDetalle_Relaciones_MASCApiConsumer;
        private IDetalle_de_ImputadoApiConsumer _IDetalle_de_ImputadoApiConsumer;
        private IDelitoApiConsumer _IDelitoApiConsumer;
        private IDetalle_de_Datos_GeneralesApiConsumer _IDetalle_de_Datos_GeneralesApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Relaciones_MASCController(IDetalle_Relaciones_MASCService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Relaciones_MASCApiConsumer Detalle_Relaciones_MASCApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IDetalle_de_ImputadoApiConsumer Detalle_de_ImputadoApiConsumer , IDelitoApiConsumer DelitoApiConsumer
, IDetalle_de_Datos_GeneralesApiConsumer Detalle_de_Datos_GeneralesApiConsumer
)
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Relaciones_MASCApiConsumer = Detalle_Relaciones_MASCApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IDetalle_de_ImputadoApiConsumer = Detalle_de_ImputadoApiConsumer;
            this._IDelitoApiConsumer = DelitoApiConsumer;
            this._IDetalle_de_Datos_GeneralesApiConsumer = Detalle_de_Datos_GeneralesApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Relaciones_MASC
        [ObjectAuth(ObjectId = (ModuleObjectId)45705, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45705);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Relaciones_MASC/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45705, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,
 int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45705);
            ViewBag.Permission = permission;
            var varDetalle_Relaciones_MASC = new Detalle_Relaciones_MASCModel();
			
            ViewBag.ObjectId = "45705";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Relaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Relaciones_MASCData = _IDetalle_Relaciones_MASCApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Relaciones_MASCs[0];
                if (Detalle_Relaciones_MASCData == null)
                    return HttpNotFound();

                varDetalle_Relaciones_MASC = new Detalle_Relaciones_MASCModel
                {
                    Clave = (int)Detalle_Relaciones_MASCData.Clave
                    ,Requerido = Detalle_Relaciones_MASCData.Requerido
                    ,RequeridoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(Convert.ToString(Detalle_Relaciones_MASCData.Requerido), "Detalle_de_Imputado") ??  (string)Detalle_Relaciones_MASCData.Requerido_Detalle_de_Imputado.Nombre_Completo_del_Tutor
                    ,Delito = Detalle_Relaciones_MASCData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Relaciones_MASCData.Delito), "Delito") ??  (string)Detalle_Relaciones_MASCData.Delito_Delito.Descripcion
                    ,Solicitante = Detalle_Relaciones_MASCData.Solicitante
                    ,SolicitanteNombre_Completo2 = CultureHelper.GetTraduction(Convert.ToString(Detalle_Relaciones_MASCData.Solicitante), "Detalle_de_Datos_Generales") ??  (string)Detalle_Relaciones_MASCData.Solicitante_Detalle_de_Datos_Generales.Nombre_Completo2

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Relaciones_MASC);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Relaciones_MASC(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45705);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Relaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Relaciones_MASCModel varDetalle_Relaciones_MASC= new Detalle_Relaciones_MASCModel();


            if (id.ToString() != "0")
            {
                var Detalle_Relaciones_MASCsData = _IDetalle_Relaciones_MASCApiConsumer.ListaSelAll(0, 1000, "Detalle_Relaciones_MASC.Clave=" + id, "").Resource.Detalle_Relaciones_MASCs;
				
				if (Detalle_Relaciones_MASCsData != null && Detalle_Relaciones_MASCsData.Count > 0)
                {
					var Detalle_Relaciones_MASCData = Detalle_Relaciones_MASCsData.First();
					varDetalle_Relaciones_MASC= new Detalle_Relaciones_MASCModel
					{
						Clave  = Detalle_Relaciones_MASCData.Clave 
	                    ,Requerido = Detalle_Relaciones_MASCData.Requerido
                    ,RequeridoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(Convert.ToString(Detalle_Relaciones_MASCData.Requerido), "Detalle_de_Imputado") ??  (string)Detalle_Relaciones_MASCData.Requerido_Detalle_de_Imputado.Nombre_Completo_del_Tutor
                    ,Delito = Detalle_Relaciones_MASCData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Relaciones_MASCData.Delito), "Delito") ??  (string)Detalle_Relaciones_MASCData.Delito_Delito.Descripcion
                    ,Solicitante = Detalle_Relaciones_MASCData.Solicitante
                    ,SolicitanteNombre_Completo2 = CultureHelper.GetTraduction(Convert.ToString(Detalle_Relaciones_MASCData.Solicitante), "Detalle_de_Datos_Generales") ??  (string)Detalle_Relaciones_MASCData.Solicitante_Detalle_de_Datos_Generales.Nombre_Completo2

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddDetalle_Relaciones_MASC", varDetalle_Relaciones_MASC);
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
		[HttpGet]
        public ActionResult GetDetalle_de_Datos_GeneralesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Datos_GeneralesApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre_Completo2).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_Completo2")?? m.Nombre_Completo2,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Relaciones_MASCPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Relaciones_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Relaciones_MASCs == null)
                result.Detalle_Relaciones_MASCs = new List<Detalle_Relaciones_MASC>();

            return Json(new
            {
                data = result.Detalle_Relaciones_MASCs.Select(m => new Detalle_Relaciones_MASCGridModel
                    {
                    Clave = m.Clave
                        ,RequeridoNombre_Completo_del_Tutor = CultureHelper.GetTraduction(m.Requerido_Detalle_de_Imputado.Clave.ToString(), "Detalle_de_Imputado") ?? (string)m.Requerido_Detalle_de_Imputado.Nombre_Completo_del_Tutor
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Delito") ?? (string)m.Delito_Delito.Descripcion
                        ,SolicitanteNombre_Completo2 = CultureHelper.GetTraduction(m.Solicitante_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Solicitante_Detalle_de_Datos_Generales.Nombre_Completo2

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_Relaciones_MASC_Requerido_Detalle_de_Imputado(string query, string where)
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
        public JsonResult GetDetalle_Relaciones_MASC_Delito_Delito(string query, string where)
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
        [HttpGet]
        public JsonResult GetDetalle_Relaciones_MASC_Solicitante_Detalle_de_Datos_Generales(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Datos_Generales.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Datos_Generales.Nombre_Completo2 as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_Datos_GeneralesApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Datos_Generales.Nombre_Completo2 ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Datos_Generaless)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Datos_Generales", "Nombre_Completo2");
                    item.Nombre_Completo2 =trans ??item.Nombre_Completo2;
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
                _IDetalle_Relaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Relaciones_MASC varDetalle_Relaciones_MASC = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Relaciones_MASCApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Relaciones_MASCModel varDetalle_Relaciones_MASC)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Relaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Relaciones_MASCInfo = new Detalle_Relaciones_MASC
                    {
                        Clave = varDetalle_Relaciones_MASC.Clave
                        ,Requerido = varDetalle_Relaciones_MASC.Requerido
                        ,Delito = varDetalle_Relaciones_MASC.Delito
                        ,Solicitante = varDetalle_Relaciones_MASC.Solicitante

                    };

                    result = !IsNew ?
                        _IDetalle_Relaciones_MASCApiConsumer.Update(Detalle_Relaciones_MASCInfo, null, null).Resource.ToString() :
                         _IDetalle_Relaciones_MASCApiConsumer.Insert(Detalle_Relaciones_MASCInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Relaciones_MASC script
        /// </summary>
        /// <param name="oDetalle_Relaciones_MASCElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Relaciones_MASCModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Relaciones_MASCModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Relaciones_MASCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Relaciones_MASCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Relaciones_MASCModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Relaciones_MASCModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Relaciones_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Relaciones_MASCModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Relaciones_MASCModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Relaciones_MASCModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Relaciones_MASCModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Relaciones_MASCModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Relaciones_MASCScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Relaciones_MASC.js")))
            {
                strDetalle_Relaciones_MASCScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Relaciones_MASC element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Relaciones_MASCModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Relaciones_MASCScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Relaciones_MASCScript.Substring(indexOfArray, strDetalle_Relaciones_MASCScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Relaciones_MASCModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Relaciones_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Relaciones_MASCScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Relaciones_MASCScript.Substring(indexOfArrayHistory, strDetalle_Relaciones_MASCScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Relaciones_MASCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Relaciones_MASCScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Relaciones_MASCScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Relaciones_MASCModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Relaciones_MASCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Relaciones_MASCScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Relaciones_MASCScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Relaciones_MASCScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Relaciones_MASC.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Relaciones_MASC.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Relaciones_MASC.js")))
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
        public ActionResult Detalle_Relaciones_MASCPropertyBag()
        {
            return PartialView("Detalle_Relaciones_MASCPropertyBag", "Detalle_Relaciones_MASC");
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

            _IDetalle_Relaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Relaciones_MASCPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Relaciones_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Relaciones_MASCs == null)
                result.Detalle_Relaciones_MASCs = new List<Detalle_Relaciones_MASC>();

            var data = result.Detalle_Relaciones_MASCs.Select(m => new Detalle_Relaciones_MASCGridModel
            {
                Clave = m.Clave
                ,RequeridoNombre_Completo_del_Tutor = (string)m.Requerido_Detalle_de_Imputado.Nombre_Completo_del_Tutor
                ,DelitoDescripcion = (string)m.Delito_Delito.Descripcion
                ,SolicitanteNombre_Completo2 = (string)m.Solicitante_Detalle_de_Datos_Generales.Nombre_Completo2

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Relaciones_MASCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Relaciones_MASCList_" + DateTime.Now.ToString());
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

            _IDetalle_Relaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Relaciones_MASCPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Relaciones_MASCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Relaciones_MASCs == null)
                result.Detalle_Relaciones_MASCs = new List<Detalle_Relaciones_MASC>();

            var data = result.Detalle_Relaciones_MASCs.Select(m => new Detalle_Relaciones_MASCGridModel
            {
                Clave = m.Clave
                ,RequeridoNombre_Completo_del_Tutor = (string)m.Requerido_Detalle_de_Imputado.Nombre_Completo_del_Tutor
                ,DelitoDescripcion = (string)m.Delito_Delito.Descripcion
                ,SolicitanteNombre_Completo2 = (string)m.Solicitante_Detalle_de_Datos_Generales.Nombre_Completo2

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
