using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Registro_de_Usuario;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Registro_de_Usuario;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Registro_de_Usuario;

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
    public class Registro_de_UsuarioController : Controller
    {
        #region "variable declaration"

        private IRegistro_de_UsuarioService service = null;
        private IRegistro_de_UsuarioApiConsumer _IRegistro_de_UsuarioApiConsumer;

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

        
        public Registro_de_UsuarioController(IRegistro_de_UsuarioService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IRegistro_de_UsuarioApiConsumer Registro_de_UsuarioApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IRegistro_de_UsuarioApiConsumer = Registro_de_UsuarioApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Registro_de_Usuario
        [ObjectAuth(ObjectId = (ModuleObjectId)45684, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45684, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Registro_de_Usuario/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45684, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45684, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varRegistro_de_Usuario = new Registro_de_UsuarioModel();
			varRegistro_de_Usuario.Clave = Id;
			
            ViewBag.ObjectId = "45684";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IRegistro_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Registro_de_UsuariosData = _IRegistro_de_UsuarioApiConsumer.ListaSelAll(0, 1000, "Registro_de_Usuario.Clave=" + Id, "").Resource.Registro_de_Usuarios;
				
				if (Registro_de_UsuariosData != null && Registro_de_UsuariosData.Count > 0)
                {
					var Registro_de_UsuarioData = Registro_de_UsuariosData.First();
					varRegistro_de_Usuario= new Registro_de_UsuarioModel
					{
						Clave  = Registro_de_UsuarioData.Clave 
	                    ,Nombres = Registro_de_UsuarioData.Nombres
                    ,Apellido_Paterno = Registro_de_UsuarioData.Apellido_Paterno
                    ,Apellido_Materno = Registro_de_UsuarioData.Apellido_Materno
                    ,Nombre_Completo = Registro_de_UsuarioData.Nombre_Completo
                    ,Usuario = Registro_de_UsuarioData.Usuario
                    ,Contrasena = Registro_de_UsuarioData.Contrasena
                    ,Confirmar_Contrasena = Registro_de_UsuarioData.Confirmar_Contrasena
                    ,Correo = Registro_de_UsuarioData.Correo
                    ,Celular = Registro_de_UsuarioData.Celular
                    ,Codigo_Verificacion_Correo = Registro_de_UsuarioData.Codigo_Verificacion_Correo
                    ,Codigo_Verificacion_Celular = Registro_de_UsuarioData.Codigo_Verificacion_Celular
                    ,Codigo_Reestablecer_Contrasena = Registro_de_UsuarioData.Codigo_Reestablecer_Contrasena
                    ,El_correo_fue_Validado = Registro_de_UsuarioData.El_correo_fue_Validado.GetValueOrDefault()
                    ,El_Celular_fue_Validado = Registro_de_UsuarioData.El_Celular_fue_Validado.GetValueOrDefault()

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

				
            return View(varRegistro_de_Usuario);
        }
		
	[HttpGet]
        public ActionResult AddRegistro_de_Usuario(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45684);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IRegistro_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
			Registro_de_UsuarioModel varRegistro_de_Usuario= new Registro_de_UsuarioModel();


            if (id.ToString() != "0")
            {
                var Registro_de_UsuariosData = _IRegistro_de_UsuarioApiConsumer.ListaSelAll(0, 1000, "Registro_de_Usuario.Clave=" + id, "").Resource.Registro_de_Usuarios;
				
				if (Registro_de_UsuariosData != null && Registro_de_UsuariosData.Count > 0)
                {
					var Registro_de_UsuarioData = Registro_de_UsuariosData.First();
					varRegistro_de_Usuario= new Registro_de_UsuarioModel
					{
						Clave  = Registro_de_UsuarioData.Clave 
	                    ,Nombres = Registro_de_UsuarioData.Nombres
                    ,Apellido_Paterno = Registro_de_UsuarioData.Apellido_Paterno
                    ,Apellido_Materno = Registro_de_UsuarioData.Apellido_Materno
                    ,Nombre_Completo = Registro_de_UsuarioData.Nombre_Completo
                    ,Usuario = Registro_de_UsuarioData.Usuario
                    ,Contrasena = Registro_de_UsuarioData.Contrasena
                    ,Confirmar_Contrasena = Registro_de_UsuarioData.Confirmar_Contrasena
                    ,Correo = Registro_de_UsuarioData.Correo
                    ,Celular = Registro_de_UsuarioData.Celular
                    ,Codigo_Verificacion_Correo = Registro_de_UsuarioData.Codigo_Verificacion_Correo
                    ,Codigo_Verificacion_Celular = Registro_de_UsuarioData.Codigo_Verificacion_Celular
                    ,Codigo_Reestablecer_Contrasena = Registro_de_UsuarioData.Codigo_Reestablecer_Contrasena
                    ,El_correo_fue_Validado = Registro_de_UsuarioData.El_correo_fue_Validado.GetValueOrDefault()
                    ,El_Celular_fue_Validado = Registro_de_UsuarioData.El_Celular_fue_Validado.GetValueOrDefault()

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddRegistro_de_Usuario", varRegistro_de_Usuario);
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
        public ActionResult ShowAdvanceFilter(Registro_de_UsuarioAdvanceSearchModel model, int idFilter = -1)
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



            var previousFiltersObj = new Registro_de_UsuarioAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Registro_de_UsuarioAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Registro_de_UsuarioAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Registro_de_UsuarioPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IRegistro_de_UsuarioApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Usuarios == null)
                result.Registro_de_Usuarios = new List<Registro_de_Usuario>();

            return Json(new
            {
                data = result.Registro_de_Usuarios.Select(m => new Registro_de_UsuarioGridModel
                    {
                    Clave = m.Clave
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Usuario = m.Usuario
			,Contrasena = m.Contrasena
			,Confirmar_Contrasena = m.Confirmar_Contrasena
			,Correo = m.Correo
			,Celular = m.Celular
			,Codigo_Verificacion_Correo = m.Codigo_Verificacion_Correo
			,Codigo_Verificacion_Celular = m.Codigo_Verificacion_Celular
			,Codigo_Reestablecer_Contrasena = m.Codigo_Reestablecer_Contrasena
			,El_correo_fue_Validado = m.El_correo_fue_Validado
			,El_Celular_fue_Validado = m.El_Celular_fue_Validado

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetRegistro_de_UsuarioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegistro_de_UsuarioApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Registro_de_Usuario", m.),
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
        /// Get List of Registro_de_Usuario from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Registro_de_Usuario Entity</returns>
        public ActionResult GetRegistro_de_UsuarioList(UrlParametersModel param)
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
            _IRegistro_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Registro_de_UsuarioPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Registro_de_UsuarioAdvanceSearchModel))
                {
					var advanceFilter =
                    (Registro_de_UsuarioAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Registro_de_UsuarioPropertyMapper oRegistro_de_UsuarioPropertyMapper = new Registro_de_UsuarioPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oRegistro_de_UsuarioPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IRegistro_de_UsuarioApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Usuarios == null)
                result.Registro_de_Usuarios = new List<Registro_de_Usuario>();

            return Json(new
            {
                aaData = result.Registro_de_Usuarios.Select(m => new Registro_de_UsuarioGridModel
            {
                    Clave = m.Clave
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Usuario = m.Usuario
			,Contrasena = m.Contrasena
			,Confirmar_Contrasena = m.Confirmar_Contrasena
			,Correo = m.Correo
			,Celular = m.Celular
			,Codigo_Verificacion_Correo = m.Codigo_Verificacion_Correo
			,Codigo_Verificacion_Celular = m.Codigo_Verificacion_Celular
			,Codigo_Reestablecer_Contrasena = m.Codigo_Reestablecer_Contrasena
			,El_correo_fue_Validado = m.El_correo_fue_Validado
			,El_Celular_fue_Validado = m.El_Celular_fue_Validado

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }







        [NonAction]
        public string GetAdvanceFilter(Registro_de_UsuarioAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Registro_de_Usuario.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Registro_de_Usuario.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Nombres))
            {
                switch (filter.NombresFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Usuario.Nombres LIKE '" + filter.Nombres + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Usuario.Nombres LIKE '%" + filter.Nombres + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Usuario.Nombres = '" + filter.Nombres + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Usuario.Nombres LIKE '%" + filter.Nombres + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Paterno))
            {
                switch (filter.Apellido_PaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Usuario.Apellido_Paterno LIKE '" + filter.Apellido_Paterno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Usuario.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Usuario.Apellido_Paterno = '" + filter.Apellido_Paterno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Usuario.Apellido_Paterno LIKE '%" + filter.Apellido_Paterno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Apellido_Materno))
            {
                switch (filter.Apellido_MaternoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Usuario.Apellido_Materno LIKE '" + filter.Apellido_Materno + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Usuario.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Usuario.Apellido_Materno = '" + filter.Apellido_Materno + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Usuario.Apellido_Materno LIKE '%" + filter.Apellido_Materno + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Nombre_Completo))
            {
                switch (filter.Nombre_CompletoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Usuario.Nombre_Completo LIKE '" + filter.Nombre_Completo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Usuario.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Usuario.Nombre_Completo = '" + filter.Nombre_Completo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Usuario.Nombre_Completo LIKE '%" + filter.Nombre_Completo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Usuario))
            {
                switch (filter.UsuarioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Usuario.Usuario LIKE '" + filter.Usuario + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Usuario.Usuario LIKE '%" + filter.Usuario + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Usuario.Usuario = '" + filter.Usuario + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Usuario.Usuario LIKE '%" + filter.Usuario + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Contrasena))
            {
                switch (filter.ContrasenaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Usuario.Contrasena LIKE '" + filter.Contrasena + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Usuario.Contrasena LIKE '%" + filter.Contrasena + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Usuario.Contrasena = '" + filter.Contrasena + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Usuario.Contrasena LIKE '%" + filter.Contrasena + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Confirmar_Contrasena))
            {
                switch (filter.Confirmar_ContrasenaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Usuario.Confirmar_Contrasena LIKE '" + filter.Confirmar_Contrasena + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Usuario.Confirmar_Contrasena LIKE '%" + filter.Confirmar_Contrasena + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Usuario.Confirmar_Contrasena = '" + filter.Confirmar_Contrasena + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Usuario.Confirmar_Contrasena LIKE '%" + filter.Confirmar_Contrasena + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Correo))
            {
                switch (filter.CorreoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Usuario.Correo LIKE '" + filter.Correo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Usuario.Correo LIKE '%" + filter.Correo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Usuario.Correo = '" + filter.Correo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Usuario.Correo LIKE '%" + filter.Correo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Celular))
            {
                switch (filter.CelularFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Usuario.Celular LIKE '" + filter.Celular + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Usuario.Celular LIKE '%" + filter.Celular + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Usuario.Celular = '" + filter.Celular + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Usuario.Celular LIKE '%" + filter.Celular + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Codigo_Verificacion_Correo))
            {
                switch (filter.Codigo_Verificacion_CorreoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Usuario.Codigo_Verificacion_Correo LIKE '" + filter.Codigo_Verificacion_Correo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Usuario.Codigo_Verificacion_Correo LIKE '%" + filter.Codigo_Verificacion_Correo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Usuario.Codigo_Verificacion_Correo = '" + filter.Codigo_Verificacion_Correo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Usuario.Codigo_Verificacion_Correo LIKE '%" + filter.Codigo_Verificacion_Correo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Codigo_Verificacion_Celular))
            {
                switch (filter.Codigo_Verificacion_CelularFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Usuario.Codigo_Verificacion_Celular LIKE '" + filter.Codigo_Verificacion_Celular + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Usuario.Codigo_Verificacion_Celular LIKE '%" + filter.Codigo_Verificacion_Celular + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Usuario.Codigo_Verificacion_Celular = '" + filter.Codigo_Verificacion_Celular + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Usuario.Codigo_Verificacion_Celular LIKE '%" + filter.Codigo_Verificacion_Celular + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Codigo_Reestablecer_Contrasena))
            {
                switch (filter.Codigo_Reestablecer_ContrasenaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Usuario.Codigo_Reestablecer_Contrasena LIKE '" + filter.Codigo_Reestablecer_Contrasena + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Usuario.Codigo_Reestablecer_Contrasena LIKE '%" + filter.Codigo_Reestablecer_Contrasena + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Usuario.Codigo_Reestablecer_Contrasena = '" + filter.Codigo_Reestablecer_Contrasena + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Usuario.Codigo_Reestablecer_Contrasena LIKE '%" + filter.Codigo_Reestablecer_Contrasena + "%'";
                        break;
                }
            }

            if (filter.El_correo_fue_Validado != RadioOptions.NoApply)
                where += " AND Registro_de_Usuario.El_correo_fue_Validado = " + Convert.ToInt32(filter.El_correo_fue_Validado);

            if (filter.El_Celular_fue_Validado != RadioOptions.NoApply)
                where += " AND Registro_de_Usuario.El_Celular_fue_Validado = " + Convert.ToInt32(filter.El_Celular_fue_Validado);


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
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
                _IRegistro_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);

                Registro_de_Usuario varRegistro_de_Usuario = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IRegistro_de_UsuarioApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Registro_de_UsuarioModel varRegistro_de_Usuario)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IRegistro_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Registro_de_UsuarioInfo = new Registro_de_Usuario
                    {
                        Clave = varRegistro_de_Usuario.Clave
                        ,Nombres = varRegistro_de_Usuario.Nombres
                        ,Apellido_Paterno = varRegistro_de_Usuario.Apellido_Paterno
                        ,Apellido_Materno = varRegistro_de_Usuario.Apellido_Materno
                        ,Nombre_Completo = varRegistro_de_Usuario.Nombre_Completo
                        ,Usuario = varRegistro_de_Usuario.Usuario
                        ,Contrasena = varRegistro_de_Usuario.Contrasena
                        ,Confirmar_Contrasena = varRegistro_de_Usuario.Confirmar_Contrasena
                        ,Correo = varRegistro_de_Usuario.Correo
                        ,Celular = varRegistro_de_Usuario.Celular
                        ,Codigo_Verificacion_Correo = varRegistro_de_Usuario.Codigo_Verificacion_Correo
                        ,Codigo_Verificacion_Celular = varRegistro_de_Usuario.Codigo_Verificacion_Celular
                        ,Codigo_Reestablecer_Contrasena = varRegistro_de_Usuario.Codigo_Reestablecer_Contrasena
                        ,El_correo_fue_Validado = varRegistro_de_Usuario.El_correo_fue_Validado
                        ,El_Celular_fue_Validado = varRegistro_de_Usuario.El_Celular_fue_Validado

                    };

                    result = !IsNew ?
                        _IRegistro_de_UsuarioApiConsumer.Update(Registro_de_UsuarioInfo, null, null).Resource.ToString() :
                         _IRegistro_de_UsuarioApiConsumer.Insert(Registro_de_UsuarioInfo, null, null).Resource.ToString();
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



        /// <summary>
        /// Write Element Array of Registro_de_Usuario script
        /// </summary>
        /// <param name="oRegistro_de_UsuarioElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Registro_de_UsuarioModuleAttributeList)
        {
            for (int i = 0; i < Registro_de_UsuarioModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Registro_de_UsuarioModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Registro_de_UsuarioModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Registro_de_UsuarioModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Registro_de_UsuarioModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Registro_de_UsuarioModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Registro_de_UsuarioModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Registro_de_UsuarioModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Registro_de_UsuarioModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Registro_de_UsuarioModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Registro_de_UsuarioModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Registro_de_UsuarioModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strRegistro_de_UsuarioScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Registro_de_Usuario.js")))
            {
                strRegistro_de_UsuarioScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Registro_de_Usuario element attributes
            string userChangeJson = jsSerialize.Serialize(Registro_de_UsuarioModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strRegistro_de_UsuarioScript.IndexOf("inpuElementArray");
            string splittedString = strRegistro_de_UsuarioScript.Substring(indexOfArray, strRegistro_de_UsuarioScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Registro_de_UsuarioModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Registro_de_UsuarioModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strRegistro_de_UsuarioScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strRegistro_de_UsuarioScript.Substring(indexOfArrayHistory, strRegistro_de_UsuarioScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strRegistro_de_UsuarioScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strRegistro_de_UsuarioScript.Substring(endIndexOfMainElement + indexOfArray, strRegistro_de_UsuarioScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Registro_de_UsuarioModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Registro_de_UsuarioModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Registro_de_Usuario.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Registro_de_Usuario.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Registro_de_Usuario.js")))
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
        public ActionResult Registro_de_UsuarioPropertyBag()
        {
            return PartialView("Registro_de_UsuarioPropertyBag", "Registro_de_Usuario");
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
                var whereClauseFormat = "Object = 45684 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IRegistro_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Registro_de_Usuario.Clave= " + RecordId;
                            var result = _IRegistro_de_UsuarioApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IRegistro_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Registro_de_UsuarioPropertyMapper());
			
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
                    (Registro_de_UsuarioAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Registro_de_UsuarioPropertyMapper oRegistro_de_UsuarioPropertyMapper = new Registro_de_UsuarioPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRegistro_de_UsuarioPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRegistro_de_UsuarioApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Usuarios == null)
                result.Registro_de_Usuarios = new List<Registro_de_Usuario>();

            var data = result.Registro_de_Usuarios.Select(m => new Registro_de_UsuarioGridModel
            {
                Clave = m.Clave
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Usuario = m.Usuario
			,Contrasena = m.Contrasena
			,Confirmar_Contrasena = m.Confirmar_Contrasena
			,Correo = m.Correo
			,Celular = m.Celular
			,Codigo_Verificacion_Correo = m.Codigo_Verificacion_Correo
			,Codigo_Verificacion_Celular = m.Codigo_Verificacion_Celular
			,Codigo_Reestablecer_Contrasena = m.Codigo_Reestablecer_Contrasena
			,El_correo_fue_Validado = m.El_correo_fue_Validado
			,El_Celular_fue_Validado = m.El_Celular_fue_Validado

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45684, arrayColumnsVisible), "Registro_de_UsuarioList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45684, arrayColumnsVisible), "Registro_de_UsuarioList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45684, arrayColumnsVisible), "Registro_de_UsuarioList_" + DateTime.Now.ToString());
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

            _IRegistro_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Registro_de_UsuarioPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Registro_de_UsuarioAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Registro_de_UsuarioPropertyMapper oRegistro_de_UsuarioPropertyMapper = new Registro_de_UsuarioPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRegistro_de_UsuarioPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRegistro_de_UsuarioApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Usuarios == null)
                result.Registro_de_Usuarios = new List<Registro_de_Usuario>();

            var data = result.Registro_de_Usuarios.Select(m => new Registro_de_UsuarioGridModel
            {
                Clave = m.Clave
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Usuario = m.Usuario
			,Contrasena = m.Contrasena
			,Confirmar_Contrasena = m.Confirmar_Contrasena
			,Correo = m.Correo
			,Celular = m.Celular
			,Codigo_Verificacion_Correo = m.Codigo_Verificacion_Correo
			,Codigo_Verificacion_Celular = m.Codigo_Verificacion_Celular
			,Codigo_Reestablecer_Contrasena = m.Codigo_Reestablecer_Contrasena
			,El_correo_fue_Validado = m.El_correo_fue_Validado
			,El_Celular_fue_Validado = m.El_Celular_fue_Validado

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
                _IRegistro_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegistro_de_UsuarioApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Registro_de_Usuario_Datos_GeneralesModel varRegistro_de_Usuario)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Usuario_Datos_GeneralesInfo = new Registro_de_Usuario_Datos_Generales
                {
                    Clave = varRegistro_de_Usuario.Clave
                                            ,Nombres = varRegistro_de_Usuario.Nombres
                        ,Apellido_Paterno = varRegistro_de_Usuario.Apellido_Paterno
                        ,Apellido_Materno = varRegistro_de_Usuario.Apellido_Materno
                        ,Nombre_Completo = varRegistro_de_Usuario.Nombre_Completo
                        ,Usuario = varRegistro_de_Usuario.Usuario
                        ,Contrasena = varRegistro_de_Usuario.Contrasena
                        ,Confirmar_Contrasena = varRegistro_de_Usuario.Confirmar_Contrasena
                        ,Correo = varRegistro_de_Usuario.Correo
                        ,Celular = varRegistro_de_Usuario.Celular
                        ,Codigo_Verificacion_Correo = varRegistro_de_Usuario.Codigo_Verificacion_Correo
                        ,Codigo_Verificacion_Celular = varRegistro_de_Usuario.Codigo_Verificacion_Celular
                        ,Codigo_Reestablecer_Contrasena = varRegistro_de_Usuario.Codigo_Reestablecer_Contrasena
                        ,El_correo_fue_Validado = varRegistro_de_Usuario.El_correo_fue_Validado
                        ,El_Celular_fue_Validado = varRegistro_de_Usuario.El_Celular_fue_Validado
                    
                };

                result = _IRegistro_de_UsuarioApiConsumer.Update_Datos_Generales(Registro_de_Usuario_Datos_GeneralesInfo).Resource.ToString();
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
                _IRegistro_de_UsuarioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_UsuarioApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Registro_de_Usuario_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,Nombres = m.Nombres
			,Apellido_Paterno = m.Apellido_Paterno
			,Apellido_Materno = m.Apellido_Materno
			,Nombre_Completo = m.Nombre_Completo
			,Usuario = m.Usuario
			,Contrasena = m.Contrasena
			,Confirmar_Contrasena = m.Confirmar_Contrasena
			,Correo = m.Correo
			,Celular = m.Celular
			,Codigo_Verificacion_Correo = m.Codigo_Verificacion_Correo
			,Codigo_Verificacion_Celular = m.Codigo_Verificacion_Celular
			,Codigo_Reestablecer_Contrasena = m.Codigo_Reestablecer_Contrasena
			,El_correo_fue_Validado = m.El_correo_fue_Validado
			,El_Celular_fue_Validado = m.El_Celular_fue_Validado

                    
                };
				var resultData = new
                {
                    data = result

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

