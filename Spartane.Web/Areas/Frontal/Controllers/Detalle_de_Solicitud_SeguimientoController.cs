using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Solicitud_Seguimiento;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Relaciones_MASC;
using Spartane.Core.Domain.Cumplimiento;
using Spartane.Core.Domain.Forma_de_Cumplimiento;
using Spartane.Core.Domain.A_Tiempo;
using Spartane.Core.Domain.Spartan_User;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Solicitud_Seguimiento;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Seguimiento;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Relaciones_MASC;
using Spartane.Web.Areas.WebApiConsumer.Cumplimiento;
using Spartane.Web.Areas.WebApiConsumer.Forma_de_Cumplimiento;
using Spartane.Web.Areas.WebApiConsumer.A_Tiempo;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;

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
    public class Detalle_de_Solicitud_SeguimientoController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Solicitud_SeguimientoService service = null;
        private IDetalle_de_Solicitud_SeguimientoApiConsumer _IDetalle_de_Solicitud_SeguimientoApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private IRelaciones_MASCApiConsumer _IRelaciones_MASCApiConsumer;
        private ICumplimientoApiConsumer _ICumplimientoApiConsumer;
        private IForma_de_CumplimientoApiConsumer _IForma_de_CumplimientoApiConsumer;
        private IA_TiempoApiConsumer _IA_TiempoApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;

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

        
        public Detalle_de_Solicitud_SeguimientoController(IDetalle_de_Solicitud_SeguimientoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Solicitud_SeguimientoApiConsumer Detalle_de_Solicitud_SeguimientoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , IRelaciones_MASCApiConsumer Relaciones_MASCApiConsumer , ICumplimientoApiConsumer CumplimientoApiConsumer , IForma_de_CumplimientoApiConsumer Forma_de_CumplimientoApiConsumer , IA_TiempoApiConsumer A_TiempoApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Solicitud_SeguimientoApiConsumer = Detalle_de_Solicitud_SeguimientoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._ISolicitudApiConsumer = SolicitudApiConsumer;
            this._IRelaciones_MASCApiConsumer = Relaciones_MASCApiConsumer;
            this._ICumplimientoApiConsumer = CumplimientoApiConsumer;
            this._IForma_de_CumplimientoApiConsumer = Forma_de_CumplimientoApiConsumer;
            this._IA_TiempoApiConsumer = A_TiempoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Solicitud_Seguimiento
        [ObjectAuth(ObjectId = (ModuleObjectId)45088, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45088, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_de_Solicitud_Seguimiento/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45088, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45088, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_de_Solicitud_Seguimiento = new Detalle_de_Solicitud_SeguimientoModel();
			varDetalle_de_Solicitud_Seguimiento.Clave = Id;
			
            ViewBag.ObjectId = "45088";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_de_Solicitud_SeguimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Solicitud_SeguimientosData = _IDetalle_de_Solicitud_SeguimientoApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Solicitud_Seguimiento.Clave=" + Id, "").Resource.Detalle_de_Solicitud_Seguimientos;
				
				if (Detalle_de_Solicitud_SeguimientosData != null && Detalle_de_Solicitud_SeguimientosData.Count > 0)
                {
					var Detalle_de_Solicitud_SeguimientoData = Detalle_de_Solicitud_SeguimientosData.First();
					varDetalle_de_Solicitud_Seguimiento= new Detalle_de_Solicitud_SeguimientoModel
					{
						Clave  = Detalle_de_Solicitud_SeguimientoData.Clave 
	                    ,Solicitud = Detalle_de_Solicitud_SeguimientoData.Solicitud
                    ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SeguimientoData.Solicitud), "Solicitud") ??  (string)Detalle_de_Solicitud_SeguimientoData.Solicitud_Solicitud.Numero_de_Folio
                    ,Fecha_de_Registro = (Detalle_de_Solicitud_SeguimientoData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_SeguimientoData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Detalle_de_Solicitud_SeguimientoData.Hora_de_Registro
                    ,Fecha_Requerida = (Detalle_de_Solicitud_SeguimientoData.Fecha_Requerida == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_SeguimientoData.Fecha_Requerida).ToString(ConfigurationProperty.DateFormat))
                    ,Relacion = Detalle_de_Solicitud_SeguimientoData.Relacion
                    ,RelacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SeguimientoData.Relacion), "Relaciones_MASC") ??  (string)Detalle_de_Solicitud_SeguimientoData.Relacion_Relaciones_MASC.Descripcion
                    ,Cumplimiento = Detalle_de_Solicitud_SeguimientoData.Cumplimiento
                    ,CumplimientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SeguimientoData.Cumplimiento), "Cumplimiento") ??  (string)Detalle_de_Solicitud_SeguimientoData.Cumplimiento_Cumplimiento.Descripcion
                    ,Fecha_de_Cumplimiento = (Detalle_de_Solicitud_SeguimientoData.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_SeguimientoData.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Forma_de_Pago = Detalle_de_Solicitud_SeguimientoData.Forma_de_Pago
                    ,Forma_de_PagoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SeguimientoData.Forma_de_Pago), "Forma_de_Cumplimiento") ??  (string)Detalle_de_Solicitud_SeguimientoData.Forma_de_Pago_Forma_de_Cumplimiento.Descripcion
                    ,Cantidad_del_Monto = Detalle_de_Solicitud_SeguimientoData.Cantidad_del_Monto
                    ,Descripcion_de_Cumplimiento = Detalle_de_Solicitud_SeguimientoData.Descripcion_de_Cumplimiento
                    ,Concluir_Acuerdo = Detalle_de_Solicitud_SeguimientoData.Concluir_Acuerdo
                    ,Concluir_AcuerdoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SeguimientoData.Concluir_Acuerdo), "A_Tiempo") ??  (string)Detalle_de_Solicitud_SeguimientoData.Concluir_Acuerdo_A_Tiempo.Descripcion
                    ,Especialista = Detalle_de_Solicitud_SeguimientoData.Especialista
                    ,EspecialistaName = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SeguimientoData.Especialista), "Spartan_User") ??  (string)Detalle_de_Solicitud_SeguimientoData.Especialista_Spartan_User.Name
                    ,Comentarios = Detalle_de_Solicitud_SeguimientoData.Comentarios
                    ,Archivo = Detalle_de_Solicitud_SeguimientoData.Archivo

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.ArchivoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Solicitud_Seguimiento.Archivo).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cumplimientos_Cumplimiento = _ICumplimientoApiConsumer.SelAll(true);
            if (Cumplimientos_Cumplimiento != null && Cumplimientos_Cumplimiento.Resource != null)
                ViewBag.Cumplimientos_Cumplimiento = Cumplimientos_Cumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Cumplimientos_Forma_de_Pago = _IForma_de_CumplimientoApiConsumer.SelAll(true);
            if (Forma_de_Cumplimientos_Forma_de_Pago != null && Forma_de_Cumplimientos_Forma_de_Pago.Resource != null)
                ViewBag.Forma_de_Cumplimientos_Forma_de_Pago = Forma_de_Cumplimientos_Forma_de_Pago.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Concluir_Acuerdo = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Concluir_Acuerdo != null && A_Tiempos_Concluir_Acuerdo.Resource != null)
                ViewBag.A_Tiempos_Concluir_Acuerdo = A_Tiempos_Concluir_Acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDetalle_de_Solicitud_Seguimiento);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Solicitud_Seguimiento(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45088);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Solicitud_SeguimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Solicitud_SeguimientoModel varDetalle_de_Solicitud_Seguimiento= new Detalle_de_Solicitud_SeguimientoModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_Solicitud_SeguimientosData = _IDetalle_de_Solicitud_SeguimientoApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Solicitud_Seguimiento.Clave=" + id, "").Resource.Detalle_de_Solicitud_Seguimientos;
				
				if (Detalle_de_Solicitud_SeguimientosData != null && Detalle_de_Solicitud_SeguimientosData.Count > 0)
                {
					var Detalle_de_Solicitud_SeguimientoData = Detalle_de_Solicitud_SeguimientosData.First();
					varDetalle_de_Solicitud_Seguimiento= new Detalle_de_Solicitud_SeguimientoModel
					{
						Clave  = Detalle_de_Solicitud_SeguimientoData.Clave 
	                    ,Solicitud = Detalle_de_Solicitud_SeguimientoData.Solicitud
                    ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SeguimientoData.Solicitud), "Solicitud") ??  (string)Detalle_de_Solicitud_SeguimientoData.Solicitud_Solicitud.Numero_de_Folio
                    ,Fecha_de_Registro = (Detalle_de_Solicitud_SeguimientoData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_SeguimientoData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Detalle_de_Solicitud_SeguimientoData.Hora_de_Registro
                    ,Fecha_Requerida = (Detalle_de_Solicitud_SeguimientoData.Fecha_Requerida == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_SeguimientoData.Fecha_Requerida).ToString(ConfigurationProperty.DateFormat))
                    ,Relacion = Detalle_de_Solicitud_SeguimientoData.Relacion
                    ,RelacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SeguimientoData.Relacion), "Relaciones_MASC") ??  (string)Detalle_de_Solicitud_SeguimientoData.Relacion_Relaciones_MASC.Descripcion
                    ,Cumplimiento = Detalle_de_Solicitud_SeguimientoData.Cumplimiento
                    ,CumplimientoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SeguimientoData.Cumplimiento), "Cumplimiento") ??  (string)Detalle_de_Solicitud_SeguimientoData.Cumplimiento_Cumplimiento.Descripcion
                    ,Fecha_de_Cumplimiento = (Detalle_de_Solicitud_SeguimientoData.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(Detalle_de_Solicitud_SeguimientoData.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
                    ,Forma_de_Pago = Detalle_de_Solicitud_SeguimientoData.Forma_de_Pago
                    ,Forma_de_PagoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SeguimientoData.Forma_de_Pago), "Forma_de_Cumplimiento") ??  (string)Detalle_de_Solicitud_SeguimientoData.Forma_de_Pago_Forma_de_Cumplimiento.Descripcion
                    ,Cantidad_del_Monto = Detalle_de_Solicitud_SeguimientoData.Cantidad_del_Monto
                    ,Descripcion_de_Cumplimiento = Detalle_de_Solicitud_SeguimientoData.Descripcion_de_Cumplimiento
                    ,Concluir_Acuerdo = Detalle_de_Solicitud_SeguimientoData.Concluir_Acuerdo
                    ,Concluir_AcuerdoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SeguimientoData.Concluir_Acuerdo), "A_Tiempo") ??  (string)Detalle_de_Solicitud_SeguimientoData.Concluir_Acuerdo_A_Tiempo.Descripcion
                    ,Especialista = Detalle_de_Solicitud_SeguimientoData.Especialista
                    ,EspecialistaName = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Solicitud_SeguimientoData.Especialista), "Spartan_User") ??  (string)Detalle_de_Solicitud_SeguimientoData.Especialista_Spartan_User.Name
                    ,Comentarios = Detalle_de_Solicitud_SeguimientoData.Comentarios
                    ,Archivo = Detalle_de_Solicitud_SeguimientoData.Archivo

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.ArchivoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Solicitud_Seguimiento.Archivo).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cumplimientos_Cumplimiento = _ICumplimientoApiConsumer.SelAll(true);
            if (Cumplimientos_Cumplimiento != null && Cumplimientos_Cumplimiento.Resource != null)
                ViewBag.Cumplimientos_Cumplimiento = Cumplimientos_Cumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Cumplimientos_Forma_de_Pago = _IForma_de_CumplimientoApiConsumer.SelAll(true);
            if (Forma_de_Cumplimientos_Forma_de_Pago != null && Forma_de_Cumplimientos_Forma_de_Pago.Resource != null)
                ViewBag.Forma_de_Cumplimientos_Forma_de_Pago = Forma_de_Cumplimientos_Forma_de_Pago.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Concluir_Acuerdo = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Concluir_Acuerdo != null && A_Tiempos_Concluir_Acuerdo.Resource != null)
                ViewBag.A_Tiempos_Concluir_Acuerdo = A_Tiempos_Concluir_Acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Solicitud_Seguimiento", varDetalle_de_Solicitud_Seguimiento);
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
        public ActionResult GetSolicitudAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitudApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Numero_de_Folio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitud", "Numero_de_Folio")?? m.Numero_de_Folio,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetRelaciones_MASCAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRelaciones_MASCApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Relaciones_MASC", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCumplimientoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICumplimientoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cumplimiento", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetForma_de_CumplimientoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_de_CumplimientoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Cumplimiento", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetA_TiempoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IA_TiempoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
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



        [HttpPost]
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Detalle_de_Solicitud_SeguimientoAdvanceSearchModel model, int idFilter = -1)
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

            _ICumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cumplimientos_Cumplimiento = _ICumplimientoApiConsumer.SelAll(true);
            if (Cumplimientos_Cumplimiento != null && Cumplimientos_Cumplimiento.Resource != null)
                ViewBag.Cumplimientos_Cumplimiento = Cumplimientos_Cumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Cumplimientos_Forma_de_Pago = _IForma_de_CumplimientoApiConsumer.SelAll(true);
            if (Forma_de_Cumplimientos_Forma_de_Pago != null && Forma_de_Cumplimientos_Forma_de_Pago.Resource != null)
                ViewBag.Forma_de_Cumplimientos_Forma_de_Pago = Forma_de_Cumplimientos_Forma_de_Pago.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Concluir_Acuerdo = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Concluir_Acuerdo != null && A_Tiempos_Concluir_Acuerdo.Resource != null)
                ViewBag.A_Tiempos_Concluir_Acuerdo = A_Tiempos_Concluir_Acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ICumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Cumplimientos_Cumplimiento = _ICumplimientoApiConsumer.SelAll(true);
            if (Cumplimientos_Cumplimiento != null && Cumplimientos_Cumplimiento.Resource != null)
                ViewBag.Cumplimientos_Cumplimiento = Cumplimientos_Cumplimiento.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_de_CumplimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_de_Cumplimientos_Forma_de_Pago = _IForma_de_CumplimientoApiConsumer.SelAll(true);
            if (Forma_de_Cumplimientos_Forma_de_Pago != null && Forma_de_Cumplimientos_Forma_de_Pago.Resource != null)
                ViewBag.Forma_de_Cumplimientos_Forma_de_Pago = Forma_de_Cumplimientos_Forma_de_Pago.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_de_Cumplimiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IA_TiempoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var A_Tiempos_Concluir_Acuerdo = _IA_TiempoApiConsumer.SelAll(true);
            if (A_Tiempos_Concluir_Acuerdo != null && A_Tiempos_Concluir_Acuerdo.Resource != null)
                ViewBag.A_Tiempos_Concluir_Acuerdo = A_Tiempos_Concluir_Acuerdo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "A_Tiempo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Detalle_de_Solicitud_SeguimientoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_de_Solicitud_SeguimientoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_de_Solicitud_SeguimientoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Solicitud_SeguimientoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Solicitud_SeguimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitud_Seguimientos == null)
                result.Detalle_de_Solicitud_Seguimientos = new List<Detalle_de_Solicitud_Seguimiento>();

            return Json(new
            {
                data = result.Detalle_de_Solicitud_Seguimientos.Select(m => new Detalle_de_Solicitud_SeguimientoGridModel
                    {
                    Clave = m.Clave
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Fecha_Requerida = (m.Fecha_Requerida == null ? string.Empty : Convert.ToDateTime(m.Fecha_Requerida).ToString(ConfigurationProperty.DateFormat))
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Relaciones_MASC.Clave.ToString(), "Relaciones_MASC") ?? (string)m.Relacion_Relaciones_MASC.Descripcion
                        ,CumplimientoDescripcion = CultureHelper.GetTraduction(m.Cumplimiento_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Cumplimiento_Cumplimiento.Descripcion
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
                        ,Forma_de_PagoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Pago_Forma_de_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Pago_Forma_de_Cumplimiento.Descripcion
			,Cantidad_del_Monto = m.Cantidad_del_Monto
			,Descripcion_de_Cumplimiento = m.Descripcion_de_Cumplimiento
                        ,Concluir_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Concluir_Acuerdo_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Concluir_Acuerdo_A_Tiempo.Descripcion
                        ,EspecialistaName = CultureHelper.GetTraduction(m.Especialista_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_Spartan_User.Name
			,Comentarios = m.Comentarios
			,Archivo = m.Archivo

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_de_Solicitud_SeguimientoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_SeguimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Solicitud_SeguimientoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_de_Solicitud_Seguimiento", m.),
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
        /// Get List of Detalle_de_Solicitud_Seguimiento from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_de_Solicitud_Seguimiento Entity</returns>
        public ActionResult GetDetalle_de_Solicitud_SeguimientoList(UrlParametersModel param)
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
            _IDetalle_de_Solicitud_SeguimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_de_Solicitud_SeguimientoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_de_Solicitud_SeguimientoAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_de_Solicitud_SeguimientoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_de_Solicitud_SeguimientoPropertyMapper oDetalle_de_Solicitud_SeguimientoPropertyMapper = new Detalle_de_Solicitud_SeguimientoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_de_Solicitud_SeguimientoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_de_Solicitud_SeguimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitud_Seguimientos == null)
                result.Detalle_de_Solicitud_Seguimientos = new List<Detalle_de_Solicitud_Seguimiento>();

            return Json(new
            {
                aaData = result.Detalle_de_Solicitud_Seguimientos.Select(m => new Detalle_de_Solicitud_SeguimientoGridModel
            {
                    Clave = m.Clave
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Fecha_Requerida = (m.Fecha_Requerida == null ? string.Empty : Convert.ToDateTime(m.Fecha_Requerida).ToString(ConfigurationProperty.DateFormat))
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Relaciones_MASC.Clave.ToString(), "Relaciones_MASC") ?? (string)m.Relacion_Relaciones_MASC.Descripcion
                        ,CumplimientoDescripcion = CultureHelper.GetTraduction(m.Cumplimiento_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Cumplimiento_Cumplimiento.Descripcion
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
                        ,Forma_de_PagoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Pago_Forma_de_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Pago_Forma_de_Cumplimiento.Descripcion
			,Cantidad_del_Monto = m.Cantidad_del_Monto
			,Descripcion_de_Cumplimiento = m.Descripcion_de_Cumplimiento
                        ,Concluir_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Concluir_Acuerdo_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Concluir_Acuerdo_A_Tiempo.Descripcion
                        ,EspecialistaName = CultureHelper.GetTraduction(m.Especialista_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_Spartan_User.Name
			,Comentarios = m.Comentarios
			,Archivo = m.Archivo

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Solicitud_Seguimiento_Solicitud_Solicitud(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Solicitud.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Solicitud.Numero_de_Folio as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISolicitudApiConsumer.ListaSelAll(1, 20,elWhere , " Solicitud.Numero_de_Folio ASC ").Resource;
               
                foreach (var item in result.Solicituds)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Solicitud", "Numero_de_Folio");
                    item.Numero_de_Folio =trans ??item.Numero_de_Folio;
                }
                return Json(result.Solicituds.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Solicitud_Seguimiento_Relacion_Relaciones_MASC(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRelaciones_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Relaciones_MASC.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Relaciones_MASC.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IRelaciones_MASCApiConsumer.ListaSelAll(1, 20,elWhere , " Relaciones_MASC.Descripcion ASC ").Resource;
               
                foreach (var item in result.Relaciones_MASCs)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Relaciones_MASC", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Relaciones_MASCs.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Solicitud_Seguimiento_Especialista_Spartan_User(string query, string where)
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
        public string GetAdvanceFilter(Detalle_de_Solicitud_SeguimientoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_de_Solicitud_Seguimiento.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_de_Solicitud_Seguimiento.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSolicitud))
            {
                switch (filter.SolicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '" + filter.AdvanceSolicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Numero_de_Folio = '" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceSolicitud + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSolicitudMultiple != null && filter.AdvanceSolicitudMultiple.Count() > 0)
            {
                var SolicitudIds = string.Join(",", filter.AdvanceSolicitudMultiple);

                where += " AND Detalle_de_Solicitud_Seguimiento.Solicitud In (" + SolicitudIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Detalle_de_Solicitud_Seguimiento.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Detalle_de_Solicitud_Seguimiento.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Detalle_de_Solicitud_Seguimiento.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Detalle_de_Solicitud_Seguimiento.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_Requerida) || !string.IsNullOrEmpty(filter.ToFecha_Requerida))
            {
                var Fecha_RequeridaFrom = DateTime.ParseExact(filter.FromFecha_Requerida, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_RequeridaTo = DateTime.ParseExact(filter.ToFecha_Requerida, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_Requerida))
                    where += " AND Detalle_de_Solicitud_Seguimiento.Fecha_Requerida >= '" + Fecha_RequeridaFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_Requerida))
                    where += " AND Detalle_de_Solicitud_Seguimiento.Fecha_Requerida <= '" + Fecha_RequeridaTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRelacion))
            {
                switch (filter.RelacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Relaciones_MASC.Descripcion LIKE '" + filter.AdvanceRelacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Relaciones_MASC.Descripcion LIKE '%" + filter.AdvanceRelacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Relaciones_MASC.Descripcion = '" + filter.AdvanceRelacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Relaciones_MASC.Descripcion LIKE '%" + filter.AdvanceRelacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRelacionMultiple != null && filter.AdvanceRelacionMultiple.Count() > 0)
            {
                var RelacionIds = string.Join(",", filter.AdvanceRelacionMultiple);

                where += " AND Detalle_de_Solicitud_Seguimiento.Relacion In (" + RelacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCumplimiento))
            {
                switch (filter.CumplimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Cumplimiento.Descripcion LIKE '" + filter.AdvanceCumplimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Cumplimiento.Descripcion LIKE '%" + filter.AdvanceCumplimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Cumplimiento.Descripcion = '" + filter.AdvanceCumplimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Cumplimiento.Descripcion LIKE '%" + filter.AdvanceCumplimiento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCumplimientoMultiple != null && filter.AdvanceCumplimientoMultiple.Count() > 0)
            {
                var CumplimientoIds = string.Join(",", filter.AdvanceCumplimientoMultiple);

                where += " AND Detalle_de_Solicitud_Seguimiento.Cumplimiento In (" + CumplimientoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Cumplimiento) || !string.IsNullOrEmpty(filter.ToFecha_de_Cumplimiento))
            {
                var Fecha_de_CumplimientoFrom = DateTime.ParseExact(filter.FromFecha_de_Cumplimiento, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_CumplimientoTo = DateTime.ParseExact(filter.ToFecha_de_Cumplimiento, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Cumplimiento))
                    where += " AND Detalle_de_Solicitud_Seguimiento.Fecha_de_Cumplimiento >= '" + Fecha_de_CumplimientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Cumplimiento))
                    where += " AND Detalle_de_Solicitud_Seguimiento.Fecha_de_Cumplimiento <= '" + Fecha_de_CumplimientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_de_Pago))
            {
                switch (filter.Forma_de_PagoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_de_Cumplimiento.Descripcion LIKE '" + filter.AdvanceForma_de_Pago + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_de_Cumplimiento.Descripcion LIKE '%" + filter.AdvanceForma_de_Pago + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_de_Cumplimiento.Descripcion = '" + filter.AdvanceForma_de_Pago + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_de_Cumplimiento.Descripcion LIKE '%" + filter.AdvanceForma_de_Pago + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_de_PagoMultiple != null && filter.AdvanceForma_de_PagoMultiple.Count() > 0)
            {
                var Forma_de_PagoIds = string.Join(",", filter.AdvanceForma_de_PagoMultiple);

                where += " AND Detalle_de_Solicitud_Seguimiento.Forma_de_Pago In (" + Forma_de_PagoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCantidad_del_Monto) || !string.IsNullOrEmpty(filter.ToCantidad_del_Monto))
            {
                if (!string.IsNullOrEmpty(filter.FromCantidad_del_Monto))
                    where += " AND Detalle_de_Solicitud_Seguimiento.Cantidad_del_Monto >= " + filter.FromCantidad_del_Monto;
                if (!string.IsNullOrEmpty(filter.ToCantidad_del_Monto))
                    where += " AND Detalle_de_Solicitud_Seguimiento.Cantidad_del_Monto <= " + filter.ToCantidad_del_Monto;
            }

            if (!string.IsNullOrEmpty(filter.Descripcion_de_Cumplimiento))
            {
                switch (filter.Descripcion_de_CumplimientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Seguimiento.Descripcion_de_Cumplimiento LIKE '" + filter.Descripcion_de_Cumplimiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Seguimiento.Descripcion_de_Cumplimiento LIKE '%" + filter.Descripcion_de_Cumplimiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Seguimiento.Descripcion_de_Cumplimiento = '" + filter.Descripcion_de_Cumplimiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Seguimiento.Descripcion_de_Cumplimiento LIKE '%" + filter.Descripcion_de_Cumplimiento + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceConcluir_Acuerdo))
            {
                switch (filter.Concluir_AcuerdoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND A_Tiempo.Descripcion LIKE '" + filter.AdvanceConcluir_Acuerdo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceConcluir_Acuerdo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND A_Tiempo.Descripcion = '" + filter.AdvanceConcluir_Acuerdo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND A_Tiempo.Descripcion LIKE '%" + filter.AdvanceConcluir_Acuerdo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceConcluir_AcuerdoMultiple != null && filter.AdvanceConcluir_AcuerdoMultiple.Count() > 0)
            {
                var Concluir_AcuerdoIds = string.Join(",", filter.AdvanceConcluir_AcuerdoMultiple);

                where += " AND Detalle_de_Solicitud_Seguimiento.Concluir_Acuerdo In (" + Concluir_AcuerdoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEspecialista))
            {
                switch (filter.EspecialistaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceEspecialista + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceEspecialista + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceEspecialista + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceEspecialista + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEspecialistaMultiple != null && filter.AdvanceEspecialistaMultiple.Count() > 0)
            {
                var EspecialistaIds = string.Join(",", filter.AdvanceEspecialistaMultiple);

                where += " AND Detalle_de_Solicitud_Seguimiento.Especialista In (" + EspecialistaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Comentarios))
            {
                switch (filter.ComentariosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Seguimiento.Comentarios LIKE '" + filter.Comentarios + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Seguimiento.Comentarios LIKE '%" + filter.Comentarios + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Seguimiento.Comentarios = '" + filter.Comentarios + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Seguimiento.Comentarios LIKE '%" + filter.Comentarios + "%'";
                        break;
                }
            }

            if (filter.Archivo != RadioOptions.NoApply)
                where += " AND Detalle_de_Solicitud_Seguimiento.Archivo " + (filter.Archivo == RadioOptions.Yes ? ">" : "==") + " 0";


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
                _IDetalle_de_Solicitud_SeguimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Solicitud_Seguimiento varDetalle_de_Solicitud_Seguimiento = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_Solicitud_SeguimientoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Solicitud_SeguimientoModel varDetalle_de_Solicitud_Seguimiento)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Solicitud_SeguimientoApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varDetalle_de_Solicitud_Seguimiento.ArchivoRemoveAttachment != 0 && varDetalle_de_Solicitud_Seguimiento.ArchivoFile == null)
                    {
                        varDetalle_de_Solicitud_Seguimiento.Archivo = 0;
                    }

                    if (varDetalle_de_Solicitud_Seguimiento.ArchivoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Solicitud_Seguimiento.ArchivoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Solicitud_Seguimiento.Archivo = (short)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Solicitud_Seguimiento.ArchivoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Detalle_de_Solicitud_SeguimientoInfo = new Detalle_de_Solicitud_Seguimiento
                    {
                        Clave = varDetalle_de_Solicitud_Seguimiento.Clave
                        ,Solicitud = varDetalle_de_Solicitud_Seguimiento.Solicitud
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Seguimiento.Fecha_de_Registro)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Seguimiento.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varDetalle_de_Solicitud_Seguimiento.Hora_de_Registro
                        ,Fecha_Requerida = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Seguimiento.Fecha_Requerida)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Seguimiento.Fecha_Requerida, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Relacion = varDetalle_de_Solicitud_Seguimiento.Relacion
                        ,Cumplimiento = varDetalle_de_Solicitud_Seguimiento.Cumplimiento
                        ,Fecha_de_Cumplimiento = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Seguimiento.Fecha_de_Cumplimiento)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Seguimiento.Fecha_de_Cumplimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Forma_de_Pago = varDetalle_de_Solicitud_Seguimiento.Forma_de_Pago
                        ,Cantidad_del_Monto = varDetalle_de_Solicitud_Seguimiento.Cantidad_del_Monto
                        ,Descripcion_de_Cumplimiento = varDetalle_de_Solicitud_Seguimiento.Descripcion_de_Cumplimiento
                        ,Concluir_Acuerdo = varDetalle_de_Solicitud_Seguimiento.Concluir_Acuerdo
                        ,Especialista = varDetalle_de_Solicitud_Seguimiento.Especialista
                        ,Comentarios = varDetalle_de_Solicitud_Seguimiento.Comentarios
                        ,Archivo = (varDetalle_de_Solicitud_Seguimiento.Archivo.HasValue && varDetalle_de_Solicitud_Seguimiento.Archivo != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Solicitud_Seguimiento.Archivo.Value)) : null


                    };

                    result = !IsNew ?
                        _IDetalle_de_Solicitud_SeguimientoApiConsumer.Update(Detalle_de_Solicitud_SeguimientoInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Solicitud_SeguimientoApiConsumer.Insert(Detalle_de_Solicitud_SeguimientoInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Detalle_de_Solicitud_Seguimiento script
        /// </summary>
        /// <param name="oDetalle_de_Solicitud_SeguimientoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_de_Solicitud_SeguimientoModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Solicitud_SeguimientoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Solicitud_SeguimientoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Solicitud_SeguimientoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Solicitud_SeguimientoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Solicitud_SeguimientoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Solicitud_SeguimientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Solicitud_SeguimientoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_de_Solicitud_SeguimientoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_de_Solicitud_SeguimientoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_de_Solicitud_SeguimientoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_de_Solicitud_SeguimientoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_de_Solicitud_SeguimientoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_de_Solicitud_SeguimientoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitud_Seguimiento.js")))
            {
                strDetalle_de_Solicitud_SeguimientoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Solicitud_Seguimiento element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Solicitud_SeguimientoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Solicitud_SeguimientoScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Solicitud_SeguimientoScript.Substring(indexOfArray, strDetalle_de_Solicitud_SeguimientoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Solicitud_SeguimientoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Solicitud_SeguimientoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Solicitud_SeguimientoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_de_Solicitud_SeguimientoScript.Substring(indexOfArrayHistory, strDetalle_de_Solicitud_SeguimientoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_de_Solicitud_SeguimientoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Solicitud_SeguimientoScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Solicitud_SeguimientoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_de_Solicitud_SeguimientoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_de_Solicitud_SeguimientoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitud_Seguimiento.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitud_Seguimiento.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Solicitud_Seguimiento.js")))
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
        public ActionResult Detalle_de_Solicitud_SeguimientoPropertyBag()
        {
            return PartialView("Detalle_de_Solicitud_SeguimientoPropertyBag", "Detalle_de_Solicitud_Seguimiento");
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
                var whereClauseFormat = "Object = 45088 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_de_Solicitud_SeguimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_de_Solicitud_Seguimiento.Clave= " + RecordId;
                            var result = _IDetalle_de_Solicitud_SeguimientoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDetalle_de_Solicitud_SeguimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Solicitud_SeguimientoPropertyMapper());
			
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
                    (Detalle_de_Solicitud_SeguimientoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_de_Solicitud_SeguimientoPropertyMapper oDetalle_de_Solicitud_SeguimientoPropertyMapper = new Detalle_de_Solicitud_SeguimientoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Solicitud_SeguimientoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Solicitud_SeguimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitud_Seguimientos == null)
                result.Detalle_de_Solicitud_Seguimientos = new List<Detalle_de_Solicitud_Seguimiento>();

            var data = result.Detalle_de_Solicitud_Seguimientos.Select(m => new Detalle_de_Solicitud_SeguimientoGridModel
            {
                Clave = m.Clave
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Fecha_Requerida = (m.Fecha_Requerida == null ? string.Empty : Convert.ToDateTime(m.Fecha_Requerida).ToString(ConfigurationProperty.DateFormat))
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Relaciones_MASC.Clave.ToString(), "Relaciones_MASC") ?? (string)m.Relacion_Relaciones_MASC.Descripcion
                        ,CumplimientoDescripcion = CultureHelper.GetTraduction(m.Cumplimiento_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Cumplimiento_Cumplimiento.Descripcion
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
                        ,Forma_de_PagoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Pago_Forma_de_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Pago_Forma_de_Cumplimiento.Descripcion
			,Cantidad_del_Monto = m.Cantidad_del_Monto
			,Descripcion_de_Cumplimiento = m.Descripcion_de_Cumplimiento
                        ,Concluir_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Concluir_Acuerdo_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Concluir_Acuerdo_A_Tiempo.Descripcion
                        ,EspecialistaName = CultureHelper.GetTraduction(m.Especialista_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_Spartan_User.Name
			,Comentarios = m.Comentarios
			,Archivo = m.Archivo

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45088, arrayColumnsVisible), "Detalle_de_Solicitud_SeguimientoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45088, arrayColumnsVisible), "Detalle_de_Solicitud_SeguimientoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45088, arrayColumnsVisible), "Detalle_de_Solicitud_SeguimientoList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Solicitud_SeguimientoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Solicitud_SeguimientoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_de_Solicitud_SeguimientoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_de_Solicitud_SeguimientoPropertyMapper oDetalle_de_Solicitud_SeguimientoPropertyMapper = new Detalle_de_Solicitud_SeguimientoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Solicitud_SeguimientoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Solicitud_SeguimientoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Solicitud_Seguimientos == null)
                result.Detalle_de_Solicitud_Seguimientos = new List<Detalle_de_Solicitud_Seguimiento>();

            var data = result.Detalle_de_Solicitud_Seguimientos.Select(m => new Detalle_de_Solicitud_SeguimientoGridModel
            {
                Clave = m.Clave
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Fecha_Requerida = (m.Fecha_Requerida == null ? string.Empty : Convert.ToDateTime(m.Fecha_Requerida).ToString(ConfigurationProperty.DateFormat))
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Relaciones_MASC.Clave.ToString(), "Relaciones_MASC") ?? (string)m.Relacion_Relaciones_MASC.Descripcion
                        ,CumplimientoDescripcion = CultureHelper.GetTraduction(m.Cumplimiento_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Cumplimiento_Cumplimiento.Descripcion
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
                        ,Forma_de_PagoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Pago_Forma_de_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Pago_Forma_de_Cumplimiento.Descripcion
			,Cantidad_del_Monto = m.Cantidad_del_Monto
			,Descripcion_de_Cumplimiento = m.Descripcion_de_Cumplimiento
                        ,Concluir_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Concluir_Acuerdo_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Concluir_Acuerdo_A_Tiempo.Descripcion
                        ,EspecialistaName = CultureHelper.GetTraduction(m.Especialista_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_Spartan_User.Name
			,Comentarios = m.Comentarios
			,Archivo = m.Archivo

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
                _IDetalle_de_Solicitud_SeguimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Solicitud_SeguimientoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_de_Solicitud_Seguimiento_Datos_GeneralesModel varDetalle_de_Solicitud_Seguimiento)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_SeguimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varDetalle_de_Solicitud_Seguimiento.ArchivoRemoveAttachment != 0 && varDetalle_de_Solicitud_Seguimiento.ArchivoFile == null)
                    {
                        varDetalle_de_Solicitud_Seguimiento.Archivo = 0;
                    }

                    if (varDetalle_de_Solicitud_Seguimiento.ArchivoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Solicitud_Seguimiento.ArchivoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Solicitud_Seguimiento.Archivo = (short)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Solicitud_Seguimiento.ArchivoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Detalle_de_Solicitud_Seguimiento_Datos_GeneralesInfo = new Detalle_de_Solicitud_Seguimiento_Datos_Generales
                {
                    Clave = varDetalle_de_Solicitud_Seguimiento.Clave
                                            ,Solicitud = varDetalle_de_Solicitud_Seguimiento.Solicitud
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Seguimiento.Fecha_de_Registro)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Seguimiento.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varDetalle_de_Solicitud_Seguimiento.Hora_de_Registro
                        ,Fecha_Requerida = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Seguimiento.Fecha_Requerida)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Seguimiento.Fecha_Requerida, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Relacion = varDetalle_de_Solicitud_Seguimiento.Relacion
                        ,Cumplimiento = varDetalle_de_Solicitud_Seguimiento.Cumplimiento
                        ,Fecha_de_Cumplimiento = (!String.IsNullOrEmpty(varDetalle_de_Solicitud_Seguimiento.Fecha_de_Cumplimiento)) ? DateTime.ParseExact(varDetalle_de_Solicitud_Seguimiento.Fecha_de_Cumplimiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Forma_de_Pago = varDetalle_de_Solicitud_Seguimiento.Forma_de_Pago
                        ,Cantidad_del_Monto = varDetalle_de_Solicitud_Seguimiento.Cantidad_del_Monto
                        ,Descripcion_de_Cumplimiento = varDetalle_de_Solicitud_Seguimiento.Descripcion_de_Cumplimiento
                        ,Concluir_Acuerdo = varDetalle_de_Solicitud_Seguimiento.Concluir_Acuerdo
                        ,Especialista = varDetalle_de_Solicitud_Seguimiento.Especialista
                        ,Comentarios = varDetalle_de_Solicitud_Seguimiento.Comentarios
                        ,Archivo = (varDetalle_de_Solicitud_Seguimiento.Archivo.HasValue && varDetalle_de_Solicitud_Seguimiento.Archivo != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Solicitud_Seguimiento.Archivo.Value)) : null

                    
                };

                result = _IDetalle_de_Solicitud_SeguimientoApiConsumer.Update_Datos_Generales(Detalle_de_Solicitud_Seguimiento_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_de_Solicitud_SeguimientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Solicitud_SeguimientoApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Detalle_de_Solicitud_Seguimiento_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Solicitud = m.Solicitud
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Fecha_Requerida = (m.Fecha_Requerida == null ? string.Empty : Convert.ToDateTime(m.Fecha_Requerida).ToString(ConfigurationProperty.DateFormat))
                        ,Relacion = m.Relacion
                        ,RelacionDescripcion = CultureHelper.GetTraduction(m.Relacion_Relaciones_MASC.Clave.ToString(), "Relaciones_MASC") ?? (string)m.Relacion_Relaciones_MASC.Descripcion
                        ,Cumplimiento = m.Cumplimiento
                        ,CumplimientoDescripcion = CultureHelper.GetTraduction(m.Cumplimiento_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Cumplimiento_Cumplimiento.Descripcion
                        ,Fecha_de_Cumplimiento = (m.Fecha_de_Cumplimiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Cumplimiento).ToString(ConfigurationProperty.DateFormat))
                        ,Forma_de_Pago = m.Forma_de_Pago
                        ,Forma_de_PagoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Pago_Forma_de_Cumplimiento.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Pago_Forma_de_Cumplimiento.Descripcion
			,Cantidad_del_Monto = m.Cantidad_del_Monto
			,Descripcion_de_Cumplimiento = m.Descripcion_de_Cumplimiento
                        ,Concluir_Acuerdo = m.Concluir_Acuerdo
                        ,Concluir_AcuerdoDescripcion = CultureHelper.GetTraduction(m.Concluir_Acuerdo_A_Tiempo.Clave.ToString(), "Descripcion") ?? (string)m.Concluir_Acuerdo_A_Tiempo.Descripcion
                        ,Especialista = m.Especialista
                        ,EspecialistaName = CultureHelper.GetTraduction(m.Especialista_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Especialista_Spartan_User.Name
			,Comentarios = m.Comentarios
			,Archivo = m.Archivo

                    
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

