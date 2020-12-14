using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Medidas_de_Proteccion;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Medida_de_Proteccion;
using Spartane.Core.Domain.Detalle_Medidas_Proteccion;


using Spartane.Core.Domain.Medida_de_Proteccion;

using Spartane.Core.Domain.SubTipo_de_Medida_de_Proteccion;
using Spartane.Core.Domain.Detalle_de_Relaciones;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Medidas_de_Proteccion;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Medidas_de_Proteccion;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Medida_de_Proteccion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_Medidas_Proteccion;


using Spartane.Web.Areas.WebApiConsumer.Medida_de_Proteccion;

using Spartane.Web.Areas.WebApiConsumer.SubTipo_de_Medida_de_Proteccion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Relaciones;

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
    public class Medidas_de_ProteccionController : Controller
    {
        #region "variable declaration"

        private IMedidas_de_ProteccionService service = null;
        private IMedidas_de_ProteccionApiConsumer _IMedidas_de_ProteccionApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ITipo_de_Medida_de_ProteccionApiConsumer _ITipo_de_Medida_de_ProteccionApiConsumer;
        private IDetalle_Medidas_ProteccionApiConsumer _IDetalle_Medidas_ProteccionApiConsumer;


        private IMedida_de_ProteccionApiConsumer _IMedida_de_ProteccionApiConsumer;

        private ISubTipo_de_Medida_de_ProteccionApiConsumer _ISubTipo_de_Medida_de_ProteccionApiConsumer;
        private IDetalle_de_RelacionesApiConsumer _IDetalle_de_RelacionesApiConsumer;

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

        
        public Medidas_de_ProteccionController(IMedidas_de_ProteccionService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IMedidas_de_ProteccionApiConsumer Medidas_de_ProteccionApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ITipo_de_Medida_de_ProteccionApiConsumer Tipo_de_Medida_de_ProteccionApiConsumer , IDetalle_Medidas_ProteccionApiConsumer Detalle_Medidas_ProteccionApiConsumer , IMedida_de_ProteccionApiConsumer Medida_de_ProteccionApiConsumer  , ISubTipo_de_Medida_de_ProteccionApiConsumer SubTipo_de_Medida_de_ProteccionApiConsumer , IDetalle_de_RelacionesApiConsumer Detalle_de_RelacionesApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IMedidas_de_ProteccionApiConsumer = Medidas_de_ProteccionApiConsumer;
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
            this._ISolicitudApiConsumer = SolicitudApiConsumer;
            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ITipo_de_Medida_de_ProteccionApiConsumer = Tipo_de_Medida_de_ProteccionApiConsumer;
            this._IDetalle_Medidas_ProteccionApiConsumer = Detalle_Medidas_ProteccionApiConsumer;


            this._IMedida_de_ProteccionApiConsumer = Medida_de_ProteccionApiConsumer;

            this._ISubTipo_de_Medida_de_ProteccionApiConsumer = SubTipo_de_Medida_de_ProteccionApiConsumer;
            this._IDetalle_de_RelacionesApiConsumer = Detalle_de_RelacionesApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Medidas_de_Proteccion
        [ObjectAuth(ObjectId = (ModuleObjectId)45624, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45624, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Medidas_de_Proteccion/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45624, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45624, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varMedidas_de_Proteccion = new Medidas_de_ProteccionModel();
			varMedidas_de_Proteccion.Clave = Id;
			
            ViewBag.ObjectId = "45624";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_Medidas_Proteccion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45625, ModuleId);
            ViewBag.PermissionDetalle_Medidas_Proteccion = permissionDetalle_Medidas_Proteccion;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IMedidas_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Medidas_de_ProteccionsData = _IMedidas_de_ProteccionApiConsumer.ListaSelAll(0, 1000, "Medidas_de_Proteccion.Clave=" + Id, "").Resource.Medidas_de_Proteccions;
				
				if (Medidas_de_ProteccionsData != null && Medidas_de_ProteccionsData.Count > 0)
                {
					var Medidas_de_ProteccionData = Medidas_de_ProteccionsData.First();
					varMedidas_de_Proteccion= new Medidas_de_ProteccionModel
					{
						Clave  = Medidas_de_ProteccionData.Clave 
	                    ,Expediente_AT = Medidas_de_ProteccionData.Expediente_AT
                    ,Expediente_ATNUAT = CultureHelper.GetTraduction(Convert.ToString(Medidas_de_ProteccionData.Expediente_AT), "Modulo_Atencion_Inicial") ??  (string)Medidas_de_ProteccionData.Expediente_AT_Modulo_Atencion_Inicial.NUAT
                    ,Expediente_MASC = Medidas_de_ProteccionData.Expediente_MASC
                    ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Medidas_de_ProteccionData.Expediente_MASC), "Solicitud") ??  (string)Medidas_de_ProteccionData.Expediente_MASC_Solicitud.Numero_de_Folio
                    ,Expediente_MP = Medidas_de_ProteccionData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Medidas_de_ProteccionData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Medidas_de_ProteccionData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Fecha_de_Registro = (Medidas_de_ProteccionData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Medidas_de_ProteccionData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Medidas_de_ProteccionData.Hora_de_Registro
                    ,Usuario_que_Registra = Medidas_de_ProteccionData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Medidas_de_ProteccionData.Usuario_que_Registra), "Spartan_User") ??  (string)Medidas_de_ProteccionData.Usuario_que_Registra_Spartan_User.Name
                    ,Orden_de_Proteccion = Medidas_de_ProteccionData.Orden_de_Proteccion
                    ,Tipo_de_Medida = Medidas_de_ProteccionData.Tipo_de_Medida
                    ,Tipo_de_MedidaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Medidas_de_ProteccionData.Tipo_de_Medida), "Tipo_de_Medida_de_Proteccion") ??  (string)Medidas_de_ProteccionData.Tipo_de_Medida_Tipo_de_Medida_de_Proteccion.Descripcion
                    ,Sub_Tipo = Medidas_de_ProteccionData.Sub_Tipo
                    ,Sub_TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Medidas_de_ProteccionData.Sub_Tipo), "SubTipo_de_Medida_de_Proteccion") ??  (string)Medidas_de_ProteccionData.Sub_Tipo_SubTipo_de_Medida_de_Proteccion.Descripcion
                    ,Fecha_de_Inicio = (Medidas_de_ProteccionData.Fecha_de_Inicio == null ? string.Empty : Convert.ToDateTime(Medidas_de_ProteccionData.Fecha_de_Inicio).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Inicio = Medidas_de_ProteccionData.Hora_de_Inicio
                    ,Fecha_de_Conclusion = (Medidas_de_ProteccionData.Fecha_de_Conclusion == null ? string.Empty : Convert.ToDateTime(Medidas_de_ProteccionData.Fecha_de_Conclusion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Conclusion = Medidas_de_ProteccionData.Hora_de_Conclusion
                    ,Duracion_en_Dias = Medidas_de_ProteccionData.Duracion_en_Dias
                    ,Aplicar_a = Medidas_de_ProteccionData.Aplicar_a
                    ,Aplicar_aDescripcion = CultureHelper.GetTraduction(Convert.ToString(Medidas_de_ProteccionData.Aplicar_a), "Detalle_de_Relaciones") ??  (string)Medidas_de_ProteccionData.Aplicar_a_Detalle_de_Relaciones.Descripcion

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_Medida_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Medida_de_Proteccions_Tipo_de_Medida = _ITipo_de_Medida_de_ProteccionApiConsumer.SelAll(true);
            if (Tipo_de_Medida_de_Proteccions_Tipo_de_Medida != null && Tipo_de_Medida_de_Proteccions_Tipo_de_Medida.Resource != null)
                ViewBag.Tipo_de_Medida_de_Proteccions_Tipo_de_Medida = Tipo_de_Medida_de_Proteccions_Tipo_de_Medida.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Medida_de_Proteccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubTipo_de_Medida_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubTipo_de_Medida_de_Proteccions_Sub_Tipo = _ISubTipo_de_Medida_de_ProteccionApiConsumer.SelAll(true);
            if (SubTipo_de_Medida_de_Proteccions_Sub_Tipo != null && SubTipo_de_Medida_de_Proteccions_Sub_Tipo.Resource != null)
                ViewBag.SubTipo_de_Medida_de_Proteccions_Sub_Tipo = SubTipo_de_Medida_de_Proteccions_Sub_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubTipo_de_Medida_de_Proteccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varMedidas_de_Proteccion);
        }
		
	[HttpGet]
        public ActionResult AddMedidas_de_Proteccion(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45624);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IMedidas_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
			Medidas_de_ProteccionModel varMedidas_de_Proteccion= new Medidas_de_ProteccionModel();
            var permissionDetalle_Medidas_Proteccion = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45625, ModuleId);
            ViewBag.PermissionDetalle_Medidas_Proteccion = permissionDetalle_Medidas_Proteccion;


            if (id.ToString() != "0")
            {
                var Medidas_de_ProteccionsData = _IMedidas_de_ProteccionApiConsumer.ListaSelAll(0, 1000, "Medidas_de_Proteccion.Clave=" + id, "").Resource.Medidas_de_Proteccions;
				
				if (Medidas_de_ProteccionsData != null && Medidas_de_ProteccionsData.Count > 0)
                {
					var Medidas_de_ProteccionData = Medidas_de_ProteccionsData.First();
					varMedidas_de_Proteccion= new Medidas_de_ProteccionModel
					{
						Clave  = Medidas_de_ProteccionData.Clave 
	                    ,Expediente_AT = Medidas_de_ProteccionData.Expediente_AT
                    ,Expediente_ATNUAT = CultureHelper.GetTraduction(Convert.ToString(Medidas_de_ProteccionData.Expediente_AT), "Modulo_Atencion_Inicial") ??  (string)Medidas_de_ProteccionData.Expediente_AT_Modulo_Atencion_Inicial.NUAT
                    ,Expediente_MASC = Medidas_de_ProteccionData.Expediente_MASC
                    ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Medidas_de_ProteccionData.Expediente_MASC), "Solicitud") ??  (string)Medidas_de_ProteccionData.Expediente_MASC_Solicitud.Numero_de_Folio
                    ,Expediente_MP = Medidas_de_ProteccionData.Expediente_MP
                    ,Expediente_MPnic = CultureHelper.GetTraduction(Convert.ToString(Medidas_de_ProteccionData.Expediente_MP), "expediente_ministerio_publico") ??  (string)Medidas_de_ProteccionData.Expediente_MP_expediente_ministerio_publico.nic
                    ,Fecha_de_Registro = (Medidas_de_ProteccionData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Medidas_de_ProteccionData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Medidas_de_ProteccionData.Hora_de_Registro
                    ,Usuario_que_Registra = Medidas_de_ProteccionData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Medidas_de_ProteccionData.Usuario_que_Registra), "Spartan_User") ??  (string)Medidas_de_ProteccionData.Usuario_que_Registra_Spartan_User.Name
                    ,Orden_de_Proteccion = Medidas_de_ProteccionData.Orden_de_Proteccion
                    ,Tipo_de_Medida = Medidas_de_ProteccionData.Tipo_de_Medida
                    ,Tipo_de_MedidaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Medidas_de_ProteccionData.Tipo_de_Medida), "Tipo_de_Medida_de_Proteccion") ??  (string)Medidas_de_ProteccionData.Tipo_de_Medida_Tipo_de_Medida_de_Proteccion.Descripcion
                    ,Sub_Tipo = Medidas_de_ProteccionData.Sub_Tipo
                    ,Sub_TipoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Medidas_de_ProteccionData.Sub_Tipo), "SubTipo_de_Medida_de_Proteccion") ??  (string)Medidas_de_ProteccionData.Sub_Tipo_SubTipo_de_Medida_de_Proteccion.Descripcion
                    ,Fecha_de_Inicio = (Medidas_de_ProteccionData.Fecha_de_Inicio == null ? string.Empty : Convert.ToDateTime(Medidas_de_ProteccionData.Fecha_de_Inicio).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Inicio = Medidas_de_ProteccionData.Hora_de_Inicio
                    ,Fecha_de_Conclusion = (Medidas_de_ProteccionData.Fecha_de_Conclusion == null ? string.Empty : Convert.ToDateTime(Medidas_de_ProteccionData.Fecha_de_Conclusion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Conclusion = Medidas_de_ProteccionData.Hora_de_Conclusion
                    ,Duracion_en_Dias = Medidas_de_ProteccionData.Duracion_en_Dias
                    ,Aplicar_a = Medidas_de_ProteccionData.Aplicar_a
                    ,Aplicar_aDescripcion = CultureHelper.GetTraduction(Convert.ToString(Medidas_de_ProteccionData.Aplicar_a), "Detalle_de_Relaciones") ??  (string)Medidas_de_ProteccionData.Aplicar_a_Detalle_de_Relaciones.Descripcion

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_Medida_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Medida_de_Proteccions_Tipo_de_Medida = _ITipo_de_Medida_de_ProteccionApiConsumer.SelAll(true);
            if (Tipo_de_Medida_de_Proteccions_Tipo_de_Medida != null && Tipo_de_Medida_de_Proteccions_Tipo_de_Medida.Resource != null)
                ViewBag.Tipo_de_Medida_de_Proteccions_Tipo_de_Medida = Tipo_de_Medida_de_Proteccions_Tipo_de_Medida.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Medida_de_Proteccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubTipo_de_Medida_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubTipo_de_Medida_de_Proteccions_Sub_Tipo = _ISubTipo_de_Medida_de_ProteccionApiConsumer.SelAll(true);
            if (SubTipo_de_Medida_de_Proteccions_Sub_Tipo != null && SubTipo_de_Medida_de_Proteccions_Sub_Tipo.Resource != null)
                ViewBag.SubTipo_de_Medida_de_Proteccions_Sub_Tipo = SubTipo_de_Medida_de_Proteccions_Sub_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubTipo_de_Medida_de_Proteccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddMedidas_de_Proteccion", varMedidas_de_Proteccion);
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
        public ActionResult GetTipo_de_Medida_de_ProteccionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Medida_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Medida_de_ProteccionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Medida_de_Proteccion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetSubTipo_de_Medida_de_ProteccionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISubTipo_de_Medida_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISubTipo_de_Medida_de_ProteccionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubTipo_de_Medida_de_Proteccion", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetDetalle_de_RelacionesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_RelacionesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_RelacionesApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Relaciones", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Medidas_de_ProteccionAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_Medida_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Medida_de_Proteccions_Tipo_de_Medida = _ITipo_de_Medida_de_ProteccionApiConsumer.SelAll(true);
            if (Tipo_de_Medida_de_Proteccions_Tipo_de_Medida != null && Tipo_de_Medida_de_Proteccions_Tipo_de_Medida.Resource != null)
                ViewBag.Tipo_de_Medida_de_Proteccions_Tipo_de_Medida = Tipo_de_Medida_de_Proteccions_Tipo_de_Medida.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Medida_de_Proteccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubTipo_de_Medida_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubTipo_de_Medida_de_Proteccions_Sub_Tipo = _ISubTipo_de_Medida_de_ProteccionApiConsumer.SelAll(true);
            if (SubTipo_de_Medida_de_Proteccions_Sub_Tipo != null && SubTipo_de_Medida_de_Proteccions_Sub_Tipo.Resource != null)
                ViewBag.SubTipo_de_Medida_de_Proteccions_Sub_Tipo = SubTipo_de_Medida_de_Proteccions_Sub_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubTipo_de_Medida_de_Proteccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_Medida_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Medida_de_Proteccions_Tipo_de_Medida = _ITipo_de_Medida_de_ProteccionApiConsumer.SelAll(true);
            if (Tipo_de_Medida_de_Proteccions_Tipo_de_Medida != null && Tipo_de_Medida_de_Proteccions_Tipo_de_Medida.Resource != null)
                ViewBag.Tipo_de_Medida_de_Proteccions_Tipo_de_Medida = Tipo_de_Medida_de_Proteccions_Tipo_de_Medida.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Medida_de_Proteccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubTipo_de_Medida_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubTipo_de_Medida_de_Proteccions_Sub_Tipo = _ISubTipo_de_Medida_de_ProteccionApiConsumer.SelAll(true);
            if (SubTipo_de_Medida_de_Proteccions_Sub_Tipo != null && SubTipo_de_Medida_de_Proteccions_Sub_Tipo.Resource != null)
                ViewBag.SubTipo_de_Medida_de_Proteccions_Sub_Tipo = SubTipo_de_Medida_de_Proteccions_Sub_Tipo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubTipo_de_Medida_de_Proteccion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Medidas_de_ProteccionAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Medidas_de_ProteccionAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Medidas_de_ProteccionAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Medidas_de_ProteccionPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IMedidas_de_ProteccionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Medidas_de_Proteccions == null)
                result.Medidas_de_Proteccions = new List<Medidas_de_Proteccion>();

            return Json(new
            {
                data = result.Medidas_de_Proteccions.Select(m => new Medidas_de_ProteccionGridModel
                    {
                    Clave = m.Clave
                        ,Expediente_ATNUAT = CultureHelper.GetTraduction(m.Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_AT_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Orden_de_Proteccion = m.Orden_de_Proteccion
                        ,Tipo_de_MedidaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Medida_Tipo_de_Medida_de_Proteccion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Medida_Tipo_de_Medida_de_Proteccion.Descripcion
                        ,Sub_TipoDescripcion = CultureHelper.GetTraduction(m.Sub_Tipo_SubTipo_de_Medida_de_Proteccion.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Tipo_SubTipo_de_Medida_de_Proteccion.Descripcion
                        ,Fecha_de_Inicio = (m.Fecha_de_Inicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Inicio = m.Hora_de_Inicio
                        ,Fecha_de_Conclusion = (m.Fecha_de_Conclusion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Conclusion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Conclusion = m.Hora_de_Conclusion
			,Duracion_en_Dias = m.Duracion_en_Dias
                        ,Aplicar_aDescripcion = CultureHelper.GetTraduction(m.Aplicar_a_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Aplicar_a_Detalle_de_Relaciones.Descripcion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetMedidas_de_ProteccionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMedidas_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMedidas_de_ProteccionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Medidas_de_Proteccion", m.),
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
        /// Get List of Medidas_de_Proteccion from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Medidas_de_Proteccion Entity</returns>
        public ActionResult GetMedidas_de_ProteccionList(UrlParametersModel param)
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
            _IMedidas_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Medidas_de_ProteccionPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Medidas_de_ProteccionAdvanceSearchModel))
                {
					var advanceFilter =
                    (Medidas_de_ProteccionAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Medidas_de_ProteccionPropertyMapper oMedidas_de_ProteccionPropertyMapper = new Medidas_de_ProteccionPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oMedidas_de_ProteccionPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IMedidas_de_ProteccionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Medidas_de_Proteccions == null)
                result.Medidas_de_Proteccions = new List<Medidas_de_Proteccion>();

            return Json(new
            {
                aaData = result.Medidas_de_Proteccions.Select(m => new Medidas_de_ProteccionGridModel
            {
                    Clave = m.Clave
                        ,Expediente_ATNUAT = CultureHelper.GetTraduction(m.Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_AT_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Orden_de_Proteccion = m.Orden_de_Proteccion
                        ,Tipo_de_MedidaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Medida_Tipo_de_Medida_de_Proteccion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Medida_Tipo_de_Medida_de_Proteccion.Descripcion
                        ,Sub_TipoDescripcion = CultureHelper.GetTraduction(m.Sub_Tipo_SubTipo_de_Medida_de_Proteccion.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Tipo_SubTipo_de_Medida_de_Proteccion.Descripcion
                        ,Fecha_de_Inicio = (m.Fecha_de_Inicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Inicio = m.Hora_de_Inicio
                        ,Fecha_de_Conclusion = (m.Fecha_de_Conclusion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Conclusion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Conclusion = m.Hora_de_Conclusion
			,Duracion_en_Dias = m.Duracion_en_Dias
                        ,Aplicar_aDescripcion = CultureHelper.GetTraduction(m.Aplicar_a_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Aplicar_a_Detalle_de_Relaciones.Descripcion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetMedidas_de_Proteccion_Expediente_AT_Modulo_Atencion_Inicial(string query, string where)
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
        public JsonResult GetMedidas_de_Proteccion_Expediente_MASC_Solicitud(string query, string where)
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
        public JsonResult GetMedidas_de_Proteccion_Expediente_MP_expediente_ministerio_publico(string query, string where)
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
        public JsonResult GetMedidas_de_Proteccion_Usuario_que_Registra_Spartan_User(string query, string where)
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
//Grid GetAutoComplete

        [HttpGet]
        public JsonResult GetMedidas_de_Proteccion_Aplicar_a_Detalle_de_Relaciones(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_RelacionesApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Relaciones.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Relaciones.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_RelacionesApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Relaciones.Descripcion ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Relacioness)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Relaciones", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Detalle_de_Relacioness.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public string GetAdvanceFilter(Medidas_de_ProteccionAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Medidas_de_Proteccion.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Medidas_de_Proteccion.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceExpediente_AT))
            {
                switch (filter.Expediente_ATFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '" + filter.AdvanceExpediente_AT + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceExpediente_AT + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.NUAT = '" + filter.AdvanceExpediente_AT + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceExpediente_AT + "%'";
                        break;
                }
            }
            else if (filter.AdvanceExpediente_ATMultiple != null && filter.AdvanceExpediente_ATMultiple.Count() > 0)
            {
                var Expediente_ATIds = string.Join(",", filter.AdvanceExpediente_ATMultiple);

                where += " AND Medidas_de_Proteccion.Expediente_AT In (" + Expediente_ATIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceExpediente_MASC))
            {
                switch (filter.Expediente_MASCFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '" + filter.AdvanceExpediente_MASC + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceExpediente_MASC + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud.Numero_de_Folio = '" + filter.AdvanceExpediente_MASC + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud.Numero_de_Folio LIKE '%" + filter.AdvanceExpediente_MASC + "%'";
                        break;
                }
            }
            else if (filter.AdvanceExpediente_MASCMultiple != null && filter.AdvanceExpediente_MASCMultiple.Count() > 0)
            {
                var Expediente_MASCIds = string.Join(",", filter.AdvanceExpediente_MASCMultiple);

                where += " AND Medidas_de_Proteccion.Expediente_MASC In (" + Expediente_MASCIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceExpediente_MP))
            {
                switch (filter.Expediente_MPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '" + filter.AdvanceExpediente_MP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceExpediente_MP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.nic = '" + filter.AdvanceExpediente_MP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.nic LIKE '%" + filter.AdvanceExpediente_MP + "%'";
                        break;
                }
            }
            else if (filter.AdvanceExpediente_MPMultiple != null && filter.AdvanceExpediente_MPMultiple.Count() > 0)
            {
                var Expediente_MPIds = string.Join(",", filter.AdvanceExpediente_MPMultiple);

                where += " AND Medidas_de_Proteccion.Expediente_MP In (" + Expediente_MPIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Medidas_de_Proteccion.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Medidas_de_Proteccion.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Medidas_de_Proteccion.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Medidas_de_Proteccion.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
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

                where += " AND Medidas_de_Proteccion.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Orden_de_Proteccion))
            {
                switch (filter.Orden_de_ProteccionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Medidas_de_Proteccion.Orden_de_Proteccion LIKE '" + filter.Orden_de_Proteccion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Medidas_de_Proteccion.Orden_de_Proteccion LIKE '%" + filter.Orden_de_Proteccion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Medidas_de_Proteccion.Orden_de_Proteccion = '" + filter.Orden_de_Proteccion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Medidas_de_Proteccion.Orden_de_Proteccion LIKE '%" + filter.Orden_de_Proteccion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Medida))
            {
                switch (filter.Tipo_de_MedidaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Medida_de_Proteccion.Descripcion LIKE '" + filter.AdvanceTipo_de_Medida + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Medida_de_Proteccion.Descripcion LIKE '%" + filter.AdvanceTipo_de_Medida + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Medida_de_Proteccion.Descripcion = '" + filter.AdvanceTipo_de_Medida + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Medida_de_Proteccion.Descripcion LIKE '%" + filter.AdvanceTipo_de_Medida + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_MedidaMultiple != null && filter.AdvanceTipo_de_MedidaMultiple.Count() > 0)
            {
                var Tipo_de_MedidaIds = string.Join(",", filter.AdvanceTipo_de_MedidaMultiple);

                where += " AND Medidas_de_Proteccion.Tipo_de_Medida In (" + Tipo_de_MedidaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSub_Tipo))
            {
                switch (filter.Sub_TipoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND SubTipo_de_Medida_de_Proteccion.Descripcion LIKE '" + filter.AdvanceSub_Tipo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND SubTipo_de_Medida_de_Proteccion.Descripcion LIKE '%" + filter.AdvanceSub_Tipo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND SubTipo_de_Medida_de_Proteccion.Descripcion = '" + filter.AdvanceSub_Tipo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND SubTipo_de_Medida_de_Proteccion.Descripcion LIKE '%" + filter.AdvanceSub_Tipo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSub_TipoMultiple != null && filter.AdvanceSub_TipoMultiple.Count() > 0)
            {
                var Sub_TipoIds = string.Join(",", filter.AdvanceSub_TipoMultiple);

                where += " AND Medidas_de_Proteccion.Sub_Tipo In (" + Sub_TipoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Inicio) || !string.IsNullOrEmpty(filter.ToFecha_de_Inicio))
            {
                var Fecha_de_InicioFrom = DateTime.ParseExact(filter.FromFecha_de_Inicio, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_InicioTo = DateTime.ParseExact(filter.ToFecha_de_Inicio, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Inicio))
                    where += " AND Medidas_de_Proteccion.Fecha_de_Inicio >= '" + Fecha_de_InicioFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Inicio))
                    where += " AND Medidas_de_Proteccion.Fecha_de_Inicio <= '" + Fecha_de_InicioTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Inicio) || !string.IsNullOrEmpty(filter.ToHora_de_Inicio))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Inicio))
                    where += " AND Convert(TIME,Medidas_de_Proteccion.Hora_de_Inicio) >='" + filter.FromHora_de_Inicio + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Inicio))
                    where += " AND Convert(TIME,Medidas_de_Proteccion.Hora_de_Inicio) <='" + filter.ToHora_de_Inicio + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Conclusion) || !string.IsNullOrEmpty(filter.ToFecha_de_Conclusion))
            {
                var Fecha_de_ConclusionFrom = DateTime.ParseExact(filter.FromFecha_de_Conclusion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_ConclusionTo = DateTime.ParseExact(filter.ToFecha_de_Conclusion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Conclusion))
                    where += " AND Medidas_de_Proteccion.Fecha_de_Conclusion >= '" + Fecha_de_ConclusionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Conclusion))
                    where += " AND Medidas_de_Proteccion.Fecha_de_Conclusion <= '" + Fecha_de_ConclusionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Conclusion) || !string.IsNullOrEmpty(filter.ToHora_de_Conclusion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Conclusion))
                    where += " AND Convert(TIME,Medidas_de_Proteccion.Hora_de_Conclusion) >='" + filter.FromHora_de_Conclusion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Conclusion))
                    where += " AND Convert(TIME,Medidas_de_Proteccion.Hora_de_Conclusion) <='" + filter.ToHora_de_Conclusion + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromDuracion_en_Dias) || !string.IsNullOrEmpty(filter.ToDuracion_en_Dias))
            {
                if (!string.IsNullOrEmpty(filter.FromDuracion_en_Dias))
                    where += " AND Medidas_de_Proteccion.Duracion_en_Dias >= " + filter.FromDuracion_en_Dias;
                if (!string.IsNullOrEmpty(filter.ToDuracion_en_Dias))
                    where += " AND Medidas_de_Proteccion.Duracion_en_Dias <= " + filter.ToDuracion_en_Dias;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAplicar_a))
            {
                switch (filter.Aplicar_aFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Relaciones.Descripcion LIKE '" + filter.AdvanceAplicar_a + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Relaciones.Descripcion LIKE '%" + filter.AdvanceAplicar_a + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Relaciones.Descripcion = '" + filter.AdvanceAplicar_a + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Relaciones.Descripcion LIKE '%" + filter.AdvanceAplicar_a + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAplicar_aMultiple != null && filter.AdvanceAplicar_aMultiple.Count() > 0)
            {
                var Aplicar_aIds = string.Join(",", filter.AdvanceAplicar_aMultiple);

                where += " AND Medidas_de_Proteccion.Aplicar_a In (" + Aplicar_aIds + ")";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_Medidas_Proteccion(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_Medidas_ProteccionGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Medidas_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_Medidas_Proteccion.Medidas_de_Proteccion=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_Medidas_Proteccion.Medidas_de_Proteccion='" + RelationId + "'";
            }
            var result = _IDetalle_Medidas_ProteccionApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_Medidas_Proteccions == null)
                result.Detalle_Medidas_Proteccions = new List<Detalle_Medidas_Proteccion>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_Medidas_Proteccions.Select(m => new Detalle_Medidas_ProteccionGridModel
                {
                    Clave = m.Clave

			,Seleccionar = m.Seleccionar
                        ,Medida = m.Medida
                        ,MedidaDescripcion = CultureHelper.GetTraduction(m.Medida_Medida_de_Proteccion.Clave.ToString(), "Descripcion") ??(string)m.Medida_Medida_de_Proteccion.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_Medidas_ProteccionGridModel> GetDetalle_Medidas_ProteccionData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_Medidas_ProteccionGridModel> resultData = new List<Detalle_Medidas_ProteccionGridModel>();
            string where = "Detalle_Medidas_Proteccion.Medidas_de_Proteccion=" + Id;
            if("int" == "string")
            {
                where = "Detalle_Medidas_Proteccion.Medidas_de_Proteccion='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_Medidas_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_Medidas_ProteccionApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_Medidas_Proteccions != null)
            {
                resultData = result.Detalle_Medidas_Proteccions.Select(m => new Detalle_Medidas_ProteccionGridModel
                    {
                        Clave = m.Clave

			,Seleccionar = m.Seleccionar
                        ,Medida = m.Medida
                        ,MedidaDescripcion = CultureHelper.GetTraduction(m.Medida_Medida_de_Proteccion.Clave.ToString(), "Descripcion") ??(string)m.Medida_Medida_de_Proteccion.Descripcion


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
                _IMedidas_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);

                Medidas_de_Proteccion varMedidas_de_Proteccion = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_Medidas_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_Medidas_Proteccion.Medidas_de_Proteccion=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_Medidas_Proteccion.Medidas_de_Proteccion='" + id + "'";
                    }
                    var Detalle_Medidas_ProteccionInfo =
                        _IDetalle_Medidas_ProteccionApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_Medidas_ProteccionInfo.Detalle_Medidas_Proteccions.Count > 0)
                    {
                        var resultDetalle_Medidas_Proteccion = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_Medidas_ProteccionItem in Detalle_Medidas_ProteccionInfo.Detalle_Medidas_Proteccions)
                            resultDetalle_Medidas_Proteccion = resultDetalle_Medidas_Proteccion
                                              && _IDetalle_Medidas_ProteccionApiConsumer.Delete(Detalle_Medidas_ProteccionItem.Clave, null,null).Resource;

                        if (!resultDetalle_Medidas_Proteccion)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IMedidas_de_ProteccionApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Medidas_de_ProteccionModel varMedidas_de_Proteccion)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IMedidas_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Medidas_de_ProteccionInfo = new Medidas_de_Proteccion
                    {
                        Clave = varMedidas_de_Proteccion.Clave
                        ,Expediente_AT = varMedidas_de_Proteccion.Expediente_AT
                        ,Expediente_MASC = varMedidas_de_Proteccion.Expediente_MASC
                        ,Expediente_MP = varMedidas_de_Proteccion.Expediente_MP
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varMedidas_de_Proteccion.Fecha_de_Registro)) ? DateTime.ParseExact(varMedidas_de_Proteccion.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varMedidas_de_Proteccion.Hora_de_Registro
                        ,Usuario_que_Registra = varMedidas_de_Proteccion.Usuario_que_Registra
                        ,Orden_de_Proteccion = varMedidas_de_Proteccion.Orden_de_Proteccion
                        ,Tipo_de_Medida = varMedidas_de_Proteccion.Tipo_de_Medida
                        ,Sub_Tipo = varMedidas_de_Proteccion.Sub_Tipo
                        ,Fecha_de_Inicio = (!String.IsNullOrEmpty(varMedidas_de_Proteccion.Fecha_de_Inicio)) ? DateTime.ParseExact(varMedidas_de_Proteccion.Fecha_de_Inicio, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Inicio = varMedidas_de_Proteccion.Hora_de_Inicio
                        ,Fecha_de_Conclusion = (!String.IsNullOrEmpty(varMedidas_de_Proteccion.Fecha_de_Conclusion)) ? DateTime.ParseExact(varMedidas_de_Proteccion.Fecha_de_Conclusion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Conclusion = varMedidas_de_Proteccion.Hora_de_Conclusion
                        ,Duracion_en_Dias = varMedidas_de_Proteccion.Duracion_en_Dias
                        ,Aplicar_a = varMedidas_de_Proteccion.Aplicar_a

                    };

                    result = !IsNew ?
                        _IMedidas_de_ProteccionApiConsumer.Update(Medidas_de_ProteccionInfo, null, null).Resource.ToString() :
                         _IMedidas_de_ProteccionApiConsumer.Insert(Medidas_de_ProteccionInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_Medidas_Proteccion(int MasterId, int referenceId, List<Detalle_Medidas_ProteccionGridModelPost> Detalle_Medidas_ProteccionItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_Medidas_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_Medidas_ProteccionData = _IDetalle_Medidas_ProteccionApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_Medidas_Proteccion.Medidas_de_Proteccion=" + referenceId,"").Resource;
                if (Detalle_Medidas_ProteccionData == null || Detalle_Medidas_ProteccionData.Detalle_Medidas_Proteccions.Count == 0)
                    return true;

                var result = true;

                Detalle_Medidas_ProteccionGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_Medidas_Proteccion in Detalle_Medidas_ProteccionData.Detalle_Medidas_Proteccions)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_Medidas_Proteccion Detalle_Medidas_Proteccion1 = varDetalle_Medidas_Proteccion;

                    if (Detalle_Medidas_ProteccionItems != null && Detalle_Medidas_ProteccionItems.Any(m => m.Clave == Detalle_Medidas_Proteccion1.Clave))
                    {
                        modelDataToChange = Detalle_Medidas_ProteccionItems.FirstOrDefault(m => m.Clave == Detalle_Medidas_Proteccion1.Clave);
                    }
                    //Chaning Id Value
                    varDetalle_Medidas_Proteccion.Medidas_de_Proteccion = MasterId;
                    var insertId = _IDetalle_Medidas_ProteccionApiConsumer.Insert(varDetalle_Medidas_Proteccion,null,null).Resource;
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
        public ActionResult PostDetalle_Medidas_Proteccion(List<Detalle_Medidas_ProteccionGridModelPost> Detalle_Medidas_ProteccionItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_Medidas_Proteccion(MasterId, referenceId, Detalle_Medidas_ProteccionItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_Medidas_ProteccionItems != null && Detalle_Medidas_ProteccionItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_Medidas_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_Medidas_ProteccionItem in Detalle_Medidas_ProteccionItems)
                    {




                        //Removal Request
                        if (Detalle_Medidas_ProteccionItem.Removed)
                        {
                            result = result && _IDetalle_Medidas_ProteccionApiConsumer.Delete(Detalle_Medidas_ProteccionItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_Medidas_ProteccionItem.Clave = 0;

                        var Detalle_Medidas_ProteccionData = new Detalle_Medidas_Proteccion
                        {
                            Medidas_de_Proteccion = MasterId
                            ,Clave = Detalle_Medidas_ProteccionItem.Clave
                            ,Seleccionar = Detalle_Medidas_ProteccionItem.Seleccionar
                            ,Medida = (Convert.ToInt32(Detalle_Medidas_ProteccionItem.Medida) == 0 ? (Int32?)null : Convert.ToInt32(Detalle_Medidas_ProteccionItem.Medida))

                        };

                        var resultId = Detalle_Medidas_ProteccionItem.Clave > 0
                           ? _IDetalle_Medidas_ProteccionApiConsumer.Update(Detalle_Medidas_ProteccionData,null,null).Resource
                           : _IDetalle_Medidas_ProteccionApiConsumer.Insert(Detalle_Medidas_ProteccionData,null,null).Resource;

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
        public ActionResult GetDetalle_Medidas_Proteccion_Medida_de_ProteccionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMedida_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMedida_de_ProteccionApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Medida_de_Proteccion", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }



        /// <summary>
        /// Write Element Array of Medidas_de_Proteccion script
        /// </summary>
        /// <param name="oMedidas_de_ProteccionElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Medidas_de_ProteccionModuleAttributeList)
        {
            for (int i = 0; i < Medidas_de_ProteccionModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Medidas_de_ProteccionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Medidas_de_ProteccionModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Medidas_de_ProteccionModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Medidas_de_ProteccionModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Medidas_de_ProteccionModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Medidas_de_ProteccionModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Medidas_de_ProteccionModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Medidas_de_ProteccionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Medidas_de_ProteccionModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Medidas_de_ProteccionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Medidas_de_ProteccionModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strMedidas_de_ProteccionScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Medidas_de_Proteccion.js")))
            {
                strMedidas_de_ProteccionScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Medidas_de_Proteccion element attributes
            string userChangeJson = jsSerialize.Serialize(Medidas_de_ProteccionModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strMedidas_de_ProteccionScript.IndexOf("inpuElementArray");
            string splittedString = strMedidas_de_ProteccionScript.Substring(indexOfArray, strMedidas_de_ProteccionScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Medidas_de_ProteccionModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Medidas_de_ProteccionModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strMedidas_de_ProteccionScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strMedidas_de_ProteccionScript.Substring(indexOfArrayHistory, strMedidas_de_ProteccionScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strMedidas_de_ProteccionScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strMedidas_de_ProteccionScript.Substring(endIndexOfMainElement + indexOfArray, strMedidas_de_ProteccionScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Medidas_de_ProteccionModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Medidas_de_ProteccionModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Medidas_de_Proteccion.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Medidas_de_Proteccion.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Medidas_de_Proteccion.js")))
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
        public ActionResult Medidas_de_ProteccionPropertyBag()
        {
            return PartialView("Medidas_de_ProteccionPropertyBag", "Medidas_de_Proteccion");
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
        public ActionResult AddDetalle_Medidas_Proteccion(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_Medidas_Proteccion/AddDetalle_Medidas_Proteccion");
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
                var whereClauseFormat = "Object = 45624 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IMedidas_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Medidas_de_Proteccion.Clave= " + RecordId;
                            var result = _IMedidas_de_ProteccionApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IMedidas_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Medidas_de_ProteccionPropertyMapper());
			
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
                    (Medidas_de_ProteccionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Medidas_de_ProteccionPropertyMapper oMedidas_de_ProteccionPropertyMapper = new Medidas_de_ProteccionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oMedidas_de_ProteccionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IMedidas_de_ProteccionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Medidas_de_Proteccions == null)
                result.Medidas_de_Proteccions = new List<Medidas_de_Proteccion>();

            var data = result.Medidas_de_Proteccions.Select(m => new Medidas_de_ProteccionGridModel
            {
                Clave = m.Clave
                        ,Expediente_ATNUAT = CultureHelper.GetTraduction(m.Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_AT_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Orden_de_Proteccion = m.Orden_de_Proteccion
                        ,Tipo_de_MedidaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Medida_Tipo_de_Medida_de_Proteccion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Medida_Tipo_de_Medida_de_Proteccion.Descripcion
                        ,Sub_TipoDescripcion = CultureHelper.GetTraduction(m.Sub_Tipo_SubTipo_de_Medida_de_Proteccion.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Tipo_SubTipo_de_Medida_de_Proteccion.Descripcion
                        ,Fecha_de_Inicio = (m.Fecha_de_Inicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Inicio = m.Hora_de_Inicio
                        ,Fecha_de_Conclusion = (m.Fecha_de_Conclusion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Conclusion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Conclusion = m.Hora_de_Conclusion
			,Duracion_en_Dias = m.Duracion_en_Dias
                        ,Aplicar_aDescripcion = CultureHelper.GetTraduction(m.Aplicar_a_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Aplicar_a_Detalle_de_Relaciones.Descripcion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45624, arrayColumnsVisible), "Medidas_de_ProteccionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45624, arrayColumnsVisible), "Medidas_de_ProteccionList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45624, arrayColumnsVisible), "Medidas_de_ProteccionList_" + DateTime.Now.ToString());
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

            _IMedidas_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Medidas_de_ProteccionPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Medidas_de_ProteccionAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Medidas_de_ProteccionPropertyMapper oMedidas_de_ProteccionPropertyMapper = new Medidas_de_ProteccionPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oMedidas_de_ProteccionPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IMedidas_de_ProteccionApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Medidas_de_Proteccions == null)
                result.Medidas_de_Proteccions = new List<Medidas_de_Proteccion>();

            var data = result.Medidas_de_Proteccions.Select(m => new Medidas_de_ProteccionGridModel
            {
                Clave = m.Clave
                        ,Expediente_ATNUAT = CultureHelper.GetTraduction(m.Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_AT_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Orden_de_Proteccion = m.Orden_de_Proteccion
                        ,Tipo_de_MedidaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Medida_Tipo_de_Medida_de_Proteccion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Medida_Tipo_de_Medida_de_Proteccion.Descripcion
                        ,Sub_TipoDescripcion = CultureHelper.GetTraduction(m.Sub_Tipo_SubTipo_de_Medida_de_Proteccion.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Tipo_SubTipo_de_Medida_de_Proteccion.Descripcion
                        ,Fecha_de_Inicio = (m.Fecha_de_Inicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Inicio = m.Hora_de_Inicio
                        ,Fecha_de_Conclusion = (m.Fecha_de_Conclusion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Conclusion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Conclusion = m.Hora_de_Conclusion
			,Duracion_en_Dias = m.Duracion_en_Dias
                        ,Aplicar_aDescripcion = CultureHelper.GetTraduction(m.Aplicar_a_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Aplicar_a_Detalle_de_Relaciones.Descripcion

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
                _IMedidas_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMedidas_de_ProteccionApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Medidas_de_Proteccion_Datos_GeneralesModel varMedidas_de_Proteccion)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMedidas_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Medidas_de_Proteccion_Datos_GeneralesInfo = new Medidas_de_Proteccion_Datos_Generales
                {
                    Clave = varMedidas_de_Proteccion.Clave
                                            ,Expediente_AT = varMedidas_de_Proteccion.Expediente_AT
                        ,Expediente_MASC = varMedidas_de_Proteccion.Expediente_MASC
                        ,Expediente_MP = varMedidas_de_Proteccion.Expediente_MP
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varMedidas_de_Proteccion.Fecha_de_Registro)) ? DateTime.ParseExact(varMedidas_de_Proteccion.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varMedidas_de_Proteccion.Hora_de_Registro
                        ,Usuario_que_Registra = varMedidas_de_Proteccion.Usuario_que_Registra
                        ,Orden_de_Proteccion = varMedidas_de_Proteccion.Orden_de_Proteccion
                        ,Tipo_de_Medida = varMedidas_de_Proteccion.Tipo_de_Medida
                        ,Sub_Tipo = varMedidas_de_Proteccion.Sub_Tipo
                        ,Fecha_de_Inicio = (!String.IsNullOrEmpty(varMedidas_de_Proteccion.Fecha_de_Inicio)) ? DateTime.ParseExact(varMedidas_de_Proteccion.Fecha_de_Inicio, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Inicio = varMedidas_de_Proteccion.Hora_de_Inicio
                        ,Fecha_de_Conclusion = (!String.IsNullOrEmpty(varMedidas_de_Proteccion.Fecha_de_Conclusion)) ? DateTime.ParseExact(varMedidas_de_Proteccion.Fecha_de_Conclusion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Conclusion = varMedidas_de_Proteccion.Hora_de_Conclusion
                        ,Duracion_en_Dias = varMedidas_de_Proteccion.Duracion_en_Dias
                        ,Aplicar_a = varMedidas_de_Proteccion.Aplicar_a
                    
                };

                result = _IMedidas_de_ProteccionApiConsumer.Update_Datos_Generales(Medidas_de_Proteccion_Datos_GeneralesInfo).Resource.ToString();
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
                _IMedidas_de_ProteccionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IMedidas_de_ProteccionApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_Medidas_Proteccion;
                var Detalle_Medidas_ProteccionData = GetDetalle_Medidas_ProteccionData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_Medidas_Proteccion);

                var result = new Medidas_de_Proteccion_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Expediente_AT = m.Expediente_AT
                        ,Expediente_ATNUAT = CultureHelper.GetTraduction(m.Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Expediente_AT_Modulo_Atencion_Inicial.NUAT
                        ,Expediente_MASC = m.Expediente_MASC
                        ,Expediente_MASCNumero_de_Folio = CultureHelper.GetTraduction(m.Expediente_MASC_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Expediente_MASC_Solicitud.Numero_de_Folio
                        ,Expediente_MP = m.Expediente_MP
                        ,Expediente_MPnic = CultureHelper.GetTraduction(m.Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Expediente_MP_expediente_ministerio_publico.nic
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Orden_de_Proteccion = m.Orden_de_Proteccion
                        ,Tipo_de_Medida = m.Tipo_de_Medida
                        ,Tipo_de_MedidaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Medida_Tipo_de_Medida_de_Proteccion.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Medida_Tipo_de_Medida_de_Proteccion.Descripcion
                        ,Sub_Tipo = m.Sub_Tipo
                        ,Sub_TipoDescripcion = CultureHelper.GetTraduction(m.Sub_Tipo_SubTipo_de_Medida_de_Proteccion.Clave.ToString(), "Descripcion") ?? (string)m.Sub_Tipo_SubTipo_de_Medida_de_Proteccion.Descripcion
                        ,Fecha_de_Inicio = (m.Fecha_de_Inicio == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Inicio).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Inicio = m.Hora_de_Inicio
                        ,Fecha_de_Conclusion = (m.Fecha_de_Conclusion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Conclusion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Conclusion = m.Hora_de_Conclusion
			,Duracion_en_Dias = m.Duracion_en_Dias
                        ,Aplicar_a = m.Aplicar_a
                        ,Aplicar_aDescripcion = CultureHelper.GetTraduction(m.Aplicar_a_Detalle_de_Relaciones.Clave.ToString(), "Detalle_de_Relaciones") ?? (string)m.Aplicar_a_Detalle_de_Relaciones.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Medidas = Detalle_Medidas_ProteccionData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

