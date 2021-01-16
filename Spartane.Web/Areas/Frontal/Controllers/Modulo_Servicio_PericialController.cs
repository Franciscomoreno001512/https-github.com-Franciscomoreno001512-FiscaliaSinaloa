using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Modulo_Servicio_Pericial;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Estatus_Servicio_Pericial;
using Spartane.Core.Domain.Detalle_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Origen_de_Invitacion;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Modulo_Servicio_Pericial;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Servicio_Pericial;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Estatus_Servicio_Pericial;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Origen_de_Invitacion;

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
    public class Modulo_Servicio_PericialController : Controller
    {
        #region "variable declaration"

        private IModulo_Servicio_PericialService service = null;
        private IModulo_Servicio_PericialApiConsumer _IModulo_Servicio_PericialApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private IEstatus_Servicio_PericialApiConsumer _IEstatus_Servicio_PericialApiConsumer;
        private IDetalle_de_Servicio_de_ApoyoApiConsumer _IDetalle_de_Servicio_de_ApoyoApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private IOrigen_de_InvitacionApiConsumer _IOrigen_de_InvitacionApiConsumer;

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

        
        public Modulo_Servicio_PericialController(IModulo_Servicio_PericialService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IModulo_Servicio_PericialApiConsumer Modulo_Servicio_PericialApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , IEstatus_Servicio_PericialApiConsumer Estatus_Servicio_PericialApiConsumer , IDetalle_de_Servicio_de_ApoyoApiConsumer Detalle_de_Servicio_de_ApoyoApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , IOrigen_de_InvitacionApiConsumer Origen_de_InvitacionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IModulo_Servicio_PericialApiConsumer = Modulo_Servicio_PericialApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IModulo_Atencion_InicialApiConsumer = Modulo_Atencion_InicialApiConsumer;
            this._IEstatus_Servicio_PericialApiConsumer = Estatus_Servicio_PericialApiConsumer;
            this._IDetalle_de_Servicio_de_ApoyoApiConsumer = Detalle_de_Servicio_de_ApoyoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ISolicitudApiConsumer = SolicitudApiConsumer;
            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
            this._IOrigen_de_InvitacionApiConsumer = Origen_de_InvitacionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Modulo_Servicio_Pericial
        [ObjectAuth(ObjectId = (ModuleObjectId)45741, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45741, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Modulo_Servicio_Pericial/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45741, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45741, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varModulo_Servicio_Pericial = new Modulo_Servicio_PericialModel();
			varModulo_Servicio_Pericial.Clave = Id;
			
            ViewBag.ObjectId = "45741";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IModulo_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Modulo_Servicio_PericialsData = _IModulo_Servicio_PericialApiConsumer.ListaSelAll(0, 1000, "Modulo_Servicio_Pericial.Clave=" + Id, "").Resource.Modulo_Servicio_Pericials;
				
				if (Modulo_Servicio_PericialsData != null && Modulo_Servicio_PericialsData.Count > 0)
                {
					var Modulo_Servicio_PericialData = Modulo_Servicio_PericialsData.First();
					varModulo_Servicio_Pericial= new Modulo_Servicio_PericialModel
					{
						Clave  = Modulo_Servicio_PericialData.Clave 
	                    ,Modulo_Atencion_Inicial = Modulo_Servicio_PericialData.Modulo_Atencion_Inicial
                    ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Modulo_Servicio_PericialData.Modulo_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Modulo_Servicio_PericialData.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Estatus = Modulo_Servicio_PericialData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Servicio_PericialData.Estatus), "Estatus_Servicio_Pericial") ??  (string)Modulo_Servicio_PericialData.Estatus_Estatus_Servicio_Pericial.Descripcion
                    ,Servicio_Pericial = Modulo_Servicio_PericialData.Servicio_Pericial
                    ,Servicio_PericialResponsable = CultureHelper.GetTraduction(Convert.ToString(Modulo_Servicio_PericialData.Servicio_Pericial), "Detalle_de_Servicio_de_Apoyo") ??  (string)Modulo_Servicio_PericialData.Servicio_Pericial_Detalle_de_Servicio_de_Apoyo.Responsable
                    ,Usuario_Asignado = Modulo_Servicio_PericialData.Usuario_Asignado
                    ,Usuario_AsignadoName = CultureHelper.GetTraduction(Convert.ToString(Modulo_Servicio_PericialData.Usuario_Asignado), "Spartan_User") ??  (string)Modulo_Servicio_PericialData.Usuario_Asignado_Spartan_User.Name
                    ,Modulo_Mecanismos_Alternos = Modulo_Servicio_PericialData.Modulo_Mecanismos_Alternos
                    ,Modulo_Mecanismos_AlternosCDI = CultureHelper.GetTraduction(Convert.ToString(Modulo_Servicio_PericialData.Modulo_Mecanismos_Alternos), "Solicitud") ??  (string)Modulo_Servicio_PericialData.Modulo_Mecanismos_Alternos_Solicitud.CDI
                    ,Modulo_Ministerio_Publico = Modulo_Servicio_PericialData.Modulo_Ministerio_Publico
                    ,Modulo_Ministerio_Publiconic = CultureHelper.GetTraduction(Convert.ToString(Modulo_Servicio_PericialData.Modulo_Ministerio_Publico), "expediente_ministerio_publico") ??  (string)Modulo_Servicio_PericialData.Modulo_Ministerio_Publico_expediente_ministerio_publico.nic
                    ,Origen = Modulo_Servicio_PericialData.Origen
                    ,OrigenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Servicio_PericialData.Origen), "Origen_de_Invitacion") ??  (string)Modulo_Servicio_PericialData.Origen_Origen_de_Invitacion.Descripcion
                    ,Descripcion = Modulo_Servicio_PericialData.Descripcion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Servicio_Pericials_Estatus = _IEstatus_Servicio_PericialApiConsumer.SelAll(true);
            if (Estatus_Servicio_Pericials_Estatus != null && Estatus_Servicio_Pericials_Estatus.Resource != null)
                ViewBag.Estatus_Servicio_Pericials_Estatus = Estatus_Servicio_Pericials_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Servicio_de_Apoyos_Servicio_Pericial = _IDetalle_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Detalle_de_Servicio_de_Apoyos_Servicio_Pericial != null && Detalle_de_Servicio_de_Apoyos_Servicio_Pericial.Resource != null)
                ViewBag.Detalle_de_Servicio_de_Apoyos_Servicio_Pericial = Detalle_de_Servicio_de_Apoyos_Servicio_Pericial.Resource.Where(m => m.Responsable != null).OrderBy(m => m.Responsable).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Servicio_de_Apoyo", "Responsable") ?? m.Responsable.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_Asignado = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_Asignado != null && Spartan_Users_Usuario_Asignado.Resource != null)
                ViewBag.Spartan_Users_Usuario_Asignado = Spartan_Users_Usuario_Asignado.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varModulo_Servicio_Pericial);
        }
		
	[HttpGet]
        public ActionResult AddModulo_Servicio_Pericial(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45741);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IModulo_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
			Modulo_Servicio_PericialModel varModulo_Servicio_Pericial= new Modulo_Servicio_PericialModel();


            if (id.ToString() != "0")
            {
                var Modulo_Servicio_PericialsData = _IModulo_Servicio_PericialApiConsumer.ListaSelAll(0, 1000, "Modulo_Servicio_Pericial.Clave=" + id, "").Resource.Modulo_Servicio_Pericials;
				
				if (Modulo_Servicio_PericialsData != null && Modulo_Servicio_PericialsData.Count > 0)
                {
					var Modulo_Servicio_PericialData = Modulo_Servicio_PericialsData.First();
					varModulo_Servicio_Pericial= new Modulo_Servicio_PericialModel
					{
						Clave  = Modulo_Servicio_PericialData.Clave 
	                    ,Modulo_Atencion_Inicial = Modulo_Servicio_PericialData.Modulo_Atencion_Inicial
                    ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Modulo_Servicio_PericialData.Modulo_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Modulo_Servicio_PericialData.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Estatus = Modulo_Servicio_PericialData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Servicio_PericialData.Estatus), "Estatus_Servicio_Pericial") ??  (string)Modulo_Servicio_PericialData.Estatus_Estatus_Servicio_Pericial.Descripcion
                    ,Servicio_Pericial = Modulo_Servicio_PericialData.Servicio_Pericial
                    ,Servicio_PericialResponsable = CultureHelper.GetTraduction(Convert.ToString(Modulo_Servicio_PericialData.Servicio_Pericial), "Detalle_de_Servicio_de_Apoyo") ??  (string)Modulo_Servicio_PericialData.Servicio_Pericial_Detalle_de_Servicio_de_Apoyo.Responsable
                    ,Usuario_Asignado = Modulo_Servicio_PericialData.Usuario_Asignado
                    ,Usuario_AsignadoName = CultureHelper.GetTraduction(Convert.ToString(Modulo_Servicio_PericialData.Usuario_Asignado), "Spartan_User") ??  (string)Modulo_Servicio_PericialData.Usuario_Asignado_Spartan_User.Name
                    ,Modulo_Mecanismos_Alternos = Modulo_Servicio_PericialData.Modulo_Mecanismos_Alternos
                    ,Modulo_Mecanismos_AlternosCDI = CultureHelper.GetTraduction(Convert.ToString(Modulo_Servicio_PericialData.Modulo_Mecanismos_Alternos), "Solicitud") ??  (string)Modulo_Servicio_PericialData.Modulo_Mecanismos_Alternos_Solicitud.CDI
                    ,Modulo_Ministerio_Publico = Modulo_Servicio_PericialData.Modulo_Ministerio_Publico
                    ,Modulo_Ministerio_Publiconic = CultureHelper.GetTraduction(Convert.ToString(Modulo_Servicio_PericialData.Modulo_Ministerio_Publico), "expediente_ministerio_publico") ??  (string)Modulo_Servicio_PericialData.Modulo_Ministerio_Publico_expediente_ministerio_publico.nic
                    ,Origen = Modulo_Servicio_PericialData.Origen
                    ,OrigenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Modulo_Servicio_PericialData.Origen), "Origen_de_Invitacion") ??  (string)Modulo_Servicio_PericialData.Origen_Origen_de_Invitacion.Descripcion
                    ,Descripcion = Modulo_Servicio_PericialData.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Servicio_Pericials_Estatus = _IEstatus_Servicio_PericialApiConsumer.SelAll(true);
            if (Estatus_Servicio_Pericials_Estatus != null && Estatus_Servicio_Pericials_Estatus.Resource != null)
                ViewBag.Estatus_Servicio_Pericials_Estatus = Estatus_Servicio_Pericials_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Servicio_de_Apoyos_Servicio_Pericial = _IDetalle_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Detalle_de_Servicio_de_Apoyos_Servicio_Pericial != null && Detalle_de_Servicio_de_Apoyos_Servicio_Pericial.Resource != null)
                ViewBag.Detalle_de_Servicio_de_Apoyos_Servicio_Pericial = Detalle_de_Servicio_de_Apoyos_Servicio_Pericial.Resource.Where(m => m.Responsable != null).OrderBy(m => m.Responsable).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Servicio_de_Apoyo", "Responsable") ?? m.Responsable.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_Asignado = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_Asignado != null && Spartan_Users_Usuario_Asignado.Resource != null)
                ViewBag.Spartan_Users_Usuario_Asignado = Spartan_Users_Usuario_Asignado.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddModulo_Servicio_Pericial", varModulo_Servicio_Pericial);
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
        public ActionResult GetModulo_Atencion_InicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModulo_Atencion_InicialApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT")?? m.NUAT,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatus_Servicio_PericialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_Servicio_PericialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Servicio_Pericial", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Servicio_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Servicio_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Responsable).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Servicio_de_Apoyo", "Responsable")?? m.Responsable,
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
		[HttpGet]
        public ActionResult GetSolicitudAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitudApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.CDI).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Solicitud", "CDI")?? m.CDI,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
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
        public ActionResult GetOrigen_de_InvitacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IOrigen_de_InvitacionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Modulo_Servicio_PericialAdvanceSearchModel model, int idFilter = -1)
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

            _IEstatus_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Servicio_Pericials_Estatus = _IEstatus_Servicio_PericialApiConsumer.SelAll(true);
            if (Estatus_Servicio_Pericials_Estatus != null && Estatus_Servicio_Pericials_Estatus.Resource != null)
                ViewBag.Estatus_Servicio_Pericials_Estatus = Estatus_Servicio_Pericials_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Servicio_de_Apoyos_Servicio_Pericial = _IDetalle_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Detalle_de_Servicio_de_Apoyos_Servicio_Pericial != null && Detalle_de_Servicio_de_Apoyos_Servicio_Pericial.Resource != null)
                ViewBag.Detalle_de_Servicio_de_Apoyos_Servicio_Pericial = Detalle_de_Servicio_de_Apoyos_Servicio_Pericial.Resource.Where(m => m.Responsable != null).OrderBy(m => m.Responsable).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Servicio_de_Apoyo", "Responsable") ?? m.Responsable.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_Asignado = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_Asignado != null && Spartan_Users_Usuario_Asignado.Resource != null)
                ViewBag.Spartan_Users_Usuario_Asignado = Spartan_Users_Usuario_Asignado.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IEstatus_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_Servicio_Pericials_Estatus = _IEstatus_Servicio_PericialApiConsumer.SelAll(true);
            if (Estatus_Servicio_Pericials_Estatus != null && Estatus_Servicio_Pericials_Estatus.Resource != null)
                ViewBag.Estatus_Servicio_Pericials_Estatus = Estatus_Servicio_Pericials_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Servicio_de_Apoyos_Servicio_Pericial = _IDetalle_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Detalle_de_Servicio_de_Apoyos_Servicio_Pericial != null && Detalle_de_Servicio_de_Apoyos_Servicio_Pericial.Resource != null)
                ViewBag.Detalle_de_Servicio_de_Apoyos_Servicio_Pericial = Detalle_de_Servicio_de_Apoyos_Servicio_Pericial.Resource.Where(m => m.Responsable != null).OrderBy(m => m.Responsable).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Servicio_de_Apoyo", "Responsable") ?? m.Responsable.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_Asignado = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_Asignado != null && Spartan_Users_Usuario_Asignado.Resource != null)
                ViewBag.Spartan_Users_Usuario_Asignado = Spartan_Users_Usuario_Asignado.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Modulo_Servicio_PericialAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Modulo_Servicio_PericialAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Modulo_Servicio_PericialAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Modulo_Servicio_PericialPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IModulo_Servicio_PericialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Modulo_Servicio_Pericials == null)
                result.Modulo_Servicio_Pericials = new List<Modulo_Servicio_Pericial>();

            return Json(new
            {
                data = result.Modulo_Servicio_Pericials.Select(m => new Modulo_Servicio_PericialGridModel
                    {
                    Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Servicio_Pericial.Descripcion
                        ,Servicio_PericialResponsable = CultureHelper.GetTraduction(m.Servicio_Pericial_Detalle_de_Servicio_de_Apoyo.Clave.ToString(), "Responsable") ?? (string)m.Servicio_Pericial_Detalle_de_Servicio_de_Apoyo.Responsable
                        ,Usuario_AsignadoName = CultureHelper.GetTraduction(m.Usuario_Asignado_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_Asignado_Spartan_User.Name
                        ,Modulo_Mecanismos_AlternosCDI = CultureHelper.GetTraduction(m.Modulo_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Modulo_Mecanismos_Alternos_Solicitud.CDI
                        ,Modulo_Ministerio_Publiconic = CultureHelper.GetTraduction(m.Modulo_Ministerio_Publico_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Modulo_Ministerio_Publico_expediente_ministerio_publico.nic
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
			,Descripcion = m.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetModulo_Servicio_PericialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModulo_Servicio_PericialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Modulo_Servicio_Pericial", m.),
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
        /// Get List of Modulo_Servicio_Pericial from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Modulo_Servicio_Pericial Entity</returns>
        public ActionResult GetModulo_Servicio_PericialList(UrlParametersModel param)
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
            _IModulo_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Modulo_Servicio_PericialPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Modulo_Servicio_PericialAdvanceSearchModel))
                {
					var advanceFilter =
                    (Modulo_Servicio_PericialAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Modulo_Servicio_PericialPropertyMapper oModulo_Servicio_PericialPropertyMapper = new Modulo_Servicio_PericialPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oModulo_Servicio_PericialPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IModulo_Servicio_PericialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Modulo_Servicio_Pericials == null)
                result.Modulo_Servicio_Pericials = new List<Modulo_Servicio_Pericial>();

            return Json(new
            {
                aaData = result.Modulo_Servicio_Pericials.Select(m => new Modulo_Servicio_PericialGridModel
            {
                    Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Servicio_Pericial.Descripcion
                        ,Servicio_PericialResponsable = CultureHelper.GetTraduction(m.Servicio_Pericial_Detalle_de_Servicio_de_Apoyo.Clave.ToString(), "Responsable") ?? (string)m.Servicio_Pericial_Detalle_de_Servicio_de_Apoyo.Responsable
                        ,Usuario_AsignadoName = CultureHelper.GetTraduction(m.Usuario_Asignado_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_Asignado_Spartan_User.Name
                        ,Modulo_Mecanismos_AlternosCDI = CultureHelper.GetTraduction(m.Modulo_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Modulo_Mecanismos_Alternos_Solicitud.CDI
                        ,Modulo_Ministerio_Publiconic = CultureHelper.GetTraduction(m.Modulo_Ministerio_Publico_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Modulo_Ministerio_Publico_expediente_ministerio_publico.nic
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
			,Descripcion = m.Descripcion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetModulo_Servicio_Pericial_Modulo_Atencion_Inicial_Modulo_Atencion_Inicial(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Modulo_Atencion_Inicial.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Modulo_Atencion_Inicial.NUAT as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IModulo_Atencion_InicialApiConsumer.ListaSelAll(1, 20,elWhere , " Modulo_Atencion_Inicial.NUAT ASC ").Resource;
               
                foreach (var item in result.Modulo_Atencion_Inicials)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Modulo_Atencion_Inicial", "NUAT");
                    item.NUAT =trans ??item.NUAT;
                }
                return Json(result.Modulo_Atencion_Inicials.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetModulo_Servicio_Pericial_Modulo_Mecanismos_Alternos_Solicitud(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitudApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Solicitud.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Solicitud.CDI as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISolicitudApiConsumer.ListaSelAll(1, 20,elWhere , " Solicitud.CDI ASC ").Resource;
               
                foreach (var item in result.Solicituds)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Solicitud", "CDI");
                    item.CDI =trans ??item.CDI;
                }
                return Json(result.Solicituds.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetModulo_Servicio_Pericial_Modulo_Ministerio_Publico_expediente_ministerio_publico(string query, string where)
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





        [NonAction]
        public string GetAdvanceFilter(Modulo_Servicio_PericialAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Modulo_Servicio_Pericial.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Modulo_Servicio_Pericial.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModulo_Atencion_Inicial))
            {
                switch (filter.Modulo_Atencion_InicialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '" + filter.AdvanceModulo_Atencion_Inicial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceModulo_Atencion_Inicial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.NUAT = '" + filter.AdvanceModulo_Atencion_Inicial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceModulo_Atencion_Inicial + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModulo_Atencion_InicialMultiple != null && filter.AdvanceModulo_Atencion_InicialMultiple.Count() > 0)
            {
                var Modulo_Atencion_InicialIds = string.Join(",", filter.AdvanceModulo_Atencion_InicialMultiple);

                where += " AND Modulo_Servicio_Pericial.Modulo_Atencion_Inicial In (" + Modulo_Atencion_InicialIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_Servicio_Pericial.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_Servicio_Pericial.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_Servicio_Pericial.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_Servicio_Pericial.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Modulo_Servicio_Pericial.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceServicio_Pericial))
            {
                switch (filter.Servicio_PericialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Responsable LIKE '" + filter.AdvanceServicio_Pericial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Responsable LIKE '%" + filter.AdvanceServicio_Pericial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Responsable = '" + filter.AdvanceServicio_Pericial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Responsable LIKE '%" + filter.AdvanceServicio_Pericial + "%'";
                        break;
                }
            }
            else if (filter.AdvanceServicio_PericialMultiple != null && filter.AdvanceServicio_PericialMultiple.Count() > 0)
            {
                var Servicio_PericialIds = string.Join(",", filter.AdvanceServicio_PericialMultiple);

                where += " AND Modulo_Servicio_Pericial.Servicio_Pericial In (" + Servicio_PericialIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_Asignado))
            {
                switch (filter.Usuario_AsignadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_Asignado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_Asignado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_Asignado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_Asignado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_AsignadoMultiple != null && filter.AdvanceUsuario_AsignadoMultiple.Count() > 0)
            {
                var Usuario_AsignadoIds = string.Join(",", filter.AdvanceUsuario_AsignadoMultiple);

                where += " AND Modulo_Servicio_Pericial.Usuario_Asignado In (" + Usuario_AsignadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModulo_Mecanismos_Alternos))
            {
                switch (filter.Modulo_Mecanismos_AlternosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.CDI LIKE '" + filter.AdvanceModulo_Mecanismos_Alternos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.CDI LIKE '%" + filter.AdvanceModulo_Mecanismos_Alternos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.CDI = '" + filter.AdvanceModulo_Mecanismos_Alternos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.CDI LIKE '%" + filter.AdvanceModulo_Mecanismos_Alternos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModulo_Mecanismos_AlternosMultiple != null && filter.AdvanceModulo_Mecanismos_AlternosMultiple.Count() > 0)
            {
                var Modulo_Mecanismos_AlternosIds = string.Join(",", filter.AdvanceModulo_Mecanismos_AlternosMultiple);

                where += " AND Modulo_Servicio_Pericial.Modulo_Mecanismos_Alternos In (" + Modulo_Mecanismos_AlternosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModulo_Ministerio_Publico))
            {
                switch (filter.Modulo_Ministerio_PublicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '" + filter.AdvanceModulo_Ministerio_Publico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceModulo_Ministerio_Publico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.nic = '" + filter.AdvanceModulo_Ministerio_Publico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceModulo_Ministerio_Publico + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModulo_Ministerio_PublicoMultiple != null && filter.AdvanceModulo_Ministerio_PublicoMultiple.Count() > 0)
            {
                var Modulo_Ministerio_PublicoIds = string.Join(",", filter.AdvanceModulo_Ministerio_PublicoMultiple);

                where += " AND Modulo_Servicio_Pericial.Modulo_Ministerio_Publico In (" + Modulo_Ministerio_PublicoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceOrigen))
            {
                switch (filter.OrigenFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Origen_de_Invitacion.Descripcion LIKE '" + filter.AdvanceOrigen + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Origen_de_Invitacion.Descripcion LIKE '%" + filter.AdvanceOrigen + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Origen_de_Invitacion.Descripcion = '" + filter.AdvanceOrigen + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Origen_de_Invitacion.Descripcion LIKE '%" + filter.AdvanceOrigen + "%'";
                        break;
                }
            }
            else if (filter.AdvanceOrigenMultiple != null && filter.AdvanceOrigenMultiple.Count() > 0)
            {
                var OrigenIds = string.Join(",", filter.AdvanceOrigenMultiple);

                where += " AND Modulo_Servicio_Pericial.Origen In (" + OrigenIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Descripcion))
            {
                switch (filter.DescripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Servicio_Pericial.Descripcion LIKE '" + filter.Descripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Servicio_Pericial.Descripcion LIKE '%" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Servicio_Pericial.Descripcion = '" + filter.Descripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Servicio_Pericial.Descripcion LIKE '%" + filter.Descripcion + "%'";
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
                _IModulo_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);

                Modulo_Servicio_Pericial varModulo_Servicio_Pericial = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IModulo_Servicio_PericialApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Modulo_Servicio_PericialModel varModulo_Servicio_Pericial)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IModulo_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Modulo_Servicio_PericialInfo = new Modulo_Servicio_Pericial
                    {
                        Clave = varModulo_Servicio_Pericial.Clave
                        ,Modulo_Atencion_Inicial = varModulo_Servicio_Pericial.Modulo_Atencion_Inicial
                        ,Estatus = varModulo_Servicio_Pericial.Estatus
                        ,Servicio_Pericial = varModulo_Servicio_Pericial.Servicio_Pericial
                        ,Usuario_Asignado = varModulo_Servicio_Pericial.Usuario_Asignado
                        ,Modulo_Mecanismos_Alternos = varModulo_Servicio_Pericial.Modulo_Mecanismos_Alternos
                        ,Modulo_Ministerio_Publico = varModulo_Servicio_Pericial.Modulo_Ministerio_Publico
                        ,Origen = varModulo_Servicio_Pericial.Origen
                        ,Descripcion = varModulo_Servicio_Pericial.Descripcion

                    };

                    result = !IsNew ?
                        _IModulo_Servicio_PericialApiConsumer.Update(Modulo_Servicio_PericialInfo, null, null).Resource.ToString() :
                         _IModulo_Servicio_PericialApiConsumer.Insert(Modulo_Servicio_PericialInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Modulo_Servicio_Pericial script
        /// </summary>
        /// <param name="oModulo_Servicio_PericialElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Modulo_Servicio_PericialModuleAttributeList)
        {
            for (int i = 0; i < Modulo_Servicio_PericialModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Modulo_Servicio_PericialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Modulo_Servicio_PericialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Modulo_Servicio_PericialModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Modulo_Servicio_PericialModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Modulo_Servicio_PericialModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Modulo_Servicio_PericialModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Modulo_Servicio_PericialModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Modulo_Servicio_PericialModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Modulo_Servicio_PericialModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Modulo_Servicio_PericialModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Modulo_Servicio_PericialModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strModulo_Servicio_PericialScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Modulo_Servicio_Pericial.js")))
            {
                strModulo_Servicio_PericialScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Modulo_Servicio_Pericial element attributes
            string userChangeJson = jsSerialize.Serialize(Modulo_Servicio_PericialModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strModulo_Servicio_PericialScript.IndexOf("inpuElementArray");
            string splittedString = strModulo_Servicio_PericialScript.Substring(indexOfArray, strModulo_Servicio_PericialScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Modulo_Servicio_PericialModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Modulo_Servicio_PericialModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strModulo_Servicio_PericialScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strModulo_Servicio_PericialScript.Substring(indexOfArrayHistory, strModulo_Servicio_PericialScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strModulo_Servicio_PericialScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strModulo_Servicio_PericialScript.Substring(endIndexOfMainElement + indexOfArray, strModulo_Servicio_PericialScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Modulo_Servicio_PericialModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Modulo_Servicio_PericialModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Modulo_Servicio_Pericial.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Modulo_Servicio_Pericial.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Modulo_Servicio_Pericial.js")))
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
        public ActionResult Modulo_Servicio_PericialPropertyBag()
        {
            return PartialView("Modulo_Servicio_PericialPropertyBag", "Modulo_Servicio_Pericial");
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
                var whereClauseFormat = "Object = 45741 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IModulo_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Modulo_Servicio_Pericial.Clave= " + RecordId;
                            var result = _IModulo_Servicio_PericialApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IModulo_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Modulo_Servicio_PericialPropertyMapper());
			
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
                    (Modulo_Servicio_PericialAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Modulo_Servicio_PericialPropertyMapper oModulo_Servicio_PericialPropertyMapper = new Modulo_Servicio_PericialPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oModulo_Servicio_PericialPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IModulo_Servicio_PericialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Modulo_Servicio_Pericials == null)
                result.Modulo_Servicio_Pericials = new List<Modulo_Servicio_Pericial>();

            var data = result.Modulo_Servicio_Pericials.Select(m => new Modulo_Servicio_PericialGridModel
            {
                Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Servicio_Pericial.Descripcion
                        ,Servicio_PericialResponsable = CultureHelper.GetTraduction(m.Servicio_Pericial_Detalle_de_Servicio_de_Apoyo.Clave.ToString(), "Responsable") ?? (string)m.Servicio_Pericial_Detalle_de_Servicio_de_Apoyo.Responsable
                        ,Usuario_AsignadoName = CultureHelper.GetTraduction(m.Usuario_Asignado_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_Asignado_Spartan_User.Name
                        ,Modulo_Mecanismos_AlternosCDI = CultureHelper.GetTraduction(m.Modulo_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Modulo_Mecanismos_Alternos_Solicitud.CDI
                        ,Modulo_Ministerio_Publiconic = CultureHelper.GetTraduction(m.Modulo_Ministerio_Publico_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Modulo_Ministerio_Publico_expediente_ministerio_publico.nic
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
			,Descripcion = m.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45741, arrayColumnsVisible), "Modulo_Servicio_PericialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45741, arrayColumnsVisible), "Modulo_Servicio_PericialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45741, arrayColumnsVisible), "Modulo_Servicio_PericialList_" + DateTime.Now.ToString());
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

            _IModulo_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Modulo_Servicio_PericialPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Modulo_Servicio_PericialAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Modulo_Servicio_PericialPropertyMapper oModulo_Servicio_PericialPropertyMapper = new Modulo_Servicio_PericialPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oModulo_Servicio_PericialPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IModulo_Servicio_PericialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Modulo_Servicio_Pericials == null)
                result.Modulo_Servicio_Pericials = new List<Modulo_Servicio_Pericial>();

            var data = result.Modulo_Servicio_Pericials.Select(m => new Modulo_Servicio_PericialGridModel
            {
                Clave = m.Clave
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Servicio_Pericial.Descripcion
                        ,Servicio_PericialResponsable = CultureHelper.GetTraduction(m.Servicio_Pericial_Detalle_de_Servicio_de_Apoyo.Clave.ToString(), "Responsable") ?? (string)m.Servicio_Pericial_Detalle_de_Servicio_de_Apoyo.Responsable
                        ,Usuario_AsignadoName = CultureHelper.GetTraduction(m.Usuario_Asignado_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_Asignado_Spartan_User.Name
                        ,Modulo_Mecanismos_AlternosCDI = CultureHelper.GetTraduction(m.Modulo_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Modulo_Mecanismos_Alternos_Solicitud.CDI
                        ,Modulo_Ministerio_Publiconic = CultureHelper.GetTraduction(m.Modulo_Ministerio_Publico_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Modulo_Ministerio_Publico_expediente_ministerio_publico.nic
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
			,Descripcion = m.Descripcion

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
                _IModulo_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModulo_Servicio_PericialApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Modulo_Servicio_Pericial_Datos_GeneralesModel varModulo_Servicio_Pericial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModulo_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Modulo_Servicio_Pericial_Datos_GeneralesInfo = new Modulo_Servicio_Pericial_Datos_Generales
                {
                    Clave = varModulo_Servicio_Pericial.Clave
                                            ,Modulo_Atencion_Inicial = varModulo_Servicio_Pericial.Modulo_Atencion_Inicial
                        ,Estatus = varModulo_Servicio_Pericial.Estatus
                        ,Servicio_Pericial = varModulo_Servicio_Pericial.Servicio_Pericial
                        ,Usuario_Asignado = varModulo_Servicio_Pericial.Usuario_Asignado
                        ,Modulo_Mecanismos_Alternos = varModulo_Servicio_Pericial.Modulo_Mecanismos_Alternos
                        ,Modulo_Ministerio_Publico = varModulo_Servicio_Pericial.Modulo_Ministerio_Publico
                        ,Origen = varModulo_Servicio_Pericial.Origen
                        ,Descripcion = varModulo_Servicio_Pericial.Descripcion
                    
                };

                result = _IModulo_Servicio_PericialApiConsumer.Update_Datos_Generales(Modulo_Servicio_Pericial_Datos_GeneralesInfo).Resource.ToString();
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
                _IModulo_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IModulo_Servicio_PericialApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Modulo_Servicio_Pericial_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Modulo_Atencion_Inicial = m.Modulo_Atencion_Inicial
                        ,Modulo_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_Servicio_Pericial.Descripcion
                        ,Servicio_Pericial = m.Servicio_Pericial
                        ,Servicio_PericialResponsable = CultureHelper.GetTraduction(m.Servicio_Pericial_Detalle_de_Servicio_de_Apoyo.Clave.ToString(), "Responsable") ?? (string)m.Servicio_Pericial_Detalle_de_Servicio_de_Apoyo.Responsable
                        ,Usuario_Asignado = m.Usuario_Asignado
                        ,Usuario_AsignadoName = CultureHelper.GetTraduction(m.Usuario_Asignado_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_Asignado_Spartan_User.Name
                        ,Modulo_Mecanismos_Alternos = m.Modulo_Mecanismos_Alternos
                        ,Modulo_Mecanismos_AlternosCDI = CultureHelper.GetTraduction(m.Modulo_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Modulo_Mecanismos_Alternos_Solicitud.CDI
                        ,Modulo_Ministerio_Publico = m.Modulo_Ministerio_Publico
                        ,Modulo_Ministerio_Publiconic = CultureHelper.GetTraduction(m.Modulo_Ministerio_Publico_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Modulo_Ministerio_Publico_expediente_ministerio_publico.nic
                        ,Origen = m.Origen
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
			,Descripcion = m.Descripcion

                    
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

