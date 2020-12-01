using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using Spartane.Core.Domain.Detalle_de_Delito_de_Justicia;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.Tipo_de_Denuncia;
using Spartane.Core.Domain.Delitos_Violencia_Genero;
using Spartane.Core.Domain.Titulo_del_Delito;
using Spartane.Core.Domain.Grupo_del_Delito;
using Spartane.Core.Domain.Delito;
using Spartane.Core.Domain.Agravantes_del_Delito_MASC;

using Spartane.Core.Domain.Agravantes;

using Spartane.Core.Domain.Circunstancias_del_Delito_MASC;

using Spartane.Core.Domain.Circunstancias;

using Spartane.Core.Domain.Forma_Comision_Delito;
using Spartane.Core.Domain.Forma_Accion_Delito;
using Spartane.Core.Domain.Modalidad_Delito;
using Spartane.Core.Domain.Elementos_Comision_Delito;
using Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado;
using Spartane.Core.Domain.Concurso;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Elemento_Robado;
using Spartane.Core.Domain.Circunstancia_Vehiculo;
using Spartane.Core.Domain.Marca_del_Vehiculo;
using Spartane.Core.Domain.Sub_Marca_del_Vehiculo;
using Spartane.Core.Domain.Tipo_de_Vehiculo;
using Spartane.Core.Domain.Color_Vehiculo;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Estado;
using Spartane.Core.Domain.Municipio;
using Spartane.Core.Domain.Colonia;
using Spartane.Core.Domain.Lugar_del_Robo;
using Spartane.Core.Domain.Aseguradora_de_Vehiculo;
using Spartane.Core.Domain.Binario;
using Spartane.Core.Domain.Tipo_de_Robo;
using Spartane.Core.Domain.Tipo_de_Lugar_del_Robo;
using Spartane.Core.Domain.Tipo_de_Carretera;
using Spartane.Core.Domain.Servicio_del_Vehiculo;
using Spartane.Core.Domain.Detalle_de_Persona_Moral_JA;
using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;
using Spartane.Core.Domain.Detalle_de_Solicitud_Solicitante;

using Spartane.Core.Enums;
using Spartane.Core.Domain.Spartane_File;
using Spartane.Core.Exceptions.Service;
using Spartane.Services.Detalle_de_Delito_de_Justicia;
using Spartane.Web.Areas.Frontal.Models;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.Spartane_File;
using Spartane.Web.Areas.WebApiConsumer.ApiAuthentication;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Delito_de_Justicia;
using Spartane.Web.Areas.WebApiConsumer.Solicitud;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Denuncia;
using Spartane.Web.Areas.WebApiConsumer.Delitos_Violencia_Genero;
using Spartane.Web.Areas.WebApiConsumer.Titulo_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Grupo_del_Delito;
using Spartane.Web.Areas.WebApiConsumer.Delito;
using Spartane.Web.Areas.WebApiConsumer.Agravantes_del_Delito_MASC;

using Spartane.Web.Areas.WebApiConsumer.Agravantes;

using Spartane.Web.Areas.WebApiConsumer.Circunstancias_del_Delito_MASC;

using Spartane.Web.Areas.WebApiConsumer.Circunstancias;

