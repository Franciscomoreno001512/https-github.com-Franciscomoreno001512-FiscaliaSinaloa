using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Compareciente;
using Spartane.Core.Domain.Spartan_User;
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
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
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

namespace Spartane.Web.Areas.Frontal.Controllers
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public class Solicitud_de_Servicios_de_ApoyoController : Controller
    {
        #region "variable declaration"

        private ISolicitud_de_Servicios_de_ApoyoService service = null;
        private ISolicitud_de_Servicios_de_ApoyoApiConsumer _ISolicitud_de_Servicios_de_ApoyoApiConsumer;
        private ITipo_de_Servicio_de_ApoyoApiConsumer _ITipo_de_Servicio_de_ApoyoApiConsumer;
        private IComparecienteApiConsumer _IComparecienteApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
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

        #endregion "variable declaration"

        #region "Constructor Declaration"

        
        public Solicitud_de_Servicios_de_ApoyoController(ISolicitud_de_Servicios_de_ApoyoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, ISolicitud_de_Servicios_de_ApoyoApiConsumer Solicitud_de_Servicios_de_ApoyoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer , ITipo_de_Servicio_de_ApoyoApiConsumer Tipo_de_Servicio_de_ApoyoApiConsumer , IComparecienteApiConsumer ComparecienteApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , IOrigen_de_InvitacionApiConsumer Origen_de_InvitacionApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , IDocumentoApiConsumer DocumentoApiConsumer , IEstatus_de_Solicitud_de_ApoyoApiConsumer Estatus_de_Solicitud_de_ApoyoApiConsumer , IArea_de_Servicios_de_ApoyoApiConsumer Area_de_Servicios_de_ApoyoApiConsumer , ISubArea_de_Servicios_de_ApoyoApiConsumer SubArea_de_Servicios_de_ApoyoApiConsumer , ITipo_de_Asignacion_de_ApoyoApiConsumer Tipo_de_Asignacion_de_ApoyoApiConsumer , IResultado_de_RevisionApiConsumer Resultado_de_RevisionApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._ISolicitud_de_Servicios_de_ApoyoApiConsumer = Solicitud_de_Servicios_de_ApoyoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ITipo_de_Servicio_de_ApoyoApiConsumer = Tipo_de_Servicio_de_ApoyoApiConsumer;
            this._IComparecienteApiConsumer = ComparecienteApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;
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
        public ActionResult Index()
        {
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45042);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
            return View();
        }

        // GET: Frontal/Solicitud_de_Servicios_de_Apoyo/Create
        [ObjectAuth(ObjectId = (ModuleObjectId)45042, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit)]
        public ActionResult Create(int Id = 0,  int consult = 0)
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45042);
            ViewBag.Permission = permission;
            var varSolicitud_de_Servicios_de_Apoyo = new Solicitud_de_Servicios_de_ApoyoModel();
			
            ViewBag.ObjectId = "45042";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Solicitud_de_Servicios_de_ApoyoData = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.GetByKeyComplete(Id).Resource.Solicitud_de_Servicios_de_Apoyos[0];
                if (Solicitud_de_Servicios_de_ApoyoData == null)
                    return HttpNotFound();

                varSolicitud_de_Servicios_de_Apoyo = new Solicitud_de_Servicios_de_ApoyoModel
                {
                    Clave = (int)Solicitud_de_Servicios_de_ApoyoData.Clave
                    ,Tipo_de_Servicio = Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Servicio
                    ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Servicio), "Tipo_de_Servicio_de_Apoyo") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                    ,Responsable = Solicitud_de_Servicios_de_ApoyoData.Responsable
                    ,Clave_MR = Solicitud_de_Servicios_de_ApoyoData.Clave_MR
                    ,Compareciente = Solicitud_de_Servicios_de_ApoyoData.Compareciente
                    ,ComparecienteNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Compareciente), "Compareciente") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Compareciente_Compareciente.Nombre_Completo
                    ,Fecha_de_Solicitud = (Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Solicitud = Solicitud_de_Servicios_de_ApoyoData.Hora_de_Solicitud
                    ,Usuario_que_Solicita = Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Solicita
                    ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Solicita), "Spartan_User") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Solicita_Spartan_User.Name
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
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.Ver_DocumentoSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varSolicitud_de_Servicios_de_Apoyo.Ver_Documento).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio != null && Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Comparecientes_Compareciente = _IComparecienteApiConsumer.SelAll(true);
            if (Comparecientes_Compareciente != null && Comparecientes_Compareciente.Resource != null)
                ViewBag.Comparecientes_Compareciente = Comparecientes_Compareciente.Resource.Where(m => m.Nombre_Completo != null).OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Compareciente", "Nombre_Completo") ?? m.Nombre_Completo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Solicita = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Solicita != null && Spartan_Users_Usuario_que_Solicita.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Solicita = Spartan_Users_Usuario_que_Solicita.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
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
            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_Numero_de_Expediente_AT = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_Numero_de_Expediente_AT != null && Modulo_Atencion_Inicials_Numero_de_Expediente_AT.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_Numero_de_Expediente_AT = Modulo_Atencion_Inicials_Numero_de_Expediente_AT.Resource.Where(m => m.NUAT != null).OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT") ?? m.NUAT.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var expediente_ministerio_publicos_Numero_de_Expediente_MP = _Iexpediente_ministerio_publicoApiConsumer.SelAll(true);
            if (expediente_ministerio_publicos_Numero_de_Expediente_MP != null && expediente_ministerio_publicos_Numero_de_Expediente_MP.Resource != null)
                ViewBag.expediente_ministerio_publicos_Numero_de_Expediente_MP = expediente_ministerio_publicos_Numero_de_Expediente_MP.Resource.Where(m => m.nuat != null).OrderBy(m => m.nuat).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "expediente_ministerio_publico", "nuat") ?? m.nuat.ToString(), Value = Convert.ToString(m.clave)
                }).ToList();
            _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Documentos_Solicitud = _IDocumentoApiConsumer.SelAll(true);
            if (Documentos_Solicitud != null && Documentos_Solicitud.Resource != null)
                ViewBag.Documentos_Solicitud = Documentos_Solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Solicitud_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Solicitud_de_Apoyos_Estatus = _IEstatus_de_Solicitud_de_ApoyoApiConsumer.SelAll(true);
            if (Estatus_de_Solicitud_de_Apoyos_Estatus != null && Estatus_de_Solicitud_de_Apoyos_Estatus.Resource != null)
                ViewBag.Estatus_de_Solicitud_de_Apoyos_Estatus = Estatus_de_Solicitud_de_Apoyos_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Solicitud_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Recibe = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Recibe != null && Spartan_Users_Usuario_que_Recibe.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Recibe = Spartan_Users_Usuario_que_Recibe.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
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
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Asigna = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Asigna != null && Spartan_Users_Usuario_que_Asigna.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Asigna = Spartan_Users_Usuario_que_Asigna.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ITipo_de_Asignacion_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion = _ITipo_de_Asignacion_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion != null && Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion.Resource != null)
                ViewBag.Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion = Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Asignacion_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Responsable_Asignado = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Responsable_Asignado != null && Spartan_Users_Responsable_Asignado.Resource != null)
                ViewBag.Spartan_Users_Responsable_Asignado = Spartan_Users_Responsable_Asignado.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_contesta = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_contesta != null && Spartan_Users_Usuario_que_contesta.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_contesta = Spartan_Users_Usuario_que_contesta.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Documentos_Dictamen = _IDocumentoApiConsumer.SelAll(true);
            if (Documentos_Dictamen != null && Documentos_Dictamen.Resource != null)
                ViewBag.Documentos_Dictamen = Documentos_Dictamen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Revisa = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Revisa != null && Spartan_Users_Usuario_que_Revisa.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Revisa = Spartan_Users_Usuario_que_Revisa.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
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
            return View(varSolicitud_de_Servicios_de_Apoyo);
        }
		
	[HttpGet]
        public ActionResult AddSolicitud_de_Servicios_de_Apoyo(int rowIndex = 0, int functionMode = 0, int id = 0)
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
                var Solicitud_de_Servicios_de_ApoyosData = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.ListaSelAll(0, 1000, "Solicitud_de_Servicios_de_Apoyo.Clave=" + id, "").Resource.Solicitud_de_Servicios_de_Apoyos;
				
				if (Solicitud_de_Servicios_de_ApoyosData != null && Solicitud_de_Servicios_de_ApoyosData.Count > 0)
                {
					var Solicitud_de_Servicios_de_ApoyoData = Solicitud_de_Servicios_de_ApoyosData.First();
					varSolicitud_de_Servicios_de_Apoyo= new Solicitud_de_Servicios_de_ApoyoModel
					{
						Clave  = Solicitud_de_Servicios_de_ApoyoData.Clave 
	                    ,Tipo_de_Servicio = Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Servicio
                    ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Servicio), "Tipo_de_Servicio_de_Apoyo") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                    ,Responsable = Solicitud_de_Servicios_de_ApoyoData.Responsable
                    ,Clave_MR = Solicitud_de_Servicios_de_ApoyoData.Clave_MR
                    ,Compareciente = Solicitud_de_Servicios_de_ApoyoData.Compareciente
                    ,ComparecienteNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Compareciente), "Compareciente") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Compareciente_Compareciente.Nombre_Completo
                    ,Fecha_de_Solicitud = (Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(Solicitud_de_Servicios_de_ApoyoData.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Solicitud = Solicitud_de_Servicios_de_ApoyoData.Hora_de_Solicitud
                    ,Usuario_que_Solicita = Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Solicita
                    ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(Convert.ToString(Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Solicita), "Spartan_User") ??  (string)Solicitud_de_Servicios_de_ApoyoData.Usuario_que_Solicita_Spartan_User.Name
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

            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio != null && Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Comparecientes_Compareciente = _IComparecienteApiConsumer.SelAll(true);
            if (Comparecientes_Compareciente != null && Comparecientes_Compareciente.Resource != null)
                ViewBag.Comparecientes_Compareciente = Comparecientes_Compareciente.Resource.Where(m => m.Nombre_Completo != null).OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Compareciente", "Nombre_Completo") ?? m.Nombre_Completo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Solicita = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Solicita != null && Spartan_Users_Usuario_que_Solicita.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Solicita = Spartan_Users_Usuario_que_Solicita.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
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
            _IModulo_Atencion_InicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modulo_Atencion_Inicials_Numero_de_Expediente_AT = _IModulo_Atencion_InicialApiConsumer.SelAll(true);
            if (Modulo_Atencion_Inicials_Numero_de_Expediente_AT != null && Modulo_Atencion_Inicials_Numero_de_Expediente_AT.Resource != null)
                ViewBag.Modulo_Atencion_Inicials_Numero_de_Expediente_AT = Modulo_Atencion_Inicials_Numero_de_Expediente_AT.Resource.Where(m => m.NUAT != null).OrderBy(m => m.NUAT).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modulo_Atencion_Inicial", "NUAT") ?? m.NUAT.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _Iexpediente_ministerio_publicoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var expediente_ministerio_publicos_Numero_de_Expediente_MP = _Iexpediente_ministerio_publicoApiConsumer.SelAll(true);
            if (expediente_ministerio_publicos_Numero_de_Expediente_MP != null && expediente_ministerio_publicos_Numero_de_Expediente_MP.Resource != null)
                ViewBag.expediente_ministerio_publicos_Numero_de_Expediente_MP = expediente_ministerio_publicos_Numero_de_Expediente_MP.Resource.Where(m => m.nuat != null).OrderBy(m => m.nuat).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.clave), "expediente_ministerio_publico", "nuat") ?? m.nuat.ToString(), Value = Convert.ToString(m.clave)
                }).ToList();
            _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Documentos_Solicitud = _IDocumentoApiConsumer.SelAll(true);
            if (Documentos_Solicitud != null && Documentos_Solicitud.Resource != null)
                ViewBag.Documentos_Solicitud = Documentos_Solicitud.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Solicitud_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Solicitud_de_Apoyos_Estatus = _IEstatus_de_Solicitud_de_ApoyoApiConsumer.SelAll(true);
            if (Estatus_de_Solicitud_de_Apoyos_Estatus != null && Estatus_de_Solicitud_de_Apoyos_Estatus.Resource != null)
                ViewBag.Estatus_de_Solicitud_de_Apoyos_Estatus = Estatus_de_Solicitud_de_Apoyos_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Solicitud_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Recibe = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Recibe != null && Spartan_Users_Usuario_que_Recibe.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Recibe = Spartan_Users_Usuario_que_Recibe.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
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
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Asigna = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Asigna != null && Spartan_Users_Usuario_que_Asigna.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Asigna = Spartan_Users_Usuario_que_Asigna.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ITipo_de_Asignacion_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion = _ITipo_de_Asignacion_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion != null && Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion.Resource != null)
                ViewBag.Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion = Tipo_de_Asignacion_de_Apoyos_Tipo_de_Asignacion.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Asignacion_de_Apoyo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Responsable_Asignado = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Responsable_Asignado != null && Spartan_Users_Responsable_Asignado.Resource != null)
                ViewBag.Spartan_Users_Responsable_Asignado = Spartan_Users_Responsable_Asignado.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_contesta = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_contesta != null && Spartan_Users_Usuario_que_contesta.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_contesta = Spartan_Users_Usuario_que_contesta.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();
            _IDocumentoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Documentos_Dictamen = _IDocumentoApiConsumer.SelAll(true);
            if (Documentos_Dictamen != null && Documentos_Dictamen.Resource != null)
                ViewBag.Documentos_Dictamen = Documentos_Dictamen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Documento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Usuario_que_Revisa = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Usuario_que_Revisa != null && Spartan_Users_Usuario_que_Revisa.Resource != null)
                ViewBag.Spartan_Users_Usuario_que_Revisa = Spartan_Users_Usuario_que_Revisa.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
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
        public ActionResult GetTipo_de_Servicio_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio")?? m.Servicio,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetComparecienteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IComparecienteApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Compareciente", "Nombre_Completo")?? m.Nombre_Completo,
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
                    Clave = m.Clave
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Responsable = m.Responsable
			,Clave_MR = m.Clave_MR
                        ,ComparecienteNombre_Completo = CultureHelper.GetTraduction(m.Compareciente_Compareciente.Clave.ToString(), "Nombre_Completo") ?? (string)m.Compareciente_Compareciente.Nombre_Completo
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Solicitud = m.Hora_de_Solicitud
                        ,Usuario_que_SolicitaName = CultureHelper.GetTraduction(m.Usuario_que_Solicita_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Solicita_Spartan_User.Name
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Numero_de_Expediente_ATNUAT = CultureHelper.GetTraduction(m.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.Clave.ToString(), "NUAT") ?? (string)m.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.NUAT
                        ,Numero_de_Expediente_MPnuat = CultureHelper.GetTraduction(m.Numero_de_Expediente_MP_expediente_ministerio_publico.clave.ToString(), "nuat") ?? (string)m.Numero_de_Expediente_MP_expediente_ministerio_publico.nuat
			,NUAT = m.NUAT
			,Numero_de_Denuncia = m.Numero_de_Denuncia
			,Carpeta_de_Investigacion = m.Carpeta_de_Investigacion
			,Numero_de_Oficio = m.Numero_de_Oficio
                        ,SolicitudDescripcion = CultureHelper.GetTraduction(m.Solicitud_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Solicitud_Documento.Descripcion
			,Ver_Documento = m.Ver_Documento
			,Observaciones = m.Observaciones
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Solicitud_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Solicitud_de_Apoyo.Descripcion
                        ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Recepcion = m.Hora_de_Recepcion
                        ,Usuario_que_RecibeName = CultureHelper.GetTraduction(m.Usuario_que_Recibe_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Recibe_Spartan_User.Name
                        ,Area_AsignadaDescripcion = CultureHelper.GetTraduction(m.Area_Asignada_Area_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                        ,SubArea_AsignadaDescripcion = CultureHelper.GetTraduction(m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
			,Observaciones_Recepcion = m.Observaciones_Recepcion
                        ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Asignacion = m.Hora_de_Asignacion
                        ,Usuario_que_AsignaName = CultureHelper.GetTraduction(m.Usuario_que_Asigna_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Asigna_Spartan_User.Name
                        ,Tipo_de_AsignacionDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Descripcion
                        ,Responsable_AsignadoName = CultureHelper.GetTraduction(m.Responsable_Asignado_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Responsable_Asignado_Spartan_User.Name
			,Observaciones_Asignacion = m.Observaciones_Asignacion
                        ,Fecha_de_Contestacion = (m.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Contestacion = m.Hora_de_Contestacion
                        ,Usuario_que_contestaName = CultureHelper.GetTraduction(m.Usuario_que_contesta_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_contesta_Spartan_User.Name
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Documento.Clave.ToString(), "Descripcion") ?? (string)m.Dictamen_Documento.Descripcion
			,Enviar_Contestacion = m.Enviar_Contestacion
			,Archivo = m.Archivo
			,Observaciones_Contestacion = m.Observaciones_Contestacion
                        ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Revision = m.Hora_de_Revision
                        ,Usuario_que_RevisaName = CultureHelper.GetTraduction(m.Usuario_que_Revisa_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Usuario_que_Revisa_Spartan_User.Name
                        ,Resultado_de_AutorizacionDescripcion = CultureHelper.GetTraduction(m.Resultado_de_Autorizacion_Resultado_de_Revision.Clave.ToString(), "Descripcion") ?? (string)m.Resultado_de_Autorizacion_Resultado_de_Revision.Descripcion
			,Motivo_de_Rechazo = m.Motivo_de_Rechazo
			,Observaciones_Autorizacion = m.Observaciones_Autorizacion

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
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
				if (ModelState.IsValid)
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
                    var Solicitud_de_Servicios_de_ApoyoInfo = new Solicitud_de_Servicios_de_Apoyo
                    {
                        Clave = varSolicitud_de_Servicios_de_Apoyo.Clave
                        ,Tipo_de_Servicio = varSolicitud_de_Servicios_de_Apoyo.Tipo_de_Servicio
                        ,Responsable = varSolicitud_de_Servicios_de_Apoyo.Responsable
                        ,Clave_MR = varSolicitud_de_Servicios_de_Apoyo.Clave_MR
                        ,Compareciente = varSolicitud_de_Servicios_de_Apoyo.Compareciente
                        ,Fecha_de_Solicitud = (!String.IsNullOrEmpty(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Solicitud)) ? DateTime.ParseExact(varSolicitud_de_Servicios_de_Apoyo.Fecha_de_Solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Solicitud = varSolicitud_de_Servicios_de_Apoyo.Hora_de_Solicitud
                        ,Usuario_que_Solicita = varSolicitud_de_Servicios_de_Apoyo.Usuario_que_Solicita
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

                    return Json(result, JsonRequestBehavior.AllowGet);
				}
				return Json(false, JsonRequestBehavior.AllowGet);
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
        public JsonResult WriteScriptSettings(CustomElements Solicitud_de_Servicios_de_ApoyoModuleAttributeList)
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
					if (string.IsNullOrEmpty(Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue))
					{
						Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].DefaultValue = string.Empty;
					}
					if (string.IsNullOrEmpty(Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].HelpText))
					{
						Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].HelpText = string.Empty;
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
				indexOfArrayHistory = strSolicitud_de_Servicios_de_ApoyoScript.IndexOf("inpuElementChildArray");
				splittedStringHistory = strSolicitud_de_Servicios_de_ApoyoScript.Substring(indexOfArrayHistory, strSolicitud_de_Servicios_de_ApoyoScript.Length - indexOfArrayHistory);
				indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
				endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
			}
			string finalResponse = strSolicitud_de_Servicios_de_ApoyoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strSolicitud_de_Servicios_de_ApoyoScript.Substring(endIndexOfMainElement + indexOfArray, strSolicitud_de_Servicios_de_ApoyoScript.Length - (endIndexOfMainElement + indexOfArray));
            if (Solicitud_de_Servicios_de_ApoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				finalResponse = strSolicitud_de_Servicios_de_ApoyoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson
                + strSolicitud_de_Servicios_de_ApoyoScript.Substring(endIndexOfMainElement + indexOfArray, (indexOfMainElementHistory + indexOfArrayHistory) - (endIndexOfMainElement + indexOfArray)) + childUserChangeJson
                + strSolicitud_de_Servicios_de_ApoyoScript.Substring(endIndexOfMainElementHistory + indexOfArrayHistory, strSolicitud_de_Servicios_de_ApoyoScript.Length - (endIndexOfMainElementHistory + indexOfArrayHistory));
			}
            
            

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

                int indexOfChildArray = strCustomScript.IndexOf("inpuElementChildArray");
				string childJsonArray = "";
                if (indexOfChildArray != -1)
                {
					string splittedChildString = strCustomScript.Substring(indexOfChildArray, strCustomScript.Length - indexOfChildArray);
					int indexOfChildElement = splittedChildString.IndexOf('[');
					int endIndexOfChildElement = splittedChildString.IndexOf(']') + 1;
					childJsonArray = splittedChildString.Substring(indexOfChildElement, endIndexOfChildElement - indexOfChildElement);
				}
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
        public void Export(string format, int pageIndex, int pageSize)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);

            if (!_tokenManager.GenerateToken())
                return;

            _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Solicitud_de_Servicios_de_ApoyoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Servicios_de_Apoyos == null)
                result.Solicitud_de_Servicios_de_Apoyos = new List<Solicitud_de_Servicios_de_Apoyo>();

            var data = result.Solicitud_de_Servicios_de_Apoyos.Select(m => new Solicitud_de_Servicios_de_ApoyoGridModel
            {
                Clave = m.Clave
                ,Tipo_de_ServicioServicio = (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                ,Responsable = m.Responsable
                ,Clave_MR = m.Clave_MR
                ,ComparecienteNombre_Completo = (string)m.Compareciente_Compareciente.Nombre_Completo
                ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Solicitud = m.Hora_de_Solicitud
                ,Usuario_que_SolicitaName = (string)m.Usuario_que_Solicita_Spartan_User.Name
                ,OrigenDescripcion = (string)m.Origen_Origen_de_Invitacion.Descripcion
                ,Numero_de_Expediente_ATNUAT = (string)m.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.NUAT
                ,Numero_de_Expediente_MPnuat = (string)m.Numero_de_Expediente_MP_expediente_ministerio_publico.nuat
                ,NUAT = m.NUAT
                ,Numero_de_Denuncia = m.Numero_de_Denuncia
                ,Carpeta_de_Investigacion = m.Carpeta_de_Investigacion
                ,Numero_de_Oficio = m.Numero_de_Oficio
                ,SolicitudDescripcion = (string)m.Solicitud_Documento.Descripcion
                ,Observaciones = m.Observaciones
                ,EstatusDescripcion = (string)m.Estatus_Estatus_de_Solicitud_de_Apoyo.Descripcion
                ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Recepcion = m.Hora_de_Recepcion
                ,Usuario_que_RecibeName = (string)m.Usuario_que_Recibe_Spartan_User.Name
                ,Area_AsignadaDescripcion = (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                ,SubArea_AsignadaDescripcion = (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
                ,Observaciones_Recepcion = m.Observaciones_Recepcion
                ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Asignacion = m.Hora_de_Asignacion
                ,Usuario_que_AsignaName = (string)m.Usuario_que_Asigna_Spartan_User.Name
                ,Tipo_de_AsignacionDescripcion = (string)m.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Descripcion
                ,Responsable_AsignadoName = (string)m.Responsable_Asignado_Spartan_User.Name
                ,Observaciones_Asignacion = m.Observaciones_Asignacion
                ,Fecha_de_Contestacion = (m.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Contestacion = m.Hora_de_Contestacion
                ,Usuario_que_contestaName = (string)m.Usuario_que_contesta_Spartan_User.Name
                ,DictamenDescripcion = (string)m.Dictamen_Documento.Descripcion
                ,Enviar_Contestacion = m.Enviar_Contestacion
                ,Archivo = m.Archivo
                ,Observaciones_Contestacion = m.Observaciones_Contestacion
                ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Revision = m.Hora_de_Revision
                ,Usuario_que_RevisaName = (string)m.Usuario_que_Revisa_Spartan_User.Name
                ,Resultado_de_AutorizacionDescripcion = (string)m.Resultado_de_Autorizacion_Resultado_de_Revision.Descripcion
                ,Motivo_de_Rechazo = m.Motivo_de_Rechazo
                ,Observaciones_Autorizacion = m.Observaciones_Autorizacion

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(), "Solicitud_de_Servicios_de_ApoyoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(), "Solicitud_de_Servicios_de_ApoyoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(), "EmployeeList_" + DateTime.Now.ToString());
                    break;
            }
        }

        [HttpGet]
        //[ObjectAuth(ObjectId = ModuleObjectId.EMPLEADOS_OBJECT, PermissionType = PermissionTypes.Export)]
        public ActionResult Print(string format, int pageIndex, int pageSize)
        {
            var exportFormatType = (ExportFormatType)Enum.Parse(
                                          typeof(ExportFormatType), format, true);

            if (!_tokenManager.GenerateToken())
                return null;

            _ISolicitud_de_Servicios_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetConfiguration(filter, new Solicitud_de_Servicios_de_ApoyoPropertyMapper());

            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _ISolicitud_de_Servicios_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Solicitud_de_Servicios_de_Apoyos == null)
                result.Solicitud_de_Servicios_de_Apoyos = new List<Solicitud_de_Servicios_de_Apoyo>();

            var data = result.Solicitud_de_Servicios_de_Apoyos.Select(m => new Solicitud_de_Servicios_de_ApoyoGridModel
            {
                Clave = m.Clave
                ,Tipo_de_ServicioServicio = (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                ,Responsable = m.Responsable
                ,Clave_MR = m.Clave_MR
                ,ComparecienteNombre_Completo = (string)m.Compareciente_Compareciente.Nombre_Completo
                ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Solicitud = m.Hora_de_Solicitud
                ,Usuario_que_SolicitaName = (string)m.Usuario_que_Solicita_Spartan_User.Name
                ,OrigenDescripcion = (string)m.Origen_Origen_de_Invitacion.Descripcion
                ,Numero_de_Expediente_ATNUAT = (string)m.Numero_de_Expediente_AT_Modulo_Atencion_Inicial.NUAT
                ,Numero_de_Expediente_MPnuat = (string)m.Numero_de_Expediente_MP_expediente_ministerio_publico.nuat
                ,NUAT = m.NUAT
                ,Numero_de_Denuncia = m.Numero_de_Denuncia
                ,Carpeta_de_Investigacion = m.Carpeta_de_Investigacion
                ,Numero_de_Oficio = m.Numero_de_Oficio
                ,SolicitudDescripcion = (string)m.Solicitud_Documento.Descripcion
                ,Observaciones = m.Observaciones
                ,EstatusDescripcion = (string)m.Estatus_Estatus_de_Solicitud_de_Apoyo.Descripcion
                ,Fecha_de_Recepcion = (m.Fecha_de_Recepcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Recepcion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Recepcion = m.Hora_de_Recepcion
                ,Usuario_que_RecibeName = (string)m.Usuario_que_Recibe_Spartan_User.Name
                ,Area_AsignadaDescripcion = (string)m.Area_Asignada_Area_de_Servicios_de_Apoyo.Descripcion
                ,SubArea_AsignadaDescripcion = (string)m.SubArea_Asignada_SubArea_de_Servicios_de_Apoyo.Descripcion
                ,Observaciones_Recepcion = m.Observaciones_Recepcion
                ,Fecha_de_Asignacion = (m.Fecha_de_Asignacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Asignacion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Asignacion = m.Hora_de_Asignacion
                ,Usuario_que_AsignaName = (string)m.Usuario_que_Asigna_Spartan_User.Name
                ,Tipo_de_AsignacionDescripcion = (string)m.Tipo_de_Asignacion_Tipo_de_Asignacion_de_Apoyo.Descripcion
                ,Responsable_AsignadoName = (string)m.Responsable_Asignado_Spartan_User.Name
                ,Observaciones_Asignacion = m.Observaciones_Asignacion
                ,Fecha_de_Contestacion = (m.Fecha_de_Contestacion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Contestacion).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Contestacion = m.Hora_de_Contestacion
                ,Usuario_que_contestaName = (string)m.Usuario_que_contesta_Spartan_User.Name
                ,DictamenDescripcion = (string)m.Dictamen_Documento.Descripcion
                ,Enviar_Contestacion = m.Enviar_Contestacion
                ,Archivo = m.Archivo
                ,Observaciones_Contestacion = m.Observaciones_Contestacion
                ,Fecha_de_Revision = (m.Fecha_de_Revision == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Revision).ToString(ConfigurationProperty.DateFormat))
                ,Hora_de_Revision = m.Hora_de_Revision
                ,Usuario_que_RevisaName = (string)m.Usuario_que_Revisa_Spartan_User.Name
                ,Resultado_de_AutorizacionDescripcion = (string)m.Resultado_de_Autorizacion_Resultado_de_Revision.Descripcion
                ,Motivo_de_Rechazo = m.Motivo_de_Rechazo
                ,Observaciones_Autorizacion = m.Observaciones_Autorizacion

            }).ToList();

            return PartialView("_Print", data);
        }

        #endregion "Custom methods"
    }
}
