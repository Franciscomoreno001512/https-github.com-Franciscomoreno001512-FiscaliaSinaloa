using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Robo_de_Vehiculo_PC;
using Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Core.Domain.Tipo_de_Solicitud;
using Spartane.Core.Domain.Marca_del_Vehiculo;
using Spartane.Core.Domain.Sub_Marca_del_Vehiculo;
using Spartane.Core.Domain.Tipo_de_Vehiculo;
using Spartane.Core.Domain.Color_Vehiculo;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Robo_de_Vehiculo_PC;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Robo_de_Vehiculo_PC;
using Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Marca_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Sub_Marca_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Color_Vehiculo;

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
    public class Robo_de_Vehiculo_PCController : Controller
    {
        #region "variable declaration"

        private IRobo_de_Vehiculo_PCService service = null;
        private IRobo_de_Vehiculo_PCApiConsumer _IRobo_de_Vehiculo_PCApiConsumer;
        private ISolicitud_de_Denuncia_CiudadanaApiConsumer _ISolicitud_de_Denuncia_CiudadanaApiConsumer;
        private ITipo_de_SolicitudApiConsumer _ITipo_de_SolicitudApiConsumer;
        private IMarca_del_VehiculoApiConsumer _IMarca_del_VehiculoApiConsumer;
        private ISub_Marca_del_VehiculoApiConsumer _ISub_Marca_del_VehiculoApiConsumer;
        private ITipo_de_VehiculoApiConsumer _ITipo_de_VehiculoApiConsumer;
        private IColor_VehiculoApiConsumer _IColor_VehiculoApiConsumer;

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

        
        public Robo_de_Vehiculo_PCController(IRobo_de_Vehiculo_PCService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IRobo_de_Vehiculo_PCApiConsumer Robo_de_Vehiculo_PCApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISolicitud_de_Denuncia_CiudadanaApiConsumer Solicitud_de_Denuncia_CiudadanaApiConsumer , ITipo_de_SolicitudApiConsumer Tipo_de_SolicitudApiConsumer , IMarca_del_VehiculoApiConsumer Marca_del_VehiculoApiConsumer , ISub_Marca_del_VehiculoApiConsumer Sub_Marca_del_VehiculoApiConsumer , ITipo_de_VehiculoApiConsumer Tipo_de_VehiculoApiConsumer , IColor_VehiculoApiConsumer Color_VehiculoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IRobo_de_Vehiculo_PCApiConsumer = Robo_de_Vehiculo_PCApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ISolicitud_de_Denuncia_CiudadanaApiConsumer = Solicitud_de_Denuncia_CiudadanaApiConsumer;
            this._ITipo_de_SolicitudApiConsumer = Tipo_de_SolicitudApiConsumer;
            this._IMarca_del_VehiculoApiConsumer = Marca_del_VehiculoApiConsumer;
            this._ISub_Marca_del_VehiculoApiConsumer = Sub_Marca_del_VehiculoApiConsumer;
            this._ITipo_de_VehiculoApiConsumer = Tipo_de_VehiculoApiConsumer;
            this._IColor_VehiculoApiConsumer = Color_VehiculoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Robo_de_Vehiculo_PC
        [ObjectAuth(ObjectId = (ModuleObjectId)45712, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45712, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Robo_de_Vehiculo_PC/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45712, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45712, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varRobo_de_Vehiculo_PC = new Robo_de_Vehiculo_PCModel();
			varRobo_de_Vehiculo_PC.Clave = Id;
			
            ViewBag.ObjectId = "45712";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IRobo_de_Vehiculo_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Robo_de_Vehiculo_PCsData = _IRobo_de_Vehiculo_PCApiConsumer.ListaSelAll(0, 1000, "Robo_de_Vehiculo_PC.Clave=" + Id, "").Resource.Robo_de_Vehiculo_PCs;
				
				if (Robo_de_Vehiculo_PCsData != null && Robo_de_Vehiculo_PCsData.Count > 0)
                {
					var Robo_de_Vehiculo_PCData = Robo_de_Vehiculo_PCsData.First();
					varRobo_de_Vehiculo_PC= new Robo_de_Vehiculo_PCModel
					{
						Clave  = Robo_de_Vehiculo_PCData.Clave 
	                    ,Solicitud = Robo_de_Vehiculo_PCData.Solicitud
                    ,SolicitudFolio = CultureHelper.GetTraduction(Convert.ToString(Robo_de_Vehiculo_PCData.Solicitud), "Solicitud_de_Denuncia_Ciudadana") ??  (string)Robo_de_Vehiculo_PCData.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                    ,Tipo_de_Solicitud = Robo_de_Vehiculo_PCData.Tipo_de_Solicitud
                    ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(Convert.ToString(Robo_de_Vehiculo_PCData.Tipo_de_Solicitud), "Tipo_de_Solicitud") ??  (string)Robo_de_Vehiculo_PCData.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                    ,Robo_de_Vehiculo = Robo_de_Vehiculo_PCData.Robo_de_Vehiculo.GetValueOrDefault()
                    ,Marca = Robo_de_Vehiculo_PCData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Robo_de_Vehiculo_PCData.Marca), "Marca_del_Vehiculo") ??  (string)Robo_de_Vehiculo_PCData.Marca_Marca_del_Vehiculo.Descripcion
                    ,Sub_Marca = Robo_de_Vehiculo_PCData.Sub_Marca
                    ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Robo_de_Vehiculo_PCData.Sub_Marca), "Sub_Marca_del_Vehiculo") ??  (string)Robo_de_Vehiculo_PCData.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                    ,Tipo_de_Vehiculo = Robo_de_Vehiculo_PCData.Tipo_de_Vehiculo
                    ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Robo_de_Vehiculo_PCData.Tipo_de_Vehiculo), "Tipo_de_Vehiculo") ??  (string)Robo_de_Vehiculo_PCData.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
                    ,Modelo = Robo_de_Vehiculo_PCData.Modelo
                    ,Color = Robo_de_Vehiculo_PCData.Color
                    ,ColorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Robo_de_Vehiculo_PCData.Color), "Color_Vehiculo") ??  (string)Robo_de_Vehiculo_PCData.Color_Color_Vehiculo.Descripcion
                    ,Placas = Robo_de_Vehiculo_PCData.Placas
                    ,Senas_Particulares = Robo_de_Vehiculo_PCData.Senas_Particulares

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Solicituds_Tipo_de_Solicitud = _ITipo_de_SolicitudApiConsumer.SelAll(true);
            if (Tipo_de_Solicituds_Tipo_de_Solicitud != null && Tipo_de_Solicituds_Tipo_de_Solicitud.Resource != null)
                ViewBag.Tipo_de_Solicituds_Tipo_de_Solicitud = Tipo_de_Solicituds_Tipo_de_Solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_del_Vehiculos_Marca = _IMarca_del_VehiculoApiConsumer.SelAll(true);
            if (Marca_del_Vehiculos_Marca != null && Marca_del_Vehiculos_Marca.Resource != null)
                ViewBag.Marca_del_Vehiculos_Marca = Marca_del_Vehiculos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sub_Marca_del_Vehiculos_Sub_Marca = _ISub_Marca_del_VehiculoApiConsumer.SelAll(true);
            if (Sub_Marca_del_Vehiculos_Sub_Marca != null && Sub_Marca_del_Vehiculos_Sub_Marca.Resource != null)
                ViewBag.Sub_Marca_del_Vehiculos_Sub_Marca = Sub_Marca_del_Vehiculos_Sub_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_Vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_Vehiculo != null && Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_Vehiculo = Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Vehiculos_Color = _IColor_VehiculoApiConsumer.SelAll(true);
            if (Color_Vehiculos_Color != null && Color_Vehiculos_Color.Resource != null)
                ViewBag.Color_Vehiculos_Color = Color_Vehiculos_Color.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


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

				
            return View(varRobo_de_Vehiculo_PC);
        }
		
	[HttpGet]
        public ActionResult AddRobo_de_Vehiculo_PC(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45712);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IRobo_de_Vehiculo_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
			Robo_de_Vehiculo_PCModel varRobo_de_Vehiculo_PC= new Robo_de_Vehiculo_PCModel();


            if (id.ToString() != "0")
            {
                var Robo_de_Vehiculo_PCsData = _IRobo_de_Vehiculo_PCApiConsumer.ListaSelAll(0, 1000, "Robo_de_Vehiculo_PC.Clave=" + id, "").Resource.Robo_de_Vehiculo_PCs;
				
				if (Robo_de_Vehiculo_PCsData != null && Robo_de_Vehiculo_PCsData.Count > 0)
                {
					var Robo_de_Vehiculo_PCData = Robo_de_Vehiculo_PCsData.First();
					varRobo_de_Vehiculo_PC= new Robo_de_Vehiculo_PCModel
					{
						Clave  = Robo_de_Vehiculo_PCData.Clave 
	                    ,Solicitud = Robo_de_Vehiculo_PCData.Solicitud
                    ,SolicitudFolio = CultureHelper.GetTraduction(Convert.ToString(Robo_de_Vehiculo_PCData.Solicitud), "Solicitud_de_Denuncia_Ciudadana") ??  (string)Robo_de_Vehiculo_PCData.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                    ,Tipo_de_Solicitud = Robo_de_Vehiculo_PCData.Tipo_de_Solicitud
                    ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(Convert.ToString(Robo_de_Vehiculo_PCData.Tipo_de_Solicitud), "Tipo_de_Solicitud") ??  (string)Robo_de_Vehiculo_PCData.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                    ,Robo_de_Vehiculo = Robo_de_Vehiculo_PCData.Robo_de_Vehiculo.GetValueOrDefault()
                    ,Marca = Robo_de_Vehiculo_PCData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Robo_de_Vehiculo_PCData.Marca), "Marca_del_Vehiculo") ??  (string)Robo_de_Vehiculo_PCData.Marca_Marca_del_Vehiculo.Descripcion
                    ,Sub_Marca = Robo_de_Vehiculo_PCData.Sub_Marca
                    ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Robo_de_Vehiculo_PCData.Sub_Marca), "Sub_Marca_del_Vehiculo") ??  (string)Robo_de_Vehiculo_PCData.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                    ,Tipo_de_Vehiculo = Robo_de_Vehiculo_PCData.Tipo_de_Vehiculo
                    ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Robo_de_Vehiculo_PCData.Tipo_de_Vehiculo), "Tipo_de_Vehiculo") ??  (string)Robo_de_Vehiculo_PCData.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
                    ,Modelo = Robo_de_Vehiculo_PCData.Modelo
                    ,Color = Robo_de_Vehiculo_PCData.Color
                    ,ColorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Robo_de_Vehiculo_PCData.Color), "Color_Vehiculo") ??  (string)Robo_de_Vehiculo_PCData.Color_Color_Vehiculo.Descripcion
                    ,Placas = Robo_de_Vehiculo_PCData.Placas
                    ,Senas_Particulares = Robo_de_Vehiculo_PCData.Senas_Particulares

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Solicituds_Tipo_de_Solicitud = _ITipo_de_SolicitudApiConsumer.SelAll(true);
            if (Tipo_de_Solicituds_Tipo_de_Solicitud != null && Tipo_de_Solicituds_Tipo_de_Solicitud.Resource != null)
                ViewBag.Tipo_de_Solicituds_Tipo_de_Solicitud = Tipo_de_Solicituds_Tipo_de_Solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_del_Vehiculos_Marca = _IMarca_del_VehiculoApiConsumer.SelAll(true);
            if (Marca_del_Vehiculos_Marca != null && Marca_del_Vehiculos_Marca.Resource != null)
                ViewBag.Marca_del_Vehiculos_Marca = Marca_del_Vehiculos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sub_Marca_del_Vehiculos_Sub_Marca = _ISub_Marca_del_VehiculoApiConsumer.SelAll(true);
            if (Sub_Marca_del_Vehiculos_Sub_Marca != null && Sub_Marca_del_Vehiculos_Sub_Marca.Resource != null)
                ViewBag.Sub_Marca_del_Vehiculos_Sub_Marca = Sub_Marca_del_Vehiculos_Sub_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_Vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_Vehiculo != null && Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_Vehiculo = Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Vehiculos_Color = _IColor_VehiculoApiConsumer.SelAll(true);
            if (Color_Vehiculos_Color != null && Color_Vehiculos_Color.Resource != null)
                ViewBag.Color_Vehiculos_Color = Color_Vehiculos_Color.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddRobo_de_Vehiculo_PC", varRobo_de_Vehiculo_PC);
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
        public ActionResult GetSolicitud_de_Denuncia_CiudadanaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Folio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitud_de_Denuncia_Ciudadana", "Folio")?? m.Folio,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_SolicitudAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_SolicitudApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Solicitud", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetMarca_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMarca_del_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetSub_Marca_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISub_Marca_del_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetColor_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColor_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColor_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Vehiculo", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Robo_de_Vehiculo_PCAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Solicituds_Tipo_de_Solicitud = _ITipo_de_SolicitudApiConsumer.SelAll(true);
            if (Tipo_de_Solicituds_Tipo_de_Solicitud != null && Tipo_de_Solicituds_Tipo_de_Solicitud.Resource != null)
                ViewBag.Tipo_de_Solicituds_Tipo_de_Solicitud = Tipo_de_Solicituds_Tipo_de_Solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_del_Vehiculos_Marca = _IMarca_del_VehiculoApiConsumer.SelAll(true);
            if (Marca_del_Vehiculos_Marca != null && Marca_del_Vehiculos_Marca.Resource != null)
                ViewBag.Marca_del_Vehiculos_Marca = Marca_del_Vehiculos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sub_Marca_del_Vehiculos_Sub_Marca = _ISub_Marca_del_VehiculoApiConsumer.SelAll(true);
            if (Sub_Marca_del_Vehiculos_Sub_Marca != null && Sub_Marca_del_Vehiculos_Sub_Marca.Resource != null)
                ViewBag.Sub_Marca_del_Vehiculos_Sub_Marca = Sub_Marca_del_Vehiculos_Sub_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_Vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_Vehiculo != null && Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_Vehiculo = Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Vehiculos_Color = _IColor_VehiculoApiConsumer.SelAll(true);
            if (Color_Vehiculos_Color != null && Color_Vehiculos_Color.Resource != null)
                ViewBag.Color_Vehiculos_Color = Color_Vehiculos_Color.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Solicituds_Tipo_de_Solicitud = _ITipo_de_SolicitudApiConsumer.SelAll(true);
            if (Tipo_de_Solicituds_Tipo_de_Solicitud != null && Tipo_de_Solicituds_Tipo_de_Solicitud.Resource != null)
                ViewBag.Tipo_de_Solicituds_Tipo_de_Solicitud = Tipo_de_Solicituds_Tipo_de_Solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Marca_del_Vehiculos_Marca = _IMarca_del_VehiculoApiConsumer.SelAll(true);
            if (Marca_del_Vehiculos_Marca != null && Marca_del_Vehiculos_Marca.Resource != null)
                ViewBag.Marca_del_Vehiculos_Marca = Marca_del_Vehiculos_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Sub_Marca_del_Vehiculos_Sub_Marca = _ISub_Marca_del_VehiculoApiConsumer.SelAll(true);
            if (Sub_Marca_del_Vehiculos_Sub_Marca != null && Sub_Marca_del_Vehiculos_Sub_Marca.Resource != null)
                ViewBag.Sub_Marca_del_Vehiculos_Sub_Marca = Sub_Marca_del_Vehiculos_Sub_Marca.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Sub_Marca_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_Vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_Vehiculo != null && Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_Vehiculo = Tipo_de_Vehiculos_Tipo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IColor_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Color_Vehiculos_Color = _IColor_VehiculoApiConsumer.SelAll(true);
            if (Color_Vehiculos_Color != null && Color_Vehiculos_Color.Resource != null)
                ViewBag.Color_Vehiculos_Color = Color_Vehiculos_Color.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Color_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Robo_de_Vehiculo_PCAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Robo_de_Vehiculo_PCAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Robo_de_Vehiculo_PCAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Robo_de_Vehiculo_PCPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IRobo_de_Vehiculo_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Robo_de_Vehiculo_PCs == null)
                result.Robo_de_Vehiculo_PCs = new List<Robo_de_Vehiculo_PC>();

            return Json(new
            {
                data = result.Robo_de_Vehiculo_PCs.Select(m => new Robo_de_Vehiculo_PCGridModel
                    {
                    Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
			,Senas_Particulares = m.Senas_Particulares

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetRobo_de_Vehiculo_PCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRobo_de_Vehiculo_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRobo_de_Vehiculo_PCApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Robo_de_Vehiculo_PC", m.),
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
        /// Get List of Robo_de_Vehiculo_PC from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Robo_de_Vehiculo_PC Entity</returns>
        public ActionResult GetRobo_de_Vehiculo_PCList(UrlParametersModel param)
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
            _IRobo_de_Vehiculo_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Robo_de_Vehiculo_PCPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Robo_de_Vehiculo_PCAdvanceSearchModel))
                {
					var advanceFilter =
                    (Robo_de_Vehiculo_PCAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Robo_de_Vehiculo_PCPropertyMapper oRobo_de_Vehiculo_PCPropertyMapper = new Robo_de_Vehiculo_PCPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oRobo_de_Vehiculo_PCPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IRobo_de_Vehiculo_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Robo_de_Vehiculo_PCs == null)
                result.Robo_de_Vehiculo_PCs = new List<Robo_de_Vehiculo_PC>();

            return Json(new
            {
                aaData = result.Robo_de_Vehiculo_PCs.Select(m => new Robo_de_Vehiculo_PCGridModel
            {
                    Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
			,Senas_Particulares = m.Senas_Particulares

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetRobo_de_Vehiculo_PC_Solicitud_Solicitud_de_Denuncia_Ciudadana(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Solicitud_de_Denuncia_Ciudadana.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Solicitud_de_Denuncia_Ciudadana.Folio as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.ListaSelAll(1, 20,elWhere , " Solicitud_de_Denuncia_Ciudadana.Folio ASC ").Resource;
               
                foreach (var item in result.Solicitud_de_Denuncia_Ciudadanas)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Solicitud_de_Denuncia_Ciudadana", "Folio");
                    item.Folio =trans ??item.Folio;
                }
                return Json(result.Solicitud_de_Denuncia_Ciudadanas.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public string GetAdvanceFilter(Robo_de_Vehiculo_PCAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Robo_de_Vehiculo_PC.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Robo_de_Vehiculo_PC.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSolicitud))
            {
                switch (filter.SolicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '" + filter.AdvanceSolicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '%" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio = '" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '%" + filter.AdvanceSolicitud + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSolicitudMultiple != null && filter.AdvanceSolicitudMultiple.Count() > 0)
            {
                var SolicitudIds = string.Join(",", filter.AdvanceSolicitudMultiple);

                where += " AND Robo_de_Vehiculo_PC.Solicitud In (" + SolicitudIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Solicitud))
            {
                switch (filter.Tipo_de_SolicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Solicitud.Descripcion LIKE '" + filter.AdvanceTipo_de_Solicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Solicitud.Descripcion LIKE '%" + filter.AdvanceTipo_de_Solicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Solicitud.Descripcion = '" + filter.AdvanceTipo_de_Solicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Solicitud.Descripcion LIKE '%" + filter.AdvanceTipo_de_Solicitud + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_SolicitudMultiple != null && filter.AdvanceTipo_de_SolicitudMultiple.Count() > 0)
            {
                var Tipo_de_SolicitudIds = string.Join(",", filter.AdvanceTipo_de_SolicitudMultiple);

                where += " AND Robo_de_Vehiculo_PC.Tipo_de_Solicitud In (" + Tipo_de_SolicitudIds + ")";
            }

            if (filter.Robo_de_Vehiculo != RadioOptions.NoApply)
                where += " AND Robo_de_Vehiculo_PC.Robo_de_Vehiculo = " + Convert.ToInt32(filter.Robo_de_Vehiculo);

            if (!string.IsNullOrEmpty(filter.AdvanceMarca))
            {
                switch (filter.MarcaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Marca_del_Vehiculo.Descripcion LIKE '" + filter.AdvanceMarca + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Marca_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceMarca + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Marca_del_Vehiculo.Descripcion = '" + filter.AdvanceMarca + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Marca_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceMarca + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMarcaMultiple != null && filter.AdvanceMarcaMultiple.Count() > 0)
            {
                var MarcaIds = string.Join(",", filter.AdvanceMarcaMultiple);

                where += " AND Robo_de_Vehiculo_PC.Marca In (" + MarcaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSub_Marca))
            {
                switch (filter.Sub_MarcaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Sub_Marca_del_Vehiculo.Descripcion LIKE '" + filter.AdvanceSub_Marca + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Sub_Marca_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceSub_Marca + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Sub_Marca_del_Vehiculo.Descripcion = '" + filter.AdvanceSub_Marca + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Sub_Marca_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceSub_Marca + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSub_MarcaMultiple != null && filter.AdvanceSub_MarcaMultiple.Count() > 0)
            {
                var Sub_MarcaIds = string.Join(",", filter.AdvanceSub_MarcaMultiple);

                where += " AND Robo_de_Vehiculo_PC.Sub_Marca In (" + Sub_MarcaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Vehiculo))
            {
                switch (filter.Tipo_de_VehiculoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Vehiculo.Descripcion LIKE '" + filter.AdvanceTipo_de_Vehiculo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Vehiculo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Vehiculo.Descripcion = '" + filter.AdvanceTipo_de_Vehiculo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Vehiculo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_VehiculoMultiple != null && filter.AdvanceTipo_de_VehiculoMultiple.Count() > 0)
            {
                var Tipo_de_VehiculoIds = string.Join(",", filter.AdvanceTipo_de_VehiculoMultiple);

                where += " AND Robo_de_Vehiculo_PC.Tipo_de_Vehiculo In (" + Tipo_de_VehiculoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromModelo) || !string.IsNullOrEmpty(filter.ToModelo))
            {
                if (!string.IsNullOrEmpty(filter.FromModelo))
                    where += " AND Robo_de_Vehiculo_PC.Modelo >= " + filter.FromModelo;
                if (!string.IsNullOrEmpty(filter.ToModelo))
                    where += " AND Robo_de_Vehiculo_PC.Modelo <= " + filter.ToModelo;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColor))
            {
                switch (filter.ColorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Color_Vehiculo.Descripcion LIKE '" + filter.AdvanceColor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Color_Vehiculo.Descripcion LIKE '%" + filter.AdvanceColor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Color_Vehiculo.Descripcion = '" + filter.AdvanceColor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Color_Vehiculo.Descripcion LIKE '%" + filter.AdvanceColor + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColorMultiple != null && filter.AdvanceColorMultiple.Count() > 0)
            {
                var ColorIds = string.Join(",", filter.AdvanceColorMultiple);

                where += " AND Robo_de_Vehiculo_PC.Color In (" + ColorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Placas))
            {
                switch (filter.PlacasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Robo_de_Vehiculo_PC.Placas LIKE '" + filter.Placas + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Robo_de_Vehiculo_PC.Placas LIKE '%" + filter.Placas + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Robo_de_Vehiculo_PC.Placas = '" + filter.Placas + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Robo_de_Vehiculo_PC.Placas LIKE '%" + filter.Placas + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Senas_Particulares))
            {
                switch (filter.Senas_ParticularesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Robo_de_Vehiculo_PC.Senas_Particulares LIKE '" + filter.Senas_Particulares + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Robo_de_Vehiculo_PC.Senas_Particulares LIKE '%" + filter.Senas_Particulares + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Robo_de_Vehiculo_PC.Senas_Particulares = '" + filter.Senas_Particulares + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Robo_de_Vehiculo_PC.Senas_Particulares LIKE '%" + filter.Senas_Particulares + "%'";
                        break;
                }
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
                _IRobo_de_Vehiculo_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

                Robo_de_Vehiculo_PC varRobo_de_Vehiculo_PC = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IRobo_de_Vehiculo_PCApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Robo_de_Vehiculo_PCModel varRobo_de_Vehiculo_PC)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IRobo_de_Vehiculo_PCApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Robo_de_Vehiculo_PCInfo = new Robo_de_Vehiculo_PC
                    {
                        Clave = varRobo_de_Vehiculo_PC.Clave
                        ,Solicitud = varRobo_de_Vehiculo_PC.Solicitud
                        ,Tipo_de_Solicitud = varRobo_de_Vehiculo_PC.Tipo_de_Solicitud
                        ,Robo_de_Vehiculo = varRobo_de_Vehiculo_PC.Robo_de_Vehiculo
                        ,Marca = varRobo_de_Vehiculo_PC.Marca
                        ,Sub_Marca = varRobo_de_Vehiculo_PC.Sub_Marca
                        ,Tipo_de_Vehiculo = varRobo_de_Vehiculo_PC.Tipo_de_Vehiculo
                        ,Modelo = varRobo_de_Vehiculo_PC.Modelo
                        ,Color = varRobo_de_Vehiculo_PC.Color
                        ,Placas = varRobo_de_Vehiculo_PC.Placas
                        ,Senas_Particulares = varRobo_de_Vehiculo_PC.Senas_Particulares

                    };

                    result = !IsNew ?
                        _IRobo_de_Vehiculo_PCApiConsumer.Update(Robo_de_Vehiculo_PCInfo, null, null).Resource.ToString() :
                         _IRobo_de_Vehiculo_PCApiConsumer.Insert(Robo_de_Vehiculo_PCInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Robo_de_Vehiculo_PC script
        /// </summary>
        /// <param name="oRobo_de_Vehiculo_PCElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Robo_de_Vehiculo_PCModuleAttributeList)
        {
            for (int i = 0; i < Robo_de_Vehiculo_PCModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Robo_de_Vehiculo_PCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Robo_de_Vehiculo_PCModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Robo_de_Vehiculo_PCModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Robo_de_Vehiculo_PCModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Robo_de_Vehiculo_PCModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Robo_de_Vehiculo_PCModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Robo_de_Vehiculo_PCModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Robo_de_Vehiculo_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Robo_de_Vehiculo_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Robo_de_Vehiculo_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Robo_de_Vehiculo_PCModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strRobo_de_Vehiculo_PCScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Robo_de_Vehiculo_PC.js")))
            {
                strRobo_de_Vehiculo_PCScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Robo_de_Vehiculo_PC element attributes
            string userChangeJson = jsSerialize.Serialize(Robo_de_Vehiculo_PCModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strRobo_de_Vehiculo_PCScript.IndexOf("inpuElementArray");
            string splittedString = strRobo_de_Vehiculo_PCScript.Substring(indexOfArray, strRobo_de_Vehiculo_PCScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Robo_de_Vehiculo_PCModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Robo_de_Vehiculo_PCModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strRobo_de_Vehiculo_PCScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strRobo_de_Vehiculo_PCScript.Substring(indexOfArrayHistory, strRobo_de_Vehiculo_PCScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strRobo_de_Vehiculo_PCScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strRobo_de_Vehiculo_PCScript.Substring(endIndexOfMainElement + indexOfArray, strRobo_de_Vehiculo_PCScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Robo_de_Vehiculo_PCModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Robo_de_Vehiculo_PCModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Robo_de_Vehiculo_PC.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Robo_de_Vehiculo_PC.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Robo_de_Vehiculo_PC.js")))
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
        public ActionResult Robo_de_Vehiculo_PCPropertyBag()
        {
            return PartialView("Robo_de_Vehiculo_PCPropertyBag", "Robo_de_Vehiculo_PC");
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
                var whereClauseFormat = "Object = 45712 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IRobo_de_Vehiculo_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Robo_de_Vehiculo_PC.Clave= " + RecordId;
                            var result = _IRobo_de_Vehiculo_PCApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IRobo_de_Vehiculo_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Robo_de_Vehiculo_PCPropertyMapper());
			
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
                    (Robo_de_Vehiculo_PCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Robo_de_Vehiculo_PCPropertyMapper oRobo_de_Vehiculo_PCPropertyMapper = new Robo_de_Vehiculo_PCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRobo_de_Vehiculo_PCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRobo_de_Vehiculo_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Robo_de_Vehiculo_PCs == null)
                result.Robo_de_Vehiculo_PCs = new List<Robo_de_Vehiculo_PC>();

            var data = result.Robo_de_Vehiculo_PCs.Select(m => new Robo_de_Vehiculo_PCGridModel
            {
                Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
			,Senas_Particulares = m.Senas_Particulares

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45712, arrayColumnsVisible), "Robo_de_Vehiculo_PCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45712, arrayColumnsVisible), "Robo_de_Vehiculo_PCList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45712, arrayColumnsVisible), "Robo_de_Vehiculo_PCList_" + DateTime.Now.ToString());
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

            _IRobo_de_Vehiculo_PCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Robo_de_Vehiculo_PCPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Robo_de_Vehiculo_PCAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Robo_de_Vehiculo_PCPropertyMapper oRobo_de_Vehiculo_PCPropertyMapper = new Robo_de_Vehiculo_PCPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRobo_de_Vehiculo_PCPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRobo_de_Vehiculo_PCApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Robo_de_Vehiculo_PCs == null)
                result.Robo_de_Vehiculo_PCs = new List<Robo_de_Vehiculo_PC>();

            var data = result.Robo_de_Vehiculo_PCs.Select(m => new Robo_de_Vehiculo_PCGridModel
            {
                Clave = m.Clave
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
			,Senas_Particulares = m.Senas_Particulares

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
                _IRobo_de_Vehiculo_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRobo_de_Vehiculo_PCApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Robo_de_Vehiculo_PC_Datos_GeneralesModel varRobo_de_Vehiculo_PC)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRobo_de_Vehiculo_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Robo_de_Vehiculo_PC_Datos_GeneralesInfo = new Robo_de_Vehiculo_PC_Datos_Generales
                {
                    Clave = varRobo_de_Vehiculo_PC.Clave
                                            ,Solicitud = varRobo_de_Vehiculo_PC.Solicitud
                        ,Tipo_de_Solicitud = varRobo_de_Vehiculo_PC.Tipo_de_Solicitud
                        ,Robo_de_Vehiculo = varRobo_de_Vehiculo_PC.Robo_de_Vehiculo
                        ,Marca = varRobo_de_Vehiculo_PC.Marca
                        ,Sub_Marca = varRobo_de_Vehiculo_PC.Sub_Marca
                        ,Tipo_de_Vehiculo = varRobo_de_Vehiculo_PC.Tipo_de_Vehiculo
                        ,Modelo = varRobo_de_Vehiculo_PC.Modelo
                        ,Color = varRobo_de_Vehiculo_PC.Color
                        ,Placas = varRobo_de_Vehiculo_PC.Placas
                        ,Senas_Particulares = varRobo_de_Vehiculo_PC.Senas_Particulares
                    
                };

                result = _IRobo_de_Vehiculo_PCApiConsumer.Update_Datos_Generales(Robo_de_Vehiculo_PC_Datos_GeneralesInfo).Resource.ToString();
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
                _IRobo_de_Vehiculo_PCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRobo_de_Vehiculo_PCApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Robo_de_Vehiculo_PC_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Solicitud = m.Solicitud
                        ,SolicitudFolio = CultureHelper.GetTraduction(m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Clave.ToString(), "Solicitud_de_Denuncia_Ciudadana") ?? (string)m.Solicitud_Solicitud_de_Denuncia_Ciudadana.Folio
                        ,Tipo_de_Solicitud = m.Tipo_de_Solicitud
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                        ,Marca = m.Marca
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_Marca = m.Sub_Marca
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_Vehiculo = m.Tipo_de_Vehiculo
                        ,Tipo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,Color = m.Color
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
			,Senas_Particulares = m.Senas_Particulares

                    
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