using Spartane.Web.Areas.WebApiConsumer.Forma_Comision_Delito;
using Spartane.Web.Areas.WebApiConsumer.Forma_Accion_Delito;
using Spartane.Web.Areas.WebApiConsumer.Modalidad_Delito;
using Spartane.Web.Areas.WebApiConsumer.Elementos_Comision_Delito;
using Spartane.Web.Areas.WebApiConsumer.Clasificacion_en_Orden_de_Resultado;
using Spartane.Web.Areas.WebApiConsumer.Concurso;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Elemento_Robado;
using Spartane.Web.Areas.WebApiConsumer.Circunstancia_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Marca_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Sub_Marca_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Color_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Estado;
using Spartane.Web.Areas.WebApiConsumer.Municipio;
using Spartane.Web.Areas.WebApiConsumer.Colonia;
using Spartane.Web.Areas.WebApiConsumer.Lugar_del_Robo;
using Spartane.Web.Areas.WebApiConsumer.Aseguradora_de_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Binario;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Robo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Lugar_del_Robo;
using Spartane.Web.Areas.WebApiConsumer.Tipo_de_Carretera;
using Spartane.Web.Areas.WebApiConsumer.Servicio_del_Vehiculo;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Persona_Moral_JA;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Solicitante;
using Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Solicitante;

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
    public class Detalle_de_Delito_de_JusticiaController : Controller
    {
        #region "variable declaration"

        private IDetalle_de_Delito_de_JusticiaService service = null;
        private IDetalle_de_Delito_de_JusticiaApiConsumer _IDetalle_de_Delito_de_JusticiaApiConsumer;
        private ISolicitudApiConsumer _ISolicitudApiConsumer;
        private ITipo_de_DenunciaApiConsumer _ITipo_de_DenunciaApiConsumer;
        private IDelitos_Violencia_GeneroApiConsumer _IDelitos_Violencia_GeneroApiConsumer;
        private ITitulo_del_DelitoApiConsumer _ITitulo_del_DelitoApiConsumer;
        private IGrupo_del_DelitoApiConsumer _IGrupo_del_DelitoApiConsumer;
        private IDelitoApiConsumer _IDelitoApiConsumer;
        private IAgravantes_del_Delito_MASCApiConsumer _IAgravantes_del_Delito_MASCApiConsumer;

        private IAgravantesApiConsumer _IAgravantesApiConsumer;

        private ICircunstancias_del_Delito_MASCApiConsumer _ICircunstancias_del_Delito_MASCApiConsumer;

        private ICircunstanciasApiConsumer _ICircunstanciasApiConsumer;

        private IForma_Comision_DelitoApiConsumer _IForma_Comision_DelitoApiConsumer;
        private IForma_Accion_DelitoApiConsumer _IForma_Accion_DelitoApiConsumer;
        private IModalidad_DelitoApiConsumer _IModalidad_DelitoApiConsumer;
        private IElementos_Comision_DelitoApiConsumer _IElementos_Comision_DelitoApiConsumer;
        private IClasificacion_en_Orden_de_ResultadoApiConsumer _IClasificacion_en_Orden_de_ResultadoApiConsumer;
        private IConcursoApiConsumer _IConcursoApiConsumer;
        private IEstadoApiConsumer _IEstadoApiConsumer;
        private IMunicipioApiConsumer _IMunicipioApiConsumer;
        private IColoniaApiConsumer _IColoniaApiConsumer;
        private IElemento_RobadoApiConsumer _IElemento_RobadoApiConsumer;
        private ICircunstancia_VehiculoApiConsumer _ICircunstancia_VehiculoApiConsumer;
        private IMarca_del_VehiculoApiConsumer _IMarca_del_VehiculoApiConsumer;
        private ISub_Marca_del_VehiculoApiConsumer _ISub_Marca_del_VehiculoApiConsumer;
        private ITipo_de_VehiculoApiConsumer _ITipo_de_VehiculoApiConsumer;
        private IColor_VehiculoApiConsumer _IColor_VehiculoApiConsumer;
        private ILugar_del_RoboApiConsumer _ILugar_del_RoboApiConsumer;
        private IAseguradora_de_VehiculoApiConsumer _IAseguradora_de_VehiculoApiConsumer;
        private IBinarioApiConsumer _IBinarioApiConsumer;
        private ITipo_de_RoboApiConsumer _ITipo_de_RoboApiConsumer;
        private ITipo_de_Lugar_del_RoboApiConsumer _ITipo_de_Lugar_del_RoboApiConsumer;
        private ITipo_de_CarreteraApiConsumer _ITipo_de_CarreteraApiConsumer;
        private IServicio_del_VehiculoApiConsumer _IServicio_del_VehiculoApiConsumer;
        private IDetalle_de_Persona_Moral_JAApiConsumer _IDetalle_de_Persona_Moral_JAApiConsumer;
        private IDetalle_de_Solicitud_SolicitanteApiConsumer _IDetalle_de_Solicitud_SolicitanteApiConsumer;

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

        
        public Detalle_de_Delito_de_JusticiaController(IDetalle_de_Delito_de_JusticiaService service,ITokenManager tokenManager, IAuthenticationApiConsumer authenticationApiConsumer, IDetalle_de_Delito_de_JusticiaApiConsumer Detalle_de_Delito_de_JusticiaApiConsumer, ISpartane_FileApiConsumer Spartane_FileApiConsumer, ISpartan_Business_RuleApiConsumer Spartan_Business_RuleApiConsumer, ISpartan_BR_Process_Event_DetailApiConsumer Spartan_BR_Process_Event_DetailApiConsumer, ISpartan_FormatApiConsumer Spartan_FormatApiConsumer, ISpartan_Format_PermissionsApiConsumer Spartan_Format_PermissionsApiConsumer, IGeneratePDFApiConsumer GeneratePDFApiConsumer, ISpartan_Format_RelatedApiConsumer Spartan_Format_RelatedApiConsumer , ISolicitudApiConsumer SolicitudApiConsumer , ITipo_de_DenunciaApiConsumer Tipo_de_DenunciaApiConsumer , IDelitos_Violencia_GeneroApiConsumer Delitos_Violencia_GeneroApiConsumer , ITitulo_del_DelitoApiConsumer Titulo_del_DelitoApiConsumer , IGrupo_del_DelitoApiConsumer Grupo_del_DelitoApiConsumer , IDelitoApiConsumer DelitoApiConsumer , IAgravantes_del_Delito_MASCApiConsumer Agravantes_del_Delito_MASCApiConsumer , IAgravantesApiConsumer AgravantesApiConsumer  , ICircunstancias_del_Delito_MASCApiConsumer Circunstancias_del_Delito_MASCApiConsumer , ICircunstanciasApiConsumer CircunstanciasApiConsumer  , IForma_Comision_DelitoApiConsumer Forma_Comision_DelitoApiConsumer , IForma_Accion_DelitoApiConsumer Forma_Accion_DelitoApiConsumer , IModalidad_DelitoApiConsumer Modalidad_DelitoApiConsumer , IElementos_Comision_DelitoApiConsumer Elementos_Comision_DelitoApiConsumer , IClasificacion_en_Orden_de_ResultadoApiConsumer Clasificacion_en_Orden_de_ResultadoApiConsumer , IConcursoApiConsumer ConcursoApiConsumer , IEstadoApiConsumer EstadoApiConsumer , IMunicipioApiConsumer MunicipioApiConsumer , IColoniaApiConsumer ColoniaApiConsumer , IElemento_RobadoApiConsumer Elemento_RobadoApiConsumer , ICircunstancia_VehiculoApiConsumer Circunstancia_VehiculoApiConsumer , IMarca_del_VehiculoApiConsumer Marca_del_VehiculoApiConsumer , ISub_Marca_del_VehiculoApiConsumer Sub_Marca_del_VehiculoApiConsumer , ITipo_de_VehiculoApiConsumer Tipo_de_VehiculoApiConsumer , IColor_VehiculoApiConsumer Color_VehiculoApiConsumer , ILugar_del_RoboApiConsumer Lugar_del_RoboApiConsumer , IAseguradora_de_VehiculoApiConsumer Aseguradora_de_VehiculoApiConsumer , IBinarioApiConsumer BinarioApiConsumer , ITipo_de_RoboApiConsumer Tipo_de_RoboApiConsumer , ITipo_de_Lugar_del_RoboApiConsumer Tipo_de_Lugar_del_RoboApiConsumer , ITipo_de_CarreteraApiConsumer Tipo_de_CarreteraApiConsumer , IServicio_del_VehiculoApiConsumer Servicio_del_VehiculoApiConsumer , IDetalle_de_Persona_Moral_JAApiConsumer Detalle_de_Persona_Moral_JAApiConsumer , IDetalle_de_Solicitud_SolicitanteApiConsumer Detalle_de_Solicitud_SolicitanteApiConsumer )
        {
            this.service = service;
            this._IAuthenticationApiConsumer = authenticationApiConsumer;
            this._IDetalle_de_Delito_de_JusticiaApiConsumer = Detalle_de_Delito_de_JusticiaApiConsumer;
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
            this._ITipo_de_DenunciaApiConsumer = Tipo_de_DenunciaApiConsumer;
            this._IDelitos_Violencia_GeneroApiConsumer = Delitos_Violencia_GeneroApiConsumer;
            this._ITitulo_del_DelitoApiConsumer = Titulo_del_DelitoApiConsumer;
            this._IGrupo_del_DelitoApiConsumer = Grupo_del_DelitoApiConsumer;
            this._IDelitoApiConsumer = DelitoApiConsumer;
            this._IAgravantes_del_Delito_MASCApiConsumer = Agravantes_del_Delito_MASCApiConsumer;

            this._IAgravantesApiConsumer = AgravantesApiConsumer;

            this._ICircunstancias_del_Delito_MASCApiConsumer = Circunstancias_del_Delito_MASCApiConsumer;

            this._ICircunstanciasApiConsumer = CircunstanciasApiConsumer;

            this._IForma_Comision_DelitoApiConsumer = Forma_Comision_DelitoApiConsumer;
            this._IForma_Accion_DelitoApiConsumer = Forma_Accion_DelitoApiConsumer;
            this._IModalidad_DelitoApiConsumer = Modalidad_DelitoApiConsumer;
            this._IElementos_Comision_DelitoApiConsumer = Elementos_Comision_DelitoApiConsumer;
            this._IClasificacion_en_Orden_de_ResultadoApiConsumer = Clasificacion_en_Orden_de_ResultadoApiConsumer;
            this._IConcursoApiConsumer = ConcursoApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._IElemento_RobadoApiConsumer = Elemento_RobadoApiConsumer;
            this._ICircunstancia_VehiculoApiConsumer = Circunstancia_VehiculoApiConsumer;
            this._IMarca_del_VehiculoApiConsumer = Marca_del_VehiculoApiConsumer;
            this._ISub_Marca_del_VehiculoApiConsumer = Sub_Marca_del_VehiculoApiConsumer;
            this._ITipo_de_VehiculoApiConsumer = Tipo_de_VehiculoApiConsumer;
            this._IColor_VehiculoApiConsumer = Color_VehiculoApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IEstadoApiConsumer = EstadoApiConsumer;
            this._IMunicipioApiConsumer = MunicipioApiConsumer;
            this._IColoniaApiConsumer = ColoniaApiConsumer;
            this._ILugar_del_RoboApiConsumer = Lugar_del_RoboApiConsumer;
            this._IAseguradora_de_VehiculoApiConsumer = Aseguradora_de_VehiculoApiConsumer;
            this._IBinarioApiConsumer = BinarioApiConsumer;
            this._ITipo_de_RoboApiConsumer = Tipo_de_RoboApiConsumer;
            this._ITipo_de_Lugar_del_RoboApiConsumer = Tipo_de_Lugar_del_RoboApiConsumer;
            this._ITipo_de_CarreteraApiConsumer = Tipo_de_CarreteraApiConsumer;
            this._IServicio_del_VehiculoApiConsumer = Servicio_del_VehiculoApiConsumer;
            this._IDetalle_de_Persona_Moral_JAApiConsumer = Detalle_de_Persona_Moral_JAApiConsumer;
            this._IDetalle_de_Solicitud_SolicitanteApiConsumer = Detalle_de_Solicitud_SolicitanteApiConsumer;
            this._IDetalle_de_Solicitud_SolicitanteApiConsumer = Detalle_de_Solicitud_SolicitanteApiConsumer;

        }

        #endregion "Constructor Declaration"

        #region "Controller Methods"

        // GET: Frontal/Detalle_de_Delito_de_Justicia
        [ObjectAuth(ObjectId = (ModuleObjectId)45093, PermissionType = PermissionTypes.Consult)]
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
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45093, ModuleId);
            ViewBag.Permission = permission;
            ViewBag.AdvanceSearch = Session["AdvanceSearch"] != null;
			          
            return View();
        }

        // GET: Frontal/Detalle_de_Delito_de_Justicia/Create
          [ObjectAuth(ObjectId = (ModuleObjectId)45093, PermissionType = PermissionTypes.New,
            OptionalParameter = "Id", OptionalPermissionType = PermissionTypes.Edit, OptionalPermissionTypeConsult = PermissionTypes.Consult)]
        public ActionResult Create(int Id = 0,  int consult = 0, int ModuleId=0)
        {
                       if(ModuleId == 0)
                       {
			    ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
                       }
                       else
                            Session["CurrentModuleId"] = ModuleId;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45093, ModuleId);
           if ((!permission.New && Id.ToString() == "0") || (!permission.Edit && Id.ToString() != "0" && (!permission.Consult && consult == 1)))
            {
                Response.Redirect("~/");
            }
            ViewBag.Permission = permission;
            var varDetalle_de_Delito_de_Justicia = new Detalle_de_Delito_de_JusticiaModel();
			varDetalle_de_Delito_de_Justicia.Clave = Id;
			
            ViewBag.ObjectId = "45093";
			ViewBag.Operation = "New";
			
			ViewBag.IsNew = true;

            var permissionAgravantes_del_Delito_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45331, ModuleId);
            ViewBag.PermissionAgravantes_del_Delito_MASC = permissionAgravantes_del_Delito_MASC;
            var permissionCircunstancias_del_Delito_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45332, ModuleId);
            ViewBag.PermissionCircunstancias_del_Delito_MASC = permissionCircunstancias_del_Delito_MASC;


            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short))&& Id.ToString() != "0"))
            {
				ViewBag.IsNew = false;
				ViewBag.Operation = "Update";
				
				_tokenManager.GenerateToken();
				_ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var Detalle_de_Delito_de_JusticiasData = _IDetalle_de_Delito_de_JusticiaApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Delito_de_Justicia.Clave=" + Id, "").Resource.Detalle_de_Delito_de_Justicias;
				
				if (Detalle_de_Delito_de_JusticiasData != null && Detalle_de_Delito_de_JusticiasData.Count > 0)
                {
					var Detalle_de_Delito_de_JusticiaData = Detalle_de_Delito_de_JusticiasData.First();
					varDetalle_de_Delito_de_Justicia= new Detalle_de_Delito_de_JusticiaModel
					{
						Clave  = Detalle_de_Delito_de_JusticiaData.Clave 
	                    ,idRegistroAT = Detalle_de_Delito_de_JusticiaData.idRegistroAT
                    ,idRegistroUI = Detalle_de_Delito_de_JusticiaData.idRegistroUI
                    ,Solicitud = Detalle_de_Delito_de_JusticiaData.Solicitud
                    ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Solicitud), "Solicitud") ??  (string)Detalle_de_Delito_de_JusticiaData.Solicitud_Solicitud.Numero_de_Folio
                    ,Tipo_de_Denuncia = Detalle_de_Delito_de_JusticiaData.Tipo_de_Denuncia
                    ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Tipo_de_Denuncia), "Tipo_de_Denuncia") ??  (string)Detalle_de_Delito_de_JusticiaData.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                    ,Fecha_de_Delito = (Detalle_de_Delito_de_JusticiaData.Fecha_de_Delito == null ? string.Empty : Convert.ToDateTime(Detalle_de_Delito_de_JusticiaData.Fecha_de_Delito).ToString(ConfigurationProperty.DateFormat))
                    ,Violencia_de_Genero = Detalle_de_Delito_de_JusticiaData.Violencia_de_Genero.GetValueOrDefault()
                    ,Delito_Violencia_Genero = Detalle_de_Delito_de_JusticiaData.Delito_Violencia_Genero
                    ,Delito_Violencia_GeneroDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Delito_Violencia_Genero), "Delitos_Violencia_Genero") ??  (string)Detalle_de_Delito_de_JusticiaData.Delito_Violencia_Genero_Delitos_Violencia_Genero.Descripcion
                    ,Hora_de_Delito = Detalle_de_Delito_de_JusticiaData.Hora_de_Delito
                    ,Tipo_de_Delito = Detalle_de_Delito_de_JusticiaData.Tipo_de_Delito
                    ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Tipo_de_Delito), "Titulo_del_Delito") ??  (string)Detalle_de_Delito_de_JusticiaData.Tipo_de_Delito_Titulo_del_Delito.Descripcion
                    ,Grupo_de_Delito = Detalle_de_Delito_de_JusticiaData.Grupo_de_Delito
                    ,Grupo_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Grupo_de_Delito), "Grupo_del_Delito") ??  (string)Detalle_de_Delito_de_JusticiaData.Grupo_de_Delito_Grupo_del_Delito.Descripcion
                    ,Delito = Detalle_de_Delito_de_JusticiaData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Delito), "Delito") ??  (string)Detalle_de_Delito_de_JusticiaData.Delito_Delito.Descripcion
                    ,Delito_Principal = Detalle_de_Delito_de_JusticiaData.Delito_Principal.GetValueOrDefault()
                    ,Forma_de_Comision_de_Delito = Detalle_de_Delito_de_JusticiaData.Forma_de_Comision_de_Delito
                    ,Forma_de_Comision_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Forma_de_Comision_de_Delito), "Forma_Comision_Delito") ??  (string)Detalle_de_Delito_de_JusticiaData.Forma_de_Comision_de_Delito_Forma_Comision_Delito.Descripcion
                    ,Forma_de_Accion_de_Delito = Detalle_de_Delito_de_JusticiaData.Forma_de_Accion_de_Delito
                    ,Forma_de_Accion_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Forma_de_Accion_de_Delito), "Forma_Accion_Delito") ??  (string)Detalle_de_Delito_de_JusticiaData.Forma_de_Accion_de_Delito_Forma_Accion_Delito.Descripcion
                    ,Modalidad_de_Delito = Detalle_de_Delito_de_JusticiaData.Modalidad_de_Delito
                    ,Modalidad_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Modalidad_de_Delito), "Modalidad_Delito") ??  (string)Detalle_de_Delito_de_JusticiaData.Modalidad_de_Delito_Modalidad_Delito.Descripcion
                    ,Elementos_de_Comision_de_Delito = Detalle_de_Delito_de_JusticiaData.Elementos_de_Comision_de_Delito
                    ,Elementos_de_Comision_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Elementos_de_Comision_de_Delito), "Elementos_Comision_Delito") ??  (string)Detalle_de_Delito_de_JusticiaData.Elementos_de_Comision_de_Delito_Elementos_Comision_Delito.Descripcion
                    ,Clasificacion_con_Orden_de_Resultado = Detalle_de_Delito_de_JusticiaData.Clasificacion_con_Orden_de_Resultado
                    ,Clasificacion_con_Orden_de_ResultadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Clasificacion_con_Orden_de_Resultado), "Clasificacion_en_Orden_de_Resultado") ??  (string)Detalle_de_Delito_de_JusticiaData.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Descripcion
                    ,Concurso = Detalle_de_Delito_de_JusticiaData.Concurso
                    ,ConcursoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Concurso), "Concurso") ??  (string)Detalle_de_Delito_de_JusticiaData.Concurso_Concurso.Descripcion
                    ,Monto_de_Reparacion_de_Danos = Detalle_de_Delito_de_JusticiaData.Monto_de_Reparacion_de_Danos
                    ,Estado_del_Delito = Detalle_de_Delito_de_JusticiaData.Estado_del_Delito
                    ,Estado_del_DelitoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Estado_del_Delito), "Estado") ??  (string)Detalle_de_Delito_de_JusticiaData.Estado_del_Delito_Estado.Nombre
                    ,Municipio_del_Delito = Detalle_de_Delito_de_JusticiaData.Municipio_del_Delito
                    ,Municipio_del_DelitoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Municipio_del_Delito), "Municipio") ??  (string)Detalle_de_Delito_de_JusticiaData.Municipio_del_Delito_Municipio.Nombre
                    ,Colonia_del_Delito = Detalle_de_Delito_de_JusticiaData.Colonia_del_Delito
                    ,Colonia_del_DelitoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Colonia_del_Delito), "Colonia") ??  (string)Detalle_de_Delito_de_JusticiaData.Colonia_del_Delito_Colonia.Nombre
                    ,Codigo_Postal = Detalle_de_Delito_de_JusticiaData.Codigo_Postal
                    ,Calle_del_Delito = Detalle_de_Delito_de_JusticiaData.Calle_del_Delito
                    ,Entre_Calle_del_Delito = Detalle_de_Delito_de_JusticiaData.Entre_Calle_del_Delito
                    ,Y_Calle_del_Delito = Detalle_de_Delito_de_JusticiaData.Y_Calle_del_Delito
                    ,Numero_Exterior_del_Delito = Detalle_de_Delito_de_JusticiaData.Numero_Exterior_del_Delito
                    ,Numero_Interior_del_Delito = Detalle_de_Delito_de_JusticiaData.Numero_Interior_del_Delito
                    ,Referencia = Detalle_de_Delito_de_JusticiaData.Referencia
                    ,Latitud = Detalle_de_Delito_de_JusticiaData.Latitud
                    ,Longitud = Detalle_de_Delito_de_JusticiaData.Longitud
                    ,Robo_de_Vehiculo = Detalle_de_Delito_de_JusticiaData.Robo_de_Vehiculo.GetValueOrDefault()
                    ,Fecha_del_Robo = (Detalle_de_Delito_de_JusticiaData.Fecha_del_Robo == null ? string.Empty : Convert.ToDateTime(Detalle_de_Delito_de_JusticiaData.Fecha_del_Robo).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_del_Robo = Detalle_de_Delito_de_JusticiaData.Hora_del_Robo
                    ,Robo_de = Detalle_de_Delito_de_JusticiaData.Robo_de
                    ,Robo_deDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Robo_de), "Elemento_Robado") ??  (string)Detalle_de_Delito_de_JusticiaData.Robo_de_Elemento_Robado.Descripcion
                    ,Registro_Federal_Vehicular = Detalle_de_Delito_de_JusticiaData.Registro_Federal_Vehicular
                    ,Numero_de_Registro_Publico_Vehicular = Detalle_de_Delito_de_JusticiaData.Numero_de_Registro_Publico_Vehicular
                    ,Circunstancia_de_Robo_de_Vehiculo = Detalle_de_Delito_de_JusticiaData.Circunstancia_de_Robo_de_Vehiculo
                    ,Circunstancia_de_Robo_de_VehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Circunstancia_de_Robo_de_Vehiculo), "Circunstancia_Vehiculo") ??  (string)Detalle_de_Delito_de_JusticiaData.Circunstancia_de_Robo_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                    ,Marca = Detalle_de_Delito_de_JusticiaData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Marca), "Marca_del_Vehiculo") ??  (string)Detalle_de_Delito_de_JusticiaData.Marca_Marca_del_Vehiculo.Descripcion
                    ,Sub_Marca = Detalle_de_Delito_de_JusticiaData.Sub_Marca
                    ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Sub_Marca), "Sub_Marca_del_Vehiculo") ??  (string)Detalle_de_Delito_de_JusticiaData.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                    ,Tipo_de_vehiculo = Detalle_de_Delito_de_JusticiaData.Tipo_de_vehiculo
                    ,Tipo_de_vehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Tipo_de_vehiculo), "Tipo_de_Vehiculo") ??  (string)Detalle_de_Delito_de_JusticiaData.Tipo_de_vehiculo_Tipo_de_Vehiculo.Descripcion
                    ,Modelo = Detalle_de_Delito_de_JusticiaData.Modelo
                    ,Color = Detalle_de_Delito_de_JusticiaData.Color
                    ,ColorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Color), "Color_Vehiculo") ??  (string)Detalle_de_Delito_de_JusticiaData.Color_Color_Vehiculo.Descripcion
                    ,Placas = Detalle_de_Delito_de_JusticiaData.Placas
                    ,Estado_de_Origen_de_las_Placas = Detalle_de_Delito_de_JusticiaData.Estado_de_Origen_de_las_Placas
                    ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Estado_de_Origen_de_las_Placas), "Estado") ??  (string)Detalle_de_Delito_de_JusticiaData.Estado_de_Origen_de_las_Placas_Estado.Nombre
                    ,Motor = Detalle_de_Delito_de_JusticiaData.Motor
                    ,Serie = Detalle_de_Delito_de_JusticiaData.Serie
                    ,Estado_De_Robo = Detalle_de_Delito_de_JusticiaData.Estado_De_Robo
                    ,Estado_De_RoboNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Estado_De_Robo), "Estado") ??  (string)Detalle_de_Delito_de_JusticiaData.Estado_De_Robo_Estado.Nombre
                    ,Municipio_de_Robo = Detalle_de_Delito_de_JusticiaData.Municipio_de_Robo
                    ,Municipio_de_RoboNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Municipio_de_Robo), "Municipio") ??  (string)Detalle_de_Delito_de_JusticiaData.Municipio_de_Robo_Municipio.Nombre
                    ,Colonia_de_Robo = Detalle_de_Delito_de_JusticiaData.Colonia_de_Robo
                    ,Colonia_de_RoboNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Colonia_de_Robo), "Colonia") ??  (string)Detalle_de_Delito_de_JusticiaData.Colonia_de_Robo_Colonia.Nombre
                    ,Codigo_Postal_de_Robo = Detalle_de_Delito_de_JusticiaData.Codigo_Postal_de_Robo
                    ,Calle_de_Robo = Detalle_de_Delito_de_JusticiaData.Calle_de_Robo
                    ,Entre_Calle_de_Robo = Detalle_de_Delito_de_JusticiaData.Entre_Calle_de_Robo
                    ,Y_Calle_de_Robo = Detalle_de_Delito_de_JusticiaData.Y_Calle_de_Robo
                    ,Numero_Exterior_de_Robo = Detalle_de_Delito_de_JusticiaData.Numero_Exterior_de_Robo
                    ,Numero_Interior_de_Robo = Detalle_de_Delito_de_JusticiaData.Numero_Interior_de_Robo
                    ,Referencia_de_Robo = Detalle_de_Delito_de_JusticiaData.Referencia_de_Robo
                    ,Latitud_de_Robo = Detalle_de_Delito_de_JusticiaData.Latitud_de_Robo
                    ,Longitud_de_Robo = Detalle_de_Delito_de_JusticiaData.Longitud_de_Robo
                    ,Lugar_de_Robo = Detalle_de_Delito_de_JusticiaData.Lugar_de_Robo
                    ,Lugar_de_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Lugar_de_Robo), "Lugar_del_Robo") ??  (string)Detalle_de_Delito_de_JusticiaData.Lugar_de_Robo_Lugar_del_Robo.Descripcion
                    ,El_vehiculo_esta_asegurado = Detalle_de_Delito_de_JusticiaData.El_vehiculo_esta_asegurado.GetValueOrDefault()
                    ,Nombre_de_la_Aseguradora = Detalle_de_Delito_de_JusticiaData.Nombre_de_la_Aseguradora
                    ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Nombre_de_la_Aseguradora), "Aseguradora_de_Vehiculo") ??  (string)Detalle_de_Delito_de_JusticiaData.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                    ,Ruta_del_Servicio_Publico = Detalle_de_Delito_de_JusticiaData.Ruta_del_Servicio_Publico
                    ,El_Vehiculo_Transportaba_Mercancia = Detalle_de_Delito_de_JusticiaData.El_Vehiculo_Transportaba_Mercancia.GetValueOrDefault()
                    ,Descripcion_de_lo_que_Transportaba = Detalle_de_Delito_de_JusticiaData.Descripcion_de_lo_que_Transportaba
                    ,Monto_de_carga = Detalle_de_Delito_de_JusticiaData.Monto_de_carga
                    ,Senas_particulares = Detalle_de_Delito_de_JusticiaData.Senas_particulares
                    ,Cuenta_con_GPS = Detalle_de_Delito_de_JusticiaData.Cuenta_con_GPS
                    ,Cuenta_con_GPSDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Cuenta_con_GPS), "Binario") ??  (string)Detalle_de_Delito_de_JusticiaData.Cuenta_con_GPS_Binario.Descripcion
                    ,Tipo_de_Robo = Detalle_de_Delito_de_JusticiaData.Tipo_de_Robo
                    ,Tipo_de_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Tipo_de_Robo), "Tipo_de_Robo") ??  (string)Detalle_de_Delito_de_JusticiaData.Tipo_de_Robo_Tipo_de_Robo.Descripcion
                    ,Tipo_de_Lugar_del_Robo = Detalle_de_Delito_de_JusticiaData.Tipo_de_Lugar_del_Robo
                    ,Tipo_de_Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Tipo_de_Lugar_del_Robo), "Tipo_de_Lugar_del_Robo") ??  (string)Detalle_de_Delito_de_JusticiaData.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                    ,Tipo_de_Carretera = Detalle_de_Delito_de_JusticiaData.Tipo_de_Carretera
                    ,Tipo_de_CarreteraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Tipo_de_Carretera), "Tipo_de_Carretera") ??  (string)Detalle_de_Delito_de_JusticiaData.Tipo_de_Carretera_Tipo_de_Carretera.Descripcion
                    ,Tipo_de_Servicio = Detalle_de_Delito_de_JusticiaData.Tipo_de_Servicio
                    ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Tipo_de_Servicio), "Servicio_del_Vehiculo") ??  (string)Detalle_de_Delito_de_JusticiaData.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
                    ,Numero_de_Serie = Detalle_de_Delito_de_JusticiaData.Numero_de_Serie
                    ,Numero_de_Motor = Detalle_de_Delito_de_JusticiaData.Numero_de_Motor
                    ,Persona_Moral = Detalle_de_Delito_de_JusticiaData.Persona_Moral.GetValueOrDefault()
                    ,Nombre_Completo_Persona_Moral = Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Persona_Moral
                    ,Nombre_Completo_Persona_MoralNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Persona_Moral), "Detalle_de_Persona_Moral_JA") ??  (string)Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Persona_Moral_Detalle_de_Persona_Moral_JA.Nombre
                    ,Persona_Fisica = Detalle_de_Delito_de_JusticiaData.Persona_Fisica.GetValueOrDefault()
                    ,Nombre_Completo_Persona_Fisica = Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Persona_Fisica
                    ,Nombre_Completo_Persona_FisicaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Persona_Fisica), "Detalle_de_Solicitud_Solicitante") ??  (string)Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante.Nombre
                    ,Denunciante = Detalle_de_Delito_de_JusticiaData.Denunciante.GetValueOrDefault()
                    ,Nombre_Completo_Denunciante = Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Denunciante
                    ,Nombre_Completo_DenuncianteNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Denunciante), "Detalle_de_Solicitud_Solicitante") ??  (string)Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Denunciante_Detalle_de_Solicitud_Solicitante.Nombre

					};
				}
				
				
				
            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITitulo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Titulo_del_Delitos_Tipo_de_Delito = _ITitulo_del_DelitoApiConsumer.SelAll(true);
            if (Titulo_del_Delitos_Tipo_de_Delito != null && Titulo_del_Delitos_Tipo_de_Delito.Resource != null)
                ViewBag.Titulo_del_Delitos_Tipo_de_Delito = Titulo_del_Delitos_Tipo_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Titulo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_del_Delitos_Grupo_de_Delito = _IGrupo_del_DelitoApiConsumer.SelAll(true);
            if (Grupo_del_Delitos_Grupo_de_Delito != null && Grupo_del_Delitos_Grupo_de_Delito.Resource != null)
                ViewBag.Grupo_del_Delitos_Grupo_de_Delito = Grupo_del_Delitos_Grupo_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Comision_Delitos_Forma_de_Comision_de_Delito = _IForma_Comision_DelitoApiConsumer.SelAll(true);
            if (Forma_Comision_Delitos_Forma_de_Comision_de_Delito != null && Forma_Comision_Delitos_Forma_de_Comision_de_Delito.Resource != null)
                ViewBag.Forma_Comision_Delitos_Forma_de_Comision_de_Delito = Forma_Comision_Delitos_Forma_de_Comision_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Accion_Delitos_Forma_de_Accion_de_Delito = _IForma_Accion_DelitoApiConsumer.SelAll(true);
            if (Forma_Accion_Delitos_Forma_de_Accion_de_Delito != null && Forma_Accion_Delitos_Forma_de_Accion_de_Delito.Resource != null)
                ViewBag.Forma_Accion_Delitos_Forma_de_Accion_de_Delito = Forma_Accion_Delitos_Forma_de_Accion_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad_de_Delito = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad_de_Delito != null && Modalidad_Delitos_Modalidad_de_Delito.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad_de_Delito = Modalidad_Delitos_Modalidad_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito = _IElementos_Comision_DelitoApiConsumer.SelAll(true);
            if (Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito != null && Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito.Resource != null)
                ViewBag.Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito = Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elementos_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IClasificacion_en_Orden_de_ResultadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado = _IClasificacion_en_Orden_de_ResultadoApiConsumer.SelAll(true);
            if (Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado != null && Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado.Resource != null)
                ViewBag.Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado = Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Clasificacion_en_Orden_de_Resultado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IConcursoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Concursos_Concurso = _IConcursoApiConsumer.SelAll(true);
            if (Concursos_Concurso != null && Concursos_Concurso.Resource != null)
                ViewBag.Concursos_Concurso = Concursos_Concurso.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Concurso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElemento_RobadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elemento_Robados_Robo_de = _IElemento_RobadoApiConsumer.SelAll(true);
            if (Elemento_Robados_Robo_de != null && Elemento_Robados_Robo_de.Resource != null)
                ViewBag.Elemento_Robados_Robo_de = Elemento_Robados_Robo_de.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elemento_Robado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo = _ICircunstancia_VehiculoApiConsumer.SelAll(true);
            if (Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo != null && Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo.Resource != null)
                ViewBag.Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo = Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_vehiculo != null && Tipo_de_Vehiculos_Tipo_de_vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_vehiculo = Tipo_de_Vehiculos_Tipo_de_vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ILugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_del_Robos_Lugar_de_Robo = _ILugar_del_RoboApiConsumer.SelAll(true);
            if (Lugar_del_Robos_Lugar_de_Robo != null && Lugar_del_Robos_Lugar_de_Robo.Resource != null)
                ViewBag.Lugar_del_Robos_Lugar_de_Robo = Lugar_del_Robos_Lugar_de_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_del_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBinarioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Binarios_Cuenta_con_GPS = _IBinarioApiConsumer.SelAll(true);
            if (Binarios_Cuenta_con_GPS != null && Binarios_Cuenta_con_GPS.Resource != null)
                ViewBag.Binarios_Cuenta_con_GPS = Binarios_Cuenta_con_GPS.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Binario", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Robos_Tipo_de_Robo = _ITipo_de_RoboApiConsumer.SelAll(true);
            if (Tipo_de_Robos_Tipo_de_Robo != null && Tipo_de_Robos_Tipo_de_Robo.Resource != null)
                ViewBag.Tipo_de_Robos_Tipo_de_Robo = Tipo_de_Robos_Tipo_de_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Lugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo = _ITipo_de_Lugar_del_RoboApiConsumer.SelAll(true);
            if (Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo != null && Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo.Resource != null)
                ViewBag.Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo = Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Lugar_del_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_CarreteraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Carreteras_Tipo_de_Carretera = _ITipo_de_CarreteraApiConsumer.SelAll(true);
            if (Tipo_de_Carreteras_Tipo_de_Carretera != null && Tipo_de_Carreteras_Tipo_de_Carretera.Resource != null)
                ViewBag.Tipo_de_Carreteras_Tipo_de_Carretera = Tipo_de_Carreteras_Tipo_de_Carretera.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Carretera", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_del_Vehiculos_Tipo_de_Servicio = _IServicio_del_VehiculoApiConsumer.SelAll(true);
            if (Servicio_del_Vehiculos_Tipo_de_Servicio != null && Servicio_del_Vehiculos_Tipo_de_Servicio.Resource != null)
                ViewBag.Servicio_del_Vehiculos_Tipo_de_Servicio = Servicio_del_Vehiculos_Tipo_de_Servicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Persona_Moral_JAApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral = _IDetalle_de_Persona_Moral_JAApiConsumer.SelAll(true);
            if (Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral != null && Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral.Resource != null)
                ViewBag.Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral = Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Persona_Moral_JA", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante = _IDetalle_de_Solicitud_SolicitanteApiConsumer.SelAll(true);
            if (Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante != null && Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante.Resource != null)
                ViewBag.Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante = Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Solicitud_Solicitante", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
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

				
            return View(varDetalle_de_Delito_de_Justicia);
        }
		
	[HttpGet]
        public ActionResult AddDetalle_de_Delito_de_Justicia(int rowIndex = 0, int functionMode = 0, string id = "0")
        {
			int ModuleId = (Session["CurrentModuleId"] != null) ? Convert.ToInt32(Session["CurrentModuleId"]) : 0;
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            ViewBag.Consult = false;
            var permission = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45093);
            ViewBag.Permission = permission;
			if (!_tokenManager.GenerateToken())
                return null;
           _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);
			Detalle_de_Delito_de_JusticiaModel varDetalle_de_Delito_de_Justicia= new Detalle_de_Delito_de_JusticiaModel();
            var permissionAgravantes_del_Delito_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45331, ModuleId);
            ViewBag.PermissionAgravantes_del_Delito_MASC = permissionAgravantes_del_Delito_MASC;
            var permissionCircunstancias_del_Delito_MASC = PermissionHelper.GetRoleObjectPermission(SessionHelper.Role, 45332, ModuleId);
            ViewBag.PermissionCircunstancias_del_Delito_MASC = permissionCircunstancias_del_Delito_MASC;


            if (id.ToString() != "0")
            {
                var Detalle_de_Delito_de_JusticiasData = _IDetalle_de_Delito_de_JusticiaApiConsumer.ListaSelAll(0, 1000, "Detalle_de_Delito_de_Justicia.Clave=" + id, "").Resource.Detalle_de_Delito_de_Justicias;
				
				if (Detalle_de_Delito_de_JusticiasData != null && Detalle_de_Delito_de_JusticiasData.Count > 0)
                {
					var Detalle_de_Delito_de_JusticiaData = Detalle_de_Delito_de_JusticiasData.First();
					varDetalle_de_Delito_de_Justicia= new Detalle_de_Delito_de_JusticiaModel
					{
						Clave  = Detalle_de_Delito_de_JusticiaData.Clave 
	                    ,idRegistroAT = Detalle_de_Delito_de_JusticiaData.idRegistroAT
                    ,idRegistroUI = Detalle_de_Delito_de_JusticiaData.idRegistroUI
                    ,Solicitud = Detalle_de_Delito_de_JusticiaData.Solicitud
                    ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Solicitud), "Solicitud") ??  (string)Detalle_de_Delito_de_JusticiaData.Solicitud_Solicitud.Numero_de_Folio
                    ,Tipo_de_Denuncia = Detalle_de_Delito_de_JusticiaData.Tipo_de_Denuncia
                    ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Tipo_de_Denuncia), "Tipo_de_Denuncia") ??  (string)Detalle_de_Delito_de_JusticiaData.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                    ,Fecha_de_Delito = (Detalle_de_Delito_de_JusticiaData.Fecha_de_Delito == null ? string.Empty : Convert.ToDateTime(Detalle_de_Delito_de_JusticiaData.Fecha_de_Delito).ToString(ConfigurationProperty.DateFormat))
                    ,Violencia_de_Genero = Detalle_de_Delito_de_JusticiaData.Violencia_de_Genero.GetValueOrDefault()
                    ,Delito_Violencia_Genero = Detalle_de_Delito_de_JusticiaData.Delito_Violencia_Genero
                    ,Delito_Violencia_GeneroDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Delito_Violencia_Genero), "Delitos_Violencia_Genero") ??  (string)Detalle_de_Delito_de_JusticiaData.Delito_Violencia_Genero_Delitos_Violencia_Genero.Descripcion
                    ,Hora_de_Delito = Detalle_de_Delito_de_JusticiaData.Hora_de_Delito
                    ,Tipo_de_Delito = Detalle_de_Delito_de_JusticiaData.Tipo_de_Delito
                    ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Tipo_de_Delito), "Titulo_del_Delito") ??  (string)Detalle_de_Delito_de_JusticiaData.Tipo_de_Delito_Titulo_del_Delito.Descripcion
                    ,Grupo_de_Delito = Detalle_de_Delito_de_JusticiaData.Grupo_de_Delito
                    ,Grupo_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Grupo_de_Delito), "Grupo_del_Delito") ??  (string)Detalle_de_Delito_de_JusticiaData.Grupo_de_Delito_Grupo_del_Delito.Descripcion
                    ,Delito = Detalle_de_Delito_de_JusticiaData.Delito
                    ,DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Delito), "Delito") ??  (string)Detalle_de_Delito_de_JusticiaData.Delito_Delito.Descripcion
                    ,Delito_Principal = Detalle_de_Delito_de_JusticiaData.Delito_Principal.GetValueOrDefault()
                    ,Forma_de_Comision_de_Delito = Detalle_de_Delito_de_JusticiaData.Forma_de_Comision_de_Delito
                    ,Forma_de_Comision_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Forma_de_Comision_de_Delito), "Forma_Comision_Delito") ??  (string)Detalle_de_Delito_de_JusticiaData.Forma_de_Comision_de_Delito_Forma_Comision_Delito.Descripcion
                    ,Forma_de_Accion_de_Delito = Detalle_de_Delito_de_JusticiaData.Forma_de_Accion_de_Delito
                    ,Forma_de_Accion_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Forma_de_Accion_de_Delito), "Forma_Accion_Delito") ??  (string)Detalle_de_Delito_de_JusticiaData.Forma_de_Accion_de_Delito_Forma_Accion_Delito.Descripcion
                    ,Modalidad_de_Delito = Detalle_de_Delito_de_JusticiaData.Modalidad_de_Delito
                    ,Modalidad_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Modalidad_de_Delito), "Modalidad_Delito") ??  (string)Detalle_de_Delito_de_JusticiaData.Modalidad_de_Delito_Modalidad_Delito.Descripcion
                    ,Elementos_de_Comision_de_Delito = Detalle_de_Delito_de_JusticiaData.Elementos_de_Comision_de_Delito
                    ,Elementos_de_Comision_de_DelitoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Elementos_de_Comision_de_Delito), "Elementos_Comision_Delito") ??  (string)Detalle_de_Delito_de_JusticiaData.Elementos_de_Comision_de_Delito_Elementos_Comision_Delito.Descripcion
                    ,Clasificacion_con_Orden_de_Resultado = Detalle_de_Delito_de_JusticiaData.Clasificacion_con_Orden_de_Resultado
                    ,Clasificacion_con_Orden_de_ResultadoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Clasificacion_con_Orden_de_Resultado), "Clasificacion_en_Orden_de_Resultado") ??  (string)Detalle_de_Delito_de_JusticiaData.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Descripcion
                    ,Concurso = Detalle_de_Delito_de_JusticiaData.Concurso
                    ,ConcursoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Concurso), "Concurso") ??  (string)Detalle_de_Delito_de_JusticiaData.Concurso_Concurso.Descripcion
                    ,Monto_de_Reparacion_de_Danos = Detalle_de_Delito_de_JusticiaData.Monto_de_Reparacion_de_Danos
                    ,Estado_del_Delito = Detalle_de_Delito_de_JusticiaData.Estado_del_Delito
                    ,Estado_del_DelitoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Estado_del_Delito), "Estado") ??  (string)Detalle_de_Delito_de_JusticiaData.Estado_del_Delito_Estado.Nombre
                    ,Municipio_del_Delito = Detalle_de_Delito_de_JusticiaData.Municipio_del_Delito
                    ,Municipio_del_DelitoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Municipio_del_Delito), "Municipio") ??  (string)Detalle_de_Delito_de_JusticiaData.Municipio_del_Delito_Municipio.Nombre
                    ,Colonia_del_Delito = Detalle_de_Delito_de_JusticiaData.Colonia_del_Delito
                    ,Colonia_del_DelitoNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Colonia_del_Delito), "Colonia") ??  (string)Detalle_de_Delito_de_JusticiaData.Colonia_del_Delito_Colonia.Nombre
                    ,Codigo_Postal = Detalle_de_Delito_de_JusticiaData.Codigo_Postal
                    ,Calle_del_Delito = Detalle_de_Delito_de_JusticiaData.Calle_del_Delito
                    ,Entre_Calle_del_Delito = Detalle_de_Delito_de_JusticiaData.Entre_Calle_del_Delito
                    ,Y_Calle_del_Delito = Detalle_de_Delito_de_JusticiaData.Y_Calle_del_Delito
                    ,Numero_Exterior_del_Delito = Detalle_de_Delito_de_JusticiaData.Numero_Exterior_del_Delito
                    ,Numero_Interior_del_Delito = Detalle_de_Delito_de_JusticiaData.Numero_Interior_del_Delito
                    ,Referencia = Detalle_de_Delito_de_JusticiaData.Referencia
                    ,Latitud = Detalle_de_Delito_de_JusticiaData.Latitud
                    ,Longitud = Detalle_de_Delito_de_JusticiaData.Longitud
                    ,Robo_de_Vehiculo = Detalle_de_Delito_de_JusticiaData.Robo_de_Vehiculo.GetValueOrDefault()
                    ,Fecha_del_Robo = (Detalle_de_Delito_de_JusticiaData.Fecha_del_Robo == null ? string.Empty : Convert.ToDateTime(Detalle_de_Delito_de_JusticiaData.Fecha_del_Robo).ToString(ConfigurationProperty.DateFormat))
                    ,Hora_del_Robo = Detalle_de_Delito_de_JusticiaData.Hora_del_Robo
                    ,Robo_de = Detalle_de_Delito_de_JusticiaData.Robo_de
                    ,Robo_deDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Robo_de), "Elemento_Robado") ??  (string)Detalle_de_Delito_de_JusticiaData.Robo_de_Elemento_Robado.Descripcion
                    ,Registro_Federal_Vehicular = Detalle_de_Delito_de_JusticiaData.Registro_Federal_Vehicular
                    ,Numero_de_Registro_Publico_Vehicular = Detalle_de_Delito_de_JusticiaData.Numero_de_Registro_Publico_Vehicular
                    ,Circunstancia_de_Robo_de_Vehiculo = Detalle_de_Delito_de_JusticiaData.Circunstancia_de_Robo_de_Vehiculo
                    ,Circunstancia_de_Robo_de_VehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Circunstancia_de_Robo_de_Vehiculo), "Circunstancia_Vehiculo") ??  (string)Detalle_de_Delito_de_JusticiaData.Circunstancia_de_Robo_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                    ,Marca = Detalle_de_Delito_de_JusticiaData.Marca
                    ,MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Marca), "Marca_del_Vehiculo") ??  (string)Detalle_de_Delito_de_JusticiaData.Marca_Marca_del_Vehiculo.Descripcion
                    ,Sub_Marca = Detalle_de_Delito_de_JusticiaData.Sub_Marca
                    ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Sub_Marca), "Sub_Marca_del_Vehiculo") ??  (string)Detalle_de_Delito_de_JusticiaData.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                    ,Tipo_de_vehiculo = Detalle_de_Delito_de_JusticiaData.Tipo_de_vehiculo
                    ,Tipo_de_vehiculoDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Tipo_de_vehiculo), "Tipo_de_Vehiculo") ??  (string)Detalle_de_Delito_de_JusticiaData.Tipo_de_vehiculo_Tipo_de_Vehiculo.Descripcion
                    ,Modelo = Detalle_de_Delito_de_JusticiaData.Modelo
                    ,Color = Detalle_de_Delito_de_JusticiaData.Color
                    ,ColorDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Color), "Color_Vehiculo") ??  (string)Detalle_de_Delito_de_JusticiaData.Color_Color_Vehiculo.Descripcion
                    ,Placas = Detalle_de_Delito_de_JusticiaData.Placas
                    ,Estado_de_Origen_de_las_Placas = Detalle_de_Delito_de_JusticiaData.Estado_de_Origen_de_las_Placas
                    ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Estado_de_Origen_de_las_Placas), "Estado") ??  (string)Detalle_de_Delito_de_JusticiaData.Estado_de_Origen_de_las_Placas_Estado.Nombre
                    ,Motor = Detalle_de_Delito_de_JusticiaData.Motor
                    ,Serie = Detalle_de_Delito_de_JusticiaData.Serie
                    ,Estado_De_Robo = Detalle_de_Delito_de_JusticiaData.Estado_De_Robo
                    ,Estado_De_RoboNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Estado_De_Robo), "Estado") ??  (string)Detalle_de_Delito_de_JusticiaData.Estado_De_Robo_Estado.Nombre
                    ,Municipio_de_Robo = Detalle_de_Delito_de_JusticiaData.Municipio_de_Robo
                    ,Municipio_de_RoboNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Municipio_de_Robo), "Municipio") ??  (string)Detalle_de_Delito_de_JusticiaData.Municipio_de_Robo_Municipio.Nombre
                    ,Colonia_de_Robo = Detalle_de_Delito_de_JusticiaData.Colonia_de_Robo
                    ,Colonia_de_RoboNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Colonia_de_Robo), "Colonia") ??  (string)Detalle_de_Delito_de_JusticiaData.Colonia_de_Robo_Colonia.Nombre
                    ,Codigo_Postal_de_Robo = Detalle_de_Delito_de_JusticiaData.Codigo_Postal_de_Robo
                    ,Calle_de_Robo = Detalle_de_Delito_de_JusticiaData.Calle_de_Robo
                    ,Entre_Calle_de_Robo = Detalle_de_Delito_de_JusticiaData.Entre_Calle_de_Robo
                    ,Y_Calle_de_Robo = Detalle_de_Delito_de_JusticiaData.Y_Calle_de_Robo
                    ,Numero_Exterior_de_Robo = Detalle_de_Delito_de_JusticiaData.Numero_Exterior_de_Robo
                    ,Numero_Interior_de_Robo = Detalle_de_Delito_de_JusticiaData.Numero_Interior_de_Robo
                    ,Referencia_de_Robo = Detalle_de_Delito_de_JusticiaData.Referencia_de_Robo
                    ,Latitud_de_Robo = Detalle_de_Delito_de_JusticiaData.Latitud_de_Robo
                    ,Longitud_de_Robo = Detalle_de_Delito_de_JusticiaData.Longitud_de_Robo
                    ,Lugar_de_Robo = Detalle_de_Delito_de_JusticiaData.Lugar_de_Robo
                    ,Lugar_de_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Lugar_de_Robo), "Lugar_del_Robo") ??  (string)Detalle_de_Delito_de_JusticiaData.Lugar_de_Robo_Lugar_del_Robo.Descripcion
                    ,El_vehiculo_esta_asegurado = Detalle_de_Delito_de_JusticiaData.El_vehiculo_esta_asegurado.GetValueOrDefault()
                    ,Nombre_de_la_Aseguradora = Detalle_de_Delito_de_JusticiaData.Nombre_de_la_Aseguradora
                    ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Nombre_de_la_Aseguradora), "Aseguradora_de_Vehiculo") ??  (string)Detalle_de_Delito_de_JusticiaData.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
                    ,Ruta_del_Servicio_Publico = Detalle_de_Delito_de_JusticiaData.Ruta_del_Servicio_Publico
                    ,El_Vehiculo_Transportaba_Mercancia = Detalle_de_Delito_de_JusticiaData.El_Vehiculo_Transportaba_Mercancia.GetValueOrDefault()
                    ,Descripcion_de_lo_que_Transportaba = Detalle_de_Delito_de_JusticiaData.Descripcion_de_lo_que_Transportaba
                    ,Monto_de_carga = Detalle_de_Delito_de_JusticiaData.Monto_de_carga
                    ,Senas_particulares = Detalle_de_Delito_de_JusticiaData.Senas_particulares
                    ,Cuenta_con_GPS = Detalle_de_Delito_de_JusticiaData.Cuenta_con_GPS
                    ,Cuenta_con_GPSDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Cuenta_con_GPS), "Binario") ??  (string)Detalle_de_Delito_de_JusticiaData.Cuenta_con_GPS_Binario.Descripcion
                    ,Tipo_de_Robo = Detalle_de_Delito_de_JusticiaData.Tipo_de_Robo
                    ,Tipo_de_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Tipo_de_Robo), "Tipo_de_Robo") ??  (string)Detalle_de_Delito_de_JusticiaData.Tipo_de_Robo_Tipo_de_Robo.Descripcion
                    ,Tipo_de_Lugar_del_Robo = Detalle_de_Delito_de_JusticiaData.Tipo_de_Lugar_del_Robo
                    ,Tipo_de_Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Tipo_de_Lugar_del_Robo), "Tipo_de_Lugar_del_Robo") ??  (string)Detalle_de_Delito_de_JusticiaData.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                    ,Tipo_de_Carretera = Detalle_de_Delito_de_JusticiaData.Tipo_de_Carretera
                    ,Tipo_de_CarreteraDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Tipo_de_Carretera), "Tipo_de_Carretera") ??  (string)Detalle_de_Delito_de_JusticiaData.Tipo_de_Carretera_Tipo_de_Carretera.Descripcion
                    ,Tipo_de_Servicio = Detalle_de_Delito_de_JusticiaData.Tipo_de_Servicio
                    ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Tipo_de_Servicio), "Servicio_del_Vehiculo") ??  (string)Detalle_de_Delito_de_JusticiaData.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
                    ,Numero_de_Serie = Detalle_de_Delito_de_JusticiaData.Numero_de_Serie
                    ,Numero_de_Motor = Detalle_de_Delito_de_JusticiaData.Numero_de_Motor
                    ,Persona_Moral = Detalle_de_Delito_de_JusticiaData.Persona_Moral.GetValueOrDefault()
                    ,Nombre_Completo_Persona_Moral = Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Persona_Moral
                    ,Nombre_Completo_Persona_MoralNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Persona_Moral), "Detalle_de_Persona_Moral_JA") ??  (string)Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Persona_Moral_Detalle_de_Persona_Moral_JA.Nombre
                    ,Persona_Fisica = Detalle_de_Delito_de_JusticiaData.Persona_Fisica.GetValueOrDefault()
                    ,Nombre_Completo_Persona_Fisica = Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Persona_Fisica
                    ,Nombre_Completo_Persona_FisicaNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Persona_Fisica), "Detalle_de_Solicitud_Solicitante") ??  (string)Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante.Nombre
                    ,Denunciante = Detalle_de_Delito_de_JusticiaData.Denunciante.GetValueOrDefault()
                    ,Nombre_Completo_Denunciante = Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Denunciante
                    ,Nombre_Completo_DenuncianteNombre = CultureHelper.GetTraduction(Convert.ToString(Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Denunciante), "Detalle_de_Solicitud_Solicitante") ??  (string)Detalle_de_Delito_de_JusticiaData.Nombre_Completo_Denunciante_Detalle_de_Solicitud_Solicitante.Nombre

					};
				}

            }
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITitulo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Titulo_del_Delitos_Tipo_de_Delito = _ITitulo_del_DelitoApiConsumer.SelAll(true);
            if (Titulo_del_Delitos_Tipo_de_Delito != null && Titulo_del_Delitos_Tipo_de_Delito.Resource != null)
                ViewBag.Titulo_del_Delitos_Tipo_de_Delito = Titulo_del_Delitos_Tipo_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Titulo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_del_Delitos_Grupo_de_Delito = _IGrupo_del_DelitoApiConsumer.SelAll(true);
            if (Grupo_del_Delitos_Grupo_de_Delito != null && Grupo_del_Delitos_Grupo_de_Delito.Resource != null)
                ViewBag.Grupo_del_Delitos_Grupo_de_Delito = Grupo_del_Delitos_Grupo_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Comision_Delitos_Forma_de_Comision_de_Delito = _IForma_Comision_DelitoApiConsumer.SelAll(true);
            if (Forma_Comision_Delitos_Forma_de_Comision_de_Delito != null && Forma_Comision_Delitos_Forma_de_Comision_de_Delito.Resource != null)
                ViewBag.Forma_Comision_Delitos_Forma_de_Comision_de_Delito = Forma_Comision_Delitos_Forma_de_Comision_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Accion_Delitos_Forma_de_Accion_de_Delito = _IForma_Accion_DelitoApiConsumer.SelAll(true);
            if (Forma_Accion_Delitos_Forma_de_Accion_de_Delito != null && Forma_Accion_Delitos_Forma_de_Accion_de_Delito.Resource != null)
                ViewBag.Forma_Accion_Delitos_Forma_de_Accion_de_Delito = Forma_Accion_Delitos_Forma_de_Accion_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad_de_Delito = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad_de_Delito != null && Modalidad_Delitos_Modalidad_de_Delito.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad_de_Delito = Modalidad_Delitos_Modalidad_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito = _IElementos_Comision_DelitoApiConsumer.SelAll(true);
            if (Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito != null && Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito.Resource != null)
                ViewBag.Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito = Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elementos_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IClasificacion_en_Orden_de_ResultadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado = _IClasificacion_en_Orden_de_ResultadoApiConsumer.SelAll(true);
            if (Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado != null && Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado.Resource != null)
                ViewBag.Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado = Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Clasificacion_en_Orden_de_Resultado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IConcursoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Concursos_Concurso = _IConcursoApiConsumer.SelAll(true);
            if (Concursos_Concurso != null && Concursos_Concurso.Resource != null)
                ViewBag.Concursos_Concurso = Concursos_Concurso.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Concurso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElemento_RobadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elemento_Robados_Robo_de = _IElemento_RobadoApiConsumer.SelAll(true);
            if (Elemento_Robados_Robo_de != null && Elemento_Robados_Robo_de.Resource != null)
                ViewBag.Elemento_Robados_Robo_de = Elemento_Robados_Robo_de.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elemento_Robado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo = _ICircunstancia_VehiculoApiConsumer.SelAll(true);
            if (Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo != null && Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo.Resource != null)
                ViewBag.Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo = Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_vehiculo != null && Tipo_de_Vehiculos_Tipo_de_vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_vehiculo = Tipo_de_Vehiculos_Tipo_de_vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ILugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_del_Robos_Lugar_de_Robo = _ILugar_del_RoboApiConsumer.SelAll(true);
            if (Lugar_del_Robos_Lugar_de_Robo != null && Lugar_del_Robos_Lugar_de_Robo.Resource != null)
                ViewBag.Lugar_del_Robos_Lugar_de_Robo = Lugar_del_Robos_Lugar_de_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_del_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBinarioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Binarios_Cuenta_con_GPS = _IBinarioApiConsumer.SelAll(true);
            if (Binarios_Cuenta_con_GPS != null && Binarios_Cuenta_con_GPS.Resource != null)
                ViewBag.Binarios_Cuenta_con_GPS = Binarios_Cuenta_con_GPS.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Binario", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Robos_Tipo_de_Robo = _ITipo_de_RoboApiConsumer.SelAll(true);
            if (Tipo_de_Robos_Tipo_de_Robo != null && Tipo_de_Robos_Tipo_de_Robo.Resource != null)
                ViewBag.Tipo_de_Robos_Tipo_de_Robo = Tipo_de_Robos_Tipo_de_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Lugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo = _ITipo_de_Lugar_del_RoboApiConsumer.SelAll(true);
            if (Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo != null && Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo.Resource != null)
                ViewBag.Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo = Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Lugar_del_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_CarreteraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Carreteras_Tipo_de_Carretera = _ITipo_de_CarreteraApiConsumer.SelAll(true);
            if (Tipo_de_Carreteras_Tipo_de_Carretera != null && Tipo_de_Carreteras_Tipo_de_Carretera.Resource != null)
                ViewBag.Tipo_de_Carreteras_Tipo_de_Carretera = Tipo_de_Carreteras_Tipo_de_Carretera.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Carretera", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_del_Vehiculos_Tipo_de_Servicio = _IServicio_del_VehiculoApiConsumer.SelAll(true);
            if (Servicio_del_Vehiculos_Tipo_de_Servicio != null && Servicio_del_Vehiculos_Tipo_de_Servicio.Resource != null)
                ViewBag.Servicio_del_Vehiculos_Tipo_de_Servicio = Servicio_del_Vehiculos_Tipo_de_Servicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Persona_Moral_JAApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral = _IDetalle_de_Persona_Moral_JAApiConsumer.SelAll(true);
            if (Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral != null && Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral.Resource != null)
                ViewBag.Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral = Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Persona_Moral_JA", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante = _IDetalle_de_Solicitud_SolicitanteApiConsumer.SelAll(true);
            if (Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante != null && Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante.Resource != null)
                ViewBag.Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante = Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Solicitud_Solicitante", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return PartialView("AddDetalle_de_Delito_de_Justicia", varDetalle_de_Delito_de_Justicia);
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
        public ActionResult GetTipo_de_DenunciaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_DenunciaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetDelitos_Violencia_GeneroAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitos_Violencia_GeneroApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelitos_Violencia_GeneroApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delitos_Violencia_Genero", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTitulo_del_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITitulo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITitulo_del_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Titulo_del_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetGrupo_del_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IGrupo_del_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetForma_Comision_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_Comision_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetForma_Accion_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IForma_Accion_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetModalidad_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IModalidad_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetElementos_Comision_DelitoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IElementos_Comision_DelitoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elementos_Comision_Delito", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetClasificacion_en_Orden_de_ResultadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IClasificacion_en_Orden_de_ResultadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IClasificacion_en_Orden_de_ResultadoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Clasificacion_en_Orden_de_Resultado", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetConcursoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IConcursoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IConcursoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Concurso", "Descripcion")?? m.Descripcion,
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
        public ActionResult GetColoniaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IColoniaApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Colonia", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetElemento_RobadoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IElemento_RobadoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IElemento_RobadoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elemento_Robado", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetCircunstancia_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstancia_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion")?? m.Descripcion,
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
        [HttpGet]
        public ActionResult GetLugar_del_RoboAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ILugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ILugar_del_RoboApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_del_Robo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetAseguradora_de_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAseguradora_de_VehiculoApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Aseguradora_de_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetBinarioAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IBinarioApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IBinarioApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Binario", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_RoboAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_RoboApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Robo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_Lugar_del_RoboAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_Lugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_Lugar_del_RoboApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Lugar_del_Robo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetTipo_de_CarreteraAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ITipo_de_CarreteraApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ITipo_de_CarreteraApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Carretera", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetServicio_del_VehiculoAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IServicio_del_VehiculoApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion")?? m.Descripcion,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult GetDetalle_de_Persona_Moral_JAAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Persona_Moral_JAApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Persona_Moral_JAApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Persona_Moral_JA", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
		[HttpGet]
        public ActionResult GetDetalle_de_Solicitud_SolicitanteAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.SelAll(false).Resource;
				
                return Json(result.OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Solicitud_Solicitante", "Nombre")?? m.Nombre,
                    Value = Convert.ToString(m.Clave)
                }).ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
       
        public JsonResult ClearAdvanceFilter()
        {
            Session["AdvanceSearch"] = null;
            return Json(new { result = Session["AdvanceSearch"] == null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ShowAdvanceFilter(Detalle_de_Delito_de_JusticiaAdvanceSearchModel model, int idFilter = -1)
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

            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITitulo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Titulo_del_Delitos_Tipo_de_Delito = _ITitulo_del_DelitoApiConsumer.SelAll(true);
            if (Titulo_del_Delitos_Tipo_de_Delito != null && Titulo_del_Delitos_Tipo_de_Delito.Resource != null)
                ViewBag.Titulo_del_Delitos_Tipo_de_Delito = Titulo_del_Delitos_Tipo_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Titulo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_del_Delitos_Grupo_de_Delito = _IGrupo_del_DelitoApiConsumer.SelAll(true);
            if (Grupo_del_Delitos_Grupo_de_Delito != null && Grupo_del_Delitos_Grupo_de_Delito.Resource != null)
                ViewBag.Grupo_del_Delitos_Grupo_de_Delito = Grupo_del_Delitos_Grupo_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Comision_Delitos_Forma_de_Comision_de_Delito = _IForma_Comision_DelitoApiConsumer.SelAll(true);
            if (Forma_Comision_Delitos_Forma_de_Comision_de_Delito != null && Forma_Comision_Delitos_Forma_de_Comision_de_Delito.Resource != null)
                ViewBag.Forma_Comision_Delitos_Forma_de_Comision_de_Delito = Forma_Comision_Delitos_Forma_de_Comision_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Accion_Delitos_Forma_de_Accion_de_Delito = _IForma_Accion_DelitoApiConsumer.SelAll(true);
            if (Forma_Accion_Delitos_Forma_de_Accion_de_Delito != null && Forma_Accion_Delitos_Forma_de_Accion_de_Delito.Resource != null)
                ViewBag.Forma_Accion_Delitos_Forma_de_Accion_de_Delito = Forma_Accion_Delitos_Forma_de_Accion_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad_de_Delito = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad_de_Delito != null && Modalidad_Delitos_Modalidad_de_Delito.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad_de_Delito = Modalidad_Delitos_Modalidad_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito = _IElementos_Comision_DelitoApiConsumer.SelAll(true);
            if (Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito != null && Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito.Resource != null)
                ViewBag.Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito = Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elementos_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IClasificacion_en_Orden_de_ResultadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado = _IClasificacion_en_Orden_de_ResultadoApiConsumer.SelAll(true);
            if (Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado != null && Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado.Resource != null)
                ViewBag.Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado = Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Clasificacion_en_Orden_de_Resultado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IConcursoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Concursos_Concurso = _IConcursoApiConsumer.SelAll(true);
            if (Concursos_Concurso != null && Concursos_Concurso.Resource != null)
                ViewBag.Concursos_Concurso = Concursos_Concurso.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Concurso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElemento_RobadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elemento_Robados_Robo_de = _IElemento_RobadoApiConsumer.SelAll(true);
            if (Elemento_Robados_Robo_de != null && Elemento_Robados_Robo_de.Resource != null)
                ViewBag.Elemento_Robados_Robo_de = Elemento_Robados_Robo_de.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elemento_Robado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo = _ICircunstancia_VehiculoApiConsumer.SelAll(true);
            if (Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo != null && Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo.Resource != null)
                ViewBag.Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo = Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_vehiculo != null && Tipo_de_Vehiculos_Tipo_de_vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_vehiculo = Tipo_de_Vehiculos_Tipo_de_vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ILugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_del_Robos_Lugar_de_Robo = _ILugar_del_RoboApiConsumer.SelAll(true);
            if (Lugar_del_Robos_Lugar_de_Robo != null && Lugar_del_Robos_Lugar_de_Robo.Resource != null)
                ViewBag.Lugar_del_Robos_Lugar_de_Robo = Lugar_del_Robos_Lugar_de_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_del_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBinarioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Binarios_Cuenta_con_GPS = _IBinarioApiConsumer.SelAll(true);
            if (Binarios_Cuenta_con_GPS != null && Binarios_Cuenta_con_GPS.Resource != null)
                ViewBag.Binarios_Cuenta_con_GPS = Binarios_Cuenta_con_GPS.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Binario", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Robos_Tipo_de_Robo = _ITipo_de_RoboApiConsumer.SelAll(true);
            if (Tipo_de_Robos_Tipo_de_Robo != null && Tipo_de_Robos_Tipo_de_Robo.Resource != null)
                ViewBag.Tipo_de_Robos_Tipo_de_Robo = Tipo_de_Robos_Tipo_de_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Lugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo = _ITipo_de_Lugar_del_RoboApiConsumer.SelAll(true);
            if (Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo != null && Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo.Resource != null)
                ViewBag.Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo = Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Lugar_del_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_CarreteraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Carreteras_Tipo_de_Carretera = _ITipo_de_CarreteraApiConsumer.SelAll(true);
            if (Tipo_de_Carreteras_Tipo_de_Carretera != null && Tipo_de_Carreteras_Tipo_de_Carretera.Resource != null)
                ViewBag.Tipo_de_Carreteras_Tipo_de_Carretera = Tipo_de_Carreteras_Tipo_de_Carretera.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Carretera", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_del_Vehiculos_Tipo_de_Servicio = _IServicio_del_VehiculoApiConsumer.SelAll(true);
            if (Servicio_del_Vehiculos_Tipo_de_Servicio != null && Servicio_del_Vehiculos_Tipo_de_Servicio.Resource != null)
                ViewBag.Servicio_del_Vehiculos_Tipo_de_Servicio = Servicio_del_Vehiculos_Tipo_de_Servicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Persona_Moral_JAApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral = _IDetalle_de_Persona_Moral_JAApiConsumer.SelAll(true);
            if (Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral != null && Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral.Resource != null)
                ViewBag.Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral = Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Persona_Moral_JA", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante = _IDetalle_de_Solicitud_SolicitanteApiConsumer.SelAll(true);
            if (Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante != null && Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante.Resource != null)
                ViewBag.Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante = Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Solicitud_Solicitante", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            return View(model);  
        }

        [HttpGet]
        public ActionResult ShowAdvanceFilter(string previousFilters = "")
        {
            if (!_tokenManager.GenerateToken())
                return Json(null, JsonRequestBehavior.AllowGet);

            _ITipo_de_DenunciaApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Denuncias_Tipo_de_Denuncia = _ITipo_de_DenunciaApiConsumer.SelAll(true);
            if (Tipo_de_Denuncias_Tipo_de_Denuncia != null && Tipo_de_Denuncias_Tipo_de_Denuncia.Resource != null)
                ViewBag.Tipo_de_Denuncias_Tipo_de_Denuncia = Tipo_de_Denuncias_Tipo_de_Denuncia.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Denuncia", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITitulo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Titulo_del_Delitos_Tipo_de_Delito = _ITitulo_del_DelitoApiConsumer.SelAll(true);
            if (Titulo_del_Delitos_Tipo_de_Delito != null && Titulo_del_Delitos_Tipo_de_Delito.Resource != null)
                ViewBag.Titulo_del_Delitos_Tipo_de_Delito = Titulo_del_Delitos_Tipo_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Titulo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IGrupo_del_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Grupo_del_Delitos_Grupo_de_Delito = _IGrupo_del_DelitoApiConsumer.SelAll(true);
            if (Grupo_del_Delitos_Grupo_de_Delito != null && Grupo_del_Delitos_Grupo_de_Delito.Resource != null)
                ViewBag.Grupo_del_Delitos_Grupo_de_Delito = Grupo_del_Delitos_Grupo_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Grupo_del_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Delitos_Delito = _IDelitoApiConsumer.SelAll(true);
            if (Delitos_Delito != null && Delitos_Delito.Resource != null)
                ViewBag.Delitos_Delito = Delitos_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Comision_Delitos_Forma_de_Comision_de_Delito = _IForma_Comision_DelitoApiConsumer.SelAll(true);
            if (Forma_Comision_Delitos_Forma_de_Comision_de_Delito != null && Forma_Comision_Delitos_Forma_de_Comision_de_Delito.Resource != null)
                ViewBag.Forma_Comision_Delitos_Forma_de_Comision_de_Delito = Forma_Comision_Delitos_Forma_de_Comision_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IForma_Accion_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Forma_Accion_Delitos_Forma_de_Accion_de_Delito = _IForma_Accion_DelitoApiConsumer.SelAll(true);
            if (Forma_Accion_Delitos_Forma_de_Accion_de_Delito != null && Forma_Accion_Delitos_Forma_de_Accion_de_Delito.Resource != null)
                ViewBag.Forma_Accion_Delitos_Forma_de_Accion_de_Delito = Forma_Accion_Delitos_Forma_de_Accion_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Forma_Accion_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IModalidad_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Modalidad_Delitos_Modalidad_de_Delito = _IModalidad_DelitoApiConsumer.SelAll(true);
            if (Modalidad_Delitos_Modalidad_de_Delito != null && Modalidad_Delitos_Modalidad_de_Delito.Resource != null)
                ViewBag.Modalidad_Delitos_Modalidad_de_Delito = Modalidad_Delitos_Modalidad_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Modalidad_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElementos_Comision_DelitoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito = _IElementos_Comision_DelitoApiConsumer.SelAll(true);
            if (Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito != null && Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito.Resource != null)
                ViewBag.Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito = Elementos_Comision_Delitos_Elementos_de_Comision_de_Delito.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elementos_Comision_Delito", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IClasificacion_en_Orden_de_ResultadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado = _IClasificacion_en_Orden_de_ResultadoApiConsumer.SelAll(true);
            if (Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado != null && Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado.Resource != null)
                ViewBag.Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado = Clasificacion_en_Orden_de_Resultados_Clasificacion_con_Orden_de_Resultado.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Clasificacion_en_Orden_de_Resultado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IConcursoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Concursos_Concurso = _IConcursoApiConsumer.SelAll(true);
            if (Concursos_Concurso != null && Concursos_Concurso.Resource != null)
                ViewBag.Concursos_Concurso = Concursos_Concurso.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Concurso", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IElemento_RobadoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Elemento_Robados_Robo_de = _IElemento_RobadoApiConsumer.SelAll(true);
            if (Elemento_Robados_Robo_de != null && Elemento_Robados_Robo_de.Resource != null)
                ViewBag.Elemento_Robados_Robo_de = Elemento_Robados_Robo_de.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Elemento_Robado", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ICircunstancia_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo = _ICircunstancia_VehiculoApiConsumer.SelAll(true);
            if (Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo != null && Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo.Resource != null)
                ViewBag.Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo = Circunstancia_Vehiculos_Circunstancia_de_Robo_de_Vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Circunstancia_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Vehiculos_Tipo_de_vehiculo = _ITipo_de_VehiculoApiConsumer.SelAll(true);
            if (Tipo_de_Vehiculos_Tipo_de_vehiculo != null && Tipo_de_Vehiculos_Tipo_de_vehiculo.Resource != null)
                ViewBag.Tipo_de_Vehiculos_Tipo_de_vehiculo = Tipo_de_Vehiculos_Tipo_de_vehiculo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
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
            _ILugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Lugar_del_Robos_Lugar_de_Robo = _ILugar_del_RoboApiConsumer.SelAll(true);
            if (Lugar_del_Robos_Lugar_de_Robo != null && Lugar_del_Robos_Lugar_de_Robo.Resource != null)
                ViewBag.Lugar_del_Robos_Lugar_de_Robo = Lugar_del_Robos_Lugar_de_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Lugar_del_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IBinarioApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Binarios_Cuenta_con_GPS = _IBinarioApiConsumer.SelAll(true);
            if (Binarios_Cuenta_con_GPS != null && Binarios_Cuenta_con_GPS.Resource != null)
                ViewBag.Binarios_Cuenta_con_GPS = Binarios_Cuenta_con_GPS.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Binario", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Robos_Tipo_de_Robo = _ITipo_de_RoboApiConsumer.SelAll(true);
            if (Tipo_de_Robos_Tipo_de_Robo != null && Tipo_de_Robos_Tipo_de_Robo.Resource != null)
                ViewBag.Tipo_de_Robos_Tipo_de_Robo = Tipo_de_Robos_Tipo_de_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_Lugar_del_RoboApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo = _ITipo_de_Lugar_del_RoboApiConsumer.SelAll(true);
            if (Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo != null && Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo.Resource != null)
                ViewBag.Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo = Tipo_de_Lugar_del_Robos_Tipo_de_Lugar_del_Robo.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Lugar_del_Robo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _ITipo_de_CarreteraApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Tipo_de_Carreteras_Tipo_de_Carretera = _ITipo_de_CarreteraApiConsumer.SelAll(true);
            if (Tipo_de_Carreteras_Tipo_de_Carretera != null && Tipo_de_Carreteras_Tipo_de_Carretera.Resource != null)
                ViewBag.Tipo_de_Carreteras_Tipo_de_Carretera = Tipo_de_Carreteras_Tipo_de_Carretera.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Tipo_de_Carretera", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IServicio_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Servicio_del_Vehiculos_Tipo_de_Servicio = _IServicio_del_VehiculoApiConsumer.SelAll(true);
            if (Servicio_del_Vehiculos_Tipo_de_Servicio != null && Servicio_del_Vehiculos_Tipo_de_Servicio.Resource != null)
                ViewBag.Servicio_del_Vehiculos_Tipo_de_Servicio = Servicio_del_Vehiculos_Tipo_de_Servicio.Resource.Where(m => m.Descripcion != null).OrderBy(m => m.Descripcion).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Servicio_del_Vehiculo", "Descripcion") ?? m.Descripcion.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Persona_Moral_JAApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral = _IDetalle_de_Persona_Moral_JAApiConsumer.SelAll(true);
            if (Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral != null && Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral.Resource != null)
                ViewBag.Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral = Detalle_de_Persona_Moral_JAs_Nombre_Completo_Persona_Moral.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Persona_Moral_JA", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();
            _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);
            var Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante = _IDetalle_de_Solicitud_SolicitanteApiConsumer.SelAll(true);
            if (Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante != null && Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante.Resource != null)
                ViewBag.Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante = Detalle_de_Solicitud_Solicitantes_Nombre_Completo_Denunciante.Resource.Where(m => m.Nombre != null).OrderBy(m => m.Nombre).Select(m => new SelectListItem
                {
                    Text = CultureHelper.GetTraduction(Convert.ToString(m.Clave), "Detalle_de_Solicitud_Solicitante", "Nombre") ?? m.Nombre.ToString(), Value = Convert.ToString(m.Clave)
                }).ToList();


            var previousFiltersObj = new Detalle_de_Delito_de_JusticiaAdvanceSearchModel();
            if (previousFilters != "")
            {
                previousFiltersObj = (Detalle_de_Delito_de_JusticiaAdvanceSearchModel)(Session["AdvanceSearch"] ?? new Detalle_de_Delito_de_JusticiaAdvanceSearchModel());
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
                configuration = GridQueryHelper.GetConfiguration(filter, new Detalle_de_Delito_de_JusticiaPropertyMapper());

            var pageSize = Convert.ToInt32(filter["pageSize"]);
            var pageIndex = Convert.ToInt32(filter["pageIndex"]);
            var result = _IDetalle_de_Delito_de_JusticiaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize, configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Delito_de_Justicias == null)
                result.Detalle_de_Delito_de_Justicias = new List<Detalle_de_Delito_de_Justicia>();

            return Json(new
            {
                data = result.Detalle_de_Delito_de_Justicias.Select(m => new Detalle_de_Delito_de_JusticiaGridModel
                    {
                    Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,Fecha_de_Delito = (m.Fecha_de_Delito == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Delito).ToString(ConfigurationProperty.DateFormat))
			,Violencia_de_Genero = m.Violencia_de_Genero
                        ,Delito_Violencia_GeneroDescripcion = CultureHelper.GetTraduction(m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Clave.ToString(), "Delitos_Violencia_Genero") ?? (string)m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Descripcion
			,Hora_de_Delito = m.Hora_de_Delito
                        ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_de_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_de_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
			,Delito_Principal = m.Delito_Principal
                        ,Forma_de_Comision_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Comision_de_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Comision_de_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_de_Accion_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Accion_de_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Accion_de_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_de_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_de_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_de_Comision_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_de_Comision_de_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_de_Comision_de_Delito_Elementos_Comision_Delito.Descripcion
                        ,Clasificacion_con_Orden_de_ResultadoDescripcion = CultureHelper.GetTraduction(m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Clave.ToString(), "Descripcion") ?? (string)m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Descripcion
                        ,ConcursoDescripcion = CultureHelper.GetTraduction(m.Concurso_Concurso.Clave.ToString(), "Descripcion") ?? (string)m.Concurso_Concurso.Descripcion
			,Monto_de_Reparacion_de_Danos = m.Monto_de_Reparacion_de_Danos
                        ,Estado_del_DelitoNombre = CultureHelper.GetTraduction(m.Estado_del_Delito_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Delito_Estado.Nombre
                        ,Municipio_del_DelitoNombre = CultureHelper.GetTraduction(m.Municipio_del_Delito_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Delito_Municipio.Nombre
                        ,Colonia_del_DelitoNombre = CultureHelper.GetTraduction(m.Colonia_del_Delito_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Delito_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle_del_Delito = m.Calle_del_Delito
			,Entre_Calle_del_Delito = m.Entre_Calle_del_Delito
			,Y_Calle_del_Delito = m.Y_Calle_del_Delito
			,Numero_Exterior_del_Delito = m.Numero_Exterior_del_Delito
			,Numero_Interior_del_Delito = m.Numero_Interior_del_Delito
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                        ,Fecha_del_Robo = (m.Fecha_del_Robo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Robo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Robo = m.Hora_del_Robo
                        ,Robo_deDescripcion = CultureHelper.GetTraduction(m.Robo_de_Elemento_Robado.Clave.ToString(), "Descripcion") ?? (string)m.Robo_de_Elemento_Robado.Descripcion
			,Registro_Federal_Vehicular = m.Registro_Federal_Vehicular
			,Numero_de_Registro_Publico_Vehicular = m.Numero_de_Registro_Publico_Vehicular
                        ,Circunstancia_de_Robo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_de_Robo_de_Vehiculo_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_de_Robo_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Marca_del_Vehiculo") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Sub_Marca_del_Vehiculo") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_vehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(m.Estado_de_Origen_de_las_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
			,Motor = m.Motor
			,Serie = m.Serie
                        ,Estado_De_RoboNombre = CultureHelper.GetTraduction(m.Estado_De_Robo_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_De_Robo_Estado.Nombre
                        ,Municipio_de_RoboNombre = CultureHelper.GetTraduction(m.Municipio_de_Robo_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Robo_Municipio.Nombre
                        ,Colonia_de_RoboNombre = CultureHelper.GetTraduction(m.Colonia_de_Robo_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_Robo_Colonia.Nombre
			,Codigo_Postal_de_Robo = m.Codigo_Postal_de_Robo
			,Calle_de_Robo = m.Calle_de_Robo
			,Entre_Calle_de_Robo = m.Entre_Calle_de_Robo
			,Y_Calle_de_Robo = m.Y_Calle_de_Robo
			,Numero_Exterior_de_Robo = m.Numero_Exterior_de_Robo
			,Numero_Interior_de_Robo = m.Numero_Interior_de_Robo
			,Referencia_de_Robo = m.Referencia_de_Robo
			,Latitud_de_Robo = m.Latitud_de_Robo
			,Longitud_de_Robo = m.Longitud_de_Robo
                        ,Lugar_de_RoboDescripcion = CultureHelper.GetTraduction(m.Lugar_de_Robo_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_Robo_Lugar_del_Robo.Descripcion
			,El_vehiculo_esta_asegurado = m.El_vehiculo_esta_asegurado
                        ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Aseguradora_de_Vehiculo") ?? (string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
			,El_Vehiculo_Transportaba_Mercancia = m.El_Vehiculo_Transportaba_Mercancia
			,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
			,Monto_de_carga = m.Monto_de_carga
			,Senas_particulares = m.Senas_particulares
                        ,Cuenta_con_GPSDescripcion = CultureHelper.GetTraduction(m.Cuenta_con_GPS_Binario.Clave.ToString(), "Descripcion") ?? (string)m.Cuenta_con_GPS_Binario.Descripcion
                        ,Tipo_de_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Robo_Tipo_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Robo_Tipo_de_Robo.Descripcion
                        ,Tipo_de_Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Tipo_de_CarreteraDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Carretera_Tipo_de_Carretera.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Carretera_Tipo_de_Carretera.Descripcion
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Numero_de_Serie = m.Numero_de_Serie
			,Numero_de_Motor = m.Numero_de_Motor
			,Persona_Moral = m.Persona_Moral
                        ,Nombre_Completo_Persona_MoralNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Persona_Moral_Detalle_de_Persona_Moral_JA.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Persona_Moral_Detalle_de_Persona_Moral_JA.Nombre
			,Persona_Fisica = m.Persona_Fisica
                        ,Nombre_Completo_Persona_FisicaNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante.Clave.ToString(), "Detalle_de_Solicitud_Solicitante") ?? (string)m.Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante.Nombre
			,Denunciante = m.Denunciante
                        ,Nombre_Completo_DenuncianteNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Denunciante_Detalle_de_Solicitud_Solicitante.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Denunciante_Detalle_de_Solicitud_Solicitante.Nombre

                    }).ToList(),
                itemsCount = result.RowCount
            }, JsonRequestBehavior.AllowGet);
        }
		/*
		 [HttpGet]
        public ActionResult GetDetalle_de_Delito_de_JusticiaAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Delito_de_JusticiaApiConsumer.SelAll(false).Resource;
                
                return Json(result.OrderBy(m => m.).Select(m => new SelectListItem
                {
                     Text = CultureHelper.GetTraductionNew(Convert.ToString(m.Clave), "Detalle_de_Delito_de_Justicia", m.),
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
        /// Get List of Detalle_de_Delito_de_Justicia from Web API.
        /// </summary>
        /// <param name="draw"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <returns>Return List of Detalle_de_Delito_de_Justicia Entity</returns>
        public ActionResult GetDetalle_de_Delito_de_JusticiaList(UrlParametersModel param)
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
            _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);

          
            NameValueCollection filter = HttpUtility.ParseQueryString(param.filters);

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfigurationNew(param, new Detalle_de_Delito_de_JusticiaPropertyMapper());
				
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
				if (Session["AdvanceSearch"].GetType() == typeof(Detalle_de_Delito_de_JusticiaAdvanceSearchModel))
                {
					var advanceFilter =
                    (Detalle_de_Delito_de_JusticiaAdvanceSearchModel)Session["AdvanceSearch"];
					configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
				}
				else
                {    
					Session.Remove("AdvanceSearch");
                }
            }

            Detalle_de_Delito_de_JusticiaPropertyMapper oDetalle_de_Delito_de_JusticiaPropertyMapper = new Detalle_de_Delito_de_JusticiaPropertyMapper();
			if (String.IsNullOrEmpty(order))
            {
                 if (sortColumn != -1)
                    configuration.OrderByClause = oDetalle_de_Delito_de_JusticiaPropertyMapper.GetPropertyName(param.columns[sortColumn].name) + " " + sortDirection;
            }

            var pageSize = iDisplayLength;
            var pageIndex = (iDisplayStart / iDisplayLength) + 1;
            var result = _IDetalle_de_Delito_de_JusticiaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Delito_de_Justicias == null)
                result.Detalle_de_Delito_de_Justicias = new List<Detalle_de_Delito_de_Justicia>();

            return Json(new
            {
                aaData = result.Detalle_de_Delito_de_Justicias.Select(m => new Detalle_de_Delito_de_JusticiaGridModel
            {
                    Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,Fecha_de_Delito = (m.Fecha_de_Delito == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Delito).ToString(ConfigurationProperty.DateFormat))
			,Violencia_de_Genero = m.Violencia_de_Genero
                        ,Delito_Violencia_GeneroDescripcion = CultureHelper.GetTraduction(m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Clave.ToString(), "Delitos_Violencia_Genero") ?? (string)m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Descripcion
			,Hora_de_Delito = m.Hora_de_Delito
                        ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_de_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_de_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
			,Delito_Principal = m.Delito_Principal
                        ,Forma_de_Comision_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Comision_de_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Comision_de_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_de_Accion_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Accion_de_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Accion_de_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_de_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_de_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_de_Comision_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_de_Comision_de_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_de_Comision_de_Delito_Elementos_Comision_Delito.Descripcion
                        ,Clasificacion_con_Orden_de_ResultadoDescripcion = CultureHelper.GetTraduction(m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Clave.ToString(), "Descripcion") ?? (string)m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Descripcion
                        ,ConcursoDescripcion = CultureHelper.GetTraduction(m.Concurso_Concurso.Clave.ToString(), "Descripcion") ?? (string)m.Concurso_Concurso.Descripcion
			,Monto_de_Reparacion_de_Danos = m.Monto_de_Reparacion_de_Danos
                        ,Estado_del_DelitoNombre = CultureHelper.GetTraduction(m.Estado_del_Delito_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Delito_Estado.Nombre
                        ,Municipio_del_DelitoNombre = CultureHelper.GetTraduction(m.Municipio_del_Delito_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Delito_Municipio.Nombre
                        ,Colonia_del_DelitoNombre = CultureHelper.GetTraduction(m.Colonia_del_Delito_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Delito_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle_del_Delito = m.Calle_del_Delito
			,Entre_Calle_del_Delito = m.Entre_Calle_del_Delito
			,Y_Calle_del_Delito = m.Y_Calle_del_Delito
			,Numero_Exterior_del_Delito = m.Numero_Exterior_del_Delito
			,Numero_Interior_del_Delito = m.Numero_Interior_del_Delito
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                        ,Fecha_del_Robo = (m.Fecha_del_Robo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Robo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Robo = m.Hora_del_Robo
                        ,Robo_deDescripcion = CultureHelper.GetTraduction(m.Robo_de_Elemento_Robado.Clave.ToString(), "Descripcion") ?? (string)m.Robo_de_Elemento_Robado.Descripcion
			,Registro_Federal_Vehicular = m.Registro_Federal_Vehicular
			,Numero_de_Registro_Publico_Vehicular = m.Numero_de_Registro_Publico_Vehicular
                        ,Circunstancia_de_Robo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_de_Robo_de_Vehiculo_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_de_Robo_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Marca_del_Vehiculo") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Sub_Marca_del_Vehiculo") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_vehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(m.Estado_de_Origen_de_las_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
			,Motor = m.Motor
			,Serie = m.Serie
                        ,Estado_De_RoboNombre = CultureHelper.GetTraduction(m.Estado_De_Robo_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_De_Robo_Estado.Nombre
                        ,Municipio_de_RoboNombre = CultureHelper.GetTraduction(m.Municipio_de_Robo_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Robo_Municipio.Nombre
                        ,Colonia_de_RoboNombre = CultureHelper.GetTraduction(m.Colonia_de_Robo_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_Robo_Colonia.Nombre
			,Codigo_Postal_de_Robo = m.Codigo_Postal_de_Robo
			,Calle_de_Robo = m.Calle_de_Robo
			,Entre_Calle_de_Robo = m.Entre_Calle_de_Robo
			,Y_Calle_de_Robo = m.Y_Calle_de_Robo
			,Numero_Exterior_de_Robo = m.Numero_Exterior_de_Robo
			,Numero_Interior_de_Robo = m.Numero_Interior_de_Robo
			,Referencia_de_Robo = m.Referencia_de_Robo
			,Latitud_de_Robo = m.Latitud_de_Robo
			,Longitud_de_Robo = m.Longitud_de_Robo
                        ,Lugar_de_RoboDescripcion = CultureHelper.GetTraduction(m.Lugar_de_Robo_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_Robo_Lugar_del_Robo.Descripcion
			,El_vehiculo_esta_asegurado = m.El_vehiculo_esta_asegurado
                        ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Aseguradora_de_Vehiculo") ?? (string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
			,El_Vehiculo_Transportaba_Mercancia = m.El_Vehiculo_Transportaba_Mercancia
			,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
			,Monto_de_carga = m.Monto_de_carga
			,Senas_particulares = m.Senas_particulares
                        ,Cuenta_con_GPSDescripcion = CultureHelper.GetTraduction(m.Cuenta_con_GPS_Binario.Clave.ToString(), "Descripcion") ?? (string)m.Cuenta_con_GPS_Binario.Descripcion
                        ,Tipo_de_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Robo_Tipo_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Robo_Tipo_de_Robo.Descripcion
                        ,Tipo_de_Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Tipo_de_CarreteraDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Carretera_Tipo_de_Carretera.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Carretera_Tipo_de_Carretera.Descripcion
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Numero_de_Serie = m.Numero_de_Serie
			,Numero_de_Motor = m.Numero_de_Motor
			,Persona_Moral = m.Persona_Moral
                        ,Nombre_Completo_Persona_MoralNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Persona_Moral_Detalle_de_Persona_Moral_JA.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Persona_Moral_Detalle_de_Persona_Moral_JA.Nombre
			,Persona_Fisica = m.Persona_Fisica
                        ,Nombre_Completo_Persona_FisicaNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante.Clave.ToString(), "Detalle_de_Solicitud_Solicitante") ?? (string)m.Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante.Nombre
			,Denunciante = m.Denunciante
                        ,Nombre_Completo_DenuncianteNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Denunciante_Detalle_de_Solicitud_Solicitante.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Denunciante_Detalle_de_Solicitud_Solicitante.Nombre

                }).ToList(),
                iTotalRecords = result.RowCount,
                iTotalDisplayRecords = result.RowCount,
                sEcho = sEcho
            }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDetalle_de_Delito_de_Justicia_Solicitud_Solicitud(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_de_Justicia_Delito_Violencia_Genero_Delitos_Violencia_Genero(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDelitos_Violencia_GeneroApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Delitos_Violencia_Genero.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Delitos_Violencia_Genero.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDelitos_Violencia_GeneroApiConsumer.ListaSelAll(1, 20,elWhere , " Delitos_Violencia_Genero.Descripcion ASC ").Resource;
               
                foreach (var item in result.Delitos_Violencia_Generos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Delitos_Violencia_Genero", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Delitos_Violencia_Generos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
//Grid GetAutoComplete

//Grid GetAutoComplete

        [HttpGet]
        public JsonResult GetDetalle_de_Delito_de_Justicia_Estado_del_Delito_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_de_Justicia_Municipio_del_Delito_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_de_Justicia_Colonia_del_Delito_Colonia(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Colonia.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Colonia.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IColoniaApiConsumer.ListaSelAll(1, 20,elWhere , " Colonia.Nombre ASC ").Resource;
               
                foreach (var item in result.Colonias)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Colonias.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Delito_de_Justicia_Marca_Marca_del_Vehiculo(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IMarca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Marca_del_Vehiculo.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Marca_del_Vehiculo.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IMarca_del_VehiculoApiConsumer.ListaSelAll(1, 20,elWhere , " Marca_del_Vehiculo.Descripcion ASC ").Resource;
               
                foreach (var item in result.Marca_del_Vehiculos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Marca_del_Vehiculo", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Marca_del_Vehiculos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Delito_de_Justicia_Sub_Marca_Sub_Marca_del_Vehiculo(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ISub_Marca_del_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Sub_Marca_del_Vehiculo.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Sub_Marca_del_Vehiculo.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _ISub_Marca_del_VehiculoApiConsumer.ListaSelAll(1, 20,elWhere , " Sub_Marca_del_Vehiculo.Descripcion ASC ").Resource;
               
                foreach (var item in result.Sub_Marca_del_Vehiculos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Sub_Marca_del_Vehiculo", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Sub_Marca_del_Vehiculos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Delito_de_Justicia_Estado_de_Origen_de_las_Placas_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_de_Justicia_Estado_De_Robo_Estado(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_de_Justicia_Municipio_de_Robo_Municipio(string query, string where)
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
        public JsonResult GetDetalle_de_Delito_de_Justicia_Colonia_de_Robo_Colonia(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IColoniaApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Colonia.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Colonia.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IColoniaApiConsumer.ListaSelAll(1, 20,elWhere , " Colonia.Nombre ASC ").Resource;
               
                foreach (var item in result.Colonias)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Colonia", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Colonias.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Delito_de_Justicia_Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAseguradora_de_VehiculoApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Aseguradora_de_Vehiculo.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Aseguradora_de_Vehiculo.Descripcion as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IAseguradora_de_VehiculoApiConsumer.ListaSelAll(1, 20,elWhere , " Aseguradora_de_Vehiculo.Descripcion ASC ").Resource;
               
                foreach (var item in result.Aseguradora_de_Vehiculos)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Aseguradora_de_Vehiculo", "Descripcion");
                    item.Descripcion =trans ??item.Descripcion;
                }
                return Json(result.Aseguradora_de_Vehiculos.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public JsonResult GetDetalle_de_Delito_de_Justicia_Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante(string query, string where)
        {
            try
            {
                if (String.IsNullOrEmpty(where))
                    where = "";
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Solicitud_SolicitanteApiConsumer.SetAuthHeader(_tokenManager.Token);

				var elWhere = " (cast(Detalle_de_Solicitud_Solicitante.Clave as nvarchar(max)) LIKE '%" + query.Trim() + "%' or cast(Detalle_de_Solicitud_Solicitante.Nombre as nvarchar(max)) LIKE '%" + query.Trim() + "%') " + where;
				elWhere = HttpUtility.UrlEncode(elWhere);
				var result = _IDetalle_de_Solicitud_SolicitanteApiConsumer.ListaSelAll(1, 20,elWhere , " Detalle_de_Solicitud_Solicitante.Nombre ASC ").Resource;
               
                foreach (var item in result.Detalle_de_Solicitud_Solicitantes)
                {
                    var trans =  CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Detalle_de_Solicitud_Solicitante", "Nombre");
                    item.Nombre =trans ??item.Nombre;
                }
                return Json(result.Detalle_de_Solicitud_Solicitantes.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }





        [NonAction]
        public string GetAdvanceFilter(Detalle_de_Delito_de_JusticiaAdvanceSearchModel filter)
        {
            var where = "";
            if (!string.IsNullOrEmpty(filter.FromClave) || !string.IsNullOrEmpty(filter.ToClave))
            {
                if (!string.IsNullOrEmpty(filter.FromClave))
                    where += " AND Detalle_de_Delito_de_Justicia.Clave >= " + filter.FromClave;
                if (!string.IsNullOrEmpty(filter.ToClave))
                    where += " AND Detalle_de_Delito_de_Justicia.Clave <= " + filter.ToClave;
            }

            if (!string.IsNullOrEmpty(filter.FromidRegistroAT) || !string.IsNullOrEmpty(filter.ToidRegistroAT))
            {
                if (!string.IsNullOrEmpty(filter.FromidRegistroAT))
                    where += " AND Detalle_de_Delito_de_Justicia.idRegistroAT >= " + filter.FromidRegistroAT;
                if (!string.IsNullOrEmpty(filter.ToidRegistroAT))
                    where += " AND Detalle_de_Delito_de_Justicia.idRegistroAT <= " + filter.ToidRegistroAT;
            }

            if (!string.IsNullOrEmpty(filter.FromidRegistroUI) || !string.IsNullOrEmpty(filter.ToidRegistroUI))
            {
                if (!string.IsNullOrEmpty(filter.FromidRegistroUI))
                    where += " AND Detalle_de_Delito_de_Justicia.idRegistroUI >= " + filter.FromidRegistroUI;
                if (!string.IsNullOrEmpty(filter.ToidRegistroUI))
                    where += " AND Detalle_de_Delito_de_Justicia.idRegistroUI <= " + filter.ToidRegistroUI;
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

                where += " AND Detalle_de_Delito_de_Justicia.Solicitud In (" + SolicitudIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Denuncia))
            {
                switch (filter.Tipo_de_DenunciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '" + filter.AdvanceTipo_de_Denuncia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Denuncia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Denuncia.Descripcion = '" + filter.AdvanceTipo_de_Denuncia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Denuncia.Descripcion LIKE '%" + filter.AdvanceTipo_de_Denuncia + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_DenunciaMultiple != null && filter.AdvanceTipo_de_DenunciaMultiple.Count() > 0)
            {
                var Tipo_de_DenunciaIds = string.Join(",", filter.AdvanceTipo_de_DenunciaMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Tipo_de_Denuncia In (" + Tipo_de_DenunciaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromFecha_de_Delito) || !string.IsNullOrEmpty(filter.ToFecha_de_Delito))
            {
                var Fecha_de_DelitoFrom = DateTime.ParseExact(filter.FromFecha_de_Delito, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_de_DelitoTo = DateTime.ParseExact(filter.ToFecha_de_Delito, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_de_Delito))
                    where += " AND Detalle_de_Delito_de_Justicia.Fecha_de_Delito >= '" + Fecha_de_DelitoFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_de_Delito))
                    where += " AND Detalle_de_Delito_de_Justicia.Fecha_de_Delito <= '" + Fecha_de_DelitoTo.ToString("MM-dd-yyyy") + "'";
            }

            if (filter.Violencia_de_Genero != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito_de_Justicia.Violencia_de_Genero = " + Convert.ToInt32(filter.Violencia_de_Genero);

            if (!string.IsNullOrEmpty(filter.AdvanceDelito_Violencia_Genero))
            {
                switch (filter.Delito_Violencia_GeneroFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delitos_Violencia_Genero.Descripcion LIKE '" + filter.AdvanceDelito_Violencia_Genero + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delitos_Violencia_Genero.Descripcion LIKE '%" + filter.AdvanceDelito_Violencia_Genero + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delitos_Violencia_Genero.Descripcion = '" + filter.AdvanceDelito_Violencia_Genero + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delitos_Violencia_Genero.Descripcion LIKE '%" + filter.AdvanceDelito_Violencia_Genero + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDelito_Violencia_GeneroMultiple != null && filter.AdvanceDelito_Violencia_GeneroMultiple.Count() > 0)
            {
                var Delito_Violencia_GeneroIds = string.Join(",", filter.AdvanceDelito_Violencia_GeneroMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Delito_Violencia_Genero In (" + Delito_Violencia_GeneroIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_de_Delito) || !string.IsNullOrEmpty(filter.ToHora_de_Delito))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_de_Delito))
                    where += " AND Convert(TIME,Detalle_de_Delito_de_Justicia.Hora_de_Delito) >='" + filter.FromHora_de_Delito + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_de_Delito))
                    where += " AND Convert(TIME,Detalle_de_Delito_de_Justicia.Hora_de_Delito) <='" + filter.ToHora_de_Delito + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Delito))
            {
                switch (filter.Tipo_de_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Titulo_del_Delito.Descripcion LIKE '" + filter.AdvanceTipo_de_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Titulo_del_Delito.Descripcion LIKE '%" + filter.AdvanceTipo_de_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Titulo_del_Delito.Descripcion = '" + filter.AdvanceTipo_de_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Titulo_del_Delito.Descripcion LIKE '%" + filter.AdvanceTipo_de_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_DelitoMultiple != null && filter.AdvanceTipo_de_DelitoMultiple.Count() > 0)
            {
                var Tipo_de_DelitoIds = string.Join(",", filter.AdvanceTipo_de_DelitoMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Tipo_de_Delito In (" + Tipo_de_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceGrupo_de_Delito))
            {
                switch (filter.Grupo_de_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Grupo_del_Delito.Descripcion LIKE '" + filter.AdvanceGrupo_de_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Grupo_del_Delito.Descripcion LIKE '%" + filter.AdvanceGrupo_de_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Grupo_del_Delito.Descripcion = '" + filter.AdvanceGrupo_de_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Grupo_del_Delito.Descripcion LIKE '%" + filter.AdvanceGrupo_de_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceGrupo_de_DelitoMultiple != null && filter.AdvanceGrupo_de_DelitoMultiple.Count() > 0)
            {
                var Grupo_de_DelitoIds = string.Join(",", filter.AdvanceGrupo_de_DelitoMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Grupo_de_Delito In (" + Grupo_de_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceDelito))
            {
                switch (filter.DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Delito.Descripcion LIKE '" + filter.AdvanceDelito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Delito.Descripcion LIKE '%" + filter.AdvanceDelito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Delito.Descripcion = '" + filter.AdvanceDelito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Delito.Descripcion LIKE '%" + filter.AdvanceDelito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceDelitoMultiple != null && filter.AdvanceDelitoMultiple.Count() > 0)
            {
                var DelitoIds = string.Join(",", filter.AdvanceDelitoMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Delito In (" + DelitoIds + ")";
            }

            if (filter.Delito_Principal != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito_de_Justicia.Delito_Principal = " + Convert.ToInt32(filter.Delito_Principal);

            if (!string.IsNullOrEmpty(filter.AdvanceForma_de_Comision_de_Delito))
            {
                switch (filter.Forma_de_Comision_de_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_Comision_Delito.Descripcion LIKE '" + filter.AdvanceForma_de_Comision_de_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_Comision_Delito.Descripcion LIKE '%" + filter.AdvanceForma_de_Comision_de_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_Comision_Delito.Descripcion = '" + filter.AdvanceForma_de_Comision_de_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_Comision_Delito.Descripcion LIKE '%" + filter.AdvanceForma_de_Comision_de_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_de_Comision_de_DelitoMultiple != null && filter.AdvanceForma_de_Comision_de_DelitoMultiple.Count() > 0)
            {
                var Forma_de_Comision_de_DelitoIds = string.Join(",", filter.AdvanceForma_de_Comision_de_DelitoMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Forma_de_Comision_de_Delito In (" + Forma_de_Comision_de_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceForma_de_Accion_de_Delito))
            {
                switch (filter.Forma_de_Accion_de_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Forma_Accion_Delito.Descripcion LIKE '" + filter.AdvanceForma_de_Accion_de_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Forma_Accion_Delito.Descripcion LIKE '%" + filter.AdvanceForma_de_Accion_de_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Forma_Accion_Delito.Descripcion = '" + filter.AdvanceForma_de_Accion_de_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Forma_Accion_Delito.Descripcion LIKE '%" + filter.AdvanceForma_de_Accion_de_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceForma_de_Accion_de_DelitoMultiple != null && filter.AdvanceForma_de_Accion_de_DelitoMultiple.Count() > 0)
            {
                var Forma_de_Accion_de_DelitoIds = string.Join(",", filter.AdvanceForma_de_Accion_de_DelitoMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Forma_de_Accion_de_Delito In (" + Forma_de_Accion_de_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceModalidad_de_Delito))
            {
                switch (filter.Modalidad_de_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Modalidad_Delito.Descripcion LIKE '" + filter.AdvanceModalidad_de_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Modalidad_Delito.Descripcion LIKE '%" + filter.AdvanceModalidad_de_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Modalidad_Delito.Descripcion = '" + filter.AdvanceModalidad_de_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Modalidad_Delito.Descripcion LIKE '%" + filter.AdvanceModalidad_de_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceModalidad_de_DelitoMultiple != null && filter.AdvanceModalidad_de_DelitoMultiple.Count() > 0)
            {
                var Modalidad_de_DelitoIds = string.Join(",", filter.AdvanceModalidad_de_DelitoMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Modalidad_de_Delito In (" + Modalidad_de_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceElementos_de_Comision_de_Delito))
            {
                switch (filter.Elementos_de_Comision_de_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Elementos_Comision_Delito.Descripcion LIKE '" + filter.AdvanceElementos_de_Comision_de_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Elementos_Comision_Delito.Descripcion LIKE '%" + filter.AdvanceElementos_de_Comision_de_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Elementos_Comision_Delito.Descripcion = '" + filter.AdvanceElementos_de_Comision_de_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Elementos_Comision_Delito.Descripcion LIKE '%" + filter.AdvanceElementos_de_Comision_de_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceElementos_de_Comision_de_DelitoMultiple != null && filter.AdvanceElementos_de_Comision_de_DelitoMultiple.Count() > 0)
            {
                var Elementos_de_Comision_de_DelitoIds = string.Join(",", filter.AdvanceElementos_de_Comision_de_DelitoMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Elementos_de_Comision_de_Delito In (" + Elementos_de_Comision_de_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceClasificacion_con_Orden_de_Resultado))
            {
                switch (filter.Clasificacion_con_Orden_de_ResultadoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Clasificacion_en_Orden_de_Resultado.Descripcion LIKE '" + filter.AdvanceClasificacion_con_Orden_de_Resultado + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Clasificacion_en_Orden_de_Resultado.Descripcion LIKE '%" + filter.AdvanceClasificacion_con_Orden_de_Resultado + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Clasificacion_en_Orden_de_Resultado.Descripcion = '" + filter.AdvanceClasificacion_con_Orden_de_Resultado + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Clasificacion_en_Orden_de_Resultado.Descripcion LIKE '%" + filter.AdvanceClasificacion_con_Orden_de_Resultado + "%'";
                        break;
                }
            }
            else if (filter.AdvanceClasificacion_con_Orden_de_ResultadoMultiple != null && filter.AdvanceClasificacion_con_Orden_de_ResultadoMultiple.Count() > 0)
            {
                var Clasificacion_con_Orden_de_ResultadoIds = string.Join(",", filter.AdvanceClasificacion_con_Orden_de_ResultadoMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Clasificacion_con_Orden_de_Resultado In (" + Clasificacion_con_Orden_de_ResultadoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceConcurso))
            {
                switch (filter.ConcursoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Concurso.Descripcion LIKE '" + filter.AdvanceConcurso + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Concurso.Descripcion LIKE '%" + filter.AdvanceConcurso + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Concurso.Descripcion = '" + filter.AdvanceConcurso + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Concurso.Descripcion LIKE '%" + filter.AdvanceConcurso + "%'";
                        break;
                }
            }
            else if (filter.AdvanceConcursoMultiple != null && filter.AdvanceConcursoMultiple.Count() > 0)
            {
                var ConcursoIds = string.Join(",", filter.AdvanceConcursoMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Concurso In (" + ConcursoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromMonto_de_Reparacion_de_Danos) || !string.IsNullOrEmpty(filter.ToMonto_de_Reparacion_de_Danos))
            {
                if (!string.IsNullOrEmpty(filter.FromMonto_de_Reparacion_de_Danos))
                    where += " AND Detalle_de_Delito_de_Justicia.Monto_de_Reparacion_de_Danos >= " + filter.FromMonto_de_Reparacion_de_Danos;
                if (!string.IsNullOrEmpty(filter.ToMonto_de_Reparacion_de_Danos))
                    where += " AND Detalle_de_Delito_de_Justicia.Monto_de_Reparacion_de_Danos <= " + filter.ToMonto_de_Reparacion_de_Danos;
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_del_Delito))
            {
                switch (filter.Estado_del_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_del_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_del_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_del_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_del_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_del_DelitoMultiple != null && filter.AdvanceEstado_del_DelitoMultiple.Count() > 0)
            {
                var Estado_del_DelitoIds = string.Join(",", filter.AdvanceEstado_del_DelitoMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Estado_del_Delito In (" + Estado_del_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_del_Delito))
            {
                switch (filter.Municipio_del_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_del_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_del_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_del_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_del_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_del_DelitoMultiple != null && filter.AdvanceMunicipio_del_DelitoMultiple.Count() > 0)
            {
                var Municipio_del_DelitoIds = string.Join(",", filter.AdvanceMunicipio_del_DelitoMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Municipio_del_Delito In (" + Municipio_del_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia_del_Delito))
            {
                switch (filter.Colonia_del_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia_del_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_del_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia_del_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_del_Delito + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia_del_DelitoMultiple != null && filter.AdvanceColonia_del_DelitoMultiple.Count() > 0)
            {
                var Colonia_del_DelitoIds = string.Join(",", filter.AdvanceColonia_del_DelitoMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Colonia_del_Delito In (" + Colonia_del_DelitoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal) || !string.IsNullOrEmpty(filter.ToCodigo_Postal))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal))
                    where += " AND Detalle_de_Delito_de_Justicia.Codigo_Postal >= " + filter.FromCodigo_Postal;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal))
                    where += " AND Detalle_de_Delito_de_Justicia.Codigo_Postal <= " + filter.ToCodigo_Postal;
            }

            if (!string.IsNullOrEmpty(filter.Calle_del_Delito))
            {
                switch (filter.Calle_del_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Calle_del_Delito LIKE '" + filter.Calle_del_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Calle_del_Delito LIKE '%" + filter.Calle_del_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Calle_del_Delito = '" + filter.Calle_del_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Calle_del_Delito LIKE '%" + filter.Calle_del_Delito + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle_del_Delito))
            {
                switch (filter.Entre_Calle_del_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Entre_Calle_del_Delito LIKE '" + filter.Entre_Calle_del_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Entre_Calle_del_Delito LIKE '%" + filter.Entre_Calle_del_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Entre_Calle_del_Delito = '" + filter.Entre_Calle_del_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Entre_Calle_del_Delito LIKE '%" + filter.Entre_Calle_del_Delito + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Y_Calle_del_Delito))
            {
                switch (filter.Y_Calle_del_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Y_Calle_del_Delito LIKE '" + filter.Y_Calle_del_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Y_Calle_del_Delito LIKE '%" + filter.Y_Calle_del_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Y_Calle_del_Delito = '" + filter.Y_Calle_del_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Y_Calle_del_Delito LIKE '%" + filter.Y_Calle_del_Delito + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior_del_Delito))
            {
                switch (filter.Numero_Exterior_del_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Exterior_del_Delito LIKE '" + filter.Numero_Exterior_del_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Exterior_del_Delito LIKE '%" + filter.Numero_Exterior_del_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Exterior_del_Delito = '" + filter.Numero_Exterior_del_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Exterior_del_Delito LIKE '%" + filter.Numero_Exterior_del_Delito + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior_del_Delito))
            {
                switch (filter.Numero_Interior_del_DelitoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Interior_del_Delito LIKE '" + filter.Numero_Interior_del_Delito + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Interior_del_Delito LIKE '%" + filter.Numero_Interior_del_Delito + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Interior_del_Delito = '" + filter.Numero_Interior_del_Delito + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Interior_del_Delito LIKE '%" + filter.Numero_Interior_del_Delito + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencia))
            {
                switch (filter.ReferenciaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Referencia LIKE '" + filter.Referencia + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Referencia LIKE '%" + filter.Referencia + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Referencia = '" + filter.Referencia + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Referencia LIKE '%" + filter.Referencia + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud))
            {
                switch (filter.LatitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Latitud LIKE '" + filter.Latitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Latitud LIKE '%" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Latitud = '" + filter.Latitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Latitud LIKE '%" + filter.Latitud + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud))
            {
                switch (filter.LongitudFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Longitud LIKE '" + filter.Longitud + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Longitud LIKE '%" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Longitud = '" + filter.Longitud + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Longitud LIKE '%" + filter.Longitud + "%'";
                        break;
                }
            }

            if (filter.Robo_de_Vehiculo != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito_de_Justicia.Robo_de_Vehiculo = " + Convert.ToInt32(filter.Robo_de_Vehiculo);

            if (!string.IsNullOrEmpty(filter.FromFecha_del_Robo) || !string.IsNullOrEmpty(filter.ToFecha_del_Robo))
            {
                var Fecha_del_RoboFrom = DateTime.ParseExact(filter.FromFecha_del_Robo, ConfigurationProperty.DateFormat,
                    CultureInfo.InvariantCulture as IFormatProvider);
                var Fecha_del_RoboTo = DateTime.ParseExact(filter.ToFecha_del_Robo, ConfigurationProperty.DateFormat,
                  CultureInfo.InvariantCulture as IFormatProvider);

                if (!string.IsNullOrEmpty(filter.FromFecha_del_Robo))
                    where += " AND Detalle_de_Delito_de_Justicia.Fecha_del_Robo >= '" + Fecha_del_RoboFrom.ToString("MM-dd-yyyy") + "'";
                if (!string.IsNullOrEmpty(filter.ToFecha_del_Robo))
                    where += " AND Detalle_de_Delito_de_Justicia.Fecha_del_Robo <= '" + Fecha_del_RoboTo.ToString("MM-dd-yyyy") + "'";
            }

            if (!string.IsNullOrEmpty(filter.FromHora_del_Robo) || !string.IsNullOrEmpty(filter.ToHora_del_Robo))
            {
                if (!string.IsNullOrEmpty(filter.FromHora_del_Robo))
                    where += " AND Convert(TIME,Detalle_de_Delito_de_Justicia.Hora_del_Robo) >='" + filter.FromHora_del_Robo + "'";
                if (!string.IsNullOrEmpty(filter.ToHora_del_Robo))
                    where += " AND Convert(TIME,Detalle_de_Delito_de_Justicia.Hora_del_Robo) <='" + filter.ToHora_del_Robo + "'";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceRobo_de))
            {
                switch (filter.Robo_deFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Elemento_Robado.Descripcion LIKE '" + filter.AdvanceRobo_de + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Elemento_Robado.Descripcion LIKE '%" + filter.AdvanceRobo_de + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Elemento_Robado.Descripcion = '" + filter.AdvanceRobo_de + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Elemento_Robado.Descripcion LIKE '%" + filter.AdvanceRobo_de + "%'";
                        break;
                }
            }
            else if (filter.AdvanceRobo_deMultiple != null && filter.AdvanceRobo_deMultiple.Count() > 0)
            {
                var Robo_deIds = string.Join(",", filter.AdvanceRobo_deMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Robo_de In (" + Robo_deIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Registro_Federal_Vehicular))
            {
                switch (filter.Registro_Federal_VehicularFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Registro_Federal_Vehicular LIKE '" + filter.Registro_Federal_Vehicular + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Registro_Federal_Vehicular LIKE '%" + filter.Registro_Federal_Vehicular + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Registro_Federal_Vehicular = '" + filter.Registro_Federal_Vehicular + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Registro_Federal_Vehicular LIKE '%" + filter.Registro_Federal_Vehicular + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Registro_Publico_Vehicular))
            {
                switch (filter.Numero_de_Registro_Publico_VehicularFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_de_Registro_Publico_Vehicular LIKE '" + filter.Numero_de_Registro_Publico_Vehicular + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_de_Registro_Publico_Vehicular LIKE '%" + filter.Numero_de_Registro_Publico_Vehicular + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_de_Registro_Publico_Vehicular = '" + filter.Numero_de_Registro_Publico_Vehicular + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_de_Registro_Publico_Vehicular LIKE '%" + filter.Numero_de_Registro_Publico_Vehicular + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCircunstancia_de_Robo_de_Vehiculo))
            {
                switch (filter.Circunstancia_de_Robo_de_VehiculoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Circunstancia_Vehiculo.Descripcion LIKE '" + filter.AdvanceCircunstancia_de_Robo_de_Vehiculo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Circunstancia_Vehiculo.Descripcion LIKE '%" + filter.AdvanceCircunstancia_de_Robo_de_Vehiculo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Circunstancia_Vehiculo.Descripcion = '" + filter.AdvanceCircunstancia_de_Robo_de_Vehiculo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Circunstancia_Vehiculo.Descripcion LIKE '%" + filter.AdvanceCircunstancia_de_Robo_de_Vehiculo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCircunstancia_de_Robo_de_VehiculoMultiple != null && filter.AdvanceCircunstancia_de_Robo_de_VehiculoMultiple.Count() > 0)
            {
                var Circunstancia_de_Robo_de_VehiculoIds = string.Join(",", filter.AdvanceCircunstancia_de_Robo_de_VehiculoMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Circunstancia_de_Robo_de_Vehiculo In (" + Circunstancia_de_Robo_de_VehiculoIds + ")";
            }

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

                where += " AND Detalle_de_Delito_de_Justicia.Marca In (" + MarcaIds + ")";
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

                where += " AND Detalle_de_Delito_de_Justicia.Sub_Marca In (" + Sub_MarcaIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_vehiculo))
            {
                switch (filter.Tipo_de_vehiculoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Vehiculo.Descripcion LIKE '" + filter.AdvanceTipo_de_vehiculo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceTipo_de_vehiculo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Vehiculo.Descripcion = '" + filter.AdvanceTipo_de_vehiculo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceTipo_de_vehiculo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_vehiculoMultiple != null && filter.AdvanceTipo_de_vehiculoMultiple.Count() > 0)
            {
                var Tipo_de_vehiculoIds = string.Join(",", filter.AdvanceTipo_de_vehiculoMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Tipo_de_vehiculo In (" + Tipo_de_vehiculoIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromModelo) || !string.IsNullOrEmpty(filter.ToModelo))
            {
                if (!string.IsNullOrEmpty(filter.FromModelo))
                    where += " AND Detalle_de_Delito_de_Justicia.Modelo >= " + filter.FromModelo;
                if (!string.IsNullOrEmpty(filter.ToModelo))
                    where += " AND Detalle_de_Delito_de_Justicia.Modelo <= " + filter.ToModelo;
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

                where += " AND Detalle_de_Delito_de_Justicia.Color In (" + ColorIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Placas))
            {
                switch (filter.PlacasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Placas LIKE '" + filter.Placas + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Placas LIKE '%" + filter.Placas + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Placas = '" + filter.Placas + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Placas LIKE '%" + filter.Placas + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_de_Origen_de_las_Placas))
            {
                switch (filter.Estado_de_Origen_de_las_PlacasFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_de_Origen_de_las_Placas + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_de_Origen_de_las_Placas + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_de_Origen_de_las_Placas + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_de_Origen_de_las_Placas + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_de_Origen_de_las_PlacasMultiple != null && filter.AdvanceEstado_de_Origen_de_las_PlacasMultiple.Count() > 0)
            {
                var Estado_de_Origen_de_las_PlacasIds = string.Join(",", filter.AdvanceEstado_de_Origen_de_las_PlacasMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Estado_de_Origen_de_las_Placas In (" + Estado_de_Origen_de_las_PlacasIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Motor))
            {
                switch (filter.MotorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Motor LIKE '" + filter.Motor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Motor LIKE '%" + filter.Motor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Motor = '" + filter.Motor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Motor LIKE '%" + filter.Motor + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Serie))
            {
                switch (filter.SerieFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Serie LIKE '" + filter.Serie + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Serie LIKE '%" + filter.Serie + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Serie = '" + filter.Serie + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Serie LIKE '%" + filter.Serie + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceEstado_De_Robo))
            {
                switch (filter.Estado_De_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Estado.Nombre LIKE '" + filter.AdvanceEstado_De_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_De_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Estado.Nombre = '" + filter.AdvanceEstado_De_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Estado.Nombre LIKE '%" + filter.AdvanceEstado_De_Robo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceEstado_De_RoboMultiple != null && filter.AdvanceEstado_De_RoboMultiple.Count() > 0)
            {
                var Estado_De_RoboIds = string.Join(",", filter.AdvanceEstado_De_RoboMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Estado_De_Robo In (" + Estado_De_RoboIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceMunicipio_de_Robo))
            {
                switch (filter.Municipio_de_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Municipio.Nombre LIKE '" + filter.AdvanceMunicipio_de_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_de_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Municipio.Nombre = '" + filter.AdvanceMunicipio_de_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Municipio.Nombre LIKE '%" + filter.AdvanceMunicipio_de_Robo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceMunicipio_de_RoboMultiple != null && filter.AdvanceMunicipio_de_RoboMultiple.Count() > 0)
            {
                var Municipio_de_RoboIds = string.Join(",", filter.AdvanceMunicipio_de_RoboMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Municipio_de_Robo In (" + Municipio_de_RoboIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceColonia_de_Robo))
            {
                switch (filter.Colonia_de_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Colonia.Nombre LIKE '" + filter.AdvanceColonia_de_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_de_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Colonia.Nombre = '" + filter.AdvanceColonia_de_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Colonia.Nombre LIKE '%" + filter.AdvanceColonia_de_Robo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceColonia_de_RoboMultiple != null && filter.AdvanceColonia_de_RoboMultiple.Count() > 0)
            {
                var Colonia_de_RoboIds = string.Join(",", filter.AdvanceColonia_de_RoboMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Colonia_de_Robo In (" + Colonia_de_RoboIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_de_Robo) || !string.IsNullOrEmpty(filter.ToCodigo_Postal_de_Robo))
            {
                if (!string.IsNullOrEmpty(filter.FromCodigo_Postal_de_Robo))
                    where += " AND Detalle_de_Delito_de_Justicia.Codigo_Postal_de_Robo >= " + filter.FromCodigo_Postal_de_Robo;
                if (!string.IsNullOrEmpty(filter.ToCodigo_Postal_de_Robo))
                    where += " AND Detalle_de_Delito_de_Justicia.Codigo_Postal_de_Robo <= " + filter.ToCodigo_Postal_de_Robo;
            }

            if (!string.IsNullOrEmpty(filter.Calle_de_Robo))
            {
                switch (filter.Calle_de_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Calle_de_Robo LIKE '" + filter.Calle_de_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Calle_de_Robo LIKE '%" + filter.Calle_de_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Calle_de_Robo = '" + filter.Calle_de_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Calle_de_Robo LIKE '%" + filter.Calle_de_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Entre_Calle_de_Robo))
            {
                switch (filter.Entre_Calle_de_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Entre_Calle_de_Robo LIKE '" + filter.Entre_Calle_de_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Entre_Calle_de_Robo LIKE '%" + filter.Entre_Calle_de_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Entre_Calle_de_Robo = '" + filter.Entre_Calle_de_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Entre_Calle_de_Robo LIKE '%" + filter.Entre_Calle_de_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Y_Calle_de_Robo))
            {
                switch (filter.Y_Calle_de_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Y_Calle_de_Robo LIKE '" + filter.Y_Calle_de_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Y_Calle_de_Robo LIKE '%" + filter.Y_Calle_de_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Y_Calle_de_Robo = '" + filter.Y_Calle_de_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Y_Calle_de_Robo LIKE '%" + filter.Y_Calle_de_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Exterior_de_Robo))
            {
                switch (filter.Numero_Exterior_de_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Exterior_de_Robo LIKE '" + filter.Numero_Exterior_de_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Exterior_de_Robo LIKE '%" + filter.Numero_Exterior_de_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Exterior_de_Robo = '" + filter.Numero_Exterior_de_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Exterior_de_Robo LIKE '%" + filter.Numero_Exterior_de_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_Interior_de_Robo))
            {
                switch (filter.Numero_Interior_de_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Interior_de_Robo LIKE '" + filter.Numero_Interior_de_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Interior_de_Robo LIKE '%" + filter.Numero_Interior_de_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Interior_de_Robo = '" + filter.Numero_Interior_de_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_Interior_de_Robo LIKE '%" + filter.Numero_Interior_de_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Referencia_de_Robo))
            {
                switch (filter.Referencia_de_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Referencia_de_Robo LIKE '" + filter.Referencia_de_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Referencia_de_Robo LIKE '%" + filter.Referencia_de_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Referencia_de_Robo = '" + filter.Referencia_de_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Referencia_de_Robo LIKE '%" + filter.Referencia_de_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Latitud_de_Robo))
            {
                switch (filter.Latitud_de_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Latitud_de_Robo LIKE '" + filter.Latitud_de_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Latitud_de_Robo LIKE '%" + filter.Latitud_de_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Latitud_de_Robo = '" + filter.Latitud_de_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Latitud_de_Robo LIKE '%" + filter.Latitud_de_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Longitud_de_Robo))
            {
                switch (filter.Longitud_de_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Longitud_de_Robo LIKE '" + filter.Longitud_de_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Longitud_de_Robo LIKE '%" + filter.Longitud_de_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Longitud_de_Robo = '" + filter.Longitud_de_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Longitud_de_Robo LIKE '%" + filter.Longitud_de_Robo + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceLugar_de_Robo))
            {
                switch (filter.Lugar_de_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Lugar_del_Robo.Descripcion LIKE '" + filter.AdvanceLugar_de_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Lugar_del_Robo.Descripcion LIKE '%" + filter.AdvanceLugar_de_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Lugar_del_Robo.Descripcion = '" + filter.AdvanceLugar_de_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Lugar_del_Robo.Descripcion LIKE '%" + filter.AdvanceLugar_de_Robo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceLugar_de_RoboMultiple != null && filter.AdvanceLugar_de_RoboMultiple.Count() > 0)
            {
                var Lugar_de_RoboIds = string.Join(",", filter.AdvanceLugar_de_RoboMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Lugar_de_Robo In (" + Lugar_de_RoboIds + ")";
            }

            if (filter.El_vehiculo_esta_asegurado != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito_de_Justicia.El_vehiculo_esta_asegurado = " + Convert.ToInt32(filter.El_vehiculo_esta_asegurado);

            if (!string.IsNullOrEmpty(filter.AdvanceNombre_de_la_Aseguradora))
            {
                switch (filter.Nombre_de_la_AseguradoraFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Aseguradora_de_Vehiculo.Descripcion LIKE '" + filter.AdvanceNombre_de_la_Aseguradora + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Aseguradora_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceNombre_de_la_Aseguradora + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Aseguradora_de_Vehiculo.Descripcion = '" + filter.AdvanceNombre_de_la_Aseguradora + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Aseguradora_de_Vehiculo.Descripcion LIKE '%" + filter.AdvanceNombre_de_la_Aseguradora + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNombre_de_la_AseguradoraMultiple != null && filter.AdvanceNombre_de_la_AseguradoraMultiple.Count() > 0)
            {
                var Nombre_de_la_AseguradoraIds = string.Join(",", filter.AdvanceNombre_de_la_AseguradoraMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Nombre_de_la_Aseguradora In (" + Nombre_de_la_AseguradoraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Ruta_del_Servicio_Publico))
            {
                switch (filter.Ruta_del_Servicio_PublicoFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Ruta_del_Servicio_Publico LIKE '" + filter.Ruta_del_Servicio_Publico + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Ruta_del_Servicio_Publico LIKE '%" + filter.Ruta_del_Servicio_Publico + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Ruta_del_Servicio_Publico = '" + filter.Ruta_del_Servicio_Publico + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Ruta_del_Servicio_Publico LIKE '%" + filter.Ruta_del_Servicio_Publico + "%'";
                        break;
                }
            }

            if (filter.El_Vehiculo_Transportaba_Mercancia != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito_de_Justicia.El_Vehiculo_Transportaba_Mercancia = " + Convert.ToInt32(filter.El_Vehiculo_Transportaba_Mercancia);

            if (!string.IsNullOrEmpty(filter.Descripcion_de_lo_que_Transportaba))
            {
                switch (filter.Descripcion_de_lo_que_TransportabaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Descripcion_de_lo_que_Transportaba LIKE '" + filter.Descripcion_de_lo_que_Transportaba + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Descripcion_de_lo_que_Transportaba LIKE '%" + filter.Descripcion_de_lo_que_Transportaba + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Descripcion_de_lo_que_Transportaba = '" + filter.Descripcion_de_lo_que_Transportaba + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Descripcion_de_lo_que_Transportaba LIKE '%" + filter.Descripcion_de_lo_que_Transportaba + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.FromMonto_de_carga) || !string.IsNullOrEmpty(filter.ToMonto_de_carga))
            {
                if (!string.IsNullOrEmpty(filter.FromMonto_de_carga))
                    where += " AND Detalle_de_Delito_de_Justicia.Monto_de_carga >= " + filter.FromMonto_de_carga;
                if (!string.IsNullOrEmpty(filter.ToMonto_de_carga))
                    where += " AND Detalle_de_Delito_de_Justicia.Monto_de_carga <= " + filter.ToMonto_de_carga;
            }

            if (!string.IsNullOrEmpty(filter.Senas_particulares))
            {
                switch (filter.Senas_particularesFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Senas_particulares LIKE '" + filter.Senas_particulares + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Senas_particulares LIKE '%" + filter.Senas_particulares + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Senas_particulares = '" + filter.Senas_particulares + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Senas_particulares LIKE '%" + filter.Senas_particulares + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.AdvanceCuenta_con_GPS))
            {
                switch (filter.Cuenta_con_GPSFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Binario.Descripcion LIKE '" + filter.AdvanceCuenta_con_GPS + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Binario.Descripcion LIKE '%" + filter.AdvanceCuenta_con_GPS + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Binario.Descripcion = '" + filter.AdvanceCuenta_con_GPS + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Binario.Descripcion LIKE '%" + filter.AdvanceCuenta_con_GPS + "%'";
                        break;
                }
            }
            else if (filter.AdvanceCuenta_con_GPSMultiple != null && filter.AdvanceCuenta_con_GPSMultiple.Count() > 0)
            {
                var Cuenta_con_GPSIds = string.Join(",", filter.AdvanceCuenta_con_GPSMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Cuenta_con_GPS In (" + Cuenta_con_GPSIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Robo))
            {
                switch (filter.Tipo_de_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Robo.Descripcion LIKE '" + filter.AdvanceTipo_de_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Robo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Robo.Descripcion = '" + filter.AdvanceTipo_de_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Robo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Robo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_RoboMultiple != null && filter.AdvanceTipo_de_RoboMultiple.Count() > 0)
            {
                var Tipo_de_RoboIds = string.Join(",", filter.AdvanceTipo_de_RoboMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Tipo_de_Robo In (" + Tipo_de_RoboIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Lugar_del_Robo))
            {
                switch (filter.Tipo_de_Lugar_del_RoboFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Lugar_del_Robo.Descripcion LIKE '" + filter.AdvanceTipo_de_Lugar_del_Robo + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Lugar_del_Robo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Lugar_del_Robo + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Lugar_del_Robo.Descripcion = '" + filter.AdvanceTipo_de_Lugar_del_Robo + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Lugar_del_Robo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Lugar_del_Robo + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_Lugar_del_RoboMultiple != null && filter.AdvanceTipo_de_Lugar_del_RoboMultiple.Count() > 0)
            {
                var Tipo_de_Lugar_del_RoboIds = string.Join(",", filter.AdvanceTipo_de_Lugar_del_RoboMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Tipo_de_Lugar_del_Robo In (" + Tipo_de_Lugar_del_RoboIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Carretera))
            {
                switch (filter.Tipo_de_CarreteraFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Tipo_de_Carretera.Descripcion LIKE '" + filter.AdvanceTipo_de_Carretera + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Tipo_de_Carretera.Descripcion LIKE '%" + filter.AdvanceTipo_de_Carretera + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Tipo_de_Carretera.Descripcion = '" + filter.AdvanceTipo_de_Carretera + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Tipo_de_Carretera.Descripcion LIKE '%" + filter.AdvanceTipo_de_Carretera + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_CarreteraMultiple != null && filter.AdvanceTipo_de_CarreteraMultiple.Count() > 0)
            {
                var Tipo_de_CarreteraIds = string.Join(",", filter.AdvanceTipo_de_CarreteraMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Tipo_de_Carretera In (" + Tipo_de_CarreteraIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.AdvanceTipo_de_Servicio))
            {
                switch (filter.Tipo_de_ServicioFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Servicio_del_Vehiculo.Descripcion LIKE '" + filter.AdvanceTipo_de_Servicio + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Servicio_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Servicio + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Servicio_del_Vehiculo.Descripcion = '" + filter.AdvanceTipo_de_Servicio + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Servicio_del_Vehiculo.Descripcion LIKE '%" + filter.AdvanceTipo_de_Servicio + "%'";
                        break;
                }
            }
            else if (filter.AdvanceTipo_de_ServicioMultiple != null && filter.AdvanceTipo_de_ServicioMultiple.Count() > 0)
            {
                var Tipo_de_ServicioIds = string.Join(",", filter.AdvanceTipo_de_ServicioMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Tipo_de_Servicio In (" + Tipo_de_ServicioIds + ")";
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Serie))
            {
                switch (filter.Numero_de_SerieFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_de_Serie LIKE '" + filter.Numero_de_Serie + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_de_Serie LIKE '%" + filter.Numero_de_Serie + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_de_Serie = '" + filter.Numero_de_Serie + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_de_Serie LIKE '%" + filter.Numero_de_Serie + "%'";
                        break;
                }
            }

            if (!string.IsNullOrEmpty(filter.Numero_de_Motor))
            {
                switch (filter.Numero_de_MotorFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_de_Motor LIKE '" + filter.Numero_de_Motor + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_de_Motor LIKE '%" + filter.Numero_de_Motor + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_de_Motor = '" + filter.Numero_de_Motor + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Delito_de_Justicia.Numero_de_Motor LIKE '%" + filter.Numero_de_Motor + "%'";
                        break;
                }
            }

            if (filter.Persona_Moral != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito_de_Justicia.Persona_Moral = " + Convert.ToInt32(filter.Persona_Moral);

            if (!string.IsNullOrEmpty(filter.AdvanceNombre_Completo_Persona_Moral))
            {
                switch (filter.Nombre_Completo_Persona_MoralFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Persona_Moral_JA.Nombre LIKE '" + filter.AdvanceNombre_Completo_Persona_Moral + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Persona_Moral_JA.Nombre LIKE '%" + filter.AdvanceNombre_Completo_Persona_Moral + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Persona_Moral_JA.Nombre = '" + filter.AdvanceNombre_Completo_Persona_Moral + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Persona_Moral_JA.Nombre LIKE '%" + filter.AdvanceNombre_Completo_Persona_Moral + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNombre_Completo_Persona_MoralMultiple != null && filter.AdvanceNombre_Completo_Persona_MoralMultiple.Count() > 0)
            {
                var Nombre_Completo_Persona_MoralIds = string.Join(",", filter.AdvanceNombre_Completo_Persona_MoralMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Nombre_Completo_Persona_Moral In (" + Nombre_Completo_Persona_MoralIds + ")";
            }

            if (filter.Persona_Fisica != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito_de_Justicia.Persona_Fisica = " + Convert.ToInt32(filter.Persona_Fisica);

            if (!string.IsNullOrEmpty(filter.AdvanceNombre_Completo_Persona_Fisica))
            {
                switch (filter.Nombre_Completo_Persona_FisicaFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre LIKE '" + filter.AdvanceNombre_Completo_Persona_Fisica + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre LIKE '%" + filter.AdvanceNombre_Completo_Persona_Fisica + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre = '" + filter.AdvanceNombre_Completo_Persona_Fisica + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre LIKE '%" + filter.AdvanceNombre_Completo_Persona_Fisica + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNombre_Completo_Persona_FisicaMultiple != null && filter.AdvanceNombre_Completo_Persona_FisicaMultiple.Count() > 0)
            {
                var Nombre_Completo_Persona_FisicaIds = string.Join(",", filter.AdvanceNombre_Completo_Persona_FisicaMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Nombre_Completo_Persona_Fisica In (" + Nombre_Completo_Persona_FisicaIds + ")";
            }

            if (filter.Denunciante != RadioOptions.NoApply)
                where += " AND Detalle_de_Delito_de_Justicia.Denunciante = " + Convert.ToInt32(filter.Denunciante);

            if (!string.IsNullOrEmpty(filter.AdvanceNombre_Completo_Denunciante))
            {
                switch (filter.Nombre_Completo_DenuncianteFilter)
                {
                    case Models.Filters.BeginWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre LIKE '" + filter.AdvanceNombre_Completo_Denunciante + "%'";
                        break;

                    case Models.Filters.EndWith:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre LIKE '%" + filter.AdvanceNombre_Completo_Denunciante + "'";
                        break;

                    case Models.Filters.Exact:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre = '" + filter.AdvanceNombre_Completo_Denunciante + "'";
                        break;

                    case Models.Filters.Contains:
                        where += " AND Detalle_de_Solicitud_Solicitante.Nombre LIKE '%" + filter.AdvanceNombre_Completo_Denunciante + "%'";
                        break;
                }
            }
            else if (filter.AdvanceNombre_Completo_DenuncianteMultiple != null && filter.AdvanceNombre_Completo_DenuncianteMultiple.Count() > 0)
            {
                var Nombre_Completo_DenuncianteIds = string.Join(",", filter.AdvanceNombre_Completo_DenuncianteMultiple);

                where += " AND Detalle_de_Delito_de_Justicia.Nombre_Completo_Denunciante In (" + Nombre_Completo_DenuncianteIds + ")";
            }


            where = new Regex(Regex.Escape("AND ")).Replace(where, "", 1);
            return where;
        }

        [NonAction]
        public Grid_File ConvertSpartane_FileToGridFile(Spartane.Core.Domain.Spartane_File.Spartane_File file)
        {
            return file == null ? new Grid_File { FileId = 0, FileSize = 0, FileName = "" } : new Grid_File { FileId = file.File_Id, FileName = file.Description, FileSize = file.File_Size ?? 0, };
        }

        public ActionResult GetAgravantes_del_Delito_MASC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Agravantes_del_Delito_MASCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _IAgravantes_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Agravantes_del_Delito_MASC.Folio_Agravante=" + RelationId;
            if("int" == "string")
            {
	           where = "Agravantes_del_Delito_MASC.Folio_Agravante='" + RelationId + "'";
            }
            var result = _IAgravantes_del_Delito_MASCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Agravantes_del_Delito_MASCs == null)
                result.Agravantes_del_Delito_MASCs = new List<Agravantes_del_Delito_MASC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Agravantes_del_Delito_MASCs.Select(m => new Agravantes_del_Delito_MASCGridModel
                {
                    Clave = m.Clave

                        ,Agravante = m.Agravante
                        ,AgravanteDescripcion = CultureHelper.GetTraduction(m.Agravante_Agravantes.Clave.ToString(), "Descripcion") ??(string)m.Agravante_Agravantes.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Agravantes_del_Delito_MASCGridModel> GetAgravantes_del_Delito_MASCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Agravantes_del_Delito_MASCGridModel> resultData = new List<Agravantes_del_Delito_MASCGridModel>();
            string where = "Agravantes_del_Delito_MASC.Folio_Agravante=" + Id;
            if("int" == "string")
            {
                where = "Agravantes_del_Delito_MASC.Folio_Agravante='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _IAgravantes_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _IAgravantes_del_Delito_MASCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Agravantes_del_Delito_MASCs != null)
            {
                resultData = result.Agravantes_del_Delito_MASCs.Select(m => new Agravantes_del_Delito_MASCGridModel
                    {
                        Clave = m.Clave

                        ,Agravante = m.Agravante
                        ,AgravanteDescripcion = CultureHelper.GetTraduction(m.Agravante_Agravantes.Clave.ToString(), "Descripcion") ??(string)m.Agravante_Agravantes.Descripcion


                    }).ToList();
                RowCount = result.RowCount;
            }
            return resultData;
        }
        public ActionResult GetCircunstancias_del_Delito_MASC(int draw, int start, int length, string RelationId = "0")
        {
            if (RelationId == "0")
            {
                return Json(new { recordsTotal = 0, recordsFiltered = 0, data = new List<Circunstancias_del_Delito_MASCGridModel>() }, JsonRequestBehavior.AllowGet);
            }

            if (!_tokenManager.GenerateToken())
                return null;
            _ICircunstancias_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var pageSize = length;
            var pageIndex = start + 1;
            string where = "Circunstancias_del_Delito_MASC.Folio_Circunstancial=" + RelationId;
            if("int" == "string")
            {
	           where = "Circunstancias_del_Delito_MASC.Folio_Circunstancial='" + RelationId + "'";
            }
            var result = _ICircunstancias_del_Delito_MASCApiConsumer.ListaSelAll(start, pageSize, where,"").Resource;
            if (result.Circunstancias_del_Delito_MASCs == null)
                result.Circunstancias_del_Delito_MASCs = new List<Circunstancias_del_Delito_MASC>();

            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);

            var jsonResult = Json(new
            {
                data = result.Circunstancias_del_Delito_MASCs.Select(m => new Circunstancias_del_Delito_MASCGridModel
                {
                    Clave = m.Clave

                        ,Tipo_de_Lugar = m.Tipo_de_Lugar
                        ,Tipo_de_LugarDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_Circunstancias.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Lugar_Circunstancias.Descripcion

                }).ToList(),
                recordsTotal = result.RowCount,
                recordsFiltered = result.RowCount,
            }, JsonRequestBehavior.AllowGet);

            jsonResult.MaxJsonLength = int.MaxValue;

            return jsonResult;
        }
        public List<Circunstancias_del_Delito_MASCGridModel> GetCircunstancias_del_Delito_MASCData(string Id, int start, int length, out int RowCount)
        {
            RowCount = 0;
            var pageSize = length;
            var pageIndex = start + 1;
            List<Circunstancias_del_Delito_MASCGridModel> resultData = new List<Circunstancias_del_Delito_MASCGridModel>();
            string where = "Circunstancias_del_Delito_MASC.Folio_Circunstancial=" + Id;
            if("int" == "string")
            {
                where = "Circunstancias_del_Delito_MASC.Folio_Circunstancial='" + Id + "'";
            }
            if (!_tokenManager.GenerateToken())
                return null;
            _ICircunstancias_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
            var result = _ICircunstancias_del_Delito_MASCApiConsumer.ListaSelAll(start, pageSize, where, "").Resource;
            _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
            if (result.Circunstancias_del_Delito_MASCs != null)
            {
                resultData = result.Circunstancias_del_Delito_MASCs.Select(m => new Circunstancias_del_Delito_MASCGridModel
                    {
                        Clave = m.Clave

                        ,Tipo_de_Lugar = m.Tipo_de_Lugar
                        ,Tipo_de_LugarDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_Circunstancias.Clave.ToString(), "Descripcion") ??(string)m.Tipo_de_Lugar_Circunstancias.Descripcion


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
                _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);

                Detalle_de_Delito_de_Justicia varDetalle_de_Delito_de_Justicia = null;
                if (id.ToString() != "0")
                {
                        string where = "";
                    _IAgravantes_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Agravantes_del_Delito_MASC.Folio_Agravante=" + id;
                    if("int" == "string")
                    {
	                where = "Agravantes_del_Delito_MASC.Folio_Agravante='" + id + "'";
                    }
                    var Agravantes_del_Delito_MASCInfo =
                        _IAgravantes_del_Delito_MASCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Agravantes_del_Delito_MASCInfo.Agravantes_del_Delito_MASCs.Count > 0)
                    {
                        var resultAgravantes_del_Delito_MASC = true;
                        //Removing associated job history with attachment
                        foreach (var Agravantes_del_Delito_MASCItem in Agravantes_del_Delito_MASCInfo.Agravantes_del_Delito_MASCs)
                            resultAgravantes_del_Delito_MASC = resultAgravantes_del_Delito_MASC
                                              && _IAgravantes_del_Delito_MASCApiConsumer.Delete(Agravantes_del_Delito_MASCItem.Clave, null,null).Resource;

                        if (!resultAgravantes_del_Delito_MASC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    _ICircunstancias_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);
                    where = "Circunstancias_del_Delito_MASC.Folio_Circunstancial=" + id;
                    if("int" == "string")
                    {
	                where = "Circunstancias_del_Delito_MASC.Folio_Circunstancial='" + id + "'";
                    }
                    var Circunstancias_del_Delito_MASCInfo =
                        _ICircunstancias_del_Delito_MASCApiConsumer.ListaSelAll(1, int.MaxValue, where,"").Resource;

                    if (Circunstancias_del_Delito_MASCInfo.Circunstancias_del_Delito_MASCs.Count > 0)
                    {
                        var resultCircunstancias_del_Delito_MASC = true;
                        //Removing associated job history with attachment
                        foreach (var Circunstancias_del_Delito_MASCItem in Circunstancias_del_Delito_MASCInfo.Circunstancias_del_Delito_MASCs)
                            resultCircunstancias_del_Delito_MASC = resultCircunstancias_del_Delito_MASC
                                              && _ICircunstancias_del_Delito_MASCApiConsumer.Delete(Circunstancias_del_Delito_MASCItem.Clave, null,null).Resource;

                        if (!resultCircunstancias_del_Delito_MASC)
                            return Json(false, JsonRequestBehavior.AllowGet);
                    }

                }
                var result = _IDetalle_de_Delito_de_JusticiaApiConsumer.Delete(id, null, null).Resource;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Post(bool IsNew, Detalle_de_Delito_de_JusticiaModel varDetalle_de_Delito_de_Justicia)
        {
            try
            {
				//if (ModelState.IsValid)
				//{
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);
                    _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);



                    
                    var result = "";
                    var Detalle_de_Delito_de_JusticiaInfo = new Detalle_de_Delito_de_Justicia
                    {
                        Clave = varDetalle_de_Delito_de_Justicia.Clave
                        ,idRegistroAT = varDetalle_de_Delito_de_Justicia.idRegistroAT
                        ,idRegistroUI = varDetalle_de_Delito_de_Justicia.idRegistroUI
                        ,Solicitud = varDetalle_de_Delito_de_Justicia.Solicitud
                        ,Tipo_de_Denuncia = varDetalle_de_Delito_de_Justicia.Tipo_de_Denuncia
                        ,Fecha_de_Delito = (!String.IsNullOrEmpty(varDetalle_de_Delito_de_Justicia.Fecha_de_Delito)) ? DateTime.ParseExact(varDetalle_de_Delito_de_Justicia.Fecha_de_Delito, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Violencia_de_Genero = varDetalle_de_Delito_de_Justicia.Violencia_de_Genero
                        ,Delito_Violencia_Genero = varDetalle_de_Delito_de_Justicia.Delito_Violencia_Genero
                        ,Hora_de_Delito = varDetalle_de_Delito_de_Justicia.Hora_de_Delito
                        ,Tipo_de_Delito = varDetalle_de_Delito_de_Justicia.Tipo_de_Delito
                        ,Grupo_de_Delito = varDetalle_de_Delito_de_Justicia.Grupo_de_Delito
                        ,Delito = varDetalle_de_Delito_de_Justicia.Delito
                        ,Delito_Principal = varDetalle_de_Delito_de_Justicia.Delito_Principal
                        ,Forma_de_Comision_de_Delito = varDetalle_de_Delito_de_Justicia.Forma_de_Comision_de_Delito
                        ,Forma_de_Accion_de_Delito = varDetalle_de_Delito_de_Justicia.Forma_de_Accion_de_Delito
                        ,Modalidad_de_Delito = varDetalle_de_Delito_de_Justicia.Modalidad_de_Delito
                        ,Elementos_de_Comision_de_Delito = varDetalle_de_Delito_de_Justicia.Elementos_de_Comision_de_Delito
                        ,Clasificacion_con_Orden_de_Resultado = varDetalle_de_Delito_de_Justicia.Clasificacion_con_Orden_de_Resultado
                        ,Concurso = varDetalle_de_Delito_de_Justicia.Concurso
                        ,Monto_de_Reparacion_de_Danos = varDetalle_de_Delito_de_Justicia.Monto_de_Reparacion_de_Danos
                        ,Estado_del_Delito = varDetalle_de_Delito_de_Justicia.Estado_del_Delito
                        ,Municipio_del_Delito = varDetalle_de_Delito_de_Justicia.Municipio_del_Delito
                        ,Colonia_del_Delito = varDetalle_de_Delito_de_Justicia.Colonia_del_Delito
                        ,Codigo_Postal = varDetalle_de_Delito_de_Justicia.Codigo_Postal
                        ,Calle_del_Delito = varDetalle_de_Delito_de_Justicia.Calle_del_Delito
                        ,Entre_Calle_del_Delito = varDetalle_de_Delito_de_Justicia.Entre_Calle_del_Delito
                        ,Y_Calle_del_Delito = varDetalle_de_Delito_de_Justicia.Y_Calle_del_Delito
                        ,Numero_Exterior_del_Delito = varDetalle_de_Delito_de_Justicia.Numero_Exterior_del_Delito
                        ,Numero_Interior_del_Delito = varDetalle_de_Delito_de_Justicia.Numero_Interior_del_Delito
                        ,Referencia = varDetalle_de_Delito_de_Justicia.Referencia
                        ,Latitud = varDetalle_de_Delito_de_Justicia.Latitud
                        ,Longitud = varDetalle_de_Delito_de_Justicia.Longitud
                        ,Robo_de_Vehiculo = varDetalle_de_Delito_de_Justicia.Robo_de_Vehiculo
                        ,Fecha_del_Robo = (!String.IsNullOrEmpty(varDetalle_de_Delito_de_Justicia.Fecha_del_Robo)) ? DateTime.ParseExact(varDetalle_de_Delito_de_Justicia.Fecha_del_Robo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_del_Robo = varDetalle_de_Delito_de_Justicia.Hora_del_Robo
                        ,Robo_de = varDetalle_de_Delito_de_Justicia.Robo_de
                        ,Registro_Federal_Vehicular = varDetalle_de_Delito_de_Justicia.Registro_Federal_Vehicular
                        ,Numero_de_Registro_Publico_Vehicular = varDetalle_de_Delito_de_Justicia.Numero_de_Registro_Publico_Vehicular
                        ,Circunstancia_de_Robo_de_Vehiculo = varDetalle_de_Delito_de_Justicia.Circunstancia_de_Robo_de_Vehiculo
                        ,Marca = varDetalle_de_Delito_de_Justicia.Marca
                        ,Sub_Marca = varDetalle_de_Delito_de_Justicia.Sub_Marca
                        ,Tipo_de_vehiculo = varDetalle_de_Delito_de_Justicia.Tipo_de_vehiculo
                        ,Modelo = varDetalle_de_Delito_de_Justicia.Modelo
                        ,Color = varDetalle_de_Delito_de_Justicia.Color
                        ,Placas = varDetalle_de_Delito_de_Justicia.Placas
                        ,Estado_de_Origen_de_las_Placas = varDetalle_de_Delito_de_Justicia.Estado_de_Origen_de_las_Placas
                        ,Motor = varDetalle_de_Delito_de_Justicia.Motor
                        ,Serie = varDetalle_de_Delito_de_Justicia.Serie
                        ,Estado_De_Robo = varDetalle_de_Delito_de_Justicia.Estado_De_Robo
                        ,Municipio_de_Robo = varDetalle_de_Delito_de_Justicia.Municipio_de_Robo
                        ,Colonia_de_Robo = varDetalle_de_Delito_de_Justicia.Colonia_de_Robo
                        ,Codigo_Postal_de_Robo = varDetalle_de_Delito_de_Justicia.Codigo_Postal_de_Robo
                        ,Calle_de_Robo = varDetalle_de_Delito_de_Justicia.Calle_de_Robo
                        ,Entre_Calle_de_Robo = varDetalle_de_Delito_de_Justicia.Entre_Calle_de_Robo
                        ,Y_Calle_de_Robo = varDetalle_de_Delito_de_Justicia.Y_Calle_de_Robo
                        ,Numero_Exterior_de_Robo = varDetalle_de_Delito_de_Justicia.Numero_Exterior_de_Robo
                        ,Numero_Interior_de_Robo = varDetalle_de_Delito_de_Justicia.Numero_Interior_de_Robo
                        ,Referencia_de_Robo = varDetalle_de_Delito_de_Justicia.Referencia_de_Robo
                        ,Latitud_de_Robo = varDetalle_de_Delito_de_Justicia.Latitud_de_Robo
                        ,Longitud_de_Robo = varDetalle_de_Delito_de_Justicia.Longitud_de_Robo
                        ,Lugar_de_Robo = varDetalle_de_Delito_de_Justicia.Lugar_de_Robo
                        ,El_vehiculo_esta_asegurado = varDetalle_de_Delito_de_Justicia.El_vehiculo_esta_asegurado
                        ,Nombre_de_la_Aseguradora = varDetalle_de_Delito_de_Justicia.Nombre_de_la_Aseguradora
                        ,Ruta_del_Servicio_Publico = varDetalle_de_Delito_de_Justicia.Ruta_del_Servicio_Publico
                        ,El_Vehiculo_Transportaba_Mercancia = varDetalle_de_Delito_de_Justicia.El_Vehiculo_Transportaba_Mercancia
                        ,Descripcion_de_lo_que_Transportaba = varDetalle_de_Delito_de_Justicia.Descripcion_de_lo_que_Transportaba
                        ,Monto_de_carga = varDetalle_de_Delito_de_Justicia.Monto_de_carga
                        ,Senas_particulares = varDetalle_de_Delito_de_Justicia.Senas_particulares
                        ,Cuenta_con_GPS = varDetalle_de_Delito_de_Justicia.Cuenta_con_GPS
                        ,Tipo_de_Robo = varDetalle_de_Delito_de_Justicia.Tipo_de_Robo
                        ,Tipo_de_Lugar_del_Robo = varDetalle_de_Delito_de_Justicia.Tipo_de_Lugar_del_Robo
                        ,Tipo_de_Carretera = varDetalle_de_Delito_de_Justicia.Tipo_de_Carretera
                        ,Tipo_de_Servicio = varDetalle_de_Delito_de_Justicia.Tipo_de_Servicio
                        ,Numero_de_Serie = varDetalle_de_Delito_de_Justicia.Numero_de_Serie
                        ,Numero_de_Motor = varDetalle_de_Delito_de_Justicia.Numero_de_Motor
                        ,Persona_Moral = varDetalle_de_Delito_de_Justicia.Persona_Moral
                        ,Nombre_Completo_Persona_Moral = varDetalle_de_Delito_de_Justicia.Nombre_Completo_Persona_Moral
                        ,Persona_Fisica = varDetalle_de_Delito_de_Justicia.Persona_Fisica
                        ,Nombre_Completo_Persona_Fisica = varDetalle_de_Delito_de_Justicia.Nombre_Completo_Persona_Fisica
                        ,Denunciante = varDetalle_de_Delito_de_Justicia.Denunciante
                        ,Nombre_Completo_Denunciante = varDetalle_de_Delito_de_Justicia.Nombre_Completo_Denunciante

                    };

                    result = !IsNew ?
                        _IDetalle_de_Delito_de_JusticiaApiConsumer.Update(Detalle_de_Delito_de_JusticiaInfo, null, null).Resource.ToString() :
                         _IDetalle_de_Delito_de_JusticiaApiConsumer.Insert(Detalle_de_Delito_de_JusticiaInfo, null, null).Resource.ToString();
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
        public bool CopyAgravantes_del_Delito_MASC(int MasterId, int referenceId, List<Agravantes_del_Delito_MASCGridModelPost> Agravantes_del_Delito_MASCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _IAgravantes_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Agravantes_del_Delito_MASCData = _IAgravantes_del_Delito_MASCApiConsumer.ListaSelAll(1, int.MaxValue, "Agravantes_del_Delito_MASC.Folio_Agravante=" + referenceId,"").Resource;
                if (Agravantes_del_Delito_MASCData == null || Agravantes_del_Delito_MASCData.Agravantes_del_Delito_MASCs.Count == 0)
                    return true;

                var result = true;

                Agravantes_del_Delito_MASCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varAgravantes_del_Delito_MASC in Agravantes_del_Delito_MASCData.Agravantes_del_Delito_MASCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Agravantes_del_Delito_MASC Agravantes_del_Delito_MASC1 = varAgravantes_del_Delito_MASC;

                    if (Agravantes_del_Delito_MASCItems != null && Agravantes_del_Delito_MASCItems.Any(m => m.Clave == Agravantes_del_Delito_MASC1.Clave))
                    {
                        modelDataToChange = Agravantes_del_Delito_MASCItems.FirstOrDefault(m => m.Clave == Agravantes_del_Delito_MASC1.Clave);
                    }
                    //Chaning Id Value
                    varAgravantes_del_Delito_MASC.Folio_Agravante = MasterId;
                    var insertId = _IAgravantes_del_Delito_MASCApiConsumer.Insert(varAgravantes_del_Delito_MASC,null,null).Resource;
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
        public ActionResult PostAgravantes_del_Delito_MASC(List<Agravantes_del_Delito_MASCGridModelPost> Agravantes_del_Delito_MASCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyAgravantes_del_Delito_MASC(MasterId, referenceId, Agravantes_del_Delito_MASCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Agravantes_del_Delito_MASCItems != null && Agravantes_del_Delito_MASCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _IAgravantes_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Agravantes_del_Delito_MASCItem in Agravantes_del_Delito_MASCItems)
                    {



                        //Removal Request
                        if (Agravantes_del_Delito_MASCItem.Removed)
                        {
                            result = result && _IAgravantes_del_Delito_MASCApiConsumer.Delete(Agravantes_del_Delito_MASCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Agravantes_del_Delito_MASCItem.Clave = 0;

                        var Agravantes_del_Delito_MASCData = new Agravantes_del_Delito_MASC
                        {
                            Folio_Agravante = MasterId
                            ,Clave = Agravantes_del_Delito_MASCItem.Clave
                            ,Agravante = (Convert.ToInt32(Agravantes_del_Delito_MASCItem.Agravante) == 0 ? (Int32?)null : Convert.ToInt32(Agravantes_del_Delito_MASCItem.Agravante))

                        };

                        var resultId = Agravantes_del_Delito_MASCItem.Clave > 0
                           ? _IAgravantes_del_Delito_MASCApiConsumer.Update(Agravantes_del_Delito_MASCData,null,null).Resource
                           : _IAgravantes_del_Delito_MASCApiConsumer.Insert(Agravantes_del_Delito_MASCData,null,null).Resource;

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
        public ActionResult GetAgravantes_del_Delito_MASC_AgravantesAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IAgravantesApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IAgravantesApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Agravantes", "Descripcion");
                  item.Descripcion= trans??item.Descripcion;
                }
                return Json(result.ToArray(), JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
        }

        [NonAction]
        public bool CopyCircunstancias_del_Delito_MASC(int MasterId, int referenceId, List<Circunstancias_del_Delito_MASCGridModelPost> Circunstancias_del_Delito_MASCItems)
        {
            try
            {
                if (referenceId <= 0)
                    return true;

                if (!_tokenManager.GenerateToken())
                    return false;

                _ICircunstancias_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                var Circunstancias_del_Delito_MASCData = _ICircunstancias_del_Delito_MASCApiConsumer.ListaSelAll(1, int.MaxValue, "Circunstancias_del_Delito_MASC.Folio_Circunstancial=" + referenceId,"").Resource;
                if (Circunstancias_del_Delito_MASCData == null || Circunstancias_del_Delito_MASCData.Circunstancias_del_Delito_MASCs.Count == 0)
                    return true;

                var result = true;

                Circunstancias_del_Delito_MASCGridModelPost modelDataToChange = null;
                //var insertId = 0;
                foreach (var varCircunstancias_del_Delito_MASC in Circunstancias_del_Delito_MASCData.Circunstancias_del_Delito_MASCs)
                {
                    if (!result)
                        return result;

                    //Initialization
                    //insertId = 0;
                    modelDataToChange = null;
                    Circunstancias_del_Delito_MASC Circunstancias_del_Delito_MASC1 = varCircunstancias_del_Delito_MASC;

                    if (Circunstancias_del_Delito_MASCItems != null && Circunstancias_del_Delito_MASCItems.Any(m => m.Clave == Circunstancias_del_Delito_MASC1.Clave))
                    {
                        modelDataToChange = Circunstancias_del_Delito_MASCItems.FirstOrDefault(m => m.Clave == Circunstancias_del_Delito_MASC1.Clave);
                    }
                    //Chaning Id Value
                    varCircunstancias_del_Delito_MASC.Folio_Circunstancial = MasterId;
                    var insertId = _ICircunstancias_del_Delito_MASCApiConsumer.Insert(varCircunstancias_del_Delito_MASC,null,null).Resource;
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
        public ActionResult PostCircunstancias_del_Delito_MASC(List<Circunstancias_del_Delito_MASCGridModelPost> Circunstancias_del_Delito_MASCItems, int MasterId, string referenceId)
        {
            try
            {
                bool result = true;

                //if (referenceId > 0 && MasterId != referenceId)
                //    if (!CopyCircunstancias_del_Delito_MASC(MasterId, referenceId, Circunstancias_del_Delito_MASCItems))
                //        return Json(false, JsonRequestBehavior.AllowGet);

                if (Circunstancias_del_Delito_MASCItems != null && Circunstancias_del_Delito_MASCItems.Count > 0)
                {
                    //Generating token
                    if (!_tokenManager.GenerateToken())
                        return Json(null, JsonRequestBehavior.AllowGet);

                    _ISpartane_FileApiConsumer.SetAuthHeader(_tokenManager.Token);
                    _ICircunstancias_del_Delito_MASCApiConsumer.SetAuthHeader(_tokenManager.Token);

                    foreach (var Circunstancias_del_Delito_MASCItem in Circunstancias_del_Delito_MASCItems)
                    {



                        //Removal Request
                        if (Circunstancias_del_Delito_MASCItem.Removed)
                        {
                            result = result && _ICircunstancias_del_Delito_MASCApiConsumer.Delete(Circunstancias_del_Delito_MASCItem.Clave, null,null).Resource;
                            continue;
                        }
						if (referenceId.ToString() != MasterId.ToString())
							Circunstancias_del_Delito_MASCItem.Clave = 0;

                        var Circunstancias_del_Delito_MASCData = new Circunstancias_del_Delito_MASC
                        {
                            Folio_Circunstancial = MasterId
                            ,Clave = Circunstancias_del_Delito_MASCItem.Clave
                            ,Tipo_de_Lugar = (Convert.ToInt32(Circunstancias_del_Delito_MASCItem.Tipo_de_Lugar) == 0 ? (Int32?)null : Convert.ToInt32(Circunstancias_del_Delito_MASCItem.Tipo_de_Lugar))

                        };

                        var resultId = Circunstancias_del_Delito_MASCItem.Clave > 0
                           ? _ICircunstancias_del_Delito_MASCApiConsumer.Update(Circunstancias_del_Delito_MASCData,null,null).Resource
                           : _ICircunstancias_del_Delito_MASCApiConsumer.Insert(Circunstancias_del_Delito_MASCData,null,null).Resource;

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
        public ActionResult GetCircunstancias_del_Delito_MASC_CircunstanciasAll()
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _ICircunstanciasApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _ICircunstanciasApiConsumer.SelAll(false).Resource;
                foreach (var item in result)
                {
				  var trans = CultureHelper.GetTraduction(Convert.ToString(item.Clave), "Circunstancias", "Descripcion");
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
        /// Write Element Array of Detalle_de_Delito_de_Justicia script
        /// </summary>
        /// <param name="oDetalle_de_Delito_de_JusticiaElements"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult WriteScriptSettings(CustomElementsNew Detalle_de_Delito_de_JusticiaModuleAttributeList)
        {
            for (int i = 0; i < Detalle_de_Delito_de_JusticiaModuleAttributeList.CustomModuleAttributeList.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(Detalle_de_Delito_de_JusticiaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue))
                {
                    Detalle_de_Delito_de_JusticiaModuleAttributeList.CustomModuleAttributeList[i].DefaultValue = string.Empty;
                }
                if (string.IsNullOrEmpty(Detalle_de_Delito_de_JusticiaModuleAttributeList.CustomModuleAttributeList[i].HelpText))
                {
                    Detalle_de_Delito_de_JusticiaModuleAttributeList.CustomModuleAttributeList[i].HelpText = string.Empty;
                }
            }
			if (Detalle_de_Delito_de_JusticiaModuleAttributeList.ChildModuleAttributeList != null)
            {
				for (int i = 0; i < Detalle_de_Delito_de_JusticiaModuleAttributeList.ChildModuleAttributeList.Count - 1; i++)
				{
					for (int j = 0; j < Detalle_de_Delito_de_JusticiaModuleAttributeList.ChildModuleAttributeList[i].elements.Count; j++)
					{
						if (string.IsNullOrEmpty(Detalle_de_Delito_de_JusticiaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue))
						{
							Detalle_de_Delito_de_JusticiaModuleAttributeList.ChildModuleAttributeList[i].elements[j].DefaultValue = string.Empty;
						}
						if (string.IsNullOrEmpty(Detalle_de_Delito_de_JusticiaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText))
						{
							Detalle_de_Delito_de_JusticiaModuleAttributeList.ChildModuleAttributeList[i].elements[j].HelpText = string.Empty;
						}
					}
				}
			}
            string strDetalle_de_Delito_de_JusticiaScript = string.Empty;
            using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Delito_de_Justicia.js")))
            {
                strDetalle_de_Delito_de_JusticiaScript = r.ReadToEnd();
            }

            JavaScriptSerializer jsSerialize = new JavaScriptSerializer();

            // get json string of change Detalle_de_Delito_de_Justicia element attributes
            string userChangeJson = jsSerialize.Serialize(Detalle_de_Delito_de_JusticiaModuleAttributeList.CustomModuleAttributeList);

            int indexOfArray = strDetalle_de_Delito_de_JusticiaScript.IndexOf("inpuElementArray");
            string splittedString = strDetalle_de_Delito_de_JusticiaScript.Substring(indexOfArray, strDetalle_de_Delito_de_JusticiaScript.Length - indexOfArray);
            int indexOfMainElement = splittedString.IndexOf('[');
            int endIndexOfMainElement = splittedString.IndexOf(']') + 1;

            // get json string of change job history element attributes
            string childUserChangeJson = jsSerialize.Serialize(Detalle_de_Delito_de_JusticiaModuleAttributeList.ChildModuleAttributeList);
			int indexOfArrayHistory = 0;
            string splittedStringHistory = "";
            int indexOfMainElementHistory = 0;
            int endIndexOfMainElementHistory = 0;
			if (Detalle_de_Delito_de_JusticiaModuleAttributeList.ChildModuleAttributeList != null)
            {
				indexOfArrayHistory = strDetalle_de_Delito_de_JusticiaScript.IndexOf("});");
				if(indexOfArrayHistory != -1)
				{
					splittedStringHistory = strDetalle_de_Delito_de_JusticiaScript.Substring(indexOfArrayHistory, strDetalle_de_Delito_de_JusticiaScript.Length - indexOfArrayHistory);
					indexOfMainElementHistory = splittedStringHistory.IndexOf('[');
					endIndexOfMainElementHistory = splittedStringHistory.IndexOf(']') + 1;
				}
			}
			string finalResponse = strDetalle_de_Delito_de_JusticiaScript.Substring(0, indexOfArray + indexOfMainElement) + userChangeJson + strDetalle_de_Delito_de_JusticiaScript.Substring(endIndexOfMainElement + indexOfArray, strDetalle_de_Delito_de_JusticiaScript.Length - (endIndexOfMainElement + indexOfArray));
           
		   var ResponseChild = string.Empty;
            if (Detalle_de_Delito_de_JusticiaModuleAttributeList.ChildModuleAttributeList != null && indexOfArrayHistory != -1)
            {
                foreach (var item in Detalle_de_Delito_de_JusticiaModuleAttributeList.ChildModuleAttributeList)
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
          

            using (StreamWriter w = new StreamWriter(Server.MapPath("~/Uploads/Scripts/Detalle_de_Delito_de_Justicia.js")))
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

            if (System.IO.File.Exists(Server.MapPath("~/Uploads/Scripts/Detalle_de_Delito_de_Justicia.js")))
            {
                using (StreamReader r = new StreamReader(Server.MapPath("~/Uploads/Scripts/Detalle_de_Delito_de_Justicia.js")))
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
        public ActionResult Detalle_de_Delito_de_JusticiaPropertyBag()
        {
            return PartialView("Detalle_de_Delito_de_JusticiaPropertyBag", "Detalle_de_Delito_de_Justicia");
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
        public ActionResult AddAgravantes_del_Delito_MASC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Agravantes_del_Delito_MASC/AddAgravantes_del_Delito_MASC");
        }

        [HttpGet]
        public ActionResult AddCircunstancias_del_Delito_MASC(int rowIndex = 0, int functionMode = 0)
        {
            ViewBag.currentRowIndex = rowIndex;
            ViewBag.functionMode = functionMode;
            return PartialView("../Circunstancias_del_Delito_MASC/AddCircunstancias_del_Delito_MASC");
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
                var whereClauseFormat = "Object = 45093 AND FormatId in (" + formats + ")";
                var Spartan_Formats = _ISpartan_FormatApiConsumer.ListaSelAll(0, 1000, whereClauseFormat, string.Empty);


                if (Spartan_Formats != null && Spartan_Formats.Resource != null && Spartan_Formats.Resource.Spartan_Formats != null)
                {
                    _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                    foreach (Spartan_Format format in Spartan_Formats.Resource.Spartan_Formats)
                    {

                        if (format.Filter != null && format.Filter.Trim() != string.Empty)
                        {
                            var where = Helper.ReplaceGlobal(format.Filter).Trim() + " And Detalle_de_Delito_de_Justicia.Clave= " + RecordId;
                            var result = _IDetalle_de_Delito_de_JusticiaApiConsumer.ListaSelAll(0, 1000, where, string.Empty);
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

            _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;
            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Delito_de_JusticiaPropertyMapper());
			
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
                    (Detalle_de_Delito_de_JusticiaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }
			string sortDirection = "asc";

            Detalle_de_Delito_de_JusticiaPropertyMapper oDetalle_de_Delito_de_JusticiaPropertyMapper = new Detalle_de_Delito_de_JusticiaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Delito_de_JusticiaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Delito_de_JusticiaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Delito_de_Justicias == null)
                result.Detalle_de_Delito_de_Justicias = new List<Detalle_de_Delito_de_Justicia>();

            var data = result.Detalle_de_Delito_de_Justicias.Select(m => new Detalle_de_Delito_de_JusticiaGridModel
            {
                Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,Fecha_de_Delito = (m.Fecha_de_Delito == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Delito).ToString(ConfigurationProperty.DateFormat))
			,Violencia_de_Genero = m.Violencia_de_Genero
                        ,Delito_Violencia_GeneroDescripcion = CultureHelper.GetTraduction(m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Clave.ToString(), "Delitos_Violencia_Genero") ?? (string)m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Descripcion
			,Hora_de_Delito = m.Hora_de_Delito
                        ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_de_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_de_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
			,Delito_Principal = m.Delito_Principal
                        ,Forma_de_Comision_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Comision_de_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Comision_de_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_de_Accion_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Accion_de_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Accion_de_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_de_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_de_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_de_Comision_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_de_Comision_de_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_de_Comision_de_Delito_Elementos_Comision_Delito.Descripcion
                        ,Clasificacion_con_Orden_de_ResultadoDescripcion = CultureHelper.GetTraduction(m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Clave.ToString(), "Descripcion") ?? (string)m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Descripcion
                        ,ConcursoDescripcion = CultureHelper.GetTraduction(m.Concurso_Concurso.Clave.ToString(), "Descripcion") ?? (string)m.Concurso_Concurso.Descripcion
			,Monto_de_Reparacion_de_Danos = m.Monto_de_Reparacion_de_Danos
                        ,Estado_del_DelitoNombre = CultureHelper.GetTraduction(m.Estado_del_Delito_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Delito_Estado.Nombre
                        ,Municipio_del_DelitoNombre = CultureHelper.GetTraduction(m.Municipio_del_Delito_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Delito_Municipio.Nombre
                        ,Colonia_del_DelitoNombre = CultureHelper.GetTraduction(m.Colonia_del_Delito_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Delito_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle_del_Delito = m.Calle_del_Delito
			,Entre_Calle_del_Delito = m.Entre_Calle_del_Delito
			,Y_Calle_del_Delito = m.Y_Calle_del_Delito
			,Numero_Exterior_del_Delito = m.Numero_Exterior_del_Delito
			,Numero_Interior_del_Delito = m.Numero_Interior_del_Delito
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                        ,Fecha_del_Robo = (m.Fecha_del_Robo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Robo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Robo = m.Hora_del_Robo
                        ,Robo_deDescripcion = CultureHelper.GetTraduction(m.Robo_de_Elemento_Robado.Clave.ToString(), "Descripcion") ?? (string)m.Robo_de_Elemento_Robado.Descripcion
			,Registro_Federal_Vehicular = m.Registro_Federal_Vehicular
			,Numero_de_Registro_Publico_Vehicular = m.Numero_de_Registro_Publico_Vehicular
                        ,Circunstancia_de_Robo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_de_Robo_de_Vehiculo_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_de_Robo_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Marca_del_Vehiculo") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Sub_Marca_del_Vehiculo") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_vehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(m.Estado_de_Origen_de_las_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
			,Motor = m.Motor
			,Serie = m.Serie
                        ,Estado_De_RoboNombre = CultureHelper.GetTraduction(m.Estado_De_Robo_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_De_Robo_Estado.Nombre
                        ,Municipio_de_RoboNombre = CultureHelper.GetTraduction(m.Municipio_de_Robo_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Robo_Municipio.Nombre
                        ,Colonia_de_RoboNombre = CultureHelper.GetTraduction(m.Colonia_de_Robo_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_Robo_Colonia.Nombre
			,Codigo_Postal_de_Robo = m.Codigo_Postal_de_Robo
			,Calle_de_Robo = m.Calle_de_Robo
			,Entre_Calle_de_Robo = m.Entre_Calle_de_Robo
			,Y_Calle_de_Robo = m.Y_Calle_de_Robo
			,Numero_Exterior_de_Robo = m.Numero_Exterior_de_Robo
			,Numero_Interior_de_Robo = m.Numero_Interior_de_Robo
			,Referencia_de_Robo = m.Referencia_de_Robo
			,Latitud_de_Robo = m.Latitud_de_Robo
			,Longitud_de_Robo = m.Longitud_de_Robo
                        ,Lugar_de_RoboDescripcion = CultureHelper.GetTraduction(m.Lugar_de_Robo_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_Robo_Lugar_del_Robo.Descripcion
			,El_vehiculo_esta_asegurado = m.El_vehiculo_esta_asegurado
                        ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Aseguradora_de_Vehiculo") ?? (string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
			,El_Vehiculo_Transportaba_Mercancia = m.El_Vehiculo_Transportaba_Mercancia
			,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
			,Monto_de_carga = m.Monto_de_carga
			,Senas_particulares = m.Senas_particulares
                        ,Cuenta_con_GPSDescripcion = CultureHelper.GetTraduction(m.Cuenta_con_GPS_Binario.Clave.ToString(), "Descripcion") ?? (string)m.Cuenta_con_GPS_Binario.Descripcion
                        ,Tipo_de_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Robo_Tipo_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Robo_Tipo_de_Robo.Descripcion
                        ,Tipo_de_Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Tipo_de_CarreteraDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Carretera_Tipo_de_Carretera.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Carretera_Tipo_de_Carretera.Descripcion
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Numero_de_Serie = m.Numero_de_Serie
			,Numero_de_Motor = m.Numero_de_Motor
			,Persona_Moral = m.Persona_Moral
                        ,Nombre_Completo_Persona_MoralNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Persona_Moral_Detalle_de_Persona_Moral_JA.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Persona_Moral_Detalle_de_Persona_Moral_JA.Nombre
			,Persona_Fisica = m.Persona_Fisica
                        ,Nombre_Completo_Persona_FisicaNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante.Clave.ToString(), "Detalle_de_Solicitud_Solicitante") ?? (string)m.Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante.Nombre
			,Denunciante = m.Denunciante
                        ,Nombre_Completo_DenuncianteNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Denunciante_Detalle_de_Solicitud_Solicitante.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Denunciante_Detalle_de_Solicitud_Solicitante.Nombre

            }).ToList();

            switch (exportFormatType)
            {
                case ExportFormatType.PDF:
                    PdfConverter.ExportToPdf(data.ToDataTable(45093, arrayColumnsVisible), "Detalle_de_Delito_de_JusticiaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.EXCEL:
                    ExcelConverter.ExportToExcel(data.ToDataTable(45093, arrayColumnsVisible), "Detalle_de_Delito_de_JusticiaList_" + DateTime.Now.ToString());
                    break;

                case ExportFormatType.CSV:
                    CsvConverter.ExportToCSV(data.ToDataTable(45093, arrayColumnsVisible), "Detalle_de_Delito_de_JusticiaList_" + DateTime.Now.ToString());
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

            _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);

            NameValueCollection filter = Request.QueryString;

            var configuration = new GridConfiguration() { OrderByClause = "", WhereClause = "" };
            if (filter != null)
                configuration = GridQueryHelper.GetDataTableConfiguration(filter, new Detalle_de_Delito_de_JusticiaPropertyMapper());
				
				
            if (!String.IsNullOrEmpty(where))
            {
                configuration.WhereClause = configuration.WhereClause == "" ? where : "(" + configuration.WhereClause + " AND " + where + ")";
            }
			if (Session["AdvanceSearch"] != null && pageSize != 0)
            {
                var advanceFilter =
                    (Detalle_de_Delito_de_JusticiaAdvanceSearchModel)Session["AdvanceSearch"];
                configuration.WhereClause = configuration.WhereClause == "" ? GetAdvanceFilter(advanceFilter) : configuration.WhereClause + " AND " + GetAdvanceFilter(advanceFilter);
            }

            string sortDirection = "asc";

            Detalle_de_Delito_de_JusticiaPropertyMapper oDetalle_de_Delito_de_JusticiaPropertyMapper = new Detalle_de_Delito_de_JusticiaPropertyMapper();
            if (Request.QueryString["sSortDir"] != null)
            {
                sortDirection = Request.QueryString["sSortDir"];
            }
            configuration.OrderByClause =  oDetalle_de_Delito_de_JusticiaPropertyMapper.GetPropertyName(iSortCol)  + " " + sortDirection;
			
			if (!String.IsNullOrEmpty(order))
            {
                configuration.OrderByClause = order;
            }
            pageSize = pageSize == 0 ? int.MaxValue : pageSize;

            var result = _IDetalle_de_Delito_de_JusticiaApiConsumer.ListaSelAll((pageIndex * pageSize) - pageSize + 1, pageSize + ((pageIndex * pageSize) - pageSize), configuration.WhereClause, configuration.OrderByClause ?? "").Resource;
            if (result.Detalle_de_Delito_de_Justicias == null)
                result.Detalle_de_Delito_de_Justicias = new List<Detalle_de_Delito_de_Justicia>();

            var data = result.Detalle_de_Delito_de_Justicias.Select(m => new Detalle_de_Delito_de_JusticiaGridModel
            {
                Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,Fecha_de_Delito = (m.Fecha_de_Delito == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Delito).ToString(ConfigurationProperty.DateFormat))
			,Violencia_de_Genero = m.Violencia_de_Genero
                        ,Delito_Violencia_GeneroDescripcion = CultureHelper.GetTraduction(m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Clave.ToString(), "Delitos_Violencia_Genero") ?? (string)m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Descripcion
			,Hora_de_Delito = m.Hora_de_Delito
                        ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_de_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_de_Delito_Grupo_del_Delito.Descripcion
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
			,Delito_Principal = m.Delito_Principal
                        ,Forma_de_Comision_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Comision_de_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Comision_de_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_de_Accion_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Accion_de_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Accion_de_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_de_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_de_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_de_Comision_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_de_Comision_de_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_de_Comision_de_Delito_Elementos_Comision_Delito.Descripcion
                        ,Clasificacion_con_Orden_de_ResultadoDescripcion = CultureHelper.GetTraduction(m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Clave.ToString(), "Descripcion") ?? (string)m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Descripcion
                        ,ConcursoDescripcion = CultureHelper.GetTraduction(m.Concurso_Concurso.Clave.ToString(), "Descripcion") ?? (string)m.Concurso_Concurso.Descripcion
			,Monto_de_Reparacion_de_Danos = m.Monto_de_Reparacion_de_Danos
                        ,Estado_del_DelitoNombre = CultureHelper.GetTraduction(m.Estado_del_Delito_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Delito_Estado.Nombre
                        ,Municipio_del_DelitoNombre = CultureHelper.GetTraduction(m.Municipio_del_Delito_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Delito_Municipio.Nombre
                        ,Colonia_del_DelitoNombre = CultureHelper.GetTraduction(m.Colonia_del_Delito_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Delito_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle_del_Delito = m.Calle_del_Delito
			,Entre_Calle_del_Delito = m.Entre_Calle_del_Delito
			,Y_Calle_del_Delito = m.Y_Calle_del_Delito
			,Numero_Exterior_del_Delito = m.Numero_Exterior_del_Delito
			,Numero_Interior_del_Delito = m.Numero_Interior_del_Delito
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo
                        ,Fecha_del_Robo = (m.Fecha_del_Robo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Robo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Robo = m.Hora_del_Robo
                        ,Robo_deDescripcion = CultureHelper.GetTraduction(m.Robo_de_Elemento_Robado.Clave.ToString(), "Descripcion") ?? (string)m.Robo_de_Elemento_Robado.Descripcion
			,Registro_Federal_Vehicular = m.Registro_Federal_Vehicular
			,Numero_de_Registro_Publico_Vehicular = m.Numero_de_Registro_Publico_Vehicular
                        ,Circunstancia_de_Robo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_de_Robo_de_Vehiculo_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_de_Robo_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Marca_del_Vehiculo") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Sub_Marca_del_Vehiculo") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_vehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(m.Estado_de_Origen_de_las_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
			,Motor = m.Motor
			,Serie = m.Serie
                        ,Estado_De_RoboNombre = CultureHelper.GetTraduction(m.Estado_De_Robo_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_De_Robo_Estado.Nombre
                        ,Municipio_de_RoboNombre = CultureHelper.GetTraduction(m.Municipio_de_Robo_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Robo_Municipio.Nombre
                        ,Colonia_de_RoboNombre = CultureHelper.GetTraduction(m.Colonia_de_Robo_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_Robo_Colonia.Nombre
			,Codigo_Postal_de_Robo = m.Codigo_Postal_de_Robo
			,Calle_de_Robo = m.Calle_de_Robo
			,Entre_Calle_de_Robo = m.Entre_Calle_de_Robo
			,Y_Calle_de_Robo = m.Y_Calle_de_Robo
			,Numero_Exterior_de_Robo = m.Numero_Exterior_de_Robo
			,Numero_Interior_de_Robo = m.Numero_Interior_de_Robo
			,Referencia_de_Robo = m.Referencia_de_Robo
			,Latitud_de_Robo = m.Latitud_de_Robo
			,Longitud_de_Robo = m.Longitud_de_Robo
                        ,Lugar_de_RoboDescripcion = CultureHelper.GetTraduction(m.Lugar_de_Robo_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_Robo_Lugar_del_Robo.Descripcion
			,El_vehiculo_esta_asegurado = m.El_vehiculo_esta_asegurado
                        ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Aseguradora_de_Vehiculo") ?? (string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
			,El_Vehiculo_Transportaba_Mercancia = m.El_Vehiculo_Transportaba_Mercancia
			,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
			,Monto_de_carga = m.Monto_de_carga
			,Senas_particulares = m.Senas_particulares
                        ,Cuenta_con_GPSDescripcion = CultureHelper.GetTraduction(m.Cuenta_con_GPS_Binario.Clave.ToString(), "Descripcion") ?? (string)m.Cuenta_con_GPS_Binario.Descripcion
                        ,Tipo_de_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Robo_Tipo_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Robo_Tipo_de_Robo.Descripcion
                        ,Tipo_de_Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Tipo_de_CarreteraDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Carretera_Tipo_de_Carretera.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Carretera_Tipo_de_Carretera.Descripcion
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Numero_de_Serie = m.Numero_de_Serie
			,Numero_de_Motor = m.Numero_de_Motor
			,Persona_Moral = m.Persona_Moral
                        ,Nombre_Completo_Persona_MoralNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Persona_Moral_Detalle_de_Persona_Moral_JA.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Persona_Moral_Detalle_de_Persona_Moral_JA.Nombre
			,Persona_Fisica = m.Persona_Fisica
                        ,Nombre_Completo_Persona_FisicaNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante.Clave.ToString(), "Detalle_de_Solicitud_Solicitante") ?? (string)m.Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante.Nombre
			,Denunciante = m.Denunciante
                        ,Nombre_Completo_DenuncianteNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Denunciante_Detalle_de_Solicitud_Solicitante.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Denunciante_Detalle_de_Solicitud_Solicitante.Nombre

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
                _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var result = _IDetalle_de_Delito_de_JusticiaApiConsumer.GenerateID().Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpPost]
        public ActionResult Post_Datos_Generales(Detalle_de_Delito_de_Justicia_Datos_GeneralesModel varDetalle_de_Delito_de_Justicia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Delito_de_Justicia_Datos_GeneralesInfo = new Detalle_de_Delito_de_Justicia_Datos_Generales
                {
                    Clave = varDetalle_de_Delito_de_Justicia.Clave
                                            ,idRegistroAT = varDetalle_de_Delito_de_Justicia.idRegistroAT
                        ,idRegistroUI = varDetalle_de_Delito_de_Justicia.idRegistroUI
                        ,Solicitud = varDetalle_de_Delito_de_Justicia.Solicitud
                        ,Tipo_de_Denuncia = varDetalle_de_Delito_de_Justicia.Tipo_de_Denuncia
                        ,Fecha_de_Delito = (!String.IsNullOrEmpty(varDetalle_de_Delito_de_Justicia.Fecha_de_Delito)) ? DateTime.ParseExact(varDetalle_de_Delito_de_Justicia.Fecha_de_Delito, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Violencia_de_Genero = varDetalle_de_Delito_de_Justicia.Violencia_de_Genero
                        ,Delito_Violencia_Genero = varDetalle_de_Delito_de_Justicia.Delito_Violencia_Genero
                        ,Hora_de_Delito = varDetalle_de_Delito_de_Justicia.Hora_de_Delito
                        ,Tipo_de_Delito = varDetalle_de_Delito_de_Justicia.Tipo_de_Delito
                        ,Grupo_de_Delito = varDetalle_de_Delito_de_Justicia.Grupo_de_Delito
                        ,Delito = varDetalle_de_Delito_de_Justicia.Delito
                        ,Delito_Principal = varDetalle_de_Delito_de_Justicia.Delito_Principal
                        ,Forma_de_Comision_de_Delito = varDetalle_de_Delito_de_Justicia.Forma_de_Comision_de_Delito
                        ,Forma_de_Accion_de_Delito = varDetalle_de_Delito_de_Justicia.Forma_de_Accion_de_Delito
                        ,Modalidad_de_Delito = varDetalle_de_Delito_de_Justicia.Modalidad_de_Delito
                        ,Elementos_de_Comision_de_Delito = varDetalle_de_Delito_de_Justicia.Elementos_de_Comision_de_Delito
                        ,Clasificacion_con_Orden_de_Resultado = varDetalle_de_Delito_de_Justicia.Clasificacion_con_Orden_de_Resultado
                        ,Concurso = varDetalle_de_Delito_de_Justicia.Concurso
                        ,Monto_de_Reparacion_de_Danos = varDetalle_de_Delito_de_Justicia.Monto_de_Reparacion_de_Danos
                        ,Estado_del_Delito = varDetalle_de_Delito_de_Justicia.Estado_del_Delito
                        ,Municipio_del_Delito = varDetalle_de_Delito_de_Justicia.Municipio_del_Delito
                        ,Colonia_del_Delito = varDetalle_de_Delito_de_Justicia.Colonia_del_Delito
                        ,Codigo_Postal = varDetalle_de_Delito_de_Justicia.Codigo_Postal
                        ,Calle_del_Delito = varDetalle_de_Delito_de_Justicia.Calle_del_Delito
                        ,Entre_Calle_del_Delito = varDetalle_de_Delito_de_Justicia.Entre_Calle_del_Delito
                        ,Y_Calle_del_Delito = varDetalle_de_Delito_de_Justicia.Y_Calle_del_Delito
                        ,Numero_Exterior_del_Delito = varDetalle_de_Delito_de_Justicia.Numero_Exterior_del_Delito
                        ,Numero_Interior_del_Delito = varDetalle_de_Delito_de_Justicia.Numero_Interior_del_Delito
                        ,Referencia = varDetalle_de_Delito_de_Justicia.Referencia
                        ,Latitud = varDetalle_de_Delito_de_Justicia.Latitud
                        ,Longitud = varDetalle_de_Delito_de_Justicia.Longitud
                        ,Robo_de_Vehiculo = varDetalle_de_Delito_de_Justicia.Robo_de_Vehiculo
                    
                };

                result = _IDetalle_de_Delito_de_JusticiaApiConsumer.Update_Datos_Generales(Detalle_de_Delito_de_Justicia_Datos_GeneralesInfo).Resource.ToString();
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
                _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Delito_de_JusticiaApiConsumer.Get_Datos_Generales(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Agravantes_del_Delito_MASC;
                var Agravantes_del_Delito_MASCData = GetAgravantes_del_Delito_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Agravantes_del_Delito_MASC);
                int RowCount_Circunstancias_del_Delito_MASC;
                var Circunstancias_del_Delito_MASCData = GetCircunstancias_del_Delito_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Circunstancias_del_Delito_MASC);

                var result = new Detalle_de_Delito_de_Justicia_Datos_GeneralesModel
                {
                    Clave = m.Clave
			,idRegistroAT = m.idRegistroAT
			,idRegistroUI = m.idRegistroUI
                        ,Solicitud = m.Solicitud
                        ,SolicitudNumero_de_Folio = CultureHelper.GetTraduction(m.Solicitud_Solicitud.Clave.ToString(), "Solicitud") ?? (string)m.Solicitud_Solicitud.Numero_de_Folio
                        ,Tipo_de_Denuncia = m.Tipo_de_Denuncia
                        ,Tipo_de_DenunciaDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Denuncia_Tipo_de_Denuncia.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Denuncia_Tipo_de_Denuncia.Descripcion
                        ,Fecha_de_Delito = (m.Fecha_de_Delito == null ? string.Empty : Convert.ToDateTime(m.Fecha_de_Delito).ToString(ConfigurationProperty.DateFormat))
			,Violencia_de_Genero = m.Violencia_de_Genero
                        ,Delito_Violencia_Genero = m.Delito_Violencia_Genero
                        ,Delito_Violencia_GeneroDescripcion = CultureHelper.GetTraduction(m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Clave.ToString(), "Delitos_Violencia_Genero") ?? (string)m.Delito_Violencia_Genero_Delitos_Violencia_Genero.Descripcion
			,Hora_de_Delito = m.Hora_de_Delito
                        ,Tipo_de_Delito = m.Tipo_de_Delito
                        ,Tipo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Delito_Titulo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Delito_Titulo_del_Delito.Descripcion
                        ,Grupo_de_Delito = m.Grupo_de_Delito
                        ,Grupo_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Grupo_de_Delito_Grupo_del_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Grupo_de_Delito_Grupo_del_Delito.Descripcion
                        ,Delito = m.Delito
                        ,DelitoDescripcion = CultureHelper.GetTraduction(m.Delito_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Delito_Delito.Descripcion
			,Delito_Principal = m.Delito_Principal
                        ,Forma_de_Comision_de_Delito = m.Forma_de_Comision_de_Delito
                        ,Forma_de_Comision_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Comision_de_Delito_Forma_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Comision_de_Delito_Forma_Comision_Delito.Descripcion
                        ,Forma_de_Accion_de_Delito = m.Forma_de_Accion_de_Delito
                        ,Forma_de_Accion_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Forma_de_Accion_de_Delito_Forma_Accion_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Forma_de_Accion_de_Delito_Forma_Accion_Delito.Descripcion
                        ,Modalidad_de_Delito = m.Modalidad_de_Delito
                        ,Modalidad_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Modalidad_de_Delito_Modalidad_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Modalidad_de_Delito_Modalidad_Delito.Descripcion
                        ,Elementos_de_Comision_de_Delito = m.Elementos_de_Comision_de_Delito
                        ,Elementos_de_Comision_de_DelitoDescripcion = CultureHelper.GetTraduction(m.Elementos_de_Comision_de_Delito_Elementos_Comision_Delito.Clave.ToString(), "Descripcion") ?? (string)m.Elementos_de_Comision_de_Delito_Elementos_Comision_Delito.Descripcion
                        ,Clasificacion_con_Orden_de_Resultado = m.Clasificacion_con_Orden_de_Resultado
                        ,Clasificacion_con_Orden_de_ResultadoDescripcion = CultureHelper.GetTraduction(m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Clave.ToString(), "Descripcion") ?? (string)m.Clasificacion_con_Orden_de_Resultado_Clasificacion_en_Orden_de_Resultado.Descripcion
                        ,Concurso = m.Concurso
                        ,ConcursoDescripcion = CultureHelper.GetTraduction(m.Concurso_Concurso.Clave.ToString(), "Descripcion") ?? (string)m.Concurso_Concurso.Descripcion
			,Monto_de_Reparacion_de_Danos = m.Monto_de_Reparacion_de_Danos
                        ,Estado_del_Delito = m.Estado_del_Delito
                        ,Estado_del_DelitoNombre = CultureHelper.GetTraduction(m.Estado_del_Delito_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_del_Delito_Estado.Nombre
                        ,Municipio_del_Delito = m.Municipio_del_Delito
                        ,Municipio_del_DelitoNombre = CultureHelper.GetTraduction(m.Municipio_del_Delito_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_del_Delito_Municipio.Nombre
                        ,Colonia_del_Delito = m.Colonia_del_Delito
                        ,Colonia_del_DelitoNombre = CultureHelper.GetTraduction(m.Colonia_del_Delito_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_del_Delito_Colonia.Nombre
			,Codigo_Postal = m.Codigo_Postal
			,Calle_del_Delito = m.Calle_del_Delito
			,Entre_Calle_del_Delito = m.Entre_Calle_del_Delito
			,Y_Calle_del_Delito = m.Y_Calle_del_Delito
			,Numero_Exterior_del_Delito = m.Numero_Exterior_del_Delito
			,Numero_Interior_del_Delito = m.Numero_Interior_del_Delito
			,Referencia = m.Referencia
			,Latitud = m.Latitud
			,Longitud = m.Longitud
			,Robo_de_Vehiculo = m.Robo_de_Vehiculo

                    
                };
				var resultData = new
                {
                    data = result
                    ,Agravantes_y_o_Calificativas = Agravantes_del_Delito_MASCData
                    ,Circunstancias_Delito = Circunstancias_del_Delito_MASCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Datos_de_Robo_de_Vehiculo(Detalle_de_Delito_de_Justicia_Datos_de_Robo_de_VehiculoModel varDetalle_de_Delito_de_Justicia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Delito_de_Justicia_Datos_de_Robo_de_VehiculoInfo = new Detalle_de_Delito_de_Justicia_Datos_de_Robo_de_Vehiculo
                {
                    Clave = varDetalle_de_Delito_de_Justicia.Clave
                                            ,Fecha_del_Robo = (!String.IsNullOrEmpty(varDetalle_de_Delito_de_Justicia.Fecha_del_Robo)) ? DateTime.ParseExact(varDetalle_de_Delito_de_Justicia.Fecha_del_Robo, ConfigurationProperty.DateFormat, CultureInfo.InvariantCulture as IFormatProvider) : (DateTime?)null
                        ,Hora_del_Robo = varDetalle_de_Delito_de_Justicia.Hora_del_Robo
                        ,Robo_de = varDetalle_de_Delito_de_Justicia.Robo_de
                        ,Registro_Federal_Vehicular = varDetalle_de_Delito_de_Justicia.Registro_Federal_Vehicular
                        ,Numero_de_Registro_Publico_Vehicular = varDetalle_de_Delito_de_Justicia.Numero_de_Registro_Publico_Vehicular
                        ,Circunstancia_de_Robo_de_Vehiculo = varDetalle_de_Delito_de_Justicia.Circunstancia_de_Robo_de_Vehiculo
                        ,Marca = varDetalle_de_Delito_de_Justicia.Marca
                        ,Sub_Marca = varDetalle_de_Delito_de_Justicia.Sub_Marca
                        ,Tipo_de_vehiculo = varDetalle_de_Delito_de_Justicia.Tipo_de_vehiculo
                        ,Modelo = varDetalle_de_Delito_de_Justicia.Modelo
                        ,Color = varDetalle_de_Delito_de_Justicia.Color
                        ,Placas = varDetalle_de_Delito_de_Justicia.Placas
                        ,Estado_de_Origen_de_las_Placas = varDetalle_de_Delito_de_Justicia.Estado_de_Origen_de_las_Placas
                        ,Motor = varDetalle_de_Delito_de_Justicia.Motor
                        ,Serie = varDetalle_de_Delito_de_Justicia.Serie
                        ,Estado_De_Robo = varDetalle_de_Delito_de_Justicia.Estado_De_Robo
                        ,Municipio_de_Robo = varDetalle_de_Delito_de_Justicia.Municipio_de_Robo
                        ,Colonia_de_Robo = varDetalle_de_Delito_de_Justicia.Colonia_de_Robo
                        ,Codigo_Postal_de_Robo = varDetalle_de_Delito_de_Justicia.Codigo_Postal_de_Robo
                        ,Calle_de_Robo = varDetalle_de_Delito_de_Justicia.Calle_de_Robo
                        ,Entre_Calle_de_Robo = varDetalle_de_Delito_de_Justicia.Entre_Calle_de_Robo
                        ,Y_Calle_de_Robo = varDetalle_de_Delito_de_Justicia.Y_Calle_de_Robo
                        ,Numero_Exterior_de_Robo = varDetalle_de_Delito_de_Justicia.Numero_Exterior_de_Robo
                        ,Numero_Interior_de_Robo = varDetalle_de_Delito_de_Justicia.Numero_Interior_de_Robo
                        ,Referencia_de_Robo = varDetalle_de_Delito_de_Justicia.Referencia_de_Robo
                        ,Latitud_de_Robo = varDetalle_de_Delito_de_Justicia.Latitud_de_Robo
                        ,Longitud_de_Robo = varDetalle_de_Delito_de_Justicia.Longitud_de_Robo
                        ,Lugar_de_Robo = varDetalle_de_Delito_de_Justicia.Lugar_de_Robo
                        ,El_vehiculo_esta_asegurado = varDetalle_de_Delito_de_Justicia.El_vehiculo_esta_asegurado
                        ,Nombre_de_la_Aseguradora = varDetalle_de_Delito_de_Justicia.Nombre_de_la_Aseguradora
                        ,Ruta_del_Servicio_Publico = varDetalle_de_Delito_de_Justicia.Ruta_del_Servicio_Publico
                        ,El_Vehiculo_Transportaba_Mercancia = varDetalle_de_Delito_de_Justicia.El_Vehiculo_Transportaba_Mercancia
                        ,Descripcion_de_lo_que_Transportaba = varDetalle_de_Delito_de_Justicia.Descripcion_de_lo_que_Transportaba
                        ,Monto_de_carga = varDetalle_de_Delito_de_Justicia.Monto_de_carga
                        ,Senas_particulares = varDetalle_de_Delito_de_Justicia.Senas_particulares
                        ,Cuenta_con_GPS = varDetalle_de_Delito_de_Justicia.Cuenta_con_GPS
                        ,Tipo_de_Robo = varDetalle_de_Delito_de_Justicia.Tipo_de_Robo
                        ,Tipo_de_Lugar_del_Robo = varDetalle_de_Delito_de_Justicia.Tipo_de_Lugar_del_Robo
                        ,Tipo_de_Carretera = varDetalle_de_Delito_de_Justicia.Tipo_de_Carretera
                        ,Tipo_de_Servicio = varDetalle_de_Delito_de_Justicia.Tipo_de_Servicio
                        ,Numero_de_Serie = varDetalle_de_Delito_de_Justicia.Numero_de_Serie
                        ,Numero_de_Motor = varDetalle_de_Delito_de_Justicia.Numero_de_Motor
                    
                };

                result = _IDetalle_de_Delito_de_JusticiaApiConsumer.Update_Datos_de_Robo_de_Vehiculo(Detalle_de_Delito_de_Justicia_Datos_de_Robo_de_VehiculoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Datos_de_Robo_de_Vehiculo(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Delito_de_JusticiaApiConsumer.Get_Datos_de_Robo_de_Vehiculo(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Agravantes_del_Delito_MASC;
                var Agravantes_del_Delito_MASCData = GetAgravantes_del_Delito_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Agravantes_del_Delito_MASC);
                int RowCount_Circunstancias_del_Delito_MASC;
                var Circunstancias_del_Delito_MASCData = GetCircunstancias_del_Delito_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Circunstancias_del_Delito_MASC);

                var result = new Detalle_de_Delito_de_Justicia_Datos_de_Robo_de_VehiculoModel
                {
                    Clave = m.Clave
                        ,Fecha_del_Robo = (m.Fecha_del_Robo == null ? string.Empty : Convert.ToDateTime(m.Fecha_del_Robo).ToString(ConfigurationProperty.DateFormat))
			,Hora_del_Robo = m.Hora_del_Robo
                        ,Robo_de = m.Robo_de
                        ,Robo_deDescripcion = CultureHelper.GetTraduction(m.Robo_de_Elemento_Robado.Clave.ToString(), "Descripcion") ?? (string)m.Robo_de_Elemento_Robado.Descripcion
			,Registro_Federal_Vehicular = m.Registro_Federal_Vehicular
			,Numero_de_Registro_Publico_Vehicular = m.Numero_de_Registro_Publico_Vehicular
                        ,Circunstancia_de_Robo_de_Vehiculo = m.Circunstancia_de_Robo_de_Vehiculo
                        ,Circunstancia_de_Robo_de_VehiculoDescripcion = CultureHelper.GetTraduction(m.Circunstancia_de_Robo_de_Vehiculo_Circunstancia_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Circunstancia_de_Robo_de_Vehiculo_Circunstancia_Vehiculo.Descripcion
                        ,Marca = m.Marca
                        ,MarcaDescripcion = CultureHelper.GetTraduction(m.Marca_Marca_del_Vehiculo.Clave.ToString(), "Marca_del_Vehiculo") ?? (string)m.Marca_Marca_del_Vehiculo.Descripcion
                        ,Sub_Marca = m.Sub_Marca
                        ,Sub_MarcaDescripcion = CultureHelper.GetTraduction(m.Sub_Marca_Sub_Marca_del_Vehiculo.Clave.ToString(), "Sub_Marca_del_Vehiculo") ?? (string)m.Sub_Marca_Sub_Marca_del_Vehiculo.Descripcion
                        ,Tipo_de_vehiculo = m.Tipo_de_vehiculo
                        ,Tipo_de_vehiculoDescripcion = CultureHelper.GetTraduction(m.Tipo_de_vehiculo_Tipo_de_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_vehiculo_Tipo_de_Vehiculo.Descripcion
			,Modelo = m.Modelo
                        ,Color = m.Color
                        ,ColorDescripcion = CultureHelper.GetTraduction(m.Color_Color_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Color_Color_Vehiculo.Descripcion
			,Placas = m.Placas
                        ,Estado_de_Origen_de_las_Placas = m.Estado_de_Origen_de_las_Placas
                        ,Estado_de_Origen_de_las_PlacasNombre = CultureHelper.GetTraduction(m.Estado_de_Origen_de_las_Placas_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_de_Origen_de_las_Placas_Estado.Nombre
			,Motor = m.Motor
			,Serie = m.Serie
                        ,Estado_De_Robo = m.Estado_De_Robo
                        ,Estado_De_RoboNombre = CultureHelper.GetTraduction(m.Estado_De_Robo_Estado.Clave.ToString(), "Estado") ?? (string)m.Estado_De_Robo_Estado.Nombre
                        ,Municipio_de_Robo = m.Municipio_de_Robo
                        ,Municipio_de_RoboNombre = CultureHelper.GetTraduction(m.Municipio_de_Robo_Municipio.Clave.ToString(), "Municipio") ?? (string)m.Municipio_de_Robo_Municipio.Nombre
                        ,Colonia_de_Robo = m.Colonia_de_Robo
                        ,Colonia_de_RoboNombre = CultureHelper.GetTraduction(m.Colonia_de_Robo_Colonia.Clave.ToString(), "Colonia") ?? (string)m.Colonia_de_Robo_Colonia.Nombre
			,Codigo_Postal_de_Robo = m.Codigo_Postal_de_Robo
			,Calle_de_Robo = m.Calle_de_Robo
			,Entre_Calle_de_Robo = m.Entre_Calle_de_Robo
			,Y_Calle_de_Robo = m.Y_Calle_de_Robo
			,Numero_Exterior_de_Robo = m.Numero_Exterior_de_Robo
			,Numero_Interior_de_Robo = m.Numero_Interior_de_Robo
			,Referencia_de_Robo = m.Referencia_de_Robo
			,Latitud_de_Robo = m.Latitud_de_Robo
			,Longitud_de_Robo = m.Longitud_de_Robo
                        ,Lugar_de_Robo = m.Lugar_de_Robo
                        ,Lugar_de_RoboDescripcion = CultureHelper.GetTraduction(m.Lugar_de_Robo_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Lugar_de_Robo_Lugar_del_Robo.Descripcion
			,El_vehiculo_esta_asegurado = m.El_vehiculo_esta_asegurado
                        ,Nombre_de_la_Aseguradora = m.Nombre_de_la_Aseguradora
                        ,Nombre_de_la_AseguradoraDescripcion = CultureHelper.GetTraduction(m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Clave.ToString(), "Aseguradora_de_Vehiculo") ?? (string)m.Nombre_de_la_Aseguradora_Aseguradora_de_Vehiculo.Descripcion
			,Ruta_del_Servicio_Publico = m.Ruta_del_Servicio_Publico
			,El_Vehiculo_Transportaba_Mercancia = m.El_Vehiculo_Transportaba_Mercancia
			,Descripcion_de_lo_que_Transportaba = m.Descripcion_de_lo_que_Transportaba
			,Monto_de_carga = m.Monto_de_carga
			,Senas_particulares = m.Senas_particulares
                        ,Cuenta_con_GPS = m.Cuenta_con_GPS
                        ,Cuenta_con_GPSDescripcion = CultureHelper.GetTraduction(m.Cuenta_con_GPS_Binario.Clave.ToString(), "Descripcion") ?? (string)m.Cuenta_con_GPS_Binario.Descripcion
                        ,Tipo_de_Robo = m.Tipo_de_Robo
                        ,Tipo_de_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Robo_Tipo_de_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Robo_Tipo_de_Robo.Descripcion
                        ,Tipo_de_Lugar_del_Robo = m.Tipo_de_Lugar_del_Robo
                        ,Tipo_de_Lugar_del_RoboDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Lugar_del_Robo_Tipo_de_Lugar_del_Robo.Descripcion
                        ,Tipo_de_Carretera = m.Tipo_de_Carretera
                        ,Tipo_de_CarreteraDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Carretera_Tipo_de_Carretera.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Carretera_Tipo_de_Carretera.Descripcion
                        ,Tipo_de_Servicio = m.Tipo_de_Servicio
                        ,Tipo_de_ServicioDescripcion = CultureHelper.GetTraduction(m.Tipo_de_Servicio_Servicio_del_Vehiculo.Clave.ToString(), "Descripcion") ?? (string)m.Tipo_de_Servicio_Servicio_del_Vehiculo.Descripcion
			,Numero_de_Serie = m.Numero_de_Serie
			,Numero_de_Motor = m.Numero_de_Motor

                    
                };
				var resultData = new
                {
                    data = result
                    ,Agravantes_y_o_Calificativas = Agravantes_del_Delito_MASCData
                    ,Circunstancias_Delito = Circunstancias_del_Delito_MASCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }

		[HttpPost]
        public ActionResult Post_Asignar_Dueno(Detalle_de_Delito_de_Justicia_Asignar_DuenoModel varDetalle_de_Delito_de_Justicia)
        {
            try
            {
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);
				
                var result = "";
                var Detalle_de_Delito_de_Justicia_Asignar_DuenoInfo = new Detalle_de_Delito_de_Justicia_Asignar_Dueno
                {
                    Clave = varDetalle_de_Delito_de_Justicia.Clave
                                            ,Persona_Moral = varDetalle_de_Delito_de_Justicia.Persona_Moral
                        ,Nombre_Completo_Persona_Moral = varDetalle_de_Delito_de_Justicia.Nombre_Completo_Persona_Moral
                        ,Persona_Fisica = varDetalle_de_Delito_de_Justicia.Persona_Fisica
                        ,Nombre_Completo_Persona_Fisica = varDetalle_de_Delito_de_Justicia.Nombre_Completo_Persona_Fisica
                        ,Denunciante = varDetalle_de_Delito_de_Justicia.Denunciante
                        ,Nombre_Completo_Denunciante = varDetalle_de_Delito_de_Justicia.Nombre_Completo_Denunciante
                    
                };

                result = _IDetalle_de_Delito_de_JusticiaApiConsumer.Update_Asignar_Dueno(Detalle_de_Delito_de_Justicia_Asignar_DuenoInfo).Resource.ToString();
                Session["KeyValueInserted"] = result;
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (ServiceException ex)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
		
		[HttpGet]
        public JsonResult Get_Asignar_Dueno(string Id)
        {     
            if ((Id.GetType() == typeof(string) && Id.ToString() != "") || ((Id.GetType() == typeof(int) || Id.GetType() == typeof(Int16) || Id.GetType() == typeof(Int32) || Id.GetType() == typeof(Int64) || Id.GetType() == typeof(short)) && Id.ToString() != "0"))
            {                
                if (!_tokenManager.GenerateToken())
                    return Json(null, JsonRequestBehavior.AllowGet);
                _IDetalle_de_Delito_de_JusticiaApiConsumer.SetAuthHeader(_tokenManager.Token);
                var m = _IDetalle_de_Delito_de_JusticiaApiConsumer.Get_Asignar_Dueno(Id).Resource;
                if (m == null)
                    return Json(null, JsonRequestBehavior.AllowGet);
				                int RowCount_Agravantes_del_Delito_MASC;
                var Agravantes_del_Delito_MASCData = GetAgravantes_del_Delito_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Agravantes_del_Delito_MASC);
                int RowCount_Circunstancias_del_Delito_MASC;
                var Circunstancias_del_Delito_MASCData = GetCircunstancias_del_Delito_MASCData(Id.ToString(), 0, Int16.MaxValue, out RowCount_Circunstancias_del_Delito_MASC);

                var result = new Detalle_de_Delito_de_Justicia_Asignar_DuenoModel
                {
                    Clave = m.Clave
			,Persona_Moral = m.Persona_Moral
                        ,Nombre_Completo_Persona_Moral = m.Nombre_Completo_Persona_Moral
                        ,Nombre_Completo_Persona_MoralNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Persona_Moral_Detalle_de_Persona_Moral_JA.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Persona_Moral_Detalle_de_Persona_Moral_JA.Nombre
			,Persona_Fisica = m.Persona_Fisica
                        ,Nombre_Completo_Persona_Fisica = m.Nombre_Completo_Persona_Fisica
                        ,Nombre_Completo_Persona_FisicaNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante.Clave.ToString(), "Detalle_de_Solicitud_Solicitante") ?? (string)m.Nombre_Completo_Persona_Fisica_Detalle_de_Solicitud_Solicitante.Nombre
			,Denunciante = m.Denunciante
                        ,Nombre_Completo_Denunciante = m.Nombre_Completo_Denunciante
                        ,Nombre_Completo_DenuncianteNombre = CultureHelper.GetTraduction(m.Nombre_Completo_Denunciante_Detalle_de_Solicitud_Solicitante.Clave.ToString(), "Nombre") ?? (string)m.Nombre_Completo_Denunciante_Detalle_de_Solicitud_Solicitante.Nombre

                    
                };
				var resultData = new
                {
                    data = result
                    ,Agravantes_y_o_Calificativas = Agravantes_del_Delito_MASCData
                    ,Circunstancias_Delito = Circunstancias_del_Delito_MASCData

                };
                return Json(resultData, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);            
        }


    }
}

