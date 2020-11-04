using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Servicios_Alternativos;
using Spartane.Core.Domain.Medios_Alternativos;
using Spartane.Core.Domain.Tipo_de_Instancia;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Servicios_Alternativos;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Servicios_Alternativos;
using Spartane.Web.Areas.WebApiConsumer.Medios_Alternativos;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Instancia;

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
    public class Servicios_AlternativosController : Controller
    {
        #region "variable declaration"

        private IServicios_AlternativosService service = null;
        private IServicios_AlternativosApiConsumer _IServicios_AlternativosApiConsumer;
        private IMedios_AlternativosApiConsumer _IMedios_AlternativosApiConsumer;
        private ITipo_de_InstanciaApiConsumer _ITipo_de_InstanciaApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Servicios_AlternativosController(IServicios_AlternativosService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IServicios_AlternativosApiConsumer Servicios_AlternativosApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , IMedios_AlternativosApiConsumer Medios_AlternativosApiConsumer , ITipo_de_InstanciaApiConsumer Tipo_de_InstanciaApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IServicios_AlternativosApiConsumer = Servicios_AlternativosApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._IMedios_AlternativosApiConsumer = Medios_AlternativosApiConsumer;
            this._ITipo_de_InstanciaApiConsumer = Tipo_de_InstanciaApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Servicios_Alternativos
        [ObjectAuth(ObjectId = (ModuleObjectId)45001, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45001);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Servicios_Alternativos/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45001, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45001);
            ViewBag.Permission = permission;
            var varServicios_Alternativos = new Servicios_AlternativosModel();
			
            ViewBag.ObjectId = "45001";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicios_AlternativosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Servicios_AlternativosData = _IServicios_AlternativosApiConsumer.GetByKeyComplete(Id).Resource.Servicios_Alternativoss[0];
                if (Servicios_AlternativosData == null)
                    return HttpNotFound();

                varServicios_Alternativos = new Servicios_AlternativosModel
                {
                    Clave = (int)Servicios_AlternativosData.Clave
                    ,CJusticia_Alternativa = Servicios_AlternativosData.CJusticia_Alternativa.GetValueOrDefault()
                    ,Medios_Alternativos = Servicios_AlternativosData.Medios_Alternativos
                    ,Medios_AlternativosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Servicios_AlternativosData.Medios_Alternativos), "Medios_Alternativos") ??  (string)Servicios_AlternativosData.Medios_Alternativos_Medios_Alternativos.Descripcion
                    ,Motivo = Servicios_AlternativosData.Motivo
                    ,Derechos = Servicios_AlternativosData.Derechos.GetValueOrDefault()
                    ,Procedimiento = Servicios_AlternativosData.Procedimiento.GetValueOrDefault()
                    ,Solicita_Medios_Alternativos = Servicios_AlternativosData.Solicita_Medios_Alternativos.GetValueOrDefault()
                    ,Se_Canaliza = Servicios_AlternativosData.Se_Canaliza
                    ,Se_CanalizaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Servicios_AlternativosData.Se_Canaliza), "Tipo_de_Instancia") ??  (string)Servicios_AlternativosData.Se_Canaliza_Tipo_de_Instancia.Descripcion
                    ,Investigacion_con_Detenido = Servicios_AlternativosData.Investigacion_con_Detenido.GetValueOrDefault()
                    ,Investigacion_sin_Detenido = Servicios_AlternativosData.Investigacion_sin_Detenido.GetValueOrDefault()
                    ,Turnar_a_Justicia_Alternativa = Servicios_AlternativosData.Turnar_a_Justicia_Alternativa.GetValueOrDefault()
                    ,Instancia_Externa = Servicios_AlternativosData.Instancia_Externa.GetValueOrDefault()

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IMedios_AlternativosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Medios_Alternativoss_Medios_Alternativos = _IMedios_AlternativosApiConsumer.SelAll(true);
            if (Medios_Alternativoss_Medios_Alternativos != null && Medios_Alternativoss_Medios_Alternativos.Resource != null)
                ViewBag.Medios_Alternativoss_Medios_Alternativos = Medios_Alternativoss_Medios_Alternativos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Medios_Alternativos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InstanciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Instancias_Se_Canaliza = _ITipo_de_InstanciaApiConsumer.SelAll(true);
            if (Tipo_de_Instancias_Se_Canaliza != null && Tipo_de_Instancias_Se_Canaliza.Resource != null)
                ViewBag.Tipo_de_Instancias_Se_Canaliza = Tipo_de_Instancias_Se_Canaliza.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Instancia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varServicios_Alternativos);
        }
		
	[HttpGet]
        public ActionResult AddServicios_Alternativos(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45001);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IServicios_AlternativosApiConsumer.SetAuthHeader(_tokenManager.Token);
			Servicios_AlternativosModel varServicios_Alternativos= new Servicios_AlternativosModel();


            if (id.ToString() != "0")
            {
                var Servicios_AlternativossData = _IServicios_AlternativosApiConsumer.ListaSelAll(0, 1000, "Servicios_Alternativos.Clave=" + id, "").Resource.Servicios_Alternativoss;
				
				if (Servicios_AlternativossData != null && Servicios_AlternativossData.Count > 0)
                {
					var Servicios_AlternativosData = Servicios_AlternativossData.First();
					varServicios_Alternativos= new Servicios_AlternativosModel
					{
						Clave  = Servicios_AlternativosData.Clave 
	                    ,CJusticia_Alternativa = Servicios_AlternativosData.CJusticia_Alternativa.GetValueOrDefault()
                    ,Medios_Alternativos = Servicios_AlternativosData.Medios_Alternativos
                    ,Medios_AlternativosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Servicios_AlternativosData.Medios_Alternativos), "Medios_Alternativos") ??  (string)Servicios_AlternativosData.Medios_Alternativos_Medios_Alternativos.Descripcion
                    ,Motivo = Servicios_AlternativosData.Motivo
                    ,Derechos = Servicios_AlternativosData.Derechos.GetValueOrDefault()
                    ,Procedimiento = Servicios_AlternativosData.Procedimiento.GetValueOrDefault()
                    ,Solicita_Medios_Alternativos = Servicios_AlternativosData.Solicita_Medios_Alternativos.GetValueOrDefault()
                    ,Se_Canaliza = Servicios_AlternativosData.Se_Canaliza
                    ,Se_CanalizaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Servicios_AlternativosData.Se_Canaliza), "Tipo_de_Instancia") ??  (string)Servicios_AlternativosData.Se_Canaliza_Tipo_de_Instancia.Descripcion
                    ,Investigacion_con_Detenido = Servicios_AlternativosData.Investigacion_con_Detenido.GetValueOrDefault()
                    ,Investigacion_sin_Detenido = Servicios_AlternativosData.Investigacion_sin_Detenido.GetValueOrDefault()
                    ,Turnar_a_Justicia_Alternativa = Servicios_AlternativosData.Turnar_a_Justicia_Alternativa.GetValueOrDefault()
                    ,Instancia_Externa = Servicios_AlternativosData.Instancia_Externa.GetValueOrDefault()

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IMedios_AlternativosApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Medios_Alternativoss_Medios_Alternativos = _IMedios_AlternativosApiConsumer.SelAll(true);
            if (Medios_Alternativoss_Medios_Alternativos != null && Medios_Alternativoss_Medios_Alternativos.Resource != null)
                ViewBag.Medios_Alternativoss_Medios_Alternativos = Medios_Alternativoss_Medios_Alternativos.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Medios_Alternativos", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_InstanciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Instancias_Se_Canaliza = _ITipo_de_InstanciaApiConsumer.SelAll(true);
            if (Tipo_de_Instancias_Se_Canaliza != null && Tipo_de_Instancias_Se_Canaliza.Resource != null)
                ViewBag.Tipo_de_Instancias_Se_Canaliza = Tipo_de_Instancias_Se_Canaliza.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Instancia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddServicios_Alternativos", varServicios_Alternativos);
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
        public ActionResult GetMedios_AlternativosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMedios_AlternativosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMedios_AlternativosApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Medios_Alternativos", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_InstanciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_InstanciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_InstanciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Instancia", "Descripcion")?? m.Descripcion,
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Servicios_AlternativosPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IServicios_AlternativosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Servicios_Alternativoss == null)
                result.Servicios_Alternativoss = new List<Servicios_Alternativos>();

            return Json(new
            {
                data = result.Servicios_Alternativoss.Select(m => new Servicios_AlternativosGridModel
                    {
                    Clave = m.Clave
			,CJusticia_Alternativa = m.CJusticia_Alternativa
                        ,Medios_AlternativosDescripcion = CultureHelper.GetTraduction(m.Medios_Alternativos_Medios_Alternativos.Clave.ToString(), "Descripcion") ?? (string)m.Medios_Alternativos_Medios_Alternativos.Descripcion
			,Motivo = m.Motivo
			,Derechos = m.Derechos
			,Procedimiento = m.Procedimiento
			,Solicita_Medios_Alternativos = m.Solicita_Medios_Alternativos
                        ,Se_CanalizaDescripcion = CultureHelper.GetTraduction(m.Se_Canaliza_Tipo_de_Instancia.Clave.ToString(), "Descripcion") ?? (string)m.Se_Canaliza_Tipo_de_Instancia.Descripcion
			,Investigacion_con_Detenido = m.Investigacion_con_Detenido
			,Investigacion_sin_Detenido = m.Investigacion_sin_Detenido
			,Turnar_a_Justicia_Alternativa = m.Turnar_a_Justicia_Alternativa
			,Instancia_Externa = m.Instancia_Externa

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
                _IServicios_AlternativosApiConsumer.SetAuthHeader(_tokenManager.Token);

                Servicios_Alternativos varServicios_Alternativos = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IServicios_AlternativosApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Servicios_AlternativosModel varServicios_Alternativos)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IServicios_AlternativosApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Servicios_AlternativosInfo = new Servicios_Alternativos
                    {
                        Clave = varServicios_Alternativos.Clave
                        ,CJusticia_Alternativa = varServicios_Alternativos.CJusticia_Alternativa
                        ,Medios_Alternativos = varServicios_Alternativos.Medios_Alternativos
                        ,Motivo = varServicios_Alternativos.Motivo
                        ,Derechos = varServicios_Alternativos.Derechos
                        ,Procedimiento = varServicios_Alternativos.Procedimiento
                        ,Solicita_Medios_Alternativos = varServicios_Alternativos.Solicita_Medios_Alternativos
                        ,Se_Canaliza = varServicios_Alternativos.Se_Canaliza
                        ,Investigacion_con_Detenido = varServicios_Alternativos.Investigacion_con_Detenido
                        ,Investigacion_sin_Detenido = varServicios_Alternativos.Investigacion_sin_Detenido
                        ,Turnar_a_Justicia_Alternativa = varServicios_Alternativos.Turnar_a_Justicia_Alternativa
                        ,Instancia_Externa = varServicios_Alternativos.Instancia_Externa

                    };

                    result = !IsNew ?
                        _IServicios_AlternativosApiConsumer.Update(Servicios_AlternativosInfo, null, null).Resource.ToString() :
                         _IServicios_AlternativosApiConsumer.Insert(Servicios_AlternativosInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Servicios_Alternativos script
        /// </summary>
        /// <param name="oServicios_AlternativosElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Servicios_AlternativosModuleAttributeList)
        {
            for (int i = 0; i < Servicios_AlternativosModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Servicios_AlternativosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Servicios_AlternativosModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Servicios_AlternativosModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Servicios_AlternativosModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Servicios_AlternativosModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Servicios_AlternativosModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Servicios_AlternativosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Servicios_AlternativosModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Servicios_AlternativosModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Servicios_AlternativosModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strServicios_AlternativosScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Servicios_Alternativos.js")))
            {
                strServicios_AlternativosScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Servicios_Alternativos element attributes
            string userChangeJson = jsSerialize.Serialize(Servicios_AlternativosModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strServicios_AlternativosScript.IndexOf("inpuElementArray");
            string splittedString = strServicios_AlternativosScript.Substring(indexOfArray, strServicios_AlternativosScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Servicios_AlternativosModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Servicios_AlternativosModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strServicios_AlternativosScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strServicios_AlternativosScript.Substring(indexOfArrayHistory, strServicios_AlternativosScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strServicios_AlternativosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strServicios_AlternativosScript.Substring(endIndexOfMainElement + indexOfArray, strServicios_AlternativosScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Servicios_AlternativosModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strServicios_AlternativosScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strServicios_AlternativosScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strServicios_AlternativosScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strServicios_AlternativosScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Servicios_Alternativos.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Servicios_Alternativos.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Servicios_Alternativos.js")))
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
        public ActionResult Servicios_AlternativosPropertyBag()
        {
            return PartialView("Servicios_AlternativosPropertyBag", "Servicios_Alternativos");
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

            _IServicios_AlternativosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Servicios_AlternativosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IServicios_AlternativosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Servicios_Alternativoss == null)
                result.Servicios_Alternativoss = new List<Servicios_Alternativos>();

            var data = result.Servicios_Alternativoss.Select(m => new Servicios_AlternativosGridModel
            {
                Clave = m.Clave
                ,CJusticia_Alternativa = m.CJusticia_Alternativa
                ,Medios_AlternativosDescripcion = (string)m.Medios_Alternativos_Medios_Alternativos.Descripcion
                ,Motivo = m.Motivo
                ,Derechos = m.Derechos
                ,Procedimiento = m.Procedimiento
                ,Solicita_Medios_Alternativos = m.Solicita_Medios_Alternativos
                ,Se_CanalizaDescripcion = (string)m.Se_Canaliza_Tipo_de_Instancia.Descripcion
                ,Investigacion_con_Detenido = m.Investigacion_con_Detenido
                ,Investigacion_sin_Detenido = m.Investigacion_sin_Detenido
                ,Turnar_a_Justicia_Alternativa = m.Turnar_a_Justicia_Alternativa
                ,Instancia_Externa = m.Instancia_Externa

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Servicios_AlternativosList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Servicios_AlternativosList_" + DateTime.Now.ToString());
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

            _IServicios_AlternativosApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Servicios_AlternativosPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IServicios_AlternativosApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Servicios_Alternativoss == null)
                result.Servicios_Alternativoss = new List<Servicios_Alternativos>();

            var data = result.Servicios_Alternativoss.Select(m => new Servicios_AlternativosGridModel
            {
                Clave = m.Clave
                ,CJusticia_Alternativa = m.CJusticia_Alternativa
                ,Medios_AlternativosDescripcion = (string)m.Medios_Alternativos_Medios_Alternativos.Descripcion
                ,Motivo = m.Motivo
                ,Derechos = m.Derechos
                ,Procedimiento = m.Procedimiento
                ,Solicita_Medios_Alternativos = m.Solicita_Medios_Alternativos
                ,Se_CanalizaDescripcion = (string)m.Se_Canaliza_Tipo_de_Instancia.Descripcion
                ,Investigacion_con_Detenido = m.Investigacion_con_Detenido
                ,Investigacion_sin_Detenido = m.Investigacion_sin_Detenido
                ,Turnar_a_Justicia_Alternativa = m.Turnar_a_Justicia_Alternativa
                ,Instancia_Externa = m.Instancia_Externa

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
