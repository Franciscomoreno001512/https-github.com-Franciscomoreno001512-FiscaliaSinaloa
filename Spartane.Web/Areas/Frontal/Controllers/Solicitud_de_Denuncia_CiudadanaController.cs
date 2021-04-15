using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Solicitud;
using Spartane.Core.Domain.Estatus_de_Solicitud;
using Spartane.Core.Domain.PC_CanalizarA;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Solicitud;
using Spartane.Web.Areas.WebApiConsumer.PC_CanalizarA;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_Resolucion_Portal_Ciudadano;
using Spartane.Web.Areas.WebApiConsumer.Region;
using Spartane.Web.Areas.WebApiConsumer.Unidad;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Contestacion_de_Portal_Ciudadano;

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
    public class Solicitud_de_Denuncia_CiudadanaController : Controller
    {
        #region "variable declaration"

        private ISolicitud_de_Denuncia_CiudadanaService service = null;
        private ISolicitud_de_Denuncia_CiudadanaApiConsumer _ISolicitud_de_Denuncia_CiudadanaApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ITipo_de_SolicitudApiConsumer _ITipo_de_SolicitudApiConsumer;
        private IEstatus_de_SolicitudApiConsumer _IEstatus_de_SolicitudApiConsumer;
        private IPC_CanalizarAApiConsumer _IPC_CanalizarAApiConsumer;
        private ITipo_Resolucion_Portal_CiudadanoApiConsumer _ITipo_Resolucion_Portal_CiudadanoApiConsumer;
        private IRegionApiConsumer _IRegionApiConsumer;
        private IUnidadApiConsumer _IUnidadApiConsumer;
        private IContestacion_de_Portal_CiudadanoApiConsumer _IContestacion_de_Portal_CiudadanoApiConsumer;

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

        
        public Solicitud_de_Denuncia_CiudadanaController(ISolicitud_de_Denuncia_CiudadanaService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ISolicitud_de_Denuncia_CiudadanaApiConsumer Solicitud_de_Denuncia_CiudadanaApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ITipo_de_SolicitudApiConsumer Tipo_de_SolicitudApiConsumer , IEstatus_de_SolicitudApiConsumer Estatus_de_SolicitudApiConsumer , IPC_CanalizarAApiConsumer PC_CanalizarAApiConsumer , ITipo_Resolucion_Portal_CiudadanoApiConsumer Tipo_Resolucion_Portal_CiudadanoApiConsumer , IRegionApiConsumer RegionApiConsumer , IUnidadApiConsumer UnidadApiConsumer , IContestacion_de_Portal_CiudadanoApiConsumer Contestacion_de_Portal_CiudadanoApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ISolicitud_de_Denuncia_CiudadanaApiConsumer = Solicitud_de_Denuncia_CiudadanaApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ITipo_de_SolicitudApiConsumer = Tipo_de_SolicitudApiConsumer;
            this._IEstatus_de_SolicitudApiConsumer = Estatus_de_SolicitudApiConsumer;
            this._IPC_CanalizarAApiConsumer = PC_CanalizarAApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ITipo_Resolucion_Portal_CiudadanoApiConsumer = Tipo_Resolucion_Portal_CiudadanoApiConsumer;
            this._IRegionApiConsumer = RegionApiConsumer;
            this._IUnidadApiConsumer = UnidadApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IContestacion_de_Portal_CiudadanoApiConsumer = Contestacion_de_Portal_CiudadanoApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Solicitud_de_Denuncia_Ciudadana
        [ObjectAuth(ObjectId = (ModuleObjectId)45710, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45710, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Solicitud_de_Denuncia_Ciudadana/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45710, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45710, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varSolicitud_de_Denuncia_Ciudadana = new Solicitud_de_Denuncia_CiudadanaModel();
			varSolicitud_de_Denuncia_Ciudadana.Clave = Id;
			
            ViewBag.ObjectId = "45710";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Solicitud_de_Denuncia_CiudadanasData = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.ListaSelAll(0, 1000, "Solicitud_de_Denuncia_Ciudadana.Clave=" + Id, "").Resource.Solicitud_de_Denuncia_Ciudadanas;
				
				if (Solicitud_de_Denuncia_CiudadanasData != null && Solicitud_de_Denuncia_CiudadanasData.Count > 0)
                {
					var Solicitud_de_Denuncia_CiudadanaData = Solicitud_de_Denuncia_CiudadanasData.First();
					varSolicitud_de_Denuncia_Ciudadana= new Solicitud_de_Denuncia_CiudadanaModel
					{
						Clave  = Solicitud_de_Denuncia_CiudadanaData.Clave 
	                    ,Folio = Solicitud_de_Denuncia_CiudadanaData.Folio
                    ,Contrasena = Solicitud_de_Denuncia_CiudadanaData.Contrasena
                    ,Fecha_de_Registro = (Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Solicitud_de_Denuncia_CiudadanaData.Hora_de_Registro
                    ,Usuario_que_Registra = Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Registra), "Spartan_User") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Registra_Spartan_User.Name
                    ,Tipo_de_Solicitud = Solicitud_de_Denuncia_CiudadanaData.Tipo_de_Solicitud
                    ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Tipo_de_Solicitud), "Tipo_de_Solicitud") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                    ,Estatus_de_Solicitud = Solicitud_de_Denuncia_CiudadanaData.Estatus_de_Solicitud
                    ,Estatus_de_SolicitudDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Estatus_de_Solicitud), "Estatus_de_Solicitud") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Estatus_de_Solicitud_Estatus_de_Solicitud.Descripcion
                    ,Motivo = Solicitud_de_Denuncia_CiudadanaData.Motivo
                    ,Canalizar_a = Solicitud_de_Denuncia_CiudadanaData.Canalizar_a
                    ,Canalizar_aDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Canalizar_a), "PC_CanalizarA") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Canalizar_a_PC_CanalizarA.Descripcion
                    ,Fecha_de_Revision = (Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Revision = Solicitud_de_Denuncia_CiudadanaData.Hora_de_Revision
                    ,Usuario_que_Revisa = Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Revisa
                    ,Usuario_que_RevisaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Revisa), "Spartan_User") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Revisa_Spartan_User.Name
                    ,Tipo_de_Resolucion = Solicitud_de_Denuncia_CiudadanaData.Tipo_de_Resolucion
                    ,Tipo_de_ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Tipo_de_Resolucion), "Tipo_Resolucion_Portal_Ciudadano") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Tipo_de_Resolucion_Tipo_Resolucion_Portal_Ciudadano.Descripcion
                    ,Region = Solicitud_de_Denuncia_CiudadanaData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Region), "Region") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Region_Region.Descripcion
                    ,Unidad_canaliza = Solicitud_de_Denuncia_CiudadanaData.Unidad_canaliza
                    ,Unidad_canalizaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Unidad_canaliza), "Unidad") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Unidad_canaliza_Unidad.Descripcion
                    ,Contestacion = Solicitud_de_Denuncia_CiudadanaData.Contestacion
                    ,Observaciones_resolucion = Solicitud_de_Denuncia_CiudadanaData.Observaciones_resolucion
                    ,Fecha_de_Asignacion = (Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Asignacion = Solicitud_de_Denuncia_CiudadanaData.Hora_de_Asignacion
                    ,Usuario_que_Asigna = Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Asigna
                    ,Usuario_que_AsignaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Asigna), "Spartan_User") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Asigna_Spartan_User.Name
                    ,Responsable_Asignado = Solicitud_de_Denuncia_CiudadanaData.Responsable_Asignado
                    ,Responsable_AsignadoName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Responsable_Asignado), "Spartan_User") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Responsable_Asignado_Spartan_User.Name
                    ,Observaciones_responsable = Solicitud_de_Denuncia_CiudadanaData.Observaciones_responsable
                    ,Fecha_de_Atencion = (Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Atencion == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Atencion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Atencion = Solicitud_de_Denuncia_CiudadanaData.Hora_de_Atencion
                    ,Usuario_que_Atiende = Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Atiende
                    ,Usuario_que_AtiendeName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Atiende), "Spartan_User") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Atiende_Spartan_User.Name
                    ,Atencion_Realizada = Solicitud_de_Denuncia_CiudadanaData.Atencion_Realizada
                    ,Atencion_RealizadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Atencion_Realizada), "Contestacion_de_Portal_Ciudadano") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Atencion_Realizada_Contestacion_de_Portal_Ciudadano.Descripcion
                    ,Observaciones_atencion = Solicitud_de_Denuncia_CiudadanaData.Observaciones_atencion

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
            _IEstatus_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Solicituds_Estatus_de_Solicitud = _IEstatus_de_SolicitudApiConsumer.SelAll(true);
            if (Estatus_de_Solicituds_Estatus_de_Solicitud != null && Estatus_de_Solicituds_Estatus_de_Solicitud.Resource != null)
                ViewBag.Estatus_de_Solicituds_Estatus_de_Solicitud = Estatus_de_Solicituds_Estatus_de_Solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPC_CanalizarAApiConsumer.SetAuthHeader(_tokenManager.Token);
            var PC_CanalizarAs_Canalizar_a = _IPC_CanalizarAApiConsumer.SelAll(true);
            if (PC_CanalizarAs_Canalizar_a != null && PC_CanalizarAs_Canalizar_a.Resource != null)
                ViewBag.PC_CanalizarAs_Canalizar_a = PC_CanalizarAs_Canalizar_a.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "PC_CanalizarA", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_Resolucion_Portal_CiudadanoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion = _ITipo_Resolucion_Portal_CiudadanoApiConsumer.SelAll(true);
            if (Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion != null && Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion.Resource != null)
                ViewBag.Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion = Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Resolucion_Portal_Ciudadano", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad_canaliza = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad_canaliza != null && Unidads_Unidad_canaliza.Resource != null)
                ViewBag.Unidads_Unidad_canaliza = Unidads_Unidad_canaliza.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IContestacion_de_Portal_CiudadanoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Contestacion_de_Portal_Ciudadanos_Atencion_Realizada = _IContestacion_de_Portal_CiudadanoApiConsumer.SelAll(true);
            if (Contestacion_de_Portal_Ciudadanos_Atencion_Realizada != null && Contestacion_de_Portal_Ciudadanos_Atencion_Realizada.Resource != null)
                ViewBag.Contestacion_de_Portal_Ciudadanos_Atencion_Realizada = Contestacion_de_Portal_Ciudadanos_Atencion_Realizada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Contestacion_de_Portal_Ciudadano", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varSolicitud_de_Denuncia_Ciudadana);
        }
		
	[HttpGet]
        public ActionResult AddSolicitud_de_Denuncia_Ciudadana(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45710);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
			Solicitud_de_Denuncia_CiudadanaModel varSolicitud_de_Denuncia_Ciudadana= new Solicitud_de_Denuncia_CiudadanaModel();


            if (id.ToString() != "0")
            {
                var Solicitud_de_Denuncia_CiudadanasData = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.ListaSelAll(0, 1000, "Solicitud_de_Denuncia_Ciudadana.Clave=" + id, "").Resource.Solicitud_de_Denuncia_Ciudadanas;
				
				if (Solicitud_de_Denuncia_CiudadanasData != null && Solicitud_de_Denuncia_CiudadanasData.Count > 0)
                {
					var Solicitud_de_Denuncia_CiudadanaData = Solicitud_de_Denuncia_CiudadanasData.First();
					varSolicitud_de_Denuncia_Ciudadana= new Solicitud_de_Denuncia_CiudadanaModel
					{
						Clave  = Solicitud_de_Denuncia_CiudadanaData.Clave 
	                    ,Folio = Solicitud_de_Denuncia_CiudadanaData.Folio
                    ,Contrasena = Solicitud_de_Denuncia_CiudadanaData.Contrasena
                    ,Fecha_de_Registro = (Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Solicitud_de_Denuncia_CiudadanaData.Hora_de_Registro
                    ,Usuario_que_Registra = Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Registra), "Spartan_User") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Registra_Spartan_User.Name
                    ,Tipo_de_Solicitud = Solicitud_de_Denuncia_CiudadanaData.Tipo_de_Solicitud
                    ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Tipo_de_Solicitud), "Tipo_de_Solicitud") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                    ,Estatus_de_Solicitud = Solicitud_de_Denuncia_CiudadanaData.Estatus_de_Solicitud
                    ,Estatus_de_SolicitudDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Estatus_de_Solicitud), "Estatus_de_Solicitud") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Estatus_de_Solicitud_Estatus_de_Solicitud.Descripcion
                    ,Motivo = Solicitud_de_Denuncia_CiudadanaData.Motivo
                    ,Canalizar_a = Solicitud_de_Denuncia_CiudadanaData.Canalizar_a
                    ,Canalizar_aDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Canalizar_a), "PC_CanalizarA") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Canalizar_a_PC_CanalizarA.Descripcion
                    ,Fecha_de_Revision = (Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Revision = Solicitud_de_Denuncia_CiudadanaData.Hora_de_Revision
                    ,Usuario_que_Revisa = Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Revisa
                    ,Usuario_que_RevisaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Revisa), "Spartan_User") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Revisa_Spartan_User.Name
                    ,Tipo_de_Resolucion = Solicitud_de_Denuncia_CiudadanaData.Tipo_de_Resolucion
                    ,Tipo_de_ResolucionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Tipo_de_Resolucion), "Tipo_Resolucion_Portal_Ciudadano") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Tipo_de_Resolucion_Tipo_Resolucion_Portal_Ciudadano.Descripcion
                    ,Region = Solicitud_de_Denuncia_CiudadanaData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Region), "Region") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Region_Region.Descripcion
                    ,Unidad_canaliza = Solicitud_de_Denuncia_CiudadanaData.Unidad_canaliza
                    ,Unidad_canalizaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Unidad_canaliza), "Unidad") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Unidad_canaliza_Unidad.Descripcion
                    ,Contestacion = Solicitud_de_Denuncia_CiudadanaData.Contestacion
                    ,Observaciones_resolucion = Solicitud_de_Denuncia_CiudadanaData.Observaciones_resolucion
                    ,Fecha_de_Asignacion = (Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Asignacion = Solicitud_de_Denuncia_CiudadanaData.Hora_de_Asignacion
                    ,Usuario_que_Asigna = Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Asigna
                    ,Usuario_que_AsignaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Asigna), "Spartan_User") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Asigna_Spartan_User.Name
                    ,Responsable_Asignado = Solicitud_de_Denuncia_CiudadanaData.Responsable_Asignado
                    ,Responsable_AsignadoName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Responsable_Asignado), "Spartan_User") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Responsable_Asignado_Spartan_User.Name
                    ,Observaciones_responsable = Solicitud_de_Denuncia_CiudadanaData.Observaciones_responsable
                    ,Fecha_de_Atencion = (Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Atencion == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Denuncia_CiudadanaData.Fecha_de_Atencion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Atencion = Solicitud_de_Denuncia_CiudadanaData.Hora_de_Atencion
                    ,Usuario_que_Atiende = Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Atiende
                    ,Usuario_que_AtiendeName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Atiende), "Spartan_User") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Usuario_que_Atiende_Spartan_User.Name
                    ,Atencion_Realizada = Solicitud_de_Denuncia_CiudadanaData.Atencion_Realizada
                    ,Atencion_RealizadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Denuncia_CiudadanaData.Atencion_Realizada), "Contestacion_de_Portal_Ciudadano") ??  (string)Solicitud_de_Denuncia_CiudadanaData.Atencion_Realizada_Contestacion_de_Portal_Ciudadano.Descripcion
                    ,Observaciones_atencion = Solicitud_de_Denuncia_CiudadanaData.Observaciones_atencion

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
            _IEstatus_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Solicituds_Estatus_de_Solicitud = _IEstatus_de_SolicitudApiConsumer.SelAll(true);
            if (Estatus_de_Solicituds_Estatus_de_Solicitud != null && Estatus_de_Solicituds_Estatus_de_Solicitud.Resource != null)
                ViewBag.Estatus_de_Solicituds_Estatus_de_Solicitud = Estatus_de_Solicituds_Estatus_de_Solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPC_CanalizarAApiConsumer.SetAuthHeader(_tokenManager.Token);
            var PC_CanalizarAs_Canalizar_a = _IPC_CanalizarAApiConsumer.SelAll(true);
            if (PC_CanalizarAs_Canalizar_a != null && PC_CanalizarAs_Canalizar_a.Resource != null)
                ViewBag.PC_CanalizarAs_Canalizar_a = PC_CanalizarAs_Canalizar_a.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "PC_CanalizarA", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_Resolucion_Portal_CiudadanoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion = _ITipo_Resolucion_Portal_CiudadanoApiConsumer.SelAll(true);
            if (Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion != null && Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion.Resource != null)
                ViewBag.Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion = Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Resolucion_Portal_Ciudadano", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad_canaliza = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad_canaliza != null && Unidads_Unidad_canaliza.Resource != null)
                ViewBag.Unidads_Unidad_canaliza = Unidads_Unidad_canaliza.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IContestacion_de_Portal_CiudadanoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Contestacion_de_Portal_Ciudadanos_Atencion_Realizada = _IContestacion_de_Portal_CiudadanoApiConsumer.SelAll(true);
            if (Contestacion_de_Portal_Ciudadanos_Atencion_Realizada != null && Contestacion_de_Portal_Ciudadanos_Atencion_Realizada.Resource != null)
                ViewBag.Contestacion_de_Portal_Ciudadanos_Atencion_Realizada = Contestacion_de_Portal_Ciudadanos_Atencion_Realizada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Contestacion_de_Portal_Ciudadano", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddSolicitud_de_Denuncia_Ciudadana", varSolicitud_de_Denuncia_Ciudadana);
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
        public ActionResult GetEstatus_de_SolicitudAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_SolicitudApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Solicitud", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetPC_CanalizarAAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPC_CanalizarAApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPC_CanalizarAApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "PC_CanalizarA", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_Resolucion_Portal_CiudadanoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_Resolucion_Portal_CiudadanoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_Resolucion_Portal_CiudadanoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Resolucion_Portal_Ciudadano", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetRegionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetUnidadAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IUnidadApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetContestacion_de_Portal_CiudadanoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IContestacion_de_Portal_CiudadanoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IContestacion_de_Portal_CiudadanoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Contestacion_de_Portal_Ciudadano", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Solicitud_de_Denuncia_CiudadanaAdvanceSearchModel model, int idFilter = -1)
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
            _IEstatus_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Solicituds_Estatus_de_Solicitud = _IEstatus_de_SolicitudApiConsumer.SelAll(true);
            if (Estatus_de_Solicituds_Estatus_de_Solicitud != null && Estatus_de_Solicituds_Estatus_de_Solicitud.Resource != null)
                ViewBag.Estatus_de_Solicituds_Estatus_de_Solicitud = Estatus_de_Solicituds_Estatus_de_Solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPC_CanalizarAApiConsumer.SetAuthHeader(_tokenManager.Token);
            var PC_CanalizarAs_Canalizar_a = _IPC_CanalizarAApiConsumer.SelAll(true);
            if (PC_CanalizarAs_Canalizar_a != null && PC_CanalizarAs_Canalizar_a.Resource != null)
                ViewBag.PC_CanalizarAs_Canalizar_a = PC_CanalizarAs_Canalizar_a.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "PC_CanalizarA", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_Resolucion_Portal_CiudadanoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion = _ITipo_Resolucion_Portal_CiudadanoApiConsumer.SelAll(true);
            if (Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion != null && Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion.Resource != null)
                ViewBag.Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion = Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Resolucion_Portal_Ciudadano", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad_canaliza = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad_canaliza != null && Unidads_Unidad_canaliza.Resource != null)
                ViewBag.Unidads_Unidad_canaliza = Unidads_Unidad_canaliza.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IContestacion_de_Portal_CiudadanoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Contestacion_de_Portal_Ciudadanos_Atencion_Realizada = _IContestacion_de_Portal_CiudadanoApiConsumer.SelAll(true);
            if (Contestacion_de_Portal_Ciudadanos_Atencion_Realizada != null && Contestacion_de_Portal_Ciudadanos_Atencion_Realizada.Resource != null)
                ViewBag.Contestacion_de_Portal_Ciudadanos_Atencion_Realizada = Contestacion_de_Portal_Ciudadanos_Atencion_Realizada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Contestacion_de_Portal_Ciudadano", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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
            _IEstatus_de_SolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Solicituds_Estatus_de_Solicitud = _IEstatus_de_SolicitudApiConsumer.SelAll(true);
            if (Estatus_de_Solicituds_Estatus_de_Solicitud != null && Estatus_de_Solicituds_Estatus_de_Solicitud.Resource != null)
                ViewBag.Estatus_de_Solicituds_Estatus_de_Solicitud = Estatus_de_Solicituds_Estatus_de_Solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Solicitud", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IPC_CanalizarAApiConsumer.SetAuthHeader(_tokenManager.Token);
            var PC_CanalizarAs_Canalizar_a = _IPC_CanalizarAApiConsumer.SelAll(true);
            if (PC_CanalizarAs_Canalizar_a != null && PC_CanalizarAs_Canalizar_a.Resource != null)
                ViewBag.PC_CanalizarAs_Canalizar_a = PC_CanalizarAs_Canalizar_a.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "PC_CanalizarA", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_Resolucion_Portal_CiudadanoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion = _ITipo_Resolucion_Portal_CiudadanoApiConsumer.SelAll(true);
            if (Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion != null && Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion.Resource != null)
                ViewBag.Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion = Tipo_Resolucion_Portal_Ciudadanos_Tipo_de_Resolucion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_Resolucion_Portal_Ciudadano", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Unidads_Unidad_canaliza = _IUnidadApiConsumer.SelAll(true);
            if (Unidads_Unidad_canaliza != null && Unidads_Unidad_canaliza.Resource != null)
                ViewBag.Unidads_Unidad_canaliza = Unidads_Unidad_canaliza.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Unidad", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IContestacion_de_Portal_CiudadanoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Contestacion_de_Portal_Ciudadanos_Atencion_Realizada = _IContestacion_de_Portal_CiudadanoApiConsumer.SelAll(true);
            if (Contestacion_de_Portal_Ciudadanos_Atencion_Realizada != null && Contestacion_de_Portal_Ciudadanos_Atencion_Realizada.Resource != null)
                ViewBag.Contestacion_de_Portal_Ciudadanos_Atencion_Realizada = Contestacion_de_Portal_Ciudadanos_Atencion_Realizada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Contestacion_de_Portal_Ciudadano", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Solicitud_de_Denuncia_CiudadanaAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Solicitud_de_Denuncia_CiudadanaAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Solicitud_de_Denuncia_CiudadanaAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Solicitud_de_Denuncia_CiudadanaPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Denuncia_Ciudadanas == null)
                result.Solicitud_de_Denuncia_Ciudadanas = new List<Solicitud_de_Denuncia_Ciudadana>();

            return Json(new
            {
                data = result.Solicitud_de_Denuncia_Ciudadanas.Select(m => new Solicitud_de_Denuncia_CiudadanaGridModel
                    {
                    Clave = m.Clave
			,Folio = m.Folio
			,Contrasena = m.Contrasena
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Estatus_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Solicitud_Estatus_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Solicitud_Estatus_de_Solicitud.Descripcion
			,Motivo = m.Motivo
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_PC_CanalizarA.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_PC_CanalizarA.Descripcion
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,Tipo_de_ResolucionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Resolucion_Tipo_Resolucion_Portal_Ciudadano.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Resolucion_Tipo_Resolucion_Portal_Ciudadano.Descripcion
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,Unidad_canalizaDescripcion = CultureHelper.GetTraduction(m.Unidad_canaliza_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_canaliza_Unidad.Descripcion
			,Contestacion = m.Contestacion
			,Observaciones_resolucion = m.Observaciones_resolucion
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Usuario_que_AsignaName = CultureHelper.GetTraduction(m.Usuario_que_Asigna_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Asigna_Spartan_User.Name
                        ,Responsable_AsignadoName = CultureHelper.GetTraduction(m.Responsable_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_Asignado_Spartan_User.Name
			,Observaciones_responsable = m.Observaciones_responsable
                        ,Fecha_de_Atencion = (m.Fecha_de_Atencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion = m.Hora_de_Atencion
                        ,Usuario_que_AtiendeName = CultureHelper.GetTraduction(m.Usuario_que_Atiende_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Atiende_Spartan_User.Name
                        ,Atencion_RealizadaDescripcion = CultureHelper.GetTraduction(m.Atencion_Realizada_Contestacion_de_Portal_Ciudadano.Clave.ToString(), "Descripcion") ?? (string)m.Atencion_Realizada_Contestacion_de_Portal_Ciudadano.Descripcion
			,Observaciones_atencion = m.Observaciones_atencion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetSolicitud_de_Denuncia_CiudadanaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Solicitud_de_Denuncia_Ciudadana", m.),
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
        /// Get List of Solicitud_de_Denuncia_Ciudadana from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Solicitud_de_Denuncia_Ciudadana Entity</returns>
        public ActionResult GetSolicitud_de_Denuncia_CiudadanaList(UrlParametersModel param)
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
            _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Solicitud_de_Denuncia_CiudadanaPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Solicitud_de_Denuncia_CiudadanaAdvanceSearchModel))
                {
					var advanceFilter =
                    (Solicitud_de_Denuncia_CiudadanaAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Solicitud_de_Denuncia_CiudadanaPropertyMapper oSolicitud_de_Denuncia_CiudadanaPropertyMapper = new Solicitud_de_Denuncia_CiudadanaPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oSolicitud_de_Denuncia_CiudadanaPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Denuncia_Ciudadanas == null)
                result.Solicitud_de_Denuncia_Ciudadanas = new List<Solicitud_de_Denuncia_Ciudadana>();

            return Json(new
            {
                aaData = result.Solicitud_de_Denuncia_Ciudadanas.Select(m => new Solicitud_de_Denuncia_CiudadanaGridModel
            {
                    Clave = m.Clave
			,Folio = m.Folio
			,Contrasena = m.Contrasena
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Estatus_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Solicitud_Estatus_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Solicitud_Estatus_de_Solicitud.Descripcion
			,Motivo = m.Motivo
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_PC_CanalizarA.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_PC_CanalizarA.Descripcion
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,Tipo_de_ResolucionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Resolucion_Tipo_Resolucion_Portal_Ciudadano.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Resolucion_Tipo_Resolucion_Portal_Ciudadano.Descripcion
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,Unidad_canalizaDescripcion = CultureHelper.GetTraduction(m.Unidad_canaliza_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_canaliza_Unidad.Descripcion
			,Contestacion = m.Contestacion
			,Observaciones_resolucion = m.Observaciones_resolucion
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Usuario_que_AsignaName = CultureHelper.GetTraduction(m.Usuario_que_Asigna_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Asigna_Spartan_User.Name
                        ,Responsable_AsignadoName = CultureHelper.GetTraduction(m.Responsable_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_Asignado_Spartan_User.Name
			,Observaciones_responsable = m.Observaciones_responsable
                        ,Fecha_de_Atencion = (m.Fecha_de_Atencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion = m.Hora_de_Atencion
                        ,Usuario_que_AtiendeName = CultureHelper.GetTraduction(m.Usuario_que_Atiende_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Atiende_Spartan_User.Name
                        ,Atencion_RealizadaDescripcion = CultureHelper.GetTraduction(m.Atencion_Realizada_Contestacion_de_Portal_Ciudadano.Clave.ToString(), "Descripcion") ?? (string)m.Atencion_Realizada_Contestacion_de_Portal_Ciudadano.Descripcion
			,Observaciones_atencion = m.Observaciones_atencion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetSolicitud_de_Denuncia_Ciudadana_Usuario_que_Registra_Spartan_User(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Spartan_User.Id_User as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Spartan_User.Name as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISpartan_UserApiConsumer.ListaSelAll(1, 20,elWhere , " Spartan_User.Name ASC ").Resource;
               
                foreach (var item in result.Spartan_Users)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                    item.Name =trans ??item.Name;
                }
                return Json(result.Spartan_Users.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetSolicitud_de_Denuncia_Ciudadana_Usuario_que_Revisa_Spartan_User(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Spartan_User.Id_User as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Spartan_User.Name as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISpartan_UserApiConsumer.ListaSelAll(1, 20,elWhere , " Spartan_User.Name ASC ").Resource;
               
                foreach (var item in result.Spartan_Users)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                    item.Name =trans ??item.Name;
                }
                return Json(result.Spartan_Users.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetSolicitud_de_Denuncia_Ciudadana_Usuario_que_Asigna_Spartan_User(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Spartan_User.Id_User as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Spartan_User.Name as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISpartan_UserApiConsumer.ListaSelAll(1, 20,elWhere , " Spartan_User.Name ASC ").Resource;
               
                foreach (var item in result.Spartan_Users)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                    item.Name =trans ??item.Name;
                }
                return Json(result.Spartan_Users.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetSolicitud_de_Denuncia_Ciudadana_Responsable_Asignado_Spartan_User(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Spartan_User.Id_User as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Spartan_User.Name as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISpartan_UserApiConsumer.ListaSelAll(1, 20,elWhere , " Spartan_User.Name ASC ").Resource;
               
                foreach (var item in result.Spartan_Users)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                    item.Name =trans ??item.Name;
                }
                return Json(result.Spartan_Users.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetSolicitud_de_Denuncia_Ciudadana_Usuario_que_Atiende_Spartan_User(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Spartan_User.Id_User as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Spartan_User.Name as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISpartan_UserApiConsumer.ListaSelAll(1, 20,elWhere , " Spartan_User.Name ASC ").Resource;
               
                foreach (var item in result.Spartan_Users)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Id_User), "Spartan_User", "Name");
                    item.Name =trans ??item.Name;
                }
                return Json(result.Spartan_Users.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public string GetAdvanceFilter(Solicitud_de_Denuncia_CiudadanaAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Solicitud_de_Denuncia_Ciudadana.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Solicitud_de_Denuncia_Ciudadana.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.Folio))
            {
                switch (filter.FolioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '" + filter.Folio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '%" + filter.Folio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio = '" + filter.Folio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Folio LIKE '%" + filter.Folio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Contrasena))
            {
                switch (filter.ContrasenaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Contrasena LIKE '" + filter.Contrasena + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Contrasena LIKE '%" + filter.Contrasena + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Contrasena = '" + filter.Contrasena + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Contrasena LIKE '%" + filter.Contrasena + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Solicitud_de_Denuncia_Ciudadana.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Solicitud_de_Denuncia_Ciudadana.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Solicitud_de_Denuncia_Ciudadana.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Solicitud_de_Denuncia_Ciudadana.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Registra))
            {
                switch (filter.Usuario_que_RegistraFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Registra + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Registra + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Registra + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Registra + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_RegistraMultiple != null && filter.AdvanceUsuario_que_RegistraMultiple.Count() > 0)
            {
                var Usuario_que_RegistraIds = string.Join(",", filter.AdvanceUsuario_que_RegistraMultiple);

                where += " AND Solicitud_de_Denuncia_Ciudadana.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
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

                where += " AND Solicitud_de_Denuncia_Ciudadana.Tipo_de_Solicitud In (" + Tipo_de_SolicitudIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus_de_Solicitud))
            {
                switch (filter.Estatus_de_SolicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_de_Solicitud.Descripcion LIKE '" + filter.AdvanceEstatus_de_Solicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_de_Solicitud.Descripcion LIKE '%" + filter.AdvanceEstatus_de_Solicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_de_Solicitud.Descripcion = '" + filter.AdvanceEstatus_de_Solicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_de_Solicitud.Descripcion LIKE '%" + filter.AdvanceEstatus_de_Solicitud + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatus_de_SolicitudMultiple != null && filter.AdvanceEstatus_de_SolicitudMultiple.Count() > 0)
            {
                var Estatus_de_SolicitudIds = string.Join(",", filter.AdvanceEstatus_de_SolicitudMultiple);

                where += " AND Solicitud_de_Denuncia_Ciudadana.Estatus_de_Solicitud In (" + Estatus_de_SolicitudIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Motivo))
            {
                switch (filter.MotivoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Motivo LIKE '" + filter.Motivo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Motivo LIKE '%" + filter.Motivo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Motivo = '" + filter.Motivo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Motivo LIKE '%" + filter.Motivo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCanalizar_a))
            {
                switch (filter.Canalizar_aFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND PC_CanalizarA.Descripcion LIKE '" + filter.AdvanceCanalizar_a + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND PC_CanalizarA.Descripcion LIKE '%" + filter.AdvanceCanalizar_a + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND PC_CanalizarA.Descripcion = '" + filter.AdvanceCanalizar_a + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND PC_CanalizarA.Descripcion LIKE '%" + filter.AdvanceCanalizar_a + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCanalizar_aMultiple != null && filter.AdvanceCanalizar_aMultiple.Count() > 0)
            {
                var Canalizar_aIds = string.Join(",", filter.AdvanceCanalizar_aMultiple);

                where += " AND Solicitud_de_Denuncia_Ciudadana.Canalizar_a In (" + Canalizar_aIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Revision) || !string.IsNullOrEmpty(filter.ToFecha_de_Revision))
            {
                var Fecha_de_RevisionFrom = DateTime.ParseExact(filter.FromFecha_de_Revision, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RevisionTo = DateTime.ParseExact(filter.ToFecha_de_Revision, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Revision))
                    where += " AND Solicitud_de_Denuncia_Ciudadana.Fecha_de_Revision >= '" + Fecha_de_RevisionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Revision))
                    where += " AND Solicitud_de_Denuncia_Ciudadana.Fecha_de_Revision <= '" + Fecha_de_RevisionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Revision) || !string.IsNullOrEmpty(filter.ToHora_de_Revision))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Revision))
                    where += " AND Convert(TIME,Solicitud_de_Denuncia_Ciudadana.Hora_de_Revision) >='" + filter.FromHora_de_Revision + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Revision))
                    where += " AND Convert(TIME,Solicitud_de_Denuncia_Ciudadana.Hora_de_Revision) <='" + filter.ToHora_de_Revision + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Revisa))
            {
                switch (filter.Usuario_que_RevisaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Revisa + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Revisa + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Revisa + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Revisa + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_RevisaMultiple != null && filter.AdvanceUsuario_que_RevisaMultiple.Count() > 0)
            {
                var Usuario_que_RevisaIds = string.Join(",", filter.AdvanceUsuario_que_RevisaMultiple);

                where += " AND Solicitud_de_Denuncia_Ciudadana.Usuario_que_Revisa In (" + Usuario_que_RevisaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Resolucion))
            {
                switch (filter.Tipo_de_ResolucionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_Resolucion_Portal_Ciudadano.Descripcion LIKE '" + filter.AdvanceTipo_de_Resolucion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_Resolucion_Portal_Ciudadano.Descripcion LIKE '%" + filter.AdvanceTipo_de_Resolucion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_Resolucion_Portal_Ciudadano.Descripcion = '" + filter.AdvanceTipo_de_Resolucion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_Resolucion_Portal_Ciudadano.Descripcion LIKE '%" + filter.AdvanceTipo_de_Resolucion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_ResolucionMultiple != null && filter.AdvanceTipo_de_ResolucionMultiple.Count() > 0)
            {
                var Tipo_de_ResolucionIds = string.Join(",", filter.AdvanceTipo_de_ResolucionMultiple);

                where += " AND Solicitud_de_Denuncia_Ciudadana.Tipo_de_Resolucion In (" + Tipo_de_ResolucionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRegion))
            {
                switch (filter.RegionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Region.Descripcion LIKE '" + filter.AdvanceRegion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Region.Descripcion LIKE '%" + filter.AdvanceRegion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Region.Descripcion = '" + filter.AdvanceRegion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Region.Descripcion LIKE '%" + filter.AdvanceRegion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRegionMultiple != null && filter.AdvanceRegionMultiple.Count() > 0)
            {
                var RegionIds = string.Join(",", filter.AdvanceRegionMultiple);

                where += " AND Solicitud_de_Denuncia_Ciudadana.Region In (" + RegionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUnidad_canaliza))
            {
                switch (filter.Unidad_canalizaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Unidad.Descripcion LIKE '" + filter.AdvanceUnidad_canaliza + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.AdvanceUnidad_canaliza + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Unidad.Descripcion = '" + filter.AdvanceUnidad_canaliza + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.AdvanceUnidad_canaliza + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUnidad_canalizaMultiple != null && filter.AdvanceUnidad_canalizaMultiple.Count() > 0)
            {
                var Unidad_canalizaIds = string.Join(",", filter.AdvanceUnidad_canalizaMultiple);

                where += " AND Solicitud_de_Denuncia_Ciudadana.Unidad_canaliza In (" + Unidad_canalizaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Contestacion))
            {
                switch (filter.ContestacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Contestacion LIKE '" + filter.Contestacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Contestacion LIKE '%" + filter.Contestacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Contestacion = '" + filter.Contestacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Contestacion LIKE '%" + filter.Contestacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_resolucion))
            {
                switch (filter.Observaciones_resolucionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Observaciones_resolucion LIKE '" + filter.Observaciones_resolucion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Observaciones_resolucion LIKE '%" + filter.Observaciones_resolucion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Observaciones_resolucion = '" + filter.Observaciones_resolucion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Observaciones_resolucion LIKE '%" + filter.Observaciones_resolucion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Asignacion) || !string.IsNullOrEmpty(filter.ToFecha_de_Asignacion))
            {
                var Fecha_de_AsignacionFrom = DateTime.ParseExact(filter.FromFecha_de_Asignacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_AsignacionTo = DateTime.ParseExact(filter.ToFecha_de_Asignacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Asignacion))
                    where += " AND Solicitud_de_Denuncia_Ciudadana.Fecha_de_Asignacion >= '" + Fecha_de_AsignacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Asignacion))
                    where += " AND Solicitud_de_Denuncia_Ciudadana.Fecha_de_Asignacion <= '" + Fecha_de_AsignacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Asignacion) || !string.IsNullOrEmpty(filter.ToHora_de_Asignacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Asignacion))
                    where += " AND Convert(TIME,Solicitud_de_Denuncia_Ciudadana.Hora_de_Asignacion) >='" + filter.FromHora_de_Asignacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Asignacion))
                    where += " AND Convert(TIME,Solicitud_de_Denuncia_Ciudadana.Hora_de_Asignacion) <='" + filter.ToHora_de_Asignacion + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Asigna))
            {
                switch (filter.Usuario_que_AsignaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Asigna + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Asigna + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Asigna + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Asigna + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_AsignaMultiple != null && filter.AdvanceUsuario_que_AsignaMultiple.Count() > 0)
            {
                var Usuario_que_AsignaIds = string.Join(",", filter.AdvanceUsuario_que_AsignaMultiple);

                where += " AND Solicitud_de_Denuncia_Ciudadana.Usuario_que_Asigna In (" + Usuario_que_AsignaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResponsable_Asignado))
            {
                switch (filter.Responsable_AsignadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceResponsable_Asignado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceResponsable_Asignado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceResponsable_Asignado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceResponsable_Asignado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResponsable_AsignadoMultiple != null && filter.AdvanceResponsable_AsignadoMultiple.Count() > 0)
            {
                var Responsable_AsignadoIds = string.Join(",", filter.AdvanceResponsable_AsignadoMultiple);

                where += " AND Solicitud_de_Denuncia_Ciudadana.Responsable_Asignado In (" + Responsable_AsignadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_responsable))
            {
                switch (filter.Observaciones_responsableFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Observaciones_responsable LIKE '" + filter.Observaciones_responsable + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Observaciones_responsable LIKE '%" + filter.Observaciones_responsable + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Observaciones_responsable = '" + filter.Observaciones_responsable + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Observaciones_responsable LIKE '%" + filter.Observaciones_responsable + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Atencion) || !string.IsNullOrEmpty(filter.ToFecha_de_Atencion))
            {
                var Fecha_de_AtencionFrom = DateTime.ParseExact(filter.FromFecha_de_Atencion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_AtencionTo = DateTime.ParseExact(filter.ToFecha_de_Atencion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Atencion))
                    where += " AND Solicitud_de_Denuncia_Ciudadana.Fecha_de_Atencion >= '" + Fecha_de_AtencionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Atencion))
                    where += " AND Solicitud_de_Denuncia_Ciudadana.Fecha_de_Atencion <= '" + Fecha_de_AtencionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Atencion) || !string.IsNullOrEmpty(filter.ToHora_de_Atencion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Atencion))
                    where += " AND Convert(TIME,Solicitud_de_Denuncia_Ciudadana.Hora_de_Atencion) >='" + filter.FromHora_de_Atencion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Atencion))
                    where += " AND Convert(TIME,Solicitud_de_Denuncia_Ciudadana.Hora_de_Atencion) <='" + filter.ToHora_de_Atencion + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Atiende))
            {
                switch (filter.Usuario_que_AtiendeFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Atiende + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Atiende + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Atiende + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Atiende + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_AtiendeMultiple != null && filter.AdvanceUsuario_que_AtiendeMultiple.Count() > 0)
            {
                var Usuario_que_AtiendeIds = string.Join(",", filter.AdvanceUsuario_que_AtiendeMultiple);

                where += " AND Solicitud_de_Denuncia_Ciudadana.Usuario_que_Atiende In (" + Usuario_que_AtiendeIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAtencion_Realizada))
            {
                switch (filter.Atencion_RealizadaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Contestacion_de_Portal_Ciudadano.Descripcion LIKE '" + filter.AdvanceAtencion_Realizada + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Contestacion_de_Portal_Ciudadano.Descripcion LIKE '%" + filter.AdvanceAtencion_Realizada + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Contestacion_de_Portal_Ciudadano.Descripcion = '" + filter.AdvanceAtencion_Realizada + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Contestacion_de_Portal_Ciudadano.Descripcion LIKE '%" + filter.AdvanceAtencion_Realizada + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAtencion_RealizadaMultiple != null && filter.AdvanceAtencion_RealizadaMultiple.Count() > 0)
            {
                var Atencion_RealizadaIds = string.Join(",", filter.AdvanceAtencion_RealizadaMultiple);

                where += " AND Solicitud_de_Denuncia_Ciudadana.Atencion_Realizada In (" + Atencion_RealizadaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_atencion))
            {
                switch (filter.Observaciones_atencionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Observaciones_atencion LIKE '" + filter.Observaciones_atencion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Observaciones_atencion LIKE '%" + filter.Observaciones_atencion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Observaciones_atencion = '" + filter.Observaciones_atencion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Denuncia_Ciudadana.Observaciones_atencion LIKE '%" + filter.Observaciones_atencion + "%'";
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
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);

                Solicitud_de_Denuncia_Ciudadana varSolicitud_de_Denuncia_Ciudadana = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Solicitud_de_Denuncia_CiudadanaModel varSolicitud_de_Denuncia_Ciudadana)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Solicitud_de_Denuncia_CiudadanaInfo = new Solicitud_de_Denuncia_Ciudadana
                    {
                        Clave = varSolicitud_de_Denuncia_Ciudadana.Clave
                        ,Folio = varSolicitud_de_Denuncia_Ciudadana.Folio
                        ,Contrasena = varSolicitud_de_Denuncia_Ciudadana.Contrasena
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Registro)) ? DateTime.ParseExact(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varSolicitud_de_Denuncia_Ciudadana.Hora_de_Registro
                        ,Usuario_que_Registra = varSolicitud_de_Denuncia_Ciudadana.Usuario_que_Registra
                        ,Tipo_de_Solicitud = varSolicitud_de_Denuncia_Ciudadana.Tipo_de_Solicitud
                        ,Estatus_de_Solicitud = varSolicitud_de_Denuncia_Ciudadana.Estatus_de_Solicitud
                        ,Motivo = varSolicitud_de_Denuncia_Ciudadana.Motivo
                        ,Canalizar_a = varSolicitud_de_Denuncia_Ciudadana.Canalizar_a
                        ,Fecha_de_Revision = (!String.IsNullOrEmpty(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Revision)) ? DateTime.ParseExact(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Revision, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Revision = varSolicitud_de_Denuncia_Ciudadana.Hora_de_Revision
                        ,Usuario_que_Revisa = varSolicitud_de_Denuncia_Ciudadana.Usuario_que_Revisa
                        ,Tipo_de_Resolucion = varSolicitud_de_Denuncia_Ciudadana.Tipo_de_Resolucion
                        ,Region = varSolicitud_de_Denuncia_Ciudadana.Region
                        ,Unidad_canaliza = varSolicitud_de_Denuncia_Ciudadana.Unidad_canaliza
                        ,Contestacion = varSolicitud_de_Denuncia_Ciudadana.Contestacion
                        ,Observaciones_resolucion = varSolicitud_de_Denuncia_Ciudadana.Observaciones_resolucion
                        ,Fecha_de_Asignacion = (!String.IsNullOrEmpty(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Asignacion)) ? DateTime.ParseExact(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Asignacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Asignacion = varSolicitud_de_Denuncia_Ciudadana.Hora_de_Asignacion
                        ,Usuario_que_Asigna = varSolicitud_de_Denuncia_Ciudadana.Usuario_que_Asigna
                        ,Responsable_Asignado = varSolicitud_de_Denuncia_Ciudadana.Responsable_Asignado
                        ,Observaciones_responsable = varSolicitud_de_Denuncia_Ciudadana.Observaciones_responsable
                        ,Fecha_de_Atencion = (!String.IsNullOrEmpty(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Atencion)) ? DateTime.ParseExact(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Atencion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Atencion = varSolicitud_de_Denuncia_Ciudadana.Hora_de_Atencion
                        ,Usuario_que_Atiende = varSolicitud_de_Denuncia_Ciudadana.Usuario_que_Atiende
                        ,Atencion_Realizada = varSolicitud_de_Denuncia_Ciudadana.Atencion_Realizada
                        ,Observaciones_atencion = varSolicitud_de_Denuncia_Ciudadana.Observaciones_atencion

                    };

                    result = !IsNew ?
                        _ISolicitud_de_Denuncia_CiudadanaApiConsumer.Update(Solicitud_de_Denuncia_CiudadanaInfo, null, null).Resource.ToString() :
                         _ISolicitud_de_Denuncia_CiudadanaApiConsumer.Insert(Solicitud_de_Denuncia_CiudadanaInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Solicitud_de_Denuncia_Ciudadana script
        /// </summary>
        /// <param name="oSolicitud_de_Denuncia_CiudadanaElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Solicitud_de_Denuncia_CiudadanaModuleAttributeList)
        {
            for (int i = 0; i < Solicitud_de_Denuncia_CiudadanaModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Solicitud_de_Denuncia_CiudadanaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Solicitud_de_Denuncia_CiudadanaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Solicitud_de_Denuncia_CiudadanaModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Solicitud_de_Denuncia_CiudadanaModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Solicitud_de_Denuncia_CiudadanaModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Solicitud_de_Denuncia_CiudadanaModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Solicitud_de_Denuncia_CiudadanaModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Solicitud_de_Denuncia_CiudadanaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Solicitud_de_Denuncia_CiudadanaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Solicitud_de_Denuncia_CiudadanaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Solicitud_de_Denuncia_CiudadanaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strSolicitud_de_Denuncia_CiudadanaScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Denuncia_Ciudadana.js")))
            {
                strSolicitud_de_Denuncia_CiudadanaScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Solicitud_de_Denuncia_Ciudadana element attributes
            string userChangeJson = jsSerialize.Serialize(Solicitud_de_Denuncia_CiudadanaModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strSolicitud_de_Denuncia_CiudadanaScript.IndexOf("inpuElementArray");
            string splittedString = strSolicitud_de_Denuncia_CiudadanaScript.Substring(indexOfArray, strSolicitud_de_Denuncia_CiudadanaScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Solicitud_de_Denuncia_CiudadanaModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Solicitud_de_Denuncia_CiudadanaModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strSolicitud_de_Denuncia_CiudadanaScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strSolicitud_de_Denuncia_CiudadanaScript.Substring(indexOfArrayHistory, strSolicitud_de_Denuncia_CiudadanaScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strSolicitud_de_Denuncia_CiudadanaScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strSolicitud_de_Denuncia_CiudadanaScript.Substring(endIndexOfMainElement + indexOfArray, strSolicitud_de_Denuncia_CiudadanaScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Solicitud_de_Denuncia_CiudadanaModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Solicitud_de_Denuncia_CiudadanaModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Denuncia_Ciudadana.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Denuncia_Ciudadana.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Denuncia_Ciudadana.js")))
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
        public ActionResult Solicitud_de_Denuncia_CiudadanaPropertyBag()
        {
            return PartialView("Solicitud_de_Denuncia_CiudadanaPropertyBag", "Solicitud_de_Denuncia_Ciudadana");
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
                var whereClauseFormat = "Object = 45710 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Solicitud_de_Denuncia_Ciudadana.Clave= " + RecordId;
                            var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Solicitud_de_Denuncia_CiudadanaPropertyMapper());
			
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
                    (Solicitud_de_Denuncia_CiudadanaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Solicitud_de_Denuncia_CiudadanaPropertyMapper oSolicitud_de_Denuncia_CiudadanaPropertyMapper = new Solicitud_de_Denuncia_CiudadanaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oSolicitud_de_Denuncia_CiudadanaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Denuncia_Ciudadanas == null)
                result.Solicitud_de_Denuncia_Ciudadanas = new List<Solicitud_de_Denuncia_Ciudadana>();

            var data = result.Solicitud_de_Denuncia_Ciudadanas.Select(m => new Solicitud_de_Denuncia_CiudadanaGridModel
            {
                Clave = m.Clave
			,Folio = m.Folio
			,Contrasena = m.Contrasena
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Estatus_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Solicitud_Estatus_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Solicitud_Estatus_de_Solicitud.Descripcion
			,Motivo = m.Motivo
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_PC_CanalizarA.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_PC_CanalizarA.Descripcion
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,Tipo_de_ResolucionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Resolucion_Tipo_Resolucion_Portal_Ciudadano.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Resolucion_Tipo_Resolucion_Portal_Ciudadano.Descripcion
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,Unidad_canalizaDescripcion = CultureHelper.GetTraduction(m.Unidad_canaliza_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_canaliza_Unidad.Descripcion
			,Contestacion = m.Contestacion
			,Observaciones_resolucion = m.Observaciones_resolucion
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Usuario_que_AsignaName = CultureHelper.GetTraduction(m.Usuario_que_Asigna_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Asigna_Spartan_User.Name
                        ,Responsable_AsignadoName = CultureHelper.GetTraduction(m.Responsable_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_Asignado_Spartan_User.Name
			,Observaciones_responsable = m.Observaciones_responsable
                        ,Fecha_de_Atencion = (m.Fecha_de_Atencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion = m.Hora_de_Atencion
                        ,Usuario_que_AtiendeName = CultureHelper.GetTraduction(m.Usuario_que_Atiende_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Atiende_Spartan_User.Name
                        ,Atencion_RealizadaDescripcion = CultureHelper.GetTraduction(m.Atencion_Realizada_Contestacion_de_Portal_Ciudadano.Clave.ToString(), "Descripcion") ?? (string)m.Atencion_Realizada_Contestacion_de_Portal_Ciudadano.Descripcion
			,Observaciones_atencion = m.Observaciones_atencion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45710, arrayColumnsVisible), "Solicitud_de_Denuncia_CiudadanaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45710, arrayColumnsVisible), "Solicitud_de_Denuncia_CiudadanaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45710, arrayColumnsVisible), "Solicitud_de_Denuncia_CiudadanaList_" + DateTime.Now.ToString());
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

            _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Solicitud_de_Denuncia_CiudadanaPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Solicitud_de_Denuncia_CiudadanaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Solicitud_de_Denuncia_CiudadanaPropertyMapper oSolicitud_de_Denuncia_CiudadanaPropertyMapper = new Solicitud_de_Denuncia_CiudadanaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oSolicitud_de_Denuncia_CiudadanaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Denuncia_Ciudadanas == null)
                result.Solicitud_de_Denuncia_Ciudadanas = new List<Solicitud_de_Denuncia_Ciudadana>();

            var data = result.Solicitud_de_Denuncia_Ciudadanas.Select(m => new Solicitud_de_Denuncia_CiudadanaGridModel
            {
                Clave = m.Clave
			,Folio = m.Folio
			,Contrasena = m.Contrasena
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Estatus_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Solicitud_Estatus_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Solicitud_Estatus_de_Solicitud.Descripcion
			,Motivo = m.Motivo
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_PC_CanalizarA.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_PC_CanalizarA.Descripcion
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,Tipo_de_ResolucionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Resolucion_Tipo_Resolucion_Portal_Ciudadano.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Resolucion_Tipo_Resolucion_Portal_Ciudadano.Descripcion
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,Unidad_canalizaDescripcion = CultureHelper.GetTraduction(m.Unidad_canaliza_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_canaliza_Unidad.Descripcion
			,Contestacion = m.Contestacion
			,Observaciones_resolucion = m.Observaciones_resolucion
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Usuario_que_AsignaName = CultureHelper.GetTraduction(m.Usuario_que_Asigna_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Asigna_Spartan_User.Name
                        ,Responsable_AsignadoName = CultureHelper.GetTraduction(m.Responsable_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_Asignado_Spartan_User.Name
			,Observaciones_responsable = m.Observaciones_responsable
                        ,Fecha_de_Atencion = (m.Fecha_de_Atencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion = m.Hora_de_Atencion
                        ,Usuario_que_AtiendeName = CultureHelper.GetTraduction(m.Usuario_que_Atiende_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Atiende_Spartan_User.Name
                        ,Atencion_RealizadaDescripcion = CultureHelper.GetTraduction(m.Atencion_Realizada_Contestacion_de_Portal_Ciudadano.Clave.ToString(), "Descripcion") ?? (string)m.Atencion_Realizada_Contestacion_de_Portal_Ciudadano.Descripcion
			,Observaciones_atencion = m.Observaciones_atencion

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
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_de_la_Solicitud(Solicitud_de_Denuncia_Ciudadana_Datos_de_la_SolicitudModel varSolicitud_de_Denuncia_Ciudadana)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_de_Denuncia_Ciudadana_Datos_de_la_SolicitudInfo = new Solicitud_de_Denuncia_Ciudadana_Datos_de_la_Solicitud
                {
                    Clave = varSolicitud_de_Denuncia_Ciudadana.Clave
                                            ,Folio = varSolicitud_de_Denuncia_Ciudadana.Folio
                        ,Contrasena = varSolicitud_de_Denuncia_Ciudadana.Contrasena
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Registro)) ? DateTime.ParseExact(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varSolicitud_de_Denuncia_Ciudadana.Hora_de_Registro
                        ,Usuario_que_Registra = varSolicitud_de_Denuncia_Ciudadana.Usuario_que_Registra
                        ,Tipo_de_Solicitud = varSolicitud_de_Denuncia_Ciudadana.Tipo_de_Solicitud
                        ,Estatus_de_Solicitud = varSolicitud_de_Denuncia_Ciudadana.Estatus_de_Solicitud
                    
                };

                result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.Update_Datos_de_la_Solicitud(Solicitud_de_Denuncia_Ciudadana_Datos_de_la_SolicitudInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_la_Solicitud(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.Get_Datos_de_la_Solicitud(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Solicitud_de_Denuncia_Ciudadana_Datos_de_la_SolicitudModel
                {
                    Clave = m.Clave
			,Folio = m.Folio
			,Contrasena = m.Contrasena
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
                        ,Tipo_de_Solicitud = m.Tipo_de_Solicitud
                        ,Tipo_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Solicitud_Tipo_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Solicitud_Tipo_de_Solicitud.Descripcion
                        ,Estatus_de_Solicitud = m.Estatus_de_Solicitud
                        ,Estatus_de_SolicitudDescripcion = CultureHelper.GetTraduction(m.Estatus_de_Solicitud_Estatus_de_Solicitud.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_de_Solicitud_Estatus_de_Solicitud.Descripcion

                    
                };
				var resultData = new
                {
                    data = result

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Resolucion(Solicitud_de_Denuncia_Ciudadana_ResolucionModel varSolicitud_de_Denuncia_Ciudadana)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_de_Denuncia_Ciudadana_ResolucionInfo = new Solicitud_de_Denuncia_Ciudadana_Resolucion
                {
                    Clave = varSolicitud_de_Denuncia_Ciudadana.Clave
                                            ,Motivo = varSolicitud_de_Denuncia_Ciudadana.Motivo
                        ,Canalizar_a = varSolicitud_de_Denuncia_Ciudadana.Canalizar_a
                        ,Fecha_de_Revision = (!String.IsNullOrEmpty(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Revision)) ? DateTime.ParseExact(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Revision, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Revision = varSolicitud_de_Denuncia_Ciudadana.Hora_de_Revision
                        ,Usuario_que_Revisa = varSolicitud_de_Denuncia_Ciudadana.Usuario_que_Revisa
                        ,Tipo_de_Resolucion = varSolicitud_de_Denuncia_Ciudadana.Tipo_de_Resolucion
                        ,Region = varSolicitud_de_Denuncia_Ciudadana.Region
                        ,Unidad_canaliza = varSolicitud_de_Denuncia_Ciudadana.Unidad_canaliza
                        ,Contestacion = varSolicitud_de_Denuncia_Ciudadana.Contestacion
                        ,Observaciones_resolucion = varSolicitud_de_Denuncia_Ciudadana.Observaciones_resolucion
                    
                };

                result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.Update_Resolucion(Solicitud_de_Denuncia_Ciudadana_ResolucionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Resolucion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.Get_Resolucion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Solicitud_de_Denuncia_Ciudadana_ResolucionModel
                {
                    Clave = m.Clave
			,Motivo = m.Motivo
                        ,Canalizar_a = m.Canalizar_a
                        ,Canalizar_aDescripcion = CultureHelper.GetTraduction(m.Canalizar_a_PC_CanalizarA.Clave.ToString(), "Descripcion") ?? (string)m.Canalizar_a_PC_CanalizarA.Descripcion
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_Revisa = m.Usuario_que_Revisa
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,Tipo_de_Resolucion = m.Tipo_de_Resolucion
                        ,Tipo_de_ResolucionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Resolucion_Tipo_Resolucion_Portal_Ciudadano.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Resolucion_Tipo_Resolucion_Portal_Ciudadano.Descripcion
                        ,Region = m.Region
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,Unidad_canaliza = m.Unidad_canaliza
                        ,Unidad_canalizaDescripcion = CultureHelper.GetTraduction(m.Unidad_canaliza_Unidad.Clave.ToString(), "Descripcion") ?? (string)m.Unidad_canaliza_Unidad.Descripcion
			,Contestacion = m.Contestacion
			,Observaciones_resolucion = m.Observaciones_resolucion

                    
                };
				var resultData = new
                {
                    data = result

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Asignar_Responsable_de_Atencion(Solicitud_de_Denuncia_Ciudadana_Asignar_Responsable_de_AtencionModel varSolicitud_de_Denuncia_Ciudadana)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_de_Denuncia_Ciudadana_Asignar_Responsable_de_AtencionInfo = new Solicitud_de_Denuncia_Ciudadana_Asignar_Responsable_de_Atencion
                {
                    Clave = varSolicitud_de_Denuncia_Ciudadana.Clave
                                            ,Fecha_de_Asignacion = (!String.IsNullOrEmpty(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Asignacion)) ? DateTime.ParseExact(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Asignacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Asignacion = varSolicitud_de_Denuncia_Ciudadana.Hora_de_Asignacion
                        ,Usuario_que_Asigna = varSolicitud_de_Denuncia_Ciudadana.Usuario_que_Asigna
                        ,Responsable_Asignado = varSolicitud_de_Denuncia_Ciudadana.Responsable_Asignado
                        ,Observaciones_responsable = varSolicitud_de_Denuncia_Ciudadana.Observaciones_responsable
                    
                };

                result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.Update_Asignar_Responsable_de_Atencion(Solicitud_de_Denuncia_Ciudadana_Asignar_Responsable_de_AtencionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Asignar_Responsable_de_Atencion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.Get_Asignar_Responsable_de_Atencion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Solicitud_de_Denuncia_Ciudadana_Asignar_Responsable_de_AtencionModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Usuario_que_Asigna = m.Usuario_que_Asigna
                        ,Usuario_que_AsignaName = CultureHelper.GetTraduction(m.Usuario_que_Asigna_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Asigna_Spartan_User.Name
                        ,Responsable_Asignado = m.Responsable_Asignado
                        ,Responsable_AsignadoName = CultureHelper.GetTraduction(m.Responsable_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_Asignado_Spartan_User.Name
			,Observaciones_responsable = m.Observaciones_responsable

                    
                };
				var resultData = new
                {
                    data = result

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Atencion(Solicitud_de_Denuncia_Ciudadana_AtencionModel varSolicitud_de_Denuncia_Ciudadana)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_de_Denuncia_Ciudadana_AtencionInfo = new Solicitud_de_Denuncia_Ciudadana_Atencion
                {
                    Clave = varSolicitud_de_Denuncia_Ciudadana.Clave
                                            ,Fecha_de_Atencion = (!String.IsNullOrEmpty(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Atencion)) ? DateTime.ParseExact(varSolicitud_de_Denuncia_Ciudadana.Fecha_de_Atencion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Atencion = varSolicitud_de_Denuncia_Ciudadana.Hora_de_Atencion
                        ,Usuario_que_Atiende = varSolicitud_de_Denuncia_Ciudadana.Usuario_que_Atiende
                        ,Atencion_Realizada = varSolicitud_de_Denuncia_Ciudadana.Atencion_Realizada
                        ,Observaciones_atencion = varSolicitud_de_Denuncia_Ciudadana.Observaciones_atencion
                    
                };

                result = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.Update_Atencion(Solicitud_de_Denuncia_Ciudadana_AtencionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Atencion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Denuncia_CiudadanaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitud_de_Denuncia_CiudadanaApiConsumer.Get_Atencion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Solicitud_de_Denuncia_Ciudadana_AtencionModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Atencion = (m.Fecha_de_Atencion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Atencion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Atencion = m.Hora_de_Atencion
                        ,Usuario_que_Atiende = m.Usuario_que_Atiende
                        ,Usuario_que_AtiendeName = CultureHelper.GetTraduction(m.Usuario_que_Atiende_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Atiende_Spartan_User.Name
                        ,Atencion_Realizada = m.Atencion_Realizada
                        ,Atencion_RealizadaDescripcion = CultureHelper.GetTraduction(m.Atencion_Realizada_Contestacion_de_Portal_Ciudadano.Clave.ToString(), "Descripcion") ?? (string)m.Atencion_Realizada_Contestacion_de_Portal_Ciudadano.Descripcion
			,Observaciones_atencion = m.Observaciones_atencion

                    
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

