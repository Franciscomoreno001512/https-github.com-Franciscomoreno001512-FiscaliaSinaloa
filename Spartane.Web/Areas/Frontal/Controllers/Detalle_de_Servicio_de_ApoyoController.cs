using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Origen_de_Invitacion;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Tipo_de_Servicio_de_Apoyo;
using Spartane.Core.Domain.Dialecto;
using Spartane.Core.Domain.Idioma;
using Spartane.Core.Domain.Compareciente;
using Spartane.Core.Domain.Detalle_de_Documentos_MPO;
using Spartane.Core.Domain.Detalle_de_documentos;
using Spartane.Core.Domain.Diligencias_MP;
using Spartane.Core.Domain.Documento;
using Spartane.Core.Domain.Autoridad_Servicio_Pericial;
using Spartane.Core.Domain.Agencia_Servicio_Pericial;
using Spartane.Core.Domain.Dictamen_Servicio_Pericial;
using Spartane.Core.Domain.Area_Pericial;
using Spartane.Core.Domain.Spartan_User;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Origen_de_Invitacion;
using Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Servicio_de_Apoyo;
using Spartane.Web.Areas.WebApiConsumer.Dialecto;
using Spartane.Web.Areas.WebApiConsumer.Idioma;
using Spartane.Web.Areas.WebApiConsumer.Compareciente;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Documentos_MPO;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_documentos;
using Spartane.Web.Areas.WebApiConsumer.Diligencias_MP;
using Spartane.Web.Areas.WebApiConsumer.Documento;
using Spartane.Web.Areas.WebApiConsumer.Autoridad_Servicio_Pericial;
using Spartane.Web.Areas.WebApiConsumer.Agencia_Servicio_Pericial;
using Spartane.Web.Areas.WebApiConsumer.Dictamen_Servicio_Pericial;
using Spartane.Web.Areas.WebApiConsumer.Area_Pericial;
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
    public class Detalle_de_Servicio_de_ApoyoController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Servicio_de_ApoyoService service = null;
        private IDetalle_de_Servicio_de_ApoyoApiConsumer _IDetalle_de_Servicio_de_ApoyoApiConsumer;
        private IOrigen_de_InvitacionApiConsumer _IOrigen_de_InvitacionApiConsumer;
        private IModulo_Atencion_InicialApiConsumer _IModulo_Atencion_InicialApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private ITipo_de_Servicio_de_ApoyoApiConsumer _ITipo_de_Servicio_de_ApoyoApiConsumer;
        private IDialectoApiConsumer _IDialectoApiConsumer;
        private IIdiomaApiConsumer _IIdiomaApiConsumer;
        private IComparecienteApiConsumer _IComparecienteApiConsumer;
        private IDetalle_de_Documentos_MPOApiConsumer _IDetalle_de_Documentos_MPOApiConsumer;
        private IDetalle_de_documentosApiConsumer _IDetalle_de_documentosApiConsumer;
        private IDiligencias_MPApiConsumer _IDiligencias_MPApiConsumer;
        private IDocumentoApiConsumer _IDocumentoApiConsumer;
        private IAutoridad_Servicio_PericialApiConsumer _IAutoridad_Servicio_PericialApiConsumer;
        private IAgencia_Servicio_PericialApiConsumer _IAgencia_Servicio_PericialApiConsumer;
        private IDictamen_Servicio_PericialApiConsumer _IDictamen_Servicio_PericialApiConsumer;
        private IArea_PericialApiConsumer _IArea_PericialApiConsumer;
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

        
        public Detalle_de_Servicio_de_ApoyoController(IDetalle_de_Servicio_de_ApoyoService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Servicio_de_ApoyoApiConsumer Detalle_de_Servicio_de_ApoyoApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , IOrigen_de_InvitacionApiConsumer Origen_de_InvitacionApiConsumer , IModulo_Atencion_InicialApiConsumer Modulo_Atencion_InicialApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , ITipo_de_Servicio_de_ApoyoApiConsumer Tipo_de_Servicio_de_ApoyoApiConsumer , IDialectoApiConsumer DialectoApiConsumer , IIdiomaApiConsumer IdiomaApiConsumer , IComparecienteApiConsumer ComparecienteApiConsumer , IDetalle_de_Documentos_MPOApiConsumer Detalle_de_Documentos_MPOApiConsumer , IDetalle_de_documentosApiConsumer Detalle_de_documentosApiConsumer , IDiligencias_MPApiConsumer Diligencias_MPApiConsumer , IDocumentoApiConsumer DocumentoApiConsumer , IAutoridad_Servicio_PericialApiConsumer Autoridad_Servicio_PericialApiConsumer , IAgencia_Servicio_PericialApiConsumer Agencia_Servicio_PericialApiConsumer , IDictamen_Servicio_PericialApiConsumer Dictamen_Servicio_PericialApiConsumer , IArea_PericialApiConsumer Area_PericialApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Servicio_de_ApoyoApiConsumer = Detalle_de_Servicio_de_ApoyoApiConsumer;
            this._userCredential = SessionHelper.UserCredential;
            this._tokenManager = tokenManager;
            this._ISpartane_FileApiConsumer = Spartane_FileApiConsumer;
            this._ISpartan_Business_RuleApiConsumer = Spartan_Business_RuleApiConsumer;
            this._ISpartan_BR_Process_Event_DetailApiConsumer = Spartan_BR_Process_Event_DetailApiConsumer;
            this._ISpartan_FormatApiConsumer = Spartan_FormatApiConsumer;
            this._ISpartan_Format_PermissionsApiConsumer = Spartan_Format_PermissionsApiConsumer;
            this._IGeneratePDFApiConsumer = GeneratePDFApiConsumer;
			this._ISpartan_FormatRelatedApiConsumer = Spartan_Format_RelatedApiConsumer;
            this._IOrigen_de_InvitacionApiConsumer = Origen_de_InvitacionApiConsumer;
            this._IModulo_Atencion_InicialApiConsumer = Modulo_Atencion_InicialApiConsumer;
            this._ISolicitudApiConsumer = SolicitudApiConsumer;
            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
            this._ITipo_de_Servicio_de_ApoyoApiConsumer = Tipo_de_Servicio_de_ApoyoApiConsumer;
            this._IDialectoApiConsumer = DialectoApiConsumer;
            this._IIdiomaApiConsumer = IdiomaApiConsumer;
            this._IComparecienteApiConsumer = ComparecienteApiConsumer;
            this._IDetalle_de_Documentos_MPOApiConsumer = Detalle_de_Documentos_MPOApiConsumer;
            this._IDetalle_de_documentosApiConsumer = Detalle_de_documentosApiConsumer;
            this._IDiligencias_MPApiConsumer = Diligencias_MPApiConsumer;
            this._IDocumentoApiConsumer = DocumentoApiConsumer;
            this._IAutoridad_Servicio_PericialApiConsumer = Autoridad_Servicio_PericialApiConsumer;
            this._IAgencia_Servicio_PericialApiConsumer = Agencia_Servicio_PericialApiConsumer;
            this._IDictamen_Servicio_PericialApiConsumer = Dictamen_Servicio_PericialApiConsumer;
            this._IArea_PericialApiConsumer = Area_PericialApiConsumer;
            this._ISpartan_UserApiConsumer = Spartan_UserApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Servicio_de_Apoyo
        [ObjectAuth(ObjectId = (ModuleObjectId)45039, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45039, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_de_Servicio_de_Apoyo/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45039, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45039, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_de_Servicio_de_Apoyo = new Detalle_de_Servicio_de_ApoyoModel();
			varDetalle_de_Servicio_de_Apoyo.Clave = Id;
			
            ViewBag.ObjectId = "45039";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;



            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Servicio_de_ApoyosData = _IDetalle_de_Servicio_de_ApoyoApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Servicio_de_Apoyo.Clave=" + Id, "").Resource.Detalle_de_Servicio_de_Apoyos;
				
				if (Detalle_de_Servicio_de_ApoyosData != null && Detalle_de_Servicio_de_ApoyosData.Count > 0)
                {
					var Detalle_de_Servicio_de_ApoyoData = Detalle_de_Servicio_de_ApoyosData.First();
					varDetalle_de_Servicio_de_Apoyo= new Detalle_de_Servicio_de_ApoyoModel
					{
						Clave  = Detalle_de_Servicio_de_ApoyoData.Clave 
	                    ,Origen = Detalle_de_Servicio_de_ApoyoData.Origen
                    ,OrigenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Origen), "Origen_de_Invitacion") ??  (string)Detalle_de_Servicio_de_ApoyoData.Origen_Origen_de_Invitacion.Descripcion
                    ,Modulo_de_Atencion_Inicial = Detalle_de_Servicio_de_ApoyoData.Modulo_de_Atencion_Inicial
                    ,Modulo_de_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Modulo_de_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Detalle_de_Servicio_de_ApoyoData.Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Modulo_Mecanismos_Alternos = Detalle_de_Servicio_de_ApoyoData.Modulo_Mecanismos_Alternos
                    ,Modulo_Mecanismos_AlternosCDI = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Modulo_Mecanismos_Alternos), "Solicitud") ??  (string)Detalle_de_Servicio_de_ApoyoData.Modulo_Mecanismos_Alternos_Solicitud.CDI
                    ,Modulo_Ministerio_Publico = Detalle_de_Servicio_de_ApoyoData.Modulo_Ministerio_Publico
                    ,Modulo_Ministerio_Publiconic = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Modulo_Ministerio_Publico), "expediente_ministerio_publico") ??  (string)Detalle_de_Servicio_de_ApoyoData.Modulo_Ministerio_Publico_expediente_ministerio_publico.nic
                    ,Tipo_de_Servicio = Detalle_de_Servicio_de_ApoyoData.Tipo_de_Servicio
                    ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Tipo_de_Servicio), "Tipo_de_Servicio_de_Apoyo") ??  (string)Detalle_de_Servicio_de_ApoyoData.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                    ,Requiere_Traductor = Detalle_de_Servicio_de_ApoyoData.Requiere_Traductor.GetValueOrDefault()
                    ,Lengua_Originaria = Detalle_de_Servicio_de_ApoyoData.Lengua_Originaria
                    ,Lengua_OriginariaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Lengua_Originaria), "Dialecto") ??  (string)Detalle_de_Servicio_de_ApoyoData.Lengua_Originaria_Dialecto.Descripcion
                    ,Idioma = Detalle_de_Servicio_de_ApoyoData.Idioma
                    ,IdiomaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Idioma), "Idioma") ??  (string)Detalle_de_Servicio_de_ApoyoData.Idioma_Idioma.Descripcion
                    ,Responsable = Detalle_de_Servicio_de_ApoyoData.Responsable
                    ,Compareciente = Detalle_de_Servicio_de_ApoyoData.Compareciente
                    ,ComparecienteNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Compareciente), "Compareciente") ??  (string)Detalle_de_Servicio_de_ApoyoData.Compareciente_Compareciente.Nombre_Completo
                    ,Documento_Atencion_Inicial = Detalle_de_Servicio_de_ApoyoData.Documento_Atencion_Inicial
                    ,Documento_Atencion_InicialObservaciones = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Documento_Atencion_Inicial), "Detalle_de_Documentos_MPO") ??  (string)Detalle_de_Servicio_de_ApoyoData.Documento_Atencion_Inicial_Detalle_de_Documentos_MPO.Observaciones
                    ,Documento_Mecanismos_Alternos = Detalle_de_Servicio_de_ApoyoData.Documento_Mecanismos_Alternos
                    ,Documento_Mecanismos_AlternosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Documento_Mecanismos_Alternos), "Detalle_de_documentos") ??  (string)Detalle_de_Servicio_de_ApoyoData.Documento_Mecanismos_Alternos_Detalle_de_documentos.Descripcion
                    ,Documento_Ministerio_Publico = Detalle_de_Servicio_de_ApoyoData.Documento_Ministerio_Publico
                    ,Documento_Ministerio_PublicoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Documento_Ministerio_Publico), "Diligencias_MP") ??  (string)Detalle_de_Servicio_de_ApoyoData.Documento_Ministerio_Publico_Diligencias_MP.Descripcion
                    ,Diligencia = Detalle_de_Servicio_de_ApoyoData.Diligencia
                    ,DiligenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Diligencia), "Documento") ??  (string)Detalle_de_Servicio_de_ApoyoData.Diligencia_Documento.Descripcion
                    ,Archivo = Detalle_de_Servicio_de_ApoyoData.Archivo
                    ,Fecha_de_Registro = (Detalle_de_Servicio_de_ApoyoData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Detalle_de_Servicio_de_ApoyoData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Fecha_de_Solicitud = (Detalle_de_Servicio_de_ApoyoData.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(Detalle_de_Servicio_de_ApoyoData.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Numero_Oficio = Detalle_de_Servicio_de_ApoyoData.Numero_Oficio
                    ,Imagen = Detalle_de_Servicio_de_ApoyoData.Imagen
                    ,Nombre_Solicitante = Detalle_de_Servicio_de_ApoyoData.Nombre_Solicitante
                    ,Rango_Solicitante = Detalle_de_Servicio_de_ApoyoData.Rango_Solicitante
                    ,Autoridades = Detalle_de_Servicio_de_ApoyoData.Autoridades
                    ,AutoridadesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Autoridades), "Autoridad_Servicio_Pericial") ??  (string)Detalle_de_Servicio_de_ApoyoData.Autoridades_Autoridad_Servicio_Pericial.Descripcion
                    ,Agencia = Detalle_de_Servicio_de_ApoyoData.Agencia
                    ,AgenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Agencia), "Agencia_Servicio_Pericial") ??  (string)Detalle_de_Servicio_de_ApoyoData.Agencia_Agencia_Servicio_Pericial.Descripcion
                    ,Observaciones = Detalle_de_Servicio_de_ApoyoData.Observaciones
                    ,Dictamen = Detalle_de_Servicio_de_ApoyoData.Dictamen
                    ,DictamenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Dictamen), "Dictamen_Servicio_Pericial") ??  (string)Detalle_de_Servicio_de_ApoyoData.Dictamen_Dictamen_Servicio_Pericial.Descripcion
                    ,Contestacion_lista_para_enviarse = Detalle_de_Servicio_de_ApoyoData.Contestacion_lista_para_enviarse.GetValueOrDefault()
                    ,Area_Pericial = Detalle_de_Servicio_de_ApoyoData.Area_Pericial
                    ,Area_PericialDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Area_Pericial), "Area_Pericial") ??  (string)Detalle_de_Servicio_de_ApoyoData.Area_Pericial_Area_Pericial.Descripcion
                    ,Perito = Detalle_de_Servicio_de_ApoyoData.Perito
                    ,PeritoName = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Perito), "Spartan_User") ??  (string)Detalle_de_Servicio_de_ApoyoData.Perito_Spartan_User.Name

					};
				}
				
				                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.ImagenSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Servicio_de_Apoyo.Imagen).Resource;

				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio != null && Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDialectoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dialectos_Lengua_Originaria = _IDialectoApiConsumer.SelAll(true);
            if (Dialectos_Lengua_Originaria != null && Dialectos_Lengua_Originaria.Resource != null)
                ViewBag.Dialectos_Lengua_Originaria = Dialectos_Lengua_Originaria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dialecto", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Comparecientes_Compareciente = _IComparecienteApiConsumer.SelAll(true);
            if (Comparecientes_Compareciente != null && Comparecientes_Compareciente.Resource != null)
                ViewBag.Comparecientes_Compareciente = Comparecientes_Compareciente.Resource.Where(m => m.Nombre_Completo != null).OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Compareciente", "Nombre_Completo") ?? m.Nombre_Completo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAutoridad_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Autoridad_Servicio_Pericials_Autoridades = _IAutoridad_Servicio_PericialApiConsumer.SelAll(true);
            if (Autoridad_Servicio_Pericials_Autoridades != null && Autoridad_Servicio_Pericials_Autoridades.Resource != null)
                ViewBag.Autoridad_Servicio_Pericials_Autoridades = Autoridad_Servicio_Pericials_Autoridades.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Autoridad_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgencia_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencia_Servicio_Pericials_Agencia = _IAgencia_Servicio_PericialApiConsumer.SelAll(true);
            if (Agencia_Servicio_Pericials_Agencia != null && Agencia_Servicio_Pericials_Agencia.Resource != null)
                ViewBag.Agencia_Servicio_Pericials_Agencia = Agencia_Servicio_Pericials_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Agencia_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDictamen_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dictamen_Servicio_Pericials_Dictamen = _IDictamen_Servicio_PericialApiConsumer.SelAll(true);
            if (Dictamen_Servicio_Pericials_Dictamen != null && Dictamen_Servicio_Pericials_Dictamen.Resource != null)
                ViewBag.Dictamen_Servicio_Pericials_Dictamen = Dictamen_Servicio_Pericials_Dictamen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dictamen_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_Pericials_Area_Pericial = _IArea_PericialApiConsumer.SelAll(true);
            if (Area_Pericials_Area_Pericial != null && Area_Pericials_Area_Pericial.Resource != null)
                ViewBag.Area_Pericials_Area_Pericial = Area_Pericials_Area_Pericial.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Perito = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Perito != null && Spartan_Users_Perito.Resource != null)
                ViewBag.Spartan_Users_Perito = Spartan_Users_Perito.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
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

				
            return View(varDetalle_de_Servicio_de_Apoyo);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Servicio_de_Apoyo(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45039);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Servicio_de_ApoyoModel varDetalle_de_Servicio_de_Apoyo= new Detalle_de_Servicio_de_ApoyoModel();


            if (id.ToString() != "0")
            {
                var Detalle_de_Servicio_de_ApoyosData = _IDetalle_de_Servicio_de_ApoyoApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Servicio_de_Apoyo.Clave=" + id, "").Resource.Detalle_de_Servicio_de_Apoyos;
				
				if (Detalle_de_Servicio_de_ApoyosData != null && Detalle_de_Servicio_de_ApoyosData.Count > 0)
                {
					var Detalle_de_Servicio_de_ApoyoData = Detalle_de_Servicio_de_ApoyosData.First();
					varDetalle_de_Servicio_de_Apoyo= new Detalle_de_Servicio_de_ApoyoModel
					{
						Clave  = Detalle_de_Servicio_de_ApoyoData.Clave 
	                    ,Origen = Detalle_de_Servicio_de_ApoyoData.Origen
                    ,OrigenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Origen), "Origen_de_Invitacion") ??  (string)Detalle_de_Servicio_de_ApoyoData.Origen_Origen_de_Invitacion.Descripcion
                    ,Modulo_de_Atencion_Inicial = Detalle_de_Servicio_de_ApoyoData.Modulo_de_Atencion_Inicial
                    ,Modulo_de_Atencion_InicialNUAT = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Modulo_de_Atencion_Inicial), "Modulo_Atencion_Inicial") ??  (string)Detalle_de_Servicio_de_ApoyoData.Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                    ,Modulo_Mecanismos_Alternos = Detalle_de_Servicio_de_ApoyoData.Modulo_Mecanismos_Alternos
                    ,Modulo_Mecanismos_AlternosCDI = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Modulo_Mecanismos_Alternos), "Solicitud") ??  (string)Detalle_de_Servicio_de_ApoyoData.Modulo_Mecanismos_Alternos_Solicitud.CDI
                    ,Modulo_Ministerio_Publico = Detalle_de_Servicio_de_ApoyoData.Modulo_Ministerio_Publico
                    ,Modulo_Ministerio_Publiconic = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Modulo_Ministerio_Publico), "expediente_ministerio_publico") ??  (string)Detalle_de_Servicio_de_ApoyoData.Modulo_Ministerio_Publico_expediente_ministerio_publico.nic
                    ,Tipo_de_Servicio = Detalle_de_Servicio_de_ApoyoData.Tipo_de_Servicio
                    ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Tipo_de_Servicio), "Tipo_de_Servicio_de_Apoyo") ??  (string)Detalle_de_Servicio_de_ApoyoData.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
                    ,Requiere_Traductor = Detalle_de_Servicio_de_ApoyoData.Requiere_Traductor.GetValueOrDefault()
                    ,Lengua_Originaria = Detalle_de_Servicio_de_ApoyoData.Lengua_Originaria
                    ,Lengua_OriginariaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Lengua_Originaria), "Dialecto") ??  (string)Detalle_de_Servicio_de_ApoyoData.Lengua_Originaria_Dialecto.Descripcion
                    ,Idioma = Detalle_de_Servicio_de_ApoyoData.Idioma
                    ,IdiomaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Idioma), "Idioma") ??  (string)Detalle_de_Servicio_de_ApoyoData.Idioma_Idioma.Descripcion
                    ,Responsable = Detalle_de_Servicio_de_ApoyoData.Responsable
                    ,Compareciente = Detalle_de_Servicio_de_ApoyoData.Compareciente
                    ,ComparecienteNombre_Completo = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Compareciente), "Compareciente") ??  (string)Detalle_de_Servicio_de_ApoyoData.Compareciente_Compareciente.Nombre_Completo
                    ,Documento_Atencion_Inicial = Detalle_de_Servicio_de_ApoyoData.Documento_Atencion_Inicial
                    ,Documento_Atencion_InicialObservaciones = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Documento_Atencion_Inicial), "Detalle_de_Documentos_MPO") ??  (string)Detalle_de_Servicio_de_ApoyoData.Documento_Atencion_Inicial_Detalle_de_Documentos_MPO.Observaciones
                    ,Documento_Mecanismos_Alternos = Detalle_de_Servicio_de_ApoyoData.Documento_Mecanismos_Alternos
                    ,Documento_Mecanismos_AlternosDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Documento_Mecanismos_Alternos), "Detalle_de_documentos") ??  (string)Detalle_de_Servicio_de_ApoyoData.Documento_Mecanismos_Alternos_Detalle_de_documentos.Descripcion
                    ,Documento_Ministerio_Publico = Detalle_de_Servicio_de_ApoyoData.Documento_Ministerio_Publico
                    ,Documento_Ministerio_PublicoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Documento_Ministerio_Publico), "Diligencias_MP") ??  (string)Detalle_de_Servicio_de_ApoyoData.Documento_Ministerio_Publico_Diligencias_MP.Descripcion
                    ,Diligencia = Detalle_de_Servicio_de_ApoyoData.Diligencia
                    ,DiligenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Diligencia), "Documento") ??  (string)Detalle_de_Servicio_de_ApoyoData.Diligencia_Documento.Descripcion
                    ,Archivo = Detalle_de_Servicio_de_ApoyoData.Archivo
                    ,Fecha_de_Registro = (Detalle_de_Servicio_de_ApoyoData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Detalle_de_Servicio_de_ApoyoData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Fecha_de_Solicitud = (Detalle_de_Servicio_de_ApoyoData.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(Detalle_de_Servicio_de_ApoyoData.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Numero_Oficio = Detalle_de_Servicio_de_ApoyoData.Numero_Oficio
                    ,Imagen = Detalle_de_Servicio_de_ApoyoData.Imagen
                    ,Nombre_Solicitante = Detalle_de_Servicio_de_ApoyoData.Nombre_Solicitante
                    ,Rango_Solicitante = Detalle_de_Servicio_de_ApoyoData.Rango_Solicitante
                    ,Autoridades = Detalle_de_Servicio_de_ApoyoData.Autoridades
                    ,AutoridadesDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Autoridades), "Autoridad_Servicio_Pericial") ??  (string)Detalle_de_Servicio_de_ApoyoData.Autoridades_Autoridad_Servicio_Pericial.Descripcion
                    ,Agencia = Detalle_de_Servicio_de_ApoyoData.Agencia
                    ,AgenciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Agencia), "Agencia_Servicio_Pericial") ??  (string)Detalle_de_Servicio_de_ApoyoData.Agencia_Agencia_Servicio_Pericial.Descripcion
                    ,Observaciones = Detalle_de_Servicio_de_ApoyoData.Observaciones
                    ,Dictamen = Detalle_de_Servicio_de_ApoyoData.Dictamen
                    ,DictamenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Dictamen), "Dictamen_Servicio_Pericial") ??  (string)Detalle_de_Servicio_de_ApoyoData.Dictamen_Dictamen_Servicio_Pericial.Descripcion
                    ,Contestacion_lista_para_enviarse = Detalle_de_Servicio_de_ApoyoData.Contestacion_lista_para_enviarse.GetValueOrDefault()
                    ,Area_Pericial = Detalle_de_Servicio_de_ApoyoData.Area_Pericial
                    ,Area_PericialDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Area_Pericial), "Area_Pericial") ??  (string)Detalle_de_Servicio_de_ApoyoData.Area_Pericial_Area_Pericial.Descripcion
                    ,Perito = Detalle_de_Servicio_de_ApoyoData.Perito
                    ,PeritoName = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Servicio_de_ApoyoData.Perito), "Spartan_User") ??  (string)Detalle_de_Servicio_de_ApoyoData.Perito_Spartan_User.Name

					};
				}
                _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                ViewBag.ImagenSpartane_File = _ISpartane_FileApiConsumer.GetByKey(varDetalle_de_Servicio_de_Apoyo.Imagen).Resource;

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio != null && Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDialectoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dialectos_Lengua_Originaria = _IDialectoApiConsumer.SelAll(true);
            if (Dialectos_Lengua_Originaria != null && Dialectos_Lengua_Originaria.Resource != null)
                ViewBag.Dialectos_Lengua_Originaria = Dialectos_Lengua_Originaria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dialecto", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Comparecientes_Compareciente = _IComparecienteApiConsumer.SelAll(true);
            if (Comparecientes_Compareciente != null && Comparecientes_Compareciente.Resource != null)
                ViewBag.Comparecientes_Compareciente = Comparecientes_Compareciente.Resource.Where(m => m.Nombre_Completo != null).OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Compareciente", "Nombre_Completo") ?? m.Nombre_Completo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAutoridad_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Autoridad_Servicio_Pericials_Autoridades = _IAutoridad_Servicio_PericialApiConsumer.SelAll(true);
            if (Autoridad_Servicio_Pericials_Autoridades != null && Autoridad_Servicio_Pericials_Autoridades.Resource != null)
                ViewBag.Autoridad_Servicio_Pericials_Autoridades = Autoridad_Servicio_Pericials_Autoridades.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Autoridad_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgencia_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencia_Servicio_Pericials_Agencia = _IAgencia_Servicio_PericialApiConsumer.SelAll(true);
            if (Agencia_Servicio_Pericials_Agencia != null && Agencia_Servicio_Pericials_Agencia.Resource != null)
                ViewBag.Agencia_Servicio_Pericials_Agencia = Agencia_Servicio_Pericials_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Agencia_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDictamen_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dictamen_Servicio_Pericials_Dictamen = _IDictamen_Servicio_PericialApiConsumer.SelAll(true);
            if (Dictamen_Servicio_Pericials_Dictamen != null && Dictamen_Servicio_Pericials_Dictamen.Resource != null)
                ViewBag.Dictamen_Servicio_Pericials_Dictamen = Dictamen_Servicio_Pericials_Dictamen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dictamen_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_Pericials_Area_Pericial = _IArea_PericialApiConsumer.SelAll(true);
            if (Area_Pericials_Area_Pericial != null && Area_Pericials_Area_Pericial.Resource != null)
                ViewBag.Area_Pericials_Area_Pericial = Area_Pericials_Area_Pericial.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Perito = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Perito != null && Spartan_Users_Perito.Resource != null)
                ViewBag.Spartan_Users_Perito = Spartan_Users_Perito.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();


            return PartialView("AddDetalle_de_Servicio_de_Apoyo", varDetalle_de_Servicio_de_Apoyo);
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
        public ActionResult GetDialectoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDialectoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDialectoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dialecto", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetIdiomaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IIdiomaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetDetalle_de_Documentos_MPOAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Documentos_MPOApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Observaciones).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Documentos_MPO", "Observaciones")?? m.Observaciones,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetDetalle_de_documentosAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_documentosApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_documentosApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_documentos", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetDiligencias_MPAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDiligencias_MPApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Diligencias_MP", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
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
        public ActionResult GetAutoridad_Servicio_PericialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAutoridad_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAutoridad_Servicio_PericialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Autoridad_Servicio_Pericial", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetAgencia_Servicio_PericialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAgencia_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAgencia_Servicio_PericialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Agencia_Servicio_Pericial", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDictamen_Servicio_PericialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDictamen_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDictamen_Servicio_PericialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dictamen_Servicio_Pericial", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetArea_PericialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IArea_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IArea_PericialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_Pericial", "Descripcion")?? m.Descripcion,
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
        public ActionResult ShowAdvanceFilter(Detalle_de_Servicio_de_ApoyoAdvanceSearchModel model, int idFilter = -1)
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

            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio != null && Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDialectoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dialectos_Lengua_Originaria = _IDialectoApiConsumer.SelAll(true);
            if (Dialectos_Lengua_Originaria != null && Dialectos_Lengua_Originaria.Resource != null)
                ViewBag.Dialectos_Lengua_Originaria = Dialectos_Lengua_Originaria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dialecto", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Comparecientes_Compareciente = _IComparecienteApiConsumer.SelAll(true);
            if (Comparecientes_Compareciente != null && Comparecientes_Compareciente.Resource != null)
                ViewBag.Comparecientes_Compareciente = Comparecientes_Compareciente.Resource.Where(m => m.Nombre_Completo != null).OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Compareciente", "Nombre_Completo") ?? m.Nombre_Completo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAutoridad_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Autoridad_Servicio_Pericials_Autoridades = _IAutoridad_Servicio_PericialApiConsumer.SelAll(true);
            if (Autoridad_Servicio_Pericials_Autoridades != null && Autoridad_Servicio_Pericials_Autoridades.Resource != null)
                ViewBag.Autoridad_Servicio_Pericials_Autoridades = Autoridad_Servicio_Pericials_Autoridades.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Autoridad_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgencia_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencia_Servicio_Pericials_Agencia = _IAgencia_Servicio_PericialApiConsumer.SelAll(true);
            if (Agencia_Servicio_Pericials_Agencia != null && Agencia_Servicio_Pericials_Agencia.Resource != null)
                ViewBag.Agencia_Servicio_Pericials_Agencia = Agencia_Servicio_Pericials_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Agencia_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDictamen_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dictamen_Servicio_Pericials_Dictamen = _IDictamen_Servicio_PericialApiConsumer.SelAll(true);
            if (Dictamen_Servicio_Pericials_Dictamen != null && Dictamen_Servicio_Pericials_Dictamen.Resource != null)
                ViewBag.Dictamen_Servicio_Pericials_Dictamen = Dictamen_Servicio_Pericials_Dictamen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dictamen_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_Pericials_Area_Pericial = _IArea_PericialApiConsumer.SelAll(true);
            if (Area_Pericials_Area_Pericial != null && Area_Pericials_Area_Pericial.Resource != null)
                ViewBag.Area_Pericials_Area_Pericial = Area_Pericials_Area_Pericial.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Perito = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Perito != null && Spartan_Users_Perito.Resource != null)
                ViewBag.Spartan_Users_Perito = Spartan_Users_Perito.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _IOrigen_de_InvitacionApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Origen_de_Invitacions_Origen = _IOrigen_de_InvitacionApiConsumer.SelAll(true);
            if (Origen_de_Invitacions_Origen != null && Origen_de_Invitacions_Origen.Resource != null)
                ViewBag.Origen_de_Invitacions_Origen = Origen_de_Invitacions_Origen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Origen_de_Invitacion", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = _ITipo_de_Servicio_de_ApoyoApiConsumer.SelAll(true);
            if (Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio != null && Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource != null)
                ViewBag.Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio = Tipo_de_Servicio_de_Apoyos_Tipo_de_Servicio.Resource.Where(m => m.Servicio != null).OrderBy(m => m.Servicio).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Servicio_de_Apoyo", "Servicio") ?? m.Servicio.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDialectoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dialectos_Lengua_Originaria = _IDialectoApiConsumer.SelAll(true);
            if (Dialectos_Lengua_Originaria != null && Dialectos_Lengua_Originaria.Resource != null)
                ViewBag.Dialectos_Lengua_Originaria = Dialectos_Lengua_Originaria.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dialecto", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IIdiomaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Idiomas_Idioma = _IIdiomaApiConsumer.SelAll(true);
            if (Idiomas_Idioma != null && Idiomas_Idioma.Resource != null)
                ViewBag.Idiomas_Idioma = Idiomas_Idioma.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Idioma", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IComparecienteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Comparecientes_Compareciente = _IComparecienteApiConsumer.SelAll(true);
            if (Comparecientes_Compareciente != null && Comparecientes_Compareciente.Resource != null)
                ViewBag.Comparecientes_Compareciente = Comparecientes_Compareciente.Resource.Where(m => m.Nombre_Completo != null).OrderBy(m => m.Nombre_Completo).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Compareciente", "Nombre_Completo") ?? m.Nombre_Completo.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAutoridad_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Autoridad_Servicio_Pericials_Autoridades = _IAutoridad_Servicio_PericialApiConsumer.SelAll(true);
            if (Autoridad_Servicio_Pericials_Autoridades != null && Autoridad_Servicio_Pericials_Autoridades.Resource != null)
                ViewBag.Autoridad_Servicio_Pericials_Autoridades = Autoridad_Servicio_Pericials_Autoridades.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Autoridad_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IAgencia_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Agencia_Servicio_Pericials_Agencia = _IAgencia_Servicio_PericialApiConsumer.SelAll(true);
            if (Agencia_Servicio_Pericials_Agencia != null && Agencia_Servicio_Pericials_Agencia.Resource != null)
                ViewBag.Agencia_Servicio_Pericials_Agencia = Agencia_Servicio_Pericials_Agencia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Agencia_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDictamen_Servicio_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Dictamen_Servicio_Pericials_Dictamen = _IDictamen_Servicio_PericialApiConsumer.SelAll(true);
            if (Dictamen_Servicio_Pericials_Dictamen != null && Dictamen_Servicio_Pericials_Dictamen.Resource != null)
                ViewBag.Dictamen_Servicio_Pericials_Dictamen = Dictamen_Servicio_Pericials_Dictamen.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Dictamen_Servicio_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IArea_PericialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Area_Pericials_Area_Pericial = _IArea_PericialApiConsumer.SelAll(true);
            if (Area_Pericials_Area_Pericial != null && Area_Pericials_Area_Pericial.Resource != null)
                ViewBag.Area_Pericials_Area_Pericial = Area_Pericials_Area_Pericial.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Area_Pericial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ISpartan_UserApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Spartan_Users_Perito = _ISpartan_UserApiConsumer.SelAll(true);
            if (Spartan_Users_Perito != null && Spartan_Users_Perito.Resource != null)
                ViewBag.Spartan_Users_Perito = Spartan_Users_Perito.Resource.Where(m => m.Name != null).OrderBy(m => m.Name).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Id_User), "Spartan_User", "Name") ?? m.Name.ToString(), Value = Convert.ToString(m.Id_User)
                }).ToList();


            var previousFiltersObj = new Detalle_de_Servicio_de_ApoyoAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_de_Servicio_de_ApoyoAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_de_Servicio_de_ApoyoAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Servicio_de_ApoyoPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Servicio_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Servicio_de_Apoyos == null)
                result.Detalle_de_Servicio_de_Apoyos = new List<Detalle_de_Servicio_de_Apoyo>();

            return Json(new
            {
                data = result.Detalle_de_Servicio_de_Apoyos.Select(m => new Detalle_de_Servicio_de_ApoyoGridModel
                    {
                    Clave = m.Clave
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Modulo_de_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Modulo_Mecanismos_AlternosCDI = CultureHelper.GetTraduction(m.Modulo_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Modulo_Mecanismos_Alternos_Solicitud.CDI
                        ,Modulo_Ministerio_Publiconic = CultureHelper.GetTraduction(m.Modulo_Ministerio_Publico_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Modulo_Ministerio_Publico_expediente_ministerio_publico.nic
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Requiere_Traductor = m.Requiere_Traductor
                        ,Lengua_OriginariaDescripcion = CultureHelper.GetTraduction(m.Lengua_Originaria_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Lengua_Originaria_Dialecto.Descripcion
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
			,Responsable = m.Responsable
                        ,ComparecienteNombre_Completo = CultureHelper.GetTraduction(m.Compareciente_Compareciente.Clave.ToString(), "Nombre_Completo") ?? (string)m.Compareciente_Compareciente.Nombre_Completo
                        ,Documento_Atencion_InicialObservaciones = CultureHelper.GetTraduction(m.Documento_Atencion_Inicial_Detalle_de_Documentos_MPO.Clave.ToString(), "Detalle_de_Documentos_MPO") ?? (string)m.Documento_Atencion_Inicial_Detalle_de_Documentos_MPO.Observaciones
                        ,Documento_Mecanismos_AlternosDescripcion = CultureHelper.GetTraduction(m.Documento_Mecanismos_Alternos_Detalle_de_documentos.Clave.ToString(), "Detalle_de_documentos") ?? (string)m.Documento_Mecanismos_Alternos_Detalle_de_documentos.Descripcion
                        ,Documento_Ministerio_PublicoDescripcion = CultureHelper.GetTraduction(m.Documento_Ministerio_Publico_Diligencias_MP.Clave.ToString(), "Diligencias_MP") ?? (string)m.Documento_Ministerio_Publico_Diligencias_MP.Descripcion
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Documento.Clave.ToString(), "Documento") ?? (string)m.Diligencia_Documento.Descripcion
			,Archivo = m.Archivo
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Numero_Oficio = m.Numero_Oficio
			,Imagen = m.Imagen
			,Nombre_Solicitante = m.Nombre_Solicitante
			,Rango_Solicitante = m.Rango_Solicitante
                        ,AutoridadesDescripcion = CultureHelper.GetTraduction(m.Autoridades_Autoridad_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Autoridades_Autoridad_Servicio_Pericial.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia_Servicio_Pericial.Descripcion
			,Observaciones = m.Observaciones
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Dictamen_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Dictamen_Dictamen_Servicio_Pericial.Descripcion
			,Contestacion_lista_para_enviarse = m.Contestacion_lista_para_enviarse
                        ,Area_PericialDescripcion = CultureHelper.GetTraduction(m.Area_Pericial_Area_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Area_Pericial_Area_Pericial.Descripcion
                        ,PeritoName = CultureHelper.GetTraduction(m.Perito_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Perito_Spartan_User.Name

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_de_Servicio_de_ApoyoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Servicio_de_ApoyoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_de_Servicio_de_Apoyo", m.),
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
        /// Get List of Detalle_de_Servicio_de_Apoyo from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_de_Servicio_de_Apoyo Entity</returns>
        public ActionResult GetDetalle_de_Servicio_de_ApoyoList(UrlParametersModel param)
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
            _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_de_Servicio_de_ApoyoPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_de_Servicio_de_ApoyoAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_de_Servicio_de_ApoyoAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_de_Servicio_de_ApoyoPropertyMapper oDetalle_de_Servicio_de_ApoyoPropertyMapper = new Detalle_de_Servicio_de_ApoyoPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_de_Servicio_de_ApoyoPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_de_Servicio_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Servicio_de_Apoyos == null)
                result.Detalle_de_Servicio_de_Apoyos = new List<Detalle_de_Servicio_de_Apoyo>();

            return Json(new
            {
                aaData = result.Detalle_de_Servicio_de_Apoyos.Select(m => new Detalle_de_Servicio_de_ApoyoGridModel
            {
                    Clave = m.Clave
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Modulo_de_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Modulo_Mecanismos_AlternosCDI = CultureHelper.GetTraduction(m.Modulo_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Modulo_Mecanismos_Alternos_Solicitud.CDI
                        ,Modulo_Ministerio_Publiconic = CultureHelper.GetTraduction(m.Modulo_Ministerio_Publico_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Modulo_Ministerio_Publico_expediente_ministerio_publico.nic
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Requiere_Traductor = m.Requiere_Traductor
                        ,Lengua_OriginariaDescripcion = CultureHelper.GetTraduction(m.Lengua_Originaria_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Lengua_Originaria_Dialecto.Descripcion
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
			,Responsable = m.Responsable
                        ,ComparecienteNombre_Completo = CultureHelper.GetTraduction(m.Compareciente_Compareciente.Clave.ToString(), "Nombre_Completo") ?? (string)m.Compareciente_Compareciente.Nombre_Completo
                        ,Documento_Atencion_InicialObservaciones = CultureHelper.GetTraduction(m.Documento_Atencion_Inicial_Detalle_de_Documentos_MPO.Clave.ToString(), "Detalle_de_Documentos_MPO") ?? (string)m.Documento_Atencion_Inicial_Detalle_de_Documentos_MPO.Observaciones
                        ,Documento_Mecanismos_AlternosDescripcion = CultureHelper.GetTraduction(m.Documento_Mecanismos_Alternos_Detalle_de_documentos.Clave.ToString(), "Detalle_de_documentos") ?? (string)m.Documento_Mecanismos_Alternos_Detalle_de_documentos.Descripcion
                        ,Documento_Ministerio_PublicoDescripcion = CultureHelper.GetTraduction(m.Documento_Ministerio_Publico_Diligencias_MP.Clave.ToString(), "Diligencias_MP") ?? (string)m.Documento_Ministerio_Publico_Diligencias_MP.Descripcion
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Documento.Clave.ToString(), "Documento") ?? (string)m.Diligencia_Documento.Descripcion
			,Archivo = m.Archivo
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Numero_Oficio = m.Numero_Oficio
			,Imagen = m.Imagen
			,Nombre_Solicitante = m.Nombre_Solicitante
			,Rango_Solicitante = m.Rango_Solicitante
                        ,AutoridadesDescripcion = CultureHelper.GetTraduction(m.Autoridades_Autoridad_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Autoridades_Autoridad_Servicio_Pericial.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia_Servicio_Pericial.Descripcion
			,Observaciones = m.Observaciones
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Dictamen_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Dictamen_Dictamen_Servicio_Pericial.Descripcion
			,Contestacion_lista_para_enviarse = m.Contestacion_lista_para_enviarse
                        ,Area_PericialDescripcion = CultureHelper.GetTraduction(m.Area_Pericial_Area_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Area_Pericial_Area_Pericial.Descripcion
                        ,PeritoName = CultureHelper.GetTraduction(m.Perito_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Perito_Spartan_User.Name

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Servicio_de_Apoyo_Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial(string query, string where)
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
        public JsonResult GetDetalle_de_Servicio_de_Apoyo_Modulo_Mecanismos_Alternos_Solicitud(string query, string where)
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
        public JsonResult GetDetalle_de_Servicio_de_Apoyo_Modulo_Ministerio_Publico_expediente_ministerio_publico(string query, string where)
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
        public JsonResult GetDetalle_de_Servicio_de_Apoyo_Documento_Atencion_Inicial_Detalle_de_Documentos_MPO(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Documentos_MPOApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Documentos_MPO.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Documentos_MPO.Observaciones as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_Documentos_MPOApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Documentos_MPO.Observaciones ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Documentos_MPOs)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Documentos_MPO", "Observaciones");
                    item.Observaciones =trans ??item.Observaciones;
                }
                return Json(result.Detalle_de_Documentos_MPOs.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Servicio_de_Apoyo_Documento_Mecanismos_Alternos_Detalle_de_documentos(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_documentosApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_documentos.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_documentos.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_documentosApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_documentos.Descripcion ASC ").Resource;
               
                foreach (var item in result.Detalle_de_documentoss)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_documentos", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Detalle_de_documentoss.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Servicio_de_Apoyo_Documento_Ministerio_Publico_Diligencias_MP(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDiligencias_MPApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Diligencias_MP.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Diligencias_MP.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDiligencias_MPApiConsumer.ListaSelAll(1, 20,elWhere , " Diligencias_MP.Descripcion ASC ").Resource;
               
                foreach (var item in result.Diligencias_MPs)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Diligencias_MP", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Diligencias_MPs.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Servicio_de_Apoyo_Diligencia_Documento(string query, string where)
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





        [NonAction]
        public string GetAdvanceFilter(Detalle_de_Servicio_de_ApoyoAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_de_Servicio_de_Apoyo.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_de_Servicio_de_Apoyo.Clave <= " + filter.ToClave;
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

                where += " AND Detalle_de_Servicio_de_Apoyo.Origen In (" + OrigenIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModulo_de_Atencion_Inicial))
            {
                switch (filter.Modulo_de_Atencion_InicialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '" + filter.AdvanceModulo_de_Atencion_Inicial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceModulo_de_Atencion_Inicial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modulo_Atencion_Inicial.NUAT = '" + filter.AdvanceModulo_de_Atencion_Inicial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modulo_Atencion_Inicial.NUAT LIKE '%" + filter.AdvanceModulo_de_Atencion_Inicial + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModulo_de_Atencion_InicialMultiple != null && filter.AdvanceModulo_de_Atencion_InicialMultiple.Count() > 0)
            {
                var Modulo_de_Atencion_InicialIds = string.Join(",", filter.AdvanceModulo_de_Atencion_InicialMultiple);

                where += " AND Detalle_de_Servicio_de_Apoyo.Modulo_de_Atencion_Inicial In (" + Modulo_de_Atencion_InicialIds + ")";
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

                where += " AND Detalle_de_Servicio_de_Apoyo.Modulo_Mecanismos_Alternos In (" + Modulo_Mecanismos_AlternosIds + ")";
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

                where += " AND Detalle_de_Servicio_de_Apoyo.Modulo_Ministerio_Publico In (" + Modulo_Ministerio_PublicoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Servicio))
            {
                switch (filter.Tipo_de_ServicioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Servicio_de_Apoyo.Servicio LIKE '" + filter.AdvanceTipo_de_Servicio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Servicio_de_Apoyo.Servicio LIKE '%" + filter.AdvanceTipo_de_Servicio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Servicio_de_Apoyo.Servicio = '" + filter.AdvanceTipo_de_Servicio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Servicio_de_Apoyo.Servicio LIKE '%" + filter.AdvanceTipo_de_Servicio + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_ServicioMultiple != null && filter.AdvanceTipo_de_ServicioMultiple.Count() > 0)
            {
                var Tipo_de_ServicioIds = string.Join(",", filter.AdvanceTipo_de_ServicioMultiple);

                where += " AND Detalle_de_Servicio_de_Apoyo.Tipo_de_Servicio In (" + Tipo_de_ServicioIds + ")";
            }

            if (filter.Requiere_Traductor != RadioOptions.NoApply)
                where += " AND Detalle_de_Servicio_de_Apoyo.Requiere_Traductor = " + Convert.ToInt32(filter.Requiere_Traductor);

            if (!string.IsNullOrEmpty(filter.AdvanceLengua_Originaria))
            {
                switch (filter.Lengua_OriginariaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Dialecto.Descripcion LIKE '" + filter.AdvanceLengua_Originaria + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Dialecto.Descripcion LIKE '%" + filter.AdvanceLengua_Originaria + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Dialecto.Descripcion = '" + filter.AdvanceLengua_Originaria + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Dialecto.Descripcion LIKE '%" + filter.AdvanceLengua_Originaria + "%'";
                        break;
                }
            }
            else if (filter.AdvanceLengua_OriginariaMultiple != null && filter.AdvanceLengua_OriginariaMultiple.Count() > 0)
            {
                var Lengua_OriginariaIds = string.Join(",", filter.AdvanceLengua_OriginariaMultiple);

                where += " AND Detalle_de_Servicio_de_Apoyo.Lengua_Originaria In (" + Lengua_OriginariaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceIdioma))
            {
                switch (filter.IdiomaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Idioma.Descripcion LIKE '" + filter.AdvanceIdioma + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Idioma.Descripcion LIKE '%" + filter.AdvanceIdioma + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Idioma.Descripcion = '" + filter.AdvanceIdioma + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Idioma.Descripcion LIKE '%" + filter.AdvanceIdioma + "%'";
                        break;
                }
            }
            else if (filter.AdvanceIdiomaMultiple != null && filter.AdvanceIdiomaMultiple.Count() > 0)
            {
                var IdiomaIds = string.Join(",", filter.AdvanceIdiomaMultiple);

                where += " AND Detalle_de_Servicio_de_Apoyo.Idioma In (" + IdiomaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Responsable))
            {
                switch (filter.ResponsableFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Responsable LIKE '" + filter.Responsable + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Responsable LIKE '%" + filter.Responsable + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Responsable = '" + filter.Responsable + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Responsable LIKE '%" + filter.Responsable + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCompareciente))
            {
                switch (filter.ComparecienteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Compareciente.Nombre_Completo LIKE '" + filter.AdvanceCompareciente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Compareciente.Nombre_Completo LIKE '%" + filter.AdvanceCompareciente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Compareciente.Nombre_Completo = '" + filter.AdvanceCompareciente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Compareciente.Nombre_Completo LIKE '%" + filter.AdvanceCompareciente + "%'";
                        break;
                }
            }
            else if (filter.AdvanceComparecienteMultiple != null && filter.AdvanceComparecienteMultiple.Count() > 0)
            {
                var ComparecienteIds = string.Join(",", filter.AdvanceComparecienteMultiple);

                where += " AND Detalle_de_Servicio_de_Apoyo.Compareciente In (" + ComparecienteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDocumento_Atencion_Inicial))
            {
                switch (filter.Documento_Atencion_InicialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Documentos_MPO.Observaciones LIKE '" + filter.AdvanceDocumento_Atencion_Inicial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Documentos_MPO.Observaciones LIKE '%" + filter.AdvanceDocumento_Atencion_Inicial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Documentos_MPO.Observaciones = '" + filter.AdvanceDocumento_Atencion_Inicial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Documentos_MPO.Observaciones LIKE '%" + filter.AdvanceDocumento_Atencion_Inicial + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDocumento_Atencion_InicialMultiple != null && filter.AdvanceDocumento_Atencion_InicialMultiple.Count() > 0)
            {
                var Documento_Atencion_InicialIds = string.Join(",", filter.AdvanceDocumento_Atencion_InicialMultiple);

                where += " AND Detalle_de_Servicio_de_Apoyo.Documento_Atencion_Inicial In (" + Documento_Atencion_InicialIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDocumento_Mecanismos_Alternos))
            {
                switch (filter.Documento_Mecanismos_AlternosFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_documentos.Descripcion LIKE '" + filter.AdvanceDocumento_Mecanismos_Alternos + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_documentos.Descripcion LIKE '%" + filter.AdvanceDocumento_Mecanismos_Alternos + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_documentos.Descripcion = '" + filter.AdvanceDocumento_Mecanismos_Alternos + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_documentos.Descripcion LIKE '%" + filter.AdvanceDocumento_Mecanismos_Alternos + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDocumento_Mecanismos_AlternosMultiple != null && filter.AdvanceDocumento_Mecanismos_AlternosMultiple.Count() > 0)
            {
                var Documento_Mecanismos_AlternosIds = string.Join(",", filter.AdvanceDocumento_Mecanismos_AlternosMultiple);

                where += " AND Detalle_de_Servicio_de_Apoyo.Documento_Mecanismos_Alternos In (" + Documento_Mecanismos_AlternosIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDocumento_Ministerio_Publico))
            {
                switch (filter.Documento_Ministerio_PublicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Diligencias_MP.Descripcion LIKE '" + filter.AdvanceDocumento_Ministerio_Publico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Diligencias_MP.Descripcion LIKE '%" + filter.AdvanceDocumento_Ministerio_Publico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Diligencias_MP.Descripcion = '" + filter.AdvanceDocumento_Ministerio_Publico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Diligencias_MP.Descripcion LIKE '%" + filter.AdvanceDocumento_Ministerio_Publico + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDocumento_Ministerio_PublicoMultiple != null && filter.AdvanceDocumento_Ministerio_PublicoMultiple.Count() > 0)
            {
                var Documento_Ministerio_PublicoIds = string.Join(",", filter.AdvanceDocumento_Ministerio_PublicoMultiple);

                where += " AND Detalle_de_Servicio_de_Apoyo.Documento_Ministerio_Publico In (" + Documento_Ministerio_PublicoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDiligencia))
            {
                switch (filter.DiligenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Documento.Descripcion LIKE '" + filter.AdvanceDiligencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Documento.Descripcion LIKE '%" + filter.AdvanceDiligencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Documento.Descripcion = '" + filter.AdvanceDiligencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Documento.Descripcion LIKE '%" + filter.AdvanceDiligencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDiligenciaMultiple != null && filter.AdvanceDiligenciaMultiple.Count() > 0)
            {
                var DiligenciaIds = string.Join(",", filter.AdvanceDiligenciaMultiple);

                where += " AND Detalle_de_Servicio_de_Apoyo.Diligencia In (" + DiligenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromArchivo) || !string.IsNullOrEmpty(filter.ToArchivo))
            {
                if (!string.IsNullOrEmpty(filter.FromArchivo))
                    where += " AND Detalle_de_Servicio_de_Apoyo.Archivo >= " + filter.FromArchivo;
                if (!string.IsNullOrEmpty(filter.ToArchivo))
                    where += " AND Detalle_de_Servicio_de_Apoyo.Archivo <= " + filter.ToArchivo;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Detalle_de_Servicio_de_Apoyo.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Detalle_de_Servicio_de_Apoyo.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Solicitud) || !string.IsNullOrEmpty(filter.ToFecha_de_Solicitud))
            {
                var Fecha_de_SolicitudFrom = DateTime.ParseExact(filter.FromFecha_de_Solicitud, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_SolicitudTo = DateTime.ParseExact(filter.ToFecha_de_Solicitud, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Solicitud))
                    where += " AND Detalle_de_Servicio_de_Apoyo.Fecha_de_Solicitud >= '" + Fecha_de_SolicitudFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Solicitud))
                    where += " AND Detalle_de_Servicio_de_Apoyo.Fecha_de_Solicitud <= '" + Fecha_de_SolicitudTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Numero_Oficio))
            {
                switch (filter.Numero_OficioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Numero_Oficio LIKE '" + filter.Numero_Oficio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Numero_Oficio LIKE '%" + filter.Numero_Oficio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Numero_Oficio = '" + filter.Numero_Oficio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Numero_Oficio LIKE '%" + filter.Numero_Oficio + "%'";
                        break;
                }
            }

            if (filter.Imagen != RadioOptions.NoApply)
                where += " AND Detalle_de_Servicio_de_Apoyo.Imagen " + (filter.Imagen == RadioOptions.Yes ? ">" : "==") + " 0";

            if (!string.IsNullOrEmpty(filter.Nombre_Solicitante))
            {
                switch (filter.Nombre_SolicitanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Nombre_Solicitante LIKE '" + filter.Nombre_Solicitante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Nombre_Solicitante LIKE '%" + filter.Nombre_Solicitante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Nombre_Solicitante = '" + filter.Nombre_Solicitante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Nombre_Solicitante LIKE '%" + filter.Nombre_Solicitante + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Rango_Solicitante))
            {
                switch (filter.Rango_SolicitanteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Rango_Solicitante LIKE '" + filter.Rango_Solicitante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Rango_Solicitante LIKE '%" + filter.Rango_Solicitante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Rango_Solicitante = '" + filter.Rango_Solicitante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Rango_Solicitante LIKE '%" + filter.Rango_Solicitante + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAutoridades))
            {
                switch (filter.AutoridadesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Autoridad_Servicio_Pericial.Descripcion LIKE '" + filter.AdvanceAutoridades + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Autoridad_Servicio_Pericial.Descripcion LIKE '%" + filter.AdvanceAutoridades + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Autoridad_Servicio_Pericial.Descripcion = '" + filter.AdvanceAutoridades + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Autoridad_Servicio_Pericial.Descripcion LIKE '%" + filter.AdvanceAutoridades + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAutoridadesMultiple != null && filter.AdvanceAutoridadesMultiple.Count() > 0)
            {
                var AutoridadesIds = string.Join(",", filter.AdvanceAutoridadesMultiple);

                where += " AND Detalle_de_Servicio_de_Apoyo.Autoridades In (" + AutoridadesIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceAgencia))
            {
                switch (filter.AgenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Agencia_Servicio_Pericial.Descripcion LIKE '" + filter.AdvanceAgencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Agencia_Servicio_Pericial.Descripcion LIKE '%" + filter.AdvanceAgencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Agencia_Servicio_Pericial.Descripcion = '" + filter.AdvanceAgencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Agencia_Servicio_Pericial.Descripcion LIKE '%" + filter.AdvanceAgencia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceAgenciaMultiple != null && filter.AdvanceAgenciaMultiple.Count() > 0)
            {
                var AgenciaIds = string.Join(",", filter.AdvanceAgenciaMultiple);

                where += " AND Detalle_de_Servicio_de_Apoyo.Agencia In (" + AgenciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Servicio_de_Apoyo.Observaciones LIKE '%" + filter.Observaciones + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDictamen))
            {
                switch (filter.DictamenFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Dictamen_Servicio_Pericial.Descripcion LIKE '" + filter.AdvanceDictamen + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Dictamen_Servicio_Pericial.Descripcion LIKE '%" + filter.AdvanceDictamen + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Dictamen_Servicio_Pericial.Descripcion = '" + filter.AdvanceDictamen + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Dictamen_Servicio_Pericial.Descripcion LIKE '%" + filter.AdvanceDictamen + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDictamenMultiple != null && filter.AdvanceDictamenMultiple.Count() > 0)
            {
                var DictamenIds = string.Join(",", filter.AdvanceDictamenMultiple);

                where += " AND Detalle_de_Servicio_de_Apoyo.Dictamen In (" + DictamenIds + ")";
            }

            if (filter.Contestacion_lista_para_enviarse != RadioOptions.NoApply)
                where += " AND Detalle_de_Servicio_de_Apoyo.Contestacion_lista_para_enviarse = " + Convert.ToInt32(filter.Contestacion_lista_para_enviarse);

            if (!string.IsNullOrEmpty(filter.AdvanceArea_Pericial))
            {
                switch (filter.Area_PericialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Area_Pericial.Descripcion LIKE '" + filter.AdvanceArea_Pericial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Area_Pericial.Descripcion LIKE '%" + filter.AdvanceArea_Pericial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Area_Pericial.Descripcion = '" + filter.AdvanceArea_Pericial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Area_Pericial.Descripcion LIKE '%" + filter.AdvanceArea_Pericial + "%'";
                        break;
                }
            }
            else if (filter.AdvanceArea_PericialMultiple != null && filter.AdvanceArea_PericialMultiple.Count() > 0)
            {
                var Area_PericialIds = string.Join(",", filter.AdvanceArea_PericialMultiple);

                where += " AND Detalle_de_Servicio_de_Apoyo.Area_Pericial In (" + Area_PericialIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePerito))
            {
                switch (filter.PeritoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Spartan_User.Name LIKE '" + filter.AdvancePerito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvancePerito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Spartan_User.Name = '" + filter.AdvancePerito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Spartan_User.Name LIKE '%" + filter.AdvancePerito + "%'";
                        break;
                }
            }
            else if (filter.AdvancePeritoMultiple != null && filter.AdvancePeritoMultiple.Count() > 0)
            {
                var PeritoIds = string.Join(",", filter.AdvancePeritoMultiple);

                where += " AND Detalle_de_Servicio_de_Apoyo.Perito In (" + PeritoIds + ")";
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
                _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Servicio_de_Apoyo varDetalle_de_Servicio_de_Apoyo = null;
                if (id.ToString() != "0")
                {
                        string where = "";

                }
                var result = _IDetalle_de_Servicio_de_ApoyoApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Servicio_de_ApoyoModel varDetalle_de_Servicio_de_Apoyo)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);


                    if (varDetalle_de_Servicio_de_Apoyo.ImagenRemoveAttachment != 0 && varDetalle_de_Servicio_de_Apoyo.ImagenFile == null)
                    {
                        varDetalle_de_Servicio_de_Apoyo.Imagen = 0;
                    }

                    if (varDetalle_de_Servicio_de_Apoyo.ImagenFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Servicio_de_Apoyo.ImagenFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Servicio_de_Apoyo.Imagen = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Servicio_de_Apoyo.ImagenFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                    
                    var result = "";
                    var Detalle_de_Servicio_de_ApoyoInfo = new Detalle_de_Servicio_de_Apoyo
                    {
                        Clave = varDetalle_de_Servicio_de_Apoyo.Clave
                        ,Origen = varDetalle_de_Servicio_de_Apoyo.Origen
                        ,Modulo_de_Atencion_Inicial = varDetalle_de_Servicio_de_Apoyo.Modulo_de_Atencion_Inicial
                        ,Modulo_Mecanismos_Alternos = varDetalle_de_Servicio_de_Apoyo.Modulo_Mecanismos_Alternos
                        ,Modulo_Ministerio_Publico = varDetalle_de_Servicio_de_Apoyo.Modulo_Ministerio_Publico
                        ,Tipo_de_Servicio = varDetalle_de_Servicio_de_Apoyo.Tipo_de_Servicio
                        ,Requiere_Traductor = varDetalle_de_Servicio_de_Apoyo.Requiere_Traductor
                        ,Lengua_Originaria = varDetalle_de_Servicio_de_Apoyo.Lengua_Originaria
                        ,Idioma = varDetalle_de_Servicio_de_Apoyo.Idioma
                        ,Responsable = varDetalle_de_Servicio_de_Apoyo.Responsable
                        ,Compareciente = varDetalle_de_Servicio_de_Apoyo.Compareciente
                        ,Documento_Atencion_Inicial = varDetalle_de_Servicio_de_Apoyo.Documento_Atencion_Inicial
                        ,Documento_Mecanismos_Alternos = varDetalle_de_Servicio_de_Apoyo.Documento_Mecanismos_Alternos
                        ,Documento_Ministerio_Publico = varDetalle_de_Servicio_de_Apoyo.Documento_Ministerio_Publico
                        ,Diligencia = varDetalle_de_Servicio_de_Apoyo.Diligencia
                        ,Archivo = varDetalle_de_Servicio_de_Apoyo.Archivo
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varDetalle_de_Servicio_de_Apoyo.Fecha_de_Registro)) ? DateTime.ParseExact(varDetalle_de_Servicio_de_Apoyo.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Fecha_de_Solicitud = (!String.IsNullOrEmpty(varDetalle_de_Servicio_de_Apoyo.Fecha_de_Solicitud)) ? DateTime.ParseExact(varDetalle_de_Servicio_de_Apoyo.Fecha_de_Solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Numero_Oficio = varDetalle_de_Servicio_de_Apoyo.Numero_Oficio
                        ,Imagen = (varDetalle_de_Servicio_de_Apoyo.Imagen.HasValue && varDetalle_de_Servicio_de_Apoyo.Imagen != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Servicio_de_Apoyo.Imagen.Value)) : null

                        ,Nombre_Solicitante = varDetalle_de_Servicio_de_Apoyo.Nombre_Solicitante
                        ,Rango_Solicitante = varDetalle_de_Servicio_de_Apoyo.Rango_Solicitante
                        ,Autoridades = varDetalle_de_Servicio_de_Apoyo.Autoridades
                        ,Agencia = varDetalle_de_Servicio_de_Apoyo.Agencia
                        ,Observaciones = varDetalle_de_Servicio_de_Apoyo.Observaciones
                        ,Dictamen = varDetalle_de_Servicio_de_Apoyo.Dictamen
                        ,Contestacion_lista_para_enviarse = varDetalle_de_Servicio_de_Apoyo.Contestacion_lista_para_enviarse
                        ,Area_Pericial = varDetalle_de_Servicio_de_Apoyo.Area_Pericial
                        ,Perito = varDetalle_de_Servicio_de_Apoyo.Perito

                    };

                    result = !IsNew ?
                        _IDetalle_de_Servicio_de_ApoyoApiConsumer.Update(Detalle_de_Servicio_de_ApoyoInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Servicio_de_ApoyoApiConsumer.Insert(Detalle_de_Servicio_de_ApoyoInfo, null, null).Resource.ToString();
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
        /// Write Element Array of Detalle_de_Servicio_de_Apoyo script
        /// </summary>
        /// <param name="oDetalle_de_Servicio_de_ApoyoElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_de_Servicio_de_ApoyoModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Servicio_de_ApoyoModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Servicio_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Servicio_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Servicio_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Servicio_de_ApoyoModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Servicio_de_ApoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Servicio_de_ApoyoModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_de_Servicio_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_de_Servicio_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_de_Servicio_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_de_Servicio_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_de_Servicio_de_ApoyoModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_de_Servicio_de_ApoyoScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Servicio_de_Apoyo.js")))
            {
                strDetalle_de_Servicio_de_ApoyoScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Servicio_de_Apoyo element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Servicio_de_ApoyoModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Servicio_de_ApoyoScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Servicio_de_ApoyoScript.Substring(indexOfArray, strDetalle_de_Servicio_de_ApoyoScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Servicio_de_ApoyoModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Servicio_de_ApoyoModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Servicio_de_ApoyoScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_de_Servicio_de_ApoyoScript.Substring(indexOfArrayHistory, strDetalle_de_Servicio_de_ApoyoScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_de_Servicio_de_ApoyoScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Servicio_de_ApoyoScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Servicio_de_ApoyoScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_de_Servicio_de_ApoyoModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_de_Servicio_de_ApoyoModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Servicio_de_Apoyo.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Servicio_de_Apoyo.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Servicio_de_Apoyo.js")))
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
        public ActionResult Detalle_de_Servicio_de_ApoyoPropertyBag()
        {
            return PartialView("Detalle_de_Servicio_de_ApoyoPropertyBag", "Detalle_de_Servicio_de_Apoyo");
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
                var whereClauseFormat = "Object = 45039 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_de_Servicio_de_Apoyo.Clave= " + RecordId;
                            var result = _IDetalle_de_Servicio_de_ApoyoApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Servicio_de_ApoyoPropertyMapper());
			
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
                    (Detalle_de_Servicio_de_ApoyoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_de_Servicio_de_ApoyoPropertyMapper oDetalle_de_Servicio_de_ApoyoPropertyMapper = new Detalle_de_Servicio_de_ApoyoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Servicio_de_ApoyoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Servicio_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Servicio_de_Apoyos == null)
                result.Detalle_de_Servicio_de_Apoyos = new List<Detalle_de_Servicio_de_Apoyo>();

            var data = result.Detalle_de_Servicio_de_Apoyos.Select(m => new Detalle_de_Servicio_de_ApoyoGridModel
            {
                Clave = m.Clave
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Modulo_de_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Modulo_Mecanismos_AlternosCDI = CultureHelper.GetTraduction(m.Modulo_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Modulo_Mecanismos_Alternos_Solicitud.CDI
                        ,Modulo_Ministerio_Publiconic = CultureHelper.GetTraduction(m.Modulo_Ministerio_Publico_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Modulo_Ministerio_Publico_expediente_ministerio_publico.nic
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Requiere_Traductor = m.Requiere_Traductor
                        ,Lengua_OriginariaDescripcion = CultureHelper.GetTraduction(m.Lengua_Originaria_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Lengua_Originaria_Dialecto.Descripcion
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
			,Responsable = m.Responsable
                        ,ComparecienteNombre_Completo = CultureHelper.GetTraduction(m.Compareciente_Compareciente.Clave.ToString(), "Nombre_Completo") ?? (string)m.Compareciente_Compareciente.Nombre_Completo
                        ,Documento_Atencion_InicialObservaciones = CultureHelper.GetTraduction(m.Documento_Atencion_Inicial_Detalle_de_Documentos_MPO.Clave.ToString(), "Detalle_de_Documentos_MPO") ?? (string)m.Documento_Atencion_Inicial_Detalle_de_Documentos_MPO.Observaciones
                        ,Documento_Mecanismos_AlternosDescripcion = CultureHelper.GetTraduction(m.Documento_Mecanismos_Alternos_Detalle_de_documentos.Clave.ToString(), "Detalle_de_documentos") ?? (string)m.Documento_Mecanismos_Alternos_Detalle_de_documentos.Descripcion
                        ,Documento_Ministerio_PublicoDescripcion = CultureHelper.GetTraduction(m.Documento_Ministerio_Publico_Diligencias_MP.Clave.ToString(), "Diligencias_MP") ?? (string)m.Documento_Ministerio_Publico_Diligencias_MP.Descripcion
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Documento.Clave.ToString(), "Documento") ?? (string)m.Diligencia_Documento.Descripcion
			,Archivo = m.Archivo
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Numero_Oficio = m.Numero_Oficio
			,Imagen = m.Imagen
			,Nombre_Solicitante = m.Nombre_Solicitante
			,Rango_Solicitante = m.Rango_Solicitante
                        ,AutoridadesDescripcion = CultureHelper.GetTraduction(m.Autoridades_Autoridad_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Autoridades_Autoridad_Servicio_Pericial.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia_Servicio_Pericial.Descripcion
			,Observaciones = m.Observaciones
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Dictamen_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Dictamen_Dictamen_Servicio_Pericial.Descripcion
			,Contestacion_lista_para_enviarse = m.Contestacion_lista_para_enviarse
                        ,Area_PericialDescripcion = CultureHelper.GetTraduction(m.Area_Pericial_Area_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Area_Pericial_Area_Pericial.Descripcion
                        ,PeritoName = CultureHelper.GetTraduction(m.Perito_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Perito_Spartan_User.Name

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45039, arrayColumnsVisible), "Detalle_de_Servicio_de_ApoyoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45039, arrayColumnsVisible), "Detalle_de_Servicio_de_ApoyoList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45039, arrayColumnsVisible), "Detalle_de_Servicio_de_ApoyoList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Servicio_de_ApoyoPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_de_Servicio_de_ApoyoAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_de_Servicio_de_ApoyoPropertyMapper oDetalle_de_Servicio_de_ApoyoPropertyMapper = new Detalle_de_Servicio_de_ApoyoPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Servicio_de_ApoyoPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Servicio_de_ApoyoApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Servicio_de_Apoyos == null)
                result.Detalle_de_Servicio_de_Apoyos = new List<Detalle_de_Servicio_de_Apoyo>();

            var data = result.Detalle_de_Servicio_de_Apoyos.Select(m => new Detalle_de_Servicio_de_ApoyoGridModel
            {
                Clave = m.Clave
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Modulo_de_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Modulo_Mecanismos_AlternosCDI = CultureHelper.GetTraduction(m.Modulo_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Modulo_Mecanismos_Alternos_Solicitud.CDI
                        ,Modulo_Ministerio_Publiconic = CultureHelper.GetTraduction(m.Modulo_Ministerio_Publico_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Modulo_Ministerio_Publico_expediente_ministerio_publico.nic
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Requiere_Traductor = m.Requiere_Traductor
                        ,Lengua_OriginariaDescripcion = CultureHelper.GetTraduction(m.Lengua_Originaria_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Lengua_Originaria_Dialecto.Descripcion
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
			,Responsable = m.Responsable
                        ,ComparecienteNombre_Completo = CultureHelper.GetTraduction(m.Compareciente_Compareciente.Clave.ToString(), "Nombre_Completo") ?? (string)m.Compareciente_Compareciente.Nombre_Completo
                        ,Documento_Atencion_InicialObservaciones = CultureHelper.GetTraduction(m.Documento_Atencion_Inicial_Detalle_de_Documentos_MPO.Clave.ToString(), "Detalle_de_Documentos_MPO") ?? (string)m.Documento_Atencion_Inicial_Detalle_de_Documentos_MPO.Observaciones
                        ,Documento_Mecanismos_AlternosDescripcion = CultureHelper.GetTraduction(m.Documento_Mecanismos_Alternos_Detalle_de_documentos.Clave.ToString(), "Detalle_de_documentos") ?? (string)m.Documento_Mecanismos_Alternos_Detalle_de_documentos.Descripcion
                        ,Documento_Ministerio_PublicoDescripcion = CultureHelper.GetTraduction(m.Documento_Ministerio_Publico_Diligencias_MP.Clave.ToString(), "Diligencias_MP") ?? (string)m.Documento_Ministerio_Publico_Diligencias_MP.Descripcion
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Documento.Clave.ToString(), "Documento") ?? (string)m.Diligencia_Documento.Descripcion
			,Archivo = m.Archivo
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Numero_Oficio = m.Numero_Oficio
			,Imagen = m.Imagen
			,Nombre_Solicitante = m.Nombre_Solicitante
			,Rango_Solicitante = m.Rango_Solicitante
                        ,AutoridadesDescripcion = CultureHelper.GetTraduction(m.Autoridades_Autoridad_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Autoridades_Autoridad_Servicio_Pericial.Descripcion
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia_Servicio_Pericial.Descripcion
			,Observaciones = m.Observaciones
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Dictamen_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Dictamen_Dictamen_Servicio_Pericial.Descripcion
			,Contestacion_lista_para_enviarse = m.Contestacion_lista_para_enviarse
                        ,Area_PericialDescripcion = CultureHelper.GetTraduction(m.Area_Pericial_Area_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Area_Pericial_Area_Pericial.Descripcion
                        ,PeritoName = CultureHelper.GetTraduction(m.Perito_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Perito_Spartan_User.Name

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
                _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Servicio_de_ApoyoApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_de_Servicio_de_Apoyo_Datos_GeneralesModel varDetalle_de_Servicio_de_Apoyo)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
				                    if (varDetalle_de_Servicio_de_Apoyo.ImagenRemoveAttachment != 0 && varDetalle_de_Servicio_de_Apoyo.ImagenFile == null)
                    {
                        varDetalle_de_Servicio_de_Apoyo.Imagen = 0;
                    }

                    if (varDetalle_de_Servicio_de_Apoyo.ImagenFile != null)
                    {
                        var fileAsBytes = HttpPostedFileHelper.GetPostedFileAsBytes(varDetalle_de_Servicio_de_Apoyo.ImagenFile);
                        _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                        varDetalle_de_Servicio_de_Apoyo.Imagen = (int)_ISpartane_FileApiConsumer.Insert(new Spartane_File()
                        {
                            File = fileAsBytes,
                            Description = varDetalle_de_Servicio_de_Apoyo.ImagenFile.FileName,
                            File_Size = fileAsBytes.Length
                        }).Resource;
                    }

                var result = "";
                var Detalle_de_Servicio_de_Apoyo_Datos_GeneralesInfo = new Detalle_de_Servicio_de_Apoyo_Datos_Generales
                {
                    Clave = varDetalle_de_Servicio_de_Apoyo.Clave
                                            ,Origen = varDetalle_de_Servicio_de_Apoyo.Origen
                        ,Modulo_de_Atencion_Inicial = varDetalle_de_Servicio_de_Apoyo.Modulo_de_Atencion_Inicial
                        ,Modulo_Mecanismos_Alternos = varDetalle_de_Servicio_de_Apoyo.Modulo_Mecanismos_Alternos
                        ,Modulo_Ministerio_Publico = varDetalle_de_Servicio_de_Apoyo.Modulo_Ministerio_Publico
                        ,Tipo_de_Servicio = varDetalle_de_Servicio_de_Apoyo.Tipo_de_Servicio
                        ,Requiere_Traductor = varDetalle_de_Servicio_de_Apoyo.Requiere_Traductor
                        ,Lengua_Originaria = varDetalle_de_Servicio_de_Apoyo.Lengua_Originaria
                        ,Idioma = varDetalle_de_Servicio_de_Apoyo.Idioma
                        ,Responsable = varDetalle_de_Servicio_de_Apoyo.Responsable
                        ,Compareciente = varDetalle_de_Servicio_de_Apoyo.Compareciente
                        ,Documento_Atencion_Inicial = varDetalle_de_Servicio_de_Apoyo.Documento_Atencion_Inicial
                        ,Documento_Mecanismos_Alternos = varDetalle_de_Servicio_de_Apoyo.Documento_Mecanismos_Alternos
                        ,Documento_Ministerio_Publico = varDetalle_de_Servicio_de_Apoyo.Documento_Ministerio_Publico
                        ,Diligencia = varDetalle_de_Servicio_de_Apoyo.Diligencia
                        ,Archivo = varDetalle_de_Servicio_de_Apoyo.Archivo
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varDetalle_de_Servicio_de_Apoyo.Fecha_de_Registro)) ? DateTime.ParseExact(varDetalle_de_Servicio_de_Apoyo.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Fecha_de_Solicitud = (!String.IsNullOrEmpty(varDetalle_de_Servicio_de_Apoyo.Fecha_de_Solicitud)) ? DateTime.ParseExact(varDetalle_de_Servicio_de_Apoyo.Fecha_de_Solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Numero_Oficio = varDetalle_de_Servicio_de_Apoyo.Numero_Oficio
                        ,Imagen = (varDetalle_de_Servicio_de_Apoyo.Imagen.HasValue && varDetalle_de_Servicio_de_Apoyo.Imagen != 0) ? ((int?)Convert.ToInt32(varDetalle_de_Servicio_de_Apoyo.Imagen.Value)) : null

                        ,Nombre_Solicitante = varDetalle_de_Servicio_de_Apoyo.Nombre_Solicitante
                        ,Rango_Solicitante = varDetalle_de_Servicio_de_Apoyo.Rango_Solicitante
                        ,Autoridades = varDetalle_de_Servicio_de_Apoyo.Autoridades
                        ,Agencia = varDetalle_de_Servicio_de_Apoyo.Agencia
                        ,Observaciones = varDetalle_de_Servicio_de_Apoyo.Observaciones
                        ,Dictamen = varDetalle_de_Servicio_de_Apoyo.Dictamen
                        ,Contestacion_lista_para_enviarse = varDetalle_de_Servicio_de_Apoyo.Contestacion_lista_para_enviarse
                    
                };

                result = _IDetalle_de_Servicio_de_ApoyoApiConsumer.Update_Datos_Generales(Detalle_de_Servicio_de_Apoyo_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Servicio_de_ApoyoApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Detalle_de_Servicio_de_Apoyo_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Origen = m.Origen
                        ,OrigenDescripcion = CultureHelper.GetTraduction(m.Origen_Origen_de_Invitacion.Clave.ToString(), "Descripcion") ?? (string)m.Origen_Origen_de_Invitacion.Descripcion
                        ,Modulo_de_Atencion_Inicial = m.Modulo_de_Atencion_Inicial
                        ,Modulo_de_Atencion_InicialNUAT = CultureHelper.GetTraduction(m.Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial.Clave.ToString(), "Modulo_Atencion_Inicial") ?? (string)m.Modulo_de_Atencion_Inicial_Modulo_Atencion_Inicial.NUAT
                        ,Modulo_Mecanismos_Alternos = m.Modulo_Mecanismos_Alternos
                        ,Modulo_Mecanismos_AlternosCDI = CultureHelper.GetTraduction(m.Modulo_Mecanismos_Alternos_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Modulo_Mecanismos_Alternos_Solicitud.CDI
                        ,Modulo_Ministerio_Publico = m.Modulo_Ministerio_Publico
                        ,Modulo_Ministerio_Publiconic = CultureHelper.GetTraduction(m.Modulo_Ministerio_Publico_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Modulo_Ministerio_Publico_expediente_ministerio_publico.nic
                        ,Tipo_de_Servicio = m.Tipo_de_Servicio
                        ,Tipo_de_ServicioServicio = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Clave.ToString(), "Servicio") ?? (string)m.Tipo_de_Servicio_Tipo_de_Servicio_de_Apoyo.Servicio
			,Requiere_Traductor = m.Requiere_Traductor
                        ,Lengua_Originaria = m.Lengua_Originaria
                        ,Lengua_OriginariaDescripcion = CultureHelper.GetTraduction(m.Lengua_Originaria_Dialecto.Clave.ToString(), "Descripcion") ?? (string)m.Lengua_Originaria_Dialecto.Descripcion
                        ,Idioma = m.Idioma
                        ,IdiomaDescripcion = CultureHelper.GetTraduction(m.Idioma_Idioma.Clave.ToString(), "Descripcion") ?? (string)m.Idioma_Idioma.Descripcion
			,Responsable = m.Responsable
                        ,Compareciente = m.Compareciente
                        ,ComparecienteNombre_Completo = CultureHelper.GetTraduction(m.Compareciente_Compareciente.Clave.ToString(), "Nombre_Completo") ?? (string)m.Compareciente_Compareciente.Nombre_Completo
                        ,Documento_Atencion_Inicial = m.Documento_Atencion_Inicial
                        ,Documento_Atencion_InicialObservaciones = CultureHelper.GetTraduction(m.Documento_Atencion_Inicial_Detalle_de_Documentos_MPO.Clave.ToString(), "Detalle_de_Documentos_MPO") ?? (string)m.Documento_Atencion_Inicial_Detalle_de_Documentos_MPO.Observaciones
                        ,Documento_Mecanismos_Alternos = m.Documento_Mecanismos_Alternos
                        ,Documento_Mecanismos_AlternosDescripcion = CultureHelper.GetTraduction(m.Documento_Mecanismos_Alternos_Detalle_de_documentos.Clave.ToString(), "Detalle_de_documentos") ?? (string)m.Documento_Mecanismos_Alternos_Detalle_de_documentos.Descripcion
                        ,Documento_Ministerio_Publico = m.Documento_Ministerio_Publico
                        ,Documento_Ministerio_PublicoDescripcion = CultureHelper.GetTraduction(m.Documento_Ministerio_Publico_Diligencias_MP.Clave.ToString(), "Diligencias_MP") ?? (string)m.Documento_Ministerio_Publico_Diligencias_MP.Descripcion
                        ,Diligencia = m.Diligencia
                        ,DiligenciaDescripcion = CultureHelper.GetTraduction(m.Diligencia_Documento.Clave.ToString(), "Documento") ?? (string)m.Diligencia_Documento.Descripcion
			,Archivo = m.Archivo
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
			,Numero_Oficio = m.Numero_Oficio
			,Imagen = m.Imagen
			,Nombre_Solicitante = m.Nombre_Solicitante
			,Rango_Solicitante = m.Rango_Solicitante
                        ,Autoridades = m.Autoridades
                        ,AutoridadesDescripcion = CultureHelper.GetTraduction(m.Autoridades_Autoridad_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Autoridades_Autoridad_Servicio_Pericial.Descripcion
                        ,Agencia = m.Agencia
                        ,AgenciaDescripcion = CultureHelper.GetTraduction(m.Agencia_Agencia_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Agencia_Agencia_Servicio_Pericial.Descripcion
			,Observaciones = m.Observaciones
                        ,Dictamen = m.Dictamen
                        ,DictamenDescripcion = CultureHelper.GetTraduction(m.Dictamen_Dictamen_Servicio_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Dictamen_Dictamen_Servicio_Pericial.Descripcion
			,Contestacion_lista_para_enviarse = m.Contestacion_lista_para_enviarse

                    
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
        public ActionResult Post_Canalizar(Detalle_de_Servicio_de_Apoyo_CanalizarModel varDetalle_de_Servicio_de_Apoyo)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Servicio_de_Apoyo_CanalizarInfo = new Detalle_de_Servicio_de_Apoyo_Canalizar
                {
                    Clave = varDetalle_de_Servicio_de_Apoyo.Clave
                                            ,Area_Pericial = varDetalle_de_Servicio_de_Apoyo.Area_Pericial
                        ,Perito = varDetalle_de_Servicio_de_Apoyo.Perito
                    
                };

                result = _IDetalle_de_Servicio_de_ApoyoApiConsumer.Update_Canalizar(Detalle_de_Servicio_de_Apoyo_CanalizarInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Canalizar(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Servicio_de_ApoyoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Servicio_de_ApoyoApiConsumer.Get_Canalizar(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				
                var result = new Detalle_de_Servicio_de_Apoyo_CanalizarModel
                {
                    Clave = m.Clave
                        ,Area_Pericial = m.Area_Pericial
                        ,Area_PericialDescripcion = CultureHelper.GetTraduction(m.Area_Pericial_Area_Pericial.Clave.ToString(), "Descripcion") ?? (string)m.Area_Pericial_Area_Pericial.Descripcion
                        ,Perito = m.Perito
                        ,PeritoName = CultureHelper.GetTraduction(m.Perito_Spartan_User.Id_User.ToString(), "Name") ?? (string)m.Perito_Spartan_User.Name

                    
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

