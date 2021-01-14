using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Registro_de_Huellas_Dactilares;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Detalle_de_Datos_Generales;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Registro_de_Huellas_Dactilares;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Registro_de_Huellas_Dactilares;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
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
    public class Registro_de_Huellas_DactilaresController : Controller
    {
        #region "variable declaration"

        private IRegistro_de_Huellas_DactilaresService service = null;
        private IRegistro_de_Huellas_DactilaresApiConsumer _IRegistro_de_Huellas_DactilaresApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private IDetalle_de_Datos_GeneralesApiConsumer _IDetalle_de_Datos_GeneralesApiConsumer;

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

        
        public Registro_de_Huellas_DactilaresController(IRegistro_de_Huellas_DactilaresService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IRegistro_de_Huellas_DactilaresApiConsumer Registro_de_Huellas_DactilaresApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , IDetalle_de_Datos_GeneralesApiConsumer Detalle_de_Datos_GeneralesApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IRegistro_de_Huellas_DactilaresApiConsumer = Registro_de_Huellas_DactilaresApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
            this._IDetalle_de_Datos_GeneralesApiConsumer = Detalle_de_Datos_GeneralesApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Registro_de_Huellas_Dactilares
        [ObjectAuth(ObjectId = (ModuleObjectId)45734, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45734, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Registro_de_Huellas_Dactilares/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45734, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45734, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varRegistro_de_Huellas_Dactilares = new Registro_de_Huellas_DactilaresModel();
			varRegistro_de_Huellas_Dactilares.Clave = Id;
			
            ViewBag.ObjectId = "45734";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IRegistro_de_Huellas_DactilaresApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Registro_de_Huellas_DactilaressData = _IRegistro_de_Huellas_DactilaresApiConsumer.ListaSelAll(0, 1000, "Registro_de_Huellas_Dactilares.Clave=" + Id, "").Resource.Registro_de_Huellas_Dactilaress;
				
				if (Registro_de_Huellas_DactilaressData != null && Registro_de_Huellas_DactilaressData.Count > 0)
                {
					var Registro_de_Huellas_DactilaresData = Registro_de_Huellas_DactilaressData.First();
					varRegistro_de_Huellas_Dactilares= new Registro_de_Huellas_DactilaresModel
					{
						Clave  = Registro_de_Huellas_DactilaresData.Clave 
	                    ,Carpeta_de_Investigacion = Registro_de_Huellas_DactilaresData.Carpeta_de_Investigacion
                    ,Carpeta_de_Investigacionnic = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Huellas_DactilaresData.Carpeta_de_Investigacion), "expediente_ministerio_publico") ??  (string)Registro_de_Huellas_DactilaresData.Carpeta_de_Investigacion_expediente_ministerio_publico.nic
                    ,Probable_Responsable = Registro_de_Huellas_DactilaresData.Probable_Responsable
                    ,Probable_ResponsableNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Huellas_DactilaresData.Probable_Responsable), "Detalle_de_Datos_Generales") ??  (string)Registro_de_Huellas_DactilaresData.Probable_Responsable_Detalle_de_Datos_Generales.Nombre_Completo
                    ,Mano_Izquierda_4_Dedos = Registro_de_Huellas_DactilaresData.Mano_Izquierda_4_Dedos
                    ,Mano_Derecha_4_Dedos = Registro_de_Huellas_DactilaresData.Mano_Derecha_4_Dedos
                    ,Pulgares = Registro_de_Huellas_DactilaresData.Pulgares
                    ,Izquierda_Menique = Registro_de_Huellas_DactilaresData.Izquierda_Menique
                    ,Izquierda_Anular = Registro_de_Huellas_DactilaresData.Izquierda_Anular
                    ,Izquierda_Medio = Registro_de_Huellas_DactilaresData.Izquierda_Medio
                    ,Izquierda_Indice = Registro_de_Huellas_DactilaresData.Izquierda_Indice
                    ,Izquierda_Pulgar = Registro_de_Huellas_DactilaresData.Izquierda_Pulgar
                    ,Derecha_Menique = Registro_de_Huellas_DactilaresData.Derecha_Menique
                    ,Derecha_Anular = Registro_de_Huellas_DactilaresData.Derecha_Anular
                    ,Derecha_Medio = Registro_de_Huellas_DactilaresData.Derecha_Medio
                    ,Derecha_Indice = Registro_de_Huellas_DactilaresData.Derecha_Indice
                    ,Derecha_Pulgar = Registro_de_Huellas_DactilaresData.Derecha_Pulgar

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Mano_Izquierda_4_DedosSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_Dedos).Resource;
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Mano_Derecha_4_DedosSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_Dedos).Resource;
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.PulgaresSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varRegistro_de_Huellas_Dactilares.Pulgares).Resource;

				
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

				
            return View(varRegistro_de_Huellas_Dactilares);
        }
		
	[HttpGet]
        public ActionResult AddRegistro_de_Huellas_Dactilares(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45734);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IRegistro_de_Huellas_DactilaresApiConsumer.SetAuthHeader(_tokenManager.Token);
			Registro_de_Huellas_DactilaresModel varRegistro_de_Huellas_Dactilares= new Registro_de_Huellas_DactilaresModel();


            if (id.ToString() != "0")
            {
                var Registro_de_Huellas_DactilaressData = _IRegistro_de_Huellas_DactilaresApiConsumer.ListaSelAll(0, 1000, "Registro_de_Huellas_Dactilares.Clave=" + id, "").Resource.Registro_de_Huellas_Dactilaress;
				
				if (Registro_de_Huellas_DactilaressData != null && Registro_de_Huellas_DactilaressData.Count > 0)
                {
					var Registro_de_Huellas_DactilaresData = Registro_de_Huellas_DactilaressData.First();
					varRegistro_de_Huellas_Dactilares= new Registro_de_Huellas_DactilaresModel
					{
						Clave  = Registro_de_Huellas_DactilaresData.Clave 
	                    ,Carpeta_de_Investigacion = Registro_de_Huellas_DactilaresData.Carpeta_de_Investigacion
                    ,Carpeta_de_Investigacionnic = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Huellas_DactilaresData.Carpeta_de_Investigacion), "expediente_ministerio_publico") ??  (string)Registro_de_Huellas_DactilaresData.Carpeta_de_Investigacion_expediente_ministerio_publico.nic
                    ,Probable_Responsable = Registro_de_Huellas_DactilaresData.Probable_Responsable
                    ,Probable_ResponsableNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Huellas_DactilaresData.Probable_Responsable), "Detalle_de_Datos_Generales") ??  (string)Registro_de_Huellas_DactilaresData.Probable_Responsable_Detalle_de_Datos_Generales.Nombre_Completo
                    ,Mano_Izquierda_4_Dedos = Registro_de_Huellas_DactilaresData.Mano_Izquierda_4_Dedos
                    ,Mano_Derecha_4_Dedos = Registro_de_Huellas_DactilaresData.Mano_Derecha_4_Dedos
                    ,Pulgares = Registro_de_Huellas_DactilaresData.Pulgares
                    ,Izquierda_Menique = Registro_de_Huellas_DactilaresData.Izquierda_Menique
                    ,Izquierda_Anular = Registro_de_Huellas_DactilaresData.Izquierda_Anular
                    ,Izquierda_Medio = Registro_de_Huellas_DactilaresData.Izquierda_Medio
                    ,Izquierda_Indice = Registro_de_Huellas_DactilaresData.Izquierda_Indice
                    ,Izquierda_Pulgar = Registro_de_Huellas_DactilaresData.Izquierda_Pulgar
                    ,Derecha_Menique = Registro_de_Huellas_DactilaresData.Derecha_Menique
                    ,Derecha_Anular = Registro_de_Huellas_DactilaresData.Derecha_Anular
                    ,Derecha_Medio = Registro_de_Huellas_DactilaresData.Derecha_Medio
                    ,Derecha_Indice = Registro_de_Huellas_DactilaresData.Derecha_Indice
                    ,Derecha_Pulgar = Registro_de_Huellas_DactilaresData.Derecha_Pulgar

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Mano_Izquierda_4_DedosSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_Dedos).Resource;
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Mano_Derecha_4_DedosSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_Dedos).Resource;
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.PulgaresSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varRegistro_de_Huellas_Dactilares.Pulgares).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);



            return PartialView("AddRegistro_de_Huellas_Dactilares", varRegistro_de_Huellas_Dactilares);
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
        public ActionResult Getexpediente_ministerio_publicoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _Iexpediente_ministerio_publicoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.nic).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "expediente_ministerio_publico", "nic")?? m.nic,
                    Value = Convert.ToString(m.clave)
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
				
                return Json(result.OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Datos_Generales", "Nombre_Completo")?? m.Nombre_Completo,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Registro_de_Huellas_DactilaresAdvanceSearchModel model, int idFilter = -1)
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



            var previousFiltersObj = new Registro_de_Huellas_DactilaresAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Registro_de_Huellas_DactilaresAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Registro_de_Huellas_DactilaresAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Registro_de_Huellas_DactilaresPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IRegistro_de_Huellas_DactilaresApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Huellas_Dactilaress == null)
                result.Registro_de_Huellas_Dactilaress = new List<Registro_de_Huellas_Dactilares>();

            return Json(new
            {
                data = result.Registro_de_Huellas_Dactilaress.Select(m => new Registro_de_Huellas_DactilaresGridModel
                    {
                    Clave = m.Clave
                        ,Carpeta_de_Investigacionnic = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Carpeta_de_Investigacion_expediente_ministerio_publico.nic
                        ,Probable_ResponsableNombre_Completo = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Probable_Responsable_Detalle_de_Datos_Generales.Nombre_Completo
			,Mano_Izquierda_4_Dedos = m.Mano_Izquierda_4_Dedos
			,Mano_Derecha_4_Dedos = m.Mano_Derecha_4_Dedos
			,Pulgares = m.Pulgares
			,Izquierda_Menique = m.Izquierda_Menique
			,Izquierda_Anular = m.Izquierda_Anular
			,Izquierda_Medio = m.Izquierda_Medio
			,Izquierda_Indice = m.Izquierda_Indice
			,Izquierda_Pulgar = m.Izquierda_Pulgar
			,Derecha_Menique = m.Derecha_Menique
			,Derecha_Anular = m.Derecha_Anular
			,Derecha_Medio = m.Derecha_Medio
			,Derecha_Indice = m.Derecha_Indice
			,Derecha_Pulgar = m.Derecha_Pulgar

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetRegistro_de_Huellas_DactilaresAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Huellas_DactilaresApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegistro_de_Huellas_DactilaresApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Registro_de_Huellas_Dactilares", m.),
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
        /// Get List of Registro_de_Huellas_Dactilares from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Registro_de_Huellas_Dactilares Entity</returns>
        public ActionResult GetRegistro_de_Huellas_DactilaresList(UrlParametersModel param)
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
            _IRegistro_de_Huellas_DactilaresApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Registro_de_Huellas_DactilaresPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Registro_de_Huellas_DactilaresAdvanceSearchModel))
                {
					var advanceFilter =
                    (Registro_de_Huellas_DactilaresAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Registro_de_Huellas_DactilaresPropertyMapper oRegistro_de_Huellas_DactilaresPropertyMapper = new Registro_de_Huellas_DactilaresPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oRegistro_de_Huellas_DactilaresPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IRegistro_de_Huellas_DactilaresApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Huellas_Dactilaress == null)
                result.Registro_de_Huellas_Dactilaress = new List<Registro_de_Huellas_Dactilares>();

            return Json(new
            {
                aaData = result.Registro_de_Huellas_Dactilaress.Select(m => new Registro_de_Huellas_DactilaresGridModel
            {
                    Clave = m.Clave
                        ,Carpeta_de_Investigacionnic = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Carpeta_de_Investigacion_expediente_ministerio_publico.nic
                        ,Probable_ResponsableNombre_Completo = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Probable_Responsable_Detalle_de_Datos_Generales.Nombre_Completo
			,Mano_Izquierda_4_Dedos = m.Mano_Izquierda_4_Dedos
			,Mano_Derecha_4_Dedos = m.Mano_Derecha_4_Dedos
			,Pulgares = m.Pulgares
			,Izquierda_Menique = m.Izquierda_Menique
			,Izquierda_Anular = m.Izquierda_Anular
			,Izquierda_Medio = m.Izquierda_Medio
			,Izquierda_Indice = m.Izquierda_Indice
			,Izquierda_Pulgar = m.Izquierda_Pulgar
			,Derecha_Menique = m.Derecha_Menique
			,Derecha_Anular = m.Derecha_Anular
			,Derecha_Medio = m.Derecha_Medio
			,Derecha_Indice = m.Derecha_Indice
			,Derecha_Pulgar = m.Derecha_Pulgar

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetRegistro_de_Huellas_Dactilares_Carpeta_de_Investigacion_expediente_ministerio_publico(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(expediente_ministerio_publico.clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(expediente_ministerio_publico.nic as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _Iexpediente_ministerio_publicoApiConsumer.ListaSelAll(1, 20,elWhere , " expediente_ministerio_publico.nic ASC ").Resource;
               
                foreach (var item in result.expediente_ministerio_publicos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.clave), "expediente_ministerio_publico", "nic");
                    item.nic =trans ??item.nic;
                }
                return Json(result.expediente_ministerio_publicos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetRegistro_de_Huellas_Dactilares_Probable_Responsable_Detalle_de_Datos_Generales(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Datos_GeneralesApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Datos_Generales.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Datos_Generales.Nombre_Completo as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_Datos_GeneralesApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Datos_Generales.Nombre_Completo ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Datos_Generaless)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Datos_Generales", "Nombre_Completo");
                    item.Nombre_Completo =trans ??item.Nombre_Completo;
                }
                return Json(result.Detalle_de_Datos_Generaless.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public string GetAdvanceFilter(Registro_de_Huellas_DactilaresAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Registro_de_Huellas_Dactilares.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Registro_de_Huellas_Dactilares.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCarpeta_de_Investigacion))
            {
                switch (filter.Carpeta_de_InvestigacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '" + filter.AdvanceCarpeta_de_Investigacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceCarpeta_de_Investigacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.nic = '" + filter.AdvanceCarpeta_de_Investigacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceCarpeta_de_Investigacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCarpeta_de_InvestigacionMultiple != null && filter.AdvanceCarpeta_de_InvestigacionMultiple.Count() > 0)
            {
                var Carpeta_de_InvestigacionIds = string.Join(",", filter.AdvanceCarpeta_de_InvestigacionMultiple);

                where += " AND Registro_de_Huellas_Dactilares.Carpeta_de_Investigacion In (" + Carpeta_de_InvestigacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceProbable_Responsable))
            {
                switch (filter.Probable_ResponsableFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo LIKE '" + filter.AdvanceProbable_Responsable + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo LIKE '%" + filter.AdvanceProbable_Responsable + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo = '" + filter.AdvanceProbable_Responsable + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Datos_Generales.Nombre_Completo LIKE '%" + filter.AdvanceProbable_Responsable + "%'";
                        break;
                }
            }
            else if (filter.AdvanceProbable_ResponsableMultiple != null && filter.AdvanceProbable_ResponsableMultiple.Count() > 0)
            {
                var Probable_ResponsableIds = string.Join(",", filter.AdvanceProbable_ResponsableMultiple);

                where += " AND Registro_de_Huellas_Dactilares.Probable_Responsable In (" + Probable_ResponsableIds + ")";
            }

            if (filter.Mano_Izquierda_4_Dedos != RadioOptions.NoApply)
                where += " AND Registro_de_Huellas_Dactilares.Mano_Izquierda_4_Dedos " + (filter.Mano_Izquierda_4_Dedos == RadioOptions.Yes ? ">" : "==") + " 0";

            if (filter.Mano_Derecha_4_Dedos != RadioOptions.NoApply)
                where += " AND Registro_de_Huellas_Dactilares.Mano_Derecha_4_Dedos " + (filter.Mano_Derecha_4_Dedos == RadioOptions.Yes ? ">" : "==") + " 0";

            if (filter.Pulgares != RadioOptions.NoApply)
                where += " AND Registro_de_Huellas_Dactilares.Pulgares " + (filter.Pulgares == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.FromIzquierda_Menique) || !string.IsNullOrEmpty(filter.ToIzquierda_Menique))
            {
                if (!string.IsNullOrEmpty(filter.FromIzquierda_Menique))
                    where += " AND Registro_de_Huellas_Dactilares.Izquierda_Menique >= " + filter.FromIzquierda_Menique;
                if (!string.IsNullOrEmpty(filter.ToIzquierda_Menique))
                    where += " AND Registro_de_Huellas_Dactilares.Izquierda_Menique <= " + filter.ToIzquierda_Menique;
            }

            if (!string.IsNullOrEmpty(filter.FromIzquierda_Anular) || !string.IsNullOrEmpty(filter.ToIzquierda_Anular))
            {
                if (!string.IsNullOrEmpty(filter.FromIzquierda_Anular))
                    where += " AND Registro_de_Huellas_Dactilares.Izquierda_Anular >= " + filter.FromIzquierda_Anular;
                if (!string.IsNullOrEmpty(filter.ToIzquierda_Anular))
                    where += " AND Registro_de_Huellas_Dactilares.Izquierda_Anular <= " + filter.ToIzquierda_Anular;
            }

            if (!string.IsNullOrEmpty(filter.FromIzquierda_Medio) || !string.IsNullOrEmpty(filter.ToIzquierda_Medio))
            {
                if (!string.IsNullOrEmpty(filter.FromIzquierda_Medio))
                    where += " AND Registro_de_Huellas_Dactilares.Izquierda_Medio >= " + filter.FromIzquierda_Medio;
                if (!string.IsNullOrEmpty(filter.ToIzquierda_Medio))
                    where += " AND Registro_de_Huellas_Dactilares.Izquierda_Medio <= " + filter.ToIzquierda_Medio;
            }

            if (!string.IsNullOrEmpty(filter.FromIzquierda_Indice) || !string.IsNullOrEmpty(filter.ToIzquierda_Indice))
            {
                if (!string.IsNullOrEmpty(filter.FromIzquierda_Indice))
                    where += " AND Registro_de_Huellas_Dactilares.Izquierda_Indice >= " + filter.FromIzquierda_Indice;
                if (!string.IsNullOrEmpty(filter.ToIzquierda_Indice))
                    where += " AND Registro_de_Huellas_Dactilares.Izquierda_Indice <= " + filter.ToIzquierda_Indice;
            }

            if (!string.IsNullOrEmpty(filter.FromIzquierda_Pulgar) || !string.IsNullOrEmpty(filter.ToIzquierda_Pulgar))
            {
                if (!string.IsNullOrEmpty(filter.FromIzquierda_Pulgar))
                    where += " AND Registro_de_Huellas_Dactilares.Izquierda_Pulgar >= " + filter.FromIzquierda_Pulgar;
                if (!string.IsNullOrEmpty(filter.ToIzquierda_Pulgar))
                    where += " AND Registro_de_Huellas_Dactilares.Izquierda_Pulgar <= " + filter.ToIzquierda_Pulgar;
            }

            if (!string.IsNullOrEmpty(filter.FromDerecha_Menique) || !string.IsNullOrEmpty(filter.ToDerecha_Menique))
            {
                if (!string.IsNullOrEmpty(filter.FromDerecha_Menique))
                    where += " AND Registro_de_Huellas_Dactilares.Derecha_Menique >= " + filter.FromDerecha_Menique;
                if (!string.IsNullOrEmpty(filter.ToDerecha_Menique))
                    where += " AND Registro_de_Huellas_Dactilares.Derecha_Menique <= " + filter.ToDerecha_Menique;
            }

            if (!string.IsNullOrEmpty(filter.FromDerecha_Anular) || !string.IsNullOrEmpty(filter.ToDerecha_Anular))
            {
                if (!string.IsNullOrEmpty(filter.FromDerecha_Anular))
                    where += " AND Registro_de_Huellas_Dactilares.Derecha_Anular >= " + filter.FromDerecha_Anular;
                if (!string.IsNullOrEmpty(filter.ToDerecha_Anular))
                    where += " AND Registro_de_Huellas_Dactilares.Derecha_Anular <= " + filter.ToDerecha_Anular;
            }

            if (!string.IsNullOrEmpty(filter.FromDerecha_Medio) || !string.IsNullOrEmpty(filter.ToDerecha_Medio))
            {
                if (!string.IsNullOrEmpty(filter.FromDerecha_Medio))
                    where += " AND Registro_de_Huellas_Dactilares.Derecha_Medio >= " + filter.FromDerecha_Medio;
                if (!string.IsNullOrEmpty(filter.ToDerecha_Medio))
                    where += " AND Registro_de_Huellas_Dactilares.Derecha_Medio <= " + filter.ToDerecha_Medio;
            }

            if (!string.IsNullOrEmpty(filter.FromDerecha_Indice) || !string.IsNullOrEmpty(filter.ToDerecha_Indice))
            {
                if (!string.IsNullOrEmpty(filter.FromDerecha_Indice))
                    where += " AND Registro_de_Huellas_Dactilares.Derecha_Indice >= " + filter.FromDerecha_Indice;
                if (!string.IsNullOrEmpty(filter.ToDerecha_Indice))
                    where += " AND Registro_de_Huellas_Dactilares.Derecha_Indice <= " + filter.ToDerecha_Indice;
            }

            if (!string.IsNullOrEmpty(filter.FromDerecha_Pulgar) || !string.IsNullOrEmpty(filter.ToDerecha_Pulgar))
            {
                if (!string.IsNullOrEmpty(filter.FromDerecha_Pulgar))
                    where += " AND Registro_de_Huellas_Dactilares.Derecha_Pulgar >= " + filter.FromDerecha_Pulgar;
                if (!string.IsNullOrEmpty(filter.ToDerecha_Pulgar))
                    where += " AND Registro_de_Huellas_Dactilares.Derecha_Pulgar <= " + filter.ToDerecha_Pulgar;
            }


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
                _IRegistro_de_Huellas_DactilaresApiConsumer.SetAuthHeader(_tokenManager.Token);

                Registro_de_Huellas_Dactilares varRegistro_de_Huellas_Dactilares = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IRegistro_de_Huellas_DactilaresApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Registro_de_Huellas_DactilaresModel varRegistro_de_Huellas_Dactilares)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IRegistro_de_Huellas_DactilaresApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_DedosRemoveAttachment != 0 && varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_DedosFile == null)
                    {
                        varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_Dedos = 0;
                    }

                    if (varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_DedosFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_DedosFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_Dedos = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_DedosFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }
                    if (varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_DedosRemoveAttachment != 0 && varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_DedosFile == null)
                    {
                        varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_Dedos = 0;
                    }

                    if (varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_DedosFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_DedosFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_Dedos = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_DedosFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }
                    if (varRegistro_de_Huellas_Dactilares.PulgaresRemoveAttachment != 0 && varRegistro_de_Huellas_Dactilares.PulgaresFile == null)
                    {
                        varRegistro_de_Huellas_Dactilares.Pulgares = 0;
                    }

                    if (varRegistro_de_Huellas_Dactilares.PulgaresFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varRegistro_de_Huellas_Dactilares.PulgaresFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varRegistro_de_Huellas_Dactilares.Pulgares = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varRegistro_de_Huellas_Dactilares.PulgaresFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Registro_de_Huellas_DactilaresInfo = new Registro_de_Huellas_Dactilares
                    {
                        Clave = varRegistro_de_Huellas_Dactilares.Clave
                        ,Carpeta_de_Investigacion = varRegistro_de_Huellas_Dactilares.Carpeta_de_Investigacion
                        ,Probable_Responsable = varRegistro_de_Huellas_Dactilares.Probable_Responsable
                        ,Mano_Izquierda_4_Dedos = (varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_Dedos.HasValue && varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_Dedos != 0) ? ((int?)Convert.ToInt32(varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_Dedos.Value)) : null

                        ,Mano_Derecha_4_Dedos = (varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_Dedos.HasValue && varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_Dedos != 0) ? ((int?)Convert.ToInt32(varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_Dedos.Value)) : null

                        ,Pulgares = (varRegistro_de_Huellas_Dactilares.Pulgares.HasValue && varRegistro_de_Huellas_Dactilares.Pulgares != 0) ? ((int?)Convert.ToInt32(varRegistro_de_Huellas_Dactilares.Pulgares.Value)) : null

                        ,Izquierda_Menique = varRegistro_de_Huellas_Dactilares.Izquierda_Menique
                        ,Izquierda_Anular = varRegistro_de_Huellas_Dactilares.Izquierda_Anular
                        ,Izquierda_Medio = varRegistro_de_Huellas_Dactilares.Izquierda_Medio
                        ,Izquierda_Indice = varRegistro_de_Huellas_Dactilares.Izquierda_Indice
                        ,Izquierda_Pulgar = varRegistro_de_Huellas_Dactilares.Izquierda_Pulgar
                        ,Derecha_Menique = varRegistro_de_Huellas_Dactilares.Derecha_Menique
                        ,Derecha_Anular = varRegistro_de_Huellas_Dactilares.Derecha_Anular
                        ,Derecha_Medio = varRegistro_de_Huellas_Dactilares.Derecha_Medio
                        ,Derecha_Indice = varRegistro_de_Huellas_Dactilares.Derecha_Indice
                        ,Derecha_Pulgar = varRegistro_de_Huellas_Dactilares.Derecha_Pulgar

                    };

                    result = !IsNew ?
                        _IRegistro_de_Huellas_DactilaresApiConsumer.Update(Registro_de_Huellas_DactilaresInfo, null, null).Resource.ToString() :
                         _IRegistro_de_Huellas_DactilaresApiConsumer.Insert(Registro_de_Huellas_DactilaresInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Registro_de_Huellas_Dactilares script
        /// </summary>
        /// <param name="oRegistro_de_Huellas_DactilaresElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Registro_de_Huellas_DactilaresModuleAttributeList)
        {
            for (int i = 0; i < Registro_de_Huellas_DactilaresModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Registro_de_Huellas_DactilaresModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Registro_de_Huellas_DactilaresModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Registro_de_Huellas_DactilaresModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Registro_de_Huellas_DactilaresModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Registro_de_Huellas_DactilaresModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Registro_de_Huellas_DactilaresModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Registro_de_Huellas_DactilaresModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Registro_de_Huellas_DactilaresModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Registro_de_Huellas_DactilaresModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Registro_de_Huellas_DactilaresModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Registro_de_Huellas_DactilaresModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strRegistro_de_Huellas_DactilaresScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Registro_de_Huellas_Dactilares.js")))
            {
                strRegistro_de_Huellas_DactilaresScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Registro_de_Huellas_Dactilares element attributes
            string userChangeJson = jsSerialize.Serialize(Registro_de_Huellas_DactilaresModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strRegistro_de_Huellas_DactilaresScript.IndexOf("inpuElementArray");
            string splittedString = strRegistro_de_Huellas_DactilaresScript.Substring(indexOfArray, strRegistro_de_Huellas_DactilaresScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Registro_de_Huellas_DactilaresModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Registro_de_Huellas_DactilaresModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strRegistro_de_Huellas_DactilaresScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strRegistro_de_Huellas_DactilaresScript.Substring(indexOfArrayHistory, strRegistro_de_Huellas_DactilaresScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strRegistro_de_Huellas_DactilaresScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strRegistro_de_Huellas_DactilaresScript.Substring(endIndexOfMainElement + indexOfArray, strRegistro_de_Huellas_DactilaresScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Registro_de_Huellas_DactilaresModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Registro_de_Huellas_DactilaresModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Registro_de_Huellas_Dactilares.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Registro_de_Huellas_Dactilares.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Registro_de_Huellas_Dactilares.js")))
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
        public ActionResult Registro_de_Huellas_DactilaresPropertyBag()
        {
            return PartialView("Registro_de_Huellas_DactilaresPropertyBag", "Registro_de_Huellas_Dactilares");
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
                var whereClauseFormat = "Object = 45734 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IRegistro_de_Huellas_DactilaresApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Registro_de_Huellas_Dactilares.Clave= " + RecordId;
                            var result = _IRegistro_de_Huellas_DactilaresApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IRegistro_de_Huellas_DactilaresApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Registro_de_Huellas_DactilaresPropertyMapper());
			
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
                    (Registro_de_Huellas_DactilaresAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Registro_de_Huellas_DactilaresPropertyMapper oRegistro_de_Huellas_DactilaresPropertyMapper = new Registro_de_Huellas_DactilaresPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRegistro_de_Huellas_DactilaresPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRegistro_de_Huellas_DactilaresApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Huellas_Dactilaress == null)
                result.Registro_de_Huellas_Dactilaress = new List<Registro_de_Huellas_Dactilares>();

            var data = result.Registro_de_Huellas_Dactilaress.Select(m => new Registro_de_Huellas_DactilaresGridModel
            {
                Clave = m.Clave
                        ,Carpeta_de_Investigacionnic = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Carpeta_de_Investigacion_expediente_ministerio_publico.nic
                        ,Probable_ResponsableNombre_Completo = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Probable_Responsable_Detalle_de_Datos_Generales.Nombre_Completo
			,Mano_Izquierda_4_Dedos = m.Mano_Izquierda_4_Dedos
			,Mano_Derecha_4_Dedos = m.Mano_Derecha_4_Dedos
			,Pulgares = m.Pulgares
			,Izquierda_Menique = m.Izquierda_Menique
			,Izquierda_Anular = m.Izquierda_Anular
			,Izquierda_Medio = m.Izquierda_Medio
			,Izquierda_Indice = m.Izquierda_Indice
			,Izquierda_Pulgar = m.Izquierda_Pulgar
			,Derecha_Menique = m.Derecha_Menique
			,Derecha_Anular = m.Derecha_Anular
			,Derecha_Medio = m.Derecha_Medio
			,Derecha_Indice = m.Derecha_Indice
			,Derecha_Pulgar = m.Derecha_Pulgar

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45734, arrayColumnsVisible), "Registro_de_Huellas_DactilaresList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45734, arrayColumnsVisible), "Registro_de_Huellas_DactilaresList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45734, arrayColumnsVisible), "Registro_de_Huellas_DactilaresList_" + DateTime.Now.ToString());
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

            _IRegistro_de_Huellas_DactilaresApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Registro_de_Huellas_DactilaresPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Registro_de_Huellas_DactilaresAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Registro_de_Huellas_DactilaresPropertyMapper oRegistro_de_Huellas_DactilaresPropertyMapper = new Registro_de_Huellas_DactilaresPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRegistro_de_Huellas_DactilaresPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRegistro_de_Huellas_DactilaresApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Huellas_Dactilaress == null)
                result.Registro_de_Huellas_Dactilaress = new List<Registro_de_Huellas_Dactilares>();

            var data = result.Registro_de_Huellas_Dactilaress.Select(m => new Registro_de_Huellas_DactilaresGridModel
            {
                Clave = m.Clave
                        ,Carpeta_de_Investigacionnic = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Carpeta_de_Investigacion_expediente_ministerio_publico.nic
                        ,Probable_ResponsableNombre_Completo = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Probable_Responsable_Detalle_de_Datos_Generales.Nombre_Completo
			,Mano_Izquierda_4_Dedos = m.Mano_Izquierda_4_Dedos
			,Mano_Derecha_4_Dedos = m.Mano_Derecha_4_Dedos
			,Pulgares = m.Pulgares
			,Izquierda_Menique = m.Izquierda_Menique
			,Izquierda_Anular = m.Izquierda_Anular
			,Izquierda_Medio = m.Izquierda_Medio
			,Izquierda_Indice = m.Izquierda_Indice
			,Izquierda_Pulgar = m.Izquierda_Pulgar
			,Derecha_Menique = m.Derecha_Menique
			,Derecha_Anular = m.Derecha_Anular
			,Derecha_Medio = m.Derecha_Medio
			,Derecha_Indice = m.Derecha_Indice
			,Derecha_Pulgar = m.Derecha_Pulgar

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
                _IRegistro_de_Huellas_DactilaresApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegistro_de_Huellas_DactilaresApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Registro_de_Huellas_Dactilares_Datos_GeneralesModel varRegistro_de_Huellas_Dactilares)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Huellas_DactilaresApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_DedosRemoveAttachment != 0 && varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_DedosFile == null)
                    {
                        varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_Dedos = 0;
                    }

                    if (varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_DedosFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_DedosFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_Dedos = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_DedosFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }
                    if (varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_DedosRemoveAttachment != 0 && varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_DedosFile == null)
                    {
                        varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_Dedos = 0;
                    }

                    if (varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_DedosFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_DedosFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_Dedos = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_DedosFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }
                    if (varRegistro_de_Huellas_Dactilares.PulgaresRemoveAttachment != 0 && varRegistro_de_Huellas_Dactilares.PulgaresFile == null)
                    {
                        varRegistro_de_Huellas_Dactilares.Pulgares = 0;
                    }

                    if (varRegistro_de_Huellas_Dactilares.PulgaresFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varRegistro_de_Huellas_Dactilares.PulgaresFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varRegistro_de_Huellas_Dactilares.Pulgares = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varRegistro_de_Huellas_Dactilares.PulgaresFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Registro_de_Huellas_Dactilares_Datos_GeneralesInfo = new Registro_de_Huellas_Dactilares_Datos_Generales
                {
                    Clave = varRegistro_de_Huellas_Dactilares.Clave
                                            ,Carpeta_de_Investigacion = varRegistro_de_Huellas_Dactilares.Carpeta_de_Investigacion
                        ,Probable_Responsable = varRegistro_de_Huellas_Dactilares.Probable_Responsable
                        ,Mano_Izquierda_4_Dedos = (varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_Dedos.HasValue && varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_Dedos != 0) ? ((int?)Convert.ToInt32(varRegistro_de_Huellas_Dactilares.Mano_Izquierda_4_Dedos.Value)) : null

                        ,Mano_Derecha_4_Dedos = (varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_Dedos.HasValue && varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_Dedos != 0) ? ((int?)Convert.ToInt32(varRegistro_de_Huellas_Dactilares.Mano_Derecha_4_Dedos.Value)) : null

                        ,Pulgares = (varRegistro_de_Huellas_Dactilares.Pulgares.HasValue && varRegistro_de_Huellas_Dactilares.Pulgares != 0) ? ((int?)Convert.ToInt32(varRegistro_de_Huellas_Dactilares.Pulgares.Value)) : null

                        ,Izquierda_Menique = varRegistro_de_Huellas_Dactilares.Izquierda_Menique
                        ,Izquierda_Anular = varRegistro_de_Huellas_Dactilares.Izquierda_Anular
                        ,Izquierda_Medio = varRegistro_de_Huellas_Dactilares.Izquierda_Medio
                        ,Izquierda_Indice = varRegistro_de_Huellas_Dactilares.Izquierda_Indice
                        ,Izquierda_Pulgar = varRegistro_de_Huellas_Dactilares.Izquierda_Pulgar
                        ,Derecha_Menique = varRegistro_de_Huellas_Dactilares.Derecha_Menique
                        ,Derecha_Anular = varRegistro_de_Huellas_Dactilares.Derecha_Anular
                        ,Derecha_Medio = varRegistro_de_Huellas_Dactilares.Derecha_Medio
                        ,Derecha_Indice = varRegistro_de_Huellas_Dactilares.Derecha_Indice
                        ,Derecha_Pulgar = varRegistro_de_Huellas_Dactilares.Derecha_Pulgar
                    
                };

                result = _IRegistro_de_Huellas_DactilaresApiConsumer.Update_Datos_Generales(Registro_de_Huellas_Dactilares_Datos_GeneralesInfo).Resource.ToString();
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
                _IRegistro_de_Huellas_DactilaresApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Huellas_DactilaresApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Registro_de_Huellas_Dactilares_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Carpeta_de_Investigacion = m.Carpeta_de_Investigacion
                        ,Carpeta_de_Investigacionnic = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Carpeta_de_Investigacion_expediente_ministerio_publico.nic
                        ,Probable_Responsable = m.Probable_Responsable
                        ,Probable_ResponsableNombre_Completo = CultureHelper.GetTraduction(m.Probable_Responsable_Detalle_de_Datos_Generales.Clave.ToString(), "Detalle_de_Datos_Generales") ?? (string)m.Probable_Responsable_Detalle_de_Datos_Generales.Nombre_Completo
			,Mano_Izquierda_4_Dedos = m.Mano_Izquierda_4_Dedos
			,Mano_Derecha_4_Dedos = m.Mano_Derecha_4_Dedos
			,Pulgares = m.Pulgares
			,Izquierda_Menique = m.Izquierda_Menique
			,Izquierda_Anular = m.Izquierda_Anular
			,Izquierda_Medio = m.Izquierda_Medio
			,Izquierda_Indice = m.Izquierda_Indice
			,Izquierda_Pulgar = m.Izquierda_Pulgar
			,Derecha_Menique = m.Derecha_Menique
			,Derecha_Anular = m.Derecha_Anular
			,Derecha_Medio = m.Derecha_Medio
			,Derecha_Indice = m.Derecha_Indice
			,Derecha_Pulgar = m.Derecha_Pulgar

                    
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

