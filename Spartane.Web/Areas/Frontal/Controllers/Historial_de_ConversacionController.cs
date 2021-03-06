﻿using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Historial_de_Conversacion;
using Spartane.Core.Domain.Detalle_de_Mensaje_de_Historial;





using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Historial_de_Conversacion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Historial_de_Conversacion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Mensaje_de_Historial;




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
    public class Historial_de_ConversacionController : Controller
    {
        #region "variable declaration"

        private IHistorial_de_ConversacionService service = null;
        private IHistorial_de_ConversacionApiConsumer _IHistorial_de_ConversacionApiConsumer;
        private IDetalle_de_Mensaje_de_HistorialApiConsumer _IDetalle_de_Mensaje_de_HistorialApiConsumer;




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

        
        public Historial_de_ConversacionController(IHistorial_de_ConversacionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IHistorial_de_ConversacionApiConsumer Historial_de_ConversacionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IDetalle_de_Mensaje_de_HistorialApiConsumer Detalle_de_Mensaje_de_HistorialApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IHistorial_de_ConversacionApiConsumer = Historial_de_ConversacionApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IDetalle_de_Mensaje_de_HistorialApiConsumer = Detalle_de_Mensaje_de_HistorialApiConsumer;




        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Historial_de_Conversacion
        [ObjectAuth(ObjectId = (ModuleObjectId)45237, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45237, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Historial_de_Conversacion/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45237, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45237, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varHistorial_de_Conversacion = new Historial_de_ConversacionModel();
			varHistorial_de_Conversacion.Folio = Id;
			
            ViewBag.ObjectId = "45237";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_de_Mensaje_de_Historial = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45238, ModuleId);
            ViewBag.PermissionDetalle_de_Mensaje_de_Historial = permissionDetalle_de_Mensaje_de_Historial;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IHistorial_de_ConversacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Historial_de_ConversacionsData = _IHistorial_de_ConversacionApiConsumer.ListaSelAll(0, 1000, "Historial_de_Conversacion.Folio=" + Id, "").Resource.Historial_de_Conversacions;
				
				if (Historial_de_ConversacionsData != null && Historial_de_ConversacionsData.Count > 0)
                {
					var Historial_de_ConversacionData = Historial_de_ConversacionsData.First();
					varHistorial_de_Conversacion= new Historial_de_ConversacionModel
					{
						Folio  = Historial_de_ConversacionData.Folio 
	                    ,Remitente = Historial_de_ConversacionData.Remitente
                    ,Destinatario = Historial_de_ConversacionData.Destinatario
                    ,Fecha = (Historial_de_ConversacionData.Fecha == null ? string.Empty : Convert.ToDateTime(Historial_de_ConversacionData.Fecha).ToString(ConfigurationProperty.DateFormat))

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

				
            return View(varHistorial_de_Conversacion);
        }
		
	[HttpGet]
        public ActionResult AddHistorial_de_Conversacion(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45237);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IHistorial_de_ConversacionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Historial_de_ConversacionModel varHistorial_de_Conversacion= new Historial_de_ConversacionModel();
            var permissionDetalle_de_Mensaje_de_Historial = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45238, ModuleId);
            ViewBag.PermissionDetalle_de_Mensaje_de_Historial = permissionDetalle_de_Mensaje_de_Historial;


            if (id.ToString() != "0")
            {
                var Historial_de_ConversacionsData = _IHistorial_de_ConversacionApiConsumer.ListaSelAll(0, 1000, "Historial_de_Conversacion.Folio=" + id, "").Resource.Historial_de_Conversacions;
				
				if (Historial_de_ConversacionsData != null && Historial_de_ConversacionsData.Count > 0)
                {
					var Historial_de_ConversacionData = Historial_de_ConversacionsData.First();
					varHistorial_de_Conversacion= new Historial_de_ConversacionModel
					{
						Folio  = Historial_de_ConversacionData.Folio 
	                    ,Remitente = Historial_de_ConversacionData.Remitente
                    ,Destinatario = Historial_de_ConversacionData.Destinatario
                    ,Fecha = (Historial_de_ConversacionData.Fecha == null ? string.Empty : Convert.ToDateTime(Historial_de_ConversacionData.Fecha).ToString(ConfigurationProperty.DateFormat))

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddHistorial_de_Conversacion", varHistorial_de_Conversacion);
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
        public ActionResult ShowAdvanceFilter(Historial_de_ConversacionAdvanceSearchModel model, int idFilter = -1)
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



            var previousFiltersObj = new Historial_de_ConversacionAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Historial_de_ConversacionAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Historial_de_ConversacionAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Historial_de_ConversacionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IHistorial_de_ConversacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Historial_de_Conversacions == null)
                result.Historial_de_Conversacions = new List<Historial_de_Conversacion>();

            return Json(new
            {
                data = result.Historial_de_Conversacions.Select(m => new Historial_de_ConversacionGridModel
                    {
                    Folio = m.Folio
			,Remitente = m.Remitente
			,Destinatario = m.Destinatario
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetHistorial_de_ConversacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IHistorial_de_ConversacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IHistorial_de_ConversacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Folio), "Historial_de_Conversacion", m.),
                     Value = Convert.ToString(m.Folio)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
*/
        /// <summary>
        /// Get List of Historial_de_Conversacion from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Historial_de_Conversacion Entity</returns>
        public ActionResult GetHistorial_de_ConversacionList(UrlParametersModel param)
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
            _IHistorial_de_ConversacionApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Historial_de_ConversacionPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Historial_de_ConversacionAdvanceSearchModel))
                {
					var advanceFilter =
                    (Historial_de_ConversacionAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Historial_de_ConversacionPropertyMapper oHistorial_de_ConversacionPropertyMapper = new Historial_de_ConversacionPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oHistorial_de_ConversacionPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IHistorial_de_ConversacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Historial_de_Conversacions == null)
                result.Historial_de_Conversacions = new List<Historial_de_Conversacion>();

            return Json(new
            {
                aaData = result.Historial_de_Conversacions.Select(m => new Historial_de_ConversacionGridModel
            {
                    Folio = m.Folio
			,Remitente = m.Remitente
			,Destinatario = m.Destinatario
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(Historial_de_ConversacionAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromFolio) || !string.IsNullOrEmpty(filter.ToFolio))
            {
                if (!string.IsNullOrEmpty(filter.FromFolio))
                    where += " AND Historial_de_Conversacion.Folio >= " + filter.FromFolio;
                if (!string.IsNullOrEmpty(filter.ToFolio))
                    where += " AND Historial_de_Conversacion.Folio <= " + filter.ToFolio;
            }

            if (!string.IsNullOrEmpty(filter.FromRemitente) || !string.IsNullOrEmpty(filter.ToRemitente))
            {
                if (!string.IsNullOrEmpty(filter.FromRemitente))
                    where += " AND Historial_de_Conversacion.Remitente >= " + filter.FromRemitente;
                if (!string.IsNullOrEmpty(filter.ToRemitente))
                    where += " AND Historial_de_Conversacion.Remitente <= " + filter.ToRemitente;
            }

            if (!string.IsNullOrEmpty(filter.FromDestinatario) || !string.IsNullOrEmpty(filter.ToDestinatario))
            {
                if (!string.IsNullOrEmpty(filter.FromDestinatario))
                    where += " AND Historial_de_Conversacion.Destinatario >= " + filter.FromDestinatario;
                if (!string.IsNullOrEmpty(filter.ToDestinatario))
                    where += " AND Historial_de_Conversacion.Destinatario <= " + filter.ToDestinatario;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha) || !string.IsNullOrEmpty(filter.ToFecha))
            {
                var FechaFrom = DateTime.ParseExact(filter.FromFecha, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var FechaTo = DateTime.ParseExact(filter.ToFecha, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha))
                    where += " AND Historial_de_Conversacion.Fecha >= '" + FechaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha))
                    where += " AND Historial_de_Conversacion.Fecha <= '" + FechaTo.ToString("MM-dd-yyyy") + "'";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_de_Mensaje_de_Historial(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Mensaje_de_HistorialGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Mensaje_de_HistorialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Mensaje_de_Historial.Historial_de_Conversacion=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Mensaje_de_Historial.Historial_de_Conversacion='" + RelationId + "'";
            }
            var result = _IDetalle_de_Mensaje_de_HistorialApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Mensaje_de_Historials == null)
                result.Detalle_de_Mensaje_de_Historials = new List<Detalle_de_Mensaje_de_Historial>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Mensaje_de_Historials.Select(m => new Detalle_de_Mensaje_de_HistorialGridModel
                {
                    Clave = m.Clave

			,Hora = m.Hora
			,Mensaje = m.Mensaje

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Mensaje_de_HistorialGridModel> GetDetalle_de_Mensaje_de_HistorialData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Mensaje_de_HistorialGridModel> resultData = new List<Detalle_de_Mensaje_de_HistorialGridModel>();
            string where = "Detalle_de_Mensaje_de_Historial.Historial_de_Conversacion=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Mensaje_de_Historial.Historial_de_Conversacion='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Mensaje_de_HistorialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Mensaje_de_HistorialApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Mensaje_de_Historials != null)
            {
                resultData = result.Detalle_de_Mensaje_de_Historials.Select(m => new Detalle_de_Mensaje_de_HistorialGridModel
                    {
                        Clave = m.Clave

			,Hora = m.Hora
			,Mensaje = m.Mensaje


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
                _IHistorial_de_ConversacionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Historial_de_Conversacion varHistorial_de_Conversacion = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_de_Mensaje_de_HistorialApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Mensaje_de_Historial.Historial_de_Conversacion=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Mensaje_de_Historial.Historial_de_Conversacion='" + id + "'";
                    }
                    var Detalle_de_Mensaje_de_HistorialInfo =
                        _IDetalle_de_Mensaje_de_HistorialApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Mensaje_de_HistorialInfo.Detalle_de_Mensaje_de_Historials.Count > 0)
                    {
                        var resultDetalle_de_Mensaje_de_Historial = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Mensaje_de_HistorialItem in Detalle_de_Mensaje_de_HistorialInfo.Detalle_de_Mensaje_de_Historials)
                            resultDetalle_de_Mensaje_de_Historial = resultDetalle_de_Mensaje_de_Historial
                                              && _IDetalle_de_Mensaje_de_HistorialApiConsumer.Delete(Detalle_de_Mensaje_de_HistorialItem.Clave, null,null).Resource;

                        if (!resultDetalle_de_Mensaje_de_Historial)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IHistorial_de_ConversacionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Historial_de_ConversacionModel varHistorial_de_Conversacion)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IHistorial_de_ConversacionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Historial_de_ConversacionInfo = new Historial_de_Conversacion
                    {
                        Folio = varHistorial_de_Conversacion.Folio
                        ,Remitente = varHistorial_de_Conversacion.Remitente
                        ,Destinatario = varHistorial_de_Conversacion.Destinatario
                        ,Fecha = (!String.IsNullOrEmpty(varHistorial_de_Conversacion.Fecha)) ? DateTime.ParseExact(varHistorial_de_Conversacion.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null

                    };

                    result = !IsNew ?
                        _IHistorial_de_ConversacionApiConsumer.Update(Historial_de_ConversacionInfo, null, null).Resource.ToString() :
                         _IHistorial_de_ConversacionApiConsumer.Insert(Historial_de_ConversacionInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_de_Mensaje_de_Historial(int MasterId, int referenceId, List<Detalle_de_Mensaje_de_HistorialGridModelPost> Detalle_de_Mensaje_de_HistorialItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Mensaje_de_HistorialApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Mensaje_de_HistorialData = _IDetalle_de_Mensaje_de_HistorialApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Mensaje_de_Historial.Historial_de_Conversacion=" + referenceId,"").Resource;
                if (Detalle_de_Mensaje_de_HistorialData == null || Detalle_de_Mensaje_de_HistorialData.Detalle_de_Mensaje_de_Historials.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Mensaje_de_HistorialGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Mensaje_de_Historial in Detalle_de_Mensaje_de_HistorialData.Detalle_de_Mensaje_de_Historials)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Mensaje_de_Historial Detalle_de_Mensaje_de_Historial1 = varDetalle_de_Mensaje_de_Historial;

                    if (Detalle_de_Mensaje_de_HistorialItems != null && Detalle_de_Mensaje_de_HistorialItems.Any(m => m.Clave == Detalle_de_Mensaje_de_Historial1.Clave))
                    {
                        modelDataToChange = Detalle_de_Mensaje_de_HistorialItems.FirstOrDefault(m => m.Clave == Detalle_de_Mensaje_de_Historial1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_de_Mensaje_de_Historial.Historial_de_Conversacion = MasterId;
                    var insertId = _IDetalle_de_Mensaje_de_HistorialApiConsumer.Insert(varDetalle_de_Mensaje_de_Historial,null,null).Resource;
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
        public ActionResult PostDetalle_de_Mensaje_de_Historial(List<Detalle_de_Mensaje_de_HistorialGridModelPost> Detalle_de_Mensaje_de_HistorialItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Mensaje_de_Historial(MasterId, referenceId, Detalle_de_Mensaje_de_HistorialItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Mensaje_de_HistorialItems != null && Detalle_de_Mensaje_de_HistorialItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Mensaje_de_HistorialApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Mensaje_de_HistorialItem in Detalle_de_Mensaje_de_HistorialItems)
                    {




                        //Removal Request
                        if (Detalle_de_Mensaje_de_HistorialItem.Removed)
                        {
                            result = result && _IDetalle_de_Mensaje_de_HistorialApiConsumer.Delete(Detalle_de_Mensaje_de_HistorialItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Mensaje_de_HistorialItem.Clave = 0;

                        var Detalle_de_Mensaje_de_HistorialData = new Detalle_de_Mensaje_de_Historial
                        {
                            Historial_de_Conversacion = MasterId
                            ,Clave = Detalle_de_Mensaje_de_HistorialItem.Clave
                            ,Hora = Detalle_de_Mensaje_de_HistorialItem.Hora
                            ,Mensaje = Detalle_de_Mensaje_de_HistorialItem.Mensaje

                        };

                        var resultId = Detalle_de_Mensaje_de_HistorialItem.Clave > 0
                           ? _IDetalle_de_Mensaje_de_HistorialApiConsumer.Update(Detalle_de_Mensaje_de_HistorialData,null,null).Resource
                           : _IDetalle_de_Mensaje_de_HistorialApiConsumer.Insert(Detalle_de_Mensaje_de_HistorialData,null,null).Resource;

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







        /// <summary>
        /// Write Element Array of Historial_de_Conversacion script
        /// </summary>
        /// <param name="oHistorial_de_ConversacionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Historial_de_ConversacionModuleAttributeList)
        {
            for (int i = 0; i < Historial_de_ConversacionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Historial_de_ConversacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Historial_de_ConversacionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Historial_de_ConversacionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Historial_de_ConversacionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Historial_de_ConversacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Historial_de_ConversacionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Historial_de_ConversacionModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Historial_de_ConversacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Historial_de_ConversacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Historial_de_ConversacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Historial_de_ConversacionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strHistorial_de_ConversacionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Historial_de_Conversacion.js")))
            {
                strHistorial_de_ConversacionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Historial_de_Conversacion element attributes
            string userChangeJson = jsSerialize.Serialize(Historial_de_ConversacionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strHistorial_de_ConversacionScript.IndexOf("inpuElementArray");
            string splittedString = strHistorial_de_ConversacionScript.Substring(indexOfArray, strHistorial_de_ConversacionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Historial_de_ConversacionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Historial_de_ConversacionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strHistorial_de_ConversacionScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strHistorial_de_ConversacionScript.Substring(indexOfArrayHistory, strHistorial_de_ConversacionScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strHistorial_de_ConversacionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strHistorial_de_ConversacionScript.Substring(endIndexOfMainElement + indexOfArray, strHistorial_de_ConversacionScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Historial_de_ConversacionModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Historial_de_ConversacionModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Historial_de_Conversacion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Historial_de_Conversacion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Historial_de_Conversacion.js")))
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
        public ActionResult Historial_de_ConversacionPropertyBag()
        {
            return PartialView("Historial_de_ConversacionPropertyBag", "Historial_de_Conversacion");
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
        public ActionResult AddDetalle_de_Mensaje_de_Historial(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Mensaje_de_Historial/AddDetalle_de_Mensaje_de_Historial");
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
                var whereClauseFormat = "Object = 45237 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IHistorial_de_ConversacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Historial_de_Conversacion.Folio= " + RecordId;
                            var result = _IHistorial_de_ConversacionApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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
										  
			string[] arrayColumnsVisible = null;

			 where = HttpUtility.UrlEncode(where);
            if (!_tokenManager.GenerateToken())
                return;

            _IHistorial_de_ConversacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Historial_de_ConversacionPropertyMapper());
			
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
                    (Historial_de_ConversacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Historial_de_ConversacionPropertyMapper oHistorial_de_ConversacionPropertyMapper = new Historial_de_ConversacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oHistorial_de_ConversacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IHistorial_de_ConversacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Historial_de_Conversacions == null)
                result.Historial_de_Conversacions = new List<Historial_de_Conversacion>();

            var data = result.Historial_de_Conversacions.Select(m => new Historial_de_ConversacionGridModel
            {
                Folio = m.Folio
			,Remitente = m.Remitente
			,Destinatario = m.Destinatario
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45237, arrayColumnsVisible), "Historial_de_ConversacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45237, arrayColumnsVisible), "Historial_de_ConversacionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45237, arrayColumnsVisible), "Historial_de_ConversacionList_" + DateTime.Now.ToString());
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

            _IHistorial_de_ConversacionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Historial_de_ConversacionPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Historial_de_ConversacionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Historial_de_ConversacionPropertyMapper oHistorial_de_ConversacionPropertyMapper = new Historial_de_ConversacionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oHistorial_de_ConversacionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IHistorial_de_ConversacionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Historial_de_Conversacions == null)
                result.Historial_de_Conversacions = new List<Historial_de_Conversacion>();

            var data = result.Historial_de_Conversacions.Select(m => new Historial_de_ConversacionGridModel
            {
                Folio = m.Folio
			,Remitente = m.Remitente
			,Destinatario = m.Destinatario
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))

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
                _IHistorial_de_ConversacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IHistorial_de_ConversacionApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Historial_de_Conversacion_Datos_GeneralesModel varHistorial_de_Conversacion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IHistorial_de_ConversacionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Historial_de_Conversacion_Datos_GeneralesInfo = new Historial_de_Conversacion_Datos_Generales
                {
                    Folio = varHistorial_de_Conversacion.Folio
                                            ,Remitente = varHistorial_de_Conversacion.Remitente
                        ,Destinatario = varHistorial_de_Conversacion.Destinatario
                        ,Fecha = (!String.IsNullOrEmpty(varHistorial_de_Conversacion.Fecha)) ? DateTime.ParseExact(varHistorial_de_Conversacion.Fecha, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                    
                };

                result = _IHistorial_de_ConversacionApiConsumer.Update_Datos_Generales(Historial_de_Conversacion_Datos_GeneralesInfo).Resource.ToString();
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
                _IHistorial_de_ConversacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IHistorial_de_ConversacionApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Mensaje_de_Historial;
                var Detalle_de_Mensaje_de_HistorialData = GetDetalle_de_Mensaje_de_HistorialData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Mensaje_de_Historial);

                var result = new Historial_de_Conversacion_Datos_GeneralesModel
                {
                    Folio = m.Folio
			,Remitente = m.Remitente
			,Destinatario = m.Destinatario
                        ,Fecha = (m.Fecha == null ? string.Empty : Convert.ToDateTime(m.Fecha).ToString(ConfigurationProperty.DateFormat))

                    
                };
				var resultData = new
                {
                    data = result
                    ,Mensaje = Detalle_de_Mensaje_de_HistorialData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

