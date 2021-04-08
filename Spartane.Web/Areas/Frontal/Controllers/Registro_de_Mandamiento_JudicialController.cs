using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Spartan_User;
using Spartane.Core.Domain.Tipo_de_Mandamiento;
using Spartane.Core.Domain.Fuente_de_Mandamiento_Judicial;
using Spartane.Core.Domain.Pais;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Institucion_Emisora;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Juzgado;
using Spartane.Core.Domain.Unidad;
using Spartane.Core.Domain.Estatus_de_Mandamiento_Judicial;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.Judicializacion;
using Spartane.Core.Domain.Detalle_de_Personas_a_Incluir;






using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Registro_de_Mandamiento_Judicial;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Registro_de_Mandamiento_Judicial;
using Spartane.Web.Areas.WebApiConsumer.Spartan_User;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Mandamiento;
using Spartane.Web.Areas.WebApiConsumer.Fuente_de_Mandamiento_Judicial;
using Spartane.Web.Areas.WebApiConsumer.Pais;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Institucion_Emisora;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Juzgado;
using Spartane.Web.Areas.WebApiConsumer.Unidad;
using Spartane.Web.Areas.WebApiConsumer.Estatus_de_Mandamiento_Judicial;
using Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico;
using Spartane.Web.Areas.WebApiConsumer.Judicializacion;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Personas_a_Incluir;




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
    public class Registro_de_Mandamiento_JudicialController : Controller
    {
        #region "variable declaration"

        private IRegistro_de_Mandamiento_JudicialService service = null;
        private IRegistro_de_Mandamiento_JudicialApiConsumer _IRegistro_de_Mandamiento_JudicialApiConsumer;
        private ISpartan_UserApiConsumer _ISpartan_UserApiConsumer;
        private ITipo_de_MandamientoApiConsumer _ITipo_de_MandamientoApiConsumer;
        private IFuente_de_Mandamiento_JudicialApiConsumer _IFuente_de_Mandamiento_JudicialApiConsumer;
        private IPaisApiConsumer _IPaisApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IInstitucion_EmisoraApiConsumer _IInstitucion_EmisoraApiConsumer;
        private IJuzgadoApiConsumer _IJuzgadoApiConsumer;
        private IUnidadApiConsumer _IUnidadApiConsumer;
        private IEstatus_de_Mandamiento_JudicialApiConsumer _IEstatus_de_Mandamiento_JudicialApiConsumer;
        private Iexpediente_ministerio_publicoApiConsumer _Iexpediente_ministerio_publicoApiConsumer;
        private IJudicializacionApiConsumer _IJudicializacionApiConsumer;
        private IDetalle_de_Personas_a_IncluirApiConsumer _IDetalle_de_Personas_a_IncluirApiConsumer;




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

        
        public Registro_de_Mandamiento_JudicialController(IRegistro_de_Mandamiento_JudicialService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IRegistro_de_Mandamiento_JudicialApiConsumer Registro_de_Mandamiento_JudicialApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISpartan_UserApiConsumer Spartan_UserApiConsumer , ITipo_de_MandamientoApiConsumer Tipo_de_MandamientoApiConsumer , IFuente_de_Mandamiento_JudicialApiConsumer Fuente_de_Mandamiento_JudicialApiConsumer , IPaisApiConsumer PaisApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IInstitucion_EmisoraApiConsumer Institucion_EmisoraApiConsumer , IJuzgadoApiConsumer JuzgadoApiConsumer , IUnidadApiConsumer UnidadApiConsumer , IEstatus_de_Mandamiento_JudicialApiConsumer Estatus_de_Mandamiento_JudicialApiConsumer , Iexpediente_ministerio_publicoApiConsumer expediente_ministerio_publicoApiConsumer , IJudicializacionApiConsumer JudicializacionApiConsumer , IDetalle_de_Personas_a_IncluirApiConsumer Detalle_de_Personas_a_IncluirApiConsumer  )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IRegistro_de_Mandamiento_JudicialApiConsumer = Registro_de_Mandamiento_JudicialApiConsumer;
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
            this._ITipo_de_MandamientoApiConsumer = Tipo_de_MandamientoApiConsumer;
            this._IFuente_de_Mandamiento_JudicialApiConsumer = Fuente_de_Mandamiento_JudicialApiConsumer;
            this._IPaisApiConsumer = PaisApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IInstitucion_EmisoraApiConsumer = Institucion_EmisoraApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IJuzgadoApiConsumer = JuzgadoApiConsumer;
            this._IUnidadApiConsumer = UnidadApiConsumer;
            this._IEstatus_de_Mandamiento_JudicialApiConsumer = Estatus_de_Mandamiento_JudicialApiConsumer;
            this._Iexpediente_ministerio_publicoApiConsumer = expediente_ministerio_publicoApiConsumer;
            this._IJudicializacionApiConsumer = JudicializacionApiConsumer;
            this._IDetalle_de_Personas_a_IncluirApiConsumer = Detalle_de_Personas_a_IncluirApiConsumer;




        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Registro_de_Mandamiento_Judicial
        [ObjectAuth(ObjectId = (ModuleObjectId)45671, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45671, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Registro_de_Mandamiento_Judicial/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45671, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45671, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varRegistro_de_Mandamiento_Judicial = new Registro_de_Mandamiento_JudicialModel();
			varRegistro_de_Mandamiento_Judicial.Clave = Id;
			
            ViewBag.ObjectId = "45671";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionDetalle_de_Personas_a_Incluir = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46300, ModuleId);
            ViewBag.PermissionDetalle_de_Personas_a_Incluir = permissionDetalle_de_Personas_a_Incluir;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Registro_de_Mandamiento_JudicialsData = _IRegistro_de_Mandamiento_JudicialApiConsumer.ListaSelAll(0, 1000, "Registro_de_Mandamiento_Judicial.Clave=" + Id, "").Resource.Registro_de_Mandamiento_Judicials;
				
				if (Registro_de_Mandamiento_JudicialsData != null && Registro_de_Mandamiento_JudicialsData.Count > 0)
                {
					var Registro_de_Mandamiento_JudicialData = Registro_de_Mandamiento_JudicialsData.First();
					varRegistro_de_Mandamiento_Judicial= new Registro_de_Mandamiento_JudicialModel
					{
						Clave  = Registro_de_Mandamiento_JudicialData.Clave 
	                    ,Fecha_de_Registro = (Registro_de_Mandamiento_JudicialData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Registro_de_Mandamiento_JudicialData.Hora_de_Registro
                    ,Usuario_que_Registra = Registro_de_Mandamiento_JudicialData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Usuario_que_Registra), "Spartan_User") ??  (string)Registro_de_Mandamiento_JudicialData.Usuario_que_Registra_Spartan_User.Name
                    ,Numero_de_Mandamiento = Registro_de_Mandamiento_JudicialData.Numero_de_Mandamiento
                    ,Tipo_Mandato = Registro_de_Mandamiento_JudicialData.Tipo_Mandato
                    ,Tipo_MandatoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tipo_Mandato), "Tipo_de_Mandamiento") ??  (string)Registro_de_Mandamiento_JudicialData.Tipo_Mandato_Tipo_de_Mandamiento.Descripcion
                    ,Fuente = Registro_de_Mandamiento_JudicialData.Fuente
                    ,FuenteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Fuente), "Fuente_de_Mandamiento_Judicial") ??  (string)Registro_de_Mandamiento_JudicialData.Fuente_Fuente_de_Mandamiento_Judicial.Descripcion
                    ,Fecha_de_Solicitud = (Registro_de_Mandamiento_JudicialData.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Pais_al_que_Pertenece_la_Informacion = Registro_de_Mandamiento_JudicialData.Pais_al_que_Pertenece_la_Informacion
                    ,Pais_al_que_Pertenece_la_InformacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Pais_al_que_Pertenece_la_Informacion), "Pais") ??  (string)Registro_de_Mandamiento_JudicialData.Pais_al_que_Pertenece_la_Informacion_Pais.Nombre
                    ,Estado_que_Envia_la_Informacion = Registro_de_Mandamiento_JudicialData.Estado_que_Envia_la_Informacion
                    ,Estado_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Estado_que_Envia_la_Informacion), "Estado") ??  (string)Registro_de_Mandamiento_JudicialData.Estado_que_Envia_la_Informacion_Estado.Nombre
                    ,Municipio_que_Envia_la_Informacion = Registro_de_Mandamiento_JudicialData.Municipio_que_Envia_la_Informacion
                    ,Municipio_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Municipio_que_Envia_la_Informacion), "Municipio") ??  (string)Registro_de_Mandamiento_JudicialData.Municipio_que_Envia_la_Informacion_Municipio.Nombre
                    ,Institucion_que_Remite = Registro_de_Mandamiento_JudicialData.Institucion_que_Remite
                    ,Institucion_que_RemiteNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Institucion_que_Remite), "Institucion_Emisora") ??  (string)Registro_de_Mandamiento_JudicialData.Institucion_que_Remite_Institucion_Emisora.Nombre
                    ,Dependencia_Autoridad_Remitente = Registro_de_Mandamiento_JudicialData.Dependencia_Autoridad_Remitente
                    ,Entidad_que_Emite_Mandamiento = Registro_de_Mandamiento_JudicialData.Entidad_que_Emite_Mandamiento
                    ,Entidad_que_Emite_MandamientoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Entidad_que_Emite_Mandamiento), "Estado") ??  (string)Registro_de_Mandamiento_JudicialData.Entidad_que_Emite_Mandamiento_Estado.Nombre
                    ,Juzgado_que_Emitio_Mandamiento = Registro_de_Mandamiento_JudicialData.Juzgado_que_Emitio_Mandamiento
                    ,Juzgado_que_Emitio_MandamientoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Juzgado_que_Emitio_Mandamiento), "Juzgado") ??  (string)Registro_de_Mandamiento_JudicialData.Juzgado_que_Emitio_Mandamiento_Juzgado.Nombre
                    ,Oficio_de_Juzgado = Registro_de_Mandamiento_JudicialData.Oficio_de_Juzgado
                    ,Area_que_envia_Orden = Registro_de_Mandamiento_JudicialData.Area_que_envia_Orden
                    ,Area_que_envia_OrdenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Area_que_envia_Orden), "Unidad") ??  (string)Registro_de_Mandamiento_JudicialData.Area_que_envia_Orden_Unidad.Descripcion
                    ,Observaciones = Registro_de_Mandamiento_JudicialData.Observaciones
                    ,Estatus = Registro_de_Mandamiento_JudicialData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Estatus), "Estatus_de_Mandamiento_Judicial") ??  (string)Registro_de_Mandamiento_JudicialData.Estatus_Estatus_de_Mandamiento_Judicial.Descripcion
                    ,Numero_de_Proceso_Judicial = Registro_de_Mandamiento_JudicialData.Numero_de_Proceso_Judicial
                    ,Fecha_de_Libramiento = (Registro_de_Mandamiento_JudicialData.Fecha_de_Libramiento == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Libramiento).ToString(ConfigurationProperty.DateFormat))
                    ,Oficio_de_Libramiento = Registro_de_Mandamiento_JudicialData.Oficio_de_Libramiento
                    ,Fecha_de_Transcripcion = (Registro_de_Mandamiento_JudicialData.Fecha_de_Transcripcion == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Transcripcion).ToString(ConfigurationProperty.DateFormat))
                    ,Oficio_Transcripcion = Registro_de_Mandamiento_JudicialData.Oficio_Transcripcion
                    ,Carpeta_de_Investigacion = Registro_de_Mandamiento_JudicialData.Carpeta_de_Investigacion
                    ,Carpeta_de_Investigacionnic = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Carpeta_de_Investigacion), "expediente_ministerio_publico") ??  (string)Registro_de_Mandamiento_JudicialData.Carpeta_de_Investigacion_expediente_ministerio_publico.nic
                    ,Causa_Penal = Registro_de_Mandamiento_JudicialData.Causa_Penal
                    ,Causa_Penalcausa_o_cuadernillo = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Causa_Penal), "Judicializacion") ??  (string)Registro_de_Mandamiento_JudicialData.Causa_Penal_Judicializacion.causa_o_cuadernillo

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_MandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mandamientos_Tipo_Mandato = _ITipo_de_MandamientoApiConsumer.SelAll(true);
            if (Tipo_de_Mandamientos_Tipo_Mandato != null && Tipo_de_Mandamientos_Tipo_Mandato.Resource != null)
                ViewBag.Tipo_de_Mandamientos_Tipo_Mandato = Tipo_de_Mandamientos_Tipo_Mandato.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mandamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFuente_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fuente_de_Mandamiento_Judicials_Fuente = _IFuente_de_Mandamiento_JudicialApiConsumer.SelAll(true);
            if (Fuente_de_Mandamiento_Judicials_Fuente != null && Fuente_de_Mandamiento_Judicials_Fuente.Resource != null)
                ViewBag.Fuente_de_Mandamiento_Judicials_Fuente = Fuente_de_Mandamiento_Judicials_Fuente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fuente_de_Mandamiento_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IInstitucion_EmisoraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Institucion_Emisoras_Institucion_que_Remite = _IInstitucion_EmisoraApiConsumer.SelAll(true);
            if (Institucion_Emisoras_Institucion_que_Remite != null && Institucion_Emisoras_Institucion_que_Remite.Resource != null)
                ViewBag.Institucion_Emisoras_Institucion_que_Remite = Institucion_Emisoras_Institucion_que_Remite.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Institucion_Emisora", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IJuzgadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Juzgados_Juzgado_que_Emitio_Mandamiento = _IJuzgadoApiConsumer.SelAll(true);
            if (Juzgados_Juzgado_que_Emitio_Mandamiento != null && Juzgados_Juzgado_que_Emitio_Mandamiento.Resource != null)
                ViewBag.Juzgados_Juzgado_que_Emitio_Mandamiento = Juzgados_Juzgado_que_Emitio_Mandamiento.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Juzgado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Mandamiento_Judicials_Estatus = _IEstatus_de_Mandamiento_JudicialApiConsumer.SelAll(true);
            if (Estatus_de_Mandamiento_Judicials_Estatus != null && Estatus_de_Mandamiento_Judicials_Estatus.Resource != null)
                ViewBag.Estatus_de_Mandamiento_Judicials_Estatus = Estatus_de_Mandamiento_Judicials_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Mandamiento_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varRegistro_de_Mandamiento_Judicial);
        }
		
	[HttpGet]
        public ActionResult AddRegistro_de_Mandamiento_Judicial(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45671);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
			Registro_de_Mandamiento_JudicialModel varRegistro_de_Mandamiento_Judicial= new Registro_de_Mandamiento_JudicialModel();
            var permissionDetalle_de_Personas_a_Incluir = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 46300, ModuleId);
            ViewBag.PermissionDetalle_de_Personas_a_Incluir = permissionDetalle_de_Personas_a_Incluir;


            if (id.ToString() != "0")
            {
                var Registro_de_Mandamiento_JudicialsData = _IRegistro_de_Mandamiento_JudicialApiConsumer.ListaSelAll(0, 1000, "Registro_de_Mandamiento_Judicial.Clave=" + id, "").Resource.Registro_de_Mandamiento_Judicials;
				
				if (Registro_de_Mandamiento_JudicialsData != null && Registro_de_Mandamiento_JudicialsData.Count > 0)
                {
					var Registro_de_Mandamiento_JudicialData = Registro_de_Mandamiento_JudicialsData.First();
					varRegistro_de_Mandamiento_Judicial= new Registro_de_Mandamiento_JudicialModel
					{
						Clave  = Registro_de_Mandamiento_JudicialData.Clave 
	                    ,Fecha_de_Registro = (Registro_de_Mandamiento_JudicialData.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_de_Registro = Registro_de_Mandamiento_JudicialData.Hora_de_Registro
                    ,Usuario_que_Registra = Registro_de_Mandamiento_JudicialData.Usuario_que_Registra
                    ,Usuario_que_RegistraName = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Usuario_que_Registra), "Spartan_User") ??  (string)Registro_de_Mandamiento_JudicialData.Usuario_que_Registra_Spartan_User.Name
                    ,Numero_de_Mandamiento = Registro_de_Mandamiento_JudicialData.Numero_de_Mandamiento
                    ,Tipo_Mandato = Registro_de_Mandamiento_JudicialData.Tipo_Mandato
                    ,Tipo_MandatoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Tipo_Mandato), "Tipo_de_Mandamiento") ??  (string)Registro_de_Mandamiento_JudicialData.Tipo_Mandato_Tipo_de_Mandamiento.Descripcion
                    ,Fuente = Registro_de_Mandamiento_JudicialData.Fuente
                    ,FuenteDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Fuente), "Fuente_de_Mandamiento_Judicial") ??  (string)Registro_de_Mandamiento_JudicialData.Fuente_Fuente_de_Mandamiento_Judicial.Descripcion
                    ,Fecha_de_Solicitud = (Registro_de_Mandamiento_JudicialData.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                    ,Pais_al_que_Pertenece_la_Informacion = Registro_de_Mandamiento_JudicialData.Pais_al_que_Pertenece_la_Informacion
                    ,Pais_al_que_Pertenece_la_InformacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Pais_al_que_Pertenece_la_Informacion), "Pais") ??  (string)Registro_de_Mandamiento_JudicialData.Pais_al_que_Pertenece_la_Informacion_Pais.Nombre
                    ,Estado_que_Envia_la_Informacion = Registro_de_Mandamiento_JudicialData.Estado_que_Envia_la_Informacion
                    ,Estado_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Estado_que_Envia_la_Informacion), "Estado") ??  (string)Registro_de_Mandamiento_JudicialData.Estado_que_Envia_la_Informacion_Estado.Nombre
                    ,Municipio_que_Envia_la_Informacion = Registro_de_Mandamiento_JudicialData.Municipio_que_Envia_la_Informacion
                    ,Municipio_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Municipio_que_Envia_la_Informacion), "Municipio") ??  (string)Registro_de_Mandamiento_JudicialData.Municipio_que_Envia_la_Informacion_Municipio.Nombre
                    ,Institucion_que_Remite = Registro_de_Mandamiento_JudicialData.Institucion_que_Remite
                    ,Institucion_que_RemiteNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Institucion_que_Remite), "Institucion_Emisora") ??  (string)Registro_de_Mandamiento_JudicialData.Institucion_que_Remite_Institucion_Emisora.Nombre
                    ,Dependencia_Autoridad_Remitente = Registro_de_Mandamiento_JudicialData.Dependencia_Autoridad_Remitente
                    ,Entidad_que_Emite_Mandamiento = Registro_de_Mandamiento_JudicialData.Entidad_que_Emite_Mandamiento
                    ,Entidad_que_Emite_MandamientoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Entidad_que_Emite_Mandamiento), "Estado") ??  (string)Registro_de_Mandamiento_JudicialData.Entidad_que_Emite_Mandamiento_Estado.Nombre
                    ,Juzgado_que_Emitio_Mandamiento = Registro_de_Mandamiento_JudicialData.Juzgado_que_Emitio_Mandamiento
                    ,Juzgado_que_Emitio_MandamientoNombre = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Juzgado_que_Emitio_Mandamiento), "Juzgado") ??  (string)Registro_de_Mandamiento_JudicialData.Juzgado_que_Emitio_Mandamiento_Juzgado.Nombre
                    ,Oficio_de_Juzgado = Registro_de_Mandamiento_JudicialData.Oficio_de_Juzgado
                    ,Area_que_envia_Orden = Registro_de_Mandamiento_JudicialData.Area_que_envia_Orden
                    ,Area_que_envia_OrdenDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Area_que_envia_Orden), "Unidad") ??  (string)Registro_de_Mandamiento_JudicialData.Area_que_envia_Orden_Unidad.Descripcion
                    ,Observaciones = Registro_de_Mandamiento_JudicialData.Observaciones
                    ,Estatus = Registro_de_Mandamiento_JudicialData.Estatus
                    ,EstatusDescripcion = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Estatus), "Estatus_de_Mandamiento_Judicial") ??  (string)Registro_de_Mandamiento_JudicialData.Estatus_Estatus_de_Mandamiento_Judicial.Descripcion
                    ,Numero_de_Proceso_Judicial = Registro_de_Mandamiento_JudicialData.Numero_de_Proceso_Judicial
                    ,Fecha_de_Libramiento = (Registro_de_Mandamiento_JudicialData.Fecha_de_Libramiento == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Libramiento).ToString(ConfigurationProperty.DateFormat))
                    ,Oficio_de_Libramiento = Registro_de_Mandamiento_JudicialData.Oficio_de_Libramiento
                    ,Fecha_de_Transcripcion = (Registro_de_Mandamiento_JudicialData.Fecha_de_Transcripcion == null ? string.Empty : Convert.ToDateTime(Registro_de_Mandamiento_JudicialData.Fecha_de_Transcripcion).ToString(ConfigurationProperty.DateFormat))
                    ,Oficio_Transcripcion = Registro_de_Mandamiento_JudicialData.Oficio_Transcripcion
                    ,Carpeta_de_Investigacion = Registro_de_Mandamiento_JudicialData.Carpeta_de_Investigacion
                    ,Carpeta_de_Investigacionnic = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Carpeta_de_Investigacion), "expediente_ministerio_publico") ??  (string)Registro_de_Mandamiento_JudicialData.Carpeta_de_Investigacion_expediente_ministerio_publico.nic
                    ,Causa_Penal = Registro_de_Mandamiento_JudicialData.Causa_Penal
                    ,Causa_Penalcausa_o_cuadernillo = CultureHelper.GetTraduction(Convert.ToString(Registro_de_Mandamiento_JudicialData.Causa_Penal), "Judicializacion") ??  (string)Registro_de_Mandamiento_JudicialData.Causa_Penal_Judicializacion.causa_o_cuadernillo

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_MandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mandamientos_Tipo_Mandato = _ITipo_de_MandamientoApiConsumer.SelAll(true);
            if (Tipo_de_Mandamientos_Tipo_Mandato != null && Tipo_de_Mandamientos_Tipo_Mandato.Resource != null)
                ViewBag.Tipo_de_Mandamientos_Tipo_Mandato = Tipo_de_Mandamientos_Tipo_Mandato.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mandamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFuente_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fuente_de_Mandamiento_Judicials_Fuente = _IFuente_de_Mandamiento_JudicialApiConsumer.SelAll(true);
            if (Fuente_de_Mandamiento_Judicials_Fuente != null && Fuente_de_Mandamiento_Judicials_Fuente.Resource != null)
                ViewBag.Fuente_de_Mandamiento_Judicials_Fuente = Fuente_de_Mandamiento_Judicials_Fuente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fuente_de_Mandamiento_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IInstitucion_EmisoraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Institucion_Emisoras_Institucion_que_Remite = _IInstitucion_EmisoraApiConsumer.SelAll(true);
            if (Institucion_Emisoras_Institucion_que_Remite != null && Institucion_Emisoras_Institucion_que_Remite.Resource != null)
                ViewBag.Institucion_Emisoras_Institucion_que_Remite = Institucion_Emisoras_Institucion_que_Remite.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Institucion_Emisora", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IJuzgadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Juzgados_Juzgado_que_Emitio_Mandamiento = _IJuzgadoApiConsumer.SelAll(true);
            if (Juzgados_Juzgado_que_Emitio_Mandamiento != null && Juzgados_Juzgado_que_Emitio_Mandamiento.Resource != null)
                ViewBag.Juzgados_Juzgado_que_Emitio_Mandamiento = Juzgados_Juzgado_que_Emitio_Mandamiento.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Juzgado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Mandamiento_Judicials_Estatus = _IEstatus_de_Mandamiento_JudicialApiConsumer.SelAll(true);
            if (Estatus_de_Mandamiento_Judicials_Estatus != null && Estatus_de_Mandamiento_Judicials_Estatus.Resource != null)
                ViewBag.Estatus_de_Mandamiento_Judicials_Estatus = Estatus_de_Mandamiento_Judicials_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Mandamiento_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddRegistro_de_Mandamiento_Judicial", varRegistro_de_Mandamiento_Judicial);
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
        public ActionResult GetTipo_de_MandamientoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_MandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_MandamientoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mandamiento", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetFuente_de_Mandamiento_JudicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IFuente_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IFuente_de_Mandamiento_JudicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fuente_de_Mandamiento_Judicial", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetPaisAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IPaisApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Pais", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetEstadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstadoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estado", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetMunicipioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IMunicipioApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Municipio", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetInstitucion_EmisoraAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IInstitucion_EmisoraApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IInstitucion_EmisoraApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Institucion_Emisora", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetJuzgadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJuzgadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IJuzgadoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Juzgado", "Nombre")?? m.Nombre,
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
        public ActionResult GetEstatus_de_Mandamiento_JudicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstatus_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IEstatus_de_Mandamiento_JudicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Mandamiento_Judicial", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetJudicializacionAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IJudicializacionApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.causa_o_cuadernillo).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Judicializacion", "causa_o_cuadernillo")?? m.causa_o_cuadernillo,
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
        public ActionResult ShowAdvanceFilter(Registro_de_Mandamiento_JudicialAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_MandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mandamientos_Tipo_Mandato = _ITipo_de_MandamientoApiConsumer.SelAll(true);
            if (Tipo_de_Mandamientos_Tipo_Mandato != null && Tipo_de_Mandamientos_Tipo_Mandato.Resource != null)
                ViewBag.Tipo_de_Mandamientos_Tipo_Mandato = Tipo_de_Mandamientos_Tipo_Mandato.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mandamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFuente_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fuente_de_Mandamiento_Judicials_Fuente = _IFuente_de_Mandamiento_JudicialApiConsumer.SelAll(true);
            if (Fuente_de_Mandamiento_Judicials_Fuente != null && Fuente_de_Mandamiento_Judicials_Fuente.Resource != null)
                ViewBag.Fuente_de_Mandamiento_Judicials_Fuente = Fuente_de_Mandamiento_Judicials_Fuente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fuente_de_Mandamiento_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IInstitucion_EmisoraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Institucion_Emisoras_Institucion_que_Remite = _IInstitucion_EmisoraApiConsumer.SelAll(true);
            if (Institucion_Emisoras_Institucion_que_Remite != null && Institucion_Emisoras_Institucion_que_Remite.Resource != null)
                ViewBag.Institucion_Emisoras_Institucion_que_Remite = Institucion_Emisoras_Institucion_que_Remite.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Institucion_Emisora", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IJuzgadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Juzgados_Juzgado_que_Emitio_Mandamiento = _IJuzgadoApiConsumer.SelAll(true);
            if (Juzgados_Juzgado_que_Emitio_Mandamiento != null && Juzgados_Juzgado_que_Emitio_Mandamiento.Resource != null)
                ViewBag.Juzgados_Juzgado_que_Emitio_Mandamiento = Juzgados_Juzgado_que_Emitio_Mandamiento.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Juzgado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Mandamiento_Judicials_Estatus = _IEstatus_de_Mandamiento_JudicialApiConsumer.SelAll(true);
            if (Estatus_de_Mandamiento_Judicials_Estatus != null && Estatus_de_Mandamiento_Judicials_Estatus.Resource != null)
                ViewBag.Estatus_de_Mandamiento_Judicials_Estatus = Estatus_de_Mandamiento_Judicials_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Mandamiento_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_MandamientoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Mandamientos_Tipo_Mandato = _ITipo_de_MandamientoApiConsumer.SelAll(true);
            if (Tipo_de_Mandamientos_Tipo_Mandato != null && Tipo_de_Mandamientos_Tipo_Mandato.Resource != null)
                ViewBag.Tipo_de_Mandamientos_Tipo_Mandato = Tipo_de_Mandamientos_Tipo_Mandato.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Mandamiento", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IFuente_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Fuente_de_Mandamiento_Judicials_Fuente = _IFuente_de_Mandamiento_JudicialApiConsumer.SelAll(true);
            if (Fuente_de_Mandamiento_Judicials_Fuente != null && Fuente_de_Mandamiento_Judicials_Fuente.Resource != null)
                ViewBag.Fuente_de_Mandamiento_Judicials_Fuente = Fuente_de_Mandamiento_Judicials_Fuente.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Fuente_de_Mandamiento_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IInstitucion_EmisoraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Institucion_Emisoras_Institucion_que_Remite = _IInstitucion_EmisoraApiConsumer.SelAll(true);
            if (Institucion_Emisoras_Institucion_que_Remite != null && Institucion_Emisoras_Institucion_que_Remite.Resource != null)
                ViewBag.Institucion_Emisoras_Institucion_que_Remite = Institucion_Emisoras_Institucion_que_Remite.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Institucion_Emisora", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IJuzgadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Juzgados_Juzgado_que_Emitio_Mandamiento = _IJuzgadoApiConsumer.SelAll(true);
            if (Juzgados_Juzgado_que_Emitio_Mandamiento != null && Juzgados_Juzgado_que_Emitio_Mandamiento.Resource != null)
                ViewBag.Juzgados_Juzgado_que_Emitio_Mandamiento = Juzgados_Juzgado_que_Emitio_Mandamiento.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Juzgado", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IEstatus_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Estatus_de_Mandamiento_Judicials_Estatus = _IEstatus_de_Mandamiento_JudicialApiConsumer.SelAll(true);
            if (Estatus_de_Mandamiento_Judicials_Estatus != null && Estatus_de_Mandamiento_Judicials_Estatus.Resource != null)
                ViewBag.Estatus_de_Mandamiento_Judicials_Estatus = Estatus_de_Mandamiento_Judicials_Estatus.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Estatus_de_Mandamiento_Judicial", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Registro_de_Mandamiento_JudicialAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Registro_de_Mandamiento_JudicialAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Registro_de_Mandamiento_JudicialAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Registro_de_Mandamiento_JudicialPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IRegistro_de_Mandamiento_JudicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Mandamiento_Judicials == null)
                result.Registro_de_Mandamiento_Judicials = new List<Registro_de_Mandamiento_Judicial>();

            return Json(new
            {
                data = result.Registro_de_Mandamiento_Judicials.Select(m => new Registro_de_Mandamiento_JudicialGridModel
                    {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Mandamiento = m.Numero_de_Mandamiento
                        ,Tipo_MandatoDescripcion = CultureHelper.GetTraduction(m.Tipo_Mandato_Tipo_de_Mandamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Mandato_Tipo_de_Mandamiento.Descripcion
                        ,FuenteDescripcion = CultureHelper.GetTraduction(m.Fuente_Fuente_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Fuente_Fuente_de_Mandamiento_Judicial.Descripcion
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                        ,Pais_al_que_Pertenece_la_InformacionNombre = CultureHelper.GetTraduction(m.Pais_al_que_Pertenece_la_Informacion_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_al_que_Pertenece_la_Informacion_Pais.Nombre
                        ,Estado_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Estado_que_Envia_la_Informacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_que_Envia_la_Informacion_Estado.Nombre
                        ,Municipio_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Municipio_que_Envia_la_Informacion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_que_Envia_la_Informacion_Municipio.Nombre
                        ,Institucion_que_RemiteNombre = CultureHelper.GetTraduction(m.Institucion_que_Remite_Institucion_Emisora.Clave.ToString(), "Nombre") ?? (string)m.Institucion_que_Remite_Institucion_Emisora.Nombre
			,Dependencia_Autoridad_Remitente = m.Dependencia_Autoridad_Remitente
                        ,Entidad_que_Emite_MandamientoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emite_Mandamiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emite_Mandamiento_Estado.Nombre
                        ,Juzgado_que_Emitio_MandamientoNombre = CultureHelper.GetTraduction(m.Juzgado_que_Emitio_Mandamiento_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_que_Emitio_Mandamiento_Juzgado.Nombre
			,Oficio_de_Juzgado = m.Oficio_de_Juzgado
                        ,Area_que_envia_OrdenDescripcion = CultureHelper.GetTraduction(m.Area_que_envia_Orden_Unidad.Clave.ToString(), "Unidad") ?? (string)m.Area_que_envia_Orden_Unidad.Descripcion
			,Observaciones = m.Observaciones
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Mandamiento_Judicial.Descripcion
			,Numero_de_Proceso_Judicial = m.Numero_de_Proceso_Judicial
                        ,Fecha_de_Libramiento = (m.Fecha_de_Libramiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Libramiento).ToString(ConfigurationProperty.DateFormat))
			,Oficio_de_Libramiento = m.Oficio_de_Libramiento
                        ,Fecha_de_Transcripcion = (m.Fecha_de_Transcripcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Transcripcion).ToString(ConfigurationProperty.DateFormat))
			,Oficio_Transcripcion = m.Oficio_Transcripcion
                        ,Carpeta_de_Investigacionnic = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Carpeta_de_Investigacion_expediente_ministerio_publico.nic
                        ,Causa_Penalcausa_o_cuadernillo = CultureHelper.GetTraduction(m.Causa_Penal_Judicializacion.Clave.ToString(), "Judicializacion") ?? (string)m.Causa_Penal_Judicializacion.causa_o_cuadernillo

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetRegistro_de_Mandamiento_JudicialAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegistro_de_Mandamiento_JudicialApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Registro_de_Mandamiento_Judicial", m.),
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
        /// Get List of Registro_de_Mandamiento_Judicial from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Registro_de_Mandamiento_Judicial Entity</returns>
        public ActionResult GetRegistro_de_Mandamiento_JudicialList(UrlParametersModel param)
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
            _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Registro_de_Mandamiento_JudicialPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Registro_de_Mandamiento_JudicialAdvanceSearchModel))
                {
					var advanceFilter =
                    (Registro_de_Mandamiento_JudicialAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Registro_de_Mandamiento_JudicialPropertyMapper oRegistro_de_Mandamiento_JudicialPropertyMapper = new Registro_de_Mandamiento_JudicialPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oRegistro_de_Mandamiento_JudicialPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IRegistro_de_Mandamiento_JudicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Mandamiento_Judicials == null)
                result.Registro_de_Mandamiento_Judicials = new List<Registro_de_Mandamiento_Judicial>();

            return Json(new
            {
                aaData = result.Registro_de_Mandamiento_Judicials.Select(m => new Registro_de_Mandamiento_JudicialGridModel
            {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Mandamiento = m.Numero_de_Mandamiento
                        ,Tipo_MandatoDescripcion = CultureHelper.GetTraduction(m.Tipo_Mandato_Tipo_de_Mandamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Mandato_Tipo_de_Mandamiento.Descripcion
                        ,FuenteDescripcion = CultureHelper.GetTraduction(m.Fuente_Fuente_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Fuente_Fuente_de_Mandamiento_Judicial.Descripcion
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                        ,Pais_al_que_Pertenece_la_InformacionNombre = CultureHelper.GetTraduction(m.Pais_al_que_Pertenece_la_Informacion_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_al_que_Pertenece_la_Informacion_Pais.Nombre
                        ,Estado_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Estado_que_Envia_la_Informacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_que_Envia_la_Informacion_Estado.Nombre
                        ,Municipio_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Municipio_que_Envia_la_Informacion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_que_Envia_la_Informacion_Municipio.Nombre
                        ,Institucion_que_RemiteNombre = CultureHelper.GetTraduction(m.Institucion_que_Remite_Institucion_Emisora.Clave.ToString(), "Nombre") ?? (string)m.Institucion_que_Remite_Institucion_Emisora.Nombre
			,Dependencia_Autoridad_Remitente = m.Dependencia_Autoridad_Remitente
                        ,Entidad_que_Emite_MandamientoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emite_Mandamiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emite_Mandamiento_Estado.Nombre
                        ,Juzgado_que_Emitio_MandamientoNombre = CultureHelper.GetTraduction(m.Juzgado_que_Emitio_Mandamiento_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_que_Emitio_Mandamiento_Juzgado.Nombre
			,Oficio_de_Juzgado = m.Oficio_de_Juzgado
                        ,Area_que_envia_OrdenDescripcion = CultureHelper.GetTraduction(m.Area_que_envia_Orden_Unidad.Clave.ToString(), "Unidad") ?? (string)m.Area_que_envia_Orden_Unidad.Descripcion
			,Observaciones = m.Observaciones
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Mandamiento_Judicial.Descripcion
			,Numero_de_Proceso_Judicial = m.Numero_de_Proceso_Judicial
                        ,Fecha_de_Libramiento = (m.Fecha_de_Libramiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Libramiento).ToString(ConfigurationProperty.DateFormat))
			,Oficio_de_Libramiento = m.Oficio_de_Libramiento
                        ,Fecha_de_Transcripcion = (m.Fecha_de_Transcripcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Transcripcion).ToString(ConfigurationProperty.DateFormat))
			,Oficio_Transcripcion = m.Oficio_Transcripcion
                        ,Carpeta_de_Investigacionnic = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Carpeta_de_Investigacion_expediente_ministerio_publico.nic
                        ,Causa_Penalcausa_o_cuadernillo = CultureHelper.GetTraduction(m.Causa_Penal_Judicializacion.Clave.ToString(), "Judicializacion") ?? (string)m.Causa_Penal_Judicializacion.causa_o_cuadernillo

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetRegistro_de_Mandamiento_Judicial_Usuario_que_Registra_Spartan_User(string query, string where)
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
        public JsonResult GetRegistro_de_Mandamiento_Judicial_Pais_al_que_Pertenece_la_Informacion_Pais(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IPaisApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Pais.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Pais.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IPaisApiConsumer.ListaSelAll(1, 20,elWhere , " Pais.Nombre ASC ").Resource;
               
                foreach (var item in result.Paiss)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Pais", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Paiss.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetRegistro_de_Mandamiento_Judicial_Estado_que_Envia_la_Informacion_Estado(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Estado.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Estado.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IEstadoApiConsumer.ListaSelAll(1, 20,elWhere , " Estado.Nombre ASC ").Resource;
               
                foreach (var item in result.Estados)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Estados.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetRegistro_de_Mandamiento_Judicial_Municipio_que_Envia_la_Informacion_Municipio(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMunicipioApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Municipio.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Municipio.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IMunicipioApiConsumer.ListaSelAll(1, 20,elWhere , " Municipio.Nombre ASC ").Resource;
               
                foreach (var item in result.Municipios)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Municipio", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Municipios.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetRegistro_de_Mandamiento_Judicial_Entidad_que_Emite_Mandamiento_Estado(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IEstadoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Estado.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Estado.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IEstadoApiConsumer.ListaSelAll(1, 20,elWhere , " Estado.Nombre ASC ").Resource;
               
                foreach (var item in result.Estados)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Estado", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Estados.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetRegistro_de_Mandamiento_Judicial_Area_que_envia_Orden_Unidad(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IUnidadApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Unidad.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Unidad.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IUnidadApiConsumer.ListaSelAll(1, 20,elWhere , " Unidad.Descripcion ASC ").Resource;
               
                foreach (var item in result.Unidads)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Unidad", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Unidads.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetRegistro_de_Mandamiento_Judicial_Carpeta_de_Investigacion_expediente_ministerio_publico(string query, string where)
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
        public JsonResult GetRegistro_de_Mandamiento_Judicial_Causa_Penal_Judicializacion(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IJudicializacionApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Judicializacion.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Judicializacion.causa_o_cuadernillo as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IJudicializacionApiConsumer.ListaSelAll(1, 20,elWhere , " Judicializacion.causa_o_cuadernillo ASC ").Resource;
               
                foreach (var item in result.Judicializacions)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Judicializacion", "causa_o_cuadernillo");
                    item.causa_o_cuadernillo =trans ??item.causa_o_cuadernillo;
                }
                return Json(result.Judicializacions.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete






        [NonAction]
        public string GetAdvanceFilter(Registro_de_Mandamiento_JudicialAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Registro_de_Mandamiento_Judicial.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Registro_de_Mandamiento_Judicial.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro) || !string.IsNullOrEmpty(filter.ToFecha_de_Registro))
            {
                var Fecha_de_RegistroFrom = DateTime.ParseExact(filter.FromFecha_de_Registro, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_RegistroTo = DateTime.ParseExact(filter.ToFecha_de_Registro, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Registro))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Registro >= '" + Fecha_de_RegistroFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Registro))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Registro <= '" + Fecha_de_RegistroTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Registro) || !string.IsNullOrEmpty(filter.ToHora_de_Registro))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Registro))
                    where += " AND Convert(TIME,Registro_de_Mandamiento_Judicial.Hora_de_Registro) >='" + filter.FromHora_de_Registro + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Registro))
                    where += " AND Convert(TIME,Registro_de_Mandamiento_Judicial.Hora_de_Registro) <='" + filter.ToHora_de_Registro + "'";
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

                where += " AND Registro_de_Mandamiento_Judicial.Usuario_que_Registra In (" + Usuario_que_RegistraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Mandamiento))
            {
                switch (filter.Numero_de_MandamientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento LIKE '" + filter.Numero_de_Mandamiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento LIKE '%" + filter.Numero_de_Mandamiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento = '" + filter.Numero_de_Mandamiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Mandamiento LIKE '%" + filter.Numero_de_Mandamiento + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_Mandato))
            {
                switch (filter.Tipo_MandatoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Mandamiento.Descripcion LIKE '" + filter.AdvanceTipo_Mandato + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Mandamiento.Descripcion LIKE '%" + filter.AdvanceTipo_Mandato + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Mandamiento.Descripcion = '" + filter.AdvanceTipo_Mandato + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Mandamiento.Descripcion LIKE '%" + filter.AdvanceTipo_Mandato + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_MandatoMultiple != null && filter.AdvanceTipo_MandatoMultiple.Count() > 0)
            {
                var Tipo_MandatoIds = string.Join(",", filter.AdvanceTipo_MandatoMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Tipo_Mandato In (" + Tipo_MandatoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceFuente))
            {
                switch (filter.FuenteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Fuente_de_Mandamiento_Judicial.Descripcion LIKE '" + filter.AdvanceFuente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Fuente_de_Mandamiento_Judicial.Descripcion LIKE '%" + filter.AdvanceFuente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Fuente_de_Mandamiento_Judicial.Descripcion = '" + filter.AdvanceFuente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Fuente_de_Mandamiento_Judicial.Descripcion LIKE '%" + filter.AdvanceFuente + "%'";
                        break;
                }
            }
            else if (filter.AdvanceFuenteMultiple != null && filter.AdvanceFuenteMultiple.Count() > 0)
            {
                var FuenteIds = string.Join(",", filter.AdvanceFuenteMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Fuente In (" + FuenteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Solicitud) || !string.IsNullOrEmpty(filter.ToFecha_de_Solicitud))
            {
                var Fecha_de_SolicitudFrom = DateTime.ParseExact(filter.FromFecha_de_Solicitud, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_SolicitudTo = DateTime.ParseExact(filter.ToFecha_de_Solicitud, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Solicitud))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Solicitud >= '" + Fecha_de_SolicitudFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Solicitud))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Solicitud <= '" + Fecha_de_SolicitudTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvancePais_al_que_Pertenece_la_Informacion))
            {
                switch (filter.Pais_al_que_Pertenece_la_InformacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Pais.Nombre LIKE '" + filter.AdvancePais_al_que_Pertenece_la_Informacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_al_que_Pertenece_la_Informacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Pais.Nombre = '" + filter.AdvancePais_al_que_Pertenece_la_Informacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Pais.Nombre LIKE '%" + filter.AdvancePais_al_que_Pertenece_la_Informacion + "%'";
                        break;
                }
            }
            else if (filter.AdvancePais_al_que_Pertenece_la_InformacionMultiple != null && filter.AdvancePais_al_que_Pertenece_la_InformacionMultiple.Count() > 0)
            {
                var Pais_al_que_Pertenece_la_InformacionIds = string.Join(",", filter.AdvancePais_al_que_Pertenece_la_InformacionMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Pais_al_que_Pertenece_la_Informacion In (" + Pais_al_que_Pertenece_la_InformacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_que_Envia_la_Informacion))
            {
                switch (filter.Estado_que_Envia_la_InformacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_que_Envia_la_Informacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_que_Envia_la_Informacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_que_Envia_la_Informacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_que_Envia_la_Informacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_que_Envia_la_InformacionMultiple != null && filter.AdvanceEstado_que_Envia_la_InformacionMultiple.Count() > 0)
            {
                var Estado_que_Envia_la_InformacionIds = string.Join(",", filter.AdvanceEstado_que_Envia_la_InformacionMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Estado_que_Envia_la_Informacion In (" + Estado_que_Envia_la_InformacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_que_Envia_la_Informacion))
            {
                switch (filter.Municipio_que_Envia_la_InformacionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_que_Envia_la_Informacion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_que_Envia_la_Informacion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_que_Envia_la_Informacion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_que_Envia_la_Informacion + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_que_Envia_la_InformacionMultiple != null && filter.AdvanceMunicipio_que_Envia_la_InformacionMultiple.Count() > 0)
            {
                var Municipio_que_Envia_la_InformacionIds = string.Join(",", filter.AdvanceMunicipio_que_Envia_la_InformacionMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Municipio_que_Envia_la_Informacion In (" + Municipio_que_Envia_la_InformacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceInstitucion_que_Remite))
            {
                switch (filter.Institucion_que_RemiteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Institucion_Emisora.Nombre LIKE '" + filter.AdvanceInstitucion_que_Remite + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Institucion_Emisora.Nombre LIKE '%" + filter.AdvanceInstitucion_que_Remite + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Institucion_Emisora.Nombre = '" + filter.AdvanceInstitucion_que_Remite + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Institucion_Emisora.Nombre LIKE '%" + filter.AdvanceInstitucion_que_Remite + "%'";
                        break;
                }
            }
            else if (filter.AdvanceInstitucion_que_RemiteMultiple != null && filter.AdvanceInstitucion_que_RemiteMultiple.Count() > 0)
            {
                var Institucion_que_RemiteIds = string.Join(",", filter.AdvanceInstitucion_que_RemiteMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Institucion_que_Remite In (" + Institucion_que_RemiteIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Dependencia_Autoridad_Remitente))
            {
                switch (filter.Dependencia_Autoridad_RemitenteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Dependencia_Autoridad_Remitente LIKE '" + filter.Dependencia_Autoridad_Remitente + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Dependencia_Autoridad_Remitente LIKE '%" + filter.Dependencia_Autoridad_Remitente + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Dependencia_Autoridad_Remitente = '" + filter.Dependencia_Autoridad_Remitente + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Dependencia_Autoridad_Remitente LIKE '%" + filter.Dependencia_Autoridad_Remitente + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEntidad_que_Emite_Mandamiento))
            {
                switch (filter.Entidad_que_Emite_MandamientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEntidad_que_Emite_Mandamiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEntidad_que_Emite_Mandamiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEntidad_que_Emite_Mandamiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEntidad_que_Emite_Mandamiento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEntidad_que_Emite_MandamientoMultiple != null && filter.AdvanceEntidad_que_Emite_MandamientoMultiple.Count() > 0)
            {
                var Entidad_que_Emite_MandamientoIds = string.Join(",", filter.AdvanceEntidad_que_Emite_MandamientoMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Entidad_que_Emite_Mandamiento In (" + Entidad_que_Emite_MandamientoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceJuzgado_que_Emitio_Mandamiento))
            {
                switch (filter.Juzgado_que_Emitio_MandamientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Juzgado.Nombre LIKE '" + filter.AdvanceJuzgado_que_Emitio_Mandamiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Juzgado.Nombre LIKE '%" + filter.AdvanceJuzgado_que_Emitio_Mandamiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Juzgado.Nombre = '" + filter.AdvanceJuzgado_que_Emitio_Mandamiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Juzgado.Nombre LIKE '%" + filter.AdvanceJuzgado_que_Emitio_Mandamiento + "%'";
                        break;
                }
            }
            else if (filter.AdvanceJuzgado_que_Emitio_MandamientoMultiple != null && filter.AdvanceJuzgado_que_Emitio_MandamientoMultiple.Count() > 0)
            {
                var Juzgado_que_Emitio_MandamientoIds = string.Join(",", filter.AdvanceJuzgado_que_Emitio_MandamientoMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Juzgado_que_Emitio_Mandamiento In (" + Juzgado_que_Emitio_MandamientoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Oficio_de_Juzgado))
            {
                switch (filter.Oficio_de_JuzgadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Juzgado LIKE '" + filter.Oficio_de_Juzgado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Juzgado LIKE '%" + filter.Oficio_de_Juzgado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Juzgado = '" + filter.Oficio_de_Juzgado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Juzgado LIKE '%" + filter.Oficio_de_Juzgado + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceArea_que_envia_Orden))
            {
                switch (filter.Area_que_envia_OrdenFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Unidad.Descripcion LIKE '" + filter.AdvanceArea_que_envia_Orden + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.AdvanceArea_que_envia_Orden + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Unidad.Descripcion = '" + filter.AdvanceArea_que_envia_Orden + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Unidad.Descripcion LIKE '%" + filter.AdvanceArea_que_envia_Orden + "%'";
                        break;
                }
            }
            else if (filter.AdvanceArea_que_envia_OrdenMultiple != null && filter.AdvanceArea_que_envia_OrdenMultiple.Count() > 0)
            {
                var Area_que_envia_OrdenIds = string.Join(",", filter.AdvanceArea_que_envia_OrdenMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Area_que_envia_Orden In (" + Area_que_envia_OrdenIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Observaciones))
            {
                switch (filter.ObservacionesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Observaciones LIKE '" + filter.Observaciones + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Observaciones LIKE '%" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Observaciones = '" + filter.Observaciones + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Observaciones LIKE '%" + filter.Observaciones + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstatus))
            {
                switch (filter.EstatusFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estatus_de_Mandamiento_Judicial.Descripcion LIKE '" + filter.AdvanceEstatus + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estatus_de_Mandamiento_Judicial.Descripcion LIKE '%" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estatus_de_Mandamiento_Judicial.Descripcion = '" + filter.AdvanceEstatus + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estatus_de_Mandamiento_Judicial.Descripcion LIKE '%" + filter.AdvanceEstatus + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstatusMultiple != null && filter.AdvanceEstatusMultiple.Count() > 0)
            {
                var EstatusIds = string.Join(",", filter.AdvanceEstatusMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Estatus In (" + EstatusIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Proceso_Judicial))
            {
                switch (filter.Numero_de_Proceso_JudicialFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Proceso_Judicial LIKE '" + filter.Numero_de_Proceso_Judicial + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Proceso_Judicial LIKE '%" + filter.Numero_de_Proceso_Judicial + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Proceso_Judicial = '" + filter.Numero_de_Proceso_Judicial + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Numero_de_Proceso_Judicial LIKE '%" + filter.Numero_de_Proceso_Judicial + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Libramiento) || !string.IsNullOrEmpty(filter.ToFecha_de_Libramiento))
            {
                var Fecha_de_LibramientoFrom = DateTime.ParseExact(filter.FromFecha_de_Libramiento, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_LibramientoTo = DateTime.ParseExact(filter.ToFecha_de_Libramiento, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Libramiento))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Libramiento >= '" + Fecha_de_LibramientoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Libramiento))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Libramiento <= '" + Fecha_de_LibramientoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Oficio_de_Libramiento))
            {
                switch (filter.Oficio_de_LibramientoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Libramiento LIKE '" + filter.Oficio_de_Libramiento + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Libramiento LIKE '%" + filter.Oficio_de_Libramiento + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Libramiento = '" + filter.Oficio_de_Libramiento + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_de_Libramiento LIKE '%" + filter.Oficio_de_Libramiento + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Transcripcion) || !string.IsNullOrEmpty(filter.ToFecha_de_Transcripcion))
            {
                var Fecha_de_TranscripcionFrom = DateTime.ParseExact(filter.FromFecha_de_Transcripcion, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_TranscripcionTo = DateTime.ParseExact(filter.ToFecha_de_Transcripcion, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Transcripcion))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Transcripcion >= '" + Fecha_de_TranscripcionFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Transcripcion))
                    where += " AND Registro_de_Mandamiento_Judicial.Fecha_de_Transcripcion <= '" + Fecha_de_TranscripcionTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.Oficio_Transcripcion))
            {
                switch (filter.Oficio_TranscripcionFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_Transcripcion LIKE '" + filter.Oficio_Transcripcion + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_Transcripcion LIKE '%" + filter.Oficio_Transcripcion + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_Transcripcion = '" + filter.Oficio_Transcripcion + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Registro_de_Mandamiento_Judicial.Oficio_Transcripcion LIKE '%" + filter.Oficio_Transcripcion + "%'";
                        break;
                }
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

                where += " AND Registro_de_Mandamiento_Judicial.Carpeta_de_Investigacion In (" + Carpeta_de_InvestigacionIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCausa_Penal))
            {
                switch (filter.Causa_PenalFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Judicializacion.causa_o_cuadernillo LIKE '" + filter.AdvanceCausa_Penal + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Judicializacion.causa_o_cuadernillo LIKE '%" + filter.AdvanceCausa_Penal + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Judicializacion.causa_o_cuadernillo = '" + filter.AdvanceCausa_Penal + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Judicializacion.causa_o_cuadernillo LIKE '%" + filter.AdvanceCausa_Penal + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCausa_PenalMultiple != null && filter.AdvanceCausa_PenalMultiple.Count() > 0)
            {
                var Causa_PenalIds = string.Join(",", filter.AdvanceCausa_PenalMultiple);

                where += " AND Registro_de_Mandamiento_Judicial.Causa_Penal In (" + Causa_PenalIds + ")";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetDetalle_de_Personas_a_Incluir(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Detalle_de_Personas_a_IncluirGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Personas_a_IncluirApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Detalle_de_Personas_a_Incluir.Mandamiento_Judicial=" + RelationId;
            if("int" == "string")
            {
	           where = "Detalle_de_Personas_a_Incluir.Mandamiento_Judicial='" + RelationId + "'";
            }
            var result = _IDetalle_de_Personas_a_IncluirApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Detalle_de_Personas_a_Incluirs == null)
                result.Detalle_de_Personas_a_Incluirs = new List<Detalle_de_Personas_a_Incluir>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Detalle_de_Personas_a_Incluirs.Select(m => new Detalle_de_Personas_a_IncluirGridModel
                {
                    Folio = m.Folio

			,Persona = m.Persona
			,Seleccionar = m.Seleccionar
			,PersonaId = m.PersonaId

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Detalle_de_Personas_a_IncluirGridModel> GetDetalle_de_Personas_a_IncluirData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Detalle_de_Personas_a_IncluirGridModel> resultData = new List<Detalle_de_Personas_a_IncluirGridModel>();
            string where = "Detalle_de_Personas_a_Incluir.Mandamiento_Judicial=" + Id;
            if("int" == "string")
            {
                where = "Detalle_de_Personas_a_Incluir.Mandamiento_Judicial='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IDetalle_de_Personas_a_IncluirApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IDetalle_de_Personas_a_IncluirApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Detalle_de_Personas_a_Incluirs != null)
            {
                resultData = result.Detalle_de_Personas_a_Incluirs.Select(m => new Detalle_de_Personas_a_IncluirGridModel
                    {
                        Folio = m.Folio

			,Persona = m.Persona
			,Seleccionar = m.Seleccionar
			,PersonaId = m.PersonaId


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
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

                Registro_de_Mandamiento_Judicial varRegistro_de_Mandamiento_Judicial = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IDetalle_de_Personas_a_IncluirApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Detalle_de_Personas_a_Incluir.Mandamiento_Judicial=" + id;
                    if("int" == "string")
                    {
	                where = "Detalle_de_Personas_a_Incluir.Mandamiento_Judicial='" + id + "'";
                    }
                    var Detalle_de_Personas_a_IncluirInfo =
                        _IDetalle_de_Personas_a_IncluirApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Detalle_de_Personas_a_IncluirInfo.Detalle_de_Personas_a_Incluirs.Count > 0)
                    {
                        var resultDetalle_de_Personas_a_Incluir = true;
                        //Removing associated job history with attachment
                        foreach (var Detalle_de_Personas_a_IncluirItem in Detalle_de_Personas_a_IncluirInfo.Detalle_de_Personas_a_Incluirs)
                            resultDetalle_de_Personas_a_Incluir = resultDetalle_de_Personas_a_Incluir
                                              && _IDetalle_de_Personas_a_IncluirApiConsumer.Delete(Detalle_de_Personas_a_IncluirItem.Folio, null,null).Resource;

                        if (!resultDetalle_de_Personas_a_Incluir)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IRegistro_de_Mandamiento_JudicialApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Registro_de_Mandamiento_JudicialModel varRegistro_de_Mandamiento_Judicial)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Registro_de_Mandamiento_JudicialInfo = new Registro_de_Mandamiento_Judicial
                    {
                        Clave = varRegistro_de_Mandamiento_Judicial.Clave
                        ,Fecha_de_Registro = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Registro)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varRegistro_de_Mandamiento_Judicial.Hora_de_Registro
                        ,Usuario_que_Registra = varRegistro_de_Mandamiento_Judicial.Usuario_que_Registra
                        ,Numero_de_Mandamiento = varRegistro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Tipo_Mandato = varRegistro_de_Mandamiento_Judicial.Tipo_Mandato
                        ,Fuente = varRegistro_de_Mandamiento_Judicial.Fuente
                        ,Fecha_de_Solicitud = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Solicitud)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Pais_al_que_Pertenece_la_Informacion = varRegistro_de_Mandamiento_Judicial.Pais_al_que_Pertenece_la_Informacion
                        ,Estado_que_Envia_la_Informacion = varRegistro_de_Mandamiento_Judicial.Estado_que_Envia_la_Informacion
                        ,Municipio_que_Envia_la_Informacion = varRegistro_de_Mandamiento_Judicial.Municipio_que_Envia_la_Informacion
                        ,Institucion_que_Remite = varRegistro_de_Mandamiento_Judicial.Institucion_que_Remite
                        ,Dependencia_Autoridad_Remitente = varRegistro_de_Mandamiento_Judicial.Dependencia_Autoridad_Remitente
                        ,Entidad_que_Emite_Mandamiento = varRegistro_de_Mandamiento_Judicial.Entidad_que_Emite_Mandamiento
                        ,Juzgado_que_Emitio_Mandamiento = varRegistro_de_Mandamiento_Judicial.Juzgado_que_Emitio_Mandamiento
                        ,Oficio_de_Juzgado = varRegistro_de_Mandamiento_Judicial.Oficio_de_Juzgado
                        ,Area_que_envia_Orden = varRegistro_de_Mandamiento_Judicial.Area_que_envia_Orden
                        ,Observaciones = varRegistro_de_Mandamiento_Judicial.Observaciones
                        ,Estatus = varRegistro_de_Mandamiento_Judicial.Estatus
                        ,Numero_de_Proceso_Judicial = varRegistro_de_Mandamiento_Judicial.Numero_de_Proceso_Judicial
                        ,Fecha_de_Libramiento = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Libramiento)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Libramiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Oficio_de_Libramiento = varRegistro_de_Mandamiento_Judicial.Oficio_de_Libramiento
                        ,Fecha_de_Transcripcion = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Transcripcion)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Transcripcion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Oficio_Transcripcion = varRegistro_de_Mandamiento_Judicial.Oficio_Transcripcion
                        ,Carpeta_de_Investigacion = varRegistro_de_Mandamiento_Judicial.Carpeta_de_Investigacion
                        ,Causa_Penal = varRegistro_de_Mandamiento_Judicial.Causa_Penal

                    };

                    result = !IsNew ?
                        _IRegistro_de_Mandamiento_JudicialApiConsumer.Update(Registro_de_Mandamiento_JudicialInfo, null, null).Resource.ToString() :
                         _IRegistro_de_Mandamiento_JudicialApiConsumer.Insert(Registro_de_Mandamiento_JudicialInfo, null, null).Resource.ToString();
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
        public bool CopyDetalle_de_Personas_a_Incluir(int MasterId, int referenceId, List<Detalle_de_Personas_a_IncluirGridModelPost> Detalle_de_Personas_a_IncluirItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IDetalle_de_Personas_a_IncluirApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Detalle_de_Personas_a_IncluirData = _IDetalle_de_Personas_a_IncluirApiConsumer.ListaSelAll(1, int.MaxValue, "Detalle_de_Personas_a_Incluir.Mandamiento_Judicial=" + referenceId,"").Resource;
                if (Detalle_de_Personas_a_IncluirData == null || Detalle_de_Personas_a_IncluirData.Detalle_de_Personas_a_Incluirs.Count == 0)
                    return true;

                var result = true;

                Detalle_de_Personas_a_IncluirGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varDetalle_de_Personas_a_Incluir in Detalle_de_Personas_a_IncluirData.Detalle_de_Personas_a_Incluirs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Detalle_de_Personas_a_Incluir Detalle_de_Personas_a_Incluir1 = varDetalle_de_Personas_a_Incluir;

                    if (Detalle_de_Personas_a_IncluirItems != null && Detalle_de_Personas_a_IncluirItems.Any(m => m.Folio == Detalle_de_Personas_a_Incluir1.Folio))
                    {
                        modelDataToChange = Detalle_de_Personas_a_IncluirItems.FirstOrDefault(m => m.Folio == Detalle_de_Personas_a_Incluir1.Folio);
                    }
                    //Chaning Id Value
                    varDetalle_de_Personas_a_Incluir.Mandamiento_Judicial = MasterId;
                    var insertId = _IDetalle_de_Personas_a_IncluirApiConsumer.Insert(varDetalle_de_Personas_a_Incluir,null,null).Resource;
                    if (insertId > 0 && modelDataToChange != null)
                        modelDataToChange.Folio = insertId;

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
        public ActionResult PostDetalle_de_Personas_a_Incluir(List<Detalle_de_Personas_a_IncluirGridModelPost> Detalle_de_Personas_a_IncluirItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyDetalle_de_Personas_a_Incluir(MasterId, referenceId, Detalle_de_Personas_a_IncluirItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Detalle_de_Personas_a_IncluirItems != null && Detalle_de_Personas_a_IncluirItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IDetalle_de_Personas_a_IncluirApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Detalle_de_Personas_a_IncluirItem in Detalle_de_Personas_a_IncluirItems)
                    {





                        //Removal Request
                        if (Detalle_de_Personas_a_IncluirItem.Removed)
                        {
                            result = result && _IDetalle_de_Personas_a_IncluirApiConsumer.Delete(Detalle_de_Personas_a_IncluirItem.Folio, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Detalle_de_Personas_a_IncluirItem.Folio = 0;

                        var Detalle_de_Personas_a_IncluirData = new Detalle_de_Personas_a_Incluir
                        {
                            Mandamiento_Judicial = MasterId
                            ,Folio = Detalle_de_Personas_a_IncluirItem.Folio
                            ,Persona = Detalle_de_Personas_a_IncluirItem.Persona
                            ,Seleccionar = Detalle_de_Personas_a_IncluirItem.Seleccionar
                            ,PersonaId = Detalle_de_Personas_a_IncluirItem.PersonaId

                        };

                        var resultId = Detalle_de_Personas_a_IncluirItem.Folio > 0
                           ? _IDetalle_de_Personas_a_IncluirApiConsumer.Update(Detalle_de_Personas_a_IncluirData,null,null).Resource
                           : _IDetalle_de_Personas_a_IncluirApiConsumer.Insert(Detalle_de_Personas_a_IncluirData,null,null).Resource;

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
        /// Write Element Array of Registro_de_Mandamiento_Judicial script
        /// </summary>
        /// <param name="oRegistro_de_Mandamiento_JudicialElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Registro_de_Mandamiento_JudicialModuleAttributeList)
        {
            for (int i = 0; i < Registro_de_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Registro_de_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Registro_de_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Registro_de_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Registro_de_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Registro_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Registro_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Registro_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Registro_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Registro_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Registro_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Registro_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strRegistro_de_Mandamiento_JudicialScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Registro_de_Mandamiento_Judicial.js")))
            {
                strRegistro_de_Mandamiento_JudicialScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Registro_de_Mandamiento_Judicial element attributes
            string userChangeJson = jsSerialize.Serialize(Registro_de_Mandamiento_JudicialModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strRegistro_de_Mandamiento_JudicialScript.IndexOf("inpuElementArray");
            string splittedString = strRegistro_de_Mandamiento_JudicialScript.Substring(indexOfArray, strRegistro_de_Mandamiento_JudicialScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Registro_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Registro_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strRegistro_de_Mandamiento_JudicialScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strRegistro_de_Mandamiento_JudicialScript.Substring(indexOfArrayHistory, strRegistro_de_Mandamiento_JudicialScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strRegistro_de_Mandamiento_JudicialScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strRegistro_de_Mandamiento_JudicialScript.Substring(endIndexOfMainElement + indexOfArray, strRegistro_de_Mandamiento_JudicialScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Registro_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Registro_de_Mandamiento_JudicialModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Registro_de_Mandamiento_Judicial.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Registro_de_Mandamiento_Judicial.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Registro_de_Mandamiento_Judicial.js")))
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
        public ActionResult Registro_de_Mandamiento_JudicialPropertyBag()
        {
            return PartialView("Registro_de_Mandamiento_JudicialPropertyBag", "Registro_de_Mandamiento_Judicial");
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
        public ActionResult AddDetalle_de_Personas_a_Incluir(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Detalle_de_Personas_a_Incluir/AddDetalle_de_Personas_a_Incluir");
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
                var whereClauseFormat = "Object = 45671 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Registro_de_Mandamiento_Judicial.Clave= " + RecordId;
                            var result = _IRegistro_de_Mandamiento_JudicialApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Registro_de_Mandamiento_JudicialPropertyMapper());
			
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
                    (Registro_de_Mandamiento_JudicialAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Registro_de_Mandamiento_JudicialPropertyMapper oRegistro_de_Mandamiento_JudicialPropertyMapper = new Registro_de_Mandamiento_JudicialPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRegistro_de_Mandamiento_JudicialPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRegistro_de_Mandamiento_JudicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Mandamiento_Judicials == null)
                result.Registro_de_Mandamiento_Judicials = new List<Registro_de_Mandamiento_Judicial>();

            var data = result.Registro_de_Mandamiento_Judicials.Select(m => new Registro_de_Mandamiento_JudicialGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Mandamiento = m.Numero_de_Mandamiento
                        ,Tipo_MandatoDescripcion = CultureHelper.GetTraduction(m.Tipo_Mandato_Tipo_de_Mandamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Mandato_Tipo_de_Mandamiento.Descripcion
                        ,FuenteDescripcion = CultureHelper.GetTraduction(m.Fuente_Fuente_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Fuente_Fuente_de_Mandamiento_Judicial.Descripcion
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                        ,Pais_al_que_Pertenece_la_InformacionNombre = CultureHelper.GetTraduction(m.Pais_al_que_Pertenece_la_Informacion_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_al_que_Pertenece_la_Informacion_Pais.Nombre
                        ,Estado_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Estado_que_Envia_la_Informacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_que_Envia_la_Informacion_Estado.Nombre
                        ,Municipio_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Municipio_que_Envia_la_Informacion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_que_Envia_la_Informacion_Municipio.Nombre
                        ,Institucion_que_RemiteNombre = CultureHelper.GetTraduction(m.Institucion_que_Remite_Institucion_Emisora.Clave.ToString(), "Nombre") ?? (string)m.Institucion_que_Remite_Institucion_Emisora.Nombre
			,Dependencia_Autoridad_Remitente = m.Dependencia_Autoridad_Remitente
                        ,Entidad_que_Emite_MandamientoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emite_Mandamiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emite_Mandamiento_Estado.Nombre
                        ,Juzgado_que_Emitio_MandamientoNombre = CultureHelper.GetTraduction(m.Juzgado_que_Emitio_Mandamiento_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_que_Emitio_Mandamiento_Juzgado.Nombre
			,Oficio_de_Juzgado = m.Oficio_de_Juzgado
                        ,Area_que_envia_OrdenDescripcion = CultureHelper.GetTraduction(m.Area_que_envia_Orden_Unidad.Clave.ToString(), "Unidad") ?? (string)m.Area_que_envia_Orden_Unidad.Descripcion
			,Observaciones = m.Observaciones
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Mandamiento_Judicial.Descripcion
			,Numero_de_Proceso_Judicial = m.Numero_de_Proceso_Judicial
                        ,Fecha_de_Libramiento = (m.Fecha_de_Libramiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Libramiento).ToString(ConfigurationProperty.DateFormat))
			,Oficio_de_Libramiento = m.Oficio_de_Libramiento
                        ,Fecha_de_Transcripcion = (m.Fecha_de_Transcripcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Transcripcion).ToString(ConfigurationProperty.DateFormat))
			,Oficio_Transcripcion = m.Oficio_Transcripcion
                        ,Carpeta_de_Investigacionnic = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Carpeta_de_Investigacion_expediente_ministerio_publico.nic
                        ,Causa_Penalcausa_o_cuadernillo = CultureHelper.GetTraduction(m.Causa_Penal_Judicializacion.Clave.ToString(), "Judicializacion") ?? (string)m.Causa_Penal_Judicializacion.causa_o_cuadernillo

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45671, arrayColumnsVisible), "Registro_de_Mandamiento_JudicialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45671, arrayColumnsVisible), "Registro_de_Mandamiento_JudicialList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45671, arrayColumnsVisible), "Registro_de_Mandamiento_JudicialList_" + DateTime.Now.ToString());
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

            _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Registro_de_Mandamiento_JudicialPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Registro_de_Mandamiento_JudicialAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Registro_de_Mandamiento_JudicialPropertyMapper oRegistro_de_Mandamiento_JudicialPropertyMapper = new Registro_de_Mandamiento_JudicialPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oRegistro_de_Mandamiento_JudicialPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IRegistro_de_Mandamiento_JudicialApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Registro_de_Mandamiento_Judicials == null)
                result.Registro_de_Mandamiento_Judicials = new List<Registro_de_Mandamiento_Judicial>();

            var data = result.Registro_de_Mandamiento_Judicials.Select(m => new Registro_de_Mandamiento_JudicialGridModel
            {
                Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Mandamiento = m.Numero_de_Mandamiento
                        ,Tipo_MandatoDescripcion = CultureHelper.GetTraduction(m.Tipo_Mandato_Tipo_de_Mandamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Mandato_Tipo_de_Mandamiento.Descripcion
                        ,FuenteDescripcion = CultureHelper.GetTraduction(m.Fuente_Fuente_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Fuente_Fuente_de_Mandamiento_Judicial.Descripcion
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                        ,Pais_al_que_Pertenece_la_InformacionNombre = CultureHelper.GetTraduction(m.Pais_al_que_Pertenece_la_Informacion_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_al_que_Pertenece_la_Informacion_Pais.Nombre
                        ,Estado_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Estado_que_Envia_la_Informacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_que_Envia_la_Informacion_Estado.Nombre
                        ,Municipio_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Municipio_que_Envia_la_Informacion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_que_Envia_la_Informacion_Municipio.Nombre
                        ,Institucion_que_RemiteNombre = CultureHelper.GetTraduction(m.Institucion_que_Remite_Institucion_Emisora.Clave.ToString(), "Nombre") ?? (string)m.Institucion_que_Remite_Institucion_Emisora.Nombre
			,Dependencia_Autoridad_Remitente = m.Dependencia_Autoridad_Remitente
                        ,Entidad_que_Emite_MandamientoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emite_Mandamiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emite_Mandamiento_Estado.Nombre
                        ,Juzgado_que_Emitio_MandamientoNombre = CultureHelper.GetTraduction(m.Juzgado_que_Emitio_Mandamiento_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_que_Emitio_Mandamiento_Juzgado.Nombre
			,Oficio_de_Juzgado = m.Oficio_de_Juzgado
                        ,Area_que_envia_OrdenDescripcion = CultureHelper.GetTraduction(m.Area_que_envia_Orden_Unidad.Clave.ToString(), "Unidad") ?? (string)m.Area_que_envia_Orden_Unidad.Descripcion
			,Observaciones = m.Observaciones
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Mandamiento_Judicial.Descripcion
			,Numero_de_Proceso_Judicial = m.Numero_de_Proceso_Judicial
                        ,Fecha_de_Libramiento = (m.Fecha_de_Libramiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Libramiento).ToString(ConfigurationProperty.DateFormat))
			,Oficio_de_Libramiento = m.Oficio_de_Libramiento
                        ,Fecha_de_Transcripcion = (m.Fecha_de_Transcripcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Transcripcion).ToString(ConfigurationProperty.DateFormat))
			,Oficio_Transcripcion = m.Oficio_Transcripcion
                        ,Carpeta_de_Investigacionnic = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Carpeta_de_Investigacion_expediente_ministerio_publico.nic
                        ,Causa_Penalcausa_o_cuadernillo = CultureHelper.GetTraduction(m.Causa_Penal_Judicializacion.Clave.ToString(), "Judicializacion") ?? (string)m.Causa_Penal_Judicializacion.causa_o_cuadernillo

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
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IRegistro_de_Mandamiento_JudicialApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Registro_de_Mandamiento_Judicial_Datos_GeneralesModel varRegistro_de_Mandamiento_Judicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Mandamiento_Judicial_Datos_GeneralesInfo = new Registro_de_Mandamiento_Judicial_Datos_Generales
                {
                    Clave = varRegistro_de_Mandamiento_Judicial.Clave
                                            ,Fecha_de_Registro = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Registro)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Registro, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_de_Registro = varRegistro_de_Mandamiento_Judicial.Hora_de_Registro
                        ,Usuario_que_Registra = varRegistro_de_Mandamiento_Judicial.Usuario_que_Registra
                        ,Numero_de_Mandamiento = varRegistro_de_Mandamiento_Judicial.Numero_de_Mandamiento
                        ,Tipo_Mandato = varRegistro_de_Mandamiento_Judicial.Tipo_Mandato
                        ,Fuente = varRegistro_de_Mandamiento_Judicial.Fuente
                        ,Fecha_de_Solicitud = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Solicitud)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Solicitud, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Pais_al_que_Pertenece_la_Informacion = varRegistro_de_Mandamiento_Judicial.Pais_al_que_Pertenece_la_Informacion
                        ,Estado_que_Envia_la_Informacion = varRegistro_de_Mandamiento_Judicial.Estado_que_Envia_la_Informacion
                        ,Municipio_que_Envia_la_Informacion = varRegistro_de_Mandamiento_Judicial.Municipio_que_Envia_la_Informacion
                        ,Institucion_que_Remite = varRegistro_de_Mandamiento_Judicial.Institucion_que_Remite
                        ,Dependencia_Autoridad_Remitente = varRegistro_de_Mandamiento_Judicial.Dependencia_Autoridad_Remitente
                        ,Entidad_que_Emite_Mandamiento = varRegistro_de_Mandamiento_Judicial.Entidad_que_Emite_Mandamiento
                        ,Juzgado_que_Emitio_Mandamiento = varRegistro_de_Mandamiento_Judicial.Juzgado_que_Emitio_Mandamiento
                        ,Oficio_de_Juzgado = varRegistro_de_Mandamiento_Judicial.Oficio_de_Juzgado
                        ,Area_que_envia_Orden = varRegistro_de_Mandamiento_Judicial.Area_que_envia_Orden
                        ,Observaciones = varRegistro_de_Mandamiento_Judicial.Observaciones
                        ,Estatus = varRegistro_de_Mandamiento_Judicial.Estatus
                    
                };

                result = _IRegistro_de_Mandamiento_JudicialApiConsumer.Update_Datos_Generales(Registro_de_Mandamiento_Judicial_Datos_GeneralesInfo).Resource.ToString();
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
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Mandamiento_JudicialApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Personas_a_Incluir;
                var Detalle_de_Personas_a_IncluirData = GetDetalle_de_Personas_a_IncluirData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Personas_a_Incluir);

                var result = new Registro_de_Mandamiento_Judicial_Datos_GeneralesModel
                {
                    Clave = m.Clave
                        ,Fecha_de_Registro = (m.Fecha_de_Registro == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Registro).ToString(ConfigurationProperty.DateFormat))
			,Hora_de_Registro = m.Hora_de_Registro
                        ,Usuario_que_Registra = m.Usuario_que_Registra
                        ,Usuario_que_RegistraName = CultureHelper.GetTraduction(m.Usuario_que_Registra_Spartan_User.Id_User.ToString(), "Spartan_User") ?? (string)m.Usuario_que_Registra_Spartan_User.Name
			,Numero_de_Mandamiento = m.Numero_de_Mandamiento
                        ,Tipo_Mandato = m.Tipo_Mandato
                        ,Tipo_MandatoDescripcion = CultureHelper.GetTraduction(m.Tipo_Mandato_Tipo_de_Mandamiento.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_Mandato_Tipo_de_Mandamiento.Descripcion
                        ,Fuente = m.Fuente
                        ,FuenteDescripcion = CultureHelper.GetTraduction(m.Fuente_Fuente_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Fuente_Fuente_de_Mandamiento_Judicial.Descripcion
                        ,Fecha_de_Solicitud = (m.Fecha_de_Solicitud == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Solicitud).ToString(ConfigurationProperty.DateFormat))
                        ,Pais_al_que_Pertenece_la_Informacion = m.Pais_al_que_Pertenece_la_Informacion
                        ,Pais_al_que_Pertenece_la_InformacionNombre = CultureHelper.GetTraduction(m.Pais_al_que_Pertenece_la_Informacion_Pais.Clave.ToString(), "Pais") ?? (string)m.Pais_al_que_Pertenece_la_Informacion_Pais.Nombre
                        ,Estado_que_Envia_la_Informacion = m.Estado_que_Envia_la_Informacion
                        ,Estado_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Estado_que_Envia_la_Informacion_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_que_Envia_la_Informacion_Estado.Nombre
                        ,Municipio_que_Envia_la_Informacion = m.Municipio_que_Envia_la_Informacion
                        ,Municipio_que_Envia_la_InformacionNombre = CultureHelper.GetTraduction(m.Municipio_que_Envia_la_Informacion_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_que_Envia_la_Informacion_Municipio.Nombre
                        ,Institucion_que_Remite = m.Institucion_que_Remite
                        ,Institucion_que_RemiteNombre = CultureHelper.GetTraduction(m.Institucion_que_Remite_Institucion_Emisora.Clave.ToString(), "Nombre") ?? (string)m.Institucion_que_Remite_Institucion_Emisora.Nombre
			,Dependencia_Autoridad_Remitente = m.Dependencia_Autoridad_Remitente
                        ,Entidad_que_Emite_Mandamiento = m.Entidad_que_Emite_Mandamiento
                        ,Entidad_que_Emite_MandamientoNombre = CultureHelper.GetTraduction(m.Entidad_que_Emite_Mandamiento_Estado.Clave.ToString(), "Estado") ?? (string)m.Entidad_que_Emite_Mandamiento_Estado.Nombre
                        ,Juzgado_que_Emitio_Mandamiento = m.Juzgado_que_Emitio_Mandamiento
                        ,Juzgado_que_Emitio_MandamientoNombre = CultureHelper.GetTraduction(m.Juzgado_que_Emitio_Mandamiento_Juzgado.Clave.ToString(), "Nombre") ?? (string)m.Juzgado_que_Emitio_Mandamiento_Juzgado.Nombre
			,Oficio_de_Juzgado = m.Oficio_de_Juzgado
                        ,Area_que_envia_Orden = m.Area_que_envia_Orden
                        ,Area_que_envia_OrdenDescripcion = CultureHelper.GetTraduction(m.Area_que_envia_Orden_Unidad.Clave.ToString(), "Unidad") ?? (string)m.Area_que_envia_Orden_Unidad.Descripcion
			,Observaciones = m.Observaciones
                        ,Estatus = m.Estatus
                        ,EstatusDescripcion = CultureHelper.GetTraduction(m.Estatus_Estatus_de_Mandamiento_Judicial.Clave.ToString(), "Descripcion") ?? (string)m.Estatus_Estatus_de_Mandamiento_Judicial.Descripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Personas_a_Incluir = Detalle_de_Personas_a_IncluirData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Proceso(Registro_de_Mandamiento_Judicial_ProcesoModel varRegistro_de_Mandamiento_Judicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Mandamiento_Judicial_ProcesoInfo = new Registro_de_Mandamiento_Judicial_Proceso
                {
                    Clave = varRegistro_de_Mandamiento_Judicial.Clave
                                            ,Numero_de_Proceso_Judicial = varRegistro_de_Mandamiento_Judicial.Numero_de_Proceso_Judicial
                        ,Fecha_de_Libramiento = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Libramiento)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Libramiento, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Oficio_de_Libramiento = varRegistro_de_Mandamiento_Judicial.Oficio_de_Libramiento
                        ,Fecha_de_Transcripcion = (!String.IsNullOrEmpty(varRegistro_de_Mandamiento_Judicial.Fecha_de_Transcripcion)) ? DateTime.ParseExact(varRegistro_de_Mandamiento_Judicial.Fecha_de_Transcripcion, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Oficio_Transcripcion = varRegistro_de_Mandamiento_Judicial.Oficio_Transcripcion
                    
                };

                result = _IRegistro_de_Mandamiento_JudicialApiConsumer.Update_Proceso(Registro_de_Mandamiento_Judicial_ProcesoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Proceso(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Mandamiento_JudicialApiConsumer.Get_Proceso(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Personas_a_Incluir;
                var Detalle_de_Personas_a_IncluirData = GetDetalle_de_Personas_a_IncluirData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Personas_a_Incluir);

                var result = new Registro_de_Mandamiento_Judicial_ProcesoModel
                {
                    Clave = m.Clave
			,Numero_de_Proceso_Judicial = m.Numero_de_Proceso_Judicial
                        ,Fecha_de_Libramiento = (m.Fecha_de_Libramiento == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Libramiento).ToString(ConfigurationProperty.DateFormat))
			,Oficio_de_Libramiento = m.Oficio_de_Libramiento
                        ,Fecha_de_Transcripcion = (m.Fecha_de_Transcripcion == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Transcripcion).ToString(ConfigurationProperty.DateFormat))
			,Oficio_Transcripcion = m.Oficio_Transcripcion

                    
                };
				var resultData = new
                {
                    data = result
                    ,Personas_a_Incluir = Detalle_de_Personas_a_IncluirData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Expediente(Registro_de_Mandamiento_Judicial_ExpedienteModel varRegistro_de_Mandamiento_Judicial)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Registro_de_Mandamiento_Judicial_ExpedienteInfo = new Registro_de_Mandamiento_Judicial_Expediente
                {
                    Clave = varRegistro_de_Mandamiento_Judicial.Clave
                                            ,Carpeta_de_Investigacion = varRegistro_de_Mandamiento_Judicial.Carpeta_de_Investigacion
                        ,Causa_Penal = varRegistro_de_Mandamiento_Judicial.Causa_Penal
                    
                };

                result = _IRegistro_de_Mandamiento_JudicialApiConsumer.Update_Expediente(Registro_de_Mandamiento_Judicial_ExpedienteInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Expediente(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IRegistro_de_Mandamiento_JudicialApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IRegistro_de_Mandamiento_JudicialApiConsumer.Get_Expediente(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Detalle_de_Personas_a_Incluir;
                var Detalle_de_Personas_a_IncluirData = GetDetalle_de_Personas_a_IncluirData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Detalle_de_Personas_a_Incluir);

                var result = new Registro_de_Mandamiento_Judicial_ExpedienteModel
                {
                    Clave = m.Clave
                        ,Carpeta_de_Investigacion = m.Carpeta_de_Investigacion
                        ,Carpeta_de_Investigacionnic = CultureHelper.GetTraduction(m.Carpeta_de_Investigacion_expediente_ministerio_publico.clave.ToString(), "expediente_ministerio_publico") ?? (string)m.Carpeta_de_Investigacion_expediente_ministerio_publico.nic
                        ,Causa_Penal = m.Causa_Penal
                        ,Causa_Penalcausa_o_cuadernillo = CultureHelper.GetTraduction(m.Causa_Penal_Judicializacion.Clave.ToString(), "Judicializacion") ?? (string)m.Causa_Penal_Judicializacion.causa_o_cuadernillo

                    
                };
				var resultData = new
                {
                    data = result
                    ,Personas_a_Incluir = Detalle_de_Personas_a_IncluirData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

