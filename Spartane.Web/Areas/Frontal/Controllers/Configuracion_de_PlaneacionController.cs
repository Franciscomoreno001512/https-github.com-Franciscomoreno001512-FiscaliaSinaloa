using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Configuracion_de_Planeacion;
using Spartane.Core.Domain.Categoria_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Configuracion_de_Planeacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Configuracion_de_Planeacion;
using Spartane.Web.Areas.WebApiConsumer.Categoria_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Servicio_de_Apoyo;

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
    public class Configuracion_de_PlaneacionController : Controller
    {
        #region "variable declaration"

        private IConfiguracion_de_PlaneacionService service = null;
        private IConfiguracion_de_PlaneacionApiConsumer _IConfiguracion_de_PlaneacionApiConsumer;
        private ICategoria_de_Servicio_de_ApoyoApiConsumer _ICategoria_de_Servicio_de_ApoyoApiConsumer;
        private ITipo_de_Servicio_de_ApoyoApiConsumer _ITipo_de_Servicio_de_ApoyoApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Configuracion_de_PlaneacionController(IConfiguracion_de_PlaneacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IConfiguracion_de_PlaneacionApiConsumer Configuracion_de_PlaneacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ICategoria_de_Servicio_de_ApoyoApiConsumer Categoria_de_Servicio_de_ApoyoApiConsumer , ITipo_de_Servicio_de_ApoyoApiConsumer Tipo_de_Servicio_de_ApoyoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IConfiguracion_de_PlaneacionApiConsumer = Configuracion_de_PlaneacionApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ICategoria_de_Servicio_de_ApoyoApiConsumer = Categoria_de_Servicio_de_ApoyoApiConsumer;
            this._ITipo_de_Servicio_de_ApoyoApiConsumer = Tipo_de_Servicio_de_ApoyoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Configuracion_de_Planeacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45477, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45477);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Configuracion_de_Planeacion/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45477, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45477);
            ViewBag.Permission = permission;
            var varConfiguracion_de_Planeacion = new Configuracion_de_PlaneacionModel();
			
            ViewBag.ObjectId = "45477";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConfiguracion_de_PlaneacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Configuracion_de_PlaneacionData = _IConfiguracion_de_PlaneacionApiConsumer.GetByKeyComplete(Id).Resource.Configuracion_de_Planeacions[0];
                if (Configuracion_de_PlaneacionData == null)
                    return HttpNotFound();

                varConfiguracion_de_Planeacion = new Configuracion_de_PlaneacionModel
                {
                    Folio = (int)Configuracion_de_PlaneacionData.Folio
                    ,Categoria = Configuracion_de_PlaneacionData.Categoria
                    ,CategoriaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Configuracion_de_PlaneacionData.Categoria), "Categoria_de_Servicio_de_Apoyo") ??  (string)Configuracion_de_PlaneacionData.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                    ,Servicio = Configuracion_de_PlaneacionData.Servicio
                    ,ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(Configuracion_de_PlaneacionData.Servicio), "Tipo_de_Servicio_de_Apoyo") ??  (string)Configuracion_de_PlaneacionData.Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                    ,Entregable = Configuracion_de_PlaneacionData.Entregable
                    ,Tiempo_Estandar = Configuracion_de_PlaneacionData.Tiempo_Estandar
                    ,Ponderacion = Configuracion_de_PlaneacionData.Ponderacion

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICategoria_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Categoria_de_Servicio_de_Apoyos_Categoria = _ICategoria_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Categoria_de_Servicio_de_Apoyos_Categoria != null && Categoria_de_Servicio_de_Apoyos_Categoria.Resource != null)
                ViewBag.Categoria_de_Servicio_de_Apoyos_Categoria = Categoria_de_Servicio_de_Apoyos_Categoria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Categoria_de_Servicio_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Servicio = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Servicio != null && Tipo_de_Servicio_de_Apoyos_Servicio.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Servicio = Tipo_de_Servicio_de_Apoyos_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varConfiguracion_de_Planeacion);
        }
		
	[HttpGet]
        public ActionResult AddConfiguracion_de_Planeacion(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45477);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IConfiguracion_de_PlaneacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Configuracion_de_PlaneacionModel varConfiguracion_de_Planeacion= new Configuracion_de_PlaneacionModel();


            if (id.ToString() != "0")
            {
                var Configuracion_de_PlaneacionsData = _IConfiguracion_de_PlaneacionApiConsumer.ListaSelAll(0, 1000, "Configuracion_de_Planeacion.Folio=" + id, "").Resource.Configuracion_de_Planeacions;
				
				if (Configuracion_de_PlaneacionsData != null && Configuracion_de_PlaneacionsData.Count > 0)
                {
					var Configuracion_de_PlaneacionData = Configuracion_de_PlaneacionsData.First();
					varConfiguracion_de_Planeacion= new Configuracion_de_PlaneacionModel
					{
						Folio  = Configuracion_de_PlaneacionData.Folio 
	                    ,Categoria = Configuracion_de_PlaneacionData.Categoria
                    ,CategoriaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Configuracion_de_PlaneacionData.Categoria), "Categoria_de_Servicio_de_Apoyo") ??  (string)Configuracion_de_PlaneacionData.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                    ,Servicio = Configuracion_de_PlaneacionData.Servicio
                    ,ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(Configuracion_de_PlaneacionData.Servicio), "Tipo_de_Servicio_de_Apoyo") ??  (string)Configuracion_de_PlaneacionData.Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                    ,Entregable = Configuracion_de_PlaneacionData.Entregable
                    ,Tiempo_Estandar = Configuracion_de_PlaneacionData.Tiempo_Estandar
                    ,Ponderacion = Configuracion_de_PlaneacionData.Ponderacion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICategoria_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Categoria_de_Servicio_de_Apoyos_Categoria = _ICategoria_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Categoria_de_Servicio_de_Apoyos_Categoria != null && Categoria_de_Servicio_de_Apoyos_Categoria.Resource != null)
                ViewBag.Categoria_de_Servicio_de_Apoyos_Categoria = Categoria_de_Servicio_de_Apoyos_Categoria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Categoria_de_Servicio_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Servicio = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Servicio != null && Tipo_de_Servicio_de_Apoyos_Servicio.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Servicio = Tipo_de_Servicio_de_Apoyos_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddConfiguracion_de_Planeacion", varConfiguracion_de_Planeacion);
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
        public ActionResult GetCategoria_de_Servicio_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICategoria_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICategoria_de_Servicio_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Categoria_de_Servicio_de_Apoyo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
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



        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Configuracion_de_PlaneacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IConfiguracion_de_PlaneacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Configuracion_de_Planeacions == null)
                result.Configuracion_de_Planeacions = new List<Configuracion_de_Planeacion>();

            return Json(new
            {
                data = result.Configuracion_de_Planeacions.Select(m => new Configuracion_de_PlaneacionGridModel
                    {
                    Folio = m.Folio
                        ,CategoriaDescripcion = CultureHelper.GetTraduction(m.Categoria_Categoria_de_Servicio_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                        ,ServicioServicio = CultureHelper.GetTraduction(m.Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Entregable = m.Entregable
			,Tiempo_Estandar = m.Tiempo_Estandar
			,Ponderacion = m.Ponderacion

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
                _IConfiguracion_de_PlaneacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Configuracion_de_Planeacion varConfiguracion_de_Planeacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IConfiguracion_de_PlaneacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Configuracion_de_PlaneacionModel varConfiguracion_de_Planeacion)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IConfiguracion_de_PlaneacionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Configuracion_de_PlaneacionInfo = new Configuracion_de_Planeacion
                    {
                        Folio = varConfiguracion_de_Planeacion.Folio
                        ,Categoria = varConfiguracion_de_Planeacion.Categoria
                        ,Servicio = varConfiguracion_de_Planeacion.Servicio
                        ,Entregable = varConfiguracion_de_Planeacion.Entregable
                        ,Tiempo_Estandar = varConfiguracion_de_Planeacion.Tiempo_Estandar
                        ,Ponderacion = varConfiguracion_de_Planeacion.Ponderacion

                    };

                    result = !IsNew ?
                        _IConfiguracion_de_PlaneacionApiConsumer.Update(Configuracion_de_PlaneacionInfo, null, null).Resource.ToString() :
                         _IConfiguracion_de_PlaneacionApiConsumer.Insert(Configuracion_de_PlaneacionInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Configuracion_de_Planeacion script
        /// </summary>
        /// <param name="oConfiguracion_de_PlaneacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Configuracion_de_PlaneacionModuleAttributeList)
        {
            for (int i = 0; i < Configuracion_de_PlaneacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Configuracion_de_PlaneacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Configuracion_de_PlaneacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Configuracion_de_PlaneacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Configuracion_de_PlaneacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Configuracion_de_PlaneacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Configuracion_de_PlaneacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Configuracion_de_PlaneacionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Configuracion_de_PlaneacionModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Configuracion_de_PlaneacionModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Configuracion_de_PlaneacionModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strConfiguracion_de_PlaneacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Configuracion_de_Planeacion.js")))
            {
                strConfiguracion_de_PlaneacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Configuracion_de_Planeacion element attributes
            string userChangeJson = jsSerialize.Serialize(Configuracion_de_PlaneacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strConfiguracion_de_PlaneacionScript.IndexOf("inpuElementArray");
            string splittedString = strConfiguracion_de_PlaneacionScript.Substring(indexOfArray, strConfiguracion_de_PlaneacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Configuracion_de_PlaneacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Configuracion_de_PlaneacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strConfiguracion_de_PlaneacionScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strConfiguracion_de_PlaneacionScript.Substring(indexOfArrayHistory, strConfiguracion_de_PlaneacionScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strConfiguracion_de_PlaneacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strConfiguracion_de_PlaneacionScript.Substring(endIndexOfMainElement + indexOfArray, strConfiguracion_de_PlaneacionScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Configuracion_de_PlaneacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strConfiguracion_de_PlaneacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strConfiguracion_de_PlaneacionScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strConfiguracion_de_PlaneacionScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strConfiguracion_de_PlaneacionScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Configuracion_de_Planeacion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Configuracion_de_Planeacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Configuracion_de_Planeacion.js")))
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
        public ActionResult Configuracion_de_PlaneacionPropertyBag()
        {
            return PartialView("Configuracion_de_PlaneacionPropertyBag", "Configuracion_de_Planeacion");
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

            _IConfiguracion_de_PlaneacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Configuracion_de_PlaneacionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IConfiguracion_de_PlaneacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Configuracion_de_Planeacions == null)
                result.Configuracion_de_Planeacions = new List<Configuracion_de_Planeacion>();

            var data = result.Configuracion_de_Planeacions.Select(m => new Configuracion_de_PlaneacionGridModel
            {
                Folio = m.Folio
                ,CategoriaDescripcion = (string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                ,ServicioServicio = (string)m.Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                ,Entregable = m.Entregable
                ,Tiempo_Estandar = m.Tiempo_Estandar
                ,Ponderacion = m.Ponderacion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Configuracion_de_PlaneacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Configuracion_de_PlaneacionList_" + DateTime.Now.ToString());
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

            _IConfiguracion_de_PlaneacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Configuracion_de_PlaneacionPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IConfiguracion_de_PlaneacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Configuracion_de_Planeacions == null)
                result.Configuracion_de_Planeacions = new List<Configuracion_de_Planeacion>();

            var data = result.Configuracion_de_Planeacions.Select(m => new Configuracion_de_PlaneacionGridModel
            {
                Folio = m.Folio
                ,CategoriaDescripcion = (string)m.Categoria_Categoria_de_Servicio_de_Apoyo.Descripcion
                ,ServicioServicio = (string)m.Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                ,Entregable = m.Entregable
                ,Tiempo_Estandar = m.Tiempo_Estandar
                ,Ponderacion = m.Ponderacion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
