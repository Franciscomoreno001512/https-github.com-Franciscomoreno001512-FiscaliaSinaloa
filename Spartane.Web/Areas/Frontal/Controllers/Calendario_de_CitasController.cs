using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Calendario_de_Citas;
using Spartane.Core.Domain.Detalle_de_Asignacion_de_Citas;

using Spartane.Core.Domain.Usuario;












using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Calendario_de_Citas;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Calendario_de_Citas;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Asignacion_de_Citas;

using Spartane.Web.Areas.WebApiConsumer.Usuario;











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

using Spartane.Web.Areas.WebApiConsumer.Spartan_Format;
using Spartane.Web.Areas.WebApiConsumer.Spartan_Format_Permissions;
using Spartane.Web.Areas.WebApiConsumer.GeneratePDF;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;

using Spartane.Web.Areas.WebApiConsumer.Spartan_Format_Related;
using Spartane.Core.Domain.Spartan_Format;
using iTextSharp.text.pdf;


namespace Spartane.Web.Areas.Frontal.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class Calendario_de_CitasController : Controller
    {
        #region "variable declaration"

        private ICalendario_de_CitasService service = null;
        private ICalendario_de_CitasApiConsumer _ICalendario_de_CitasApiConsumer;
        private IDetalle_de_Asignacion_de_CitasApiConsumer _IDetalle_de_Asignacion_de_CitasApiConsumer;

        private IUsuarioApiConsumer _IUsuarioApiConsumer;











        private ISpartan_Business_RuleApiConsumer _ISpartan_Business_RuleApiConsumer;
        private ISpartan_BR_Process_Event_DetailApiConsumer _ISpartan_BR_Process_Event_DetailApiConsumer;
        private ISpartane_FileApiConsumer _ISpartane_FileApiConsumer;
        private IAuthenticationApiConsumer _IAuthenticationApiConsumer = null;
        private Spartane_Credential _userCredential = null;
        private ITokenManager _tokenManager = null;
        private IGeneratePDFApiConsumer _IGeneratePDFApiConsumer;
        private ISpartan_FormatApiConsumer _ISpartan_FormatApiConsumer;
        private ISpartan_Format_PermissionsApiConsumer _ISpartan_Format_PermissionsApiConsumer;
		private ISpartan_Format_RelatedApiConsumer _ISpartan_FormatRelatedApiConsumer;

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Calendario_de_CitasController(ICalendario_de_CitasService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ICalendario_de_CitasApiConsumer Calendario_de_CitasApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IDetalle_de_Asignacion_de_CitasApiConsumer Detalle_de_Asignacion_de_CitasApiConsumer , IUsuarioApiConsumer UsuarioApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ICalendario_de_CitasApiConsumer = Calendario_de_CitasApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IDetalle_de_Asignacion_de_CitasApiConsumer = Detalle_de_Asignacion_de_CitasApiConsumer;

            this._IUsuarioApiConsumer = UsuarioApiConsumer;











        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Calendario_de_Citas
        [ObjectAuth(ObjectId = (ModuleObjectId)45081, PermissionType = PermissionTypes.Consult)]
        public ActionResult Index(int ModuleId=0)
        {
			if (Session["AdvanceReportFilter"] != null)
            {
                Session["AdvanceReportFilter"] = null;
                Session["AdvanceSearch"] = null;
            }
			if (ModuleId == 0)
            {
                ModuleId = Convert.ToInt32(Session["CurrentModuleId"]);
                if (ModuleId == 0)
                {
                    Response.Redirect("~/");
                }
            }
            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45081, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Calendario_de_Citas/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45081, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45081, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varCalendario_de_Citas = new Calendario_de_CitasModel();
			varCalendario_de_Citas.Clave = Id;
			
            ViewBag.ObjectId = "45081";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_de_Asignacion_de_Citas = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45084, ModuleId);
            ViewBag.PermissionDetalle_de_Asignacion_de_Citas = permissionDetalle_de_Asignacion_de_Citas;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _ICalendario_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Calendario_de_CitassData = _ICalendario_de_CitasApiConsumer.ListaSelAll(0, 1000, "Calendario_de_Citas.Clave=" + Id, "").Resource.Calendario_de_Citass;
				
				if (Calendario_de_CitassData != null && Calendario_de_CitassData.Count > 0)
                {
					var Calendario_de_CitasData = Calendario_de_CitassData.First();
					varCalendario_de_Citas= new Calendario_de_CitasModel
					{
						Clave  = Calendario_de_CitasData.Clave 
	                    ,Pertenece_a = Calendario_de_CitasData.Pertenece_a

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            ViewBag.Consult = consult == 1;
			if (consult == 1)
                ViewBag.Operation = "Consult";
				
			var viewInEframe = false;
			var isPartial = false;
            var isMR = false;
            var nameMR = string.Empty;
            var nameAttribute = string.Empty;

	        if (Request.QueryString["isPartial"]!= null)
                isPartial = Convert.ToBoolean(Request.QueryString["isPartial"]);

            if (Request.QueryString["isMR"] != null)
                isMR = Convert.ToBoolean(Request.QueryString["isMR"]);

            if (Request.QueryString["nameMR"] != null)
                nameMR = Request.QueryString["nameMR"].ToString();

            if (Request.QueryString["nameAttribute"] != null)
                nameAttribute = Request.QueryString["nameAttribute"].ToString();
				
			if (Request.QueryString["viewInEframe"] != null)
                viewInEframe = Convert.ToBoolean(Request.QueryString["viewInEframe"]);	
				
			ViewBag.isPartial=isPartial;
			ViewBag.isMR=isMR;
			ViewBag.nameMR=nameMR;
			ViewBag.nameAttribute=nameAttribute;
			ViewBag.viewInEframe = viewInEframe;

				
            return View(varCalendario_de_Citas);
        }
		
	[HttpGet]
        public ActionResult AddCalendario_de_Citas(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45081);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ICalendario_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);
			Calendario_de_CitasModel varCalendario_de_Citas= new Calendario_de_CitasModel();
            var permissionDetalle_de_Asignacion_de_Citas = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45084, ModuleId);
            ViewBag.PermissionDetalle_de_Asignacion_de_Citas = permissionDetalle_de_Asignacion_de_Citas;


            if (id.ToString() != "0")
            {
                var Calendario_de_CitassData = _ICalendario_de_CitasApiConsumer.ListaSelAll(0, 1000, "Calendario_de_Citas.Clave=" + id, "").Resource.Calendario_de_Citass;
				
				if (Calendario_de_CitassData != null && Calendario_de_CitassData.Count > 0)
                {
					var Calendario_de_CitasData = Calendario_de_CitassData.First();
					varCalendario_de_Citas= new Calendario_de_CitasModel
					{
						Clave  = Calendario_de_CitasData.Clave 
	                    ,Pertenece_a = Calendario_de_CitasData.Pertenece_a

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddCalendario_de_Citas", varCalendario_de_Citas);
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




        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Calendario_de_CitasAdvanceSearchModel model, int idFilter = -1)
        {
            if (ModelState.IsValid)
            {
                Session["AdvanceSearch"] = model;
				if (idFilter != -1)
                {
                    Session["AdvanceReportFilter"] = GetAdvanceFilter(model);
                    return RedirectToAction("Index", "Report", new { id = idFilter });
                }
                return RedirectToAction("Index");
            }
            ViewBag.Filter = new List<SelectListItem>
            {
                new SelectListItem() {Text = Resources.Resources.BeginWith, Value = "1"},
                new SelectListItem() {Text = Resources.Resources.EndWith, Value = "2"},
                new SelectListItem() {Text = Resources.Resources.Contains, Value = "4"},
                new SelectListItem() {Text = Resources.Resources.Exact, Value = "3"},
            };
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            var previousFiltersObj = new Calendario_de_CitasAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Calendario_de_CitasAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Calendario_de_CitasAdvanceSearchModel());
            }

            ViewBag.Filter = new List<SelectListItem>
            {
                new SelectListItem() {Text = Resources.Resources.BeginWith, Value = "1"},
                new SelectListItem() {Text = Resources.Resources.EndWith, Value = "2"},
                new SelectListItem() {Text = Resources.Resources.Contains, Value = "4"},
                new SelectListItem() {Text = Resources.Resources.Exact, Value = "3"},

            };

            return View(previousFiltersObj);
        }

        public ActionResult Get()
        {
            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Calendario_de_CitasPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ICalendario_de_CitasApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Calendario_de_Citass == null)
                result.Calendario_de_Citass = new List<Calendario_de_Citas>();

            return Json(new
            {
                data = result.Calendario_de_Citass.Select(m => new Calendario_de_CitasGridModel
                    {
                    Clave = m.Clave
			,Pertenece_a = m.Pertenece_a

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetCalendario_de_CitasAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICalendario_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICalendario_de_CitasApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Calendario_de_Citas", m.),
                     Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
*/
        /// <summary>
        /// Get List of Calendario_de_Citas from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Calendario_de_Citas Entity</returns>
        public ActionResult GetCalendario_de_CitasList(UrlParametersModel param)
        {
			 int sEcho = param.sEcho;
            int iDisplayStart = param.iDisplayStart;
            int iDisplayLength = param.iDisplayLength;
            string where = param.where;
            string order = param.order;

            where = HttpUtility.UrlEncode(where);
            int sortColumn = -1;
            string sortDirection = "asc";
            if (iDisplayLength == -1)
            {
                //length = TOTAL_ROWS;
                iDisplayLength = Int32.MaxValue;
            }
            // note: we only sort one column at a time
            if (param.sortColumn != null)
            {
                sortColumn = int.Parse(param.sortColumn);
            }
            if (param.sortDirection != null)
            {
                sortDirection = param.sortDirection;
            }


            if (!_tokenManager.GenerateToken())
                return null;
            _ICalendario_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Calendario_de_CitasPropertyMapper());
				
			if (!String.IsNullOrEmpty(where))
            {
                 configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
            if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            //Adding Advance Search
            if (param.AdvanceSearch != null && param.AdvanceSearch == true && Session["AdvanceSearch"] != null)            
            {
				if (Session["AdvanceSearch"].GetType() == typeof(Calendario_de_CitasAdvanceSearchModel))
                {
					var advanceFilter =
                    (Calendario_de_CitasAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Calendario_de_CitasPropertyMapper oCalendario_de_CitasPropertyMapper = new Calendario_de_CitasPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oCalendario_de_CitasPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _ICalendario_de_CitasApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Calendario_de_Citass == null)
                result.Calendario_de_Citass = new List<Calendario_de_Citas>();

            return Json(new
            {
                aaData = result.Calendario_de_Citass.Select(m => new Calendario_de_CitasGridModel
            {
                    Clave = m.Clave
			,Pertenece_a = m.Pertenece_a

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(Calendario_de_CitasAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Calendario_de_Citas.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Calendario_de_Citas.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.FromPertenece_a) || !string.IsNullOrEmpty(filter.ToPertenece_a))
            {
                if (!string.IsNullOrEmpty(filter.FromPertenece_a))
                    where += " AND Calendario_de_Citas.Pertenece_a >= " + filter.FromPertenece_a;
                if (!string.IsNullOrEmpty(filter.ToPertenece_a))
                    where += " AND Calendario_de_Citas.Pertenece_a <= " + filter.ToPertenece_a;
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_de_Asignacion_de_Citas(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Asignacion_de_CitasGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Asignacion_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Asignacion_de_Citas.Calendario_de_Citas=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Asignacion_de_Citas.Calendario_de_Citas='" + RelationId + "'";
            }
            var result = _IDetalle_de_Asignacion_de_CitasApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Asignacion_de_Citass == null)
                result.Detalle_de_Asignacion_de_Citass = new List<Detalle_de_Asignacion_de_Citas>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Asignacion_de_Citass.Select(m => new Detalle_de_Asignacion_de_CitasGridModel
                {
                    Clave = m.Clave

                        ,Numero_de_Empleado = m.Numero_de_Empleado
                        ,Numero_de_EmpleadoNumero_de_Empleado = CultureHelper.GetTraduction(m.Numero_de_Empleado_Usuario.Clave.ToString(), "Numero_de_Empleado") ??(string)m.Numero_de_Empleado_Usuario.Numero_de_Empleado
			,Nombre_de_Empleado = m.Nombre_de_Empleado
			,Lunes = m.Lunes
			,Martes = m.Martes
			,Miercoles = m.Miercoles
			,Jueves = m.Jueves
			,Viernes = m.Viernes
			,Sabado = m.Sabado
			,Domingo = m.Domingo
			,Hora_Inicio = m.Hora_Inicio
			,Hora_Fin = m.Hora_Fin

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Asignacion_de_CitasGridModel> GetDetalle_de_Asignacion_de_CitasData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Asignacion_de_CitasGridModel> resultData = new List<Detalle_de_Asignacion_de_CitasGridModel>();
            string where = "Detalle_de_Asignacion_de_Citas.Calendario_de_Citas=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Asignacion_de_Citas.Calendario_de_Citas='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Asignacion_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Asignacion_de_CitasApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Asignacion_de_Citass != null)
            {
                resultData = result.Detalle_de_Asignacion_de_Citass.Select(m => new Detalle_de_Asignacion_de_CitasGridModel
                    {
                        Clave = m.Clave

                        ,Numero_de_Empleado = m.Numero_de_Empleado
                        ,Numero_de_EmpleadoNumero_de_Empleado = CultureHelper.GetTraduction(m.Numero_de_Empleado_Usuario.Clave.ToString(), "Numero_de_Empleado") ??(string)m.Numero_de_Empleado_Usuario.Numero_de_Empleado
			,Nombre_de_Empleado = m.Nombre_de_Empleado
			,Lunes = m.Lunes
			,Martes = m.Martes
			,Miercoles = m.Miercoles
			,Jueves = m.Jueves
			,Viernes = m.Viernes
			,Sabado = m.Sabado
			,Domingo = m.Domingo
			,Hora_Inicio = m.Hora_Inicio
			,Hora_Fin = m.Hora_Fin


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }


        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICalendario_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);

                Calendario_de_Citas varCalendario_de_Citas = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_de_Asignacion_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Asignacion_de_Citas.Calendario_de_Citas=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Asignacion_de_Citas.Calendario_de_Citas='" + id + "'";
                    }
                    var Detalle_de_Asignacion_de_CitasInfo =
                        _IDetalle_de_Asignacion_de_CitasApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Asignacion_de_CitasInfo.Detalle_de_Asignacion_de_Citass.Count > 0)
                    {
                        var resultDetalle_de_Asignacion_de_Citas = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Asignacion_de_CitasItem in Detalle_de_Asignacion_de_CitasInfo.Detalle_de_Asignacion_de_Citass)
                            resultDetalle_de_Asignacion_de_Citas = resultDetalle_de_Asignacion_de_Citas
                                              && _IDetalle_de_Asignacion_de_CitasApiConsumer.Delete(Detalle_de_Asignacion_de_CitasItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Asignacion_de_Citas)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _ICalendario_de_CitasApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Calendario_de_CitasModel varCalendario_de_Citas)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ICalendario_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Calendario_de_CitasInfo = new Calendario_de_Citas
                    {
                        Clave = varCalendario_de_Citas.Clave
                        ,Pertenece_a = varCalendario_de_Citas.Pertenece_a

                    };

                    result = !IsNew ?
                        _ICalendario_de_CitasApiConsumer.Update(Calendario_de_CitasInfo, null, null).Resource.ToString() :
                         _ICalendario_de_CitasApiConsumer.Insert(Calendario_de_CitasInfo, null, null).Resource.ToString();
					Session["KeyValueInserted"] = result;
                    return Json(result, JsonRequestBehavior.AllowGet);
				//}
				//return Json(false, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [NonAction]
        public bool CopyDetalle_de_Asignacion_de_Citas(int MasterId, int referenceId, List<Detalle_de_Asignacion_de_CitasGridModelPost> Detalle_de_Asignacion_de_CitasItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Asignacion_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Asignacion_de_CitasData = _IDetalle_de_Asignacion_de_CitasApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Asignacion_de_Citas.Calendario_de_Citas=" + referenceId,"").Resource;
                if (Detalle_de_Asignacion_de_CitasData == null || Detalle_de_Asignacion_de_CitasData.Detalle_de_Asignacion_de_Citass.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Asignacion_de_CitasGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Asignacion_de_Citas in Detalle_de_Asignacion_de_CitasData.Detalle_de_Asignacion_de_Citass)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Asignacion_de_Citas Detalle_de_Asignacion_de_Citas1 = varDetalle_de_Asignacion_de_Citas;

                    if (Detalle_de_Asignacion_de_CitasItems != null && Detalle_de_Asignacion_de_CitasItems.Any(m => m.Clave == Detalle_de_Asignacion_de_Citas1.Clave))
                    {
                        modelDataToChange = Detalle_de_Asignacion_de_CitasItems.FirstOrDefault(m => m.Clave == Detalle_de_Asignacion_de_Citas1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Asignacion_de_Citas.Calendario_de_Citas = MasterId;
                    var insertId = _IDetalle_de_Asignacion_de_CitasApiConsumer.Insert(varDetalle_de_Asignacion_de_Citas,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Clave = insertId;

                    result = insertId > 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPost]
        public ActionResult PostDetalle_de_Asignacion_de_Citas(List<Detalle_de_Asignacion_de_CitasGridModelPost> Detalle_de_Asignacion_de_CitasItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Asignacion_de_Citas(MasterId, referenceId, Detalle_de_Asignacion_de_CitasItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Asignacion_de_CitasItems != null && Detalle_de_Asignacion_de_CitasItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Asignacion_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Asignacion_de_CitasItem in Detalle_de_Asignacion_de_CitasItems)
                    {













                        //Removal Request
                        if (Detalle_de_Asignacion_de_CitasItem.Removed)
                        {
                            result = result && _IDetalle_de_Asignacion_de_CitasApiConsumer.Delete(Detalle_de_Asignacion_de_CitasItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Asignacion_de_CitasItem.Clave = 0;

                        var Detalle_de_Asignacion_de_CitasData = new Detalle_de_Asignacion_de_Citas
                        {
                            Calendario_de_Citas = MasterId
                            ,Clave = Detalle_de_Asignacion_de_CitasItem.Clave
                            ,Numero_de_Empleado = (Convert.ToInt32(Detalle_de_Asignacion_de_CitasItem.Numero_de_Empleado) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_de_Asignacion_de_CitasItem.Numero_de_Empleado))
                            ,Nombre_de_Empleado = Detalle_de_Asignacion_de_CitasItem.Nombre_de_Empleado
                            ,Lunes = Detalle_de_Asignacion_de_CitasItem.Lunes
                            ,Martes = Detalle_de_Asignacion_de_CitasItem.Martes
                            ,Miercoles = Detalle_de_Asignacion_de_CitasItem.Miercoles
                            ,Jueves = Detalle_de_Asignacion_de_CitasItem.Jueves
                            ,Viernes = Detalle_de_Asignacion_de_CitasItem.Viernes
                            ,Sabado = Detalle_de_Asignacion_de_CitasItem.Sabado
                            ,Domingo = Detalle_de_Asignacion_de_CitasItem.Domingo
                            ,Hora_Inicio = Detalle_de_Asignacion_de_CitasItem.Hora_Inicio
                            ,Hora_Fin = Detalle_de_Asignacion_de_CitasItem.Hora_Fin

                        };

                        var resultId = Detalle_de_Asignacion_de_CitasItem.Clave > 0
                           ? _IDetalle_de_Asignacion_de_CitasApiConsumer.Update(Detalle_de_Asignacion_de_CitasData,null,null).Resource
                           : _IDetalle_de_Asignacion_de_CitasApiConsumer.Insert(Detalle_de_Asignacion_de_CitasData,null,null).Resource;

                        result = result && resultId != -1;
                    }
                }
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public ActionResult GetDetalle_de_Asignacion_de_Citas_UsuarioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUsuarioApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Usuario", "Numero_de_Empleado");
                  item.Numero_de_Empleado= trans??item.Numero_de_Empleado;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }













        /// <summary>
        /// Write Element Array of Calendario_de_Citas script
        /// </summary>
        /// <param name="oCalendario_de_CitasElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Calendario_de_CitasModuleAttributeList)
        {
            for (int i = 0; i < Calendario_de_CitasModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Calendario_de_CitasModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Calendario_de_CitasModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Calendario_de_CitasModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Calendario_de_CitasModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Calendario_de_CitasModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Calendario_de_CitasModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Calendario_de_CitasModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Calendario_de_CitasModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Calendario_de_CitasModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Calendario_de_CitasModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Calendario_de_CitasModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strCalendario_de_CitasScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Calendario_de_Citas.js")))
            {
                strCalendario_de_CitasScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Calendario_de_Citas element attributes
            string userChangeJson = jsSerialize.Serialize(Calendario_de_CitasModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strCalendario_de_CitasScript.IndexOf("inpuElementArray");
            string splittedString = strCalendario_de_CitasScript.Substring(indexOfArray, strCalendario_de_CitasScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Calendario_de_CitasModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Calendario_de_CitasModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strCalendario_de_CitasScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strCalendario_de_CitasScript.Substring(indexOfArrayHistory, strCalendario_de_CitasScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strCalendario_de_CitasScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strCalendario_de_CitasScript.Substring(endIndexOfMainElement + indexOfArray, strCalendario_de_CitasScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Calendario_de_CitasModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Calendario_de_CitasModuleAttributeList.ChildModuleAttributeList)
                {
				if (item!= null && item.elements != null  && item.elements.Count>0)
                    ResponseChild += "\r\n  \n\r function set" + item.table + "Validation() { " +
                                    " \r\n var inpuElementChildArray =" + jsSerialize.Serialize(item.elements) + ";" +
                                    "  \r\n setInputEntityAttributes(inpuElementChildArray, \".\", 0);" +
                                    "  \r\n setDynamicRenderElement(); \n\r } ";

                }
            }
            finalResponse = finalResponse.Substring(0, finalResponse.IndexOf("});") + 4) +  "\n\r";
            finalResponse += ResponseChild;
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Calendario_de_Citas.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Calendario_de_Citas.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Calendario_de_Citas.js")))
                {
                    strCustomScript = r.ReadToEnd();
                
                }

                int indexOfArray = strCustomScript.IndexOf("inpuElementArray");
                string splittedString = strCustomScript.Substring(indexOfArray, strCustomScript.Length - indexOfArray);                
                int indexOfMainElement = splittedString.IndexOf('[');                
                int endIndexOfMainElement = splittedString.IndexOf(']') + 1;                
                string mainJsonArray = splittedString.Substring(indexOfMainElement, endIndexOfMainElement - indexOfMainElement);

                int indexOfChildArray = strCustomScript.IndexOf("function set");
                string childJsonArray = "[";
                if (indexOfChildArray != -1)
                {
                    string splittedChildString = strCustomScript.Substring(indexOfChildArray, strCustomScript.Length - indexOfChildArray);

                    var funcionsValidations = splittedChildString.Split(new string[] { "function" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var str in funcionsValidations)
                    {
                        var tabla = str.Substring(0, str.IndexOf('('));
                        tabla = tabla.Trim().Replace("set", string.Empty).Replace("Validation", string.Empty);
                        childJsonArray += "{ \"table\": \"" + tabla + "\", \"elements\":";
                        int indexOfChildElement = str.IndexOf('[');
                        int endIndexOfChildElement = str.IndexOf(']') + 1;
                        childJsonArray += str.Substring(indexOfChildElement, endIndexOfChildElement - indexOfChildElement) + "},";
                    }
                }
                childJsonArray = childJsonArray.TrimEnd(',') + "]";
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
        public ActionResult Calendario_de_CitasPropertyBag()
        {
            return PartialView("Calendario_de_CitasPropertyBag", "Calendario_de_Citas");
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

        [HttpGet]
        public ActionResult AddDetalle_de_Asignacion_de_Citas(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Asignacion_de_Citas/AddDetalle_de_Asignacion_de_Citas");
        }



        #endregion "Controller Methods"

        #region "Custom methods"
		
		[HttpGet]
        public FileStreamResult PrintFormats(int idFormat, string RecordId)
        {
            if (!_tokenManager.GenerateToken())
                return null;

            _IGeneratePDFApiConsumer.SetAuthHeader(_tokenManager.Token);
            _ISpartan_FormatRelatedApiConsumer.SetAuthHeader(_tokenManager.Token);

            MemoryStream ms = new MemoryStream();
           
            //Buscar los Formatos Relacionados
            var relacionados = _ISpartan_FormatRelatedApiConsumer.ListaSelAll(0, 5000, "Spartan_Format_Related.FormatId = " + idFormat, "").Resource.Spartan_Format_Relateds.OrderBy(r => r.Order).ToList();
            if (relacionados.Count > 0)
            {
                var outputDocument = new iTextSharp.text.Document();
                var writer = new PdfCopy(outputDocument, ms);
                outputDocument.Open();
                foreach (var spartan_Format_Related in relacionados)
                {
                    var bytePdf = _IGeneratePDFApiConsumer.GeneratePDF(Convert.ToInt32(spartan_Format_Related.FormatId_Related), RecordId).Resource;
                    var reader = new PdfReader(bytePdf);
                    for (var j = 1; j <= reader.NumberOfPages; j++)
                    {
                        writer.AddPage(writer.GetImportedPage(reader, j));
                    }
                    writer.FreeReader(reader);
                    reader.Close();
                }
                writer.Close();
                outputDocument.Close();
                var allPagesContent = ms.GetBuffer();
                ms.Flush();
            }
            else {
                var bytePdf = _IGeneratePDFApiConsumer.GeneratePDF(idFormat, RecordId);
                ms.Write(bytePdf.Resource, 0, bytePdf.Resource.Length);           
            }
                
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Formatos.pdf");
            Response.Buffer = true;
            Response.Clear();
            Response.OutputStream.Write(ms.GetBuffer(), 0, ms.GetBuffer().Length);
            Response.OutputStream.Flush();
            Response.End();

            return new FileStreamResult(Response.OutputStream, "application/pdf");
        }
		
		
		
		[HttpGet]
        public ActionResult GetFormats(string RecordId)
        {
            if (!_tokenManager.GenerateToken())
                return null;

            var formatList = new List<SelectListItem>();

            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);
            _ISpartan_Format_PermissionsApiConsumer.SetAuthHeader(_tokenManager.Token);
           _ISpartan_FormatApiConsumer.SetAuthHeader(_tokenManager.Token);

            var whereClause = " Spartan_Format_Permissions.Spartan_User_Role = " + SessionHelper.Role + " AND Spartan_Format_Permissions.Permission_Type = 1 AND Apply=1 ";
            var formatsPermisions = _ISpartan_Format_PermissionsApiConsumer.ListaSelAll(0, 500, whereClause, string.Empty).Resource;
            if (formatsPermisions.RowCount > 0)
            {
                var formats = string.Join(",", formatsPermisions.Spartan_Format_Permissionss.Select(f => f.Format).ToArray());
                var whereClauseFormat = "Object = 45081 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _ICalendario_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Calendario_de_Citas.Clave= " + RecordId;
                            var result = _ICalendario_de_CitasApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
                            if (result != null && result.Resource != null && result.Resource.RowCount > 0)
                            {
                                formatList.Add(new SelectListItem
                                {
                                    Text =  CultureHelper.GetTraductionAdd(format.FormatId.ToString(), "Format", format.Format_Name),
                                    Value = Convert.ToString(format.FormatId)
                                });
                            }
                        }
                        else
                        {
                            formatList.Add(new SelectListItem
                            {
                                Text =  CultureHelper.GetTraductionAdd(format.FormatId.ToString(), "Format", format.Format_Name),
                                Value = Convert.ToString(format.FormatId)
                            });
                        }


                    }
                }
            }
            return Json(formatList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public void Export(string format, int pageIndex, int pageSize, string iSortCol, string sSortDir, string where, string order, dynamic columnsVisible)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);
										  
			string[] arrayColumnsVisible = ((string[])columnsVisible)[0].ToString().Split(',');

			 where = HttpUtility.UrlEncode(where);
            if (!_tokenManager.GenerateToken())
                return;

            _ICalendario_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Calendario_de_CitasPropertyMapper());
			
			 if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
            if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            //Adding Advance Search
            if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Calendario_de_CitasAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Calendario_de_CitasPropertyMapper oCalendario_de_CitasPropertyMapper = new Calendario_de_CitasPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oCalendario_de_CitasPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ICalendario_de_CitasApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Calendario_de_Citass == null)
                result.Calendario_de_Citass = new List<Calendario_de_Citas>();

            var data = result.Calendario_de_Citass.Select(m => new Calendario_de_CitasGridModel
            {
                Clave = m.Clave
			,Pertenece_a = m.Pertenece_a

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45081, arrayColumnsVisible), "Calendario_de_CitasList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45081, arrayColumnsVisible), "Calendario_de_CitasList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45081, arrayColumnsVisible), "Calendario_de_CitasList_" + DateTime.Now.ToString());
                    break;
            }
        }

        [HttpGet]
        //[ObjectAuth(ObjectId = ModuleObjectId.EMPLEADOS_OBJECT, PermissionType = PermissionTypes.Export)]
        public ActionResult Print(string format, int pageIndex, int pageSize, string iSortCol, string sSortDir,string where, string order)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);

			where = HttpUtility.UrlEncode(where);
										   
            if (!_tokenManager.GenerateToken())
                return null;

            _ICalendario_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Calendario_de_CitasPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Calendario_de_CitasAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Calendario_de_CitasPropertyMapper oCalendario_de_CitasPropertyMapper = new Calendario_de_CitasPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oCalendario_de_CitasPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ICalendario_de_CitasApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Calendario_de_Citass == null)
                result.Calendario_de_Citass = new List<Calendario_de_Citas>();

            var data = result.Calendario_de_Citass.Select(m => new Calendario_de_CitasGridModel
            {
                Clave = m.Clave
			,Pertenece_a = m.Pertenece_a

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
		
		[HttpGet]
        public JsonResult CreateID()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICalendario_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICalendario_de_CitasApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Calendario_de_Citas_Datos_GeneralesModel varCalendario_de_Citas)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICalendario_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Calendario_de_Citas_Datos_GeneralesInfo = new Calendario_de_Citas_Datos_Generales
                {
                    Clave = varCalendario_de_Citas.Clave
                                            ,Pertenece_a = varCalendario_de_Citas.Pertenece_a
                    
                };

                result = _ICalendario_de_CitasApiConsumer.Update_Datos_Generales(Calendario_de_Citas_Datos_GeneralesInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_Generales(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICalendario_de_CitasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ICalendario_de_CitasApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Asignacion_de_Citas;
                var Detalle_de_Asignacion_de_CitasData = GetDetalle_de_Asignacion_de_CitasData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Asignacion_de_Citas);

                var result = new Calendario_de_Citas_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Pertenece_a = m.Pertenece_a

                    
                };
				var resultData = new
                {
                    data = result
                    ,Calendario_de_CitasC = Detalle_de_Asignacion_de_CitasData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

