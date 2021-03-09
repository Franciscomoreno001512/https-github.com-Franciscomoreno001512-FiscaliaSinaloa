using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Region;
using Spartane.Core.Domain.Origen_de_Invitacion;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Documento;
using Spartane.Core.Domain.Estatus_de_Solicitud_de_Apoyo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Area_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.SubArea_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Asignacion_de_Apoyo;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Documento;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Resultado_de_Revision;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Solicitud_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Region;
using Spartane.Web.Areas.WebApiConsumer.Origen_de_Invitacion;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Documento;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Solicitud_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Area_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.SubArea_de_Servicios_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Asignacion_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Documento;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Resultado_de_Revision;

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
    public class Solicitud_de_Servicios_de_ApoyoController : Controller
    {
        #region "variable declaration"

        private ISolicitud_de_Servicios_de_ApoyoService service = null;
        private ISolicitud_de_Servicios_de_ApoyoApiConsumer _ISolicitud_de_Servicios_de_ApoyoApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private IRegionApiConsumer _IRegionApiConsumer;
        private IOrigen_de_InvitacionApiConsumer _IOrigen_de_InvitacionApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private IDocumentoApiConsumer _IDocumentoApiConsumer;
        private IEstatus_de_Solicitud_de_ApoyoApiConsumer _IEstatus_de_Solicitud_de_ApoyoApiConsumer;
        private IArea_de_Servicios_de_ApoyoApiConsumer _IArea_de_Servicios_de_ApoyoApiConsumer;
        private ISubArea_de_Servicios_de_ApoyoApiConsumer _ISubArea_de_Servicios_de_ApoyoApiConsumer;
        private ITipo_de_Asignacion_de_ApoyoApiConsumer _ITipo_de_Asignacion_de_ApoyoApiConsumer;
        private IResultado_de_RevisionApiConsumer _IResultado_de_RevisionApiConsumer;

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

        
        public Solicitud_de_Servicios_de_ApoyoController(ISolicitud_de_Servicios_de_ApoyoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ISolicitud_de_Servicios_de_ApoyoApiConsumer Solicitud_de_Servicios_de_ApoyoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IRegionApiConsumer RegionApiConsumer , IOrigen_de_InvitacionApiConsumer Origen_de_InvitacionApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , IDocumentoApiConsumer DocumentoApiConsumer , IEstatus_de_Solicitud_de_ApoyoApiConsumer Estatus_de_Solicitud_de_ApoyoApiConsumer , IArea_de_Servicios_de_ApoyoApiConsumer Area_de_Servicios_de_ApoyoApiConsumer , ISubArea_de_Servicios_de_ApoyoApiConsumer SubArea_de_Servicios_de_ApoyoApiConsumer , ITipo_de_Asignacion_de_ApoyoApiConsumer Tipo_de_Asignacion_de_ApoyoApiConsumer , IResultado_de_RevisionApiConsumer Resultado_de_RevisionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ISolicitud_de_Servicios_de_ApoyoApiConsumer = Solicitud_de_Servicios_de_ApoyoApiConsumer;
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
            this._IRegionApiConsumer = RegionApiConsumer;
            this._IOrigen_de_InvitacionApiConsumer = Origen_de_InvitacionApiConsumer;
            this._IModulo_Atencion_InicialApiConsumer = Modulo_Atencion_InicialApiConsumer;
            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
            this._IDocumentoApiConsumer = DocumentoApiConsumer;
            this._IEstatus_de_Solicitud_de_ApoyoApiConsumer = Estatus_de_Solicitud_de_ApoyoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IArea_de_Servicios_de_ApoyoApiConsumer = Area_de_Servicios_de_ApoyoApiConsumer;
            this._ISubArea_de_Servicios_de_ApoyoApiConsumer = SubArea_de_Servicios_de_ApoyoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ITipo_de_Asignacion_de_ApoyoApiConsumer = Tipo_de_Asignacion_de_ApoyoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IDocumentoApiConsumer = DocumentoApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
            this._IResultado_de_RevisionApiConsumer = Resultado_de_RevisionApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Solicitud_de_Servicios_de_Apoyo
        [ObjectAuth(ObjectId = (ModuleObjectId)45042, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45042, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Solicitud_de_Servicios_de_Apoyo/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45042, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45042, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varSolicitud_de_Servicios_de_Apoyo = new Solicitud_de_Servicios_de_ApoyoModel();
			varSolicitud_de_Servicios_de_Apoyo.Folio = Id;
			
            ViewBag.ObjectId = "45042";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Solicitud_de_Servicios_de_ApoyosData = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.ListaSelAll(0, 1000, "Solicitud_de_Servicios_de_Apoyo.Folio=" + Id, "").Resource.Solicitud_de_Servicios_de_Apoyos;
				
				if (Solicitud_de_Servicios_de_ApoyosData != null && Solicitud_de_Servicios_de_ApoyosData.Count > 0)
                {
					var Solicitud_de_Servicios_de_ApoyoData = Solicitud_de_Servicios_de_ApoyosData.First();
					varSolicitud_de_Servicios_de_Apoyo= new Solicitud_de_Servicios_de_ApoyoModel
					{
						Folio  = Solicitud_de_Servicios_de_ApoyoData.Folio 
	                    ,Fecha_de_Solicitud = (Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Solicitud = Solicitud_de_Servicios_de_ApoyoData.Hora_de_Solicitud
                    ,Usuario_que_Solicita = Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Solicita
                    ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Solicita), "Spartan_User") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Solicita_Spartan_User.Name
                    ,Region = Solicitud_de_Servicios_de_ApoyoData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Region), "Region") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Region_Region.Descripcion
                    ,Origen = Solicitud_de_Servicios_de_ApoyoData.Origen
                    ,OrigenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Origen), "Origen_de_Invitacion") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Origen_Origen_de_Invitacion.Descripcion
                    ,Numero_de_Expediente_AT = Solicitud_de_Servicios_de_ApoyoData.Numero_de_Expediente_AT
                    ,Numero_de_Expediente_ATNUAT = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Numero_de_Expediente_AT), "Modulo_Atencion_Inicial") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.NUAT
                    ,Numero_de_Expediente_MP = Solicitud_de_Servicios_de_ApoyoData.Numero_de_Expediente_MP
                    ,Numero_de_Expediente_MPnuat = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Numero_de_Expediente_MP), "expediente_ministerio_publico") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Numero_de_Expediente_MP_expediente_ministerio_publico.nuat
                    ,NUAT = Solicitud_de_Servicios_de_ApoyoData.NUAT
                    ,Numero_de_Denuncia = Solicitud_de_Servicios_de_ApoyoData.Numero_de_Denuncia
                    ,Carpeta_de_Investigacion = Solicitud_de_Servicios_de_ApoyoData.Carpeta_de_Investigacion
                    ,Numero_de_Oficio = Solicitud_de_Servicios_de_ApoyoData.Numero_de_Oficio
                    ,Solicitud = Solicitud_de_Servicios_de_ApoyoData.Solicitud
                    ,SolicitudDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Solicitud), "Documento") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Solicitud_Documento.Descripcion
                    ,Ver_Documento = Solicitud_de_Servicios_de_ApoyoData.Ver_Documento
                    ,Observaciones = Solicitud_de_Servicios_de_ApoyoData.Observaciones
                    ,Estatus = Solicitud_de_Servicios_de_ApoyoData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Estatus), "Estatus_de_Solicitud_de_Apoyo") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Estatus_Estatus_de_Solicitud_de_Apoyo.Descripcion
                    ,Fecha_de_Recepcion = (Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Recepcion = Solicitud_de_Servicios_de_ApoyoData.Hora_de_Recepcion
                    ,Usuario_que_Recibe = Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Recibe
                    ,Usuario_que_RecibeName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Recibe), "Spartan_User") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Recibe_Spartan_User.Name
                    ,Area_Asignada = Solicitud_de_Servicios_de_ApoyoData.Area_Asignada
                    ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Area_Asignada), "Area_de_Servicios_de_Apoyo") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                    ,SubArea_Asignada = Solicitud_de_Servicios_de_ApoyoData.SubArea_Asignada
                    ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.SubArea_Asignada), "SubArea_de_Servicios_de_Apoyo") ??  (string)Solicitud_de_Servicios_de_ApoyoData.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
                    ,Observaciones_Recepcion = Solicitud_de_Servicios_de_ApoyoData.Observaciones_Recepcion
                    ,Fecha_de_Asignacion = (Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Asignacion = Solicitud_de_Servicios_de_ApoyoData.Hora_de_Asignacion
                    ,Usuario_que_Asigna = Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Asigna
                    ,Usuario_que_AsignaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Asigna), "Spartan_User") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Asigna_Spartan_User.Name
                    ,Tipo_de_Asignacion = Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Asignacion
                    ,Tipo_de_AsignacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Asignacion), "Tipo_de_Asignacion_de_Apoyo") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Descripcion
                    ,Responsable_Asignado = Solicitud_de_Servicios_de_ApoyoData.Responsable_Asignado
                    ,Responsable_AsignadoName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Responsable_Asignado), "Spartan_User") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Responsable_Asignado_Spartan_User.Name
                    ,Observaciones_Asignacion = Solicitud_de_Servicios_de_ApoyoData.Observaciones_Asignacion
                    ,Fecha_de_Contestacion = (Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Contestacion = Solicitud_de_Servicios_de_ApoyoData.Hora_de_Contestacion
                    ,Usuario_que_contesta = Solicitud_de_Servicios_de_ApoyoData.Usuario_que_contesta
                    ,Usuario_que_contestaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Usuario_que_contesta), "Spartan_User") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Usuario_que_contesta_Spartan_User.Name
                    ,Dictamen = Solicitud_de_Servicios_de_ApoyoData.Dictamen
                    ,DictamenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Dictamen), "Documento") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Dictamen_Documento.Descripcion
                    ,Enviar_Contestacion = Solicitud_de_Servicios_de_ApoyoData.Enviar_Contestacion.GetValueOrDefault()
                    ,Archivo = Solicitud_de_Servicios_de_ApoyoData.Archivo
                    ,Observaciones_Contestacion = Solicitud_de_Servicios_de_ApoyoData.Observaciones_Contestacion
                    ,Fecha_de_Revision = (Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Revision = Solicitud_de_Servicios_de_ApoyoData.Hora_de_Revision
                    ,Usuario_que_Revisa = Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Revisa
                    ,Usuario_que_RevisaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Revisa), "Spartan_User") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Revisa_Spartan_User.Name
                    ,Resultado_de_Autorizacion = Solicitud_de_Servicios_de_ApoyoData.Resultado_de_Autorizacion
                    ,Resultado_de_AutorizacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Resultado_de_Autorizacion), "Resultado_de_Revision") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Resultado_de_Autorizacion_Resultado_de_Revision.Descripcion
                    ,Motivo_de_Rechazo = Solicitud_de_Servicios_de_ApoyoData.Motivo_de_Rechazo
                    ,Observaciones_Autorizacion = Solicitud_de_Servicios_de_ApoyoData.Observaciones_Autorizacion

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Ver_DocumentoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varSolicitud_de_Servicios_de_Apoyo.Ver_Documento).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Solicitud_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Solicitud_de_Apoyos_Estatus = _IEstatus_de_Solicitud_de_ApoyoApiConsumer.SelAll(true);
            if (Estatus_de_Solicitud_de_Apoyos_Estatus != null && Estatus_de_Solicitud_de_Apoyos_Estatus.Resource != null)
                ViewBag.Estatus_de_Solicitud_de_Apoyos_Estatus = Estatus_de_Solicitud_de_Apoyos_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Solicitud_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_Asignada = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_Asignada != null && Area_de_Servicios_de_Apoyos_Area_Asignada.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_Asignada = Area_de_Servicios_de_Apoyos_Area_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea_Asignada != null && SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Asignacion_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion = _ITipo_de_Asignacion_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion != null && Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion.Resource != null)
                ViewBag.Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion = Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Asignacion_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado_de_Autorizacion = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado_de_Autorizacion != null && Resultado_de_Revisions_Resultado_de_Autorizacion.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado_de_Autorizacion = Resultado_de_Revisions_Resultado_de_Autorizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varSolicitud_de_Servicios_de_Apoyo);
        }
		
	[HttpGet]
        public ActionResult AddSolicitud_de_Servicios_de_Apoyo(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45042);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Solicitud_de_Servicios_de_ApoyoModel varSolicitud_de_Servicios_de_Apoyo= new Solicitud_de_Servicios_de_ApoyoModel();


            if (id.ToString() != "0")
            {
                var Solicitud_de_Servicios_de_ApoyosData = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.ListaSelAll(0, 1000, "Solicitud_de_Servicios_de_Apoyo.Folio=" + id, "").Resource.Solicitud_de_Servicios_de_Apoyos;
				
				if (Solicitud_de_Servicios_de_ApoyosData != null && Solicitud_de_Servicios_de_ApoyosData.Count > 0)
                {
					var Solicitud_de_Servicios_de_ApoyoData = Solicitud_de_Servicios_de_ApoyosData.First();
					varSolicitud_de_Servicios_de_Apoyo= new Solicitud_de_Servicios_de_ApoyoModel
					{
						Folio  = Solicitud_de_Servicios_de_ApoyoData.Folio 
	                    ,Fecha_de_Solicitud = (Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Solicitud = Solicitud_de_Servicios_de_ApoyoData.Hora_de_Solicitud
                    ,Usuario_que_Solicita = Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Solicita
                    ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Solicita), "Spartan_User") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Solicita_Spartan_User.Name
                    ,Region = Solicitud_de_Servicios_de_ApoyoData.Region
                    ,RegionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Region), "Region") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Region_Region.Descripcion
                    ,Origen = Solicitud_de_Servicios_de_ApoyoData.Origen
                    ,OrigenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Origen), "Origen_de_Invitacion") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Origen_Origen_de_Invitacion.Descripcion
                    ,Numero_de_Expediente_AT = Solicitud_de_Servicios_de_ApoyoData.Numero_de_Expediente_AT
                    ,Numero_de_Expediente_ATNUAT = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Numero_de_Expediente_AT), "Modulo_Atencion_Inicial") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.NUAT
                    ,Numero_de_Expediente_MP = Solicitud_de_Servicios_de_ApoyoData.Numero_de_Expediente_MP
                    ,Numero_de_Expediente_MPnuat = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Numero_de_Expediente_MP), "expediente_ministerio_publico") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Numero_de_Expediente_MP_expediente_ministerio_publico.nuat
                    ,NUAT = Solicitud_de_Servicios_de_ApoyoData.NUAT
                    ,Numero_de_Denuncia = Solicitud_de_Servicios_de_ApoyoData.Numero_de_Denuncia
                    ,Carpeta_de_Investigacion = Solicitud_de_Servicios_de_ApoyoData.Carpeta_de_Investigacion
                    ,Numero_de_Oficio = Solicitud_de_Servicios_de_ApoyoData.Numero_de_Oficio
                    ,Solicitud = Solicitud_de_Servicios_de_ApoyoData.Solicitud
                    ,SolicitudDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Solicitud), "Documento") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Solicitud_Documento.Descripcion
                    ,Ver_Documento = Solicitud_de_Servicios_de_ApoyoData.Ver_Documento
                    ,Observaciones = Solicitud_de_Servicios_de_ApoyoData.Observaciones
                    ,Estatus = Solicitud_de_Servicios_de_ApoyoData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Estatus), "Estatus_de_Solicitud_de_Apoyo") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Estatus_Estatus_de_Solicitud_de_Apoyo.Descripcion
                    ,Fecha_de_Recepcion = (Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Recepcion = Solicitud_de_Servicios_de_ApoyoData.Hora_de_Recepcion
                    ,Usuario_que_Recibe = Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Recibe
                    ,Usuario_que_RecibeName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Recibe), "Spartan_User") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Recibe_Spartan_User.Name
                    ,Area_Asignada = Solicitud_de_Servicios_de_ApoyoData.Area_Asignada
                    ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Area_Asignada), "Area_de_Servicios_de_Apoyo") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                    ,SubArea_Asignada = Solicitud_de_Servicios_de_ApoyoData.SubArea_Asignada
                    ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.SubArea_Asignada), "SubArea_de_Servicios_de_Apoyo") ??  (string)Solicitud_de_Servicios_de_ApoyoData.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
                    ,Observaciones_Recepcion = Solicitud_de_Servicios_de_ApoyoData.Observaciones_Recepcion
                    ,Fecha_de_Asignacion = (Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Asignacion = Solicitud_de_Servicios_de_ApoyoData.Hora_de_Asignacion
                    ,Usuario_que_Asigna = Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Asigna
                    ,Usuario_que_AsignaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Asigna), "Spartan_User") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Asigna_Spartan_User.Name
                    ,Tipo_de_Asignacion = Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Asignacion
                    ,Tipo_de_AsignacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Asignacion), "Tipo_de_Asignacion_de_Apoyo") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Descripcion
                    ,Responsable_Asignado = Solicitud_de_Servicios_de_ApoyoData.Responsable_Asignado
                    ,Responsable_AsignadoName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Responsable_Asignado), "Spartan_User") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Responsable_Asignado_Spartan_User.Name
                    ,Observaciones_Asignacion = Solicitud_de_Servicios_de_ApoyoData.Observaciones_Asignacion
                    ,Fecha_de_Contestacion = (Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Contestacion = Solicitud_de_Servicios_de_ApoyoData.Hora_de_Contestacion
                    ,Usuario_que_contesta = Solicitud_de_Servicios_de_ApoyoData.Usuario_que_contesta
                    ,Usuario_que_contestaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Usuario_que_contesta), "Spartan_User") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Usuario_que_contesta_Spartan_User.Name
                    ,Dictamen = Solicitud_de_Servicios_de_ApoyoData.Dictamen
                    ,DictamenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Dictamen), "Documento") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Dictamen_Documento.Descripcion
                    ,Enviar_Contestacion = Solicitud_de_Servicios_de_ApoyoData.Enviar_Contestacion.GetValueOrDefault()
                    ,Archivo = Solicitud_de_Servicios_de_ApoyoData.Archivo
                    ,Observaciones_Contestacion = Solicitud_de_Servicios_de_ApoyoData.Observaciones_Contestacion
                    ,Fecha_de_Revision = (Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Revision = Solicitud_de_Servicios_de_ApoyoData.Hora_de_Revision
                    ,Usuario_que_Revisa = Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Revisa
                    ,Usuario_que_RevisaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Revisa), "Spartan_User") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Revisa_Spartan_User.Name
                    ,Resultado_de_Autorizacion = Solicitud_de_Servicios_de_ApoyoData.Resultado_de_Autorizacion
                    ,Resultado_de_AutorizacionDescripcion = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Resultado_de_Autorizacion), "Resultado_de_Revision") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Resultado_de_Autorizacion_Resultado_de_Revision.Descripcion
                    ,Motivo_de_Rechazo = Solicitud_de_Servicios_de_ApoyoData.Motivo_de_Rechazo
                    ,Observaciones_Autorizacion = Solicitud_de_Servicios_de_ApoyoData.Observaciones_Autorizacion

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Ver_DocumentoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varSolicitud_de_Servicios_de_Apoyo.Ver_Documento).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Solicitud_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Solicitud_de_Apoyos_Estatus = _IEstatus_de_Solicitud_de_ApoyoApiConsumer.SelAll(true);
            if (Estatus_de_Solicitud_de_Apoyos_Estatus != null && Estatus_de_Solicitud_de_Apoyos_Estatus.Resource != null)
                ViewBag.Estatus_de_Solicitud_de_Apoyos_Estatus = Estatus_de_Solicitud_de_Apoyos_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Solicitud_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_Asignada = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_Asignada != null && Area_de_Servicios_de_Apoyos_Area_Asignada.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_Asignada = Area_de_Servicios_de_Apoyos_Area_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea_Asignada != null && SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Asignacion_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion = _ITipo_de_Asignacion_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion != null && Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion.Resource != null)
                ViewBag.Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion = Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Asignacion_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado_de_Autorizacion = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado_de_Autorizacion != null && Resultado_de_Revisions_Resultado_de_Autorizacion.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado_de_Autorizacion = Resultado_de_Revisions_Resultado_de_Autorizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddSolicitud_de_Servicios_de_Apoyo", varSolicitud_de_Servicios_de_Apoyo);
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
        public ActionResult Getexpediente_ministerio_publicoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _Iexpediente_ministerio_publicoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.nuat).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "expediente_ministerio_publico", "nuat")?? m.nuat,
                    Value = Convert.ToString(m.clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetDocumentoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDocumentoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetEstatus_de_Solicitud_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_Solicitud_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_Solicitud_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Solicitud_de_Apoyo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetArea_de_Servicios_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetSubArea_de_Servicios_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_Asignacion_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Asignacion_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Asignacion_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Asignacion_de_Apoyo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetResultado_de_RevisionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IResultado_de_RevisionApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Solicitud_de_Servicios_de_ApoyoAdvanceSearchModel model, int idFilter = -1)
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

            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Solicitud_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Solicitud_de_Apoyos_Estatus = _IEstatus_de_Solicitud_de_ApoyoApiConsumer.SelAll(true);
            if (Estatus_de_Solicitud_de_Apoyos_Estatus != null && Estatus_de_Solicitud_de_Apoyos_Estatus.Resource != null)
                ViewBag.Estatus_de_Solicitud_de_Apoyos_Estatus = Estatus_de_Solicitud_de_Apoyos_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Solicitud_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_Asignada = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_Asignada != null && Area_de_Servicios_de_Apoyos_Area_Asignada.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_Asignada = Area_de_Servicios_de_Apoyos_Area_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea_Asignada != null && SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Asignacion_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion = _ITipo_de_Asignacion_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion != null && Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion.Resource != null)
                ViewBag.Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion = Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Asignacion_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado_de_Autorizacion = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado_de_Autorizacion != null && Resultado_de_Revisions_Resultado_de_Autorizacion.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado_de_Autorizacion = Resultado_de_Revisions_Resultado_de_Autorizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IRegionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Regions_Region = _IRegionApiConsumer.SelAll(true);
            if (Regions_Region != null && Regions_Region.Resource != null)
                ViewBag.Regions_Region = Regions_Region.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Region", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Solicitud_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Solicitud_de_Apoyos_Estatus = _IEstatus_de_Solicitud_de_ApoyoApiConsumer.SelAll(true);
            if (Estatus_de_Solicitud_de_Apoyos_Estatus != null && Estatus_de_Solicitud_de_Apoyos_Estatus.Resource != null)
                ViewBag.Estatus_de_Solicitud_de_Apoyos_Estatus = Estatus_de_Solicitud_de_Apoyos_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Solicitud_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_de_Servicios_de_Apoyos_Area_Asignada = _IArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (Area_de_Servicios_de_Apoyos_Area_Asignada != null && Area_de_Servicios_de_Apoyos_Area_Asignada.Resource != null)
                ViewBag.Area_de_Servicios_de_Apoyos_Area_Asignada = Area_de_Servicios_de_Apoyos_Area_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISubArea_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = _ISubArea_de_Servicios_de_ApoyoApiConsumer.SelAll(true);
            if (SubArea_de_Servicios_de_Apoyos_SubArea_Asignada != null && SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource != null)
                ViewBag.SubArea_de_Servicios_de_Apoyos_SubArea_Asignada = SubArea_de_Servicios_de_Apoyos_SubArea_Asignada.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "SubArea_de_Servicios_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Asignacion_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion = _ITipo_de_Asignacion_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion != null && Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion.Resource != null)
                ViewBag.Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion = Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Asignacion_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IResultado_de_RevisionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Resultado_de_Revisions_Resultado_de_Autorizacion = _IResultado_de_RevisionApiConsumer.SelAll(true);
            if (Resultado_de_Revisions_Resultado_de_Autorizacion != null && Resultado_de_Revisions_Resultado_de_Autorizacion.Resource != null)
                ViewBag.Resultado_de_Revisions_Resultado_de_Autorizacion = Resultado_de_Revisions_Resultado_de_Autorizacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Resultado_de_Revision", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Solicitud_de_Servicios_de_ApoyoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Solicitud_de_Servicios_de_ApoyoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Solicitud_de_Servicios_de_ApoyoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Solicitud_de_Servicios_de_ApoyoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Servicios_de_Apoyos == null)
                result.Solicitud_de_Servicios_de_Apoyos = new List<Solicitud_de_Servicios_de_Apoyo>();

            return Json(new
            {
                data = result.Solicitud_de_Servicios_de_Apoyos.Select(m => new Solicitud_de_Servicios_de_ApoyoGridModel
                    {
                    Folio = m.Folio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Solicitud = m.Hora_de_Solicitud
                        ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(m.Usuario_que_Solicita_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Solicita_Spartan_User.Name
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Numero_de_Expediente_ATNUAT = CultureHelper.GetTraduction(m.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.NUAT
                        ,Numero_de_Expediente_MPnuat = CultureHelper.GetTraduction(m.Numero_de_Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Numero_de_Expediente_MP_expediente_ministerio_publico.nuat
			,NUAT = m.NUAT
			,Numero_de_Denuncia = m.Numero_de_Denuncia
			,Carpeta_de_Investigacion = m.Carpeta_de_Investigacion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,SolicitudDescripcion = CultureHelper.GetTraduction(m.Solicitud_Documento.Clave.ToString(), "Documento") ?? (string)m.Solicitud_Documento.Descripcion
			,Ver_Documento = m.Ver_Documento
			,Observaciones = m.Observaciones
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Solicitud_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Solicitud_de_Apoyo.Descripcion
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Recepcion = m.Hora_de_Recepcion
                        ,Usuario_que_RecibeName = CultureHelper.GetTraduction(m.Usuario_que_Recibe_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Recibe_Spartan_User.Name
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
			,Observaciones_Recepcion = m.Observaciones_Recepcion
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Usuario_que_AsignaName = CultureHelper.GetTraduction(m.Usuario_que_Asigna_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Asigna_Spartan_User.Name
                        ,Tipo_de_AsignacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Descripcion
                        ,Responsable_AsignadoName = CultureHelper.GetTraduction(m.Responsable_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_Asignado_Spartan_User.Name
			,Observaciones_Asignacion = m.Observaciones_Asignacion
                        ,Fecha_de_Contestacion = (m.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Contestacion = m.Hora_de_Contestacion
                        ,Usuario_que_contestaName = CultureHelper.GetTraduction(m.Usuario_que_contesta_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_contesta_Spartan_User.Name
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Documento.Descripcion
			,Enviar_Contestacion = m.Enviar_Contestacion
			,Archivo = m.Archivo
			,Observaciones_Contestacion = m.Observaciones_Contestacion
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,Resultado_de_AutorizacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Autorizacion_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Autorizacion_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo = m.Motivo_de_Rechazo
			,Observaciones_Autorizacion = m.Observaciones_Autorizacion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetSolicitud_de_Servicios_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Folio), "Solicitud_de_Servicios_de_Apoyo", m.),
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
        /// Get List of Solicitud_de_Servicios_de_Apoyo from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Solicitud_de_Servicios_de_Apoyo Entity</returns>
        public ActionResult GetSolicitud_de_Servicios_de_ApoyoList(UrlParametersModel param)
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
            _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Solicitud_de_Servicios_de_ApoyoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Solicitud_de_Servicios_de_ApoyoAdvanceSearchModel))
                {
					var advanceFilter =
                    (Solicitud_de_Servicios_de_ApoyoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Solicitud_de_Servicios_de_ApoyoPropertyMapper oSolicitud_de_Servicios_de_ApoyoPropertyMapper = new Solicitud_de_Servicios_de_ApoyoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oSolicitud_de_Servicios_de_ApoyoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Servicios_de_Apoyos == null)
                result.Solicitud_de_Servicios_de_Apoyos = new List<Solicitud_de_Servicios_de_Apoyo>();

            return Json(new
            {
                aaData = result.Solicitud_de_Servicios_de_Apoyos.Select(m => new Solicitud_de_Servicios_de_ApoyoGridModel
            {
                    Folio = m.Folio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Solicitud = m.Hora_de_Solicitud
                        ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(m.Usuario_que_Solicita_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Solicita_Spartan_User.Name
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Numero_de_Expediente_ATNUAT = CultureHelper.GetTraduction(m.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.NUAT
                        ,Numero_de_Expediente_MPnuat = CultureHelper.GetTraduction(m.Numero_de_Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Numero_de_Expediente_MP_expediente_ministerio_publico.nuat
			,NUAT = m.NUAT
			,Numero_de_Denuncia = m.Numero_de_Denuncia
			,Carpeta_de_Investigacion = m.Carpeta_de_Investigacion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,SolicitudDescripcion = CultureHelper.GetTraduction(m.Solicitud_Documento.Clave.ToString(), "Documento") ?? (string)m.Solicitud_Documento.Descripcion
			,Ver_Documento = m.Ver_Documento
			,Observaciones = m.Observaciones
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Solicitud_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Solicitud_de_Apoyo.Descripcion
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Recepcion = m.Hora_de_Recepcion
                        ,Usuario_que_RecibeName = CultureHelper.GetTraduction(m.Usuario_que_Recibe_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Recibe_Spartan_User.Name
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
			,Observaciones_Recepcion = m.Observaciones_Recepcion
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Usuario_que_AsignaName = CultureHelper.GetTraduction(m.Usuario_que_Asigna_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Asigna_Spartan_User.Name
                        ,Tipo_de_AsignacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Descripcion
                        ,Responsable_AsignadoName = CultureHelper.GetTraduction(m.Responsable_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_Asignado_Spartan_User.Name
			,Observaciones_Asignacion = m.Observaciones_Asignacion
                        ,Fecha_de_Contestacion = (m.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Contestacion = m.Hora_de_Contestacion
                        ,Usuario_que_contestaName = CultureHelper.GetTraduction(m.Usuario_que_contesta_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_contesta_Spartan_User.Name
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Documento.Descripcion
			,Enviar_Contestacion = m.Enviar_Contestacion
			,Archivo = m.Archivo
			,Observaciones_Contestacion = m.Observaciones_Contestacion
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,Resultado_de_AutorizacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Autorizacion_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Autorizacion_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo = m.Motivo_de_Rechazo
			,Observaciones_Autorizacion = m.Observaciones_Autorizacion

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetSolicitud_de_Servicios_de_Apoyo_Usuario_que_Solicita_Spartan_User(string query, string where)
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
        public JsonResult GetSolicitud_de_Servicios_de_Apoyo_Numero_de_Expediente_AT_Modulo_Atencion_Inicial(string query, string where)
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
        public JsonResult GetSolicitud_de_Servicios_de_Apoyo_Numero_de_Expediente_MP_expediente_ministerio_publico(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(expediente_ministerio_publico.clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(expediente_ministerio_publico.nuat as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _Iexpediente_ministerio_publicoApiConsumer.ListaSelAll(1, 20,elWhere , " expediente_ministerio_publico.nuat ASC ").Resource;
               
                foreach (var item in result.expediente_ministerio_publicos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.clave), "expediente_ministerio_publico", "nuat");
                    item.nuat =trans ??item.nuat;
                }
                return Json(result.expediente_ministerio_publicos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetSolicitud_de_Servicios_de_Apoyo_Solicitud_Documento(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Documento.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Documento.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDocumentoApiConsumer.ListaSelAll(1, 20,elWhere , " Documento.Descripcion ASC ").Resource;
               
                foreach (var item in result.Documentos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Documento", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Documentos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetSolicitud_de_Servicios_de_Apoyo_Usuario_que_Recibe_Spartan_User(string query, string where)
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
        public JsonResult GetSolicitud_de_Servicios_de_Apoyo_Usuario_que_Asigna_Spartan_User(string query, string where)
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
        public JsonResult GetSolicitud_de_Servicios_de_Apoyo_Responsable_Asignado_Spartan_User(string query, string where)
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
        public JsonResult GetSolicitud_de_Servicios_de_Apoyo_Usuario_que_contesta_Spartan_User(string query, string where)
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
        public JsonResult GetSolicitud_de_Servicios_de_Apoyo_Dictamen_Documento(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Documento.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Documento.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDocumentoApiConsumer.ListaSelAll(1, 20,elWhere , " Documento.Descripcion ASC ").Resource;
               
                foreach (var item in result.Documentos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Documento", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Documentos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetSolicitud_de_Servicios_de_Apoyo_Usuario_que_Revisa_Spartan_User(string query, string where)
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
        public string GetAdvanceFilter(Solicitud_de_Servicios_de_ApoyoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromFolio) || !string.IsNullOrEmpty(filter.ToFolio))
            {
                if (!string.IsNullOrEmpty(filter.FromFolio))
                    where += " AND Solicitud_de_Servicios_de_Apoyo.Folio >= " + filter.FromFolio;
                if (!string.IsNullOrEmpty(filter.ToFolio))
                    where += " AND Solicitud_de_Servicios_de_Apoyo.Folio <= " + filter.ToFolio;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Solicitud) || !string.IsNullOrEmpty(filter.ToFecha_de_Solicitud))
            {
                var Fecha_de_SolicitudFrom = DateTime.ParseExact(filter.FromFecha_de_Solicitud, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_SolicitudTo = DateTime.ParseExact(filter.ToFecha_de_Solicitud, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Solicitud))
                    where += " AND Solicitud_de_Servicios_de_Apoyo.Fecha_de_Solicitud >= '" + Fecha_de_SolicitudFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Solicitud))
                    where += " AND Solicitud_de_Servicios_de_Apoyo.Fecha_de_Solicitud <= '" + Fecha_de_SolicitudTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Solicitud) || !string.IsNullOrEmpty(filter.ToHora_de_Solicitud))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Solicitud))
                    where += " AND Convert(TIME,Solicitud_de_Servicios_de_Apoyo.Hora_de_Solicitud) >='" + filter.FromHora_de_Solicitud + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Solicitud))
                    where += " AND Convert(TIME,Solicitud_de_Servicios_de_Apoyo.Hora_de_Solicitud) <='" + filter.ToHora_de_Solicitud + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Solicita))
            {
                switch (filter.Usuario_que_SolicitaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Solicita + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Solicita + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Solicita + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Solicita + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_SolicitaMultiple != null && filter.AdvanceUsuario_que_SolicitaMultiple.Count() > 0)
            {
                var Usuario_que_SolicitaIds = string.Join(",", filter.AdvanceUsuario_que_SolicitaMultiple);

                where += " AND Solicitud_de_Servicios_de_Apoyo.Usuario_que_Solicita In (" + Usuario_que_SolicitaIds + ")";
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

                where += " AND Solicitud_de_Servicios_de_Apoyo.Region In (" + RegionIds + ")";
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

                where += " AND Solicitud_de_Servicios_de_Apoyo.Origen In (" + OrigenIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNumero_de_Expediente_AT))
            {
                switch (filter.Numero_de_Expediente_ATFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '" + filter.AdvanceNumero_de_Expediente_AT + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceNumero_de_Expediente_AT + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.NUAT = '" + filter.AdvanceNumero_de_Expediente_AT + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceNumero_de_Expediente_AT + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNumero_de_Expediente_ATMultiple != null && filter.AdvanceNumero_de_Expediente_ATMultiple.Count() > 0)
            {
                var Numero_de_Expediente_ATIds = string.Join(",", filter.AdvanceNumero_de_Expediente_ATMultiple);

                where += " AND Solicitud_de_Servicios_de_Apoyo.Numero_de_Expediente_AT In (" + Numero_de_Expediente_ATIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceNumero_de_Expediente_MP))
            {
                switch (filter.Numero_de_Expediente_MPFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND expediente_ministerio_publico.nuat LIKE '" + filter.AdvanceNumero_de_Expediente_MP + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND expediente_ministerio_publico.nuat LIKE '%" + filter.AdvanceNumero_de_Expediente_MP + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND expediente_ministerio_publico.nuat = '" + filter.AdvanceNumero_de_Expediente_MP + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND expediente_ministerio_publico.nuat LIKE '%" + filter.AdvanceNumero_de_Expediente_MP + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNumero_de_Expediente_MPMultiple != null && filter.AdvanceNumero_de_Expediente_MPMultiple.Count() > 0)
            {
                var Numero_de_Expediente_MPIds = string.Join(",", filter.AdvanceNumero_de_Expediente_MPMultiple);

                where += " AND Solicitud_de_Servicios_de_Apoyo.Numero_de_Expediente_MP In (" + Numero_de_Expediente_MPIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.NUAT))
            {
                switch (filter.NUATFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.NUAT LIKE '" + filter.NUAT + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.NUAT LIKE '%" + filter.NUAT + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.NUAT = '" + filter.NUAT + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.NUAT LIKE '%" + filter.NUAT + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Denuncia))
            {
                switch (filter.Numero_de_DenunciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Numero_de_Denuncia LIKE '" + filter.Numero_de_Denuncia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Numero_de_Denuncia LIKE '%" + filter.Numero_de_Denuncia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Numero_de_Denuncia = '" + filter.Numero_de_Denuncia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Numero_de_Denuncia LIKE '%" + filter.Numero_de_Denuncia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Carpeta_de_Investigacion))
            {
                switch (filter.Carpeta_de_InvestigacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Carpeta_de_Investigacion LIKE '" + filter.Carpeta_de_Investigacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Carpeta_de_Investigacion LIKE '%" + filter.Carpeta_de_Investigacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Carpeta_de_Investigacion = '" + filter.Carpeta_de_Investigacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Carpeta_de_Investigacion LIKE '%" + filter.Carpeta_de_Investigacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Oficio))
            {
                switch (filter.Numero_de_OficioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Numero_de_Oficio LIKE '" + filter.Numero_de_Oficio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Numero_de_Oficio LIKE '%" + filter.Numero_de_Oficio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Numero_de_Oficio = '" + filter.Numero_de_Oficio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Numero_de_Oficio LIKE '%" + filter.Numero_de_Oficio + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSolicitud))
            {
                switch (filter.SolicitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Documento.Descripcion LIKE '" + filter.AdvanceSolicitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Documento.Descripcion LIKE '%" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Documento.Descripcion = '" + filter.AdvanceSolicitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Documento.Descripcion LIKE '%" + filter.AdvanceSolicitud + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSolicitudMultiple != null && filter.AdvanceSolicitudMultiple.Count() > 0)
            {
                var SolicitudIds = string.Join(",", filter.AdvanceSolicitudMultiple);

                where += " AND Solicitud_de_Servicios_de_Apoyo.Solicitud In (" + SolicitudIds + ")";
            }

            if (filter.Ver_Documento != RadioOptions.NoApply)
                where += " AND Solicitud_de_Servicios_de_Apoyo.Ver_Documento " + (filter.Ver_Documento == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones LIKE '%" + filter.Observaciones + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_de_Solicitud_de_Apoyo.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_de_Solicitud_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_de_Solicitud_de_Apoyo.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_de_Solicitud_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Solicitud_de_Servicios_de_Apoyo.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Recepcion) || !string.IsNullOrEmpty(filter.ToFecha_de_Recepcion))
            {
                var Fecha_de_RecepcionFrom = DateTime.ParseExact(filter.FromFecha_de_Recepcion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RecepcionTo = DateTime.ParseExact(filter.ToFecha_de_Recepcion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Recepcion))
                    where += " AND Solicitud_de_Servicios_de_Apoyo.Fecha_de_Recepcion >= '" + Fecha_de_RecepcionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Recepcion))
                    where += " AND Solicitud_de_Servicios_de_Apoyo.Fecha_de_Recepcion <= '" + Fecha_de_RecepcionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Recepcion) || !string.IsNullOrEmpty(filter.ToHora_de_Recepcion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Recepcion))
                    where += " AND Convert(TIME,Solicitud_de_Servicios_de_Apoyo.Hora_de_Recepcion) >='" + filter.FromHora_de_Recepcion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Recepcion))
                    where += " AND Convert(TIME,Solicitud_de_Servicios_de_Apoyo.Hora_de_Recepcion) <='" + filter.ToHora_de_Recepcion + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_Recibe))
            {
                switch (filter.Usuario_que_RecibeFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_Recibe + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Recibe + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_Recibe + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_Recibe + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_RecibeMultiple != null && filter.AdvanceUsuario_que_RecibeMultiple.Count() > 0)
            {
                var Usuario_que_RecibeIds = string.Join(",", filter.AdvanceUsuario_que_RecibeMultiple);

                where += " AND Solicitud_de_Servicios_de_Apoyo.Usuario_que_Recibe In (" + Usuario_que_RecibeIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceArea_Asignada))
            {
                switch (filter.Area_AsignadaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '" + filter.AdvanceArea_Asignada + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceArea_Asignada + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion = '" + filter.AdvanceArea_Asignada + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Area_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceArea_Asignada + "%'";
                        break;
                }
            }
            else if (filter.AdvanceArea_AsignadaMultiple != null && filter.AdvanceArea_AsignadaMultiple.Count() > 0)
            {
                var Area_AsignadaIds = string.Join(",", filter.AdvanceArea_AsignadaMultiple);

                where += " AND Solicitud_de_Servicios_de_Apoyo.Area_Asignada In (" + Area_AsignadaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceSubArea_Asignada))
            {
                switch (filter.SubArea_AsignadaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion LIKE '" + filter.AdvanceSubArea_Asignada + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceSubArea_Asignada + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion = '" + filter.AdvanceSubArea_Asignada + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND SubArea_de_Servicios_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceSubArea_Asignada + "%'";
                        break;
                }
            }
            else if (filter.AdvanceSubArea_AsignadaMultiple != null && filter.AdvanceSubArea_AsignadaMultiple.Count() > 0)
            {
                var SubArea_AsignadaIds = string.Join(",", filter.AdvanceSubArea_AsignadaMultiple);

                where += " AND Solicitud_de_Servicios_de_Apoyo.SubArea_Asignada In (" + SubArea_AsignadaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_Recepcion))
            {
                switch (filter.Observaciones_RecepcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Recepcion LIKE '" + filter.Observaciones_Recepcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Recepcion LIKE '%" + filter.Observaciones_Recepcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Recepcion = '" + filter.Observaciones_Recepcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Recepcion LIKE '%" + filter.Observaciones_Recepcion + "%'";
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
                    where += " AND Solicitud_de_Servicios_de_Apoyo.Fecha_de_Asignacion >= '" + Fecha_de_AsignacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Asignacion))
                    where += " AND Solicitud_de_Servicios_de_Apoyo.Fecha_de_Asignacion <= '" + Fecha_de_AsignacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Asignacion) || !string.IsNullOrEmpty(filter.ToHora_de_Asignacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Asignacion))
                    where += " AND Convert(TIME,Solicitud_de_Servicios_de_Apoyo.Hora_de_Asignacion) >='" + filter.FromHora_de_Asignacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Asignacion))
                    where += " AND Convert(TIME,Solicitud_de_Servicios_de_Apoyo.Hora_de_Asignacion) <='" + filter.ToHora_de_Asignacion + "'";
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

                where += " AND Solicitud_de_Servicios_de_Apoyo.Usuario_que_Asigna In (" + Usuario_que_AsignaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Asignacion))
            {
                switch (filter.Tipo_de_AsignacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Asignacion_de_Apoyo.Descripcion LIKE '" + filter.AdvanceTipo_de_Asignacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Asignacion_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Asignacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Asignacion_de_Apoyo.Descripcion = '" + filter.AdvanceTipo_de_Asignacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Asignacion_de_Apoyo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Asignacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_AsignacionMultiple != null && filter.AdvanceTipo_de_AsignacionMultiple.Count() > 0)
            {
                var Tipo_de_AsignacionIds = string.Join(",", filter.AdvanceTipo_de_AsignacionMultiple);

                where += " AND Solicitud_de_Servicios_de_Apoyo.Tipo_de_Asignacion In (" + Tipo_de_AsignacionIds + ")";
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

                where += " AND Solicitud_de_Servicios_de_Apoyo.Responsable_Asignado In (" + Responsable_AsignadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_Asignacion))
            {
                switch (filter.Observaciones_AsignacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Asignacion LIKE '" + filter.Observaciones_Asignacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Asignacion LIKE '%" + filter.Observaciones_Asignacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Asignacion = '" + filter.Observaciones_Asignacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Asignacion LIKE '%" + filter.Observaciones_Asignacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Contestacion) || !string.IsNullOrEmpty(filter.ToFecha_de_Contestacion))
            {
                var Fecha_de_ContestacionFrom = DateTime.ParseExact(filter.FromFecha_de_Contestacion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_ContestacionTo = DateTime.ParseExact(filter.ToFecha_de_Contestacion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Contestacion))
                    where += " AND Solicitud_de_Servicios_de_Apoyo.Fecha_de_Contestacion >= '" + Fecha_de_ContestacionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Contestacion))
                    where += " AND Solicitud_de_Servicios_de_Apoyo.Fecha_de_Contestacion <= '" + Fecha_de_ContestacionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Contestacion) || !string.IsNullOrEmpty(filter.ToHora_de_Contestacion))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Contestacion))
                    where += " AND Convert(TIME,Solicitud_de_Servicios_de_Apoyo.Hora_de_Contestacion) >='" + filter.FromHora_de_Contestacion + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Contestacion))
                    where += " AND Convert(TIME,Solicitud_de_Servicios_de_Apoyo.Hora_de_Contestacion) <='" + filter.ToHora_de_Contestacion + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceUsuario_que_contesta))
            {
                switch (filter.Usuario_que_contestaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvanceUsuario_que_contesta + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_contesta + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvanceUsuario_que_contesta + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvanceUsuario_que_contesta + "%'";
                        break;
                }
            }
            else if (filter.AdvanceUsuario_que_contestaMultiple != null && filter.AdvanceUsuario_que_contestaMultiple.Count() > 0)
            {
                var Usuario_que_contestaIds = string.Join(",", filter.AdvanceUsuario_que_contestaMultiple);

                where += " AND Solicitud_de_Servicios_de_Apoyo.Usuario_que_contesta In (" + Usuario_que_contestaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDictamen))
            {
                switch (filter.DictamenFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Documento.Descripcion LIKE '" + filter.AdvanceDictamen + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Documento.Descripcion LIKE '%" + filter.AdvanceDictamen + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Documento.Descripcion = '" + filter.AdvanceDictamen + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Documento.Descripcion LIKE '%" + filter.AdvanceDictamen + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDictamenMultiple != null && filter.AdvanceDictamenMultiple.Count() > 0)
            {
                var DictamenIds = string.Join(",", filter.AdvanceDictamenMultiple);

                where += " AND Solicitud_de_Servicios_de_Apoyo.Dictamen In (" + DictamenIds + ")";
            }

            if (filter.Enviar_Contestacion != RadioOptions.NoApply)
                where += " AND Solicitud_de_Servicios_de_Apoyo.Enviar_Contestacion = " + Convert.ToInt32(filter.Enviar_Contestacion);

            if (!string.IsNullOrEmpty(filter.FromArchivo) || !string.IsNullOrEmpty(filter.ToArchivo))
            {
                if (!string.IsNullOrEmpty(filter.FromArchivo))
                    where += " AND Solicitud_de_Servicios_de_Apoyo.Archivo >= " + filter.FromArchivo;
                if (!string.IsNullOrEmpty(filter.ToArchivo))
                    where += " AND Solicitud_de_Servicios_de_Apoyo.Archivo <= " + filter.ToArchivo;
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_Contestacion))
            {
                switch (filter.Observaciones_ContestacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Contestacion LIKE '" + filter.Observaciones_Contestacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Contestacion LIKE '%" + filter.Observaciones_Contestacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Contestacion = '" + filter.Observaciones_Contestacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Contestacion LIKE '%" + filter.Observaciones_Contestacion + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Revision) || !string.IsNullOrEmpty(filter.ToFecha_de_Revision))
            {
                var Fecha_de_RevisionFrom = DateTime.ParseExact(filter.FromFecha_de_Revision, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RevisionTo = DateTime.ParseExact(filter.ToFecha_de_Revision, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Revision))
                    where += " AND Solicitud_de_Servicios_de_Apoyo.Fecha_de_Revision >= '" + Fecha_de_RevisionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Revision))
                    where += " AND Solicitud_de_Servicios_de_Apoyo.Fecha_de_Revision <= '" + Fecha_de_RevisionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Revision) || !string.IsNullOrEmpty(filter.ToHora_de_Revision))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Revision))
                    where += " AND Convert(TIME,Solicitud_de_Servicios_de_Apoyo.Hora_de_Revision) >='" + filter.FromHora_de_Revision + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Revision))
                    where += " AND Convert(TIME,Solicitud_de_Servicios_de_Apoyo.Hora_de_Revision) <='" + filter.ToHora_de_Revision + "'";
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

                where += " AND Solicitud_de_Servicios_de_Apoyo.Usuario_que_Revisa In (" + Usuario_que_RevisaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceResultado_de_Autorizacion))
            {
                switch (filter.Resultado_de_AutorizacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Resultado_de_Revision.Descripcion LIKE '" + filter.AdvanceResultado_de_Autorizacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Resultado_de_Revision.Descripcion LIKE '%" + filter.AdvanceResultado_de_Autorizacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Resultado_de_Revision.Descripcion = '" + filter.AdvanceResultado_de_Autorizacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Resultado_de_Revision.Descripcion LIKE '%" + filter.AdvanceResultado_de_Autorizacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceResultado_de_AutorizacionMultiple != null && filter.AdvanceResultado_de_AutorizacionMultiple.Count() > 0)
            {
                var Resultado_de_AutorizacionIds = string.Join(",", filter.AdvanceResultado_de_AutorizacionMultiple);

                where += " AND Solicitud_de_Servicios_de_Apoyo.Resultado_de_Autorizacion In (" + Resultado_de_AutorizacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Motivo_de_Rechazo))
            {
                switch (filter.Motivo_de_RechazoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Motivo_de_Rechazo LIKE '" + filter.Motivo_de_Rechazo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Motivo_de_Rechazo LIKE '%" + filter.Motivo_de_Rechazo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Motivo_de_Rechazo = '" + filter.Motivo_de_Rechazo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Motivo_de_Rechazo LIKE '%" + filter.Motivo_de_Rechazo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Observaciones_Autorizacion))
            {
                switch (filter.Observaciones_AutorizacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Autorizacion LIKE '" + filter.Observaciones_Autorizacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Autorizacion LIKE '%" + filter.Observaciones_Autorizacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Autorizacion = '" + filter.Observaciones_Autorizacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Solicitud_de_Servicios_de_Apoyo.Observaciones_Autorizacion LIKE '%" + filter.Observaciones_Autorizacion + "%'";
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
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Solicitud_de_Servicios_de_Apoyo varSolicitud_de_Servicios_de_Apoyo = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Solicitud_de_Servicios_de_ApoyoModel varSolicitud_de_Servicios_de_Apoyo)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varSolicitud_de_Servicios_de_Apoyo.Ver_DocumentoRemoveAttachment != 0 && varSolicitud_de_Servicios_de_Apoyo.Ver_DocumentoFile == null)
                    {
                        varSolicitud_de_Servicios_de_Apoyo.Ver_Documento = 0;
                    }

                    if (varSolicitud_de_Servicios_de_Apoyo.Ver_DocumentoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varSolicitud_de_Servicios_de_Apoyo.Ver_DocumentoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varSolicitud_de_Servicios_de_Apoyo.Ver_Documento = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varSolicitud_de_Servicios_de_Apoyo.Ver_DocumentoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Solicitud_de_Servicios_de_ApoyoInfo = new Solicitud_de_Servicios_de_Apoyo
                    {
                        Folio = varSolicitud_de_Servicios_de_Apoyo.Folio
                        ,Fecha_de_Solicitud = (!String.IsNullOrEmpty(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Solicitud)) ? DateTime.ParseExact(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Solicitud = varSolicitud_de_Servicios_de_Apoyo.Hora_de_Solicitud
                        ,Usuario_que_Solicita = varSolicitud_de_Servicios_de_Apoyo.Usuario_que_Solicita
                        ,Region = varSolicitud_de_Servicios_de_Apoyo.Region
                        ,Origen = varSolicitud_de_Servicios_de_Apoyo.Origen
                        ,Numero_de_Expediente_AT = varSolicitud_de_Servicios_de_Apoyo.Numero_de_Expediente_AT
                        ,Numero_de_Expediente_MP = varSolicitud_de_Servicios_de_Apoyo.Numero_de_Expediente_MP
                        ,NUAT = varSolicitud_de_Servicios_de_Apoyo.NUAT
                        ,Numero_de_Denuncia = varSolicitud_de_Servicios_de_Apoyo.Numero_de_Denuncia
                        ,Carpeta_de_Investigacion = varSolicitud_de_Servicios_de_Apoyo.Carpeta_de_Investigacion
                        ,Numero_de_Oficio = varSolicitud_de_Servicios_de_Apoyo.Numero_de_Oficio
                        ,Solicitud = varSolicitud_de_Servicios_de_Apoyo.Solicitud
                        ,Ver_Documento = (varSolicitud_de_Servicios_de_Apoyo.Ver_Documento.HasValue && varSolicitud_de_Servicios_de_Apoyo.Ver_Documento != 0) ? ((int?)Convert.ToInt32(varSolicitud_de_Servicios_de_Apoyo.Ver_Documento.Value)) : null

                        ,Observaciones = varSolicitud_de_Servicios_de_Apoyo.Observaciones
                        ,Estatus = varSolicitud_de_Servicios_de_Apoyo.Estatus
                        ,Fecha_de_Recepcion = (!String.IsNullOrEmpty(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Recepcion)) ? DateTime.ParseExact(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Recepcion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Recepcion = varSolicitud_de_Servicios_de_Apoyo.Hora_de_Recepcion
                        ,Usuario_que_Recibe = varSolicitud_de_Servicios_de_Apoyo.Usuario_que_Recibe
                        ,Area_Asignada = varSolicitud_de_Servicios_de_Apoyo.Area_Asignada
                        ,SubArea_Asignada = varSolicitud_de_Servicios_de_Apoyo.SubArea_Asignada
                        ,Observaciones_Recepcion = varSolicitud_de_Servicios_de_Apoyo.Observaciones_Recepcion
                        ,Fecha_de_Asignacion = (!String.IsNullOrEmpty(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Asignacion)) ? DateTime.ParseExact(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Asignacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Asignacion = varSolicitud_de_Servicios_de_Apoyo.Hora_de_Asignacion
                        ,Usuario_que_Asigna = varSolicitud_de_Servicios_de_Apoyo.Usuario_que_Asigna
                        ,Tipo_de_Asignacion = varSolicitud_de_Servicios_de_Apoyo.Tipo_de_Asignacion
                        ,Responsable_Asignado = varSolicitud_de_Servicios_de_Apoyo.Responsable_Asignado
                        ,Observaciones_Asignacion = varSolicitud_de_Servicios_de_Apoyo.Observaciones_Asignacion
                        ,Fecha_de_Contestacion = (!String.IsNullOrEmpty(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Contestacion)) ? DateTime.ParseExact(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Contestacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Contestacion = varSolicitud_de_Servicios_de_Apoyo.Hora_de_Contestacion
                        ,Usuario_que_contesta = varSolicitud_de_Servicios_de_Apoyo.Usuario_que_contesta
                        ,Dictamen = varSolicitud_de_Servicios_de_Apoyo.Dictamen
                        ,Enviar_Contestacion = varSolicitud_de_Servicios_de_Apoyo.Enviar_Contestacion
                        ,Archivo = varSolicitud_de_Servicios_de_Apoyo.Archivo
                        ,Observaciones_Contestacion = varSolicitud_de_Servicios_de_Apoyo.Observaciones_Contestacion
                        ,Fecha_de_Revision = (!String.IsNullOrEmpty(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Revision)) ? DateTime.ParseExact(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Revision, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Revision = varSolicitud_de_Servicios_de_Apoyo.Hora_de_Revision
                        ,Usuario_que_Revisa = varSolicitud_de_Servicios_de_Apoyo.Usuario_que_Revisa
                        ,Resultado_de_Autorizacion = varSolicitud_de_Servicios_de_Apoyo.Resultado_de_Autorizacion
                        ,Motivo_de_Rechazo = varSolicitud_de_Servicios_de_Apoyo.Motivo_de_Rechazo
                        ,Observaciones_Autorizacion = varSolicitud_de_Servicios_de_Apoyo.Observaciones_Autorizacion

                    };

                    result = !IsNew ?
                        _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Update(Solicitud_de_Servicios_de_ApoyoInfo, null, null).Resource.ToString() :
                         _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Insert(Solicitud_de_Servicios_de_ApoyoInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Solicitud_de_Servicios_de_Apoyo script
        /// </summary>
        /// <param name="oSolicitud_de_Servicios_de_ApoyoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Solicitud_de_Servicios_de_ApoyoModuleAttributeList)
        {
            for (int i = 0; i < Solicitud_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Solicitud_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Solicitud_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Solicitud_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Solicitud_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strSolicitud_de_Servicios_de_ApoyoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Servicios_de_Apoyo.js")))
            {
                strSolicitud_de_Servicios_de_ApoyoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Solicitud_de_Servicios_de_Apoyo element attributes
            string userChangeJson = jsSerialize.Serialize(Solicitud_de_Servicios_de_ApoyoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strSolicitud_de_Servicios_de_ApoyoScript.IndexOf("inpuElementArray");
            string splittedString = strSolicitud_de_Servicios_de_ApoyoScript.Substring(indexOfArray, strSolicitud_de_Servicios_de_ApoyoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strSolicitud_de_Servicios_de_ApoyoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strSolicitud_de_Servicios_de_ApoyoScript.Substring(indexOfArrayHistory, strSolicitud_de_Servicios_de_ApoyoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strSolicitud_de_Servicios_de_ApoyoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strSolicitud_de_Servicios_de_ApoyoScript.Substring(endIndexOfMainElement + indexOfArray, strSolicitud_de_Servicios_de_ApoyoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Servicios_de_Apoyo.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Servicios_de_Apoyo.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Solicitud_de_Servicios_de_Apoyo.js")))
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
        public ActionResult Solicitud_de_Servicios_de_ApoyoPropertyBag()
        {
            return PartialView("Solicitud_de_Servicios_de_ApoyoPropertyBag", "Solicitud_de_Servicios_de_Apoyo");
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
                var whereClauseFormat = "Object = 45042 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Solicitud_de_Servicios_de_Apoyo.Folio= " + RecordId;
                            var result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Solicitud_de_Servicios_de_ApoyoPropertyMapper());
			
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
                    (Solicitud_de_Servicios_de_ApoyoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Solicitud_de_Servicios_de_ApoyoPropertyMapper oSolicitud_de_Servicios_de_ApoyoPropertyMapper = new Solicitud_de_Servicios_de_ApoyoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oSolicitud_de_Servicios_de_ApoyoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Servicios_de_Apoyos == null)
                result.Solicitud_de_Servicios_de_Apoyos = new List<Solicitud_de_Servicios_de_Apoyo>();

            var data = result.Solicitud_de_Servicios_de_Apoyos.Select(m => new Solicitud_de_Servicios_de_ApoyoGridModel
            {
                Folio = m.Folio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Solicitud = m.Hora_de_Solicitud
                        ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(m.Usuario_que_Solicita_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Solicita_Spartan_User.Name
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Numero_de_Expediente_ATNUAT = CultureHelper.GetTraduction(m.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.NUAT
                        ,Numero_de_Expediente_MPnuat = CultureHelper.GetTraduction(m.Numero_de_Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Numero_de_Expediente_MP_expediente_ministerio_publico.nuat
			,NUAT = m.NUAT
			,Numero_de_Denuncia = m.Numero_de_Denuncia
			,Carpeta_de_Investigacion = m.Carpeta_de_Investigacion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,SolicitudDescripcion = CultureHelper.GetTraduction(m.Solicitud_Documento.Clave.ToString(), "Documento") ?? (string)m.Solicitud_Documento.Descripcion
			,Ver_Documento = m.Ver_Documento
			,Observaciones = m.Observaciones
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Solicitud_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Solicitud_de_Apoyo.Descripcion
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Recepcion = m.Hora_de_Recepcion
                        ,Usuario_que_RecibeName = CultureHelper.GetTraduction(m.Usuario_que_Recibe_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Recibe_Spartan_User.Name
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
			,Observaciones_Recepcion = m.Observaciones_Recepcion
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Usuario_que_AsignaName = CultureHelper.GetTraduction(m.Usuario_que_Asigna_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Asigna_Spartan_User.Name
                        ,Tipo_de_AsignacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Descripcion
                        ,Responsable_AsignadoName = CultureHelper.GetTraduction(m.Responsable_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_Asignado_Spartan_User.Name
			,Observaciones_Asignacion = m.Observaciones_Asignacion
                        ,Fecha_de_Contestacion = (m.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Contestacion = m.Hora_de_Contestacion
                        ,Usuario_que_contestaName = CultureHelper.GetTraduction(m.Usuario_que_contesta_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_contesta_Spartan_User.Name
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Documento.Descripcion
			,Enviar_Contestacion = m.Enviar_Contestacion
			,Archivo = m.Archivo
			,Observaciones_Contestacion = m.Observaciones_Contestacion
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,Resultado_de_AutorizacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Autorizacion_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Autorizacion_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo = m.Motivo_de_Rechazo
			,Observaciones_Autorizacion = m.Observaciones_Autorizacion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45042, arrayColumnsVisible), "Solicitud_de_Servicios_de_ApoyoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45042, arrayColumnsVisible), "Solicitud_de_Servicios_de_ApoyoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45042, arrayColumnsVisible), "Solicitud_de_Servicios_de_ApoyoList_" + DateTime.Now.ToString());
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

            _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Solicitud_de_Servicios_de_ApoyoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Solicitud_de_Servicios_de_ApoyoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Solicitud_de_Servicios_de_ApoyoPropertyMapper oSolicitud_de_Servicios_de_ApoyoPropertyMapper = new Solicitud_de_Servicios_de_ApoyoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oSolicitud_de_Servicios_de_ApoyoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Servicios_de_Apoyos == null)
                result.Solicitud_de_Servicios_de_Apoyos = new List<Solicitud_de_Servicios_de_Apoyo>();

            var data = result.Solicitud_de_Servicios_de_Apoyos.Select(m => new Solicitud_de_Servicios_de_ApoyoGridModel
            {
                Folio = m.Folio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Solicitud = m.Hora_de_Solicitud
                        ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(m.Usuario_que_Solicita_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Solicita_Spartan_User.Name
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Numero_de_Expediente_ATNUAT = CultureHelper.GetTraduction(m.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.NUAT
                        ,Numero_de_Expediente_MPnuat = CultureHelper.GetTraduction(m.Numero_de_Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Numero_de_Expediente_MP_expediente_ministerio_publico.nuat
			,NUAT = m.NUAT
			,Numero_de_Denuncia = m.Numero_de_Denuncia
			,Carpeta_de_Investigacion = m.Carpeta_de_Investigacion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,SolicitudDescripcion = CultureHelper.GetTraduction(m.Solicitud_Documento.Clave.ToString(), "Documento") ?? (string)m.Solicitud_Documento.Descripcion
			,Ver_Documento = m.Ver_Documento
			,Observaciones = m.Observaciones
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Solicitud_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Solicitud_de_Apoyo.Descripcion
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Recepcion = m.Hora_de_Recepcion
                        ,Usuario_que_RecibeName = CultureHelper.GetTraduction(m.Usuario_que_Recibe_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Recibe_Spartan_User.Name
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
			,Observaciones_Recepcion = m.Observaciones_Recepcion
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Usuario_que_AsignaName = CultureHelper.GetTraduction(m.Usuario_que_Asigna_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Asigna_Spartan_User.Name
                        ,Tipo_de_AsignacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Descripcion
                        ,Responsable_AsignadoName = CultureHelper.GetTraduction(m.Responsable_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_Asignado_Spartan_User.Name
			,Observaciones_Asignacion = m.Observaciones_Asignacion
                        ,Fecha_de_Contestacion = (m.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Contestacion = m.Hora_de_Contestacion
                        ,Usuario_que_contestaName = CultureHelper.GetTraduction(m.Usuario_que_contesta_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_contesta_Spartan_User.Name
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Documento.Descripcion
			,Enviar_Contestacion = m.Enviar_Contestacion
			,Archivo = m.Archivo
			,Observaciones_Contestacion = m.Observaciones_Contestacion
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,Resultado_de_AutorizacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Autorizacion_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Autorizacion_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo = m.Motivo_de_Rechazo
			,Observaciones_Autorizacion = m.Observaciones_Autorizacion

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
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Solicitud_de_Servicios_de_Apoyo_Datos_GeneralesModel varSolicitud_de_Servicios_de_Apoyo)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varSolicitud_de_Servicios_de_Apoyo.Ver_DocumentoRemoveAttachment != 0 && varSolicitud_de_Servicios_de_Apoyo.Ver_DocumentoFile == null)
                    {
                        varSolicitud_de_Servicios_de_Apoyo.Ver_Documento = 0;
                    }

                    if (varSolicitud_de_Servicios_de_Apoyo.Ver_DocumentoFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varSolicitud_de_Servicios_de_Apoyo.Ver_DocumentoFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varSolicitud_de_Servicios_de_Apoyo.Ver_Documento = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varSolicitud_de_Servicios_de_Apoyo.Ver_DocumentoFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Solicitud_de_Servicios_de_Apoyo_Datos_GeneralesInfo = new Solicitud_de_Servicios_de_Apoyo_Datos_Generales
                {
                    Folio = varSolicitud_de_Servicios_de_Apoyo.Folio
                                            ,Fecha_de_Solicitud = (!String.IsNullOrEmpty(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Solicitud)) ? DateTime.ParseExact(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Solicitud = varSolicitud_de_Servicios_de_Apoyo.Hora_de_Solicitud
                        ,Usuario_que_Solicita = varSolicitud_de_Servicios_de_Apoyo.Usuario_que_Solicita
                        ,Region = varSolicitud_de_Servicios_de_Apoyo.Region
                        ,Origen = varSolicitud_de_Servicios_de_Apoyo.Origen
                        ,Numero_de_Expediente_AT = varSolicitud_de_Servicios_de_Apoyo.Numero_de_Expediente_AT
                        ,Numero_de_Expediente_MP = varSolicitud_de_Servicios_de_Apoyo.Numero_de_Expediente_MP
                        ,NUAT = varSolicitud_de_Servicios_de_Apoyo.NUAT
                        ,Numero_de_Denuncia = varSolicitud_de_Servicios_de_Apoyo.Numero_de_Denuncia
                        ,Carpeta_de_Investigacion = varSolicitud_de_Servicios_de_Apoyo.Carpeta_de_Investigacion
                        ,Numero_de_Oficio = varSolicitud_de_Servicios_de_Apoyo.Numero_de_Oficio
                        ,Solicitud = varSolicitud_de_Servicios_de_Apoyo.Solicitud
                        ,Ver_Documento = (varSolicitud_de_Servicios_de_Apoyo.Ver_Documento.HasValue && varSolicitud_de_Servicios_de_Apoyo.Ver_Documento != 0) ? ((int?)Convert.ToInt32(varSolicitud_de_Servicios_de_Apoyo.Ver_Documento.Value)) : null

                        ,Observaciones = varSolicitud_de_Servicios_de_Apoyo.Observaciones
                        ,Estatus = varSolicitud_de_Servicios_de_Apoyo.Estatus
                    
                };

                result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Update_Datos_Generales(Solicitud_de_Servicios_de_Apoyo_Datos_GeneralesInfo).Resource.ToString();
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
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Solicitud_de_Servicios_de_Apoyo_Datos_GeneralesModel
                {
                    Folio = m.Folio
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Solicitud = m.Hora_de_Solicitud
                        ,Usuario_que_Solicita = m.Usuario_que_Solicita
                        ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(m.Usuario_que_Solicita_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Solicita_Spartan_User.Name
                        ,Region = m.Region
                        ,RegionDescripcion = CultureHelper.GetTraduction(m.Region_Region.Clave.ToString(), "Descripcion") ?? (string)m.Region_Region.Descripcion
                        ,Origen = m.Origen
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Numero_de_Expediente_AT = m.Numero_de_Expediente_AT
                        ,Numero_de_Expediente_ATNUAT = CultureHelper.GetTraduction(m.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.NUAT
                        ,Numero_de_Expediente_MP = m.Numero_de_Expediente_MP
                        ,Numero_de_Expediente_MPnuat = CultureHelper.GetTraduction(m.Numero_de_Expediente_MP_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Numero_de_Expediente_MP_expediente_ministerio_publico.nuat
			,NUAT = m.NUAT
			,Numero_de_Denuncia = m.Numero_de_Denuncia
			,Carpeta_de_Investigacion = m.Carpeta_de_Investigacion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,Solicitud = m.Solicitud
                        ,SolicitudDescripcion = CultureHelper.GetTraduction(m.Solicitud_Documento.Clave.ToString(), "Documento") ?? (string)m.Solicitud_Documento.Descripcion
			,Ver_Documento = m.Ver_Documento
			,Observaciones = m.Observaciones
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Solicitud_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Solicitud_de_Apoyo.Descripcion

                    
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
        public ActionResult Post_Recepcion(Solicitud_de_Servicios_de_Apoyo_RecepcionModel varSolicitud_de_Servicios_de_Apoyo)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_de_Servicios_de_Apoyo_RecepcionInfo = new Solicitud_de_Servicios_de_Apoyo_Recepcion
                {
                    Folio = varSolicitud_de_Servicios_de_Apoyo.Folio
                                            ,Fecha_de_Recepcion = (!String.IsNullOrEmpty(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Recepcion)) ? DateTime.ParseExact(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Recepcion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Recepcion = varSolicitud_de_Servicios_de_Apoyo.Hora_de_Recepcion
                        ,Usuario_que_Recibe = varSolicitud_de_Servicios_de_Apoyo.Usuario_que_Recibe
                        ,Area_Asignada = varSolicitud_de_Servicios_de_Apoyo.Area_Asignada
                        ,SubArea_Asignada = varSolicitud_de_Servicios_de_Apoyo.SubArea_Asignada
                        ,Observaciones_Recepcion = varSolicitud_de_Servicios_de_Apoyo.Observaciones_Recepcion
                    
                };

                result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Update_Recepcion(Solicitud_de_Servicios_de_Apoyo_RecepcionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Recepcion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Get_Recepcion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Solicitud_de_Servicios_de_Apoyo_RecepcionModel
                {
                    Folio = m.Folio
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Recepcion = m.Hora_de_Recepcion
                        ,Usuario_que_Recibe = m.Usuario_que_Recibe
                        ,Usuario_que_RecibeName = CultureHelper.GetTraduction(m.Usuario_que_Recibe_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Recibe_Spartan_User.Name
                        ,Area_Asignada = m.Area_Asignada
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_Asignada = m.SubArea_Asignada
                        ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
			,Observaciones_Recepcion = m.Observaciones_Recepcion

                    
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
        public ActionResult Post_Asignacion(Solicitud_de_Servicios_de_Apoyo_AsignacionModel varSolicitud_de_Servicios_de_Apoyo)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_de_Servicios_de_Apoyo_AsignacionInfo = new Solicitud_de_Servicios_de_Apoyo_Asignacion
                {
                    Folio = varSolicitud_de_Servicios_de_Apoyo.Folio
                                            ,Fecha_de_Asignacion = (!String.IsNullOrEmpty(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Asignacion)) ? DateTime.ParseExact(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Asignacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Asignacion = varSolicitud_de_Servicios_de_Apoyo.Hora_de_Asignacion
                        ,Usuario_que_Asigna = varSolicitud_de_Servicios_de_Apoyo.Usuario_que_Asigna
                        ,Tipo_de_Asignacion = varSolicitud_de_Servicios_de_Apoyo.Tipo_de_Asignacion
                        ,Responsable_Asignado = varSolicitud_de_Servicios_de_Apoyo.Responsable_Asignado
                        ,Observaciones_Asignacion = varSolicitud_de_Servicios_de_Apoyo.Observaciones_Asignacion
                    
                };

                result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Update_Asignacion(Solicitud_de_Servicios_de_Apoyo_AsignacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Asignacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Get_Asignacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Solicitud_de_Servicios_de_Apoyo_AsignacionModel
                {
                    Folio = m.Folio
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Usuario_que_Asigna = m.Usuario_que_Asigna
                        ,Usuario_que_AsignaName = CultureHelper.GetTraduction(m.Usuario_que_Asigna_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Asigna_Spartan_User.Name
                        ,Tipo_de_Asignacion = m.Tipo_de_Asignacion
                        ,Tipo_de_AsignacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Descripcion
                        ,Responsable_Asignado = m.Responsable_Asignado
                        ,Responsable_AsignadoName = CultureHelper.GetTraduction(m.Responsable_Asignado_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Responsable_Asignado_Spartan_User.Name
			,Observaciones_Asignacion = m.Observaciones_Asignacion

                    
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
        public ActionResult Post_Contestacion(Solicitud_de_Servicios_de_Apoyo_ContestacionModel varSolicitud_de_Servicios_de_Apoyo)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_de_Servicios_de_Apoyo_ContestacionInfo = new Solicitud_de_Servicios_de_Apoyo_Contestacion
                {
                    Folio = varSolicitud_de_Servicios_de_Apoyo.Folio
                                            ,Fecha_de_Contestacion = (!String.IsNullOrEmpty(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Contestacion)) ? DateTime.ParseExact(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Contestacion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Contestacion = varSolicitud_de_Servicios_de_Apoyo.Hora_de_Contestacion
                        ,Usuario_que_contesta = varSolicitud_de_Servicios_de_Apoyo.Usuario_que_contesta
                        ,Dictamen = varSolicitud_de_Servicios_de_Apoyo.Dictamen
                        ,Enviar_Contestacion = varSolicitud_de_Servicios_de_Apoyo.Enviar_Contestacion
                        ,Archivo = varSolicitud_de_Servicios_de_Apoyo.Archivo
                        ,Observaciones_Contestacion = varSolicitud_de_Servicios_de_Apoyo.Observaciones_Contestacion
                    
                };

                result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Update_Contestacion(Solicitud_de_Servicios_de_Apoyo_ContestacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Contestacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Get_Contestacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Solicitud_de_Servicios_de_Apoyo_ContestacionModel
                {
                    Folio = m.Folio
                        ,Fecha_de_Contestacion = (m.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Contestacion = m.Hora_de_Contestacion
                        ,Usuario_que_contesta = m.Usuario_que_contesta
                        ,Usuario_que_contestaName = CultureHelper.GetTraduction(m.Usuario_que_contesta_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_contesta_Spartan_User.Name
                        ,Dictamen = m.Dictamen
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Documento.Clave.ToString(), "Documento") ?? (string)m.Dictamen_Documento.Descripcion
			,Enviar_Contestacion = m.Enviar_Contestacion
			,Archivo = m.Archivo
			,Observaciones_Contestacion = m.Observaciones_Contestacion

                    
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
        public ActionResult Post_Autorizacion(Solicitud_de_Servicios_de_Apoyo_AutorizacionModel varSolicitud_de_Servicios_de_Apoyo)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Solicitud_de_Servicios_de_Apoyo_AutorizacionInfo = new Solicitud_de_Servicios_de_Apoyo_Autorizacion
                {
                    Folio = varSolicitud_de_Servicios_de_Apoyo.Folio
                                            ,Fecha_de_Revision = (!String.IsNullOrEmpty(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Revision)) ? DateTime.ParseExact(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Revision, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Revision = varSolicitud_de_Servicios_de_Apoyo.Hora_de_Revision
                        ,Usuario_que_Revisa = varSolicitud_de_Servicios_de_Apoyo.Usuario_que_Revisa
                        ,Resultado_de_Autorizacion = varSolicitud_de_Servicios_de_Apoyo.Resultado_de_Autorizacion
                        ,Motivo_de_Rechazo = varSolicitud_de_Servicios_de_Apoyo.Motivo_de_Rechazo
                        ,Observaciones_Autorizacion = varSolicitud_de_Servicios_de_Apoyo.Observaciones_Autorizacion
                    
                };

                result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Update_Autorizacion(Solicitud_de_Servicios_de_Apoyo_AutorizacionInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Autorizacion(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.Get_Autorizacion(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Solicitud_de_Servicios_de_Apoyo_AutorizacionModel
                {
                    Folio = m.Folio
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_Revisa = m.Usuario_que_Revisa
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,Resultado_de_Autorizacion = m.Resultado_de_Autorizacion
                        ,Resultado_de_AutorizacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Autorizacion_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Autorizacion_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo = m.Motivo_de_Rechazo
			,Observaciones_Autorizacion = m.Observaciones_Autorizacion

                    
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

