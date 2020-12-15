using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento;
using Spartane.Core.Domain.Tipo_de_Dato;
using Spartane.Core.Domain.Relaciones_para_Movimientos;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_Datos_Adicionales_Movimiento;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Datos_Adicionales_Movimiento;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Dato;
using Spartane.Web.Areas.WebApiConsumer.Relaciones_para_Movimientos;

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
    public class Detalle_Datos_Adicionales_MovimientoController : Controller
    {
        #region "variable declaration"

        private IDetalle_Datos_Adicionales_MovimientoService service = null;
        private IDetalle_Datos_Adicionales_MovimientoApiConsumer _IDetalle_Datos_Adicionales_MovimientoApiConsumer;
        private ITipo_de_DatoApiConsumer _ITipo_de_DatoApiConsumer;
        private IRelaciones_para_MovimientosApiConsumer _IRelaciones_para_MovimientosApiConsumer;

        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Detalle_Datos_Adicionales_MovimientoController(IDetalle_Datos_Adicionales_MovimientoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_Datos_Adicionales_MovimientoApiConsumer Detalle_Datos_Adicionales_MovimientoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ITipo_de_DatoApiConsumer Tipo_de_DatoApiConsumer , IRelaciones_para_MovimientosApiConsumer Relaciones_para_MovimientosApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_Datos_Adicionales_MovimientoApiConsumer = Detalle_Datos_Adicionales_MovimientoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ITipo_de_DatoApiConsumer = Tipo_de_DatoApiConsumer;
            this._IRelaciones_para_MovimientosApiConsumer = Relaciones_para_MovimientosApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_Datos_Adicionales_Movimiento
        [ObjectAuth(ObjectId = (ModuleObjectId)45635, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45635);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Detalle_Datos_Adicionales_Movimiento/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45635, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45635);
            ViewBag.Permission = permission;
            var varDetalle_Datos_Adicionales_Movimiento = new Detalle_Datos_Adicionales_MovimientoModel();
			
            ViewBag.ObjectId = "45635";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_Datos_Adicionales_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_Datos_Adicionales_MovimientoData = _IDetalle_Datos_Adicionales_MovimientoApiConsumer.GetByKeyComplete(Id).Resource.Detalle_Datos_Adicionales_Movimientos[0];
                if (Detalle_Datos_Adicionales_MovimientoData == null)
                    return HttpNotFound();

                varDetalle_Datos_Adicionales_Movimiento = new Detalle_Datos_Adicionales_MovimientoModel
                {
                    Clave = (int)Detalle_Datos_Adicionales_MovimientoData.Clave
                    ,Dato = Detalle_Datos_Adicionales_MovimientoData.Dato
                    ,Tipo_de_Dato = Detalle_Datos_Adicionales_MovimientoData.Tipo_de_Dato
                    ,Tipo_de_DatoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_Adicionales_MovimientoData.Tipo_de_Dato), "Tipo_de_Dato") ??  (string)Detalle_Datos_Adicionales_MovimientoData.Tipo_de_Dato_Tipo_de_Dato.Descripcion
                    ,Relacion = Detalle_Datos_Adicionales_MovimientoData.Relacion
                    ,RelacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_Adicionales_MovimientoData.Relacion), "Relaciones_para_Movimientos") ??  (string)Detalle_Datos_Adicionales_MovimientoData.Relacion_Relaciones_para_Movimientos.Descripcion
                    ,Obligatorio = Detalle_Datos_Adicionales_MovimientoData.Obligatorio.GetValueOrDefault()

                };

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DatoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Datos_Tipo_de_Dato = _ITipo_de_DatoApiConsumer.SelAll(true);
            if (Tipo_de_Datos_Tipo_de_Dato != null && Tipo_de_Datos_Tipo_de_Dato.Resource != null)
                ViewBag.Tipo_de_Datos_Tipo_de_Dato = Tipo_de_Datos_Tipo_de_Dato.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Dato", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
            return View(varDetalle_Datos_Adicionales_Movimiento);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_Datos_Adicionales_Movimiento(int rowIndex = 0, int functionMode = 0, int id = 0)
        {
            int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45635);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_Datos_Adicionales_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_Datos_Adicionales_MovimientoModel varDetalle_Datos_Adicionales_Movimiento= new Detalle_Datos_Adicionales_MovimientoModel();


            if (id.ToString() != "0")
            {
                var Detalle_Datos_Adicionales_MovimientosData = _IDetalle_Datos_Adicionales_MovimientoApiConsumer.ListaSelAll(0, 1000, "Detalle_Datos_Adicionales_Movimiento.Clave=" + id, "").Resource.Detalle_Datos_Adicionales_Movimientos;
				
				if (Detalle_Datos_Adicionales_MovimientosData != null && Detalle_Datos_Adicionales_MovimientosData.Count > 0)
                {
					var Detalle_Datos_Adicionales_MovimientoData = Detalle_Datos_Adicionales_MovimientosData.First();
					varDetalle_Datos_Adicionales_Movimiento= new Detalle_Datos_Adicionales_MovimientoModel
					{
						Clave  = Detalle_Datos_Adicionales_MovimientoData.Clave 
	                    ,Dato = Detalle_Datos_Adicionales_MovimientoData.Dato
                    ,Tipo_de_Dato = Detalle_Datos_Adicionales_MovimientoData.Tipo_de_Dato
                    ,Tipo_de_DatoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_Adicionales_MovimientoData.Tipo_de_Dato), "Tipo_de_Dato") ??  (string)Detalle_Datos_Adicionales_MovimientoData.Tipo_de_Dato_Tipo_de_Dato.Descripcion
                    ,Relacion = Detalle_Datos_Adicionales_MovimientoData.Relacion
                    ,RelacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_Datos_Adicionales_MovimientoData.Relacion), "Relaciones_para_Movimientos") ??  (string)Detalle_Datos_Adicionales_MovimientoData.Relacion_Relaciones_para_Movimientos.Descripcion
                    ,Obligatorio = Detalle_Datos_Adicionales_MovimientoData.Obligatorio.GetValueOrDefault()

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DatoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Datos_Tipo_de_Dato = _ITipo_de_DatoApiConsumer.SelAll(true);
            if (Tipo_de_Datos_Tipo_de_Dato != null && Tipo_de_Datos_Tipo_de_Dato.Resource != null)
                ViewBag.Tipo_de_Datos_Tipo_de_Dato = Tipo_de_Datos_Tipo_de_Dato.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Dato", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_Datos_Adicionales_Movimiento", varDetalle_Datos_Adicionales_Movimiento);
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
        public ActionResult GetTipo_de_DatoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_DatoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_DatoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Dato", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetRelaciones_para_MovimientosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRelaciones_para_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRelaciones_para_MovimientosApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.ObjectId), "Relaciones_para_Movimientos", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.ObjectId)
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Datos_Adicionales_MovimientoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_Datos_Adicionales_MovimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Datos_Adicionales_Movimientos == null)
                result.Detalle_Datos_Adicionales_Movimientos = new List<Detalle_Datos_Adicionales_Movimiento>();

            return Json(new
            {
                data = result.Detalle_Datos_Adicionales_Movimientos.Select(m => new Detalle_Datos_Adicionales_MovimientoGridModel
                    {
                    Clave = m.Clave
			,Dato = m.Dato
                        ,Tipo_de_DatoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Dato_Tipo_de_Dato.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Dato_Tipo_de_Dato.Descripcion
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Relaciones_para_Movimientos.ObjectId.ToString(), "Relaciones_para_Movimientos") ?? (string)m.Relacion_Relaciones_para_Movimientos.Descripcion
			,Obligatorio = m.Obligatorio

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_Datos_Adicionales_Movimiento_Relacion_Relaciones_para_Movimientos(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRelaciones_para_MovimientosApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Relaciones_para_Movimientos.ObjectId as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Relaciones_para_Movimientos.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IRelaciones_para_MovimientosApiConsumer.ListaSelAll(1, 20,elWhere , " Relaciones_para_Movimientos.Descripcion ASC ").Resource;
               
                foreach (var item in result.Relaciones_para_Movimientoss)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.ObjectId), "Relaciones_para_Movimientos", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Relaciones_para_Movimientoss.ToArray(), JsonRequestBehavior.AllowGet);
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
                _IDetalle_Datos_Adicionales_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_Datos_Adicionales_Movimiento varDetalle_Datos_Adicionales_Movimiento = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_Datos_Adicionales_MovimientoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_Datos_Adicionales_MovimientoModel varDetalle_Datos_Adicionales_Movimiento)
        {
            try
            {
				if (ModelState.IsValid)
				{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_Datos_Adicionales_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_Datos_Adicionales_MovimientoInfo = new Detalle_Datos_Adicionales_Movimiento
                    {
                        Clave = varDetalle_Datos_Adicionales_Movimiento.Clave
                        ,Dato = varDetalle_Datos_Adicionales_Movimiento.Dato
                        ,Tipo_de_Dato = varDetalle_Datos_Adicionales_Movimiento.Tipo_de_Dato
                        ,Relacion = varDetalle_Datos_Adicionales_Movimiento.Relacion
                        ,Obligatorio = varDetalle_Datos_Adicionales_Movimiento.Obligatorio

                    };

                    result = !IsNew ?
                        _IDetalle_Datos_Adicionales_MovimientoApiConsumer.Update(Detalle_Datos_Adicionales_MovimientoInfo, null, null).Resource.ToString() :
                         _IDetalle_Datos_Adicionales_MovimientoApiConsumer.Insert(Detalle_Datos_Adicionales_MovimientoInfo, null, null).Resource.ToString();

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
        /// Write Element Array of Detalle_Datos_Adicionales_Movimiento script
        /// </summary>
        /// <param name="oDetalle_Datos_Adicionales_MovimientoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElements Detalle_Datos_Adicionales_MovimientoModuleAttributeList)
        {
            for (int i = 0; i < Detalle_Datos_Adicionales_MovimientoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_Datos_Adicionales_MovimientoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_Datos_Adicionales_MovimientoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_Datos_Adicionales_MovimientoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_Datos_Adicionales_MovimientoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_Datos_Adicionales_MovimientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_Datos_Adicionales_MovimientoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					if (string.IsNullOrEmpty(Detalle_Datos_Adicionales_MovimientoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Detalle_Datos_Adicionales_MovimientoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Detalle_Datos_Adicionales_MovimientoModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Detalle_Datos_Adicionales_MovimientoModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
					}
				}
			}
            string strDetalle_Datos_Adicionales_MovimientoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Datos_Adicionales_Movimiento.js")))
            {
                strDetalle_Datos_Adicionales_MovimientoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_Datos_Adicionales_Movimiento element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_Datos_Adicionales_MovimientoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_Datos_Adicionales_MovimientoScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_Datos_Adicionales_MovimientoScript.Substring(indexOfArray, strDetalle_Datos_Adicionales_MovimientoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_Datos_Adicionales_MovimientoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_Datos_Adicionales_MovimientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_Datos_Adicionales_MovimientoScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strDetalle_Datos_Adicionales_MovimientoScript.Substring(indexOfArrayHistory, strDetalle_Datos_Adicionales_MovimientoScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strDetalle_Datos_Adicionales_MovimientoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_Datos_Adicionales_MovimientoScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_Datos_Adicionales_MovimientoScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Detalle_Datos_Adicionales_MovimientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strDetalle_Datos_Adicionales_MovimientoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strDetalle_Datos_Adicionales_MovimientoScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strDetalle_Datos_Adicionales_MovimientoScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strDetalle_Datos_Adicionales_MovimientoScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_Datos_Adicionales_Movimiento.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_Datos_Adicionales_Movimiento.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_Datos_Adicionales_Movimiento.js")))
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
        public ActionResult Detalle_Datos_Adicionales_MovimientoPropertyBag()
        {
            return PartialView("Detalle_Datos_Adicionales_MovimientoPropertyBag", "Detalle_Datos_Adicionales_Movimiento");
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

            _IDetalle_Datos_Adicionales_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Datos_Adicionales_MovimientoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Datos_Adicionales_MovimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Datos_Adicionales_Movimientos == null)
                result.Detalle_Datos_Adicionales_Movimientos = new List<Detalle_Datos_Adicionales_Movimiento>();

            var data = result.Detalle_Datos_Adicionales_Movimientos.Select(m => new Detalle_Datos_Adicionales_MovimientoGridModel
            {
                Clave = m.Clave
                ,Dato = m.Dato
                ,Tipo_de_DatoDescripcion = (string)m.Tipo_de_Dato_Tipo_de_Dato.Descripcion
                ,RelacionDescripcion = (string)m.Relacion_Relaciones_para_Movimientos.Descripcion
                ,Obligatorio = m.Obligatorio

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Detalle_Datos_Adicionales_MovimientoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Detalle_Datos_Adicionales_MovimientoList_" + DateTime.Now.ToString());
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

            _IDetalle_Datos_Adicionales_MovimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_Datos_Adicionales_MovimientoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_Datos_Adicionales_MovimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_Datos_Adicionales_Movimientos == null)
                result.Detalle_Datos_Adicionales_Movimientos = new List<Detalle_Datos_Adicionales_Movimiento>();

            var data = result.Detalle_Datos_Adicionales_Movimientos.Select(m => new Detalle_Datos_Adicionales_MovimientoGridModel
            {
                Clave = m.Clave
                ,Dato = m.Dato
                ,Tipo_de_DatoDescripcion = (string)m.Tipo_de_Dato_Tipo_de_Dato.Descripcion
                ,RelacionDescripcion = (string)m.Relacion_Relaciones_para_Movimientos.Descripcion
                ,Obligatorio = m.Obligatorio

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
